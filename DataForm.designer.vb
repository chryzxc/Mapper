<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataForm))
        Me.WorkstationsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.WorkstationsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.WorkstationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Status_dateDataGridView = New System.Windows.Forms.DataGridView()
        Me.StatusDataGridView = New System.Windows.Forms.DataGridView()
        Me.BorderDataGridView = New System.Windows.Forms.DataGridView()
        Me.ImageDataGridView = New System.Windows.Forms.DataGridView()

        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        Me.ChristianDataSet = New Christian.ChristianDataSet()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ImageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status_dateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkstationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkstationsTableAdapter = New Christian.ChristianDataSetTableAdapters.workstationsTableAdapter()
        Me.Status_dateTableAdapter = New Christian.ChristianDataSetTableAdapters.status_dateTableAdapter()
        Me.StatusTableAdapter = New Christian.ChristianDataSetTableAdapters.statusTableAdapter()
        Me.BorderTableAdapter = New Christian.ChristianDataSetTableAdapters.borderTableAdapter()
        Me.TableAdapterManager = New Christian.ChristianDataSetTableAdapters.TableAdapterManager()
        Me.ImageTableAdapter = New Christian.ChristianDataSetTableAdapters.imageTableAdapter()
        CType(Me.WorkstationsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkstationsBindingNavigator.SuspendLayout()
        CType(Me.WorkstationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Status_dateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()

        CType(Me.ChristianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Status_dateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkstationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WorkstationsBindingNavigator
        '
        Me.WorkstationsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WorkstationsBindingNavigator.BindingSource = Me.WorkstationsBindingSource
        Me.WorkstationsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WorkstationsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WorkstationsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WorkstationsBindingNavigatorSaveItem})
        Me.WorkstationsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WorkstationsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WorkstationsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WorkstationsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WorkstationsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WorkstationsBindingNavigator.Name = "WorkstationsBindingNavigator"
        Me.WorkstationsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WorkstationsBindingNavigator.Size = New System.Drawing.Size(1155, 25)
        Me.WorkstationsBindingNavigator.TabIndex = 0
        Me.WorkstationsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'WorkstationsBindingNavigatorSaveItem
        '
        Me.WorkstationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WorkstationsBindingNavigatorSaveItem.Image = CType(resources.GetObject("WorkstationsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WorkstationsBindingNavigatorSaveItem.Name = "WorkstationsBindingNavigatorSaveItem"
        Me.WorkstationsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.WorkstationsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WorkstationsDataGridView
        '
        Me.WorkstationsDataGridView.AutoGenerateColumns = False
        Me.WorkstationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkstationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.WorkstationsDataGridView.DataSource = Me.WorkstationsBindingSource
        Me.WorkstationsDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.WorkstationsDataGridView.Name = "WorkstationsDataGridView"
        Me.WorkstationsDataGridView.Size = New System.Drawing.Size(468, 220)
        Me.WorkstationsDataGridView.TabIndex = 1
        '
        'Status_dateDataGridView
        '
        Me.Status_dateDataGridView.AutoGenerateColumns = False
        Me.Status_dateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Status_dateDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.Status_dateDataGridView.DataSource = Me.Status_dateBindingSource
        Me.Status_dateDataGridView.Location = New System.Drawing.Point(318, 254)
        Me.Status_dateDataGridView.Name = "Status_dateDataGridView"
        Me.Status_dateDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.Status_dateDataGridView.TabIndex = 2
        '
        'StatusDataGridView
        '
        Me.StatusDataGridView.AutoGenerateColumns = False
        Me.StatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StatusDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.StatusDataGridView.DataSource = Me.StatusBindingSource
        Me.StatusDataGridView.Location = New System.Drawing.Point(12, 254)
        Me.StatusDataGridView.Name = "StatusDataGridView"
        Me.StatusDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.StatusDataGridView.TabIndex = 3
        '
        'BorderDataGridView
        '
        Me.BorderDataGridView.AutoGenerateColumns = False
        Me.BorderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29})
        Me.BorderDataGridView.DataSource = Me.BorderBindingSource
        Me.BorderDataGridView.Location = New System.Drawing.Point(486, 28)
        Me.BorderDataGridView.Name = "BorderDataGridView"
        Me.BorderDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.BorderDataGridView.TabIndex = 4
        '
        'ImageDataGridView
        '
        Me.ImageDataGridView.AutoGenerateColumns = False
        Me.ImageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ImageDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1})
        Me.ImageDataGridView.DataSource = Me.ImageBindingSource
        Me.ImageDataGridView.Location = New System.Drawing.Point(624, 254)
        Me.ImageDataGridView.Name = "ImageDataGridView"
        Me.ImageDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ImageDataGridView.TabIndex = 5
        '

        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "workstation_number"
        Me.DataGridViewTextBoxColumn30.HeaderText = "workstation_number"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "item"
        Me.DataGridViewTextBoxColumn31.HeaderText = "item"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn32.HeaderText = "description"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "barcode"
        Me.DataGridViewTextBoxColumn33.HeaderText = "barcode"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "prod"
        Me.DataGridViewTextBoxColumn34.HeaderText = "prod"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn35.HeaderText = "date"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'ReplacementsBindingSource
        '

        '
        'ChristianDataSet
        '
        Me.ChristianDataSet.DataSetName = "ChristianDataSet"
        Me.ChristianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "prod_layout"
        Me.DataGridViewImageColumn1.HeaderText = "prod_layout"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'ImageBindingSource
        '
        Me.ImageBindingSource.DataMember = "image"
        Me.ImageBindingSource.DataSource = Me.ChristianDataSet
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "border_name"
        Me.DataGridViewTextBoxColumn25.HeaderText = "border_name"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "point_x"
        Me.DataGridViewTextBoxColumn26.HeaderText = "point_x"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "point_y"
        Me.DataGridViewTextBoxColumn27.HeaderText = "point_y"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "border_height"
        Me.DataGridViewTextBoxColumn28.HeaderText = "border_height"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "border_width"
        Me.DataGridViewTextBoxColumn29.HeaderText = "border_width"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'BorderBindingSource
        '
        Me.BorderBindingSource.DataMember = "border"
        Me.BorderBindingSource.DataSource = Me.ChristianDataSet
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "workstation_number"
        Me.DataGridViewTextBoxColumn15.HeaderText = "workstation_number"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "mo"
        Me.DataGridViewTextBoxColumn16.HeaderText = "mo"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "mm"
        Me.DataGridViewTextBoxColumn17.HeaderText = "mm"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "dm"
        Me.DataGridViewTextBoxColumn18.HeaderText = "dm"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "hd"
        Me.DataGridViewTextBoxColumn19.HeaderText = "hd"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "pw"
        Me.DataGridViewTextBoxColumn20.HeaderText = "pw"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "om"
        Me.DataGridViewTextBoxColumn21.HeaderText = "om"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "kb"
        Me.DataGridViewTextBoxColumn22.HeaderText = "kb"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "ms"
        Me.DataGridViewTextBoxColumn23.HeaderText = "ms"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "up"
        Me.DataGridViewTextBoxColumn24.HeaderText = "up"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'StatusBindingSource
        '
        Me.StatusBindingSource.DataMember = "status"
        Me.StatusBindingSource.DataSource = Me.ChristianDataSet
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "workstation_name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "workstation_name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "mo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "mo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "mm"
        Me.DataGridViewTextBoxColumn7.HeaderText = "mm"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "dm"
        Me.DataGridViewTextBoxColumn8.HeaderText = "dm"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "hd"
        Me.DataGridViewTextBoxColumn9.HeaderText = "hd"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "pw"
        Me.DataGridViewTextBoxColumn10.HeaderText = "pw"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "om"
        Me.DataGridViewTextBoxColumn11.HeaderText = "om"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "kb"
        Me.DataGridViewTextBoxColumn12.HeaderText = "kb"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ms"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ms"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "up"
        Me.DataGridViewTextBoxColumn14.HeaderText = "up"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'Status_dateBindingSource
        '
        Me.Status_dateBindingSource.DataMember = "status_date"
        Me.Status_dateBindingSource.DataSource = Me.ChristianDataSet
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "workstation_number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "workstation_number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "point_x"
        Me.DataGridViewTextBoxColumn2.HeaderText = "point_x"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "point_y"
        Me.DataGridViewTextBoxColumn3.HeaderText = "point_y"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "prod"
        Me.DataGridViewTextBoxColumn4.HeaderText = "prod"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'WorkstationsBindingSource
        '
        Me.WorkstationsBindingSource.DataMember = "workstations"
        Me.WorkstationsBindingSource.DataSource = Me.ChristianDataSet
        '
        'WorkstationsTableAdapter
        '
        Me.WorkstationsTableAdapter.ClearBeforeFill = True
        '
        'Status_dateTableAdapter
        '
        Me.Status_dateTableAdapter.ClearBeforeFill = True
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'BorderTableAdapter
        '
        Me.BorderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.borderTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.imageTableAdapter = Nothing
        Me.TableAdapterManager.logsTableAdapter = Nothing
        Me.TableAdapterManager.status_dateTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Christian.ChristianDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.workstationsTableAdapter = Nothing
        '
        'ImageTableAdapter
        '
        Me.ImageTableAdapter.ClearBeforeFill = True
        '
        'DataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 543)

        Me.Controls.Add(Me.ImageDataGridView)
        Me.Controls.Add(Me.BorderDataGridView)
        Me.Controls.Add(Me.StatusDataGridView)
        Me.Controls.Add(Me.Status_dateDataGridView)
        Me.Controls.Add(Me.WorkstationsDataGridView)
        Me.Controls.Add(Me.WorkstationsBindingNavigator)
        Me.Name = "DataForm"
        Me.Text = "DataForm"
        CType(Me.WorkstationsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkstationsBindingNavigator.ResumeLayout(False)
        Me.WorkstationsBindingNavigator.PerformLayout()
        CType(Me.WorkstationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Status_dateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageDataGridView, System.ComponentModel.ISupportInitialize).EndInit()

        CType(Me.ChristianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Status_dateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkstationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChristianDataSet As ChristianDataSet
    Friend WithEvents WorkstationsBindingSource As BindingSource
    Friend WithEvents WorkstationsTableAdapter As ChristianDataSetTableAdapters.workstationsTableAdapter
    Friend WithEvents TableAdapterManager As ChristianDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WorkstationsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents WorkstationsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Status_dateTableAdapter As ChristianDataSetTableAdapters.status_dateTableAdapter
    Friend WithEvents WorkstationsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Status_dateBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As ChristianDataSetTableAdapters.statusTableAdapter
    Friend WithEvents Status_dateDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents StatusDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents BorderBindingSource As BindingSource
    Friend WithEvents BorderTableAdapter As ChristianDataSetTableAdapters.borderTableAdapter
    Friend WithEvents BorderDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents ImageBindingSource As BindingSource
    Friend WithEvents ImageTableAdapter As ChristianDataSetTableAdapters.imageTableAdapter
    Friend WithEvents ImageDataGridView As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn

    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
End Class
