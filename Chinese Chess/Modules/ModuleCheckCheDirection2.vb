' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 28/01/2011
' Descripitons : Chinese Chess V1

Module ModuleCheckCheDirection2
    Dim i As Integer

    Public Sub CheA6EastMovementArea()
        i = 1
        If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox38Color()
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                Pic38None()
                PictureboxAbleToBlock(i) = 38
                CheckPicturebox39Color()
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                    Pic38None()
                    Pic39None()
                    PictureboxAbleToBlock(i) = 38
                    i = i + 1
                    PictureboxAbleToBlock(i) = 39
                    CheckPicturebox40Color()
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Pic38None()
                        Pic39None()
                        Pic40None()
                        PictureboxAbleToBlock(i) = 38
                        i = i + 1
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        CheckPicturebox41Color()
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Pic38None()
                            Pic39None()
                            Pic40None()
                            Pic41None()
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            CheckPicturebox42Color()
                            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Pic38None()
                                Pic39None()
                                Pic40None()
                                Pic41None()
                                Pic42None()
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                CheckPicturebox43Color()
                                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Pic38None()
                                    Pic39None()
                                    Pic40None()
                                    Pic41None()
                                    Pic42None()
                                    Pic43None()
                                    PictureboxAbleToBlock(i) = 38
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    CheckPicturebox44Color()
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                        Pic38None()
                                        Pic39None()
                                        Pic40None()
                                        Pic41None()
                                        Pic42None()
                                        Pic43None()
                                        Pic44None()
                                        PictureboxAbleToBlock(i) = 38
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 39
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 40
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 41
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 42
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 43
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 44
                                        CheckPicturebox45Color()
                                    Else
                                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                        Pic38None()
                                        Pic39None()
                                        Pic40None()
                                        Pic41None()
                                        Pic42None()
                                        Pic43None()
                                        Pic44None()
                                        Pic45None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA6SouthMovementArea()
        i = 1
        If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox46Color()
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                Pic46None()
                PictureboxAbleToBlock(i) = 46
                CheckPicturebox55Color()
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                    Pic46None()
                    Pic55None()
                    PictureboxAbleToBlock(i) = 46
                    i = i + 1
                    PictureboxAbleToBlock(i) = 55
                    CheckPicturebox64Color()
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                        Pic46None()
                        Pic55None()
                        Pic64None()
                        PictureboxAbleToBlock(i) = 46
                        i = i + 1
                        PictureboxAbleToBlock(i) = 55
                        i = i + 1
                        PictureboxAbleToBlock(i) = 64
                        CheckPicturebox73Color()
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                            Pic46None()
                            Pic55None()
                            Pic64None()
                            Pic73None()
                            PictureboxAbleToBlock(i) = 46
                            i = i + 1
                            PictureboxAbleToBlock(i) = 55
                            i = i + 1
                            PictureboxAbleToBlock(i) = 64
                            i = i + 1
                            PictureboxAbleToBlock(i) = 73
                            CheckPicturebox82Color()
                        Else
                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                            Pic46None()
                            Pic55None()
                            Pic64None()
                            Pic73None()
                            Pic82None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA6NorthMovementArea()
        i = 1
        If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox28Color()
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                Pic28None()
                PictureboxAbleToBlock(i) = 28
                CheckPicturebox19Color()
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                    Pic28None()
                    Pic19None()
                    PictureboxAbleToBlock(i) = 28
                    i = i + 1
                    PictureboxAbleToBlock(i) = 19
                    CheckPicturebox10Color()
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                        Pic28None()
                        Pic19None()
                        Pic10None()
                        PictureboxAbleToBlock(i) = 28
                        i = i + 1
                        PictureboxAbleToBlock(i) = 19
                        i = i + 1
                        PictureboxAbleToBlock(i) = 10
                        CheckPicturebox1Color()
                    Else
                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                        Pic28None()
                        Pic19None()
                        Pic10None()
                        Pic1None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB6EastMovementArea()
        i = 1
        If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox39Color()
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                Pic39None()
                PictureboxAbleToBlock(i) = 39
                CheckPicturebox40Color()
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    Pic39None()
                    Pic40None()
                    PictureboxAbleToBlock(i) = 39
                    i = i + 1
                    PictureboxAbleToBlock(i) = 40
                    CheckPicturebox41Color()
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Pic39None()
                        Pic40None()
                        Pic41None()
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        CheckPicturebox42Color()
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Pic39None()
                            Pic40None()
                            Pic41None()
                            Pic42None()
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            CheckPicturebox43Color()
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Pic39None()
                                Pic40None()
                                Pic41None()
                                Pic42None()
                                Pic43None()
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                CheckPicturebox44Color()
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                    Pic39None()
                                    Pic40None()
                                    Pic41None()
                                    Pic42None()
                                    Pic43None()
                                    Pic44None()
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                    CheckPicturebox45Color()
                                Else
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                    Pic39None()
                                    Pic40None()
                                    Pic41None()
                                    Pic42None()
                                    Pic43None()
                                    Pic44None()
                                    Pic45None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB6SouthMovementArea()
        i = 1
        If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox47Color()
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                Pic47None()
                PictureboxAbleToBlock(i) = 47
                CheckPicturebox56Color()
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                    Pic47None()
                    Pic56None()
                    PictureboxAbleToBlock(i) = 47
                    i = i + 1
                    PictureboxAbleToBlock(i) = 56
                    CheckPicturebox65Color()
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                        Pic47None()
                        Pic56None()
                        Pic65None()
                        PictureboxAbleToBlock(i) = 47
                        i = i + 1
                        PictureboxAbleToBlock(i) = 56
                        i = i + 1
                        PictureboxAbleToBlock(i) = 65
                        CheckPicturebox74Color()
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                            Pic47None()
                            Pic56None()
                            Pic65None()
                            Pic74None()
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 56
                            i = i + 1
                            PictureboxAbleToBlock(i) = 65
                            i = i + 1
                            PictureboxAbleToBlock(i) = 74
                            CheckPicturebox83Color()
                        Else
                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                            Pic47None()
                            Pic56None()
                            Pic65None()
                            Pic74None()
                            Pic83None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB6WestMovementArea()
        If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox37Color()
        Else
            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
            Pic37None()
        End If
    End Sub

    Public Sub CheB6NorthMovementArea()
        i = 1
        If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox29Color()
            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                Pic29None()
                PictureboxAbleToBlock(i) = 29
                CheckPicturebox20Color()
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                    Pic29None()
                    Pic20None()
                    PictureboxAbleToBlock(i) = 29
                    i = i + 1
                    PictureboxAbleToBlock(i) = 20
                    CheckPicturebox11Color()
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                        Pic29None()
                        Pic20None()
                        Pic11None()
                        PictureboxAbleToBlock(i) = 29
                        i = i + 1
                        PictureboxAbleToBlock(i) = 20
                        i = i + 1
                        PictureboxAbleToBlock(i) = 11
                        CheckPicturebox2Color()
                    Else
                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                        Pic29None()
                        Pic20None()
                        Pic11None()
                        Pic2None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC6EastMovementArea()
        i = 1
        If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox40Color()
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                Pic40None()
                PictureboxAbleToBlock(i) = 40
                CheckPicturebox41Color()
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    Pic40None()
                    Pic41None()
                    PictureboxAbleToBlock(i) = 40
                    i = i + 1
                    PictureboxAbleToBlock(i) = 41
                    CheckPicturebox42Color()
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Pic40None()
                        Pic41None()
                        Pic42None()
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        CheckPicturebox43Color()
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Pic40None()
                            Pic41None()
                            Pic42None()
                            Pic43None()
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            CheckPicturebox44Color()
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Pic40None()
                                Pic41None()
                                Pic42None()
                                Pic43None()
                                Pic44None()
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                CheckPicturebox45Color()
                            Else
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                Pic40None()
                                Pic41None()
                                Pic42None()
                                Pic43None()
                                Pic44None()
                                Pic45None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC6SouthMovementArea()
        i = 1
        If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox48Color()
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                Pic48None()
                PictureboxAbleToBlock(i) = 48
                CheckPicturebox57Color()
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                    Pic48None()
                    Pic57None()
                    PictureboxAbleToBlock(i) = 48
                    i = i + 1
                    PictureboxAbleToBlock(i) = 57
                    CheckPicturebox66Color()
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                        Pic48None()
                        Pic57None()
                        Pic66None()
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 66
                        CheckPicturebox75Color()
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                            Pic48None()
                            Pic57None()
                            Pic66None()
                            Pic75None()
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                            i = i + 1
                            PictureboxAbleToBlock(i) = 75
                            CheckPicturebox84Color()
                        Else
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                            Pic48None()
                            Pic57None()
                            Pic66None()
                            Pic75None()
                            Pic84None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC6WestMovementArea()
        i = 1
        If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox38Color()
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                Pic38None()
                PictureboxAbleToBlock(i) = 38
                CheckPicturebox37Color()
            Else
                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                Pic38None()
                Pic37None()
            End If
        End If
    End Sub

    Public Sub CheC6NorthMovementArea()
        i = 1
        If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox30Color()
            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                Pic30None()
                PictureboxAbleToBlock(i) = 30
                CheckPicturebox21Color()
                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                    Pic30None()
                    Pic21None()
                    PictureboxAbleToBlock(i) = 30
                    i = i + 1
                    PictureboxAbleToBlock(i) = 21
                    CheckPicturebox12Color()
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                        Pic30None()
                        Pic21None()
                        Pic12None()
                        PictureboxAbleToBlock(i) = 30
                        i = i + 1
                        PictureboxAbleToBlock(i) = 21
                        i = i + 1
                        PictureboxAbleToBlock(i) = 12
                        CheckPicturebox3Color()
                    Else
                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                        Pic30None()
                        Pic21None()
                        Pic12None()
                        Pic3None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD6EastMovementArea()
        i = 1
        If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox41Color()
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
                PictureboxAbleToBlock(i) = 41
                CheckPicturebox42Color()
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    Pic41None()
                    Pic42None()
                    PictureboxAbleToBlock(i) = 41
                    i = i + 1
                    PictureboxAbleToBlock(i) = 42
                    CheckPicturebox43Color()
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                        Pic41None()
                        Pic42None()
                        Pic43None()
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                        CheckPicturebox44Color()
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                            Pic41None()
                            Pic42None()
                            Pic43None()
                            Pic44None()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                            CheckPicturebox45Color()
                        Else
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                            Pic41None()
                            Pic42None()
                            Pic43None()
                            Pic44None()
                            Pic45None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD6SouthMovementArea()
        i = 1
        If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox49Color()
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                Pic49None()
                PictureboxAbleToBlock(i) = 49
                CheckPicturebox58Color()
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    Pic49None()
                    Pic58None()
                    PictureboxAbleToBlock(i) = 49
                    i = i + 1
                    PictureboxAbleToBlock(i) = 58
                    CheckPicturebox67Color()
                    Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                        Pic49None()
                        Pic58None()
                        Pic67None()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 67
                        CheckPicturebox76Color()
                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                            Pic49None()
                            Pic58None()
                            Pic67None()
                            Pic76None()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 76
                            CheckPicturebox85Color()
                        Else
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                            Pic49None()
                            Pic58None()
                            Pic67None()
                            Pic76None()
                            Pic85None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD6WestMovementArea()
        i = 1
        If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox39Color()
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                Pic39None()
                PictureboxAbleToBlock(i) = 39
                CheckPicturebox38Color()
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                    Pic39None()
                    Pic38None()
                    PictureboxAbleToBlock(i) = 39
                    i = i + 1
                    PictureboxAbleToBlock(i) = 38
                    CheckPicturebox37Color()
                Else
                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                    Pic39None()
                    Pic38None()
                    Pic37None()
                End If
            End If
        End If
    End Sub

    Public Sub CheD6NorthMovementArea()
        i = 1
        If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox31Color()
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                Pic31None()
                PictureboxAbleToBlock(i) = 31
                CheckPicturebox22Color()
                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    Pic31None()
                    Pic22None()
                    PictureboxAbleToBlock(i) = 31
                    i = i + 1
                    PictureboxAbleToBlock(i) = 22
                    CheckPicturebox13Color()
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                        Pic31None()
                        Pic22None()
                        Pic13None()
                        PictureboxAbleToBlock(i) = 31
                        i = i + 1
                        PictureboxAbleToBlock(i) = 22
                        i = i + 1
                        PictureboxAbleToBlock(i) = 13
                        CheckPicturebox4Color()
                    Else
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                        Pic31None()
                        Pic22None()
                        Pic13None()
                        Pic4None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE6EastMovementArea()
        i = 1
        If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox42Color()
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                Pic42None()
                PictureboxAbleToBlock(i) = 42
                CheckPicturebox43Color()
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    Pic42None()
                    Pic43None()
                    PictureboxAbleToBlock(i) = 42
                    i = i + 1
                    PictureboxAbleToBlock(i) = 43
                    CheckPicturebox44Color()
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                        Pic42None()
                        Pic43None()
                        Pic44None()
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 44
                        CheckPicturebox45Color()
                    Else
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                        Pic42None()
                        Pic43None()
                        Pic44None()
                        Pic45None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE6SouthMovementArea()
        i = 1
        If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox50Color()
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
                PictureboxAbleToBlock(i) = 50
                CheckPicturebox59Color()
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox68 IsNot Form1.nonePic.Image Then
                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    Pic50None()
                    Pic59None()
                    PictureboxAbleToBlock(i) = 50
                    i = i + 1
                    PictureboxAbleToBlock(i) = 59
                    CheckPicturebox68Color()
                    Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox77 IsNot Form1.nonePic.Image Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                        Pic50None()
                        Pic59None()
                        Pic68None()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 68
                        CheckPicturebox77Color()
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                            Pic50None()
                            Pic59None()
                            Pic68None()
                            Pic77None()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 77
                            CheckPicturebox86Color()
                        Else
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                            Pic50None()
                            Pic59None()
                            Pic68None()
                            Pic77None()
                            Pic86None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE6WestMovementArea()
        i = 1
        If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox40Color()
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                Pic40None()
                PictureboxAbleToBlock(i) = 40
                CheckPicturebox39Color()
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                    Pic40None()
                    Pic39None()
                    PictureboxAbleToBlock(i) = 40
                    i = i + 1
                    PictureboxAbleToBlock(i) = 39
                    CheckPicturebox38Color()
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                        Pic40None()
                        Pic39None()
                        Pic38None()
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 38
                        CheckPicturebox37Color()
                    Else
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                        Pic40None()
                        Pic39None()
                        Pic38None()
                        Pic37None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE6NorthMovementArea()
        i = 1
        If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox32Color()
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                Pic32None()
                PictureboxAbleToBlock(i) = 32
                CheckPicturebox23Color()
                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    Pic32None()
                    Pic23None()
                    PictureboxAbleToBlock(i) = 32
                    i = i + 1
                    PictureboxAbleToBlock(i) = 23
                    CheckPicturebox14Color()
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                        Pic32None()
                        Pic23None()
                        Pic14None()
                        PictureboxAbleToBlock(i) = 32
                        i = i + 1
                        PictureboxAbleToBlock(i) = 23
                        i = i + 1
                        PictureboxAbleToBlock(i) = 14
                        CheckPicturebox5Color()
                    Else
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                        Pic32None()
                        Pic23None()
                        Pic14None()
                        Pic5None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF6EastMovementArea()
        i = 1
        If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox43Color()
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
                PictureboxAbleToBlock(i) = 43
                CheckPicturebox44Color()
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    Pic43None()
                    Pic44None()
                    PictureboxAbleToBlock(i) = 43
                    i = i + 1
                    PictureboxAbleToBlock(i) = 44
                    CheckPicturebox45Color()
                Else
                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    Pic43None()
                    Pic44None()
                    Pic45None()
                End If
            End If
        End If
    End Sub

    Public Sub CheF6SouthMovementArea()
        i = 1
        If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox51Color()
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                Pic51None()
                PictureboxAbleToBlock(i) = 51
                CheckPicturebox60Color()
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    Pic51None()
                    Pic60None()
                    PictureboxAbleToBlock(i) = 51
                    i = i + 1
                    PictureboxAbleToBlock(i) = 60
                    CheckPicturebox69Color()
                    Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                        Pic51None()
                        Pic60None()
                        Pic69None()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 69
                        CheckPicturebox78Color()
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                            Pic51None()
                            Pic60None()
                            Pic69None()
                            Pic78None()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 78
                            CheckPicturebox87Color()
                        Else
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                            Pic51None()
                            Pic60None()
                            Pic69None()
                            Pic78None()
                            Pic87None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF6WestMovementArea()
        i = 1
        If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox41Color()
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
                PictureboxAbleToBlock(i) = 41
                CheckPicturebox40Color()
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    Pic41None()
                    Pic40None()
                    PictureboxAbleToBlock(i) = 41
                    i = i + 1
                    PictureboxAbleToBlock(i) = 40
                    CheckPicturebox39Color()
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                        Pic41None()
                        Pic40None()
                        Pic39None()
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 39
                        CheckPicturebox38Color()
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                            Pic41None()
                            Pic40None()
                            Pic39None()
                            Pic38None()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 38
                            CheckPicturebox37Color()
                        Else
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                            Pic41None()
                            Pic40None()
                            Pic39None()
                            Pic38None()
                            Pic37None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF6NorthMovementArea()
        i = 1
        If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox33Color()
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                Pic33None()
                PictureboxAbleToBlock(i) = 33
                CheckPicturebox24Color()
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    Pic33None()
                    Pic24None()
                    PictureboxAbleToBlock(i) = 33
                    i = i + 1
                    PictureboxAbleToBlock(i) = 24
                    CheckPicturebox15Color()
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                        Pic33None()
                        Pic24None()
                        Pic15None()
                        PictureboxAbleToBlock(i) = 33
                        i = i + 1
                        PictureboxAbleToBlock(i) = 24
                        i = i + 1
                        PictureboxAbleToBlock(i) = 15
                        CheckPicturebox6Color()
                    Else
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                        Pic33None()
                        Pic24None()
                        Pic15None()
                        Pic6None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG6EastMovementArea()
        i = 1
        If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox44Color()
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
                PictureboxAbleToBlock(i) = 44
                CheckPicturebox45Color()
            Else
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                Pic44None()
                Pic45None()
            End If
        End If
    End Sub

    Public Sub CheG6SouthMovementArea()
        i = 1
        If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox52Color()
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
                PictureboxAbleToBlock(i) = 52
                CheckPicturebox61Color()
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    Pic52None()
                    Pic61None()
                    PictureboxAbleToBlock(i) = 52
                    i = i + 1
                    PictureboxAbleToBlock(i) = 61
                    CheckPicturebox70Color()
                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                        Pic52None()
                        Pic61None()
                        Pic70None()
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 70
                        CheckPicturebox79Color()
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                            Pic52None()
                            Pic61None()
                            Pic70None()
                            Pic79None()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 79
                            CheckPicturebox88Color()
                        Else
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                            Pic52None()
                            Pic61None()
                            Pic70None()
                            Pic79None()
                            Pic88None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG6WestMovementArea()
        i = 1
        If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox42Color()
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                Pic42None()
                PictureboxAbleToBlock(i) = 42
                CheckPicturebox41Color()
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    Pic42None()
                    Pic41None()
                    PictureboxAbleToBlock(i) = 42
                    i = i + 1
                    PictureboxAbleToBlock(i) = 41
                    CheckPicturebox40Color()
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Pic42None()
                        Pic41None()
                        Pic40None()
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        CheckPicturebox39Color()
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Pic42None()
                            Pic41None()
                            Pic40None()
                            Pic39None()
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            CheckPicturebox38Color()
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Pic42None()
                                Pic41None()
                                Pic40None()
                                Pic39None()
                                Pic38None()
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                                CheckPicturebox37Color()
                            Else
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                Pic42None()
                                Pic41None()
                                Pic40None()
                                Pic39None()
                                Pic38None()
                                Pic37None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG6NorthMovementArea()
        i = 1
        If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox34Color()
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
                PictureboxAbleToBlock(i) = 34
                CheckPicturebox25Color()
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    Pic34None()
                    Pic25None()
                    PictureboxAbleToBlock(i) = 34
                    i = i + 1
                    PictureboxAbleToBlock(i) = 25
                    CheckPicturebox16Color()
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                        Pic34None()
                        Pic25None()
                        Pic16None()
                        PictureboxAbleToBlock(i) = 34
                        i = i + 1
                        PictureboxAbleToBlock(i) = 25
                        i = i + 1
                        PictureboxAbleToBlock(i) = 16
                        CheckPicturebox7Color()
                    Else
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                        Pic34None()
                        Pic25None()
                        Pic16None()
                        Pic7None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH6EastMovementArea()
        If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox45Color()
        Else
            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
            Pic45None()
        End If
    End Sub

    Public Sub CheH6SouthMovementArea()
        i = 1
        If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox53Color()
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
                PictureboxAbleToBlock(i) = 53
                CheckPicturebox62Color()
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    Pic53None()
                    Pic62None()
                    PictureboxAbleToBlock(i) = 53
                    i = i + 1
                    PictureboxAbleToBlock(i) = 62
                    CheckPicturebox71Color()
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                        Pic53None()
                        Pic62None()
                        Pic71None()
                        PictureboxAbleToBlock(i) = 53
                        i = i + 1
                        PictureboxAbleToBlock(i) = 62
                        i = i + 1
                        PictureboxAbleToBlock(i) = 71
                        CheckPicturebox80Color()
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                            Pic53None()
                            Pic62None()
                            Pic71None()
                            Pic80None()
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 71
                            i = i + 1
                            PictureboxAbleToBlock(i) = 80
                            CheckPicturebox89Color()
                        Else
                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                            Pic53None()
                            Pic62None()
                            Pic71None()
                            Pic80None()
                            Pic89None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH6WestMovementArea()
        i = 1
        If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox43Color()
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
                PictureboxAbleToBlock(i) = 43
                CheckPicturebox42Color()
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    Pic43None()
                    Pic42None()
                    PictureboxAbleToBlock(i) = 43
                    i = i + 1
                    PictureboxAbleToBlock(i) = 42
                    CheckPicturebox41Color()
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Pic43None()
                        Pic42None()
                        Pic41None()
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        CheckPicturebox40Color()
                        Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Pic43None()
                            Pic42None()
                            Pic41None()
                            Pic40None()
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            CheckPicturebox39Color()
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Pic43None()
                                Pic42None()
                                Pic41None()
                                Pic40None()
                                Pic39None()
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                CheckPicturebox38Color()
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                    Pic43None()
                                    Pic42None()
                                    Pic41None()
                                    Pic40None()
                                    Pic39None()
                                    Pic38None()
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 38
                                    CheckPicturebox37Color()
                                Else
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                    Pic43None()
                                    Pic42None()
                                    Pic41None()
                                    Pic40None()
                                    Pic39None()
                                    Pic38None()
                                    Pic37None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH6NorthMovementArea()
        i = 1
        If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox35Color()
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
                PictureboxAbleToBlock(i) = 35
                CheckPicturebox26Color()
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    Pic35None()
                    Pic26None()
                    PictureboxAbleToBlock(i) = 35
                    i = i + 1
                    PictureboxAbleToBlock(i) = 26
                    CheckPicturebox17Color()
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                        Pic35None()
                        Pic26None()
                        Pic17None()
                        PictureboxAbleToBlock(i) = 35
                        i = i + 1
                        PictureboxAbleToBlock(i) = 26
                        i = i + 1
                        PictureboxAbleToBlock(i) = 17
                        CheckPicturebox8Color()
                    Else
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                        Pic35None()
                        Pic26None()
                        Pic17None()
                        Pic8None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI6SouthMovementArea()
        i = 1
        If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox54Color()
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                Pic54None()
                PictureboxAbleToBlock(i) = 54
                CheckPicturebox63Color()
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    Pic54None()
                    Pic63None()
                    PictureboxAbleToBlock(i) = 54
                    i = i + 1
                    PictureboxAbleToBlock(i) = 63
                    CheckPicturebox72Color()
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                        Pic54None()
                        Pic63None()
                        Pic72None()
                        PictureboxAbleToBlock(i) = 54
                        i = i + 1
                        PictureboxAbleToBlock(i) = 63
                        i = i + 1
                        PictureboxAbleToBlock(i) = 72
                        CheckPicturebox81Color()
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                            Pic54None()
                            Pic63None()
                            Pic72None()
                            Pic81None()
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 63
                            i = i + 1
                            PictureboxAbleToBlock(i) = 72
                            i = i + 1
                            PictureboxAbleToBlock(i) = 81
                            CheckPicturebox90Color()
                        Else
                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                            Pic54None()
                            Pic63None()
                            Pic72None()
                            Pic81None()
                            Pic90None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI6WestMovementArea()
        i = 1
        If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox44Color()
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
                PictureboxAbleToBlock(i) = 44
                CheckPicturebox43Color()
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    Pic44None()
                    Pic43None()
                    PictureboxAbleToBlock(i) = 44
                    i = i + 1
                    PictureboxAbleToBlock(i) = 43
                    CheckPicturebox42Color()
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Pic44None()
                        Pic43None()
                        Pic42None()
                        PictureboxAbleToBlock(i) = 44
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        CheckPicturebox41Color()
                        Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Pic44None()
                            Pic43None()
                            Pic42None()
                            Pic41None()
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            CheckPicturebox40Color()
                            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Pic44None()
                                Pic43None()
                                Pic42None()
                                Pic41None()
                                Pic40None()
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                CheckPicturebox39Color()
                                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Pic44None()
                                    Pic43None()
                                    Pic42None()
                                    Pic41None()
                                    Pic40None()
                                    Pic39None()
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    CheckPicturebox38Color()
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                        Pic44None()
                                        Pic43None()
                                        Pic42None()
                                        Pic41None()
                                        Pic40None()
                                        Pic39None()
                                        Pic38None()
                                        PictureboxAbleToBlock(i) = 44
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 43
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 42
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 41
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 40
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 39
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 38
                                        CheckPicturebox37Color()
                                    Else
                                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                        Pic44None()
                                        Pic43None()
                                        Pic42None()
                                        Pic41None()
                                        Pic40None()
                                        Pic39None()
                                        Pic38None()
                                        Pic37None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI6NorthMovementArea()
        i = 1
        If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox36Color()
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                Pic36None()
                PictureboxAbleToBlock(i) = 36
                CheckPicturebox27Color()
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                    Pic36None()
                    Pic27None()
                    PictureboxAbleToBlock(i) = 36
                    i = i + 1
                    PictureboxAbleToBlock(i) = 27
                    CheckPicturebox18Color()
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                        Pic36None()
                        Pic27None()
                        Pic18None()
                        PictureboxAbleToBlock(i) = 36
                        i = i + 1
                        PictureboxAbleToBlock(i) = 27
                        i = i + 1
                        PictureboxAbleToBlock(i) = 18
                        CheckPicturebox9Color()
                    Else
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                        Pic36None()
                        Pic27None()
                        Pic18None()
                        Pic9None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA7EastMovementArea()
        i = 1
        If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox29Color()
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                Pic29None()
                PictureboxAbleToBlock(i) = 29
                CheckPicturebox30Color()
                Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                    Pic29None()
                    Pic30None()
                    PictureboxAbleToBlock(i) = 29
                    i = i + 1
                    PictureboxAbleToBlock(i) = 30
                    CheckPicturebox31Color()
                    Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Pic29None()
                        Pic30None()
                        Pic31None()
                        PictureboxAbleToBlock(i) = 29
                        i = i + 1
                        PictureboxAbleToBlock(i) = 30
                        i = i + 1
                        PictureboxAbleToBlock(i) = 31
                        CheckPicturebox32Color()
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Pic29None()
                            Pic30None()
                            Pic31None()
                            Pic32None()
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            CheckPicturebox33Color()
                            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Pic29None()
                                Pic30None()
                                Pic31None()
                                Pic32None()
                                Pic33None()
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                CheckPicturebox34Color()
                                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Pic29None()
                                    Pic30None()
                                    Pic31None()
                                    Pic32None()
                                    Pic33None()
                                    Pic34None()
                                    PictureboxAbleToBlock(i) = 29
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 30
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    CheckPicturebox35Color()
                                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                        Pic29None()
                                        Pic30None()
                                        Pic31None()
                                        Pic32None()
                                        Pic33None()
                                        Pic34None()
                                        Pic35None()
                                        PictureboxAbleToBlock(i) = 29
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 30
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 31
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 32
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 33
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 34
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 35
                                        CheckPicturebox36Color()
                                    Else
                                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                        Pic29None()
                                        Pic30None()
                                        Pic31None()
                                        Pic32None()
                                        Pic33None()
                                        Pic34None()
                                        Pic35None()
                                        Pic36None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA7SouthMovementArea()
        i = 1
        If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox37Color()
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                Pic37None()
                PictureboxAbleToBlock(i) = 37
                CheckPicturebox46Color()
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                    Pic37None()
                    Pic46None()
                    PictureboxAbleToBlock(i) = 37
                    i = i + 1
                    PictureboxAbleToBlock(i) = 46
                    CheckPicturebox55Color()
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                        Pic37None()
                        Pic46None()
                        Pic55None()
                        PictureboxAbleToBlock(i) = 37
                        i = i + 1
                        PictureboxAbleToBlock(i) = 46
                        i = i + 1
                        PictureboxAbleToBlock(i) = 55
                        CheckPicturebox64Color()
                        Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                            Pic37None()
                            Pic46None()
                            Pic55None()
                            Pic64None()
                            PictureboxAbleToBlock(i) = 37
                            i = i + 1
                            PictureboxAbleToBlock(i) = 46
                            i = i + 1
                            PictureboxAbleToBlock(i) = 55
                            i = i + 1
                            PictureboxAbleToBlock(i) = 64
                            CheckPicturebox73Color()
                            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                Pic37None()
                                Pic46None()
                                Pic55None()
                                Pic64None()
                                Pic73None()
                                PictureboxAbleToBlock(i) = 37
                                i = i + 1
                                PictureboxAbleToBlock(i) = 46
                                i = i + 1
                                PictureboxAbleToBlock(i) = 55
                                i = i + 1
                                PictureboxAbleToBlock(i) = 64
                                i = i + 1
                                PictureboxAbleToBlock(i) = 73
                                CheckPicturebox82Color()
                            Else
                                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                                Pic37None()
                                Pic46None()
                                Pic55None()
                                Pic64None()
                                Pic73None()
                                Pic82None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA7NorthMovementArea()
        i = 1
        If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox19Color()
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                Pic19None()
                PictureboxAbleToBlock(i) = 19
                CheckPicturebox10Color()
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                    Pic19None()
                    Pic10None()
                    PictureboxAbleToBlock(i) = 19
                    i = i + 1
                    PictureboxAbleToBlock(i) = 10
                    CheckPicturebox1Color()
                Else
                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                    Pic19None()
                    Pic10None()
                    Pic1None()
                End If
            End If
        End If
    End Sub

    Public Sub CheB7EastMovementArea()
        i = 1
        If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox30Color()
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                Pic30None()
                PictureboxAbleToBlock(i) = 30
                CheckPicturebox31Color()
                Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    Pic30None()
                    Pic31None()
                    PictureboxAbleToBlock(i) = 30
                    i = i + 1
                    PictureboxAbleToBlock(i) = 31
                    CheckPicturebox32Color()
                    Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Pic30None()
                        Pic31None()
                        Pic32None()
                        PictureboxAbleToBlock(i) = 30
                        i = i + 1
                        PictureboxAbleToBlock(i) = 31
                        i = i + 1
                        PictureboxAbleToBlock(i) = 32
                        CheckPicturebox33Color()
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Pic30None()
                            Pic31None()
                            Pic32None()
                            Pic33None()
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            CheckPicturebox34Color()
                            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                Pic30None()
                                Pic31None()
                                Pic32None()
                                Pic33None()
                                Pic34None()
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                CheckPicturebox35Color()
                                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                    Pic30None()
                                    Pic31None()
                                    Pic32None()
                                    Pic33None()
                                    Pic34None()
                                    Pic35None()
                                    PictureboxAbleToBlock(i) = 30
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 35
                                    CheckPicturebox36Color()
                                Else
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                    Pic30None()
                                    Pic31None()
                                    Pic32None()
                                    Pic33None()
                                    Pic34None()
                                    Pic35None()
                                    Pic36None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB7SouthMovementArea()
        i = 1
        If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox38Color()
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                Pic38None()
                PictureboxAbleToBlock(i) = 38
                CheckPicturebox47Color()
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                    Pic38None()
                    Pic47None()
                    PictureboxAbleToBlock(i) = 38
                    i = i + 1
                    PictureboxAbleToBlock(i) = 47
                    CheckPicturebox56Color()
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                        Pic38None()
                        Pic47None()
                        Pic56None()
                        PictureboxAbleToBlock(i) = 38
                        i = i + 1
                        PictureboxAbleToBlock(i) = 47
                        i = i + 1
                        PictureboxAbleToBlock(i) = 56
                        CheckPicturebox65Color()
                        Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                            Pic38None()
                            Pic47None()
                            Pic56None()
                            Pic65None()
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 56
                            i = i + 1
                            PictureboxAbleToBlock(i) = 65
                            CheckPicturebox74Color()
                            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                Pic38None()
                                Pic47None()
                                Pic56None()
                                Pic65None()
                                Pic74None()
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 56
                                i = i + 1
                                PictureboxAbleToBlock(i) = 65
                                i = i + 1
                                PictureboxAbleToBlock(i) = 74
                                CheckPicturebox83Color()
                            Else
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                Pic38None()
                                Pic47None()
                                Pic56None()
                                Pic65None()
                                Pic74None()
                                Pic83None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB7WestMovementArea()
        If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox28Color()
        Else
            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
            Pic28None()
        End If
    End Sub

    Public Sub CheB7NorthMovementArea()
        i = 1
        If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox20Color()
            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                Pic20None()
                PictureboxAbleToBlock(i) = 20
                CheckPicturebox11Color()
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                    Pic20None()
                    Pic11None()
                    PictureboxAbleToBlock(i) = 20
                    i = i + 1
                    PictureboxAbleToBlock(i) = 11
                    CheckPicturebox2Color()
                Else
                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                    Pic20None()
                    Pic11None()
                    Pic2None()
                End If
            End If
        End If
    End Sub

    Public Sub CheC7EastMovementArea()
        i = 1
        If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox31Color()
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                Pic31None()
                PictureboxAbleToBlock(i) = 31
                CheckPicturebox32Color()
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    Pic31None()
                    Pic32None()
                    PictureboxAbleToBlock(i) = 31
                    i = i + 1
                    PictureboxAbleToBlock(i) = 32
                    CheckPicturebox33Color()
                    Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Pic31None()
                        Pic32None()
                        Pic33None()
                        PictureboxAbleToBlock(i) = 31
                        i = i + 1
                        PictureboxAbleToBlock(i) = 32
                        i = i + 1
                        PictureboxAbleToBlock(i) = 33
                        CheckPicturebox34Color()
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                            Pic31None()
                            Pic32None()
                            Pic33None()
                            Pic34None()
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            CheckPicturebox35Color()
                            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                Pic31None()
                                Pic32None()
                                Pic33None()
                                Pic34None()
                                Pic35None()
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                CheckPicturebox36Color()
                            Else
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                Pic31None()
                                Pic32None()
                                Pic33None()
                                Pic34None()
                                Pic35None()
                                Pic36None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC7SouthMovementArea()
        i = 1
        If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox39Color()
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                Pic39None()
                PictureboxAbleToBlock(i) = 39
                CheckPicturebox48Color()
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                    Pic39None()
                    Pic48None()
                    PictureboxAbleToBlock(i) = 39
                    i = i + 1
                    PictureboxAbleToBlock(i) = 48
                    CheckPicturebox57Color()
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                        Pic39None()
                        Pic48None()
                        Pic57None()
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 57
                        CheckPicturebox66Color()
                        Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                            Pic39None()
                            Pic48None()
                            Pic57None()
                            Pic66None()
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                            CheckPicturebox75Color()
                            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                Pic39None()
                                Pic48None()
                                Pic57None()
                                Pic66None()
                                Pic75None()
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                                i = i + 1
                                PictureboxAbleToBlock(i) = 75
                                CheckPicturebox84Color()
                            Else
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                Pic39None()
                                Pic48None()
                                Pic57None()
                                Pic66None()
                                Pic75None()
                                Pic84None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC7WestMovementArea()
        i = 1
        If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox29Color()
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                Pic29None()
                PictureboxAbleToBlock(i) = 29
                CheckPicturebox28Color()
            Else
                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                Pic29None()
                Pic28None()
            End If
        End If
    End Sub

    Public Sub CheC7NorthMovementArea()
        i = 1
        If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox21Color()
            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                Pic21None()
                PictureboxAbleToBlock(i) = 21
                CheckPicturebox12Color()
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                    Pic21None()
                    Pic12None()
                    PictureboxAbleToBlock(i) = 21
                    i = i + 1
                    PictureboxAbleToBlock(i) = 12
                    CheckPicturebox3Color()
                Else
                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                    Pic21None()
                    Pic12None()
                    Pic3None()
                End If
            End If
        End If
    End Sub

    Public Sub CheD7EastMovementArea()
        i = 1
        If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox32Color()
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                Pic32None()
                PictureboxAbleToBlock(i) = 32
                CheckPicturebox33Color()
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    Pic32None()
                    Pic33None()
                    PictureboxAbleToBlock(i) = 32
                    i = i + 1
                    PictureboxAbleToBlock(i) = 33
                    CheckPicturebox34Color()
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                        Pic32None()
                        Pic33None()
                        Pic34None()
                        PictureboxAbleToBlock(i) = 32
                        i = i + 1
                        PictureboxAbleToBlock(i) = 33
                        i = i + 1
                        PictureboxAbleToBlock(i) = 34
                        CheckPicturebox35Color()
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                            Pic32None()
                            Pic33None()
                            Pic34None()
                            Pic35None()
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            CheckPicturebox36Color()
                        Else
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                            Pic32None()
                            Pic33None()
                            Pic34None()
                            Pic35None()
                            Pic36None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD7SouthMovementArea()
        i = 1
        If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox40Color()
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                Pic40None()
                PictureboxAbleToBlock(i) = 40
                CheckPicturebox49Color()
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    Pic40None()
                    Pic49None()
                    PictureboxAbleToBlock(i) = 40
                    i = i + 1
                    PictureboxAbleToBlock(i) = 49
                    CheckPicturebox58Color()
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Pic40None()
                        Pic49None()
                        Pic58None()
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        CheckPicturebox67Color()
                        Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                            Pic40None()
                            Pic49None()
                            Pic58None()
                            Pic67None()
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            CheckPicturebox76Color()
                            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                Pic40None()
                                Pic49None()
                                Pic58None()
                                Pic67None()
                                Pic76None()
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 76
                                CheckPicturebox85Color()
                            Else
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                Pic40None()
                                Pic49None()
                                Pic58None()
                                Pic67None()
                                Pic76None()
                                Pic85None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD7WestMovementArea()
        i = 1
        If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox30Color()
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                Pic30None()
                PictureboxAbleToBlock(i) = 30
                CheckPicturebox29Color()
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                    Pic30None()
                    Pic29None()
                    PictureboxAbleToBlock(i) = 30
                    i = i + 1
                    PictureboxAbleToBlock(i) = 29
                    CheckPicturebox28Color()
                Else
                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                    Pic30None()
                    Pic29None()
                    Pic28None()
                End If
            End If
        End If
    End Sub

    Public Sub CheD7NorthMovementArea()
        i = 1
        If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox22Color()
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                Pic22None()
                PictureboxAbleToBlock(i) = 22
                CheckPicturebox13Color()
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                    Pic22None()
                    Pic13None()
                    PictureboxAbleToBlock(i) = 22
                    i = i + 1
                    PictureboxAbleToBlock(i) = 13
                    CheckPicturebox4Color()
                Else
                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                    Pic22None()
                    Pic13None()
                    Pic4None()
                End If
            End If
        End If
    End Sub

    Public Sub CheE7EastMovementArea()
        i = 1
        If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox33Color()
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                Pic33None()
                PictureboxAbleToBlock(i) = 33
                CheckPicturebox34Color()
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    Pic33None()
                    Pic34None()
                    PictureboxAbleToBlock(i) = 33
                    i = i + 1
                    PictureboxAbleToBlock(i) = 34
                    CheckPicturebox35Color()
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                        Pic33None()
                        Pic34None()
                        Pic35None()
                        PictureboxAbleToBlock(i) = 33
                        i = i + 1
                        PictureboxAbleToBlock(i) = 34
                        i = i + 1
                        PictureboxAbleToBlock(i) = 35
                        CheckPicturebox36Color()
                    Else
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                        Pic33None()
                        Pic34None()
                        Pic35None()
                        Pic36None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE7SouthMovementArea()
        i = 1
        If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox41Color()
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
                PictureboxAbleToBlock(i) = 41
                CheckPicturebox50Color()
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    Pic41None()
                    Pic50None()
                    PictureboxAbleToBlock(i) = 41
                    i = i + 1
                    PictureboxAbleToBlock(i) = 50
                    CheckPicturebox59Color()
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox68 IsNot Form1.nonePic.Image Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Pic41None()
                        Pic50None()
                        Pic59None()
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        CheckPicturebox68Color()
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox77 IsNot Form1.nonePic.Image Then
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                            Pic41None()
                            Pic50None()
                            Pic59None()
                            Pic68None()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            CheckPicturebox77Color()
                            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                Pic41None()
                                Pic50None()
                                Pic59None()
                                Pic68None()
                                Pic77None()
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 77
                                CheckPicturebox86Color()
                            Else
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                Pic41None()
                                Pic50None()
                                Pic59None()
                                Pic68None()
                                Pic77None()
                                Pic86None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE7WestMovementArea()
        i = 1
        If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox31Color()
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                Pic31None()
                PictureboxAbleToBlock(i) = 31
                CheckPicturebox30Color()
                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                    Pic31None()
                    Pic30None()
                    PictureboxAbleToBlock(i) = 31
                    i = i + 1
                    PictureboxAbleToBlock(i) = 30
                    CheckPicturebox29Color()
                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                        Pic31None()
                        Pic30None()
                        Pic29None()
                        PictureboxAbleToBlock(i) = 31
                        i = i + 1
                        PictureboxAbleToBlock(i) = 30
                        i = i + 1
                        PictureboxAbleToBlock(i) = 29
                        CheckPicturebox28Color()
                    Else
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                        Pic31None()
                        Pic30None()
                        Pic29None()
                        Pic28None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE7NorthMovementArea()
        i = 1
        If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox23Color()
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
                PictureboxAbleToBlock(i) = 23
                CheckPicturebox14Color()
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    Pic23None()
                    Pic14None()
                    PictureboxAbleToBlock(i) = 23
                    i = i + 1
                    PictureboxAbleToBlock(i) = 14
                    CheckPicturebox5Color()
                Else
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                    Pic23None()
                    Pic14None()
                    Pic5None()
                End If
            End If
        End If
    End Sub

    Public Sub CheF7EastMovementArea()
        i = 1
        If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox34Color()
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
                PictureboxAbleToBlock(i) = 34
                CheckPicturebox35Color()
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    Pic34None()
                    Pic35None()
                    PictureboxAbleToBlock(i) = 34
                    i = i + 1
                    PictureboxAbleToBlock(i) = 35
                    CheckPicturebox36Color()
                Else
                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    Pic34None()
                    Pic35None()
                    Pic36None()
                End If
            End If
        End If
    End Sub

    Public Sub CheF7SouthMovementArea()
        i = 1
        If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox42Color()
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                Pic42None()
                PictureboxAbleToBlock(i) = 42
                CheckPicturebox51Color()
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    Pic42None()
                    Pic51None()
                    PictureboxAbleToBlock(i) = 42
                    i = i + 1
                    PictureboxAbleToBlock(i) = 51
                    CheckPicturebox60Color()
                    Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Pic42None()
                        Pic51None()
                        Pic60None()
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        CheckPicturebox69Color()
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                            Pic42None()
                            Pic51None()
                            Pic60None()
                            Pic69None()
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            CheckPicturebox78Color()
                            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                Pic42None()
                                Pic51None()
                                Pic60None()
                                Pic69None()
                                Pic78None()
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 78
                                CheckPicturebox87Color()
                            Else
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                Pic42None()
                                Pic51None()
                                Pic60None()
                                Pic69None()
                                Pic78None()
                                Pic87None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF7WestMovementArea()
        i = 1
        If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox32Color()
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                Pic32None()
                PictureboxAbleToBlock(i) = 32
                CheckPicturebox31Color()
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    Pic32None()
                    Pic31None()
                    PictureboxAbleToBlock(i) = 32
                    i = i + 1
                    PictureboxAbleToBlock(i) = 31
                    CheckPicturebox30Color()
                    Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                        Pic32None()
                        Pic31None()
                        Pic30None()
                        PictureboxAbleToBlock(i) = 32
                        i = i + 1
                        PictureboxAbleToBlock(i) = 31
                        i = i + 1
                        PictureboxAbleToBlock(i) = 30
                        CheckPicturebox29Color()
                        Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                            Pic32None()
                            Pic31None()
                            Pic30None()
                            Pic29None()
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 29
                            CheckPicturebox28Color()
                        Else
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                            Pic32None()
                            Pic31None()
                            Pic30None()
                            Pic29None()
                            Pic28None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF7NorthMovementArea()
        i = 1
        If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox24Color()
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
                PictureboxAbleToBlock(i) = 24
                CheckPicturebox15Color()
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    Pic24None()
                    Pic15None()
                    PictureboxAbleToBlock(i) = 24
                    i = i + 1
                    PictureboxAbleToBlock(i) = 15
                    CheckPicturebox6Color()
                Else
                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                    Pic24None()
                    Pic15None()
                    Pic6None()
                End If
            End If
        End If
    End Sub

    Public Sub CheG7EastMovementArea()
        i = 1
        If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox35Color()
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
                PictureboxAbleToBlock(i) = 35
                CheckPicturebox36Color()
            Else
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                Pic35None()
                Pic36None()
            End If
        End If
    End Sub

    Public Sub CheG7SouthMovementArea()
        i = 1
        If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox43Color()
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
                PictureboxAbleToBlock(i) = 43
                CheckPicturebox52Color()
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    Pic43None()
                    Pic52None()
                    PictureboxAbleToBlock(i) = 43
                    i = i + 1
                    PictureboxAbleToBlock(i) = 52
                    CheckPicturebox61Color()
                    Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                        Pic43None()
                        Pic52None()
                        Pic61None()
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 61
                        CheckPicturebox70Color()
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                            Pic43None()
                            Pic52None()
                            Pic61None()
                            Pic70None()
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 70
                            CheckPicturebox79Color()
                            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                Pic43None()
                                Pic52None()
                                Pic61None()
                                Pic70None()
                                Pic79None()
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 79
                                CheckPicturebox88Color()
                            Else
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                Pic43None()
                                Pic52None()
                                Pic61None()
                                Pic70None()
                                Pic79None()
                                Pic88None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG7WestMovementArea()
        i = 1
        If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox33Color()
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                Pic33None()
                PictureboxAbleToBlock(i) = 33
                CheckPicturebox32Color()
                Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    Pic33None()
                    Pic32None()
                    PictureboxAbleToBlock(i) = 33
                    i = i + 1
                    PictureboxAbleToBlock(i) = 32
                    CheckPicturebox31Color()
                    Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Pic33None()
                        Pic32None()
                        Pic31None()
                        PictureboxAbleToBlock(i) = 33
                        i = i + 1
                        PictureboxAbleToBlock(i) = 32
                        i = i + 1
                        PictureboxAbleToBlock(i) = 31
                        CheckPicturebox30Color()
                        Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                            Pic33None()
                            Pic32None()
                            Pic31None()
                            Pic30None()
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            CheckPicturebox29Color()
                            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                Pic33None()
                                Pic32None()
                                Pic31None()
                                Pic30None()
                                Pic29None()
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 29
                                CheckPicturebox28Color()
                            Else
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                Pic33None()
                                Pic32None()
                                Pic31None()
                                Pic30None()
                                Pic29None()
                                Pic28None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG7NorthMovementArea()
        i = 1
        If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox25Color()
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                Pic25None()
                PictureboxAbleToBlock(i) = 25
                CheckPicturebox16Color()
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    Pic25None()
                    Pic16None()
                    PictureboxAbleToBlock(i) = 25
                    i = i + 1
                    PictureboxAbleToBlock(i) = 16
                    CheckPicturebox7Color()
                Else
                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                    Pic25None()
                    Pic16None()
                    Pic7None()
                End If
            End If
        End If
    End Sub

    Public Sub CheH7EastMovementArea()
        If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox36Color()
        Else
            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
            Pic36None()
        End If
    End Sub

    Public Sub CheH7SouthMovementArea()
        i = 1
        If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox44Color()
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
                PictureboxAbleToBlock(i) = 44
                CheckPicturebox53Color()
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    Pic44None()
                    Pic53None()
                    PictureboxAbleToBlock(i) = 44
                    i = i + 1
                    PictureboxAbleToBlock(i) = 53
                    CheckPicturebox62Color()
                    Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                        Pic44None()
                        Pic53None()
                        Pic62None()
                        PictureboxAbleToBlock(i) = 44
                        i = i + 1
                        PictureboxAbleToBlock(i) = 53
                        i = i + 1
                        PictureboxAbleToBlock(i) = 62
                        CheckPicturebox71Color()
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                            Pic44None()
                            Pic53None()
                            Pic62None()
                            Pic71None()
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 71
                            CheckPicturebox80Color()
                            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                Pic44None()
                                Pic53None()
                                Pic62None()
                                Pic71None()
                                Pic80None()
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 71
                                i = i + 1
                                PictureboxAbleToBlock(i) = 80
                                CheckPicturebox89Color()
                            Else
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                Pic44None()
                                Pic53None()
                                Pic62None()
                                Pic71None()
                                Pic80None()
                                Pic89None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH7WestMovementArea()
        i = 1
        If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox34Color()
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
                PictureboxAbleToBlock(i) = 34
                CheckPicturebox33Color()
                Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    Pic34None()
                    Pic33None()
                    PictureboxAbleToBlock(i) = 34
                    i = i + 1
                    PictureboxAbleToBlock(i) = 33
                    CheckPicturebox32Color()
                    Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Pic34None()
                        Pic33None()
                        Pic32None()
                        PictureboxAbleToBlock(i) = 34
                        i = i + 1
                        PictureboxAbleToBlock(i) = 33
                        i = i + 1
                        PictureboxAbleToBlock(i) = 32
                        CheckPicturebox31Color()
                        Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Pic34None()
                            Pic33None()
                            Pic32None()
                            Pic31None()
                            PictureboxAbleToBlock(i) = 34
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            CheckPicturebox30Color()
                            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                Pic34None()
                                Pic33None()
                                Pic32None()
                                Pic31None()
                                Pic30None()
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                CheckPicturebox29Color()
                                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                    Pic34None()
                                    Pic33None()
                                    Pic32None()
                                    Pic31None()
                                    Pic30None()
                                    Pic29None()
                                    PictureboxAbleToBlock(i) = 34
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 30
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 29
                                    CheckPicturebox28Color()
                                Else
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                    Pic34None()
                                    Pic33None()
                                    Pic32None()
                                    Pic31None()
                                    Pic30None()
                                    Pic29None()
                                    Pic28None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH7NorthMovementArea()
        i = 1
        If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox26Color()
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
                PictureboxAbleToBlock(i) = 26
                CheckPicturebox17Color()
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    Pic26None()
                    Pic17None()
                    PictureboxAbleToBlock(i) = 26
                    i = i + 1
                    PictureboxAbleToBlock(i) = 17
                    CheckPicturebox8Color()
                Else
                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                    Pic26None()
                    Pic17None()
                    Pic8None()
                End If
            End If
        End If
    End Sub

    Public Sub CheI7SouthMovementArea()
        i = 1
        If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox45Color()
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                Pic45None()
                PictureboxAbleToBlock(i) = 45
                CheckPicturebox54Color()
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    Pic45None()
                    Pic54None()
                    PictureboxAbleToBlock(i) = 45
                    i = i + 1
                    PictureboxAbleToBlock(i) = 54
                    CheckPicturebox63Color()
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                        Pic45None()
                        Pic54None()
                        Pic63None()
                        PictureboxAbleToBlock(i) = 45
                        i = i + 1
                        PictureboxAbleToBlock(i) = 54
                        i = i + 1
                        PictureboxAbleToBlock(i) = 63
                        CheckPicturebox72Color()
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                            Pic45None()
                            Pic54None()
                            Pic63None()
                            Pic72None()
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 63
                            i = i + 1
                            PictureboxAbleToBlock(i) = 72
                            CheckPicturebox81Color()
                            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                Pic45None()
                                Pic54None()
                                Pic63None()
                                Pic72None()
                                Pic81None()
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 63
                                i = i + 1
                                PictureboxAbleToBlock(i) = 72
                                i = i + 1
                                PictureboxAbleToBlock(i) = 81
                                CheckPicturebox90Color()
                            Else
                                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                                Pic45None()
                                Pic54None()
                                Pic63None()
                                Pic72None()
                                Pic81None()
                                Pic90None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI7WestMovementArea()
        i = 1
        If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox35Color()
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
                PictureboxAbleToBlock(i) = 35
                CheckPicturebox34Color()
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    Pic35None()
                    Pic34None()
                    PictureboxAbleToBlock(i) = 35
                    i = i + 1
                    PictureboxAbleToBlock(i) = 34
                    CheckPicturebox33Color()
                    Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Pic35None()
                        Pic34None()
                        Pic33None()
                        PictureboxAbleToBlock(i) = 35
                        i = i + 1
                        PictureboxAbleToBlock(i) = 34
                        i = i + 1
                        PictureboxAbleToBlock(i) = 33
                        CheckPicturebox32Color()
                        Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Pic35None()
                            Pic34None()
                            Pic33None()
                            Pic32None()
                            PictureboxAbleToBlock(i) = 35
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            CheckPicturebox31Color()
                            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Pic35None()
                                Pic34None()
                                Pic33None()
                                Pic32None()
                                Pic31None()
                                PictureboxAbleToBlock(i) = 35
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                CheckPicturebox30Color()
                                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Pic35None()
                                    Pic34None()
                                    Pic33None()
                                    Pic32None()
                                    Pic31None()
                                    Pic30None()
                                    PictureboxAbleToBlock(i) = 35
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 30
                                    CheckPicturebox29Color()
                                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                        Pic35None()
                                        Pic34None()
                                        Pic33None()
                                        Pic32None()
                                        Pic31None()
                                        Pic30None()
                                        Pic29None()
                                        PictureboxAbleToBlock(i) = 35
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 34
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 33
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 32
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 31
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 30
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 29
                                        CheckPicturebox28Color()
                                    Else
                                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                        Pic35None()
                                        Pic34None()
                                        Pic33None()
                                        Pic32None()
                                        Pic31None()
                                        Pic30None()
                                        Pic29None()
                                        Pic28None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI7NorthMovementArea()
        i = 1
        If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox27Color()
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                Pic27None()
                PictureboxAbleToBlock(i) = 27
                CheckPicturebox18Color()
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                    Pic27None()
                    Pic18None()
                    PictureboxAbleToBlock(i) = 27
                    i = i + 1
                    PictureboxAbleToBlock(i) = 18
                    CheckPicturebox9Color()
                Else
                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                    Pic27None()
                    Pic18None()
                    Pic9None()
                End If
            End If
        End If
    End Sub

    Public Sub CheA8EastMovementArea()
        i = 1
        If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox20Color()
            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                Pic20None()
                PictureboxAbleToBlock(i) = 20
                CheckPicturebox21Color()
                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                    Pic20None()
                    Pic21None()
                    PictureboxAbleToBlock(i) = 20
                    i = i + 1
                    PictureboxAbleToBlock(i) = 21
                    CheckPicturebox22Color()
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                        Pic20None()
                        Pic21None()
                        Pic22None()
                        PictureboxAbleToBlock(i) = 20
                        i = i + 1
                        PictureboxAbleToBlock(i) = 21
                        i = i + 1
                        PictureboxAbleToBlock(i) = 22
                        CheckPicturebox23Color()
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Pic20None()
                            Pic21None()
                            Pic22None()
                            Pic23None()
                            PictureboxAbleToBlock(i) = 20
                            i = i + 1
                            PictureboxAbleToBlock(i) = 21
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            CheckPicturebox24Color()
                            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                Pic20None()
                                Pic21None()
                                Pic22None()
                                Pic23None()
                                Pic24None()
                                PictureboxAbleToBlock(i) = 20
                                i = i + 1
                                PictureboxAbleToBlock(i) = 21
                                i = i + 1
                                PictureboxAbleToBlock(i) = 22
                                i = i + 1
                                PictureboxAbleToBlock(i) = 23
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                CheckPicturebox25Color()
                                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                    Pic20None()
                                    Pic21None()
                                    Pic22None()
                                    Pic23None()
                                    Pic24None()
                                    Pic25None()
                                    PictureboxAbleToBlock(i) = 20
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 21
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 22
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 23
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 24
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 25
                                    CheckPicturebox26Color()
                                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                        Pic20None()
                                        Pic21None()
                                        Pic22None()
                                        Pic23None()
                                        Pic24None()
                                        Pic25None()
                                        Pic26None()
                                        PictureboxAbleToBlock(i) = 20
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 21
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 22
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 23
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 24
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 25
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 26
                                        CheckPicturebox27Color()
                                    Else
                                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                        Pic20None()
                                        Pic21None()
                                        Pic22None()
                                        Pic23None()
                                        Pic24None()
                                        Pic25None()
                                        Pic26None()
                                        Pic27None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA8SouthMovementArea()
        i = 1
        If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox28Color()
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                Pic28None()
                PictureboxAbleToBlock(i) = 28
                CheckPicturebox37Color()
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                    Pic28None()
                    Pic37None()
                    PictureboxAbleToBlock(i) = 28
                    i = i + 1
                    PictureboxAbleToBlock(i) = 37
                    CheckPicturebox46Color()
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                        Pic28None()
                        Pic37None()
                        Pic46None()
                        PictureboxAbleToBlock(i) = 28
                        i = i + 1
                        PictureboxAbleToBlock(i) = 37
                        i = i + 1
                        PictureboxAbleToBlock(i) = 46
                        CheckPicturebox55Color()
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                            Pic28None()
                            Pic37None()
                            Pic46None()
                            Pic55None()
                            PictureboxAbleToBlock(i) = 28
                            i = i + 1
                            PictureboxAbleToBlock(i) = 37
                            i = i + 1
                            PictureboxAbleToBlock(i) = 46
                            i = i + 1
                            PictureboxAbleToBlock(i) = 55
                            CheckPicturebox64Color()
                            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                Pic28None()
                                Pic37None()
                                Pic46None()
                                Pic55None()
                                Pic64None()
                                PictureboxAbleToBlock(i) = 28
                                i = i + 1
                                PictureboxAbleToBlock(i) = 37
                                i = i + 1
                                PictureboxAbleToBlock(i) = 46
                                i = i + 1
                                PictureboxAbleToBlock(i) = 55
                                i = i + 1
                                PictureboxAbleToBlock(i) = 64
                                CheckPicturebox73Color()
                                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                    Pic28None()
                                    Pic37None()
                                    Pic46None()
                                    Pic55None()
                                    Pic64None()
                                    Pic73None()
                                    PictureboxAbleToBlock(i) = 28
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 37
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 46
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 55
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 64
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 73
                                    CheckPicturebox82Color()
                                Else
                                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                                    Pic28None()
                                    Pic37None()
                                    Pic46None()
                                    Pic55None()
                                    Pic64None()
                                    Pic73None()
                                    Pic82None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA8NorthMovementArea()
        i = 1
        If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox10Color()
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                Pic10None()
                PictureboxAbleToBlock(i) = 10
                CheckPicturebox1Color()
            Else
                Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                Pic10None()
                Pic1None()
            End If
        End If
    End Sub

    Public Sub CheB8EastMovementArea()
        i = 1
        If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox21Color()
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                Pic21None()
                PictureboxAbleToBlock(i) = 21
                CheckPicturebox22Color()
                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    Pic21None()
                    Pic22None()
                    PictureboxAbleToBlock(i) = 21
                    i = i + 1
                    PictureboxAbleToBlock(i) = 22
                    CheckPicturebox23Color()
                    Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                        Pic21None()
                        Pic22None()
                        Pic23None()
                        PictureboxAbleToBlock(i) = 21
                        i = i + 1
                        PictureboxAbleToBlock(i) = 22
                        i = i + 1
                        PictureboxAbleToBlock(i) = 23
                        CheckPicturebox24Color()
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                            Pic21None()
                            Pic22None()
                            Pic23None()
                            Pic24None()
                            PictureboxAbleToBlock(i) = 21
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                            CheckPicturebox25Color()
                            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                Pic21None()
                                Pic22None()
                                Pic23None()
                                Pic24None()
                                Pic25None()
                                PictureboxAbleToBlock(i) = 21
                                i = i + 1
                                PictureboxAbleToBlock(i) = 22
                                i = i + 1
                                PictureboxAbleToBlock(i) = 23
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                                CheckPicturebox26Color()
                                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                    Pic21None()
                                    Pic22None()
                                    Pic23None()
                                    Pic24None()
                                    Pic25None()
                                    Pic26None()
                                    PictureboxAbleToBlock(i) = 21
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 22
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 23
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 24
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 25
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 26
                                    CheckPicturebox27Color()
                                Else
                                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                    Pic21None()
                                    Pic22None()
                                    Pic23None()
                                    Pic24None()
                                    Pic25None()
                                    Pic26None()
                                    Pic27None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB8SouthMovementArea()
        i = 1
        If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox29Color()
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                Pic29None()
                PictureboxAbleToBlock(i) = 29
                CheckPicturebox38Color()
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                    Pic29None()
                    Pic38None()
                    PictureboxAbleToBlock(i) = 29
                    i = i + 1
                    PictureboxAbleToBlock(i) = 38
                    CheckPicturebox47Color()
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                        Pic29None()
                        Pic38None()
                        Pic47None()
                        PictureboxAbleToBlock(i) = 29
                        i = i + 1
                        PictureboxAbleToBlock(i) = 38
                        i = i + 1
                        PictureboxAbleToBlock(i) = 47
                        CheckPicturebox56Color()
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                            Pic29None()
                            Pic38None()
                            Pic47None()
                            Pic56None()
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 56
                            CheckPicturebox65Color()
                            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                Pic29None()
                                Pic38None()
                                Pic47None()
                                Pic56None()
                                Pic65None()
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 56
                                i = i + 1
                                PictureboxAbleToBlock(i) = 65
                                CheckPicturebox74Color()
                                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                    Pic29None()
                                    Pic38None()
                                    Pic47None()
                                    Pic56None()
                                    Pic65None()
                                    Pic74None()
                                    PictureboxAbleToBlock(i) = 29
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 38
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 47
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 56
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 65
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 74
                                    CheckPicturebox83Color()
                                Else
                                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                    Pic29None()
                                    Pic38None()
                                    Pic47None()
                                    Pic56None()
                                    Pic65None()
                                    Pic74None()
                                    Pic83None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB8WestMovementArea()
        If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox19Color()
        Else
            Form1.PictureBox19.Image = Form1.movementAreaPic.Image
            Pic19None()
        End If
    End Sub

    Public Sub CheB8NorthMovementArea()
        i = 1
        If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox11Color()
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                Pic11None()
                PictureboxAbleToBlock(i) = 11
                CheckPicturebox2Color()
            Else
                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                Pic11None()
                Pic2None()
            End If
        End If
    End Sub

    Public Sub CheC8EastMovementArea()
        i = 1
        If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox22Color()
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                Pic22None()
                PictureboxAbleToBlock(i) = 22
                CheckPicturebox23Color()
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    Pic22None()
                    Pic23None()
                    PictureboxAbleToBlock(i) = 22
                    i = i + 1
                    PictureboxAbleToBlock(i) = 23
                    CheckPicturebox24Color()
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                        Pic22None()
                        Pic23None()
                        Pic24None()
                        PictureboxAbleToBlock(i) = 22
                        i = i + 1
                        PictureboxAbleToBlock(i) = 23
                        i = i + 1
                        PictureboxAbleToBlock(i) = 24
                        CheckPicturebox25Color()
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                            Pic22None()
                            Pic23None()
                            Pic24None()
                            Pic25None()
                            PictureboxAbleToBlock(i) = 22
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                            i = i + 1
                            PictureboxAbleToBlock(i) = 25
                            CheckPicturebox26Color()
                            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                Pic22None()
                                Pic23None()
                                Pic24None()
                                Pic25None()
                                Pic26None()
                                PictureboxAbleToBlock(i) = 22
                                i = i + 1
                                PictureboxAbleToBlock(i) = 23
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                                i = i + 1
                                PictureboxAbleToBlock(i) = 26
                                CheckPicturebox27Color()
                            Else
                                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                Pic22None()
                                Pic23None()
                                Pic24None()
                                Pic25None()
                                Pic26None()
                                Pic27None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC8SouthMovementArea()
        i = 1
        If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox30Color()
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                Pic30None()
                PictureboxAbleToBlock(i) = 30
                CheckPicturebox39Color()
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                    Pic30None()
                    Pic39None()
                    PictureboxAbleToBlock(i) = 30
                    i = i + 1
                    PictureboxAbleToBlock(i) = 39
                    CheckPicturebox48Color()
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                        Pic30None()
                        Pic39None()
                        Pic48None()
                        PictureboxAbleToBlock(i) = 30
                        i = i + 1
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 48
                        CheckPicturebox57Color()
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                            Pic30None()
                            Pic39None()
                            Pic48None()
                            Pic57None()
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            CheckPicturebox66Color()
                            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                Pic30None()
                                Pic39None()
                                Pic48None()
                                Pic57None()
                                Pic66None()
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                                CheckPicturebox75Color()
                                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                    Pic30None()
                                    Pic39None()
                                    Pic48None()
                                    Pic57None()
                                    Pic66None()
                                    Pic75None()
                                    PictureboxAbleToBlock(i) = 30
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 75
                                    CheckPicturebox84Color()
                                Else
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                    Pic30None()
                                    Pic39None()
                                    Pic48None()
                                    Pic57None()
                                    Pic66None()
                                    Pic75None()
                                    Pic84None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC8WestMovementArea()
        i = 1
        If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox20Color()
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                Pic20None()
                PictureboxAbleToBlock(i) = 20
                CheckPicturebox19Color()
            Else
                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                Pic20None()
                Pic19None()
            End If
        End If
    End Sub

    Public Sub CheC8NorthMovementArea()
        i = 1
        If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox12Color()
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                Pic12None()
                PictureboxAbleToBlock(i) = 12
                CheckPicturebox3Color()
            Else
                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                Pic12None()
                Pic3None()
            End If
        End If
    End Sub

    Public Sub CheD8EastMovementArea()
        i = 1
        If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox23Color()
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
                PictureboxAbleToBlock(i) = 23
                CheckPicturebox24Color()
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    Pic23None()
                    Pic24None()
                    PictureboxAbleToBlock(i) = 23
                    i = i + 1
                    PictureboxAbleToBlock(i) = 24
                    CheckPicturebox25Color()
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                        Pic23None()
                        Pic24None()
                        Pic25None()
                        PictureboxAbleToBlock(i) = 23
                        i = i + 1
                        PictureboxAbleToBlock(i) = 24
                        i = i + 1
                        PictureboxAbleToBlock(i) = 25
                        CheckPicturebox26Color()
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                            Pic23None()
                            Pic24None()
                            Pic25None()
                            Pic26None()
                            PictureboxAbleToBlock(i) = 23
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                            i = i + 1
                            PictureboxAbleToBlock(i) = 25
                            i = i + 1
                            PictureboxAbleToBlock(i) = 26
                            CheckPicturebox27Color()
                        Else
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                            Pic23None()
                            Pic24None()
                            Pic25None()
                            Pic26None()
                            Pic27None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD8SouthMovementArea()
        i = 1
        If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox31Color()
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                Pic31None()
                PictureboxAbleToBlock(i) = 31
                CheckPicturebox40Color()
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    Pic31None()
                    Pic40None()
                    PictureboxAbleToBlock(i) = 31
                    i = i + 1
                    PictureboxAbleToBlock(i) = 40
                    CheckPicturebox49Color()
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Pic31None()
                        Pic40None()
                        Pic49None()
                        PictureboxAbleToBlock(i) = 31
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        CheckPicturebox58Color()
                        Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Pic31None()
                            Pic40None()
                            Pic49None()
                            Pic58None()
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            CheckPicturebox67Color()
                            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                Pic31None()
                                Pic40None()
                                Pic49None()
                                Pic58None()
                                Pic67None()
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                CheckPicturebox76Color()
                                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                    Pic31None()
                                    Pic40None()
                                    Pic49None()
                                    Pic58None()
                                    Pic67None()
                                    Pic76None()
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 76
                                    CheckPicturebox85Color()
                                Else
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                    Pic31None()
                                    Pic40None()
                                    Pic49None()
                                    Pic58None()
                                    Pic67None()
                                    Pic76None()
                                    Pic85None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD8WestMovementArea()
        i = 1
        If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox21Color()
            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                Pic21None()
                PictureboxAbleToBlock(i) = 21
                CheckPicturebox20Color()
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                    Pic21None()
                    Pic20None()
                    PictureboxAbleToBlock(i) = 21
                    i = i + 1
                    PictureboxAbleToBlock(i) = 20
                    CheckPicturebox19Color()
                Else
                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                    Pic21None()
                    Pic20None()
                    Pic19None()
                End If
            End If
        End If
    End Sub

    Public Sub CheD8NorthMovementArea()
        i = 1
        If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox13Color()
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                Pic13None()
                PictureboxAbleToBlock(i) = 13
                CheckPicturebox4Color()
            Else
                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                Pic13None()
                Pic4None()
            End If
        End If
    End Sub

    Public Sub CheE8EastMovementArea()
        i = 1
        If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox24Color()
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
                PictureboxAbleToBlock(i) = 24
                CheckPicturebox25Color()
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    Pic24None()
                    Pic25None()
                    PictureboxAbleToBlock(i) = 24
                    i = i + 1
                    PictureboxAbleToBlock(i) = 25
                    CheckPicturebox26Color()
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                        Pic24None()
                        Pic25None()
                        Pic26None()
                        PictureboxAbleToBlock(i) = 24
                        i = i + 1
                        PictureboxAbleToBlock(i) = 25
                        i = i + 1
                        PictureboxAbleToBlock(i) = 26
                        CheckPicturebox27Color()
                    Else
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                        Pic24None()
                        Pic25None()
                        Pic26None()
                        Pic27None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE8SouthMovementArea()
        i = 1
        If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox32Color()
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                Pic32None()
                PictureboxAbleToBlock(i) = 32
                CheckPicturebox41Color()
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    Pic32None()
                    Pic41None()
                    PictureboxAbleToBlock(i) = 32
                    i = i + 1
                    PictureboxAbleToBlock(i) = 41
                    CheckPicturebox50Color()
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Pic32None()
                        Pic41None()
                        Pic50None()
                        PictureboxAbleToBlock(i) = 32
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        CheckPicturebox59Color()
                        Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox68 IsNot Form1.nonePic.Image Then
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                            Pic32None()
                            Pic41None()
                            Pic50None()
                            Pic59None()
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            CheckPicturebox68Color()
                            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox77 IsNot Form1.nonePic.Image Then
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                Pic32None()
                                Pic41None()
                                Pic50None()
                                Pic59None()
                                Pic68None()
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                CheckPicturebox77Color()
                                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                    Pic32None()
                                    Pic41None()
                                    Pic50None()
                                    Pic59None()
                                    Pic68None()
                                    Pic77None()
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 77
                                    CheckPicturebox86Color()
                                Else
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                    Pic32None()
                                    Pic41None()
                                    Pic50None()
                                    Pic59None()
                                    Pic68None()
                                    Pic77None()
                                    Pic86None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE8WestMovementArea()
        i = 1
        If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox22Color()
            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                Pic22None()
                PictureboxAbleToBlock(i) = 22
                CheckPicturebox21Color()
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                    Pic22None()
                    Pic21None()
                    PictureboxAbleToBlock(i) = 22
                    i = i + 1
                    PictureboxAbleToBlock(i) = 21
                    CheckPicturebox20Color()
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                        Pic22None()
                        Pic21None()
                        Pic20None()
                        PictureboxAbleToBlock(i) = 22
                        i = i + 1
                        PictureboxAbleToBlock(i) = 21
                        i = i + 1
                        PictureboxAbleToBlock(i) = 20
                        CheckPicturebox19Color()
                    Else
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                        Pic22None()
                        Pic21None()
                        Pic20None()
                        Pic19None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE8NorthMovementArea()
        i = 1
        If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox14Color()
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
                PictureboxAbleToBlock(i) = 14
                CheckPicturebox5Color()
            Else
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                Pic14None()
                Pic5None()
            End If
        End If
    End Sub

    Public Sub CheF8EastMovementArea()
        i = 1
        If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox25Color()
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                Pic25None()
                PictureboxAbleToBlock(i) = 25
                CheckPicturebox26Color()
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    Pic25None()
                    Pic26None()
                    PictureboxAbleToBlock(i) = 25
                    i = i + 1
                    PictureboxAbleToBlock(i) = 26
                    CheckPicturebox27Color()
                Else
                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                    Pic25None()
                    Pic26None()
                    Pic27None()
                End If
            End If
        End If
    End Sub

    Public Sub CheF8SouthMovementArea()
        i = 1
        If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox33Color()
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                Pic33None()
                PictureboxAbleToBlock(i) = 33
                CheckPicturebox42Color()
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    Pic33None()
                    Pic42None()
                    PictureboxAbleToBlock(i) = 33
                    i = i + 1
                    PictureboxAbleToBlock(i) = 42
                    CheckPicturebox51Color()
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Pic33None()
                        Pic42None()
                        Pic51None()
                        PictureboxAbleToBlock(i) = 33
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        CheckPicturebox60Color()
                        Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Pic33None()
                            Pic42None()
                            Pic51None()
                            Pic60None()
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            CheckPicturebox69Color()
                            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                Pic33None()
                                Pic42None()
                                Pic51None()
                                Pic60None()
                                Pic69None()
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                CheckPicturebox78Color()
                                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                    Pic33None()
                                    Pic42None()
                                    Pic51None()
                                    Pic60None()
                                    Pic69None()
                                    Pic78None()
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 78
                                    CheckPicturebox87Color()
                                Else
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                    Pic33None()
                                    Pic42None()
                                    Pic51None()
                                    Pic60None()
                                    Pic69None()
                                    Pic78None()
                                    Pic87None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF8WestMovementArea()
        i = 1
        If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox23Color()
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
                PictureboxAbleToBlock(i) = 23
                CheckPicturebox22Color()
                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    Pic23None()
                    Pic22None()
                    PictureboxAbleToBlock(i) = 23
                    i = i + 1
                    PictureboxAbleToBlock(i) = 22
                    CheckPicturebox21Color()
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                        Pic23None()
                        Pic22None()
                        Pic21None()
                        PictureboxAbleToBlock(i) = 23
                        i = i + 1
                        PictureboxAbleToBlock(i) = 22
                        i = i + 1
                        PictureboxAbleToBlock(i) = 21
                        CheckPicturebox20Color()
                        Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                            Pic23None()
                            Pic22None()
                            Pic21None()
                            Pic20None()
                            PictureboxAbleToBlock(i) = 23
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                            i = i + 1
                            PictureboxAbleToBlock(i) = 21
                            i = i + 1
                            PictureboxAbleToBlock(i) = 20
                            CheckPicturebox19Color()
                        Else
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                            Pic23None()
                            Pic22None()
                            Pic21None()
                            Pic20None()
                            Pic19None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF8NorthMovementArea()
        i = 1
        If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox15Color()
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Pic15None()
                PictureboxAbleToBlock(i) = 15
                CheckPicturebox6Color()
            Else
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                Pic15None()
                Pic6None()
            End If
        End If
    End Sub

    Public Sub CheG8EastMovementArea()
        i = 1
        If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox26Color()
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
                PictureboxAbleToBlock(i) = 26
                CheckPicturebox27Color()
            Else
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                Pic26None()
                Pic27None()
            End If
        End If
    End Sub

    Public Sub CheG8SouthMovementArea()
        i = 1
        If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox34Color()
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
                PictureboxAbleToBlock(i) = 34
                CheckPicturebox43Color()
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    Pic34None()
                    Pic43None()
                    PictureboxAbleToBlock(i) = 34
                    i = i + 1
                    PictureboxAbleToBlock(i) = 43
                    CheckPicturebox52Color()
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                        Pic34None()
                        Pic43None()
                        Pic52None()
                        PictureboxAbleToBlock(i) = 34
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 52
                        CheckPicturebox61Color()
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                            Pic34None()
                            Pic43None()
                            Pic52None()
                            Pic61None()
                            PictureboxAbleToBlock(i) = 34
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            CheckPicturebox70Color()
                            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                Pic34None()
                                Pic43None()
                                Pic52None()
                                Pic61None()
                                Pic70None()
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 70
                                CheckPicturebox79Color()
                                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                    Pic34None()
                                    Pic43None()
                                    Pic52None()
                                    Pic61None()
                                    Pic70None()
                                    Pic79None()
                                    PictureboxAbleToBlock(i) = 34
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 79
                                    CheckPicturebox88Color()
                                Else
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                    Pic34None()
                                    Pic43None()
                                    Pic52None()
                                    Pic61None()
                                    Pic70None()
                                    Pic79None()
                                    Pic88None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG8WestMovementArea()
        i = 1
        If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox24Color()
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
                PictureboxAbleToBlock(i) = 24
                CheckPicturebox23Color()
                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    Pic24None()
                    Pic23None()
                    PictureboxAbleToBlock(i) = 24
                    i = i + 1
                    PictureboxAbleToBlock(i) = 23
                    CheckPicturebox22Color()
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                        Pic24None()
                        Pic23None()
                        Pic22None()
                        PictureboxAbleToBlock(i) = 24
                        i = i + 1
                        PictureboxAbleToBlock(i) = 23
                        i = i + 1
                        PictureboxAbleToBlock(i) = 22
                        CheckPicturebox21Color()
                        Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                            Pic24None()
                            Pic23None()
                            Pic22None()
                            Pic21None()
                            PictureboxAbleToBlock(i) = 24
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                            i = i + 1
                            PictureboxAbleToBlock(i) = 21
                            CheckPicturebox20Color()
                            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                Pic24None()
                                Pic23None()
                                Pic22None()
                                Pic21None()
                                Pic20None()
                                PictureboxAbleToBlock(i) = 24
                                i = i + 1
                                PictureboxAbleToBlock(i) = 23
                                i = i + 1
                                PictureboxAbleToBlock(i) = 22
                                i = i + 1
                                PictureboxAbleToBlock(i) = 21
                                i = i + 1
                                PictureboxAbleToBlock(i) = 20
                                CheckPicturebox19Color()
                            Else
                                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                Pic24None()
                                Pic23None()
                                Pic22None()
                                Pic21None()
                                Pic20None()
                                Pic19None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG8NorthMovementArea()
        i = 1
        If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox16Color()
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                Pic16None()
                PictureboxAbleToBlock(i) = 16
                CheckPicturebox7Color()
            Else
                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                Pic16None()
                Pic7None()
            End If
        End If
    End Sub

    Public Sub CheH8EastMovementArea()
        If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox27Color()
        Else
            Form1.PictureBox27.Image = Form1.movementAreaPic.Image
            Pic27None()
        End If
    End Sub

    Public Sub CheH8SouthMovementArea()
        i = 1
        If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox35Color()
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
                PictureboxAbleToBlock(i) = 35
                CheckPicturebox44Color()
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    Pic35None()
                    Pic44None()
                    PictureboxAbleToBlock(i) = 35
                    i = i + 1
                    PictureboxAbleToBlock(i) = 44
                    CheckPicturebox53Color()
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                        Pic35None()
                        Pic44None()
                        Pic53None()
                        PictureboxAbleToBlock(i) = 35
                        i = i + 1
                        PictureboxAbleToBlock(i) = 44
                        i = i + 1
                        PictureboxAbleToBlock(i) = 53
                        CheckPicturebox62Color()
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                            Pic35None()
                            Pic44None()
                            Pic53None()
                            Pic62None()
                            PictureboxAbleToBlock(i) = 35
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 62
                            CheckPicturebox71Color()
                            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                Pic35None()
                                Pic44None()
                                Pic53None()
                                Pic62None()
                                Pic71None()
                                PictureboxAbleToBlock(i) = 35
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 71
                                CheckPicturebox80Color()
                                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                    Pic35None()
                                    Pic44None()
                                    Pic53None()
                                    Pic62None()
                                    Pic71None()
                                    Pic80None()
                                    PictureboxAbleToBlock(i) = 35
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 71
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 80
                                    CheckPicturebox89Color()
                                Else
                                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                    Pic35None()
                                    Pic44None()
                                    Pic53None()
                                    Pic62None()
                                    Pic71None()
                                    Pic80None()
                                    Pic89None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH8WestMovementArea()
        i = 1
        If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox25Color()
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                Pic25None()
                PictureboxAbleToBlock(i) = 25
                CheckPicturebox24Color()
                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    Pic25None()
                    Pic24None()
                    PictureboxAbleToBlock(i) = 25
                    i = i + 1
                    PictureboxAbleToBlock(i) = 24
                    CheckPicturebox23Color()
                    Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                        Pic25None()
                        Pic24None()
                        Pic23None()
                        PictureboxAbleToBlock(i) = 25
                        i = i + 1
                        PictureboxAbleToBlock(i) = 24
                        i = i + 1
                        PictureboxAbleToBlock(i) = 23
                        CheckPicturebox22Color()
                        Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                            Pic25None()
                            Pic24None()
                            Pic23None()
                            Pic22None()
                            PictureboxAbleToBlock(i) = 25
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                            CheckPicturebox21Color()
                            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                Pic25None()
                                Pic24None()
                                Pic23None()
                                Pic22None()
                                Pic21None()
                                PictureboxAbleToBlock(i) = 25
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                i = i + 1
                                PictureboxAbleToBlock(i) = 23
                                i = i + 1
                                PictureboxAbleToBlock(i) = 22
                                i = i + 1
                                PictureboxAbleToBlock(i) = 21
                                CheckPicturebox20Color()
                                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                    Pic25None()
                                    Pic24None()
                                    Pic23None()
                                    Pic22None()
                                    Pic21None()
                                    Pic20None()
                                    PictureboxAbleToBlock(i) = 25
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 24
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 23
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 22
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 21
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 20
                                    CheckPicturebox19Color()
                                Else
                                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                    Pic25None()
                                    Pic24None()
                                    Pic23None()
                                    Pic22None()
                                    Pic21None()
                                    Pic20None()
                                    Pic19None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH8NorthMovementArea()
        i = 1
        If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox17Color()
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                Pic17None()
                PictureboxAbleToBlock(i) = 17
                CheckPicturebox8Color()
            Else
                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                Pic17None()
                Pic8None()
            End If
        End If
    End Sub

    Public Sub CheI8SouthMovementArea()
        i = 1
        If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox36Color()
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                Pic36None()
                PictureboxAbleToBlock(i) = 36
                CheckPicturebox45Color()
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    Pic36None()
                    Pic45None()
                    PictureboxAbleToBlock(i) = 36
                    i = i + 1
                    PictureboxAbleToBlock(i) = 45
                    CheckPicturebox54Color()
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                        Pic36None()
                        Pic45None()
                        Pic54None()
                        PictureboxAbleToBlock(i) = 36
                        i = i + 1
                        PictureboxAbleToBlock(i) = 45
                        i = i + 1
                        PictureboxAbleToBlock(i) = 54
                        CheckPicturebox63Color()
                        Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                            Pic36None()
                            Pic45None()
                            Pic54None()
                            Pic63None()
                            PictureboxAbleToBlock(i) = 36
                            i = i + 1
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 63
                            CheckPicturebox72Color()
                            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                Pic36None()
                                Pic45None()
                                Pic54None()
                                Pic63None()
                                Pic72None()
                                PictureboxAbleToBlock(i) = 36
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 63
                                i = i + 1
                                PictureboxAbleToBlock(i) = 72
                                CheckPicturebox81Color()
                                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                    Pic36None()
                                    Pic45None()
                                    Pic54None()
                                    Pic63None()
                                    Pic72None()
                                    Pic81None()
                                    PictureboxAbleToBlock(i) = 36
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 45
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 54
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 63
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 72
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 81
                                    CheckPicturebox90Color()
                                Else
                                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                                    Pic36None()
                                    Pic45None()
                                    Pic54None()
                                    Pic63None()
                                    Pic72None()
                                    Pic81None()
                                    Pic90None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI8WestMovementArea()
        i = 1
        If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox26Color()
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
                PictureboxAbleToBlock(i) = 26
                CheckPicturebox25Color()
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    Pic26None()
                    Pic25None()
                    PictureboxAbleToBlock(i) = 26
                    i = i + 1
                    PictureboxAbleToBlock(i) = 25
                    CheckPicturebox24Color()
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                        Pic26None()
                        Pic25None()
                        Pic24None()
                        PictureboxAbleToBlock(i) = 26
                        i = i + 1
                        PictureboxAbleToBlock(i) = 25
                        i = i + 1
                        PictureboxAbleToBlock(i) = 24
                        CheckPicturebox23Color()
                        Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Pic26None()
                            Pic25None()
                            Pic24None()
                            Pic23None()
                            PictureboxAbleToBlock(i) = 26
                            i = i + 1
                            PictureboxAbleToBlock(i) = 25
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            CheckPicturebox22Color()
                            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                Pic26None()
                                Pic25None()
                                Pic24None()
                                Pic23None()
                                Pic22None()
                                PictureboxAbleToBlock(i) = 26
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                i = i + 1
                                PictureboxAbleToBlock(i) = 23
                                i = i + 1
                                PictureboxAbleToBlock(i) = 22
                                CheckPicturebox21Color()
                                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                    Pic26None()
                                    Pic25None()
                                    Pic24None()
                                    Pic23None()
                                    Pic22None()
                                    Pic21None()
                                    PictureboxAbleToBlock(i) = 26
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 25
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 24
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 23
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 22
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 21
                                    CheckPicturebox20Color()
                                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                        Pic26None()
                                        Pic25None()
                                        Pic24None()
                                        Pic23None()
                                        Pic22None()
                                        Pic21None()
                                        Pic20None()
                                        PictureboxAbleToBlock(i) = 26
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 25
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 24
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 23
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 22
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 21
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 20
                                        CheckPicturebox19Color()
                                    Else
                                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                        Pic26None()
                                        Pic25None()
                                        Pic24None()
                                        Pic23None()
                                        Pic22None()
                                        Pic21None()
                                        Pic20None()
                                        Pic19None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI8NorthMovementArea()
        i = 1
        If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox18Color()
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                Pic18None()
                PictureboxAbleToBlock(i) = 18
                CheckPicturebox9Color()
            Else
                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                Pic18None()
                Pic9None()
            End If
        End If
    End Sub

    Public Sub CheA9EastMovementArea()
        i = 1
        If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox11Color()
            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                Pic11None()
                PictureboxAbleToBlock(i) = 11
                CheckPicturebox12Color()
                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                    Pic11None()
                    Pic12None()
                    PictureboxAbleToBlock(i) = 11
                    i = i + 1
                    PictureboxAbleToBlock(i) = 12
                    CheckPicturebox13Color()
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                        Pic11None()
                        Pic12None()
                        Pic13None()
                        PictureboxAbleToBlock(i) = 11
                        i = i + 1
                        PictureboxAbleToBlock(i) = 12
                        i = i + 1
                        PictureboxAbleToBlock(i) = 13
                        CheckPicturebox14Color()
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Pic11None()
                            Pic12None()
                            Pic13None()
                            Pic14None()
                            PictureboxAbleToBlock(i) = 11
                            i = i + 1
                            PictureboxAbleToBlock(i) = 12
                            i = i + 1
                            PictureboxAbleToBlock(i) = 13
                            i = i + 1
                            PictureboxAbleToBlock(i) = 14
                            CheckPicturebox15Color()
                            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                Pic11None()
                                Pic12None()
                                Pic13None()
                                Pic14None()
                                Pic15None()
                                PictureboxAbleToBlock(i) = 11
                                i = i + 1
                                PictureboxAbleToBlock(i) = 12
                                i = i + 1
                                PictureboxAbleToBlock(i) = 13
                                i = i + 1
                                PictureboxAbleToBlock(i) = 14
                                i = i + 1
                                PictureboxAbleToBlock(i) = 15
                                CheckPicturebox16Color()
                                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                    Pic11None()
                                    Pic12None()
                                    Pic13None()
                                    Pic14None()
                                    Pic15None()
                                    Pic16None()
                                    PictureboxAbleToBlock(i) = 11
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 12
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 13
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 14
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 15
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 16
                                    CheckPicturebox17Color()
                                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                        Pic11None()
                                        Pic12None()
                                        Pic13None()
                                        Pic14None()
                                        Pic15None()
                                        Pic16None()
                                        Pic17None()
                                        PictureboxAbleToBlock(i) = 11
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 12
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 13
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 14
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 15
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 16
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 17
                                        CheckPicturebox18Color()
                                    Else
                                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                        Pic11None()
                                        Pic12None()
                                        Pic13None()
                                        Pic14None()
                                        Pic15None()
                                        Pic16None()
                                        Pic17None()
                                        Pic18None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheA9SouthMovementArea()
        i = 1
        If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox19Color()
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                Pic19None()
                PictureboxAbleToBlock(i) = 19
                CheckPicturebox28Color()
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                    Pic19None()
                    Pic28None()
                    PictureboxAbleToBlock(i) = 19
                    i = i + 1
                    PictureboxAbleToBlock(i) = 28
                    CheckPicturebox37Color()
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                        Pic19None()
                        Pic28None()
                        Pic37None()
                        PictureboxAbleToBlock(i) = 19
                        i = i + 1
                        PictureboxAbleToBlock(i) = 28
                        i = i + 1
                        PictureboxAbleToBlock(i) = 37
                        CheckPicturebox46Color()
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                            Pic19None()
                            Pic28None()
                            Pic37None()
                            Pic46None()
                            PictureboxAbleToBlock(i) = 19
                            i = i + 1
                            PictureboxAbleToBlock(i) = 28
                            i = i + 1
                            PictureboxAbleToBlock(i) = 37
                            i = i + 1
                            PictureboxAbleToBlock(i) = 46
                            CheckPicturebox55Color()
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                Pic19None()
                                Pic28None()
                                Pic37None()
                                Pic46None()
                                Pic55None()
                                PictureboxAbleToBlock(i) = 19
                                i = i + 1
                                PictureboxAbleToBlock(i) = 28
                                i = i + 1
                                PictureboxAbleToBlock(i) = 37
                                i = i + 1
                                PictureboxAbleToBlock(i) = 46
                                i = i + 1
                                PictureboxAbleToBlock(i) = 55
                                CheckPicturebox64Color()
                                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                    Pic19None()
                                    Pic28None()
                                    Pic37None()
                                    Pic46None()
                                    Pic55None()
                                    Pic64None()
                                    PictureboxAbleToBlock(i) = 19
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 28
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 37
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 46
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 55
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 64
                                    CheckPicturebox73Color()
                                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                        Pic19None()
                                        Pic28None()
                                        Pic37None()
                                        Pic46None()
                                        Pic55None()
                                        Pic64None()
                                        Pic73None()
                                        PictureboxAbleToBlock(i) = 19
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 28
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 37
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 46
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 55
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 64
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 73
                                        CheckPicturebox82Color()
                                    Else
                                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                                        Pic19None()
                                        Pic28None()
                                        Pic37None()
                                        Pic46None()
                                        Pic55None()
                                        Pic64None()
                                        Pic73None()
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

    Public Sub CheA9NorthMovementArea()
        If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox1Color()
        Else
            Form1.PictureBox1.Image = Form1.movementAreaPic.Image
            Pic1None()
        End If
    End Sub

    Public Sub CheB9EastMovementArea()
        i = 1
        If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox12Color()
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                Pic12None()
                PictureboxAbleToBlock(i) = 12
                CheckPicturebox13Color()
                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                    Pic12None()
                    Pic13None()
                    PictureboxAbleToBlock(i) = 12
                    i = i + 1
                    PictureboxAbleToBlock(i) = 13
                    CheckPicturebox14Color()
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                        Pic12None()
                        Pic13None()
                        Pic14None()
                        PictureboxAbleToBlock(i) = 12
                        i = i + 1
                        PictureboxAbleToBlock(i) = 13
                        i = i + 1
                        PictureboxAbleToBlock(i) = 14
                        CheckPicturebox15Color()
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                            Pic12None()
                            Pic13None()
                            Pic14None()
                            Pic15None()
                            PictureboxAbleToBlock(i) = 12
                            i = i + 1
                            PictureboxAbleToBlock(i) = 13
                            i = i + 1
                            PictureboxAbleToBlock(i) = 14
                            i = i + 1
                            PictureboxAbleToBlock(i) = 15
                            CheckPicturebox16Color()
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                Pic12None()
                                Pic13None()
                                Pic14None()
                                Pic15None()
                                Pic16None()
                                PictureboxAbleToBlock(i) = 12
                                i = i + 1
                                PictureboxAbleToBlock(i) = 13
                                i = i + 1
                                PictureboxAbleToBlock(i) = 14
                                i = i + 1
                                PictureboxAbleToBlock(i) = 15
                                i = i + 1
                                PictureboxAbleToBlock(i) = 16
                                CheckPicturebox17Color()
                                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                    Pic12None()
                                    Pic13None()
                                    Pic14None()
                                    Pic15None()
                                    Pic16None()
                                    Pic17None()
                                    PictureboxAbleToBlock(i) = 12
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 13
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 14
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 15
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 16
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 17
                                    CheckPicturebox18Color()
                                Else
                                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                    Pic12None()
                                    Pic13None()
                                    Pic14None()
                                    Pic15None()
                                    Pic16None()
                                    Pic17None()
                                    Pic18None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Public Sub CheB9SouthMovementArea()
        i = 1
        If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox20Color()
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                Pic20None()
                PictureboxAbleToBlock(i) = 20
                CheckPicturebox29Color()
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                    Pic20None()
                    Pic29None()
                    PictureboxAbleToBlock(i) = 20
                    i = i + 1
                    PictureboxAbleToBlock(i) = 29
                    CheckPicturebox38Color()
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                        Pic20None()
                        Pic29None()
                        Pic38None()
                        PictureboxAbleToBlock(i) = 20
                        i = i + 1
                        PictureboxAbleToBlock(i) = 29
                        i = i + 1
                        PictureboxAbleToBlock(i) = 38
                        CheckPicturebox47Color()
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                            Pic20None()
                            Pic29None()
                            Pic38None()
                            Pic47None()
                            PictureboxAbleToBlock(i) = 20
                            i = i + 1
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 47
                            CheckPicturebox56Color()
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                Pic20None()
                                Pic29None()
                                Pic38None()
                                Pic47None()
                                Pic56None()
                                PictureboxAbleToBlock(i) = 20
                                i = i + 1
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 56
                                CheckPicturebox65Color()
                                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                    Pic20None()
                                    Pic29None()
                                    Pic38None()
                                    Pic47None()
                                    Pic56None()
                                    Pic65None()
                                    PictureboxAbleToBlock(i) = 20
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 29
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 38
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 47
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 56
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 65
                                    CheckPicturebox74Color()
                                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                        Pic20None()
                                        Pic29None()
                                        Pic38None()
                                        Pic47None()
                                        Pic56None()
                                        Pic65None()
                                        Pic74None()
                                        PictureboxAbleToBlock(i) = 20
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 29
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 38
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 47
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 56
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 65
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 74
                                        CheckPicturebox83Color()
                                    Else
                                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                        Pic20None()
                                        Pic29None()
                                        Pic38None()
                                        Pic47None()
                                        Pic56None()
                                        Pic65None()
                                        Pic74None()
                                        Pic83None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB9WestMovementArea()
        If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox10Color()
        Else
            Form1.PictureBox10.Image = Form1.movementAreaPic.Image
            Pic10None()
        End If
    End Sub

    Public Sub CheB9NorthMovementArea()
        If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox2Color()
        Else
            Form1.PictureBox2.Image = Form1.movementAreaPic.Image
            Pic2None()
        End If
    End Sub

    Public Sub CheC9EastMovementArea()
        i = 1
        If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox13Color()
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                Pic13None()
                PictureboxAbleToBlock(i) = 13
                CheckPicturebox14Color()
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    Pic13None()
                    Pic14None()
                    PictureboxAbleToBlock(i) = 13
                    i = i + 1
                    PictureboxAbleToBlock(i) = 14
                    CheckPicturebox15Color()
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                        Pic13None()
                        Pic14None()
                        Pic15None()
                        PictureboxAbleToBlock(i) = 13
                        i = i + 1
                        PictureboxAbleToBlock(i) = 14
                        i = i + 1
                        PictureboxAbleToBlock(i) = 15
                        CheckPicturebox16Color()
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                            Pic13None()
                            Pic14None()
                            Pic15None()
                            Pic16None()
                            PictureboxAbleToBlock(i) = 13
                            i = i + 1
                            PictureboxAbleToBlock(i) = 14
                            i = i + 1
                            PictureboxAbleToBlock(i) = 15
                            i = i + 1
                            PictureboxAbleToBlock(i) = 16
                            CheckPicturebox17Color()
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                Pic13None()
                                Pic14None()
                                Pic15None()
                                Pic16None()
                                Pic17None()
                                PictureboxAbleToBlock(i) = 13
                                i = i + 1
                                PictureboxAbleToBlock(i) = 14
                                i = i + 1
                                PictureboxAbleToBlock(i) = 15
                                i = i + 1
                                PictureboxAbleToBlock(i) = 16
                                i = i + 1
                                PictureboxAbleToBlock(i) = 17
                                CheckPicturebox18Color()
                            Else
                                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                Pic13None()
                                Pic14None()
                                Pic15None()
                                Pic16None()
                                Pic17None()
                                Pic18None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC9SouthMovementArea()
        i = 1
        If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox21Color()
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                Pic21None()
                PictureboxAbleToBlock(i) = 21
                CheckPicturebox30Color()
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                    Pic21None()
                    Pic30None()
                    PictureboxAbleToBlock(i) = 21
                    i = i + 1
                    PictureboxAbleToBlock(i) = 30
                    CheckPicturebox39Color()
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                        Pic21None()
                        Pic30None()
                        Pic39None()
                        PictureboxAbleToBlock(i) = 21
                        i = i + 1
                        PictureboxAbleToBlock(i) = 30
                        i = i + 1
                        PictureboxAbleToBlock(i) = 39
                        CheckPicturebox48Color()
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Pic21None()
                            Pic30None()
                            Pic39None()
                            Pic48None()
                            PictureboxAbleToBlock(i) = 21
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            CheckPicturebox57Color()
                            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                Pic21None()
                                Pic30None()
                                Pic39None()
                                Pic48None()
                                Pic57None()
                                PictureboxAbleToBlock(i) = 21
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                CheckPicturebox66Color()
                                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                    Pic21None()
                                    Pic30None()
                                    Pic39None()
                                    Pic48None()
                                    Pic57None()
                                    Pic66None()
                                    PictureboxAbleToBlock(i) = 21
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 30
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    CheckPicturebox75Color()
                                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                        Pic21None()
                                        Pic30None()
                                        Pic39None()
                                        Pic48None()
                                        Pic57None()
                                        Pic66None()
                                        Pic75None()
                                        PictureboxAbleToBlock(i) = 21
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 30
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 39
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 48
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 57
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 66
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 75
                                        CheckPicturebox84Color()
                                    Else
                                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                        Pic21None()
                                        Pic30None()
                                        Pic39None()
                                        Pic48None()
                                        Pic57None()
                                        Pic66None()
                                        Pic75None()
                                        Pic84None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC9WestMovementArea()
        i = 1
        If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox11Color()
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                Pic11None()
                PictureboxAbleToBlock(i) = 11
                CheckPicturebox10Color()
            Else
                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                Pic11None()
                Pic10None()
            End If
        End If
    End Sub

    Public Sub CheC9NorthMovementArea()
        If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox3Color()
        Else
            Form1.PictureBox3.Image = Form1.movementAreaPic.Image
            Pic3None()
        End If
    End Sub

    Public Sub CheD9EastMovementArea()
        i = 1
        If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox14Color()
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
                PictureboxAbleToBlock(i) = 14
                CheckPicturebox15Color()
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    Pic14None()
                    Pic15None()
                    PictureboxAbleToBlock(i) = 14
                    i = i + 1
                    PictureboxAbleToBlock(i) = 15
                    CheckPicturebox16Color()
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                        Pic14None()
                        Pic15None()
                        Pic16None()
                        PictureboxAbleToBlock(i) = 14
                        i = i + 1
                        PictureboxAbleToBlock(i) = 15
                        i = i + 1
                        PictureboxAbleToBlock(i) = 16
                        CheckPicturebox17Color()
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                            Pic14None()
                            Pic15None()
                            Pic16None()
                            Pic17None()
                            PictureboxAbleToBlock(i) = 14
                            i = i + 1
                            PictureboxAbleToBlock(i) = 15
                            i = i + 1
                            PictureboxAbleToBlock(i) = 16
                            i = i + 1
                            PictureboxAbleToBlock(i) = 17
                            CheckPicturebox18Color()
                        Else
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                            Pic14None()
                            Pic15None()
                            Pic16None()
                            Pic17None()
                            Pic18None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD9SouthMovementArea()
        i = 1
        If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox22Color()
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                Pic22None()
                PictureboxAbleToBlock(i) = 22
                CheckPicturebox31Color()
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    Pic22None()
                    Pic31None()
                    PictureboxAbleToBlock(i) = 22
                    i = i + 1
                    PictureboxAbleToBlock(i) = 31
                    CheckPicturebox40Color()
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Pic22None()
                        Pic31None()
                        Pic40None()
                        PictureboxAbleToBlock(i) = 22
                        i = i + 1
                        PictureboxAbleToBlock(i) = 31
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        CheckPicturebox49Color()
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Pic22None()
                            Pic31None()
                            Pic40None()
                            Pic49None()
                            PictureboxAbleToBlock(i) = 22
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            CheckPicturebox58Color()
                            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                Pic22None()
                                Pic31None()
                                Pic40None()
                                Pic49None()
                                Pic58None()
                                PictureboxAbleToBlock(i) = 22
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                CheckPicturebox67Color()
                                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                    Pic22None()
                                    Pic31None()
                                    Pic40None()
                                    Pic49None()
                                    Pic58None()
                                    Pic67None()
                                    PictureboxAbleToBlock(i) = 22
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    CheckPicturebox76Color()
                                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                        Pic22None()
                                        Pic31None()
                                        Pic40None()
                                        Pic49None()
                                        Pic58None()
                                        Pic67None()
                                        Pic76None()
                                        PictureboxAbleToBlock(i) = 22
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 31
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 40
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 49
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 58
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 67
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 76
                                        CheckPicturebox85Color()
                                    Else
                                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                        Pic22None()
                                        Pic31None()
                                        Pic40None()
                                        Pic49None()
                                        Pic58None()
                                        Pic67None()
                                        Pic76None()
                                        Pic85None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD9WestMovementArea()
        i = 1
        If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox12Color()
            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                Pic12None()
                PictureboxAbleToBlock(i) = 12
                CheckPicturebox11Color()
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                    Pic12None()
                    Pic11None()
                    PictureboxAbleToBlock(i) = 12
                    i = i + 1
                    PictureboxAbleToBlock(i) = 11
                    CheckPicturebox10Color()
                Else
                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                    Pic12None()
                    Pic11None()
                    Pic10None()
                End If
            End If
        End If
    End Sub

    Public Sub CheD9NorthMovementArea()
        If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox4Color()
        Else
            Form1.PictureBox4.Image = Form1.movementAreaPic.Image
            Pic4None()
        End If
    End Sub

    Public Sub CheE9EastMovementArea()
        i = 1
        If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox15Color()
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Pic15None()
                PictureboxAbleToBlock(i) = 15
                CheckPicturebox16Color()
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    Pic15None()
                    Pic16None()
                    PictureboxAbleToBlock(i) = 15
                    i = i + 1
                    PictureboxAbleToBlock(i) = 16
                    CheckPicturebox17Color()
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                        Pic15None()
                        Pic16None()
                        Pic17None()
                        PictureboxAbleToBlock(i) = 15
                        i = i + 1
                        PictureboxAbleToBlock(i) = 16
                        i = i + 1
                        PictureboxAbleToBlock(i) = 17
                        CheckPicturebox18Color()
                    Else
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                        Pic15None()
                        Pic16None()
                        Pic17None()
                        Pic18None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE9SouthMovementArea()
        i = 1
        If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox23Color()
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
                PictureboxAbleToBlock(i) = 23
                CheckPicturebox32Color()
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    Pic23None()
                    Pic32None()
                    PictureboxAbleToBlock(i) = 23
                    i = i + 1
                    PictureboxAbleToBlock(i) = 32
                    CheckPicturebox41Color()
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Pic23None()
                        Pic32None()
                        Pic41None()
                        PictureboxAbleToBlock(i) = 23
                        i = i + 1
                        PictureboxAbleToBlock(i) = 32
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        CheckPicturebox50Color()
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                            Pic23None()
                            Pic32None()
                            Pic41None()
                            Pic50None()
                            PictureboxAbleToBlock(i) = 23
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            CheckPicturebox59Color()
                            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox68 IsNot Form1.nonePic.Image Then
                                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                Pic23None()
                                Pic32None()
                                Pic41None()
                                Pic50None()
                                Pic59None()
                                PictureboxAbleToBlock(i) = 23
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                CheckPicturebox68Color()
                                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox77 IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                    Pic23None()
                                    Pic32None()
                                    Pic41None()
                                    Pic50None()
                                    Pic59None()
                                    Pic68None()
                                    PictureboxAbleToBlock(i) = 23
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    CheckPicturebox77Color()
                                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                        Pic23None()
                                        Pic32None()
                                        Pic41None()
                                        Pic50None()
                                        Pic59None()
                                        Pic68None()
                                        Pic77None()
                                        PictureboxAbleToBlock(i) = 23
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 32
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 41
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 50
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 59
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 68
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 77
                                        CheckPicturebox86Color()
                                    Else
                                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                        Pic23None()
                                        Pic32None()
                                        Pic41None()
                                        Pic50None()
                                        Pic59None()
                                        Pic68None()
                                        Pic77None()
                                        Pic86None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE9WestMovementArea()
        i = 1
        If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox13Color()
            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                Pic13None()
                PictureboxAbleToBlock(i) = 13
                CheckPicturebox12Color()
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                    Pic13None()
                    Pic12None()
                    PictureboxAbleToBlock(i) = 13
                    i = i + 1
                    PictureboxAbleToBlock(i) = 12
                    CheckPicturebox11Color()
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                        Pic13None()
                        Pic12None()
                        Pic11None()
                        PictureboxAbleToBlock(i) = 13
                        i = i + 1
                        PictureboxAbleToBlock(i) = 12
                        i = i + 1
                        PictureboxAbleToBlock(i) = 11
                        CheckPicturebox10Color()
                    Else
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                        Pic13None()
                        Pic12None()
                        Pic11None()
                        Pic10None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE9NorthMovementArea()
        If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox5Color()
        Else
            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
            Pic5None()
        End If
    End Sub

    Public Sub CheF9EastMovementArea()
        i = 1
        If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox16Color()
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                Pic16None()
                PictureboxAbleToBlock(i) = 16
                CheckPicturebox17Color()
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    Pic16None()
                    Pic17None()
                    PictureboxAbleToBlock(i) = 16
                    i = i + 1
                    PictureboxAbleToBlock(i) = 17
                    CheckPicturebox18Color()
                Else
                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                    Pic16None()
                    Pic17None()
                    Pic18None()
                End If
            End If
        End If
    End Sub

    Public Sub CheF9SouthMovementArea()
        i = 1
        If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox24Color()
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
                PictureboxAbleToBlock(i) = 24
                CheckPicturebox33Color()
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    Pic24None()
                    Pic33None()
                    PictureboxAbleToBlock(i) = 24
                    i = i + 1
                    PictureboxAbleToBlock(i) = 33
                    CheckPicturebox42Color()
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Pic24None()
                        Pic33None()
                        Pic42None()
                        PictureboxAbleToBlock(i) = 24
                        i = i + 1
                        PictureboxAbleToBlock(i) = 33
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        CheckPicturebox51Color()
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Pic24None()
                            Pic33None()
                            Pic42None()
                            Pic51None()
                            PictureboxAbleToBlock(i) = 24
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            CheckPicturebox60Color()
                            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                Pic24None()
                                Pic33None()
                                Pic42None()
                                Pic51None()
                                Pic60None()
                                PictureboxAbleToBlock(i) = 24
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                CheckPicturebox69Color()
                                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                    Pic24None()
                                    Pic33None()
                                    Pic42None()
                                    Pic51None()
                                    Pic60None()
                                    Pic69None()
                                    PictureboxAbleToBlock(i) = 24
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    CheckPicturebox78Color()
                                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                        Pic24None()
                                        Pic33None()
                                        Pic42None()
                                        Pic51None()
                                        Pic60None()
                                        Pic69None()
                                        Pic78None()
                                        PictureboxAbleToBlock(i) = 24
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 33
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 42
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 51
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 60
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 69
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 78
                                        CheckPicturebox87Color()
                                    Else
                                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                        Pic24None()
                                        Pic33None()
                                        Pic42None()
                                        Pic51None()
                                        Pic60None()
                                        Pic69None()
                                        Pic78None()
                                        Pic87None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF9WestMovementArea()
        i = 1
        If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox14Color()
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
                PictureboxAbleToBlock(i) = 14
                CheckPicturebox13Color()
                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                    Pic14None()
                    Pic13None()
                    PictureboxAbleToBlock(i) = 14
                    i = i + 1
                    PictureboxAbleToBlock(i) = 13
                    CheckPicturebox12Color()
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                        Pic14None()
                        Pic13None()
                        Pic12None()
                        PictureboxAbleToBlock(i) = 14
                        i = i + 1
                        PictureboxAbleToBlock(i) = 13
                        i = i + 1
                        PictureboxAbleToBlock(i) = 12
                        CheckPicturebox11Color()
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                            Pic14None()
                            Pic13None()
                            Pic12None()
                            Pic11None()
                            PictureboxAbleToBlock(i) = 14
                            i = i + 1
                            PictureboxAbleToBlock(i) = 13
                            i = i + 1
                            PictureboxAbleToBlock(i) = 12
                            i = i + 1
                            PictureboxAbleToBlock(i) = 11
                            CheckPicturebox10Color()
                        Else
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                            Pic14None()
                            Pic13None()
                            Pic12None()
                            Pic11None()
                            Pic10None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF9NorthMovementArea()
        If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox6Color()
        Else
            Form1.PictureBox6.Image = Form1.movementAreaPic.Image
            Pic6None()
        End If
    End Sub

    Public Sub CheG9EastMovementArea()
        i = 1
        If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox17Color()
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                Pic17None()
                PictureboxAbleToBlock(i) = 17
                CheckPicturebox18Color()
            Else
                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                Pic17None()
                Pic18None()
            End If
        End If
    End Sub

    Public Sub CheG9SouthMovementArea()
        i = 1
        If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox25Color()
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                Pic25None()
                PictureboxAbleToBlock(i) = 25
                CheckPicturebox34Color()
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    Pic25None()
                    Pic34None()
                    PictureboxAbleToBlock(i) = 25
                    i = i + 1
                    PictureboxAbleToBlock(i) = 34
                    CheckPicturebox43Color()
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                        Pic25None()
                        Pic34None()
                        Pic43None()
                        PictureboxAbleToBlock(i) = 25
                        i = i + 1
                        PictureboxAbleToBlock(i) = 34
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                        CheckPicturebox52Color()
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Pic25None()
                            Pic34None()
                            Pic43None()
                            Pic52None()
                            PictureboxAbleToBlock(i) = 25
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            CheckPicturebox61Color()
                            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                Pic25None()
                                Pic34None()
                                Pic43None()
                                Pic52None()
                                Pic61None()
                                PictureboxAbleToBlock(i) = 25
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                CheckPicturebox70Color()
                                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                    Pic25None()
                                    Pic34None()
                                    Pic43None()
                                    Pic52None()
                                    Pic61None()
                                    Pic70None()
                                    PictureboxAbleToBlock(i) = 25
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 70
                                    CheckPicturebox79Color()
                                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                        Pic25None()
                                        Pic34None()
                                        Pic43None()
                                        Pic52None()
                                        Pic61None()
                                        Pic70None()
                                        Pic79None()
                                        PictureboxAbleToBlock(i) = 25
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 34
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 43
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 52
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 61
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 70
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 79
                                        CheckPicturebox88Color()
                                    Else
                                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                        Pic25None()
                                        Pic34None()
                                        Pic43None()
                                        Pic52None()
                                        Pic61None()
                                        Pic70None()
                                        Pic79None()
                                        Pic88None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG9WestMovementArea()
        i = 1
        If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox15Color()
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Pic15None()
                PictureboxAbleToBlock(i) = 15
                CheckPicturebox14Color()
                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    Pic15None()
                    Pic14None()
                    PictureboxAbleToBlock(i) = 15
                    i = i + 1
                    PictureboxAbleToBlock(i) = 14
                    CheckPicturebox13Color()
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                        Pic15None()
                        Pic14None()
                        Pic13None()
                        PictureboxAbleToBlock(i) = 15
                        i = i + 1
                        PictureboxAbleToBlock(i) = 14
                        i = i + 1
                        PictureboxAbleToBlock(i) = 13
                        CheckPicturebox12Color()
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                            Pic15None()
                            Pic14None()
                            Pic13None()
                            Pic12None()
                            PictureboxAbleToBlock(i) = 15
                            i = i + 1
                            PictureboxAbleToBlock(i) = 14
                            i = i + 1
                            PictureboxAbleToBlock(i) = 13
                            i = i + 1
                            PictureboxAbleToBlock(i) = 12
                            CheckPicturebox11Color()
                            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                Pic15None()
                                Pic14None()
                                Pic13None()
                                Pic12None()
                                Pic11None()
                                PictureboxAbleToBlock(i) = 15
                                i = i + 1
                                PictureboxAbleToBlock(i) = 14
                                i = i + 1
                                PictureboxAbleToBlock(i) = 13
                                i = i + 1
                                PictureboxAbleToBlock(i) = 12
                                i = i + 1
                                PictureboxAbleToBlock(i) = 11
                                CheckPicturebox10Color()
                            Else
                                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                Pic15None()
                                Pic14None()
                                Pic13None()
                                Pic12None()
                                Pic11None()
                                Pic10None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheG9NorthMovementArea()
        If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox7Color()
        Else
            Form1.PictureBox7.Image = Form1.movementAreaPic.Image
            Pic7None()
        End If
    End Sub

    Public Sub CheH9EastMovementArea()
        If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox18Color()
        Else
            Form1.PictureBox18.Image = Form1.movementAreaPic.Image
            Pic18None()
        End If
    End Sub

    Public Sub CheH9SouthMovementArea()
        i = 1
        If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox26Color()
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
                PictureboxAbleToBlock(i) = 26
                CheckPicturebox35Color()
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    Pic26None()
                    Pic35None()
                    PictureboxAbleToBlock(i) = 26
                    i = i + 1
                    PictureboxAbleToBlock(i) = 35
                    CheckPicturebox44Color()
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                        Pic26None()
                        Pic35None()
                        Pic44None()
                        PictureboxAbleToBlock(i) = 26
                        i = i + 1
                        PictureboxAbleToBlock(i) = 35
                        i = i + 1
                        PictureboxAbleToBlock(i) = 44
                        CheckPicturebox53Color()
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                            Pic26None()
                            Pic35None()
                            Pic44None()
                            Pic53None()
                            PictureboxAbleToBlock(i) = 26
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 53
                            CheckPicturebox62Color()
                            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                Pic26None()
                                Pic35None()
                                Pic44None()
                                Pic53None()
                                Pic62None()
                                PictureboxAbleToBlock(i) = 26
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 62
                                CheckPicturebox71Color()
                                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                    Pic26None()
                                    Pic35None()
                                    Pic44None()
                                    Pic53None()
                                    Pic62None()
                                    Pic71None()
                                    PictureboxAbleToBlock(i) = 26
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 35
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 71
                                    CheckPicturebox80Color()
                                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                        Pic26None()
                                        Pic35None()
                                        Pic44None()
                                        Pic53None()
                                        Pic62None()
                                        Pic71None()
                                        Pic80None()
                                        PictureboxAbleToBlock(i) = 26
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 35
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 44
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 53
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 62
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 71
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 80
                                        CheckPicturebox89Color()
                                    Else
                                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                        Pic26None()
                                        Pic35None()
                                        Pic44None()
                                        Pic53None()
                                        Pic62None()
                                        Pic71None()
                                        Pic80None()
                                        Pic89None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH9WestMovementArea()
        i = 1
        If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox16Color()
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                Pic16None()
                PictureboxAbleToBlock(i) = 16
                CheckPicturebox15Color()
                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    Pic16None()
                    Pic15None()
                    PictureboxAbleToBlock(i) = 16
                    i = i + 1
                    PictureboxAbleToBlock(i) = 15
                    CheckPicturebox14Color()
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                        Pic16None()
                        Pic15None()
                        Pic14None()
                        PictureboxAbleToBlock(i) = 16
                        i = i + 1
                        PictureboxAbleToBlock(i) = 15
                        i = i + 1
                        PictureboxAbleToBlock(i) = 14
                        CheckPicturebox13Color()
                        Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                            Pic16None()
                            Pic15None()
                            Pic14None()
                            Pic13None()
                            PictureboxAbleToBlock(i) = 16
                            i = i + 1
                            PictureboxAbleToBlock(i) = 15
                            i = i + 1
                            PictureboxAbleToBlock(i) = 14
                            i = i + 1
                            PictureboxAbleToBlock(i) = 13
                            CheckPicturebox12Color()
                            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                Pic16None()
                                Pic15None()
                                Pic14None()
                                Pic13None()
                                Pic12None()
                                PictureboxAbleToBlock(i) = 16
                                i = i + 1
                                PictureboxAbleToBlock(i) = 15
                                i = i + 1
                                PictureboxAbleToBlock(i) = 14
                                i = i + 1
                                PictureboxAbleToBlock(i) = 13
                                i = i + 1
                                PictureboxAbleToBlock(i) = 12
                                CheckPicturebox11Color()
                                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                    Pic16None()
                                    Pic15None()
                                    Pic14None()
                                    Pic13None()
                                    Pic12None()
                                    Pic11None()
                                    PictureboxAbleToBlock(i) = 16
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 15
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 14
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 13
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 12
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 11
                                    CheckPicturebox10Color()
                                Else
                                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                    Pic16None()
                                    Pic15None()
                                    Pic14None()
                                    Pic13None()
                                    Pic12None()
                                    Pic11None()
                                    Pic10None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH9NorthMovementArea()
        If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox8Color()
        Else
            Form1.PictureBox8.Image = Form1.movementAreaPic.Image
            Pic8None()
        End If
    End Sub

    Public Sub CheI9SouthMovementArea()
        i = 1
        If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox27Color()
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                Pic27None()
                PictureboxAbleToBlock(i) = 27
                CheckPicturebox36Color()
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    Pic27None()
                    Pic36None()
                    PictureboxAbleToBlock(i) = 27
                    i = i + 1
                    PictureboxAbleToBlock(i) = 36
                    CheckPicturebox45Color()
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                        Pic27None()
                        Pic36None()
                        Pic45None()
                        PictureboxAbleToBlock(i) = 27
                        i = i + 1
                        PictureboxAbleToBlock(i) = 36
                        i = i + 1
                        PictureboxAbleToBlock(i) = 45
                        CheckPicturebox54Color()
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                            Pic27None()
                            Pic36None()
                            Pic45None()
                            Pic54None()
                            PictureboxAbleToBlock(i) = 27
                            i = i + 1
                            PictureboxAbleToBlock(i) = 36
                            i = i + 1
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 54
                            CheckPicturebox63Color()
                            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                Pic27None()
                                Pic36None()
                                Pic45None()
                                Pic54None()
                                Pic63None()
                                PictureboxAbleToBlock(i) = 27
                                i = i + 1
                                PictureboxAbleToBlock(i) = 36
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 63
                                CheckPicturebox72Color()
                                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                    Pic27None()
                                    Pic36None()
                                    Pic45None()
                                    Pic54None()
                                    Pic63None()
                                    Pic72None()
                                    PictureboxAbleToBlock(i) = 27
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 36
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 45
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 54
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 63
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 72
                                    CheckPicturebox81Color()
                                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                        Pic27None()
                                        Pic36None()
                                        Pic45None()
                                        Pic54None()
                                        Pic63None()
                                        Pic72None()
                                        Pic81None()
                                        PictureboxAbleToBlock(i) = 27
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 36
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 45
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 54
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 63
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 72
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 81
                                        CheckPicturebox90Color()
                                    Else
                                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                                        Pic27None()
                                        Pic36None()
                                        Pic45None()
                                        Pic54None()
                                        Pic63None()
                                        Pic72None()
                                        Pic81None()
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

    Public Sub CheI9WestMovementArea()
        i = 1
        If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox17Color()
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                Pic17None()
                PictureboxAbleToBlock(i) = 17
                CheckPicturebox16Color()
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    Pic17None()
                    Pic16None()
                    PictureboxAbleToBlock(i) = 17
                    i = i + 1
                    PictureboxAbleToBlock(i) = 16
                    CheckPicturebox15Color()
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                        Pic17None()
                        Pic16None()
                        Pic15None()
                        PictureboxAbleToBlock(i) = 17
                        i = i + 1
                        PictureboxAbleToBlock(i) = 16
                        i = i + 1
                        PictureboxAbleToBlock(i) = 15
                        CheckPicturebox14Color()
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Pic17None()
                            Pic16None()
                            Pic15None()
                            Pic14None()
                            PictureboxAbleToBlock(i) = 17
                            i = i + 1
                            PictureboxAbleToBlock(i) = 16
                            i = i + 1
                            PictureboxAbleToBlock(i) = 15
                            i = i + 1
                            PictureboxAbleToBlock(i) = 14
                            CheckPicturebox13Color()
                            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                Pic17None()
                                Pic16None()
                                Pic15None()
                                Pic14None()
                                Pic13None()
                                PictureboxAbleToBlock(i) = 17
                                i = i + 1
                                PictureboxAbleToBlock(i) = 16
                                i = i + 1
                                PictureboxAbleToBlock(i) = 15
                                i = i + 1
                                PictureboxAbleToBlock(i) = 14
                                i = i + 1
                                PictureboxAbleToBlock(i) = 13
                                CheckPicturebox12Color()
                                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                    Pic17None()
                                    Pic16None()
                                    Pic15None()
                                    Pic14None()
                                    Pic13None()
                                    Pic12None()
                                    PictureboxAbleToBlock(i) = 17
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 16
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 15
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 14
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 13
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 12
                                    CheckPicturebox11Color()
                                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                        Pic17None()
                                        Pic16None()
                                        Pic15None()
                                        Pic14None()
                                        Pic13None()
                                        Pic12None()
                                        Pic11None()
                                        PictureboxAbleToBlock(i) = 17
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 16
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 15
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 14
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 13
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 12
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 11
                                        CheckPicturebox10Color()
                                    Else
                                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                        Pic17None()
                                        Pic16None()
                                        Pic15None()
                                        Pic14None()
                                        Pic13None()
                                        Pic12None()
                                        Pic11None()
                                        Pic10None()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI9NorthMovementArea()
        If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox9Color()
        Else
            Form1.PictureBox9.Image = Form1.movementAreaPic.Image
            Pic9None()
        End If
    End Sub

    Public Sub CheA10EastMovementArea()
        i = 1
        If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox2Color()
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                Pic2None()
                PictureboxAbleToBlock(i) = 2
                CheckPicturebox3Color()
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                    Pic2None()
                    Pic3None()
                    PictureboxAbleToBlock(i) = 2
                    i = i + 1
                    PictureboxAbleToBlock(i) = 3
                    CheckPicturebox4Color()
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                        Pic2None()
                        Pic3None()
                        Pic4None()
                        PictureboxAbleToBlock(i) = 2
                        i = i + 1
                        PictureboxAbleToBlock(i) = 3
                        i = i + 1
                        PictureboxAbleToBlock(i) = 4
                        CheckPicturebox5Color()
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                            Pic2None()
                            Pic3None()
                            Pic4None()
                            Pic5None()
                            PictureboxAbleToBlock(i) = 2
                            i = i + 1
                            PictureboxAbleToBlock(i) = 3
                            i = i + 1
                            PictureboxAbleToBlock(i) = 4
                            i = i + 1
                            PictureboxAbleToBlock(i) = 5
                            CheckPicturebox6Color()
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                Pic2None()
                                Pic3None()
                                Pic4None()
                                Pic5None()
                                Pic6None()
                                PictureboxAbleToBlock(i) = 2
                                i = i + 1
                                PictureboxAbleToBlock(i) = 3
                                i = i + 1
                                PictureboxAbleToBlock(i) = 4
                                i = i + 1
                                PictureboxAbleToBlock(i) = 5
                                i = i + 1
                                PictureboxAbleToBlock(i) = 6
                                CheckPicturebox7Color()
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                    Pic2None()
                                    Pic3None()
                                    Pic4None()
                                    Pic5None()
                                    Pic6None()
                                    Pic7None()
                                    PictureboxAbleToBlock(i) = 2
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 3
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 4
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 5
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 6
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 7
                                    CheckPicturebox8Color()
                                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                        Pic2None()
                                        Pic3None()
                                        Pic4None()
                                        Pic5None()
                                        Pic6None()
                                        Pic7None()
                                        Pic8None()
                                        PictureboxAbleToBlock(i) = 2
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 3
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 4
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 5
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 6
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 7
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 8
                                        CheckPicturebox9Color()
                                    Else
                                        Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                                        Pic2None()
                                        Pic3None()
                                        Pic4None()
                                        Pic5None()
                                        Pic6None()
                                        Pic7None()
                                        Pic8None()
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

    Public Sub CheA10SouthMovementArea()
        i = 1
        If Form1.PictureBox10.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox10Color()
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox19.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                Pic10None()
                PictureboxAbleToBlock(i) = 10
                CheckPicturebox19Color()
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox28.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                    Pic10None()
                    Pic19None()
                    PictureboxAbleToBlock(i) = 10
                    i = i + 1
                    PictureboxAbleToBlock(i) = 19
                    CheckPicturebox28Color()
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox37.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                        Pic10None()
                        Pic19None()
                        Pic28None()
                        PictureboxAbleToBlock(i) = 10
                        i = i + 1
                        PictureboxAbleToBlock(i) = 19
                        i = i + 1
                        PictureboxAbleToBlock(i) = 28
                        CheckPicturebox37Color()
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox46.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                            Pic10None()
                            Pic19None()
                            Pic28None()
                            Pic37None()
                            PictureboxAbleToBlock(i) = 10
                            i = i + 1
                            PictureboxAbleToBlock(i) = 19
                            i = i + 1
                            PictureboxAbleToBlock(i) = 28
                            i = i + 1
                            PictureboxAbleToBlock(i) = 37
                            CheckPicturebox46Color()
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox55.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                Pic10None()
                                Pic19None()
                                Pic28None()
                                Pic37None()
                                Pic46None()
                                PictureboxAbleToBlock(i) = 10
                                i = i + 1
                                PictureboxAbleToBlock(i) = 19
                                i = i + 1
                                PictureboxAbleToBlock(i) = 28
                                i = i + 1
                                PictureboxAbleToBlock(i) = 37
                                i = i + 1
                                PictureboxAbleToBlock(i) = 46
                                CheckPicturebox55Color()
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox64.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                    Pic10None()
                                    Pic19None()
                                    Pic28None()
                                    Pic37None()
                                    Pic46None()
                                    Pic55None()
                                    PictureboxAbleToBlock(i) = 10
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 19
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 28
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 37
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 46
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 55
                                    CheckPicturebox64Color()
                                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox73.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                        Pic10None()
                                        Pic19None()
                                        Pic28None()
                                        Pic37None()
                                        Pic46None()
                                        Pic55None()
                                        Pic64None()
                                        PictureboxAbleToBlock(i) = 10
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 19
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 28
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 37
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 46
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 55
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 64
                                        CheckPicturebox73Color()
                                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox82.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                            Pic10None()
                                            Pic19None()
                                            Pic28None()
                                            Pic37None()
                                            Pic46None()
                                            Pic55None()
                                            Pic64None()
                                            Pic73None()
                                            PictureboxAbleToBlock(i) = 10
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 19
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 28
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 37
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 46
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 55
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 64
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 73
                                            CheckPicturebox82Color()
                                        Else
                                            Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                                            Pic10None()
                                            Pic19None()
                                            Pic28None()
                                            Pic37None()
                                            Pic46None()
                                            Pic55None()
                                            Pic64None()
                                            Pic73None()
                                            Pic82None()
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

    Public Sub CheB10EastMovementArea()
        i = 1
        If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox3Color()
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                Pic3None()
                PictureboxAbleToBlock(i) = 3
                CheckPicturebox4Color()
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                    Pic3None()
                    Pic4None()
                    PictureboxAbleToBlock(i) = 3
                    i = i + 1
                    PictureboxAbleToBlock(i) = 4
                    CheckPicturebox5Color()
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                        Pic3None()
                        Pic4None()
                        Pic5None()
                        PictureboxAbleToBlock(i) = 3
                        i = i + 1
                        PictureboxAbleToBlock(i) = 4
                        i = i + 1
                        PictureboxAbleToBlock(i) = 5
                        CheckPicturebox6Color()
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                            Pic3None()
                            Pic4None()
                            Pic5None()
                            Pic6None()
                            PictureboxAbleToBlock(i) = 3
                            i = i + 1
                            PictureboxAbleToBlock(i) = 4
                            i = i + 1
                            PictureboxAbleToBlock(i) = 5
                            i = i + 1
                            PictureboxAbleToBlock(i) = 6
                            CheckPicturebox7Color()
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                Pic3None()
                                Pic4None()
                                Pic5None()
                                Pic6None()
                                Pic7None()
                                PictureboxAbleToBlock(i) = 3
                                i = i + 1
                                PictureboxAbleToBlock(i) = 4
                                i = i + 1
                                PictureboxAbleToBlock(i) = 5
                                i = i + 1
                                PictureboxAbleToBlock(i) = 6
                                i = i + 1
                                PictureboxAbleToBlock(i) = 7
                                CheckPicturebox8Color()
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                    Pic3None()
                                    Pic4None()
                                    Pic5None()
                                    Pic6None()
                                    Pic7None()
                                    Pic8None()
                                    PictureboxAbleToBlock(i) = 3
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 4
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 5
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 6
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 7
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 8
                                    CheckPicturebox9Color()
                                Else
                                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                                    Pic3None()
                                    Pic4None()
                                    Pic5None()
                                    Pic6None()
                                    Pic7None()
                                    Pic8None()
                                    Pic9None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheB10SouthMovementArea()
        i = 1
        If Form1.PictureBox11.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox11Color()
            Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox20.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                Pic11None()
                PictureboxAbleToBlock(i) = 11
                CheckPicturebox20Color()
                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox29.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                    Pic11None()
                    Pic20None()
                    PictureboxAbleToBlock(i) = 11
                    i = i + 1
                    PictureboxAbleToBlock(i) = 20
                    CheckPicturebox29Color()
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox38.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                        Pic11None()
                        Pic20None()
                        Pic29None()
                        PictureboxAbleToBlock(i) = 11
                        i = i + 1
                        PictureboxAbleToBlock(i) = 20
                        i = i + 1
                        PictureboxAbleToBlock(i) = 29
                        CheckPicturebox38Color()
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox47.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                            Pic11None()
                            Pic20None()
                            Pic29None()
                            Pic38None()
                            PictureboxAbleToBlock(i) = 11
                            i = i + 1
                            PictureboxAbleToBlock(i) = 20
                            i = i + 1
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 38
                            CheckPicturebox47Color()
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox56.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Pic11None()
                                Pic20None()
                                Pic29None()
                                Pic38None()
                                Pic47None()
                                PictureboxAbleToBlock(i) = 11
                                i = i + 1
                                PictureboxAbleToBlock(i) = 20
                                i = i + 1
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 47
                                CheckPicturebox56Color()
                                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox65.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                    Pic11None()
                                    Pic20None()
                                    Pic29None()
                                    Pic38None()
                                    Pic47None()
                                    Pic56None()
                                    PictureboxAbleToBlock(i) = 11
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 20
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 29
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 38
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 47
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 56
                                    CheckPicturebox65Color()
                                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox74.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                        Pic11None()
                                        Pic20None()
                                        Pic29None()
                                        Pic38None()
                                        Pic47None()
                                        Pic56None()
                                        Pic65None()
                                        PictureboxAbleToBlock(i) = 11
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 20
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 29
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 38
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 47
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 56
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 65
                                        CheckPicturebox74Color()
                                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox83.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                            Pic11None()
                                            Pic20None()
                                            Pic29None()
                                            Pic38None()
                                            Pic47None()
                                            Pic56None()
                                            Pic65None()
                                            Pic74None()
                                            PictureboxAbleToBlock(i) = 11
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 20
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 29
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 38
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 47
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 56
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 65
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 74
                                            CheckPicturebox83Color()
                                        Else
                                            Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                                            Pic11None()
                                            Pic20None()
                                            Pic29None()
                                            Pic38None()
                                            Pic47None()
                                            Pic56None()
                                            Pic65None()
                                            Pic74None()
                                            Pic83None()
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

    Public Sub CheB10WestMovementArea()
        If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox1Color()
        Else
            Form1.PictureBox1.Image = Form1.movementAreaPic.Image
            Pic1None()
        End If
    End Sub

    Public Sub CheC10EastMovementArea()
        i = 1
        If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox4Color()
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                Pic4None()
                PictureboxAbleToBlock(i) = 4
                CheckPicturebox5Color()
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                    Pic4None()
                    Pic5None()
                    PictureboxAbleToBlock(i) = 4
                    i = i + 1
                    PictureboxAbleToBlock(i) = 5
                    CheckPicturebox6Color()
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                        Pic4None()
                        Pic5None()
                        Pic6None()
                        PictureboxAbleToBlock(i) = 4
                        i = i + 1
                        PictureboxAbleToBlock(i) = 5
                        i = i + 1
                        PictureboxAbleToBlock(i) = 6
                        CheckPicturebox7Color()
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                            Pic4None()
                            Pic5None()
                            Pic6None()
                            Pic7None()
                            PictureboxAbleToBlock(i) = 4
                            i = i + 1
                            PictureboxAbleToBlock(i) = 5
                            i = i + 1
                            PictureboxAbleToBlock(i) = 6
                            i = i + 1
                            PictureboxAbleToBlock(i) = 7
                            CheckPicturebox8Color()
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                Pic4None()
                                Pic5None()
                                Pic6None()
                                Pic7None()
                                Pic8None()
                                PictureboxAbleToBlock(i) = 4
                                i = i + 1
                                PictureboxAbleToBlock(i) = 5
                                i = i + 1
                                PictureboxAbleToBlock(i) = 6
                                i = i + 1
                                PictureboxAbleToBlock(i) = 7
                                i = i + 1
                                PictureboxAbleToBlock(i) = 8
                                CheckPicturebox9Color()
                            Else
                                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                                Pic4None()
                                Pic5None()
                                Pic6None()
                                Pic7None()
                                Pic8None()
                                Pic9None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheC10SouthMovementArea()
        i = 1
        If Form1.PictureBox12.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox12Color()
            Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox21.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                Pic12None()
                PictureboxAbleToBlock(i) = 12
                CheckPicturebox21Color()
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox30.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                    Pic12None()
                    Pic21None()
                    PictureboxAbleToBlock(i) = 12
                    i = i + 1
                    PictureboxAbleToBlock(i) = 21
                    CheckPicturebox30Color()
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox39.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                        Pic12None()
                        Pic21None()
                        Pic30None()
                        PictureboxAbleToBlock(i) = 12
                        i = i + 1
                        PictureboxAbleToBlock(i) = 21
                        i = i + 1
                        PictureboxAbleToBlock(i) = 30
                        CheckPicturebox39Color()
                        Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox48.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Pic12None()
                            Pic21None()
                            Pic30None()
                            Pic39None()
                            PictureboxAbleToBlock(i) = 12
                            i = i + 1
                            PictureboxAbleToBlock(i) = 21
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            CheckPicturebox48Color()
                            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox57.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Pic12None()
                                Pic21None()
                                Pic30None()
                                Pic39None()
                                Pic48None()
                                PictureboxAbleToBlock(i) = 12
                                i = i + 1
                                PictureboxAbleToBlock(i) = 21
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                CheckPicturebox57Color()
                                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox66.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                    Pic12None()
                                    Pic21None()
                                    Pic30None()
                                    Pic39None()
                                    Pic48None()
                                    Pic57None()
                                    PictureboxAbleToBlock(i) = 12
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 21
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 30
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    CheckPicturebox66Color()
                                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                        Pic12None()
                                        Pic21None()
                                        Pic30None()
                                        Pic39None()
                                        Pic48None()
                                        Pic57None()
                                        Pic66None()
                                        PictureboxAbleToBlock(i) = 12
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 21
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 30
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 39
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 48
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 57
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 66
                                        CheckPicturebox75Color()
                                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox84.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                            Pic12None()
                                            Pic21None()
                                            Pic30None()
                                            Pic39None()
                                            Pic48None()
                                            Pic57None()
                                            Pic66None()
                                            Pic75None()
                                            PictureboxAbleToBlock(i) = 12
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 21
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 30
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 39
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 48
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 57
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 66
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 75
                                            CheckPicturebox84Color()
                                        Else
                                            Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                                            Pic12None()
                                            Pic21None()
                                            Pic30None()
                                            Pic39None()
                                            Pic48None()
                                            Pic57None()
                                            Pic66None()
                                            Pic75None()
                                            Pic84None()
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

    Public Sub CheC10WestMovementArea()
        i = 1
        If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox2Color()
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                Pic2None()
                PictureboxAbleToBlock(i) = 2
                CheckPicturebox1Color()
            Else
                Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                Pic2None()
                Pic1None()
            End If
        End If
    End Sub

    Public Sub CheD10EastMovementArea()
        i = 1
        If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox5Color()
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                Pic5None()
                PictureboxAbleToBlock(i) = 5
                CheckPicturebox6Color()
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                    Pic5None()
                    Pic6None()
                    PictureboxAbleToBlock(i) = 5
                    i = i + 1
                    PictureboxAbleToBlock(i) = 6
                    CheckPicturebox7Color()
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                        Pic5None()
                        Pic6None()
                        Pic7None()
                        PictureboxAbleToBlock(i) = 5
                        i = i + 1
                        PictureboxAbleToBlock(i) = 6
                        i = i + 1
                        PictureboxAbleToBlock(i) = 7
                        CheckPicturebox8Color()
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                            Pic5None()
                            Pic6None()
                            Pic7None()
                            Pic8None()
                            PictureboxAbleToBlock(i) = 5
                            i = i + 1
                            PictureboxAbleToBlock(i) = 6
                            i = i + 1
                            PictureboxAbleToBlock(i) = 7
                            i = i + 1
                            PictureboxAbleToBlock(i) = 8
                            CheckPicturebox9Color()
                        Else
                            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                            Pic5None()
                            Pic6None()
                            Pic7None()
                            Pic8None()
                            Pic9None()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheD10SouthMovementArea()
        i = 1
        If Form1.PictureBox13.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox13Color()
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox22.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                Pic13None()
                PictureboxAbleToBlock(i) = 13
                CheckPicturebox22Color()
                Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox31.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    Pic13None()
                    Pic22None()
                    PictureboxAbleToBlock(i) = 13
                    i = i + 1
                    PictureboxAbleToBlock(i) = 22
                    CheckPicturebox31Color()
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox40.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                        Pic13None()
                        Pic22None()
                        Pic31None()
                        PictureboxAbleToBlock(i) = 13
                        i = i + 1
                        PictureboxAbleToBlock(i) = 22
                        i = i + 1
                        PictureboxAbleToBlock(i) = 31
                        CheckPicturebox40Color()
                        Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox49.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Pic13None()
                            Pic22None()
                            Pic31None()
                            Pic40None()
                            PictureboxAbleToBlock(i) = 13
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            CheckPicturebox49Color()
                            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox58.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                Pic13None()
                                Pic22None()
                                Pic31None()
                                Pic40None()
                                Pic49None()
                                PictureboxAbleToBlock(i) = 13
                                i = i + 1
                                PictureboxAbleToBlock(i) = 22
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                CheckPicturebox58Color()
                                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox67.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                    Pic13None()
                                    Pic22None()
                                    Pic31None()
                                    Pic40None()
                                    Pic49None()
                                    Pic58None()
                                    PictureboxAbleToBlock(i) = 13
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 22
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    CheckPicturebox67Color()
                                    Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox76.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                        Pic13None()
                                        Pic22None()
                                        Pic31None()
                                        Pic40None()
                                        Pic49None()
                                        Pic58None()
                                        Pic67None()
                                        PictureboxAbleToBlock(i) = 13
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 22
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 31
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 40
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 49
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 58
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 67
                                        CheckPicturebox76Color()
                                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox85.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                            Pic13None()
                                            Pic22None()
                                            Pic31None()
                                            Pic40None()
                                            Pic49None()
                                            Pic58None()
                                            Pic67None()
                                            Pic76None()
                                            PictureboxAbleToBlock(i) = 13
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 22
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 31
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 40
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 49
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 58
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 67
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 76
                                            CheckPicturebox85Color()
                                        Else
                                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                                            Pic13None()
                                            Pic22None()
                                            Pic31None()
                                            Pic40None()
                                            Pic49None()
                                            Pic58None()
                                            Pic67None()
                                            Pic76None()
                                            Pic85None()
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

    Public Sub CheD10WestMovementArea()
        i = 1
        If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox3Color()
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                Pic3None()
                PictureboxAbleToBlock(i) = 3
                CheckPicturebox2Color()
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                    Pic3None()
                    Pic2None()
                    PictureboxAbleToBlock(i) = 3
                    i = i + 1
                    PictureboxAbleToBlock(i) = 2
                    CheckPicturebox1Color()
                Else
                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                    Pic3None()
                    Pic2None()
                    Pic1None()
                End If
            End If
        End If
    End Sub

    Public Sub CheE10EastMovementArea()
        i = 1
        If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox6Color()
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                Pic6None()
                PictureboxAbleToBlock(i) = 6
                CheckPicturebox7Color()
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                    Pic6None()
                    Pic7None()
                    PictureboxAbleToBlock(i) = 6
                    i = i + 1
                    PictureboxAbleToBlock(i) = 7
                    CheckPicturebox8Color()
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                        Pic6None()
                        Pic7None()
                        Pic8None()
                        PictureboxAbleToBlock(i) = 6
                        i = i + 1
                        PictureboxAbleToBlock(i) = 7
                        i = i + 1
                        PictureboxAbleToBlock(i) = 8
                        CheckPicturebox9Color()
                    Else
                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                        Pic6None()
                        Pic7None()
                        Pic8None()
                        Pic9None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheE10SouthMovementArea()
        i = 1
        If Form1.PictureBox14.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox14Color()
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox23.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
                PictureboxAbleToBlock(i) = 14
                CheckPicturebox23Color()
                Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox32.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    Pic14None()
                    Pic23None()
                    PictureboxAbleToBlock(i) = 14
                    i = i + 1
                    PictureboxAbleToBlock(i) = 23
                    CheckPicturebox32Color()
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox41.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Pic14None()
                        Pic23None()
                        Pic32None()
                        PictureboxAbleToBlock(i) = 14
                        i = i + 1
                        PictureboxAbleToBlock(i) = 23
                        i = i + 1
                        PictureboxAbleToBlock(i) = 32
                        CheckPicturebox41Color()
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox50.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                            Pic14None()
                            Pic23None()
                            Pic32None()
                            Pic41None()
                            PictureboxAbleToBlock(i) = 14
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            CheckPicturebox50Color()
                            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox59.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                Pic14None()
                                Pic23None()
                                Pic32None()
                                Pic41None()
                                Pic50None()
                                PictureboxAbleToBlock(i) = 14
                                i = i + 1
                                PictureboxAbleToBlock(i) = 23
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                CheckPicturebox59Color()
                                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox68 IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                    Pic14None()
                                    Pic23None()
                                    Pic32None()
                                    Pic41None()
                                    Pic50None()
                                    Pic59None()
                                    PictureboxAbleToBlock(i) = 14
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 23
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    CheckPicturebox68Color()
                                    Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox77 IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                        Pic14None()
                                        Pic23None()
                                        Pic32None()
                                        Pic41None()
                                        Pic50None()
                                        Pic59None()
                                        Pic68None()
                                        PictureboxAbleToBlock(i) = 14
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 23
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 32
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 41
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 50
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 59
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 68
                                        CheckPicturebox77Color()
                                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox86.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                            Pic14None()
                                            Pic23None()
                                            Pic32None()
                                            Pic41None()
                                            Pic50None()
                                            Pic59None()
                                            Pic68None()
                                            Pic77None()
                                            PictureboxAbleToBlock(i) = 14
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 23
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 32
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 41
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 50
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 59
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 68
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 77
                                            CheckPicturebox86Color()
                                        Else
                                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                                            Pic14None()
                                            Pic23None()
                                            Pic32None()
                                            Pic41None()
                                            Pic50None()
                                            Pic59None()
                                            Pic68None()
                                            Pic77None()
                                            Pic86None()
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

    Public Sub CheE10WestMovementArea()
        i = 1
        If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox4Color()
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                Pic4None()
                PictureboxAbleToBlock(i) = 4
                CheckPicturebox3Color()
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                    Pic4None()
                    Pic3None()
                    PictureboxAbleToBlock(i) = 4
                    i = i + 1
                    PictureboxAbleToBlock(i) = 3
                    CheckPicturebox2Color()
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                        Pic4None()
                        Pic3None()
                        Pic2None()
                        PictureboxAbleToBlock(i) = 4
                        i = i + 1
                        PictureboxAbleToBlock(i) = 3
                        i = i + 1
                        PictureboxAbleToBlock(i) = 2
                        CheckPicturebox1Color()
                    Else
                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                        Pic4None()
                        Pic3None()
                        Pic2None()
                        Pic1None()
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheF10EastMovementArea()
        i = 1
        If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox7Color()
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                Pic7None()
                PictureboxAbleToBlock(i) = 7
                CheckPicturebox8Color()
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                    Pic7None()
                    Pic8None()
                    PictureboxAbleToBlock(i) = 7
                    i = i + 1
                    PictureboxAbleToBlock(i) = 8
                    CheckPicturebox9Color()
                Else
                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                    Pic7None()
                    Pic8None()
                    Pic9None()
                End If
            End If
        End If
    End Sub

    Public Sub CheF10SouthMovementArea()
        i = 1
        If Form1.PictureBox15.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox15Color()
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox24.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Pic15None()
                PictureboxAbleToBlock(i) = 15
                CheckPicturebox24Color()
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox33.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    Pic15None()
                    Pic24None()
                    PictureboxAbleToBlock(i) = 15
                    i = i + 1
                    PictureboxAbleToBlock(i) = 24
                    CheckPicturebox33Color()
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox42.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Pic15None()
                        Pic24None()
                        Pic33None()
                        PictureboxAbleToBlock(i) = 15
                        i = i + 1
                        PictureboxAbleToBlock(i) = 24
                        i = i + 1
                        PictureboxAbleToBlock(i) = 33
                        CheckPicturebox42Color()
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox51.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Pic15None()
                            Pic24None()
                            Pic33None()
                            Pic42None()
                            PictureboxAbleToBlock(i) = 15
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            CheckPicturebox51Color()
                            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox60.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                Pic15None()
                                Pic24None()
                                Pic33None()
                                Pic42None()
                                Pic51None()
                                PictureboxAbleToBlock(i) = 15
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                CheckPicturebox60Color()
                                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox69.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                    Pic15None()
                                    Pic24None()
                                    Pic33None()
                                    Pic42None()
                                    Pic51None()
                                    Pic60None()
                                    PictureboxAbleToBlock(i) = 15
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 24
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    CheckPicturebox69Color()
                                    Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox78.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                        Pic15None()
                                        Pic24None()
                                        Pic33None()
                                        Pic42None()
                                        Pic51None()
                                        Pic60None()
                                        Pic69None()
                                        PictureboxAbleToBlock(i) = 15
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 24
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 33
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 42
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 51
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 60
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 69
                                        CheckPicturebox78Color()
                                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox87.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                            Pic15None()
                                            Pic24None()
                                            Pic33None()
                                            Pic42None()
                                            Pic51None()
                                            Pic60None()
                                            Pic69None()
                                            Pic78None()
                                            PictureboxAbleToBlock(i) = 15
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 24
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 33
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 42
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 51
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 60
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 69
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 78
                                            CheckPicturebox87Color()
                                        Else
                                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                                            Pic15None()
                                            Pic24None()
                                            Pic33None()
                                            Pic42None()
                                            Pic51None()
                                            Pic60None()
                                            Pic69None()
                                            Pic78None()
                                            Pic87None()
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

    Public Sub CheF10WestMovementArea()
        i = 1
        If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox5Color()
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                Pic5None()
                PictureboxAbleToBlock(i) = 5
                CheckPicturebox4Color()
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                    Pic5None()
                    Pic4None()
                    PictureboxAbleToBlock(i) = 5
                    i = i + 1
                    PictureboxAbleToBlock(i) = 4
                    CheckPicturebox3Color()
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                        Pic5None()
                        Pic4None()
                        Pic3None()
                        PictureboxAbleToBlock(i) = 5
                        i = i + 1
                        PictureboxAbleToBlock(i) = 4
                        i = i + 1
                        PictureboxAbleToBlock(i) = 3
                        CheckPicturebox2Color()
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                            Pic5None()
                            Pic4None()
                            Pic3None()
                            Pic2None()
                            PictureboxAbleToBlock(i) = 5
                            i = i + 1
                            PictureboxAbleToBlock(i) = 4
                            i = i + 1
                            PictureboxAbleToBlock(i) = 3
                            i = i + 1
                            PictureboxAbleToBlock(i) = 2
                            CheckPicturebox1Color()
                        Else
                            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                            Pic5None()
                            Pic4None()
                            Pic3None()
                            Pic2None()
                            Pic1None()
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Public Sub CheG10EastMovementArea()
        i = 1
        If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox8Color()
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                Pic8None()
                PictureboxAbleToBlock(i) = 8
                CheckPicturebox9Color()
            Else
                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                Pic8None()
                Pic9None()
            End If
        End If
    End Sub

    Public Sub CheG10SouthMovementArea()
        i = 1
        If Form1.PictureBox16.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox16Color()
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox25.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                Pic16None()
                PictureboxAbleToBlock(i) = 16
                CheckPicturebox25Color()
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox34.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    Pic16None()
                    Pic25None()
                    PictureboxAbleToBlock(i) = 16
                    i = i + 1
                    PictureboxAbleToBlock(i) = 25
                    CheckPicturebox34Color()
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox43.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                        Pic16None()
                        Pic25None()
                        Pic34None()
                        PictureboxAbleToBlock(i) = 16
                        i = i + 1
                        PictureboxAbleToBlock(i) = 25
                        i = i + 1
                        PictureboxAbleToBlock(i) = 34
                        CheckPicturebox43Color()
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox52.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Pic16None()
                            Pic25None()
                            Pic34None()
                            Pic43None()
                            PictureboxAbleToBlock(i) = 16
                            i = i + 1
                            PictureboxAbleToBlock(i) = 25
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            CheckPicturebox52Color()
                            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox61.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Pic16None()
                                Pic25None()
                                Pic34None()
                                Pic43None()
                                Pic52None()
                                PictureboxAbleToBlock(i) = 16
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                CheckPicturebox61Color()
                                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox70.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                    Pic16None()
                                    Pic25None()
                                    Pic34None()
                                    Pic43None()
                                    Pic52None()
                                    Pic61None()
                                    PictureboxAbleToBlock(i) = 16
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 25
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    CheckPicturebox70Color()
                                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox79.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                        Pic16None()
                                        Pic25None()
                                        Pic34None()
                                        Pic43None()
                                        Pic52None()
                                        Pic61None()
                                        Pic70None()
                                        PictureboxAbleToBlock(i) = 16
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 25
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 34
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 43
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 52
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 61
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 70
                                        CheckPicturebox79Color()
                                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox88.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                            Pic16None()
                                            Pic25None()
                                            Pic34None()
                                            Pic43None()
                                            Pic52None()
                                            Pic61None()
                                            Pic70None()
                                            Pic79None()
                                            PictureboxAbleToBlock(i) = 16
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 25
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 34
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 43
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 52
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 61
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 70
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 79
                                            CheckPicturebox88Color()
                                        Else
                                            Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                                            Pic16None()
                                            Pic25None()
                                            Pic34None()
                                            Pic43None()
                                            Pic52None()
                                            Pic61None()
                                            Pic70None()
                                            Pic79None()
                                            Pic88None()
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

    Public Sub CheG10WestMovementArea()
        i = 1
        If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox6Color()
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                Pic6None()
                PictureboxAbleToBlock(i) = 6
                CheckPicturebox5Color()
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                    Pic6None()
                    Pic5None()
                    PictureboxAbleToBlock(i) = 6
                    i = i + 1
                    PictureboxAbleToBlock(i) = 5
                    CheckPicturebox4Color()
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                        Pic6None()
                        Pic5None()
                        Pic4None()
                        PictureboxAbleToBlock(i) = 6
                        i = i + 1
                        PictureboxAbleToBlock(i) = 5
                        i = i + 1
                        PictureboxAbleToBlock(i) = 4
                        CheckPicturebox3Color()
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                            Pic6None()
                            Pic5None()
                            Pic4None()
                            Pic3None()
                            PictureboxAbleToBlock(i) = 6
                            i = i + 1
                            PictureboxAbleToBlock(i) = 5
                            i = i + 1
                            PictureboxAbleToBlock(i) = 4
                            i = i + 1
                            PictureboxAbleToBlock(i) = 3
                            CheckPicturebox2Color()
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                Pic6None()
                                Pic5None()
                                Pic4None()
                                Pic3None()
                                Pic2None()
                                PictureboxAbleToBlock(i) = 6
                                i = i + 1
                                PictureboxAbleToBlock(i) = 5
                                i = i + 1
                                PictureboxAbleToBlock(i) = 4
                                i = i + 1
                                PictureboxAbleToBlock(i) = 3
                                i = i + 1
                                PictureboxAbleToBlock(i) = 2
                                CheckPicturebox1Color()
                            Else
                                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                                Pic6None()
                                Pic5None()
                                Pic4None()
                                Pic3None()
                                Pic2None()
                                Pic1None()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheH10EastMovementArea()
        If Form1.PictureBox9.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox9Color()
        Else
            Form1.PictureBox9.Image = Form1.movementAreaPic.Image
            Pic9None()
        End If
    End Sub

    Public Sub CheH10SouthMovementArea()
        i = 1
        If Form1.PictureBox17.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox17Color()
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox26.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                Pic17None()
                PictureboxAbleToBlock(i) = 17
                CheckPicturebox26Color()
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox35.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    Pic17None()
                    Pic26None()
                    PictureboxAbleToBlock(i) = 17
                    i = i + 1
                    PictureboxAbleToBlock(i) = 26
                    CheckPicturebox35Color()
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox44.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                        Pic17None()
                        Pic26None()
                        Pic35None()
                        PictureboxAbleToBlock(i) = 17
                        i = i + 1
                        PictureboxAbleToBlock(i) = 26
                        i = i + 1
                        PictureboxAbleToBlock(i) = 35
                        CheckPicturebox44Color()
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox53.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                            Pic17None()
                            Pic26None()
                            Pic35None()
                            Pic44None()
                            PictureboxAbleToBlock(i) = 17
                            i = i + 1
                            PictureboxAbleToBlock(i) = 26
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                            CheckPicturebox53Color()
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox62.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Pic17None()
                                Pic26None()
                                Pic35None()
                                Pic44None()
                                Pic53None()
                                PictureboxAbleToBlock(i) = 17
                                i = i + 1
                                PictureboxAbleToBlock(i) = 26
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                                CheckPicturebox62Color()
                                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox71.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                    Pic17None()
                                    Pic26None()
                                    Pic35None()
                                    Pic44None()
                                    Pic53None()
                                    Pic62None()
                                    PictureboxAbleToBlock(i) = 17
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 26
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 35
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 62
                                    CheckPicturebox71Color()
                                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox80.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                        Pic17None()
                                        Pic26None()
                                        Pic35None()
                                        Pic44None()
                                        Pic53None()
                                        Pic62None()
                                        Pic71None()
                                        PictureboxAbleToBlock(i) = 17
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 26
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 35
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 44
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 53
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 62
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 71
                                        CheckPicturebox80Color()
                                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox89.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                            Pic17None()
                                            Pic26None()
                                            Pic35None()
                                            Pic44None()
                                            Pic53None()
                                            Pic62None()
                                            Pic71None()
                                            Pic80None()
                                            PictureboxAbleToBlock(i) = 17
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 26
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 35
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 44
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 53
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 62
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 71
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 80
                                            CheckPicturebox89Color()
                                        Else
                                            Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                                            Pic17None()
                                            Pic26None()
                                            Pic35None()
                                            Pic44None()
                                            Pic53None()
                                            Pic62None()
                                            Pic71None()
                                            Pic80None()
                                            Pic89None()
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

    Public Sub CheH10WestMovementArea()
        i = 1
        If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox7Color()
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                Pic7None()
                PictureboxAbleToBlock(i) = 7
                CheckPicturebox6Color()
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                    Pic7None()
                    Pic6None()
                    PictureboxAbleToBlock(i) = 7
                    i = i + 1
                    PictureboxAbleToBlock(i) = 6
                    CheckPicturebox5Color()
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                        Pic7None()
                        Pic6None()
                        Pic5None()
                        PictureboxAbleToBlock(i) = 7
                        i = i + 1
                        PictureboxAbleToBlock(i) = 6
                        i = i + 1
                        PictureboxAbleToBlock(i) = 5
                        CheckPicturebox4Color()
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                            Pic7None()
                            Pic6None()
                            Pic5None()
                            Pic4None()
                            PictureboxAbleToBlock(i) = 7
                            i = i + 1
                            PictureboxAbleToBlock(i) = 6
                            i = i + 1
                            PictureboxAbleToBlock(i) = 5
                            i = i + 1
                            PictureboxAbleToBlock(i) = 4
                            CheckPicturebox3Color()
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                Pic7None()
                                Pic6None()
                                Pic5None()
                                Pic4None()
                                Pic3None()
                                PictureboxAbleToBlock(i) = 7
                                i = i + 1
                                PictureboxAbleToBlock(i) = 6
                                i = i + 1
                                PictureboxAbleToBlock(i) = 5
                                i = i + 1
                                PictureboxAbleToBlock(i) = 4
                                i = i + 1
                                PictureboxAbleToBlock(i) = 3
                                CheckPicturebox2Color()
                                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                    Pic7None()
                                    Pic6None()
                                    Pic5None()
                                    Pic4None()
                                    Pic3None()
                                    Pic2None()
                                    PictureboxAbleToBlock(i) = 7
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 6
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 5
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 4
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 3
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 2
                                    CheckPicturebox1Color()
                                Else
                                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                                    Pic7None()
                                    Pic6None()
                                    Pic5None()
                                    Pic4None()
                                    Pic3None()
                                    Pic2None()
                                    Pic1None()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CheI10SouthMovementArea()
        i = 1
        If Form1.PictureBox18.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox18Color()
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox27.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                Pic18None()
                PictureboxAbleToBlock(i) = 18
                CheckPicturebox27Color()
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox36.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                    Pic18None()
                    Pic27None()
                    PictureboxAbleToBlock(i) = 18
                    i = i + 1
                    PictureboxAbleToBlock(i) = 27
                    CheckPicturebox36Color()
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox45.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                        Pic18None()
                        Pic27None()
                        Pic36None()
                        PictureboxAbleToBlock(i) = 18
                        i = i + 1
                        PictureboxAbleToBlock(i) = 27
                        i = i + 1
                        PictureboxAbleToBlock(i) = 36
                        CheckPicturebox45Color()
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox54.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                            Pic18None()
                            Pic27None()
                            Pic36None()
                            Pic45None()
                            PictureboxAbleToBlock(i) = 18
                            i = i + 1
                            PictureboxAbleToBlock(i) = 27
                            i = i + 1
                            PictureboxAbleToBlock(i) = 36
                            i = i + 1
                            PictureboxAbleToBlock(i) = 45
                            CheckPicturebox54Color()
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox63.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                Pic18None()
                                Pic27None()
                                Pic36None()
                                Pic45None()
                                Pic54None()
                                PictureboxAbleToBlock(i) = 18
                                i = i + 1
                                PictureboxAbleToBlock(i) = 27
                                i = i + 1
                                PictureboxAbleToBlock(i) = 36
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 54
                                CheckPicturebox63Color()
                                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox72.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                    Pic18None()
                                    Pic27None()
                                    Pic36None()
                                    Pic45None()
                                    Pic54None()
                                    Pic63None()
                                    PictureboxAbleToBlock(i) = 18
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 27
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 36
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 45
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 54
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 63
                                    CheckPicturebox72Color()
                                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox81.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                        Pic18None()
                                        Pic27None()
                                        Pic36None()
                                        Pic45None()
                                        Pic54None()
                                        Pic63None()
                                        Pic72None()
                                        PictureboxAbleToBlock(i) = 18
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 27
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 36
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 45
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 54
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 63
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 72
                                        CheckPicturebox81Color()
                                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        If Form1.PictureBox90.Image IsNot Form1.nonePic.Image Then
                                            Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                            Pic18None()
                                            Pic27None()
                                            Pic36None()
                                            Pic45None()
                                            Pic54None()
                                            Pic63None()
                                            Pic72None()
                                            Pic81None()
                                            PictureboxAbleToBlock(i) = 18
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 27
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 36
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 45
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 54
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 63
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 72
                                            i = i + 1
                                            PictureboxAbleToBlock(i) = 81
                                            CheckPicturebox90Color()
                                        Else
                                            Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                                            Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                                            Pic18None()
                                            Pic27None()
                                            Pic36None()
                                            Pic45None()
                                            Pic54None()
                                            Pic63None()
                                            Pic72None()
                                            Pic81None()
                                            Pic90None()
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

    Public Sub CheI10WestMovementArea()
        i = 1
        If Form1.PictureBox8.Image IsNot Form1.nonePic.Image Then
            CheckPicturebox8Color()
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
        Else
            If Form1.PictureBox7.Image IsNot Form1.nonePic.Image Then
                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                Pic8None()
                PictureboxAbleToBlock(i) = 8
                CheckPicturebox7Color()
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            Else
                If Form1.PictureBox6.Image IsNot Form1.nonePic.Image Then
                    Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                    Pic8None()
                    Pic7None()
                    PictureboxAbleToBlock(i) = 8
                    i = i + 1
                    PictureboxAbleToBlock(i) = 7
                    CheckPicturebox6Color()
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                Else
                    If Form1.PictureBox5.Image IsNot Form1.nonePic.Image Then
                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                        Pic8None()
                        Pic7None()
                        Pic6None()
                        PictureboxAbleToBlock(i) = 8
                        i = i + 1
                        PictureboxAbleToBlock(i) = 7
                        i = i + 1
                        PictureboxAbleToBlock(i) = 6
                        CheckPicturebox5Color()
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    Else
                        If Form1.PictureBox4.Image IsNot Form1.nonePic.Image Then
                            Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                            Pic8None()
                            Pic7None()
                            Pic6None()
                            Pic5None()
                            PictureboxAbleToBlock(i) = 8
                            i = i + 1
                            PictureboxAbleToBlock(i) = 7
                            i = i + 1
                            PictureboxAbleToBlock(i) = 6
                            i = i + 1
                            PictureboxAbleToBlock(i) = 5
                            CheckPicturebox4Color()
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        Else
                            If Form1.PictureBox3.Image IsNot Form1.nonePic.Image Then
                                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                Pic8None()
                                Pic7None()
                                Pic6None()
                                Pic5None()
                                Pic4None()
                                PictureboxAbleToBlock(i) = 8
                                i = i + 1
                                PictureboxAbleToBlock(i) = 7
                                i = i + 1
                                PictureboxAbleToBlock(i) = 6
                                i = i + 1
                                PictureboxAbleToBlock(i) = 5
                                i = i + 1
                                PictureboxAbleToBlock(i) = 4
                                CheckPicturebox3Color()
                                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                            Else
                                If Form1.PictureBox2.Image IsNot Form1.nonePic.Image Then
                                    Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                    Pic8None()
                                    Pic7None()
                                    Pic6None()
                                    Pic5None()
                                    Pic4None()
                                    Pic3None()
                                    PictureboxAbleToBlock(i) = 8
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 7
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 6
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 5
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 4
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 3
                                    CheckPicturebox2Color()
                                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    If Form1.PictureBox1.Image IsNot Form1.nonePic.Image Then
                                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                        Pic8None()
                                        Pic7None()
                                        Pic6None()
                                        Pic5None()
                                        Pic4None()
                                        Pic3None()
                                        Pic2None()
                                        PictureboxAbleToBlock(i) = 8
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 7
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 6
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 5
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 4
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 3
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 2
                                        CheckPicturebox1Color()
                                    Else
                                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                        Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                                        Pic8None()
                                        Pic7None()
                                        Pic6None()
                                        Pic5None()
                                        Pic4None()
                                        Pic3None()
                                        Pic2None()
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
End Module
