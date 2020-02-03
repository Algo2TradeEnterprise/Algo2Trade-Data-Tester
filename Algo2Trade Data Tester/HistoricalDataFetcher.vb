Imports System.IO
Imports System.Net
Imports System.Threading
Imports Utilities.Strings

Public Class HistoricalDataFetcher
    Implements IDisposable

#Region "Events/Event handlers"
    Public Event DocumentDownloadComplete()
    Public Event DocumentRetryStatus(ByVal currentTry As Integer, ByVal totalTries As Integer)
    Public Event Heartbeat(ByVal msg As String)
    Public Event WaitingFor(ByVal elapsedSecs As Integer, ByVal totalSecs As Integer, ByVal msg As String)
    'The below functions are needed to allow the derived classes to raise the above two events
    Protected Overridable Sub OnDocumentDownloadComplete()
        RaiseEvent DocumentDownloadComplete()
    End Sub
    Protected Overridable Sub OnDocumentRetryStatus(ByVal currentTry As Integer, ByVal totalTries As Integer)
        RaiseEvent DocumentRetryStatus(currentTry, totalTries)
    End Sub
    Protected Overridable Sub OnHeartbeat(ByVal msg As String)
        RaiseEvent Heartbeat(msg)
    End Sub
    Protected Overridable Sub OnWaitingFor(ByVal elapsedSecs As Integer, ByVal totalSecs As Integer, ByVal msg As String)
        RaiseEvent WaitingFor(elapsedSecs, totalSecs, msg)
    End Sub
