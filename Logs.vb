Public Class Logs

    Dim num As Integer
    Private Sub Replacements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ChristianDataSet.logs' table. You can move, or remove it, as needed.
        Me.LogsTableAdapter.Fill(Me.ChristianDataSet.logs)
        Label6.Text = ""


        'TODO: This line of code loads data into the 'ChristianDataSet.replacements' table. You can move, or remove it, as needed.

        recordsLabel.Text = ""
        prodListAdd()
        Label3.Text = startDate.Value.ToString + "     to     " + endDate.Value.ToString
        statusListBox.SelectedIndex = 0

    End Sub

    Public Sub prodListAdd()
        prodListBox.Items.Clear()
        prodListBox.Items.Add("All")
        prodListBox.SelectedIndex = 0
        num = 0


        If DataForm.BorderTableAdapter.ScalarQuery() <> 0 Then
            For rowNum = 1 To DataForm.BorderTableAdapter.ScalarQuery()


                prodListBox.SelectedIndex = prodListBox.FindStringExact("All")
                prodListBox.Items.Add(DataForm.BorderDataGridView.Rows(num).Cells(0).Value).ToString()

                num += 1

            Next


        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles searchRecords.Click
        Label6.Text = ""
        Label3.Text = startDate.Value.ToString + "     to     " + endDate.Value.ToString

        If prodListBox.SelectedItem = "All" And statusListBox.SelectedItem = "All" Then
            LogsTableAdapter.FillByDate(Me.ChristianDataSet.logs, startDate.Value, endDate.Value)
            recordsLabel.Text = "Found (" + LogsTableAdapter.ScalarQueryDate(startDate.Value, endDate.Value).ToString + ") record(s)"

        ElseIf prodListBox.SelectedItem = "All" And statusListBox.SelectedItem <> "All" Then
            LogsTableAdapter.FillByStatus(Me.ChristianDataSet.logs, startDate.Value, endDate.Value, statusListBox.SelectedItem.ToString)
            recordsLabel.Text = "Found (" + LogsTableAdapter.ScalarQueryStatus(startDate.Value, endDate.Value, statusListBox.SelectedItem).ToString + ") " + statusListBox.SelectedItem + " items"

        ElseIf prodListBox.SelectedItem <> "All" And statusListBox.SelectedItem = "All" Then
            LogsTableAdapter.FillByProd(Me.ChristianDataSet.logs, startDate.Value, endDate.Value, prodListBox.SelectedItem.ToString)
            recordsLabel.Text = "Found (" + LogsTableAdapter.ScalarQueryProd(startDate.Value, endDate.Value, prodListBox.SelectedItem).ToString + ") record(s)"

        ElseIf prodListBox.SelectedItem <> "All" And statusListBox.SelectedItem <> "All" Then
            LogsTableAdapter.FillByProdStatus(Me.ChristianDataSet.logs, startDate.Value, endDate.Value, statusListBox.SelectedItem.ToString, prodListBox.SelectedItem.ToString)
            recordsLabel.Text = "Found (" + LogsTableAdapter.ScalarQueryProdStatus(startDate.Value, endDate.Value, statusListBox.SelectedItem.ToString, prodListBox.SelectedItem).ToString + ") record(s)"
        End If

    End Sub

    Private Sub startDate_ValueChanged(sender As Object, e As EventArgs) Handles startDate.ValueChanged
        Label3.Text = startDate.Value.ToString + "     to     " + endDate.Value.ToString

    End Sub

    Private Sub endDate_ValueChanged(sender As Object, e As EventArgs) Handles endDate.ValueChanged
        Label3.Text = startDate.Value.ToString + "     to     " + endDate.Value.ToString

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub LogsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LogsDataGridView.CellClick
        '  Label6.Text = LogsDataGridView.Item(e.ColumnIndex, e.RowIndex).Value.ToString()
    End Sub
End Class