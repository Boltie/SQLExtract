Public Class fMain
    Public Const sAppName As String = "SQL Extract"
    Public Const sVersion As String = "v0.1"

    Public _
        cd As New ColorDialog(),
        clrTemp As Color,
        cnADODB As ADODB.Connection,
        rsADODB As ADODB.Recordset,
        rsTemp As ADODB.Recordset

    Private Sub fMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadSettings()
        updateLog(sAppName & " " & sVersion & " Launched")
    End Sub

    Private Sub loadSettings()
        lbVersion.Text = sVersion
        Me.Text = sAppName & " " & sVersion
        txtEditor.AllowDrop = True

        'Editor Page
        If My.Settings.EditorBold Then
            chkEditorBold.Checked = True
            txtEditor.Font = New Font(txtEditor.Font.FontFamily, txtEditor.Font.Size, FontStyle.Bold)
        End If

        If My.Settings.EditorWrap Then
            chkEditorWrap.Checked = True
            txtEditor.WordWrap = True
        End If

        If My.Settings.Limit Then
            chkLimit.Checked = True
            txtLimitAmount.Enabled = True
        Else
            txtLimitAmount.Enabled = False
        End If

        txtLimitAmount.Text = My.Settings.LimitAmount

        'History Page
        If My.Settings.HistoryBold Then
            chkHistoryBold.Checked = True
            txtHistory.Font = New Font(txtHistory.Font.FontFamily, txtHistory.Font.Size, FontStyle.Bold)
        End If

        If My.Settings.HistoryWrap Then
            chkHistoryWrap.Checked = True
            txtHistory.WordWrap = True
        End If

        'Settings Page
        txtProvider.Text = My.Settings.Provider
        txtDataSource.Text = My.Settings.DataSource
        txtCatalog.Text = My.Settings.Catalog
        txtSecurity.Text = My.Settings.Security
        txtCommandTime.Text = My.Settings.CommandTime
        txtConnectionTime.Text = My.Settings.ConnectTime
    End Sub

    Private Function isDateTimeErr(typeToCheck As DataTypeEnum) As Boolean
        Dim _
            types(4) As DataTypeEnum

        types(0) = DataTypeEnum.adDBDate
        types(1) = DataTypeEnum.adDBTime
        types(2) = DataTypeEnum.adDBTimeStamp
        types(3) = DataTypeEnum.adError
        types(4) = DataTypeEnum.adVarWChar

        For Each type In types
            If typeToCheck = type _
                Then Return True
        Next
    End Function

    Private Function isNumType(typeToCheck As DataTypeEnum) As Boolean
        Dim _
            types(9) As DataTypeEnum

        types(0) = DataTypeEnum.adBigInt
        types(1) = DataTypeEnum.adCurrency
        types(2) = DataTypeEnum.adDecimal
        types(3) = DataTypeEnum.adDouble
        types(4) = DataTypeEnum.adInteger
        types(5) = DataTypeEnum.adNumeric
        types(6) = DataTypeEnum.adSingle
        types(7) = DataTypeEnum.adSmallInt
        types(8) = DataTypeEnum.adTinyInt
        types(9) = DataTypeEnum.adVarNumeric

        For Each type In types
            If typeToCheck = type _
                Then Return True
        Next
    End Function

    Private Sub updateLog(sMessage As String)
        Dim _
            sTimeStamp As String = Now().ToLocalTime.ToString & " - "

        If txtLog.Text = vbNullString _
            Then txtLog.Text = sTimeStamp & sMessage _
            Else txtLog.Text = txtLog.Text & vbNewLine & sTimeStamp & sMessage
    End Sub

    Private Sub updateStatus(sMessage As String, bVisible As Boolean)
        With lbStatus
            .Text = sMessage
            .Visible = bVisible
            .Refresh()
        End With
    End Sub

    Private Sub openConnection()
        On Error GoTo ErrorHandle
        Dim _
            sConn As String

        cnADODB = New ADODB.Connection

        sConn = "Provider=" & txtProvider.Text _
              & ";Data Source=" & txtDataSource.Text _
              & ";Initial Catalog=" & txtCatalog.Text _
              & ";Integrated Security=" & txtSecurity.Text & ";"

        With cnADODB
            .CommandTimeout = txtCommandTime.Text
            .ConnectionTimeout = txtConnectionTime.Text
            .Open(sConn)
        End With

        updateLog("Connection opened" & vbNewLine _
                & "Connection Settings:" & sConn & vbNewLine _
                & "Command Timeout:" & txtCommandTime.Text & vbNewLine _
                & "Connection Timeout:" & txtConnectionTime.Text)
        Exit Sub
