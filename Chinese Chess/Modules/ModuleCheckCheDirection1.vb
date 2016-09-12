' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 11/01/2011
' Descripitons : Chinese Chess V1

Module ModuleCheckCheDirection1
    Public PictureboxAbleToBlock(10) As Integer
    Dim i As Integer

    Public Sub CheA1EastMovementArea()
        i = 1
        If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox83Color()
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                Pic83None()
                PictureboxAbleToBlock(i) = 83
                CheckPicturebox84Color()
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                    Pic83None()
                    Pic84None()
                    PictureboxAbleToBlock(i) = 83
                    i = i + 1
                    PictureboxAbleToBlock(i) = 84
                    CheckPicturebox85Color()
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                        Pic83None()
                        Pic84None()
                        Pic85None()
                        PictureboxAbleToBlock(i) = 83
                        i = i + 1
                        PictureboxAbleToBlock(i) = 84
                        i = i + 1
                        PictureboxAbleToBlock(i) = 85
                        CheckPicturebox86Color()
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                            Pic83None()
                            Pic84None()
                            Pic85None()
                            Pic86None()
                            PictureboxAbleToBlock(i) = 83
                            i = i + 1
                            PictureboxAbleToBlock(i) = 84
                            i = i + 1
                            PictureboxAbleToBlock(i) = 85
                            i = i + 1
                            PictureboxAbleToBlock(i) = 86
                            CheckPicturebox87Color()
                            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                Pic83None()
                                Pic84None()
                                Pic85None()
                                Pic86None()
                                Pic87None()
                                PictureboxAbleToBlock(i) = 83
                                i = i + 1
                                PictureboxAbleToBlock(i) = 84
                                i = i + 1
                                PictureboxAbleToBlock(i) = 85
                                i = i + 1
                                PictureboxAbleToBlock(i) = 86
                                i = i + 1
                                PictureboxAbleToBlock(i) = 87
                                CheckPicturebox88Color()
                                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                    Pic83None()
                                    Pic84None()
                                    Pic85None()
                                    Pic86None()
                                    Pic87None()
                                    Pic88None()
                                    PictureboxAbleToBlock(i) = 83
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 84
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 85
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 86
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 87
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 88
                                    CheckPicturebox89Color()
                                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                        Pic83None()
                                        Pic84None()
                                        Pic85None()
                                        Pic86None()
                                        Pic87None()
                                        Pic88None()
                                        Pic89None()
                                        PictureboxAbleToBlock(i) = 83
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 84
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 85
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 86
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 87
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 88
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 89
                                        CheckPicturebox90Color()
                                    Else
                                        Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                                        Pic83None()
                                        Pic84None()
                                        Pic85None()
                                        Pic86None()
                                        Pic87None()
                                        Pic88None()
                                        Pic89None()
                                        Pic90None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA1NorthMovementArea()
        i = 1
        If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox73Color()
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                Pic73None()
                PictureboxAbleToBlock(i) = 73
                CheckPicturebox64Color()
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                    Pic73None()
                    Pic64None()
                    PictureboxAbleToBlock(i) = 73
                    i = i + 1
                    PictureboxAbleToBlock(i) = 64
                    CheckPicturebox55Color()
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                        Pic73None()
                        Pic64None()
                        Pic55None()
                        PictureboxAbleToBlock(i) = 73
                        i = i + 1
                        PictureboxAbleToBlock(i) = 64
                        i = i + 1
                        PictureboxAbleToBlock(i) = 55
                        CheckPicturebox46Color()
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                            Pic73None()
                            Pic64None()
                            Pic55None()
                            Pic46None()
                            PictureboxAbleToBlock(i) = 73
                            i = i + 1
                            PictureboxAbleToBlock(i) = 64
                            i = i + 1
                            PictureboxAbleToBlock(i) = 55
                            i = i + 1
                            PictureboxAbleToBlock(i) = 46
                            CheckPicturebox37Color()
                            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                Pic73None()
                                Pic64None()
                                Pic55None()
                                Pic46None()
                                Pic37None()
                                PictureboxAbleToBlock(i) = 73
                                i = i + 1
                                PictureboxAbleToBlock(i) = 64
                                i = i + 1
                                PictureboxAbleToBlock(i) = 55
                                i = i + 1
                                PictureboxAbleToBlock(i) = 46
                                i = i + 1
                                PictureboxAbleToBlock(i) = 37
                                CheckPicturebox28Color()
                                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                    Pic73None()
                                    Pic64None()
                                    Pic55None()
                                    Pic46None()
                                    Pic37None()
                                    Pic28None()
                                    PictureboxAbleToBlock(i) = 73
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 64
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 55
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 46
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 37
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 28
                                    CheckPicturebox19Color()
                                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                        Pic73None()
                                        Pic64None()
                                        Pic55None()
                                        Pic46None()
                                        Pic37None()
                                        Pic28None()
                                        Pic19None()
                                        PictureboxAbleToBlock(i) = 73
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 64
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 55
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 46
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 37
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 28
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 19
                                        CheckPicturebox10Color()
                                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                            Pic73None()
                                            Pic64None()
                                            Pic55None()
                                            Pic46None()
                                            Pic37None()
                                            Pic28None()
                                            Pic19None()
                                            Pic10None()
                                            PictureboxAbleToBlock(i) = 73
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 64
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 55
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 46
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 37
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 28
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 19
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 10
                                            CheckPicturebox1Color()
                                        Else
                                            Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                                            Pic73None()
                                            Pic64None()
                                            Pic55None()
                                            Pic46None()
                                            Pic37None()
                                            Pic28None()
                                            Pic19None()
                                            Pic10None()
                                            Pic1None()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB1EastMovementArea()
        i = 1
        If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox84Color()
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                Pic84None()
                PictureboxAbleToBlock(i) = 84
                CheckPicturebox85Color()
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                    Pic84None()
                    Pic85None()
                    PictureboxAbleToBlock(i) = 84
                    i = i + 1
                    PictureboxAbleToBlock(i) = 85
                    CheckPicturebox86Color()
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                        Pic84None()
                        Pic85None()
                        Pic86None()
                        PictureboxAbleToBlock(i) = 84
                        i = i + 1
                        PictureboxAbleToBlock(i) = 85
                        i = i + 1
                        PictureboxAbleToBlock(i) = 86
                        CheckPicturebox87Color()
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                            Pic84None()
                            Pic85None()
                            Pic86None()
                            Pic87None()
                            PictureboxAbleToBlock(i) = 84
                            i = i + 1
                            PictureboxAbleToBlock(i) = 85
                            i = i + 1
                            PictureboxAbleToBlock(i) = 86
                            i = i + 1
                            PictureboxAbleToBlock(i) = 87
                            CheckPicturebox88Color()
                            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                Pic84None()
                                Pic85None()
                                Pic86None()
                                Pic87None()
                                Pic88None()
                                PictureboxAbleToBlock(i) = 84
                                i = i + 1
                                PictureboxAbleToBlock(i) = 85
                                i = i + 1
                                PictureboxAbleToBlock(i) = 86
                                i = i + 1
                                PictureboxAbleToBlock(i) = 87
                                i = i + 1
                                PictureboxAbleToBlock(i) = 88
                                CheckPicturebox89Color()
                                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                    Pic84None()
                                    Pic85None()
                                    Pic86None()
                                    Pic87None()
                                    Pic88None()
                                    Pic89None()
                                    PictureboxAbleToBlock(i) = 84
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 85
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 86
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 87
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 88
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 89
                                    CheckPicturebox90Color()
                                Else
                                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                                    Pic84None()
                                    Pic85None()
                                    Pic86None()
                                    Pic87None()
                                    Pic88None()
                                    Pic89None()
                                    Pic90None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Public Sub CheB1WestMovementArea()
        If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox82Color()
        Else
            Form1.PictureBox82.Image = Form1.movementAreaPic.Image
        End If
    End Sub

    Public Sub CheB1NorthMovementArea()
        i = 1

        If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox74Color()
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                Pic74None()
                PictureboxAbleToBlock(i) = 74
                CheckPicturebox65Color()
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                    Pic74None()
                    Pic65None()
                    PictureboxAbleToBlock(i) = 74
                    i = i + 1
                    PictureboxAbleToBlock(i) = 65
                    CheckPicturebox56Color()
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                        Pic74None()
                        Pic65None()
                        Pic56None()
                        PictureboxAbleToBlock(i) = 74
                        i = i + 1
                        PictureboxAbleToBlock(i) = 65
                        i = i + 1
                        PictureboxAbleToBlock(i) = 56
                        CheckPicturebox47Color()
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                            Pic74None()
                            Pic65None()
                            Pic56None()
                            Pic47None()
                            PictureboxAbleToBlock(i) = 74
                            i = i + 1
                            PictureboxAbleToBlock(i) = 65
                            i = i + 1
                            PictureboxAbleToBlock(i) = 56
                            i = i + 1
                            PictureboxAbleToBlock(i) = 47
                            CheckPicturebox38Color()
                            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Pic74None()
                                Pic65None()
                                Pic56None()
                                Pic47None()
                                Pic38None()
                                PictureboxAbleToBlock(i) = 74
                                i = i + 1
                                PictureboxAbleToBlock(i) = 65
                                i = i + 1
                                PictureboxAbleToBlock(i) = 56
                                i = i + 1
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                                CheckPicturebox29Color()
                                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                    Pic74None()
                                    Pic65None()
                                    Pic56None()
                                    Pic47None()
                                    Pic38None()
                                    Pic29None()
                                    PictureboxAbleToBlock(i) = 74
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 65
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 56
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 47
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 38
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 29
                                    CheckPicturebox20Color()
                                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                        Pic74None()
                                        Pic65None()
                                        Pic56None()
                                        Pic47None()
                                        Pic38None()
                                        Pic29None()
                                        Pic20None()
                                        PictureboxAbleToBlock(i) = 74
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 65
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 56
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 47
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 38
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 29
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 20
                                        CheckPicturebox11Color()
                                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                            Pic74None()
                                            Pic65None()
                                            Pic56None()
                                            Pic47None()
                                            Pic38None()
                                            Pic29None()
                                            Pic20None()
                                            Pic11None()
                                            PictureboxAbleToBlock(i) = 74
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 65
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 56
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 47
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 38
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 29
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 20
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 11
                                            CheckPicturebox2Color()
                                        Else
                                            Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                            Pic74None()
                                            Pic65None()
                                            Pic56None()
                                            Pic47None()
                                            Pic38None()
                                            Pic29None()
                                            Pic20None()
                                            Pic11None()
                                            Pic2None()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC1EastMovementArea()
        i = 1
        If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox85Color()
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                Pic85None()
                PictureboxAbleToBlock(i) = 85
                CheckPicturebox86Color()
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                    Pic85None()
                    Pic86None()
                    PictureboxAbleToBlock(i) = 85
                    i = i + 1
                    PictureboxAbleToBlock(i) = 86
                    CheckPicturebox87Color()
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                        Pic85None()
                        Pic86None()
                        Pic87None()
                        PictureboxAbleToBlock(i) = 85
                        i = i + 1
                        PictureboxAbleToBlock(i) = 86
                        i = i + 1
                        PictureboxAbleToBlock(i) = 87
                        CheckPicturebox88Color()
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                            Pic85None()
                            Pic86None()
                            Pic87None()
                            Pic88None()
                            PictureboxAbleToBlock(i) = 85
                            i = i + 1
                            PictureboxAbleToBlock(i) = 86
                            i = i + 1
                            PictureboxAbleToBlock(i) = 87
                            i = i + 1
                            PictureboxAbleToBlock(i) = 88
                            CheckPicturebox89Color()
                            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                Pic85None()
                                Pic86None()
                                Pic87None()
                                Pic88None()
                                Pic89None()
                                PictureboxAbleToBlock(i) = 85
                                i = i + 1
                                PictureboxAbleToBlock(i) = 86
                                i = i + 1
                                PictureboxAbleToBlock(i) = 87
                                i = i + 1
                                PictureboxAbleToBlock(i) = 88
                                i = i + 1
                                PictureboxAbleToBlock(i) = 89
                                CheckPicturebox90Color()
                            Else
                                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                                Pic85None()
                                Pic86None()
                                Pic87None()
                                Pic88None()
                                Pic89None()
                                Pic90None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC1WestMovementArea()
        i = 1

        If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox83Color()
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                Pic83None()
                PictureboxAbleToBlock(i) = 83
                CheckPicturebox82Color()
            Else
                Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                Pic83None()
                Pic82None()
            End If
        End If
    End Sub

    Public Sub CheC1NorthMovementArea()
        i = 1
        If Form1.PictureBox75.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox75Color()
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                Pic75None()
                PictureboxAbleToBlock(i) = 75
                CheckPicturebox66Color()
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                    Pic75None()
                    Pic66None()
                    PictureboxAbleToBlock(i) = 75
                    i = i + 1
                    PictureboxAbleToBlock(i) = 66
                    CheckPicturebox57Color()
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                        Pic75None()
                        Pic66None()
                        Pic57None()
                        PictureboxAbleToBlock(i) = 75
                        i = i + 1
                        PictureboxAbleToBlock(i) = 66
                        i = i + 1
                        PictureboxAbleToBlock(i) = 57
                        CheckPicturebox48Color()
                        Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Pic75None()
                            Pic66None()
                            Pic57None()
                            Pic48None()
                            PictureboxAbleToBlock(i) = 75
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            CheckPicturebox39Color()
                            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Pic75None()
                                Pic66None()
                                Pic57None()
                                Pic48None()
                                Pic39None()
                                PictureboxAbleToBlock(i) = 75
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                CheckPicturebox30Color()
                                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Pic75None()
                                    Pic66None()
                                    Pic57None()
                                    Pic48None()
                                    Pic39None()
                                    Pic30None()
                                    PictureboxAbleToBlock(i) = 75
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 30
                                    CheckPicturebox21Color()
                                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                        Pic75None()
                                        Pic66None()
                                        Pic57None()
                                        Pic48None()
                                        Pic39None()
                                        Pic30None()
                                        Pic21None()
                                        PictureboxAbleToBlock(i) = 75
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 66
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 57
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 48
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 39
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 30
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 21
                                        CheckPicturebox12Color()
                                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                            Pic75None()
                                            Pic66None()
                                            Pic57None()
                                            Pic48None()
                                            Pic39None()
                                            Pic30None()
                                            Pic21None()
                                            Pic12None()
                                            PictureboxAbleToBlock(i) = 75
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 66
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 57
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 48
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 39
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 30
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 21
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 12
                                            CheckPicturebox3Color()
                                        Else
                                            Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                            Pic75None()
                                            Pic66None()
                                            Pic57None()
                                            Pic48None()
                                            Pic39None()
                                            Pic30None()
                                            Pic21None()
                                            Pic12None()
                                            Pic3None()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD1EastMovementArea()
        i = 1
        If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox86Color()
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                Pic86None()
                PictureboxAbleToBlock(i) = 86
                CheckPicturebox87Color()
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                    Pic86None()
                    Pic87None()
                    PictureboxAbleToBlock(i) = 86
                    i = i + 1
                    PictureboxAbleToBlock(i) = 87
                    CheckPicturebox88Color()
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                        Pic86None()
                        Pic87None()
                        Pic88None()
                        PictureboxAbleToBlock(i) = 86
                        i = i + 1
                        PictureboxAbleToBlock(i) = 87
                        i = i + 1
                        PictureboxAbleToBlock(i) = 88
                        CheckPicturebox89Color()
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                            Pic86None()
                            Pic87None()
                            Pic88None()
                            Pic89None()
                            PictureboxAbleToBlock(i) = 86
                            i = i + 1
                            PictureboxAbleToBlock(i) = 87
                            i = i + 1
                            PictureboxAbleToBlock(i) = 88
                            i = i + 1
                            PictureboxAbleToBlock(i) = 89
                            CheckPicturebox90Color()
                        Else
                            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                            Pic86None()
                            Pic87None()
                            Pic88None()
                            Pic89None()
                            Pic90None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD1WestMovementArea()
        i = 1

        If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox84Color()
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                Pic84None()
                PictureboxAbleToBlock(i) = 84
                CheckPicturebox83Color()
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                    Pic84None()
                    Pic83None()
                    CheckPicturebox82Color()
                Else
                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                    Pic84None()
                    Pic83None()
                    Pic82None()
                End If
            End If
        End If
    End Sub

    Public Sub CheD1NorthMovementArea()
        i = 1
        If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox76Color()
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                Pic76None()
                PictureboxAbleToBlock(i) = 76
                CheckPicturebox67Color()
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                    Pic76None()
                    Pic67None()
                    PictureboxAbleToBlock(i) = 76
                    i = i + 1
                    PictureboxAbleToBlock(i) = 67
                    CheckPicturebox58Color()
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Pic76None()
                        Pic67None()
                        Pic58None()
                        PictureboxAbleToBlock(i) = 76
                        i = i + 1
                        PictureboxAbleToBlock(i) = 67
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        CheckPicturebox49Color()
                        Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Pic76None()
                            Pic67None()
                            Pic58None()
                            Pic49None()
                            PictureboxAbleToBlock(i) = 76
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            CheckPicturebox40Color()
                            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Pic76None()
                                Pic67None()
                                Pic58None()
                                Pic49None()
                                Pic40None()
                                PictureboxAbleToBlock(i) = 76
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                CheckPicturebox31Color()
                                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Pic76None()
                                    Pic67None()
                                    Pic58None()
                                    Pic49None()
                                    Pic40None()
                                    Pic31None()
                                    PictureboxAbleToBlock(i) = 76
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    CheckPicturebox22Color()
                                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                        Pic76None()
                                        Pic67None()
                                        Pic58None()
                                        Pic49None()
                                        Pic40None()
                                        Pic31None()
                                        Pic22None()
                                        PictureboxAbleToBlock(i) = 76
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 67
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 58
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 49
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 40
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 31
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 22
                                        CheckPicturebox13Color()
                                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                            Pic76None()
                                            Pic67None()
                                            Pic58None()
                                            Pic49None()
                                            Pic40None()
                                            Pic31None()
                                            Pic22None()
                                            Pic13None()
                                            PictureboxAbleToBlock(i) = 76
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 67
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 58
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 49
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 40
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 31
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 22
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 13
                                            CheckPicturebox4Color()
                                        Else
                                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                            Pic76None()
                                            Pic67None()
                                            Pic58None()
                                            Pic49None()
                                            Pic40None()
                                            Pic31None()
                                            Pic22None()
                                            Pic13None()
                                            Pic4None()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE1EastMovementArea()
        i = 1
        If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox87Color()
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                Pic87None()
                PictureboxAbleToBlock(i) = 87
                CheckPicturebox88Color()
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                    Pic87None()
                    Pic88None()
                    PictureboxAbleToBlock(i) = 87
                    i = i + 1
                    PictureboxAbleToBlock(i) = 88
                    CheckPicturebox89Color()
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                        Pic87None()
                        Pic88None()
                        Pic89None()
                        PictureboxAbleToBlock(i) = 87
                        i = i + 1
                        PictureboxAbleToBlock(i) = 88
                        i = i + 1
                        PictureboxAbleToBlock(i) = 89
                        CheckPicturebox90Color()
                    Else
                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                        Pic87None()
                        Pic88None()
                        Pic89None()
                        Pic90None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE1WestMovementArea()
        i = 1
        If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox85Color()
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                Pic85None()
                PictureboxAbleToBlock(i) = 85
                CheckPicturebox84Color()
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                    Pic85None()
                    Pic84None()
                    PictureboxAbleToBlock(i) = 85
                    i = i + 1
                    PictureboxAbleToBlock(i) = 84
                    CheckPicturebox83Color()
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                        Pic85None()
                        Pic84None()
                        Pic83None()
                        PictureboxAbleToBlock(i) = 85
                        i = i + 1
                        PictureboxAbleToBlock(i) = 84
                        i = i + 1
                        PictureboxAbleToBlock(i) = 83
                        CheckPicturebox82Color()
                    Else
                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                        Pic85None()
                        Pic84None()
                        Pic83None()
                        Pic82None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE1NorthMovementArea()
        i = 1

        If Form1.PictureBox77.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox77Color()
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox68.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
                PictureboxAbleToBlock(i) = 77
                CheckPicturebox68Color()
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    Pic77None()
                    Pic68None()
                    PictureboxAbleToBlock(i) = 77
                    i = i + 1
                    PictureboxAbleToBlock(i) = 68
                    CheckPicturebox59Color()
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Pic77None()
                        Pic68None()
                        Pic59None()
                        PictureboxAbleToBlock(i) = 77
                        i = i + 1
                        PictureboxAbleToBlock(i) = 68
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        CheckPicturebox50Color()
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Pic77None()
                            Pic68None()
                            Pic59None()
                            Pic50None()
                            PictureboxAbleToBlock(i) = 77
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            CheckPicturebox41Color()
                            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Pic77None()
                                Pic68None()
                                Pic59None()
                                Pic50None()
                                Pic41None()
                                PictureboxAbleToBlock(i) = 77
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                CheckPicturebox32Color()
                                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Pic77None()
                                    Pic68None()
                                    Pic59None()
                                    Pic50None()
                                    Pic41None()
                                    Pic32None()
                                    PictureboxAbleToBlock(i) = 77
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    CheckPicturebox23Color()
                                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                        Pic77None()
                                        Pic68None()
                                        Pic59None()
                                        Pic50None()
                                        Pic41None()
                                        Pic32None()
                                        Pic23None()
                                        PictureboxAbleToBlock(i) = 77
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 68
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 59
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 50
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 41
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 32
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 23
                                        CheckPicturebox14Color()
                                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                            Pic77None()
                                            Pic68None()
                                            Pic59None()
                                            Pic50None()
                                            Pic41None()
                                            Pic32None()
                                            Pic23None()
                                            Pic14None()
                                            PictureboxAbleToBlock(i) = 77
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 68
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 59
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 50
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 41
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 32
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 23
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 14
                                            CheckPicturebox5Color()
                                        Else
                                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                            Pic77None()
                                            Pic68None()
                                            Pic59None()
                                            Pic50None()
                                            Pic41None()
                                            Pic32None()
                                            Pic23None()
                                            Pic14None()
                                            Pic5None()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF1EastMovementArea()
        i = 1
        If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox88Color()
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                Pic88None()
                PictureboxAbleToBlock(i) = 88
                CheckPicturebox89Color()
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                    Pic88None()
                    Pic89None()
                    PictureboxAbleToBlock(i) = 88
                    i = i + 1
                    PictureboxAbleToBlock(i) = 89
                    CheckPicturebox90Color()
                Else
                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                    Pic88None()
                    Pic89None()
                    Pic90None()
                End If
            End If
        End If
    End Sub

    Public Sub CheF1WestMovementArea()
        i = 1
        If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox86Color()
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                Pic86None()
                PictureboxAbleToBlock(i) = 86
                CheckPicturebox85Color()
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                    Pic86None()
                    Pic85None()
                    PictureboxAbleToBlock(i) = 86
                    i = i + 1
                    PictureboxAbleToBlock(i) = 85
                    CheckPicturebox84Color()
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                        Pic86None()
                        Pic85None()
                        Pic84None()
                        PictureboxAbleToBlock(i) = 86
                        i = i + 1
                        PictureboxAbleToBlock(i) = 85
                        i = i + 1
                        PictureboxAbleToBlock(i) = 84
                        CheckPicturebox83Color()
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                            Pic86None()
                            Pic85None()
                            Pic84None()
                            Pic83None()
                            PictureboxAbleToBlock(i) = 86
                            i = i + 1
                            PictureboxAbleToBlock(i) = 85
                            i = i + 1
                            PictureboxAbleToBlock(i) = 84
                            i = i + 1
                            PictureboxAbleToBlock(i) = 83
                            CheckPicturebox82Color()
                        Else
                            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                            Pic86None()
                            Pic85None()
                            Pic84None()
                            Pic83None()
                            Pic82None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF1NorthMovementArea()
        i = 1
        If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox78Color()
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
                PictureboxAbleToBlock(i) = 78
                CheckPicturebox69Color()
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    Pic78None()
                    Pic69None()
                    PictureboxAbleToBlock(i) = 78
                    i = i + 1
                    PictureboxAbleToBlock(i) = 69
                    CheckPicturebox60Color()
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Pic78None()
                        Pic69None()
                        Pic60None()
                        PictureboxAbleToBlock(i) = 78
                        i = i + 1
                        PictureboxAbleToBlock(i) = 69
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        CheckPicturebox51Color()
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Pic78None()
                            Pic69None()
                            Pic60None()
                            Pic51None()
                            PictureboxAbleToBlock(i) = 78
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            CheckPicturebox42Color()
                            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Pic78None()
                                Pic69None()
                                Pic60None()
                                Pic51None()
                                Pic42None()
                                PictureboxAbleToBlock(i) = 78
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                CheckPicturebox33Color()
                                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Pic78None()
                                    Pic69None()
                                    Pic60None()
                                    Pic51None()
                                    Pic42None()
                                    Pic33None()
                                    PictureboxAbleToBlock(i) = 78
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    CheckPicturebox24Color()
                                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                        Pic78None()
                                        Pic69None()
                                        Pic60None()
                                        Pic51None()
                                        Pic42None()
                                        Pic33None()
                                        Pic24None()
                                        PictureboxAbleToBlock(i) = 78
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 69
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 60
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 51
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 42
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 33
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 24
                                        CheckPicturebox15Color()
                                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                            Pic78None()
                                            Pic69None()
                                            Pic60None()
                                            Pic51None()
                                            Pic42None()
                                            Pic33None()
                                            Pic24None()
                                            Pic15None()
                                            PictureboxAbleToBlock(i) = 78
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 69
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 60
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 51
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 42
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 33
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 24
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 15
                                            CheckPicturebox6Color()
                                        Else
                                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                            Pic78None()
                                            Pic69None()
                                            Pic60None()
                                            Pic51None()
                                            Pic42None()
                                            Pic33None()
                                            Pic24None()
                                            Pic15None()
                                            Pic6None()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG1EastMovementArea()
        i = 1
        If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox89Color()
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                Pic89None()
                PictureboxAbleToBlock(i) = 89
                CheckPicturebox90Color()
            Else
                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                Pic89None()
                Pic90None()
            End If
        End If
    End Sub

    Public Sub CheG1WestMovementArea()
        i = 1
        If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox87Color()
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                Pic87None()
                PictureboxAbleToBlock(i) = 87
                CheckPicturebox86Color()
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                    Pic87None()
                    Pic86None()
                    PictureboxAbleToBlock(i) = 87
                    i = i + 1
                    PictureboxAbleToBlock(i) = 86
                    CheckPicturebox85Color()
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                        Pic87None()
                        Pic86None()
                        Pic85None()
                        PictureboxAbleToBlock(i) = 87
                        i = i + 1
                        PictureboxAbleToBlock(i) = 86
                        i = i + 1
                        PictureboxAbleToBlock(i) = 85
                        CheckPicturebox84Color()
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                            Pic87None()
                            Pic86None()
                            Pic85None()
                            Pic84None()
                            PictureboxAbleToBlock(i) = 87
                            i = i + 1
                            PictureboxAbleToBlock(i) = 86
                            i = i + 1
                            PictureboxAbleToBlock(i) = 85
                            i = i + 1
                            PictureboxAbleToBlock(i) = 84
                            CheckPicturebox83Color()
                            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                Pic87None()
                                Pic86None()
                                Pic85None()
                                Pic84None()
                                Pic83None()
                                PictureboxAbleToBlock(i) = 87
                                i = i + 1
                                PictureboxAbleToBlock(i) = 86
                                i = i + 1
                                PictureboxAbleToBlock(i) = 85
                                i = i + 1
                                PictureboxAbleToBlock(i) = 84
                                i = i + 1
                                PictureboxAbleToBlock(i) = 83
                                CheckPicturebox82Color()
                            Else
                                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                                Pic87None()
                                Pic86None()
                                Pic85None()
                                Pic84None()
                                Pic83None()
                                Pic82None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG1NorthMovementArea()
        i = 1
        If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox79Color()
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                Pic79None()
                PictureboxAbleToBlock(i) = 79
                CheckPicturebox70Color()
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    Pic79None()
                    Pic70None()
                    PictureboxAbleToBlock(i) = 79
                    i = i + 1
                    PictureboxAbleToBlock(i) = 70
                    CheckPicturebox61Color()
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                        Pic79None()
                        Pic70None()
                        Pic61None()
                        PictureboxAbleToBlock(i) = 79
                        i = i + 1
                        PictureboxAbleToBlock(i) = 70
                        i = i + 1
                        PictureboxAbleToBlock(i) = 61
                        CheckPicturebox52Color()
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Pic79None()
                            Pic70None()
                            Pic61None()
                            Pic52None()
                            PictureboxAbleToBlock(i) = 79
                            i = i + 1
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            CheckPicturebox43Color()
                            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Pic79None()
                                Pic70None()
                                Pic61None()
                                Pic52None()
                                Pic43None()
                                PictureboxAbleToBlock(i) = 79
                                i = i + 1
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                CheckPicturebox34Color()
                                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Pic79None()
                                    Pic70None()
                                    Pic61None()
                                    Pic52None()
                                    Pic43None()
                                    Pic34None()
                                    PictureboxAbleToBlock(i) = 79
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    CheckPicturebox25Color()
                                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                        Pic79None()
                                        Pic70None()
                                        Pic61None()
                                        Pic52None()
                                        Pic43None()
                                        Pic34None()
                                        Pic25None()
                                        PictureboxAbleToBlock(i) = 79
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 70
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 61
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 52
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 43
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 34
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 25
                                        CheckPicturebox16Color()
                                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                            Pic79None()
                                            Pic70None()
                                            Pic61None()
                                            Pic52None()
                                            Pic43None()
                                            Pic34None()
                                            Pic25None()
                                            Pic16None()
                                            PictureboxAbleToBlock(i) = 79
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 70
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 61
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 52
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 43
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 34
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 25
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 16
                                            CheckPicturebox7Color()
                                        Else
                                            Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                            Pic79None()
                                            Pic70None()
                                            Pic61None()
                                            Pic52None()
                                            Pic43None()
                                            Pic34None()
                                            Pic25None()
                                            Pic16None()
                                            Pic7None()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH1EastMovementArea()
        If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox90Color()
        Else
            Form1.PictureBox90.Image = Form1.movementAreaPic.Image
            Pic90None()
        End If
    End Sub

    Public Sub CheH1WestMovementArea()
        i = 1
        If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox88Color()
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                Pic88None()
                PictureboxAbleToBlock(i) = 88
                CheckPicturebox87Color()
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                    Pic88None()
                    Pic87None()
                    PictureboxAbleToBlock(i) = 88
                    i = i + 1
                    PictureboxAbleToBlock(i) = 87
                    CheckPicturebox86Color()
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                        Pic88None()
                        Pic87None()
                        Pic86None()
                        PictureboxAbleToBlock(i) = 88
                        i = i + 1
                        PictureboxAbleToBlock(i) = 87
                        i = i + 1
                        PictureboxAbleToBlock(i) = 86
                        CheckPicturebox85Color()
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                            Pic88None()
                            Pic87None()
                            Pic86None()
                            Pic85None()
                            PictureboxAbleToBlock(i) = 88
                            i = i + 1
                            PictureboxAbleToBlock(i) = 87
                            i = i + 1
                            PictureboxAbleToBlock(i) = 86
                            i = i + 1
                            PictureboxAbleToBlock(i) = 85
                            CheckPicturebox84Color()
                            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                Pic88None()
                                Pic87None()
                                Pic86None()
                                Pic85None()
                                Pic84None()
                                PictureboxAbleToBlock(i) = 88
                                i = i + 1
                                PictureboxAbleToBlock(i) = 87
                                i = i + 1
                                PictureboxAbleToBlock(i) = 86
                                i = i + 1
                                PictureboxAbleToBlock(i) = 85
                                i = i + 1
                                PictureboxAbleToBlock(i) = 84
                                CheckPicturebox83Color()
                                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                    Pic88None()
                                    Pic87None()
                                    Pic86None()
                                    Pic85None()
                                    Pic84None()
                                    Pic83None()
                                    PictureboxAbleToBlock(i) = 88
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 87
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 86
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 85
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 84
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 83
                                    CheckPicturebox82Color()
                                Else
                                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                                    Pic88None()
                                    Pic87None()
                                    Pic86None()
                                    Pic85None()
                                    Pic84None()
                                    Pic83None()
                                    Pic82None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH1NorthMovementArea()
        i = 1
        If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox80Color()
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                Pic80None()
                PictureboxAbleToBlock(i) = 80
                CheckPicturebox71Color()
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    Pic80None()
                    Pic71None()
                    PictureboxAbleToBlock(i) = 80
                    i = i + 1
                    PictureboxAbleToBlock(i) = 71
                    CheckPicturebox62Color()
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                        Pic80None()
                        Pic71None()
                        Pic62None()
                        PictureboxAbleToBlock(i) = 80
                        i = i + 1
                        PictureboxAbleToBlock(i) = 71
                        i = i + 1
                        PictureboxAbleToBlock(i) = 62
                        CheckPicturebox53Color()
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                            Pic80None()
                            Pic71None()
                            Pic62None()
                            Pic53None()
                            PictureboxAbleToBlock(i) = 80
                            i = i + 1
                            PictureboxAbleToBlock(i) = 71
                            i = i + 1
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 53
                            CheckPicturebox44Color()
                            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Pic80None()
                                Pic71None()
                                Pic62None()
                                Pic53None()
                                Pic44None()
                                PictureboxAbleToBlock(i) = 80
                                i = i + 1
                                PictureboxAbleToBlock(i) = 71
                                i = i + 1
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                CheckPicturebox35Color()
                                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                    Pic80None()
                                    Pic71None()
                                    Pic62None()
                                    Pic53None()
                                    Pic44None()
                                    Pic35None()
                                    PictureboxAbleToBlock(i) = 80
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 71
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 35
                                    CheckPicturebox26Color()
                                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                        Pic80None()
                                        Pic71None()
                                        Pic62None()
                                        Pic53None()
                                        Pic44None()
                                        Pic35None()
                                        Pic26None()
                                        PictureboxAbleToBlock(i) = 80
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 71
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 62
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 53
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 44
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 35
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 26
                                        CheckPicturebox17Color()
                                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                            Pic80None()
                                            Pic71None()
                                            Pic62None()
                                            Pic53None()
                                            Pic44None()
                                            Pic35None()
                                            Pic26None()
                                            Pic17None()
                                            PictureboxAbleToBlock(i) = 80
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 71
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 62
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 53
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 44
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 35
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 26
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 17
                                            CheckPicturebox8Color()
                                        Else
                                            Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                            Pic80None()
                                            Pic71None()
                                            Pic62None()
                                            Pic53None()
                                            Pic44None()
                                            Pic35None()
                                            Pic26None()
                                            Pic17None()
                                            Pic8None()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI1WestMovementArea()
        i = 1
        If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox89Color()
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                Pic89None()
                PictureboxAbleToBlock(i) = 89
                CheckPicturebox88Color()
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                    Pic89None()
                    Pic88None()
                    PictureboxAbleToBlock(i) = 89
                    i = i + 1
                    PictureboxAbleToBlock(i) = 88
                    CheckPicturebox87Color()
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                        Pic89None()
                        Pic88None()
                        Pic87None()
                        PictureboxAbleToBlock(i) = 89
                        i = i + 1
                        PictureboxAbleToBlock(i) = 88
                        i = i + 1
                        PictureboxAbleToBlock(i) = 87
                        CheckPicturebox86Color()
                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                            Pic89None()
                            Pic88None()
                            Pic87None()
                            Pic86None()
                            PictureboxAbleToBlock(i) = 89
                            i = i + 1
                            PictureboxAbleToBlock(i) = 88
                            i = i + 1
                            PictureboxAbleToBlock(i) = 87
                            i = i + 1
                            PictureboxAbleToBlock(i) = 86
                            CheckPicturebox85Color()
                            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                Pic89None()
                                Pic88None()
                                Pic87None()
                                Pic86None()
                                Pic85None()
                                PictureboxAbleToBlock(i) = 89
                                i = i + 1
                                PictureboxAbleToBlock(i) = 88
                                i = i + 1
                                PictureboxAbleToBlock(i) = 87
                                i = i + 1
                                PictureboxAbleToBlock(i) = 86
                                i = i + 1
                                PictureboxAbleToBlock(i) = 85
                                CheckPicturebox84Color()
                                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                    Pic89None()
                                    Pic88None()
                                    Pic87None()
                                    Pic86None()
                                    Pic85None()
                                    Pic84None()
                                    PictureboxAbleToBlock(i) = 89
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 88
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 87
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 86
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 85
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 84
                                    CheckPicturebox83Color()
                                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                        Pic89None()
                                        Pic88None()
                                        Pic87None()
                                        Pic86None()
                                        Pic85None()
                                        Pic84None()
                                        Pic83None()
                                        PictureboxAbleToBlock(i) = 89
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 88
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 87
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 86
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 85
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 84
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 83
                                        CheckPicturebox82Color()
                                    Else
                                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                                        Pic89None()
                                        Pic88None()
                                        Pic87None()
                                        Pic86None()
                                        Pic85None()
                                        Pic84None()
                                        Pic83None()
                                        Pic82None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI1NorthMovementArea()
        i = 1
        If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox81Color()
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                Pic81None()
                PictureboxAbleToBlock(i) = 81
                CheckPicturebox72Color()
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                    Pic81None()
                    Pic72None()
                    PictureboxAbleToBlock(i) = 81
                    i = i + 1
                    PictureboxAbleToBlock(i) = 72
                    CheckPicturebox63Color()
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                        Pic81None()
                        Pic72None()
                        Pic63None()
                        PictureboxAbleToBlock(i) = 81
                        i = i + 1
                        PictureboxAbleToBlock(i) = 72
                        i = i + 1
                        PictureboxAbleToBlock(i) = 63
                        CheckPicturebox54Color()
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                            Pic81None()
                            Pic72None()
                            Pic63None()
                            Pic54None()
                            PictureboxAbleToBlock(i) = 81
                            i = i + 1
                            PictureboxAbleToBlock(i) = 72
                            i = i + 1
                            PictureboxAbleToBlock(i) = 63
                            i = i + 1
                            PictureboxAbleToBlock(i) = 54
                            CheckPicturebox45Color()
                            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                Pic81None()
                                Pic72None()
                                Pic63None()
                                Pic54None()
                                Pic45None()
                                PictureboxAbleToBlock(i) = 81
                                i = i + 1
                                PictureboxAbleToBlock(i) = 72
                                i = i + 1
                                PictureboxAbleToBlock(i) = 63
                                i = i + 1
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                CheckPicturebox36Color()
                                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                    Pic81None()
                                    Pic72None()
                                    Pic63None()
                                    Pic54None()
                                    Pic45None()
                                    Pic36None()
                                    PictureboxAbleToBlock(i) = 81
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 72
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 63
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 54
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 45
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 36
                                    CheckPicturebox27Color()
                                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                        Pic81None()
                                        Pic72None()
                                        Pic63None()
                                        Pic54None()
                                        Pic45None()
                                        Pic36None()
                                        Pic27None()
                                        PictureboxAbleToBlock(i) = 81
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 72
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 63
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 54
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 45
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 36
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 27
                                        CheckPicturebox18Color()
                                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                            Pic81None()
                                            Pic72None()
                                            Pic63None()
                                            Pic54None()
                                            Pic45None()
                                            Pic36None()
                                            Pic27None()
                                            Pic18None()
                                            PictureboxAbleToBlock(i) = 81
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 72
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 63
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 54
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 45
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 36
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 27
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 18
                                            CheckPicturebox9Color()
                                        Else
                                            Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                                            Pic81None()
                                            Pic72None()
                                            Pic63None()
                                            Pic54None()
                                            Pic45None()
                                            Pic36None()
                                            Pic27None()
                                            Pic18None()
                                            Pic9None()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA2EastMovementArea()
        i = 1
        If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox74Color()
            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox75.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                Pic74None()
                PictureboxAbleToBlock(i) = 74
                CheckPicturebox75Color()
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                    Pic74None()
                    Pic75None()
                    PictureboxAbleToBlock(i) = 74
                    i = i + 1
                    PictureboxAbleToBlock(i) = 75
                    CheckPicturebox76Color()
                    Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox77.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                        Pic74None()
                        Pic75None()
                        Pic76None()
                        PictureboxAbleToBlock(i) = 74
                        i = i + 1
                        PictureboxAbleToBlock(i) = 75
                        i = i + 1
                        PictureboxAbleToBlock(i) = 76
                        CheckPicturebox77Color()
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                            Pic74None()
                            Pic75None()
                            Pic76None()
                            Pic77None()
                            PictureboxAbleToBlock(i) = 74
                            i = i + 1
                            PictureboxAbleToBlock(i) = 75
                            i = i + 1
                            PictureboxAbleToBlock(i) = 76
                            i = i + 1
                            PictureboxAbleToBlock(i) = 77
                            CheckPicturebox78Color()
                            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                Pic74None()
                                Pic75None()
                                Pic76None()
                                Pic77None()
                                Pic78None()
                                PictureboxAbleToBlock(i) = 74
                                i = i + 1
                                PictureboxAbleToBlock(i) = 75
                                i = i + 1
                                PictureboxAbleToBlock(i) = 76
                                i = i + 1
                                PictureboxAbleToBlock(i) = 77
                                i = i + 1
                                PictureboxAbleToBlock(i) = 78
                                CheckPicturebox79Color()
                                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                    Pic74None()
                                    Pic75None()
                                    Pic76None()
                                    Pic77None()
                                    Pic78None()
                                    Pic79None()
                                    PictureboxAbleToBlock(i) = 74
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 75
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 76
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 77
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 78
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 79
                                    CheckPicturebox80Color()
                                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                        Pic74None()
                                        Pic75None()
                                        Pic76None()
                                        Pic77None()
                                        Pic78None()
                                        Pic79None()
                                        Pic80None()
                                        PictureboxAbleToBlock(i) = 74
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 75
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 76
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 77
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 78
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 79
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 80
                                        CheckPicturebox81Color()
                                    Else
                                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                        Pic74None()
                                        Pic75None()
                                        Pic76None()
                                        Pic77None()
                                        Pic78None()
                                        Pic79None()
                                        Pic80None()
                                        Pic81None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA2SouthMovementArea()
        If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox82Color()
        Else
            Form1.PictureBox82.Image = Form1.movementAreaPic.Image
            Pic82None()
        End If
    End Sub

    Public Sub CheA2NorthMovementArea()
        i = 1
        If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox64Color()
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                Pic64None()
                PictureboxAbleToBlock(i) = 64
                CheckPicturebox55Color()
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                    Pic64None()
                    Pic55None()
                    PictureboxAbleToBlock(i) = 64
                    i = i + 1
                    PictureboxAbleToBlock(i) = 55
                    CheckPicturebox46Color()
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                        Pic64None()
                        Pic55None()
                        Pic46None()
                        PictureboxAbleToBlock(i) = 64
                        i = i + 1
                        PictureboxAbleToBlock(i) = 55
                        i = i + 1
                        PictureboxAbleToBlock(i) = 46
                        CheckPicturebox37Color()
                        Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                            Pic64None()
                            Pic55None()
                            Pic46None()
                            Pic37None()
                            PictureboxAbleToBlock(i) = 64
                            i = i + 1
                            PictureboxAbleToBlock(i) = 55
                            i = i + 1
                            PictureboxAbleToBlock(i) = 46
                            i = i + 1
                            PictureboxAbleToBlock(i) = 37
                            CheckPicturebox28Color()
                            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                Pic64None()
                                Pic55None()
                                Pic46None()
                                Pic37None()
                                Pic28None()
                                PictureboxAbleToBlock(i) = 64
                                i = i + 1
                                PictureboxAbleToBlock(i) = 55
                                i = i + 1
                                PictureboxAbleToBlock(i) = 46
                                i = i + 1
                                PictureboxAbleToBlock(i) = 37
                                i = i + 1
                                PictureboxAbleToBlock(i) = 28
                                CheckPicturebox19Color()
                                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                    Pic64None()
                                    Pic55None()
                                    Pic46None()
                                    Pic37None()
                                    Pic28None()
                                    Pic19None()
                                    PictureboxAbleToBlock(i) = 64
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 55
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 46
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 37
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 28
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 19
                                    CheckPicturebox10Color()
                                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                        Pic64None()
                                        Pic55None()
                                        Pic46None()
                                        Pic37None()
                                        Pic28None()
                                        Pic19None()
                                        Pic10None()
                                        PictureboxAbleToBlock(i) = 64
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 55
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 46
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 37
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 28
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 19
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 10
                                        CheckPicturebox1Color()
                                    Else
                                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                                        Pic64None()
                                        Pic55None()
                                        Pic46None()
                                        Pic37None()
                                        Pic28None()
                                        Pic19None()
                                        Pic10None()
                                        Pic1None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB2EastMovementArea()
        i = 1
        If Form1.PictureBox75.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox75Color()
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                Pic75None()
                PictureboxAbleToBlock(i) = 75
                CheckPicturebox76Color()
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox77.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                    Pic75None()
                    Pic76None()
                    PictureboxAbleToBlock(i) = 75
                    i = i + 1
                    PictureboxAbleToBlock(i) = 76
                    CheckPicturebox77Color()
                    Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                        Pic75None()
                        Pic76None()
                        Pic77None()
                        PictureboxAbleToBlock(i) = 75
                        i = i + 1
                        PictureboxAbleToBlock(i) = 76
                        i = i + 1
                        PictureboxAbleToBlock(i) = 77
                        CheckPicturebox78Color()
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                            Pic75None()
                            Pic76None()
                            Pic77None()
                            Pic78None()
                            PictureboxAbleToBlock(i) = 75
                            i = i + 1
                            PictureboxAbleToBlock(i) = 76
                            i = i + 1
                            PictureboxAbleToBlock(i) = 77
                            i = i + 1
                            PictureboxAbleToBlock(i) = 78
                            CheckPicturebox79Color()
                            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                Pic75None()
                                Pic76None()
                                Pic77None()
                                Pic78None()
                                Pic79None()
                                PictureboxAbleToBlock(i) = 75
                                i = i + 1
                                PictureboxAbleToBlock(i) = 76
                                i = i + 1
                                PictureboxAbleToBlock(i) = 77
                                i = i + 1
                                PictureboxAbleToBlock(i) = 78
                                i = i + 1
                                PictureboxAbleToBlock(i) = 79
                                CheckPicturebox80Color()
                                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                    Pic75None()
                                    Pic76None()
                                    Pic77None()
                                    Pic78None()
                                    Pic79None()
                                    Pic80None()
                                    PictureboxAbleToBlock(i) = 75
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 76
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 77
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 78
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 79
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 80
                                    CheckPicturebox81Color()
                                Else
                                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                    Pic75None()
                                    Pic76None()
                                    Pic77None()
                                    Pic78None()
                                    Pic79None()
                                    Pic80None()
                                    Pic81None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB2SouthMovementArea()
        If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox83Color()
        Else
            Form1.PictureBox83.Image = Form1.movementAreaPic.Image
            Pic83None()
        End If
    End Sub

    Public Sub CheB2WestMovementArea()
        If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox73Color()
        Else
            Form1.PictureBox73.Image = Form1.movementAreaPic.Image
            Pic73None()
        End If
    End Sub

    Public Sub CheB2NorthMovementArea()
        i = 1
        If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox65Color()
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                Pic65None()
                PictureboxAbleToBlock(i) = 65
                CheckPicturebox56Color()
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                    Pic65None()
                    Pic56None()
                    PictureboxAbleToBlock(i) = 65
                    i = i + 1
                    PictureboxAbleToBlock(i) = 56
                    CheckPicturebox47Color()
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                        Pic65None()
                        Pic56None()
                        Pic47None()
                        PictureboxAbleToBlock(i) = 65
                        i = i + 1
                        PictureboxAbleToBlock(i) = 56
                        i = i + 1
                        PictureboxAbleToBlock(i) = 47
                        CheckPicturebox38Color()
                        Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                            Pic65None()
                            Pic56None()
                            Pic47None()
                            Pic38None()
                            PictureboxAbleToBlock(i) = 65
                            i = i + 1
                            PictureboxAbleToBlock(i) = 56
                            i = i + 1
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 38
                            CheckPicturebox29Color()
                            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                Pic65None()
                                Pic56None()
                                Pic47None()
                                Pic38None()
                                Pic29None()
                                PictureboxAbleToBlock(i) = 65
                                i = i + 1
                                PictureboxAbleToBlock(i) = 56
                                i = i + 1
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 29
                                CheckPicturebox20Color()
                                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                    Pic65None()
                                    Pic56None()
                                    Pic47None()
                                    Pic38None()
                                    Pic29None()
                                    Pic20None()
                                    PictureboxAbleToBlock(i) = 65
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 56
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 47
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 38
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 29
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 20
                                    CheckPicturebox11Color()
                                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                        Pic65None()
                                        Pic56None()
                                        Pic47None()
                                        Pic38None()
                                        Pic29None()
                                        Pic20None()
                                        Pic11None()
                                        PictureboxAbleToBlock(i) = 65
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 56
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 47
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 38
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 29
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 20
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 11
                                        CheckPicturebox2Color()
                                    Else
                                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                        Pic65None()
                                        Pic56None()
                                        Pic47None()
                                        Pic38None()
                                        Pic29None()
                                        Pic20None()
                                        Pic11None()
                                        Pic2None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC2EastMovementArea()
        i = 1
        If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox76Color()
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox77.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                Pic76None()
                PictureboxAbleToBlock(i) = 76
                CheckPicturebox77Color()
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    Pic76None()
                    Pic77None()
                    PictureboxAbleToBlock(i) = 76
                    i = i + 1
                    PictureboxAbleToBlock(i) = 77
                    CheckPicturebox78Color()
                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                        Pic76None()
                        Pic77None()
                        Pic78None()
                        PictureboxAbleToBlock(i) = 76
                        i = i + 1
                        PictureboxAbleToBlock(i) = 77
                        i = i + 1
                        PictureboxAbleToBlock(i) = 78
                        CheckPicturebox79Color()
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                            Pic76None()
                            Pic77None()
                            Pic78None()
                            Pic79None()
                            PictureboxAbleToBlock(i) = 76
                            i = i + 1
                            PictureboxAbleToBlock(i) = 77
                            i = i + 1
                            PictureboxAbleToBlock(i) = 78
                            i = i + 1
                            PictureboxAbleToBlock(i) = 79
                            CheckPicturebox80Color()
                            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                Pic76None()
                                Pic77None()
                                Pic78None()
                                Pic79None()
                                Pic80None()
                                PictureboxAbleToBlock(i) = 76
                                i = i + 1
                                PictureboxAbleToBlock(i) = 77
                                i = i + 1
                                PictureboxAbleToBlock(i) = 78
                                i = i + 1
                                PictureboxAbleToBlock(i) = 79
                                i = i + 1
                                PictureboxAbleToBlock(i) = 80
                                CheckPicturebox81Color()
                            Else
                                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                Pic76None()
                                Pic77None()
                                Pic78None()
                                Pic79None()
                                Pic80None()
                                Pic81None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC2SouthMovementArea()
        If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox84Color()
        Else
            Form1.PictureBox84.Image = Form1.movementAreaPic.Image
            Pic84None()
        End If
    End Sub

    Public Sub CheC2WestMovementArea()
        i = 1
        If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox74Color()
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                Pic74None()
                PictureboxAbleToBlock(i) = 74
                CheckPicturebox73Color()
            Else
                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                Pic74None()
                Pic73None()
            End If
        End If
    End Sub

    Public Sub CheC2NorthMovementArea()
        i = 1
        If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox66Color()
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                Pic66None()
                PictureboxAbleToBlock(i) = 66
                CheckPicturebox57Color()
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                    Pic66None()
                    Pic57None()
                    PictureboxAbleToBlock(i) = 66
                    i = i + 1
                    PictureboxAbleToBlock(i) = 57
                    CheckPicturebox48Color()
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                        Pic66None()
                        Pic57None()
                        Pic48None()
                        PictureboxAbleToBlock(i) = 66
                        i = i + 1
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 48
                        CheckPicturebox39Color()
                        Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Pic66None()
                            Pic57None()
                            Pic48None()
                            Pic39None()
                            PictureboxAbleToBlock(i) = 66
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            CheckPicturebox30Color()
                            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                Pic66None()
                                Pic57None()
                                Pic48None()
                                Pic39None()
                                Pic30None()
                                PictureboxAbleToBlock(i) = 66
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                CheckPicturebox21Color()
                                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                    Pic66None()
                                    Pic57None()
                                    Pic48None()
                                    Pic39None()
                                    Pic30None()
                                    Pic21None()
                                    PictureboxAbleToBlock(i) = 66
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 30
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 21
                                    CheckPicturebox12Color()
                                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                        Pic66None()
                                        Pic57None()
                                        Pic48None()
                                        Pic39None()
                                        Pic30None()
                                        Pic21None()
                                        Pic12None()
                                        PictureboxAbleToBlock(i) = 66
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 57
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 48
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 39
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 30
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 21
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 12
                                        CheckPicturebox3Color()
                                    Else
                                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                        Pic66None()
                                        Pic57None()
                                        Pic48None()
                                        Pic39None()
                                        Pic30None()
                                        Pic21None()
                                        Pic12None()
                                        Pic3None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD2EastMovementArea()
        i = 1
        If Form1.PictureBox77.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox77Color()
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
                PictureboxAbleToBlock(i) = 77
                CheckPicturebox78Color()
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    Pic77None()
                    Pic78None()
                    PictureboxAbleToBlock(i) = 77
                    i = i + 1
                    PictureboxAbleToBlock(i) = 78
                    CheckPicturebox79Color()
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                        Pic77None()
                        Pic78None()
                        Pic79None()
                        PictureboxAbleToBlock(i) = 77
                        i = i + 1
                        PictureboxAbleToBlock(i) = 78
                        i = i + 1
                        PictureboxAbleToBlock(i) = 79
                        CheckPicturebox80Color()
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                            Pic77None()
                            Pic78None()
                            Pic79None()
                            Pic80None()
                            PictureboxAbleToBlock(i) = 77
                            i = i + 1
                            PictureboxAbleToBlock(i) = 78
                            i = i + 1
                            PictureboxAbleToBlock(i) = 79
                            i = i + 1
                            PictureboxAbleToBlock(i) = 80
                            CheckPicturebox81Color()
                        Else
                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                            Pic77None()
                            Pic78None()
                            Pic79None()
                            Pic80None()
                            Pic81None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD2SouthMovementArea()
        If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox85Color()
        Else
            Form1.PictureBox85.Image = Form1.movementAreaPic.Image
            Pic85None()
        End If
    End Sub

    Public Sub CheD2WestMovementArea()
        i = 1
        If Form1.PictureBox75.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox75Color()
            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                Pic75None()
                PictureboxAbleToBlock(i) = 75
                CheckPicturebox74Color()
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                    Pic75None()
                    Pic74None()
                    PictureboxAbleToBlock(i) = 75
                    i = i + 1
                    PictureboxAbleToBlock(i) = 74
                    CheckPicturebox73Color()
                Else
                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                    Pic75None()
                    Pic74None()
                    Pic73None()
                End If
            End If
        End If
    End Sub

    Public Sub CheD2NorthMovementArea()
        i = 1
        If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox67Color()
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                Pic67None()
                PictureboxAbleToBlock(i) = 67
                CheckPicturebox58Color()
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    Pic67None()
                    Pic58None()
                    PictureboxAbleToBlock(i) = 67
                    i = i + 1
                    PictureboxAbleToBlock(i) = 58
                    CheckPicturebox49Color()
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Pic67None()
                        Pic58None()
                        Pic49None()
                        PictureboxAbleToBlock(i) = 67
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        CheckPicturebox40Color()
                        Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Pic67None()
                            Pic58None()
                            Pic49None()
                            Pic40None()
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            CheckPicturebox31Color()
                            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Pic67None()
                                Pic58None()
                                Pic49None()
                                Pic40None()
                                Pic31None()
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                CheckPicturebox22Color()
                                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                    Pic67None()
                                    Pic58None()
                                    Pic49None()
                                    Pic40None()
                                    Pic31None()
                                    Pic22None()
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 22
                                    CheckPicturebox13Color()
                                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                        Pic67None()
                                        Pic58None()
                                        Pic49None()
                                        Pic40None()
                                        Pic31None()
                                        Pic22None()
                                        Pic13None()
                                        PictureboxAbleToBlock(i) = 67
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 58
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 49
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 40
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 31
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 22
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 13
                                        CheckPicturebox4Color()
                                    Else
                                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                        Pic67None()
                                        Pic58None()
                                        Pic49None()
                                        Pic40None()
                                        Pic31None()
                                        Pic22None()
                                        Pic13None()
                                        Pic4None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE2EastMovementArea()
        i = 1
        If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox78Color()
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
                PictureboxAbleToBlock(i) = 78
                CheckPicturebox79Color()
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    Pic78None()
                    Pic79None()
                    PictureboxAbleToBlock(i) = 78
                    i = i + 1
                    PictureboxAbleToBlock(i) = 79
                    CheckPicturebox80Color()
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                        Pic78None()
                        Pic79None()
                        Pic80None()
                        PictureboxAbleToBlock(i) = 78
                        i = i + 1
                        PictureboxAbleToBlock(i) = 79
                        i = i + 1
                        PictureboxAbleToBlock(i) = 80
                        CheckPicturebox81Color()
                    Else
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                        Pic78None()
                        Pic79None()
                        Pic80None()
                        Pic81None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE2SouthMovementArea()
        If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox86Color()
        Else
            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
            Pic86None()
        End If
    End Sub

    Public Sub CheE2WestMovementArea()
        i = 1
        If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox76Color()
            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox75.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                Pic76None()
                PictureboxAbleToBlock(i) = 76
                CheckPicturebox75Color()
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                    Pic76None()
                    Pic75None()
                    PictureboxAbleToBlock(i) = 76
                    i = i + 1
                    PictureboxAbleToBlock(i) = 75
                    CheckPicturebox74Color()
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                        Pic76None()
                        Pic75None()
                        Pic74None()
                        PictureboxAbleToBlock(i) = 76
                        i = i + 1
                        PictureboxAbleToBlock(i) = 75
                        i = i + 1
                        PictureboxAbleToBlock(i) = 74
                        CheckPicturebox73Color()
                    Else
                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                        Pic76None()
                        Pic75None()
                        Pic74None()
                        Pic73None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE2NorthMovementArea()
        i = 1
        If Form1.PictureBox68.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox68Color()
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
                PictureboxAbleToBlock(i) = 68
                CheckPicturebox59Color()
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    Pic68None()
                    Pic59None()
                    PictureboxAbleToBlock(i) = 68
                    i = i + 1
                    PictureboxAbleToBlock(i) = 59
                    CheckPicturebox50Color()
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Pic68None()
                        Pic59None()
                        Pic50None()
                        PictureboxAbleToBlock(i) = 68
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        CheckPicturebox41Color()
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Pic68None()
                            Pic59None()
                            Pic50None()
                            Pic41None()
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            CheckPicturebox32Color()
                            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Pic68None()
                                Pic59None()
                                Pic50None()
                                Pic41None()
                                Pic32None()
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                CheckPicturebox23Color()
                                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                    Pic68None()
                                    Pic59None()
                                    Pic50None()
                                    Pic41None()
                                    Pic32None()
                                    Pic23None()
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 23
                                    CheckPicturebox14Color()
                                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                        Pic68None()
                                        Pic59None()
                                        Pic50None()
                                        Pic41None()
                                        Pic32None()
                                        Pic23None()
                                        Pic14None()
                                        PictureboxAbleToBlock(i) = 68
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 59
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 50
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 41
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 32
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 23
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 14
                                        CheckPicturebox5Color()
                                    Else
                                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                        Pic68None()
                                        Pic59None()
                                        Pic50None()
                                        Pic41None()
                                        Pic32None()
                                        Pic23None()
                                        Pic14None()
                                        Pic5None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF2EastMovementArea()
        i = 1
        If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox79Color()
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                Pic79None()
                PictureboxAbleToBlock(i) = 79
                CheckPicturebox80Color()
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                    Pic79None()
                    Pic80None()
                    PictureboxAbleToBlock(i) = 79
                    i = i + 1
                    PictureboxAbleToBlock(i) = 80
                    CheckPicturebox81Color()
                Else
                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                    Pic79None()
                    Pic80None()
                    Pic81None()
                End If
            End If
        End If
    End Sub

    Public Sub CheF2SouthMovementArea()
        If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox87Color()
        Else
            Form1.PictureBox87.Image = Form1.movementAreaPic.Image
            Pic87None()
        End If
    End Sub

    Public Sub CheF2WestMovementArea()
        i = 1
        If Form1.PictureBox77.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox77Color()
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
                PictureboxAbleToBlock(i) = 77
                CheckPicturebox76Color()
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox75.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                    Pic77None()
                    Pic76None()
                    PictureboxAbleToBlock(i) = 77
                    i = i + 1
                    PictureboxAbleToBlock(i) = 76
                    CheckPicturebox75Color()
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                        Pic77None()
                        Pic76None()
                        Pic75None()
                        PictureboxAbleToBlock(i) = 77
                        i = i + 1
                        PictureboxAbleToBlock(i) = 76
                        i = i + 1
                        PictureboxAbleToBlock(i) = 75
                        CheckPicturebox74Color()
                        Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                            Pic77None()
                            Pic76None()
                            Pic75None()
                            Pic74None()
                            PictureboxAbleToBlock(i) = 77
                            i = i + 1
                            PictureboxAbleToBlock(i) = 76
                            i = i + 1
                            PictureboxAbleToBlock(i) = 75
                            i = i + 1
                            PictureboxAbleToBlock(i) = 74
                            CheckPicturebox73Color()
                        Else
                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                            Pic77None()
                            Pic76None()
                            Pic75None()
                            Pic74None()
                            Pic73None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF2NorthMovementArea()
        i = 1
        If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox69Color()
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
                PictureboxAbleToBlock(i) = 69
                CheckPicturebox60Color()
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    Pic69None()
                    Pic60None()
                    PictureboxAbleToBlock(i) = 69
                    i = i + 1
                    PictureboxAbleToBlock(i) = 60
                    CheckPicturebox51Color()
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Pic69None()
                        Pic60None()
                        Pic51None()
                        PictureboxAbleToBlock(i) = 69
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        CheckPicturebox42Color()
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Pic69None()
                            Pic60None()
                            Pic51None()
                            Pic42None()
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            CheckPicturebox33Color()
                            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Pic69None()
                                Pic60None()
                                Pic51None()
                                Pic42None()
                                Pic33None()
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                CheckPicturebox24Color()
                                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                    Pic69None()
                                    Pic60None()
                                    Pic51None()
                                    Pic42None()
                                    Pic33None()
                                    Pic24None()
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 24
                                    CheckPicturebox15Color()
                                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                        Pic69None()
                                        Pic60None()
                                        Pic51None()
                                        Pic42None()
                                        Pic33None()
                                        Pic24None()
                                        Pic15None()
                                        PictureboxAbleToBlock(i) = 69
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 60
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 51
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 42
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 33
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 24
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 15
                                        CheckPicturebox6Color()
                                    Else
                                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                        Pic69None()
                                        Pic60None()
                                        Pic51None()
                                        Pic42None()
                                        Pic33None()
                                        Pic24None()
                                        Pic15None()
                                        Pic6None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG2EastMovementArea()
        i = 1
        If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox80Color()
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                Pic80None()
                PictureboxAbleToBlock(i) = 80
                CheckPicturebox81Color()
            Else
                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                Pic80None()
                Pic81None()
            End If
        End If
    End Sub

    Public Sub CheG2SouthMovementArea()
        If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox88Color()
        Else
            Form1.PictureBox88.Image = Form1.movementAreaPic.Image
            Pic88None()
        End If
    End Sub

    Public Sub CheG2WestMovementArea()
        i = 1
        If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox78Color()
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox77.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
                PictureboxAbleToBlock(i) = 78
                CheckPicturebox77Color()
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    Pic78None()
                    Pic77None()
                    PictureboxAbleToBlock(i) = 78
                    i = i + 1
                    PictureboxAbleToBlock(i) = 77
                    CheckPicturebox76Color()
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox75.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                        Pic78None()
                        Pic77None()
                        Pic76None()
                        PictureboxAbleToBlock(i) = 78
                        i = i + 1
                        PictureboxAbleToBlock(i) = 77
                        i = i + 1
                        PictureboxAbleToBlock(i) = 76
                        CheckPicturebox75Color()
                        Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                            Pic78None()
                            Pic77None()
                            Pic76None()
                            Pic75None()
                            PictureboxAbleToBlock(i) = 78
                            i = i + 1
                            PictureboxAbleToBlock(i) = 77
                            i = i + 1
                            PictureboxAbleToBlock(i) = 76
                            i = i + 1
                            PictureboxAbleToBlock(i) = 75
                            CheckPicturebox74Color()
                            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                Pic78None()
                                Pic77None()
                                Pic76None()
                                Pic75None()
                                Pic74None()
                                PictureboxAbleToBlock(i) = 78
                                i = i + 1
                                PictureboxAbleToBlock(i) = 77
                                i = i + 1
                                PictureboxAbleToBlock(i) = 76
                                i = i + 1
                                PictureboxAbleToBlock(i) = 75
                                i = i + 1
                                PictureboxAbleToBlock(i) = 74
                                CheckPicturebox73Color()
                            Else
                                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                Pic78None()
                                Pic77None()
                                Pic76None()
                                Pic75None()
                                Pic74None()
                                Pic73None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG2NorthMovementArea()
        i = 1
        If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox70Color()
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
                PictureboxAbleToBlock(i) = 70
                CheckPicturebox61Color()
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    Pic70None()
                    Pic61None()
                    PictureboxAbleToBlock(i) = 70
                    i = i + 1
                    PictureboxAbleToBlock(i) = 61
                    CheckPicturebox52Color()
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                        Pic70None()
                        Pic61None()
                        Pic52None()
                        PictureboxAbleToBlock(i) = 70
                        i = i + 1
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 52
                        CheckPicturebox43Color()
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Pic70None()
                            Pic61None()
                            Pic52None()
                            Pic43None()
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            CheckPicturebox34Color()
                            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                Pic70None()
                                Pic61None()
                                Pic52None()
                                Pic43None()
                                Pic34None()
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                CheckPicturebox25Color()
                                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                    Pic70None()
                                    Pic61None()
                                    Pic52None()
                                    Pic43None()
                                    Pic34None()
                                    Pic25None()
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 25
                                    CheckPicturebox16Color()
                                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                        Pic70None()
                                        Pic61None()
                                        Pic52None()
                                        Pic43None()
                                        Pic34None()
                                        Pic25None()
                                        Pic16None()
                                        PictureboxAbleToBlock(i) = 70
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 61
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 52
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 43
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 34
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 25
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 16
                                        CheckPicturebox7Color()
                                    Else
                                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                        Pic70None()
                                        Pic61None()
                                        Pic52None()
                                        Pic43None()
                                        Pic34None()
                                        Pic25None()
                                        Pic16None()
                                        Pic7None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH2EastMovementArea()
        If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox81Color()
        Else
            Form1.PictureBox81.Image = Form1.movementAreaPic.Image
            Pic81None()
        End If
    End Sub

    Public Sub CheH2SouthMovementArea()
        If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox89Color()
        Else
            Form1.PictureBox89.Image = Form1.movementAreaPic.Image
            Pic89None()
        End If
    End Sub

    Public Sub CheH2WestMovementArea()
        i = 1
        If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox79Color()
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                Pic79None()
                PictureboxAbleToBlock(i) = 79
                CheckPicturebox78Color()
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox77.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    Pic79None()
                    Pic78None()
                    PictureboxAbleToBlock(i) = 79
                    i = i + 1
                    PictureboxAbleToBlock(i) = 78
                    CheckPicturebox77Color()
                    Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                        Pic79None()
                        Pic78None()
                        Pic77None()
                        PictureboxAbleToBlock(i) = 79
                        i = i + 1
                        PictureboxAbleToBlock(i) = 78
                        i = i + 1
                        PictureboxAbleToBlock(i) = 77
                        CheckPicturebox76Color()
                        Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox75.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                            Pic79None()
                            Pic78None()
                            Pic77None()
                            Pic76None()
                            PictureboxAbleToBlock(i) = 79
                            i = i + 1
                            PictureboxAbleToBlock(i) = 78
                            i = i + 1
                            PictureboxAbleToBlock(i) = 77
                            i = i + 1
                            PictureboxAbleToBlock(i) = 76
                            CheckPicturebox75Color()
                            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                Pic79None()
                                Pic78None()
                                Pic77None()
                                Pic76None()
                                Pic75None()
                                PictureboxAbleToBlock(i) = 79
                                i = i + 1
                                PictureboxAbleToBlock(i) = 78
                                i = i + 1
                                PictureboxAbleToBlock(i) = 77
                                i = i + 1
                                PictureboxAbleToBlock(i) = 76
                                i = i + 1
                                PictureboxAbleToBlock(i) = 75
                                CheckPicturebox74Color()
                                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                    Pic79None()
                                    Pic78None()
                                    Pic77None()
                                    Pic76None()
                                    Pic75None()
                                    Pic74None()
                                    PictureboxAbleToBlock(i) = 79
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 78
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 77
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 76
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 75
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 74
                                    CheckPicturebox73Color()
                                Else
                                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                    Pic79None()
                                    Pic78None()
                                    Pic77None()
                                    Pic76None()
                                    Pic75None()
                                    Pic74None()
                                    Pic73None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH2NorthMovementArea()
        i = 1
        If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox71Color()
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
                PictureboxAbleToBlock(i) = 71
                CheckPicturebox62Color()
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    Pic71None()
                    Pic62None()
                    PictureboxAbleToBlock(i) = 71
                    i = i + 1
                    PictureboxAbleToBlock(i) = 62
                    CheckPicturebox53Color()
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                        Pic71None()
                        Pic62None()
                        Pic53None()
                        PictureboxAbleToBlock(i) = 71
                        i = i + 1
                        PictureboxAbleToBlock(i) = 62
                        i = i + 1
                        PictureboxAbleToBlock(i) = 53
                        CheckPicturebox44Color()
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                            Pic71None()
                            Pic62None()
                            Pic53None()
                            Pic44None()
                            PictureboxAbleToBlock(i) = 71
                            i = i + 1
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                            CheckPicturebox35Color()
                            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                Pic71None()
                                Pic62None()
                                Pic53None()
                                Pic44None()
                                Pic35None()
                                PictureboxAbleToBlock(i) = 71
                                i = i + 1
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                CheckPicturebox26Color()
                                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                    Pic71None()
                                    Pic62None()
                                    Pic53None()
                                    Pic44None()
                                    Pic35None()
                                    Pic26None()
                                    PictureboxAbleToBlock(i) = 71
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 35
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 26
                                    CheckPicturebox17Color()
                                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                        Pic71None()
                                        Pic62None()
                                        Pic53None()
                                        Pic44None()
                                        Pic35None()
                                        Pic26None()
                                        Pic17None()
                                        PictureboxAbleToBlock(i) = 71
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 62
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 53
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 44
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 35
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 26
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 17
                                        CheckPicturebox8Color()
                                    Else
                                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                        Pic71None()
                                        Pic62None()
                                        Pic53None()
                                        Pic44None()
                                        Pic35None()
                                        Pic26None()
                                        Pic17None()
                                        Pic8None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI2SouthMovementArea()
        If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox90Color()
        Else
            Form1.PictureBox90.Image = Form1.movementAreaPic.Image
            Pic90None()
        End If
    End Sub

    Public Sub CheI2WestMovementArea()
        i = 1
        If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox80Color()
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                Pic80None()
                PictureboxAbleToBlock(i) = 80
                CheckPicturebox79Color()
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    Pic80None()
                    Pic79None()
                    PictureboxAbleToBlock(i) = 80
                    i = i + 1
                    PictureboxAbleToBlock(i) = 79
                    CheckPicturebox78Color()
                    Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox77.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                        Pic80None()
                        Pic79None()
                        Pic78None()
                        PictureboxAbleToBlock(i) = 80
                        i = i + 1
                        PictureboxAbleToBlock(i) = 79
                        i = i + 1
                        PictureboxAbleToBlock(i) = 78
                        CheckPicturebox77Color()
                        Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                            Pic80None()
                            Pic79None()
                            Pic78None()
                            Pic77None()
                            PictureboxAbleToBlock(i) = 80
                            i = i + 1
                            PictureboxAbleToBlock(i) = 79
                            i = i + 1
                            PictureboxAbleToBlock(i) = 78
                            i = i + 1
                            PictureboxAbleToBlock(i) = 77
                            CheckPicturebox76Color()
                            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox75.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                Pic80None()
                                Pic79None()
                                Pic78None()
                                Pic77None()
                                Pic76None()
                                PictureboxAbleToBlock(i) = 80
                                i = i + 1
                                PictureboxAbleToBlock(i) = 79
                                i = i + 1
                                PictureboxAbleToBlock(i) = 78
                                i = i + 1
                                PictureboxAbleToBlock(i) = 77
                                i = i + 1
                                PictureboxAbleToBlock(i) = 76
                                CheckPicturebox75Color()
                                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                    Pic80None()
                                    Pic79None()
                                    Pic78None()
                                    Pic77None()
                                    Pic76None()
                                    Pic75None()
                                    PictureboxAbleToBlock(i) = 80
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 79
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 78
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 77
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 76
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 75
                                    CheckPicturebox74Color()
                                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                        Pic80None()
                                        Pic79None()
                                        Pic78None()
                                        Pic77None()
                                        Pic76None()
                                        Pic75None()
                                        Pic74None()
                                        PictureboxAbleToBlock(i) = 80
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 79
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 78
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 77
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 76
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 75
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 74
                                        CheckPicturebox73Color()
                                    Else
                                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                        Pic80None()
                                        Pic79None()
                                        Pic78None()
                                        Pic77None()
                                        Pic76None()
                                        Pic75None()
                                        Pic74None()
                                        Pic73None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI2NorthMovementArea()
        i = 1
        If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox72Color()
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                Pic72None()
                PictureboxAbleToBlock(i) = 72
                CheckPicturebox63Color()
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    Pic72None()
                    Pic63None()
                    PictureboxAbleToBlock(i) = 72
                    i = i + 1
                    PictureboxAbleToBlock(i) = 63
                    CheckPicturebox54Color()
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                        Pic72None()
                        Pic63None()
                        Pic54None()
                        PictureboxAbleToBlock(i) = 72
                        i = i + 1
                        PictureboxAbleToBlock(i) = 63
                        i = i + 1
                        PictureboxAbleToBlock(i) = 54
                        CheckPicturebox45Color()
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                            Pic72None()
                            Pic63None()
                            Pic54None()
                            Pic45None()
                            PictureboxAbleToBlock(i) = 72
                            i = i + 1
                            PictureboxAbleToBlock(i) = 63
                            i = i + 1
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 45
                            CheckPicturebox36Color()
                            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                Pic72None()
                                Pic63None()
                                Pic54None()
                                Pic45None()
                                Pic36None()
                                PictureboxAbleToBlock(i) = 72
                                i = i + 1
                                PictureboxAbleToBlock(i) = 63
                                i = i + 1
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 36
                                CheckPicturebox27Color()
                                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                    Pic72None()
                                    Pic63None()
                                    Pic54None()
                                    Pic45None()
                                    Pic36None()
                                    Pic27None()
                                    PictureboxAbleToBlock(i) = 72
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 63
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 54
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 45
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 36
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 27
                                    CheckPicturebox18Color()
                                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                        Pic72None()
                                        Pic63None()
                                        Pic54None()
                                        Pic45None()
                                        Pic36None()
                                        Pic27None()
                                        Pic18None()
                                        PictureboxAbleToBlock(i) = 72
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 63
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 54
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 45
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 36
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 27
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 18
                                        CheckPicturebox9Color()
                                    Else
                                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                                        Pic72None()
                                        Pic63None()
                                        Pic54None()
                                        Pic45None()
                                        Pic36None()
                                        Pic27None()
                                        Pic18None()
                                        Pic9None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA3EastMovementArea()
        i = 1
        If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox65Color()
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                Pic65None()
                PictureboxAbleToBlock(i) = 65
                CheckPicturebox66Color()
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                    Pic65None()
                    Pic66None()
                    PictureboxAbleToBlock(i) = 65
                    i = i + 1
                    PictureboxAbleToBlock(i) = 66
                    CheckPicturebox67Color()
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox68.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                        Pic65None()
                        Pic66None()
                        Pic67None()
                        PictureboxAbleToBlock(i) = 65
                        i = i + 1
                        PictureboxAbleToBlock(i) = 66
                        i = i + 1
                        PictureboxAbleToBlock(i) = 67
                        CheckPicturebox68Color()
                        Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Pic65None()
                            Pic66None()
                            Pic67None()
                            Pic68None()
                            PictureboxAbleToBlock(i) = 65
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            CheckPicturebox69Color()
                            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                Pic65None()
                                Pic66None()
                                Pic67None()
                                Pic68None()
                                Pic69None()
                                PictureboxAbleToBlock(i) = 65
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                CheckPicturebox70Color()
                                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                    Pic65None()
                                    Pic66None()
                                    Pic67None()
                                    Pic68None()
                                    Pic69None()
                                    Pic70None()
                                    PictureboxAbleToBlock(i) = 65
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 70
                                    CheckPicturebox71Color()
                                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                        Pic65None()
                                        Pic66None()
                                        Pic67None()
                                        Pic68None()
                                        Pic69None()
                                        Pic70None()
                                        Pic71None()
                                        PictureboxAbleToBlock(i) = 65
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 66
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 67
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 68
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 69
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 70
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 71
                                        CheckPicturebox72Color()
                                    Else
                                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                        Pic65None()
                                        Pic66None()
                                        Pic67None()
                                        Pic68None()
                                        Pic69None()
                                        Pic70None()
                                        Pic71None()
                                        Pic72None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA3SouthMovementArea()
        i = 1
        If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox73Color()
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                Pic73None()
                PictureboxAbleToBlock(i) = 73
                CheckPicturebox82Color()
            Else
                Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                Pic73None()
                Pic82None()
            End If
        End If
    End Sub

    Public Sub CheA3NorthMovementArea()
        i = 1
        If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox55Color()
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                Pic55None()
                PictureboxAbleToBlock(i) = 55
                CheckPicturebox46Color()
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                    Pic55None()
                    Pic46None()
                    PictureboxAbleToBlock(i) = 55
                    i = i + 1
                    PictureboxAbleToBlock(i) = 46
                    CheckPicturebox37Color()
                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                        Pic55None()
                        Pic46None()
                        Pic37None()
                        PictureboxAbleToBlock(i) = 55
                        i = i + 1
                        PictureboxAbleToBlock(i) = 46
                        i = i + 1
                        PictureboxAbleToBlock(i) = 37
                        CheckPicturebox28Color()
                        Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                            Pic55None()
                            Pic46None()
                            Pic37None()
                            Pic28None()
                            PictureboxAbleToBlock(i) = 55
                            i = i + 1
                            PictureboxAbleToBlock(i) = 46
                            i = i + 1
                            PictureboxAbleToBlock(i) = 37
                            i = i + 1
                            PictureboxAbleToBlock(i) = 28
                            CheckPicturebox19Color()
                            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                Pic55None()
                                Pic46None()
                                Pic37None()
                                Pic28None()
                                Pic19None()
                                PictureboxAbleToBlock(i) = 55
                                i = i + 1
                                PictureboxAbleToBlock(i) = 46
                                i = i + 1
                                PictureboxAbleToBlock(i) = 37
                                i = i + 1
                                PictureboxAbleToBlock(i) = 28
                                i = i + 1
                                PictureboxAbleToBlock(i) = 19
                                CheckPicturebox10Color()
                                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                    Pic55None()
                                    Pic46None()
                                    Pic37None()
                                    Pic28None()
                                    Pic19None()
                                    Pic10None()
                                    PictureboxAbleToBlock(i) = 55
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 46
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 37
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 28
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 19
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 10
                                    CheckPicturebox1Color()
                                Else
                                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                                    Pic55None()
                                    Pic46None()
                                    Pic37None()
                                    Pic28None()
                                    Pic19None()
                                    Pic10None()
                                    Pic1None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB3EastMovementArea()
        i = 1
        If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox66Color()
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                Pic66None()
                PictureboxAbleToBlock(i) = 66
                CheckPicturebox67Color()
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox68.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                    Pic66None()
                    Pic67None()
                    PictureboxAbleToBlock(i) = 66
                    i = i + 1
                    PictureboxAbleToBlock(i) = 67
                    CheckPicturebox68Color()
                    Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                        Pic66None()
                        Pic67None()
                        Pic68None()
                        PictureboxAbleToBlock(i) = 66
                        i = i + 1
                        PictureboxAbleToBlock(i) = 67
                        i = i + 1
                        PictureboxAbleToBlock(i) = 68
                        CheckPicturebox69Color()
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                            Pic66None()
                            Pic67None()
                            Pic68None()
                            Pic69None()
                            PictureboxAbleToBlock(i) = 66
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            CheckPicturebox70Color()
                            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                Pic66None()
                                Pic67None()
                                Pic68None()
                                Pic69None()
                                Pic70None()
                                PictureboxAbleToBlock(i) = 66
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 70
                                CheckPicturebox71Color()
                                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                    Pic66None()
                                    Pic67None()
                                    Pic68None()
                                    Pic69None()
                                    Pic70None()
                                    Pic71None()
                                    PictureboxAbleToBlock(i) = 66
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 71
                                    CheckPicturebox72Color()
                                Else
                                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                    Pic66None()
                                    Pic67None()
                                    Pic68None()
                                    Pic69None()
                                    Pic70None()
                                    Pic71None()
                                    Pic72None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB3SouthMovementArea()
        i = 1
        If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox74Color()
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                Pic74None()
                PictureboxAbleToBlock(i) = 74
                CheckPicturebox83Color()
            Else
                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                Pic74None()
                Pic83None()
            End If
        End If
    End Sub

    Public Sub CheB3WestMovementArea()
        If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox64Color()
        Else
            Form1.PictureBox64.Image = Form1.movementAreaPic.Image
            Pic64None()
        End If
    End Sub

    Public Sub CheB3NorthMovementArea()
        i = 1
        If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox56Color()
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                Pic56None()
                PictureboxAbleToBlock(i) = 56
                CheckPicturebox47Color()
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                    Pic56None()
                    Pic47None()
                    PictureboxAbleToBlock(i) = 56
                    i = i + 1
                    PictureboxAbleToBlock(i) = 47
                    CheckPicturebox38Color()
                    Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                        Pic56None()
                        Pic47None()
                        Pic38None()
                        PictureboxAbleToBlock(i) = 56
                        i = i + 1
                        PictureboxAbleToBlock(i) = 47
                        i = i + 1
                        PictureboxAbleToBlock(i) = 38
                        CheckPicturebox29Color()
                        Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                            Pic56None()
                            Pic47None()
                            Pic38None()
                            Pic29None()
                            PictureboxAbleToBlock(i) = 56
                            i = i + 1
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 29
                            CheckPicturebox20Color()
                            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                Pic56None()
                                Pic47None()
                                Pic38None()
                                Pic29None()
                                Pic20None()
                                PictureboxAbleToBlock(i) = 56
                                i = i + 1
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 20
                                CheckPicturebox11Color()
                                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                    Pic56None()
                                    Pic47None()
                                    Pic38None()
                                    Pic29None()
                                    Pic20None()
                                    Pic11None()
                                    PictureboxAbleToBlock(i) = 56
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 47
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 38
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 29
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 20
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 11
                                    CheckPicturebox2Color()
                                Else
                                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                    Pic56None()
                                    Pic47None()
                                    Pic38None()
                                    Pic29None()
                                    Pic20None()
                                    Pic11None()
                                    Pic2None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC3EastMovementArea()
        i = 1
        If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox67Color()
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox68.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                Pic67None()
                PictureboxAbleToBlock(i) = 67
                CheckPicturebox68Color()
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    Pic67None()
                    Pic68None()
                    PictureboxAbleToBlock(i) = 67
                    i = i + 1
                    PictureboxAbleToBlock(i) = 68
                    CheckPicturebox69Color()
                    Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                        Pic67None()
                        Pic68None()
                        Pic69None()
                        PictureboxAbleToBlock(i) = 67
                        i = i + 1
                        PictureboxAbleToBlock(i) = 68
                        i = i + 1
                        PictureboxAbleToBlock(i) = 69
                        CheckPicturebox70Color()
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                            Pic67None()
                            Pic68None()
                            Pic69None()
                            Pic70None()
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 70
                            CheckPicturebox71Color()
                            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                Pic67None()
                                Pic68None()
                                Pic69None()
                                Pic70None()
                                Pic71None()
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 71
                                CheckPicturebox72Color()
                            Else
                                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                Pic67None()
                                Pic68None()
                                Pic69None()
                                Pic70None()
                                Pic71None()
                                Pic72None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC3SouthMovementArea()
        i = 1
        If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
            CheckPicturebox75Color()
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                Pic75None()
                PictureboxAbleToBlock(i) = 75
                CheckPicturebox84Color()
            Else
                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                Pic75None()
                Pic84None()
            End If
        End If
    End Sub

    Public Sub CheC3WestMovementArea()
        i = 1
        If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox65Color()
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                Pic65None()
                PictureboxAbleToBlock(i) = 65
                CheckPicturebox64Color()
            Else
                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                Pic65None()
                Pic64None()
            End If
        End If
    End Sub

    Public Sub CheC3NorthMovementArea()
        i = 1
        If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox57Color()
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                Pic57None()
                PictureboxAbleToBlock(i) = 57
                CheckPicturebox48Color()
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                    Pic57None()
                    Pic48None()
                    PictureboxAbleToBlock(i) = 57
                    i = i + 1
                    PictureboxAbleToBlock(i) = 48
                    CheckPicturebox39Color()
                    Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                        Pic57None()
                        Pic48None()
                        Pic39None()
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 39
                        CheckPicturebox30Color()
                        Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                            Pic57None()
                            Pic48None()
                            Pic39None()
                            Pic30None()
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            CheckPicturebox21Color()
                            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                Pic57None()
                                Pic48None()
                                Pic39None()
                                Pic30None()
                                Pic21None()
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 21
                                CheckPicturebox12Color()
                                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                    Pic57None()
                                    Pic48None()
                                    Pic39None()
                                    Pic30None()
                                    Pic21None()
                                    Pic12None()
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 30
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 21
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 12
                                    CheckPicturebox3Color()
                                Else
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                    Pic57None()
                                    Pic48None()
                                    Pic39None()
                                    Pic30None()
                                    Pic21None()
                                    Pic12None()
                                    Pic3None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD3EastMovementArea()
        i = 1
        If Form1.PictureBox68.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox68Color()
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
                PictureboxAbleToBlock(i) = 68
                CheckPicturebox69Color()
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    Pic68None()
                    Pic69None()
                    PictureboxAbleToBlock(i) = 68
                    i = i + 1
                    PictureboxAbleToBlock(i) = 69
                    CheckPicturebox70Color()
                    Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                        Pic68None()
                        Pic69None()
                        Pic70None()
                        PictureboxAbleToBlock(i) = 68
                        i = i + 1
                        PictureboxAbleToBlock(i) = 69
                        i = i + 1
                        PictureboxAbleToBlock(i) = 70
                        CheckPicturebox71Color()
                        Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                            Pic68None()
                            Pic69None()
                            Pic70None()
                            Pic71None()
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 71
                            CheckPicturebox72Color()
                        Else
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                            Pic68None()
                            Pic69None()
                            Pic70None()
                            Pic71None()
                            Pic72None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD3SouthMovementArea()
        i = 1
        If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox76Color()
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                Pic76None()
                PictureboxAbleToBlock(i) = 76
                CheckPicturebox85Color()
            Else
                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                Pic76None()
                Pic85None()
            End If
        End If
    End Sub

    Public Sub CheD3WestMovementArea()
        i = 1
        If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox66Color()
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                Pic66None()
                PictureboxAbleToBlock(i) = 66
                CheckPicturebox65Color()
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                    Pic66None()
                    Pic65None()
                    PictureboxAbleToBlock(i) = 66
                    i = i + 1
                    PictureboxAbleToBlock(i) = 65
                    CheckPicturebox64Color()
                Else
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                    Pic66None()
                    Pic65None()
                    Pic64None()
                End If
            End If
        End If
    End Sub

    Public Sub CheD3NorthMovementArea()
        i = 1
        If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox58Color()
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                Pic58None()
                PictureboxAbleToBlock(i) = 58
                CheckPicturebox49Color()
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    Pic58None()
                    Pic49None()
                    PictureboxAbleToBlock(i) = 58
                    i = i + 1
                    PictureboxAbleToBlock(i) = 49
                    CheckPicturebox40Color()
                    Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Pic58None()
                        Pic49None()
                        Pic40None()
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        CheckPicturebox31Color()
                        Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Pic58None()
                            Pic49None()
                            Pic40None()
                            Pic31None()
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            CheckPicturebox22Color()
                            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                Pic58None()
                                Pic49None()
                                Pic40None()
                                Pic31None()
                                Pic22None()
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 22
                                CheckPicturebox13Color()
                                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                    Pic58None()
                                    Pic49None()
                                    Pic40None()
                                    Pic31None()
                                    Pic22None()
                                    Pic13None()
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 22
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 13
                                    CheckPicturebox4Color()
                                Else
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                    Pic58None()
                                    Pic49None()
                                    Pic40None()
                                    Pic31None()
                                    Pic22None()
                                    Pic13None()
                                    Pic4None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE3EastMovementArea()
        i = 1
        If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox69Color()
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
                PictureboxAbleToBlock(i) = 69
                CheckPicturebox70Color()
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    Pic69None()
                    Pic70None()
                    PictureboxAbleToBlock(i) = 69
                    i = i + 1
                    PictureboxAbleToBlock(i) = 70
                    CheckPicturebox71Color()
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                        Pic69None()
                        Pic70None()
                        Pic71None()
                        PictureboxAbleToBlock(i) = 69
                        i = i + 1
                        PictureboxAbleToBlock(i) = 70
                        i = i + 1
                        PictureboxAbleToBlock(i) = 71
                        CheckPicturebox72Color()
                    Else
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                        Pic69None()
                        Pic70None()
                        Pic71None()
                        Pic72None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE3SouthMovementArea()
        i = 1
        If Form1.PictureBox77 IsNot Form1.nonePic.Image Then
            CheckPicturebox77Color()
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
                PictureboxAbleToBlock(i) = 77
                CheckPicturebox86Color()
            Else
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                Pic77None()
                Pic86None()
            End If
        End If
    End Sub

    Public Sub CheE3WestMovementArea()
        i = 1
        If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox67Color()
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                Pic67None()
                PictureboxAbleToBlock(i) = 67
                CheckPicturebox66Color()
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                    Pic67None()
                    Pic66None()
                    PictureboxAbleToBlock(i) = 67
                    i = i + 1
                    PictureboxAbleToBlock(i) = 66
                    CheckPicturebox65Color()
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                        Pic67None()
                        Pic66None()
                        Pic65None()
                        PictureboxAbleToBlock(i) = 67
                        i = i + 1
                        PictureboxAbleToBlock(i) = 66
                        i = i + 1
                        PictureboxAbleToBlock(i) = 65
                        CheckPicturebox64Color()
                    Else
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                        Pic67None()
                        Pic66None()
                        Pic65None()
                        Pic64None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE3NorthMovementArea()
        i = 1
        If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox59Color()
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                Pic59None()
                PictureboxAbleToBlock(i) = 59
                CheckPicturebox50Color()
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    Pic59None()
                    Pic50None()
                    PictureboxAbleToBlock(i) = 59
                    i = i + 1
                    PictureboxAbleToBlock(i) = 50
                    CheckPicturebox41Color()
                    Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Pic59None()
                        Pic50None()
                        Pic41None()
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        CheckPicturebox32Color()
                        Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Pic59None()
                            Pic50None()
                            Pic41None()
                            Pic32None()
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            CheckPicturebox23Color()
                            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                Pic59None()
                                Pic50None()
                                Pic41None()
                                Pic32None()
                                Pic23None()
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 23
                                CheckPicturebox14Color()
                                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                    Pic59None()
                                    Pic50None()
                                    Pic41None()
                                    Pic32None()
                                    Pic23None()
                                    Pic14None()
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 23
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 14
                                    CheckPicturebox5Color()
                                Else
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                    Pic59None()
                                    Pic50None()
                                    Pic41None()
                                    Pic32None()
                                    Pic23None()
                                    Pic14None()
                                    Pic5None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF3EastMovementArea()
        i = 1
        If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox70Color()
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
                PictureboxAbleToBlock(i) = 70
                CheckPicturebox71Color()
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    Pic70None()
                    Pic71None()
                    PictureboxAbleToBlock(i) = 70
                    i = i + 1
                    PictureboxAbleToBlock(i) = 71
                    CheckPicturebox72Color()
                Else
                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                    Pic70None()
                    Pic71None()
                    Pic72None()
                End If
            End If
        End If
    End Sub

    Public Sub CheF3SouthMovementArea()
        i = 1
        If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox78Color()
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
                PictureboxAbleToBlock(i) = 78
                CheckPicturebox87Color()
            Else
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                Pic78None()
                Pic87None()
            End If
        End If
    End Sub

    Public Sub CheF3WestMovementArea()
        i = 1
        If Form1.PictureBox68.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox68Color()
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
                PictureboxAbleToBlock(i) = 68
                CheckPicturebox67Color()
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                    Pic68None()
                    Pic67None()
                    PictureboxAbleToBlock(i) = 68
                    i = i + 1
                    PictureboxAbleToBlock(i) = 67
                    CheckPicturebox66Color()
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                        Pic68None()
                        Pic67None()
                        Pic66None()
                        PictureboxAbleToBlock(i) = 68
                        i = i + 1
                        PictureboxAbleToBlock(i) = 67
                        i = i + 1
                        PictureboxAbleToBlock(i) = 66
                        CheckPicturebox65Color()
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                            Pic68None()
                            Pic67None()
                            Pic66None()
                            Pic65None()
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                            i = i + 1
                            PictureboxAbleToBlock(i) = 65
                            CheckPicturebox64Color()
                        Else
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                            Pic68None()
                            Pic67None()
                            Pic66None()
                            Pic65None()
                            Pic64None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF3NorthMovementArea()
        i = 1
        If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox60Color()
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
                PictureboxAbleToBlock(i) = 60
                CheckPicturebox51Color()
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    Pic60None()
                    Pic51None()
                    PictureboxAbleToBlock(i) = 60
                    i = i + 1
                    PictureboxAbleToBlock(i) = 51
                    CheckPicturebox42Color()
                    Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Pic60None()
                        Pic51None()
                        Pic42None()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        CheckPicturebox33Color()
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Pic60None()
                            Pic51None()
                            Pic42None()
                            Pic33None()
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            CheckPicturebox24Color()
                            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                Pic60None()
                                Pic51None()
                                Pic42None()
                                Pic33None()
                                Pic24None()
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                CheckPicturebox15Color()
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                    Pic60None()
                                    Pic51None()
                                    Pic42None()
                                    Pic33None()
                                    Pic24None()
                                    Pic15None()
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 24
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 15
                                    CheckPicturebox6Color()
                                Else
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                    Pic60None()
                                    Pic51None()
                                    Pic42None()
                                    Pic33None()
                                    Pic24None()
                                    Pic15None()
                                    Pic6None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG3EastMovementArea()
        i = 1
        If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox71Color()
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
                PictureboxAbleToBlock(i) = 71
                CheckPicturebox72Color()
            Else
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                Pic71None()
                Pic72None()
            End If
        End If
    End Sub

    Public Sub CheG3SouthMovementArea()
        i = 1
        If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox79Color()
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                Pic79None()
                PictureboxAbleToBlock(i) = 79
                CheckPicturebox88Color()
            Else
                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                Pic79None()
                Pic88None()
            End If
        End If
    End Sub

    Public Sub CheG3WestMovementArea()
        i = 1
        If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox69Color()
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox68.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
                PictureboxAbleToBlock(i) = 69
                CheckPicturebox68Color()
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    Pic69None()
                    Pic68None()
                    PictureboxAbleToBlock(i) = 69
                    i = i + 1
                    PictureboxAbleToBlock(i) = 68
                    CheckPicturebox67Color()
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                        Pic69None()
                        Pic68None()
                        Pic67None()
                        PictureboxAbleToBlock(i) = 69
                        i = i + 1
                        PictureboxAbleToBlock(i) = 68
                        i = i + 1
                        PictureboxAbleToBlock(i) = 67
                        CheckPicturebox66Color()
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                            Pic69None()
                            Pic68None()
                            Pic67None()
                            Pic66None()
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                            CheckPicturebox65Color()
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                Pic69None()
                                Pic68None()
                                Pic67None()
                                Pic66None()
                                Pic65None()
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                                i = i + 1
                                PictureboxAbleToBlock(i) = 65
                                CheckPicturebox64Color()
                            Else
                                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                Pic69None()
                                Pic68None()
                                Pic67None()
                                Pic66None()
                                Pic65None()
                                Pic64None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG3NorthMovementArea()
        i = 1
        If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox61Color()
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
                PictureboxAbleToBlock(i) = 61
                CheckPicturebox52Color()
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    Pic61None()
                    Pic52None()
                    PictureboxAbleToBlock(i) = 61
                    i = i + 1
                    PictureboxAbleToBlock(i) = 52
                    CheckPicturebox43Color()
                    Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                        Pic61None()
                        Pic52None()
                        Pic43None()
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                        CheckPicturebox34Color()
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                            Pic61None()
                            Pic52None()
                            Pic43None()
                            Pic34None()
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            CheckPicturebox25Color()
                            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                Pic61None()
                                Pic52None()
                                Pic43None()
                                Pic34None()
                                Pic25None()
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                                CheckPicturebox16Color()
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                    Pic61None()
                                    Pic52None()
                                    Pic43None()
                                    Pic34None()
                                    Pic25None()
                                    Pic16None()
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 25
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 16
                                    CheckPicturebox7Color()
                                Else
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                    Pic61None()
                                    Pic52None()
                                    Pic43None()
                                    Pic34None()
                                    Pic25None()
                                    Pic16None()
                                    Pic7None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH3EastMovementArea()
        If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox72Color()
        Else
            Form1.PictureBox72.Image = Form1.movementAreaPic.Image
            Pic72None()
        End If
    End Sub

    Public Sub CheH3SouthMovementArea()
        i = 1
        If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox80Color()
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                Pic80None()
                PictureboxAbleToBlock(i) = 80
                CheckPicturebox89Color()
            Else
                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                Pic80None()
                Pic89None()
            End If
        End If
    End Sub

    Public Sub CheH3WestMovementArea()
        i = 1
        If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox70Color()
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
                PictureboxAbleToBlock(i) = 70
                CheckPicturebox69Color()
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox68.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    Pic70None()
                    Pic69None()
                    PictureboxAbleToBlock(i) = 70
                    i = i + 1
                    PictureboxAbleToBlock(i) = 69
                    CheckPicturebox68Color()
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                        Pic70None()
                        Pic69None()
                        Pic68None()
                        PictureboxAbleToBlock(i) = 70
                        i = i + 1
                        PictureboxAbleToBlock(i) = 69
                        i = i + 1
                        PictureboxAbleToBlock(i) = 68
                        CheckPicturebox67Color()
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                            Pic70None()
                            Pic69None()
                            Pic68None()
                            Pic67None()
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            CheckPicturebox66Color()
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                Pic70None()
                                Pic69None()
                                Pic68None()
                                Pic67None()
                                Pic66None()
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                                CheckPicturebox65Color()
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                    Pic70None()
                                    Pic69None()
                                    Pic68None()
                                    Pic67None()
                                    Pic66None()
                                    Pic65None()
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 65
                                    CheckPicturebox64Color()
                                Else
                                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                    Pic70None()
                                    Pic69None()
                                    Pic68None()
                                    Pic67None()
                                    Pic66None()
                                    Pic65None()
                                    Pic64None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH3NorthMovementArea()
        i = 1
        If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox62Color()
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
                PictureboxAbleToBlock(i) = 62
                CheckPicturebox53Color()
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    Pic62None()
                    Pic53None()
                    PictureboxAbleToBlock(i) = 62
                    i = i + 1
                    PictureboxAbleToBlock(i) = 53
                    CheckPicturebox44Color()
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                        Pic62None()
                        Pic53None()
                        Pic44None()
                        PictureboxAbleToBlock(i) = 62
                        i = i + 1
                        PictureboxAbleToBlock(i) = 53
                        i = i + 1
                        PictureboxAbleToBlock(i) = 44
                        CheckPicturebox35Color()
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                            Pic62None()
                            Pic53None()
                            Pic44None()
                            Pic35None()
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            CheckPicturebox26Color()
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                Pic62None()
                                Pic53None()
                                Pic44None()
                                Pic35None()
                                Pic26None()
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                i = i + 1
                                PictureboxAbleToBlock(i) = 26
                                CheckPicturebox17Color()
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                    Pic62None()
                                    Pic53None()
                                    Pic44None()
                                    Pic35None()
                                    Pic26None()
                                    Pic17None()
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 35
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 26
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 17
                                    CheckPicturebox8Color()
                                Else
                                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                    Pic62None()
                                    Pic53None()
                                    Pic44None()
                                    Pic35None()
                                    Pic26None()
                                    Pic17None()
                                    Pic8None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI3SouthMovementArea()
        i = 1
        If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox81Color()
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                Pic81None()
                PictureboxAbleToBlock(i) = 81
                CheckPicturebox90Color()
            Else
                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                Pic81None()
                Pic90None()
            End If
        End If
    End Sub

    Public Sub CheI3WestMovementArea()
        i = 1
        If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox71Color()
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
                PictureboxAbleToBlock(i) = 71
                CheckPicturebox70Color()
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    Pic71None()
                    Pic70None()
                    PictureboxAbleToBlock(i) = 71
                    i = i + 1
                    PictureboxAbleToBlock(i) = 70
                    CheckPicturebox69Color()
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox68.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                        Pic71None()
                        Pic70None()
                        Pic69None()
                        PictureboxAbleToBlock(i) = 71
                        i = i + 1
                        PictureboxAbleToBlock(i) = 70
                        i = i + 1
                        PictureboxAbleToBlock(i) = 69
                        CheckPicturebox68Color()
                        Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Pic71None()
                            Pic70None()
                            Pic69None()
                            Pic68None()
                            PictureboxAbleToBlock(i) = 71
                            i = i + 1
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            CheckPicturebox67Color()
                            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                Pic71None()
                                Pic70None()
                                Pic69None()
                                Pic68None()
                                Pic67None()
                                PictureboxAbleToBlock(i) = 71
                                i = i + 1
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                CheckPicturebox66Color()
                                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                    Pic71None()
                                    Pic70None()
                                    Pic69None()
                                    Pic68None()
                                    Pic67None()
                                    Pic66None()
                                    PictureboxAbleToBlock(i) = 71
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    CheckPicturebox65Color()
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                        Pic71None()
                                        Pic70None()
                                        Pic69None()
                                        Pic68None()
                                        Pic67None()
                                        Pic66None()
                                        Pic65None()
                                        PictureboxAbleToBlock(i) = 71
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 70
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 69
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 68
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 67
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 66
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 65
                                        CheckPicturebox64Color()
                                    Else
                                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                        Pic71None()
                                        Pic70None()
                                        Pic69None()
                                        Pic68None()
                                        Pic67None()
                                        Pic66None()
                                        Pic65None()
                                        Pic64None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI3NorthMovementArea()
        i = 1
        If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox63Color()
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                Pic63None()
                PictureboxAbleToBlock(i) = 63
                CheckPicturebox54Color()
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    Pic63None()
                    Pic54None()
                    PictureboxAbleToBlock(i) = 63
                    i = i + 1
                    PictureboxAbleToBlock(i) = 54
                    CheckPicturebox45Color()
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                        Pic63None()
                        Pic54None()
                        Pic45None()
                        PictureboxAbleToBlock(i) = 63
                        i = i + 1
                        PictureboxAbleToBlock(i) = 54
                        i = i + 1
                        PictureboxAbleToBlock(i) = 45
                        CheckPicturebox36Color()
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                            Pic63None()
                            Pic54None()
                            Pic45None()
                            Pic36None()
                            PictureboxAbleToBlock(i) = 63
                            i = i + 1
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 36
                            CheckPicturebox27Color()
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                Pic63None()
                                Pic54None()
                                Pic45None()
                                Pic36None()
                                Pic27None()
                                PictureboxAbleToBlock(i) = 63
                                i = i + 1
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 36
                                i = i + 1
                                PictureboxAbleToBlock(i) = 27
                                CheckPicturebox18Color()
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                    Pic63None()
                                    Pic54None()
                                    Pic45None()
                                    Pic36None()
                                    Pic27None()
                                    Pic18None()
                                    PictureboxAbleToBlock(i) = 63
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 54
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 45
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 36
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 27
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 18
                                    CheckPicturebox9Color()
                                Else
                                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                                    Pic63None()
                                    Pic54None()
                                    Pic45None()
                                    Pic36None()
                                    Pic27None()
                                    Pic18None()
                                    Pic9None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA4EastMovementArea()
        i = 1
        If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox56Color()
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                Pic56None()
                PictureboxAbleToBlock(i) = 56
                CheckPicturebox57Color()
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                    Pic56None()
                    Pic57None()
                    PictureboxAbleToBlock(i) = 56
                    i = i + 1
                    PictureboxAbleToBlock(i) = 57
                    CheckPicturebox58Color()
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Pic56None()
                        Pic57None()
                        Pic58None()
                        PictureboxAbleToBlock(i) = 56
                        i = i + 1
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        CheckPicturebox59Color()
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Pic56None()
                            Pic57None()
                            Pic58None()
                            Pic59None()
                            PictureboxAbleToBlock(i) = 56
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            CheckPicturebox60Color()
                            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Pic56None()
                                Pic57None()
                                Pic58None()
                                Pic59None()
                                Pic60None()
                                PictureboxAbleToBlock(i) = 56
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                CheckPicturebox61Color()
                                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Pic56None()
                                    Pic57None()
                                    Pic58None()
                                    Pic59None()
                                    Pic60None()
                                    Pic61None()
                                    PictureboxAbleToBlock(i) = 56
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    CheckPicturebox62Color()
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox63.Image IsNot Form1.movementAreaPic.Image Then
                                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                        Pic56None()
                                        Pic57None()
                                        Pic58None()
                                        Pic59None()
                                        Pic60None()
                                        Pic61None()
                                        Pic62None()
                                        PictureboxAbleToBlock(i) = 56
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 57
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 58
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 59
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 60
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 61
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 62
                                        CheckPicturebox63Color()
                                    Else
                                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                        Pic56None()
                                        Pic57None()
                                        Pic58None()
                                        Pic59None()
                                        Pic60None()
                                        Pic61None()
                                        Pic62None()
                                        Pic63None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA4SouthMovementArea()
        i = 1
        If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox64Color()
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                Pic64None()
                PictureboxAbleToBlock(i) = 64
                CheckPicturebox73Color()
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                    Pic64None()
                    Pic73None()
                    PictureboxAbleToBlock(i) = 64
                    i = i + 1
                    PictureboxAbleToBlock(i) = 73
                    CheckPicturebox82Color()
                Else
                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                    Pic64None()
                    Pic73None()
                    Pic82None()
                End If
            End If
        End If
    End Sub

    Public Sub CheA4NorthMovementArea()
        i = 1
        If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox46Color()
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                Pic46None()
                PictureboxAbleToBlock(i) = 46
                CheckPicturebox37Color()
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                    Pic46None()
                    Pic37None()
                    PictureboxAbleToBlock(i) = 46
                    i = i + 1
                    PictureboxAbleToBlock(i) = 37
                    CheckPicturebox28Color()
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                        Pic46None()
                        Pic37None()
                        Pic28None()
                        PictureboxAbleToBlock(i) = 46
                        i = i + 1
                        PictureboxAbleToBlock(i) = 37
                        i = i + 1
                        PictureboxAbleToBlock(i) = 28
                        CheckPicturebox19Color()
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                            Pic46None()
                            Pic37None()
                            Pic28None()
                            Pic19None()
                            PictureboxAbleToBlock(i) = 46
                            i = i + 1
                            PictureboxAbleToBlock(i) = 37
                            i = i + 1
                            PictureboxAbleToBlock(i) = 28
                            i = i + 1
                            PictureboxAbleToBlock(i) = 19
                            CheckPicturebox10Color()
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                Pic46None()
                                Pic37None()
                                Pic28None()
                                Pic19None()
                                Pic10None()
                                PictureboxAbleToBlock(i) = 46
                                i = i + 1
                                PictureboxAbleToBlock(i) = 37
                                i = i + 1
                                PictureboxAbleToBlock(i) = 28
                                i = i + 1
                                PictureboxAbleToBlock(i) = 19
                                i = i + 1
                                PictureboxAbleToBlock(i) = 10
                                CheckPicturebox1Color()
                            Else
                                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                                Pic46None()
                                Pic37None()
                                Pic28None()
                                Pic19None()
                                Pic10None()
                                Pic1None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB4EastMovementArea()
        i = 1
        If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox57Color()
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                Pic57None()
                PictureboxAbleToBlock(i) = 57
                CheckPicturebox58Color()
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    Pic57None()
                    Pic58None()
                    PictureboxAbleToBlock(i) = 57
                    i = i + 1
                    PictureboxAbleToBlock(i) = 58
                    CheckPicturebox59Color()
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Pic57None()
                        Pic58None()
                        Pic59None()
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        CheckPicturebox60Color()
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Pic57None()
                            Pic58None()
                            Pic59None()
                            Pic60None()
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            CheckPicturebox61Color()
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                Pic57None()
                                Pic58None()
                                Pic59None()
                                Pic60None()
                                Pic61None()
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                CheckPicturebox62Color()
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                    Pic57None()
                                    Pic58None()
                                    Pic59None()
                                    Pic60None()
                                    Pic61None()
                                    Pic62None()
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 62
                                    CheckPicturebox63Color()
                                Else
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                    Pic57None()
                                    Pic58None()
                                    Pic59None()
                                    Pic60None()
                                    Pic61None()
                                    Pic62None()
                                    Pic63None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB4SouthMovementArea()
        i = 1
        If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox65Color()
            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                Pic65None()
                PictureboxAbleToBlock(i) = 65
                CheckPicturebox74Color()
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                    Pic65None()
                    Pic74None()
                    PictureboxAbleToBlock(i) = 65
                    i = i + 1
                    PictureboxAbleToBlock(i) = 74
                    CheckPicturebox83Color()
                Else
                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                    Pic65None()
                    Pic74None()
                    Pic83None()
                End If
            End If
        End If
    End Sub

    Public Sub CheB4WestMovementArea()
        If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox55Color()
        Else
            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
            Pic55None()
        End If
    End Sub

    Public Sub CheB4NorthMovementArea()
        i = 1
        If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox47Color()
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                Pic47None()
                PictureboxAbleToBlock(i) = 47
                CheckPicturebox38Color()
                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                    Pic47None()
                    Pic38None()
                    PictureboxAbleToBlock(i) = 47
                    i = i + 1
                    PictureboxAbleToBlock(i) = 38
                    CheckPicturebox29Color()
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                        Pic47None()
                        Pic38None()
                        Pic29None()
                        PictureboxAbleToBlock(i) = 47
                        i = i + 1
                        PictureboxAbleToBlock(i) = 38
                        i = i + 1
                        PictureboxAbleToBlock(i) = 29
                        CheckPicturebox20Color()
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                            Pic47None()
                            Pic38None()
                            Pic29None()
                            Pic20None()
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 20
                            CheckPicturebox11Color()
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                Pic47None()
                                Pic38None()
                                Pic29None()
                                Pic20None()
                                Pic11None()
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 20
                                i = i + 1
                                PictureboxAbleToBlock(i) = 11
                                CheckPicturebox2Color()
                            Else
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                Pic47None()
                                Pic38None()
                                Pic29None()
                                Pic20None()
                                Pic11None()
                                Pic2None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC4EastMovementArea()
        i = 1
        If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox58Color()
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                Pic58None()
                PictureboxAbleToBlock(i) = 58
                CheckPicturebox59Color()
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    Pic58None()
                    Pic59None()
                    PictureboxAbleToBlock(i) = 58
                    i = i + 1
                    PictureboxAbleToBlock(i) = 59
                    CheckPicturebox60Color()
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Pic58None()
                        Pic59None()
                        Pic60None()
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        CheckPicturebox61Color()
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                            Pic58None()
                            Pic59None()
                            Pic60None()
                            Pic61None()
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            CheckPicturebox62Color()
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                Pic58None()
                                Pic59None()
                                Pic60None()
                                Pic61None()
                                Pic62None()
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 62
                                CheckPicturebox63Color()
                            Else
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                Pic58None()
                                Pic59None()
                                Pic60None()
                                Pic61None()
                                Pic62None()
                                Pic63None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC4SouthMovementArea()
        i = 1
        If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox66Color()
            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                Pic66None()
                PictureboxAbleToBlock(i) = 66
                CheckPicturebox75Color()
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                    Pic66None()
                    Pic75None()
                    PictureboxAbleToBlock(i) = 66
                    i = i + 1
                    PictureboxAbleToBlock(i) = 75
                    CheckPicturebox84Color()
                Else
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                    Pic66None()
                    Pic75None()
                    Pic84None()
                End If
            End If
        End If
    End Sub

    Public Sub CheC4WestMovementArea()
        i = 1
        If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox56Color()
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                Pic56None()
                PictureboxAbleToBlock(i) = 56
                CheckPicturebox55Color()
            Else
                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                Pic56None()
                Pic55None()
            End If
        End If
    End Sub

    Public Sub CheC4NorthMovementArea()
        i = 1
        If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox48Color()
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                Pic48None()
                PictureboxAbleToBlock(i) = 48
                CheckPicturebox39Color()
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                    Pic48None()
                    Pic39None()
                    PictureboxAbleToBlock(i) = 48
                    i = i + 1
                    PictureboxAbleToBlock(i) = 39
                    CheckPicturebox30Color()
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                        Pic48None()
                        Pic39None()
                        Pic30None()
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 30
                        CheckPicturebox21Color()
                        Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                            Pic48None()
                            Pic39None()
                            Pic30None()
                            Pic21None()
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 21
                            CheckPicturebox12Color()
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                Pic48None()
                                Pic39None()
                                Pic30None()
                                Pic21None()
                                Pic12None()
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 21
                                i = i + 1
                                PictureboxAbleToBlock(i) = 12
                                CheckPicturebox3Color()
                            Else
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                Pic48None()
                                Pic39None()
                                Pic30None()
                                Pic21None()
                                Pic12None()
                                Pic3None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD4EastMovementArea()
        i = 1
        If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox59Color()
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                Pic59None()
                PictureboxAbleToBlock(i) = 59
                CheckPicturebox60Color()
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    Pic59None()
                    Pic60None()
                    PictureboxAbleToBlock(i) = 59
                    i = i + 1
                    PictureboxAbleToBlock(i) = 60
                    CheckPicturebox61Color()
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                        Pic59None()
                        Pic60None()
                        Pic61None()
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 61
                        CheckPicturebox62Color()
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                            Pic59None()
                            Pic60None()
                            Pic61None()
                            Pic62None()
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 62
                            CheckPicturebox63Color()
                        Else
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                            Pic59None()
                            Pic60None()
                            Pic61None()
                            Pic62None()
                            Pic63None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD4SouthMovementArea()
        i = 1
        If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox67Color()
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                Pic67None()
                PictureboxAbleToBlock(i) = 67
                CheckPicturebox76Color()
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                    Pic67None()
                    Pic76None()
                    PictureboxAbleToBlock(i) = 67
                    i = i + 1
                    PictureboxAbleToBlock(i) = 76
                    CheckPicturebox85Color()
                Else
                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                    Pic67None()
                    Pic76None()
                    Pic85None()
                End If
            End If
        End If
    End Sub

    Public Sub CheD4WestMovementArea()
        i = 1
        If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox57Color()
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                Pic57None()
                PictureboxAbleToBlock(i) = 57
                CheckPicturebox56Color()
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                    Pic57None()
                    Pic56None()
                    PictureboxAbleToBlock(i) = 57
                    i = i + 1
                    PictureboxAbleToBlock(i) = 56
                    CheckPicturebox55Color()
                Else
                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                    Pic57None()
                    Pic56None()
                    Pic55None()
                End If
            End If
        End If
    End Sub

    Public Sub CheD4NorthMovementArea()
        i = 1
        If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox49Color()
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                Pic49None()
                PictureboxAbleToBlock(i) = 49
                CheckPicturebox40Color()
                Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    Pic49None()
                    Pic40None()
                    PictureboxAbleToBlock(i) = 49
                    i = i + 1
                    PictureboxAbleToBlock(i) = 40
                    CheckPicturebox31Color()
                    Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Pic49None()
                        Pic40None()
                        Pic31None()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 31
                        CheckPicturebox22Color()
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                            Pic49None()
                            Pic40None()
                            Pic31None()
                            Pic22None()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                            CheckPicturebox13Color()
                            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                Pic49None()
                                Pic40None()
                                Pic31None()
                                Pic22None()
                                Pic13None()
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 22
                                i = i + 1
                                PictureboxAbleToBlock(i) = 13
                                CheckPicturebox4Color()
                            Else
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                Pic49None()
                                Pic40None()
                                Pic31None()
                                Pic22None()
                                Pic13None()
                                Pic4None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE4EastMovementArea()
        i = 1
        If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox60Color()
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
                PictureboxAbleToBlock(i) = 60
                CheckPicturebox61Color()
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    Pic60None()
                    Pic61None()
                    PictureboxAbleToBlock(i) = 60
                    i = i + 1
                    PictureboxAbleToBlock(i) = 61
                    CheckPicturebox62Color()
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                        Pic60None()
                        Pic61None()
                        Pic62None()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 62
                        CheckPicturebox63Color()
                    Else
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                        Pic60None()
                        Pic61None()
                        Pic62None()
                        Pic63None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE4SouthMovementArea()
        i = 1
        If Form1.PictureBox68.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox68Color()
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox77.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
                PictureboxAbleToBlock(i) = 68
                CheckPicturebox77Color()
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    Pic68None()
                    Pic77None()
                    PictureboxAbleToBlock(i) = 68
                    i = i + 1
                    PictureboxAbleToBlock(i) = 77
                    CheckPicturebox86Color()
                Else
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                    Pic68None()
                    Pic77None()
                    Pic86None()
                End If
            End If
        End If
    End Sub

    Public Sub CheE4WestMovementArea()
        i = 1
        If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox58Color()
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                Pic58None()
                PictureboxAbleToBlock(i) = 58
                CheckPicturebox57Color()
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                    Pic58None()
                    Pic57None()
                    PictureboxAbleToBlock(i) = 58
                    i = i + 1
                    PictureboxAbleToBlock(i) = 57
                    CheckPicturebox56Color()
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                        Pic58None()
                        Pic57None()
                        Pic56None()
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 56
                        CheckPicturebox55Color()
                    Else
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                        Pic58None()
                        Pic57None()
                        Pic56None()
                        Pic55None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE4NorthMovementArea()
        i = 1
        If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox50Color()
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
                PictureboxAbleToBlock(i) = 50
                CheckPicturebox41Color()
                Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    Pic50None()
                    Pic41None()
                    PictureboxAbleToBlock(i) = 50
                    i = i + 1
                    PictureboxAbleToBlock(i) = 41
                    CheckPicturebox32Color()
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Pic50None()
                        Pic41None()
                        Pic32None()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 32
                        CheckPicturebox23Color()
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Pic50None()
                            Pic41None()
                            Pic32None()
                            Pic23None()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            CheckPicturebox14Color()
                            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                Pic50None()
                                Pic41None()
                                Pic32None()
                                Pic23None()
                                Pic14None()
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 23
                                i = i + 1
                                PictureboxAbleToBlock(i) = 14
                                CheckPicturebox5Color()
                            Else
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                Pic50None()
                                Pic41None()
                                Pic32None()
                                Pic23None()
                                Pic14None()
                                Pic5None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF4EastMovementArea()
        i = 1
        If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox61Color()
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
                PictureboxAbleToBlock(i) = 61
                CheckPicturebox62Color()
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    Pic61None()
                    Pic62None()
                    PictureboxAbleToBlock(i) = 61
                    i = i + 1
                    PictureboxAbleToBlock(i) = 62
                    CheckPicturebox63Color()
                Else
                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    Pic61None()
                    Pic62None()
                    Pic63None()
                End If
            End If
        End If
    End Sub

    Public Sub CheF4SouthMovementArea()
        i = 1
        If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox69Color()
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
                PictureboxAbleToBlock(i) = 69
                CheckPicturebox78Color()
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    Pic69None()
                    Pic78None()
                    PictureboxAbleToBlock(i) = 69
                    i = i + 1
                    PictureboxAbleToBlock(i) = 78
                    CheckPicturebox87Color()
                Else
                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                    Pic69None()
                    Pic78None()
                    Pic87None()
                End If
            End If
        End If
    End Sub

    Public Sub CheF4WestMovementArea()
        i = 1
        If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox59Color()
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                Pic59None()
                PictureboxAbleToBlock(i) = 59
                CheckPicturebox58Color()
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    Pic59None()
                    Pic58None()
                    PictureboxAbleToBlock(i) = 59
                    i = i + 1
                    PictureboxAbleToBlock(i) = 58
                    CheckPicturebox57Color()
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                        Pic59None()
                        Pic58None()
                        Pic57None()
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 57
                        CheckPicturebox56Color()
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                            Pic59None()
                            Pic58None()
                            Pic57None()
                            Pic56None()
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 56
                            CheckPicturebox55Color()
                        Else
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                            Pic59None()
                            Pic58None()
                            Pic57None()
                            Pic56None()
                            Pic55None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF4NorthMovementArea()
        i = 1
        If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox51Color()
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                Pic51None()
                PictureboxAbleToBlock(i) = 51
                CheckPicturebox42Color()
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    Pic51None()
                    Pic42None()
                    PictureboxAbleToBlock(i) = 51
                    i = i + 1
                    PictureboxAbleToBlock(i) = 42
                    CheckPicturebox33Color()
                    Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Pic51None()
                        Pic42None()
                        Pic33None()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 33
                        CheckPicturebox24Color()
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                            Pic51None()
                            Pic42None()
                            Pic33None()
                            Pic24None()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                            CheckPicturebox15Color()
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                Pic51None()
                                Pic42None()
                                Pic33None()
                                Pic24None()
                                Pic15None()
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                i = i + 1
                                PictureboxAbleToBlock(i) = 15
                                CheckPicturebox6Color()
                            Else
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                Pic51None()
                                Pic42None()
                                Pic33None()
                                Pic24None()
                                Pic15None()
                                Pic6None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG4EastMovementArea()
        i = 1
        If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox62Color()
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
                PictureboxAbleToBlock(i) = 62
                CheckPicturebox63Color()
            Else
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                Pic62None()
                Pic63None()
            End If
        End If
    End Sub

    Public Sub CheG4SouthMovementArea()
        i = 1
        If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox70Color()
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
                PictureboxAbleToBlock(i) = 70
                CheckPicturebox79Color()
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    Pic70None()
                    Pic79None()
                    PictureboxAbleToBlock(i) = 70
                    i = i + 1
                    PictureboxAbleToBlock(i) = 79
                    CheckPicturebox88Color()
                Else
                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                    Pic70None()
                    Pic79None()
                    Pic88None()
                End If
            End If
        End If
    End Sub

    Public Sub CheG4WestMovementArea()
        i = 1
        If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox60Color()
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
                PictureboxAbleToBlock(i) = 60
                CheckPicturebox59Color()
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    Pic60None()
                    Pic59None()
                    PictureboxAbleToBlock(i) = 60
                    i = i + 1
                    PictureboxAbleToBlock(i) = 59
                    CheckPicturebox58Color()
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Pic60None()
                        Pic59None()
                        Pic58None()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        CheckPicturebox57Color()
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                            Pic60None()
                            Pic59None()
                            Pic58None()
                            Pic57None()
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            CheckPicturebox56Color()
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                Pic60None()
                                Pic59None()
                                Pic58None()
                                Pic57None()
                                Pic56None()
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 56
                                CheckPicturebox55Color()
                            Else
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                Pic60None()
                                Pic59None()
                                Pic58None()
                                Pic57None()
                                Pic56None()
                                Pic55None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG4NorthMovementArea()
        i = 1
        If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox52Color()
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
                PictureboxAbleToBlock(i) = 52
                CheckPicturebox43Color()
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    Pic52None()
                    Pic43None()
                    PictureboxAbleToBlock(i) = 52
                    i = i + 1
                    PictureboxAbleToBlock(i) = 43
                    CheckPicturebox34Color()
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                        Pic52None()
                        Pic43None()
                        Pic34None()
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 34
                        CheckPicturebox25Color()
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                            Pic52None()
                            Pic43None()
                            Pic34None()
                            Pic25None()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            i = i + 1
                            PictureboxAbleToBlock(i) = 25
                            CheckPicturebox16Color()
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                Pic52None()
                                Pic43None()
                                Pic34None()
                                Pic25None()
                                Pic16None()
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                                i = i + 1
                                PictureboxAbleToBlock(i) = 16
                                CheckPicturebox7Color()
                            Else
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                Pic52None()
                                Pic43None()
                                Pic34None()
                                Pic25None()
                                Pic16None()
                                Pic7None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH4EastMovementArea()
        If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox63Color()
        Else
            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
            Pic63None()
        End If
    End Sub

    Public Sub CheH4SouthMovementArea()
        i = 1
        If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox71Color()
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
                PictureboxAbleToBlock(i) = 71
                CheckPicturebox80Color()
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                    Pic71None()
                    Pic80None()
                    PictureboxAbleToBlock(i) = 71
                    i = i + 1
                    PictureboxAbleToBlock(i) = 80
                    CheckPicturebox89Color()
                Else
                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                    Pic71None()
                    Pic80None()
                    Pic89None()
                End If
            End If
        End If
    End Sub

    Public Sub CheH4WestMovementArea()
        i = 1
        If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox61Color()
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
                PictureboxAbleToBlock(i) = 61
                CheckPicturebox60Color()
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    Pic61None()
                    Pic60None()
                    PictureboxAbleToBlock(i) = 61
                    i = i + 1
                    PictureboxAbleToBlock(i) = 60
                    CheckPicturebox59Color()
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Pic61None()
                        Pic60None()
                        Pic59None()
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        CheckPicturebox58Color()
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Pic61None()
                            Pic60None()
                            Pic59None()
                            Pic58None()
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            CheckPicturebox57Color()
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                Pic61None()
                                Pic60None()
                                Pic59None()
                                Pic58None()
                                Pic57None()
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                CheckPicturebox56Color()
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                    Pic61None()
                                    Pic60None()
                                    Pic59None()
                                    Pic58None()
                                    Pic57None()
                                    Pic56None()
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 56
                                    CheckPicturebox55Color()
                                Else
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                    Pic61None()
                                    Pic60None()
                                    Pic59None()
                                    Pic58None()
                                    Pic57None()
                                    Pic56None()
                                    Pic55None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH4NorthMovementArea()
        i = 1
        If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox53Color()
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
                PictureboxAbleToBlock(i) = 53
                CheckPicturebox44Color()
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    Pic53None()
                    Pic44None()
                    PictureboxAbleToBlock(i) = 53
                    i = i + 1
                    PictureboxAbleToBlock(i) = 44
                    CheckPicturebox35Color()
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                        Pic53None()
                        Pic44None()
                        Pic35None()
                        PictureboxAbleToBlock(i) = 53
                        i = i + 1
                        PictureboxAbleToBlock(i) = 44
                        i = i + 1
                        PictureboxAbleToBlock(i) = 35
                        CheckPicturebox26Color()
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                            Pic53None()
                            Pic44None()
                            Pic35None()
                            Pic26None()
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            i = i + 1
                            PictureboxAbleToBlock(i) = 26
                            CheckPicturebox17Color()
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                Pic53None()
                                Pic44None()
                                Pic35None()
                                Pic26None()
                                Pic17None()
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                i = i + 1
                                PictureboxAbleToBlock(i) = 26
                                i = i + 1
                                PictureboxAbleToBlock(i) = 17
                                CheckPicturebox8Color()
                            Else
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                Pic53None()
                                Pic44None()
                                Pic35None()
                                Pic26None()
                                Pic17None()
                                Pic8None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI4SouthMovementArea()
        i = 1
        If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox72Color()
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                Pic72None()
                PictureboxAbleToBlock(i) = 72
                CheckPicturebox81Color()
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                    Pic72None()
                    Pic81None()
                    PictureboxAbleToBlock(i) = 72
                    i = i + 1
                    PictureboxAbleToBlock(i) = 81
                    CheckPicturebox90Color()
                Else
                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                    Pic72None()
                    Pic81None()
                    Pic90None()
                End If
            End If
        End If
    End Sub

    Public Sub CheI4WestMovementArea()
        i = 1
        If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox62Color()
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
                PictureboxAbleToBlock(i) = 62
                CheckPicturebox61Color()
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    Pic62None()
                    Pic61None()
                    PictureboxAbleToBlock(i) = 62
                    i = i + 1
                    PictureboxAbleToBlock(i) = 61
                    CheckPicturebox60Color()
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Pic62None()
                        Pic61None()
                        Pic60None()
                        PictureboxAbleToBlock(i) = 62
                        i = i + 1
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        CheckPicturebox59Color()
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Pic62None()
                            Pic61None()
                            Pic60None()
                            Pic59None()
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            CheckPicturebox58Color()
                            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Pic62None()
                                Pic61None()
                                Pic60None()
                                Pic59None()
                                Pic58None()
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                CheckPicturebox57Color()
                                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Pic62None()
                                    Pic61None()
                                    Pic60None()
                                    Pic59None()
                                    Pic58None()
                                    Pic57None()
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    CheckPicturebox56Color()
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                        Pic62None()
                                        Pic61None()
                                        Pic60None()
                                        Pic59None()
                                        Pic58None()
                                        Pic57None()
                                        Pic56None()
                                        PictureboxAbleToBlock(i) = 62
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 61
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 60
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 59
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 58
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 57
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 56
                                        CheckPicturebox55Color()
                                    Else
                                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                        Pic62None()
                                        Pic61None()
                                        Pic60None()
                                        Pic59None()
                                        Pic58None()
                                        Pic57None()
                                        Pic56None()
                                        Pic55None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI4NorthMovementArea()
        i = 1
        If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox54Color()
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                Pic54None()
                PictureboxAbleToBlock(i) = 54
                CheckPicturebox45Color()
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    Pic54None()
                    Pic45None()
                    PictureboxAbleToBlock(i) = 54
                    i = i + 1
                    PictureboxAbleToBlock(i) = 45
                    CheckPicturebox36Color()
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                        Pic54None()
                        Pic45None()
                        Pic36None()
                        PictureboxAbleToBlock(i) = 54
                        i = i + 1
                        PictureboxAbleToBlock(i) = 45
                        i = i + 1
                        PictureboxAbleToBlock(i) = 36
                        CheckPicturebox27Color()
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                            Pic54None()
                            Pic45None()
                            Pic36None()
                            Pic27None()
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 36
                            i = i + 1
                            PictureboxAbleToBlock(i) = 27
                            CheckPicturebox18Color()
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                Pic54None()
                                Pic45None()
                                Pic36None()
                                Pic27None()
                                Pic18None()
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 36
                                i = i + 1
                                PictureboxAbleToBlock(i) = 27
                                i = i + 1
                                PictureboxAbleToBlock(i) = 18
                                CheckPicturebox9Color()
                            Else
                                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                                Pic54None()
                                Pic45None()
                                Pic36None()
                                Pic27None()
                                Pic18None()
                                Pic9None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA5EastMovementArea()
        i = 1
        If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox47Color()
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                Pic47None()
                PictureboxAbleToBlock(i) = 47
                CheckPicturebox48Color()
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                    Pic47None()
                    Pic48None()
                    PictureboxAbleToBlock(i) = 47
                    i = i + 1
                    PictureboxAbleToBlock(i) = 48
                    CheckPicturebox49Color()
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Pic47None()
                        Pic48None()
                        Pic49None()
                        PictureboxAbleToBlock(i) = 47
                        i = i + 1
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        CheckPicturebox50Color()
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Pic47None()
                            Pic48None()
                            Pic49None()
                            Pic50None()
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            CheckPicturebox51Color()
                            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Pic47None()
                                Pic48None()
                                Pic49None()
                                Pic50None()
                                Pic51None()
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                CheckPicturebox52Color()
                                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Pic47None()
                                    Pic48None()
                                    Pic49None()
                                    Pic50None()
                                    Pic51None()
                                    Pic52None()
                                    PictureboxAbleToBlock(i) = 47
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    CheckPicturebox53Color()
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                        Pic47None()
                                        Pic48None()
                                        Pic49None()
                                        Pic50None()
                                        Pic51None()
                                        Pic52None()
                                        Pic53None()
                                        PictureboxAbleToBlock(i) = 47
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 48
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 49
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 50
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 51
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 52
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 53
                                        CheckPicturebox54Color()
                                    Else
                                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                        Pic47None()
                                        Pic48None()
                                        Pic49None()
                                        Pic50None()
                                        Pic51None()
                                        Pic52None()
                                        Pic53None()
                                        Pic54None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA5SouthMovementArea()
        i = 1
        If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox55Color()
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                Pic55None()
                PictureboxAbleToBlock(i) = 55
                CheckPicturebox64Color()
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                    Pic55None()
                    Pic64None()
                    PictureboxAbleToBlock(i) = 55
                    i = i + 1
                    PictureboxAbleToBlock(i) = 64
                    CheckPicturebox73Color()
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                        Pic55None()
                        Pic64None()
                        Pic73None()
                        PictureboxAbleToBlock(i) = 55
                        i = i + 1
                        PictureboxAbleToBlock(i) = 64
                        i = i + 1
                        PictureboxAbleToBlock(i) = 73
                        CheckPicturebox82Color()
                    Else
                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                        Pic55None()
                        Pic64None()
                        Pic73None()
                        Pic82None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA5NorthMovementArea()
        i = 1
        If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox37Color()
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                Pic37None()
                PictureboxAbleToBlock(i) = 37
                CheckPicturebox28Color()
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                    Pic37None()
                    Pic28None()
                    PictureboxAbleToBlock(i) = 37
                    i = i + 1
                    PictureboxAbleToBlock(i) = 28
                    CheckPicturebox19Color()
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                        Pic37None()
                        Pic28None()
                        Pic19None()
                        PictureboxAbleToBlock(i) = 37
                        i = i + 1
                        PictureboxAbleToBlock(i) = 28
                        i = i + 1
                        PictureboxAbleToBlock(i) = 19
                        CheckPicturebox10Color()
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                            Pic37None()
                            Pic28None()
                            Pic19None()
                            Pic10None()
                            PictureboxAbleToBlock(i) = 37
                            i = i + 1
                            PictureboxAbleToBlock(i) = 28
                            i = i + 1
                            PictureboxAbleToBlock(i) = 19
                            i = i + 1
                            PictureboxAbleToBlock(i) = 10
                            CheckPicturebox1Color()
                        Else
                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                            Pic37None()
                            Pic28None()
                            Pic19None()
                            Pic10None()
                            Pic1None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB5EastMovementArea()
        i = 1
        If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox48Color()
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                Pic48None()
                PictureboxAbleToBlock(i) = 48
                CheckPicturebox49Color()
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    Pic48None()
                    Pic49None()
                    PictureboxAbleToBlock(i) = 48
                    i = i + 1
                    PictureboxAbleToBlock(i) = 49
                    CheckPicturebox50Color()
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Pic48None()
                        Pic49None()
                        Pic50None()
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        CheckPicturebox51Color()
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Pic48None()
                            Pic49None()
                            Pic50None()
                            Pic51None()
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            CheckPicturebox52Color()
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Pic48None()
                                Pic49None()
                                Pic50None()
                                Pic51None()
                                Pic52None()
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                CheckPicturebox53Color()
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                    Pic48None()
                                    Pic49None()
                                    Pic50None()
                                    Pic51None()
                                    Pic52None()
                                    Pic53None()
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                    CheckPicturebox54Color()
                                Else
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                    Pic48None()
                                    Pic49None()
                                    Pic50None()
                                    Pic51None()
                                    Pic52None()
                                    Pic53None()
                                    Pic54None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB5SouthMovementArea()
        i = 1
        If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox56Color()
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                Pic56None()
                PictureboxAbleToBlock(i) = 56
                CheckPicturebox65Color()
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                    Pic56None()
                    Pic65None()
                    PictureboxAbleToBlock(i) = 56
                    i = i + 1
                    PictureboxAbleToBlock(i) = 65
                    CheckPicturebox74Color()
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                        Pic56None()
                        Pic65None()
                        Pic74None()
                        PictureboxAbleToBlock(i) = 56
                        i = i + 1
                        PictureboxAbleToBlock(i) = 65
                        i = i + 1
                        PictureboxAbleToBlock(i) = 74
                        CheckPicturebox83Color()
                    Else
                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                        Pic56None()
                        Pic65None()
                        Pic74None()
                        Pic83None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB5WestMovementArea()
        If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox46Color()
        Else
            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
            Pic46None()
        End If
    End Sub

    Public Sub CheB5NorthMovementArea()
        i = 1
        If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox38Color()
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                Pic38None()
                PictureboxAbleToBlock(i) = 38
                CheckPicturebox29Color()
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                    Pic38None()
                    Pic29None()
                    PictureboxAbleToBlock(i) = 38
                    i = i + 1
                    PictureboxAbleToBlock(i) = 29
                    CheckPicturebox20Color()
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                        Pic38None()
                        Pic29None()
                        Pic20None()
                        PictureboxAbleToBlock(i) = 38
                        i = i + 1
                        PictureboxAbleToBlock(i) = 29
                        i = i + 1
                        PictureboxAbleToBlock(i) = 20
                        CheckPicturebox11Color()
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                            Pic38None()
                            Pic29None()
                            Pic20None()
                            Pic11None()
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 20
                            i = i + 1
                            PictureboxAbleToBlock(i) = 11
                            CheckPicturebox2Color()
                        Else
                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                            Pic38None()
                            Pic29None()
                            Pic20None()
                            Pic11None()
                            Pic2None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC5EastMovementArea()
        i = 1
        If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox49Color()
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                Pic49None()
                PictureboxAbleToBlock(i) = 49
                CheckPicturebox50Color()
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    Pic49None()
                    Pic50None()
                    PictureboxAbleToBlock(i) = 49
                    i = i + 1
                    PictureboxAbleToBlock(i) = 50
                    CheckPicturebox51Color()
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Pic49None()
                        Pic50None()
                        Pic51None()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        CheckPicturebox52Color()
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Pic49None()
                            Pic50None()
                            Pic51None()
                            Pic52None()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            CheckPicturebox53Color()
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Pic49None()
                                Pic50None()
                                Pic51None()
                                Pic52None()
                                Pic53None()
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                                CheckPicturebox54Color()
                            Else
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                Pic49None()
                                Pic50None()
                                Pic51None()
                                Pic52None()
                                Pic53None()
                                Pic54None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC5SouthMovementArea()
        i = 1
        If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox57Color()
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                Pic57None()
                PictureboxAbleToBlock(i) = 57
                CheckPicturebox66Color()
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                    Pic57None()
                    Pic66None()
                    PictureboxAbleToBlock(i) = 57
                    i = i + 1
                    PictureboxAbleToBlock(i) = 66
                    CheckPicturebox75Color()
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                        Pic57None()
                        Pic66None()
                        Pic75None()
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 66
                        i = i + 1
                        PictureboxAbleToBlock(i) = 75
                        CheckPicturebox84Color()
                    Else
                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                        Pic57None()
                        Pic66None()
                        Pic75None()
                        Pic84None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC5WestMovementArea()
        i = 1
        If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox47Color()
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                Pic47None()
                PictureboxAbleToBlock(i) = 47
                CheckPicturebox46Color()
            Else
                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                Pic47None()
                Pic46None()
            End If
        End If
    End Sub

    Public Sub CheC5NorthMovementArea()
        i = 1
        If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox39Color()
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                Pic39None()
                PictureboxAbleToBlock(i) = 39
                CheckPicturebox30Color()
                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                    Pic39None()
                    Pic30None()
                    PictureboxAbleToBlock(i) = 39
                    i = i + 1
                    PictureboxAbleToBlock(i) = 30
                    CheckPicturebox21Color()
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                        Pic39None()
                        Pic30None()
                        Pic21None()
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 30
                        i = i + 1
                        PictureboxAbleToBlock(i) = 21
                        CheckPicturebox12Color()
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                            Pic39None()
                            Pic30None()
                            Pic21None()
                            Pic12None()
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 21
                            i = i + 1
                            PictureboxAbleToBlock(i) = 12
                            CheckPicturebox3Color()
                        Else
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                            Pic39None()
                            Pic30None()
                            Pic21None()
                            Pic12None()
                            Pic3None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD5EastMovementArea()
        i = 1
        If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox50Color()
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
                PictureboxAbleToBlock(i) = 50
                CheckPicturebox51Color()
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    Pic50None()
                    Pic51None()
                    PictureboxAbleToBlock(i) = 50
                    i = i + 1
                    PictureboxAbleToBlock(i) = 51
                    CheckPicturebox52Color()
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                        Pic50None()
                        Pic51None()
                        Pic52None()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 52
                        CheckPicturebox53Color()
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                            Pic50None()
                            Pic51None()
                            Pic52None()
                            Pic53None()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 53
                            CheckPicturebox54Color()
                        Else
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                            Pic50None()
                            Pic51None()
                            Pic52None()
                            Pic53None()
                            Pic54None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD5SouthMovementArea()
        i = 1
        If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox58Color()
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                Pic58None()
                PictureboxAbleToBlock(i) = 58
                CheckPicturebox67Color()
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                    Pic58None()
                    Pic67None()
                    PictureboxAbleToBlock(i) = 58
                    i = i + 1
                    PictureboxAbleToBlock(i) = 67
                    CheckPicturebox76Color()
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                        Pic58None()
                        Pic67None()
                        Pic76None()
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 67
                        i = i + 1
                        PictureboxAbleToBlock(i) = 76
                        CheckPicturebox85Color()
                    Else
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                        Pic58None()
                        Pic67None()
                        Pic76None()
                        Pic85None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD5WestMovementArea()
        i = 1
        If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox48Color()
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                Pic48None()
                PictureboxAbleToBlock(i) = 48
                CheckPicturebox47Color()
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                    Pic48None()
                    Pic47None()
                    PictureboxAbleToBlock(i) = 48
                    i = i + 1
                    PictureboxAbleToBlock(i) = 47
                    CheckPicturebox46Color()
                Else
                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                    Pic48None()
                    Pic47None()
                    Pic46None()
                End If
            End If
        End If
    End Sub

    Public Sub CheD5NorthMovementArea()
        i = 1
        If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox40Color()
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                Pic40None()
                PictureboxAbleToBlock(i) = 40
                CheckPicturebox31Color()
                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    Pic40None()
                    Pic31None()
                    PictureboxAbleToBlock(i) = 40
                    i = i + 1
                    PictureboxAbleToBlock(i) = 31
                    CheckPicturebox22Color()
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                        Pic40None()
                        Pic31None()
                        Pic22None()
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 31
                        i = i + 1
                        PictureboxAbleToBlock(i) = 22
                        CheckPicturebox13Color()
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                            Pic40None()
                            Pic31None()
                            Pic22None()
                            Pic13None()
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                            i = i + 1
                            PictureboxAbleToBlock(i) = 13
                            CheckPicturebox4Color()
                        Else
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                            Pic40None()
                            Pic31None()
                            Pic22None()
                            Pic13None()
                            Pic4None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE5EastMovementArea()
        i = 1
        If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox51Color()
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                Pic51None()
                PictureboxAbleToBlock(i) = 51
                CheckPicturebox52Color()
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    Pic51None()
                    Pic52None()
                    PictureboxAbleToBlock(i) = 51
                    i = i + 1
                    PictureboxAbleToBlock(i) = 52
                    CheckPicturebox53Color()
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                        Pic51None()
                        Pic52None()
                        Pic53None()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 53
                        CheckPicturebox54Color()
                    Else
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                        Pic51None()
                        Pic52None()
                        Pic53None()
                        Pic54None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE5SouthMovementArea()
        i = 1
        If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox59Color()
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox68 IsNot Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                Pic59None()
                PictureboxAbleToBlock(i) = 59
                CheckPicturebox68Color()
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox77 IsNot Form1.nonePic.Image Then
                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    Pic59None()
                    Pic68None()
                    PictureboxAbleToBlock(i) = 59
                    i = i + 1
                    PictureboxAbleToBlock(i) = 68
                    CheckPicturebox77Color()
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                        Pic59None()
                        Pic68None()
                        Pic77None()
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 68
                        i = i + 1
                        PictureboxAbleToBlock(i) = 77
                        CheckPicturebox86Color()
                    Else
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                        Pic59None()
                        Pic68None()
                        Pic77None()
                        Pic86None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE5WestMovementArea()
        i = 1
        If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox49Color()
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                Pic49None()
                PictureboxAbleToBlock(i) = 49
                CheckPicturebox48Color()
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                    Pic49None()
                    Pic48None()
                    PictureboxAbleToBlock(i) = 49
                    i = i + 1
                    PictureboxAbleToBlock(i) = 48
                    CheckPicturebox47Color()
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                        Pic49None()
                        Pic48None()
                        Pic47None()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 47
                        CheckPicturebox46Color()
                    Else
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                        Pic49None()
                        Pic48None()
                        Pic47None()
                        Pic46None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE5NorthMovementArea()
        i = 1
        If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox41Color()
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
                PictureboxAbleToBlock(i) = 41
                CheckPicturebox32Color()
                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    Pic41None()
                    Pic32None()
                    PictureboxAbleToBlock(i) = 41
                    i = i + 1
                    PictureboxAbleToBlock(i) = 32
                    CheckPicturebox23Color()
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                        Pic41None()
                        Pic32None()
                        Pic23None()
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 32
                        i = i + 1
                        PictureboxAbleToBlock(i) = 23
                        CheckPicturebox14Color()
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Pic41None()
                            Pic32None()
                            Pic23None()
                            Pic14None()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            i = i + 1
                            PictureboxAbleToBlock(i) = 14
                            CheckPicturebox5Color()
                        Else
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                            Pic41None()
                            Pic32None()
                            Pic23None()
                            Pic14None()
                            Pic5None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF5EastMovementArea()
        i = 1
        If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox52Color()
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
                PictureboxAbleToBlock(i) = 52
                CheckPicturebox53Color()
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    Pic52None()
                    Pic53None()
                    PictureboxAbleToBlock(i) = 52
                    i = i + 1
                    PictureboxAbleToBlock(i) = 53
                    CheckPicturebox54Color()
                Else
                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    Pic52None()
                    Pic53None()
                    Pic54None()
                End If
            End If
        End If
    End Sub

    Public Sub CheF5SouthMovementArea()
        i = 1
        If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox60Color()
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
                PictureboxAbleToBlock(i) = 60
                CheckPicturebox69Color()
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    Pic60None()
                    Pic69None()
                    PictureboxAbleToBlock(i) = 60
                    i = i + 1
                    PictureboxAbleToBlock(i) = 69
                    CheckPicturebox78Color()
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                        Pic60None()
                        Pic69None()
                        Pic78None()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 69
                        i = i + 1
                        PictureboxAbleToBlock(i) = 78
                        CheckPicturebox87Color()
                    Else
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                        Pic60None()
                        Pic69None()
                        Pic78None()
                        Pic87None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF5WestMovementArea()
        i = 1
        If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox50Color()
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
                PictureboxAbleToBlock(i) = 50
                CheckPicturebox49Color()
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    Pic50None()
                    Pic49None()
                    PictureboxAbleToBlock(i) = 50
                    i = i + 1
                    PictureboxAbleToBlock(i) = 49
                    CheckPicturebox48Color()
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                        Pic50None()
                        Pic49None()
                        Pic48None()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 48
                        CheckPicturebox47Color()
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                            Pic50None()
                            Pic49None()
                            Pic48None()
                            Pic47None()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 47
                            CheckPicturebox46Color()
                        Else
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                            Pic50None()
                            Pic49None()
                            Pic48None()
                            Pic47None()
                            Pic46None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF5NorthMovementArea()
        i = 1
        If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox42Color()
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                Pic42None()
                PictureboxAbleToBlock(i) = 42
                CheckPicturebox33Color()
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    Pic42None()
                    Pic33None()
                    PictureboxAbleToBlock(i) = 42
                    i = i + 1
                    PictureboxAbleToBlock(i) = 33
                    CheckPicturebox24Color()
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                        Pic42None()
                        Pic33None()
                        Pic24None()
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 33
                        i = i + 1
                        PictureboxAbleToBlock(i) = 24
                        CheckPicturebox15Color()
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                            Pic42None()
                            Pic33None()
                            Pic24None()
                            Pic15None()
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                            i = i + 1
                            PictureboxAbleToBlock(i) = 15
                            CheckPicturebox6Color()
                        Else
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                            Pic42None()
                            Pic33None()
                            Pic24None()
                            Pic15None()
                            Pic6None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG5EastMovementArea()
        i = 1
        If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox53Color()
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
                PictureboxAbleToBlock(i) = 53
                CheckPicturebox54Color()
            Else
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                Pic53None()
                Pic54None()
            End If
        End If
    End Sub

    Public Sub CheG5SouthMovementArea()
        i = 1
        If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox61Color()
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
                PictureboxAbleToBlock(i) = 61
                CheckPicturebox70Color()
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    Pic61None()
                    Pic70None()
                    PictureboxAbleToBlock(i) = 61
                    i = i + 1
                    PictureboxAbleToBlock(i) = 70
                    CheckPicturebox79Color()
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                        Pic61None()
                        Pic70None()
                        Pic79None()
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 70
                        i = i + 1
                        PictureboxAbleToBlock(i) = 79
                        CheckPicturebox88Color()
                    Else
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                        Pic61None()
                        Pic70None()
                        Pic79None()
                        Pic88None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG5WestMovementArea()
        i = 1
        If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox51Color()
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                Pic51None()
                PictureboxAbleToBlock(i) = 51
                CheckPicturebox50Color()
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    Pic51None()
                    Pic50None()
                    PictureboxAbleToBlock(i) = 51
                    i = i + 1
                    PictureboxAbleToBlock(i) = 50
                    CheckPicturebox49Color()
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Pic51None()
                        Pic50None()
                        Pic49None()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        CheckPicturebox48Color()
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Pic51None()
                            Pic50None()
                            Pic49None()
                            Pic48None()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            CheckPicturebox47Color()
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Pic51None()
                                Pic50None()
                                Pic49None()
                                Pic48None()
                                Pic47None()
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 47
                                CheckPicturebox46Color()
                            Else
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                Pic51None()
                                Pic50None()
                                Pic49None()
                                Pic48None()
                                Pic47None()
                                Pic46None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG5NorthMovementArea()
        i = 1
        If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox43Color()
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
                PictureboxAbleToBlock(i) = 43
                CheckPicturebox34Color()
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    Pic43None()
                    Pic34None()
                    PictureboxAbleToBlock(i) = 43
                    i = i + 1
                    PictureboxAbleToBlock(i) = 34
                    CheckPicturebox25Color()
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                        Pic43None()
                        Pic34None()
                        Pic25None()
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 34
                        i = i + 1
                        PictureboxAbleToBlock(i) = 25
                        CheckPicturebox16Color()
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                            Pic43None()
                            Pic34None()
                            Pic25None()
                            Pic16None()
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            i = i + 1
                            PictureboxAbleToBlock(i) = 25
                            i = i + 1
                            PictureboxAbleToBlock(i) = 16
                            CheckPicturebox7Color()
                        Else
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                            Pic43None()
                            Pic34None()
                            Pic25None()
                            Pic16None()
                            Pic7None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH5EastMovementArea()
        If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox54Color()
        Else
            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
            Pic54None()
        End If
    End Sub

    Public Sub CheH5SouthMovementArea()
        i = 1
        If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox62Color()
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
                PictureboxAbleToBlock(i) = 62
                CheckPicturebox71Color()
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    Pic62None()
                    Pic71None()
                    PictureboxAbleToBlock(i) = 62
                    i = i + 1
                    PictureboxAbleToBlock(i) = 71
                    CheckPicturebox80Color()
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                        Pic62None()
                        Pic71None()
                        Pic80None()
                        PictureboxAbleToBlock(i) = 62
                        i = i + 1
                        PictureboxAbleToBlock(i) = 71
                        i = i + 1
                        PictureboxAbleToBlock(i) = 80
                        CheckPicturebox89Color()
                    Else
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                        Pic62None()
                        Pic71None()
                        Pic80None()
                        Pic89None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH5WestMovementArea()
        i = 1
        If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox52Color()
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
                PictureboxAbleToBlock(i) = 52
                CheckPicturebox51Color()
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    Pic52None()
                    Pic51None()
                    PictureboxAbleToBlock(i) = 52
                    i = i + 1
                    PictureboxAbleToBlock(i) = 51
                    CheckPicturebox50Color()
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Pic52None()
                        Pic51None()
                        Pic50None()
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        CheckPicturebox49Color()
                        Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Pic52None()
                            Pic51None()
                            Pic50None()
                            Pic49None()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            CheckPicturebox48Color()
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Pic52None()
                                Pic51None()
                                Pic50None()
                                Pic49None()
                                Pic48None()
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                CheckPicturebox47Color()
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                    Pic52None()
                                    Pic51None()
                                    Pic50None()
                                    Pic49None()
                                    Pic48None()
                                    Pic47None()
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 47
                                    CheckPicturebox46Color()
                                Else
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                    Pic52None()
                                    Pic51None()
                                    Pic50None()
                                    Pic49None()
                                    Pic48None()
                                    Pic47None()
                                    Pic46None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH5NorthMovementArea()
        i = 1
        If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox44Color()
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
                PictureboxAbleToBlock(i) = 44
                CheckPicturebox35Color()
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    Pic44None()
                    Pic35None()
                    PictureboxAbleToBlock(i) = 44
                    i = i + 1
                    PictureboxAbleToBlock(i) = 35
                    CheckPicturebox26Color()
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                        Pic44None()
                        Pic35None()
                        Pic26None()
                        PictureboxAbleToBlock(i) = 44
                        i = i + 1
                        PictureboxAbleToBlock(i) = 35
                        i = i + 1
                        PictureboxAbleToBlock(i) = 26
                        CheckPicturebox17Color()
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                            Pic44None()
                            Pic35None()
                            Pic26None()
                            Pic17None()
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            i = i + 1
                            PictureboxAbleToBlock(i) = 26
                            i = i + 1
                            PictureboxAbleToBlock(i) = 17
                            CheckPicturebox8Color()
                        Else
                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                            Pic44None()
                            Pic35None()
                            Pic26None()
                            Pic17None()
                            Pic8None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI5SouthMovementArea()
        i = 1
        If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox63Color()
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                Pic63None()
                PictureboxAbleToBlock(i) = 63
                CheckPicturebox72Color()
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                    Pic63None()
                    Pic72None()
                    PictureboxAbleToBlock(i) = 63
                    i = i + 1
                    PictureboxAbleToBlock(i) = 72
                    CheckPicturebox81Color()
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                        Pic63None()
                        Pic72None()
                        Pic81None()
                        PictureboxAbleToBlock(i) = 63
                        i = i + 1
                        PictureboxAbleToBlock(i) = 72
                        i = i + 1
                        PictureboxAbleToBlock(i) = 81
                        CheckPicturebox90Color()
                    Else
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                        Pic63None()
                        Pic72None()
                        Pic81None()
                        Pic90None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI5WestMovementArea()
        i = 1
        If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox53Color()
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
                PictureboxAbleToBlock(i) = 53
                CheckPicturebox52Color()
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    Pic53None()
                    Pic52None()
                    PictureboxAbleToBlock(i) = 53
                    i = i + 1
                    PictureboxAbleToBlock(i) = 52
                    CheckPicturebox51Color()
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Pic53None()
                        Pic52None()
                        Pic51None()
                        PictureboxAbleToBlock(i) = 53
                        i = i + 1
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        CheckPicturebox50Color()
                        Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Pic53None()
                            Pic52None()
                            Pic51None()
                            Pic50None()
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            CheckPicturebox49Color()
                            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Pic53None()
                                Pic52None()
                                Pic51None()
                                Pic50None()
                                Pic49None()
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                CheckPicturebox48Color()
                                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Pic53None()
                                    Pic52None()
                                    Pic51None()
                                    Pic50None()
                                    Pic49None()
                                    Pic48None()
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    CheckPicturebox47Color()
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                        Pic53None()
                                        Pic52None()
                                        Pic51None()
                                        Pic50None()
                                        Pic49None()
                                        Pic48None()
                                        Pic47None()
                                        PictureboxAbleToBlock(i) = 53
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 52
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 51
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 50
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 49
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 48
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 47
                                        CheckPicturebox46Color()
                                    Else
                                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                        Pic53None()
                                        Pic52None()
                                        Pic51None()
                                        Pic50None()
                                        Pic49None()
                                        Pic48None()
                                        Pic47None()
                                        Pic46None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI5NorthMovementArea()
        i = 1
        If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox45Color()
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                Pic45None()
                PictureboxAbleToBlock(i) = 45
                CheckPicturebox36Color()
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    Pic45None()
                    Pic36None()
                    PictureboxAbleToBlock(i) = 45
                    i = i + 1
                    PictureboxAbleToBlock(i) = 36
                    CheckPicturebox27Color()
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                        Pic45None()
                        Pic36None()
                        Pic27None()
                        PictureboxAbleToBlock(i) = 45
                        i = i + 1
                        PictureboxAbleToBlock(i) = 36
                        i = i + 1
                        PictureboxAbleToBlock(i) = 27
                        CheckPicturebox18Color()
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                            Pic45None()
                            Pic36None()
                            Pic27None()
                            Pic18None()
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 36
                            i = i + 1
                            PictureboxAbleToBlock(i) = 27
                            i = i + 1
                            PictureboxAbleToBlock(i) = 18
                            CheckPicturebox9Color()
                        Else
                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                            Pic45None()
                            Pic36None()
                            Pic27None()
                            Pic18None()
                            Pic9None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

End Module
