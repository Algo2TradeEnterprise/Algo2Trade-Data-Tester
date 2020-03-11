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

    Delegate Function GetRadioButtonChecked_Delegate(ByVal [radiobutton] As RadioButton) As Boolean
    Public Function GetRadioButtonChecked_ThreadSafe(ByVal [radiobutton] As RadioButton) As Boolean
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [radiobutton].InvokeRequired Then
            Dim MyDelegate As New GetRadioButtonChecked_Delegate(AddressOf GetRadioButtonChecked_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[radiobutton]})
        Else
            Return [radiobutton].Checked
        End If
    End Function
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
    Private _symbolList As Dictionary(Of String, PairSymbolDetails)
    Private _fileName As String = Path.Combine(My.Application.Info.DirectoryPath, "Symbol List.a2t")

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetObjectEnableDisable_ThreadSafe(btnStop, False)
        Me.Text = String.Format("Algo2Trade Data Tester v{0}", My.Application.Info.Version)

        If File.Exists(_fileName) Then _symbolList = Utilities.Strings.DeserializeToCollection(Of Dictionary(Of String, PairSymbolDetails))(_fileName)

        If _symbolList Is Nothing Then _symbolList = New Dictionary(Of String, PairSymbolDetails)
        If _symbolList.Count > 0 Then
            For Each symbol In _symbolList.Keys
                cmbSymbol.Items.Add(symbol)
            Next
            cmbSymbol.SelectedIndex = My.Settings.ComboBoxIndex
        End If
        rdbLive.Checked = My.Settings.Live
        rdbDatabase.Checked = My.Settings.Database
    End Sub

    Private Async Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        _canceller = New CancellationTokenSource

        SetObjectEnableDisable_ThreadSafe(btnStart, False)
        SetObjectEnableDisable_ThreadSafe(btnStop, True)

        Dim symbolDetails As PairSymbolDetails = New PairSymbolDetails With {
            .Instrument1AutoSelectTradingSymbol = chkbAutoSelectTradingSymbol1.Checked,
            .Instrument1Table = cmbTable1.SelectedIndex,
            .Instrument1Name = txtSymbol1.Text.Trim.ToUpper,
            .Instrument1Token = txtToken1.Text.Trim,
            .Instrument1StartingColumn = nmrcInstrument1Column.Value,
            .Instrument1LotSize = nmrcInstrument1LotSize.Value,
            .Instrument1NumberOfLots = nmrcInstrument1NumberOfLots.Value,
            .Instrument1Brokerage = txtInstrument1Brokerage.Text,
            .Instrument2AutoSelectTradingSymbol = chkbAutoSelectTradingSymbol2.Checked,
            .Instrument2Table = cmbTable2.SelectedIndex,
            .Instrument2Name = txtSymbol2.Text.Trim.ToUpper,
            .Instrument2Token = txtToken2.Text.Trim,
            .Instrument2StartingColumn = nmrcInstrument2Column.Value,
            .Instrument2LotSize = nmrcInstrument2LotSize.Value,
            .Instrument2NumberOfLots = nmrcInstrument2NumberOfLots.Value,
            .Instrument2Brokerage = txtInstrument2Brokerage.Text,
            .FromDate = dtpckrFromDate.Value,
            .ToDate = dtpckrToDate.Value,
            .TemplateFilePath = txtFilePath.Text,
            .TimeFrame = cmbTimeframe.SelectedItem,
            .ExchangeStartTime = dtPckrExchangeTime.Value
        }

        Dim combineInstrumentName As String = String.Format("{0}_{1}", symbolDetails.Instrument1Name, symbolDetails.Instrument2Name)
        If _symbolList.ContainsKey(combineInstrumentName) Then
            _symbolList(combineInstrumentName) = symbolDetails
        Else
            _symbolList.Add(combineInstrumentName, symbolDetails)
            cmbSymbol.Items.Add(combineInstrumentName)
        End If
        cmbSymbol.SelectedItem = combineInstrumentName

        My.Settings.ComboBoxIndex = GetComboBoxIndex_ThreadSafe(cmbSymbol)
        My.Settings.Live = rdbLive.Checked
        My.Settings.Database = rdbDatabase.Checked
        My.Settings.Save()

        Utilities.Strings.SerializeFromCollection(Of Dictionary(Of String, PairSymbolDetails))(_fileName, _symbolList)

        Await Task.Run(AddressOf StartProcessing).ConfigureAwait(False)
    End Sub
    Private Async Function StartProcessing() As Task
        Try
            Dim fromDate As Date = GetDateTimePickerValue_ThreadSafe(dtpckrFromDate)
            Dim toDate As Date = GetDateTimePickerValue_ThreadSafe(dtpckrToDate)
            fromDate = fromDate.Date
            toDate = toDate.Date
            If fromDate > toDate Then
                Throw New ApplicationException("From Date can not be greater than To Date")
            End If

            Dim token1 As String = GetTextBoxText_ThreadSafe(txtToken1)
            Dim symbol1 As String = GetTextBoxText_ThreadSafe(txtSymbol1).ToUpper
            Dim token2 As String = GetTextBoxText_ThreadSafe(txtToken2)
            Dim symbol2 As String = GetTextBoxText_ThreadSafe(txtSymbol2).ToUpper
            Dim timeFrame As Integer = GetComboBoxIndex_ThreadSafe(cmbTimeframe)

            If Not (token1 IsNot Nothing AndAlso token1.Trim <> "" AndAlso
                symbol1 IsNot Nothing AndAlso symbol1.Trim <> "") Then
                Throw New ApplicationException("Instrument 1 details cannot be blank")
            End If

            If Not (token2 IsNot Nothing AndAlso token2.Trim <> "" AndAlso
                symbol2 IsNot Nothing AndAlso symbol2.Trim <> "") Then
                symbol2 = Nothing
            End If

            Dim symbolDetails As PairSymbolDetails = _symbolList(GetComboBoxItem_ThreadSafe(cmbSymbol))

            Dim pairData As Dictionary(Of Date, PairPayload) = Nothing
            Using dataFetcher As New HistoricalDataFetcher(_canceller, GetRadioButtonChecked_ThreadSafe(rdbDatabase))
                AddHandler dataFetcher.Heartbeat, AddressOf OnHeartbeat
                AddHandler dataFetcher.WaitingFor, AddressOf OnWaitingFor
                AddHandler dataFetcher.DocumentRetryStatus, AddressOf OnDocumentRetryStatus
                AddHandler dataFetcher.DocumentDownloadComplete, AddressOf OnDocumentDownloadComplete
                pairData = Await dataFetcher.GetInstrumentsData(symbolDetails, fromDate, toDate).ConfigureAwait(False)
            End Using
            OnHeartbeat("Payload generation complete")

            Dim templateFile As String = GetTextBoxText_ThreadSafe(txtFilePath)
            Dim combinationOfSymbolName As String = String.Format("{0}{1}{2}", symbol1, If(symbol2 IsNot Nothing, "_", ""), If(symbol2 IsNot Nothing, symbol2, ""))
            Dim combinationOfDates As String = String.Format("{0}{1}{2}", fromDate.ToString("dd-MM-yy"), If(fromDate <> toDate, " to ", ""), If(fromDate <> toDate, toDate.ToString("dd-MM-yy"), ""))
            Dim outputFilename As String = Path.Combine(Path.GetDirectoryName(templateFile), String.Format("{0} {1} {2}_{3}_{4}.xlsx",
                                                                                                           combinationOfSymbolName.Trim,
                                                                                                           combinationOfDates.Trim,
                                                                                                           Now.Hour, Now.Minute, Now.Second))
            If outputFilename.Length > 250 Then
                OnHeartbeat("Modifying output filename")
                outputFilename = outputFilename.Substring(0, 250)
                outputFilename = String.Format("{0}.xlsx", outputFilename)
            End If

            OnHeartbeat("File Copy in progress")
            File.Copy(templateFile, outputFilename)

            Await WriteToExcel(outputFilename, pairData).ConfigureAwait(False)
            OnHeartbeat("Process Complete")

            If MessageBox.Show("Do you want to open file?", "Algo2Trade Data Tester", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Process.Start(outputFilename)
            End If
        Catch cex As OperationCanceledException
            MsgBox(cex.Message)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SetObjectEnableDisable_ThreadSafe(btnStart, True)
            SetObjectEnableDisable_ThreadSafe(btnStop, False)
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
        OnHeartbeat("Opening Excel")
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
                Dim lastInstrument1Data As Payload = Nothing
                Dim lastInstrument2Data As Payload = Nothing
                For Each runningData In dataToWrite.OrderBy(Function(x)
                                                                Return x.Key
                                                            End Function)
                    dateCtr += 1
                    OnHeartbeat(String.Format("Excel printing for Date: {0} [{1} of {2}]", runningData.Key.Date.ToShortDateString, dateCtr, dataToWrite.Count))

                    If runningData.Value.Instrument1Payload IsNot Nothing Then
                        columnCounter = instrument1StartingColumn
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.PayloadDate.ToString("dd-MM-yyyy HH:mm:ss")
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.TradingSymbol
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.Open
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.Low
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.High
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.Close
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument1Payload.Volume

                        lastInstrument1Data = runningData.Value.Instrument1Payload
                    Else
                        columnCounter = instrument1StartingColumn
                        mainRawData(rowCounter, columnCounter) = runningData.Key.ToString("dd-MM-yyyy HH:mm:ss")
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = lastInstrument1Data.TradingSymbol
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
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.PayloadDate.ToString("dd-MM-yyyy HH:mm:ss")
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.TradingSymbol
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.Open
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.Low
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.High
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.Close
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = runningData.Value.Instrument2Payload.Volume

                        lastInstrument2Data = runningData.Value.Instrument2Payload
                    Else
                        columnCounter = instrument2StartingColumn
                        mainRawData(rowCounter, columnCounter) = runningData.Key.ToString("dd-MM-yyyy HH:mm:ss")
                        columnCounter += 1
                        mainRawData(rowCounter, columnCounter) = lastInstrument2Data.TradingSymbol
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

                'After Processing
                Try
                    excelWriter.CreateNewSheet("Settings")
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    'Ignore this error as 'Settings' sheet may be available
                End Try
                excelWriter.SetActiveSheet("Settings")
                excelWriter.SetData(1, 2, "Instrument 1")
                excelWriter.SetData(1, 3, "Instrument 2")
                excelWriter.SetData(2, 1, "Lot Size")
                excelWriter.SetData(2, 2, GetNumericUpDownValue_ThreadSafe(nmrcInstrument1LotSize))
                excelWriter.SetData(2, 3, GetNumericUpDownValue_ThreadSafe(nmrcInstrument2LotSize))
                excelWriter.SetData(3, 1, "Number Of Lots")
                excelWriter.SetData(3, 2, GetNumericUpDownValue_ThreadSafe(nmrcInstrument1NumberOfLots))
                excelWriter.SetData(3, 3, GetNumericUpDownValue_ThreadSafe(nmrcInstrument2NumberOfLots))
                excelWriter.SetData(4, 1, "Brokerage")
                excelWriter.SetData(4, 2, GetTextBoxText_ThreadSafe(txtInstrument1Brokerage))
                excelWriter.SetData(4, 3, GetTextBoxText_ThreadSafe(txtInstrument2Brokerage))
            End If
            excelWriter.SaveExcel()
        End Using
    End Function

    Private Sub cmbSymbol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSymbol.SelectedIndexChanged
        Dim symbol As String = GetComboBoxItem_ThreadSafe(cmbSymbol)
        If _symbolList IsNot Nothing AndAlso _symbolList.Count > 0 AndAlso _symbolList.ContainsKey(symbol) Then
            LoadSettings(_symbolList(symbol))
        End If
    End Sub

    Private Sub LoadSettings(ByVal data As PairSymbolDetails)
        chkbAutoSelectTradingSymbol1.Checked = data.Instrument1AutoSelectTradingSymbol
        cmbTable1.SelectedIndex = data.Instrument1Table
        txtToken1.Text = data.Instrument1Token
        txtSymbol1.Text = data.Instrument1Name
        nmrcInstrument1Column.Value = data.Instrument1StartingColumn
        nmrcInstrument1LotSize.Value = data.Instrument1LotSize
        nmrcInstrument1NumberOfLots.Value = data.Instrument1NumberOfLots
        txtInstrument1Brokerage.Text = data.Instrument1Brokerage

        chkbAutoSelectTradingSymbol2.Checked = data.Instrument2AutoSelectTradingSymbol
        cmbTable2.SelectedIndex = data.Instrument2Table
        txtToken2.Text = data.Instrument2Token
        txtSymbol2.Text = data.Instrument2Name
        nmrcInstrument2Column.Value = data.Instrument2StartingColumn
        nmrcInstrument2LotSize.Value = data.Instrument2LotSize
        nmrcInstrument2NumberOfLots.Value = data.Instrument2NumberOfLots
        txtInstrument2Brokerage.Text = data.Instrument2Brokerage

        txtFilePath.Text = data.TemplateFilePath
        dtpckrFromDate.Value = data.FromDate.Date
        dtpckrToDate.Value = data.ToDate.Date
        cmbTimeframe.SelectedItem = data.TimeFrame
        If data.ExchangeStartTime <> Date.MinValue Then
            dtPckrExchangeTime.Value = data.ExchangeStartTime
        Else
            dtPckrExchangeTime.Value = New Date(Now.Year, Now.Month, Now.Day, 9, 15, 0)
        End If
    End Sub

    Private Sub rdbLive_CheckedChanged(sender As Object, e As EventArgs) Handles rdbLive.CheckedChanged
        cmbTable1.Enabled = False
        cmbTable2.Enabled = False

        chkbAutoSelectTradingSymbol1.Checked = False
        chkbAutoSelectTradingSymbol1.Enabled = False

        chkbAutoSelectTradingSymbol2.Checked = False
        chkbAutoSelectTradingSymbol2.Enabled = False
    End Sub

    Private Sub rdbDatabase_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDatabase.CheckedChanged
        cmbTable1.Enabled = True
        cmbTable2.Enabled = True

        'chkbAutoSelectTradingSymbol1.Checked = True
        chkbAutoSelectTradingSymbol1.Enabled = True

        'chkbAutoSelectTradingSymbol2.Checked = True
        chkbAutoSelectTradingSymbol2.Enabled = True
    End Sub
End Class