#End Region

    Private ReadOnly cts As CancellationTokenSource
    Private ReadOnly ZerodhaHistoricalURL = "https://kitecharts-aws.zerodha.com/api/chart/{0}/minute?api_key=kitefront&access_token=K&from={1}&to={2}"
    Private HistoricalDataCollection As Dictionary(Of Date, PairPayload) = Nothing
    Private ReadOnly _database As Boolean
    Private ReadOnly _table As Common.DataBaseTable

    Public Sub New(ByVal canceller As CancellationTokenSource)
        cts = canceller
        _database = My.Settings.Database
        _table = My.Settings.TableIndex + 2
    End Sub

    Private Async Function GetHistoricalCandleStickAsync(ByVal instrumentToken As String, ByVal fromDate As Date, ByVal toDate As Date) As Task(Of Dictionary(Of String, Object))
        Try
            cts.Token.ThrowIfCancellationRequested()
            Dim historicalDataURL As String = String.Format(ZerodhaHistoricalURL, instrumentToken, fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd"))
            OnHeartbeat(String.Format("Fetching historical Data: {0}", historicalDataURL))
            Using sr As New StreamReader(HttpWebRequest.Create(historicalDataURL).GetResponseAsync().Result.GetResponseStream)
                Dim jsonString = Await sr.ReadToEndAsync.ConfigureAwait(False)
                Dim retDictionary As Dictionary(Of String, Object) = StringManipulation.JsonDeserialize(jsonString)
                Return retDictionary
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Async Function ProcessHistoricalData(ByVal instrumentList As Dictionary(Of Integer, String), ByVal fromDate As Date, ByVal toDate As Date) As Task(Of Dictionary(Of Date, PairPayload))
        Try
            If instrumentList IsNot Nothing AndAlso instrumentList.Count > 0 Then
                Dim counter As Integer = 0
                For Each runningInstrument In instrumentList.Keys
                    cts.Token.ThrowIfCancellationRequested()
                    counter += 1
                    If _database Then
                        Dim cmn As Common = New Common(cts)
                        AddHandler cmn.Heartbeat, AddressOf OnHeartbeat

                        Dim candleData As Dictionary(Of Date, Payload) = cmn.GetRawPayloadForSpecificTradingSymbol(_table, instrumentList(runningInstrument), fromDate, toDate)
                        If candleData IsNot Nothing AndAlso candleData.Count > 0 Then
                            GetChartFromDatabase(candleData, counter, instrumentList(runningInstrument))
                        Else
                            Throw New ApplicationException(String.Format("No data found from database for {0}", instrumentList(runningInstrument)))
                        End If
                    Else
                        Dim historicalCandlesJSONDict As Dictionary(Of String, Object) = Await GetHistoricalCandleStickAsync(runningInstrument, fromDate, toDate).ConfigureAwait(False)
                        If historicalCandlesJSONDict IsNot Nothing AndAlso historicalCandlesJSONDict.Count > 0 Then
                            GetChartFromHistorical(historicalCandlesJSONDict, counter, instrumentList(runningInstrument))
                        Else
                            Throw New ApplicationException(String.Format("No data found from live for {0}", instrumentList(runningInstrument)))
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return HistoricalDataCollection
    End Function

    Private Sub GetChartFromHistorical(ByVal historicalCandlesJSONDict As Dictionary(Of String, Object),
                                            ByVal instrumentNumber As Integer,
                                            ByVal tradingSymbol As String)
        If instrumentNumber > 2 Then Exit Sub
        If instrumentNumber < 1 Then Exit Sub

        If historicalCandlesJSONDict.ContainsKey("data") Then
            Dim historicalCandlesDict As Dictionary(Of String, Object) = historicalCandlesJSONDict("data")
            If historicalCandlesDict.ContainsKey("candles") AndAlso historicalCandlesDict("candles").count > 0 Then
                Dim historicalCandles As ArrayList = historicalCandlesDict("candles")
                If HistoricalDataCollection Is Nothing Then HistoricalDataCollection = New Dictionary(Of Date, PairPayload)
                OnHeartbeat(String.Format("Generating Payload for {0}", tradingSymbol))
                For Each historicalCandle In historicalCandles
                    cts.Token.ThrowIfCancellationRequested()
                    Dim runningSnapshotTime As Date = Utilities.Time.GetDateTimeTillMinutes(historicalCandle(0))
                    Dim runningPairPayload As PairPayload = Nothing
                    If HistoricalDataCollection IsNot Nothing AndAlso HistoricalDataCollection.Count > 0 AndAlso
                            HistoricalDataCollection.ContainsKey(runningSnapshotTime) Then
                        runningPairPayload = HistoricalDataCollection(runningSnapshotTime)
                    End If

                    Dim runningPayload As OHLCPayload = New OHLCPayload
                    With runningPayload
                        .SnapshotDateTime = Utilities.Time.GetDateTimeTillMinutes(historicalCandle(0))
                        .TradingSymbol = tradingSymbol
                        .OpenPrice = historicalCandle(1)
                        .HighPrice = historicalCandle(2)
                        .LowPrice = historicalCandle(3)
                        .ClosePrice = historicalCandle(4)
                        .Volume = historicalCandle(5)
                    End With

                    If runningPairPayload Is Nothing Then
                        runningPairPayload = New PairPayload
                        HistoricalDataCollection.Add(runningSnapshotTime, runningPairPayload)
                    End If

                    If instrumentNumber = 1 Then
                        runningPairPayload.Instrument1Payload = runningPayload
                    ElseIf instrumentNumber = 2 Then
                        runningPairPayload.Instrument2Payload = runningPayload
                    Else
                        Throw New NotImplementedException
                    End If

                Next
            End If
        End If
    End Sub

    Private Sub GetChartFromDatabase(ByVal candlesData As Dictionary(Of Date, Payload),
                                            ByVal instrumentNumber As Integer,
                                            ByVal tradingSymbol As String)
        If instrumentNumber > 2 Then Exit Sub
        If instrumentNumber < 1 Then Exit Sub

        If candlesData IsNot Nothing AndAlso candlesData.Count > 0 Then
            If HistoricalDataCollection Is Nothing Then HistoricalDataCollection = New Dictionary(Of Date, PairPayload)
            OnHeartbeat(String.Format("Generating Payload for {0}", tradingSymbol))
            For Each historicalCandle In candlesData
                cts.Token.ThrowIfCancellationRequested()
                Dim runningSnapshotTime As Date = historicalCandle.Value.PayloadDate
                Dim runningPairPayload As PairPayload = Nothing
                If HistoricalDataCollection IsNot Nothing AndAlso HistoricalDataCollection.Count > 0 AndAlso
                        HistoricalDataCollection.ContainsKey(runningSnapshotTime) Then
                    runningPairPayload = HistoricalDataCollection(runningSnapshotTime)
                End If

                Dim runningPayload As OHLCPayload = New OHLCPayload
                With runningPayload
                    .SnapshotDateTime = historicalCandle.Value.PayloadDate
                    .TradingSymbol = tradingSymbol
                    .OpenPrice = historicalCandle.Value.Open
                    .HighPrice = historicalCandle.Value.High
                    .LowPrice = historicalCandle.Value.Low
                    .ClosePrice = historicalCandle.Value.Close
                    .Volume = historicalCandle.Value.Volume
                End With

                If runningPairPayload Is Nothing Then
                    runningPairPayload = New PairPayload
                    HistoricalDataCollection.Add(runningSnapshotTime, runningPairPayload)
                End If

                If instrumentNumber = 1 Then
                    runningPairPayload.Instrument1Payload = runningPayload
                ElseIf instrumentNumber = 2 Then
                    runningPairPayload.Instrument2Payload = runningPayload
                Else
                    Throw New NotImplementedException
                End If

            Next
        End If
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
