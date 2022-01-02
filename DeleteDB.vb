Public Class DeleteDB
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataForm.WorkstationsTableAdapter.DeleteAll()
        DataForm.StatusTableAdapter.DeleteAll()
        DataForm.Status_dateTableAdapter.DeleteAll()
        DataForm.ImageTableAdapter.DeleteImage()
        DataForm.BorderTableAdapter.DeleteAll()
        Logs.LogsTableAdapter.DeleteAll()

        WorkstationMain.WorkstationMain_Load(e, e)
        Me.Dispose()
    End Sub
End Class