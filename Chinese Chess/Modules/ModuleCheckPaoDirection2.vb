' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 17/01/2011
' Descriptions : Chinese Chess V1

Module ModuleCheckPaoDirection2
    Dim i As Integer

    Public Sub PaoF3EastMovementArea()
        i = 1
        If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
            Pic70None()
            If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
                If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                    Pic72None()
                Else
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox72Color()
                    PictureboxAbleToBlock(i) = 70
                End If
            End If
        Else
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox72Color()
                    PictureboxAbleToBlock(i) = 71
                End If
            Else
                CheckPicturebox71Color()
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoF3SouthMovementArea()
        i = 1
        If Form1.PictureBox78.Image Is Form1.nonePic.Image Then
            Form1.PictureBox78.Image = Form1.movementAreaPic.Image
            Pic78None()
            If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                Pic87None()
            Else
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            End If
        Else
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Else
                CheckPicturebox87Color()
            End If
        End If
    End Sub

    Public Sub PaoF3WestMovementArea()
        i = 1
        If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
            Pic68None()
            If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                Pic67None()
                If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                    Pic66None()
                    If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                        Pic65None()
                        If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                            Pic64None()
                        Else
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox64Color()
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                        End If
                    End If
                Else
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox64Color()
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 65
                        End If
                    Else
                        CheckPicturebox65Color()
                        PictureboxAbleToBlock(i) = 68
                        i = i + 1
                        PictureboxAbleToBlock(i) = 67
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox64Color()
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                            i = i + 1
                            PictureboxAbleToBlock(i) = 65
                        End If
                    Else
                        CheckPicturebox65Color()
                        PictureboxAbleToBlock(i) = 68
                        i = i + 1
                        PictureboxAbleToBlock(i) = 66
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox66Color()
                    PictureboxAbleToBlock(i) = 68
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox64Color()
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                            i = i + 1
                            PictureboxAbleToBlock(i) = 65
                        End If
                    Else
                        CheckPicturebox65Color()
                        PictureboxAbleToBlock(i) = 67
                        i = i + 1
                        PictureboxAbleToBlock(i) = 66
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox66Color()
                    PictureboxAbleToBlock(i) = 67
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox67Color()
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            End If
        End If

    End Sub

    Public Sub PaoF3NorthMovementArea()
        i = 1
        If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
            Pic60None()
            If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                Pic51None()
                If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    Pic42None()
                    If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                        Pic33None()
                        If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                            Pic24None()
                            If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                                Pic15None()
                                If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                    Pic6None()
                                Else
                                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox6Color()
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 24
                                End If
                            End If
                        Else
                            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox6Color()
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 15
                                End If
                            Else
                                CheckPicturebox15Color()
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox6Color()
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 24
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 15
                                End If
                            Else
                                CheckPicturebox15Color()
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox24Color()
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox6Color()
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 24
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 15
                                End If
                            Else
                                CheckPicturebox15Color()
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox24Color()
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox33Color()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox6Color()
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 24
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 15
                                End If
                            Else
                                CheckPicturebox15Color()
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox24Color()
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox33Color()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox42Color()
                    PictureboxAbleToBlock(i) = 60
                    Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox6Color()
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 24
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 15
                                End If
                            Else
                                CheckPicturebox15Color()
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox24Color()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox33Color()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox42Color()
                    PictureboxAbleToBlock(i) = 51
                    Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox51Color()
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoG3EastMovementArea()
        i = 1
        If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
            Pic71None()
            If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                Pic72None()
            Else
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            End If
        Else
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Else
                CheckPicturebox72Color()
            End If
        End If
    End Sub

    Public Sub PaoG3SouthMovementArea()
        i = 1
        If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
            Form1.PictureBox79.Image = Form1.movementAreaPic.Image
            Pic79None()
            If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                Pic88None()
            Else
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            End If
        Else
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Else
                CheckPicturebox88Color()
            End If
        End If
    End Sub

    Public Sub PaoG3WestMovementArea()
        i = 1
        If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
            Pic69None()
            If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
                If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                    Pic67None()
                    If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                        Pic66None()
                        If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                            Pic65None()
                            If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                Pic64None()
                            Else
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox64Color()
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                            End If
                        End If
                    Else
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox64Color()
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 65
                            End If
                        Else
                            CheckPicturebox65Color()
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox64Color()
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                                i = i + 1
                                PictureboxAbleToBlock(i) = 65
                            End If
                        Else
                            CheckPicturebox65Color()
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox66Color()
                        PictureboxAbleToBlock(i) = 69
                        i = i + 1
                        PictureboxAbleToBlock(i) = 68
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox64Color()
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                                i = i + 1
                                PictureboxAbleToBlock(i) = 65
                            End If
                        Else
                            CheckPicturebox65Color()
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox66Color()
                        PictureboxAbleToBlock(i) = 69
                        i = i + 1
                        PictureboxAbleToBlock(i) = 67
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox67Color()
                    PictureboxAbleToBlock(i) = 69
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox64Color()
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                                i = i + 1
                                PictureboxAbleToBlock(i) = 65
                            End If
                        Else
                            CheckPicturebox65Color()
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox66Color()
                        PictureboxAbleToBlock(i) = 68
                        i = i + 1
                        PictureboxAbleToBlock(i) = 67
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox67Color()
                    PictureboxAbleToBlock(i) = 68
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox68Color()
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoG3NorthMovementArea()
        i = 1
        If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
            Pic61None()
            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
                If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    Pic43None()
                    If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                        Pic34None()
                        If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                            Pic25None()
                            If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                                Pic16None()
                                If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                    Pic7None()
                                Else
                                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox7Color()
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 25
                                End If
                            End If
                        Else
                            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox7Color()
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 16
                                End If
                            Else
                                CheckPicturebox16Color()
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox7Color()
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 25
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 16
                                End If
                            Else
                                CheckPicturebox16Color()
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox25Color()
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox7Color()
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 25
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 16
                                End If
                            Else
                                CheckPicturebox16Color()
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox25Color()
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox34Color()
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 52
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox7Color()
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 25
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 16
                                End If
                            Else
                                CheckPicturebox16Color()
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox25Color()
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox34Color()
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox43Color()
                    PictureboxAbleToBlock(i) = 61
                    Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox7Color()
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 25
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 16
                                End If
                            Else
                                CheckPicturebox16Color()
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox25Color()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox34Color()
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox43Color()
                    PictureboxAbleToBlock(i) = 52
                    Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox52Color()
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoH3EastMovementArea()
        i = 1
        If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
            Form1.PictureBox72.Image = Form1.movementAreaPic.Image
            Pic72None()
        Else
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub PaoH3SouthMovementArea()
        i = 1
        If Form1.PictureBox80.Image Is Form1.nonePic.Image Then
            Form1.PictureBox80.Image = Form1.movementAreaPic.Image
            Pic80None()
            If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                Pic89None()
            Else
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            End If
        Else
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            Else
                CheckPicturebox89Color()
            End If
        End If
    End Sub

    Public Sub PaoH3WestMovementArea()
        i = 1
        If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
            Pic70None()
            If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
                If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    Pic68None()
                    If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                        Pic67None()
                        If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                            Pic66None()
                            If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                Pic65None()
                                If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                    Pic64None()
                                Else
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox64Color()
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                End If
                            End If
                        Else
                            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox64Color()
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 65
                                End If
                            Else
                                CheckPicturebox65Color()
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox64Color()
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 65
                                End If
                            Else
                                CheckPicturebox65Color()
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox66Color()
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox64Color()
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 65
                                End If
                            Else
                                CheckPicturebox65Color()
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox66Color()
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox67Color()
                        PictureboxAbleToBlock(i) = 70
                        i = i + 1
                        PictureboxAbleToBlock(i) = 69
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox64Color()
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 65
                                End If
                            Else
                                CheckPicturebox65Color()
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox66Color()
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox67Color()
                        PictureboxAbleToBlock(i) = 70
                        i = i + 1
                        PictureboxAbleToBlock(i) = 68
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox68Color()
                    PictureboxAbleToBlock(i) = 70
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox64Color()
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 65
                                End If
                            Else
                                CheckPicturebox65Color()
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                i = i + 1
                                PictureboxAbleToBlock(i) = 66
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox66Color()
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox67Color()
                        PictureboxAbleToBlock(i) = 69
                        i = i + 1
                        PictureboxAbleToBlock(i) = 68
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox68Color()
                    PictureboxAbleToBlock(i) = 69
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox69Color()
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoH3NorthMovementArea()
        i = 1
        If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
            Pic62None()
            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
                If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    Pic44None()
                    If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                        Pic35None()
                        If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                            Pic26None()
                            If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                                Pic17None()
                                If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                    Pic8None()
                                Else
                                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox8Color()
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 35
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 26
                                End If
                            End If
                        Else
                            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox8Color()
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 35
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 17
                                End If
                            Else
                                CheckPicturebox17Color()
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox8Color()
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 26
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 17
                                End If
                            Else
                                CheckPicturebox17Color()
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 26
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox26Color()
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox8Color()
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 35
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 26
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 17
                                End If
                            Else
                                CheckPicturebox17Color()
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                i = i + 1
                                PictureboxAbleToBlock(i) = 26
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox26Color()
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox35Color()
                        PictureboxAbleToBlock(i) = 62
                        i = i + 1
                        PictureboxAbleToBlock(i) = 53
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox8Color()
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 35
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 26
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 17
                                End If
                            Else
                                CheckPicturebox17Color()
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                i = i + 1
                                PictureboxAbleToBlock(i) = 26
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox26Color()
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox35Color()
                        PictureboxAbleToBlock(i) = 62
                        i = i + 1
                        PictureboxAbleToBlock(i) = 44
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox44Color()
                    PictureboxAbleToBlock(i) = 62
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox8Color()
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 35
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 26
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 17
                                End If
                            Else
                                CheckPicturebox17Color()
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                i = i + 1
                                PictureboxAbleToBlock(i) = 26
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox26Color()
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox35Color()
                        PictureboxAbleToBlock(i) = 53
                        i = i + 1
                        PictureboxAbleToBlock(i) = 44
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox44Color()
                    PictureboxAbleToBlock(i) = 53
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox53Color()
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoI3SouthMovementArea()
        i = 1
        If Form1.PictureBox81.Image Is Form1.nonePic.Image Then
            Form1.PictureBox81.Image = Form1.movementAreaPic.Image
            Pic81None()
            If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                Pic90None()
            Else
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            End If
        Else
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            Else
                CheckPicturebox90Color()
            End If
        End If
    End Sub

    Public Sub PaoI3WestMovementArea()
        i = 1
        If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
            Pic71None()
            If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
                If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    Pic69None()
                    If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                        Pic68None()
                        If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                            Pic67None()
                            If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                                Pic66None()
                                If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                                    Pic65None()
                                    If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                                        Pic64None()
                                    Else
                                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                    End If
                                Else
                                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox64Color()
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
                                    End If
                                End If
                            Else
                                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox64Color()
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
                                        PictureboxAbleToBlock(i) = 65
                                    End If
                                Else
                                    CheckPicturebox65Color()
                                    PictureboxAbleToBlock(i) = 71
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                End If
                            End If
                        Else
                            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox64Color()
                                        PictureboxAbleToBlock(i) = 71
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 70
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 69
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 68
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 66
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 65
                                    End If
                                Else
                                    CheckPicturebox65Color()
                                    PictureboxAbleToBlock(i) = 71
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox66Color()
                                PictureboxAbleToBlock(i) = 71
                                i = i + 1
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox64Color()
                                        PictureboxAbleToBlock(i) = 71
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 70
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 69
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 67
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 66
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 65
                                    End If
                                Else
                                    CheckPicturebox65Color()
                                    PictureboxAbleToBlock(i) = 71
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox66Color()
                                PictureboxAbleToBlock(i) = 71
                                i = i + 1
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox67Color()
                            PictureboxAbleToBlock(i) = 71
                            i = i + 1
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox64Color()
                                        PictureboxAbleToBlock(i) = 71
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 70
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 68
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 67
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 66
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 65
                                    End If
                                Else
                                    CheckPicturebox65Color()
                                    PictureboxAbleToBlock(i) = 71
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox66Color()
                                PictureboxAbleToBlock(i) = 71
                                i = i + 1
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox67Color()
                            PictureboxAbleToBlock(i) = 71
                            i = i + 1
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox68Color()
                        PictureboxAbleToBlock(i) = 71
                        i = i + 1
                        PictureboxAbleToBlock(i) = 70
                        Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox64Color()
                                        PictureboxAbleToBlock(i) = 71
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
                                    End If
                                Else
                                    CheckPicturebox65Color()
                                    PictureboxAbleToBlock(i) = 71
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox66Color()
                                PictureboxAbleToBlock(i) = 71
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox67Color()
                            PictureboxAbleToBlock(i) = 71
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox68Color()
                        PictureboxAbleToBlock(i) = 71
                        i = i + 1
                        PictureboxAbleToBlock(i) = 69
                        Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox69Color()
                    PictureboxAbleToBlock(i) = 71
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox64Color()
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
                                    End If
                                Else
                                    CheckPicturebox65Color()
                                    PictureboxAbleToBlock(i) = 70
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 69
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 68
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 67
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 66
                                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox66Color()
                                PictureboxAbleToBlock(i) = 70
                                i = i + 1
                                PictureboxAbleToBlock(i) = 69
                                i = i + 1
                                PictureboxAbleToBlock(i) = 68
                                i = i + 1
                                PictureboxAbleToBlock(i) = 67
                                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox67Color()
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox68Color()
                        PictureboxAbleToBlock(i) = 70
                        i = i + 1
                        PictureboxAbleToBlock(i) = 69
                        Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox69Color()
                    PictureboxAbleToBlock(i) = 70
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox70Color()
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoI3NorthMovementArea()
        i = 1
        If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
            Pic63None()
            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                Pic54None()
                If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    Pic45None()
                    If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                        Pic36None()
                        If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                            Pic27None()
                            If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                                Pic18None()
                                If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                                    Pic9None()
                                Else
                                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox9Color()
                                    PictureboxAbleToBlock(i) = 63
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 54
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 45
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 36
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 27
                                End If
                            End If
                        Else
                            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox9Color()
                                    PictureboxAbleToBlock(i) = 63
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 54
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 45
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 36
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 18
                                End If
                            Else
                                CheckPicturebox18Color()
                                PictureboxAbleToBlock(i) = 63
                                i = i + 1
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 36
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox9Color()
                                    PictureboxAbleToBlock(i) = 63
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 54
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 45
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 27
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 18
                                End If
                            Else
                                CheckPicturebox18Color()
                                PictureboxAbleToBlock(i) = 63
                                i = i + 1
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 27
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox27Color()
                            PictureboxAbleToBlock(i) = 63
                            i = i + 1
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 45
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox9Color()
                                    PictureboxAbleToBlock(i) = 63
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 54
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 36
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 27
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 18
                                End If
                            Else
                                CheckPicturebox18Color()
                                PictureboxAbleToBlock(i) = 63
                                i = i + 1
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 36
                                i = i + 1
                                PictureboxAbleToBlock(i) = 27
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox27Color()
                            PictureboxAbleToBlock(i) = 63
                            i = i + 1
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 36
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox36Color()
                        PictureboxAbleToBlock(i) = 63
                        i = i + 1
                        PictureboxAbleToBlock(i) = 54
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox9Color()
                                    PictureboxAbleToBlock(i) = 63
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 45
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 36
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 27
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 18
                                End If
                            Else
                                CheckPicturebox18Color()
                                PictureboxAbleToBlock(i) = 63
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 36
                                i = i + 1
                                PictureboxAbleToBlock(i) = 27
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox27Color()
                            PictureboxAbleToBlock(i) = 63
                            i = i + 1
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 36
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox36Color()
                        PictureboxAbleToBlock(i) = 63
                        i = i + 1
                        PictureboxAbleToBlock(i) = 45
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox45Color()
                    PictureboxAbleToBlock(i) = 63
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox9Color()
                                    PictureboxAbleToBlock(i) = 54
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 45
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 36
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 27
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 18
                                End If
                            Else
                                CheckPicturebox18Color()
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 36
                                i = i + 1
                                PictureboxAbleToBlock(i) = 27
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox27Color()
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 36
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox36Color()
                        PictureboxAbleToBlock(i) = 54
                        i = i + 1
                        PictureboxAbleToBlock(i) = 45
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox45Color()
                    PictureboxAbleToBlock(i) = 54
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox54Color()
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoA4EastMovementArea()
        i = 1
        If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
            Pic56None()
            If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                Pic57None()
                If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    Pic58None()
                    If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Pic59None()
                        If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                            Pic60None()
                            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                                Pic61None()
                                If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                    Pic62None()
                                    If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                        Pic63None()
                                    Else
                                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                    End If
                                Else
                                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox63Color()
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
                                    End If
                                End If
                            Else
                                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox63Color()
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
                                        PictureboxAbleToBlock(i) = 62
                                    End If
                                Else
                                    CheckPicturebox62Color()
                                    PictureboxAbleToBlock(i) = 56
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                End If
                            End If
                        Else
                            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox63Color()
                                        PictureboxAbleToBlock(i) = 56
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 57
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 58
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 59
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 61
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 62
                                    End If
                                Else
                                    CheckPicturebox62Color()
                                    PictureboxAbleToBlock(i) = 56
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox61Color()
                                PictureboxAbleToBlock(i) = 56
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox63Color()
                                        PictureboxAbleToBlock(i) = 56
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 57
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 58
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 60
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 61
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 62
                                    End If
                                Else
                                    CheckPicturebox62Color()
                                    PictureboxAbleToBlock(i) = 56
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox61Color()
                                PictureboxAbleToBlock(i) = 56
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox60Color()
                            PictureboxAbleToBlock(i) = 56
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox63Color()
                                        PictureboxAbleToBlock(i) = 56
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 57
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 59
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 60
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 61
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 62
                                    End If
                                Else
                                    CheckPicturebox62Color()
                                    PictureboxAbleToBlock(i) = 56
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox61Color()
                                PictureboxAbleToBlock(i) = 56
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox60Color()
                            PictureboxAbleToBlock(i) = 56
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox59Color()
                        PictureboxAbleToBlock(i) = 56
                        i = i + 1
                        PictureboxAbleToBlock(i) = 57
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox63Color()
                                        PictureboxAbleToBlock(i) = 56
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
                                    End If
                                Else
                                    CheckPicturebox62Color()
                                    PictureboxAbleToBlock(i) = 56
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox61Color()
                                PictureboxAbleToBlock(i) = 56
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox60Color()
                            PictureboxAbleToBlock(i) = 56
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox59Color()
                        PictureboxAbleToBlock(i) = 56
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox58Color()
                    PictureboxAbleToBlock(i) = 56
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox63Color()
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
                                    End If
                                Else
                                    CheckPicturebox62Color()
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox61Color()
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox60Color()
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox59Color()
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox58Color()
                    PictureboxAbleToBlock(i) = 57
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox57Color()
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoA4SouthMovementArea()
        i = 1
        If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
            Form1.PictureBox64.Image = Form1.movementAreaPic.Image
            Pic64None()
            If Form1.PictureBox73.Image Is Form1.nonePic.Image Then
                Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                Pic73None()
                If Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                    Pic82None()
                Else
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox82Color()
                    PictureboxAbleToBlock(i) = 64
                End If
            End If
        Else
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox73.Image Is Form1.nonePic.Image Then
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox82Color()
                    PictureboxAbleToBlock(i) = 73
                End If
            Else
                CheckPicturebox73Color()
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoA4NorthMovementArea()
        i = 1
        If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
            Pic46None()
            If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                Pic37None()
                If Form1.PictureBox28.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                    Pic28None()
                    If Form1.PictureBox19.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                        Pic19None()
                        If Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                            Pic10None()
                            If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                                Pic1None()
                            Else
                                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox1Color()
                                PictureboxAbleToBlock(i) = 46
                                i = i + 1
                                PictureboxAbleToBlock(i) = 37
                                i = i + 1
                                PictureboxAbleToBlock(i) = 28
                                i = i + 1
                                PictureboxAbleToBlock(i) = 19
                            End If
                        End If
                    Else
                        Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox1Color()
                                PictureboxAbleToBlock(i) = 46
                                i = i + 1
                                PictureboxAbleToBlock(i) = 37
                                i = i + 1
                                PictureboxAbleToBlock(i) = 28
                                i = i + 1
                                PictureboxAbleToBlock(i) = 10
                            End If
                        Else
                            CheckPicturebox10Color()
                            PictureboxAbleToBlock(i) = 46
                            i = i + 1
                            PictureboxAbleToBlock(i) = 37
                            i = i + 1
                            PictureboxAbleToBlock(i) = 28
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox19.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox1Color()
                                PictureboxAbleToBlock(i) = 46
                                i = i + 1
                                PictureboxAbleToBlock(i) = 37
                                i = i + 1
                                PictureboxAbleToBlock(i) = 19
                                i = i + 1
                                PictureboxAbleToBlock(i) = 10
                            End If
                        Else
                            CheckPicturebox10Color()
                            PictureboxAbleToBlock(i) = 46
                            i = i + 1
                            PictureboxAbleToBlock(i) = 37
                            i = i + 1
                            PictureboxAbleToBlock(i) = 19
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox19Color()
                        PictureboxAbleToBlock(i) = 46
                        i = i + 1
                        PictureboxAbleToBlock(i) = 37
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox28.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox19.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox1Color()
                                PictureboxAbleToBlock(i) = 46
                                i = i + 1
                                PictureboxAbleToBlock(i) = 28
                                i = i + 1
                                PictureboxAbleToBlock(i) = 19
                                i = i + 1
                                PictureboxAbleToBlock(i) = 10
                            End If
                        Else
                            CheckPicturebox10Color()
                            PictureboxAbleToBlock(i) = 46
                            i = i + 1
                            PictureboxAbleToBlock(i) = 28
                            i = i + 1
                            PictureboxAbleToBlock(i) = 19
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox19Color()
                        PictureboxAbleToBlock(i) = 46
                        i = i + 1
                        PictureboxAbleToBlock(i) = 28
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox28Color()
                    PictureboxAbleToBlock(i) = 46
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox28.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox19.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox1Color()
                                PictureboxAbleToBlock(i) = 37
                                i = i + 1
                                PictureboxAbleToBlock(i) = 28
                                i = i + 1
                                PictureboxAbleToBlock(i) = 19
                                i = i + 1
                                PictureboxAbleToBlock(i) = 10
                            End If
                        Else
                            CheckPicturebox10Color()
                            PictureboxAbleToBlock(i) = 37
                            i = i + 1
                            PictureboxAbleToBlock(i) = 28
                            i = i + 1
                            PictureboxAbleToBlock(i) = 19
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox19Color()
                        PictureboxAbleToBlock(i) = 37
                        i = i + 1
                        PictureboxAbleToBlock(i) = 28
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox28Color()
                    PictureboxAbleToBlock(i) = 37
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox37Color()
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoB4EastMovementArea()
        i = 1
        If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
            Pic57None()
            If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                Pic58None()
                If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    Pic59None()
                    If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                        Pic60None()
                        If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                            Pic61None()
                            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                                Pic62None()
                                If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                    Pic63None()
                                Else
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox63Color()
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                End If
                            End If
                        Else
                            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox63Color()
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 62
                                End If
                            Else
                                CheckPicturebox62Color()
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox63Color()
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 62
                                End If
                            Else
                                CheckPicturebox62Color()
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox61Color()
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox63Color()
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 62
                                End If
                            Else
                                CheckPicturebox62Color()
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox61Color()
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox60Color()
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox63Color()
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 62
                                End If
                            Else
                                CheckPicturebox62Color()
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox61Color()
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox60Color()
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox59Color()
                    PictureboxAbleToBlock(i) = 57
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox63Color()
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 62
                                End If
                            Else
                                CheckPicturebox62Color()
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox61Color()
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox60Color()
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox59Color()
                    PictureboxAbleToBlock(i) = 58
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox58Color()
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoB4SouthMovementArea()
        i = 1
        If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
            Form1.PictureBox65.Image = Form1.movementAreaPic.Image
            Pic65None()
            If Form1.PictureBox74.Image Is Form1.nonePic.Image Then
                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                Pic74None()
                If Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                    Pic83None()
                Else
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox83Color()
                    PictureboxAbleToBlock(i) = 65
                End If
            End If
        Else
            Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox74.Image Is Form1.nonePic.Image Then
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox83Color()
                    PictureboxAbleToBlock(i) = 74
                End If
            Else
                CheckPicturebox74Color()
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoB4WestMovementArea()
        i = 1
        If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
            Pic55None()
        Else
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub PaoB4NorthMovementArea()
        i = 1
        If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
            Pic47None()
            If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                Pic38None()
                If Form1.PictureBox29.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                    Pic29None()
                    If Form1.PictureBox20.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                        Pic20None()
                        If Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                            Pic11None()
                            If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                                Pic2None()
                            Else
                                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox2Color()
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 20
                            End If
                        End If
                    Else
                        Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox2Color()
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 11
                            End If
                        Else
                            CheckPicturebox11Color()
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 29
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox20.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox2Color()
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 20
                                i = i + 1
                                PictureboxAbleToBlock(i) = 11
                            End If
                        Else
                            CheckPicturebox11Color()
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 20
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox20Color()
                        PictureboxAbleToBlock(i) = 47
                        i = i + 1
                        PictureboxAbleToBlock(i) = 38
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox29.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox20.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox2Color()
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 20
                                i = i + 1
                                PictureboxAbleToBlock(i) = 11
                            End If
                        Else
                            CheckPicturebox11Color()
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 20
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox20Color()
                        PictureboxAbleToBlock(i) = 47
                        i = i + 1
                        PictureboxAbleToBlock(i) = 29
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox29Color()
                    PictureboxAbleToBlock(i) = 47
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox29.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox20.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox2Color()
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 20
                                i = i + 1
                                PictureboxAbleToBlock(i) = 11
                            End If
                        Else
                            CheckPicturebox11Color()
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 20
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox20Color()
                        PictureboxAbleToBlock(i) = 38
                        i = i + 1
                        PictureboxAbleToBlock(i) = 29
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox29Color()
                    PictureboxAbleToBlock(i) = 38
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox38Color()
                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoC4EastMovementArea()
        i = 1
        If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
            Pic58None()
            If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                Pic59None()
                If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    Pic60None()
                    If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                        Pic61None()
                        If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                            Pic62None()
                            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                                Pic63None()
                            Else
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox63Color()
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                            End If
                        End If
                    Else
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox63Color()
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 62
                            End If
                        Else
                            CheckPicturebox62Color()
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox63Color()
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 62
                            End If
                        Else
                            CheckPicturebox62Color()
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox61Color()
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox63Color()
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 62
                            End If
                        Else
                            CheckPicturebox62Color()
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox61Color()
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox60Color()
                    PictureboxAbleToBlock(i) = 58
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox63Color()
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 62
                            End If
                        Else
                            CheckPicturebox62Color()
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox61Color()
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox60Color()
                    PictureboxAbleToBlock(i) = 59
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox59Color()
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoC4SouthMovementArea()
        i = 1
        If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
            Form1.PictureBox66.Image = Form1.movementAreaPic.Image
            Pic66None()
            If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                Pic75None()
                If Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                    Pic84None()
                Else
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox84Color()
                    PictureboxAbleToBlock(i) = 66
                End If
            End If
        Else
            Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox84Color()
                    PictureboxAbleToBlock(i) = 75
                End If
            Else
                CheckPicturebox75Color()
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoC4WestMovementArea()
        i = 1
        If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
            Pic56None()
            If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                Pic55None()
            Else
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            End If
        Else
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            Else
                CheckPicturebox55Color()
            End If
        End If
    End Sub

    Public Sub PaoC4NorthMovementArea()
        i = 1
        If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
            Pic48None()
            If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                Pic39None()
                If Form1.PictureBox30.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                    Pic30None()
                    If Form1.PictureBox21.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                        Pic21None()
                        If Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                            Pic12None()
                            If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                                Pic3None()
                            Else
                                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox3Color()
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 21
                            End If
                        End If
                    Else
                        Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox3Color()
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 12
                            End If
                        Else
                            CheckPicturebox12Color()
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox21.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox3Color()
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 21
                                i = i + 1
                                PictureboxAbleToBlock(i) = 12
                            End If
                        Else
                            CheckPicturebox12Color()
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 21
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox21Color()
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 39
                        Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox30.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox21.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox3Color()
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 21
                                i = i + 1
                                PictureboxAbleToBlock(i) = 12
                            End If
                        Else
                            CheckPicturebox12Color()
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 21
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox21Color()
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 30
                        Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox30Color()
                    PictureboxAbleToBlock(i) = 48
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox30.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox21.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox3Color()
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 21
                                i = i + 1
                                PictureboxAbleToBlock(i) = 12
                            End If
                        Else
                            CheckPicturebox12Color()
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 21
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox21Color()
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 30
                        Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox30Color()
                    PictureboxAbleToBlock(i) = 39
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox39Color()
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoD4EastMovementArea()
        i = 1
        If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
            Pic59None()
            If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
                If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    Pic61None()
                    If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                        Pic62None()
                        If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                            Pic63None()
                        Else
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox63Color()
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                        End If
                    End If
                Else
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox63Color()
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 62
                        End If
                    Else
                        CheckPicturebox62Color()
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox63Color()
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 62
                        End If
                    Else
                        CheckPicturebox62Color()
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 61
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox61Color()
                    PictureboxAbleToBlock(i) = 59
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox63Color()
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 62
                        End If
                    Else
                        CheckPicturebox62Color()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 61
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox61Color()
                    PictureboxAbleToBlock(i) = 60
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox60Color()
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoD4SouthMovementArea()
        i = 1
        If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
            Form1.PictureBox67.Image = Form1.movementAreaPic.Image
            Pic67None()
            If Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                Pic76None()
                If Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                    Pic85None()
                Else
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox85Color()
                    PictureboxAbleToBlock(i) = 67
                End If
            End If
        Else
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox85Color()
                    PictureboxAbleToBlock(i) = 76
                End If
            Else
                CheckPicturebox76Color()
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoD4WestMovementArea()
        i = 1
        If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
            Pic57None()
            If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                Pic56None()
                If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                    Pic55None()
                Else
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox55Color()
                    PictureboxAbleToBlock(i) = 57
                End If
            End If
        Else
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox55Color()
                    PictureboxAbleToBlock(i) = 56
                End If
            Else
                CheckPicturebox56Color()
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoD4NorthMovementArea()
        i = 1
        If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
            Pic49None()
            If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                Pic40None()
                If Form1.PictureBox31.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    Pic31None()
                    If Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                        Pic22None()
                        If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                            Pic13None()
                            If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                                Pic4None()
                            Else
                                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox4Color()
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 22
                            End If
                        End If
                    Else
                        Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox4Color()
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 13
                            End If
                        Else
                            CheckPicturebox13Color()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox4Color()
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 22
                                i = i + 1
                                PictureboxAbleToBlock(i) = 13
                            End If
                        Else
                            CheckPicturebox13Color()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox22Color()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox31.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox4Color()
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 22
                                i = i + 1
                                PictureboxAbleToBlock(i) = 13
                            End If
                        Else
                            CheckPicturebox13Color()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox22Color()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 31
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox31Color()
                    PictureboxAbleToBlock(i) = 49
                    Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox31.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox4Color()
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 22
                                i = i + 1
                                PictureboxAbleToBlock(i) = 13
                            End If
                        Else
                            CheckPicturebox13Color()
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox22Color()
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 31
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox31Color()
                    PictureboxAbleToBlock(i) = 40
                    Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox40Color()
                Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoE4EastMovementArea()
        i = 1
        If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
            Pic60None()
            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
                If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    Pic62None()
                    If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                        Pic63None()
                    Else
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox63Color()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 61
                    End If
                End If
            Else
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox63Color()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 62
                    End If
                Else
                    CheckPicturebox62Color()
                    PictureboxAbleToBlock(i) = 60
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox63Color()
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 62
                    End If
                Else
                    CheckPicturebox62Color()
                    PictureboxAbleToBlock(i) = 61
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox61Color()
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoE4SouthMovementArea()
        i = 1
        If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
            Form1.PictureBox68.Image = Form1.movementAreaPic.Image
            Pic68None()
            If Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
                If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                    Pic86None()
                Else
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox86Color()
                    PictureboxAbleToBlock(i) = 68
                End If
            End If
        Else
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox86Color()
                    PictureboxAbleToBlock(i) = 77
                End If
            Else
                CheckPicturebox77Color()
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoE4WestMovementArea()
        i = 1
        If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
            Pic58None()
            If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                Pic57None()
                If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                    Pic56None()
                    If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                        Pic55None()
                    Else
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox55Color()
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 57
                    End If
                End If
            Else
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox55Color()
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 56
                    End If
                Else
                    CheckPicturebox56Color()
                    PictureboxAbleToBlock(i) = 58
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox55Color()
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 56
                    End If
                Else
                    CheckPicturebox56Color()
                    PictureboxAbleToBlock(i) = 57
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox57Color()
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            End If
        End If

    End Sub

    Public Sub PaoE4NorthMovementArea()
        i = 1
        If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
            Pic50None()
            If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
                If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    Pic32None()
                    If Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                        Pic23None()
                        If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                            Pic14None()
                            If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                                Pic5None()
                            Else
                                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox5Color()
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 23
                            End If
                        End If
                    Else
                        Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox5Color()
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 14
                            End If
                        Else
                            CheckPicturebox14Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox5Color()
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 23
                                i = i + 1
                                PictureboxAbleToBlock(i) = 14
                            End If
                        Else
                            CheckPicturebox14Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox23Color()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox5Color()
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 23
                                i = i + 1
                                PictureboxAbleToBlock(i) = 14
                            End If
                        Else
                            CheckPicturebox14Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox23Color()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 32
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox32Color()
                    PictureboxAbleToBlock(i) = 50
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox5Color()
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 23
                                i = i + 1
                                PictureboxAbleToBlock(i) = 14
                            End If
                        Else
                            CheckPicturebox14Color()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox23Color()
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 32
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox32Color()
                    PictureboxAbleToBlock(i) = 41
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox41Color()
                Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoF4EastMovementArea()
        i = 1
        If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
            Pic61None()
            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
                If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    Pic63None()
                Else
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox63Color()
                    PictureboxAbleToBlock(i) = 61
                End If
            End If
        Else
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox63Color()
                    PictureboxAbleToBlock(i) = 62
                End If
            Else
                CheckPicturebox62Color()
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoF4SouthMovementArea()
        i = 1
        If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
            Form1.PictureBox69.Image = Form1.movementAreaPic.Image
            Pic69None()
            If Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
                If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                    Pic87None()
                Else
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox87Color()
                    PictureboxAbleToBlock(i) = 69
                End If
            End If
        Else
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox87Color()
                    PictureboxAbleToBlock(i) = 78
                End If
            Else
                CheckPicturebox78Color()
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoF4WestMovementArea()
        i = 1
        If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
            Pic59None()
            If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                Pic58None()
                If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                    Pic57None()
                    If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                        Pic56None()
                        If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                            Pic55None()
                        Else
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox55Color()
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                        End If
                    End If
                Else
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox55Color()
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 56
                        End If
                    Else
                        CheckPicturebox56Color()
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox55Color()
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 56
                        End If
                    Else
                        CheckPicturebox56Color()
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 57
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox57Color()
                    PictureboxAbleToBlock(i) = 59
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox55Color()
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 56
                        End If
                    Else
                        CheckPicturebox56Color()
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 57
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox57Color()
                    PictureboxAbleToBlock(i) = 58
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox58Color()
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoF4NorthMovementArea()
        i = 1
        If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
            Pic51None()
            If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                Pic42None()
                If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    Pic33None()
                    If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                        Pic24None()
                        If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                            Pic15None()
                            If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                                Pic6None()
                            Else
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox6Color()
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                            End If
                        End If
                    Else
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox6Color()
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 15
                            End If
                        Else
                            CheckPicturebox15Color()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox6Color()
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                i = i + 1
                                PictureboxAbleToBlock(i) = 15
                            End If
                        Else
                            CheckPicturebox15Color()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox24Color()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox6Color()
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                i = i + 1
                                PictureboxAbleToBlock(i) = 15
                            End If
                        Else
                            CheckPicturebox15Color()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox24Color()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 33
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox33Color()
                    PictureboxAbleToBlock(i) = 51
                    Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox6Color()
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                i = i + 1
                                PictureboxAbleToBlock(i) = 24
                                i = i + 1
                                PictureboxAbleToBlock(i) = 15
                            End If
                        Else
                            CheckPicturebox15Color()
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox24Color()
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 33
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox33Color()
                    PictureboxAbleToBlock(i) = 42
                    Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox42Color()
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoG4EastMovementArea()
        i = 1
        If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
            Pic62None()
            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                Pic63None()
            Else
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            End If
        Else
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Else
                CheckPicturebox63Color()
            End If
        End If
    End Sub

    Public Sub PaoG4SouthMovementArea()
        i = 1
        If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
            Form1.PictureBox70.Image = Form1.movementAreaPic.Image
            Pic70None()
            If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                Pic79None()
                If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                    Pic88None()
                Else
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox88Color()
                    PictureboxAbleToBlock(i) = 70
                End If
            End If
        Else
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox88Color()
                    PictureboxAbleToBlock(i) = 79
                End If
            Else
                CheckPicturebox79Color()
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoG4WestMovementArea()
        i = 1
        If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
            Pic60None()
            If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                Pic59None()
                If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    Pic58None()
                    If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                        Pic57None()
                        If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                            Pic56None()
                            If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                Pic55None()
                            Else
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox55Color()
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                            End If
                        End If
                    Else
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox55Color()
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 56
                            End If
                        Else
                            CheckPicturebox56Color()
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox55Color()
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 56
                            End If
                        Else
                            CheckPicturebox56Color()
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox57Color()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox55Color()
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 56
                            End If
                        Else
                            CheckPicturebox56Color()
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox57Color()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox58Color()
                    PictureboxAbleToBlock(i) = 60
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox55Color()
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                i = i + 1
                                PictureboxAbleToBlock(i) = 56
                            End If
                        Else
                            CheckPicturebox56Color()
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox57Color()
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox58Color()
                    PictureboxAbleToBlock(i) = 59
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox59Color()
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoG4NorthMovementArea()
        i = 1
        If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
            Pic52None()
            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
                If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    Pic34None()
                    If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                        Pic25None()
                        If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                            Pic16None()
                            If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                                Pic7None()
                            Else
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox7Color()
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                            End If
                        End If
                    Else
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox7Color()
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 16
                            End If
                        Else
                            CheckPicturebox16Color()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox7Color()
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                                i = i + 1
                                PictureboxAbleToBlock(i) = 16
                            End If
                        Else
                            CheckPicturebox16Color()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 25
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox25Color()
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox7Color()
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                                i = i + 1
                                PictureboxAbleToBlock(i) = 16
                            End If
                        Else
                            CheckPicturebox16Color()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            i = i + 1
                            PictureboxAbleToBlock(i) = 25
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox25Color()
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 34
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox34Color()
                    PictureboxAbleToBlock(i) = 52
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox7Color()
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 34
                                i = i + 1
                                PictureboxAbleToBlock(i) = 25
                                i = i + 1
                                PictureboxAbleToBlock(i) = 16
                            End If
                        Else
                            CheckPicturebox16Color()
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            i = i + 1
                            PictureboxAbleToBlock(i) = 25
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox25Color()
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 34
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox34Color()
                    PictureboxAbleToBlock(i) = 43
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox43Color()
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoH4EastMovementArea()
        i = 1
        If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
            Pic63None()
        Else
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub PaoH4SouthMovementArea()
        i = 1
        If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
            Form1.PictureBox71.Image = Form1.movementAreaPic.Image
            Pic71None()
            If Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                Pic80None()
                If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                    Pic89None()
                Else
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox89Color()
                    PictureboxAbleToBlock(i) = 71
                End If
            End If
        Else
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox89Color()
                    PictureboxAbleToBlock(i) = 80
                End If
            Else
                CheckPicturebox80Color()
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoH4WestMovementArea()
        i = 1
        If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
            Pic61None()
            If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
                If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    Pic59None()
                    If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                        Pic58None()
                        If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                            Pic57None()
                            If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                Pic56None()
                                If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                    Pic55None()
                                Else
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox55Color()
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                End If
                            End If
                        Else
                            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox55Color()
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 56
                                End If
                            Else
                                CheckPicturebox56Color()
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox55Color()
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 56
                                End If
                            Else
                                CheckPicturebox56Color()
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox57Color()
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox55Color()
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 56
                                End If
                            Else
                                CheckPicturebox56Color()
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox57Color()
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox58Color()
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox55Color()
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 56
                                End If
                            Else
                                CheckPicturebox56Color()
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox57Color()
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox58Color()
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox59Color()
                    PictureboxAbleToBlock(i) = 61
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox55Color()
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 56
                                End If
                            Else
                                CheckPicturebox56Color()
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                i = i + 1
                                PictureboxAbleToBlock(i) = 57
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox57Color()
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox58Color()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox59Color()
                    PictureboxAbleToBlock(i) = 60
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox60Color()
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            End If
        End If

    End Sub

    Public Sub PaoH4NorthMovementArea()
        i = 1
        If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
            Pic53None()
            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
                If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    Pic35None()
                    If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                        Pic26None()
                        If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                            Pic17None()
                            If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                                Pic8None()
                            Else
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox8Color()
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                i = i + 1
                                PictureboxAbleToBlock(i) = 26
                            End If
                        End If
                    Else
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox8Color()
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                i = i + 1
                                PictureboxAbleToBlock(i) = 17
                            End If
                        Else
                            CheckPicturebox17Color()
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox8Color()
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 26
                                i = i + 1
                                PictureboxAbleToBlock(i) = 17
                            End If
                        Else
                            CheckPicturebox17Color()
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 26
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox26Color()
                        PictureboxAbleToBlock(i) = 53
                        i = i + 1
                        PictureboxAbleToBlock(i) = 44
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox8Color()
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                i = i + 1
                                PictureboxAbleToBlock(i) = 26
                                i = i + 1
                                PictureboxAbleToBlock(i) = 17
                            End If
                        Else
                            CheckPicturebox17Color()
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            i = i + 1
                            PictureboxAbleToBlock(i) = 26
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox26Color()
                        PictureboxAbleToBlock(i) = 53
                        i = i + 1
                        PictureboxAbleToBlock(i) = 35
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox35Color()
                    PictureboxAbleToBlock(i) = 53
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox8Color()
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 35
                                i = i + 1
                                PictureboxAbleToBlock(i) = 26
                                i = i + 1
                                PictureboxAbleToBlock(i) = 17
                            End If
                        Else
                            CheckPicturebox17Color()
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            i = i + 1
                            PictureboxAbleToBlock(i) = 26
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox26Color()
                        PictureboxAbleToBlock(i) = 44
                        i = i + 1
                        PictureboxAbleToBlock(i) = 35
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox35Color()
                    PictureboxAbleToBlock(i) = 44
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox44Color()
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoI4SouthMovementArea()
        i = 1
        If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
            Form1.PictureBox72.Image = Form1.movementAreaPic.Image
            Pic72None()
            If Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                Pic81None()
                If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                    Pic90None()
                Else
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox90Color()
                    PictureboxAbleToBlock(i) = 72
                End If
            End If
        Else
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox90Color()
                    PictureboxAbleToBlock(i) = 81
                End If
            Else
                CheckPicturebox81Color()
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoI4WestMovementArea()
        i = 1
        If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
            Pic62None()
            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
                If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    Pic60None()
                    If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                        Pic59None()
                        If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                            Pic58None()
                            If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                                Pic57None()
                                If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                                    Pic56None()
                                    If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                                        Pic55None()
                                    Else
                                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                    End If
                                Else
                                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox55Color()
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
                                    End If
                                End If
                            Else
                                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox55Color()
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
                                        PictureboxAbleToBlock(i) = 56
                                    End If
                                Else
                                    CheckPicturebox56Color()
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                End If
                            End If
                        Else
                            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox55Color()
                                        PictureboxAbleToBlock(i) = 62
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 61
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 60
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 59
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 57
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 56
                                    End If
                                Else
                                    CheckPicturebox56Color()
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox57Color()
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox55Color()
                                        PictureboxAbleToBlock(i) = 62
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 61
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 60
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 58
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 57
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 56
                                    End If
                                Else
                                    CheckPicturebox56Color()
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox57Color()
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox58Color()
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox55Color()
                                        PictureboxAbleToBlock(i) = 62
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 61
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 59
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 58
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 57
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 56
                                    End If
                                Else
                                    CheckPicturebox56Color()
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox57Color()
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox58Color()
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox59Color()
                        PictureboxAbleToBlock(i) = 62
                        i = i + 1
                        PictureboxAbleToBlock(i) = 61
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox55Color()
                                        PictureboxAbleToBlock(i) = 62
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
                                    End If
                                Else
                                    CheckPicturebox56Color()
                                    PictureboxAbleToBlock(i) = 62
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox57Color()
                                PictureboxAbleToBlock(i) = 62
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox58Color()
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox59Color()
                        PictureboxAbleToBlock(i) = 62
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox60Color()
                    PictureboxAbleToBlock(i) = 62
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox55Color()
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
                                    End If
                                Else
                                    CheckPicturebox56Color()
                                    PictureboxAbleToBlock(i) = 61
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 60
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 59
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 58
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 57
                                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox57Color()
                                PictureboxAbleToBlock(i) = 61
                                i = i + 1
                                PictureboxAbleToBlock(i) = 60
                                i = i + 1
                                PictureboxAbleToBlock(i) = 59
                                i = i + 1
                                PictureboxAbleToBlock(i) = 58
                                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox58Color()
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox59Color()
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox60Color()
                    PictureboxAbleToBlock(i) = 61
                    Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox61Color()
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoI4NorthMovementArea()
        i = 1
        If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
            Pic54None()
            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                Pic45None()
                If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    Pic36None()
                    If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                        Pic27None()
                        If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                            Pic18None()
                            If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                                Pic9None()
                            Else
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox9Color()
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 36
                                i = i + 1
                                PictureboxAbleToBlock(i) = 27
                            End If
                        End If
                    Else
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox9Color()
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 36
                                i = i + 1
                                PictureboxAbleToBlock(i) = 18
                            End If
                        Else
                            CheckPicturebox18Color()
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 36
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox9Color()
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 27
                                i = i + 1
                                PictureboxAbleToBlock(i) = 18
                            End If
                        Else
                            CheckPicturebox18Color()
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 27
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox27Color()
                        PictureboxAbleToBlock(i) = 54
                        i = i + 1
                        PictureboxAbleToBlock(i) = 45
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox9Color()
                                PictureboxAbleToBlock(i) = 54
                                i = i + 1
                                PictureboxAbleToBlock(i) = 36
                                i = i + 1
                                PictureboxAbleToBlock(i) = 27
                                i = i + 1
                                PictureboxAbleToBlock(i) = 18
                            End If
                        Else
                            CheckPicturebox18Color()
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 36
                            i = i + 1
                            PictureboxAbleToBlock(i) = 27
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox27Color()
                        PictureboxAbleToBlock(i) = 54
                        i = i + 1
                        PictureboxAbleToBlock(i) = 36
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox36Color()
                    PictureboxAbleToBlock(i) = 54
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox9Color()
                                PictureboxAbleToBlock(i) = 45
                                i = i + 1
                                PictureboxAbleToBlock(i) = 36
                                i = i + 1
                                PictureboxAbleToBlock(i) = 27
                                i = i + 1
                                PictureboxAbleToBlock(i) = 18
                            End If
                        Else
                            CheckPicturebox18Color()
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 36
                            i = i + 1
                            PictureboxAbleToBlock(i) = 27
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox27Color()
                        PictureboxAbleToBlock(i) = 45
                        i = i + 1
                        PictureboxAbleToBlock(i) = 36
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox36Color()
                    PictureboxAbleToBlock(i) = 45
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox45Color()
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoA5EastMovementArea()
        i = 1
        If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
            Pic47None()
            If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                Pic48None()
                If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    Pic49None()
                    If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Pic50None()
                        If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                            Pic51None()
                            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                                Pic52None()
                                If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                    Pic53None()
                                    If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                        Pic54None()
                                    Else
                                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                    End If
                                Else
                                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox54Color()
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
                                    End If
                                End If
                            Else
                                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox54Color()
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
                                        PictureboxAbleToBlock(i) = 53
                                    End If
                                Else
                                    CheckPicturebox53Color()
                                    PictureboxAbleToBlock(i) = 47
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                End If
                            End If
                        Else
                            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox54Color()
                                        PictureboxAbleToBlock(i) = 47
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 48
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 49
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 50
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 52
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 53
                                    End If
                                Else
                                    CheckPicturebox53Color()
                                    PictureboxAbleToBlock(i) = 47
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox52Color()
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox54Color()
                                        PictureboxAbleToBlock(i) = 47
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 48
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 49
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 51
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 52
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 53
                                    End If
                                Else
                                    CheckPicturebox53Color()
                                    PictureboxAbleToBlock(i) = 47
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox52Color()
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox51Color()
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox54Color()
                                        PictureboxAbleToBlock(i) = 47
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 48
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 50
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 51
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 52
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 53
                                    End If
                                Else
                                    CheckPicturebox53Color()
                                    PictureboxAbleToBlock(i) = 47
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox52Color()
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox51Color()
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox50Color()
                        PictureboxAbleToBlock(i) = 47
                        i = i + 1
                        PictureboxAbleToBlock(i) = 48
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox54Color()
                                        PictureboxAbleToBlock(i) = 47
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
                                    End If
                                Else
                                    CheckPicturebox53Color()
                                    PictureboxAbleToBlock(i) = 47
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox52Color()
                                PictureboxAbleToBlock(i) = 47
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox51Color()
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox50Color()
                        PictureboxAbleToBlock(i) = 47
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox49Color()
                    PictureboxAbleToBlock(i) = 47
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox54Color()
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
                                    End If
                                Else
                                    CheckPicturebox53Color()
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox52Color()
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox51Color()
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox50Color()
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox49Color()
                    PictureboxAbleToBlock(i) = 48
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox48Color()
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoA5SouthMovementArea()
        i = 1
        If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
            Form1.PictureBox55.Image = Form1.movementAreaPic.Image
            Pic55None()
            If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                Pic64None()
                If Form1.PictureBox73.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                    Pic73None()
                    If Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                        Pic82None()
                    Else
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox82Color()
                        PictureboxAbleToBlock(i) = 55
                        i = i + 1
                        PictureboxAbleToBlock(i) = 64
                    End If
                End If
            Else
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox73.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox82Color()
                        PictureboxAbleToBlock(i) = 55
                        i = i + 1
                        PictureboxAbleToBlock(i) = 73
                    End If
                Else
                    CheckPicturebox73Color()
                    PictureboxAbleToBlock(i) = 55
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox73.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox82Color()
                        PictureboxAbleToBlock(i) = 64
                        i = i + 1
                        PictureboxAbleToBlock(i) = 73
                    End If
                Else
                    CheckPicturebox73Color()
                    PictureboxAbleToBlock(i) = 64
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox64Color()
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoA5NorthMovementArea()
        i = 1
        If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
            Pic37None()
            If Form1.PictureBox28.Image Is Form1.nonePic.Image Then
                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                Pic28None()
                If Form1.PictureBox19.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                    Pic19None()
                    If Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                        Pic10None()
                        If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                            Pic1None()
                        Else
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox1Color()
                            PictureboxAbleToBlock(i) = 37
                            i = i + 1
                            PictureboxAbleToBlock(i) = 28
                            i = i + 1
                            PictureboxAbleToBlock(i) = 19
                        End If
                    End If
                Else
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox1Color()
                            PictureboxAbleToBlock(i) = 37
                            i = i + 1
                            PictureboxAbleToBlock(i) = 28
                            i = i + 1
                            PictureboxAbleToBlock(i) = 10
                        End If
                    Else
                        CheckPicturebox10Color()
                        PictureboxAbleToBlock(i) = 37
                        i = i + 1
                        PictureboxAbleToBlock(i) = 28
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox19.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox1Color()
                            PictureboxAbleToBlock(i) = 37
                            i = i + 1
                            PictureboxAbleToBlock(i) = 19
                            i = i + 1
                            PictureboxAbleToBlock(i) = 10
                        End If
                    Else
                        CheckPicturebox10Color()
                        PictureboxAbleToBlock(i) = 37
                        i = i + 1
                        PictureboxAbleToBlock(i) = 19
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox19Color()
                    PictureboxAbleToBlock(i) = 37
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox28.Image Is Form1.nonePic.Image Then
                Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox19.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox1Color()
                            PictureboxAbleToBlock(i) = 28
                            i = i + 1
                            PictureboxAbleToBlock(i) = 19
                            i = i + 1
                            PictureboxAbleToBlock(i) = 10
                        End If
                    Else
                        CheckPicturebox10Color()
                        PictureboxAbleToBlock(i) = 28
                        i = i + 1
                        PictureboxAbleToBlock(i) = 19
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox19Color()
                    PictureboxAbleToBlock(i) = 28
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox28Color()
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoB5EastMovementArea()
        i = 1
        If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
            Pic48None()
            If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                Pic49None()
                If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    Pic50None()
                    If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                        Pic51None()
                        If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                            Pic52None()
                            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                                Pic53None()
                                If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                    Pic54None()
                                Else
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox54Color()
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                End If
                            End If
                        Else
                            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox54Color()
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                End If
                            Else
                                CheckPicturebox53Color()
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox54Color()
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                End If
                            Else
                                CheckPicturebox53Color()
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox52Color()
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox54Color()
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                End If
                            Else
                                CheckPicturebox53Color()
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox52Color()
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox51Color()
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox54Color()
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                End If
                            Else
                                CheckPicturebox53Color()
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox52Color()
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox51Color()
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox50Color()
                    PictureboxAbleToBlock(i) = 48
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox54Color()
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 53
                                End If
                            Else
                                CheckPicturebox53Color()
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox52Color()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox51Color()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox50Color()
                    PictureboxAbleToBlock(i) = 49
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox49Color()
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoB5SouthMovementArea()
        i = 1
        If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
            Form1.PictureBox56.Image = Form1.movementAreaPic.Image
            Pic56None()
            If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                Pic65None()
                If Form1.PictureBox74.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                    Pic74None()
                    If Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                        Pic83None()
                    Else
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox83Color()
                        PictureboxAbleToBlock(i) = 56
                        i = i + 1
                        PictureboxAbleToBlock(i) = 65
                    End If
                End If
            Else
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox74.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox83Color()
                        PictureboxAbleToBlock(i) = 56
                        i = i + 1
                        PictureboxAbleToBlock(i) = 74
                    End If
                Else
                    CheckPicturebox74Color()
                    PictureboxAbleToBlock(i) = 56
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox74.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox83Color()
                        PictureboxAbleToBlock(i) = 65
                        i = i + 1
                        PictureboxAbleToBlock(i) = 74
                    End If
                Else
                    CheckPicturebox74Color()
                    PictureboxAbleToBlock(i) = 65
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox65Color()
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoB5WestMovementArea()
        i = 1
        If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
            Pic46None()
        Else
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
        End If

    End Sub

    Public Sub PaoB5NorthMovementArea()
        i = 1
        If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
            Pic38None()
            If Form1.PictureBox29.Image Is Form1.nonePic.Image Then
                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                Pic29None()
                If Form1.PictureBox20.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                    Pic20None()
                    If Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                        Pic11None()
                        If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                            Pic2None()
                        Else
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox2Color()
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 20
                        End If
                    End If
                Else
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox2Color()
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 11
                        End If
                    Else
                        CheckPicturebox11Color()
                        PictureboxAbleToBlock(i) = 38
                        i = i + 1
                        PictureboxAbleToBlock(i) = 29
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox20.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox2Color()
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 20
                            i = i + 1
                            PictureboxAbleToBlock(i) = 11
                        End If
                    Else
                        CheckPicturebox11Color()
                        PictureboxAbleToBlock(i) = 38
                        i = i + 1
                        PictureboxAbleToBlock(i) = 20
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox20Color()
                    PictureboxAbleToBlock(i) = 38
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox29.Image Is Form1.nonePic.Image Then
                Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox20.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox2Color()
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 20
                            i = i + 1
                            PictureboxAbleToBlock(i) = 11
                        End If
                    Else
                        CheckPicturebox11Color()
                        PictureboxAbleToBlock(i) = 29
                        i = i + 1
                        PictureboxAbleToBlock(i) = 20
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox20Color()
                    PictureboxAbleToBlock(i) = 29
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox29Color()
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoC5EastMovementArea()
        i = 1
        If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
            Pic49None()
            If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
                If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    Pic51None()
                    If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                        Pic52None()
                        If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                            Pic53None()
                            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                                Pic54None()
                            Else
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox54Color()
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                            End If
                        End If
                    Else
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox54Color()
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                            End If
                        Else
                            CheckPicturebox53Color()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox54Color()
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                            End If
                        Else
                            CheckPicturebox53Color()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox52Color()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox54Color()
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                            End If
                        Else
                            CheckPicturebox53Color()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox52Color()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox51Color()
                    PictureboxAbleToBlock(i) = 49
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox54Color()
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 53
                            End If
                        Else
                            CheckPicturebox53Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox52Color()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox51Color()
                    PictureboxAbleToBlock(i) = 50
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox50Color()
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoC5SouthMovementArea()
        i = 1
        If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
            Form1.PictureBox57.Image = Form1.movementAreaPic.Image
            Pic57None()
            If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                Pic66None()
                If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                    Pic75None()
                    If Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                        Pic84None()
                    Else
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox84Color()
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 66
                    End If
                End If
            Else
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox84Color()
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 75
                    End If
                Else
                    CheckPicturebox75Color()
                    PictureboxAbleToBlock(i) = 57
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox84Color()
                        PictureboxAbleToBlock(i) = 66
                        i = i + 1
                        PictureboxAbleToBlock(i) = 75
                    End If
                Else
                    CheckPicturebox75Color()
                    PictureboxAbleToBlock(i) = 66
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox66Color()
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoC5WestMovementArea()
        i = 1
        If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
            Pic47None()
            If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                Pic46None()
            Else
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            End If
        Else
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            Else
                CheckPicturebox46Color()
            End If
        End If
    End Sub

    Public Sub PaoC5NorthMovementArea()
        i = 1
        If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
            Pic39None()
            If Form1.PictureBox30.Image Is Form1.nonePic.Image Then
                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                Pic30None()
                If Form1.PictureBox21.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                    Pic21None()
                    If Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                        Pic12None()
                        If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                            Pic3None()
                        Else
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox3Color()
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 21
                        End If
                    End If
                Else
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox3Color()
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 12
                        End If
                    Else
                        CheckPicturebox12Color()
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 30
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox21.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox3Color()
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 21
                            i = i + 1
                            PictureboxAbleToBlock(i) = 12
                        End If
                    Else
                        CheckPicturebox12Color()
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 21
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox21Color()
                    PictureboxAbleToBlock(i) = 39
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox30.Image Is Form1.nonePic.Image Then
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox21.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox3Color()
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 21
                            i = i + 1
                            PictureboxAbleToBlock(i) = 12
                        End If
                    Else
                        CheckPicturebox12Color()
                        PictureboxAbleToBlock(i) = 30
                        i = i + 1
                        PictureboxAbleToBlock(i) = 21
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox21Color()
                    PictureboxAbleToBlock(i) = 30
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox30Color()
                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoD5EastMovementArea()
        i = 1
        If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
            Pic50None()
            If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                Pic51None()
                If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    Pic52None()
                    If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                        Pic53None()
                        If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                            Pic54None()
                        Else
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox54Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                        End If
                    End If
                Else
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox54Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 53
                        End If
                    Else
                        CheckPicturebox53Color()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox54Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 53
                        End If
                    Else
                        CheckPicturebox53Color()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 52
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox52Color()
                    PictureboxAbleToBlock(i) = 50
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox54Color()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 53
                        End If
                    Else
                        CheckPicturebox53Color()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 52
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox52Color()
                    PictureboxAbleToBlock(i) = 51
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox51Color()
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoD5SouthMovementArea()
        i = 1
        If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
            Form1.PictureBox58.Image = Form1.movementAreaPic.Image
            Pic58None()
            If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                Pic67None()
                If Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                    Pic76None()
                    If Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                        Pic85None()
                    Else
                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox85Color()
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 67
                    End If
                End If
            Else
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox85Color()
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 76
                    End If
                Else
                    CheckPicturebox76Color()
                    PictureboxAbleToBlock(i) = 58
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox85Color()
                        PictureboxAbleToBlock(i) = 67
                        i = i + 1
                        PictureboxAbleToBlock(i) = 76
                    End If
                Else
                    CheckPicturebox76Color()
                    PictureboxAbleToBlock(i) = 67
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox67Color()
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoD5WestMovementArea()
        i = 1
        If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
            Pic48None()
            If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                Pic47None()
                If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                    Pic46None()
                Else
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox46Color()
                    PictureboxAbleToBlock(i) = 48
                End If
            End If
        Else
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox46Color()
                    PictureboxAbleToBlock(i) = 47
                End If
            Else
                CheckPicturebox47Color()
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoD5NorthMovementArea()
        i = 1
        If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
            Pic40None()
            If Form1.PictureBox31.Image Is Form1.nonePic.Image Then
                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                Pic31None()
                If Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    Pic22None()
                    If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                        Pic13None()
                        If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                            Pic4None()
                        Else
                            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox4Color()
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                        End If
                    End If
                Else
                    Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox4Color()
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 13
                        End If
                    Else
                        CheckPicturebox13Color()
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 31
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox4Color()
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                            i = i + 1
                            PictureboxAbleToBlock(i) = 13
                        End If
                    Else
                        CheckPicturebox13Color()
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 22
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox22Color()
                    PictureboxAbleToBlock(i) = 40
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox31.Image Is Form1.nonePic.Image Then
                Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox4Color()
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 22
                            i = i + 1
                            PictureboxAbleToBlock(i) = 13
                        End If
                    Else
                        CheckPicturebox13Color()
                        PictureboxAbleToBlock(i) = 31
                        i = i + 1
                        PictureboxAbleToBlock(i) = 22
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox22Color()
                    PictureboxAbleToBlock(i) = 31
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox31Color()
                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoE5EastMovementArea()
        i = 1
        If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
            Pic51None()
            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
                If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    Pic53None()
                    If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                        Pic54None()
                    Else
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox54Color()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 52
                    End If
                End If
            Else
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox54Color()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 53
                    End If
                Else
                    CheckPicturebox53Color()
                    PictureboxAbleToBlock(i) = 51
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox54Color()
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 53
                    End If
                Else
                    CheckPicturebox53Color()
                    PictureboxAbleToBlock(i) = 52
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox52Color()
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoE5SouthMovementArea()
        i = 1
        If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
            Form1.PictureBox59.Image = Form1.movementAreaPic.Image
            Pic59None()
            If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
                If Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    Pic77None()
                    If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                        Pic86None()
                    Else
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox86Color()
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 68
                    End If
                End If
            Else
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox86Color()
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 77
                    End If
                Else
                    CheckPicturebox77Color()
                    PictureboxAbleToBlock(i) = 59
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox86Color()
                        PictureboxAbleToBlock(i) = 68
                        i = i + 1
                        PictureboxAbleToBlock(i) = 77
                    End If
                Else
                    CheckPicturebox77Color()
                    PictureboxAbleToBlock(i) = 68
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox68Color()
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoE5WestMovementArea()
        i = 1
        If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
            Pic49None()
            If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                Pic48None()
                If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                    Pic47None()
                    If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                        Pic46None()
                    Else
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox46Color()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 48
                    End If
                End If
            Else
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox46Color()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 47
                    End If
                Else
                    CheckPicturebox47Color()
                    PictureboxAbleToBlock(i) = 49
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox46Color()
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 47
                    End If
                Else
                    CheckPicturebox47Color()
                    PictureboxAbleToBlock(i) = 48
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox48Color()
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoE5NorthMovementArea()
        i = 1
        If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
            Pic41None()
            If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                Pic32None()
                If Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    Pic23None()
                    If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                        Pic14None()
                        If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                            Pic5None()
                        Else
                            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox5Color()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                        End If
                    End If
                Else
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox5Color()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 14
                        End If
                    Else
                        CheckPicturebox14Color()
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 32
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox5Color()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            i = i + 1
                            PictureboxAbleToBlock(i) = 14
                        End If
                    Else
                        CheckPicturebox14Color()
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 23
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox23Color()
                    PictureboxAbleToBlock(i) = 41
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox5Color()
                            PictureboxAbleToBlock(i) = 32
                            i = i + 1
                            PictureboxAbleToBlock(i) = 23
                            i = i + 1
                            PictureboxAbleToBlock(i) = 14
                        End If
                    Else
                        CheckPicturebox14Color()
                        PictureboxAbleToBlock(i) = 32
                        i = i + 1
                        PictureboxAbleToBlock(i) = 23
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox23Color()
                    PictureboxAbleToBlock(i) = 32
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox32Color()
                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoF5EastMovementArea()
        i = 1
        If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
            Pic52None()
            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
                If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    Pic54None()
                Else
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox54Color()
                    PictureboxAbleToBlock(i) = 52
                End If
            End If
        Else
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox54Color()
                    PictureboxAbleToBlock(i) = 53
                End If
            Else
                CheckPicturebox53Color()
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoF5SouthMovementArea()
        i = 1
        If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
            Form1.PictureBox60.Image = Form1.movementAreaPic.Image
            Pic60None()
            If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
                If Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    Pic78None()
                    If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                        Pic87None()
                    Else
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox87Color()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 69
                    End If
                End If
            Else
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox87Color()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 78
                    End If
                Else
                    CheckPicturebox78Color()
                    PictureboxAbleToBlock(i) = 60
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox87Color()
                        PictureboxAbleToBlock(i) = 69
                        i = i + 1
                        PictureboxAbleToBlock(i) = 78
                    End If
                Else
                    CheckPicturebox78Color()
                    PictureboxAbleToBlock(i) = 69
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox69Color()
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoF5WestMovementArea()
        i = 1
        If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
            Pic50None()
            If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                Pic49None()
                If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                    Pic48None()
                    If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                        Pic47None()
                        If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                            Pic46None()
                        Else
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox46Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                        End If
                    End If
                Else
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox46Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 47
                        End If
                    Else
                        CheckPicturebox47Color()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox46Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 47
                        End If
                    Else
                        CheckPicturebox47Color()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 48
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox48Color()
                    PictureboxAbleToBlock(i) = 50
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox46Color()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 47
                        End If
                    Else
                        CheckPicturebox47Color()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 48
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox48Color()
                    PictureboxAbleToBlock(i) = 49
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox49Color()
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoF5NorthMovementArea()
        i = 1
        If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
            Pic42None()
            If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                Pic33None()
                If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    Pic24None()
                    If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                        Pic15None()
                        If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                            Pic6None()
                        Else
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox6Color()
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                        End If
                    End If
                Else
                    Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox6Color()
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 15
                        End If
                    Else
                        CheckPicturebox15Color()
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 33
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox6Color()
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                            i = i + 1
                            PictureboxAbleToBlock(i) = 15
                        End If
                    Else
                        CheckPicturebox15Color()
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 24
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox24Color()
                    PictureboxAbleToBlock(i) = 42
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox6Color()
                            PictureboxAbleToBlock(i) = 33
                            i = i + 1
                            PictureboxAbleToBlock(i) = 24
                            i = i + 1
                            PictureboxAbleToBlock(i) = 15
                        End If
                    Else
                        CheckPicturebox15Color()
                        PictureboxAbleToBlock(i) = 33
                        i = i + 1
                        PictureboxAbleToBlock(i) = 24
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox24Color()
                    PictureboxAbleToBlock(i) = 33
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox33Color()
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoG5EastMovementArea()
        i = 1
        If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
            Pic53None()
            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                Pic54None()
            Else
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            End If
        Else
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Else
                CheckPicturebox54Color()
            End If
        End If
    End Sub

    Public Sub PaoG5SouthMovementArea()
        i = 1
        If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
            Form1.PictureBox61.Image = Form1.movementAreaPic.Image
            Pic61None()
            If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
                If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    Pic79None()
                    If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                        Pic88None()
                    Else
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox88Color()
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 70
                    End If
                End If
            Else
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox88Color()
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 79
                    End If
                Else
                    CheckPicturebox79Color()
                    PictureboxAbleToBlock(i) = 61
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox88Color()
                        PictureboxAbleToBlock(i) = 70
                        i = i + 1
                        PictureboxAbleToBlock(i) = 79
                    End If
                Else
                    CheckPicturebox79Color()
                    PictureboxAbleToBlock(i) = 70
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox70Color()
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoG5WestMovementArea()
        i = 1
        If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
            Pic51None()
            If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
                If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    Pic49None()
                    If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                        Pic48None()
                        If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                            Pic47None()
                            If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                Pic46None()
                            Else
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox46Color()
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                            End If
                        End If
                    Else
                        Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox46Color()
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 47
                            End If
                        Else
                            CheckPicturebox47Color()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox46Color()
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 47
                            End If
                        Else
                            CheckPicturebox47Color()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox48Color()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox46Color()
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 47
                            End If
                        Else
                            CheckPicturebox47Color()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox48Color()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox49Color()
                    PictureboxAbleToBlock(i) = 51
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox46Color()
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                i = i + 1
                                PictureboxAbleToBlock(i) = 47
                            End If
                        Else
                            CheckPicturebox47Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 48
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox48Color()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 49
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox49Color()
                    PictureboxAbleToBlock(i) = 50
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox50Color()
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoG5NorthMovementArea()
        i = 1
        If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
            Pic43None()
            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
                If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    Pic25None()
                    If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                        Pic16None()
                        If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                            Pic7None()
                        Else
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox7Color()
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            i = i + 1
                            PictureboxAbleToBlock(i) = 25
                        End If
                    End If
                Else
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox7Color()
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 34
                            i = i + 1
                            PictureboxAbleToBlock(i) = 16
                        End If
                    Else
                        CheckPicturebox16Color()
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 34
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox7Color()
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 25
                            i = i + 1
                            PictureboxAbleToBlock(i) = 16
                        End If
                    Else
                        CheckPicturebox16Color()
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 25
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox25Color()
                    PictureboxAbleToBlock(i) = 43
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox7Color()
                            PictureboxAbleToBlock(i) = 34
                            i = i + 1
                            PictureboxAbleToBlock(i) = 25
                            i = i + 1
                            PictureboxAbleToBlock(i) = 16
                        End If
                    Else
                        CheckPicturebox16Color()
                        PictureboxAbleToBlock(i) = 34
                        i = i + 1
                        PictureboxAbleToBlock(i) = 25
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox25Color()
                    PictureboxAbleToBlock(i) = 34
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox34Color()
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoH5EastMovementArea()
        i = 1
        If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
            Pic54None()
        Else
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub PaoH5SouthMovementArea()
        i = 1
        If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
            Form1.PictureBox62.Image = Form1.movementAreaPic.Image
            Pic62None()
            If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
                If Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                    Pic80None()
                    If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                        Pic89None()
                    Else
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox89Color()
                        PictureboxAbleToBlock(i) = 62
                        i = i + 1
                        PictureboxAbleToBlock(i) = 71
                    End If
                End If
            Else
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox89Color()
                        PictureboxAbleToBlock(i) = 62
                        i = i + 1
                        PictureboxAbleToBlock(i) = 80
                    End If
                Else
                    CheckPicturebox80Color()
                    PictureboxAbleToBlock(i) = 62
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox89Color()
                        PictureboxAbleToBlock(i) = 71
                        i = i + 1
                        PictureboxAbleToBlock(i) = 80
                    End If
                Else
                    CheckPicturebox80Color()
                    PictureboxAbleToBlock(i) = 71
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox71Color()
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoH5WestMovementArea()
        i = 1
        If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
            Pic52None()
            If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                Pic51None()
                If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    Pic50None()
                    If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                        Pic49None()
                        If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                            Pic48None()
                            If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                Pic47None()
                                If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                    Pic46None()
                                Else
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox46Color()
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                End If
                            End If
                        Else
                            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox46Color()
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 47
                                End If
                            Else
                                CheckPicturebox47Color()
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox46Color()
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 47
                                End If
                            Else
                                CheckPicturebox47Color()
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox48Color()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox46Color()
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 47
                                End If
                            Else
                                CheckPicturebox47Color()
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox48Color()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox49Color()
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox46Color()
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 47
                                End If
                            Else
                                CheckPicturebox47Color()
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox48Color()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox49Color()
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox50Color()
                    PictureboxAbleToBlock(i) = 52
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox46Color()
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 47
                                End If
                            Else
                                CheckPicturebox47Color()
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                i = i + 1
                                PictureboxAbleToBlock(i) = 48
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox48Color()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 49
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox49Color()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 50
                        Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox50Color()
                    PictureboxAbleToBlock(i) = 51
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox51Color()
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoH5NorthMovementArea()
        i = 1
        If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
            Pic44None()
            If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
                If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    Pic26None()
                    If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                        Pic17None()
                        If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                            Pic8None()
                        Else
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox8Color()
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            i = i + 1
                            PictureboxAbleToBlock(i) = 26
                        End If
                    End If
                Else
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox8Color()
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 35
                            i = i + 1
                            PictureboxAbleToBlock(i) = 17
                        End If
                    Else
                        CheckPicturebox17Color()
                        PictureboxAbleToBlock(i) = 44
                        i = i + 1
                        PictureboxAbleToBlock(i) = 35
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox8Color()
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 26
                            i = i + 1
                            PictureboxAbleToBlock(i) = 17
                        End If
                    Else
                        CheckPicturebox17Color()
                        PictureboxAbleToBlock(i) = 44
                        i = i + 1
                        PictureboxAbleToBlock(i) = 26
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox26Color()
                    PictureboxAbleToBlock(i) = 44
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox8Color()
                            PictureboxAbleToBlock(i) = 35
                            i = i + 1
                            PictureboxAbleToBlock(i) = 26
                            i = i + 1
                            PictureboxAbleToBlock(i) = 17
                        End If
                    Else
                        CheckPicturebox17Color()
                        PictureboxAbleToBlock(i) = 35
                        i = i + 1
                        PictureboxAbleToBlock(i) = 26
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox26Color()
                    PictureboxAbleToBlock(i) = 35
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox35Color()
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoI5SouthMovementArea()
        i = 1
        If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
            Form1.PictureBox63.Image = Form1.movementAreaPic.Image
            Pic63None()
            If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                Pic72None()
                If Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                    Pic81None()
                    If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                        Pic90None()
                    Else
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox90Color()
                        PictureboxAbleToBlock(i) = 63
                        i = i + 1
                        PictureboxAbleToBlock(i) = 72
                    End If
                End If
            Else
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox90Color()
                        PictureboxAbleToBlock(i) = 63
                        i = i + 1
                        PictureboxAbleToBlock(i) = 81
                    End If
                Else
                    CheckPicturebox81Color()
                    PictureboxAbleToBlock(i) = 63
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox90Color()
                        PictureboxAbleToBlock(i) = 72
                        i = i + 1
                        PictureboxAbleToBlock(i) = 81
                    End If
                Else
                    CheckPicturebox81Color()
                    PictureboxAbleToBlock(i) = 72
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox72Color()
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoI5WestMovementArea()
        i = 1
        If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
            Pic53None()
            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
                If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    Pic51None()
                    If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                        Pic50None()
                        If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                            Pic49None()
                            If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                                Pic48None()
                                If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                                    Pic47None()
                                    If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                                        Pic46None()
                                    Else
                                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                    End If
                                Else
                                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox46Color()
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
                                    End If
                                End If
                            Else
                                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox46Color()
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
                                        PictureboxAbleToBlock(i) = 47
                                    End If
                                Else
                                    CheckPicturebox47Color()
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                End If
                            End If
                        Else
                            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox46Color()
                                        PictureboxAbleToBlock(i) = 53
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 52
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 51
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 50
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 48
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 47
                                    End If
                                Else
                                    CheckPicturebox47Color()
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox48Color()
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox46Color()
                                        PictureboxAbleToBlock(i) = 53
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 52
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 51
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 49
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 48
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 47
                                    End If
                                Else
                                    CheckPicturebox47Color()
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox48Color()
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox49Color()
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox46Color()
                                        PictureboxAbleToBlock(i) = 53
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 52
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 50
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 49
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 48
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 47
                                    End If
                                Else
                                    CheckPicturebox47Color()
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox48Color()
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox49Color()
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox50Color()
                        PictureboxAbleToBlock(i) = 53
                        i = i + 1
                        PictureboxAbleToBlock(i) = 52
                        Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox46Color()
                                        PictureboxAbleToBlock(i) = 53
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
                                    End If
                                Else
                                    CheckPicturebox47Color()
                                    PictureboxAbleToBlock(i) = 53
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox48Color()
                                PictureboxAbleToBlock(i) = 53
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox49Color()
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox50Color()
                        PictureboxAbleToBlock(i) = 53
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox51Color()
                    PictureboxAbleToBlock(i) = 53
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox46Color()
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
                                    End If
                                Else
                                    CheckPicturebox47Color()
                                    PictureboxAbleToBlock(i) = 52
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 51
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 50
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 49
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 48
                                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox48Color()
                                PictureboxAbleToBlock(i) = 52
                                i = i + 1
                                PictureboxAbleToBlock(i) = 51
                                i = i + 1
                                PictureboxAbleToBlock(i) = 50
                                i = i + 1
                                PictureboxAbleToBlock(i) = 49
                                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox49Color()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 50
                            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox50Color()
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 51
                        Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox51Color()
                    PictureboxAbleToBlock(i) = 52
                    Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox52Color()
                Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoI5NorthMovementArea()
        i = 1
        If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
            Pic45None()
            If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                Pic36None()
                If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                    Pic27None()
                    If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                        Pic18None()
                        If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                            Pic9None()
                        Else
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox9Color()
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 36
                            i = i + 1
                            PictureboxAbleToBlock(i) = 27
                        End If
                    End If
                Else
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox9Color()
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 36
                            i = i + 1
                            PictureboxAbleToBlock(i) = 18
                        End If
                    Else
                        CheckPicturebox18Color()
                        PictureboxAbleToBlock(i) = 45
                        i = i + 1
                        PictureboxAbleToBlock(i) = 36
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox9Color()
                            PictureboxAbleToBlock(i) = 45
                            i = i + 1
                            PictureboxAbleToBlock(i) = 27
                            i = i + 1
                            PictureboxAbleToBlock(i) = 18
                        End If
                    Else
                        CheckPicturebox18Color()
                        PictureboxAbleToBlock(i) = 45
                        i = i + 1
                        PictureboxAbleToBlock(i) = 27
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox27Color()
                    PictureboxAbleToBlock(i) = 45
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox9Color()
                            PictureboxAbleToBlock(i) = 36
                            i = i = 1
                            PictureboxAbleToBlock(i) = 27
                            i = i = 1
                            PictureboxAbleToBlock(i) = 18
                        End If
                    Else
                        CheckPicturebox18Color()
                        PictureboxAbleToBlock(i) = 36
                        i = i = 1
                        PictureboxAbleToBlock(i) = 27
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox27Color()
                    PictureboxAbleToBlock(i) = 36
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox36Color()
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoA6EastMovementArea()
        i = 1
        If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
            Pic38None()
            If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                Pic39None()
                If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    Pic40None()
                    If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Pic41None()
                        If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                            Pic42None()
                            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                                Pic43None()
                                If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                    Pic44None()
                                    If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                        Pic45None()
                                    Else
                                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                    End If
                                Else
                                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox45Color()
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
                                    End If
                                End If
                            Else
                                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox45Color()
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
                                        PictureboxAbleToBlock(i) = 44
                                    End If
                                Else
                                    CheckPicturebox44Color()
                                    PictureboxAbleToBlock(i) = 38
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                End If
                            End If
                        Else
                            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox45Color()
                                        PictureboxAbleToBlock(i) = 38
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 39
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 40
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 41
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 43
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 44
                                    End If
                                Else
                                    CheckPicturebox44Color()
                                    PictureboxAbleToBlock(i) = 38
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox43Color()
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox45Color()
                                        PictureboxAbleToBlock(i) = 38
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 39
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 40
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 42
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 43
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 44
                                    End If
                                Else
                                    CheckPicturebox44Color()
                                    PictureboxAbleToBlock(i) = 38
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox43Color()
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox42Color()
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox45Color()
                                        PictureboxAbleToBlock(i) = 38
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 39
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 41
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 42
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 43
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 44
                                    End If
                                Else
                                    CheckPicturebox44Color()
                                    PictureboxAbleToBlock(i) = 38
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox43Color()
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox42Color()
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox41Color()
                        PictureboxAbleToBlock(i) = 38
                        i = i + 1
                        PictureboxAbleToBlock(i) = 39
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox45Color()
                                        PictureboxAbleToBlock(i) = 38
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
                                    End If
                                Else
                                    CheckPicturebox44Color()
                                    PictureboxAbleToBlock(i) = 38
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox43Color()
                                PictureboxAbleToBlock(i) = 38
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox42Color()
                            PictureboxAbleToBlock(i) = 38
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox41Color()
                        PictureboxAbleToBlock(i) = 38
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox40Color()
                    PictureboxAbleToBlock(i) = 38
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox45Color()
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
                                    End If
                                Else
                                    CheckPicturebox44Color()
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox43Color()
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox42Color()
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox41Color()
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox40Color()
                    PictureboxAbleToBlock(i) = 39
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox39Color()
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoA6SouthMovementArea()
        i = 1
        If Form1.PictureBox46.Image Is Form1.nonePic.Image Then
            Form1.PictureBox46.Image = Form1.movementAreaPic.Image
            Pic46None()
            If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                Pic55None()
                If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                    Pic64None()
                    If Form1.PictureBox73.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                        Pic73None()
                        If Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                            Pic82None()
                        Else
                            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox82Color()
                            PictureboxAbleToBlock(i) = 46
                            i = i + 1
                            PictureboxAbleToBlock(i) = 55
                            i = i + 1
                            PictureboxAbleToBlock(i) = 64
                        End If
                    End If
                Else
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox73.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox82Color()
                            PictureboxAbleToBlock(i) = 46
                            i = i + 1
                            PictureboxAbleToBlock(i) = 55
                            i = i + 1
                            PictureboxAbleToBlock(i) = 73
                        End If
                    Else
                        CheckPicturebox73Color()
                        PictureboxAbleToBlock(i) = 46
                        i = i + 1
                        PictureboxAbleToBlock(i) = 55
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox73.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox82Color()
                            PictureboxAbleToBlock(i) = 46
                            i = i + 1
                            PictureboxAbleToBlock(i) = 64
                            i = i + 1
                            PictureboxAbleToBlock(i) = 73
                        End If
                    Else
                        CheckPicturebox73Color()
                        PictureboxAbleToBlock(i) = 46
                        i = i + 1
                        PictureboxAbleToBlock(i) = 64
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox64Color()
                    PictureboxAbleToBlock(i) = 46
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox73.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox82Color()
                            PictureboxAbleToBlock(i) = 55
                            i = i + 1
                            PictureboxAbleToBlock(i) = 64
                            i = i + 1
                            PictureboxAbleToBlock(i) = 73
                        End If
                    Else
                        CheckPicturebox73Color()
                        PictureboxAbleToBlock(i) = 55
                        i = i + 1
                        PictureboxAbleToBlock(i) = 64
                        Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox64Color()
                    PictureboxAbleToBlock(i) = 55
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox55Color()
                Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoA6NorthMovementArea()
        i = 1
        If Form1.PictureBox28.Image Is Form1.nonePic.Image Then
            Form1.PictureBox28.Image = Form1.movementAreaPic.Image
            Pic28None()
            If Form1.PictureBox19.Image Is Form1.nonePic.Image Then
                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                Pic19None()
                If Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                    Pic10None()
                    If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                        Pic1None()
                    Else
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox1Color()
                        PictureboxAbleToBlock(i) = 28
                        i = i + 1
                        PictureboxAbleToBlock(i) = 19
                    End If
                End If
            Else
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox1Color()
                        PictureboxAbleToBlock(i) = 28
                        i = i + 1
                        PictureboxAbleToBlock(i) = 10
                    End If
                Else
                    CheckPicturebox10Color()
                    PictureboxAbleToBlock(i) = 28
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox19.Image Is Form1.nonePic.Image Then
                Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox1Color()
                        PictureboxAbleToBlock(i) = 19
                        i = i + 1
                        PictureboxAbleToBlock(i) = 10
                    End If
                Else
                    CheckPicturebox10Color()
                    PictureboxAbleToBlock(i) = 19
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox19Color()
                Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoB6EastMovementArea()
        i = 1
        If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
            Pic39None()
            If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                Pic40None()
                If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    Pic41None()
                    If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                        Pic42None()
                        If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                            Pic43None()
                            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                                Pic44None()
                                If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                    Pic45None()
                                Else
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox45Color()
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                End If
                            End If
                        Else
                            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox45Color()
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                End If
                            Else
                                CheckPicturebox44Color()
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox45Color()
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                End If
                            Else
                                CheckPicturebox44Color()
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox43Color()
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox45Color()
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                End If
                            Else
                                CheckPicturebox44Color()
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox43Color()
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox42Color()
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox45Color()
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                End If
                            Else
                                CheckPicturebox44Color()
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox43Color()
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox42Color()
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox41Color()
                    PictureboxAbleToBlock(i) = 39
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox45Color()
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 44
                                End If
                            Else
                                CheckPicturebox44Color()
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox43Color()
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox42Color()
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox41Color()
                    PictureboxAbleToBlock(i) = 40
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox40Color()
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoB6SouthMovementArea()
        i = 1
        If Form1.PictureBox47.Image Is Form1.nonePic.Image Then
            Form1.PictureBox47.Image = Form1.movementAreaPic.Image
            Pic47None()
            If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                Pic56None()
                If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                    Pic65None()
                    If Form1.PictureBox74.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                        Pic74None()
                        If Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                            Pic83None()
                        Else
                            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox83Color()
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 56
                            i = i + 1
                            PictureboxAbleToBlock(i) = 65
                        End If
                    End If
                Else
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox74.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox83Color()
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 56
                            i = i + 1
                            PictureboxAbleToBlock(i) = 74
                        End If
                    Else
                        CheckPicturebox74Color()
                        PictureboxAbleToBlock(i) = 47
                        i = i + 1
                        PictureboxAbleToBlock(i) = 56
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox74.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox83Color()
                            PictureboxAbleToBlock(i) = 47
                            i = i + 1
                            PictureboxAbleToBlock(i) = 65
                            i = i + 1
                            PictureboxAbleToBlock(i) = 74
                        End If
                    Else
                        CheckPicturebox74Color()
                        PictureboxAbleToBlock(i) = 47
                        i = i + 1
                        PictureboxAbleToBlock(i) = 65
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox65Color()
                    PictureboxAbleToBlock(i) = 47
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox74.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox83Color()
                            PictureboxAbleToBlock(i) = 56
                            i = i + 1
                            PictureboxAbleToBlock(i) = 65
                            i = i + 1
                            PictureboxAbleToBlock(i) = 74
                        End If
                    Else
                        CheckPicturebox74Color()
                        PictureboxAbleToBlock(i) = 56
                        i = i + 1
                        PictureboxAbleToBlock(i) = 65
                        Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox65Color()
                    PictureboxAbleToBlock(i) = 56
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox56Color()
                Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoB6WestMovementArea()
        i = 1
        If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
            Pic37None()
        Else
            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub PaoB6NorthMovementArea()
        i = 1
        If Form1.PictureBox29.Image Is Form1.nonePic.Image Then
            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
            Pic29None()
            If Form1.PictureBox20.Image Is Form1.nonePic.Image Then
                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                Pic20None()
                If Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                    Pic11None()
                    If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                        Pic2None()
                    Else
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox2Color()
                        PictureboxAbleToBlock(i) = 29
                        i = i + 1
                        PictureboxAbleToBlock(i) = 20
                    End If
                End If
            Else
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox2Color()
                        PictureboxAbleToBlock(i) = 29
                        i = i + 1
                        PictureboxAbleToBlock(i) = 11
                    End If
                Else
                    CheckPicturebox11Color()
                    PictureboxAbleToBlock(i) = 29
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox20.Image Is Form1.nonePic.Image Then
                Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox2Color()
                        PictureboxAbleToBlock(i) = 20
                        i = i + 1
                        PictureboxAbleToBlock(i) = 11
                    End If
                Else
                    CheckPicturebox11Color()
                    PictureboxAbleToBlock(i) = 20
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox20Color()
                Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoC6EastMovementArea()
        i = 1
        If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
            Pic40None()
            If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
                If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    Pic42None()
                    If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                        Pic43None()
                        If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                            Pic44None()
                            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                                Pic45None()
                            Else
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox45Color()
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                            End If
                        End If
                    Else
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox45Color()
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                            End If
                        Else
                            CheckPicturebox44Color()
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox45Color()
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                            End If
                        Else
                            CheckPicturebox44Color()
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox43Color()
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox45Color()
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                            End If
                        Else
                            CheckPicturebox44Color()
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox43Color()
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox42Color()
                    PictureboxAbleToBlock(i) = 40
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox45Color()
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 44
                            End If
                        Else
                            CheckPicturebox44Color()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox43Color()
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox42Color()
                    PictureboxAbleToBlock(i) = 41
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox41Color()
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoC6SouthMovementArea()
        i = 1
        If Form1.PictureBox48.Image Is Form1.nonePic.Image Then
            Form1.PictureBox48.Image = Form1.movementAreaPic.Image
            Pic48None()
            If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                Pic57None()
                If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                    Pic66None()
                    If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                        Pic75None()
                        If Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                            Pic84None()
                        Else
                            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox84Color()
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                        End If
                    End If
                Else
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox84Color()
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 75
                        End If
                    Else
                        CheckPicturebox75Color()
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 57
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox84Color()
                            PictureboxAbleToBlock(i) = 48
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                            i = i + 1
                            PictureboxAbleToBlock(i) = 75
                        End If
                    Else
                        CheckPicturebox75Color()
                        PictureboxAbleToBlock(i) = 48
                        i = i + 1
                        PictureboxAbleToBlock(i) = 66
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox66Color()
                    PictureboxAbleToBlock(i) = 48
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox84Color()
                            PictureboxAbleToBlock(i) = 57
                            i = i + 1
                            PictureboxAbleToBlock(i) = 66
                            i = i + 1
                            PictureboxAbleToBlock(i) = 75
                        End If
                    Else
                        CheckPicturebox75Color()
                        PictureboxAbleToBlock(i) = 57
                        i = i + 1
                        PictureboxAbleToBlock(i) = 66
                        Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox66Color()
                    PictureboxAbleToBlock(i) = 57
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox57Color()
                Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoC6WestMovementArea()
        i = 1
        If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
            Pic38None()
            If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                Pic37None()
            Else
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            End If
        Else
            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            Else
                CheckPicturebox37Color()
            End If
        End If
    End Sub

    Public Sub PaoC6NorthMovementArea()
        i = 1
        If Form1.PictureBox30.Image Is Form1.nonePic.Image Then
            Form1.PictureBox30.Image = Form1.movementAreaPic.Image
            Pic30None()
            If Form1.PictureBox21.Image Is Form1.nonePic.Image Then
                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                Pic21None()
                If Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                    Pic12None()
                    If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                        Pic3None()
                    Else
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox3Color()
                        PictureboxAbleToBlock(i) = 30
                        i = i + 1
                        PictureboxAbleToBlock(i) = 21
                    End If
                End If
            Else
                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox3Color()
                        PictureboxAbleToBlock(i) = 30
                        i = i + 1
                        PictureboxAbleToBlock(i) = 12
                    End If
                Else
                    CheckPicturebox12Color()
                    PictureboxAbleToBlock(i) = 30
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox21.Image Is Form1.nonePic.Image Then
                Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox3Color()
                        PictureboxAbleToBlock(i) = 21
                        i = i + 1
                        PictureboxAbleToBlock(i) = 12
                    End If
                Else
                    CheckPicturebox12Color()
                    PictureboxAbleToBlock(i) = 21
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox21Color()
                Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoD6EastMovementArea()
        i = 1
        If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
            Pic41None()
            If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                Pic42None()
                If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    Pic43None()
                    If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                        Pic44None()
                        If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                            Pic45None()
                        Else
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox45Color()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                        End If
                    End If
                Else
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox45Color()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                        End If
                    Else
                        CheckPicturebox44Color()
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox45Color()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                        End If
                    Else
                        CheckPicturebox44Color()
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox43Color()
                    PictureboxAbleToBlock(i) = 41
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox45Color()
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 44
                        End If
                    Else
                        CheckPicturebox44Color()
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox43Color()
                    PictureboxAbleToBlock(i) = 42
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox42Color()
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoD6SouthMovementArea()
        i = 1
        If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
            Form1.PictureBox49.Image = Form1.movementAreaPic.Image
            Pic49None()
            If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                Pic58None()
                If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                    Pic67None()
                    If Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                        Pic76None()
                        If Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                            Pic85None()
                        Else
                            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox85Color()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                        End If
                    End If
                Else
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox85Color()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 76
                        End If
                    Else
                        CheckPicturebox76Color()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 58
                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox85Color()
                            PictureboxAbleToBlock(i) = 49
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 76
                        End If
                    Else
                        CheckPicturebox76Color()
                        PictureboxAbleToBlock(i) = 49
                        i = i + 1
                        PictureboxAbleToBlock(i) = 67
                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox67Color()
                    PictureboxAbleToBlock(i) = 49
                    Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox85Color()
                            PictureboxAbleToBlock(i) = 58
                            i = i + 1
                            PictureboxAbleToBlock(i) = 67
                            i = i + 1
                            PictureboxAbleToBlock(i) = 76
                        End If
                    Else
                        CheckPicturebox76Color()
                        PictureboxAbleToBlock(i) = 58
                        i = i + 1
                        PictureboxAbleToBlock(i) = 67
                        Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox67Color()
                    PictureboxAbleToBlock(i) = 58
                    Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox58Color()
                Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoD6WestMovementArea()
        i = 1
        If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
            Pic39None()
            If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                Pic38None()
                If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                    Pic37None()
                Else
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox37Color()
                    PictureboxAbleToBlock(i) = 39
                End If
            End If
        Else
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox37Color()
                    PictureboxAbleToBlock(i) = 38
                End If
            Else
                CheckPicturebox38Color()
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoD6NorthMovementArea()
        i = 1
        If Form1.PictureBox31.Image Is Form1.nonePic.Image Then
            Form1.PictureBox31.Image = Form1.movementAreaPic.Image
            Pic31None()
            If Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                Pic22None()
                If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                    Pic13None()
                    If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                        Pic4None()
                    Else
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox4Color()
                        PictureboxAbleToBlock(i) = 31
                        i = i + 1
                        PictureboxAbleToBlock(i) = 22
                    End If
                End If
            Else
                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox4Color()
                        PictureboxAbleToBlock(i) = 31
                        i = i + 1
                        PictureboxAbleToBlock(i) = 13
                    End If
                Else
                    CheckPicturebox13Color()
                    PictureboxAbleToBlock(i) = 31
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox4Color()
                        PictureboxAbleToBlock(i) = 22
                        i = i + 1
                        PictureboxAbleToBlock(i) = 13
                    End If
                Else
                    CheckPicturebox13Color()
                    PictureboxAbleToBlock(i) = 22
                    Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox22Color()
                Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoE6EastMovementArea()
        i = 1
        If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
            Pic42None()
            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
                If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    Pic44None()
                    If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                        Pic45None()
                    Else
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox45Color()
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                    End If
                End If
            Else
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox45Color()
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 44
                    End If
                Else
                    CheckPicturebox44Color()
                    PictureboxAbleToBlock(i) = 42
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox45Color()
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 44
                    End If
                Else
                    CheckPicturebox44Color()
                    PictureboxAbleToBlock(i) = 43
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox43Color()
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoE6SouthMovementArea()
        i = 1
        If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
            Form1.PictureBox50.Image = Form1.movementAreaPic.Image
            Pic50None()
            If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                Pic59None()
                If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    Pic68None()
                    If Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                        Pic77None()
                        If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                            Pic86None()
                        Else
                            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox86Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                        End If
                    End If
                Else
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox86Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 77
                        End If
                    Else
                        CheckPicturebox77Color()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 59
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox86Color()
                            PictureboxAbleToBlock(i) = 50
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 77
                        End If
                    Else
                        CheckPicturebox77Color()
                        PictureboxAbleToBlock(i) = 50
                        i = i + 1
                        PictureboxAbleToBlock(i) = 68
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox68Color()
                    PictureboxAbleToBlock(i) = 50
                    Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox86Color()
                            PictureboxAbleToBlock(i) = 59
                            i = i + 1
                            PictureboxAbleToBlock(i) = 68
                            i = i + 1
                            PictureboxAbleToBlock(i) = 77
                        End If
                    Else
                        CheckPicturebox77Color()
                        PictureboxAbleToBlock(i) = 59
                        i = i + 1
                        PictureboxAbleToBlock(i) = 68
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox68Color()
                    PictureboxAbleToBlock(i) = 59
                    Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox59Color()
                Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoE6WestMovementArea()
        i = 1
        If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
            Pic40None()
            If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                Pic39None()
                If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                    Pic38None()
                    If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                        Pic37None()
                    Else
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox37Color()
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 39
                    End If
                End If
            Else
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox37Color()
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 38
                    End If
                Else
                    CheckPicturebox38Color()
                    PictureboxAbleToBlock(i) = 40
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox37Color()
                        PictureboxAbleToBlock(i) = 39
                        i = i + 1
                        PictureboxAbleToBlock(i) = 38
                    End If
                Else
                    CheckPicturebox38Color()
                    PictureboxAbleToBlock(i) = 39
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox39Color()
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoE6NorthMovementArea()
        i = 1
        If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
            Form1.PictureBox32.Image = Form1.movementAreaPic.Image
            Pic32None()
            If Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
                If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    Pic14None()
                    If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                        Pic5None()
                    Else
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox5Color()
                        PictureboxAbleToBlock(i) = 32
                        i = i + 1
                        PictureboxAbleToBlock(i) = 23
                    End If
                End If
            Else
                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox5Color()
                        PictureboxAbleToBlock(i) = 32
                        i = i + 1
                        PictureboxAbleToBlock(i) = 14
                    End If
                Else
                    CheckPicturebox14Color()
                    PictureboxAbleToBlock(i) = 32
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox5Color()
                        PictureboxAbleToBlock(i) = 23
                        i = i + 1
                        PictureboxAbleToBlock(i) = 14
                    End If
                Else
                    CheckPicturebox14Color()
                    PictureboxAbleToBlock(i) = 23
                    Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox23Color()
                Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoF6EastMovementArea()
        i = 1
        If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
            Pic43None()
            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
                If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    Pic45None()
                Else
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox45Color()
                    PictureboxAbleToBlock(i) = 43
                End If
            End If
        Else
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                Else
                    CheckPicturebox45Color()
                    PictureboxAbleToBlock(i) = 44
                End If
            Else
                CheckPicturebox44Color()
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoF6SouthMovementArea()
        i = 1
        If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
            Form1.PictureBox51.Image = Form1.movementAreaPic.Image
            Pic51None()
            If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
                If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    Pic69None()
                    If Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                        Pic78None()
                        If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                            Pic87None()
                        Else
                            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox87Color()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                        End If
                    End If
                Else
                    Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox87Color()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 78
                        End If
                    Else
                        CheckPicturebox78Color()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 60
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox87Color()
                            PictureboxAbleToBlock(i) = 51
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 78
                        End If
                    Else
                        CheckPicturebox78Color()
                        PictureboxAbleToBlock(i) = 51
                        i = i + 1
                        PictureboxAbleToBlock(i) = 69
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox69Color()
                    PictureboxAbleToBlock(i) = 51
                    Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox87Color()
                            PictureboxAbleToBlock(i) = 60
                            i = i + 1
                            PictureboxAbleToBlock(i) = 69
                            i = i + 1
                            PictureboxAbleToBlock(i) = 78
                        End If
                    Else
                        CheckPicturebox78Color()
                        PictureboxAbleToBlock(i) = 60
                        i = i + 1
                        PictureboxAbleToBlock(i) = 69
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox69Color()
                    PictureboxAbleToBlock(i) = 60
                    Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox60Color()
                Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoF6WestMovementArea()
        i = 1
        If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
            Form1.PictureBox41.Image = Form1.movementAreaPic.Image
            Pic41None()
            If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                Pic40None()
                If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                    Pic39None()
                    If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                        Pic38None()
                        If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                            Pic37None()
                        Else
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox37Color()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                        End If
                    End If
                Else
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox37Color()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 38
                        End If
                    Else
                        CheckPicturebox38Color()
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox37Color()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 38
                        End If
                    Else
                        CheckPicturebox38Color()
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 39
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox39Color()
                    PictureboxAbleToBlock(i) = 41
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox37Color()
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            i = i + 1
                            PictureboxAbleToBlock(i) = 38
                        End If
                    Else
                        CheckPicturebox38Color()
                        PictureboxAbleToBlock(i) = 40
                        i = i + 1
                        PictureboxAbleToBlock(i) = 39
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox39Color()
                    PictureboxAbleToBlock(i) = 40
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox40Color()
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoF6NorthMovementArea()
        i = 1
        If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
            Pic33None()
            If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
                If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    Pic15None()
                    If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                        Pic6None()
                    Else
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox6Color()
                        PictureboxAbleToBlock(i) = 33
                        i = i + 1
                        PictureboxAbleToBlock(i) = 24
                    End If
                End If
            Else
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox6Color()
                        PictureboxAbleToBlock(i) = 33
                        i = i + 1
                        PictureboxAbleToBlock(i) = 15
                    End If
                Else
                    CheckPicturebox15Color()
                    PictureboxAbleToBlock(i) = 33
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox6Color()
                        PictureboxAbleToBlock(i) = 24
                        i = i + 1
                        PictureboxAbleToBlock(i) = 15
                    End If
                Else
                    CheckPicturebox15Color()
                    PictureboxAbleToBlock(i) = 24
                    Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox24Color()
                Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoG6EastMovementArea()
        If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
            Pic44None()
            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                Pic45None()
            Else
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            End If
        Else
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Else
                CheckPicturebox45Color()
            End If
        End If
    End Sub

    Public Sub PaoG6SouthMovementArea()
        i = 1
        If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
            Form1.PictureBox52.Image = Form1.movementAreaPic.Image
            Pic52None()
            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
                If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    Pic70None()
                    If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                        Pic79None()
                        If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                            Pic88None()
                        Else
                            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox88Color()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 70
                        End If
                    End If
                Else
                    Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox88Color()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 79
                        End If
                    Else
                        CheckPicturebox79Color()
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 61
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox88Color()
                            PictureboxAbleToBlock(i) = 52
                            i = i + 1
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 79
                        End If
                    Else
                        CheckPicturebox79Color()
                        PictureboxAbleToBlock(i) = 52
                        i = i + 1
                        PictureboxAbleToBlock(i) = 70
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox70Color()
                    PictureboxAbleToBlock(i) = 52
                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox88Color()
                            PictureboxAbleToBlock(i) = 61
                            i = i + 1
                            PictureboxAbleToBlock(i) = 70
                            i = i + 1
                            PictureboxAbleToBlock(i) = 79
                        End If
                    Else
                        CheckPicturebox79Color()
                        PictureboxAbleToBlock(i) = 61
                        i = i + 1
                        PictureboxAbleToBlock(i) = 70
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox70Color()
                    PictureboxAbleToBlock(i) = 61
                    Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox61Color()
                Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoG6WestMovementArea()
        i = 1
        If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
            Form1.PictureBox42.Image = Form1.movementAreaPic.Image
            Pic42None()
            If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
                If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    Pic40None()
                    If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                        Pic39None()
                        If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                            Pic38None()
                            If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                Pic37None()
                            Else
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox37Color()
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                            End If
                        End If
                    Else
                        Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox37Color()
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                            End If
                        Else
                            CheckPicturebox38Color()
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox37Color()
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                            End If
                        Else
                            CheckPicturebox38Color()
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox39Color()
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox37Color()
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                            End If
                        Else
                            CheckPicturebox38Color()
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox39Color()
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox40Color()
                    PictureboxAbleToBlock(i) = 42
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            Else
                                CheckPicturebox37Color()
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                i = i + 1
                                PictureboxAbleToBlock(i) = 38
                            End If
                        Else
                            CheckPicturebox38Color()
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            i = i + 1
                            PictureboxAbleToBlock(i) = 39
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox39Color()
                        PictureboxAbleToBlock(i) = 41
                        i = i + 1
                        PictureboxAbleToBlock(i) = 40
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox40Color()
                    PictureboxAbleToBlock(i) = 41
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox41Color()
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoG6NorthMovementArea()
        i = 1
        If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
            Form1.PictureBox34.Image = Form1.movementAreaPic.Image
            Pic34None()
            If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                Pic25None()
                If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    Pic16None()
                    If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                        Pic7None()
                    Else
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox7Color()
                        PictureboxAbleToBlock(i) = 34
                        i = i + 1
                        PictureboxAbleToBlock(i) = 25
                    End If
                End If
            Else
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox7Color()
                        PictureboxAbleToBlock(i) = 34
                        i = i + 1
                        PictureboxAbleToBlock(i) = 16
                    End If
                Else
                    CheckPicturebox16Color()
                    PictureboxAbleToBlock(i) = 34
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox7Color()
                        PictureboxAbleToBlock(i) = 25
                        i = i + 1
                        PictureboxAbleToBlock(i) = 16
                    End If
                Else
                    CheckPicturebox16Color()
                    PictureboxAbleToBlock(i) = 25
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox25Color()
                Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoH6EastMovementArea()
        i = 1
        If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
            Form1.PictureBox45.Image = Form1.movementAreaPic.Image
            Pic45None()
        Else
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub PaoH6SouthMovementArea()
        i = 1
        If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
            Form1.PictureBox53.Image = Form1.movementAreaPic.Image
            Pic53None()
            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
                If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    Pic71None()
                    If Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                        Pic80None()
                        If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                            Pic89None()
                        Else
                            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox89Color()
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 71
                        End If
                    End If
                Else
                    Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox89Color()
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 80
                        End If
                    Else
                        CheckPicturebox80Color()
                        PictureboxAbleToBlock(i) = 53
                        i = i + 1
                        PictureboxAbleToBlock(i) = 62
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox89Color()
                            PictureboxAbleToBlock(i) = 53
                            i = i + 1
                            PictureboxAbleToBlock(i) = 71
                            i = i + 1
                            PictureboxAbleToBlock(i) = 80
                        End If
                    Else
                        CheckPicturebox80Color()
                        PictureboxAbleToBlock(i) = 53
                        i = i + 1
                        PictureboxAbleToBlock(i) = 71
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox71Color()
                    PictureboxAbleToBlock(i) = 53
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox89Color()
                            PictureboxAbleToBlock(i) = 62
                            i = i + 1
                            PictureboxAbleToBlock(i) = 71
                            i = i + 1
                            PictureboxAbleToBlock(i) = 80
                        End If
                    Else
                        CheckPicturebox80Color()
                        PictureboxAbleToBlock(i) = 62
                        i = i + 1
                        PictureboxAbleToBlock(i) = 71
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox71Color()
                    PictureboxAbleToBlock(i) = 62
                    Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox62Color()
                Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoH6WestMovementArea()
        i = 1
        If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
            Form1.PictureBox43.Image = Form1.movementAreaPic.Image
            Pic43None()
            If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                Pic42None()
                If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    Pic41None()
                    If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                        Pic40None()
                        If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                            Pic39None()
                            If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                Pic38None()
                                If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                    Pic37None()
                                Else
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox37Color()
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                End If
                            End If
                        Else
                            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox37Color()
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 38
                                End If
                            Else
                                CheckPicturebox38Color()
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox37Color()
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 38
                                End If
                            Else
                                CheckPicturebox38Color()
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox39Color()
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox37Color()
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 38
                                End If
                            Else
                                CheckPicturebox38Color()
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox39Color()
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox40Color()
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox37Color()
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 38
                                End If
                            Else
                                CheckPicturebox38Color()
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox39Color()
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox40Color()
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox41Color()
                    PictureboxAbleToBlock(i) = 43
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                Else
                                    CheckPicturebox37Color()
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 38
                                End If
                            Else
                                CheckPicturebox38Color()
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                i = i + 1
                                PictureboxAbleToBlock(i) = 39
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox39Color()
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            i = i + 1
                            PictureboxAbleToBlock(i) = 40
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox40Color()
                        PictureboxAbleToBlock(i) = 42
                        i = i + 1
                        PictureboxAbleToBlock(i) = 41
                        Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox41Color()
                    PictureboxAbleToBlock(i) = 42
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox42Color()
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoH6NorthMovementArea()
        i = 1
        If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
            Form1.PictureBox35.Image = Form1.movementAreaPic.Image
            Pic35None()
            If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
                If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    Pic17None()
                    If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                        Pic8None()
                    Else
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox8Color()
                        PictureboxAbleToBlock(i) = 35
                        i = i + 1
                        PictureboxAbleToBlock(i) = 26
                    End If
                End If
            Else
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox8Color()
                        PictureboxAbleToBlock(i) = 35
                        i = i + 1
                        PictureboxAbleToBlock(i) = 17
                    End If
                Else
                    CheckPicturebox17Color()
                    PictureboxAbleToBlock(i) = 35
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox8Color()
                        PictureboxAbleToBlock(i) = 26
                        i = i + 1
                        PictureboxAbleToBlock(i) = 17
                    End If
                Else
                    CheckPicturebox17Color()
                    PictureboxAbleToBlock(i) = 26
                    Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox26Color()
                Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoI6SouthMovementArea()
        i = 1
        If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
            Form1.PictureBox54.Image = Form1.movementAreaPic.Image
            Pic54None()
            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                Pic63None()
                If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                    Pic72None()
                    If Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                        Pic81None()
                        If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                            Pic90None()
                        Else
                            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox90Color()
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 63
                            i = i + 1
                            PictureboxAbleToBlock(i) = 72
                        End If
                    End If
                Else
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox90Color()
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 63
                            i = i + 1
                            PictureboxAbleToBlock(i) = 81
                        End If
                    Else
                        CheckPicturebox81Color()
                        PictureboxAbleToBlock(i) = 54
                        i = i + 1
                        PictureboxAbleToBlock(i) = 63
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox90Color()
                            PictureboxAbleToBlock(i) = 54
                            i = i + 1
                            PictureboxAbleToBlock(i) = 72
                            i = i + 1
                            PictureboxAbleToBlock(i) = 81
                        End If
                    Else
                        CheckPicturebox81Color()
                        PictureboxAbleToBlock(i) = 54
                        i = i + 1
                        PictureboxAbleToBlock(i) = 72
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox72Color()
                    PictureboxAbleToBlock(i) = 54
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                        Else
                            CheckPicturebox90Color()
                            PictureboxAbleToBlock(i) = 63
                            i = i + 1
                            PictureboxAbleToBlock(i) = 72
                            i = i + 1
                            PictureboxAbleToBlock(i) = 81
                        End If
                    Else
                        CheckPicturebox81Color()
                        PictureboxAbleToBlock(i) = 63
                        i = i + 1
                        PictureboxAbleToBlock(i) = 72
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox72Color()
                    PictureboxAbleToBlock(i) = 63
                    Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox63Color()
                Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoI6WestMovementArea()
        i = 1
        If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
            Form1.PictureBox44.Image = Form1.movementAreaPic.Image
            Pic44None()
            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
                If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    Pic42None()
                    If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                        Pic41None()
                        If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                            Pic40None()
                            If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                                Pic39None()
                                If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                                    Pic38None()
                                    If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                                        Pic37None()
                                    Else
                                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                    End If
                                Else
                                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox37Color()
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
                                    End If
                                End If
                            Else
                                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox37Color()
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
                                        PictureboxAbleToBlock(i) = 38
                                    End If
                                Else
                                    CheckPicturebox38Color()
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                End If
                            End If
                        Else
                            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox37Color()
                                        PictureboxAbleToBlock(i) = 44
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 43
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 42
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 41
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 39
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 38
                                    End If
                                Else
                                    CheckPicturebox38Color()
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox39Color()
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox37Color()
                                        PictureboxAbleToBlock(i) = 44
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 43
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 42
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 40
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 39
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 38
                                    End If
                                Else
                                    CheckPicturebox38Color()
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox39Color()
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox40Color()
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox37Color()
                                        PictureboxAbleToBlock(i) = 44
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 43
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 41
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 40
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 39
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 38
                                    End If
                                Else
                                    CheckPicturebox38Color()
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox39Color()
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox40Color()
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox41Color()
                        PictureboxAbleToBlock(i) = 44
                        i = i + 1
                        PictureboxAbleToBlock(i) = 43
                        Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox37Color()
                                        PictureboxAbleToBlock(i) = 44
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
                                    End If
                                Else
                                    CheckPicturebox38Color()
                                    PictureboxAbleToBlock(i) = 44
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox39Color()
                                PictureboxAbleToBlock(i) = 44
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox40Color()
                            PictureboxAbleToBlock(i) = 44
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox41Color()
                        PictureboxAbleToBlock(i) = 44
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox42Color()
                    PictureboxAbleToBlock(i) = 44
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox37Color()
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
                                    End If
                                Else
                                    CheckPicturebox38Color()
                                    PictureboxAbleToBlock(i) = 43
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 42
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 41
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 40
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 39
                                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox39Color()
                                PictureboxAbleToBlock(i) = 43
                                i = i + 1
                                PictureboxAbleToBlock(i) = 42
                                i = i + 1
                                PictureboxAbleToBlock(i) = 41
                                i = i + 1
                                PictureboxAbleToBlock(i) = 40
                                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox40Color()
                            PictureboxAbleToBlock(i) = 43
                            i = i + 1
                            PictureboxAbleToBlock(i) = 42
                            i = i + 1
                            PictureboxAbleToBlock(i) = 41
                            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox41Color()
                        PictureboxAbleToBlock(i) = 43
                        i = i + 1
                        PictureboxAbleToBlock(i) = 42
                        Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox42Color()
                    PictureboxAbleToBlock(i) = 43
                    Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox43Color()
                Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoI6NorthMovementArea()
        i = 1
        If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
            Form1.PictureBox36.Image = Form1.movementAreaPic.Image
            Pic36None()
            If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                Pic27None()
                If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                    Pic18None()
                    If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                        Pic9None()
                    Else
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox9Color()
                        PictureboxAbleToBlock(i) = 36
                        i = i + 1
                        PictureboxAbleToBlock(i) = 27
                    End If
                End If
            Else
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox9Color()
                        PictureboxAbleToBlock(i) = 36
                        i = i + 1
                        PictureboxAbleToBlock(i) = 18
                    End If
                Else
                    CheckPicturebox18Color()
                    PictureboxAbleToBlock(i) = 36
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    Else
                        CheckPicturebox9Color()
                        PictureboxAbleToBlock(i) = 27
                        i = i + 1
                        PictureboxAbleToBlock(i) = 18
                    End If
                Else
                    CheckPicturebox18Color()
                    PictureboxAbleToBlock(i) = 27
                    Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox27Color()
                Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub

    Public Sub PaoA7EastMovementArea()
        i = 1
        If Form1.PictureBox29.Image Is Form1.nonePic.Image Then
            Form1.PictureBox29.Image = Form1.movementAreaPic.Image
            Pic29None()
            If Form1.PictureBox30.Image Is Form1.nonePic.Image Then
                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                Pic30None()
                If Form1.PictureBox31.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    Pic31None()
                    If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                        Pic32None()
                        If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                            Pic33None()
                            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                                Pic34None()
                                If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                                    Pic35None()
                                    If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                                        Pic36None()
                                    Else
                                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                    End If
                                Else
                                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox36Color()
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
                                    End If
                                End If
                            Else
                                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox36Color()
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
                                        PictureboxAbleToBlock(i) = 35
                                    End If
                                Else
                                    CheckPicturebox35Color()
                                    PictureboxAbleToBlock(i) = 29
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 30
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                End If
                            End If
                        Else
                            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox36Color()
                                        PictureboxAbleToBlock(i) = 29
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 30
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 31
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 32
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 34
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 35
                                    End If
                                Else
                                    CheckPicturebox35Color()
                                    PictureboxAbleToBlock(i) = 29
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 30
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox34Color()
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                            End If
                        End If
                    Else
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox36Color()
                                        PictureboxAbleToBlock(i) = 29
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 30
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 31
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 33
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 34
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 35
                                    End If
                                Else
                                    CheckPicturebox35Color()
                                    PictureboxAbleToBlock(i) = 29
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 30
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox34Color()
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox33Color()
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                        End If
                    End If
                Else
                    Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox36Color()
                                        PictureboxAbleToBlock(i) = 29
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 30
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 32
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 33
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 34
                                        i = i + 1
                                        PictureboxAbleToBlock(i) = 35
                                    End If
                                Else
                                    CheckPicturebox35Color()
                                    PictureboxAbleToBlock(i) = 29
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 30
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox34Color()
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox33Color()
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox32Color()
                        PictureboxAbleToBlock(i) = 29
                        i = i + 1
                        PictureboxAbleToBlock(i) = 30
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    End If
                End If
            Else
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox31.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox36Color()
                                        PictureboxAbleToBlock(i) = 29
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
                                    End If
                                Else
                                    CheckPicturebox35Color()
                                    PictureboxAbleToBlock(i) = 29
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox34Color()
                                PictureboxAbleToBlock(i) = 29
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox33Color()
                            PictureboxAbleToBlock(i) = 29
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox32Color()
                        PictureboxAbleToBlock(i) = 29
                        i = i + 1
                        PictureboxAbleToBlock(i) = 31
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox31Color()
                    PictureboxAbleToBlock(i) = 29
                    Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                End If
            End If
        Else
            Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
            If Form1.PictureBox30.Image Is Form1.nonePic.Image Then
                Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                If Form1.PictureBox31.Image Is Form1.nonePic.Image Then
                    Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                        If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                                If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                                    If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                    Else
                                        CheckPicturebox36Color()
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
                                    End If
                                Else
                                    CheckPicturebox35Color()
                                    PictureboxAbleToBlock(i) = 30
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 31
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 32
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 33
                                    i = i + 1
                                    PictureboxAbleToBlock(i) = 34
                                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                                End If
                            Else
                                CheckPicturebox34Color()
                                PictureboxAbleToBlock(i) = 30
                                i = i + 1
                                PictureboxAbleToBlock(i) = 31
                                i = i + 1
                                PictureboxAbleToBlock(i) = 32
                                i = i + 1
                                PictureboxAbleToBlock(i) = 33
                                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                            End If
                        Else
                            CheckPicturebox33Color()
                            PictureboxAbleToBlock(i) = 30
                            i = i + 1
                            PictureboxAbleToBlock(i) = 31
                            i = i + 1
                            PictureboxAbleToBlock(i) = 32
                            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                        End If
                    Else
                        CheckPicturebox32Color()
                        PictureboxAbleToBlock(i) = 30
                        i = i + 1
                        PictureboxAbleToBlock(i) = 31
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    End If
                Else
                    CheckPicturebox31Color()
                    PictureboxAbleToBlock(i) = 30
                    Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                End If
            Else
                CheckPicturebox30Color()
                Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            End If
        End If
    End Sub
End Module
