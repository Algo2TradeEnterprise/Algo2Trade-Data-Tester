Imports System.IO
Imports System.Threading

Public Class frmMain

#Region "Common Delegates"
    Delegate Sub SetObjectEnableDisable_Delegate(ByVal [obj] As Object, ByVal [value] As Boolean)
    Public Sub SetObjectEnableDisable_ThreadSafe(ByVal [obj] As Object, ByVal [value] As Boolean)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [obj].InvokeRequired Then
            Dim MyDelegate As New SetObjectEnableDisable_Delegate(AddressOf SetObjectEnableDisable_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[obj], [value]})
        Else
            [obj].Enabled = [value]
        End If
    End Sub

    Delegate Sub SetLabelText_Delegate(ByVal [label] As Label, ByVal [text] As String)
    Public Sub SetLabelText_ThreadSafe(ByVal [label] As Label, ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [label].InvokeRequired Then
            Dim MyDelegate As New SetLabelText_Delegate(AddressOf SetLabelText_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[label], [text]})
        Else
            [label].Text = [text]
        End If
    End Sub

    Delegate Function GetLabelText_Delegate(ByVal [label] As Label) As String
    Public Function GetLabelText_ThreadSafe(ByVal [label] As Label) As String
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [label].InvokeRequired Then
            Dim MyDelegate As New GetLabelText_Delegate(AddressOf GetLabelText_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[label]})
        Else
            Return [label].Text
        End If
    End Function

    Delegate Sub SetLabelTag_Delegate(ByVal [label] As Label, ByVal [tag] As String)
    Public Sub SetLabelTag_ThreadSafe(ByVal [label] As Label, ByVal [tag] As String)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [label].InvokeRequired Then
            Dim MyDelegate As New SetLabelTag_Delegate(AddressOf SetLabelTag_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[label], [tag]})
        Else
            [label].Tag = [tag]
        End If
    End Sub

    Delegate Function GetLabelTag_Delegate(ByVal [label] As Label) As String
    Public Function GetLabelTag_ThreadSafe(ByVal [label] As Label) As String
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [label].InvokeRequired Then
            Dim MyDelegate As New GetLabelTag_Delegate(AddressOf GetLabelTag_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[label]})
        Else
            Return [label].Tag
        End If
    End Function
    Delegate Sub SetToolStripLabel_Delegate(ByVal [toolStrip] As StatusStrip, ByVal [label] As ToolStripStatusLabel, ByVal [text] As String)
    Public Sub SetToolStripLabel_ThreadSafe(ByVal [toolStrip] As StatusStrip, ByVal [label] As ToolStripStatusLabel, ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [toolStrip].InvokeRequired Then
            Dim MyDelegate As New SetToolStripLabel_Delegate(AddressOf SetToolStripLabel_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[toolStrip], [label], [text]})
        Else
            [label].Text = [text]
        End If
    End Sub

    Delegate Function GetToolStripLabel_Delegate(ByVal [toolStrip] As StatusStrip, ByVal [label] As ToolStripLabel) As String
    Public Function GetToolStripLabel_ThreadSafe(ByVal [toolStrip] As StatusStrip, ByVal [label] As ToolStripLabel) As String
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [toolStrip].InvokeRequired Then
            Dim MyDelegate As New GetToolStripLabel_Delegate(AddressOf GetToolStripLabel_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[toolStrip], [label]})
        Else
            Return [label].Text
        End If
    End Function

    Delegate Function GetDateTimePickerValue_Delegate(ByVal [dateTimePicker] As DateTimePicker) As Date
    Public Function GetDateTimePickerValue_ThreadSafe(ByVal [dateTimePicker] As DateTimePicker) As Date
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [dateTimePicker].InvokeRequired Then
            Dim MyDelegate As New GetDateTimePickerValue_Delegate(AddressOf GetDateTimePickerValue_ThreadSafe)
            Return Me.Invoke(MyDelegate, New DateTimePicker() {[dateTimePicker]})
        Else
            Return [dateTimePicker].Value
        End If
    End Function

    Delegate Function GetNumericUpDownValue_Delegate(ByVal [numericUpDown] As NumericUpDown) As Integer
    Public Function GetNumericUpDownValue_ThreadSafe(ByVal [numericUpDown] As NumericUpDown) As Integer
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [numericUpDown].InvokeRequired Then
            Dim MyDelegate As New GetNumericUpDownValue_Delegate(AddressOf GetNumericUpDownValue_ThreadSafe)
            Return Me.Invoke(MyDelegate, New NumericUpDown() {[numericUpDown]})
        Else
            Return [numericUpDown].Value
        End If
    End Function

    Delegate Function GetComboBoxIndex_Delegate(ByVal [combobox] As ComboBox) As Integer
    Public Function GetComboBoxIndex_ThreadSafe(ByVal [combobox] As ComboBox) As Integer
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [combobox].InvokeRequired Then
            Dim MyDelegate As New GetComboBoxIndex_Delegate(AddressOf GetComboBoxIndex_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[combobox]})
        Else
            Return [combobox].SelectedIndex
        End If
    End Function

    Delegate Function GetComboBoxItem_Delegate(ByVal [ComboBox] As ComboBox) As String
    Public Function GetComboBoxItem_ThreadSafe(ByVal [ComboBox] As ComboBox) As String
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [ComboBox].InvokeRequired Then
            Dim MyDelegate As New GetComboBoxItem_Delegate(AddressOf GetComboBoxItem_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[ComboBox]})
        Else
            Return [ComboBox].SelectedItem.ToString
        End If
    End Function

    Delegate Function GetTextBoxText_Delegate(ByVal [textBox] As TextBox) As String
    Public Function GetTextBoxText_ThreadSafe(ByVal [textBox] As TextBox) As String
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [textBox].InvokeRequired Then
            Dim MyDelegate As New GetTextBoxText_Delegate(AddressOf GetTextBoxText_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[textBox]})
        Else
            Return [textBox].Text
        End If
    End Function

    Delegate Function GetCheckBoxChecked_Delegate(ByVal [checkBox] As CheckBox) As Boolean
    Public Function GetCheckBoxChecked_ThreadSafe(ByVal [checkBox] As CheckBox) As Boolean
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [checkBox].InvokeRequired Then
            Dim MyDelegate As New GetCheckBoxChecked_Delegate(AddressOf GetCheckBoxChecked_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[checkBox]})
        Else
            Return [checkBox].Checked
        End If
    End Function

    Delegate Sub SetDatagridBindDatatable_Delegate(ByVal [datagrid] As DataGridView, ByVal [table] As DataTable)
    Public Sub SetDatagridBindDatatable_ThreadSafe(ByVal [datagrid] As DataGridView, ByVal [table] As DataTable)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [datagrid].InvokeRequired Then
            Dim MyDelegate As New SetDatagridBindDatatable_Delegate(AddressOf SetDatagridBindDatatable_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[datagrid], [table]})
        Else
            [datagrid].DataSource = [table]
        End If
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub OnHeartbeat(message As String)
        SetLabelText_ThreadSafe(lblProgress, message)
    End Sub
    Private Sub OnDocumentDownloadComplete()
        'OnHeartbeat("Document download compelete")
    End Sub
    Private Sub OnDocumentRetryStatus(currentTry As Integer, totalTries As Integer)
        OnHeartbeat(String.Format("Try #{0}/{1}: Connecting...", currentTry, totalTries))
    End Sub
    Public Sub OnWaitingFor(ByVal elapsedSecs As Integer, ByVal totalSecs As Integer, ByVal msg As String)
        OnHeartbeat(String.Format("{0}, waiting {1}/{2} secs", msg, elapsedSecs, totalSecs))
    End Sub
