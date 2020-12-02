Imports System.IO

Public Class Form1
    Dim m_filenameIn As String = ""
    Dim m_columnNames() As String
    Dim m_rowColumnData() As String
    Dim m_recordsFound As Int64
    Dim m_uniqueCBs As New Dictionary(Of String, CheckBox)
    Dim m_dicUniqueStrs As New Dictionary(Of String, Int64)
    Dim m_dicRepeatingStrs As New Dictionary(Of String, Int16)
    Dim m_filteredIDs As New ArrayList
    Dim m_skippedLines As Int16
    Dim m_stop As Boolean
    Dim m_isDate1, m_isDate2, m_isDate3, m_isDate4 As Boolean
    Dim m_textDate1, m_textDate2, m_textDate3, m_textDate4 As Date
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub btnCsvFile_Click(sender As Object, e As EventArgs) Handles btnCsvFile.Click
        cbDoUniqueRepeating.Checked = False
        'remove and delete all the checkboxes
        For i = m_uniqueCBs.Count - 1 To 0 Step -1
            Dim cb As CheckBox = m_uniqueCBs(i)
            m_uniqueCBs.Remove(i)
            UniquePanel.Controls.Remove(cb)
        Next
        cboColumn1.Items.Clear()
        cboColumn2.Items.Clear()
        cboColumn3.Items.Clear()
        cboColumn4.Items.Clear()
        cboColumn1b.Items.Clear()
        cboColumn2b.Items.Clear()
        cboColumn3b.Items.Clear()
        cboColumn4b.Items.Clear()
        m_filenameIn = ""
        Erase m_columnNames
        Erase m_rowColumnData
        m_recordsFound = 0
        m_dicUniqueStrs.Clear()
        m_dicRepeatingStrs.Clear()
        m_filteredIDs.Clear()
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            m_filenameIn = OpenFileDialog1.FileName.ToLower
        End If
        txtFileIn.Text = m_filenameIn
        If Not m_filenameIn.EndsWith(".csv") Then
            MsgBox("File must end in .csv",, "Wrong File Format")
            Exit Sub
        End If
        Dim line As String
        ' Create new StreamReader instance with Using block.
        Try
            Using reader As StreamReader = New StreamReader(m_filenameIn)
                line = reader.ReadLine.Trim
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        If line = "" Then
            MsgBox("First line is blank.  The first line must be column headers")
            Exit Sub
        End If
        m_columnNames = line.Split(",")
        cboColumn1.Items.AddRange(m_columnNames)
        cboColumn2.Items.AddRange(m_columnNames)
        cboColumn3.Items.AddRange(m_columnNames)
        cboColumn4.Items.AddRange(m_columnNames)
        cboColumn1.Items.Add("")
        cboColumn2.Items.Add("")
        cboColumn3.Items.Add("")
        cboColumn4.Items.Add("")
        cboColumn1b.Items.AddRange(m_columnNames)
        cboColumn2b.Items.AddRange(m_columnNames)
        cboColumn3b.Items.AddRange(m_columnNames)
        cboColumn4b.Items.AddRange(m_columnNames)
        FilterPanel.Visible = True
        cboOperation1.SelectedIndex = 1
        cboOperation2.SelectedIndex = 1
        cboOperation3.SelectedIndex = 1
        cboOperation4.SelectedIndex = 1
        btnExecuteFilter.Visible = True
        cboCompareType1.SelectedIndex = 0
        cboCompareType2.SelectedIndex = 0
        cboCompareType3.SelectedIndex = 0
        cboCompareType4.SelectedIndex = 0
        cboColumn1b.SelectedIndex = 0
        cboColumn2b.SelectedIndex = 0
        cboColumn3b.SelectedIndex = 0
        cboColumn4b.SelectedIndex = 0

        For i As Integer = 0 To m_columnNames.Length - 1
            Dim cb As New CheckBox
            UniquePanel.Controls.Add(cb)
            cb.Height = 17
            cb.Width = 205
            cb.Left = (i Mod 5) * 218 + 9
            cb.Top = (i \ 5) * 19 + 9
            cb.Text = i
            cb.Tag = i
            Dim fnt As Font
            fnt = cb.Font
            cb.Font = New Font(fnt.Name, 7)
            m_uniqueCBs(i) = cb
        Next
    End Sub
    Private Sub btnExecuteFilter_Click(sender As Object, e As EventArgs) Handles btnExecuteFilter.Click
        txtText1.Text = txtText1.Text.Trim
        txtText2.Text = txtText2.Text.Trim
        txtText3.Text = txtText3.Text.Trim
        txtText4.Text = txtText4.Text.Trim
        m_stop = False
        lblSkippedLines.Visible = False
        btnStop.Visible = True
        m_skippedLines = 0
        btnSave.Visible = False
        lblRecordsFound.Visible = True
        lblWorking.Visible = True
        lblWorking.Text = "Searching the File"
        lblLinesDone.Visible = True
        lblRecordsFound.Visible = True
        m_recordsFound = 0
        Dim cnt As Int16 = 0
        Dim lineCnt As Int64 = 0
        m_dicUniqueStrs.Clear()
        m_dicRepeatingStrs.Clear()
        Dim uniqueFields() As Int16
        Dim uniqueStr As String = ""
        m_filteredIDs.Clear()
        If cboColumn1.Text <> "" Then
            If Not (cboCompareType1.SelectedIndex = 0 And txtText1.Text = "") Then
                Dim result As DialogResult = MessageBox.Show("Is the '" & cboColumn1.Text & "' column a date column with a month?", "Is this a Date?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    m_isDate1 = True
                    m_textDate1 = ConvertDate(txtText1.Text)
                Else
                    m_isDate1 = False
                End If
            End If
        End If
        If cboColumn2.Text <> "" Then
            If Not (cboCompareType2.SelectedIndex = 0 And txtText2.Text = "") Then
                Dim result As DialogResult = MessageBox.Show("Is the '" & cboColumn2.Text & "' column a date column with a month?", "Is this a Date?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    m_isDate2 = True
                    m_textDate2 = ConvertDate(txtText2.Text)
                Else
                    m_isDate2 = False
                End If
            End If
        End If
        If cboColumn3.Text <> "" Then
            If Not (cboCompareType3.SelectedIndex = 0 And txtText3.Text = "") Then
                Dim result As DialogResult = MessageBox.Show("Is the '" & cboColumn3.Text & "' column a date column with a month?", "Is this a Date?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    m_isDate3 = True
                    m_textDate3 = ConvertDate(txtText3.Text)
                Else
                    m_isDate3 = False
                End If
            End If
        End If
        If cboColumn4.Text <> "" Then
            If Not (cboCompareType4.SelectedIndex = 0 And txtText4.Text = "") Then
                Dim result As DialogResult = MessageBox.Show("Is the '" & cboColumn4.Text & "' column a date column with a month?", "Is this a Date?", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    m_isDate4 = True
                    m_textDate4 = ConvertDate(txtText4.Text)
                Else
                    m_isDate4 = False
                End If
            End If
        End If

        For n = 0 To m_columnNames.Length - 1
            If m_uniqueCBs(n).Checked Then
                If uniqueFields Is Nothing Then
                    ReDim Preserve uniqueFields(0)
                Else
                    ReDim Preserve uniqueFields(uniqueFields.Length)
                End If
                uniqueFields(uniqueFields.Length - 1) = n
            End If
        Next
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(m_filenameIn)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            m_rowColumnData = MyReader.ReadFields()
            Dim str As String = ""
            While Not MyReader.EndOfData
                Try
                    m_rowColumnData = MyReader.ReadFields()
                    If DoAnding() Then
                        'Filter says this is a good row
                        m_recordsFound += 1
                        m_filteredIDs.Add(lineCnt)
                        If cbDoUniqueRepeating.Checked Then
                            uniqueStr = ""
                            For n = 0 To uniqueFields.Length - 1
                                uniqueStr = uniqueStr & m_rowColumnData(uniqueFields(n))
                            Next
                            If m_dicUniqueStrs.ContainsKey(uniqueStr) Then
                                If Not m_dicRepeatingStrs.ContainsKey(m_dicUniqueStrs(uniqueStr)) Then
                                    m_dicRepeatingStrs.Add(m_dicUniqueStrs(uniqueStr), 0)
                                End If
                                m_dicRepeatingStrs.Add(lineCnt, 0)
                            Else
                                m_dicUniqueStrs.Add(uniqueStr, lineCnt)
                            End If
                        End If
                    End If
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    'MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                    lblSkippedLines.Visible = True
                    m_skippedLines += 1
                    lblSkippedLines.Text = m_skippedLines & " Lines skipped due to a formatting issue"
                End Try
                If m_stop Then
                    MyReader.Close()
                    lblWorking.Text = "Stopped"
                    m_stop = False
                    Exit Sub
                End If
                cnt += 1
                lineCnt += 1
                If cnt = 10000 Then
                    cnt = 0
                    lblLinesDone.Text = lineCnt & " lines tested"
                    If cbDoUniqueRepeating.Checked Then
                        If cbUniqueOrRepeating.SelectedIndex = 0 Then
                            lblRecordsFound.Text = m_dicRepeatingStrs.Count & " duplicate records found"
                        Else
                            lblRecordsFound.Text = m_recordsFound - m_dicRepeatingStrs.Count & " unique records found"
                        End If
                    Else
                        lblRecordsFound.Text = m_recordsFound & " records found"
                    End If
                    Application.DoEvents()
                End If
            End While
        End Using
        lblWorking.Text = "Finished Testing"
        lblLinesDone.Text = lineCnt & " lines tested"
        btnStop.Visible = False
        If cbDoUniqueRepeating.Checked Then
            If cbUniqueOrRepeating.SelectedIndex = 0 Then
                Dim percent As String = String.Format("{0:0.000%}", m_dicRepeatingStrs.Count / lineCnt)
                lblRecordsFound.Text = m_dicRepeatingStrs.Count & " duplicate records found = " & percent
            Else
                Dim percent As String = String.Format("{0:0.000%}", (m_recordsFound - m_dicRepeatingStrs.Count) / lineCnt)
                lblRecordsFound.Text = m_recordsFound - m_dicRepeatingStrs.Count & " unique records found = " & percent
            End If
        Else
            Dim percent As String = String.Format("{0:0.000%}", m_recordsFound / lineCnt)
            lblRecordsFound.Text = m_recordsFound & " records found = " & percent
        End If
        Application.DoEvents()
        If m_filteredIDs.Count > 0 Then
            btnSave.Visible = True
        End If
    End Sub
    Private Function DoAnding() As Boolean
        Dim LeftSide, RightSide As String
        Dim LeftDate, RightDate As Date
        '-----------------------------------------------------------------
        If cboColumn1.Text = "" Then
            Return True
        Else
            If m_isDate1 Then
                LeftDate = ConvertDate(m_rowColumnData(cboColumn1.SelectedIndex))
                If cboCompareType1.SelectedIndex = 0 Then
                    RightDate = m_textDate1
                Else
                    RightDate = ConvertDate(m_rowColumnData(cboColumn1b.SelectedIndex))
                End If
                Select Case cboOperation1.SelectedIndex
                    Case 0 'less than
                        If Not LeftDate < RightDate Then
                            Return False
                        End If
                    Case 1 'equals
                        If Not LeftDate = RightDate Then
                            Return False
                        End If
                    Case 2 'not equals
                        If Not LeftDate <> RightDate Then
                            Return False
                        End If
                    Case 3 'greater than
                        If Not LeftDate > RightDate Then
                            Return False
                        End If
                End Select
            Else
                LeftSide = m_rowColumnData(cboColumn1.SelectedIndex).ToLower
                If cboCompareType1.SelectedIndex = 0 Then
                    RightSide = txtText1.Text.ToLower
                Else
                    RightSide = m_rowColumnData(cboColumn1b.SelectedIndex).ToLower
                End If
                Select Case cboOperation1.SelectedIndex
                    Case 0 'less than
                        If Not LeftSide < RightSide Then
                            Return False
                        End If
                    Case 1 'equals
                        If Not LeftSide = RightSide Then
                            Return False
                        End If
                    Case 2 'not equals
                        If Not LeftSide <> RightSide Then
                            Return False
                        End If
                    Case 3 'greater than
                        If Not LeftSide > RightSide Then
                            Return False
                        End If
                End Select
            End If
        End If
        '-----------------------------------------------------------------
        If cboColumn2.Text = "" Then
            Return True
        Else
            If m_isDate2 Then
                LeftDate = ConvertDate(m_rowColumnData(cboColumn2.SelectedIndex))
                If cboCompareType2.SelectedIndex = 0 Then
                    RightDate = m_textDate2
                Else
                    RightDate = ConvertDate(m_rowColumnData(cboColumn2b.SelectedIndex))
                End If
                Select Case cboOperation2.SelectedIndex
                    Case 0 'less than
                        If Not LeftDate < RightDate Then
                            Return False
                        End If
                    Case 1 'equals
                        If Not LeftDate = RightDate Then
                            Return False
                        End If
                    Case 2 'not equals
                        If Not LeftDate <> RightDate Then
                            Return False
                        End If
                    Case 3 'greater than
                        If Not LeftDate > RightDate Then
                            Return False
                        End If
                End Select
            Else
                LeftSide = m_rowColumnData(cboColumn2.SelectedIndex).ToLower
                If cboCompareType2.SelectedIndex = 0 Then
                    RightSide = txtText2.Text.ToLower
                Else
                    RightSide = m_rowColumnData(cboColumn2b.SelectedIndex).ToLower
                End If
                Select Case cboOperation2.SelectedIndex
                    Case 0 'less than
                        If Not LeftSide < RightSide Then
                            Return False
                        End If
                    Case 1 'equals
                        If Not LeftSide = RightSide Then
                            Return False
                        End If
                    Case 2 'not equals
                        If Not LeftSide <> RightSide Then
                            Return False
                        End If
                    Case 3 'greater than
                        If Not LeftSide > RightSide Then
                            Return False
                        End If
                End Select
            End If
        End If
        '-----------------------------------------------------------------
        If cboColumn3.Text = "" Then
            Return True
        Else
            If m_isDate3 Then
                LeftDate = ConvertDate(m_rowColumnData(cboColumn3.SelectedIndex))
                If cboCompareType3.SelectedIndex = 0 Then
                    RightDate = m_textDate3
                Else
                    RightDate = ConvertDate(m_rowColumnData(cboColumn3b.SelectedIndex))
                End If
                Select Case cboOperation3.SelectedIndex
                    Case 0 'less than
                        If Not LeftDate < RightDate Then
                            Return False
                        End If
                    Case 1 'equals
                        If Not LeftDate = RightDate Then
                            Return False
                        End If
                    Case 2 'not equals
                        If Not LeftDate <> RightDate Then
                            Return False
                        End If
                    Case 3 'greater than
                        If Not LeftDate > RightDate Then
                            Return False
                        End If
                End Select
            Else
                LeftSide = m_rowColumnData(cboColumn3.SelectedIndex).ToLower
                If cboCompareType3.SelectedIndex = 0 Then
                    RightSide = txtText3.Text.ToLower
                Else
                    RightSide = m_rowColumnData(cboColumn3b.SelectedIndex).ToLower
                End If
                Select Case cboOperation3.SelectedIndex
                    Case 0 'less than
                        If Not LeftSide < RightSide Then
                            Return False
                        End If
                    Case 1 'equals
                        If Not LeftSide = RightSide Then
                            Return False
                        End If
                    Case 2 'not equals
                        If Not LeftSide <> RightSide Then
                            Return False
                        End If
                    Case 3 'greater than
                        If Not LeftSide > RightSide Then
                            Return False
                        End If
                End Select
            End If
        End If
        '-----------------------------------------------------------------
        If cboColumn4.Text = "" Then
            Return True
        Else
            If m_isDate4 Then
                LeftDate = ConvertDate(m_rowColumnData(cboColumn4.SelectedIndex))
                If cboCompareType4.SelectedIndex = 0 Then
                    RightDate = m_textDate4
                Else
                    RightDate = ConvertDate(m_rowColumnData(cboColumn4b.SelectedIndex))
                End If
                Select Case cboOperation4.SelectedIndex
                    Case 0 'less than
                        If Not LeftDate < RightDate Then
                            Return False
                        End If
                    Case 1 'equals
                        If Not LeftDate = RightDate Then
                            Return False
                        End If
                    Case 2 'not equals
                        If Not LeftDate <> RightDate Then
                            Return False
                        End If
                    Case 3 'greater than
                        If Not LeftDate > RightDate Then
                            Return False
                        End If
                End Select
            Else
                LeftSide = m_rowColumnData(cboColumn4.SelectedIndex).ToLower
                If cboCompareType4.SelectedIndex = 0 Then
                    RightSide = txtText4.Text.ToLower
                Else
                    RightSide = m_rowColumnData(cboColumn4b.SelectedIndex).ToLower
                End If
                Select Case cboOperation4.SelectedIndex
                    Case 0 'less than
                        If Not LeftSide < RightSide Then
                            Return False
                        End If
                    Case 1 'equals
                        If Not LeftSide = RightSide Then
                            Return False
                        End If
                    Case 2 'not equals
                        If Not LeftSide <> RightSide Then
                            Return False
                        End If
                    Case 3 'greater than
                        If Not LeftSide > RightSide Then
                            Return False
                        End If
                End Select
            End If
        End If
        Return True
    End Function
    Private Function ConvertDate(strDate As String) As Date
        Dim parts As String()
        If strDate = "" Then
            strDate = "1-1-1700"
        End If
        If strDate.Contains("-") Then
            parts = Split(strDate, "-")
        Else
            parts = Split(strDate, "/")
        End If
        If parts.Length = 1 Then
            strDate = "1-1-" & parts(0)
        End If
        If parts.Length = 3 Then
            If parts(0).Length = 4 Then
                strDate = parts(1) & "-" & parts(2) & "-" & parts(0)
            End If
        End If
        Try
            If Not IsDate(CDate(strDate).ToString) Then
                MsgBox("""" & strDate & """" & " is an invalid date.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            strDate = "1-1-1700"
            btnStop.PerformClick()
        End Try
        Return CDate(strDate)
    End Function
    Private Sub cbDoUniqueRepeating_CheckedChanged(sender As Object, e As EventArgs) Handles cbDoUniqueRepeating.CheckedChanged
        If cbDoUniqueRepeating.Checked Then
            UniquePanel.Visible = True
            cbUniqueOrRepeating.Visible = True
            cbUniqueOrRepeating.SelectedIndex = 0
            For n = 0 To m_columnNames.Length - 1
                m_uniqueCBs(n).Checked = False
                m_uniqueCBs(n).Text = m_columnNames(n)
            Next
        Else
            UniquePanel.Visible = False
            cbUniqueOrRepeating.Visible = False
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim filenameOut As String = ""
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 0
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            filenameOut = saveFileDialog1.FileName
            Dim result As DialogResult = MessageBox.Show("Would you like to save a screenshot of the current filter also?", "Save Filter", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Me.Refresh()
                For i As Integer = 0 To 100
                    System.Threading.Thread.Sleep(10)
                    Application.DoEvents()
                Next
                Dim screenShotName As String = filenameOut.Substring(0, InStrRev(filenameOut, ".")) & "png"
                DoPrintScreen(screenShotName)
            End If
            btnSave.Visible = False
            lblWorking.Text = "Saving file"
            lblRecordsFound.Visible = False
            lblLinesDone.Text = "Rows saved " & 0
            Dim line As String
            Dim cnt As Int64 = 0
            Dim cntWritten As Int64 = 0
            Dim lineCnt As Int64 = -1
            Dim filteredIDsCnt As Long = 0
            Dim writer As New System.IO.StreamWriter(filenameOut)
            Using reader As StreamReader = New StreamReader(m_filenameIn)
                line = reader.ReadLine
                Do While (Not line Is Nothing)
                    If lineCnt = -1 Then
                        writer.WriteLine(line)
                    Else
                        If lineCnt = m_filteredIDs(filteredIDsCnt) Then
                            ''We have a record that the filter said was good
                            If cbDoUniqueRepeating.Checked Then
                                If cbUniqueOrRepeating.SelectedIndex = 0 Then
                                    If m_dicRepeatingStrs.ContainsKey(lineCnt) Then
                                        'it is in the repeating list so save it.
                                        writer.WriteLine(line)
                                        cntWritten += 1
                                    End If
                                Else
                                    If Not m_dicRepeatingStrs.ContainsKey(lineCnt) Then
                                        'it is not in the repeating list so it is unique so save it.
                                        writer.WriteLine(line)
                                        cntWritten += 1
                                    End If
                                End If
                            Else
                                'there is no unique or repeating so just save it.
                                writer.WriteLine(line)
                                cntWritten += 1
                            End If
                            filteredIDsCnt += 1
                            If filteredIDsCnt = m_filteredIDs.Count Then
                                'we are all done.
                                reader.Close()
                                writer.Close()
                                lblWorking.Text = "Finished Saving"
                                lblLinesDone.Text = cntWritten & " lines written"
                                Exit Sub
                            End If
                        End If
                    End If
                    lineCnt += 1
                    line = reader.ReadLine
                    cnt += 1
                    If cnt = 10000 Then
                        cnt = 0
                        lblLinesDone.Text = cntWritten & " lines written"
                        Application.DoEvents()
                    End If
                Loop
            End Using
            writer.Close()
            MsgBox("ended at wrong place")
        End If
    End Sub
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        m_stop = True
        btnStop.Visible = False
    End Sub


    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Private Declare Function GetWindowRect Lib "user32" (ByVal hwnd As IntPtr, ByRef lpRect As RECT) As Integer
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
    Private Sub DoPrintScreen(filePath As String)
        'Dim r As New RECT
        'GetWindowRect(GetActiveWindow, r)
        'Dim img As New Bitmap(r.Right - r.Left, r.Bottom - r.Top)
        'Dim gr As Graphics = Graphics.FromImage(img)
        'gr.CopyFromScreen(New Point(r.Left, r.Top), Point.Empty, img.Size)
        'img.Save(filePath)


        'create a memory bitmap And size to the form outside outline
        Dim img As Bitmap = New Bitmap(Me.Width, Me.Height)
        'draw the form on the memory bitmap
        Me.DrawToBitmap(img, New Rectangle(0, 0, Me.Width, Me.Height))
        img.Save(filePath)

    End Sub
    Private Sub cboCompareType1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCompareType1.SelectedIndexChanged
        If cboCompareType1.SelectedIndex = 0 Then
            cboColumn1b.Visible = False
            txtText1.Visible = True
        Else
            cboColumn1b.Visible = True
            txtText1.Visible = False
        End If
    End Sub
    Private Sub cboCompareType2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCompareType2.SelectedIndexChanged
        If cboCompareType2.SelectedIndex = 0 Then
            cboColumn2b.Visible = False
            txtText2.Visible = True
        Else
            cboColumn2b.Visible = True
            txtText2.Visible = False
        End If
    End Sub
    Private Sub cboCompareType3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCompareType3.SelectedIndexChanged
        If cboCompareType3.SelectedIndex = 0 Then
            cboColumn3b.Visible = False
            txtText3.Visible = True
        Else
            cboColumn3b.Visible = True
            txtText3.Visible = False
        End If
    End Sub
    Private Sub cboCompareType4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCompareType4.SelectedIndexChanged
        If cboCompareType4.SelectedIndex = 0 Then
            cboColumn4b.Visible = False
            txtText4.Visible = True
        Else
            cboColumn4b.Visible = True
            txtText4.Visible = False
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("http://www.hereistheevidence.com")
    End Sub
End Class
