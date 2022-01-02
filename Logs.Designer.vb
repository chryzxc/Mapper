<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Logs
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
        Me.ReplacementsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChristianDataSet = New Christian.ChristianDataSet()
        Me.prodListBox = New System.Windows.Forms.ComboBox()
        Me.startDate = New System.Windows.Forms.DateTimePicker()
        Me.endDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchRecords = New System.Windows.Forms.Button()
        Me.recordsLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New Christian.ChristianDataSetTableAdapters.TableAdapterManager()
        Me.LogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogsTableAdapter = New Christian.ChristianDataSetTableAdapters.logsTableAdapter()
        Me.LogsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.statusListBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.ReplacementsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChristianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReplacementsBindingSource
        '
        Me.ReplacementsBindingSource.DataMember = "replacements"
        Me.ReplacementsBindingSource.DataSource = Me.ChristianDataSet
        '
        'ChristianDataSet
        '
        Me.ChristianDataSet.DataSetName = "ChristianDataSet"
        Me.ChristianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'prodListBox
        '
        Me.prodListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prodListBox.FormattingEnabled = True
        Me.prodListBox.Location = New System.Drawing.Point(94, 19)
        Me.prodListBox.Name = "prodListBox"
        Me.prodListBox.Size = New System.Drawing.Size(184, 24)
        Me.prodListBox.TabIndex = 2
        '
        'startDate
        '
        Me.startDate.CustomFormat = ""
        Me.startDate.Location = New System.Drawing.Point(442, 15)
        Me.startDate.Name = "startDate"
        Me.startDate.Size = New System.Drawing.Size(233, 23)
        Me.startDate.TabIndex = 3
        Me.startDate.Value = New Date(2021, 3, 3, 0, 0, 0, 0)
        '
        'endDate
        '
        Me.endDate.CustomFormat = "dddd,MMMM d,yyyy   hh:mm:ss tt"
        Me.endDate.Location = New System.Drawing.Point(725, 15)
        Me.endDate.Name = "endDate"
        Me.endDate.Size = New System.Drawing.Size(233, 23)
        Me.endDate.TabIndex = 4
        Me.endDate.Value = New Date(2031, 4, 29, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(393, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(694, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "To :"
        '
        'searchRecords
        '
        Me.searchRecords.Location = New System.Drawing.Point(772, 93)
        Me.searchRecords.Name = "searchRecords"
        Me.searchRecords.Size = New System.Drawing.Size(186, 29)
        Me.searchRecords.TabIndex = 7
        Me.searchRecords.Text = "Search"
        Me.searchRecords.UseVisualStyleBackColor = True
        '
        'recordsLabel
        '
        Me.recordsLabel.AutoSize = True
        Me.recordsLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recordsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.recordsLabel.Location = New System.Drawing.Point(15, 106)
        Me.recordsLabel.Name = "recordsLabel"
        Me.recordsLabel.Size = New System.Drawing.Size(23, 16)
        Me.recordsLabel.TabIndex = 8
        Me.recordsLabel.Text = "sss"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(492, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
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
        'LogsBindingSource
        '
        Me.LogsBindingSource.DataMember = "logs"
        Me.LogsBindingSource.DataSource = Me.ChristianDataSet
        '
        'LogsTableAdapter
        '
        Me.LogsTableAdapter.ClearBeforeFill = True
        '
        'LogsDataGridView
        '
        Me.LogsDataGridView.AutoGenerateColumns = False
        Me.LogsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LogsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.LogsDataGridView.DataSource = Me.LogsBindingSource
        Me.LogsDataGridView.Location = New System.Drawing.Point(12, 128)
        Me.LogsDataGridView.Name = "LogsDataGridView"
        Me.LogsDataGridView.ReadOnly = True
        Me.LogsDataGridView.Size = New System.Drawing.Size(946, 414)
        Me.LogsDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Workstation"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Workstation"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Prod"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Prod"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Item"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Barcode"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Barcode"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Note"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Production :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(393, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Time frame : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Status :"
        '
        'statusListBox
        '
        Me.statusListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statusListBox.FormattingEnabled = True
        Me.statusListBox.Items.AddRange(New Object() {"All", "Replaced", "Defective", "For upgrade", "Swap (Temporary)", "Swap (Permanent)"})
        Me.statusListBox.Location = New System.Drawing.Point(94, 57)
        Me.statusListBox.Name = "statusListBox"
        Me.statusListBox.Size = New System.Drawing.Size(184, 24)
        Me.statusListBox.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Tomato
        Me.Label6.Location = New System.Drawing.Point(393, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Label6"
        '
        'Logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 554)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.statusListBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LogsDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.recordsLabel)
        Me.Controls.Add(Me.searchRecords)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.endDate)
        Me.Controls.Add(Me.startDate)
        Me.Controls.Add(Me.prodListBox)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Logs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logs"
        CType(Me.ReplacementsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChristianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChristianDataSet As ChristianDataSet
    Friend WithEvents ReplacementsBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As ChristianDataSetTableAdapters.TableAdapterManager
    Friend WithEvents prodListBox As ComboBox
    Friend WithEvents startDate As DateTimePicker
    Friend WithEvents endDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents searchRecords As Button
    Friend WithEvents recordsLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LogsBindingSource As BindingSource
    Friend WithEvents LogsTableAdapter As ChristianDataSetTableAdapters.logsTableAdapter
    Friend WithEvents LogsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents statusListBox As ComboBox
    Friend WithEvents Label6 As Label
End Class
