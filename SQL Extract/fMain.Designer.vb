<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMain
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtEditor = New System.Windows.Forms.TextBox()
        Me.lstResult = New System.Windows.Forms.ListView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pgEditorResult = New System.Windows.Forms.TabPage()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lbEditorForeColour = New System.Windows.Forms.Label()
        Me.lbEditorBackColour = New System.Windows.Forms.Label()
        Me.lbEditorFore = New System.Windows.Forms.Label()
        Me.lbEditorBack = New System.Windows.Forms.Label()
        Me.txtLimitAmount = New System.Windows.Forms.TextBox()
        Me.chkLimit = New System.Windows.Forms.CheckBox()
        Me.chkEditorBold = New System.Windows.Forms.CheckBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.chkEditorWrap = New System.Windows.Forms.CheckBox()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.pgHistory = New System.Windows.Forms.TabPage()
        Me.lbHistoryForeColour = New System.Windows.Forms.Label()
        Me.lbHistoryBackColour = New System.Windows.Forms.Label()
        Me.lbHistoryFore = New System.Windows.Forms.Label()
        Me.lvHistoryBack = New System.Windows.Forms.Label()
        Me.chkHistoryBold = New System.Windows.Forms.CheckBox()
        Me.chkHistoryWrap = New System.Windows.Forms.CheckBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.txtHistory = New System.Windows.Forms.TextBox()
        Me.lstHistory = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pgSettings = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbDefaultName = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lbDefaultPath = New System.Windows.Forms.Label()
        Me.txtDefaultPath = New System.Windows.Forms.TextBox()
        Me.grpConnection = New System.Windows.Forms.GroupBox()
        Me.btnSaveConn = New System.Windows.Forms.Button()
        Me.lbConnectionTime = New System.Windows.Forms.Label()
        Me.txtConnectionTime = New System.Windows.Forms.TextBox()
        Me.lbCommandTime = New System.Windows.Forms.Label()
        Me.txtCommandTime = New System.Windows.Forms.TextBox()
        Me.lbSecurity = New System.Windows.Forms.Label()
        Me.txtSecurity = New System.Windows.Forms.TextBox()
        Me.lbCatalog = New System.Windows.Forms.Label()
        Me.txtCatalog = New System.Windows.Forms.TextBox()
        Me.lbDataSource = New System.Windows.Forms.Label()
        Me.txtDataSource = New System.Windows.Forms.TextBox()
        Me.lbProvider = New System.Windows.Forms.Label()
        Me.txtProvider = New System.Windows.Forms.TextBox()
        Me.pgLog = New System.Windows.Forms.TabPage()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.pgEditorResult.SuspendLayout()
        Me.pgHistory.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.pgSettings.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpConnection.SuspendLayout()
        Me.pgLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 36)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEditor)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstResult)
        Me.SplitContainer1.Size = New System.Drawing.Size(748, 428)
        Me.SplitContainer1.SplitterDistance = 236
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 0
        '
        'txtEditor
        '
        Me.txtEditor.AcceptsReturn = True
        Me.txtEditor.AcceptsTab = True
        Me.txtEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEditor.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtEditor.Font = New System.Drawing.Font("Courier New", 14.0!)
        Me.txtEditor.ForeColor = System.Drawing.Color.White
        Me.txtEditor.Location = New System.Drawing.Point(3, 3)
        Me.txtEditor.Multiline = True
        Me.txtEditor.Name = "txtEditor"
        Me.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEditor.Size = New System.Drawing.Size(738, 225)
        Me.txtEditor.TabIndex = 0
        Me.txtEditor.WordWrap = False
        '
        'lstResult
        '
        Me.lstResult.AllowColumnReorder = True
        Me.lstResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstResult.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstResult.FullRowSelect = True
        Me.lstResult.GridLines = True
        Me.lstResult.HideSelection = False
        Me.lstResult.Location = New System.Drawing.Point(3, 3)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(738, 169)
        Me.lstResult.TabIndex = 1
        Me.lstResult.UseCompatibleStateImageBehavior = False
        Me.lstResult.View = System.Windows.Forms.View.Details
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.pgEditorResult)
        Me.TabControl1.Controls.Add(Me.pgHistory)
        Me.TabControl1.Controls.Add(Me.pgSettings)
        Me.TabControl1.Controls.Add(Me.pgLog)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(768, 546)
        Me.TabControl1.TabIndex = 1
        '
        'pgEditorResult
        '
        Me.pgEditorResult.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pgEditorResult.Controls.Add(Me.btnExport)
        Me.pgEditorResult.Controls.Add(Me.lbEditorForeColour)
        Me.pgEditorResult.Controls.Add(Me.lbEditorBackColour)
        Me.pgEditorResult.Controls.Add(Me.lbEditorFore)
        Me.pgEditorResult.Controls.Add(Me.lbEditorBack)
        Me.pgEditorResult.Controls.Add(Me.txtLimitAmount)
        Me.pgEditorResult.Controls.Add(Me.chkLimit)
        Me.pgEditorResult.Controls.Add(Me.chkEditorBold)
        Me.pgEditorResult.Controls.Add(Me.btnLoad)
        Me.pgEditorResult.Controls.Add(Me.btnSave)
        Me.pgEditorResult.Controls.Add(Me.btnQuery)
        Me.pgEditorResult.Controls.Add(Me.chkEditorWrap)
        Me.pgEditorResult.Controls.Add(Me.SplitContainer1)
        Me.pgEditorResult.Location = New System.Drawing.Point(4, 24)
        Me.pgEditorResult.Name = "pgEditorResult"
        Me.pgEditorResult.Padding = New System.Windows.Forms.Padding(3)
        Me.pgEditorResult.Size = New System.Drawing.Size(760, 518)
        Me.pgEditorResult.TabIndex = 0
        Me.pgEditorResult.Text = "Editor/Result"
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackColor = System.Drawing.Color.LightGreen
        Me.btnExport.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnExport.Location = New System.Drawing.Point(240, 470)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(111, 38)
        Me.btnExport.TabIndex = 15
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'lbEditorForeColour
        '
        Me.lbEditorForeColour.BackColor = System.Drawing.Color.White
        Me.lbEditorForeColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEditorForeColour.Location = New System.Drawing.Point(193, 9)
        Me.lbEditorForeColour.Name = "lbEditorForeColour"
        Me.lbEditorForeColour.Size = New System.Drawing.Size(21, 21)
        Me.lbEditorForeColour.TabIndex = 14
        '
        'lbEditorBackColour
        '
        Me.lbEditorBackColour.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lbEditorBackColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEditorBackColour.Location = New System.Drawing.Point(88, 9)
        Me.lbEditorBackColour.Name = "lbEditorBackColour"
        Me.lbEditorBackColour.Size = New System.Drawing.Size(21, 21)
        Me.lbEditorBackColour.TabIndex = 13
        '
        'lbEditorFore
        '
        Me.lbEditorFore.AutoSize = True
        Me.lbEditorFore.Location = New System.Drawing.Point(115, 11)
        Me.lbEditorFore.Name = "lbEditorFore"
        Me.lbEditorFore.Size = New System.Drawing.Size(72, 17)
        Me.lbEditorFore.TabIndex = 12
        Me.lbEditorFore.Text = "Fore Colour"
        '
        'lbEditorBack
        '
        Me.lbEditorBack.AutoSize = True
        Me.lbEditorBack.Location = New System.Drawing.Point(8, 11)
        Me.lbEditorBack.Name = "lbEditorBack"
        Me.lbEditorBack.Size = New System.Drawing.Size(74, 17)
        Me.lbEditorBack.TabIndex = 10
        Me.lbEditorBack.Text = "Back Colour"
        '
        'txtLimitAmount
        '
        Me.txtLimitAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLimitAmount.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.txtLimitAmount.Location = New System.Drawing.Point(686, 9)
        Me.txtLimitAmount.Name = "txtLimitAmount"
        Me.txtLimitAmount.Size = New System.Drawing.Size(63, 21)
        Me.txtLimitAmount.TabIndex = 8
        Me.txtLimitAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkLimit
        '
        Me.chkLimit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkLimit.AutoSize = True
        Me.chkLimit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLimit.Location = New System.Drawing.Point(582, 10)
        Me.chkLimit.Name = "chkLimit"
        Me.chkLimit.Size = New System.Drawing.Size(98, 21)
        Me.chkLimit.TabIndex = 7
        Me.chkLimit.Text = "Limit Results"
        Me.chkLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLimit.UseVisualStyleBackColor = True
        '
        'chkEditorBold
        '
        Me.chkEditorBold.AutoSize = True
        Me.chkEditorBold.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEditorBold.Location = New System.Drawing.Point(220, 10)
        Me.chkEditorBold.Name = "chkEditorBold"
        Me.chkEditorBold.Size = New System.Drawing.Size(52, 21)
        Me.chkEditorBold.TabIndex = 6
        Me.chkEditorBold.Text = "Bold"
        Me.chkEditorBold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEditorBold.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLoad.BackColor = System.Drawing.Color.SandyBrown
        Me.btnLoad.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoad.Location = New System.Drawing.Point(6, 470)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(111, 38)
        Me.btnLoad.TabIndex = 4
        Me.btnLoad.Text = "LOAD"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Khaki
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Location = New System.Drawing.Point(123, 470)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 38)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuery.BackColor = System.Drawing.Color.Maroon
        Me.btnQuery.Enabled = False
        Me.btnQuery.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnQuery.ForeColor = System.Drawing.Color.White
        Me.btnQuery.Location = New System.Drawing.Point(638, 470)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(111, 38)
        Me.btnQuery.TabIndex = 2
        Me.btnQuery.Text = "RUN QUERY"
        Me.btnQuery.UseVisualStyleBackColor = False
        '
        'chkEditorWrap
        '
        Me.chkEditorWrap.AutoSize = True
        Me.chkEditorWrap.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEditorWrap.Location = New System.Drawing.Point(278, 10)
        Me.chkEditorWrap.Name = "chkEditorWrap"
        Me.chkEditorWrap.Size = New System.Drawing.Size(85, 21)
        Me.chkEditorWrap.TabIndex = 1
        Me.chkEditorWrap.Text = "Wrap Text"
        Me.chkEditorWrap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEditorWrap.UseVisualStyleBackColor = True
        '
        'lbStatus
        '
        Me.lbStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbStatus.BackColor = System.Drawing.Color.Transparent
        Me.lbStatus.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbStatus.ForeColor = System.Drawing.Color.Khaki
        Me.lbStatus.Location = New System.Drawing.Point(320, 0)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(370, 28)
        Me.lbStatus.TabIndex = 5
        Me.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pgHistory
        '
        Me.pgHistory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pgHistory.Controls.Add(Me.lbHistoryForeColour)
        Me.pgHistory.Controls.Add(Me.lbHistoryBackColour)
        Me.pgHistory.Controls.Add(Me.lbHistoryFore)
        Me.pgHistory.Controls.Add(Me.lvHistoryBack)
        Me.pgHistory.Controls.Add(Me.chkHistoryBold)
        Me.pgHistory.Controls.Add(Me.chkHistoryWrap)
        Me.pgHistory.Controls.Add(Me.SplitContainer2)
        Me.pgHistory.Location = New System.Drawing.Point(4, 24)
        Me.pgHistory.Name = "pgHistory"
        Me.pgHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.pgHistory.Size = New System.Drawing.Size(760, 518)
        Me.pgHistory.TabIndex = 1
        Me.pgHistory.Text = "History"
        '
        'lbHistoryForeColour
        '
        Me.lbHistoryForeColour.BackColor = System.Drawing.Color.White
        Me.lbHistoryForeColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbHistoryForeColour.Location = New System.Drawing.Point(193, 9)
        Me.lbHistoryForeColour.Name = "lbHistoryForeColour"
        Me.lbHistoryForeColour.Size = New System.Drawing.Size(21, 21)
        Me.lbHistoryForeColour.TabIndex = 18
        '
        'lbHistoryBackColour
        '
        Me.lbHistoryBackColour.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbHistoryBackColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbHistoryBackColour.Location = New System.Drawing.Point(88, 9)
        Me.lbHistoryBackColour.Name = "lbHistoryBackColour"
        Me.lbHistoryBackColour.Size = New System.Drawing.Size(21, 21)
        Me.lbHistoryBackColour.TabIndex = 17
        '
        'lbHistoryFore
        '
        Me.lbHistoryFore.AutoSize = True
        Me.lbHistoryFore.Location = New System.Drawing.Point(115, 11)
        Me.lbHistoryFore.Name = "lbHistoryFore"
        Me.lbHistoryFore.Size = New System.Drawing.Size(72, 17)
        Me.lbHistoryFore.TabIndex = 16
        Me.lbHistoryFore.Text = "Fore Colour"
        '
        'lvHistoryBack
        '
        Me.lvHistoryBack.AutoSize = True
        Me.lvHistoryBack.Location = New System.Drawing.Point(8, 11)
        Me.lvHistoryBack.Name = "lvHistoryBack"
        Me.lvHistoryBack.Size = New System.Drawing.Size(74, 17)
        Me.lvHistoryBack.TabIndex = 14
        Me.lvHistoryBack.Text = "Back Colour"
        '
        'chkHistoryBold
        '
        Me.chkHistoryBold.AutoSize = True
        Me.chkHistoryBold.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHistoryBold.Location = New System.Drawing.Point(220, 10)
        Me.chkHistoryBold.Name = "chkHistoryBold"
        Me.chkHistoryBold.Size = New System.Drawing.Size(52, 21)
        Me.chkHistoryBold.TabIndex = 7
        Me.chkHistoryBold.Text = "Bold"
        Me.chkHistoryBold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHistoryBold.UseVisualStyleBackColor = True
        '
        'chkHistoryWrap
        '
        Me.chkHistoryWrap.AutoSize = True
        Me.chkHistoryWrap.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHistoryWrap.Location = New System.Drawing.Point(278, 10)
        Me.chkHistoryWrap.Name = "chkHistoryWrap"
        Me.chkHistoryWrap.Size = New System.Drawing.Size(85, 21)
        Me.chkHistoryWrap.TabIndex = 2
        Me.chkHistoryWrap.Text = "Wrap Text"
        Me.chkHistoryWrap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHistoryWrap.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Location = New System.Drawing.Point(6, 36)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtHistory)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lstHistory)
        Me.SplitContainer2.Size = New System.Drawing.Size(748, 476)
        Me.SplitContainer2.SplitterDistance = 236
        Me.SplitContainer2.SplitterWidth = 5
        Me.SplitContainer2.TabIndex = 1
        '
        'txtHistory
        '
        Me.txtHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHistory.BackColor = System.Drawing.Color.Black
        Me.txtHistory.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHistory.ForeColor = System.Drawing.Color.White
        Me.txtHistory.Location = New System.Drawing.Point(3, 3)
        Me.txtHistory.Multiline = True
        Me.txtHistory.Name = "txtHistory"
        Me.txtHistory.ReadOnly = True
        Me.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtHistory.Size = New System.Drawing.Size(738, 225)
        Me.txtHistory.TabIndex = 0
        Me.txtHistory.WordWrap = False
        '
        'lstHistory
        '
        Me.lstHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstHistory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstHistory.FullRowSelect = True
        Me.lstHistory.GridLines = True
        Me.lstHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstHistory.HideSelection = False
        Me.lstHistory.Location = New System.Drawing.Point(3, 3)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(738, 225)
        Me.lstHistory.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.lstHistory.TabIndex = 2
        Me.lstHistory.UseCompatibleStateImageBehavior = False
        Me.lstHistory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date/Time"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Statement"
        Me.ColumnHeader3.Width = 290
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Time (hh:mm:ss)"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 110
        '
        'pgSettings
        '
        Me.pgSettings.AutoScroll = True
        Me.pgSettings.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pgSettings.Controls.Add(Me.GroupBox1)
        Me.pgSettings.Controls.Add(Me.grpConnection)
        Me.pgSettings.Location = New System.Drawing.Point(4, 24)
        Me.pgSettings.Name = "pgSettings"
        Me.pgSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.pgSettings.Size = New System.Drawing.Size(760, 518)
        Me.pgSettings.TabIndex = 2
        Me.pgSettings.Text = "Settings"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbDefaultName)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.lbDefaultPath)
        Me.GroupBox1.Controls.Add(Me.txtDefaultPath)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(347, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 222)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Export"
        '
        'lbDefaultName
        '
        Me.lbDefaultName.AutoSize = True
        Me.lbDefaultName.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbDefaultName.Location = New System.Drawing.Point(27, 58)
        Me.lbDefaultName.Name = "lbDefaultName"
        Me.lbDefaultName.Size = New System.Drawing.Size(124, 19)
        Me.lbDefaultName.TabIndex = 3
        Me.lbDefaultName.Text = "Default Filename:"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.TextBox5.Location = New System.Drawing.Point(157, 55)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(170, 27)
        Me.TextBox5.TabIndex = 2
        '
        'lbDefaultPath
        '
        Me.lbDefaultPath.AutoSize = True
        Me.lbDefaultPath.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbDefaultPath.Location = New System.Drawing.Point(57, 25)
        Me.lbDefaultPath.Name = "lbDefaultPath"
        Me.lbDefaultPath.Size = New System.Drawing.Size(94, 19)
        Me.lbDefaultPath.TabIndex = 1
        Me.lbDefaultPath.Text = "Default Path:"
        Me.lbDefaultPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDefaultPath
        '
        Me.txtDefaultPath.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtDefaultPath.Location = New System.Drawing.Point(157, 22)
        Me.txtDefaultPath.Name = "txtDefaultPath"
        Me.txtDefaultPath.Size = New System.Drawing.Size(170, 27)
        Me.txtDefaultPath.TabIndex = 0
        '
        'grpConnection
        '
        Me.grpConnection.BackColor = System.Drawing.Color.Transparent
        Me.grpConnection.Controls.Add(Me.btnSaveConn)
        Me.grpConnection.Controls.Add(Me.lbConnectionTime)
        Me.grpConnection.Controls.Add(Me.txtConnectionTime)
        Me.grpConnection.Controls.Add(Me.lbCommandTime)
        Me.grpConnection.Controls.Add(Me.txtCommandTime)
        Me.grpConnection.Controls.Add(Me.lbSecurity)
        Me.grpConnection.Controls.Add(Me.txtSecurity)
        Me.grpConnection.Controls.Add(Me.lbCatalog)
        Me.grpConnection.Controls.Add(Me.txtCatalog)
        Me.grpConnection.Controls.Add(Me.lbDataSource)
        Me.grpConnection.Controls.Add(Me.txtDataSource)
        Me.grpConnection.Controls.Add(Me.lbProvider)
        Me.grpConnection.Controls.Add(Me.txtProvider)
        Me.grpConnection.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.grpConnection.Location = New System.Drawing.Point(6, 6)
        Me.grpConnection.Name = "grpConnection"
        Me.grpConnection.Size = New System.Drawing.Size(335, 258)
        Me.grpConnection.TabIndex = 0
        Me.grpConnection.TabStop = False
        Me.grpConnection.Text = "Connection"
        '
        'btnSaveConn
        '
        Me.btnSaveConn.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.btnSaveConn.Location = New System.Drawing.Point(217, 220)
        Me.btnSaveConn.Name = "btnSaveConn"
        Me.btnSaveConn.Size = New System.Drawing.Size(110, 30)
        Me.btnSaveConn.TabIndex = 12
        Me.btnSaveConn.Text = "Save as Default"
        Me.btnSaveConn.UseVisualStyleBackColor = True
        '
        'lbConnectionTime
        '
        Me.lbConnectionTime.AutoSize = True
        Me.lbConnectionTime.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbConnectionTime.Location = New System.Drawing.Point(8, 190)
        Me.lbConnectionTime.Name = "lbConnectionTime"
        Me.lbConnectionTime.Size = New System.Drawing.Size(143, 19)
        Me.lbConnectionTime.TabIndex = 11
        Me.lbConnectionTime.Text = "Connection Timeout:"
        '
        'txtConnectionTime
        '
        Me.txtConnectionTime.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtConnectionTime.Location = New System.Drawing.Point(157, 187)
        Me.txtConnectionTime.Name = "txtConnectionTime"
        Me.txtConnectionTime.Size = New System.Drawing.Size(170, 27)
        Me.txtConnectionTime.TabIndex = 10
        '
        'lbCommandTime
        '
        Me.lbCommandTime.AutoSize = True
        Me.lbCommandTime.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbCommandTime.Location = New System.Drawing.Point(16, 157)
        Me.lbCommandTime.Name = "lbCommandTime"
        Me.lbCommandTime.Size = New System.Drawing.Size(135, 19)
        Me.lbCommandTime.TabIndex = 9
        Me.lbCommandTime.Text = "Command Timeout:"
        '
        'txtCommandTime
        '
        Me.txtCommandTime.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtCommandTime.Location = New System.Drawing.Point(157, 154)
        Me.txtCommandTime.Name = "txtCommandTime"
        Me.txtCommandTime.Size = New System.Drawing.Size(170, 27)
        Me.txtCommandTime.TabIndex = 8
        '
        'lbSecurity
        '
        Me.lbSecurity.AutoSize = True
        Me.lbSecurity.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbSecurity.Location = New System.Drawing.Point(16, 124)
        Me.lbSecurity.Name = "lbSecurity"
        Me.lbSecurity.Size = New System.Drawing.Size(135, 19)
        Me.lbSecurity.TabIndex = 7
        Me.lbSecurity.Text = "Integrated Security:"
        '
        'txtSecurity
        '
        Me.txtSecurity.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtSecurity.Location = New System.Drawing.Point(157, 121)
        Me.txtSecurity.Name = "txtSecurity"
        Me.txtSecurity.Size = New System.Drawing.Size(170, 27)
        Me.txtSecurity.TabIndex = 6
        '
        'lbCatalog
        '
        Me.lbCatalog.AutoSize = True
        Me.lbCatalog.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbCatalog.Location = New System.Drawing.Point(47, 91)
        Me.lbCatalog.Name = "lbCatalog"
        Me.lbCatalog.Size = New System.Drawing.Size(104, 19)
        Me.lbCatalog.TabIndex = 5
        Me.lbCatalog.Text = "Initial Catalog:"
        '
        'txtCatalog
        '
        Me.txtCatalog.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtCatalog.Location = New System.Drawing.Point(157, 88)
        Me.txtCatalog.Name = "txtCatalog"
        Me.txtCatalog.Size = New System.Drawing.Size(170, 27)
        Me.txtCatalog.TabIndex = 4
        '
        'lbDataSource
        '
        Me.lbDataSource.AutoSize = True
        Me.lbDataSource.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbDataSource.Location = New System.Drawing.Point(60, 58)
        Me.lbDataSource.Name = "lbDataSource"
        Me.lbDataSource.Size = New System.Drawing.Size(91, 19)
        Me.lbDataSource.TabIndex = 3
        Me.lbDataSource.Text = "Data Source:"
        '
        'txtDataSource
        '
        Me.txtDataSource.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtDataSource.Location = New System.Drawing.Point(157, 55)
        Me.txtDataSource.Name = "txtDataSource"
        Me.txtDataSource.Size = New System.Drawing.Size(170, 27)
        Me.txtDataSource.TabIndex = 2
        '
        'lbProvider
        '
        Me.lbProvider.AutoSize = True
        Me.lbProvider.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lbProvider.Location = New System.Drawing.Point(85, 25)
        Me.lbProvider.Name = "lbProvider"
        Me.lbProvider.Size = New System.Drawing.Size(66, 19)
        Me.lbProvider.TabIndex = 1
        Me.lbProvider.Text = "Provider:"
        Me.lbProvider.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProvider
        '
        Me.txtProvider.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtProvider.Location = New System.Drawing.Point(157, 22)
        Me.txtProvider.Name = "txtProvider"
        Me.txtProvider.Size = New System.Drawing.Size(170, 27)
        Me.txtProvider.TabIndex = 0
        '
        'pgLog
        '
        Me.pgLog.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pgLog.Controls.Add(Me.txtLog)
        Me.pgLog.Location = New System.Drawing.Point(4, 24)
        Me.pgLog.Name = "pgLog"
        Me.pgLog.Padding = New System.Windows.Forms.Padding(3)
        Me.pgLog.Size = New System.Drawing.Size(760, 518)
        Me.pgLog.TabIndex = 3
        Me.pgLog.Text = "Log"
        '
        'txtLog
        '
        Me.txtLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.Location = New System.Drawing.Point(7, 7)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(744, 510)
        Me.txtLog.TabIndex = 0
        Me.txtLog.WordWrap = False
        '
        'lbVersion
        '
        Me.lbVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbVersion.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVersion.ForeColor = System.Drawing.Color.White
        Me.lbVersion.Location = New System.Drawing.Point(679, 8)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(93, 18)
        Me.lbVersion.TabIndex = 2
        Me.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'fMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "fMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SQL Extract"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.pgEditorResult.ResumeLayout(False)
        Me.pgEditorResult.PerformLayout()
        Me.pgHistory.ResumeLayout(False)
        Me.pgHistory.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.pgSettings.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpConnection.ResumeLayout(False)
        Me.grpConnection.PerformLayout()
        Me.pgLog.ResumeLayout(False)
        Me.pgLog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pgEditorResult As TabPage
    Friend WithEvents pgHistory As TabPage
    Friend WithEvents pgSettings As TabPage
    Friend WithEvents chkEditorWrap As CheckBox
    Friend WithEvents btnQuery As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lbVersion As Label
    Friend WithEvents txtEditor As TextBox
    Friend WithEvents grpConnection As GroupBox
    Friend WithEvents lbConnectionTime As Label
    Friend WithEvents txtConnectionTime As TextBox
    Friend WithEvents lbCommandTime As Label
    Friend WithEvents txtCommandTime As TextBox
    Friend WithEvents lbSecurity As Label
    Friend WithEvents txtSecurity As TextBox
    Friend WithEvents lbCatalog As Label
    Friend WithEvents txtCatalog As TextBox
    Friend WithEvents lbDataSource As Label
    Friend WithEvents txtDataSource As TextBox
    Friend WithEvents lbProvider As Label
    Friend WithEvents txtProvider As TextBox
    Friend WithEvents pgLog As TabPage
    Friend WithEvents txtLog As TextBox
    Friend WithEvents lbStatus As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents txtHistory As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents chkHistoryWrap As CheckBox
    Friend WithEvents chkEditorBold As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbDefaultName As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents lbDefaultPath As Label
    Friend WithEvents txtDefaultPath As TextBox
    Friend WithEvents chkHistoryBold As CheckBox
    Friend WithEvents lstResult As ListView
    Friend WithEvents txtLimitAmount As TextBox
    Friend WithEvents chkLimit As CheckBox
    Friend WithEvents btnSaveConn As Button
    Friend WithEvents lbEditorFore As Label
    Friend WithEvents lbEditorBack As Label
    Friend WithEvents lbHistoryFore As Label
    Friend WithEvents lvHistoryBack As Label
    Friend WithEvents lbEditorBackColour As Label
    Friend WithEvents lbEditorForeColour As Label
    Friend WithEvents lbHistoryForeColour As Label
    Friend WithEvents lbHistoryBackColour As Label
    Friend WithEvents btnExport As Button
    Friend WithEvents lstHistory As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
