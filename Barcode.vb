Public Class Barcode
    Public isDefective As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Info.def(bcode.Text, desc.Text, note.Text)
        Me.Dispose()

    End Sub



    Private Sub Barcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Barcode_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Info.returnLast()
    End Sub
End Class