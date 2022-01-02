<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BatchAdd
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.distanceBox = New System.Windows.Forms.TextBox()
        Me.batchaddButton = New System.Windows.Forms.Button()
        Me.toTop = New System.Windows.Forms.RadioButton()
        Me.toLeft = New System.Windows.Forms.RadioButton()
        Me.toBottom = New System.Windows.Forms.RadioButton()
        Me.toRight = New System.Windows.Forms.RadioButton()
        Me.rangeLabel = New System.Windows.Forms.Label()
        Me.addTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.distanceBox)
        Me.GroupBox2.Controls.Add(Me.batchaddButton)
        Me.GroupBox2.Controls.Add(Me.toTop)
        Me.GroupBox2.Controls.Add(Me.toLeft)
        Me.GroupBox2.Controls.Add(Me.toBottom)
        Me.GroupBox2.Controls.Add(Me.toRight)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 130)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Direction"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Distance"
        '
        'distanceBox
        '
        Me.distanceBox.Location = New System.Drawing.Point(79, 23)
        Me.distanceBox.Name = "distanceBox"
        Me.distanceBox.Size = New System.Drawing.Size(114, 24)
        Me.distanceBox.TabIndex = 19
        '
        'batchaddButton
        '
        Me.batchaddButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.batchaddButton.Location = New System.Drawing.Point(79, 55)
        Me.batchaddButton.Name = "batchaddButton"
        Me.batchaddButton.Size = New System.Drawing.Size(114, 25)
        Me.batchaddButton.TabIndex = 7
        Me.batchaddButton.Text = "Batch Add"
        Me.batchaddButton.UseVisualStyleBackColor = False
        '
        'toTop
        '
        Me.toTop.AutoSize = True
        Me.toTop.Location = New System.Drawing.Point(215, 23)
        Me.toTop.Name = "toTop"
        Me.toTop.Size = New System.Drawing.Size(97, 20)
        Me.toTop.TabIndex = 14
        Me.toTop.TabStop = True
        Me.toTop.Text = "Here to top"
        Me.toTop.UseVisualStyleBackColor = True
        '
        'toLeft
        '
        Me.toLeft.AutoSize = True
        Me.toLeft.Location = New System.Drawing.Point(215, 77)
        Me.toLeft.Name = "toLeft"
        Me.toLeft.Size = New System.Drawing.Size(97, 20)
        Me.toLeft.TabIndex = 16
        Me.toLeft.TabStop = True
        Me.toLeft.Text = "Here to left"
        Me.toLeft.UseVisualStyleBackColor = True
        '
        'toBottom
        '
        Me.toBottom.AutoSize = True
        Me.toBottom.Location = New System.Drawing.Point(215, 50)
        Me.toBottom.Name = "toBottom"
        Me.toBottom.Size = New System.Drawing.Size(122, 20)
        Me.toBottom.TabIndex = 15
        Me.toBottom.TabStop = True
        Me.toBottom.Text = "Here to bottom"
        Me.toBottom.UseVisualStyleBackColor = True
        '
        'toRight
        '
        Me.toRight.AutoSize = True
        Me.toRight.Location = New System.Drawing.Point(215, 103)
        Me.toRight.Name = "toRight"
        Me.toRight.Size = New System.Drawing.Size(106, 20)
        Me.toRight.TabIndex = 17
        Me.toRight.TabStop = True
        Me.toRight.Text = "Here to right"
        Me.toRight.UseVisualStyleBackColor = True
        '
        'rangeLabel
        '
        Me.rangeLabel.AutoSize = True
        Me.rangeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.rangeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rangeLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.rangeLabel.Location = New System.Drawing.Point(172, 43)
        Me.rangeLabel.Name = "rangeLabel"
        Me.rangeLabel.Size = New System.Drawing.Size(76, 16)
        Me.rangeLabel.TabIndex = 14
        Me.rangeLabel.Text = "rangeLabel"
        '
        'addTotal
        '
        Me.addTotal.Location = New System.Drawing.Point(175, 13)
        Me.addTotal.Name = "addTotal"
        Me.addTotal.Size = New System.Drawing.Size(114, 24)
        Me.addTotal.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Number of workstations"
        '
        'BatchAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 199)
        Me.Controls.Add(Me.rangeLabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.addTotal)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BatchAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents batchaddButton As Button
    Friend WithEvents rangeLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents toRight As RadioButton
    Friend WithEvents toLeft As RadioButton
    Friend WithEvents toBottom As RadioButton
    Friend WithEvents toTop As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents distanceBox As TextBox
End Class
