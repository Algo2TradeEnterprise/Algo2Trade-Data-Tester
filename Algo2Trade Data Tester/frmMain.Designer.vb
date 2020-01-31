<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.grpBoxInstrument1 = New System.Windows.Forms.GroupBox()
        Me.lblInstrument1Brokerage = New System.Windows.Forms.Label()
        Me.txtInstrument1Brokerage = New System.Windows.Forms.TextBox()
        Me.nmrcInstrument1NumberOfLots = New System.Windows.Forms.NumericUpDown()
        Me.lblInstrument1NumberOfLots = New System.Windows.Forms.Label()
        Me.nmrcInstrument1LotSize = New System.Windows.Forms.NumericUpDown()
        Me.lblInstrument1LotSize = New System.Windows.Forms.Label()
        Me.nmrcInstrument1Column = New System.Windows.Forms.NumericUpDown()
        Me.lblInstrument1Column = New System.Windows.Forms.Label()
        Me.lblSymbol1 = New System.Windows.Forms.Label()
        Me.txtSymbol1 = New System.Windows.Forms.TextBox()
        Me.txtToken1 = New System.Windows.Forms.TextBox()
        Me.lblToken1 = New System.Windows.Forms.Label()
        Me.grpBoxInstrument2 = New System.Windows.Forms.GroupBox()
        Me.lblInstrument2Brokerage = New System.Windows.Forms.Label()
        Me.txtInstrument2Brokerage = New System.Windows.Forms.TextBox()
        Me.nmrcInstrument2NumberOfLots = New System.Windows.Forms.NumericUpDown()
        Me.lblInstrument2NumberOfLots = New System.Windows.Forms.Label()
        Me.nmrcInstrument2LotSize = New System.Windows.Forms.NumericUpDown()
        Me.lblInstrument2LotSize = New System.Windows.Forms.Label()
        Me.nmrcInstrument2Column = New System.Windows.Forms.NumericUpDown()
        Me.lblInstrument2Column = New System.Windows.Forms.Label()
        Me.txtSymbol2 = New System.Windows.Forms.TextBox()
        Me.lblSymbol2 = New System.Windows.Forms.Label()
        Me.txtToken2 = New System.Windows.Forms.TextBox()
        Me.lblToken2 = New System.Windows.Forms.Label()
        Me.grpBoxDate = New System.Windows.Forms.GroupBox()
        Me.dtpckrToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpckrFromDate = New System.Windows.Forms.DateTimePicker()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.cmbSymbol = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpckrEODTime = New System.Windows.Forms.DateTimePicker()
        Me.lblEODTime = New System.Windows.Forms.Label()
        Me.nmrcTimeFrame = New System.Windows.Forms.NumericUpDown()
        Me.lblTimeFrame = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbLive = New System.Windows.Forms.RadioButton()
        Me.rdbDatabase = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTable = New System.Windows.Forms.ComboBox()
        Me.grpBoxInstrument1.SuspendLayout()
        CType(Me.nmrcInstrument1NumberOfLots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrcInstrument1LotSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrcInstrument1Column, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxInstrument2.SuspendLayout()
        CType(Me.nmrcInstrument2NumberOfLots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrcInstrument2LotSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrcInstrument2Column, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxDate.SuspendLayout()
        CType(Me.nmrcTimeFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProgress
        '
        Me.lblProgress.Location = New System.Drawing.Point(25, 425)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(695, 34)
        Me.lblProgress.TabIndex = 0
        Me.lblProgress.Text = "lblProgress"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(536, 367)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(84, 43)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'grpBoxInstrument1
        '
        Me.grpBoxInstrument1.Controls.Add(Me.lblInstrument1Brokerage)
        Me.grpBoxInstrument1.Controls.Add(Me.txtInstrument1Brokerage)
        Me.grpBoxInstrument1.Controls.Add(Me.nmrcInstrument1NumberOfLots)
        Me.grpBoxInstrument1.Controls.Add(Me.lblInstrument1NumberOfLots)
        Me.grpBoxInstrument1.Controls.Add(Me.nmrcInstrument1LotSize)
        Me.grpBoxInstrument1.Controls.Add(Me.lblInstrument1LotSize)
        Me.grpBoxInstrument1.Controls.Add(Me.nmrcInstrument1Column)
        Me.grpBoxInstrument1.Controls.Add(Me.lblInstrument1Column)
        Me.grpBoxInstrument1.Controls.Add(Me.lblSymbol1)
        Me.grpBoxInstrument1.Controls.Add(Me.txtSymbol1)
        Me.grpBoxInstrument1.Controls.Add(Me.txtToken1)
        Me.grpBoxInstrument1.Controls.Add(Me.lblToken1)
        Me.grpBoxInstrument1.Location = New System.Drawing.Point(26, 105)
        Me.grpBoxInstrument1.Name = "grpBoxInstrument1"
        Me.grpBoxInstrument1.Size = New System.Drawing.Size(340, 219)
        Me.grpBoxInstrument1.TabIndex = 2
        Me.grpBoxInstrument1.TabStop = False
        Me.grpBoxInstrument1.Text = "Instrument 1 Details"
        '
        'lblInstrument1Brokerage
        '
        Me.lblInstrument1Brokerage.AutoSize = True
        Me.lblInstrument1Brokerage.Location = New System.Drawing.Point(12, 184)
        Me.lblInstrument1Brokerage.Name = "lblInstrument1Brokerage"
        Me.lblInstrument1Brokerage.Size = New System.Drawing.Size(74, 17)
        Me.lblInstrument1Brokerage.TabIndex = 10
        Me.lblInstrument1Brokerage.Text = "Brokerage"
        '
        'txtInstrument1Brokerage
        '
        Me.txtInstrument1Brokerage.Location = New System.Drawing.Point(136, 183)
        Me.txtInstrument1Brokerage.Name = "txtInstrument1Brokerage"
        Me.txtInstrument1Brokerage.Size = New System.Drawing.Size(193, 22)
        Me.txtInstrument1Brokerage.TabIndex = 11
        '
        'nmrcInstrument1NumberOfLots
        '
        Me.nmrcInstrument1NumberOfLots.Location = New System.Drawing.Point(136, 152)
        Me.nmrcInstrument1NumberOfLots.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nmrcInstrument1NumberOfLots.Name = "nmrcInstrument1NumberOfLots"
        Me.nmrcInstrument1NumberOfLots.Size = New System.Drawing.Size(120, 22)
        Me.nmrcInstrument1NumberOfLots.TabIndex = 9
        '
        'lblInstrument1NumberOfLots
        '
        Me.lblInstrument1NumberOfLots.AutoSize = True
        Me.lblInstrument1NumberOfLots.Location = New System.Drawing.Point(12, 152)
        Me.lblInstrument1NumberOfLots.Name = "lblInstrument1NumberOfLots"
        Me.lblInstrument1NumberOfLots.Size = New System.Drawing.Size(108, 17)
        Me.lblInstrument1NumberOfLots.TabIndex = 8
        Me.lblInstrument1NumberOfLots.Text = "Number Of Lots"
        '
        'nmrcInstrument1LotSize
        '
        Me.nmrcInstrument1LotSize.Location = New System.Drawing.Point(136, 120)
        Me.nmrcInstrument1LotSize.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nmrcInstrument1LotSize.Name = "nmrcInstrument1LotSize"
        Me.nmrcInstrument1LotSize.Size = New System.Drawing.Size(120, 22)
        Me.nmrcInstrument1LotSize.TabIndex = 7
        '
        'lblInstrument1LotSize
        '
        Me.lblInstrument1LotSize.AutoSize = True
        Me.lblInstrument1LotSize.Location = New System.Drawing.Point(12, 120)
        Me.lblInstrument1LotSize.Name = "lblInstrument1LotSize"
        Me.lblInstrument1LotSize.Size = New System.Drawing.Size(59, 17)
        Me.lblInstrument1LotSize.TabIndex = 6
        Me.lblInstrument1LotSize.Text = "Lot Size"
        '
        'nmrcInstrument1Column
        '
        Me.nmrcInstrument1Column.Location = New System.Drawing.Point(136, 87)
        Me.nmrcInstrument1Column.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nmrcInstrument1Column.Name = "nmrcInstrument1Column"
        Me.nmrcInstrument1Column.Size = New System.Drawing.Size(120, 22)
        Me.nmrcInstrument1Column.TabIndex = 5
        '
        'lblInstrument1Column
        '
        Me.lblInstrument1Column.AutoSize = True
        Me.lblInstrument1Column.Location = New System.Drawing.Point(12, 87)
        Me.lblInstrument1Column.Name = "lblInstrument1Column"
        Me.lblInstrument1Column.Size = New System.Drawing.Size(108, 17)
        Me.lblInstrument1Column.TabIndex = 4
        Me.lblInstrument1Column.Text = "Starting Column"
        '
        'lblSymbol1
        '
        Me.lblSymbol1.AutoSize = True
        Me.lblSymbol1.Location = New System.Drawing.Point(12, 57)
        Me.lblSymbol1.Name = "lblSymbol1"
        Me.lblSymbol1.Size = New System.Drawing.Size(107, 17)
        Me.lblSymbol1.TabIndex = 2
        Me.lblSymbol1.Text = "Trading Symbol"
        '
        'txtSymbol1
        '
        Me.txtSymbol1.Location = New System.Drawing.Point(136, 55)
        Me.txtSymbol1.Name = "txtSymbol1"
        Me.txtSymbol1.Size = New System.Drawing.Size(193, 22)
        Me.txtSymbol1.TabIndex = 3
        '
        'txtToken1
        '
        Me.txtToken1.Location = New System.Drawing.Point(136, 25)
        Me.txtToken1.Name = "txtToken1"
        Me.txtToken1.Size = New System.Drawing.Size(193, 22)
        Me.txtToken1.TabIndex = 1
        '
        'lblToken1
        '
        Me.lblToken1.AutoSize = True
        Me.lblToken1.Location = New System.Drawing.Point(12, 27)
        Me.lblToken1.Name = "lblToken1"
        Me.lblToken1.Size = New System.Drawing.Size(118, 17)
        Me.lblToken1.TabIndex = 0
        Me.lblToken1.Text = "Instrument Token"
        '
        'grpBoxInstrument2
        '
        Me.grpBoxInstrument2.Controls.Add(Me.lblInstrument2Brokerage)
        Me.grpBoxInstrument2.Controls.Add(Me.txtInstrument2Brokerage)
        Me.grpBoxInstrument2.Controls.Add(Me.nmrcInstrument2NumberOfLots)
        Me.grpBoxInstrument2.Controls.Add(Me.lblInstrument2NumberOfLots)
        Me.grpBoxInstrument2.Controls.Add(Me.nmrcInstrument2LotSize)
        Me.grpBoxInstrument2.Controls.Add(Me.lblInstrument2LotSize)
        Me.grpBoxInstrument2.Controls.Add(Me.nmrcInstrument2Column)
        Me.grpBoxInstrument2.Controls.Add(Me.lblInstrument2Column)
        Me.grpBoxInstrument2.Controls.Add(Me.txtSymbol2)
        Me.grpBoxInstrument2.Controls.Add(Me.lblSymbol2)
        Me.grpBoxInstrument2.Controls.Add(Me.txtToken2)
        Me.grpBoxInstrument2.Controls.Add(Me.lblToken2)
        Me.grpBoxInstrument2.Location = New System.Drawing.Point(383, 105)
        Me.grpBoxInstrument2.Name = "grpBoxInstrument2"
        Me.grpBoxInstrument2.Size = New System.Drawing.Size(340, 219)
        Me.grpBoxInstrument2.TabIndex = 3
        Me.grpBoxInstrument2.TabStop = False
        Me.grpBoxInstrument2.Text = "Instrument 2 Details"
        '
        'lblInstrument2Brokerage
        '
        Me.lblInstrument2Brokerage.AutoSize = True
        Me.lblInstrument2Brokerage.Location = New System.Drawing.Point(12, 184)
        Me.lblInstrument2Brokerage.Name = "lblInstrument2Brokerage"
        Me.lblInstrument2Brokerage.Size = New System.Drawing.Size(74, 17)
        Me.lblInstrument2Brokerage.TabIndex = 16
        Me.lblInstrument2Brokerage.Text = "Brokerage"
        '
        'txtInstrument2Brokerage
        '
        Me.txtInstrument2Brokerage.Location = New System.Drawing.Point(136, 183)
        Me.txtInstrument2Brokerage.Name = "txtInstrument2Brokerage"
        Me.txtInstrument2Brokerage.Size = New System.Drawing.Size(193, 22)
        Me.txtInstrument2Brokerage.TabIndex = 17
        '
        'nmrcInstrument2NumberOfLots
        '
        Me.nmrcInstrument2NumberOfLots.Location = New System.Drawing.Point(136, 152)
        Me.nmrcInstrument2NumberOfLots.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nmrcInstrument2NumberOfLots.Name = "nmrcInstrument2NumberOfLots"
        Me.nmrcInstrument2NumberOfLots.Size = New System.Drawing.Size(120, 22)
        Me.nmrcInstrument2NumberOfLots.TabIndex = 15
        '
        'lblInstrument2NumberOfLots
        '
        Me.lblInstrument2NumberOfLots.AutoSize = True
        Me.lblInstrument2NumberOfLots.Location = New System.Drawing.Point(12, 152)
        Me.lblInstrument2NumberOfLots.Name = "lblInstrument2NumberOfLots"
        Me.lblInstrument2NumberOfLots.Size = New System.Drawing.Size(108, 17)
        Me.lblInstrument2NumberOfLots.TabIndex = 14
        Me.lblInstrument2NumberOfLots.Text = "Number Of Lots"
        '
        'nmrcInstrument2LotSize
        '
        Me.nmrcInstrument2LotSize.Location = New System.Drawing.Point(136, 120)
        Me.nmrcInstrument2LotSize.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nmrcInstrument2LotSize.Name = "nmrcInstrument2LotSize"
        Me.nmrcInstrument2LotSize.Size = New System.Drawing.Size(120, 22)
        Me.nmrcInstrument2LotSize.TabIndex = 13
        '
        'lblInstrument2LotSize
        '
        Me.lblInstrument2LotSize.AutoSize = True
        Me.lblInstrument2LotSize.Location = New System.Drawing.Point(12, 120)
        Me.lblInstrument2LotSize.Name = "lblInstrument2LotSize"
        Me.lblInstrument2LotSize.Size = New System.Drawing.Size(59, 17)
        Me.lblInstrument2LotSize.TabIndex = 12
        Me.lblInstrument2LotSize.Text = "Lot Size"
        '
        'nmrcInstrument2Column
        '
        Me.nmrcInstrument2Column.Location = New System.Drawing.Point(136, 86)
        Me.nmrcInstrument2Column.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nmrcInstrument2Column.Name = "nmrcInstrument2Column"
        Me.nmrcInstrument2Column.Size = New System.Drawing.Size(120, 22)
        Me.nmrcInstrument2Column.TabIndex = 6
        '
        'lblInstrument2Column
        '
        Me.lblInstrument2Column.AutoSize = True
        Me.lblInstrument2Column.Location = New System.Drawing.Point(12, 88)
        Me.lblInstrument2Column.Name = "lblInstrument2Column"
        Me.lblInstrument2Column.Size = New System.Drawing.Size(108, 17)
        Me.lblInstrument2Column.TabIndex = 5
        Me.lblInstrument2Column.Text = "Starting Column"
        '
        'txtSymbol2
        '
        Me.txtSymbol2.Location = New System.Drawing.Point(136, 55)
        Me.txtSymbol2.Name = "txtSymbol2"
        Me.txtSymbol2.Size = New System.Drawing.Size(193, 22)
        Me.txtSymbol2.TabIndex = 3
        '
        'lblSymbol2
        '
        Me.lblSymbol2.AutoSize = True
        Me.lblSymbol2.Location = New System.Drawing.Point(12, 57)
        Me.lblSymbol2.Name = "lblSymbol2"
        Me.lblSymbol2.Size = New System.Drawing.Size(107, 17)
        Me.lblSymbol2.TabIndex = 2
        Me.lblSymbol2.Text = "Trading Symbol"
        '
        'txtToken2
        '
        Me.txtToken2.Location = New System.Drawing.Point(136, 25)
        Me.txtToken2.Name = "txtToken2"
        Me.txtToken2.Size = New System.Drawing.Size(193, 22)
        Me.txtToken2.TabIndex = 1
        '
        'lblToken2
        '
        Me.lblToken2.AutoSize = True
        Me.lblToken2.Location = New System.Drawing.Point(12, 27)
        Me.lblToken2.Name = "lblToken2"
        Me.lblToken2.Size = New System.Drawing.Size(118, 17)
        Me.lblToken2.TabIndex = 0
        Me.lblToken2.Text = "Instrument Token"
        '
        'grpBoxDate
        '
        Me.grpBoxDate.Controls.Add(Me.dtpckrToDate)
        Me.grpBoxDate.Controls.Add(Me.dtpckrFromDate)
        Me.grpBoxDate.Controls.Add(Me.lblToDate)
        Me.grpBoxDate.Controls.Add(Me.lblFromDate)
        Me.grpBoxDate.Location = New System.Drawing.Point(26, 320)
        Me.grpBoxDate.Name = "grpBoxDate"
        Me.grpBoxDate.Size = New System.Drawing.Size(230, 94)
        Me.grpBoxDate.TabIndex = 4
        Me.grpBoxDate.TabStop = False
        Me.grpBoxDate.Text = "Date Range"
        '
        'dtpckrToDate
        '
        Me.dtpckrToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpckrToDate.Location = New System.Drawing.Point(92, 55)
        Me.dtpckrToDate.Name = "dtpckrToDate"
        Me.dtpckrToDate.Size = New System.Drawing.Size(119, 22)
        Me.dtpckrToDate.TabIndex = 4
        '
        'dtpckrFromDate
        '
        Me.dtpckrFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpckrFromDate.Location = New System.Drawing.Point(92, 26)
        Me.dtpckrFromDate.Name = "dtpckrFromDate"
        Me.dtpckrFromDate.Size = New System.Drawing.Size(119, 22)
        Me.dtpckrFromDate.TabIndex = 3
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(12, 57)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(59, 17)
        Me.lblToDate.TabIndex = 2
        Me.lblToDate.Text = "To Date"
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(12, 27)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(74, 17)
        Me.lblFromDate.TabIndex = 0
        Me.lblFromDate.Text = "From Date"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(636, 367)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(84, 43)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Location = New System.Drawing.Point(273, 335)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(126, 17)
        Me.lblFilePath.TabIndex = 6
        Me.lblFilePath.Text = "Template File Path"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(682, 333)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(41, 23)
        Me.btnBrowse.TabIndex = 8
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(408, 334)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(268, 22)
        Me.txtFilePath.TabIndex = 7
        '
        'cmbSymbol
        '
        Me.cmbSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSymbol.FormattingEnabled = True
        Me.cmbSymbol.Location = New System.Drawing.Point(115, 17)
        Me.cmbSymbol.Name = "cmbSymbol"
        Me.cmbSymbol.Size = New System.Drawing.Size(430, 24)
        Me.cmbSymbol.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Symbol List:"
        '
        'dtpckrEODTime
        '
        Me.dtpckrEODTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpckrEODTime.Location = New System.Drawing.Point(408, 369)
        Me.dtpckrEODTime.Name = "dtpckrEODTime"
        Me.dtpckrEODTime.ShowUpDown = True
        Me.dtpckrEODTime.Size = New System.Drawing.Size(119, 22)
        Me.dtpckrEODTime.TabIndex = 11
        Me.dtpckrEODTime.Value = New Date(2019, 5, 14, 23, 0, 0, 0)
        '
        'lblEODTime
        '
        Me.lblEODTime.AutoSize = True
        Me.lblEODTime.Location = New System.Drawing.Point(273, 371)
        Me.lblEODTime.Name = "lblEODTime"
        Me.lblEODTime.Size = New System.Drawing.Size(99, 17)
        Me.lblEODTime.TabIndex = 10
        Me.lblEODTime.Text = "EOD Exit Time"
        '
        'nmrcTimeFrame
        '
        Me.nmrcTimeFrame.Location = New System.Drawing.Point(636, 18)
        Me.nmrcTimeFrame.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nmrcTimeFrame.Name = "nmrcTimeFrame"
        Me.nmrcTimeFrame.Size = New System.Drawing.Size(76, 22)
        Me.nmrcTimeFrame.TabIndex = 13
        '
        'lblTimeFrame
        '
        Me.lblTimeFrame.AutoSize = True
        Me.lblTimeFrame.Location = New System.Drawing.Point(551, 20)
        Me.lblTimeFrame.Name = "lblTimeFrame"
        Me.lblTimeFrame.Size = New System.Drawing.Size(87, 17)
        Me.lblTimeFrame.TabIndex = 12
        Me.lblTimeFrame.Text = "Time Frame:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTable)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rdbDatabase)
        Me.GroupBox1.Controls.Add(Me.rdbLive)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 52)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Source"
        '
        'rdbLive
        '
        Me.rdbLive.AutoSize = True
        Me.rdbLive.Checked = True
        Me.rdbLive.Location = New System.Drawing.Point(13, 22)
        Me.rdbLive.Name = "rdbLive"
        Me.rdbLive.Size = New System.Drawing.Size(55, 21)
        Me.rdbLive.TabIndex = 0
        Me.rdbLive.TabStop = True
        Me.rdbLive.Text = "Live"
        Me.rdbLive.UseVisualStyleBackColor = True
        '
        'rdbDatabase
        '
        Me.rdbDatabase.AutoSize = True
        Me.rdbDatabase.Location = New System.Drawing.Point(100, 21)
        Me.rdbDatabase.Name = "rdbDatabase"
        Me.rdbDatabase.Size = New System.Drawing.Size(90, 21)
        Me.rdbDatabase.TabIndex = 1
        Me.rdbDatabase.Text = "Database"
        Me.rdbDatabase.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Table:"
        '
        'cmbTable
        '
        Me.cmbTable.FormattingEnabled = True
        Me.cmbTable.Items.AddRange(New Object() {"Intraday Cash", "Intraday Commodity", "Intraday Currency", "Intraday Futures", "EOD Cash", "EOD Commodity", "EOD Currency", "EOD Futures", "Intraday Futures Option", "EOD Futures Option"})
        Me.cmbTable.Location = New System.Drawing.Point(302, 19)
        Me.cmbTable.Name = "cmbTable"
        Me.cmbTable.Size = New System.Drawing.Size(290, 24)
        Me.cmbTable.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 468)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.nmrcTimeFrame)
        Me.Controls.Add(Me.lblTimeFrame)
        Me.Controls.Add(Me.dtpckrEODTime)
        Me.Controls.Add(Me.lblEODTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSymbol)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.lblFilePath)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.grpBoxDate)
        Me.Controls.Add(Me.grpBoxInstrument2)
        Me.Controls.Add(Me.grpBoxInstrument1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblProgress)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Algo2Trade Data Tester"
        Me.grpBoxInstrument1.ResumeLayout(False)
        Me.grpBoxInstrument1.PerformLayout()
        CType(Me.nmrcInstrument1NumberOfLots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrcInstrument1LotSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrcInstrument1Column, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxInstrument2.ResumeLayout(False)
        Me.grpBoxInstrument2.PerformLayout()
        CType(Me.nmrcInstrument2NumberOfLots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrcInstrument2LotSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrcInstrument2Column, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxDate.ResumeLayout(False)
        Me.grpBoxDate.PerformLayout()
        CType(Me.nmrcTimeFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProgress As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents grpBoxInstrument1 As GroupBox
    Friend WithEvents txtSymbol1 As TextBox
    Friend WithEvents lblSymbol1 As Label
    Friend WithEvents txtToken1 As TextBox
    Friend WithEvents lblToken1 As Label
    Friend WithEvents grpBoxInstrument2 As GroupBox
    Friend WithEvents txtSymbol2 As TextBox
    Friend WithEvents lblSymbol2 As Label
    Friend WithEvents txtToken2 As TextBox
    Friend WithEvents lblToken2 As Label
    Friend WithEvents grpBoxDate As GroupBox
    Friend WithEvents dtpckrToDate As DateTimePicker
    Friend WithEvents dtpckrFromDate As DateTimePicker
    Friend WithEvents lblToDate As Label
    Friend WithEvents lblFromDate As Label
    Friend WithEvents btnStop As Button
    Friend WithEvents lblFilePath As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents lblInstrument1Column As Label
    Friend WithEvents lblInstrument2Column As Label
    Friend WithEvents nmrcInstrument1Column As NumericUpDown
    Friend WithEvents nmrcInstrument2Column As NumericUpDown
    Friend WithEvents cmbSymbol As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblInstrument1Brokerage As Label
    Friend WithEvents txtInstrument1Brokerage As TextBox
    Friend WithEvents nmrcInstrument1NumberOfLots As NumericUpDown
    Friend WithEvents lblInstrument1NumberOfLots As Label
    Friend WithEvents nmrcInstrument1LotSize As NumericUpDown
    Friend WithEvents lblInstrument1LotSize As Label
    Friend WithEvents lblInstrument2Brokerage As Label
    Friend WithEvents txtInstrument2Brokerage As TextBox
    Friend WithEvents nmrcInstrument2NumberOfLots As NumericUpDown
    Friend WithEvents lblInstrument2NumberOfLots As Label
    Friend WithEvents nmrcInstrument2LotSize As NumericUpDown
    Friend WithEvents lblInstrument2LotSize As Label
    Friend WithEvents dtpckrEODTime As DateTimePicker
    Friend WithEvents lblEODTime As Label
    Friend WithEvents nmrcTimeFrame As NumericUpDown
    Friend WithEvents lblTimeFrame As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbDatabase As RadioButton
    Friend WithEvents rdbLive As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTable As ComboBox
End Class