#End Region

    Private _canceller As CancellationTokenSource

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.FromDate <> Date.MinValue Then dtpckrFromDate.Value = My.Settings.FromDate
        If My.Settings.ToDate <> Date.MinValue Then dtpckrToDate.Value = My.Settings.ToDate
        txtToken1.Text = My.Settings.Token1
        txtSymbol1.Text = My.Settings.Symbol1
        txtToken2.Text = My.Settings.Token2
        txtSymbol2.Text = My.Settings.Symbol2
        txtFilePath.Text = My.Settings.FilePath
        nmrcInstrument1Column.Value = My.Settings.Column1
        nmrcInstrument2Column.Value = My.Settings.Column2
    End Sub

    Private Async Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        SetObjectEnableDisable_ThreadSafe(btnStart, False)
        My.Settings.FromDate = dtpckrFromDate.Value
        My.Settings.ToDate = dtpckrToDate.Value
        My.Settings.Token1 = txtToken1.Text
        My.Settings.Symbol1 = txtSymbol1.Text
        My.Settings.Token2 = txtToken2.Text
        My.Settings.Symbol2 = txtSymbol2.Text
        My.Settings.FilePath = txtFilePath.Text
        My.Settings.Column1 = nmrcInstrument1Column.Value
        My.Settings.Column2 = nmrcInstrument2Column.Value
        My.Settings.Save()
        _canceller = New CancellationTokenSource
        Await Task.Run(AddressOf StartProcessing).ConfigureAwait(False)
    End Sub
    Private Async Function StartProcessing() As Task
        Try
            Dim instrumentList As Dictionary(Of Integer, String) = Nothing
            Dim fromDate As Date = GetDateTimePickerValue_ThreadSafe(dtpckrFromDate)
            Dim toDate As Date = GetDateTimePickerValue_ThreadSafe(dtpckrToDate)
            fromDate = fromDate.Date
            toDate = toDate.Date
            If fromDate > toDate Then
                Throw New ApplicationException("From Date can not be greater than To Date")
            End If
            If (toDate - fromDate).TotalDays > 25 Then
                Throw New ApplicationException("Cannot fetch data more than 25 days")
            End If

            Dim token1 As String = GetTextBoxText_ThreadSafe(txtToken1)
            Dim symbol1 As String = GetTextBoxText_ThreadSafe(txtSymbol1)
            Dim column1 As Integer = GetNumericUpDownValue_ThreadSafe(nmrcInstrument1Column)
            Dim token2 As String = GetTextBoxText_ThreadSafe(txtToken2)
            Dim symbol2 As String = GetTextBoxText_ThreadSafe(txtSymbol2)
            Dim column2 As Integer = GetNumericUpDownValue_ThreadSafe(nmrcInstrument2Column)

            If token1 IsNot Nothing AndAlso token1.Trim <> "" AndAlso
                symbol1 IsNot Nothing AndAlso symbol1.Trim <> "" Then
                If instrumentList Is Nothing Then instrumentList = New Dictionary(Of Integer, String)
                instrumentList.Add(Val(token1), symbol1)
            End If
            If token2 IsNot Nothing AndAlso token2.Trim <> "" AndAlso
                symbol2 IsNot Nothing AndAlso symbol2.Trim <> "" Then
                If instrumentList Is Nothing Then instrumentList = New Dictionary(Of Integer, String)
                instrumentList.Add(Val(token2), symbol2)
            End If

            Dim historicalData As Dictionary(Of Date, PairPayload) = Nothing
            Using dataFetcher As New HistoricalDataFetcher(_canceller)
                AddHandler dataFetcher.Heartbeat, AddressOf OnHeartbeat
                AddHandler dataFetcher.WaitingFor, AddressOf OnWaitingFor
                AddHandler dataFetcher.DocumentRetryStatus, AddressOf OnDocumentRetryStatus
                AddHandler dataFetcher.DocumentDownloadComplete, AddressOf OnDocumentDownloadComplete
                historicalData = Await dataFetcher.ProcessHistoricalData(instrumentList, fromDate, toDate).ConfigureAwait(False)
            End Using
            OnHeartbeat("Payload generation complete")

            Dim templateFile As String = GetTextBoxText_ThreadSafe(txtFilePath)
            Dim outputFilename As String = Path.Combine(Path.GetDirectoryName(templateFile), String.Format("{0} {1}_{2}_{3}_{4}_{5}_{6}.xlsx",
                                                                                                           Path.GetFileNameWithoutExtension(templateFile),
                                                                                                           Now.Year, Now.Month, Now.Day,
                                                                                                           Now.Hour, Now.Minute, Now.Second))
            OnHeartbeat("File Copy in progress")
            File.Copy(templateFile, outputFilename)
            OnHeartbeat("Writting Excel")
            Await WriteToExcel(outputFilename, historicalData).ConfigureAwait(False)
        Catch cex As OperationCanceledException
            MsgBox(cex.Message)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        _canceller.Cancel()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog.ShowDialog()
    End Sub

    Private Sub OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
        txtFilePath.Text = OpenFileDialog.FileName
    End Sub

    Private Async Function WriteToExcel(ByVal outputFileName As String, ByVal dataToWrite As Dictionary(Of Date, PairPayload)) As Task
        Await Task.Delay(0, _canceller.Token).ConfigureAwait(False)
        Using excelWriter As New Utilities.DAL.ExcelHelper(outputFileName, Utilities.DAL.ExcelHelper.ExcelOpenStatus.OpenExistingForReadWrite, Utilities.DAL.ExcelHelper.ExcelSaveType.XLS_XLSX, _canceller)
            AddHandler excelWriter.Heartbeat, AddressOf OnHeartbeat
            AddHandler excelWriter.WaitingFor, AddressOf OnWaitingFor

            Dim instrument1StartingColumn As Integer = GetNumericUpDownValue_ThreadSafe(nmrcInstrument1Column) - 1
            Dim instrument2StartingColumn As Integer = GetNumericUpDownValue_ThreadSafe(nmrcInstrument2Column) - 1
            Dim rowCounter As Integer = 0
            Dim columnCounter As Integer = 0

            If dataToWrite IsNot Nothing AndAlso dataToWrite.Count > 0 Then
                Dim mainRawData(dataToWrite.Count - 1, 13) As Object
                Dim dateCtr As Integer = 0
                Dim lastInstrument1Data As OHLCPayload = Nothing
                Dim lastInstrument2Data As OHLCPayload = Nothing
                For Each runningData In dataToWrite
                    dateCtr += 1
                    OnHeartbeat(String.Format("Excel printing for Date: {0} [{1} of {2}]", runningData.Key.Date.ToShortDateString, dateCtr, dataToWrite.Count))

                    If runningData.Value.Instrument1Payload IsNot Nothing Then
                        columnCounter = instrument1StartingColumn
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.TradingSymbol
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.SnapshotDateTime
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.OpenPrice
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.LowPrice
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.HighPrice
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.ClosePrice
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.Volume

                        lastInstrument1Data = runningData.Value.Instrument1Payload
                    Else
                        columnCounter = instrument1StartingColumn
                        mainRawData(rowCounter, columnCounter) = lastInstrument1Data.TradingSymbol
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Key
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = ""
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = ""
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = ""
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = ""
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = ""
                    End If

                    If runningData.Value.Instrument2Payload IsNot Nothing Then
                        columnCounter = instrument2StartingColumn
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.TradingSymbol
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.SnapshotDateTime
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.OpenPrice
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.LowPrice
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.HighPrice
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.ClosePrice
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.Volume

                        lastInstrument2Data = runningData.Value.Instrument2Payload
                    Else
                        columnCounter = instrument2StartingColumn
                        mainRawData(rowCounter, columnCounter) = lastInstrument2Data.TradingSymbol
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Key
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = ""
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = ""
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = ""
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = ""
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = ""
                    End If
                    rowCounter += 1
                Next

                Dim range As String = excelWriter.GetNamedRange(2, rowCounter - 1, 1, 13)
                excelWriter.WriteArrayToExcel(mainRawData, range)
                Erase mainRawData
                mainRawData = Nothing
            End If
            excelWriter.SaveExcel()
        End Using
        OnHeartbeat("Process Complete")
        SetObjectEnableDisable_ThreadSafe(btnStart, True)
    End Function
End Class
