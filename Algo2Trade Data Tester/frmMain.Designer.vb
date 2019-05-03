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
        Me.nmrcInstrument1Column = New System.Windows.Forms.NumericUpDown()
        Me.lblInstrument1Column = New System.Windows.Forms.Label()
        Me.txtSymbol1 = New System.Windows.Forms.TextBox()
        Me.lblSymbol1 = New System.Windows.Forms.Label()
        Me.txtToken1 = New System.Windows.Forms.TextBox()
        Me.lblToken1 = New System.Windows.Forms.Label()
        Me.grpBoxInstrument2 = New System.Windows.Forms.GroupBox()
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
        Me.grpBoxInstrument1.SuspendLayout()
        CType(Me.nmrcInstrument1Column, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxInstrument2.SuspendLayout()
        CType(Me.nmrcInstrument2Column, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProgress
        '
        Me.lblProgress.Location = New System.Drawing.Point(26, 245)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(695, 34)
        Me.lblProgress.TabIndex = 0
        Me.lblProgress.Text = "lblProgress"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(536, 190)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(84, 43)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'grpBoxInstrument1
        '
        Me.grpBoxInstrument1.Controls.Add(Me.nmrcInstrument1Column)
        Me.grpBoxInstrument1.Controls.Add(Me.lblInstrument1Column)
        Me.grpBoxInstrument1.Controls.Add(Me.txtSymbol1)
        Me.grpBoxInstrument1.Controls.Add(Me.lblSymbol1)
        Me.grpBoxInstrument1.Controls.Add(Me.txtToken1)
        Me.grpBoxInstrument1.Controls.Add(Me.lblToken1)
        Me.grpBoxInstrument1.Location = New System.Drawing.Point(26, 17)
        Me.grpBoxInstrument1.Name = "grpBoxInstrument1"
        Me.grpBoxInstrument1.Size = New System.Drawing.Size(340, 120)
        Me.grpBoxInstrument1.TabIndex = 2
        Me.grpBoxInstrument1.TabStop = False
        Me.grpBoxInstrument1.Text = "Instrument 1 Details"
        '
        'nmrcInstrument1Column
        '
        Me.nmrcInstrument1Column.Location = New System.Drawing.Point(136, 87)
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
        'txtSymbol1
        '
        Me.txtSymbol1.Location = New System.Drawing.Point(136, 55)
        Me.txtSymbol1.Name = "txtSymbol1"
        Me.txtSymbol1.Size = New System.Drawing.Size(193, 22)
        Me.txtSymbol1.TabIndex = 3
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
        Me.grpBoxInstrument2.Controls.Add(Me.nmrcInstrument2Column)
        Me.grpBoxInstrument2.Controls.Add(Me.lblInstrument2Column)
        Me.grpBoxInstrument2.Controls.Add(Me.txtSymbol2)
        Me.grpBoxInstrument2.Controls.Add(Me.lblSymbol2)
        Me.grpBoxInstrument2.Controls.Add(Me.txtToken2)
        Me.grpBoxInstrument2.Controls.Add(Me.lblToken2)
        Me.grpBoxInstrument2.Location = New System.Drawing.Point(383, 17)
        Me.grpBoxInstrument2.Name = "grpBoxInstrument2"
        Me.grpBoxInstrument2.Size = New System.Drawing.Size(340, 120)
        Me.grpBoxInstrument2.TabIndex = 3
        Me.grpBoxInstrument2.TabStop = False
        Me.grpBoxInstrument2.Text = "Instrument 2 Details"
        '
        'nmrcInstrument2Column
        '
        Me.nmrcInstrument2Column.Location = New System.Drawing.Point(136, 86)
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
        Me.grpBoxDate.Location = New System.Drawing.Point(26, 143)
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
        Me.btnStop.Location = New System.Drawing.Point(636, 190)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(84, 43)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Location = New System.Drawing.Point(273, 158)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(126, 17)
        Me.lblFilePath.TabIndex = 6
        Me.lblFilePath.Text = "Template File Path"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(682, 157)
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
        Me.txtFilePath.Location = New System.Drawing.Point(408, 157)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(268, 22)
        Me.txtFilePath.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 294)
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
        CType(Me.nmrcInstrument1Column, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxInstrument2.ResumeLayout(False)
        Me.grpBoxInstrument2.PerformLayout()
        CType(Me.nmrcInstrument2Column, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxDate.ResumeLayout(False)
        Me.grpBoxDate.PerformLayout()
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
End Class