ErrorHandle:
        cnADODB = Nothing

        updateLog("openConnection() Error:" & Err.Number & " - " & Err.Description)
        MsgBox("openConnection() Error:" & Err.Number & " - " & Err.Description)
    End Sub

    Private Sub closeConnection()
        updateLog("Data connection closed")
        cnADODB.Close()
        cnADODB = Nothing
    End Sub

    Private Function getColour(dfltColour As Color) As Color
        With cd
            .AllowFullOpen = True
            .AnyColor = True
            .Color = txtEditor.BackColor
            .FullOpen = True
        End With

        If cd.ShowDialog() = DialogResult.OK _
            Then Return cd.Color _
            Else Return dfltColour
    End Function

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        'On Error GoTo ErrorHandle
        Dim _
            dtStart As DateTime,
            dtEnd As DateTime,
            tsTime As TimeSpan,
            i As Int32,
            iCurrent As Int32,
            iFields As Int32,
            iRecCount As Int32,
            sHeader As String,
            sRecCount As String,
            sResponse As String,
            sSQL As String

        iCurrent = 0
        iFields = 0
        iRecCount = 0
        sHeader = vbNullString
        sRecCount = vbNullString
        sSQL = txtEditor.Text
        With lstHistory
            .Items.Add(vbNullString)
            .Items(lstHistory.Items.Count - 1).SubItems.Add(Now().ToLocalTime.ToString)
            .Items(lstHistory.Items.Count - 1).SubItems.Add(sSQL)
        End With

        updateStatus("QUERYING - PLEASE WAIT", True)

        openConnection()

        dtStart = Now()
        rsADODB = New ADODB.Recordset
        With rsADODB
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .Open(sSQL, cnADODB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockBatchOptimistic)
            .ActiveConnection = Nothing
            rsTemp = rsADODB.Clone()
        End With

        dtEnd = Now()
        tsTime = dtEnd.Subtract(dtStart)
        lstHistory.Items(lstHistory.Items.Count - 1).SubItems.Add(Format(tsTime.Hours, "00") _
                                                                 & ":" & Format(tsTime.Minutes, "00") _
                                                                 & ":" & Format(tsTime.Seconds, "00"))

        rsADODB = Nothing
        iRecCount = rsTemp.RecordCount
        closeConnection()

        If iRecCount > 500000 _
        And Not chkLimit.Checked Then
            sResponse = MsgBox("Your query has returned " & Format(iRecCount, "#,##0") & " records." _
                               & vbNewLine & vbNewLine _
                               & "Do you want to continue?", MsgBoxStyle.YesNo)
            If sResponse <> MsgBoxResult.Yes _
                Then Exit Sub
        End If

        lstResult.Clear()

        iFields = rsTemp.Fields.Count
        lstResult.Columns.Add(sHeader, 32)

        For i = 0 To iFields - 1
            sHeader = rsTemp.Fields(i).Name
            lstResult.Columns.Add(sHeader, 100)
            If isNumType(rsTemp.Fields(i).Type) _
                Then lstResult.Columns(i + 1).TextAlign = HorizontalAlignment.Right _
            Else If isDateTimeErr(rsTemp.Fields(i).Type) _
                Then lstResult.Columns(i + 1).TextAlign = HorizontalAlignment.Center _
                Else lstResult.Columns(i + 1).TextAlign = HorizontalAlignment.Left
        Next

        If chkLimit.Checked _
            Then sRecCount = Format(CSng(txtLimitAmount.Text), "#,##0") _
            Else sRecCount = Format(iRecCount, "#,##0")

        Do While Not rsTemp.EOF
            lstResult.Items.Add((iCurrent + 1).ToString)
            For i = 0 To iFields - 1
                lstResult.Items(iCurrent).SubItems.Add(rsTemp.Fields.Item(i).Value)
            Next i

            iCurrent = iCurrent + 1
            updateStatus("LOADING - " & Format(iCurrent, "#,##0") & "/" & sRecCount, True)

            If chkLimit.Checked _
            And iCurrent = txtLimitAmount.Text _
                Then rsTemp.MoveLast()

            rsTemp.MoveNext()
        Loop

        lstResult.Refresh()
        updateStatus(vbNullString, True)

        Exit Sub
