Public Class Swap
    Public tNumber As String
    Dim defUnits As ArrayList

    Private Sub Swap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        swapItems.SelectedIndex = 0
        statusBox.SelectedIndex = 0

        Dim num As Integer = 0
        If DataForm.WorkstationsTableAdapter.ScalarQuery() <> 0 Then
            For rowNum = 1 To DataForm.WorkstationsTableAdapter.ScalarQuery()

                If DataForm.WorkstationsDataGridView.Rows(num).Cells(0).Value <> Convert.ToInt32(currentTerminal.Text) Then

                    workstationBox.Items.Add(DataForm.WorkstationsDataGridView.Rows(num).Cells(0).Value)

                End If

                num += 1

            Next
        End If
    End Sub

    Private Sub workstationBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles workstationBox.SelectedIndexChanged
        swappedTerminal.Text = workstationBox.SelectedItem

        defUnits = New ArrayList

        defUnits.Add(DataForm.StatusDataGridView.Rows(Convert.ToInt32(swappedTerminal.Text) - 1).Cells(1).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(Convert.ToInt32(swappedTerminal.Text) - 1).Cells(2).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(Convert.ToInt32(swappedTerminal.Text) - 1).Cells(3).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(Convert.ToInt32(swappedTerminal.Text) - 1).Cells(4).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(Convert.ToInt32(swappedTerminal.Text) - 1).Cells(5).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(Convert.ToInt32(swappedTerminal.Text) - 1).Cells(6).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(Convert.ToInt32(swappedTerminal.Text) - 1).Cells(7).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(Convert.ToInt32(swappedTerminal.Text) - 1).Cells(8).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(Convert.ToInt32(swappedTerminal.Text) - 1).Cells(9).Value)
        If defUnits.Contains("DEFECTIVE") Then

            swappedStatus.Text = "Defective"


            swappedStatus.BackColor = Color.LightCoral


        Else
            swappedStatus.Text = "Working"
            swappedStatus.BackColor = Color.LightGreen

        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If swappedTerminal.Text <> "Target terminal" Then
            Logs.LogsTableAdapter.Insert(currentTerminal.Text, DataForm.WorkstationsTableAdapter.getProd(currentTerminal.Text), statusBox.SelectedItem.ToString, swapItems.SelectedItem.ToString, currentDesc.Text, currentB.Text, statusBox.SelectedItem.ToString + " to workstation " + swappedTerminal.Text, DateAndTime.Now)

            Logs.LogsTableAdapter.Insert(swappedTerminal.Text, DataForm.WorkstationsTableAdapter.getProd(swappedTerminal.Text), statusBox.SelectedItem.ToString, swapItems.SelectedItem.ToString, swappedDesc.Text, swappedB.Text, statusBox.SelectedItem.ToString + " to workstation " + currentTerminal.Text, DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)
            Me.Close()
        End If


    End Sub
End Class