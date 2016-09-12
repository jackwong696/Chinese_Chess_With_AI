' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 28/10/2010
' Descripitons : Chinese Chess V1

Module ModuleCheckPiece

    Public Sub CheckPiece()
        Form1.travelPic.Image = Form1.PictureBox1.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(1) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(1) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(1) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(1) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(1) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(1) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(1) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(1) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(1) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(1) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(1) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(1) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(1) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(1) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(1) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox2.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(2) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(2) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(2) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(2) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(2) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(2) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(2) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(2) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(2) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(2) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(2) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(2) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(2) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(2) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(2) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox3.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(3) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(3) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(3) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(3) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(3) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(3) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(3) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(3) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(3) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(3) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(3) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(3) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(3) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(3) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(3) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox4.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(4) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(4) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(4) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(4) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(4) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(4) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(4) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(4) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(4) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(4) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(4) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(4) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(4) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(4) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(4) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox5.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(5) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(5) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(5) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(5) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(5) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(5) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(5) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(5) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(5) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(5) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(5) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(5) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(5) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(5) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(5) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox6.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(6) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(6) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(6) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(6) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(6) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(6) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(6) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(6) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(6) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(6) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(6) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(6) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(6) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(6) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(6) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox7.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(7) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(7) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(7) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(7) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(7) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(7) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(7) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(7) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(7) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(7) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(7) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(7) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(7) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(7) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(7) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox8.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(8) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(8) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(8) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(8) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(8) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(8) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(8) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(8) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(8) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(8) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(8) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(8) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(8) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(8) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(8) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox9.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(9) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(9) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(9) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(9) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(9) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(9) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(9) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(9) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(9) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(9) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(9) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(9) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(9) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(9) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(9) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox10.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(10) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(10) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(10) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(10) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(10) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(10) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(10) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(10) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(10) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(10) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(10) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(10) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(10) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(10) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(10) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox11.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(11) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(11) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(11) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(11) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(11) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(11) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(11) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(11) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(11) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(11) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(11) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(11) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(11) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(11) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(11) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox12.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(12) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(12) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(12) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(12) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(12) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(12) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(12) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(12) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(12) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(12) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(12) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(12) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(12) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(12) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(12) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox13.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(13) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(13) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(13) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(13) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(13) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(13) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(13) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(13) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(13) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(13) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(13) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(13) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(13) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(13) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(13) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox14.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(14) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(14) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(14) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(14) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(14) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(14) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(14) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(14) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(14) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(14) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(14) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(14) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(14) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(14) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(14) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox15.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(15) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(15) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(15) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(15) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(15) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(15) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(15) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(15) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(15) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(15) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(15) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(15) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(15) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(15) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(15) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox16.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(16) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(16) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(16) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(16) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(16) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(16) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(16) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(16) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(16) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(16) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(16) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(16) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(16) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(16) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(16) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox17.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(17) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(17) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(17) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(17) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(17) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(17) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(17) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(17) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(17) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(17) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(17) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(17) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(17) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(17) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(17) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox18.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(18) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(18) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(18) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(18) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(18) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(18) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(18) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(18) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(18) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(18) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(18) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(18) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(18) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(18) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(18) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox19.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(19) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(19) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(19) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(19) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(19) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(19) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(19) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(19) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(19) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(19) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(19) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(19) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(19) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(19) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(19) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox20.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(20) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(20) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(20) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(20) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(20) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(20) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(20) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(20) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(20) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(20) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(20) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(20) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(20) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(20) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(20) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox21.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(21) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(21) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(21) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(21) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(21) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(21) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(21) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(21) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(21) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(21) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(21) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(21) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(21) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(21) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(21) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox22.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(22) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(22) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(22) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(22) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(22) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(22) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(22) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(22) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(22) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(22) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(22) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(22) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(22) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(22) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(22) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox23.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(23) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(23) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(23) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(23) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(23) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(23) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(23) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(23) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(23) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(23) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(23) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(23) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(23) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(23) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(23) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox24.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(24) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(24) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(24) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(24) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(24) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(24) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(24) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(24) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(24) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(24) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(24) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(24) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(24) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(24) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(24) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox25.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(25) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(25) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(25) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(25) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(25) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(25) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(25) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(25) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(25) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(25) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(25) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(25) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(25) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(25) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(25) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox26.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(26) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(26) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(26) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(26) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(26) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(26) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(26) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(26) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(26) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(26) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(26) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(26) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(26) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(26) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(26) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox27.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(27) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(27) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(27) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(27) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(27) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(27) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(27) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(27) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(27) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(27) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(27) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(27) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(27) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(27) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(27) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox28.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(28) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(28) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(28) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(28) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(28) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(28) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(28) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(28) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(28) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(28) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(28) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(28) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(28) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(28) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(28) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox29.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(29) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(29) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(29) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(29) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(29) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(29) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(29) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(29) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(29) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(29) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(29) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(29) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(29) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(29) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(29) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox30.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(30) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(30) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(30) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(30) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(30) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(30) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(30) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(30) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(30) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(30) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(30) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(30) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(30) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(30) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(30) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox31.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(31) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(31) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(31) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(31) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(31) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(31) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(31) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(31) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(31) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(31) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(31) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(31) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(31) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(31) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(31) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox32.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(32) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(32) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(32) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(32) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(32) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(32) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(32) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(32) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(32) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(32) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(32) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(32) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(32) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(32) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(32) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox33.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(33) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(33) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(33) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(33) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(33) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(33) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(33) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(33) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(33) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(33) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(33) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(33) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(33) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(33) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(33) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox34.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(34) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(34) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(34) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(34) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(34) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(34) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(34) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(34) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(34) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(34) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(34) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(34) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(34) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(34) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(34) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox35.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(35) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(35) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(35) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(35) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(35) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(35) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(35) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(35) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(35) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(35) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(35) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(35) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(35) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(35) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(35) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox36.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(36) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(36) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(36) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(36) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(36) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(36) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(36) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(36) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(36) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(36) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(36) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(36) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(36) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(36) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(36) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox37.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(37) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(37) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(37) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(37) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(37) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(37) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(37) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(37) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(37) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(37) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(37) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(37) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(37) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(37) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(37) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox38.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(38) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(38) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(38) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(38) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(38) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(38) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(38) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(38) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(38) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(38) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(38) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(38) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(38) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(38) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(38) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox39.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(39) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(39) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(39) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(39) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(39) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(39) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(39) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(39) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(39) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(39) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(39) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(39) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(39) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(39) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(39) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox40.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(40) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(40) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(40) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(40) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(40) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(40) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(40) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(40) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(40) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(40) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(40) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(40) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(40) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(40) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(40) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox41.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(41) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(41) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(41) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(41) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(41) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(41) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(41) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(41) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(41) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(41) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(41) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(41) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(41) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(41) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(41) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox42.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(42) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(42) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(42) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(42) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(42) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(42) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(42) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(42) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(42) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(42) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(42) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(42) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(42) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(42) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(42) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox43.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(43) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(43) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(43) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(43) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(43) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(43) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(43) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(43) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(43) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(43) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(43) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(43) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(43) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(43) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(43) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox44.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(44) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(44) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(44) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(44) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(44) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(44) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(44) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(44) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(44) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(44) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(44) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(44) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(44) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(44) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(44) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox45.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(45) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(45) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(45) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(45) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(45) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(45) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(45) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(45) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(45) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(45) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(45) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(45) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(45) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(45) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(45) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox46.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(46) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(46) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(46) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(46) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(46) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(46) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(46) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(46) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(46) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(46) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(46) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(46) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(46) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(46) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(46) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox47.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(47) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(47) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(47) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(47) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(47) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(47) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(47) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(47) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(47) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(47) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(47) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(47) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(47) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(47) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(47) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox48.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(48) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(48) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(48) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(48) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(48) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(48) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(48) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(48) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(48) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(48) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(48) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(48) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(48) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(48) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(48) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox49.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(49) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(49) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(49) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(49) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(49) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(49) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(49) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(49) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(49) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(49) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(49) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(49) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(49) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(49) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(49) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox50.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(50) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(50) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(50) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(50) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(50) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(50) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(50) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(50) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(50) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(50) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(50) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(50) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(50) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(50) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(50) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox51.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(51) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(51) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(51) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(51) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(51) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(51) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(51) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(51) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(51) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(51) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(51) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(51) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(51) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(51) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(51) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox52.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(52) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(52) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(52) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(52) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(52) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(52) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(52) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(52) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(52) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(52) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(52) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(52) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(52) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(52) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(52) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox53.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(53) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(53) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(53) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(53) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(53) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(53) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(53) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(53) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(53) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(53) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(53) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(53) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(53) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(53) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(53) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox54.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(54) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(54) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(54) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(54) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(54) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(54) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(54) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(54) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(54) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(54) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(54) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(54) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(54) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(54) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(54) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox55.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(55) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(55) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(55) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(55) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(55) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(55) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(55) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(55) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(55) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(55) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(55) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(55) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(55) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(55) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(55) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox56.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(56) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(56) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(56) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(56) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(56) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(56) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(56) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(56) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(56) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(56) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(56) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(56) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(56) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(56) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(56) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox57.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(57) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(57) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(57) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(57) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(57) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(57) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(57) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(57) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(57) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(57) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(57) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(57) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(57) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(57) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(57) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox58.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(58) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(58) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(58) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(58) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(58) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(58) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(58) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(58) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(58) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(58) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(58) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(58) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(58) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(58) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(58) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox59.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(59) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(59) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(59) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(59) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(59) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(59) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(59) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(59) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(59) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(59) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(59) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(59) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(59) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(59) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(59) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox60.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(60) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(60) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(60) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(60) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(60) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(60) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(60) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(60) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(60) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(60) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(60) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(60) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(60) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(60) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(60) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox61.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(61) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(61) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(61) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(61) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(61) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(61) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(61) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(61) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(61) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(61) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(61) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(61) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(61) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(61) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(61) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox62.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(62) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(62) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(62) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(62) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(62) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(62) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(62) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(62) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(62) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(62) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(62) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(62) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(62) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(62) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(62) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox63.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(63) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(63) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(63) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(63) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(63) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(63) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(63) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(63) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(63) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(63) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(63) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(63) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(63) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(63) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(63) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox64.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(64) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(64) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(64) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(64) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(64) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(64) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(64) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(64) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(64) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(64) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(64) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(64) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(64) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(64) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(64) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox65.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(65) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(65) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(65) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(65) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(65) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(65) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(65) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(65) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(65) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(65) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(65) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(65) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(65) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(65) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(65) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox66.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(66) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(66) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(66) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(66) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(66) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(66) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(66) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(66) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(66) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(66) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(66) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(66) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(66) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(66) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(66) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox67.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(67) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(67) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(67) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(67) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(67) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(67) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(67) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(67) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(67) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(67) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(67) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(67) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(67) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(67) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(67) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox68.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(68) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(68) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(68) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(68) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(68) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(68) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(68) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(68) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(68) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(68) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(68) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(68) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(68) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(68) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(68) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox69.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(69) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(69) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(69) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(69) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(69) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(69) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(69) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(69) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(69) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(69) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(69) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(69) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(69) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(69) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(69) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox70.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(70) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(70) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(70) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(70) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(70) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(70) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(70) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(70) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(70) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(70) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(70) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(70) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(70) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(70) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(70) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox71.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(71) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(71) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(71) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(71) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(71) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(71) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(71) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(71) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(71) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(71) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(71) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(71) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(71) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(71) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(71) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox72.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(72) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(72) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(72) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(72) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(72) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(72) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(72) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(72) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(72) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(72) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(72) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(72) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(72) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(72) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(72) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox73.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(73) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(73) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(73) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(73) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(73) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(73) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(73) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(73) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(73) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(73) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(73) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(73) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(73) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(73) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(73) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox74.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(74) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(74) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(74) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(74) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(74) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(74) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(74) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(74) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(74) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(74) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(74) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(74) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(74) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(74) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(74) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox75.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(75) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(75) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(75) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(75) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(75) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(75) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(75) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(75) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(75) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(75) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(75) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(75) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(75) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(75) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(75) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox76.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(76) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(76) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(76) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(76) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(76) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(76) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(76) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(76) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(76) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(76) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(76) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(76) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(76) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(76) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(76) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox77.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(77) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(77) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(77) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(77) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(77) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(77) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(77) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(77) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(77) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(77) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(77) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(77) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(77) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(77) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(77) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox78.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(78) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(78) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(78) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(78) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(78) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(78) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(78) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(78) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(78) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(78) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(78) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(78) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(78) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(78) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(78) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox79.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(79) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(79) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(79) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(79) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(79) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(79) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(79) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(79) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(79) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(79) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(79) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(79) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(79) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(79) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(79) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox80.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(80) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(80) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(80) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(80) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(80) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(80) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(80) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(80) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(80) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(80) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(80) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(80) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(80) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(80) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(80) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox81.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(81) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(81) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(81) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(81) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(81) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(81) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(81) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(81) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(81) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(81) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(81) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(81) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(81) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(81) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(81) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox82.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(82) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(82) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(82) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(82) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(82) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(82) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(82) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(82) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(82) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(82) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(82) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(82) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(82) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(82) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(82) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox83.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(83) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(83) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(83) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(83) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(83) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(83) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(83) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(83) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(83) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(83) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(83) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(83) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(83) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(83) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(83) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox84.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(84) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(84) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(84) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(84) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(84) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(84) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(84) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(84) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(84) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(84) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(84) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(84) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(84) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(84) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(84) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox85.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(85) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(85) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(85) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(85) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(85) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(85) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(85) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(85) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(85) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(85) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(85) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(85) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(85) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(85) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(85) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox86.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(86) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(86) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(86) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(86) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(86) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(86) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(86) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(86) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(86) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(86) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(86) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(86) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(86) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(86) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(86) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox87.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(87) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(87) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(87) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(87) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(87) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(87) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(87) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(87) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(87) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(87) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(87) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(87) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(87) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(87) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(87) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox88.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(88) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(88) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(88) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(88) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(88) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(88) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(88) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(88) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(88) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(88) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(88) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(88) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(88) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(88) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(88) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox89.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(89) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(89) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(89) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(89) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(89) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(89) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(89) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(89) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(89) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(89) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(89) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(89) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(89) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(89) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(89) = "None"
        End If
        Form1.travelPic.Image = Form1.PictureBox90.Image
        If (Form1.travelPic.Image Is Form1.whiteChePic.Image) Then
            Form1.picturebox(90) = "WhiteChe"
        ElseIf (Form1.travelPic.Image Is Form1.blackChePic.Image) Then
            Form1.picturebox(90) = "BlackChe"
        ElseIf (Form1.travelPic.Image Is Form1.whiteZuPic.Image) Then
            Form1.picturebox(90) = "WhiteZu"
        ElseIf (Form1.travelPic.Image Is Form1.blackBingPic.Image) Then
            Form1.picturebox(90) = "BlackBing"
        ElseIf (Form1.travelPic.Image Is Form1.whiteJiangPic.Image) Then
            Form1.picturebox(90) = "WhiteJiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackJiangPic.Image) Then
            Form1.picturebox(90) = "BlackJiang"
        ElseIf (Form1.travelPic.Image Is Form1.whitePaoPic.Image) Then
            Form1.picturebox(90) = "WhitePao"
        ElseIf (Form1.travelPic.Image Is Form1.blackPaoPic.Image) Then
            Form1.picturebox(90) = "BlackPao"
        ElseIf (Form1.travelPic.Image Is Form1.whiteMaPic.Image) Then
            Form1.picturebox(90) = "WhiteMa"
        ElseIf (Form1.travelPic.Image Is Form1.blackMaPic.Image) Then
            Form1.picturebox(90) = "BlackMa"
        ElseIf (Form1.travelPic.Image Is Form1.whiteXiangPic.Image) Then
            Form1.picturebox(90) = "WhiteXiang"
        ElseIf (Form1.travelPic.Image Is Form1.blackXiangPic.Image) Then
            Form1.picturebox(90) = "BlackXiang"
        ElseIf (Form1.travelPic.Image Is Form1.whiteShiPic.Image) Then
            Form1.picturebox(90) = "WhiteShi"
        ElseIf (Form1.travelPic.Image Is Form1.blackShiPic.Image) Then
            Form1.picturebox(90) = "BlackShi"
        ElseIf (Form1.travelPic.Image Is Form1.nonePic.Image) Then
            Form1.picturebox(90) = "None"
        End If
    End Sub
End Module
