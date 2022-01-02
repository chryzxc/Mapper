Public Class BorderRename

    Public origProd As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataForm.BorderTableAdapter.UpdateBorderName(TextBox1.Text, origProd)
        DataForm.BorderTableAdapter.Fill(DataForm.ChristianDataSet.border)

        DataForm.WorkstationsTableAdapter.UpdateProd(TextBox1.Text, origProd)
        DataForm.WorkstationsTableAdapter.Fill(DataForm.ChristianDataSet.workstations)

        WorkstationMain.renameLastProdName(TextBox1.Text)
        Me.Dispose()
    End Sub

    Private Sub BorderRename_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class