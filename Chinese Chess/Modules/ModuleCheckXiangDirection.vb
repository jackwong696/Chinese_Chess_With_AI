' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 26/01/2011
' Descriptions : Chinese Chess V1

Module ModuleCheckXiangDirection
    Dim i As Integer

    Public Sub BlackXiangA3NorthEastMovementArea()
        i = 1
        If (Form1.PictureBox56.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 56
            If (Form1.PictureBox48.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic48Protected()
                End If
            ElseIf (Form1.PictureBox48.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox48.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox48.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox48.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic48Attacked()
                End If
            ElseIf Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                Pic48None()
            End If
        Else
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangA3SouthEastMovementArea()
        i = 1
        If (Form1.PictureBox74.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 74
            If (Form1.PictureBox84.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic84Protected()
                End If
            ElseIf (Form1.PictureBox84.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox84.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox84.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox84.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic84Attacked()
                End If
            ElseIf Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                Pic84None()
            End If
        Else
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangC1NorthEastMovementArea()
        i = 1
        If (Form1.PictureBox76.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 76
            If (Form1.PictureBox68.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic68Protected()
                End If
            ElseIf (Form1.PictureBox68.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic68Attacked()
                End If
            ElseIf Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
            End If
        Else
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangC1NorthWestMovementArea()
        i = 0
        If (Form1.PictureBox74.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 74
            If (Form1.PictureBox64.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic64Protected()
                End If
            ElseIf (Form1.PictureBox64.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox64.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox64.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox64.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic64Attacked()
                End If
            ElseIf Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                Pic64None()
            End If
        Else
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangC5SouthWestMovementArea()
        i = 1
        If (Form1.PictureBox56.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 56
            If (Form1.PictureBox64.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic64Protected()
                End If
            ElseIf (Form1.PictureBox64.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox64.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox64.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox64.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic64Attacked()
                End If
            ElseIf Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                Pic64None()
            End If
        Else
            Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangC5SouthEastMovementArea()
        i = 1
        If (Form1.PictureBox58.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 58
            If (Form1.PictureBox68.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic68Protected()
                End If
            ElseIf (Form1.PictureBox68.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic68Attacked()
                End If
            ElseIf Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
            End If
        Else
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangE3NorthEastMovementArea()
        i = 1
        If (Form1.PictureBox60.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 60
            If (Form1.PictureBox52.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox52.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox52.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox52.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic52Protected()
                End If
            ElseIf (Form1.PictureBox52.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox52.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox52.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox52.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic52Attacked()
                End If
            ElseIf Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
            End If
        Else
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangE3NorthWestMovementArea()
        i = 1
        If (Form1.PictureBox58.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 58
            If (Form1.PictureBox48.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic48Protected()
                End If
            ElseIf (Form1.PictureBox48.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox48.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox48.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox48.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic48Attacked()
                End If
            ElseIf Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                Pic48None()
            End If
        Else
            Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangE3SouthEastMovementArea()
        i = 1
        If (Form1.PictureBox78.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 78
            If (Form1.PictureBox88.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox88.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox88.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox88.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic88Protected()
                End If
            ElseIf (Form1.PictureBox88.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox88.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox88.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox88.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic88Attacked()
                End If
            ElseIf Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                Pic88None()
            End If
        Else
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangE3SouthWestMovementArea()
        i = 1
        If (Form1.PictureBox76.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 76
            If (Form1.PictureBox84.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic84Protected()
                End If
            ElseIf (Form1.PictureBox84.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox84.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox84.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox84.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic84Attacked()
                End If
            ElseIf Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                Pic84None()
            End If
        Else
            Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangG1NorthEastMovementArea()
        i = 1
        If (Form1.PictureBox80.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 80
            If (Form1.PictureBox72.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox72.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox72.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox72.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic72Protected()
                End If
            ElseIf (Form1.PictureBox72.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox72.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox72.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox72.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic72Attacked()
                End If
            ElseIf Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                Pic72None()
            End If
        Else
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangG1NorthWestMovementArea()
        i = 1
        If (Form1.PictureBox78.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 78
            If (Form1.PictureBox68.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic68Protected()
                End If
            ElseIf (Form1.PictureBox68.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic68Attacked()
                End If
            ElseIf Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
            End If
        Else
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangG5SouthEastMovementArea()
        i = 1
        If (Form1.PictureBox62.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 62
            If (Form1.PictureBox72.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox72.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox72.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox72.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic72Protected()
                End If
            ElseIf (Form1.PictureBox72.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox72.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox72.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox72.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic72Attacked()
                End If
            ElseIf Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                Pic72None()
            End If
        Else
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangG5SouthWestMovementArea()
        i = 1
        If (Form1.PictureBox60.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 60
            If (Form1.PictureBox68.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic68Protected()
                End If
            ElseIf (Form1.PictureBox68.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox68.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic68Attacked()
                End If
            ElseIf Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
            End If
        Else
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangI3NorthWestMovementArea()
        i = 1
        If (Form1.PictureBox62.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 62
            If (Form1.PictureBox52.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox52.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox52.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox52.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic52Protected()
                End If
            ElseIf (Form1.PictureBox52.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox52.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox52.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox52.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic52Attacked()
                End If
            ElseIf Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
            End If
        Else
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub BlackXiangI3SouthWestMovementArea()
        i = 1
        If (Form1.PictureBox80.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 80
            If (Form1.PictureBox88.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox88.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox88.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox88.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic88Protected()
                End If
            ElseIf (Form1.PictureBox88.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox88.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox88.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox88.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic88Attacked()
                End If
            ElseIf Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                Pic88None()
            End If
        Else
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangA8NorthEastMovementArea()
        i = 1
        If (Form1.PictureBox11.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 11
            If (Form1.PictureBox3.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic3Attacked()
                End If
            ElseIf (Form1.PictureBox3.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox3.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox3.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox3.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic3Protected()
                End If
            ElseIf Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                Pic3None()
            End If
        Else
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangA8SouthEastMovementArea()
        i = 1
        If (Form1.PictureBox29.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 29
            If (Form1.PictureBox39.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic39Attacked()
                End If
            ElseIf (Form1.PictureBox39.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox39.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox39.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox39.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic39Protected()
                End If
            ElseIf Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                Pic39None()
            End If
        Else
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangC10SouthEastMovementArea()
        i = 1
        If (Form1.PictureBox13.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 13
            If (Form1.PictureBox23.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic23Attacked()
                End If
            ElseIf (Form1.PictureBox23.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic23Protected()
                End If
            ElseIf Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
            End If
        Else
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangC10SouthWestMovementArea()
        i = 1
        If (Form1.PictureBox11.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 11
            If (Form1.PictureBox19.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic19Attacked()
                End If
            ElseIf (Form1.PictureBox19.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox19.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox19.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox19.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic19Protected()
                End If
            ElseIf Form1.PictureBox19.Image Is Form1.nonePic.Image Then
                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                Pic19None()
            End If
        Else
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangC6NorthEastMovementArea()
        i = 1
        If (Form1.PictureBox31.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 31
            If (Form1.PictureBox23.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic23Attacked()
                End If
            ElseIf (Form1.PictureBox23.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic23Protected()
                End If
            ElseIf Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
            End If
        Else
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangC6NorthWestMovementArea()
        i = 1
        If (Form1.PictureBox29.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 29
            If (Form1.PictureBox19.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic19Attacked()
                End If
            ElseIf (Form1.PictureBox19.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox19.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox19.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox19.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic19Protected()
                End If
            ElseIf Form1.PictureBox19.Image Is Form1.nonePic.Image Then
                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                Pic19None()
            End If
        Else
            Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangE8NorthEastMovementArea()
        i = 1
        If (Form1.PictureBox15.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 15
            If (Form1.PictureBox7.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox7.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox7.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox7.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic7Attacked()
                End If
            ElseIf (Form1.PictureBox7.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox7.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox7.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox7.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic7Protected()
                End If
            ElseIf Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                Pic7None()
            End If
        Else
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangE8NorthWestMovementArea()
        i = 1
        If (Form1.PictureBox13.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 13
            If (Form1.PictureBox3.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic3Attacked()
                End If
            ElseIf (Form1.PictureBox3.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox3.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox3.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox3.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic3Protected()
                End If
            ElseIf Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                Pic3None()
            End If
        Else
            Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangE8SouthEastMovementArea()
        i = 1
        If (Form1.PictureBox33.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 33
            If (Form1.PictureBox43.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox43.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox43.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox43.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic43Attacked()
                End If
            ElseIf (Form1.PictureBox43.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox43.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox43.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox43.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic43Protected()
                End If
            ElseIf Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
            End If
        Else
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangE8SouthWestMovementArea()
        i = 1
        If (Form1.PictureBox31.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 31
            If (Form1.PictureBox39.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic39Attacked()
                End If
            ElseIf (Form1.PictureBox39.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox39.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox39.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox39.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic39Protected()
                End If
            ElseIf Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                Pic39None()
            End If
        Else
            Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangG10SouthEastMovementArea()
        i = 1
        If (Form1.PictureBox17.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 17
            If (Form1.PictureBox27.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox27.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox27.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox27.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic27Attacked()
                End If
            ElseIf (Form1.PictureBox27.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox27.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox27.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox27.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic27Protected()
                End If
            ElseIf Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                Pic27None()
            End If
        Else
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangG10SouthWestMovementArea()
        i = 1
        If (Form1.PictureBox15.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 15
            If (Form1.PictureBox23.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic23Attacked()
                End If
            ElseIf (Form1.PictureBox23.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic23Protected()
                End If
            ElseIf Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
            End If
        Else
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangG6NorthEastMovementArea()
        i = 1
        If (Form1.PictureBox35.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 35
            If (Form1.PictureBox27.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox27.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox27.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox27.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic27Attacked()
                End If
            ElseIf (Form1.PictureBox27.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox27.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox27.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox27.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic27Protected()
                End If
            ElseIf Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                Pic27None()
            End If
        Else
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangG6NorthWestMovementArea()
        i = 1
        If (Form1.PictureBox33.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 33
            If (Form1.PictureBox23.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic23Attacked()
                End If
            ElseIf (Form1.PictureBox23.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox23.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic23Protected()
                End If
            ElseIf Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
            End If
        Else
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangI8NorthWestMovementArea()
        i = 1
        If (Form1.PictureBox17.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 17
            If (Form1.PictureBox7.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox7.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox7.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox7.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic7Attacked()
                End If
            ElseIf (Form1.PictureBox7.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox7.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox7.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox7.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic7Protected()
                End If
            ElseIf Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                Pic7None()
            End If
        Else
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub WhiteXiangI8SouthWestMovementArea()
        i = 1
        If (Form1.PictureBox35.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 35
            If (Form1.PictureBox43.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox43.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox43.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox43.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic43Attacked()
                End If
            ElseIf (Form1.PictureBox43.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox43.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox43.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox43.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic43Protected()
                End If
            ElseIf Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
            End If
        Else
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub
End Module
