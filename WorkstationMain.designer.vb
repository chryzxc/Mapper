<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WorkstationMain
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkstationMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBorder = New System.Windows.Forms.ToolStripMenuItem()
        Me.sortItems = New System.Windows.Forms.ToolStripComboBox()
        Me.sortProd2 = New System.Windows.Forms.ToolStripComboBox()
        Me.menuLogs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.lockSub = New System.Windows.Forms.ToolStripMenuItem()
        Me.borderSub = New System.Windows.Forms.ToolStripMenuItem()
        Me.statSub = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchSub = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.formStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.workstationclickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SwapMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.highlightTimer = New System.Windows.Forms.Timer(Me.components)
        Me.statusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.prodListview = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.workstationPopBox = New System.Windows.Forms.Panel()
        Me.details = New System.Windows.Forms.Label()
        Me.statisticsPanel = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.sortProd = New System.Windows.Forms.ComboBox()
        Me.prodLabel = New System.Windows.Forms.Label()
        Me.overall = New System.Windows.Forms.Label()
        Me.totalWorking = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.totalDefective = New System.Windows.Forms.Label()
        Me.overallW = New System.Windows.Forms.Label()
        Me.overallD = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.labelUPW = New System.Windows.Forms.Label()
        Me.labelMSW = New System.Windows.Forms.Label()
        Me.labelKBW = New System.Windows.Forms.Label()
        Me.labelOMW = New System.Windows.Forms.Label()
        Me.labelPWW = New System.Windows.Forms.Label()
        Me.labelHDW = New System.Windows.Forms.Label()
        Me.labelDMW = New System.Windows.Forms.Label()
        Me.labelMMW = New System.Windows.Forms.Label()
        Me.labelMOW = New System.Windows.Forms.Label()
        Me.labelUPD = New System.Windows.Forms.Label()
        Me.labelMSD = New System.Windows.Forms.Label()
        Me.labelKBD = New System.Windows.Forms.Label()
        Me.labelOMD = New System.Windows.Forms.Label()
        Me.labelPWD = New System.Windows.Forms.Label()
        Me.labelHDD = New System.Windows.Forms.Label()
        Me.labelDMD = New System.Windows.Forms.Label()
        Me.labelMMD = New System.Windows.Forms.Label()
        Me.labelMOD = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.imageBox = New System.Windows.Forms.PictureBox()
        Me.timeTick = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.borderclickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.renameBorder = New System.Windows.Forms.ToolStripMenuItem()
        Me.deleteBorder = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChristianDataSet = New Christian.ChristianDataSet()
        Me.TableAdapterManager = New Christian.ChristianDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.workstationclickMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.prodListview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.workstationPopBox.SuspendLayout()
        Me.statisticsPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.borderclickMenu.SuspendLayout()
        CType(Me.ChristianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuImport, Me.menuRefresh, Me.menuBorder, Me.sortItems, Me.sortProd2, Me.menuLogs, Me.menuTools})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1178, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuImport
        '
        Me.menuImport.Name = "menuImport"
        Me.menuImport.Size = New System.Drawing.Size(88, 23)
        Me.menuImport.Text = "Import layout"
        '
        'menuRefresh
        '
        Me.menuRefresh.Name = "menuRefresh"
        Me.menuRefresh.Size = New System.Drawing.Size(58, 23)
        Me.menuRefresh.Text = "Refresh"
        '
        'menuBorder
        '
        Me.menuBorder.Name = "menuBorder"
        Me.menuBorder.Size = New System.Drawing.Size(78, 23)
        Me.menuBorder.Text = "Add border"
        '
        'sortItems
        '
        Me.sortItems.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.sortItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sortItems.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.sortItems.Name = "sortItems"
        Me.sortItems.Size = New System.Drawing.Size(121, 23)
        Me.sortItems.Visible = False
        '
        'sortProd2
        '
        Me.sortProd2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.sortProd2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sortProd2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.sortProd2.Name = "sortProd2"
        Me.sortProd2.Size = New System.Drawing.Size(121, 23)
        Me.sortProd2.Sorted = True
        Me.sortProd2.Visible = False
        '
        'menuLogs
        '
        Me.menuLogs.Name = "menuLogs"
        Me.menuLogs.Size = New System.Drawing.Size(43, 23)
        Me.menuLogs.Text = "Logs"
        '
        'menuTools
        '
        Me.menuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lockSub, Me.borderSub, Me.statSub, Me.searchSub, Me.ClearDatabaseToolStripMenuItem})
        Me.menuTools.Name = "menuTools"
        Me.menuTools.Size = New System.Drawing.Size(46, 23)
        Me.menuTools.Text = "Tools"
        '
        'lockSub
        '
        Me.lockSub.Name = "lockSub"
        Me.lockSub.Size = New System.Drawing.Size(174, 22)
        Me.lockSub.Text = "Lock controls"
        '
        'borderSub
        '
        Me.borderSub.Name = "borderSub"
        Me.borderSub.Size = New System.Drawing.Size(174, 22)
        Me.borderSub.Text = "Production borders"
        '
        'statSub
        '
        Me.statSub.Name = "statSub"
        Me.statSub.Size = New System.Drawing.Size(174, 22)
        Me.statSub.Text = "View statistics"
        '
        'searchSub
        '
        Me.searchSub.Name = "searchSub"
        Me.searchSub.Size = New System.Drawing.Size(174, 22)
        Me.searchSub.Text = "Search workstation"
        Me.searchSub.Visible = False
        '
        'ClearDatabaseToolStripMenuItem
        '
        Me.ClearDatabaseToolStripMenuItem.Name = "ClearDatabaseToolStripMenuItem"
        Me.ClearDatabaseToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ClearDatabaseToolStripMenuItem.Text = "Clear database"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.formStatus, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 442)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 18, 0)
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1178, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'formStatus
        '
        Me.formStatus.Name = "formStatus"
        Me.formStatus.Size = New System.Drawing.Size(1027, 17)
        Me.formStatus.Spring = True
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe Print", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(132, 17)
        Me.ToolStripStatusLabel1.Text = "Developed by: Christian Villablanca"
        '
        'workstationclickMenu
        '
        Me.workstationclickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMenuItem, Me.StatusMenuItem, Me.SwapMenuItem, Me.DeleteMenuItem})
        Me.workstationclickMenu.Name = "rightclickMenu"
        Me.workstationclickMenu.Size = New System.Drawing.Size(204, 92)
        '
        'AddMenuItem
        '
        Me.AddMenuItem.Name = "AddMenuItem"
        Me.AddMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AddMenuItem.Text = "Add terminals from here"
        '
        'StatusMenuItem
        '
        Me.StatusMenuItem.Name = "StatusMenuItem"
        Me.StatusMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.StatusMenuItem.Text = "Status"
        '
        'SwapMenuItem
        '
        Me.SwapMenuItem.Name = "SwapMenuItem"
        Me.SwapMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.SwapMenuItem.Text = "Swap item"
        '
        'DeleteMenuItem
        '
        Me.DeleteMenuItem.Name = "DeleteMenuItem"
        Me.DeleteMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.DeleteMenuItem.Text = "Delete terminal"
        '
        'highlightTimer
        '
        Me.highlightTimer.Interval = 1000
        '
        'statusTimer
        '
        Me.statusTimer.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.prodListview)
        Me.Panel1.Controls.Add(Me.workstationPopBox)
        Me.Panel1.Controls.Add(Me.statisticsPanel)
        Me.Panel1.Controls.Add(Me.searchBox)
        Me.Panel1.Controls.Add(Me.searchButton)
        Me.Panel1.Controls.Add(Me.imageBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1178, 418)
        Me.Panel1.TabIndex = 3
        '
        'prodListview
        '
        Me.prodListview.AllowUserToAddRows = False
        Me.prodListview.AllowUserToDeleteRows = False
        Me.prodListview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.prodListview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.prodListview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.prodListview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4})
        Me.prodListview.EnableHeadersVisualStyles = False
        Me.prodListview.GridColor = System.Drawing.SystemColors.Control
        Me.prodListview.Location = New System.Drawing.Point(339, 224)
        Me.prodListview.Name = "prodListview"
        Me.prodListview.ReadOnly = True
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.prodListview.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.prodListview.RowHeadersVisible = False
        Me.prodListview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodListview.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.prodListview.Size = New System.Drawing.Size(286, 191)
        Me.prodListview.TabIndex = 53
        Me.prodListview.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column3.HeaderText = "Defective"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column2.HeaderText = "Working"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'workstationPopBox
        '
        Me.workstationPopBox.AutoSize = True
        Me.workstationPopBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.workstationPopBox.Controls.Add(Me.details)
        Me.workstationPopBox.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.workstationPopBox.Location = New System.Drawing.Point(12, 535)
        Me.workstationPopBox.Name = "workstationPopBox"
        Me.workstationPopBox.Size = New System.Drawing.Size(51, 17)
        Me.workstationPopBox.TabIndex = 6
        Me.workstationPopBox.Visible = False
        '
        'details
        '
        Me.details.AutoSize = True
        Me.details.Location = New System.Drawing.Point(2, 0)
        Me.details.Name = "details"
        Me.details.Size = New System.Drawing.Size(44, 14)
        Me.details.TabIndex = 1
        Me.details.Text = "Popup "
        '
        'statisticsPanel
        '
        Me.statisticsPanel.AutoSize = True
        Me.statisticsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.statisticsPanel.Controls.Add(Me.GroupBox2)
        Me.statisticsPanel.Controls.Add(Me.GroupBox1)
        Me.statisticsPanel.Controls.Add(Me.Label1)
        Me.statisticsPanel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statisticsPanel.Location = New System.Drawing.Point(12, 15)
        Me.statisticsPanel.Name = "statisticsPanel"
        Me.statisticsPanel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.statisticsPanel.Size = New System.Drawing.Size(321, 400)
        Me.statisticsPanel.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.sortProd)
        Me.GroupBox2.Controls.Add(Me.prodLabel)
        Me.GroupBox2.Controls.Add(Me.overall)
        Me.GroupBox2.Controls.Add(Me.totalWorking)
        Me.GroupBox2.Controls.Add(Me.totalLabel)
        Me.GroupBox2.Controls.Add(Me.totalDefective)
        Me.GroupBox2.Controls.Add(Me.overallW)
        Me.GroupBox2.Controls.Add(Me.overallD)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.GroupBox2.Size = New System.Drawing.Size(298, 133)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(143, 24)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(88, 14)
        Me.LinkLabel1.TabIndex = 52
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Detailed Report"
        '
        'sortProd
        '
        Me.sortProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sortProd.FormattingEnabled = True
        Me.sortProd.Location = New System.Drawing.Point(6, 20)
        Me.sortProd.Name = "sortProd"
        Me.sortProd.Size = New System.Drawing.Size(131, 24)
        Me.sortProd.TabIndex = 51
        '
        'prodLabel
        '
        Me.prodLabel.AutoSize = True
        Me.prodLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.prodLabel.Location = New System.Drawing.Point(7, 20)
        Me.prodLabel.Name = "prodLabel"
        Me.prodLabel.Size = New System.Drawing.Size(58, 19)
        Me.prodLabel.TabIndex = 50
        Me.prodLabel.Text = "Overall"
        Me.prodLabel.Visible = False
        '
        'overall
        '
        Me.overall.AutoSize = True
        Me.overall.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.overall.Location = New System.Drawing.Point(7, 98)
        Me.overall.Name = "overall"
        Me.overall.Size = New System.Drawing.Size(45, 16)
        Me.overall.TabIndex = 4
        Me.overall.Text = "Total : "
        '
        'totalWorking
        '
        Me.totalWorking.AutoSize = True
        Me.totalWorking.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalWorking.Location = New System.Drawing.Point(116, 78)
        Me.totalWorking.Name = "totalWorking"
        Me.totalWorking.Size = New System.Drawing.Size(15, 16)
        Me.totalWorking.TabIndex = 49
        Me.totalWorking.Text = "0"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(116, 98)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(15, 16)
        Me.totalLabel.TabIndex = 5
        Me.totalLabel.Text = "0"
        '
        'totalDefective
        '
        Me.totalDefective.AutoSize = True
        Me.totalDefective.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalDefective.Location = New System.Drawing.Point(116, 62)
        Me.totalDefective.Name = "totalDefective"
        Me.totalDefective.Size = New System.Drawing.Size(15, 16)
        Me.totalDefective.TabIndex = 48
        Me.totalDefective.Text = "0"
        '
        'overallW
        '
        Me.overallW.AutoSize = True
        Me.overallW.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.overallW.Location = New System.Drawing.Point(7, 78)
        Me.overallW.Name = "overallW"
        Me.overallW.Size = New System.Drawing.Size(65, 16)
        Me.overallW.TabIndex = 46
        Me.overallW.Text = "Working : "
        '
        'overallD
        '
        Me.overallD.AutoSize = True
        Me.overallD.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.overallD.Location = New System.Drawing.Point(7, 62)
        Me.overallD.Name = "overallD"
        Me.overallD.Size = New System.Drawing.Size(73, 16)
        Me.overallD.TabIndex = 47
        Me.overallD.Text = "Defective : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.labelUPW)
        Me.GroupBox1.Controls.Add(Me.labelMSW)
        Me.GroupBox1.Controls.Add(Me.labelKBW)
        Me.GroupBox1.Controls.Add(Me.labelOMW)
        Me.GroupBox1.Controls.Add(Me.labelPWW)
        Me.GroupBox1.Controls.Add(Me.labelHDW)
        Me.GroupBox1.Controls.Add(Me.labelDMW)
        Me.GroupBox1.Controls.Add(Me.labelMMW)
        Me.GroupBox1.Controls.Add(Me.labelMOW)
        Me.GroupBox1.Controls.Add(Me.labelUPD)
        Me.GroupBox1.Controls.Add(Me.labelMSD)
        Me.GroupBox1.Controls.Add(Me.labelKBD)
        Me.GroupBox1.Controls.Add(Me.labelOMD)
        Me.GroupBox1.Controls.Add(Me.labelPWD)
        Me.GroupBox1.Controls.Add(Me.labelHDD)
        Me.GroupBox1.Controls.Add(Me.labelDMD)
        Me.GroupBox1.Controls.Add(Me.labelMMD)
        Me.GroupBox1.Controls.Add(Me.labelMOD)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 222)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'labelUPW
        '
        Me.labelUPW.AutoSize = True
        Me.labelUPW.Location = New System.Drawing.Point(222, 197)
        Me.labelUPW.Name = "labelUPW"
        Me.labelUPW.Size = New System.Drawing.Size(15, 16)
        Me.labelUPW.TabIndex = 35
        Me.labelUPW.Text = "0"
        '
        'labelMSW
        '
        Me.labelMSW.AutoSize = True
        Me.labelMSW.Location = New System.Drawing.Point(222, 178)
        Me.labelMSW.Name = "labelMSW"
        Me.labelMSW.Size = New System.Drawing.Size(15, 16)
        Me.labelMSW.TabIndex = 34
        Me.labelMSW.Text = "0"
        '
        'labelKBW
        '
        Me.labelKBW.AutoSize = True
        Me.labelKBW.Location = New System.Drawing.Point(222, 157)
        Me.labelKBW.Name = "labelKBW"
        Me.labelKBW.Size = New System.Drawing.Size(15, 16)
        Me.labelKBW.TabIndex = 33
        Me.labelKBW.Text = "0"
        '
        'labelOMW
        '
        Me.labelOMW.AutoSize = True
        Me.labelOMW.Location = New System.Drawing.Point(222, 138)
        Me.labelOMW.Name = "labelOMW"
        Me.labelOMW.Size = New System.Drawing.Size(15, 16)
        Me.labelOMW.TabIndex = 32
        Me.labelOMW.Text = "0"
        '
        'labelPWW
        '
        Me.labelPWW.AutoSize = True
        Me.labelPWW.Location = New System.Drawing.Point(222, 117)
        Me.labelPWW.Name = "labelPWW"
        Me.labelPWW.Size = New System.Drawing.Size(15, 16)
        Me.labelPWW.TabIndex = 31
        Me.labelPWW.Text = "0"
        '
        'labelHDW
        '
        Me.labelHDW.AutoSize = True
        Me.labelHDW.Location = New System.Drawing.Point(222, 98)
        Me.labelHDW.Name = "labelHDW"
        Me.labelHDW.Size = New System.Drawing.Size(15, 16)
        Me.labelHDW.TabIndex = 30
        Me.labelHDW.Text = "0"
        '
        'labelDMW
        '
        Me.labelDMW.AutoSize = True
        Me.labelDMW.Location = New System.Drawing.Point(222, 77)
        Me.labelDMW.Name = "labelDMW"
        Me.labelDMW.Size = New System.Drawing.Size(15, 16)
        Me.labelDMW.TabIndex = 29
        Me.labelDMW.Text = "0"
        '
        'labelMMW
        '
        Me.labelMMW.AutoSize = True
        Me.labelMMW.Location = New System.Drawing.Point(222, 58)
        Me.labelMMW.Name = "labelMMW"
        Me.labelMMW.Size = New System.Drawing.Size(15, 16)
        Me.labelMMW.TabIndex = 28
        Me.labelMMW.Text = "0"
        '
        'labelMOW
        '
        Me.labelMOW.AutoSize = True
        Me.labelMOW.Location = New System.Drawing.Point(222, 39)
        Me.labelMOW.Name = "labelMOW"
        Me.labelMOW.Size = New System.Drawing.Size(15, 16)
        Me.labelMOW.TabIndex = 26
        Me.labelMOW.Text = "0"
        '
        'labelUPD
        '
        Me.labelUPD.AutoSize = True
        Me.labelUPD.Location = New System.Drawing.Point(129, 197)
        Me.labelUPD.Name = "labelUPD"
        Me.labelUPD.Size = New System.Drawing.Size(15, 16)
        Me.labelUPD.TabIndex = 25
        Me.labelUPD.Text = "0"
        '
        'labelMSD
        '
        Me.labelMSD.AutoSize = True
        Me.labelMSD.Location = New System.Drawing.Point(129, 178)
        Me.labelMSD.Name = "labelMSD"
        Me.labelMSD.Size = New System.Drawing.Size(15, 16)
        Me.labelMSD.TabIndex = 24
        Me.labelMSD.Text = "0"
        '
        'labelKBD
        '
        Me.labelKBD.AutoSize = True
        Me.labelKBD.Location = New System.Drawing.Point(129, 157)
        Me.labelKBD.Name = "labelKBD"
        Me.labelKBD.Size = New System.Drawing.Size(15, 16)
        Me.labelKBD.TabIndex = 23
        Me.labelKBD.Text = "0"
        '
        'labelOMD
        '
        Me.labelOMD.AutoSize = True
        Me.labelOMD.Location = New System.Drawing.Point(129, 138)
        Me.labelOMD.Name = "labelOMD"
        Me.labelOMD.Size = New System.Drawing.Size(15, 16)
        Me.labelOMD.TabIndex = 22
        Me.labelOMD.Text = "0"
        '
        'labelPWD
        '
        Me.labelPWD.AutoSize = True
        Me.labelPWD.Location = New System.Drawing.Point(129, 117)
        Me.labelPWD.Name = "labelPWD"
        Me.labelPWD.Size = New System.Drawing.Size(15, 16)
        Me.labelPWD.TabIndex = 21
        Me.labelPWD.Text = "0"
        '
        'labelHDD
        '
        Me.labelHDD.AutoSize = True
        Me.labelHDD.Location = New System.Drawing.Point(129, 98)
        Me.labelHDD.Name = "labelHDD"
        Me.labelHDD.Size = New System.Drawing.Size(15, 16)
        Me.labelHDD.TabIndex = 20
        Me.labelHDD.Text = "0"
        '
        'labelDMD
        '
        Me.labelDMD.AutoSize = True
        Me.labelDMD.Location = New System.Drawing.Point(129, 77)
        Me.labelDMD.Name = "labelDMD"
        Me.labelDMD.Size = New System.Drawing.Size(15, 16)
        Me.labelDMD.TabIndex = 19
        Me.labelDMD.Text = "0"
        '
        'labelMMD
        '
        Me.labelMMD.AutoSize = True
        Me.labelMMD.Location = New System.Drawing.Point(129, 58)
        Me.labelMMD.Name = "labelMMD"
        Me.labelMMD.Size = New System.Drawing.Size(15, 16)
        Me.labelMMD.TabIndex = 18
        Me.labelMMD.Text = "0"
        '
        'labelMOD
        '
        Me.labelMOD.AutoSize = True
        Me.labelMOD.Location = New System.Drawing.Point(129, 39)
        Me.labelMOD.Name = "labelMOD"
        Me.labelMOD.Size = New System.Drawing.Size(15, 16)
        Me.labelMOD.TabIndex = 16
        Me.labelMOD.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(206, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 14)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Working"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(109, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 14)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Defective"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 197)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 14)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Ups"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 178)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 14)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Mouse"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 14)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Keyboard"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 14)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Monitor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 14)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Power supply"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Hard disk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Video card"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Memory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Motherboard"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Statistics"
        '
        'searchBox
        '
        Me.searchBox.Location = New System.Drawing.Point(349, 15)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(132, 24)
        Me.searchBox.TabIndex = 2
        Me.searchBox.Visible = False
        '
        'searchButton
        '
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.searchButton.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchButton.Location = New System.Drawing.Point(487, 12)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(99, 29)
        Me.searchButton.TabIndex = 1
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        Me.searchButton.Visible = False
        '
        'imageBox
        '
        Me.imageBox.Image = CType(resources.GetObject("imageBox.Image"), System.Drawing.Image)
        Me.imageBox.Location = New System.Drawing.Point(0, 0)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Size = New System.Drawing.Size(1500, 1500)
        Me.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBox.TabIndex = 0
        Me.imageBox.TabStop = False
        Me.imageBox.WaitOnLoad = True
        '
        'timeTick
        '
        Me.timeTick.Interval = 1000
        '
        'BackgroundWorker
        '
        '
        'borderclickMenu
        '
        Me.borderclickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.renameBorder, Me.deleteBorder})
        Me.borderclickMenu.Name = "borderclickMenu"
        Me.borderclickMenu.Size = New System.Drawing.Size(118, 48)
        '
        'renameBorder
        '
        Me.renameBorder.Name = "renameBorder"
        Me.renameBorder.Size = New System.Drawing.Size(117, 22)
        Me.renameBorder.Text = "Rename"
        '
        'deleteBorder
        '
        Me.deleteBorder.Name = "deleteBorder"
        Me.deleteBorder.Size = New System.Drawing.Size(117, 22)
        Me.deleteBorder.Text = "Delete"
        '
        'ChristianDataSet
        '
        Me.ChristianDataSet.DataSetName = "ChristianDataSet"
        Me.ChristianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.borderTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.imageTableAdapter = Nothing
        Me.TableAdapterManager.logsTableAdapter = Nothing
        Me.TableAdapterManager.replacementsTableAdapter = Nothing
        Me.TableAdapterManager.status_dateTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Christian.ChristianDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.workstationsTableAdapter = Nothing
        '
        'WorkstationMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1178, 464)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "WorkstationMain"
        Me.Text = "Monitoring"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.workstationclickMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.prodListview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.workstationPopBox.ResumeLayout(False)
        Me.workstationPopBox.PerformLayout()
        Me.statisticsPanel.ResumeLayout(False)
        Me.statisticsPanel.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.borderclickMenu.ResumeLayout(False)
        CType(Me.ChristianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents formStatus As ToolStripStatusLabel
    Friend WithEvents workstationclickMenu As ContextMenuStrip
    Friend WithEvents AddMenuItem As ToolStripMenuItem
    Friend WithEvents StatusMenuItem As ToolStripMenuItem
    Friend WithEvents highlightTimer As Timer
    Friend WithEvents statusTimer As Timer
    Friend WithEvents menuImport As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents statisticsPanel As Panel
    Friend WithEvents menuRefresh As ToolStripMenuItem
    Friend WithEvents totalLabel As Label
    Friend WithEvents overall As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents labelUPD As Label
    Friend WithEvents labelMSD As Label
    Friend WithEvents labelKBD As Label
    Friend WithEvents labelOMD As Label
    Friend WithEvents labelPWD As Label
    Friend WithEvents labelHDD As Label
    Friend WithEvents labelDMD As Label
    Friend WithEvents labelMMD As Label
    Friend WithEvents labelMOD As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents labelUPW As Label
    Friend WithEvents labelMSW As Label
    Friend WithEvents labelKBW As Label
    Friend WithEvents labelOMW As Label
    Friend WithEvents labelPWW As Label
    Friend WithEvents labelHDW As Label
    Friend WithEvents labelDMW As Label
    Friend WithEvents labelMMW As Label
    Friend WithEvents labelMOW As Label
    Friend WithEvents timeTick As Timer
    Friend WithEvents totalWorking As Label
    Friend WithEvents totalDefective As Label
    Friend WithEvents overallD As Label
    Friend WithEvents overallW As Label
    Friend WithEvents sortItems As ToolStripComboBox
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents menuBorder As ToolStripMenuItem
    Friend WithEvents borderclickMenu As ContextMenuStrip
    Friend WithEvents renameBorder As ToolStripMenuItem
    Friend WithEvents deleteBorder As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ChristianDataSet As ChristianDataSet


    Friend WithEvents TableAdapterManager As ChristianDataSetTableAdapters.TableAdapterManager
    Friend WithEvents menuTools As ToolStripMenuItem
    Friend WithEvents lockSub As ToolStripMenuItem
    Friend WithEvents borderSub As ToolStripMenuItem
    Friend WithEvents statSub As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents prodLabel As Label
    Friend WithEvents workstationPopBox As Panel
    Friend WithEvents details As Label
    Friend WithEvents searchSub As ToolStripMenuItem
    Friend WithEvents menuLogs As ToolStripMenuItem
    Friend WithEvents DeleteMenuItem As ToolStripMenuItem
    Friend WithEvents ClearDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SwapMenuItem As ToolStripMenuItem
    Friend WithEvents sortProd2 As ToolStripComboBox
    Friend WithEvents sortProd As ComboBox
    Friend WithEvents imageBox As PictureBox
    Friend WithEvents searchBox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents prodListview As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
