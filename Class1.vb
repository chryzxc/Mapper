Public Class ResizeableControl
    Dim borderName As String

    Private WithEvents mControl As Control
    Private mMouseDown As Boolean = False
    Private mEdge As EdgeEnum = EdgeEnum.None
    Private mWidth As Integer = 4
    Private mOutlineDrawn As Boolean = False
    Public resizeRestrict As Boolean = False

    Private Enum EdgeEnum
        None
        Right
        Left
        Top
        Bottom
        TopLeft
    End Enum

    Public Sub New(ByVal Control As Control)
        mControl = Control
    End Sub

    Public Sub updateDB(topVal As Object, leftVal As Object, heightVal As Object, widthVal As Object, bordName As String)

        DataForm.BorderTableAdapter.UpdateBorder(leftVal, topVal, heightVal, widthVal, bordName)
        DataForm.BorderTableAdapter.Fill(DataForm.ChristianDataSet.border)
        ' WorkstationMain.sortProd.SelectedIndex = WorkstationMain.sortProd.FindStringExact(bordName)
        WorkstationMain.sortProd.SelectedIndex = WorkstationMain.sortProd.FindStringExact("All")
        WorkstationMain.totalDefective.Text = WorkstationMain.tDef
        WorkstationMain.totalWorking.Text = WorkstationMain.tWor
        WorkstationMain.totalLabel.Text = WorkstationMain.tLabel
    End Sub



    Private Sub mControl_MouseDown(ByVal sender As Object,
        ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles mControl.MouseDown

        resizeRestrict = True

        WorkstationMain.panStartPoint = New Point(e.X, e.Y)

        borderName = sender.Text


        updateDB(sender.top, sender.left, sender.Height, sender.Width, borderName)


        If e.Button = Windows.Forms.MouseButtons.Left Then
            mMouseDown = True
        End If
    End Sub

    Public Sub mControl_MouseUp(ByVal sender As Object,
        ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles mControl.MouseUp





        DataForm.BorderTableAdapter.UpdateBorder(sender.left, sender.top, sender.Height, sender.Width, borderName)
        DataForm.BorderTableAdapter.Fill(DataForm.ChristianDataSet.border)

        DataForm.WorkstationsTableAdapter.UpdateProd("None", sender.Text)
        DataForm.WorkstationsTableAdapter.Fill(DataForm.ChristianDataSet.workstations)


        For Each WorkstationMain.terminalPoint In WorkstationMain.imageBox.Controls.OfType(Of Button)().ToArray()



            If sender.Bounds.IntersectsWith(WorkstationMain.terminalPoint.Bounds) Then


                ' WorkstationMain.sortProd.Items.Add(WorkstationMain.terminalPoint.Text)

                DataForm.WorkstationsTableAdapter.UpdateProdBorder(sender.Text, WorkstationMain.terminalPoint.Text)
                DataForm.WorkstationsTableAdapter.Fill(DataForm.ChristianDataSet.workstations)

                '  WorkstationMain.sortByProd(sender.Text)
            Else

            End If

        Next

        mMouseDown = False



        resizeRestrict = False



    End Sub

    Private Sub mControl_MouseMove(ByVal sender As Object,
    ByVal e As System.Windows.Forms.MouseEventArgs) _
    Handles mControl.MouseMove







        If WorkstationMain.lockSub.Checked = False Then



            Dim c As Control = CType(sender, Control)
            Dim g As Graphics = c.CreateGraphics
            Select Case mEdge
                Case EdgeEnum.TopLeft
                    g.FillRectangle(Brushes.Fuchsia,
            0, 0, mWidth * 4, mWidth * 4)
                    mOutlineDrawn = True
                Case EdgeEnum.Left
                    g.FillRectangle(Brushes.Fuchsia,
            0, 0, mWidth, c.Height)
                    mOutlineDrawn = True
                Case EdgeEnum.Right
                    g.FillRectangle(Brushes.Fuchsia,
            c.Width - mWidth, 0, c.Width, c.Height)
                    mOutlineDrawn = True
                Case EdgeEnum.Top
                    g.FillRectangle(Brushes.Fuchsia,
            0, 0, c.Width, mWidth)
                    mOutlineDrawn = True
                Case EdgeEnum.Bottom
                    g.FillRectangle(Brushes.Fuchsia,
            0, c.Height - mWidth, c.Width, mWidth)
                    mOutlineDrawn = True
                Case EdgeEnum.None
                    If mOutlineDrawn Then
                        ' c.Refresh()
                        c.Invalidate()
                        c.Update()
                        mOutlineDrawn = False
                    End If


            End Select



            If mMouseDown And mEdge <> EdgeEnum.None Then
                c.SuspendLayout()
                Select Case mEdge
                    Case EdgeEnum.TopLeft
                        c.SetBounds(c.Left + e.X, c.Top + e.Y,
            c.Width, c.Height)
                    Case EdgeEnum.Left
                        c.SetBounds(c.Left + e.X, c.Top,
            c.Width - e.X, c.Height)
                    Case EdgeEnum.Right
                        c.SetBounds(c.Left, c.Top,
            c.Width - (c.Width - e.X), c.Height)
                    Case EdgeEnum.Top
                        c.SetBounds(c.Left, c.Top + e.Y,
            c.Width, c.Height - e.Y)
                    Case EdgeEnum.Bottom
                        c.SetBounds(c.Left, c.Top,
            c.Width, c.Height - (c.Height - e.Y))


                End Select
                c.ResumeLayout()




            Else
                Select Case True





                    Case e.X <= (mWidth * 4) And
            e.Y <= (mWidth * 4) 'top left corner

                        If resizeRestrict = False Then
                            c.Cursor = Cursors.SizeAll
                            mEdge = EdgeEnum.TopLeft
                        End If
                    Case e.X <= mWidth 'left edge
                        If resizeRestrict = False Then
                            c.Cursor = Cursors.VSplit
                            mEdge = EdgeEnum.Left
                        End If
                    Case e.X > c.Width - (mWidth + 1) 'right edge
                        If resizeRestrict = False Then
                            c.Cursor = Cursors.VSplit
                            mEdge = EdgeEnum.Right
                        End If
                    Case e.Y <= mWidth 'top edge
                        If resizeRestrict = False Then
                            c.Cursor = Cursors.HSplit
                            mEdge = EdgeEnum.Top
                        End If
                    Case e.Y > c.Height - (mWidth + 1) 'bottom edge
                        If resizeRestrict = False Then
                            c.Cursor = Cursors.HSplit
                            mEdge = EdgeEnum.Bottom
                        End If
                    Case Else 'no edge
                        If resizeRestrict = False Then
                            c.Cursor = Cursors.Default
                            mEdge = EdgeEnum.None
                        End If

                        If e.Button = Windows.Forms.MouseButtons.Left Then



                            Dim DeltaX As Integer = (WorkstationMain.panStartPoint.X - e.X)
                            Dim DeltaY As Integer = (WorkstationMain.panStartPoint.Y - e.Y)


                            WorkstationMain.Panel1.AutoScrollPosition =
                    New Drawing.Point((DeltaX - WorkstationMain.Panel1.AutoScrollPosition.X),
                                    (DeltaY - WorkstationMain.Panel1.AutoScrollPosition.Y))

                            WorkstationMain.Invalidate()
                            WorkstationMain.Update()

                            resizeRestrict = True


                        End If




                End Select
            End If
        Else

            If e.Button = Windows.Forms.MouseButtons.Left Then



                Dim DeltaX As Integer = (WorkstationMain.panStartPoint.X - e.X)
                Dim DeltaY As Integer = (WorkstationMain.panStartPoint.Y - e.Y)


                WorkstationMain.Panel1.AutoScrollPosition =
        New Drawing.Point((DeltaX - WorkstationMain.Panel1.AutoScrollPosition.X),
                        (DeltaY - WorkstationMain.Panel1.AutoScrollPosition.Y))

                WorkstationMain.Invalidate()
                WorkstationMain.Update()

                resizeRestrict = True


            End If

        End If


    End Sub

    Private Sub mControl_MouseLeave(ByVal sender As Object,
        ByVal e As System.EventArgs) _
        Handles mControl.MouseLeave

        Dim c As Control = CType(sender, Control)
        mEdge = EdgeEnum.None
        ' c.Refresh()
        c.Invalidate()
        c.Update()
    End Sub

End Class