ErrorHandle:
        If Not cnADODB Is Nothing _
            Then closeConnection()
        rsADODB = Nothing
        rsTemp = Nothing
        updateStatus(vbNullString, True)

        updateLog("btnQuery()_Click Error:" & Err.Number & " - " & Err.Description)
        MsgBox("btnQuery()_Click Error:" & Err.Number & " - " & Err.Description)
    End Sub

    Private Sub chkEditorBold_CheckedChanged(sender As Object, e As EventArgs) Handles chkEditorBold.CheckedChanged
        Dim _
            sngSize As Single = txtEditor.Font.Size

        If chkEditorBold.Checked _
            Then txtEditor.Font = New Font(txtEditor.Font.FontFamily, sngSize, FontStyle.Bold) _
            Else txtEditor.Font = New Font(txtEditor.Font.FontFamily, sngSize, FontStyle.Regular)
    End Sub

    Private Sub chkEditorWrap_CheckedChanged(sender As Object, e As EventArgs) Handles chkEditorWrap.CheckedChanged
        txtEditor.WordWrap = chkEditorWrap.Checked
    End Sub

    Private Sub chkLimit_CheckedChanged(sender As Object, e As EventArgs) Handles chkLimit.CheckedChanged
        txtLimitAmount.Enabled = chkLimit.Checked
    End Sub

    Private Sub lbEditorBackColour_Click(sender As Object, e As EventArgs) Handles lbEditorBackColour.Click
        clrTemp = getColour(txtEditor.BackColor)
        txtEditor.BackColor = clrTemp
        lbEditorBackColour.BackColor = clrTemp
    End Sub

    Private Sub lbEditorForeColour_Click(sender As Object, e As EventArgs) Handles lbEditorForeColour.Click
        clrTemp = getColour(txtEditor.ForeColor)
        txtEditor.ForeColor = clrTemp
        lbEditorForeColour.BackColor = clrTemp
    End Sub

    Private Sub txtEditor_DragDrop(sender As Object, e As DragEventArgs) Handles txtEditor.DragDrop
        Dim _
            sLoaded As String

        sLoaded = vbNullString
        txtEditor.Text = vbNullString

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then 'Item is a file
            'Store filepaths in string array/collection
            Dim _
                files() As String = e.Data.GetData(DataFormats.FileDrop, False)

            For Each path In files
                'If file path ends with either .sql or .txt, grab (and combine for multi) text from file(s)
                If Dir(path) <> "" And (path.ToLower.EndsWith(".sql") Or path.ToLower.EndsWith(".txt")) Then
                    If sLoaded = vbNullString _
                        Then sLoaded = My.Computer.FileSystem.ReadAllText(path) _
                        Else sLoaded = sLoaded & vbNewLine & My.Computer.FileSystem.ReadAllText(path)
                End If
            Next
        ElseIf e.Data.GetDataPresent(DataFormats.Text) Then 'Item is text
            sLoaded = e.Data.GetData(DataFormats.Text, True).ToString()
        End If

        txtEditor.Text = sLoaded
    End Sub

    Private Sub txtEditor_DragEnter(sender As Object, e As DragEventArgs) Handles txtEditor.DragEnter
        'Dragged item(s) file or text? Yes->copy passed item(s) to e.Effect
        If e.Data.GetDataPresent(DataFormats.FileDrop) Or e.Data.GetDataPresent(DataFormats.Text) _
            Then e.Effect = DragDropEffects.All
    End Sub

    Private Sub txtEditor_TextChanged(sender As Object, e As EventArgs) Handles txtEditor.TextChanged
        If txtEditor.Text.Length > 0 _
            Then btnQuery.Enabled = True _
            Else btnQuery.Enabled = False
    End Sub

    Private Sub txtLimitAmount_LostFocus(sender As Object, e As EventArgs) Handles txtLimitAmount.LostFocus
        If Not IsNumeric(txtLimitAmount.Text) Then
            MsgBox(txtLimitAmount.Text & " is invalid value. Please try again.", MsgBoxStyle.Exclamation, "Invalid Value!")
            txtLimitAmount.Text = vbNullString
            txtLimitAmount.Focus()
        End If
    End Sub

    Private Sub lstHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHistory.SelectedIndexChanged
        txtHistory.Text = lstHistory.FocusedItem.SubItems(2).Text
    End Sub

    Private Sub btnSaveConn_Click(sender As Object, e As EventArgs) Handles btnSaveConn.Click
        With My.Settings
            .Catalog = txtCatalog.Text
            .CommandTime = txtCommandTime.Text
            .ConnectTime = txtConnectionTime.Text
            .DataSource = txtDataSource.Text
            .Provider = txtProvider.Text
            .Security = txtSecurity.Text
        End With
    End Sub

    Private Sub chkHistoryWrap_CheckedChanged(sender As Object, e As EventArgs) Handles chkHistoryWrap.CheckedChanged
        txtHistory.WordWrap = chkHistoryWrap.Checked
    End Sub

    Private Sub lbHistoryBackColour_Click(sender As Object, e As EventArgs) Handles lbHistoryBackColour.Click
        clrTemp = getColour(txtHistory.BackColor)
        txtHistory.BackColor = clrTemp
        lbHistoryBackColour.BackColor = clrTemp
    End Sub

    Private Sub lbHistoryForeColour_Click(sender As Object, e As EventArgs) Handles lbHistoryForeColour.Click
        clrTemp = getColour(txtHistory.ForeColor)
        txtHistory.ForeColor = clrTemp
        lbHistoryForeColour.BackColor = clrTemp
    End Sub

    Private Sub lstHistory_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstHistory.MouseDoubleClick
        If lstHistory.Items.Count > 0 Then
            txtEditor.Text = txtHistory.Text
            TabControl1.SelectedTab = TabControl1.TabPages(0)
        End If
    End Sub
End Class