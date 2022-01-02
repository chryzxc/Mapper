Public Class Info
    Dim moIsClicked, mmIsClicked, dmIsClicked, hdIsClicked, pwIsClicked, omIsClicked, kbIsClicked, msIsClicked, upIsClicked As String
    Dim itemKey, description As String
    Dim moBarcode, mmBarcode, dmBarcode, hdBarcode, pwBarcode, omBarcode, kbBarcode, msBarcode, upBarcode As String
    Dim editable As Boolean
    Dim lastVal As String
    Dim terminalRow As Integer = 0
    Public mark As Object
    Dim isDefective As Boolean = False

    Public Sub returnLast()
        If itemKey = "mo" Then
            moS.SelectedIndex = moS.FindStringExact(lastVal)
        End If
    End Sub
    Private Sub cbDropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
        '  editable = False
        If sender.SelectedItem = "OK" Then
            sender.BackColor = Color.LightGreen
        ElseIf sender.SelectedItem = "DEFECTIVE" Then
            sender.BackColor = Color.LightCoral
        ElseIf sender.SelectedItem = "FOR UPGRADE" Then
            sender.BackColor = Color.Orange
        End If
        saveButton.Focus()
    End Sub

    Private Sub cbDropDown(ByVal sender As Object, ByVal e As EventArgs)
        editable = True
        sender.BackColor = Color.White
        lastVal = sender.SelectedItem
    End Sub



    Private Sub cbIndexChanged(ByVal sender As Object, ByVal e As EventArgs)


        If sender.SelectedItem = "OK" Then
            sender.BackColor = Color.LightGreen
        ElseIf sender.SelectedItem = "DEFECTIVE" Then
            sender.BackColor = Color.LightCoral
        ElseIf sender.SelectedItem = "FOR UPGRADE" Then
            sender.BackColor = Color.Orange
        End If
        saveButton.Focus()


        If editable = True Then

            If sender.Name = "moS" Then
                If sender.SelectedItem = "DEFECTIVE" Then


                    moSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")
                    moIsClicked = "DEFECTIVE"



                ElseIf sender.SelectedItem = "FOR UPGRADE" Then

                    moSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")



                    moIsClicked = "FOR UPGRADE"

                ElseIf sender.SelectedItem <> lastVal Then


                    itemKey = "mo"

                    Barcode.Show()
                    Barcode.BringToFront()


                End If

            ElseIf sender.Name = "mmS" Then
                If sender.SelectedItem = "DEFECTIVE" Then


                    mmSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")
                    mmIsClicked = "DEFECTIVE"



                ElseIf sender.SelectedItem = "FOR UPGRADE" Then

                    mmSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")



                    mmIsClicked = "FOR UPGRADE"

                ElseIf sender.SelectedItem <> lastVal Then

                    itemKey = "mm"
                    Barcode.Show()
                    Barcode.BringToFront()



                End If


            ElseIf sender.Name = "dmS" Then
                If sender.SelectedItem = "DEFECTIVE" Then


                    dmSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")
                    dmIsClicked = "DEFECTIVE"



                ElseIf sender.SelectedItem = "FOR UPGRADE" Then

                    dmSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")



                    dmIsClicked = "FOR UPGRADE"

                ElseIf sender.SelectedItem <> lastVal Then


                    itemKey = "dm"
                    Barcode.Show()
                    Barcode.BringToFront()



                End If

            ElseIf sender.Name = "hdS" Then
                If sender.SelectedItem = "DEFECTIVE" Then


                    hdSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")
                    hdIsClicked = "DEFECTIVE"



                ElseIf sender.SelectedItem = "FOR UPGRADE" Then

                    hdSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")



                    hdIsClicked = "FOR UPGRADE"

                ElseIf sender.SelectedItem <> lastVal Then


                    itemKey = "hd"
                    Barcode.Show()
                    Barcode.BringToFront()



                End If

            ElseIf sender.Name = "pwS" Then
                If sender.SelectedItem = "DEFECTIVE" Then


                    pwSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")
                    pwIsClicked = "DEFECTIVE"



                ElseIf sender.SelectedItem = "FOR UPGRADE" Then

                    pwSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")



                    pwIsClicked = "FOR UPGRADE"

                ElseIf sender.SelectedItem <> lastVal Then



                    itemKey = "pw"
                    Barcode.Show()
                    Barcode.BringToFront()



                End If



            ElseIf sender.Name = "omS" Then
                If sender.SelectedItem = "DEFECTIVE" Then


                    omSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")
                    omIsClicked = "DEFECTIVE"



                ElseIf sender.SelectedItem = "FOR UPGRADE" Then

                    omSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")



                    omIsClicked = "FOR UPGRADE"

                ElseIf sender.SelectedItem <> lastVal Then



                    itemKey = "om"
                    Barcode.Show()
                    Barcode.BringToFront()



                End If



            ElseIf sender.Name = "kbS" Then
                If sender.SelectedItem = "DEFECTIVE" Then


                    kbSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")
                    kbIsClicked = "DEFECTIVE"



                ElseIf sender.SelectedItem = "FOR UPGRADE" Then

                    kbSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")



                    kbIsClicked = "FOR UPGRADE"

                ElseIf sender.SelectedItem <> lastVal Then


                    itemKey = "kb"
                    Barcode.Show()
                    Barcode.BringToFront()



                End If


            ElseIf sender.Name = "msS" Then
                If sender.SelectedItem = "DEFECTIVE" Then


                    msSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")
                    msIsClicked = "DEFECTIVE"



                ElseIf sender.SelectedItem = "FOR UPGRADE" Then

                    msSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")



                    msIsClicked = "FOR UPGRADE"

                ElseIf sender.SelectedItem <> lastVal Then


                    itemKey = "ms"
                    Barcode.Show()
                    Barcode.BringToFront()



                End If

            ElseIf sender.Name = "upS" Then
                If sender.SelectedItem = "DEFECTIVE" Then


                    upSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")
                    upIsClicked = "DEFECTIVE"



                ElseIf sender.SelectedItem = "FOR UPGRADE" Then

                    upSD.Text = DateTime.Now.ToString("dddd,MMMM d,yyyy   hh:mm:ss tt")



                    upIsClicked = "FOR UPGRADE"

                ElseIf sender.SelectedItem <> lastVal Then



                    itemKey = "up"
                    Barcode.Show()
                    Barcode.BringToFront()



                End If



            End If

        End If

    End Sub

    Dim moDesc, mmDesc, dmDesc, hdDesc, pwDesc, omDesc, kbDesc, msDesc, upDesc As String
    Dim moN, mmN, dmN, hdN, pwN, omN, kbN, msN, upN As String
    Dim passTerminalNumber As String
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        editable = False

        AddHandler moS.DropDownClosed, AddressOf cbDropDownClosed
        AddHandler moS.SelectedIndexChanged, AddressOf cbIndexChanged
        AddHandler moS.DropDown, AddressOf cbDropDown

        AddHandler mmS.DropDownClosed, AddressOf cbDropDownClosed
        AddHandler mmS.SelectedIndexChanged, AddressOf cbIndexChanged
        AddHandler mmS.DropDown, AddressOf cbDropDown

        AddHandler dmS.DropDownClosed, AddressOf cbDropDownClosed
        AddHandler dmS.SelectedIndexChanged, AddressOf cbIndexChanged
        AddHandler dmS.DropDown, AddressOf cbDropDown

        AddHandler hdS.DropDownClosed, AddressOf cbDropDownClosed
        AddHandler hdS.SelectedIndexChanged, AddressOf cbIndexChanged
        AddHandler hdS.DropDown, AddressOf cbDropDown

        AddHandler pwS.DropDownClosed, AddressOf cbDropDownClosed
        AddHandler pwS.SelectedIndexChanged, AddressOf cbIndexChanged
        AddHandler pwS.DropDown, AddressOf cbDropDown

        AddHandler omS.DropDownClosed, AddressOf cbDropDownClosed
        AddHandler omS.SelectedIndexChanged, AddressOf cbIndexChanged
        AddHandler omS.DropDown, AddressOf cbDropDown

        AddHandler kbS.DropDownClosed, AddressOf cbDropDownClosed
        AddHandler kbS.SelectedIndexChanged, AddressOf cbIndexChanged
        AddHandler kbS.DropDown, AddressOf cbDropDown

        AddHandler msS.DropDownClosed, AddressOf cbDropDownClosed
        AddHandler msS.SelectedIndexChanged, AddressOf cbIndexChanged
        AddHandler msS.DropDown, AddressOf cbDropDown


        AddHandler upS.DropDownClosed, AddressOf cbDropDownClosed
        AddHandler upS.SelectedIndexChanged, AddressOf cbIndexChanged
        AddHandler upS.DropDown, AddressOf cbDropDown


        moIsClicked = "None"
        mmIsClicked = "None"
        dmIsClicked = "None"
        hdIsClicked = "None"
        pwIsClicked = "None"
        omIsClicked = "None"
        kbIsClicked = "None"
        msIsClicked = "None"
        upIsClicked = "None"
        prodNumber.Text = "None"


        terminalRow = Convert.ToInt32(workstationNumber.Text) - 1



        prodNumber.Text = DataForm.WorkstationsDataGridView.Rows(terminalRow).Cells(3).Value

        moS.SelectedIndex = moS.FindStringExact(DataForm.StatusDataGridView.Rows(terminalRow).Cells(1).Value)
        mmS.SelectedIndex = moS.FindStringExact(DataForm.StatusDataGridView.Rows(terminalRow).Cells(2).Value)
        dmS.SelectedIndex = moS.FindStringExact(DataForm.StatusDataGridView.Rows(terminalRow).Cells(3).Value)
        hdS.SelectedIndex = moS.FindStringExact(DataForm.StatusDataGridView.Rows(terminalRow).Cells(4).Value)
        pwS.SelectedIndex = moS.FindStringExact(DataForm.StatusDataGridView.Rows(terminalRow).Cells(5).Value)
        omS.SelectedIndex = moS.FindStringExact(DataForm.StatusDataGridView.Rows(terminalRow).Cells(6).Value)
        kbS.SelectedIndex = moS.FindStringExact(DataForm.StatusDataGridView.Rows(terminalRow).Cells(7).Value)
        msS.SelectedIndex = moS.FindStringExact(DataForm.StatusDataGridView.Rows(terminalRow).Cells(8).Value)
        upS.SelectedIndex = moS.FindStringExact(DataForm.StatusDataGridView.Rows(terminalRow).Cells(9).Value)






        If moS.SelectedItem = "OK" Then
            moSD.Text = ""
            moS.BackColor = Color.LightGreen

        ElseIf moS.SelectedItem = "DEFECTIVE" Then
            moS.BackColor = Color.LightCoral
            moSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(1).Value.ToString

        ElseIf moS.SelectedItem = "FOR UPGRADE" Then
            moS.BackColor = Color.Orange
            moSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(1).Value.ToString
        End If

        If mmS.SelectedItem = "OK" Then
            mmSD.Text = ""
            mmS.BackColor = Color.LightGreen

        ElseIf mmS.SelectedItem = "DEFECTIVE" Then
            mmS.BackColor = Color.LightCoral
            mmSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(2).Value.ToString

        ElseIf mmS.SelectedItem = "FOR UPGRADE" Then
            mmS.BackColor = Color.Orange
            mmSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(2).Value.ToString
        End If

        If dmS.SelectedItem = "OK" Then
            dmSD.Text = ""
            dmS.BackColor = Color.LightGreen

        ElseIf dmS.SelectedItem = "DEFECTIVE" Then
            dmS.BackColor = Color.LightCoral
            dmSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(3).Value.ToString

        ElseIf dmS.SelectedItem = "FOR UPGRADE" Then
            dmS.BackColor = Color.Orange
            dmSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(3).Value.ToString
        End If


        If hdS.SelectedItem = "OK" Then
            hdSD.Text = ""
            hdS.BackColor = Color.LightGreen

        ElseIf hdS.SelectedItem = "DEFECTIVE" Then
            hdS.BackColor = Color.LightCoral
            hdSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(4).Value.ToString

        ElseIf hdS.SelectedItem = "FOR UPGRADE" Then
            hdS.BackColor = Color.Orange
            hdSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(4).Value.ToString
        End If

        If pwS.SelectedItem = "OK" Then
            pwSD.Text = ""
            pwS.BackColor = Color.LightGreen

        ElseIf pwS.SelectedItem = "DEFECTIVE" Then
            pwS.BackColor = Color.LightCoral
            pwSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(5).Value.ToString

        ElseIf pwS.SelectedItem = "FOR UPGRADE" Then
            pwS.BackColor = Color.Orange
            pwSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(5).Value.ToString
        End If



        If omS.SelectedItem = "OK" Then
            omSD.Text = ""
            omS.BackColor = Color.LightGreen

        ElseIf omS.SelectedItem = "DEFECTIVE" Then
            omS.BackColor = Color.LightCoral
            omSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(6).Value.ToString

        ElseIf omS.SelectedItem = "FOR UPGRADE" Then
            omS.BackColor = Color.Orange
            omSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(6).Value.ToString
        End If

        If kbS.SelectedItem = "OK" Then
            kbSD.Text = ""
            kbS.BackColor = Color.LightGreen

        ElseIf kbS.SelectedItem = "DEFECTIVE" Then
            kbS.BackColor = Color.LightCoral
            kbSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(7).Value.ToString

        ElseIf kbS.SelectedItem = "FOR UPGRADE" Then
            kbS.BackColor = Color.Orange
            kbSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(7).Value.ToString
        End If

        If msS.SelectedItem = "OK" Then
            msSD.Text = ""
            msS.BackColor = Color.LightGreen

        ElseIf msS.SelectedItem = "DEFECTIVE" Then
            msS.BackColor = Color.LightCoral
            msSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(8).Value.ToString

        ElseIf msS.SelectedItem = "FOR UPGRADE" Then
            msS.BackColor = Color.Orange
            msSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(8).Value.ToString
        End If

        If upS.SelectedItem = "OK" Then
            upSD.Text = ""
            upS.BackColor = Color.LightGreen

        ElseIf upS.SelectedItem = "DEFECTIVE" Then
            upS.BackColor = Color.LightCoral
            upSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(9).Value.ToString

        ElseIf upS.SelectedItem = "FOR UPGRADE" Then
            upS.BackColor = Color.Orange
            upSD.Text = DataForm.Status_dateDataGridView.Rows(terminalRow).Cells(9).Value.ToString
        End If







    End Sub
    Public Sub AddItems()

    End Sub



    Private Sub Save_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        WorkstationMain.workstationPopBox.Hide()

        DataForm.StatusTableAdapter.UpdateStatus(moS.SelectedItem.ToString, mmS.SelectedItem.ToString, dmS.SelectedItem.ToString, hdS.SelectedItem.ToString, pwS.SelectedItem.ToString, omS.SelectedItem.ToString, kbS.SelectedItem.ToString, msS.SelectedItem.ToString, upS.SelectedItem.ToString, workstationNumber.Text)
        DataForm.Status_dateTableAdapter.UpdateStatusDate(moSD.Text.ToString, mmSD.Text.ToString, dmSD.Text, hdSD.Text, pwSD.Text, omSD.Text, kbSD.Text, msSD.Text, upSD.Text, workstationNumber.Text)
        DataForm.StatusTableAdapter.Fill(DataForm.ChristianDataSet.status)
        DataForm.Status_dateTableAdapter.Fill(DataForm.ChristianDataSet.status_date)



        If moIsClicked = "DEFECTIVE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Defective", "Motherboard", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)
            isDefective = True
        ElseIf moIsClicked = "FOR UPGRADE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "For upgrade", "Motherboard", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        ElseIf moIsClicked = "OK" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Replaced", "Motherboard", moDesc, moBarcode, moN, DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        End If



        If mmIsClicked = "DEFECTIVE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Defective", "Memory", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)
            isDefective = True

        ElseIf mmIsClicked = "FOR UPGRADE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "For upgrade", "Memory", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        ElseIf mmIsClicked = "OK" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Replaced", "Memory", mmDesc, mmBarcode, mmN, DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        End If

        If dmIsClicked = "DEFECTIVE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Defective", "Video card", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)
            isDefective = True
        ElseIf dmIsClicked = "FOR UPGRADE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "For upgrade", "Video card", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        ElseIf dmIsClicked = "OK" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Replaced", "Video card", dmDesc, dmBarcode, dmN, DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        End If


        If hdIsClicked = "DEFECTIVE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Defective", "Hard disk", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)
            isDefective = True
        ElseIf hdIsClicked = "FOR UPGRADE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "For upgrade", "Hard disk", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        ElseIf hdIsClicked = "OK" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Replaced", "Hard disk", hdDesc, hdBarcode, hdN, DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        End If



        If pwIsClicked = "DEFECTIVE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Defective", "Power supply", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)
            isDefective = True
        ElseIf pwIsClicked = "FOR UPGRADE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "For upgrade", "Power supply", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        ElseIf pwIsClicked = "OK" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Replaced", "Power supply", pwDesc, pwBarcode, pwN, DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        End If

        If omIsClicked = "DEFECTIVE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Defective", "Monitor", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)
            isDefective = True
        ElseIf omIsClicked = "FOR UPGRADE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "For upgrade", "Monitor", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        ElseIf omIsClicked = "OK" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Replaced", "Monitor", omDesc, omBarcode, omN, DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        End If


        If kbIsClicked = "DEFECTIVE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Defective", "Keyboard", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)
            isDefective = True
        ElseIf kbIsClicked = "FOR UPGRADE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "For upgrade", "Keyboard", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        ElseIf kbIsClicked = "OK" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Replaced", "Keyboard", kbDesc, kbBarcode, kbN, DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        End If

        If msIsClicked = "DEFECTIVE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Defective", "Mouse", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)
            isDefective = True
        ElseIf msIsClicked = "FOR UPGRADE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "For upgrade", "Mouse", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        ElseIf msIsClicked = "OK" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Replaced", "Mouse", msDesc, msBarcode, msN, DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        End If

        If upIsClicked = "DEFECTIVE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Defective", "Ups", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)
            isDefective = True
        ElseIf upIsClicked = "FOR UPGRADE" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "For upgrade", "Ups", "", "", "", DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        ElseIf upIsClicked = "OK" Then
            Logs.LogsTableAdapter.Insert(workstationNumber.Text, prodNumber.Text, "Replaced", "Ups", upDesc, upBarcode, upN, DateAndTime.Now)
            Logs.LogsTableAdapter.Fill(Logs.ChristianDataSet.logs)

        End If








        Me.Dispose()

        If isDefective = True Then
            WorkstationMain.UpdateForm(mark, True)
        Else
            WorkstationMain.UpdateForm(mark, False)
        End If

        '  WorkstationMain.WorkstationMain_Load(e, e)

    End Sub





    Public Sub def(bCode As String, itemDesc As String, note As String)

        If itemKey = "mo" Then


            moSD.Text = ""
            moIsClicked = "OK"
            moBarcode = bCode
            moDesc = itemDesc
            moN = note

        ElseIf itemKey = "mm" Then

            mmSD.Text = ""


            mmIsClicked = "OK"
            mmBarcode = bCode
            mmDesc = itemDesc
            mmN = note
        ElseIf itemKey = "dm" Then

            dmSD.Text = ""


            dmIsClicked = "OK"
            dmBarcode = bCode
            dmDesc = itemDesc
            dmN = note
        ElseIf itemKey = "hd" Then

            hdSD.Text = ""



            hdIsClicked = "OK"
            hdBarcode = bCode
            hdDesc = itemDesc
            hdN = note
        ElseIf itemKey = "pw" Then

            pwSD.Text = ""



            pwIsClicked = "OK"
            pwBarcode = bCode
            pwDesc = itemDesc
            pwN = note
        ElseIf itemKey = "om" Then

            omSD.Text = ""



            omIsClicked = "OK"
            omBarcode = bCode
            omDesc = itemDesc
            omN = note
        ElseIf itemKey = "kb" Then


            kbSD.Text = ""

            kbIsClicked = "OK"
            kbBarcode = bCode
            kbDesc = itemDesc
            kbN = note
        ElseIf itemKey = "ms" Then


            msSD.Text = ""


            msIsClicked = "OK"
            msBarcode = bCode
            msDesc = itemDesc
            msN = note
        ElseIf itemKey = "up" Then


            upSD.Text = ""

            upIsClicked = "OK"
            upBarcode = bCode
            upDesc = itemDesc
            upN = note
        End If





    End Sub




End Class