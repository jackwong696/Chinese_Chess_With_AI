' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 15/11/2010
' Descripitons : Chinese Chess V1

Module ModuleJiangMovementArea
    Public Sub CheckBlackJiangMovementArea()

        If positionOne = "d1" Then
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
            ElseIf Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                Pic76None()
            End If
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
            ElseIf Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                Pic86None()
            End If
        ElseIf positionOne = "d2" Then
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
            ElseIf Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                Pic67None()
            End If
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
            ElseIf Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
            End If
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
            ElseIf Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                Pic85None()
            End If
        ElseIf positionOne = "d3" Then
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
            ElseIf Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                Pic76None()
            End If
        ElseIf positionOne = "e1" Then
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
            ElseIf Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
            End If
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
            ElseIf Form1.PictureBox85.Image Is Form1.nonePic.Image Then
                Form1.PictureBox85.Image = Form1.movementAreaPic.Image
                Pic85None()
            End If
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
            ElseIf Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                Pic87None()
            End If
        ElseIf positionOne = "e2" Then
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
            ElseIf Form1.PictureBox76.Image Is Form1.nonePic.Image Then
                Form1.PictureBox76.Image = Form1.movementAreaPic.Image
                Pic76None()
            End If
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
            ElseIf Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
            End If
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
            ElseIf Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                Pic86None()
            End If
        ElseIf positionOne = "e3" Then
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
            ElseIf Form1.PictureBox67.Image Is Form1.nonePic.Image Then
                Form1.PictureBox67.Image = Form1.movementAreaPic.Image
                Pic67None()
            End If
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
            ElseIf Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
            End If
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
            ElseIf Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
            End If
        ElseIf positionOne = "f1" Then
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
            ElseIf Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
            End If
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
            ElseIf Form1.PictureBox86.Image Is Form1.nonePic.Image Then
                Form1.PictureBox86.Image = Form1.movementAreaPic.Image
                Pic86None()
            End If
        ElseIf positionOne = "f2" Then
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
            ElseIf Form1.PictureBox69.Image Is Form1.nonePic.Image Then
                Form1.PictureBox69.Image = Form1.movementAreaPic.Image
                Pic69None()
            End If
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
            ElseIf Form1.PictureBox77.Image Is Form1.nonePic.Image Then
                Form1.PictureBox77.Image = Form1.movementAreaPic.Image
                Pic77None()
            End If
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
            ElseIf Form1.PictureBox87.Image Is Form1.nonePic.Image Then
                Form1.PictureBox87.Image = Form1.movementAreaPic.Image
                Pic87None()
            End If
        ElseIf positionOne = "f3" Then
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
            ElseIf Form1.PictureBox78.Image Is Form1.nonePic.Image Then
                Form1.PictureBox78.Image = Form1.movementAreaPic.Image
                Pic78None()
            End If
        End If
    End Sub
    Public Sub CheckWhiteJiangMovementArea()
        If positionOne = "d10" Then
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
            ElseIf Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                Pic5None()
            End If
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
            ElseIf Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                Pic13None()
            End If
        ElseIf positionOne = "d9" Then
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
            ElseIf Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                Pic4None()
            End If
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
            ElseIf Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
            End If
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
            ElseIf Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                Pic22None()
            End If
        ElseIf positionOne = "d8" Then
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
            ElseIf Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                Pic13None()
            End If
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
        ElseIf positionOne = "e10" Then
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
            ElseIf Form1.PictureBox4.Image Is Form1.nonePic.Image Then
                Form1.PictureBox4.Image = Form1.movementAreaPic.Image
                Pic4None()
            End If
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
            ElseIf Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                Pic6None()
            End If
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
            ElseIf Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
            End If
        ElseIf positionOne = "e9" Then
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
            ElseIf Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                Pic5None()
            End If
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
            ElseIf Form1.PictureBox13.Image Is Form1.nonePic.Image Then
                Form1.PictureBox13.Image = Form1.movementAreaPic.Image
                Pic13None()
            End If
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
            ElseIf Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Pic15None()
            End If
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
        ElseIf positionOne = "e8" Then
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
            ElseIf Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
            End If
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
            ElseIf Form1.PictureBox22.Image Is Form1.nonePic.Image Then
                Form1.PictureBox22.Image = Form1.movementAreaPic.Image
                Pic22None()
            End If
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
            ElseIf Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
            End If
        ElseIf positionOne = "f10" Then
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
            ElseIf Form1.PictureBox5.Image Is Form1.nonePic.Image Then
                Form1.PictureBox5.Image = Form1.movementAreaPic.Image
                Pic5None()
            End If
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
            ElseIf Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Pic15None()
            End If
        ElseIf positionOne = "f9" Then
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
            ElseIf Form1.PictureBox6.Image Is Form1.nonePic.Image Then
                Form1.PictureBox6.Image = Form1.movementAreaPic.Image
                Pic6None()
            End If
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
            ElseIf Form1.PictureBox14.Image Is Form1.nonePic.Image Then
                Form1.PictureBox14.Image = Form1.movementAreaPic.Image
                Pic14None()
            End If
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
            ElseIf Form1.PictureBox24.Image Is Form1.nonePic.Image Then
                Form1.PictureBox24.Image = Form1.movementAreaPic.Image
                Pic24None()
            End If
        ElseIf positionOne = "f8" Then
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
            ElseIf Form1.PictureBox15.Image Is Form1.nonePic.Image Then
                Form1.PictureBox15.Image = Form1.movementAreaPic.Image
                Pic15None()
            End If
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
        End If
    End Sub
End Module
