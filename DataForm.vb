Public Class DataForm
    Private Sub WorkstationsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WorkstationsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WorkstationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ChristianDataSet)

    End Sub

    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ChristianDataSet.replacements' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'ChristianDataSet.image' table. You can move, or remove it, as needed.
        Me.ImageTableAdapter.Fill(Me.ChristianDataSet.image)
        'TODO: This line of code loads data into the 'ChristianDataSet.sort_out' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'ChristianDataSet.border' table. You can move, or remove it, as needed.
        Me.BorderTableAdapter.Fill(Me.ChristianDataSet.border)
        'TODO: This line of code loads data into the 'ChristianDataSet.status' table. You can move, or remove it, as needed.
        Me.StatusTableAdapter.Fill(Me.ChristianDataSet.status)
        'TODO: This line of code loads data into the 'ChristianDataSet.status_date' table. You can move, or remove it, as needed.
        Me.Status_dateTableAdapter.Fill(Me.ChristianDataSet.status_date)
        'TODO: This line of code loads data into the 'ChristianDataSet.workstations' table. You can move, or remove it, as needed.
        Me.WorkstationsTableAdapter.Fill(Me.ChristianDataSet.workstations)

    End Sub
End Class