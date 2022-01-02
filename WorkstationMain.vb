Public Class WorkstationMain
    Public terminalPoint As Button
    Public borderPoint As GroupBox
    Dim bpoint_x As String
    Dim bpoint_y As String

    Dim point_x As String
    Dim point_y As String
    Dim ppoint_x As String
    Dim ppoint_y As String
    Dim rc As ResizeableControl
    Dim coordinates As New Point
    Dim prodBorder As New Panel
    Dim addPoint As PictureBox
    Public previewTerminal As Panel

    Dim distance As Integer
    Public total As Integer
    Dim deleteIsOn As Boolean = False
    Dim mark As Object
    Public terminalNum As Integer = 1
    Dim background As Image

    Private _originalSize As Size = Nothing
    Private _scale As Single = 1
    Private _scaleDelta As Single = 0.0005

    Public background_x As Integer
    Public background_y As Integer

    Public terminalwidth As String = 35
    Public terminalheight As String = 22

    Public terminalCnt As Integer = 0
    Dim counter As Integer = 0
    Dim statusTimerCnt As Integer = 0
    Dim currentColor As Color
    Dim X As Integer = 0
    Dim Y As Integer = 0
    Dim num, num1, bnum As Integer


    Dim defUnits As ArrayList
    Dim workingUnits As ArrayList
    Dim totalDefNum As String = 0
    Dim totalWorkingNum As String = 0

    Dim totalMoD As Integer
    Dim totalMoW As Integer

    Dim totalPpD As Integer
    Dim totalPpW As Integer

    Dim totalMmD As Integer
    Dim totalMmW As Integer

    Dim totalDmD As Integer
    Dim totalDmW As Integer

    Dim totalHdD As Integer
    Dim totalHdW As Integer

    Dim totalPwD As Integer
    Dim totalPwW As Integer

    Dim totalOmD As Integer
    Dim totalOmW As Integer

    Dim totalKbD As Integer
    Dim totalKbW As Integer

    Dim totalMsD As Integer
    Dim totalMsW As Integer

    Dim totalUpD As Integer
    Dim totalUpW As Integer



    Dim prodNumber As String = "None"
    Dim wNumber As String

    Dim lastProdName As String = ""
    Public panStartPoint As New Point

    Dim rs As New Resizer

    Dim toSort As Boolean

    Public tDef As String
    Public tWor As String
    Public tLabel As String







    Private Sub WorkstationMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        '  Dim coordinatesPositon As String
        showDetailedReport(False)

        If e.Button = Windows.Forms.MouseButtons.Left Then

            If borderSub.Checked = True Then

            Else
                For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
                    borderPoint.Hide()

                Next
            End If

            If lockSub.Checked = False Then
                coordinates.Y = MousePosition.Y - sender.top
                coordinates.X = MousePosition.X - sender.left

            End If



        End If



        If e.Button = Windows.Forms.MouseButtons.Right Then
                workstationPopBox.Hide()
                AddMenuItem.Visible = False
                DeleteMenuItem.Visible = False
                sender.Select()



                point_x = sender.Location.X
                point_y = sender.Location.Y

                BatchAdd.currentpoint_x = sender.Location.X
                BatchAdd.currentpoint_y = sender.Location.Y

                mark = sender
                If sender.BackColor = Color.LightCoral Then
                    Swap.currentStatus.Text = "Defective"
                    Swap.currentStatus.BackColor = Color.LightCoral
                ElseIf sender.BackColor = Color.LightGreen Then
                    Swap.currentStatus.Text = "Working"
                    Swap.currentStatus.BackColor = Color.LightGreen
                End If

                If sender.Text = DataForm.WorkstationsTableAdapter.ScalarQuery() Then
                    AddMenuItem.Visible = True
                    DeleteMenuItem.Visible = True
                End If
            End If



    End Sub
    Public Sub borderControl()









        If terminalPoint.Location.Y + terminalPoint.Height >= imageBox.Location.Y And
           terminalPoint.Location.Y() + terminalPoint.Height() <= imageBox.Location.Y + imageBox.Height() And
           terminalPoint.Location.X + terminalPoint.Width >= imageBox.Location.X And
             terminalPoint.Location.X() + terminalPoint.Width() <= imageBox.Location.X + imageBox.Width() Then






        Else





        End If
    End Sub
    Private Sub WorkstationMouseLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        '  formStatus.Text = "mLeave"
        ' moveTerminal = False
    End Sub
    Private Sub WorkstationMouseHover(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        '  formStatus.Text = "mInsde"
        '  moveTerminal = True
    End Sub

    Private Sub WorkstationMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        'borderControl()



        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Invalidate()
            Me.Update()

            If lockSub.Checked = False Then

                sender.BringToFront()
                sender.top = MousePosition.Y - coordinates.Y
                sender.left = MousePosition.X - coordinates.X


                For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
                    borderPoint.Show()
                    borderSub.Checked = True
                Next

                prodNumber = "None"
                If TypeOf sender Is Button Then

                    Dim terminalpoint As Button = DirectCast(sender, Button)

                    wNumber = sender.Text




                    For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()

                        If terminalpoint.Bounds.IntersectsWith(borderPoint.Bounds) Then
                            borderPoint.BackColor = Color.FromArgb(20, Color.Blue)
                            prodNumber = borderPoint.Text
                            sortByProd(borderPoint.Text)
                            ' sortProd.SelectedIndex = sortProd.FindStringExact(borderPoint.Text)


                        Else
                            borderPoint.BackColor = Color.FromArgb(20, Color.Transparent)

                            '  sortProd.SelectedIndex = sortProd.FindStringExact("All")
                        End If




                    Next


                End If
            End If



        End If


    End Sub

    Private Sub WorkstationMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ' BTN.BackColor = Color.Red
        'DataForm.WorkstationsTableAdapter.Insert(sender.Text, sender.left, sender.top)
        ' DataForm.WorkstationsTableAdapter.Insert(terminalNum, point_x, point_y)
        'Dim testx As String = sender.left
        ' Dim testy As String = sender.top
        'formStatus.Text = "doen pointx =" + testx + "pointy= " + testy + sender.Text

        '  For Each borderPoint In PictureBox1.Controls.OfType(Of GroupBox)().ToArray()
        '   borderPoint.BackColor = Color.Transparent
        '  Next

        terminalPoint.BringToFront()

            If e.Button = Windows.Forms.MouseButtons.Left Then
                If lockSub.Checked = False Then
                    sender.top = MousePosition.Y - coordinates.Y
                    sender.left = MousePosition.X - coordinates.X

                    Dim workstationNumber As String
                    workstationNumber = sender.Text

                    prodNumber = "None"
                    If imageBox.Controls.Contains(borderPoint) Then








                        For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()

                            If sender.Bounds.IntersectsWith(borderPoint.Bounds) Then
                                borderPoint.BackColor = Color.FromArgb(20, Color.Blue)
                                prodNumber = borderPoint.Text
                            sortByProd(borderPoint.Text)
                            DataForm.WorkstationsTableAdapter.UpdateWorkstation(sender.left, sender.top, prodNumber, workstationNumber)
                                DataForm.WorkstationsTableAdapter.Fill(DataForm.ChristianDataSet.workstations)



                            Else

                                borderPoint.BackColor = Color.FromArgb(20, Color.Transparent)
                                DataForm.WorkstationsTableAdapter.UpdateWorkstation(sender.left, sender.top, prodNumber, workstationNumber)
                                DataForm.WorkstationsTableAdapter.Fill(DataForm.ChristianDataSet.workstations)


                            End If




                        Next






                    Else
                        DataForm.WorkstationsTableAdapter.UpdateWorkstation(sender.left, sender.top, prodNumber, workstationNumber)
                        DataForm.WorkstationsTableAdapter.Fill(DataForm.ChristianDataSet.workstations)

                    End If







                End If
            End If







    End Sub


    Private Sub WorkstationClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        '  coordinates.Y = MousePosition.Y - sender.top
        '  coordinates.X = MousePosition.X - sender.left

        '   For Each borderPoint In PictureBox1.Controls.OfType(Of GroupBox)().ToArray()
        '   borderPoint.Hide()
        '  Next
        '  For Each terminalPoint In PictureBox1.Controls.OfType(Of Button)().ToArray()
        '  If terminalPoint.Text = 1 Then
        ' highlightTimer.Interval = 1000
        ' Dim rect As Rectangle
        ' Dim gr As Graphics = Me.CreateGraphics.FromImage(PictureBox1.Image)
        ' currentColor = terminalPoint.BackColor
        'terminalPoint.BackColor = Color.Brown
        'highlightTimer.Start()

        'rect = terminalPoint.Bounds
        'rect.Inflate(1, 1)
        'ControlPaint.DrawBorder(gr, terminalPoint.Bounds, Color.Red, ButtonBorderStyle.Solid)
        ' Dim rec As Rectangle = terminalPoint.Bounds
        'Dim myPen As Pen
        'myPen = New Pen(Drawing.Color.Transparent, 2)
        'gr.DrawRectangle(myPen, rec)
        'ictureBox1.Refresh()
        'End If

        ' Next



        If e.Button = Windows.Forms.MouseButtons.Left Then

           
                For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
                    borderPoint.Show()
                    borderSub.Checked = True
                Next


            If sender.BackColor = Color.LightCoral Then

                ''  coordinates.Y = MousePosition.Y - sender.top
                '  coordinates.X = MousePosition.X - sender.left


                workstationPopBox.Show()
                details.Text = ""
                workstationPopBox.Height = 14
                workstationPopBox.Width = 14
                imageBox.Controls.Add(workstationPopBox)
                workstationPopBox.Left = sender.Location.X + 40
                workstationPopBox.Top = sender.Location.Y
                workstationPopBox.BringToFront()




                Dim arrayDetails As ArrayList = New ArrayList
                Dim itemsArray As ArrayList = New ArrayList

                itemsArray.Add("None")
                itemsArray.Add("Motherboard")
                itemsArray.Add("Memory")
                itemsArray.Add("Video card")
                itemsArray.Add("Hard disk")
                itemsArray.Add("Power supply")
                itemsArray.Add("Monitor")
                itemsArray.Add("Keyboard")
                itemsArray.Add("Mouse")
                itemsArray.Add("Ups")


                Dim fetch As String = ""
                Dim terminalRow As Integer = Convert.ToInt32(sender.Text) - 1
                Dim valNum1 As Integer = 1
                Dim valNum2 As Integer = 0

                '  infoNumber.Text = "Workstation : " + sender.Text

                For rowNum = 1 To 9

                    fetch = DataForm.StatusDataGridView.Rows(terminalRow).Cells(valNum1).Value

                    If fetch = "DEFECTIVE" Then


                        arrayDetails.Add(itemsArray(rowNum) + " : " + fetch.ToString + " - " + DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(rowNum).Value)

                    End If
                    valNum1 += 1


                Next

                For num = 1 To arrayDetails.Count

                    details.Text += arrayDetails(valNum2).ToString + vbCrLf
                    valNum2 += 1
                Next
            Else
                workstationPopBox.Hide()
            End If
        End If



        If TypeOf sender Is Button Then
            '  Info.Show()


            sender.Select()

            point_x = sender.Location.X
            point_y = sender.Location.Y

            BatchAdd.currentpoint_x = sender.Location.X
            BatchAdd.currentpoint_y = sender.Location.Y

            mark = sender


        End If




    End Sub

    Private Sub WorkstationDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        'Me.TableAdapterManager1.UpdateAll(Me.ChristianDataSet1)

        If TypeOf sender Is Button Then
            ' Info.Show()


            mark = sender









        End If


    End Sub
    Private Sub statsPanelMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        '  Dim coordinatesPositon As String


        coordinates.Y = MousePosition.Y - sender.top
        coordinates.X = MousePosition.X - sender.left




    End Sub
    Private Sub statsPanelMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then

            sender.left = MousePosition.X - coordinates.X
            sender.top = MousePosition.Y - coordinates.Y
            Me.Invalidate()
            Me.Update()



        End If


    End Sub

    Private Sub statsPanelMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ' BTN.BackColor = Color.Red
    End Sub







    Private Sub borderPanelMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim coordinatesPositon As String
        showDetailedReport(False)

        '  panStartPoint = New Point(e.X, e.Y)

        '  coordinates.Y = MousePosition.Y - sender.top
        '  coordinates.X = MousePosition.X - sender.left

        For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
            borderPoint.Show()
        Next

        If e.Button = Windows.Forms.MouseButtons.Right Then


            mark = sender.Text







        End If

    End Sub
    Private Sub borderPanelMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        '     If e.Button = Windows.Forms.MouseButtons.Left Then

        '        sender.left = MousePosition.X - coordinates.X
        '        sender.top = MousePosition.Y - coordinates.Y


        '   End If


        If e.Button = Windows.Forms.MouseButtons.Left Then



                Dim DeltaX As Integer = (panStartPoint.X - e.X)
                Dim DeltaY As Integer = (panStartPoint.Y - e.Y)


                Panel1.AutoScrollPosition =
                    New Drawing.Point((DeltaX - Panel1.AutoScrollPosition.X),
                                    (DeltaY - Panel1.AutoScrollPosition.Y))

                Me.Invalidate()
                Me.Update()



            End If




    End Sub
    Private Sub borderPanelClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)



        '    For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
        '   borderPoint.Show()
        '    borderSub.Checked = True
        '       borderPoint.BackColor = Color.FromArgb(50, Color.Transparent)

        '   Next
        '   sortByProd(sortProd.SelectedItem.ToString)
        '   higlightBorder()





    End Sub

    Private Sub borderPanelDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)




        If TypeOf sender Is GroupBox Then
            For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
                borderPoint.Hide()
                borderSub.Checked = False


            Next




        End If


    End Sub
    Private Sub borderPanelMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ' BTN.BackColor = Color.Red
    End Sub


    Public Sub batchAddTerminal(direction As String)

        BatchAdd.Show()
        BatchAdd.BringToFront()


        For a = 1 To total
            terminalPoint = New Button


            If direction = "right" Then
                Int32.TryParse(BatchAdd.distance, distance)
                terminalPoint.Location = New Point(point_x + distance,
            point_y)
                point_x = point_x + distance
                point_y = point_y
            End If

            If direction = "left" Then
                Int32.TryParse(BatchAdd.distance, distance)
                distance = distance - distance - distance
                terminalPoint.Location = New Point(point_x + distance,
            point_y)
                point_x = point_x + distance
                point_y = point_y
            End If

            If direction = "bottom" Then
                Int32.TryParse(BatchAdd.distance, distance)
                terminalPoint.Location = New Point(point_x,
            point_y + distance)
                point_x = point_x
                point_y = point_y + distance
            End If

            If direction = "top" Then
                Int32.TryParse(BatchAdd.distance, distance)
                distance = distance - distance - distance
                terminalPoint.Location = New Point(point_x,
            point_y + distance)
                point_x = point_x
                point_y = point_y + distance

            End If


            Dim workingText As String = "OK"
            terminalNum = (DataForm.WorkstationsTableAdapter.ScalarQuery()) + 1




            terminalPoint.Width = terminalwidth
            terminalPoint.Height = terminalheight

            'AccessibleName = terminalNum
            terminalPoint.Text = terminalNum
            terminalPoint.Font = New Font(terminalPoint.Font.FontFamily, 7, FontStyle.Regular)
            'terminalNum = terminalNum + 1

            For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
                borderPoint.Show()
            Next

            terminalNum = (DataForm.WorkstationsTableAdapter.ScalarQuery()) + 1
            totalLabel.Text = terminalNum

            terminalPoint.ContextMenuStrip = workstationclickMenu
            imageBox.Controls.Add(terminalPoint)
            terminalPoint.AutoEllipsis = True
            terminalPoint.BackColor = Color.LightGreen

            terminalPoint.BringToFront()
            wNumber = terminalNum

            totalWorkingNum += 1
            totalWorking.Text = totalWorkingNum

            totalMoW += 1
            labelMOW.Text = totalMoW
            totalMmW += 1
            labelMMW.Text = totalMmW
            totalDmW += 1
            labelDMW.Text = totalDmW
            totalHdW += 1
            labelHDW.Text = totalHdW
            totalPwW += 1
            labelPWW.Text = totalPwW
            totalOmW += 1
            labelOMW.Text = totalOmW
            totalKbW += 1
            labelKBW.Text = totalKbW
            totalMsW += 1
            labelMSW.Text = totalMsW
            totalUpW += 1
            labelUPW.Text = totalUpW

            If sortProd.SelectedIndex = sortProd.FindStringExact("All") Then
                tDef = totalDefective.Text
                tWor = totalWorking.Text
                tLabel = totalLabel.Text
            End If




            For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()

                If terminalPoint.Bounds.IntersectsWith(borderPoint.Bounds) Then

                    prodNumber = borderPoint.Text

                Else


                End If

            Next
            DataForm.WorkstationsTableAdapter.Insert(terminalNum, point_x, point_y, prodNumber)
            DataForm.WorkstationsTableAdapter.Fill(DataForm.ChristianDataSet.workstations)

            DataForm.StatusTableAdapter.Insert(terminalNum, workingText, workingText, workingText, workingText, workingText, workingText, workingText, workingText, workingText)
            DataForm.StatusTableAdapter.Fill(DataForm.ChristianDataSet.status)

            Dim statusDate As String = ""
            DataForm.Status_dateTableAdapter.Insert(terminalNum, statusDate, statusDate, statusDate, statusDate, statusDate, statusDate, statusDate, statusDate, statusDate)
            DataForm.Status_dateTableAdapter.Fill(DataForm.ChristianDataSet.status_date)

            prodNumber = "None"
            AddHandler terminalPoint.Click, AddressOf WorkstationClick
            AddHandler terminalPoint.DoubleClick, AddressOf WorkstationClick
            AddHandler terminalPoint.MouseDown, AddressOf WorkstationMouseDown
            AddHandler terminalPoint.MouseMove, AddressOf WorkstationMouseMove
            AddHandler terminalPoint.MouseUp, AddressOf WorkstationMouseUp
        Next

    End Sub
    Public Sub batchPreviewTerminal(direction As String)

        BatchAdd.Show()
        BatchAdd.BringToFront()



        ppoint_x = BatchAdd.currentpoint_x
        ppoint_y = BatchAdd.currentpoint_y
        For a = 1 To total
            previewTerminal = New Panel




            If direction = "right" Then

                Int32.TryParse(BatchAdd.distance, distance)
                previewTerminal.Location = New Point(ppoint_x + distance,
            ppoint_y + 2)
                ppoint_x = ppoint_x + distance
                ppoint_y = ppoint_y
            End If

            If direction = "left" Then
                Int32.TryParse(BatchAdd.distance, distance)
                distance = distance - distance - distance
                previewTerminal.Location = New Point(ppoint_x + distance,
            ppoint_y + 2)
                ppoint_x = ppoint_x + distance
                ppoint_y = ppoint_y
            End If

            If direction = "bottom" Then
                Int32.TryParse(BatchAdd.distance, distance)
                previewTerminal.Location = New Point(ppoint_x,
            ppoint_y + distance)
                ppoint_x = ppoint_x
                ppoint_y = ppoint_y + distance
            End If

            If direction = "top" Then
                Int32.TryParse(BatchAdd.distance, distance)
                distance = distance - distance - distance
                previewTerminal.Location = New Point(ppoint_x,
            ppoint_y + distance)
                ppoint_x = ppoint_x
                ppoint_y = ppoint_y + distance

            End If



            'to bottom
            'terminalPoint.Location = New Point(sender.Location.X,
            'sender.Location.Y + distance)

            previewTerminal.Width = terminalwidth - 2
            previewTerminal.Height = terminalheight - 4

            ' previewTerminal.ContextMenuStrip = rightclickMenu
            imageBox.Controls.Add(previewTerminal)
            previewTerminal.BackColor = Color.Blue

            previewTerminal.BringToFront()

        Next

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As MouseEventArgs) Handles imageBox.DoubleClick

        showDetailedReport(False)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sortProd.SelectedIndex = sortProd.FindStringExact("All")

            terminalPoint = New Button
            'background = PictureBox1.BackgroundImage
            '  background_x = background.Width * MousePosition.X / PictureBox1.Width
            '  background_y = background.Height * MousePosition.Y / PictureBox1.Height
            'terminalPoint.Name =
            ' terminalPoint.Text =

            '  sender.top = MousePosition.Y - coordinates.Y
            ' sender.left = MousePosition.X - coordinates.X




            point_x = e.X - 12.5
            point_y = e.Y - 10


            terminalPoint.Location = New Point(point_x,
            point_y)

            'rc = New ResizeableControl(terminalPoint)
            terminalPoint.Width = terminalwidth
            terminalPoint.Height = terminalheight
            terminalNum = (DataForm.WorkstationsTableAdapter.ScalarQuery()) + 1
            totalLabel.Text = terminalNum
            terminalPoint.Text = terminalNum

            terminalPoint.Font = New Font(terminalPoint.Font.FontFamily, 7, FontStyle.Regular)
            terminalPoint.AutoEllipsis = True

            terminalPoint.ContextMenuStrip = workstationclickMenu
            terminalPoint.Anchor = AnchorStyles.Top Or AnchorStyles.Left
            imageBox.Controls.Add(terminalPoint)






            '    terminalPoint.Anchor = AnchorStyles.Left Or AnchorStyles.Top
            terminalPoint.BackColor = Color.LightGreen
            terminalPoint.BringToFront()



            DataForm.WorkstationsTableAdapter.Insert(terminalNum, point_x, point_y, "None")
            DataForm.WorkstationsTableAdapter.Fill(DataForm.ChristianDataSet.workstations)


            Dim workingText As String = "OK"
            DataForm.StatusTableAdapter.Insert(terminalNum, workingText, workingText, workingText, workingText, workingText, workingText, workingText, workingText, workingText)
            DataForm.StatusTableAdapter.Fill(DataForm.ChristianDataSet.status)
            Dim statusDate As String = ""
            DataForm.Status_dateTableAdapter.Insert(terminalNum, statusDate, statusDate, statusDate, statusDate, statusDate, statusDate, statusDate, statusDate, statusDate)
            DataForm.Status_dateTableAdapter.Fill(DataForm.ChristianDataSet.status_date)
            totalWorkingNum += 1
            totalWorking.Text = totalWorkingNum
            terminalNum = terminalNum + 1



            totalMoW += 1
            labelMOW.Text = totalMoW
            totalMmW += 1
            labelMMW.Text = totalMmW
            totalDmW += 1
            labelDMW.Text = totalDmW
            totalHdW += 1
            labelHDW.Text = totalHdW
            totalPwW += 1
            labelPWW.Text = totalPwW
            totalOmW += 1
            labelOMW.Text = totalOmW
            totalKbW += 1
            labelKBW.Text = totalKbW
            totalMsW += 1
            labelMSW.Text = totalMsW
            totalUpW += 1
            labelUPW.Text = totalUpW


            If sortProd.SelectedIndex = sortProd.FindStringExact("All") Then
                tDef = totalDefective.Text
                tWor = totalWorking.Text
                tLabel = totalLabel.Text
            End If


            '   workstationCountText.Text = terminalCnt
            terminalCnt = 0


            ' terminalPoint.ContextMenuStrip = rightclickMenu



            AddHandler terminalPoint.Click, AddressOf WorkstationClick
            ' AddHandler terminalPoint.DoubleClick, AddressOf WorkstationDoubleClick
            AddHandler terminalPoint.MouseDown, AddressOf WorkstationMouseDown
            AddHandler terminalPoint.MouseMove, AddressOf WorkstationMouseMove
            AddHandler terminalPoint.MouseUp, AddressOf WorkstationMouseUp


            'AddHandler terminalPoint.MouseHover, AddressOf WorkstationMouseHover
            ' AddHandler terminalPoint.MouseLeave, AddressOf WorkstationMouseLeave
            '  Me.WorkstationMain_Load(e, e)
        End If
    End Sub
    Private Sub AddMenuItem_Click(sender As Object, e As EventArgs) _
