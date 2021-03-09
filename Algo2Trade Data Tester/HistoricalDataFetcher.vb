Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Threading
Imports Utilities.Network
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
    Private ReadOnly ZerodhaHistoricalMinuteURL = "https://kite.zerodha.com/oms/instruments/historical/{0}/minute?oi=1&from={1}&to={2}"
    Private ReadOnly ZerodhaHistoricalDayURL = "https://kite.zerodha.com/oms/instruments/historical/{0}/day?&oi=1&from={1}&to={2}"

    Private HistoricalDataCollection As Dictionary(Of Date, PairPayload) = Nothing

    Private ReadOnly _database As Boolean

    Public Sub New(ByVal canceller As CancellationTokenSource, ByVal fetchFromDB As Boolean)
        cts = canceller
        _database = fetchFromDB
    End Sub

    Private Async Function GetHistoricalMinuteCandleStickAsync(ByVal instrumentToken As String, ByVal fromDate As Date, ByVal toDate As Date) As Task(Of Dictionary(Of String, Object))
        Dim ret As Dictionary(Of String, Object) = Nothing
        Try
            cts.Token.ThrowIfCancellationRequested()
            Dim historicalDataURL As String = String.Format(ZerodhaHistoricalMinuteURL, instrumentToken, fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd"))
            OnHeartbeat(String.Format("Fetching historical Data: {0}", historicalDataURL))
            ServicePointManager.Expect100Continue = False
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            ServicePointManager.ServerCertificateValidationCallback = Function(s, Ca, CaC, sslPE)
                                                                          Return True
                                                                      End Function
            Using browser As New HttpBrowser(Nothing, Net.DecompressionMethods.GZip Or DecompressionMethods.Deflate Or DecompressionMethods.None, New TimeSpan(0, 1, 0), cts)
                Dim headers As New Dictionary(Of String, String)
                headers.Add("Host", "kite.zerodha.com")
                headers.Add("Accept", "*/*")
                headers.Add("Accept-Encoding", "gzip, deflate")
                headers.Add("Accept-Language", "en-US,en;q=0.9,hi;q=0.8,ko;q=0.7")
                headers.Add("Authorization", String.Format("enctoken {0}", "ubaJJytV6qh4YflnoqM9+sWJvFnVd5UDIrJrn84X05JGZjc42+8AxTpLQ8yYH5vghHPjjZ/QePu0q1QbCm1FgMjuhOKQeA=="))
                headers.Add("Referer", "https://kite.zerodha.com/static/build/chart.html?v=2.4.0")
                headers.Add("sec-fetch-mode", "cors")
                headers.Add("sec-fetch-site", "same-origin")
                headers.Add("Connection", "keep-alive")

                cts.Token.ThrowIfCancellationRequested()
                Dim l As Tuple(Of Uri, Object) = Await browser.NonPOSTRequestAsync(historicalDataURL,
                                                                                        HttpMethod.Get,
                                                                                        Nothing,
                                                                                        False,
                                                                                        headers,
                                                                                        True,
                                                                                        "application/json").ConfigureAwait(False)
                cts.Token.ThrowIfCancellationRequested()
                If l IsNot Nothing AndAlso l.Item2 IsNot Nothing Then
                    ret = l.Item2
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return ret
    End Function

    Private Async Function GetHistoricalDayCandleStickAsync(ByVal instrumentToken As String, ByVal fromDate As Date, ByVal toDate As Date) As Task(Of Dictionary(Of String, Object))
        Dim ret As Dictionary(Of String, Object) = Nothing
        Try
            cts.Token.ThrowIfCancellationRequested()
            Dim historicalDataURL As String = String.Format(ZerodhaHistoricalDayURL, instrumentToken, fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd"))
            OnHeartbeat(String.Format("Fetching historical Data: {0}", historicalDataURL))
            ServicePointManager.Expect100Continue = False
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            ServicePointManager.ServerCertificateValidationCallback = Function(s, Ca, CaC, sslPE)
                                                                          Return True
                                                                      End Function
            Using browser As New HttpBrowser(Nothing, Net.DecompressionMethods.GZip Or DecompressionMethods.Deflate Or DecompressionMethods.None, New TimeSpan(0, 1, 0), cts)
                Dim headers As New Dictionary(Of String, String)
                headers.Add("Host", "kite.zerodha.com")
                headers.Add("Accept", "*/*")
                headers.Add("Accept-Encoding", "gzip, deflate")
                headers.Add("Accept-Language", "en-US,en;q=0.9,hi;q=0.8,ko;q=0.7")
                headers.Add("Authorization", String.Format("enctoken {0}", "ubaJJytV6qh4YflnoqM9+sWJvFnVd5UDIrJrn84X05JGZjc42+8AxTpLQ8yYH5vghHPjjZ/QePu0q1QbCm1FgMjuhOKQeA=="))
                headers.Add("Referer", "https://kite.zerodha.com/static/build/chart.html?v=2.4.0")
                headers.Add("sec-fetch-mode", "cors")
                headers.Add("sec-fetch-site", "same-origin")
                headers.Add("Connection", "keep-alive")

                cts.Token.ThrowIfCancellationRequested()
                Dim l As Tuple(Of Uri, Object) = Await browser.NonPOSTRequestAsync(historicalDataURL,
                                                                                        HttpMethod.Get,
                                                                                        Nothing,
                                                                                        False,
                                                                                        headers,
                                                                                        True,
                                                                                        "application/json").ConfigureAwait(False)
                cts.Token.ThrowIfCancellationRequested()
                If l IsNot Nothing AndAlso l.Item2 IsNot Nothing Then
                    ret = l.Item2
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return ret
    End Function

    Public Async Function GetInstrumentsData(ByVal instrumentsDetails As PairSymbolDetails, ByVal fromDate As Date, ByVal toDate As Date) As Task(Of Dictionary(Of Date, PairPayload))
        Try
            If instrumentsDetails IsNot Nothing Then
                For i As Integer = 1 To 2
                    cts.Token.ThrowIfCancellationRequested()
                    If i = 1 Then
                        Await ProcessData(instrumentsDetails.Instrument1Table, instrumentsDetails.Instrument1AutoSelectTradingSymbol, instrumentsDetails.TimeFrame, instrumentsDetails.ExchangeStartTime, instrumentsDetails.Instrument1Name, instrumentsDetails.Instrument1Token, fromDate, toDate, i).ConfigureAwait(False)
                    ElseIf i = 2 Then
                        Await ProcessData(instrumentsDetails.Instrument2Table, instrumentsDetails.Instrument2AutoSelectTradingSymbol, instrumentsDetails.TimeFrame, instrumentsDetails.ExchangeStartTime, instrumentsDetails.Instrument2Name, instrumentsDetails.Instrument2Token, fromDate, toDate, i).ConfigureAwait(False)
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return HistoricalDataCollection
    End Function

    Private Async Function ProcessData(ByVal tableIndex As Integer, ByVal autoSelectTradingSymbol As Boolean,
                                    ByVal timeframe As String, ByVal exchangeStartTime As Date,
                                    ByVal instrumentName As String, ByVal token As String,
                                    ByVal fromDate As Date, ByVal toDate As Date, ByVal instrumentNumber As Integer) As Task
        Dim candleData As Dictionary(Of Date, Payload) = Nothing
        If _database Then
            Dim cmn As Common = New Common(cts)
            AddHandler cmn.Heartbeat, AddressOf OnHeartbeat

            Dim table As Common.DataBaseTable = Common.DataBaseTable.None
            Select Case tableIndex
                Case 0
                    If timeframe.Contains("Min") OrElse timeframe.Contains("Hour") Then
                        table = Common.DataBaseTable.Intraday_Cash
                    ElseIf timeframe.Contains("Day") OrElse timeframe.Contains("Week") OrElse timeframe.Contains("Month") Then
                        table = Common.DataBaseTable.EOD_Cash
                    End If
                Case 1
                    If timeframe.Contains("Min") OrElse timeframe.Contains("Hour") Then
                        table = Common.DataBaseTable.Intraday_Futures
                    ElseIf timeframe.Contains("Day") OrElse timeframe.Contains("Week") OrElse timeframe.Contains("Month") Then
                        table = Common.DataBaseTable.EOD_Futures
                    End If
                Case 2
                    If timeframe.Contains("Min") OrElse timeframe.Contains("Hour") Then
                        table = Common.DataBaseTable.Intraday_Commodity
                    ElseIf timeframe.Contains("Day") OrElse timeframe.Contains("Week") OrElse timeframe.Contains("Month") Then
                        table = Common.DataBaseTable.EOD_Commodity
                    End If
                Case 3
                    If timeframe.Contains("Min") OrElse timeframe.Contains("Hour") Then
                        table = Common.DataBaseTable.Intraday_Currency
                    ElseIf timeframe.Contains("Day") OrElse timeframe.Contains("Week") OrElse timeframe.Contains("Month") Then
                        table = Common.DataBaseTable.EOD_Currency
                    End If
                Case 4
                    If timeframe.Contains("Min") OrElse timeframe.Contains("Hour") Then
                        table = Common.DataBaseTable.Intraday_Futures_Option
                    ElseIf timeframe.Contains("Day") OrElse timeframe.Contains("Week") OrElse timeframe.Contains("Month") Then
                        table = Common.DataBaseTable.EOD_Futures_Option
                    End If
            End Select

            If autoSelectTradingSymbol Then
                Dim startDate As Date = fromDate
                While startDate.Date <= toDate.Date
                    'Dim tradingSymbol As String = Nothing
                    'If instrumentNumber = 1 Then
                    '    tradingSymbol = cmn.GetCurrentTradingSymbol(table, startDate, instrumentName)
                    'ElseIf instrumentNumber = 2 Then
                    '    tradingSymbol = cmn.GetNextTradingSymbol(table, startDate, instrumentName)
                    'End If
                    'Dim requiredData As Dictionary(Of Date, Payload) = Nothing
                    'If tradingSymbol IsNot Nothing Then
                    '    requiredData = cmn.GetRawPayloadForSpecificTradingSymbol(table, tradingSymbol, startDate, startDate)
                    'End If
                    Dim requiredData As Dictionary(Of Date, Payload) = cmn.GetRawPayload(table, instrumentName, startDate, startDate)
                    If requiredData IsNot Nothing AndAlso requiredData.Count > 0 Then
                        For Each runningData In requiredData
                            If candleData Is Nothing Then candleData = New Dictionary(Of Date, Payload)
                            candleData.Add(runningData.Key, runningData.Value)
                        Next
                    End If
                    startDate = startDate.Date.AddDays(1)
                End While
            Else
                candleData = cmn.GetRawPayloadForSpecificTradingSymbol(table, instrumentName, fromDate, toDate)
            End If

        Else
            Dim historicalCandlesJSONDict As Dictionary(Of String, Object) = Nothing
            If timeframe.Contains("Min") OrElse timeframe.Contains("Hour") Then
                historicalCandlesJSONDict = Await GetHistoricalMinuteCandleStickAsync(token, fromDate, toDate).ConfigureAwait(False)
            ElseIf timeframe.Contains("Day") OrElse timeframe.Contains("Week") OrElse timeframe.Contains("Month") Then
                historicalCandlesJSONDict = Await GetHistoricalDayCandleStickAsync(token, fromDate, toDate).ConfigureAwait(False)
            End If
            candleData = GetPayloadFromHistorical(historicalCandlesJSONDict, instrumentName)
        End If

        If candleData IsNot Nothing AndAlso candleData.Count > 0 Then
            Dim xMinuteData As Dictionary(Of Date, Payload) = Nothing
            If Not timeframe.Contains("1 Min") AndAlso Not timeframe.Contains("1 Day") Then
                Dim signalTimeframe As Integer = Val(timeframe.Split(" ")(0))
                If timeframe.Contains("Min") Then
                    xMinuteData = Common.ConvertPayloadsToXMinutes(candleData, signalTimeframe, exchangeStartTime)
                ElseIf timeframe.Contains("Week") Then
                    xMinuteData = Common.ConvertDayPayloadsToWeek(candleData)
                ElseIf timeframe.Contains("Month") Then
                    xMinuteData = Common.ConvertDayPayloadsToMonth(candleData)
                End If
            Else
                xMinuteData = candleData
            End If

            GeneratePairPayload(xMinuteData, instrumentNumber, instrumentName)
        Else
            Throw New ApplicationException(String.Format("No data found for {0}", instrumentName))
        End If
    End Function

    Private Function GetPayloadFromHistorical(ByVal historicalCandlesJSONDict As Dictionary(Of String, Object), ByVal tradingSymbol As String) As Dictionary(Of Date, Payload)
        Dim ret As Dictionary(Of Date, Payload) = Nothing
        If historicalCandlesJSONDict.ContainsKey("data") Then
            Dim historicalCandlesDict As Dictionary(Of String, Object) = historicalCandlesJSONDict("data")
            If historicalCandlesDict.ContainsKey("candles") AndAlso historicalCandlesDict("candles").count > 0 Then
                Dim historicalCandles As ArrayList = historicalCandlesDict("candles")
                OnHeartbeat(String.Format("Generating Payload for {0}", tradingSymbol))
                For Each historicalCandle In historicalCandles
                    cts.Token.ThrowIfCancellationRequested()
                    Dim runningSnapshotTime As Date = Utilities.Time.GetDateTimeTillMinutes(historicalCandle(0))

                    Dim runningPayload As Payload = New Payload(Payload.CandleDataSource.Chart)
                    With runningPayload
                        .PayloadDate = runningSnapshotTime
                        .TradingSymbol = tradingSymbol
                        .Open = historicalCandle(1)
                        .High = historicalCandle(2)
                        .Low = historicalCandle(3)
                        .Close = historicalCandle(4)
                        .Volume = historicalCandle(5)
                    End With

                    If ret Is Nothing Then ret = New Dictionary(Of Date, Payload)
                    ret.Add(runningSnapshotTime, runningPayload)
                Next
            End If
        End If
        Return ret
    End Function

    Private Sub GeneratePairPayload(ByVal candlesData As Dictionary(Of Date, Payload),
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

                Dim runningPayload As Payload = New Payload(Payload.CandleDataSource.Chart)
                With runningPayload
                    .PayloadDate = historicalCandle.Value.PayloadDate
                    .TradingSymbol = historicalCandle.Value.TradingSymbol
                    .Open = historicalCandle.Value.Open
                    .High = historicalCandle.Value.High
                    .Low = historicalCandle.Value.Low
                    .Close = historicalCandle.Value.Close
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
