' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 18/01/2011
' Descriptions : Chinese Chess V1

Module ModuleCheckMaDirection2
    Dim i As Integer

    Public Sub MaF3EastMovementArea()
        i = 1
        If (Form1.PictureBox70.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 70
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Protected()
                    End If
                ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Attacked()
                    End If
                ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Protected()
                    End If
                End If
            End If
            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox80.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic80Protected()
                    End If
                ElseIf (Form1.PictureBox80.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic80Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox80.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic80Attacked()
                    End If
                ElseIf (Form1.PictureBox80.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic80Protected()
                    End If
                End If
            End If
            If Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                Pic80None()
            End If
        Else
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF3SouthMovementArea()
        i = 1
        If (Form1.PictureBox78.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 78
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox86.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic86Protected()
                    End If
                ElseIf (Form1.PictureBox86.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic86Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox86.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic86Attacked()
                    End If
                ElseIf (Form1.PictureBox86.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic86Protected()
                    End If
                End If
            End If
            If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                Pic86None()
            End If
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox88.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic88Attacked()
                    End If
                ElseIf (Form1.PictureBox88.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic88Protected()
                    End If
                End If
            End If
            If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                Pic88None()
            End If
        Else
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF3WestMovementArea()
        i = 1
        If (Form1.PictureBox68.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 68
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox58.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic58Protected()
                    End If
                ElseIf (Form1.PictureBox58.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic58Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox58.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic58Attacked()
                    End If
                ElseIf (Form1.PictureBox58.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic58Protected()
                    End If
                End If
            End If
            If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                Pic58None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox76.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox76.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox76.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox76.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic76Protected()
                    End If
                ElseIf (Form1.PictureBox76.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox76.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox76.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox76.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox76.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox76.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox76.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic76Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox76.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox76.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox76.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox76.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic76Attacked()
                    End If
                ElseIf (Form1.PictureBox76.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox76.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox76.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox76.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox76.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox76.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox76.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic76Protected()
                    End If
                End If
            End If
            If Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                Pic76None()
            End If
        Else
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox76.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF3NorthMovementArea()
        i = 1
        If (Form1.PictureBox60.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 60
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox50.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Protected()
                    End If
                ElseIf (Form1.PictureBox50.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox50.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Attacked()
                    End If
                ElseIf (Form1.PictureBox50.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Protected()
                    End If
                End If
            End If
            If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
            End If
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox52.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic52Attacked()
                    End If
                ElseIf (Form1.PictureBox52.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic52Protected()
                    End If
                End If
            End If
            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
            End If
        Else
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF4EastMovementArea()
        i = 1
        If (Form1.PictureBox61.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 61
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Protected()
                    End If
                ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Attacked()
                    End If
                ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Protected()
                    End If
                End If
            End If
            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox71.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Protected()
                    End If
                ElseIf (Form1.PictureBox71.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox71.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Attacked()
                    End If
                ElseIf (Form1.PictureBox71.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Protected()
                    End If
                End If
            End If
            If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
            End If
        Else
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF4SouthMovementArea()
        i = 1
        If (Form1.PictureBox69.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 69
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox77.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic77Protected()
                    End If
                ElseIf (Form1.PictureBox77.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic77Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox77.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic77Attacked()
                    End If
                ElseIf (Form1.PictureBox77.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic77Protected()
                    End If
                End If
            End If
            If Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox79.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Protected()
                    End If
                ElseIf (Form1.PictureBox79.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox79.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Attacked()
                    End If
                ElseIf (Form1.PictureBox79.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Protected()
                    End If
                End If
            End If
            If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                Pic79None()
            End If
        Else
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF4WestMovementArea()
        i = 1
        If (Form1.PictureBox59.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 59
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox49.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic49Protected()
                    End If
                ElseIf (Form1.PictureBox49.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic49Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox49.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic49Attacked()
                    End If
                ElseIf (Form1.PictureBox49.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic49Protected()
                    End If
                End If
            End If
            If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                Pic49None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox67.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox67.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox67.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox67.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic67Protected()
                    End If
                ElseIf (Form1.PictureBox67.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox67.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox67.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox67.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox67.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox67.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox67.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic67Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox67.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox67.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox67.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox67.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic67Attacked()
                    End If
                ElseIf (Form1.PictureBox67.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox67.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox67.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox67.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox67.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox67.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox67.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic67Protected()
                    End If
                End If
            End If
            If Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                Pic67None()
            End If
        Else
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox67.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF4NorthMovementArea()
        i = 1
        If (Form1.PictureBox51.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 51
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox41.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Protected()
                    End If
                ElseIf (Form1.PictureBox41.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox41.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Attacked()
                    End If
                ElseIf (Form1.PictureBox41.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Protected()
                    End If
                End If
            End If
            If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox43.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic43Protected()
                    End If
                ElseIf (Form1.PictureBox43.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic43Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
            End If
        Else
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF5EastMovementArea()
        i = 1
        If (Form1.PictureBox52.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 52
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Protected()
                    End If
                ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Attacked()
                    End If
                ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Protected()
                    End If
                End If
            End If
            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Protected()
                    End If
                ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Attacked()
                    End If
                ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Protected()
                    End If
                End If
            End If
            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
            End If
        Else
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF5SouthMovementArea()
        i = 1
        If (Form1.PictureBox60.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 60
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox68.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic68Attacked()
                    End If
                ElseIf (Form1.PictureBox68.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic68Protected()
                    End If
                End If
            End If
            If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox70.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Protected()
                    End If
                ElseIf (Form1.PictureBox70.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox70.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Attacked()
                    End If
                ElseIf (Form1.PictureBox70.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Protected()
                    End If
                End If
            End If
            If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
            End If
        Else
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF5WestMovementArea()
        i = 1
        If (Form1.PictureBox50.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 50
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox40.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic40Protected()
                    End If
                ElseIf (Form1.PictureBox40.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic40Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox40.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic40Attacked()
                    End If
                ElseIf (Form1.PictureBox40.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic40Protected()
                    End If
                End If
            End If
            If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                Pic40None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox58.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic58Protected()
                    End If
                ElseIf (Form1.PictureBox58.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic58Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox58.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic58Attacked()
                    End If
                ElseIf (Form1.PictureBox58.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox58.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic58Protected()
                    End If
                End If
            End If
            If Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                Pic58None()
            End If
        Else
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox58.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF5NorthMovementArea()
        i = 1
        If (Form1.PictureBox42.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 42
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox32.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Protected()
                    End If
                ElseIf (Form1.PictureBox32.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox32.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Attacked()
                    End If
                ElseIf (Form1.PictureBox32.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Protected()
                    End If
                End If
            End If
            If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                Pic32None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Protected()
                    End If
                ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Attacked()
                    End If
                ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Protected()
                    End If
                End If
            End If
            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
            End If
        Else
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF6EastMovementArea()
        i = 1
        If (Form1.PictureBox43.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 43
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Protected()
                    End If
                ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Attacked()
                    End If
                ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Protected()
                    End If
                End If
            End If
            If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Protected()
                    End If
                ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Attacked()
                    End If
                ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Protected()
                    End If
                End If
            End If
            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
            End If
        Else
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF6SouthMovementArea()
        i = 1
        If (Form1.PictureBox51.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 51
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox59.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic59Protected()
                    End If
                ElseIf (Form1.PictureBox59.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic59Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox59.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic59Attacked()
                    End If
                ElseIf (Form1.PictureBox59.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic59Protected()
                    End If
                End If
            End If
            If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                Pic59None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox61.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Protected()
                    End If
                ElseIf (Form1.PictureBox61.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox61.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Attacked()
                    End If
                ElseIf (Form1.PictureBox61.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Protected()
                    End If
                End If
            End If
            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
            End If
        Else
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF6WestMovementArea()
        i = 1
        If (Form1.PictureBox41.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 41
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox31.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic31Protected()
                    End If
                ElseIf (Form1.PictureBox31.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic31Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox31.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic31Attacked()
                    End If
                ElseIf (Form1.PictureBox31.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic31Protected()
                    End If
                End If
            End If
            If Form1.PictureBox31.Image Is Form1.nonePic.Image Then
                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                Pic31None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox49.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic49Protected()
                    End If
                ElseIf (Form1.PictureBox49.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic49Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox49.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic49Attacked()
                    End If
                ElseIf (Form1.PictureBox49.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox49.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic49Protected()
                    End If
                End If
            End If
            If Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                Pic49None()
            End If
        Else
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox49.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF6NorthMovementArea()
        i = 1
        If (Form1.PictureBox33.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 33
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox23.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic23Protected()
                    End If
                ElseIf (Form1.PictureBox23.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic23Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox25.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Protected()
                    End If
                ElseIf (Form1.PictureBox25.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox25.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Attacked()
                    End If
                ElseIf (Form1.PictureBox25.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Protected()
                    End If
                End If
            End If
            If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                Pic25None()
            End If
        Else
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF7EastMovementArea()
        i = 1
        If (Form1.PictureBox34.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 34
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Protected()
                    End If
                ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Attacked()
                    End If
                ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Protected()
                    End If
                End If
            End If
            If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Protected()
                    End If
                ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Attacked()
                    End If
                ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Protected()
                    End If
                End If
            End If
            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
            End If
        Else
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF7SouthMovementArea()
        i = 1
        If (Form1.PictureBox42.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 42
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox50.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Protected()
                    End If
                ElseIf (Form1.PictureBox50.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox50.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Attacked()
                    End If
                ElseIf (Form1.PictureBox50.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Protected()
                    End If
                End If
            End If
            If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
            End If
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox52.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic52Attacked()
                    End If
                ElseIf (Form1.PictureBox52.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic52Protected()
                    End If
                End If
            End If
            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
            End If
        Else
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF7WestMovementArea()
        i = 1
        If (Form1.PictureBox32.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 32
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox22.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic22Protected()
                    End If
                ElseIf (Form1.PictureBox22.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic22Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox22.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic22Attacked()
                    End If
                ElseIf (Form1.PictureBox22.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic22Protected()
                    End If
                End If
            End If
            If Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                Pic22None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox40.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic40Protected()
                    End If
                ElseIf (Form1.PictureBox40.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic40Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox40.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic40Attacked()
                    End If
                ElseIf (Form1.PictureBox40.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox40.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic40Protected()
                    End If
                End If
            End If
            If Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                Pic40None()
            End If
        Else
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox40.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF7NorthMovementArea()
        i = 1
        If (Form1.PictureBox24.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 24
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox14.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic14Protected()
                    End If
                ElseIf (Form1.PictureBox14.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic14Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox14.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic14Attacked()
                    End If
                ElseIf (Form1.PictureBox14.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic14Protected()
                    End If
                End If
            End If
            If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox16.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Protected()
                    End If
                ElseIf (Form1.PictureBox16.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox16.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Attacked()
                    End If
                ElseIf (Form1.PictureBox16.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Protected()
                    End If
                End If
            End If
            If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                Pic16None()
            End If
        Else
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF8EastMovementArea()
        i = 1
        If (Form1.PictureBox25.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 25
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox17.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Protected()
                    End If
                ElseIf (Form1.PictureBox17.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox17.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Attacked()
                    End If
                ElseIf (Form1.PictureBox17.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Protected()
                    End If
                End If
            End If
            If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                Pic17None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Protected()
                    End If
                ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Attacked()
                    End If
                ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Protected()
                    End If
                End If
            End If
            If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
            End If
        Else
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF8SouthMovementArea()
        i = 1
        If (Form1.PictureBox33.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 33
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox41.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Protected()
                    End If
                ElseIf (Form1.PictureBox41.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox41.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Attacked()
                    End If
                ElseIf (Form1.PictureBox41.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Protected()
                    End If
                End If
            End If
            If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox43.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic43Protected()
                    End If
                ElseIf (Form1.PictureBox43.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic43Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
            End If
        Else
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF8WestMovementArea()
        i = 1
        If (Form1.PictureBox23.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 23
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox13.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic13Protected()
                    End If
                ElseIf (Form1.PictureBox13.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic13Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox13.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic13Attacked()
                    End If
                ElseIf (Form1.PictureBox13.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic13Protected()
                    End If
                End If
            End If
            If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                Pic13None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox31.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic31Protected()
                    End If
                ElseIf (Form1.PictureBox31.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic31Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox31.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic31Attacked()
                    End If
                ElseIf (Form1.PictureBox31.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox31.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic31Protected()
                    End If
                End If
            End If
            If Form1.PictureBox31.Image Is Form1.nonePic.Image Then
                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                Pic31None()
            End If
        Else
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox31.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF8NorthMovementArea()
        i = 1
        If (Form1.PictureBox15.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 15
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox5.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic5Protected()
                    End If
                ElseIf (Form1.PictureBox5.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic5Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox5.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic5Attacked()
                    End If
                ElseIf (Form1.PictureBox5.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic5Protected()
                    End If
                End If
            End If
            If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                Pic5None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox7.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic7Protected()
                    End If
                ElseIf (Form1.PictureBox7.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic7Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                Pic7None()
            End If
        Else
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF9EastMovementArea()
        i = 1
        If (Form1.PictureBox16.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 16
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox8.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic8Protected()
                    End If
                ElseIf (Form1.PictureBox8.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic8Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox8.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic8Attacked()
                    End If
                ElseIf (Form1.PictureBox8.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic8Protected()
                    End If
                End If
            End If
            If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                Pic8None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Protected()
                    End If
                ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Attacked()
                    End If
                ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Protected()
                    End If
                End If
            End If
            If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
            End If
        Else
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF9SouthMovementArea()
        i = 1
        If (Form1.PictureBox24.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 24
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox32.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Protected()
                    End If
                ElseIf (Form1.PictureBox32.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox32.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Attacked()
                    End If
                ElseIf (Form1.PictureBox32.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Protected()
                    End If
                End If
            End If
            If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                Pic32None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Protected()
                    End If
                ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Attacked()
                    End If
                ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Protected()
                    End If
                End If
            End If
            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
            End If
        Else
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF9WestMovementArea()
        i = 1
        If (Form1.PictureBox14.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 14
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox4.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox4.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox4.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox4.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic4Protected()
                    End If
                ElseIf (Form1.PictureBox4.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox4.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox4.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox4.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox4.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox4.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox4.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic4Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox4.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox4.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox4.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox4.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic4Attacked()
                    End If
                ElseIf (Form1.PictureBox4.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox4.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox4.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox4.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox4.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox4.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox4.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic4Protected()
                    End If
                End If
            End If
            If Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                Pic4None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox22.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic22Protected()
                    End If
                ElseIf (Form1.PictureBox22.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic22Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox22.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic22Attacked()
                    End If
                ElseIf (Form1.PictureBox22.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox22.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic22Protected()
                    End If
                End If
            End If
            If Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                Pic22None()
            End If
        Else
            Form1.PictureBox4.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox22.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF10EastMovementArea()
        i = 1
        If (Form1.PictureBox7.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 7
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox17.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Protected()
                    End If
                ElseIf (Form1.PictureBox17.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox17.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Attacked()
                    End If
                ElseIf (Form1.PictureBox17.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Protected()
                    End If
                End If
            End If
            If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                Pic17None()
            End If
        Else
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF10SouthMovementArea()
        i = 1
        If (Form1.PictureBox15.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 15
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox23.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic23Protected()
                    End If
                ElseIf (Form1.PictureBox23.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic23Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox25.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Protected()
                    End If
                ElseIf (Form1.PictureBox25.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox25.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Attacked()
                    End If
                ElseIf (Form1.PictureBox25.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Protected()
                    End If
                End If
            End If
            If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                Pic25None()
            End If
        Else
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaF10WestMovementArea()
        i = 1
        If (Form1.PictureBox5.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 5
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox13.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic13Protected()
                    End If
                ElseIf (Form1.PictureBox13.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic13Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox13.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic13Attacked()
                    End If
                ElseIf (Form1.PictureBox13.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox13.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic13Protected()
                    End If
                End If
            End If
            If Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                Pic13None()
            End If
        Else
            Form1.PictureBox13.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG1EastMovementArea()
        i = 1
        If (Form1.PictureBox89.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 89
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox81.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic81Protected()
                    End If
                ElseIf (Form1.PictureBox81.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic81Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox81.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic81Attacked()
                    End If
                ElseIf (Form1.PictureBox81.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic81Protected()
                    End If
                End If
            End If
            If Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                Pic81None()
            End If
        Else
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG1WestMovementArea()
        i = 1
        If (Form1.PictureBox87.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 87
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox77.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic77Protected()
                    End If
                ElseIf (Form1.PictureBox77.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic77Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox77.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic77Attacked()
                    End If
                ElseIf (Form1.PictureBox77.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic77Protected()
                    End If
                End If
            End If
            If Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
            End If
        Else
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG1NorthMovementArea()
        i = 1
        If (Form1.PictureBox79.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 79
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox69.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Protected()
                    End If
                ElseIf (Form1.PictureBox69.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox69.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Attacked()
                    End If
                ElseIf (Form1.PictureBox69.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Protected()
                    End If
                End If
            End If
            If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox71.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Protected()
                    End If
                ElseIf (Form1.PictureBox71.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox71.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Attacked()
                    End If
                ElseIf (Form1.PictureBox71.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Protected()
                    End If
                End If
            End If
            If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
            End If
        Else
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG2EastMovementArea()
        i = 1
        If (Form1.PictureBox80.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 80
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox72.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic72Attacked()
                    End If
                ElseIf (Form1.PictureBox72.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic72Protected()
                    End If
                End If
            End If
            If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                Pic72None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox90.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic90Protected()
                    End If
                ElseIf (Form1.PictureBox90.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic90Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox90.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic90Attacked()
                    End If
                ElseIf (Form1.PictureBox90.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic90Protected()
                    End If
                End If
            End If
            If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                Pic90None()
            End If
        Else
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG2WestMovementArea()
        i = 1
        If (Form1.PictureBox78.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 78
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox68.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic68Attacked()
                    End If
                ElseIf (Form1.PictureBox68.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic68Protected()
                    End If
                End If
            End If
            If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox86.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic86Protected()
                    End If
                ElseIf (Form1.PictureBox86.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic86Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox86.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic86Attacked()
                    End If
                ElseIf (Form1.PictureBox86.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox86.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic86Protected()
                    End If
                End If
            End If
            If Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                Pic86None()
            End If
        Else
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox86.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG2NorthMovementArea()
        i = 1
        If (Form1.PictureBox70.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 70
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox60.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Protected()
                    End If
                ElseIf (Form1.PictureBox60.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox60.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Attacked()
                    End If
                ElseIf (Form1.PictureBox60.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Protected()
                    End If
                End If
            End If
            If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Protected()
                    End If
                ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Attacked()
                    End If
                ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Protected()
                    End If
                End If
            End If
            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
            End If
        Else
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG3EastMovementArea()
        i = 1
        If (Form1.PictureBox71.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 71
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox63.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Protected()
                    End If
                ElseIf (Form1.PictureBox63.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox63.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Attacked()
                    End If
                ElseIf (Form1.PictureBox63.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Protected()
                    End If
                End If
            End If
            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                Pic63None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox81.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic81Protected()
                    End If
                ElseIf (Form1.PictureBox81.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic81Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox81.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic81Attacked()
                    End If
                ElseIf (Form1.PictureBox81.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic81Protected()
                    End If
                End If
            End If
            If Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                Pic81None()
            End If
        Else
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG3SouthMovementArea()
        i = 1
        If (Form1.PictureBox79.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 79
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox87.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic87Protected()
                    End If
                ElseIf (Form1.PictureBox87.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic87Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox87.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic87Attacked()
                    End If
                ElseIf (Form1.PictureBox87.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic87Protected()
                    End If
                End If
            End If
            If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                Pic87None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox89.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic89Protected()
                    End If
                ElseIf (Form1.PictureBox89.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic89Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox89.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic89Attacked()
                    End If
                ElseIf (Form1.PictureBox89.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic89Protected()
                    End If
                End If
            End If
            If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                Pic89None()
            End If
        Else
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG3WestMovementArea()
        i = 1
        If (Form1.PictureBox69.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 69
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox59.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic59Protected()
                    End If
                ElseIf (Form1.PictureBox59.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic59Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox59.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic59Attacked()
                    End If
                ElseIf (Form1.PictureBox59.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic59Protected()
                    End If
                End If
            End If
            If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                Pic59None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox77.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic77Protected()
                    End If
                ElseIf (Form1.PictureBox77.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic77Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox77.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic77Attacked()
                    End If
                ElseIf (Form1.PictureBox77.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox77.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic77Protected()
                    End If
                End If
            End If
            If Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
            End If
        Else
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox77.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG3NorthMovementArea()
        i = 1
        If (Form1.PictureBox61.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 61
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox51.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Protected()
                    End If
                ElseIf (Form1.PictureBox51.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox51.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Attacked()
                    End If
                ElseIf (Form1.PictureBox51.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Protected()
                    End If
                End If
            End If
            If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                Pic51None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Protected()
                    End If
                ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Attacked()
                    End If
                ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Protected()
                    End If
                End If
            End If
            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
            End If
        Else
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG4EastMovementArea()
        i = 1
        If (Form1.PictureBox62.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 62
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox54.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Protected()
                    End If
                ElseIf (Form1.PictureBox54.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox54.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Attacked()
                    End If
                ElseIf (Form1.PictureBox54.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Protected()
                    End If
                End If
            End If
            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                Pic54None()
            End If
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox72.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic72Attacked()
                    End If
                ElseIf (Form1.PictureBox72.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic72Protected()
                    End If
                End If
            End If
            If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                Pic72None()
            End If
        Else
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG4SouthMovementArea()
        i = 1
        If (Form1.PictureBox70.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 70
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox78.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic78Protected()
                    End If
                ElseIf (Form1.PictureBox78.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic78Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox78.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic78Attacked()
                    End If
                ElseIf (Form1.PictureBox78.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic78Protected()
                    End If
                End If
            End If
            If Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox80.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic80Protected()
                    End If
                ElseIf (Form1.PictureBox80.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic80Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox80.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic80Attacked()
                    End If
                ElseIf (Form1.PictureBox80.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic80Protected()
                    End If
                End If
            End If
            If Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                Pic80None()
            End If
        Else
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG4WestMovementArea()
        i = 1
        If (Form1.PictureBox60.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 60
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox50.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Protected()
                    End If
                ElseIf (Form1.PictureBox50.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox50.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Attacked()
                    End If
                ElseIf (Form1.PictureBox50.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Protected()
                    End If
                End If
            End If
            If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
            End If
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox68.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic68Attacked()
                    End If
                ElseIf (Form1.PictureBox68.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox68.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic68Protected()
                    End If
                End If
            End If
            If Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
            End If
        Else
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox68.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG4NorthMovementArea()
        i = 1
        If (Form1.PictureBox52.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 52
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox42.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Protected()
                    End If
                ElseIf (Form1.PictureBox42.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox42.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Attacked()
                    End If
                ElseIf (Form1.PictureBox42.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Protected()
                    End If
                End If
            End If
            If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                Pic42None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Protected()
                    End If
                ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Attacked()
                    End If
                ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Protected()
                    End If
                End If
            End If
            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
            End If
        Else
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG5EastMovementArea()
        i = 1
        If (Form1.PictureBox53.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 53
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox45.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Protected()
                    End If
                ElseIf (Form1.PictureBox45.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox45.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Attacked()
                    End If
                ElseIf (Form1.PictureBox45.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Protected()
                    End If
                End If
            End If
            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                Pic45None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox63.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Protected()
                    End If
                ElseIf (Form1.PictureBox63.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox63.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Attacked()
                    End If
                ElseIf (Form1.PictureBox63.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Protected()
                    End If
                End If
            End If
            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                Pic63None()
            End If
        Else
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG5SouthMovementArea()
        i = 1
        If (Form1.PictureBox61.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 61
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox69.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Protected()
                    End If
                ElseIf (Form1.PictureBox69.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox69.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Attacked()
                    End If
                ElseIf (Form1.PictureBox69.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Protected()
                    End If
                End If
            End If
            If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox71.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Protected()
                    End If
                ElseIf (Form1.PictureBox71.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox71.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Attacked()
                    End If
                ElseIf (Form1.PictureBox71.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Protected()
                    End If
                End If
            End If
            If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
            End If
        Else
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG5WestMovementArea()
        i = 1
        If (Form1.PictureBox51.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 51
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox41.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Protected()
                    End If
                ElseIf (Form1.PictureBox41.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox41.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Attacked()
                    End If
                ElseIf (Form1.PictureBox41.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Protected()
                    End If
                End If
            End If
            If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox59.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic59Protected()
                    End If
                ElseIf (Form1.PictureBox59.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic59Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox59.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic59Attacked()
                    End If
                ElseIf (Form1.PictureBox59.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox59.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic59Protected()
                    End If
                End If
            End If
            If Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                Pic59None()
            End If
        Else
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox59.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG5NorthMovementArea()
        i = 1
        If (Form1.PictureBox43.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 43
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox33.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Protected()
                    End If
                ElseIf (Form1.PictureBox33.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox33.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Attacked()
                    End If
                ElseIf (Form1.PictureBox33.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Protected()
                    End If
                End If
            End If
            If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                Pic33None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Protected()
                    End If
                ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Attacked()
                    End If
                ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Protected()
                    End If
                End If
            End If
            If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
            End If
        Else
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG6EastMovementArea()
        i = 1
        If (Form1.PictureBox44.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 44
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox36.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Protected()
                    End If
                ElseIf (Form1.PictureBox36.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox36.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Attacked()
                    End If
                ElseIf (Form1.PictureBox36.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Protected()
                    End If
                End If
            End If
            If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                Pic36None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox54.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Protected()
                    End If
                ElseIf (Form1.PictureBox54.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox54.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Attacked()
                    End If
                ElseIf (Form1.PictureBox54.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Protected()
                    End If
                End If
            End If
            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                Pic54None()
            End If
        Else
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG6SouthMovementArea()
        i = 1
        If (Form1.PictureBox52.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 52
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox60.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Protected()
                    End If
                ElseIf (Form1.PictureBox60.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox60.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Attacked()
                    End If
                ElseIf (Form1.PictureBox60.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Protected()
                    End If
                End If
            End If
            If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Protected()
                    End If
                ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Attacked()
                    End If
                ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Protected()
                    End If
                End If
            End If
            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
            End If
        Else
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG6WestMovementArea()
        i = 1
        If (Form1.PictureBox42.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 42
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox32.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Protected()
                    End If
                ElseIf (Form1.PictureBox32.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox32.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Attacked()
                    End If
                ElseIf (Form1.PictureBox32.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Protected()
                    End If
                End If
            End If
            If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                Pic32None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox50.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Protected()
                    End If
                ElseIf (Form1.PictureBox50.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox50.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Attacked()
                    End If
                ElseIf (Form1.PictureBox50.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox50.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic50Protected()
                    End If
                End If
            End If
            If Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
            End If
        Else
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox50.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG6NorthMovementArea()
        i = 1
        If (Form1.PictureBox34.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 34
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox24.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Protected()
                    End If
                ElseIf (Form1.PictureBox24.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox24.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Attacked()
                    End If
                ElseIf (Form1.PictureBox24.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Protected()
                    End If
                End If
            End If
            If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Protected()
                    End If
                ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Attacked()
                    End If
                ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Protected()
                    End If
                End If
            End If
            If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
            End If
        Else
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG7EastMovementArea()
        i = 1
        If (Form1.PictureBox35.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 35
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox27.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic27Protected()
                    End If
                ElseIf (Form1.PictureBox27.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic27Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                Pic27None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox45.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Protected()
                    End If
                ElseIf (Form1.PictureBox45.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox45.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Attacked()
                    End If
                ElseIf (Form1.PictureBox45.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Protected()
                    End If
                End If
            End If
            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                Pic45None()
            End If
        Else
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG7SouthMovementArea()
        i = 1
        If (Form1.PictureBox43.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 43
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox51.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Protected()
                    End If
                ElseIf (Form1.PictureBox51.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox51.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Attacked()
                    End If
                ElseIf (Form1.PictureBox51.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Protected()
                    End If
                End If
            End If
            If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                Pic51None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Protected()
                    End If
                ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Attacked()
                    End If
                ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Protected()
                    End If
                End If
            End If
            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
            End If
        Else
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG7WestMovementArea()
        i = 1
        If (Form1.PictureBox33.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 33
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox23.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic23Protected()
                    End If
                ElseIf (Form1.PictureBox23.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic23Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox41.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Protected()
                    End If
                ElseIf (Form1.PictureBox41.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox41.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Attacked()
                    End If
                ElseIf (Form1.PictureBox41.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox41.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic41Protected()
                    End If
                End If
            End If
            If Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
            End If
        Else
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox41.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG7NorthMovementArea()
        i = 1
        If (Form1.PictureBox25.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 25
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox15.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic15Protected()
                    End If
                ElseIf (Form1.PictureBox15.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic15Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox15.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic15Attacked()
                    End If
                ElseIf (Form1.PictureBox15.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic15Protected()
                    End If
                End If
            End If
            If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Pic15None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox17.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Protected()
                    End If
                ElseIf (Form1.PictureBox17.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox17.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Attacked()
                    End If
                ElseIf (Form1.PictureBox17.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Protected()
                    End If
                End If
            End If
            If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                Pic17None()
            End If
        Else
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG8EastMovementArea()
        i = 1
        If (Form1.PictureBox26.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 26
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox18.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic18Protected()
                    End If
                ElseIf (Form1.PictureBox18.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic18Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox18.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic18Attacked()
                    End If
                ElseIf (Form1.PictureBox18.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic18Protected()
                    End If
                End If
            End If
            If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                Pic18None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox36.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Protected()
                    End If
                ElseIf (Form1.PictureBox36.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox36.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Attacked()
                    End If
                ElseIf (Form1.PictureBox36.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Protected()
                    End If
                End If
            End If
            If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                Pic36None()
            End If
        Else
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG8SouthMovementArea()
        i = 1
        If (Form1.PictureBox34.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 34
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox42.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Protected()
                    End If
                ElseIf (Form1.PictureBox42.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox42.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Attacked()
                    End If
                ElseIf (Form1.PictureBox42.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Protected()
                    End If
                End If
            End If
            If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                Pic42None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Protected()
                    End If
                ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Attacked()
                    End If
                ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Protected()
                    End If
                End If
            End If
            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
            End If
        Else
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG8WestMovementArea()
        i = 1
        If (Form1.PictureBox24.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 24
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox14.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic14Protected()
                    End If
                ElseIf (Form1.PictureBox14.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic14Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox14.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic14Attacked()
                    End If
                ElseIf (Form1.PictureBox14.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic14Protected()
                    End If
                End If
            End If
            If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox32.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Protected()
                    End If
                ElseIf (Form1.PictureBox32.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox32.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Attacked()
                    End If
                ElseIf (Form1.PictureBox32.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox32.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic32Protected()
                    End If
                End If
            End If
            If Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                Pic32None()
            End If
        Else
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox32.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG8NorthMovementArea()
        i = 1
        If (Form1.PictureBox16.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 16
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox6.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic6Protected()
                    End If
                ElseIf (Form1.PictureBox6.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic6Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox6.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic6Attacked()
                    End If
                ElseIf (Form1.PictureBox6.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic6Protected()
                    End If
                End If
            End If
            If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                Pic6None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox8.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic8Protected()
                    End If
                ElseIf (Form1.PictureBox8.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic8Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox8.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic8Attacked()
                    End If
                ElseIf (Form1.PictureBox8.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic8Protected()
                    End If
                End If
            End If
            If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                Pic8None()
            End If
        Else
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG9EastMovementArea()
        i = 1
        If (Form1.PictureBox17.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 17
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox9.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic9Protected()
                    End If
                ElseIf (Form1.PictureBox9.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic9Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox9.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic9Attacked()
                    End If
                ElseIf (Form1.PictureBox9.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic9Protected()
                    End If
                End If
            End If
            If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                Pic9None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox27.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic27Protected()
                    End If
                ElseIf (Form1.PictureBox27.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic27Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                Pic27None()
            End If
        Else
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG9SouthMovementArea()
        i = 1
        If (Form1.PictureBox25.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 25
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox33.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Protected()
                    End If
                ElseIf (Form1.PictureBox33.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox33.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Attacked()
                    End If
                ElseIf (Form1.PictureBox33.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Protected()
                    End If
                End If
            End If
            If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                Pic33None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Protected()
                    End If
                ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Attacked()
                    End If
                ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Protected()
                    End If
                End If
            End If
            If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
            End If
        Else
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG9WestMovementArea()
        i = 1
        If (Form1.PictureBox15.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 15
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox5.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic5Protected()
                    End If
                ElseIf (Form1.PictureBox5.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic5Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox5.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic5Attacked()
                    End If
                ElseIf (Form1.PictureBox5.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox5.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic5Protected()
                    End If
                End If
            End If
            If Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                Pic5None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox23.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic23Protected()
                    End If
                ElseIf (Form1.PictureBox23.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox23.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic23Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
            End If
        Else
            Form1.PictureBox5.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox23.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG10EastMovementArea()
        i = 1
        If (Form1.PictureBox8.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 8
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox18.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic18Protected()
                    End If
                ElseIf (Form1.PictureBox18.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic18Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox18.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic18Attacked()
                    End If
                ElseIf (Form1.PictureBox18.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic18Protected()
                    End If
                End If
            End If
            If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                Pic18None()
            End If
        Else
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG10SouthMovementArea()
        i = 1
        If (Form1.PictureBox16.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 16
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox24.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Protected()
                    End If
                ElseIf (Form1.PictureBox24.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox24.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Attacked()
                    End If
                ElseIf (Form1.PictureBox24.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Protected()
                    End If
                End If
            End If
            If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Protected()
                    End If
                ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Attacked()
                    End If
                ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Protected()
                    End If
                End If
            End If
            If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
            End If
        Else
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaG10WestMovementArea()
        i = 1
        If (Form1.PictureBox6.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 6
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox14.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic14Protected()
                    End If
                ElseIf (Form1.PictureBox14.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic14Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox14.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic14Attacked()
                    End If
                ElseIf (Form1.PictureBox14.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox14.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic14Protected()
                    End If
                End If
            End If
            If Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
            End If
        Else
            Form1.PictureBox14.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH1WestMovementArea()
        i = 1
        If (Form1.PictureBox88.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 88
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox78.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic78Protected()
                    End If
                ElseIf (Form1.PictureBox78.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic78Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox78.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic78Attacked()
                    End If
                ElseIf (Form1.PictureBox78.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic78Protected()
                    End If
                End If
            End If
            If Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
            End If
        Else
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH1NorthMovementArea()
        i = 1
        If (Form1.PictureBox80.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 80
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox70.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Protected()
                    End If
                ElseIf (Form1.PictureBox70.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox70.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Attacked()
                    End If
                ElseIf (Form1.PictureBox70.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Protected()
                    End If
                End If
            End If
            If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
            End If
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox72.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic72Attacked()
                    End If
                ElseIf (Form1.PictureBox72.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic72Protected()
                    End If
                End If
            End If
            If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                Pic72None()
            End If
        Else
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH2WestMovementArea()
        i = 1
        If (Form1.PictureBox79.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 79
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox69.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Protected()
                    End If
                ElseIf (Form1.PictureBox69.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox69.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Attacked()
                    End If
                ElseIf (Form1.PictureBox69.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Protected()
                    End If
                End If
            End If
            If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox87.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic87Protected()
                    End If
                ElseIf (Form1.PictureBox87.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic87Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox87.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic87Attacked()
                    End If
                ElseIf (Form1.PictureBox87.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox87.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic87Protected()
                    End If
                End If
            End If
            If Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                Pic87None()
            End If
        Else
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox87.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH2NorthMovementArea()
        i = 1
        If (Form1.PictureBox71.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 71
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox61.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Protected()
                    End If
                ElseIf (Form1.PictureBox61.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox61.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Attacked()
                    End If
                ElseIf (Form1.PictureBox61.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Protected()
                    End If
                End If
            End If
            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox63.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Protected()
                    End If
                ElseIf (Form1.PictureBox63.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox63.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Attacked()
                    End If
                ElseIf (Form1.PictureBox63.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Protected()
                    End If
                End If
            End If
            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                Pic63None()
            End If
        Else
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH3SouthMovementArea()
        i = 1
        If (Form1.PictureBox80.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 80
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox88.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic88Attacked()
                    End If
                ElseIf (Form1.PictureBox88.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic88Protected()
                    End If
                End If
            End If
            If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                Pic88None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox90.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic90Protected()
                    End If
                ElseIf (Form1.PictureBox90.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic90Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox90.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic90Attacked()
                    End If
                ElseIf (Form1.PictureBox90.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox90.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic90Protected()
                    End If
                End If
            End If
            If Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                Pic90None()
            End If
        Else
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox90.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH3WestMovementArea()
        i = 1
        If (Form1.PictureBox70.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 70
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox60.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Protected()
                    End If
                ElseIf (Form1.PictureBox60.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox60.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Attacked()
                    End If
                ElseIf (Form1.PictureBox60.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Protected()
                    End If
                End If
            End If
            If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox78.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic78Protected()
                    End If
                ElseIf (Form1.PictureBox78.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic78Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox78.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic78Attacked()
                    End If
                ElseIf (Form1.PictureBox78.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox78.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic78Protected()
                    End If
                End If
            End If
            If Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
            End If
        Else
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox78.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH3NorthMovementArea()
        i = 1
        If (Form1.PictureBox62.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 62
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox52.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic52Attacked()
                    End If
                ElseIf (Form1.PictureBox52.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic52Protected()
                    End If
                End If
            End If
            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox54.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Protected()
                    End If
                ElseIf (Form1.PictureBox54.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox54.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Attacked()
                    End If
                ElseIf (Form1.PictureBox54.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Protected()
                    End If
                End If
            End If
            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                Pic54None()
            End If
        Else
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH4SouthMovementArea()
        i = 1
        If (Form1.PictureBox71.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 71
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox79.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Protected()
                    End If
                ElseIf (Form1.PictureBox79.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox79.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Attacked()
                    End If
                ElseIf (Form1.PictureBox79.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Protected()
                    End If
                End If
            End If
            If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                Pic79None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox81.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic81Protected()
                    End If
                ElseIf (Form1.PictureBox81.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic81Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox81.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic81Attacked()
                    End If
                ElseIf (Form1.PictureBox81.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox81.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic81Protected()
                    End If
                End If
            End If
            If Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                Pic81None()
            End If
        Else
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox81.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH4WestMovementArea()
        i = 1
        If (Form1.PictureBox61.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 61
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox51.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Protected()
                    End If
                ElseIf (Form1.PictureBox51.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox51.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Attacked()
                    End If
                ElseIf (Form1.PictureBox51.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Protected()
                    End If
                End If
            End If
            If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                Pic51None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox69.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Protected()
                    End If
                ElseIf (Form1.PictureBox69.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox69.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Attacked()
                    End If
                ElseIf (Form1.PictureBox69.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox69.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic69Protected()
                    End If
                End If
            End If
            If Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
            End If
        Else
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox69.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH4NorthMovementArea()
        i = 1
        If (Form1.PictureBox53.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 53
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox43.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic43Protected()
                    End If
                ElseIf (Form1.PictureBox43.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic43Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox45.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Protected()
                    End If
                ElseIf (Form1.PictureBox45.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox45.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Attacked()
                    End If
                ElseIf (Form1.PictureBox45.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Protected()
                    End If
                End If
            End If
            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                Pic45None()
            End If
        Else
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH5SouthMovementArea()
        i = 1
        If (Form1.PictureBox62.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 62
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox70.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Protected()
                    End If
                ElseIf (Form1.PictureBox70.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox70.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Attacked()
                    End If
                ElseIf (Form1.PictureBox70.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Protected()
                    End If
                End If
            End If
            If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
            End If
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox72.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic72Attacked()
                    End If
                ElseIf (Form1.PictureBox72.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox72.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic72Protected()
                    End If
                End If
            End If
            If Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                Pic72None()
            End If
        Else
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox72.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH5WestMovementArea()
        i = 1
        If (Form1.PictureBox52.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 52
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox42.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Protected()
                    End If
                ElseIf (Form1.PictureBox42.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox42.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Attacked()
                    End If
                ElseIf (Form1.PictureBox42.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Protected()
                    End If
                End If
            End If
            If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                Pic42None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox60.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Protected()
                    End If
                ElseIf (Form1.PictureBox60.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox60.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Attacked()
                    End If
                ElseIf (Form1.PictureBox60.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox60.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic60Protected()
                    End If
                End If
            End If
            If Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
            End If
        Else
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox60.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH5NorthMovementArea()
        i = 1
        If (Form1.PictureBox44.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 44
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Protected()
                    End If
                ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Attacked()
                    End If
                ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Protected()
                    End If
                End If
            End If
            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox36.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Protected()
                    End If
                ElseIf (Form1.PictureBox36.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox36.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Attacked()
                    End If
                ElseIf (Form1.PictureBox36.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Protected()
                    End If
                End If
            End If
            If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                Pic36None()
            End If
        Else
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH6SouthMovementArea()
        i = 1
        If (Form1.PictureBox53.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 53
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox61.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Protected()
                    End If
                ElseIf (Form1.PictureBox61.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox61.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Attacked()
                    End If
                ElseIf (Form1.PictureBox61.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Protected()
                    End If
                End If
            End If
            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox63.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Protected()
                    End If
                ElseIf (Form1.PictureBox63.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox63.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Attacked()
                    End If
                ElseIf (Form1.PictureBox63.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox63.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic63Protected()
                    End If
                End If
            End If
            If Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                Pic63None()
            End If
        Else
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox63.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH6WestMovementArea()
        i = 1
        If (Form1.PictureBox43.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 43
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox33.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Protected()
                    End If
                ElseIf (Form1.PictureBox33.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox33.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Attacked()
                    End If
                ElseIf (Form1.PictureBox33.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Protected()
                    End If
                End If
            End If
            If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                Pic33None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox51.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Protected()
                    End If
                ElseIf (Form1.PictureBox51.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox51.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Attacked()
                    End If
                ElseIf (Form1.PictureBox51.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox51.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic51Protected()
                    End If
                End If
            End If
            If Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                Pic51None()
            End If
        Else
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox51.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH6NorthMovementArea()
        i = 1
        If (Form1.PictureBox35.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 35
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox25.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Protected()
                    End If
                ElseIf (Form1.PictureBox25.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox25.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Attacked()
                    End If
                ElseIf (Form1.PictureBox25.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Protected()
                    End If
                End If
            End If
            If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                Pic25None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox27.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic27Protected()
                    End If
                ElseIf (Form1.PictureBox27.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic27Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                Pic27None()
            End If
        Else
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH7SouthMovementArea()
        i = 1
        If (Form1.PictureBox44.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 44
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox52.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic52Attacked()
                    End If
                ElseIf (Form1.PictureBox52.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic52Protected()
                    End If
                End If
            End If
            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox54.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Protected()
                    End If
                ElseIf (Form1.PictureBox54.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox54.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Attacked()
                    End If
                ElseIf (Form1.PictureBox54.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox54.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic54Protected()
                    End If
                End If
            End If
            If Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                Pic54None()
            End If
        Else
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox54.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH7WestMovementArea()
        i = 1
        If (Form1.PictureBox34.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 34
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox24.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Protected()
                    End If
                ElseIf (Form1.PictureBox24.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox24.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Attacked()
                    End If
                ElseIf (Form1.PictureBox24.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Protected()
                    End If
                End If
            End If
            If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox42.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Protected()
                    End If
                ElseIf (Form1.PictureBox42.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox42.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Attacked()
                    End If
                ElseIf (Form1.PictureBox42.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox42.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic42Protected()
                    End If
                End If
            End If
            If Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                Pic42None()
            End If
        Else
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox42.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH7NorthMovementArea()
        i = 1
        If (Form1.PictureBox26.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 26
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox16.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Protected()
                    End If
                ElseIf (Form1.PictureBox16.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox16.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Attacked()
                    End If
                ElseIf (Form1.PictureBox16.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Protected()
                    End If
                End If
            End If
            If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                Pic16None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox18.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic18Protected()
                    End If
                ElseIf (Form1.PictureBox18.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic18Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox18.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic18Attacked()
                    End If
                ElseIf (Form1.PictureBox18.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox18.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic18Protected()
                    End If
                End If
            End If
            If Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                Pic18None()
            End If
        Else
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox18.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH8SouthMovementArea()
        i = 1
        If (Form1.PictureBox35.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 35
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox43.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic43Protected()
                    End If
                ElseIf (Form1.PictureBox43.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic43Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox45.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Protected()
                    End If
                ElseIf (Form1.PictureBox45.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox45.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Attacked()
                    End If
                ElseIf (Form1.PictureBox45.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox45.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic45Protected()
                    End If
                End If
            End If
            If Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                Pic45None()
            End If
        Else
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox45.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH8WestMovementArea()
        i = 1
        If (Form1.PictureBox25.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 25
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox15.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic15Protected()
                    End If
                ElseIf (Form1.PictureBox15.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic15Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox15.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic15Attacked()
                    End If
                ElseIf (Form1.PictureBox15.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic15Protected()
                    End If
                End If
            End If
            If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Pic15None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox33.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Protected()
                    End If
                ElseIf (Form1.PictureBox33.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox33.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Attacked()
                    End If
                ElseIf (Form1.PictureBox33.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox33.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic33Protected()
                    End If
                End If
            End If
            If Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                Pic33None()
            End If
        Else
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox33.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH8NorthMovementArea()
        i = 1
        If (Form1.PictureBox17.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 17
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox7.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic7Protected()
                    End If
                ElseIf (Form1.PictureBox7.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic7Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                Pic7None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox9.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic9Protected()
                    End If
                ElseIf (Form1.PictureBox9.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic9Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox9.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic9Attacked()
                    End If
                ElseIf (Form1.PictureBox9.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox9.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic9Protected()
                    End If
                End If
            End If
            If Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                Pic9None()
            End If
        Else
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox9.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH9SouthMovementArea()
        i = 1
        If (Form1.PictureBox26.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 26
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Protected()
                    End If
                ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Attacked()
                    End If
                ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Protected()
                    End If
                End If
            End If
            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox36.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Protected()
                    End If
                ElseIf (Form1.PictureBox36.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox36.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Attacked()
                    End If
                ElseIf (Form1.PictureBox36.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox36.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic36Protected()
                    End If
                End If
            End If
            If Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                Pic36None()
            End If
        Else
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox36.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH9WestMovementArea()
        i = 1
        If (Form1.PictureBox16.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 16
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox6.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic6Protected()
                    End If
                ElseIf (Form1.PictureBox6.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic6Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox6.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic6Attacked()
                    End If
                ElseIf (Form1.PictureBox6.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox6.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic6Protected()
                    End If
                End If
            End If
            If Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                Pic6None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox24.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Protected()
                    End If
                ElseIf (Form1.PictureBox24.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox24.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Attacked()
                    End If
                ElseIf (Form1.PictureBox24.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox24.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic24Protected()
                    End If
                End If
            End If
            If Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
            End If
        Else
            Form1.PictureBox6.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox24.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH10SouthMovementArea()
        i = 1
        If (Form1.PictureBox17.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 17
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox25.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Protected()
                    End If
                ElseIf (Form1.PictureBox25.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox25.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Attacked()
                    End If
                ElseIf (Form1.PictureBox25.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Protected()
                    End If
                End If
            End If
            If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                Pic25None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox27.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic27Protected()
                    End If
                ElseIf (Form1.PictureBox27.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox27.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic27Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                Pic27None()
            End If
        Else
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox27.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaH10WestMovementArea()
        i = 1
        If (Form1.PictureBox7.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 7
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox15.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic15Protected()
                    End If
                ElseIf (Form1.PictureBox15.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic15Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox15.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic15Attacked()
                    End If
                ElseIf (Form1.PictureBox15.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox15.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic15Protected()
                    End If
                End If
            End If
            If Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Pic15None()
            End If
        Else
            Form1.PictureBox15.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI1WestMovementArea()
        i = 1
        If (Form1.PictureBox89.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 89
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox79.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Protected()
                    End If
                ElseIf (Form1.PictureBox79.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox79.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Attacked()
                    End If
                ElseIf (Form1.PictureBox79.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Protected()
                    End If
                End If
            End If
            If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                Pic79None()
            End If
        Else
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI1NorthMovementArea()
        i = 1
        If (Form1.PictureBox81.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 81
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox71.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Protected()
                    End If
                ElseIf (Form1.PictureBox71.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox71.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Attacked()
                    End If
                ElseIf (Form1.PictureBox71.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Protected()
                    End If
                End If
            End If
            If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
            End If
        Else
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI2WestMovementArea()
        i = 1
        If (Form1.PictureBox80.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 80
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox70.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Protected()
                    End If
                ElseIf (Form1.PictureBox70.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox70.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Attacked()
                    End If
                ElseIf (Form1.PictureBox70.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Protected()
                    End If
                End If
            End If
            If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
            End If
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox88.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic88Attacked()
                    End If
                ElseIf (Form1.PictureBox88.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox88.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic88Protected()
                    End If
                End If
            End If
            If Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                Pic88None()
            End If
        Else
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox88.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI2NorthMovementArea()
        i = 1
        If (Form1.PictureBox72.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 72
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Protected()
                    End If
                ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Attacked()
                    End If
                ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Protected()
                    End If
                End If
            End If
            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
            End If
        Else
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI3SouthMovementArea()
        i = 1
        If (Form1.PictureBox81.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 81
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox89.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic89Protected()
                    End If
                ElseIf (Form1.PictureBox89.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic89Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox89.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic89Attacked()
                    End If
                ElseIf (Form1.PictureBox89.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox89.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic89Protected()
                    End If
                End If
            End If
            If Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                Pic89None()
            End If
        Else
            Form1.PictureBox89.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI3WestMovementArea()
        i = 1
        If (Form1.PictureBox71.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 71
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox61.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Protected()
                    End If
                ElseIf (Form1.PictureBox61.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox61.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Attacked()
                    End If
                ElseIf (Form1.PictureBox61.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Protected()
                    End If
                End If
            End If
            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox79.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Protected()
                    End If
                ElseIf (Form1.PictureBox79.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox79.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Attacked()
                    End If
                ElseIf (Form1.PictureBox79.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox79.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic79Protected()
                    End If
                End If
            End If
            If Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                Pic79None()
            End If
        Else
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox79.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI3NorthMovementArea()
        i = 1
        If (Form1.PictureBox63.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 63
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Protected()
                    End If
                ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Attacked()
                    End If
                ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Protected()
                    End If
                End If
            End If
            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
            End If
        Else
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI4SouthMovementArea()
        i = 1
        If (Form1.PictureBox72.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 72
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox80.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic80Protected()
                    End If
                ElseIf (Form1.PictureBox80.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic80Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox80.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic80Attacked()
                    End If
                ElseIf (Form1.PictureBox80.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox80.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic80Protected()
                    End If
                End If
            End If
            If Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                Pic80None()
            End If
        Else
            Form1.PictureBox80.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI4WestMovementArea()
        i = 1
        If (Form1.PictureBox62.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 62
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox52.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic52Attacked()
                    End If
                ElseIf (Form1.PictureBox52.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic52Protected()
                    End If
                End If
            End If
            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox70.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Protected()
                    End If
                ElseIf (Form1.PictureBox70.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox70.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Attacked()
                    End If
                ElseIf (Form1.PictureBox70.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox70.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic70Protected()
                    End If
                End If
            End If
            If Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
            End If
        Else
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox70.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI4NorthMovementArea()
        i = 1
        If (Form1.PictureBox54.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 54
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Protected()
                    End If
                ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Attacked()
                    End If
                ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Protected()
                    End If
                End If
            End If
            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
            End If
        Else
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI5SouthMovementArea()
        i = 1
        If (Form1.PictureBox63.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 63
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox71.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Protected()
                    End If
                ElseIf (Form1.PictureBox71.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox71.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Attacked()
                    End If
                ElseIf (Form1.PictureBox71.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox71.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic71Protected()
                    End If
                End If
            End If
            If Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
            End If
        Else
            Form1.PictureBox71.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI5WestMovementArea()
        i = 1
        If (Form1.PictureBox53.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 53
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox43.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic43Protected()
                    End If
                ElseIf (Form1.PictureBox43.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic43Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox61.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Protected()
                    End If
                ElseIf (Form1.PictureBox61.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox61.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Attacked()
                    End If
                ElseIf (Form1.PictureBox61.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox61.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic61Protected()
                    End If
                End If
            End If
            If Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
            End If
        Else
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox61.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI5NorthMovementArea()
        i = 1
        If (Form1.PictureBox45.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 45
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Protected()
                    End If
                ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Attacked()
                    End If
                ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Protected()
                    End If
                End If
            End If
            If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
            End If
        Else
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI6SouthMovementArea()
        i = 1
        If (Form1.PictureBox54.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 54
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Protected()
                    End If
                ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Attacked()
                    End If
                ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic62Protected()
                    End If
                End If
            End If
            If Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
            End If
        Else
            Form1.PictureBox62.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI6WestMovementArea()
        i = 1
        If (Form1.PictureBox44.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 44
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Protected()
                    End If
                ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Attacked()
                    End If
                ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Protected()
                    End If
                End If
            End If
            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
            End If
            If Form1.PieceColor Is "Black" Then
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
                End If
            Else
                If (Form1.PictureBox52.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic52Attacked()
                    End If
                ElseIf (Form1.PictureBox52.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox52.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic52Protected()
                    End If
                End If
            End If
            If Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
            End If
        Else
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox52.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI6NorthMovementArea()
        i = 1
        If (Form1.PictureBox36.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 36
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Protected()
                    End If
                ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Attacked()
                    End If
                ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Protected()
                    End If
                End If
            End If
            If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
            End If
        Else
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI7SouthMovementArea()
        i = 1
        If (Form1.PictureBox45.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 45
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Protected()
                    End If
                ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Attacked()
                    End If
                ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic53Protected()
                    End If
                End If
            End If
            If Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
            End If
        Else
            Form1.PictureBox53.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI7WestMovementArea()
        i = 1
        If (Form1.PictureBox35.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 35
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox25.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Protected()
                    End If
                ElseIf (Form1.PictureBox25.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox25.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Attacked()
                    End If
                ElseIf (Form1.PictureBox25.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox25.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic25Protected()
                    End If
                End If
            End If
            If Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                Pic25None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox43.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic43Protected()
                    End If
                ElseIf (Form1.PictureBox43.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox43.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic43Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
            End If
        Else
            Form1.PictureBox25.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox43.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI7NorthMovementArea()
        i = 1
        If (Form1.PictureBox27.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 27
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox17.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Protected()
                    End If
                ElseIf (Form1.PictureBox17.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox17.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Attacked()
                    End If
                ElseIf (Form1.PictureBox17.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox17.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic17Protected()
                    End If
                End If
            End If
            If Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                Pic17None()
            End If
        Else
            Form1.PictureBox17.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI8SouthMovementArea()
        i = 1
        If (Form1.PictureBox36.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 36
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Protected()
                    End If
                ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Attacked()
                    End If
                ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic44Protected()
                    End If
                End If
            End If
            If Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
            End If
        Else
            Form1.PictureBox44.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI8WestMovementArea()
        i = 1
        If (Form1.PictureBox26.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 26
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox16.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Protected()
                    End If
                ElseIf (Form1.PictureBox16.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox16.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Attacked()
                    End If
                ElseIf (Form1.PictureBox16.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Protected()
                    End If
                End If
            End If
            If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                Pic16None()
            End If
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Protected()
                    End If
                ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Attacked()
                    End If
                ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic34Protected()
                    End If
                End If
            End If
            If Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
            End If
        Else
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
            Form1.PictureBox34.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI8NorthMovementArea()
        i = 1
        If (Form1.PictureBox18.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 18
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox8.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic8Protected()
                    End If
                ElseIf (Form1.PictureBox8.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic8Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox8.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic8Attacked()
                    End If
                ElseIf (Form1.PictureBox8.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox8.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic8Protected()
                    End If
                End If
            End If
            If Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                Pic8None()
            End If
        Else
            Form1.PictureBox8.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI9SouthMovementArea()
        i = 1
        If (Form1.PictureBox27.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 27
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Protected()
                    End If
                ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Attacked()
                    End If
                ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic35Protected()
                    End If
                End If
            End If
            If Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
            End If
        Else
            Form1.PictureBox35.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI9WestMovementArea()
        i = 1
        If (Form1.PictureBox17.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 17
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox7.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic7Protected()
                    End If
                ElseIf (Form1.PictureBox7.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox7.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic7Attacked()
                    End If
                End If
            Else
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
                End If
            End If
            If Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                Pic7None()
            End If
        Else
            Form1.PictureBox7.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI10SouthMovementArea()
        i = 1
        If (Form1.PictureBox18.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 18
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Protected()
                    End If
                ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Attacked()
                    End If
                ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic26Protected()
                    End If
                End If
            End If
            If Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
            End If
        Else
            Form1.PictureBox26.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub

    Public Sub MaI10WestMovementArea()
        i = 1
        If (Form1.PictureBox8.Image Is Form1.nonePic.Image) Then
            PictureboxAbleToBlock(i) = 8
            If Form1.PieceColor Is "Black" Then
                If (Form1.PictureBox16.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Protected()
                    End If
                ElseIf (Form1.PictureBox16.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Attacked()
                    End If
                End If
            Else
                If (Form1.PictureBox16.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.blackXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Attacked()
                    End If
                ElseIf (Form1.PictureBox16.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteChePic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteMaPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteShiPic.Image) Or _
                (Form1.PictureBox16.Image Is Form1.whiteXiangPic.Image) Then
                    If Form1.Purpose1 = "CheckMovementArea" Then
                        Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
                    ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                        Pic16Protected()
                    End If
                End If
            End If
            If Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                Pic16None()
            End If
        Else
            Form1.PictureBox16.Image = Form1.blockMovementAreaPic.Image
        End If
    End Sub
End Module
