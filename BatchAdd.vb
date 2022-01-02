Public Class BatchAdd
    Dim total As Integer = 0
    Dim workstationString As String
    Public currentpoint_x As String
    Public currentpoint_y As String
    Public distance As Integer
    Dim sum As Double
    Dim wsCnt As Double




    Private Sub batchaddButton_Click(sender As Object, e As EventArgs) Handles batchaddButton.Click
        For Each WorkstationMain.previewTerminal In WorkstationMain.imageBox.Controls.OfType(Of Panel)().ToArray()
            WorkstationMain.previewTerminal.Dispose()
        Next
        If distanceBox.Text = "" Then
            distance = 35
            If toTop.Checked = True Then
                WorkstationMain.total = CInt(addTotal.Text)
                WorkstationMain.batchAddTerminal("top")
                Me.Dispose()
            End If

            If toBottom.Checked = True Then
                WorkstationMain.total = CInt(addTotal.Text)
                WorkstationMain.batchAddTerminal("bottom")
                Me.Dispose()
            End If

            If toLeft.Checked = True Then
                WorkstationMain.total = CInt(addTotal.Text)
                WorkstationMain.batchAddTerminal("left")
                Me.Dispose()
            End If

            If toRight.Checked = True Then
                WorkstationMain.total = CInt(addTotal.Text)
                WorkstationMain.batchAddTerminal("right")
                Me.Dispose()
            End If

        Else

            Int32.TryParse(distanceBox.Text, distance + 51)
            If toTop.Checked = True Then
                WorkstationMain.total = CInt(addTotal.Text)
                WorkstationMain.batchAddTerminal("top")
                Me.Dispose()
            End If

            If toBottom.Checked = True Then
                WorkstationMain.total = CInt(addTotal.Text)
                WorkstationMain.batchAddTerminal("bottom")
                Me.Dispose()
            End If

            If toLeft.Checked = True Then
                WorkstationMain.total = CInt(addTotal.Text)
                WorkstationMain.batchAddTerminal("left")
                Me.Dispose()
            End If

            If toRight.Checked = True Then
                WorkstationMain.total = CInt(addTotal.Text)
                WorkstationMain.batchAddTerminal("right")
                Me.Dispose()
            End If

        End If


    End Sub





    Private Sub distanceBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles distanceBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub addTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles addTotal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub addTotal_TextChanged(sender As Object, e As EventArgs) Handles addTotal.TextChanged
        Int32.TryParse(addTotal.Text, total)
        wsCnt = WorkstationMain.terminalNum - 1
        sum = wsCnt + total
        rangeLabel.Text = "Terminal " + wsCnt.ToString + " to " + sum.ToString
        preview()
    End Sub

    Private Sub BatchAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wsCnt = WorkstationMain.terminalNum - 1
        rangeLabel.Text = "Terminal " + wsCnt.ToString
    End Sub

    Private Sub toTop_CheckedChanged(sender As Object, e As EventArgs) Handles toTop.CheckedChanged
        preview()
    End Sub

    Public Sub preview()


        If addTotal.Text <> "" Then

            For Each WorkstationMain.previewTerminal In WorkstationMain.imageBox.Controls.OfType(Of Panel)().ToArray()
                WorkstationMain.previewTerminal.Dispose()
            Next


            Int32.TryParse(distanceBox.Text, distance)

            distance += 35
            If distanceBox.Text = "" Then
                distance = 35
                If toTop.Checked = True Then
                    WorkstationMain.total = CInt(addTotal.Text)
                    WorkstationMain.batchPreviewTerminal("top")
                End If

                If toBottom.Checked = True Then
                    WorkstationMain.total = CInt(addTotal.Text)
                    WorkstationMain.batchPreviewTerminal("bottom")
                End If

                If toLeft.Checked = True Then
                    WorkstationMain.total = CInt(addTotal.Text)
                    WorkstationMain.batchPreviewTerminal("left")
                End If

                If toRight.Checked = True Then
                    WorkstationMain.total = CInt(addTotal.Text)
                    WorkstationMain.batchPreviewTerminal("right")
                End If

            Else
                Int32.TryParse(distanceBox.Text, distance + 51)

                If toTop.Checked = True Then
                    WorkstationMain.total = CInt(addTotal.Text)
                    WorkstationMain.batchPreviewTerminal("top")
                End If

                If toBottom.Checked = True Then
                    WorkstationMain.total = CInt(addTotal.Text)
                    WorkstationMain.batchPreviewTerminal("bottom")
                End If

                If toLeft.Checked = True Then
                    WorkstationMain.total = CInt(addTotal.Text)
                    WorkstationMain.batchPreviewTerminal("left")
                End If

                If toRight.Checked = True Then
                    WorkstationMain.total = CInt(addTotal.Text)
                    WorkstationMain.batchPreviewTerminal("right")
                End If
            End If

        End If




    End Sub

    Private Sub toBottom_CheckedChanged(sender As Object, e As EventArgs) Handles toBottom.CheckedChanged
        preview()
    End Sub

    Private Sub toLeft_CheckedChanged(sender As Object, e As EventArgs) Handles toLeft.CheckedChanged
        preview()
    End Sub

    Private Sub toRight_CheckedChanged(sender As Object, e As EventArgs) Handles toRight.CheckedChanged
        preview()
    End Sub

    Private Sub distanceBox_TextChanged(sender As Object, e As EventArgs) Handles distanceBox.TextChanged
        preview()
    End Sub


    Private Sub BatchAdd_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate

        'Me.Dispose()
    End Sub

    Private Sub BatchAdd_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        For Each WorkstationMain.previewTerminal In WorkstationMain.imageBox.Controls.OfType(Of Panel)().ToArray()
            WorkstationMain.previewTerminal.Dispose()
        Next
    End Sub
End Class