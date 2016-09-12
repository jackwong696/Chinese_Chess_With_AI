' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 13/11/2010
' Descripitons : Chinese Chess V1

Module ModuleCheckMovementAreaColor
    Public Sub CheckPicturebox1Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox1.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox1.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox1.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox1.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic1Protected()
                End If
            ElseIf (Form1.PictureBox1.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox1.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox1.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox1.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox1.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox1.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox1.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic1Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox1.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox1.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox1.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox1.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic1Attacked()
                End If
            ElseIf (Form1.PictureBox1.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox1.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox1.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox1.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox1.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox1.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox1.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox1.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic1Protected()
                End If
            End If
        End If
    End Sub
    Public Sub CheckPicturebox2Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox2.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox2.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox2.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox2.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic2Protected()
                End If
            ElseIf (Form1.PictureBox2.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox2.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox2.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox2.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox2.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox2.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox2.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic2Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox2.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox2.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox2.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox2.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic2Attacked()
                End If
            ElseIf (Form1.PictureBox2.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox2.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox2.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox2.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox2.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox2.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox2.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox2.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic2Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox3Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox3.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox3.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic3Protected()
                End If
            ElseIf (Form1.PictureBox3.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox3.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox3.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox3.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox3.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic3Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
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
            End If
        End If
    End Sub

    Public Sub CheckPicturebox4Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox5Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox6Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox7Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox8Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox9Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox10Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox10.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox10.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox10.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox10.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic10Protected()
                End If
            ElseIf (Form1.PictureBox10.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox10.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox10.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox10.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox10.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox10.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox10.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic10Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox10.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox10.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox10.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox10.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic10Attacked()
                End If
            ElseIf (Form1.PictureBox10.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox10.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox10.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox10.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox10.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox10.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox10.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox10.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic10Protected()
                End If
            End If
        End If
    End Sub
    Public Sub CheckPicturebox11Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox11.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox11.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox11.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox11.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic11Protected()
                End If
            ElseIf (Form1.PictureBox11.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox11.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox11.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox11.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox11.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox11.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox11.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic11Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox11.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox11.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox11.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox11.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic11Attacked()
                End If
            ElseIf (Form1.PictureBox11.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox11.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox11.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox11.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox11.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox11.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox11.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox11.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic11Protected()
                End If
            End If
        End If
    End Sub
    Public Sub CheckPicturebox12Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox12.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox12.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox12.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox12.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic12Protected()
                End If
            ElseIf (Form1.PictureBox12.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox12.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox12.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox12.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox12.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox12.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox12.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic12Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox12.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox12.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox12.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox12.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic12Attacked()
                End If
            ElseIf (Form1.PictureBox12.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox12.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox12.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox12.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox12.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox12.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox12.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox12.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic12Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox13Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox14Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox15Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox16Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox17Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox18Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox19Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox19.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox19.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic19Protected()
                End If
            ElseIf (Form1.PictureBox19.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox19.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox19.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox19.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox19.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic19Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
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
            End If
        End If
    End Sub

    Public Sub CheckPicturebox20Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox20.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox20.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox20.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox20.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic20Protected()
                End If
            ElseIf (Form1.PictureBox20.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox20.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox20.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox20.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox20.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox20.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox20.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic20Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox20.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox20.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox20.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox20.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic20Attacked()
                End If
            ElseIf (Form1.PictureBox20.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox20.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox20.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox20.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox20.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox20.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox20.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox20.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic20Protected()
                End If
            End If
        End If
    End Sub
    Public Sub CheckPicturebox21Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox21.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox21.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox21.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox21.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic21Protected()
                End If
            ElseIf (Form1.PictureBox21.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox21.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox21.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox21.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox21.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox21.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox21.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic21Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox21.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox21.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox21.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox21.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic21Attacked()
                End If
            ElseIf (Form1.PictureBox21.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox21.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox21.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox21.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox21.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox21.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox21.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox21.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic21Protected()
                End If
            End If
        End If
    End Sub
    Public Sub CheckPicturebox22Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox23Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox24Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox25Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox26Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox27Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox28Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox28.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox28.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox28.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox28.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic28Protected()
                End If
            ElseIf (Form1.PictureBox28.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox28.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox28.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox28.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox28.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox28.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox28.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic28Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox28.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox28.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox28.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox28.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic28Attacked()
                End If
            ElseIf (Form1.PictureBox28.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox28.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox28.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox28.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox28.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox28.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox28.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox28.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic28Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox29Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox29.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox29.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox29.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox29.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic29Protected()
                End If
            ElseIf (Form1.PictureBox29.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox29.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox29.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox29.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox29.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox29.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox29.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic29Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox29.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox29.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox29.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox29.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic29Attacked()
                End If
            ElseIf (Form1.PictureBox29.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox29.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox29.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox29.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox29.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox29.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox29.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox29.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic29Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox30Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox30.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox30.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox30.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox30.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic30Protected()
                End If
            ElseIf (Form1.PictureBox30.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox30.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox30.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox30.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox30.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox30.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox30.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic30Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox30.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox30.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox30.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox30.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic30Attacked()
                End If
            ElseIf (Form1.PictureBox30.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox30.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox30.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox30.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox30.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox30.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox30.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox30.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic30Protected()
                End If
            End If
        End If
    End Sub
    Public Sub CheckPicturebox31Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub
    Public Sub CheckPicturebox32Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox33Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox34Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox35Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox36Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox37Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox37.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox37.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox37.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox37.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic37Protected()
                End If
            ElseIf (Form1.PictureBox37.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox37.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox37.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox37.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox37.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox37.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox37.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic37Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox37.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox37.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox37.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox37.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic37Attacked()
                End If
            ElseIf (Form1.PictureBox37.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox37.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox37.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox37.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox37.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox37.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox37.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox37.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic37Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox38Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox38.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox38.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox38.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox38.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic38Protected()
                End If
            ElseIf (Form1.PictureBox38.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox38.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox38.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox38.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox38.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox38.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox38.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic38Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox38.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox38.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox38.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox38.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic38Attacked()
                End If
            ElseIf (Form1.PictureBox38.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox38.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox38.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox38.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox38.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox38.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox38.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox38.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic38Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox39Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox39.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox39.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic39Protected()
                End If
            ElseIf (Form1.PictureBox39.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox39.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox39.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox39.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox39.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic39Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
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
            End If
        End If
    End Sub

    Public Sub CheckPicturebox40Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub
    Public Sub CheckPicturebox41Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub
    Public Sub CheckPicturebox42Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox43Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox44Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox45Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox46Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox46.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic46Protected()
                End If
            ElseIf (Form1.PictureBox46.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox46.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox46.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox46.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic46Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox46.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic46Attacked()
                End If
            ElseIf (Form1.PictureBox46.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox46.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox46.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox46.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox46.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic46Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox47Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox47.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic47Protected()
                End If
            ElseIf (Form1.PictureBox47.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox47.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox47.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox47.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic47Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox47.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic47Attacked()
                End If
            ElseIf (Form1.PictureBox47.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox47.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox47.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox47.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox47.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic47Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox48Color()
        If Form1.PieceColor Is "Black" Then
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
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox48.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic48Attacked()
                End If
            ElseIf (Form1.PictureBox48.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox48.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox48.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox48.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox48.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic48Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox49Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox50Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub
    Public Sub CheckPicturebox51Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub
    Public Sub CheckPicturebox52Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox53Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox54Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox55Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox55.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic55Protected()
                End If
            ElseIf (Form1.PictureBox55.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox55.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox55.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox55.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic55Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox55.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic55Attacked()
                End If
            ElseIf (Form1.PictureBox55.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox55.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox55.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox55.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox55.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic55Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox56Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox56.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic56Protected()
                End If
            ElseIf (Form1.PictureBox56.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox56.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox56.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox56.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic56Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox56.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic56Attacked()
                End If
            ElseIf (Form1.PictureBox56.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox56.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox56.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox56.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox56.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic56Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox57Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox57.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic57Protected()
                End If
            ElseIf (Form1.PictureBox57.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox57.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox57.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox57.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic57Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox57.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic57Attacked()
                End If
            ElseIf (Form1.PictureBox57.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox57.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox57.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox57.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox57.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic57Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox58Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox59Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox60Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub
    Public Sub CheckPicturebox61Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub
    Public Sub CheckPicturebox62Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox63Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox64Color()
        If Form1.PieceColor Is "Black" Then
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
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox64.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic64Attacked()
                End If
            ElseIf (Form1.PictureBox64.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox64.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox64.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox64.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox64.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic64Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox65Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox65.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic65Protected()
                End If
            ElseIf (Form1.PictureBox65.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox65.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox65.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox65.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic65Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox65.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic65Attacked()
                End If
            ElseIf (Form1.PictureBox65.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox65.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox65.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox65.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox65.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic65Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox66Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox66.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic66Protected()
                End If
            ElseIf (Form1.PictureBox66.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox66.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox66.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox66.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic66Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox66.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic66Attacked()
                End If
            ElseIf (Form1.PictureBox66.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox66.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox66.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox66.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox66.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic66Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox67Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox68Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox69Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox70Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub
    Public Sub CheckPicturebox71Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub
    Public Sub CheckPicturebox72Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox73Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox73.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic73Protected()
                End If
            ElseIf (Form1.PictureBox73.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox73.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox73.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox73.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic73Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox73.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic73Attacked()
                End If
            ElseIf (Form1.PictureBox73.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox73.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox73.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox73.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox73.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic73Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox74Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox74.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic74Protected()
                End If
            ElseIf (Form1.PictureBox74.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox74.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox74.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox74.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic74Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox74.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic74Attacked()
                End If
            ElseIf (Form1.PictureBox74.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox74.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox74.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox74.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox74.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic74Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox75Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox75.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic75Protected()
                End If
            ElseIf (Form1.PictureBox75.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox75.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox75.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox75.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic75Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox75.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic75Attacked()
                End If
            ElseIf (Form1.PictureBox75.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox75.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox75.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox75.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox75.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic75Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox76Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox77Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox78Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox79Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox80Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub
    Public Sub CheckPicturebox81Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub
    Public Sub CheckPicturebox82Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox82.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic82Protected()
                End If
            ElseIf (Form1.PictureBox82.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox82.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox82.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox82.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic82Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox82.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic82Attacked()
                End If
            ElseIf (Form1.PictureBox82.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox82.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox82.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox82.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox82.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic82Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox83Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox83.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic83Protected()
                End If
            ElseIf (Form1.PictureBox83.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox83.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox83.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox83.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic83Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox83.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic83Attacked()
                End If
            ElseIf (Form1.PictureBox83.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox83.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox83.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox83.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox83.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic83Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox84Color()
        If Form1.PieceColor Is "Black" Then
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
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox84.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic84Attacked()
                End If
            ElseIf (Form1.PictureBox84.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox84.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox84.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox84.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox84.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic84Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox85Color()
        If Form1.PieceColor Is "Black" Then
            If (Form1.PictureBox85.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox85.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox85.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox85.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic85Protected()
                End If
            ElseIf (Form1.PictureBox85.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox85.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox85.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox85.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox85.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox85.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox85.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic85Attacked()
                End If
            End If
        ElseIf Form1.PieceColor Is "White" Then
            If (Form1.PictureBox85.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox85.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox85.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox85.Image Is Form1.blackXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic85Attacked()
                End If
            ElseIf (Form1.PictureBox85.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox85.Image Is Form1.whiteChePic.Image) Or _
            (Form1.PictureBox85.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox85.Image Is Form1.whiteMaPic.Image) Or _
            (Form1.PictureBox85.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox85.Image Is Form1.whiteShiPic.Image) Or _
            (Form1.PictureBox85.Image Is Form1.whiteXiangPic.Image) Then
                If Form1.Purpose1 = "CheckMovementArea" Then
                    Form1.PictureBox85.Image = Form1.blockMovementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic85Protected()
                End If
            End If
        End If
    End Sub

    Public Sub CheckPicturebox86Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox87Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox88Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox89Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub

    Public Sub CheckPicturebox90Color()
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
        ElseIf Form1.PieceColor Is "White" Then
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
    End Sub
End Module
