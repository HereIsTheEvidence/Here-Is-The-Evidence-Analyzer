<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnCsvFile = New System.Windows.Forms.Button()
        Me.txtFileIn = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FilterPanel = New System.Windows.Forms.Panel()
        Me.cboColumn4b = New System.Windows.Forms.ComboBox()
        Me.cboColumn3b = New System.Windows.Forms.ComboBox()
        Me.cboColumn2b = New System.Windows.Forms.ComboBox()
        Me.cboColumn1b = New System.Windows.Forms.ComboBox()
        Me.cboCompareType4 = New System.Windows.Forms.ComboBox()
        Me.cboCompareType3 = New System.Windows.Forms.ComboBox()
        Me.cboCompareType2 = New System.Windows.Forms.ComboBox()
        Me.cboCompareType1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDoUniqueRepeating = New System.Windows.Forms.CheckBox()
        Me.txtText4 = New System.Windows.Forms.TextBox()
        Me.cboOperation4 = New System.Windows.Forms.ComboBox()
        Me.cboColumn4 = New System.Windows.Forms.ComboBox()
        Me.txtText3 = New System.Windows.Forms.TextBox()
        Me.cboOperation3 = New System.Windows.Forms.ComboBox()
        Me.cboColumn3 = New System.Windows.Forms.ComboBox()
        Me.txtText2 = New System.Windows.Forms.TextBox()
        Me.cboOperation2 = New System.Windows.Forms.ComboBox()
        Me.cboColumn2 = New System.Windows.Forms.ComboBox()
        Me.txtText1 = New System.Windows.Forms.TextBox()
        Me.cboOperation1 = New System.Windows.Forms.ComboBox()
        Me.cboColumn1 = New System.Windows.Forms.ComboBox()
        Me.btnExecuteFilter = New System.Windows.Forms.Button()
        Me.lblWorking = New System.Windows.Forms.Label()
        Me.lblLinesDone = New System.Windows.Forms.Label()
        Me.lblRecordsFound = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblSkippedLines = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.UniquePanel = New System.Windows.Forms.Panel()
        Me.cbUniqueOrRepeating = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FilterPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCsvFile
        '
        Me.btnCsvFile.Location = New System.Drawing.Point(18, 145)
        Me.btnCsvFile.Name = "btnCsvFile"
        Me.btnCsvFile.Size = New System.Drawing.Size(151, 23)
        Me.btnCsvFile.TabIndex = 0
        Me.btnCsvFile.Text = "Select CSV File To Search"
        Me.btnCsvFile.UseVisualStyleBackColor = True
        '
        'txtFileIn
        '
        Me.txtFileIn.Location = New System.Drawing.Point(175, 147)
        Me.txtFileIn.Name = "txtFileIn"
        Me.txtFileIn.ReadOnly = True
        Me.txtFileIn.Size = New System.Drawing.Size(932, 20)
        Me.txtFileIn.TabIndex = 1
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.cboColumn4b)
        Me.FilterPanel.Controls.Add(Me.cboColumn3b)
        Me.FilterPanel.Controls.Add(Me.cboColumn2b)
        Me.FilterPanel.Controls.Add(Me.cboColumn1b)
        Me.FilterPanel.Controls.Add(Me.cboCompareType4)
        Me.FilterPanel.Controls.Add(Me.cboCompareType3)
        Me.FilterPanel.Controls.Add(Me.cboCompareType2)
        Me.FilterPanel.Controls.Add(Me.cboCompareType1)
        Me.FilterPanel.Controls.Add(Me.Label2)
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.cbDoUniqueRepeating)
        Me.FilterPanel.Controls.Add(Me.txtText4)
        Me.FilterPanel.Controls.Add(Me.cboOperation4)
        Me.FilterPanel.Controls.Add(Me.cboColumn4)
        Me.FilterPanel.Controls.Add(Me.txtText3)
        Me.FilterPanel.Controls.Add(Me.cboOperation3)
        Me.FilterPanel.Controls.Add(Me.cboColumn3)
        Me.FilterPanel.Controls.Add(Me.txtText2)
        Me.FilterPanel.Controls.Add(Me.cboOperation2)
        Me.FilterPanel.Controls.Add(Me.cboColumn2)
        Me.FilterPanel.Controls.Add(Me.txtText1)
        Me.FilterPanel.Controls.Add(Me.cboOperation1)
        Me.FilterPanel.Controls.Add(Me.cboColumn1)
        Me.FilterPanel.Location = New System.Drawing.Point(10, 164)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(1105, 169)
        Me.FilterPanel.TabIndex = 2
        Me.FilterPanel.Visible = False
        '
        'cboColumn4b
        '
        Me.cboColumn4b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumn4b.FormattingEnabled = True
        Me.cboColumn4b.Location = New System.Drawing.Point(662, 119)
        Me.cboColumn4b.Name = "cboColumn4b"
        Me.cboColumn4b.Size = New System.Drawing.Size(350, 21)
        Me.cboColumn4b.TabIndex = 36
        Me.cboColumn4b.Visible = False
        '
        'cboColumn3b
        '
        Me.cboColumn3b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumn3b.FormattingEnabled = True
        Me.cboColumn3b.Location = New System.Drawing.Point(662, 92)
        Me.cboColumn3b.Name = "cboColumn3b"
        Me.cboColumn3b.Size = New System.Drawing.Size(350, 21)
        Me.cboColumn3b.TabIndex = 35
        Me.cboColumn3b.Visible = False
        '
        'cboColumn2b
        '
        Me.cboColumn2b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumn2b.FormattingEnabled = True
        Me.cboColumn2b.Location = New System.Drawing.Point(662, 65)
        Me.cboColumn2b.Name = "cboColumn2b"
        Me.cboColumn2b.Size = New System.Drawing.Size(350, 21)
        Me.cboColumn2b.TabIndex = 34
        Me.cboColumn2b.Visible = False
        '
        'cboColumn1b
        '
        Me.cboColumn1b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumn1b.FormattingEnabled = True
        Me.cboColumn1b.Location = New System.Drawing.Point(662, 38)
        Me.cboColumn1b.Name = "cboColumn1b"
        Me.cboColumn1b.Size = New System.Drawing.Size(350, 21)
        Me.cboColumn1b.TabIndex = 33
        Me.cboColumn1b.Visible = False
        '
        'cboCompareType4
        '
        Me.cboCompareType4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompareType4.FormattingEnabled = True
        Me.cboCompareType4.Items.AddRange(New Object() {"Compare Field to Text", "Compare Field to Field"})
        Me.cboCompareType4.Location = New System.Drawing.Point(13, 119)
        Me.cboCompareType4.Name = "cboCompareType4"
        Me.cboCompareType4.Size = New System.Drawing.Size(150, 21)
        Me.cboCompareType4.TabIndex = 32
        '
        'cboCompareType3
        '
        Me.cboCompareType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompareType3.FormattingEnabled = True
        Me.cboCompareType3.Items.AddRange(New Object() {"Compare Field to Text", "Compare Field to Field"})
        Me.cboCompareType3.Location = New System.Drawing.Point(14, 92)
        Me.cboCompareType3.Name = "cboCompareType3"
        Me.cboCompareType3.Size = New System.Drawing.Size(150, 21)
        Me.cboCompareType3.TabIndex = 31
        '
        'cboCompareType2
        '
        Me.cboCompareType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompareType2.FormattingEnabled = True
        Me.cboCompareType2.Items.AddRange(New Object() {"Compare Field to Text", "Compare Field to Field"})
        Me.cboCompareType2.Location = New System.Drawing.Point(14, 65)
        Me.cboCompareType2.Name = "cboCompareType2"
        Me.cboCompareType2.Size = New System.Drawing.Size(150, 21)
        Me.cboCompareType2.TabIndex = 30
        '
        'cboCompareType1
        '
        Me.cboCompareType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompareType1.FormattingEnabled = True
        Me.cboCompareType1.Items.AddRange(New Object() {"Compare Field to Text", "Compare Field to Field"})
        Me.cboCompareType1.Location = New System.Drawing.Point(14, 38)
        Me.cboCompareType1.Name = "cboCompareType1"
        Me.cboCompareType1.Size = New System.Drawing.Size(150, 21)
        Me.cboCompareType1.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Set criteria to filter records."
        '
        'cbDoUniqueRepeating
        '
        Me.cbDoUniqueRepeating.AutoSize = True
        Me.cbDoUniqueRepeating.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoUniqueRepeating.Location = New System.Drawing.Point(13, 146)
        Me.cbDoUniqueRepeating.Name = "cbDoUniqueRepeating"
        Me.cbDoUniqueRepeating.Size = New System.Drawing.Size(199, 17)
        Me.cbDoUniqueRepeating.TabIndex = 24
        Me.cbDoUniqueRepeating.Text = "Keep only Unique or Repeating rows"
        Me.cbDoUniqueRepeating.UseVisualStyleBackColor = True
        '
        'txtText4
        '
        Me.txtText4.Location = New System.Drawing.Point(662, 119)
        Me.txtText4.Name = "txtText4"
        Me.txtText4.Size = New System.Drawing.Size(350, 20)
        Me.txtText4.TabIndex = 14
        '
        'cboOperation4
        '
        Me.cboOperation4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperation4.FormattingEnabled = True
        Me.cboOperation4.Items.AddRange(New Object() {"Less Than  (Before)", "Equals", "Not Equals", "Greater Than  (After)"})
        Me.cboOperation4.Location = New System.Drawing.Point(530, 119)
        Me.cboOperation4.Name = "cboOperation4"
        Me.cboOperation4.Size = New System.Drawing.Size(126, 21)
        Me.cboOperation4.TabIndex = 13
        '
        'cboColumn4
        '
        Me.cboColumn4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumn4.FormattingEnabled = True
        Me.cboColumn4.Location = New System.Drawing.Point(170, 119)
        Me.cboColumn4.Name = "cboColumn4"
        Me.cboColumn4.Size = New System.Drawing.Size(350, 21)
        Me.cboColumn4.TabIndex = 12
        '
        'txtText3
        '
        Me.txtText3.Location = New System.Drawing.Point(662, 92)
        Me.txtText3.Name = "txtText3"
        Me.txtText3.Size = New System.Drawing.Size(350, 20)
        Me.txtText3.TabIndex = 10
        '
        'cboOperation3
        '
        Me.cboOperation3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperation3.FormattingEnabled = True
        Me.cboOperation3.Items.AddRange(New Object() {"Less Than  (Before)", "Equals", "Not Equals", "Greater Than (After)"})
        Me.cboOperation3.Location = New System.Drawing.Point(530, 92)
        Me.cboOperation3.Name = "cboOperation3"
        Me.cboOperation3.Size = New System.Drawing.Size(126, 21)
        Me.cboOperation3.TabIndex = 9
        '
        'cboColumn3
        '
        Me.cboColumn3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumn3.FormattingEnabled = True
        Me.cboColumn3.Location = New System.Drawing.Point(171, 92)
        Me.cboColumn3.Name = "cboColumn3"
        Me.cboColumn3.Size = New System.Drawing.Size(350, 21)
        Me.cboColumn3.TabIndex = 8
        '
        'txtText2
        '
        Me.txtText2.Location = New System.Drawing.Point(662, 65)
        Me.txtText2.Name = "txtText2"
        Me.txtText2.Size = New System.Drawing.Size(350, 20)
        Me.txtText2.TabIndex = 6
        '
        'cboOperation2
        '
        Me.cboOperation2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperation2.FormattingEnabled = True
        Me.cboOperation2.Items.AddRange(New Object() {"Less Than  (Before)", "Equals", "Not Equals", "Greater Than  (After)"})
        Me.cboOperation2.Location = New System.Drawing.Point(530, 65)
        Me.cboOperation2.Name = "cboOperation2"
        Me.cboOperation2.Size = New System.Drawing.Size(126, 21)
        Me.cboOperation2.TabIndex = 5
        '
        'cboColumn2
        '
        Me.cboColumn2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumn2.FormattingEnabled = True
        Me.cboColumn2.Location = New System.Drawing.Point(171, 65)
        Me.cboColumn2.Name = "cboColumn2"
        Me.cboColumn2.Size = New System.Drawing.Size(350, 21)
        Me.cboColumn2.TabIndex = 4
        '
        'txtText1
        '
        Me.txtText1.Location = New System.Drawing.Point(662, 38)
        Me.txtText1.Name = "txtText1"
        Me.txtText1.Size = New System.Drawing.Size(350, 20)
        Me.txtText1.TabIndex = 2
        '
        'cboOperation1
        '
        Me.cboOperation1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperation1.FormattingEnabled = True
        Me.cboOperation1.Items.AddRange(New Object() {"Less Than  (Before)", "Equals", "Not Equals", "Greater Than  (After)"})
        Me.cboOperation1.Location = New System.Drawing.Point(529, 38)
        Me.cboOperation1.Name = "cboOperation1"
        Me.cboOperation1.Size = New System.Drawing.Size(126, 21)
        Me.cboOperation1.TabIndex = 1
        '
        'cboColumn1
        '
        Me.cboColumn1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumn1.FormattingEnabled = True
        Me.cboColumn1.Location = New System.Drawing.Point(171, 38)
        Me.cboColumn1.Name = "cboColumn1"
        Me.cboColumn1.Size = New System.Drawing.Size(350, 21)
        Me.cboColumn1.TabIndex = 0
        '
        'btnExecuteFilter
        '
        Me.btnExecuteFilter.Location = New System.Drawing.Point(8, 8)
        Me.btnExecuteFilter.Name = "btnExecuteFilter"
        Me.btnExecuteFilter.Size = New System.Drawing.Size(170, 23)
        Me.btnExecuteFilter.TabIndex = 16
        Me.btnExecuteFilter.Text = "Execute"
        Me.btnExecuteFilter.UseVisualStyleBackColor = True
        Me.btnExecuteFilter.Visible = False
        '
        'lblWorking
        '
        Me.lblWorking.AutoSize = True
        Me.lblWorking.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorking.Location = New System.Drawing.Point(210, 5)
        Me.lblWorking.Name = "lblWorking"
        Me.lblWorking.Size = New System.Drawing.Size(181, 24)
        Me.lblWorking.TabIndex = 17
        Me.lblWorking.Text = "Searching the File"
        Me.lblWorking.Visible = False
        '
        'lblLinesDone
        '
        Me.lblLinesDone.AutoSize = True
        Me.lblLinesDone.Location = New System.Drawing.Point(437, 8)
        Me.lblLinesDone.Name = "lblLinesDone"
        Me.lblLinesDone.Size = New System.Drawing.Size(69, 13)
        Me.lblLinesDone.TabIndex = 18
        Me.lblLinesDone.Text = "0 lines tested"
        Me.lblLinesDone.Visible = False
        '
        'lblRecordsFound
        '
        Me.lblRecordsFound.AutoSize = True
        Me.lblRecordsFound.Location = New System.Drawing.Point(438, 27)
        Me.lblRecordsFound.Name = "lblRecordsFound"
        Me.lblRecordsFound.Size = New System.Drawing.Size(81, 13)
        Me.lblRecordsFound.TabIndex = 19
        Me.lblRecordsFound.Text = "0 records found"
        Me.lblRecordsFound.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.lblSkippedLines)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnExecuteFilter)
        Me.Panel1.Controls.Add(Me.lblWorking)
        Me.Panel1.Controls.Add(Me.lblLinesDone)
        Me.Panel1.Controls.Add(Me.lblRecordsFound)
        Me.Panel1.Location = New System.Drawing.Point(10, 593)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1105, 64)
        Me.Panel1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(971, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Submit irregularities to"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(958, 37)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(141, 15)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "HereIsTheEvidence.com"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(9, 38)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(170, 23)
        Me.btnStop.TabIndex = 23
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        Me.btnStop.Visible = False
        '
        'lblSkippedLines
        '
        Me.lblSkippedLines.AutoSize = True
        Me.lblSkippedLines.Location = New System.Drawing.Point(438, 45)
        Me.lblSkippedLines.Name = "lblSkippedLines"
        Me.lblSkippedLines.Size = New System.Drawing.Size(70, 13)
        Me.lblSkippedLines.TabIndex = 22
        Me.lblSkippedLines.Text = "Skipped lines"
        Me.lblSkippedLines.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(8, 37)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(170, 23)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save Records Found to File"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'UniquePanel
        '
        Me.UniquePanel.AutoScroll = True
        Me.UniquePanel.Location = New System.Drawing.Point(10, 358)
        Me.UniquePanel.Name = "UniquePanel"
        Me.UniquePanel.Size = New System.Drawing.Size(1124, 229)
        Me.UniquePanel.TabIndex = 4
        Me.UniquePanel.Visible = False
        '
        'cbUniqueOrRepeating
        '
        Me.cbUniqueOrRepeating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUniqueOrRepeating.FormattingEnabled = True
        Me.cbUniqueOrRepeating.Items.AddRange(New Object() {"Combine the checked fields and find REPEATING rows", "Combine the checked fields and find UNIQUE rows"})
        Me.cbUniqueOrRepeating.Location = New System.Drawing.Point(18, 336)
        Me.cbUniqueOrRepeating.Name = "cbUniqueOrRepeating"
        Me.cbUniqueOrRepeating.Size = New System.Drawing.Size(379, 21)
        Me.cbUniqueOrRepeating.TabIndex = 28
        Me.cbUniqueOrRepeating.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(217, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(690, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 661)
        Me.Controls.Add(Me.btnCsvFile)
        Me.Controls.Add(Me.txtFileIn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UniquePanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FilterPanel)
        Me.Controls.Add(Me.cbUniqueOrRepeating)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Here Is The Evidence"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCsvFile As Button
    Friend WithEvents txtFileIn As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FilterPanel As Panel
    Friend WithEvents txtText1 As TextBox
    Friend WithEvents cboOperation1 As ComboBox
    Friend WithEvents cboColumn1 As ComboBox
    Friend WithEvents txtText4 As TextBox
    Friend WithEvents cboOperation4 As ComboBox
    Friend WithEvents cboColumn4 As ComboBox
    Friend WithEvents txtText3 As TextBox
    Friend WithEvents cboOperation3 As ComboBox
    Friend WithEvents cboColumn3 As ComboBox
    Friend WithEvents txtText2 As TextBox
    Friend WithEvents cboOperation2 As ComboBox
    Friend WithEvents cboColumn2 As ComboBox
    Friend WithEvents btnExecuteFilter As Button
    Friend WithEvents lblLinesDone As Label
    Friend WithEvents lblWorking As Label
    Friend WithEvents lblRecordsFound As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbDoUniqueRepeating As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UniquePanel As Panel
    Friend WithEvents cbUniqueOrRepeating As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSkippedLines As Label
    Friend WithEvents btnStop As Button
    Friend WithEvents cboCompareType1 As ComboBox
    Friend WithEvents cboCompareType4 As ComboBox
    Friend WithEvents cboCompareType3 As ComboBox
    Friend WithEvents cboCompareType2 As ComboBox
    Friend WithEvents cboColumn4b As ComboBox
    Friend WithEvents cboColumn3b As ComboBox
    Friend WithEvents cboColumn2b As ComboBox
    Friend WithEvents cboColumn1b As ComboBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
End Class