Handles AddMenuItem.Click
        showDetailedReport(False)
        BatchAdd.Show()
        BatchAdd.BringToFront()
    End Sub



    Private Sub InfoMenuItem_Click(sender As Object, e As EventArgs) _
Handles StatusMenuItem.Click

        showDetailedReport(False)
        DataForm.StatusTableAdapter.Fill(DataForm.ChristianDataSet.status)
        Info.workstationNumber.Text = mark.Text

        Info.mark = mark
        Info.Show()
        Info.BringToFront()


    End Sub
    Private Sub SwapMenuItem_Click(sender As Object, e As EventArgs)
        Swap.swappedTerminal.Text = "Workstation " + mark.Text
        Swap.tNumber = mark.Text
        Swap.Show()
        Swap.BringToFront()
    End Sub

    Private Sub searchButton_Click(sender As Object, ByVal e As EventArgs) Handles searchButton.Click
        Dim workstationNumber As String
        workstationNumber = searchBox.Text
        If searchBox.Text <> "" Then

            Dim searchValue As String
            searchValue = searchBox.Text


            For Each terminalPoint In imageBox.Controls.OfType(Of Button)().ToArray()
                terminalPoint.FlatStyle = FlatStyle.Standard

                If terminalPoint.Text = searchValue Then
                    highlightTimer.Interval = 1000

                    currentColor = terminalPoint.BackColor
                    terminalPoint.FlatStyle = FlatStyle.Flat
                    terminalPoint.FlatAppearance.BorderColor = Color.Brown
                    statusTimer.Start()

                    searchButton.Hide()
                    searchBox.Hide()




                    'Dim rect As Rectangle
                    ' Dim gr As Graphics = Me.CreateGraphics.FromImage(PictureBox1.Image)

                    'terminalPoint.BackColor = Color.Brown
                    'highlightTimer.Start()

                    'rect = terminalPoint.Bounds
                    'rect.Inflate(1, 1)
                    'ControlPaint.DrawBorder(gr, terminalPoint.Bounds, Color.Red, ButtonBorderStyle.Solid)
                    ' Dim rec As Rectangle = terminalPoint.Bounds
                    ' Dim myPen As Pen
                    'myPen = New Pen(Drawing.Color.Red, 2)
                    'gr.DrawRectangle(myPen, rec)
                    'PictureBox1.Refresh()
                    'gr.Dispose()
                Else




                End If
            Next
        Else

            statusTimer.Start()
        End If






    End Sub
    Private Sub statusTimer_Tick_1(sender As Object, e As EventArgs) Handles statusTimer.Tick

        statusTimerCnt = statusTimerCnt + 1
        If statusTimerCnt = 3 Then



            statusTimer.Stop()
            statusTimerCnt = 0

        End If

    End Sub


    Private Sub highlightTimer_Tick_1(sender As Object, e As EventArgs) Handles highlightTimer.Tick


    End Sub



    Private Sub MenuStrip1_ItemClicked(sender As Object, e As EventArgs)
        Dim terminalCnt As Integer = 0
        If searchBox.Visible = False And searchButton.Visible = False Then
            searchButton.Show()
            searchBox.Show()

            For Each terminalPoint In imageBox.Controls.OfType(Of Button)().ToArray()
                terminalCnt = terminalCnt + 1
            Next
            If terminalCnt <> 0 Then
                terminalPoint.FlatStyle = FlatStyle.Standard
                terminalCnt = 0
            End If
        Else
            searchButton.Hide()
            searchBox.Hide()


            For Each terminalPoint In imageBox.Controls.OfType(Of Button)().ToArray()
                terminalCnt = terminalCnt + 1
            Next
            If terminalCnt <> 0 Then
                terminalPoint.FlatStyle = FlatStyle.Standard
                terminalCnt = 0
            End If
        End If
    End Sub

    Private Sub menuStatistics_ItemClicked(sender As Object, e As EventArgs)

    End Sub
    Private Sub menuRefresh_ItemClicked(sender As Object, e As EventArgs) Handles menuRefresh.Click
        Me.WorkstationMain_Load(e, e)

        showDetailedReport(False)


    End Sub




    Private Sub searchBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles searchBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True

            End If
        End If
    End Sub

    Public Sub UpdateForm(termTarget As Object, isdef As Boolean)
        If isdef = True Then
            termTarget.BackColor = Color.LightCoral
        Else
            termTarget.BackColor = Color.LightGreen
        End If



        totalMoD = 0
        totalMoW = 0
        labelMOD.Text = totalMoD
        labelMOW.Text = totalMoW



        totalMmD = 0
        totalMmW = 0
        labelMMD.Text = totalMmD
        labelMMW.Text = totalMmW

        totalDmD = 0
        totalDmW = 0
        labelDMD.Text = totalDmD
        labelDMW.Text = totalDmW

        totalHdD = 0
        totalHdW = 0
        labelHDD.Text = totalHdD
        labelHDW.Text = totalHdW

        totalPwD = 0
        totalPwW = 0
        labelPWD.Text = totalPwD
        labelPWW.Text = totalPwW

        totalOmD = 0
        totalOmW = 0
        labelOMD.Text = totalOmD
        labelOMW.Text = totalOmW

        totalKbD = 0
        totalKbW = 0
        labelKBD.Text = totalKbD
        labelKBW.Text = totalKbW

        totalMsD = 0
        totalMsW = 0
        labelMSD.Text = totalMsD
        labelMSW.Text = totalMsW

        totalUpD = 0
        totalUpW = 0
        labelUPD.Text = totalUpD
        labelUPW.Text = totalUpW

        totalDefNum = 0
        totalWorkingNum = 0
        ' totalWorking.Text = 0
        totalDefective.Text = 0


        num = 0




        If DataForm.WorkstationsTableAdapter.ScalarQuery() <> 0 Then
            For rowNum = 1 To DataForm.WorkstationsTableAdapter.ScalarQuery()


                getDefAndWorking(num)
                moDef(num)
                mmDef(num)
                dmDef(num)
                hdDef(num)
                pwDef(num)
                omDef(num)
                kbDef(num)
                msDef(num)
                upDef(num)


                num += 1

            Next
            totalLabel.Text = num

        End If







        For Each button In imageBox.Controls.OfType(Of Button)
            If button.BackColor = Color.LightGreen Then

                terminalCnt += 1

            ElseIf button.BackColor = Color.LightCoral Then

                terminalCnt += 1

            ElseIf button.BackColor = Color.Orange Then

                terminalCnt += 1

            End If

        Next
    End Sub

    Public Sub WorkstationMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '    Me.Update()
        '   Me.Refresh()


        'TODO: This line of code loads data into the 'ChristianDataSet.history' table. You can move, or remove it, as needed.

        '  timeTick.Start()
        DataForm.Show()
        DataForm.Hide()

        If DataForm.ImageTableAdapter.ScalarQuery <> 0 Then
            Panel1.Show()
            Dim arrImage() As Byte
            arrImage = DataForm.ImageDataGridView.Rows(0).Cells(0).Value
            Dim ms As New System.IO.MemoryStream(arrImage)

            imageBox.Height = 1600
            imageBox.Width = 1600
            imageBox.Image = Image.FromStream(ms)

        Else
            Panel1.Hide()

        End If



        totalMoD = 0
        totalMoW = 0
        labelMOD.Text = totalMoD
        labelMOW.Text = totalMoW



        totalMmD = 0
        totalMmW = 0
        labelMMD.Text = totalMmD
        labelMMW.Text = totalMmW

        totalDmD = 0
        totalDmW = 0
        labelDMD.Text = totalDmD
        labelDMW.Text = totalDmW

        totalHdD = 0
        totalHdW = 0
        labelHDD.Text = totalHdD
        labelHDW.Text = totalHdW

        totalPwD = 0
        totalPwW = 0
        labelPWD.Text = totalPwD
        labelPWW.Text = totalPwW

        totalOmD = 0
        totalOmW = 0
        labelOMD.Text = totalOmD
        labelOMW.Text = totalOmW

        totalKbD = 0
        totalKbW = 0
        labelKBD.Text = totalKbD
        labelKBW.Text = totalKbW

        totalMsD = 0
        totalMsW = 0
        labelMSD.Text = totalMsD
        labelMSW.Text = totalMsW

        totalUpD = 0
        totalUpW = 0
        labelUPD.Text = totalUpD
        labelUPW.Text = totalUpW

        totalDefNum = 0
        totalWorkingNum = 0
        ' totalWorking.Text = 0
        totalDefective.Text = 0



        For Each terminalPoint In imageBox.Controls.OfType(Of Button)().ToArray()
            terminalPoint.Dispose()
        Next

        For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
            borderPoint.Dispose()
        Next

        Dim borderName(DataForm.BorderTableAdapter.ScalarQuery()) As String
        Dim bx(DataForm.BorderTableAdapter.ScalarQuery()) As String
        Dim by(DataForm.BorderTableAdapter.ScalarQuery()) As String
        Dim bh(DataForm.BorderTableAdapter.ScalarQuery()) As String
        Dim bw(DataForm.BorderTableAdapter.ScalarQuery()) As String
        bnum = 0


        'BORDER
        If DataForm.BorderTableAdapter.ScalarQuery() <> 0 Then
            For rowNum = 1 To DataForm.BorderTableAdapter.ScalarQuery()

                borderName(bnum) = DataForm.BorderDataGridView.Rows(bnum).Cells(0).Value
                bx(bnum) = DataForm.BorderDataGridView.Rows(bnum).Cells(1).Value
                by(bnum) = DataForm.BorderDataGridView.Rows(bnum).Cells(2).Value
                bh(bnum) = DataForm.BorderDataGridView.Rows(bnum).Cells(3).Value
                bw(bnum) = DataForm.BorderDataGridView.Rows(bnum).Cells(4).Value


                borderPoint = New GroupBox
                borderPoint.Text = New String(borderName(bnum))

                borderPoint.Height = bh(bnum)
                borderPoint.Width = bw(bnum)

                borderPoint.ForeColor = Color.Red
                borderPoint.BackColor = Color.Transparent
                borderPoint.Font = New Font(borderPoint.Font.FontFamily, 14, FontStyle.Bold)
                imageBox.Controls.Add(borderPoint)


                borderPoint.Location = New Point(bx(bnum), by(bnum))


                borderPoint.ContextMenuStrip = borderclickMenu
                AddHandler borderPoint.MouseClick, AddressOf borderPanelClick
                AddHandler borderPoint.MouseDown, AddressOf borderPanelMouseDown

                AddHandler borderPoint.MouseUp, AddressOf borderPanelMouseUp

                rc = New ResizeableControl(borderPoint)


                bnum += 1
            Next
        End If




        'WORKSTATION
        Dim terminalNumber(DataForm.WorkstationsTableAdapter.ScalarQuery()) As String
        Dim x(DataForm.WorkstationsTableAdapter.ScalarQuery()) As String
        Dim y(DataForm.WorkstationsTableAdapter.ScalarQuery()) As String
        num = 0

        If DataForm.WorkstationsTableAdapter.ScalarQuery() <> 0 Then
            For rowNum = 1 To DataForm.WorkstationsTableAdapter.ScalarQuery()


                terminalNumber(num) = DataForm.WorkstationsDataGridView.Rows(num).Cells(0).Value
                x(num) = DataForm.WorkstationsDataGridView.Rows(num).Cells(1).Value
                y(num) = DataForm.WorkstationsDataGridView.Rows(num).Cells(2).Value


                'terminals
                terminalPoint = New Button


                point_x = x(num)
                point_y = y(num)


                terminalPoint.Location = New Point(point_x,
                point_y)

                'rc = New ResizeableControl(terminalPoint)
                terminalPoint.Width = terminalwidth
                terminalPoint.Height = terminalheight

                terminalPoint.Text = terminalNumber(num)
                terminalPoint.Font = New Font(terminalPoint.Font.FontFamily, 7, FontStyle.Regular)

                terminalPoint.AutoEllipsis = True
                terminalPoint.ContextMenuStrip = workstationclickMenu
                imageBox.Controls.Add(terminalPoint)


                'def units
                getDefAndWorking(num)
                moDef(num)
                mmDef(num)
                dmDef(num)
                hdDef(num)
                pwDef(num)
                omDef(num)
                kbDef(num)
                msDef(num)
                upDef(num)

                'DataForm.WorkstationsTableAdapter.Insert(terminalNum, point_x, point_y)
                'terminalNum = terminalNum + 1

                '   workstationCountText.Text = terminalCnt
                terminalCnt = 0

                terminalPoint.ContextMenuStrip = workstationclickMenu


                AddHandler terminalPoint.Click, AddressOf WorkstationClick
                '     AddHandler terminalPoint.DoubleClick, AddressOf WorkstationDoubleClick
                AddHandler terminalPoint.MouseDown, AddressOf WorkstationMouseDown
                AddHandler terminalPoint.MouseMove, AddressOf WorkstationMouseMove
                AddHandler terminalPoint.MouseUp, AddressOf WorkstationMouseUp


                num += 1

            Next
            totalLabel.Text = num

        End If







        For Each button In imageBox.Controls.OfType(Of Button)
            If button.BackColor = Color.LightGreen Then

                terminalCnt += 1

            ElseIf button.BackColor = Color.LightCoral Then

                terminalCnt += 1

            ElseIf button.BackColor = Color.Orange Then

                terminalCnt += 1

            End If

        Next




        AddHandler statisticsPanel.MouseDown, AddressOf statsPanelMouseDown
        AddHandler statisticsPanel.MouseMove, AddressOf statsPanelMouseMove
        AddHandler statisticsPanel.MouseUp, AddressOf statsPanelMouseUp



        Dim productionNum(DataForm.WorkstationsTableAdapter.ScalarQuery()) As String
        num1 = 0
        If DataForm.BorderTableAdapter.ScalarQuery() <> 0 Then
            For rowNum = 1 To DataForm.BorderTableAdapter.ScalarQuery()

                productionNum(num1) = DataForm.WorkstationsDataGridView.Rows(num1).Cells(0).Value
                num1 = +1
            Next
        End If


        sortProd.Items.Clear()
        sortProd.Items.Add("All")
        sortProd.SelectedIndex = sortProd.FindStringExact("All")
        num = 0

        If DataForm.BorderTableAdapter.ScalarQuery() <> 0 Then
            For rowNum = 1 To DataForm.BorderTableAdapter.ScalarQuery()

                sortProd.Items.Add(DataForm.BorderDataGridView.Rows(num).Cells(0).Value).ToString()

                num += 1

            Next


        End If




        ' sortItems.Items.Clear()
        '  sortItems.Items.Add("All")
        '   sortItems.SelectedIndex = 0
        ''   sortItems.Items.Add("Motherboard")
        '  sortItems.Items.Add("Memory")
        '  sortItems.Items.Add("Video card")
        '   sortItems.Items.Add("Hard disk")
        '   sortItems.Items.Add("Power supply")
        '   sortItems.Items.Add("Monitor")
        '   sortItems.Items.Add("Keyboard")
        '    sortItems.Items.Add("Mouse")
        '    sortItems.Items.Add("Ups")

        ' sortProd.SelectedItem("All")


        borderSub.Checked = True
        If borderSub.Checked = True Then
            For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
                borderPoint.Show()
            Next



        Else
            borderPoint.Hide()


        End If

        lockSub.Checked = True

        statSub.Checked = True
        If statSub.Checked = True Then
            statisticsPanel.Show()



        Else
            statisticsPanel.Hide()


        End If

        searchSub.Checked = False
        If searchSub.Checked = True Then
            searchBox.Show()
            searchButton.Show()
            searchSub.Checked = True


        Else
            searchBox.Hide()
            searchButton.Hide()
            searchSub.Checked = False

        End If

        '  rs.FindAllControls(Me)

    End Sub

    Private Sub WorkstationMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        '  rs.ResizeAllControls(Me)
    End Sub

    Public Sub getDefAndWorking(rowKey As Integer)
        defUnits = New ArrayList

        defUnits.Add(DataForm.StatusDataGridView.Rows(rowKey).Cells(1).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(rowKey).Cells(2).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(rowKey).Cells(3).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(rowKey).Cells(4).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(rowKey).Cells(5).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(rowKey).Cells(6).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(rowKey).Cells(7).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(rowKey).Cells(8).Value)
        defUnits.Add(DataForm.StatusDataGridView.Rows(rowKey).Cells(9).Value)
        If defUnits.Contains("DEFECTIVE") Then

            totalDefNum += 1
            totalDefective.Text = totalDefNum


            terminalPoint.BackColor = Color.LightCoral
            terminalPoint.BringToFront()


        Else
            totalWorkingNum += 1
            totalWorking.Text = totalWorkingNum
            terminalPoint.BackColor = Color.LightGreen
            terminalPoint.BringToFront()
        End If

        If sortProd.SelectedIndex = sortProd.FindStringExact("All") Then
            tDef = totalDefective.Text
            tWor = totalWorking.Text
            tLabel = totalLabel.Text
        End If


        defUnits.Clear()
    End Sub
    Public Sub moDef(rowKey As Integer)

        Dim valMO As String = DataForm.StatusDataGridView.Rows(rowKey).Cells(1).Value
        If valMO = "DEFECTIVE" Then
            totalMoD += 1
            labelMOD.Text = totalMoD
        Else
            totalMoW += 1
            labelMOW.Text = totalMoW
        End If

    End Sub

    Public Sub mmDef(rowKey As Integer)
        Dim valMM As String = DataForm.StatusDataGridView.Rows(rowKey).Cells(2).Value
        If valMM = "DEFECTIVE" Then
            totalMmD += 1
            labelMMD.Text = totalMmD
        Else
            totalMmW += 1
            labelMMW.Text = totalMmW
        End If
    End Sub
    Public Sub dmDef(rowKey As Integer)
        Dim valDM As String = DataForm.StatusDataGridView.Rows(rowKey).Cells(3).Value
        If valDM = "DEFECTIVE" Then
            totalDmD += 1
            labelDMD.Text = totalDmD
        Else
            totalDmW += 1
            labelDMW.Text = totalDmW
        End If
    End Sub
    Public Sub hdDef(rowKey As Integer)
        Dim valHD As String = DataForm.StatusDataGridView.Rows(rowKey).Cells(4).Value
        If valHD = "DEFECTIVE" Then
            totalHdD += 1
            labelHDD.Text = totalHdD
        Else
            totalHdW += 1
            labelHDW.Text = totalHdW
        End If
    End Sub
    Public Sub pwDef(rowKey As Integer)
        Dim valPW As String = DataForm.StatusDataGridView.Rows(rowKey).Cells(5).Value
        If valPW = "DEFECTIVE" Then
            totalPwD += 1
            labelPWD.Text = totalPwD
        Else
            totalPwW += 1
            labelPWW.Text = totalPwW
        End If
    End Sub
    Public Sub omDef(rowKey As Integer)
        Dim valOM As String = DataForm.StatusDataGridView.Rows(rowKey).Cells(6).Value
        If valOM = "DEFECTIVE" Then
            totalOmD += 1
            labelOMD.Text = totalOmD
        Else
            totalOmW += 1
            labelOMW.Text = totalOmW
        End If
    End Sub
    Public Sub kbDef(rowKey As Integer)
        Dim valKB As String = DataForm.StatusDataGridView.Rows(rowKey).Cells(7).Value
        If valKB = "DEFECTIVE" Then
            totalKbD += 1
            labelKBD.Text = totalKbD
        Else
            totalKbW += 1
            labelKBW.Text = totalKbW
        End If
    End Sub
    Public Sub msDef(rowKey As Integer)
        Dim valMS As String = DataForm.StatusDataGridView.Rows(rowKey).Cells(8).Value
        If valMS = "DEFECTIVE" Then
            totalMsD += 1
            labelMSD.Text = totalMsD
        Else
            totalMsW += 1
            labelMSW.Text = totalMsW
        End If
    End Sub
    Public Sub upDef(rowKey As Integer)
        Dim valUP As String = DataForm.StatusDataGridView.Rows(rowKey).Cells(9).Value
        If valUP = "DEFECTIVE" Then
            totalUpD += 1
            labelUPD.Text = totalUpD
        Else
            totalUpW += 1
            labelUPW.Text = totalUpW
        End If
    End Sub

    Public Sub loadWorkstations()


    End Sub





    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork







    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted

    End Sub

    Private Sub BackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged

    End Sub



    Private Sub menuBorder_Click(sender As Object, e As EventArgs) Handles menuBorder.Click
        showDetailedReport(False)
        BorderAdd.Show()
        BorderAdd.BringToFront()

    End Sub

    Public Sub addBorder(prodNum As String)

        borderPoint = New GroupBox
        borderPoint.Text = New String(prodNum)
        '  borderPoint.Text = prodNum

        borderPoint.ForeColor = Color.Red
        borderPoint.BackColor = Color.Transparent
        borderPoint.Font = New Font(borderPoint.Font.FontFamily, 14, FontStyle.Bold)
        imageBox.Controls.Add(borderPoint)


        bpoint_x = 450
        bpoint_y = 30
        borderPoint.Height = 100
        borderPoint.Width = 100


        borderPoint.Location = New Point(bpoint_x,
            bpoint_y)

        DataForm.BorderTableAdapter.Insert(prodNum, bpoint_x, bpoint_y, borderPoint.Height, borderPoint.Width)
        DataForm.BorderTableAdapter.Fill(DataForm.ChristianDataSet.border)

        borderPoint.ContextMenuStrip = borderclickMenu
        '  AddHandler borderPoint.MouseClick, AddressOf borderPanelClick

        AddHandler borderPoint.MouseDown, AddressOf borderPanelMouseDown
        AddHandler borderPoint.DoubleClick, AddressOf borderPanelDoubleClick
        AddHandler borderPoint.MouseUp, AddressOf borderPanelMouseUp




        rc = New ResizeableControl(borderPoint)


        sortProd.Items.Clear()
        sortProd.Items.Add("All")
        sortProd.SelectedIndex = 0
        num = 0

        addBorderToList()


    End Sub

    Private Sub sortItems_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub deleteBorder_Click(sender As Object, e As EventArgs) Handles deleteBorder.Click

        For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
            If borderPoint.Text = mark Then
                DataForm.BorderTableAdapter.DeleteBorder(mark)
                DataForm.BorderTableAdapter.Fill(DataForm.ChristianDataSet.border)

                DataForm.WorkstationsTableAdapter.UpdateProd("None", mark)
                DataForm.WorkstationsTableAdapter.Fill(DataForm.ChristianDataSet.workstations)
                borderPoint.Dispose()
            End If
        Next

    End Sub

    Private Sub LockControlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles lockSub.Click
        If lockSub.Checked = True Then
            lockSub.Checked = False
        Else
            lockSub.Checked = True
        End If
    End Sub

    Private Sub borderSub_Click(sender As Object, e As EventArgs) Handles borderSub.Click
        If borderSub.Checked = True Then
            borderSub.Checked = False
            For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
                borderPoint.Hide()
            Next


        Else
            borderSub.Checked = True
            For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
                borderPoint.Show()
            Next
        End If
    End Sub
    Private Sub higlightBorder()
        For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
            borderPoint.Show()
            borderSub.Checked = True
            If borderPoint.Text = sortProd.SelectedItem.ToString() Then

                borderPoint.BackColor = Color.FromArgb(50, Color.Gold)
            End If

        Next

    End Sub


    Private Sub sortProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sortProd.SelectedIndexChanged, sortProd2.SelectedIndexChanged
        For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
            borderPoint.Show()
            borderSub.Checked = True
            borderPoint.BackColor = Color.FromArgb(50, Color.Transparent)

        Next

        If sortProd.SelectedIndex = sortProd.FindStringExact("All") Then
            Dim tDef As String = totalDefective.Text
            Dim tWor As String = totalWorking.Text
            Dim tLabel As String = totalLabel.Text
            LinkLabel1.Visible = True
        Else
            showDetailedReport(False)
            LinkLabel1.Visible = False
        End If


        If toSort = True Then
            sortByProd(sortProd.SelectedItem.ToString)

            higlightBorder()
            toSort = False
        End If


    End Sub

    Private Sub sortItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sortItems.SelectedIndexChanged

        If sortItems.SelectedItem.ToString = "Motherboard" Then
            DataForm.StatusTableAdapter.FillByMo(DataForm.ChristianDataSet.status, "DEFECTIVE")
            '    moMark()
        ElseIf sortItems.SelectedItem.ToString = "Memory" Then

        End If


    End Sub

    Private Sub ViewStatisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles statSub.Click
        If statSub.Checked = False Then
            statisticsPanel.Show()
            statSub.Checked = True


        Else
            statisticsPanel.Hide()
            statSub.Checked = False

        End If
    End Sub





    Private Sub renameBorder_Click(sender As Object, e As EventArgs) Handles renameBorder.Click

        lastProdName = mark
        BorderRename.Show()
        BorderRename.origProd = mark
        BorderRename.BringToFront()
    End Sub

    Private Sub menuImport_Click(sender As Object, e As EventArgs) Handles menuImport.Click
        Dim opf As New OpenFileDialog



        opf.Filter = "Choose Image(*.jpg;*.png;)|*.jpg;*.png;"
        If opf.ShowDialog = DialogResult.OK Then
            imageBox.Image = Nothing

            imageBox.Height = 1600
            imageBox.Width = 1600
            imageBox.Image = Image.FromFile(opf.FileName)

            Dim ms As New System.IO.MemoryStream
            imageBox.Image.Save(ms, imageBox.Image.RawFormat)
            Dim arrImage() As Byte = ms.GetBuffer

            DataForm.ImageTableAdapter.DeleteImage()
            DataForm.ImageTableAdapter.Fill(DataForm.ChristianDataSet.image)

            DataForm.ImageTableAdapter.Insert(arrImage)
            DataForm.ImageTableAdapter.Fill(DataForm.ChristianDataSet.image)
            Panel1.Show()
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        imageBox.Image = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim arrImage() As Byte
        arrImage = DataForm.ImageDataGridView.Rows(0).Cells(0).Value
        Dim ms As New System.IO.MemoryStream(arrImage)
        imageBox.Image = Image.FromStream(ms)
    End Sub

    Public Sub sortByProd(prodName As String)
        Dim d As Integer = 0
        Dim w As Integer = 0
        Dim t As Integer = 0

        totalWorking.Text = 0
        totalDefective.Text = 0
        totalLabel.Text = 0

        If sortProd.SelectedItem = "All" Then
            prodLabel.Text = "Overall"

            For Each terminalPoint In imageBox.Controls.OfType(Of Button)().ToArray()

                t += 1


                If terminalPoint.BackColor = Color.LightGreen Then

                    w += 1
                    totalWorking.Text = w.ToString

                End If

                If terminalPoint.BackColor = Color.LightCoral Then

                    d += 1
                    totalDefective.Text = d.ToString

                End If

            Next
            totalLabel.Text = t.ToString

        Else
            prodLabel.Text = prodName


            For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()



                If borderPoint.Text = prodName Then

                    For Each terminalPoint In imageBox.Controls.OfType(Of Button)().ToArray()

                        If borderPoint.Bounds.IntersectsWith(terminalPoint.Bounds) Then

                            t += 1


                            If terminalPoint.BackColor = Color.LightGreen Then

                                w += 1
                                totalWorking.Text = w.ToString

                            End If

                            If terminalPoint.BackColor = Color.LightCoral Then

                                d += 1
                                totalDefective.Text = d.ToString

                            End If
                        End If

                    Next
                    totalLabel.Text = t.ToString

                Else

                End If

            Next

        End If


    End Sub


    Public Sub renameLastProdName(newName As String)

        For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
            If borderPoint.Text = lastProdName Then
                borderPoint.Text = newName
                lastProdName = ""
            End If




        Next
        addBorderToList()
    End Sub

    Private Sub imageBox_Click(sender As Object, e As EventArgs) Handles imageBox.Click
        workstationPopBox.Hide()
        sortProd.SelectedIndex = sortProd.FindStringExact("All")
        For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()



            borderPoint.BackColor = Color.FromArgb(20, Color.Transparent)


        Next
    End Sub

    Private Sub logsBox_SelectedIndexChanged(sender As Object, e As EventArgs)


        ' If sortBox.SelectedItem = "All" Then
        '  HistoryTableAdapter.FillAll(ChristianDataSet.history)
        '   Else
        '   HistoryTableAdapter.FillBy(ChristianDataSet.history, sortBox.SelectedItem.ToString)
        '   End If


        '    Label3.Text = logsBox.SelectedItem.ToString

        '   If logsBox.SelectedItem.ToString = "History" Then
        '   HistoryDataGridView.Show()
        '''   ElseIf logsBox.SelectedItem.ToString = "Replacements" Then
        '  HistoryDataGridView.Hide()
        '  End If
    End Sub

    Private Sub searchSub_Click(sender As Object, e As EventArgs) Handles searchSub.Click
        If searchSub.Checked = False Then
            searchBox.Show()
            searchButton.Show()
            searchSub.Checked = True


        Else
            searchBox.Hide()
            searchButton.Hide()
            searchSub.Checked = False

        End If
    End Sub



    Private Sub ReplacementsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub imageBox_MouseMove(sender As Object, e As MouseEventArgs) Handles imageBox.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then



            Dim DeltaX As Integer = (panStartPoint.X - e.X)
            Dim DeltaY As Integer = (panStartPoint.Y - e.Y)


            Panel1.AutoScrollPosition =
                New Drawing.Point((DeltaX - Panel1.AutoScrollPosition.X),
                                (DeltaY - Panel1.AutoScrollPosition.Y))

            Me.Invalidate()
            Me.Update()



        End If
    End Sub

    Private Sub imageBox_MouseDown(sender As Object, e As MouseEventArgs) Handles imageBox.MouseDown

        panStartPoint = New Point(e.X, e.Y)

    End Sub



    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteMenuItem.Click
        DataForm.WorkstationsTableAdapter.DeleteWorkstation(Convert.ToInt32(mark.Text))
        DataForm.WorkstationsTableAdapter.Fill(DataForm.ChristianDataSet.workstations)

        DataForm.StatusTableAdapter.DeleteStatus(Convert.ToInt32(mark.Text))
        DataForm.StatusTableAdapter.Fill(DataForm.ChristianDataSet.status)

        DataForm.Status_dateTableAdapter.DeleteStatusDate(Convert.ToInt32(mark.Text))
        DataForm.Status_dateTableAdapter.Fill(DataForm.ChristianDataSet.status_date)

        showDetailedReport(False)
        If mark.BackColor = Color.LightGreen Then
            totalWorkingNum -= 1
            totalWorking.Text = totalWorkingNum
        ElseIf mark.BackColor = Color.LightCoral Then

            totalDefNum -= 1
            totalDefective.Text = totalDefNum
        End If
        totalLabel.Text = (Convert.ToInt32(totalLabel.Text)) - 1
        mark.Dispose()


        totalMoW -= 1
        labelMOW.Text = totalMoW
        totalMmW -= 1
        labelMMW.Text = totalMmW
        totalDmW -= 1
        labelDMW.Text = totalDmW
        totalHdW -= 1
        labelHDW.Text = totalHdW
        totalPwW -= 1
        labelPWW.Text = totalPwW
        totalOmW -= 1
        labelOMW.Text = totalOmW
        totalKbW -= 1
        labelKBW.Text = totalKbW
        totalMsW -= 1
        labelMSW.Text = totalMsW
        totalUpW -= 1
        labelUPW.Text = totalUpW


    End Sub

    Private Sub menuLogs_Click(sender As Object, e As EventArgs) Handles menuLogs.Click
        Logs.Show()
        Logs.BringToFront()
    End Sub

    Private Sub AdwToolStripMenuItem_Click(sender As Object, e As EventArgs)
        DataForm.Show()
    End Sub

    Private Sub ClearDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearDatabaseToolStripMenuItem.Click
        DeleteDB.Show()
        DeleteDB.BringToFront()
    End Sub

    Private Sub SwapMenuItem_Click_1(sender As Object, e As EventArgs) Handles SwapMenuItem.Click
        Swap.currentTerminal.Text = mark.Text
        Swap.tNumber = mark.ToString
        Swap.Show()
        Swap.BringToFront()

    End Sub

    Private Sub sortProd_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles sortProd.SelectedIndexChanged
        For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()
            borderPoint.Show()
            borderSub.Checked = True
            borderPoint.BackColor = Color.FromArgb(50, Color.Transparent)

        Next
        sortByProd(sortProd.SelectedItem.ToString)
        higlightBorder()
    End Sub

    Private Sub sortProd_DropDown(sender As Object, e As EventArgs) Handles sortProd.DropDown
        toSort = True
    End Sub

    Private Sub sortProd_DropDownClosed(sender As Object, e As EventArgs) Handles sortProd.DropDownClosed
        toSort = False
    End Sub

    Public Sub showDetailedReport(toShow As Boolean)

        If toShow = True Then
            Dim d As Integer = 0
            Dim w As Integer = 0
            Dim t As Integer = 0

            GroupBox2.Controls.Add(prodListview)
            prodListview.Left = 6
            prodListview.Top = 50
            prodListview.BringToFront()
            prodListview.ColumnHeadersDefaultCellStyle.Font = New Font(prodListview.Font.FontFamily, 8, FontStyle.Regular)




            If prodListview.Visible = False Then
                prodListview.Visible = True
                LinkLabel1.Text = "Hide"

                num = 0

                If DataForm.BorderTableAdapter.ScalarQuery() <> 0 Then
                    For rowNum = 1 To DataForm.BorderTableAdapter.ScalarQuery()


                        For Each borderPoint In imageBox.Controls.OfType(Of GroupBox)().ToArray()



                            If borderPoint.Text = DataForm.BorderDataGridView.Rows(num).Cells(0).Value Then

                                For Each terminalPoint In imageBox.Controls.OfType(Of Button)().ToArray()

                                    If borderPoint.Bounds.IntersectsWith(terminalPoint.Bounds) Then

                                        t += 1


                                        If terminalPoint.BackColor = Color.LightGreen Then

                                            w += 1


                                        End If

                                        If terminalPoint.BackColor = Color.LightCoral Then

                                            d += 1


                                        End If
                                    End If

                                Next

                                prodListview.Rows.Insert(num, New String() {DataForm.BorderDataGridView.Rows(num).Cells(0).Value, d.ToString(), w.ToString(), t.ToString()})



                            End If

                        Next
                        d = 0
                        w = 0
                        t = 0


                        num += 1

                    Next


                End If
            Else
                prodListview.Rows.Clear()
                prodListview.Visible = False
                LinkLabel1.Text = "Detailed Report"
            End If
        Else
            prodListview.Rows.Clear()
            prodListview.Visible = False
            LinkLabel1.Text = "Detailed Report"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        showDetailedReport(True)




    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub



    Public Sub addBorderToList()
        sortProd.Items.Clear()
        sortProd.Items.Add("All")
        sortProd.SelectedIndex = 0


        num = 0

        If DataForm.BorderTableAdapter.ScalarQuery() <> 0 Then
            For rowNum = 1 To DataForm.BorderTableAdapter.ScalarQuery()

                sortProd.Items.Add(DataForm.BorderDataGridView.Rows(num).Cells(0).Value).ToString()

                num += 1

            Next


        End If

    End Sub

    Public Sub moMark()


        defUnits = New ArrayList
        defUnits.Clear()
        num1 = 0
        If DataForm.StatusTableAdapter.ScalarQuery() <> 0 Then
            For rowNum = 1 To DataForm.StatusTableAdapter.ScalarQuery()

                defUnits.Add(DataForm.StatusDataGridView.Rows(num1).Cells(0).Value)

                num1 = +1
            Next





            For Each terminalPoint In imageBox.Controls.OfType(Of Button)().ToArray()

                If defUnits.Contains(Convert.ToInt32(terminalPoint.Text)) Then

                    terminalPoint.BackColor = Color.LightCoral
                Else

                    terminalPoint.BackColor = Color.LightGreen
                End If
            Next
        End If


















        defUnits.Clear()



    End Sub


End Class





