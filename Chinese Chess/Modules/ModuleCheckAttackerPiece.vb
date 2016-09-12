' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 26/01/2011
' Descripitons : Chinese Chess V1

Module ModuleCheckAttackerPiece
    Public AttackerPiece As String

    Public Sub CheckAttackerPiece()
        If AttackerPicLocation = 1 Then
            If (Form1.PictureBox1.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox1.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox1.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox1.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox1.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox1.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox1.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox1.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 2 Then
            If (Form1.PictureBox2.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox2.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox2.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox2.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox2.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox2.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox2.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox2.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 3 Then
            If (Form1.PictureBox3.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox3.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox3.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox3.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox3.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox3.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox3.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox3.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 4 Then
            If (Form1.PictureBox4.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox4.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox4.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox4.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox4.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox4.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox4.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox4.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 5 Then
            If (Form1.PictureBox5.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox5.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox5.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox5.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox5.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox5.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox5.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox5.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 6 Then
            If (Form1.PictureBox6.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox6.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox6.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox6.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox6.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox6.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox6.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox6.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 7 Then
            If (Form1.PictureBox7.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox7.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox7.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox7.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox7.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox7.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox7.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox7.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 8 Then
            If (Form1.PictureBox8.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox8.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox8.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox8.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox8.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox8.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox8.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox8.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 9 Then
            If (Form1.PictureBox9.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox9.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox9.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox9.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox9.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox9.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox9.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox9.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 10 Then
            If (Form1.PictureBox10.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox10.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox10.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox10.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox10.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox10.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox10.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox10.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 11 Then
            If (Form1.PictureBox11.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox11.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox11.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox11.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox11.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox11.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox11.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox11.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 12 Then
            If (Form1.PictureBox12.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox12.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox12.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox12.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox12.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox12.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox12.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox12.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 13 Then
            If (Form1.PictureBox13.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox13.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox13.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox13.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox13.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox13.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox13.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox13.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 14 Then
            If (Form1.PictureBox14.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox14.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox14.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox14.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox14.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox14.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox14.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox14.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 15 Then
            If (Form1.PictureBox15.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox15.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox15.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox15.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox15.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox15.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox15.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox15.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 16 Then
            If (Form1.PictureBox16.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox16.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox16.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox16.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox16.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox16.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox16.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox16.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 17 Then
            If (Form1.PictureBox17.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox17.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox17.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox17.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox17.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox17.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox17.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox17.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 18 Then
            If (Form1.PictureBox18.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox18.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox18.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox18.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox18.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox18.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox18.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox18.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 19 Then
            If (Form1.PictureBox19.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox19.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox19.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox19.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox19.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox19.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox19.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox19.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 20 Then
            If (Form1.PictureBox20.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox20.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox20.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox20.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox20.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox20.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox20.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox20.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 21 Then
            If (Form1.PictureBox21.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox21.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox21.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox21.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox21.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox21.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox21.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox21.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 22 Then
            If (Form1.PictureBox22.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox22.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox22.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox22.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox22.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox22.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox22.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox22.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 23 Then
            If (Form1.PictureBox23.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox23.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox23.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox23.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox23.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox23.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox23.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox23.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 24 Then
            If (Form1.PictureBox24.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox24.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox24.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox24.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox24.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox24.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox24.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox24.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 25 Then
            If (Form1.PictureBox25.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox25.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox25.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox25.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox25.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox25.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox25.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox25.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 26 Then
            If (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 27 Then
            If (Form1.PictureBox27.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox27.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox27.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox27.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox27.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox27.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox27.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox27.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 28 Then
            If (Form1.PictureBox28.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox28.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox28.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox28.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox28.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox28.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox28.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox28.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 29 Then
            If (Form1.PictureBox29.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox29.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox29.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox29.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox29.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox29.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox29.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox29.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 30 Then
            If (Form1.PictureBox30.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox30.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox30.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox30.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox30.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox30.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox30.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox30.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 31 Then
            If (Form1.PictureBox31.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox31.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox31.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox31.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox31.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox31.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox31.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox31.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 32 Then
            If (Form1.PictureBox32.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox32.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox32.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox32.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox32.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox32.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox32.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox32.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 33 Then
            If (Form1.PictureBox33.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox33.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox33.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox33.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox33.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox33.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox33.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox33.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 34 Then
            If (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 35 Then
            If (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 36 Then
            If (Form1.PictureBox36.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox36.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox36.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox36.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox36.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox36.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox36.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox36.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 37 Then
            If (Form1.PictureBox37.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox37.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox37.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox37.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox37.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox37.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox37.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox37.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 38 Then
            If (Form1.PictureBox38.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox38.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox38.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox38.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox38.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox38.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox38.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox38.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 39 Then
            If (Form1.PictureBox39.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox39.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox39.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox39.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox39.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox39.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox39.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox39.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 40 Then
            If (Form1.PictureBox40.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox40.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox40.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox40.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox40.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox40.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox40.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox40.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 41 Then
            If (Form1.PictureBox41.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox41.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox41.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox41.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox41.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox41.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox41.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox41.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 42 Then
            If (Form1.PictureBox42.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox42.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox42.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox42.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox42.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox42.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox42.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox42.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 43 Then
            If (Form1.PictureBox43.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox43.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox43.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox43.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox43.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox43.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox43.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox43.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 44 Then
            If (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 45 Then
            If (Form1.PictureBox45.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox45.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox45.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox45.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox45.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox45.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox45.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox45.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 46 Then
            If (Form1.PictureBox46.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox46.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox46.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox46.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox46.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox46.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox46.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox46.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 47 Then
            If (Form1.PictureBox47.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox47.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox47.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox47.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox47.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox47.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox47.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox47.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 48 Then
            If (Form1.PictureBox48.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox48.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox48.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox48.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox48.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox48.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox48.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox48.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 49 Then
            If (Form1.PictureBox49.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox49.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox49.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox49.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox49.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox49.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox49.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox49.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 50 Then
            If (Form1.PictureBox50.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox50.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox50.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox50.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox50.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox50.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox50.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox50.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 51 Then
            If (Form1.PictureBox51.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox51.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox51.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox51.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox51.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox51.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox51.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox51.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 52 Then
            If (Form1.PictureBox52.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox52.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox52.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox52.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox52.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox52.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox52.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox52.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 53 Then
            If (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 54 Then
            If (Form1.PictureBox54.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox54.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox54.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox54.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox54.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox54.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox54.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox54.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 55 Then
            If (Form1.PictureBox55.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox55.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox55.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox55.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox55.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox55.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox55.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox55.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 56 Then
            If (Form1.PictureBox56.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox56.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox56.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox56.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox56.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox56.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox56.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox56.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 57 Then
            If (Form1.PictureBox57.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox57.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox57.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox57.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox57.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox57.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox57.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox57.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 58 Then
            If (Form1.PictureBox58.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox58.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox58.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox58.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox58.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox58.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox58.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox58.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 59 Then
            If (Form1.PictureBox59.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox59.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox59.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox59.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox59.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox59.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox59.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox59.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 60 Then
            If (Form1.PictureBox60.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox60.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox60.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox60.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox60.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox60.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox60.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox60.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 61 Then
            If (Form1.PictureBox61.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox61.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox61.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox61.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox61.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox61.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox61.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox61.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 62 Then
            If (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 63 Then
            If (Form1.PictureBox63.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox63.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox63.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox63.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox63.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox63.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox63.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox63.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 64 Then
            If (Form1.PictureBox64.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox64.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox64.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox64.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox64.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox64.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox64.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox64.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 65 Then
            If (Form1.PictureBox65.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox65.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox65.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox65.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox65.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox65.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox65.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox65.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 66 Then
            If (Form1.PictureBox66.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox66.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox66.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox66.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox66.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox66.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox66.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox66.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 67 Then
            If (Form1.PictureBox67.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox67.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox67.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox67.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox67.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox67.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox67.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox67.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 68 Then
            If (Form1.PictureBox68.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox68.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox68.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox68.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox68.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox68.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox68.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox68.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 69 Then
            If (Form1.PictureBox69.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox69.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox69.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox69.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox69.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox69.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox69.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox69.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 70 Then
            If (Form1.PictureBox70.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox70.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox70.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox70.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox70.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox70.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox70.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox70.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 71 Then
            If (Form1.PictureBox71.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox71.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox71.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox71.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox71.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox71.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox71.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox71.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 72 Then
            If (Form1.PictureBox72.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox72.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox72.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox72.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox72.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox72.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox72.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox72.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 73 Then
            If (Form1.PictureBox73.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox73.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox73.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox73.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox73.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox73.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox73.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox73.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 74 Then
            If (Form1.PictureBox74.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox74.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox74.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox74.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox74.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox74.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox74.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox74.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 75 Then
            If (Form1.PictureBox75.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox75.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox75.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox75.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox75.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox75.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox75.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox75.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 76 Then
            If (Form1.PictureBox76.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox76.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox76.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox76.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox76.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox76.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox76.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox76.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 77 Then
            If (Form1.PictureBox77.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox77.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox77.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox77.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox77.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox77.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox77.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox77.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 78 Then
            If (Form1.PictureBox78.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox78.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox78.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox78.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox78.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox78.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox78.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox78.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 79 Then
            If (Form1.PictureBox79.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox79.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox79.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox79.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox79.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox79.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox79.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox79.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 80 Then
            If (Form1.PictureBox80.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox80.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox80.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox80.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox80.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox80.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox80.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox80.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 81 Then
            If (Form1.PictureBox81.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox81.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox81.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox81.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox81.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox81.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox81.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox81.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 82 Then
            If (Form1.PictureBox82.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox82.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox82.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox82.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox82.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox82.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox82.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox82.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 83 Then
            If (Form1.PictureBox83.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox83.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox83.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox83.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox83.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox83.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox83.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox83.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 84 Then
            If (Form1.PictureBox84.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox84.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox84.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox84.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox84.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox84.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox84.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox84.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 85 Then
            If (Form1.PictureBox85.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox85.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox85.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox85.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox85.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox85.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox85.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox85.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 86 Then
            If (Form1.PictureBox86.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox86.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox86.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox86.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox86.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox86.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox86.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox86.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 87 Then
            If (Form1.PictureBox87.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox87.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox87.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox87.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox87.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox87.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox87.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox87.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 88 Then
            If (Form1.PictureBox88.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox88.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox88.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox88.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox88.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox88.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox88.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox88.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 89 Then
            If (Form1.PictureBox89.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox89.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox89.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox89.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox89.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox89.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox89.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox89.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        ElseIf AttackerPicLocation = 90 Then
            If (Form1.PictureBox90.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox90.Image Is Form1.blackChePic.Image) Then
                AttackerPiece = "Che"
            ElseIf (Form1.PictureBox90.Image Is Form1.whitePaoPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackPaoPic.Image) Then
                AttackerPiece = "Pao"
            ElseIf (Form1.PictureBox90.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackMaPic.Image) Then
                AttackerPiece = "Ma"
            ElseIf (Form1.PictureBox90.Image Is Form1.whiteZuPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackBingPic.Image) Then
                AttackerPiece = "BingZu"
            ElseIf (Form1.PictureBox90.Image Is Form1.whiteXiangPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackXiangPic.Image) Then
                AttackerPiece = "Xiang"
            ElseIf (Form1.PictureBox90.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackShiPic.Image) Then
                AttackerPiece = "Shi"
            ElseIf (Form1.PictureBox90.Image Is Form1.whiteJiangPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackJiangPic.Image) Then
                AttackerPiece = "Jiang"
            End If
        End If
    End Sub
End Module
