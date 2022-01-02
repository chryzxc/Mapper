<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Swap
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.currentTerminal = New System.Windows.Forms.Label()
        Me.currentB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.currentDesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.swappedTerminal = New System.Windows.Forms.Label()
        Me.swappedB = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.swappedDesc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.statusBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.workstationBox = New System.Windows.Forms.ComboBox()
        Me.swapItems = New System.Windows.Forms.ComboBox()
        Me.currentStatus = New System.Windows.Forms.Label()
        Me.swappedStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.statusBox)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.workstationBox)
        Me.GroupBox2.Controls.Add(Me.swapItems)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(532, 285)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.currentStatus)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.currentTerminal)
        Me.GroupBox3.Controls.Add(Me.currentB)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.currentDesc)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 82)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(253, 162)
        Me.GroupBox3.TabIndex = 97
        Me.GroupBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "Terminal :"
        '
        'currentTerminal
        '
        Me.currentTerminal.AutoSize = True
        Me.currentTerminal.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentTerminal.Location = New System.Drawing.Point(90, 22)
        Me.currentTerminal.Name = "currentTerminal"
        Me.currentTerminal.Size = New System.Drawing.Size(60, 21)
        Me.currentTerminal.TabIndex = 77
        Me.currentTerminal.Text = "Label1"
        '
        'currentB
        '
        Me.currentB.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentB.Location = New System.Drawing.Point(90, 111)
        Me.currentB.Name = "currentB"
        Me.currentB.Size = New System.Drawing.Size(138, 24)
        Me.currentB.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Barcode :"
        '
        'currentDesc
        '
        Me.currentDesc.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentDesc.Location = New System.Drawing.Point(90, 78)
        Me.currentDesc.Name = "currentDesc"
        Me.currentDesc.Size = New System.Drawing.Size(138, 24)
        Me.currentDesc.TabIndex = 86
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Description :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Item :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.swappedStatus)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.swappedTerminal)
        Me.GroupBox1.Controls.Add(Me.swappedB)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.swappedDesc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(268, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 162)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Terminal :"
        '
        'swappedTerminal
        '
        Me.swappedTerminal.AutoSize = True
        Me.swappedTerminal.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swappedTerminal.Location = New System.Drawing.Point(90, 22)
        Me.swappedTerminal.Name = "swappedTerminal"
        Me.swappedTerminal.Size = New System.Drawing.Size(128, 21)
        Me.swappedTerminal.TabIndex = 77
        Me.swappedTerminal.Text = "Target terminal"
        '
        'swappedB
        '
        Me.swappedB.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swappedB.Location = New System.Drawing.Point(90, 111)
        Me.swappedB.Name = "swappedB"
        Me.swappedB.Size = New System.Drawing.Size(138, 24)
        Me.swappedB.TabIndex = 71
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 16)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Barcode :"
        '
        'swappedDesc
        '
        Me.swappedDesc.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swappedDesc.Location = New System.Drawing.Point(90, 78)
        Me.swappedDesc.Name = "swappedDesc"
        Me.swappedDesc.Size = New System.Drawing.Size(138, 24)
        Me.swappedDesc.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Description :"
        '
        'statusBox
        '
        Me.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statusBox.FormattingEnabled = True
        Me.statusBox.Items.AddRange(New Object() {"Swap (Temporary)", "Swap (Permanent)"})
        Me.statusBox.Location = New System.Drawing.Point(184, 52)
        Me.statusBox.Name = "statusBox"
        Me.statusBox.Size = New System.Drawing.Size(154, 24)
        Me.statusBox.TabIndex = 81
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(446, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 16)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Swap to :"
        '
        'workstationBox
        '
        Me.workstationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.workstationBox.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.workstationBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.workstationBox.FormattingEnabled = True
        Me.workstationBox.Location = New System.Drawing.Point(76, 52)
        Me.workstationBox.Name = "workstationBox"
        Me.workstationBox.Size = New System.Drawing.Size(102, 24)
        Me.workstationBox.TabIndex = 74
        '
        'swapItems
        '
        Me.swapItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.swapItems.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swapItems.ForeColor = System.Drawing.SystemColors.WindowText
        Me.swapItems.FormattingEnabled = True
        Me.swapItems.Items.AddRange(New Object() {"All", "System unit", "Motherboard", "Processor", "Memory", "Video card", "Hard disk", "Power supply", "Monitor", "Keyboard", "Mouse", "Ups"})
        Me.swapItems.Location = New System.Drawing.Point(76, 22)
        Me.swapItems.Name = "swapItems"
        Me.swapItems.Size = New System.Drawing.Size(138, 24)
        Me.swapItems.TabIndex = 68
        '
        'currentStatus
        '
        Me.currentStatus.AutoSize = True
        Me.currentStatus.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentStatus.Location = New System.Drawing.Point(91, 50)
        Me.currentStatus.Name = "currentStatus"
        Me.currentStatus.Size = New System.Drawing.Size(48, 16)
        Me.currentStatus.TabIndex = 90
        Me.currentStatus.Text = "Label1"
        '
        'swappedStatus
        '
        Me.swappedStatus.AutoSize = True
        Me.swappedStatus.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swappedStatus.Location = New System.Drawing.Point(91, 50)
        Me.swappedStatus.Name = "swappedStatus"
        Me.swappedStatus.Size = New System.Drawing.Size(0, 16)
        Me.swappedStatus.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Status :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Status :"
        '
        'Swap
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(556, 311)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Swap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Swap"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents workstationBox As ComboBox
    Friend WithEvents swapItems As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents currentTerminal As Label
    Friend WithEvents currentB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents currentDesc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents statusBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents swappedTerminal As Label
    Friend WithEvents swappedB As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents swappedDesc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents currentStatus As Label
    Friend WithEvents swappedStatus As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
End Class
