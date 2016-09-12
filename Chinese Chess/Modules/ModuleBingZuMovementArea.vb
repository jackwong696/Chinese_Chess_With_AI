' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 15/11/2010
' Descripitons : Chinese Chess V1

Module ModuleBingZuMovementArea
    Public Sub CheckBlackBingMovementArea()
        If positionOne = "a4" Then
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
            ElseIf Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                Pic46None()
            End If
        ElseIf positionOne = "a5" Then
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
            ElseIf Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                Pic37None()
            End If
        ElseIf positionOne = "a6" Then
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
            ElseIf Form1.PictureBox28.Image Is Form1.nonePic.Image Then
                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                Pic28None()
            End If
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
            ElseIf Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                Pic38None()
            End If
        ElseIf positionOne = "a7" Then
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
            ElseIf Form1.PictureBox19.Image Is Form1.nonePic.Image Then
                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                Pic19None()
            End If
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
                    Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                ElseIf Form1.Purpose1 = "AIPieceProtected" Then
                    Pic19Attacked()
                End If
            ElseIf Form1.PictureBox29.Image Is Form1.nonePic.Image Then
                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                Pic29None()
            End If
        ElseIf positionOne = "a8" Then
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
            ElseIf Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                Pic10None()
            End If
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
            ElseIf Form1.PictureBox20.Image Is Form1.nonePic.Image Then
                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                Pic20None()
            End If
        ElseIf positionOne = "a9" Then
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
            ElseIf Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                Pic1None()
            End If

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
            ElseIf Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                Pic11None()
            End If
        ElseIf positionOne = "a10" Then
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
            ElseIf Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                Pic2None()
            End If
        ElseIf positionOne = "b6" Then
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
            ElseIf Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                Pic37None()
            End If
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
            ElseIf Form1.PictureBox29.Image Is Form1.nonePic.Image Then
                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                Pic29None()
            End If
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
            ElseIf Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                Pic39None()
            End If
        ElseIf positionOne = "b7" Then
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
            ElseIf Form1.PictureBox28.Image Is Form1.nonePic.Image Then
                Form1.PictureBox28.Image = Form1.movementAreaPic.Image
                Pic28None()
            End If
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
            ElseIf Form1.PictureBox20.Image Is Form1.nonePic.Image Then
                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                Pic20None()
            End If
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
            ElseIf Form1.PictureBox30.Image Is Form1.nonePic.Image Then
                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                Pic30None()
            End If
        ElseIf positionOne = "b8" Then
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
            ElseIf Form1.PictureBox19.Image Is Form1.nonePic.Image Then
                Form1.PictureBox19.Image = Form1.movementAreaPic.Image
                Pic19None()
            End If
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
            ElseIf Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                Pic11None()
            End If
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
            ElseIf Form1.PictureBox21.Image Is Form1.nonePic.Image Then
                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                Pic21None()
            End If
        ElseIf positionOne = "b9" Then
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
            ElseIf Form1.PictureBox10.Image Is Form1.nonePic.Image Then
                Form1.PictureBox10.Image = Form1.movementAreaPic.Image
                Pic10None()
            End If
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
            ElseIf Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                Pic2None()
            End If
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
            ElseIf Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                Pic12None()
            End If
        ElseIf positionOne = "b10" Then
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
            ElseIf Form1.PictureBox1.Image Is Form1.nonePic.Image Then
                Form1.PictureBox1.Image = Form1.movementAreaPic.Image
                Pic1None()
            End If
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
            ElseIf Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                Pic3None()
            End If
        ElseIf positionOne = "c4" Then
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
        ElseIf positionOne = "c5" Then
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
            ElseIf Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                Pic39None()
            End If
        ElseIf positionOne = "c6" Then
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
            ElseIf Form1.PictureBox38.Image Is Form1.nonePic.Image Then
                Form1.PictureBox38.Image = Form1.movementAreaPic.Image
                Pic38None()
            End If
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
            ElseIf Form1.PictureBox30.Image Is Form1.nonePic.Image Then
                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                Pic30None()
            End If
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
            ElseIf Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                Pic40None()
            End If
        ElseIf positionOne = "c7" Then
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
            ElseIf Form1.PictureBox29.Image Is Form1.nonePic.Image Then
                Form1.PictureBox29.Image = Form1.movementAreaPic.Image
                Pic29None()
            End If
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
            ElseIf Form1.PictureBox21.Image Is Form1.nonePic.Image Then
                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                Pic21None()
            End If
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
            ElseIf Form1.PictureBox31.Image Is Form1.nonePic.Image Then
                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                Pic31None()
            End If
        ElseIf positionOne = "c8" Then
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
            ElseIf Form1.PictureBox20.Image Is Form1.nonePic.Image Then
                Form1.PictureBox20.Image = Form1.movementAreaPic.Image
                Pic20None()
            End If
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
            ElseIf Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                Pic12None()
            End If
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
            ElseIf Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                Pic22None()
            End If
        ElseIf positionOne = "c9" Then
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
            ElseIf Form1.PictureBox11.Image Is Form1.nonePic.Image Then
                Form1.PictureBox11.Image = Form1.movementAreaPic.Image
                Pic11None()
            End If
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
            ElseIf Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                Pic3None()
            End If
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
            ElseIf Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                Pic13None()
            End If
        ElseIf positionOne = "c10" Then
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
            ElseIf Form1.PictureBox2.Image Is Form1.nonePic.Image Then
                Form1.PictureBox2.Image = Form1.movementAreaPic.Image
                Pic2None()
            End If
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
            ElseIf Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                Pic4None()
            End If
        ElseIf positionOne = "d6" Then
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
            ElseIf Form1.PictureBox39.Image Is Form1.nonePic.Image Then
                Form1.PictureBox39.Image = Form1.movementAreaPic.Image
                Pic39None()
            End If
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
            ElseIf Form1.PictureBox31.Image Is Form1.nonePic.Image Then
                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                Pic31None()
            End If
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
            ElseIf Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
            End If
        ElseIf positionOne = "d7" Then
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
            ElseIf Form1.PictureBox30.Image Is Form1.nonePic.Image Then
                Form1.PictureBox30.Image = Form1.movementAreaPic.Image
                Pic30None()
            End If
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
            ElseIf Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                Pic22None()
            End If
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
            ElseIf Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                Pic32None()
            End If
        ElseIf positionOne = "d8" Then
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
            ElseIf Form1.PictureBox21.Image Is Form1.nonePic.Image Then
                Form1.PictureBox21.Image = Form1.movementAreaPic.Image
                Pic21None()
            End If
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
            ElseIf Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                Pic13None()
            End If
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
            ElseIf Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
            End If
        ElseIf positionOne = "d9" Then
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
            ElseIf Form1.PictureBox12.Image Is Form1.nonePic.Image Then
                Form1.PictureBox12.Image = Form1.movementAreaPic.Image
                Pic12None()
            End If
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
            ElseIf Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                Pic4None()
            End If
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
            ElseIf Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
            End If
        ElseIf positionOne = "d10" Then
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
            ElseIf Form1.PictureBox3.Image Is Form1.nonePic.Image Then
                Form1.PictureBox3.Image = Form1.movementAreaPic.Image
                Pic3None()
            End If
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
                    Pic5None()
                End If
            ElseIf Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
            End If
        ElseIf positionOne = "e4" Then
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
            ElseIf Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
            End If
        ElseIf positionOne = "e5" Then
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
            ElseIf Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
            End If
        ElseIf positionOne = "e6" Then
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
            ElseIf Form1.PictureBox40.Image Is Form1.nonePic.Image Then
                Form1.PictureBox40.Image = Form1.movementAreaPic.Image
                Pic40None()
            End If
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
            ElseIf Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                Pic32None()
            End If
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
            ElseIf Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                Pic42None()
            End If
        ElseIf positionOne = "e7" Then
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
            ElseIf Form1.PictureBox31.Image Is Form1.nonePic.Image Then
                Form1.PictureBox31.Image = Form1.movementAreaPic.Image
                Pic31None()
            End If
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
            ElseIf Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
            End If
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
            ElseIf Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                Pic33None()
            End If
        ElseIf positionOne = "e8" Then
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
            ElseIf Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                Pic22None()
            End If
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
            ElseIf Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
            End If
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
            ElseIf Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
            End If
        ElseIf positionOne = "e9" Then
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
            ElseIf Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                Pic13None()
            End If
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
            ElseIf Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                Pic5None()
            End If
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
            ElseIf Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Pic15None()
            End If
        ElseIf positionOne = "e10" Then
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
            ElseIf Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                Pic4None()
            End If
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
            ElseIf Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                Pic6None()
            End If
        ElseIf positionOne = "f6" Then
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
            ElseIf Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
            End If
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
            ElseIf Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                Pic33None()
            End If
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
            ElseIf Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
            End If
        ElseIf positionOne = "f7" Then
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
            ElseIf Form1.PictureBox32.Image Is Form1.nonePic.Image Then
                Form1.PictureBox32.Image = Form1.movementAreaPic.Image
                Pic32None()
            End If
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
            ElseIf Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
            End If
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
            ElseIf Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
            End If
        ElseIf positionOne = "f8" Then
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
            ElseIf Form1.PictureBox23.Image Is Form1.nonePic.Image Then
                Form1.PictureBox23.Image = Form1.movementAreaPic.Image
                Pic23None()
            End If
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
            ElseIf Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Pic15None()
            End If
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
            ElseIf Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                Pic25None()
            End If
        ElseIf positionOne = "f9" Then
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
            ElseIf Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
            End If
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
            ElseIf Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                Pic6None()
            End If
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
            ElseIf Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                Pic16None()
            End If
        ElseIf positionOne = "f10" Then
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
            ElseIf Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                Pic5None()
            End If
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
            ElseIf Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                Pic7None()
            End If
        ElseIf positionOne = "g4" Then
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
        ElseIf positionOne = "g5" Then
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
            ElseIf Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
            End If
        ElseIf positionOne = "g6" Then
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
            ElseIf Form1.PictureBox42.Image Is Form1.nonePic.Image Then
                Form1.PictureBox42.Image = Form1.movementAreaPic.Image
                Pic42None()
            End If
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
            ElseIf Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
            End If
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
            ElseIf Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
            End If
        ElseIf positionOne = "g7" Then
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
            ElseIf Form1.PictureBox33.Image Is Form1.nonePic.Image Then
                Form1.PictureBox33.Image = Form1.movementAreaPic.Image
                Pic33None()
            End If
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
            ElseIf Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                Pic25None()
            End If
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
            ElseIf Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
            End If
        ElseIf positionOne = "g8" Then
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
            ElseIf Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
            End If
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
            ElseIf Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                Pic16None()
            End If
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
            ElseIf Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
            End If
        ElseIf positionOne = "g9" Then
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
            ElseIf Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Pic15None()
            End If
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
            ElseIf Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                Pic7None()
            End If
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
            ElseIf Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                Pic17None()
            End If
        ElseIf positionOne = "g10" Then
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
            ElseIf Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                Pic6None()
            End If
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
            ElseIf Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                Pic8None()
            End If
        ElseIf positionOne = "h6" Then
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
            ElseIf Form1.PictureBox43.Image Is Form1.nonePic.Image Then
                Form1.PictureBox43.Image = Form1.movementAreaPic.Image
                Pic43None()
            End If
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
            ElseIf Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
            End If
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
            ElseIf Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                Pic45None()
            End If
        ElseIf positionOne = "h7" Then
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
            ElseIf Form1.PictureBox34.Image Is Form1.nonePic.Image Then
                Form1.PictureBox34.Image = Form1.movementAreaPic.Image
                Pic34None()
            End If
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
            ElseIf Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
            End If
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
            ElseIf Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                Pic36None()
            End If
        ElseIf positionOne = "h8" Then
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
            ElseIf Form1.PictureBox25.Image Is Form1.nonePic.Image Then
                Form1.PictureBox25.Image = Form1.movementAreaPic.Image
                Pic25None()
            End If
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
            ElseIf Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                Pic17None()
            End If
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
            ElseIf Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                Pic27None()
            End If
        ElseIf positionOne = "h9" Then
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
            ElseIf Form1.PictureBox16.Image Is Form1.nonePic.Image Then
                Form1.PictureBox16.Image = Form1.movementAreaPic.Image
                Pic16None()
            End If
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
            ElseIf Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                Pic8None()
            End If
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
            ElseIf Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                Pic18None()
            End If
        ElseIf positionOne = "h10" Then
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
            ElseIf Form1.PictureBox7.Image Is Form1.nonePic.Image Then
                Form1.PictureBox7.Image = Form1.movementAreaPic.Image
                Pic7None()
            End If
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
            ElseIf Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                Pic9None()
            End If
        ElseIf positionOne = "i4" Then
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
            ElseIf Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                Pic54None()
            End If
        ElseIf positionOne = "i5" Then
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
            ElseIf Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                Pic45None()
            End If
        ElseIf positionOne = "i6" Then
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
            ElseIf Form1.PictureBox44.Image Is Form1.nonePic.Image Then
                Form1.PictureBox44.Image = Form1.movementAreaPic.Image
                Pic44None()
            End If
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
            ElseIf Form1.PictureBox36.Image Is Form1.nonePic.Image Then
                Form1.PictureBox36.Image = Form1.movementAreaPic.Image
                Pic36None()
            End If
        ElseIf positionOne = "i7" Then
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
            ElseIf Form1.PictureBox35.Image Is Form1.nonePic.Image Then
                Form1.PictureBox35.Image = Form1.movementAreaPic.Image
                Pic35None()
            End If
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
            ElseIf Form1.PictureBox27.Image Is Form1.nonePic.Image Then
                Form1.PictureBox27.Image = Form1.movementAreaPic.Image
                Pic27None()
            End If
        ElseIf positionOne = "i8" Then
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
            ElseIf Form1.PictureBox26.Image Is Form1.nonePic.Image Then
                Form1.PictureBox26.Image = Form1.movementAreaPic.Image
                Pic26None()
            End If
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
            ElseIf Form1.PictureBox18.Image Is Form1.nonePic.Image Then
                Form1.PictureBox18.Image = Form1.movementAreaPic.Image
                Pic18None()
            End If
        ElseIf positionOne = "i9" Then
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
            ElseIf Form1.PictureBox17.Image Is Form1.nonePic.Image Then
                Form1.PictureBox17.Image = Form1.movementAreaPic.Image
                Pic17None()
            End If
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
            ElseIf Form1.PictureBox9.Image Is Form1.nonePic.Image Then
                Form1.PictureBox9.Image = Form1.movementAreaPic.Image
                Pic9None()
            End If
        ElseIf positionOne = "i10" Then
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
            ElseIf Form1.PictureBox8.Image Is Form1.nonePic.Image Then
                Form1.PictureBox8.Image = Form1.movementAreaPic.Image
                Pic8None()
            End If
        End If
    End Sub
    Public Sub CheckWhiteZuMovementArea()
        If positionOne = "a7" Then
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
            ElseIf Form1.PictureBox37.Image Is Form1.nonePic.Image Then
                Form1.PictureBox37.Image = Form1.movementAreaPic.Image
                Pic37None()
            End If
        ElseIf positionOne = "a6" Then
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
            ElseIf Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                Pic46None()
            End If
        ElseIf positionOne = "a5" Then
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
            ElseIf Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                Pic47None()
            End If
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
            ElseIf Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                Pic55None()
            End If
        ElseIf positionOne = "a4" Then
            If (Form1.PictureBox56.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox56.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                Pic56None()
            End If
            If (Form1.PictureBox64.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox64.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                Pic64None()
            End If
        ElseIf positionOne = "a3" Then
            If (Form1.PictureBox65.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox65.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                Pic65None()
            End If
            If (Form1.PictureBox73.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox73.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox73.Image Is Form1.nonePic.Image Then
                Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                Pic73None()
            End If
        ElseIf positionOne = "a2" Then
            If (Form1.PictureBox74.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox74.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox74.Image Is Form1.nonePic.Image Then
                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                Pic74None()
            End If
            If (Form1.PictureBox82.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox82.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                Pic82None()
            End If
        ElseIf positionOne = "a1" Then
            If (Form1.PictureBox83.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox83.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                Pic83None()
            End If
        ElseIf positionOne = "b5" Then
            If (Form1.PictureBox46.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox46.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox46.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox46.Image Is Form1.nonePic.Image Then
                Form1.PictureBox46.Image = Form1.movementAreaPic.Image
                Pic46None()
            End If
            If (Form1.PictureBox48.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox48.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                Pic48None()
            End If
            If (Form1.PictureBox56.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox56.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox56.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                Pic56None()
            End If
        ElseIf positionOne = "b4" Then
            If (Form1.PictureBox55.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox55.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox55.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox55.Image Is Form1.nonePic.Image Then
                Form1.PictureBox55.Image = Form1.movementAreaPic.Image
                Pic55None()
            End If
            If (Form1.PictureBox57.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox57.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                Pic57None()
            End If
            If (Form1.PictureBox65.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox65.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox65.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                Pic65None()
            End If
        ElseIf positionOne = "b3" Then
            If (Form1.PictureBox64.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox64.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox64.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox64.Image Is Form1.nonePic.Image Then
                Form1.PictureBox64.Image = Form1.movementAreaPic.Image
                Pic64None()
            End If
            If (Form1.PictureBox66.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox66.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox66.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                Pic66None()
            End If
            If (Form1.PictureBox74.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox74.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox74.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox74.Image Is Form1.nonePic.Image Then
                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                Pic74None()
            End If
        ElseIf positionOne = "b2" Then
            If (Form1.PictureBox73.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox73.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox73.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox73.Image Is Form1.nonePic.Image Then
                Form1.PictureBox73.Image = Form1.movementAreaPic.Image
                Pic73None()
            End If
            If (Form1.PictureBox75.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox75.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox75.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                Pic75None()
            End If
            If (Form1.PictureBox83.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox83.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox83.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                Pic83None()
            End If
        ElseIf positionOne = "b1" Then
            If (Form1.PictureBox82.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox82.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox82.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox82.Image Is Form1.nonePic.Image Then
                Form1.PictureBox82.Image = Form1.movementAreaPic.Image
                Pic82None()
            End If
            If (Form1.PictureBox84.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox84.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox84.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                Pic84None()
            End If
        ElseIf positionOne = "c7" Then
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
        ElseIf positionOne = "c6" Then
            If (Form1.PictureBox48.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox48.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox48.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                Pic48None()
            End If
        ElseIf positionOne = "c5" Then
            If (Form1.PictureBox47.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox47.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox47.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox47.Image Is Form1.nonePic.Image Then
                Form1.PictureBox47.Image = Form1.movementAreaPic.Image
                Pic47None()
            End If
            If (Form1.PictureBox49.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox49.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox49.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox49.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox49.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                Pic49None()
            End If
            If (Form1.PictureBox57.Image Is Form1.blackBingPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackChePic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.blackJiangPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackMaPic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.blackPaoPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackShiPic.Image) Or _
            (Form1.PictureBox57.Image Is Form1.blackXiangPic.Image) Or (Form1.PictureBox57.Image Is Form1.nonePic.Image) Then
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
            ElseIf Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                Pic57None()
            End If
        ElseIf positionOne = "c4" Then
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
            ElseIf Form1.PictureBox56.Image Is Form1.nonePic.Image Then
                Form1.PictureBox56.Image = Form1.movementAreaPic.Image
                Pic56None()
            End If
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
            ElseIf Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                Pic58None()
            End If
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
            ElseIf Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                Pic66None()
            End If
        ElseIf positionOne = "c3" Then
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
            ElseIf Form1.PictureBox65.Image Is Form1.nonePic.Image Then
                Form1.PictureBox65.Image = Form1.movementAreaPic.Image
                Pic65None()
            End If
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
            ElseIf Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                Pic67None()
            End If
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
            ElseIf Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                Pic75None()
            End If
        ElseIf positionOne = "c2" Then
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
            ElseIf Form1.PictureBox74.Image Is Form1.nonePic.Image Then
                Form1.PictureBox74.Image = Form1.movementAreaPic.Image
                Pic74None()
            End If
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
            ElseIf Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                Pic76None()
            End If
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
            ElseIf Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                Pic84None()
            End If
        ElseIf positionOne = "c1" Then
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
            ElseIf Form1.PictureBox83.Image Is Form1.nonePic.Image Then
                Form1.PictureBox83.Image = Form1.movementAreaPic.Image
                Pic83None()
            End If
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
            ElseIf Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                Pic85None()
            End If
        ElseIf positionOne = "d5" Then
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
            ElseIf Form1.PictureBox48.Image Is Form1.nonePic.Image Then
                Form1.PictureBox48.Image = Form1.movementAreaPic.Image
                Pic48None()
            End If
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
            ElseIf Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
            End If
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
            ElseIf Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                Pic58None()
            End If
        ElseIf positionOne = "d4" Then
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
            ElseIf Form1.PictureBox57.Image Is Form1.nonePic.Image Then
                Form1.PictureBox57.Image = Form1.movementAreaPic.Image
                Pic57None()
            End If
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
            ElseIf Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                Pic59None()
            End If
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
            ElseIf Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                Pic67None()
            End If
        ElseIf positionOne = "d3" Then
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
            ElseIf Form1.PictureBox66.Image Is Form1.nonePic.Image Then
                Form1.PictureBox66.Image = Form1.movementAreaPic.Image
                Pic66None()
            End If
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
            ElseIf Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
            End If
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
            ElseIf Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                Pic76None()
            End If
        ElseIf positionOne = "d2" Then
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
            ElseIf Form1.PictureBox75.Image Is Form1.nonePic.Image Then
                Form1.PictureBox75.Image = Form1.movementAreaPic.Image
                Pic75None()
            End If
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
            ElseIf Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
            End If
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
            ElseIf Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                Pic85None()
            End If
        ElseIf positionOne = "d1" Then
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
            ElseIf Form1.PictureBox84.Image Is Form1.nonePic.Image Then
                Form1.PictureBox84.Image = Form1.movementAreaPic.Image
                Pic84None()
            End If
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
            ElseIf Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                Pic86None()
            End If
        ElseIf positionOne = "e7" Then
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
            ElseIf Form1.PictureBox41.Image Is Form1.nonePic.Image Then
                Form1.PictureBox41.Image = Form1.movementAreaPic.Image
                Pic41None()
            End If
        ElseIf positionOne = "e6" Then
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
            ElseIf Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
            End If
        ElseIf positionOne = "e5" Then
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
            ElseIf Form1.PictureBox49.Image Is Form1.nonePic.Image Then
                Form1.PictureBox49.Image = Form1.movementAreaPic.Image
                Pic49None()
            End If
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
            ElseIf Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                Pic51None()
            End If
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
            ElseIf Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                Pic59None()
            End If
        ElseIf positionOne = "e4" Then
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
            ElseIf Form1.PictureBox58.Image Is Form1.nonePic.Image Then
                Form1.PictureBox58.Image = Form1.movementAreaPic.Image
                Pic58None()
            End If
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
            ElseIf Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
            End If
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
            ElseIf Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
            End If
        ElseIf positionOne = "e3" Then
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
            ElseIf Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                Pic67None()
            End If
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
            ElseIf Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
            End If
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
            ElseIf Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
            End If
        ElseIf positionOne = "e2" Then
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
            ElseIf Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                Pic76None()
            End If
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
            ElseIf Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
            End If
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
            ElseIf Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                Pic86None()
            End If
        ElseIf positionOne = "e1" Then
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
            ElseIf Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                Pic85None()
            End If
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
            ElseIf Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                Pic87None()
            End If
        ElseIf positionOne = "f5" Then
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
            ElseIf Form1.PictureBox50.Image Is Form1.nonePic.Image Then
                Form1.PictureBox50.Image = Form1.movementAreaPic.Image
                Pic50None()
            End If
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
            ElseIf Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
            End If
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
            ElseIf Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
            End If
        ElseIf positionOne = "f4" Then
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
            ElseIf Form1.PictureBox59.Image Is Form1.nonePic.Image Then
                Form1.PictureBox59.Image = Form1.movementAreaPic.Image
                Pic59None()
            End If
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
            ElseIf Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
            End If
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
            ElseIf Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
            End If
        ElseIf positionOne = "f3" Then
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
            ElseIf Form1.PictureBox68.Image Is Form1.nonePic.Image Then
                Form1.PictureBox68.Image = Form1.movementAreaPic.Image
                Pic68None()
            End If
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
            ElseIf Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
            End If
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
            ElseIf Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
            End If
        ElseIf positionOne = "f2" Then
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
            ElseIf Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
            End If
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
            ElseIf Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                Pic79None()
            End If
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
            ElseIf Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                Pic87None()
            End If
        ElseIf positionOne = "f1" Then
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
            ElseIf Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                Pic86None()
            End If
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
            ElseIf Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                Pic88None()
            End If
        ElseIf positionOne = "g7" Then
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
        ElseIf positionOne = "g6" Then
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
            ElseIf Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
            End If
        ElseIf positionOne = "g5" Then
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
            ElseIf Form1.PictureBox51.Image Is Form1.nonePic.Image Then
                Form1.PictureBox51.Image = Form1.movementAreaPic.Image
                Pic51None()
            End If
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
            ElseIf Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
            End If
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
            ElseIf Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
            End If
        ElseIf positionOne = "g4" Then
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
            ElseIf Form1.PictureBox60.Image Is Form1.nonePic.Image Then
                Form1.PictureBox60.Image = Form1.movementAreaPic.Image
                Pic60None()
            End If
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
            ElseIf Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
            End If
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
            ElseIf Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
            End If
        ElseIf positionOne = "g3" Then
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
            ElseIf Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
            End If
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
            ElseIf Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
            End If
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
            ElseIf Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                Pic79None()
            End If
        ElseIf positionOne = "g2" Then
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
            ElseIf Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
            End If
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
            ElseIf Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                Pic80None()
            End If
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
            ElseIf Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                Pic88None()
            End If
        ElseIf positionOne = "g1" Then
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
            ElseIf Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                Pic87None()
            End If
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
            ElseIf Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                Pic89None()
            End If
        ElseIf positionOne = "h5" Then
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
            ElseIf Form1.PictureBox52.Image Is Form1.nonePic.Image Then
                Form1.PictureBox52.Image = Form1.movementAreaPic.Image
                Pic52None()
            End If
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
            ElseIf Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                Pic54None()
            End If
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
            ElseIf Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
            End If
        ElseIf positionOne = "h4" Then
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
            ElseIf Form1.PictureBox61.Image Is Form1.nonePic.Image Then
                Form1.PictureBox61.Image = Form1.movementAreaPic.Image
                Pic61None()
            End If
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
            ElseIf Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                Pic63None()
            End If
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
            ElseIf Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
            End If
        ElseIf positionOne = "h3" Then
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
            ElseIf Form1.PictureBox70.Image Is Form1.nonePic.Image Then
                Form1.PictureBox70.Image = Form1.movementAreaPic.Image
                Pic70None()
            End If
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
            ElseIf Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                Pic72None()
            End If
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
            ElseIf Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                Pic80None()
            End If
        ElseIf positionOne = "h2" Then
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
            ElseIf Form1.PictureBox79.Image Is Form1.nonePic.Image Then
                Form1.PictureBox79.Image = Form1.movementAreaPic.Image
                Pic79None()
            End If
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
            ElseIf Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                Pic81None()
            End If
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
            ElseIf Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                Pic89None()
            End If
        ElseIf positionOne = "h1" Then
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
            ElseIf Form1.PictureBox88.Image Is Form1.nonePic.Image Then
                Form1.PictureBox88.Image = Form1.movementAreaPic.Image
                Pic88None()
            End If
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
            ElseIf Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                Pic90None()
            End If
        ElseIf positionOne = "i7" Then
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
            ElseIf Form1.PictureBox45.Image Is Form1.nonePic.Image Then
                Form1.PictureBox45.Image = Form1.movementAreaPic.Image
                Pic45None()
            End If
        ElseIf positionOne = "i6" Then
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
            ElseIf Form1.PictureBox54.Image Is Form1.nonePic.Image Then
                Form1.PictureBox54.Image = Form1.movementAreaPic.Image
                Pic54None()
            End If
        ElseIf positionOne = "i5" Then
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
            ElseIf Form1.PictureBox53.Image Is Form1.nonePic.Image Then
                Form1.PictureBox53.Image = Form1.movementAreaPic.Image
                Pic53None()
            End If
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
            ElseIf Form1.PictureBox63.Image Is Form1.nonePic.Image Then
                Form1.PictureBox63.Image = Form1.movementAreaPic.Image
                Pic63None()
            End If
        ElseIf positionOne = "i4" Then
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
            ElseIf Form1.PictureBox62.Image Is Form1.nonePic.Image Then
                Form1.PictureBox62.Image = Form1.movementAreaPic.Image
                Pic62None()
            End If
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
            ElseIf Form1.PictureBox72.Image Is Form1.nonePic.Image Then
                Form1.PictureBox72.Image = Form1.movementAreaPic.Image
                Pic72None()
            End If
        ElseIf positionOne = "i3" Then
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
            ElseIf Form1.PictureBox71.Image Is Form1.nonePic.Image Then
                Form1.PictureBox71.Image = Form1.movementAreaPic.Image
                Pic71None()
            End If
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
            ElseIf Form1.PictureBox81.Image Is Form1.nonePic.Image Then
                Form1.PictureBox81.Image = Form1.movementAreaPic.Image
                Pic81None()
            End If
        ElseIf positionOne = "i2" Then
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
            ElseIf Form1.PictureBox80.Image Is Form1.nonePic.Image Then
                Form1.PictureBox80.Image = Form1.movementAreaPic.Image
                Pic80None()
            End If
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
            ElseIf Form1.PictureBox90.Image Is Form1.nonePic.Image Then
                Form1.PictureBox90.Image = Form1.movementAreaPic.Image
                Pic90None()
            End If
        ElseIf positionOne = "i1" Then
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
            ElseIf Form1.PictureBox89.Image Is Form1.nonePic.Image Then
                Form1.PictureBox89.Image = Form1.movementAreaPic.Image
                Pic89None()
            End If
        End If
    End Sub
End Module
