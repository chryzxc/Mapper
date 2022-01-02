Public Class BorderAdd
    Dim num As Integer
    Dim borderNames As ArrayList
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Label2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        borderNames = New ArrayList
        num = 0

        If TextBox1.Text = "" Then

            Label2.Text = "Name is empty"
        Else

            If DataForm.BorderTableAdapter.ScalarQuery() <> 0 Then
                For rowNum = 1 To DataForm.BorderTableAdapter.ScalarQuery()



                    borderNames.Add(DataForm.BorderDataGridView.Rows(num).Cells(0).Value).ToString()
                    num += 1

                Next


            End If

            If borderNames.Contains(TextBox1.Text) Then
                Label2.Text = "Name already exist"
            Else

                WorkstationMain.addBorder(TextBox1.Text)
                Me.Dispose()



            End If


        End If

    End Sub

    Private Sub BorderAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = ""
    End Sub
End Class