'Project : Chinese Chess V1
'Programmer : Wong Wei Jian
'Date : 15/11/2010
'Descripitons : Chinese Chess V1

Module ModuleAIPieceProtected
    Public PieceScore(90) As Integer
    Public GotPiece(90), PictureboxColor(90) As String
    'Public Strings As String ' AttackOrProtect,
    Public By As Integer ' CurrPic,

    Public Sub CheckProtectedPiece()
        Length = 0
        Form1.Purpose1 = "AIPieceProtected"
        CheckPiece()
        SavePurpose = "saveBeforeShowMA"
        Form1.SavePieceLocation()
        positionOne = "a1"
        By = 82
        If (Form1.PictureBox82.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox82.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox82.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox82.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox82.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox82.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox82.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(82) = "White"
        ElseIf (Form1.PictureBox82.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox82.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox82.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox82.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox82.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox82.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(82) = "Black"
        ElseIf Form1.PictureBox82.Image Is Form1.nonePic.Image Then
            PictureboxColor(82) = "None"
        End If
        If (Form1.PictureBox82.Image Is Form1.nonePic.Image) Then
            GotPiece(82) = "False"
        Else
            GotPiece(82) = "True"
        End If
        If (Form1.PictureBox82.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(82) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox82.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(82) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox82.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(82) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox82.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(82) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox82.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(82) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox82.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(82) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox82.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(82) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox82.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(82) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox82.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(82) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox82.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(82) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox82.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(82) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox82.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(82) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox82.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(82) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox82.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(82) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()
        positionOne = "b1"
        By = 83
        If (Form1.PictureBox83.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox83.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox83.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox83.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox83.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox83.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox83.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(83) = "White"
        ElseIf (Form1.PictureBox83.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox83.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox83.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox83.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox83.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox83.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(83) = "Black"
        ElseIf Form1.PictureBox83.Image Is Form1.nonePic.Image Then
            PictureboxColor(83) = "None"
        End If
        If (Form1.PictureBox83.Image Is Form1.nonePic.Image) Then
            GotPiece(83) = "False"
        Else
            GotPiece(83) = "True"
        End If
        If (Form1.PictureBox83.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(83) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox83.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(83) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox83.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(83) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox83.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(83) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox83.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(83) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox83.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(83) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox83.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(83) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox83.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(83) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox83.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(83) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox83.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(83) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox83.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(83) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox83.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(83) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox83.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(83) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox83.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(83) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()
        positionOne = "c1"
        By = 84
        If (Form1.PictureBox84.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox84.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox84.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox84.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox84.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox84.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox84.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(84) = "White"
        ElseIf (Form1.PictureBox84.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox84.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox84.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox84.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox84.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox84.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(84) = "Black"
        ElseIf Form1.PictureBox84.Image Is Form1.nonePic.Image Then
            PictureboxColor(84) = "None"
        End If
        If (Form1.PictureBox84.Image Is Form1.nonePic.Image) Then
            GotPiece(84) = "False"
        Else
            GotPiece(84) = "True"
        End If
        If (Form1.PictureBox84.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(84) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox84.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(84) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox84.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(84) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox84.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(84) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox84.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(84) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox84.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(84) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox84.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(84) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox84.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(84) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox84.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(84) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox84.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(84) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox84.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(84) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox84.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(84) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox84.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(84) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox84.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(84) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()
        positionOne = "d1"
        By = 85
        If (Form1.PictureBox85.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox85.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox85.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox85.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox85.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox85.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox85.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(85) = "White"
        ElseIf (Form1.PictureBox85.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox85.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox85.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox85.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox85.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox85.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(85) = "Black"
        ElseIf Form1.PictureBox85.Image Is Form1.nonePic.Image Then
            PictureboxColor(85) = "None"
        End If
        If (Form1.PictureBox85.Image Is Form1.nonePic.Image) Then
            GotPiece(85) = "False"
        Else
            GotPiece(85) = "True"
        End If
        If (Form1.PictureBox85.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(85) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox85.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(85) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox85.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(85) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox85.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(85) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox85.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(85) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox85.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(85) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox85.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(85) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox85.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(85) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox85.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(85) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox85.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(85) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox85.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(85) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox85.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(85) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox85.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(85) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox85.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(85) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()
        positionOne = "e1"
        By = 86
        If (Form1.PictureBox86.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox86.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox86.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox86.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox86.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox86.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(86) = "White"
        ElseIf (Form1.PictureBox86.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox86.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox86.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox86.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox86.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox86.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(86) = "Black"
        ElseIf Form1.PictureBox86.Image Is Form1.nonePic.Image Then
            PictureboxColor(86) = "None"
        End If
        If (Form1.PictureBox86.Image Is Form1.nonePic.Image) Then
            GotPiece(86) = "False"
        Else
            GotPiece(86) = "True"
        End If
        If (Form1.PictureBox86.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(86) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox86.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(86) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox86.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(86) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox86.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(86) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox86.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(86) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox86.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(86) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox86.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(86) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox86.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(86) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox86.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(86) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox86.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(86) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox86.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(86) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox86.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(86) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox86.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(86) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox86.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(86) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()
        positionOne = "f1"
        By = 87
        If (Form1.PictureBox87.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox87.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox87.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox87.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox87.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox87.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(87) = "White"
        ElseIf (Form1.PictureBox87.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox87.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox87.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox87.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox87.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox87.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(87) = "Black"
        ElseIf Form1.PictureBox87.Image Is Form1.nonePic.Image Then
            PictureboxColor(87) = "None"
        End If
        If (Form1.PictureBox87.Image Is Form1.nonePic.Image) Then
            GotPiece(87) = "False"
        Else
            GotPiece(87) = "True"
        End If
        If (Form1.PictureBox87.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(87) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox87.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(87) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox87.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(87) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox87.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(87) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox87.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(87) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox87.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(87) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox87.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(87) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox87.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(87) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox87.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(87) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox87.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(87) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox87.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(87) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox87.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(87) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox87.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(87) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox87.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(87) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()
        positionOne = "g1"
        By = 88
        If (Form1.PictureBox88.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox88.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox88.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox88.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox88.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox88.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(88) = "White"
        ElseIf (Form1.PictureBox88.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox88.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox88.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox88.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox88.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox88.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(88) = "Black"
        ElseIf Form1.PictureBox88.Image Is Form1.nonePic.Image Then
            PictureboxColor(88) = "None"
        End If
        If (Form1.PictureBox88.Image Is Form1.nonePic.Image) Then
            GotPiece(88) = "False"
        Else
            GotPiece(88) = "True"
        End If
        If (Form1.PictureBox88.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(88) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox88.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(88) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox88.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(88) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox88.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(88) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox88.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(88) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox88.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(88) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox88.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(88) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox88.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(88) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox88.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(88) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox88.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(88) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox88.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(88) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox88.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(88) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox88.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(88) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox88.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(88) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()
        positionOne = "h1"
        By = 89
        If (Form1.PictureBox89.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox89.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox89.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox89.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox89.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox89.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(89) = "White"
        ElseIf (Form1.PictureBox89.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox89.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox89.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox89.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox89.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox89.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(89) = "Black"
        ElseIf Form1.PictureBox89.Image Is Form1.nonePic.Image Then
            PictureboxColor(89) = "None"
        End If
        If (Form1.PictureBox89.Image Is Form1.nonePic.Image) Then
            GotPiece(89) = "False"
        Else
            GotPiece(89) = "True"
        End If
        If (Form1.PictureBox89.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(89) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox89.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(89) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox89.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(89) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox89.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(89) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox89.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(89) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox89.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(89) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox89.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(89) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox89.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(89) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox89.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(89) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox89.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(89) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox89.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(89) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox89.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(89) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox89.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(89) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox89.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(89) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()
        positionOne = "i1"
        By = 90
        If (Form1.PictureBox90.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox90.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox90.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox90.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox90.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox90.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(90) = "White"
        ElseIf (Form1.PictureBox90.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox90.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox90.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox90.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox90.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox90.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(90) = "Black"
        ElseIf Form1.PictureBox90.Image Is Form1.nonePic.Image Then
            PictureboxColor(90) = "None"
        End If
        If (Form1.PictureBox90.Image Is Form1.nonePic.Image) Then
            GotPiece(90) = "False"
        Else
            GotPiece(90) = "True"
        End If
        If (Form1.PictureBox90.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(90) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox90.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(90) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox90.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(90) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox90.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(90) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox90.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(90) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox90.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(90) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox90.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(90) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox90.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(90) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox90.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(90) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox90.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(90) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox90.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(90) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox90.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(90) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox90.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(90) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox90.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(90) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()
        positionOne = "a2"
        By = 73
        If (Form1.PictureBox73.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox73.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox73.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox73.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox73.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox73.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox73.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(73) = "White"
        ElseIf (Form1.PictureBox73.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox73.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox73.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox73.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox73.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox73.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(73) = "Black"
        ElseIf Form1.PictureBox73.Image Is Form1.nonePic.Image Then
            PictureboxColor(73) = "None"
        End If
        If (Form1.PictureBox73.Image Is Form1.nonePic.Image) Then
            GotPiece(73) = "False"
        Else
            GotPiece(73) = "True"
        End If
        If (Form1.PictureBox73.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(73) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox73.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(73) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox73.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(73) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox73.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(73) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox73.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(73) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox73.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(73) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox73.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(73) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox73.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(73) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox73.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(73) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox73.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(73) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox73.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(73) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox73.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(73) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox73.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(73) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox73.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(73) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "b2"
        By = 74
        If (Form1.PictureBox74.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox74.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox74.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox74.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox74.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox74.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox74.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(74) = "White"
        ElseIf (Form1.PictureBox74.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox74.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox74.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox74.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox74.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox74.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(74) = "Black"
        ElseIf Form1.PictureBox74.Image Is Form1.nonePic.Image Then
            PictureboxColor(74) = "None"
        End If
        If (Form1.PictureBox74.Image Is Form1.nonePic.Image) Then
            GotPiece(74) = "False"
        Else
            GotPiece(74) = "True"
        End If
        If (Form1.PictureBox74.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(74) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox74.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(74) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox74.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(74) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox74.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(74) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox74.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(74) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox74.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(74) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox74.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(74) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox74.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(74) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox74.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(74) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox74.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(74) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox74.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(74) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox74.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(74) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox74.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(74) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox74.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(74) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "c2"
        By = 75
        If (Form1.PictureBox75.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox75.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox75.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox75.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox75.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox75.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox75.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(75) = "White"
        ElseIf (Form1.PictureBox75.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox75.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox75.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox75.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox75.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox75.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(75) = "Black"
        ElseIf Form1.PictureBox75.Image Is Form1.nonePic.Image Then
            PictureboxColor(75) = "None"
        End If
        If (Form1.PictureBox75.Image Is Form1.nonePic.Image) Then
            GotPiece(75) = "False"
        Else
            GotPiece(75) = "True"
        End If
        If (Form1.PictureBox75.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(75) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox75.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(75) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox75.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(75) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox75.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(75) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox75.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(75) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox75.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(75) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox75.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(75) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox75.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(75) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox75.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(75) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox75.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(75) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox75.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(75) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox75.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(75) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox75.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(75) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox75.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(75) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "d2"
        By = 76
        If (Form1.PictureBox76.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox76.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox76.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox76.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox76.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox76.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox76.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(76) = "White"
        ElseIf (Form1.PictureBox76.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox76.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox76.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox76.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox76.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox76.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(76) = "Black"
        ElseIf Form1.PictureBox76.Image Is Form1.nonePic.Image Then
            PictureboxColor(76) = "None"
        End If
        If (Form1.PictureBox76.Image Is Form1.nonePic.Image) Then
            GotPiece(76) = "False"
        Else
            GotPiece(76) = "True"
        End If
        If (Form1.PictureBox76.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(76) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox76.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(76) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox76.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(76) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox76.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(76) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox76.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(76) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox76.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(76) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox76.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(76) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox76.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(76) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox76.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(76) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox76.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(76) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox76.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(76) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox76.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(76) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox76.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(76) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox76.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(76) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "e2"
        By = 77
        If (Form1.PictureBox77.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox77.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox77.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox77.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox77.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox77.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(77) = "White"
        ElseIf (Form1.PictureBox77.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox77.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox77.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox77.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox77.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox77.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(77) = "Black"
        ElseIf Form1.PictureBox77.Image Is Form1.nonePic.Image Then
            PictureboxColor(77) = "None"
        End If
        If (Form1.PictureBox77.Image Is Form1.nonePic.Image) Then
            GotPiece(77) = "False"
        Else
            GotPiece(77) = "True"
        End If
        If (Form1.PictureBox77.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(77) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox77.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(77) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox77.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(77) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox77.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(77) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox77.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(77) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox77.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(77) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox77.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(77) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox77.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(77) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox77.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(77) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox77.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(77) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox77.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(77) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox77.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(77) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox77.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(77) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox77.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(77) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "f2"
        By = 78
        If (Form1.PictureBox78.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox78.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox78.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox78.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox78.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox78.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(78) = "White"
        ElseIf (Form1.PictureBox78.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox78.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox78.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox78.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox78.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox78.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(78) = "Black"
        ElseIf Form1.PictureBox78.Image Is Form1.nonePic.Image Then
            PictureboxColor(78) = "None"
        End If
        If (Form1.PictureBox78.Image Is Form1.nonePic.Image) Then
            GotPiece(78) = "False"
        Else
            GotPiece(78) = "True"
        End If
        If (Form1.PictureBox78.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(78) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox78.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(78) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox78.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(78) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox78.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(78) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox78.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(78) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox78.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(78) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox78.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(78) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox78.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(78) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox78.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(78) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox78.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(78) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox78.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(78) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox78.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(78) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox78.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(78) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox78.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(78) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "g2"
        By = 79
        If (Form1.PictureBox79.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox79.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox79.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox79.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox79.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox79.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(79) = "White"
        ElseIf (Form1.PictureBox79.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox79.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox79.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox79.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox79.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox79.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(79) = "Black"
        ElseIf Form1.PictureBox79.Image Is Form1.nonePic.Image Then
            PictureboxColor(79) = "None"
        End If
        If (Form1.PictureBox79.Image Is Form1.nonePic.Image) Then
            GotPiece(79) = "False"
        Else
            GotPiece(79) = "True"
        End If
        If (Form1.PictureBox79.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(79) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox79.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(79) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox79.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(79) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox79.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(79) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox79.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(79) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox79.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(79) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox79.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(79) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox79.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(79) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox79.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(79) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox79.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(79) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox79.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(79) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox79.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(79) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox79.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(79) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox79.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(79) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "h2"
        By = 80
        If (Form1.PictureBox80.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox80.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox80.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox80.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox80.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox80.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(80) = "White"
        ElseIf (Form1.PictureBox80.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox80.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox80.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox80.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox80.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox80.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(80) = "Black"
        ElseIf Form1.PictureBox80.Image Is Form1.nonePic.Image Then
            PictureboxColor(80) = "None"
        End If
        If (Form1.PictureBox80.Image Is Form1.nonePic.Image) Then
            GotPiece(80) = "False"
        Else
            GotPiece(80) = "True"
        End If
        If (Form1.PictureBox80.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(80) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox80.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(80) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox80.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(80) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox80.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(80) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox80.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(80) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox80.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(80) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox80.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(80) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox80.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(80) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox80.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(80) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox80.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(80) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox80.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(80) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox80.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(80) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox80.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(80) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox80.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(80) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "i2"
        By = 81
        If (Form1.PictureBox81.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox81.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox81.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox81.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox81.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox81.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(81) = "White"
        ElseIf (Form1.PictureBox81.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox81.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox81.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox81.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox81.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox81.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(81) = "Black"
        ElseIf Form1.PictureBox81.Image Is Form1.nonePic.Image Then
            PictureboxColor(81) = "None"
        End If
        If (Form1.PictureBox81.Image Is Form1.nonePic.Image) Then
            GotPiece(81) = "False"
        Else
            GotPiece(81) = "True"
        End If
        If (Form1.PictureBox81.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(81) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox81.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(81) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox81.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(81) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox81.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(81) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox81.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(81) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox81.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(81) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox81.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(81) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox81.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(81) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox81.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(81) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox81.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(81) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox81.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(81) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox81.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(81) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox81.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(81) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox81.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(81) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "a3"
        By = 64
        If (Form1.PictureBox64.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox64.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox64.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox64.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox64.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox64.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox64.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(64) = "White"
        ElseIf (Form1.PictureBox64.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox64.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox64.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox64.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox64.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox64.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(64) = "Black"
        ElseIf Form1.PictureBox64.Image Is Form1.nonePic.Image Then
            PictureboxColor(64) = "None"
        End If
        If (Form1.PictureBox64.Image Is Form1.nonePic.Image) Then
            GotPiece(64) = "False"
        Else
            GotPiece(64) = "True"
        End If
        If (Form1.PictureBox64.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(64) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox64.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(64) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox64.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(64) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox64.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(64) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox64.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(64) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox64.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(64) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox64.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(64) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox64.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(64) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox64.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(64) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox64.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(64) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox64.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(64) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox64.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(64) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox64.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(64) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox64.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(64) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "b3"
        By = 65
        If (Form1.PictureBox65.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox65.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox65.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox65.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox65.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox65.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox65.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(65) = "White"
        ElseIf (Form1.PictureBox65.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox65.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox65.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox65.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox65.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox65.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(65) = "Black"
        ElseIf Form1.PictureBox65.Image Is Form1.nonePic.Image Then
            PictureboxColor(65) = "None"
        End If
        If (Form1.PictureBox65.Image Is Form1.nonePic.Image) Then
            GotPiece(65) = "False"
        Else
            GotPiece(65) = "True"
        End If
        If (Form1.PictureBox65.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(65) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox65.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(65) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox65.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(65) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox65.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(65) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox65.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(65) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox65.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(65) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox65.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(65) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox65.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(65) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox65.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(65) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox65.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(65) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox65.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(65) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox65.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(65) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox65.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(65) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox65.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(65) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "c3"
        By = 66
        If (Form1.PictureBox66.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox66.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox66.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox66.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox66.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox66.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox66.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(66) = "White"
        ElseIf (Form1.PictureBox66.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox66.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox66.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox66.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox66.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox66.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(66) = "Black"
        ElseIf Form1.PictureBox66.Image Is Form1.nonePic.Image Then
            PictureboxColor(66) = "None"
        End If
        If (Form1.PictureBox66.Image Is Form1.nonePic.Image) Then
            GotPiece(66) = "False"
        Else
            GotPiece(66) = "True"
        End If
        If (Form1.PictureBox66.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(66) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox66.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(66) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox66.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(66) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox66.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(66) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox66.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(66) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox66.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(66) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox66.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(66) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox66.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(66) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox66.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(66) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox66.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(66) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox66.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(66) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox66.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(66) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox66.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(66) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox66.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(66) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "d3"
        By = 67
        If (Form1.PictureBox67.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox67.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox67.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox67.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox67.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox67.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox67.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(67) = "White"
        ElseIf (Form1.PictureBox67.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox67.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox67.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox67.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox67.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox67.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(67) = "Black"
        ElseIf Form1.PictureBox67.Image Is Form1.nonePic.Image Then
            PictureboxColor(67) = "None"
        End If
        If (Form1.PictureBox67.Image Is Form1.nonePic.Image) Then
            GotPiece(67) = "False"
        Else
            GotPiece(67) = "True"
        End If
        If (Form1.PictureBox67.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(67) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox67.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(67) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox67.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(67) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox67.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(67) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox67.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(67) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox67.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(67) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox67.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(67) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox67.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(67) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox67.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(67) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox67.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(67) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox67.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(67) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox67.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(67) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox67.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(67) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox67.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(67) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "e3"
        By = 68
        If (Form1.PictureBox68.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox68.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox68.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox68.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox68.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox68.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(68) = "White"
        ElseIf (Form1.PictureBox68.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox68.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox68.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox68.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox68.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox68.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(68) = "Black"
        ElseIf Form1.PictureBox68.Image Is Form1.nonePic.Image Then
            PictureboxColor(68) = "None"
        End If
        If (Form1.PictureBox68.Image Is Form1.nonePic.Image) Then
            GotPiece(68) = "False"
        Else
            GotPiece(68) = "True"
        End If
        If (Form1.PictureBox68.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(68) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox68.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(68) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox68.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(68) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox68.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(68) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox68.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(68) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox68.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(68) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox68.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(68) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox68.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(68) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox68.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(68) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox68.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(68) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox68.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(68) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox68.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(68) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox68.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(68) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox68.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(68) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "f3"
        By = 69
        If (Form1.PictureBox69.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox69.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox69.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox69.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox69.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox69.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(69) = "White"
        ElseIf (Form1.PictureBox69.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox69.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox69.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox69.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox69.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox69.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(69) = "Black"
        ElseIf Form1.PictureBox69.Image Is Form1.nonePic.Image Then
            PictureboxColor(69) = "None"
        End If
        If (Form1.PictureBox69.Image Is Form1.nonePic.Image) Then
            GotPiece(69) = "False"
        Else
            GotPiece(69) = "True"
        End If
        If (Form1.PictureBox69.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(69) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox69.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(69) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox69.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(69) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox69.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(69) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox69.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(69) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox69.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(69) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox69.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(69) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox69.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(69) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox69.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(69) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox69.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(69) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox69.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(69) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox69.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(69) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox69.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(69) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox69.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(69) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "g3"
        By = 70
        If (Form1.PictureBox70.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox70.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox70.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox70.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox70.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox70.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(70) = "White"
        ElseIf (Form1.PictureBox70.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox70.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox70.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox70.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox70.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox70.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(70) = "Black"
        ElseIf Form1.PictureBox70.Image Is Form1.nonePic.Image Then
            PictureboxColor(70) = "None"
        End If
        If (Form1.PictureBox70.Image Is Form1.nonePic.Image) Then
            GotPiece(70) = "False"
        Else
            GotPiece(70) = "True"
        End If
        If (Form1.PictureBox70.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(70) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox70.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(70) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox70.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(70) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox70.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(70) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox70.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(70) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox70.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(70) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox70.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(70) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox70.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(70) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox70.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(70) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox70.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(70) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox70.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(70) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox70.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(70) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox70.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(70) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox70.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(70) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "h3"
        By = 71
        If (Form1.PictureBox71.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox71.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox71.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox71.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox71.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox71.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(71) = "White"
        ElseIf (Form1.PictureBox71.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox71.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox71.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox71.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox71.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox71.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(71) = "Black"
        ElseIf Form1.PictureBox71.Image Is Form1.nonePic.Image Then
            PictureboxColor(71) = "None"
        End If
        If (Form1.PictureBox71.Image Is Form1.nonePic.Image) Then
            GotPiece(71) = "False"
        Else
            GotPiece(71) = "True"
        End If
        If (Form1.PictureBox71.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(71) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox71.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(71) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox71.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(71) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox71.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(71) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox71.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(71) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox71.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(71) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox71.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(71) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox71.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(71) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox71.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(71) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox71.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(71) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox71.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(71) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox71.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(71) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox71.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(71) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox71.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(71) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "i3"
        By = 72
        If (Form1.PictureBox72.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox72.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox72.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox72.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox72.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox72.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(72) = "White"
        ElseIf (Form1.PictureBox72.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox72.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox72.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox72.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox72.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox72.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(72) = "Black"
        ElseIf Form1.PictureBox72.Image Is Form1.nonePic.Image Then
            PictureboxColor(72) = "None"
        End If
        If (Form1.PictureBox72.Image Is Form1.nonePic.Image) Then
            GotPiece(72) = "False"
        Else
            GotPiece(72) = "True"
        End If
        If (Form1.PictureBox72.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(72) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox72.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(72) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox72.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(72) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox72.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(72) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox72.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(72) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox72.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(72) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox72.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(72) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox72.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(72) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox72.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(72) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox72.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(72) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox72.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(72) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox72.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(72) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox72.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(72) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox72.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(72) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "a4"
        By = 55
        If (Form1.PictureBox55.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox55.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox55.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox55.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox55.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox55.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox55.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(55) = "White"
        ElseIf (Form1.PictureBox55.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox55.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox55.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox55.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox55.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox55.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(55) = "Black"
        ElseIf Form1.PictureBox55.Image Is Form1.nonePic.Image Then
            PictureboxColor(55) = "None"
        End If
        If (Form1.PictureBox55.Image Is Form1.nonePic.Image) Then
            GotPiece(55) = "False"
        Else
            GotPiece(55) = "True"
        End If
        If (Form1.PictureBox55.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(55) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox55.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(55) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox55.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(55) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox55.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(55) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox55.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(55) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox55.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(55) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox55.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(55) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox55.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(55) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox55.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(55) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox55.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(55) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox55.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(55) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox55.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(55) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox55.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(55) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox55.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(55) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "b4"
        By = 56
        If (Form1.PictureBox56.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox56.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox56.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox56.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox56.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox56.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox56.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(56) = "White"
        ElseIf (Form1.PictureBox56.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox56.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox56.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox56.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox56.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox56.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(56) = "Black"
        ElseIf Form1.PictureBox56.Image Is Form1.nonePic.Image Then
            PictureboxColor(56) = "None"
        End If
        If (Form1.PictureBox56.Image Is Form1.nonePic.Image) Then
            GotPiece(56) = "False"
        Else
            GotPiece(56) = "True"
        End If
        If (Form1.PictureBox56.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(56) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox56.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(56) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox56.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(56) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox56.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(56) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox56.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(56) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox56.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(56) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox56.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(56) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox56.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(56) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox56.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(56) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox56.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(56) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox56.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(56) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox56.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(56) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox56.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(56) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox56.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(56) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "c4"
        By = 57
        If (Form1.PictureBox57.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox57.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox57.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox57.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox57.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox57.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox57.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(57) = "White"
        ElseIf (Form1.PictureBox57.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox57.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox57.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox57.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox57.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox57.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(57) = "Black"
        ElseIf Form1.PictureBox57.Image Is Form1.nonePic.Image Then
            PictureboxColor(57) = "None"
        End If
        If (Form1.PictureBox57.Image Is Form1.nonePic.Image) Then
            GotPiece(57) = "False"
        Else
            GotPiece(57) = "True"
        End If
        If (Form1.PictureBox57.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(57) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox57.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(57) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox57.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(57) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox57.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(57) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox57.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(57) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox57.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(57) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox57.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(57) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox57.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(57) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox57.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(57) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox57.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(57) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox57.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(57) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox57.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(57) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox57.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(57) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox57.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(57) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "d4"
        By = 58
        If (Form1.PictureBox58.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox58.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox58.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox58.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox58.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox58.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(58) = "White"
        ElseIf (Form1.PictureBox58.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox58.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox58.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox58.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox58.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox58.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(58) = "Black"
        ElseIf Form1.PictureBox58.Image Is Form1.nonePic.Image Then
            PictureboxColor(58) = "None"
        End If
        If (Form1.PictureBox58.Image Is Form1.nonePic.Image) Then
            GotPiece(58) = "False"
        Else
            GotPiece(58) = "True"
        End If
        If (Form1.PictureBox58.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(58) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox58.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(58) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox58.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(58) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox58.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(58) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox58.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(58) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox58.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(58) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox58.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(58) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox58.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(58) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox58.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(58) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox58.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(58) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox58.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(58) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox58.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(58) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox58.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(58) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox58.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(58) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "e4"
        By = 59
        If (Form1.PictureBox59.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox59.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox59.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox59.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox59.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox59.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(59) = "White"
        ElseIf (Form1.PictureBox59.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox59.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox59.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox59.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox59.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox59.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(59) = "Black"
        ElseIf Form1.PictureBox59.Image Is Form1.nonePic.Image Then
            PictureboxColor(59) = "None"
        End If
        If (Form1.PictureBox59.Image Is Form1.nonePic.Image) Then
            GotPiece(59) = "False"
        Else
            GotPiece(59) = "True"
        End If
        If (Form1.PictureBox59.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(59) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox59.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(59) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox59.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(59) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox59.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(59) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox59.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(59) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox59.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(59) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox59.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(59) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox59.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(59) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox59.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(59) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox59.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(59) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox59.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(59) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox59.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(59) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox59.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(59) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox59.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(59) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "f4"
        By = 60
        If (Form1.PictureBox60.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox60.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox60.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox60.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox60.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox60.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(60) = "White"
        ElseIf (Form1.PictureBox60.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox60.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox60.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox60.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox60.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox60.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(60) = "Black"
        ElseIf Form1.PictureBox60.Image Is Form1.nonePic.Image Then
            PictureboxColor(60) = "None"
        End If
        If (Form1.PictureBox60.Image Is Form1.nonePic.Image) Then
            GotPiece(60) = "False"
        Else
            GotPiece(60) = "True"
        End If
        If (Form1.PictureBox60.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(60) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox60.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(60) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox60.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(60) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox60.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(60) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox60.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(60) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox60.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(60) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox60.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(60) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox60.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(60) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox60.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(60) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox60.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(60) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox60.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(60) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox60.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(60) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox60.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(60) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox60.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(60) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "g4"
        By = 61
        If (Form1.PictureBox61.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox61.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox61.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox61.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox61.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox61.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(61) = "White"
        ElseIf (Form1.PictureBox61.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox61.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox61.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox61.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox61.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox61.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(61) = "Black"
        ElseIf Form1.PictureBox61.Image Is Form1.nonePic.Image Then
            PictureboxColor(61) = "None"
        End If
        If (Form1.PictureBox61.Image Is Form1.nonePic.Image) Then
            GotPiece(61) = "False"
        Else
            GotPiece(61) = "True"
        End If
        If (Form1.PictureBox61.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(61) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox61.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(61) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox61.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(61) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox61.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(61) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox61.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(61) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox61.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(61) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox61.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(61) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox61.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(61) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox61.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(61) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox61.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(61) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox61.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(61) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox61.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(61) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox61.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(61) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox61.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(61) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "h4"
        By = 62
        If (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(62) = "White"
        ElseIf (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(62) = "Black"
        ElseIf Form1.PictureBox62.Image Is Form1.nonePic.Image Then
            PictureboxColor(62) = "None"
        End If
        If (Form1.PictureBox62.Image Is Form1.nonePic.Image) Then
            GotPiece(62) = "False"
        Else
            GotPiece(62) = "True"
        End If
        If (Form1.PictureBox62.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(62) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox62.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(62) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox62.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(62) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox62.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(62) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox62.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(62) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox62.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(62) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox62.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(62) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox62.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(62) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox62.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(62) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox62.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(62) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox62.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(62) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox62.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(62) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox62.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(62) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox62.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(62) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "i4"
        By = 63
        If (Form1.PictureBox63.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox63.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox63.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox63.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox63.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox63.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(63) = "White"
        ElseIf (Form1.PictureBox63.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox63.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox63.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox63.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox63.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox63.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(63) = "Black"
        ElseIf Form1.PictureBox63.Image Is Form1.nonePic.Image Then
            PictureboxColor(63) = "None"
        End If
        If (Form1.PictureBox63.Image Is Form1.nonePic.Image) Then
            GotPiece(63) = "False"
        Else
            GotPiece(63) = "True"
        End If
        If (Form1.PictureBox63.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(63) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox63.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(63) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox63.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(63) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox63.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(63) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox63.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(63) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox63.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(63) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox63.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(63) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox63.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(63) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox63.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(63) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox63.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(63) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox63.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(63) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox63.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(63) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox63.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(63) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox63.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(63) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "a5"
        By = 46
        If (Form1.PictureBox46.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox46.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox46.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox46.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox46.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox46.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox46.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(46) = "White"
        ElseIf (Form1.PictureBox46.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox46.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox46.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox46.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox46.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox46.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(46) = "Black"
        ElseIf Form1.PictureBox46.Image Is Form1.nonePic.Image Then
            PictureboxColor(46) = "None"
        End If
        If (Form1.PictureBox46.Image Is Form1.nonePic.Image) Then
            GotPiece(46) = "False"
        Else
            GotPiece(46) = "True"
        End If
        If (Form1.PictureBox46.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(46) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox46.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(46) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox46.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(46) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox46.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(46) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox46.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(46) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox46.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(46) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox46.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(46) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox46.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(46) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox46.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(46) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox46.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(46) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox46.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(46) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox46.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(46) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox46.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(46) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox46.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(46) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "b5"
        By = 47
        If (Form1.PictureBox47.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox47.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox47.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox47.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox47.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox47.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox47.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(47) = "White"
        ElseIf (Form1.PictureBox47.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox47.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox47.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox47.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox47.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox47.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(47) = "Black"
        ElseIf Form1.PictureBox47.Image Is Form1.nonePic.Image Then
            PictureboxColor(47) = "None"
        End If
        If (Form1.PictureBox47.Image Is Form1.nonePic.Image) Then
            GotPiece(47) = "False"
        Else
            GotPiece(47) = "True"
        End If
        If (Form1.PictureBox47.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(47) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox47.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(47) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox47.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(47) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox47.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(47) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox47.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(47) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox47.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(47) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox47.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(47) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox47.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(47) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox47.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(47) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox47.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(47) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox47.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(47) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox47.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(47) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox47.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(47) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox47.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(47) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "c5"
        By = 48
        If (Form1.PictureBox48.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox48.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox48.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox48.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox48.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox48.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox48.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(48) = "White"
        ElseIf (Form1.PictureBox48.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox48.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox48.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox48.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox48.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox48.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(48) = "Black"
        ElseIf Form1.PictureBox48.Image Is Form1.nonePic.Image Then
            PictureboxColor(48) = "None"
        End If
        If (Form1.PictureBox48.Image Is Form1.nonePic.Image) Then
            GotPiece(48) = "False"
        Else
            GotPiece(48) = "True"
        End If
        If (Form1.PictureBox48.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(48) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox48.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(48) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox48.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(48) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox48.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(48) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox48.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(48) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox48.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(48) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox48.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(48) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox48.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(48) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox48.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(48) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox48.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(48) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox48.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(48) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox48.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(48) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox48.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(48) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox48.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(48) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "d5"
        By = 49
        If (Form1.PictureBox49.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox49.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox49.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox49.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox49.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox49.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(49) = "White"
        ElseIf (Form1.PictureBox49.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox49.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox49.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox49.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox49.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox49.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(49) = "Black"
        ElseIf Form1.PictureBox49.Image Is Form1.nonePic.Image Then
            PictureboxColor(49) = "None"
        End If
        If (Form1.PictureBox49.Image Is Form1.nonePic.Image) Then
            GotPiece(49) = "False"
        Else
            GotPiece(49) = "True"
        End If
        If (Form1.PictureBox49.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(49) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox49.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(49) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox49.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(49) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox49.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(49) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox49.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(49) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox49.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(49) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox49.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(49) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox49.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(49) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox49.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(49) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox49.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(49) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox49.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(49) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox49.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(49) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox49.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(49) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox49.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(49) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "e5"
        By = 50
        If (Form1.PictureBox50.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox50.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox50.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox50.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox50.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox50.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(50) = "White"
        ElseIf (Form1.PictureBox50.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox50.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox50.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox50.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox50.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox50.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(50) = "Black"
        ElseIf Form1.PictureBox50.Image Is Form1.nonePic.Image Then
            PictureboxColor(50) = "None"
        End If
        If (Form1.PictureBox50.Image Is Form1.nonePic.Image) Then
            GotPiece(50) = "False"
        Else
            GotPiece(50) = "True"
        End If
        If (Form1.PictureBox50.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(50) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox50.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(50) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox50.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(50) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox50.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(50) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox50.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(50) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox50.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(50) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox50.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(50) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox50.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(50) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox50.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(50) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox50.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(50) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox50.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(50) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox50.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(50) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox50.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(50) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox50.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(50) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "f5"
        By = 51
        If (Form1.PictureBox51.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox51.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox51.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox51.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox51.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox51.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(51) = "White"
        ElseIf (Form1.PictureBox51.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox51.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox51.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox51.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox51.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox51.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(51) = "Black"
        ElseIf Form1.PictureBox51.Image Is Form1.nonePic.Image Then
            PictureboxColor(51) = "None"
        End If
        If (Form1.PictureBox51.Image Is Form1.nonePic.Image) Then
            GotPiece(51) = "False"
        Else
            GotPiece(51) = "True"
        End If
        If (Form1.PictureBox51.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(51) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox51.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(51) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox51.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(51) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox51.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(51) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox51.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(51) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox51.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(51) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox51.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(51) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox51.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(51) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox51.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(51) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox51.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(51) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox51.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(51) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox51.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(51) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox51.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(51) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox51.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(51) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "g5"
        By = 52
        If (Form1.PictureBox52.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox52.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox52.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox52.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox52.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox52.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(52) = "White"
        ElseIf (Form1.PictureBox52.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox52.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox52.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox52.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox52.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox52.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(52) = "Black"
        ElseIf Form1.PictureBox52.Image Is Form1.nonePic.Image Then
            PictureboxColor(52) = "None"
        End If
        If (Form1.PictureBox52.Image Is Form1.nonePic.Image) Then
            GotPiece(52) = "False"
        Else
            GotPiece(52) = "True"
        End If
        If (Form1.PictureBox52.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(52) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox52.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(52) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox52.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(52) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox52.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(52) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox52.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(52) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox52.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(52) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox52.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(52) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox52.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(52) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox52.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(52) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox52.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(52) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox52.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(52) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox52.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(52) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox52.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(52) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox52.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(52) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "h5"
        By = 53
        If (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(53) = "White"
        ElseIf (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(53) = "Black"
        ElseIf Form1.PictureBox53.Image Is Form1.nonePic.Image Then
            PictureboxColor(53) = "None"
        End If
        If (Form1.PictureBox53.Image Is Form1.nonePic.Image) Then
            GotPiece(53) = "False"
        Else
            GotPiece(53) = "True"
        End If
        If (Form1.PictureBox53.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(53) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox53.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(53) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox53.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(53) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox53.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(53) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox53.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(53) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox53.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(53) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox53.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(53) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox53.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(53) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox53.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(53) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox53.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(53) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox53.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(53) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox53.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(53) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox53.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(53) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox53.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(53) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "i5"
        By = 54
        If (Form1.PictureBox54.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox54.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox54.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox54.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox54.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox54.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(54) = "White"
        ElseIf (Form1.PictureBox54.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox54.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox54.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox54.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox54.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox54.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(54) = "Black"
        ElseIf Form1.PictureBox54.Image Is Form1.nonePic.Image Then
            PictureboxColor(54) = "None"
        End If
        If (Form1.PictureBox54.Image Is Form1.nonePic.Image) Then
            GotPiece(54) = "False"
        Else
            GotPiece(54) = "True"
        End If
        If (Form1.PictureBox54.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(54) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox54.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(54) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox54.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(54) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox54.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(54) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox54.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(54) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox54.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(54) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox54.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(54) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox54.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(54) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox54.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(54) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox54.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(54) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox54.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(54) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox54.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(54) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox54.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(54) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox54.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(54) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "a6"
        By = 37
        If (Form1.PictureBox37.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox37.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox37.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox37.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox37.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox37.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox37.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(37) = "White"
        ElseIf (Form1.PictureBox37.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox37.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox37.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox37.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox37.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox37.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(37) = "Black"
        ElseIf Form1.PictureBox37.Image Is Form1.nonePic.Image Then
            PictureboxColor(37) = "None"
        End If
        If (Form1.PictureBox37.Image Is Form1.nonePic.Image) Then
            GotPiece(37) = "False"
        Else
            GotPiece(37) = "True"
        End If
        If (Form1.PictureBox37.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(37) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox37.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(37) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox37.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(37) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox37.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(37) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox37.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(37) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox37.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(37) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox37.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(37) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox37.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(37) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox37.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(37) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox37.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(37) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox37.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(37) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox37.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(37) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox37.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(37) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox37.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(37) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "b6"
        By = 38
        If (Form1.PictureBox38.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox38.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox38.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox38.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox38.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox38.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox38.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(38) = "White"
        ElseIf (Form1.PictureBox38.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox38.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox38.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox38.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox38.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox38.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(38) = "Black"
        ElseIf Form1.PictureBox38.Image Is Form1.nonePic.Image Then
            PictureboxColor(38) = "None"
        End If
        If (Form1.PictureBox38.Image Is Form1.nonePic.Image) Then
            GotPiece(38) = "False"
        Else
            GotPiece(38) = "True"
        End If
        If (Form1.PictureBox38.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(38) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox38.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(38) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox38.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(38) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox38.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(38) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox38.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(38) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox38.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(38) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox38.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(38) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox38.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(38) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox38.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(38) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox38.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(38) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox38.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(38) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox38.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(38) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox38.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(38) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox38.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(38) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "c6"
        By = 39
        If (Form1.PictureBox39.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox39.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox39.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox39.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox39.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox39.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox39.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(39) = "White"
        ElseIf (Form1.PictureBox39.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox39.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox39.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox39.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox39.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox39.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(39) = "Black"
        ElseIf Form1.PictureBox39.Image Is Form1.nonePic.Image Then
            PictureboxColor(39) = "None"
        End If
        If (Form1.PictureBox39.Image Is Form1.nonePic.Image) Then
            GotPiece(39) = "False"
        Else
            GotPiece(39) = "True"
        End If
        If (Form1.PictureBox39.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(39) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox39.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(39) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox39.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(39) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox39.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(39) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox39.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(39) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox39.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(39) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox39.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(39) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox39.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(39) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox39.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(39) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox39.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(39) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox39.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(39) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox39.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(39) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox39.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(39) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox39.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(39) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "d6"
        By = 40
        If (Form1.PictureBox40.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox40.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox40.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox40.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox40.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox40.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(40) = "White"
        ElseIf (Form1.PictureBox40.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox40.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox40.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox40.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox40.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox40.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(40) = "Black"
        ElseIf Form1.PictureBox40.Image Is Form1.nonePic.Image Then
            PictureboxColor(40) = "None"
        End If
        If (Form1.PictureBox40.Image Is Form1.nonePic.Image) Then
            GotPiece(40) = "False"
        Else
            GotPiece(40) = "True"
        End If
        If (Form1.PictureBox40.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(40) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox40.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(40) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox40.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(40) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox40.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(40) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox40.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(40) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox40.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(40) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox40.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(40) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox40.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(40) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox40.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(40) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox40.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(40) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox40.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(40) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox40.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(40) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox40.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(40) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox40.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(40) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "e6"
        By = 41
        If (Form1.PictureBox41.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox41.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox41.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox41.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox41.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox41.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(41) = "White"
        ElseIf (Form1.PictureBox41.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox41.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox41.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox41.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox41.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox41.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(41) = "Black"
        ElseIf Form1.PictureBox41.Image Is Form1.nonePic.Image Then
            PictureboxColor(41) = "None"
        End If
        If (Form1.PictureBox41.Image Is Form1.nonePic.Image) Then
            GotPiece(41) = "False"
        Else
            GotPiece(41) = "True"
        End If
        If (Form1.PictureBox41.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(41) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox41.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(41) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox41.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(41) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox41.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(41) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox41.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(41) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox41.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(41) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox41.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(41) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox41.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(41) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox41.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(41) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox41.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(41) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox41.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(41) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox41.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(41) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox41.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(41) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox41.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(41) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "f6"
        By = 42
        If (Form1.PictureBox42.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox42.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox42.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox42.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox42.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox42.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(42) = "White"
        ElseIf (Form1.PictureBox42.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox42.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox42.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox42.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox42.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox42.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(42) = "Black"
        ElseIf Form1.PictureBox42.Image Is Form1.nonePic.Image Then
            PictureboxColor(42) = "None"
        End If
        If (Form1.PictureBox42.Image Is Form1.nonePic.Image) Then
            GotPiece(42) = "False"
        Else
            GotPiece(42) = "True"
        End If
        If (Form1.PictureBox42.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(42) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox42.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(42) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox42.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(42) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox42.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(42) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox42.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(42) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox42.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(42) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox42.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(42) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox42.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(42) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox42.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(42) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox42.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(42) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox42.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(42) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox42.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(42) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox42.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(42) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox42.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(42) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "g6"
        By = 43
        If (Form1.PictureBox43.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox43.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox43.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox43.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox43.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox43.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(43) = "White"
        ElseIf (Form1.PictureBox43.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox43.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox43.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox43.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox43.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox43.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(43) = "Black"
        ElseIf Form1.PictureBox43.Image Is Form1.nonePic.Image Then
            PictureboxColor(43) = "None"
        End If
        If (Form1.PictureBox43.Image Is Form1.nonePic.Image) Then
            GotPiece(43) = "False"
        Else
            GotPiece(43) = "True"
        End If
        If (Form1.PictureBox43.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(43) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox43.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(43) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox43.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(43) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox43.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(43) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox43.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(43) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox43.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(43) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox43.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(43) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox43.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(43) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox43.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(43) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox43.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(43) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox43.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(43) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox43.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(43) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox43.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(43) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox43.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(43) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "h6"
        By = 44
        If (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(44) = "White"
        ElseIf (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(44) = "Black"
        ElseIf Form1.PictureBox44.Image Is Form1.nonePic.Image Then
            PictureboxColor(44) = "None"
        End If
        If (Form1.PictureBox44.Image Is Form1.nonePic.Image) Then
            GotPiece(44) = "False"
        Else
            GotPiece(44) = "True"
        End If
        If (Form1.PictureBox44.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(44) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox44.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(44) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox44.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(44) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox44.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(44) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox44.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(44) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox44.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(44) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox44.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(44) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox44.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(44) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox44.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(44) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox44.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(44) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox44.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(44) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox44.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(44) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox44.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(44) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox44.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(44) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "i6"
        By = 45
        If (Form1.PictureBox45.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox45.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox45.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox45.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox45.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox45.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(45) = "White"
        ElseIf (Form1.PictureBox45.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox45.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox45.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox45.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox45.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox45.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(45) = "Black"
        ElseIf Form1.PictureBox45.Image Is Form1.nonePic.Image Then
            PictureboxColor(45) = "None"
        End If
        If (Form1.PictureBox45.Image Is Form1.nonePic.Image) Then
            GotPiece(45) = "False"
        Else
            GotPiece(45) = "True"
        End If
        If (Form1.PictureBox45.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(45) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox45.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(45) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox45.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(45) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox45.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(45) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox45.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(45) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox45.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(45) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox45.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(45) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox45.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(45) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox45.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(45) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox45.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(45) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox45.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(45) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox45.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(45) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox45.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(45) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox45.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(45) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "a7"
        By = 28
        If (Form1.PictureBox28.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox28.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox28.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox28.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox28.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox28.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox28.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(28) = "White"
        ElseIf (Form1.PictureBox28.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox28.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox28.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox28.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox28.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox28.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(28) = "Black"
        ElseIf Form1.PictureBox28.Image Is Form1.nonePic.Image Then
            PictureboxColor(28) = "None"
        End If
        If (Form1.PictureBox28.Image Is Form1.nonePic.Image) Then
            GotPiece(28) = "False"
        Else
            GotPiece(28) = "True"
        End If
        If (Form1.PictureBox28.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(28) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox28.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(28) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox28.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(28) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox28.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(28) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox28.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(28) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox28.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(28) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox28.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(28) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox28.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(28) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox28.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(28) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox28.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(28) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox28.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(28) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox28.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(28) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox28.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(28) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox28.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(28) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "b7"
        By = 29
        If (Form1.PictureBox29.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox29.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox29.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox29.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox29.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox29.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox29.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(29) = "White"
        ElseIf (Form1.PictureBox29.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox29.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox29.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox29.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox29.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox29.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(29) = "Black"
        ElseIf Form1.PictureBox29.Image Is Form1.nonePic.Image Then
            PictureboxColor(29) = "None"
        End If
        If (Form1.PictureBox29.Image Is Form1.nonePic.Image) Then
            GotPiece(29) = "False"
        Else
            GotPiece(29) = "True"
        End If
        If (Form1.PictureBox29.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(29) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox29.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(29) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox29.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(29) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox29.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(29) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox29.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(29) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox29.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(29) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox29.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(29) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox29.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(29) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox29.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(29) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox29.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(29) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox29.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(29) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox29.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(29) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox29.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(29) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox29.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(29) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "c7"
        By = 30
        If (Form1.PictureBox30.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox30.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox30.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox30.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox30.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox30.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox30.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(30) = "White"
        ElseIf (Form1.PictureBox30.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox30.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox30.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox30.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox30.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox30.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(30) = "Black"
        ElseIf Form1.PictureBox30.Image Is Form1.nonePic.Image Then
            PictureboxColor(30) = "None"
        End If
        If (Form1.PictureBox30.Image Is Form1.nonePic.Image) Then
            GotPiece(30) = "False"
        Else
            GotPiece(30) = "True"
        End If
        If (Form1.PictureBox30.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(30) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox30.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(30) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox30.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(30) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox30.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(30) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox30.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(30) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox30.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(30) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox30.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(30) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox30.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(30) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox30.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(30) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox30.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(30) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox30.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(30) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox30.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(30) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox30.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(30) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox30.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(30) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "d7"
        By = 31
        If (Form1.PictureBox31.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox31.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox31.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox31.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox31.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox31.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(31) = "White"
        ElseIf (Form1.PictureBox31.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox31.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox31.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox31.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox31.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox31.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(31) = "Black"
        ElseIf Form1.PictureBox31.Image Is Form1.nonePic.Image Then
            PictureboxColor(31) = "None"
        End If
        If (Form1.PictureBox31.Image Is Form1.nonePic.Image) Then
            GotPiece(31) = "False"
        Else
            GotPiece(31) = "True"
        End If
        If (Form1.PictureBox31.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(31) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox31.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(31) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox31.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(31) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox31.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(31) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox31.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(31) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox31.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(31) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox31.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(31) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox31.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(31) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox31.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(31) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox31.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(31) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox31.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(31) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox31.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(31) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox31.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(31) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox31.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(31) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "e7"
        By = 32
        If (Form1.PictureBox32.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox32.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox32.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox32.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox32.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox32.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(32) = "White"
        ElseIf (Form1.PictureBox32.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox32.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox32.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox32.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox32.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox32.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(32) = "Black"
        ElseIf Form1.PictureBox32.Image Is Form1.nonePic.Image Then
            PictureboxColor(32) = "None"
        End If
        If (Form1.PictureBox32.Image Is Form1.nonePic.Image) Then
            GotPiece(32) = "False"
        Else
            GotPiece(32) = "True"
        End If
        If (Form1.PictureBox32.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(32) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox32.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(32) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox32.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(32) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox32.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(32) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox32.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(32) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox32.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(32) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox32.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(32) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox32.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(32) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox32.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(32) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox32.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(32) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox32.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(32) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox32.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(32) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox32.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(32) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox32.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(32) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "f7"
        By = 33
        If (Form1.PictureBox33.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox33.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox33.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox33.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox33.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox33.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(33) = "White"
        ElseIf (Form1.PictureBox33.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox33.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox33.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox33.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox33.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox33.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(33) = "Black"
        ElseIf Form1.PictureBox33.Image Is Form1.nonePic.Image Then
            PictureboxColor(33) = "None"
        End If
        If (Form1.PictureBox33.Image Is Form1.nonePic.Image) Then
            GotPiece(33) = "False"
        Else
            GotPiece(33) = "True"
        End If
        If (Form1.PictureBox33.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(33) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox33.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(33) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox33.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(33) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox33.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(33) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox33.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(33) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox33.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(33) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox33.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(33) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox33.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(33) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox33.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(33) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox33.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(33) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox33.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(33) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox33.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(33) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox33.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(33) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox33.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(33) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "g7"
        By = 34
        If (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(34) = "White"
        ElseIf (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(34) = "Black"
        ElseIf Form1.PictureBox34.Image Is Form1.nonePic.Image Then
            PictureboxColor(34) = "None"
        End If
        If (Form1.PictureBox34.Image Is Form1.nonePic.Image) Then
            GotPiece(34) = "False"
        Else
            GotPiece(34) = "True"
        End If
        If (Form1.PictureBox34.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(34) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox34.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(34) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox34.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(34) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox34.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(34) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox34.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(34) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox34.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(34) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox34.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(34) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox34.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(34) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox34.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(34) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox34.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(34) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox34.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(34) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox34.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(34) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox34.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(34) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox34.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(34) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "h7"
        By = 35
        If (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(35) = "White"
        ElseIf (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(35) = "Black"
        ElseIf Form1.PictureBox35.Image Is Form1.nonePic.Image Then
            PictureboxColor(35) = "None"
        End If
        If (Form1.PictureBox35.Image Is Form1.nonePic.Image) Then
            GotPiece(35) = "False"
        Else
            GotPiece(35) = "True"
        End If
        If (Form1.PictureBox35.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(35) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox35.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(35) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox35.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(35) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox35.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(35) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox35.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(35) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox35.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(35) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox35.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(35) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox35.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(35) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox35.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(35) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox35.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(35) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox35.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(35) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox35.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(35) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox35.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(35) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox35.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(35) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "i7"
        By = 36
        If (Form1.PictureBox36.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox36.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox36.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox36.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox36.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox36.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(36) = "White"
        ElseIf (Form1.PictureBox36.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox36.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox36.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox36.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox36.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox36.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(36) = "Black"
        ElseIf Form1.PictureBox36.Image Is Form1.nonePic.Image Then
            PictureboxColor(36) = "None"
        End If
        If (Form1.PictureBox36.Image Is Form1.nonePic.Image) Then
            GotPiece(36) = "False"
        Else
            GotPiece(36) = "True"
        End If
        If (Form1.PictureBox36.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(36) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox36.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(36) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox36.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(36) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox36.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(36) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox36.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(36) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox36.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(36) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox36.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(36) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox36.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(36) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox36.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(36) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox36.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(36) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox36.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(36) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox36.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(36) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox36.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(36) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox36.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(36) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "a8"
        By = 19
        If (Form1.PictureBox19.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox19.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox19.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox19.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox19.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox19.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox19.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(19) = "White"
        ElseIf (Form1.PictureBox19.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox19.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox19.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox19.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox19.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox19.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(19) = "Black"
        ElseIf Form1.PictureBox19.Image Is Form1.nonePic.Image Then
            PictureboxColor(19) = "None"
        End If
        If (Form1.PictureBox19.Image Is Form1.nonePic.Image) Then
            GotPiece(19) = "False"
        Else
            GotPiece(19) = "True"
        End If
        If (Form1.PictureBox19.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(19) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox19.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(19) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox19.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(19) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox19.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(19) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox19.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(19) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox19.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(19) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox19.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(19) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox19.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(19) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox19.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(19) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox19.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(19) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox19.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(19) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox19.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(19) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox19.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(19) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox19.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(19) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "b8"
        By = 20
        If (Form1.PictureBox20.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox20.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox20.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox20.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox20.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox20.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox20.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(20) = "White"
        ElseIf (Form1.PictureBox20.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox20.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox20.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox20.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox20.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox20.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(20) = "Black"
        ElseIf Form1.PictureBox20.Image Is Form1.nonePic.Image Then
            PictureboxColor(20) = "None"
        End If
        If (Form1.PictureBox20.Image Is Form1.nonePic.Image) Then
            GotPiece(20) = "False"
        Else
            GotPiece(20) = "True"
        End If
        If (Form1.PictureBox20.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(20) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox20.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(20) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox20.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(20) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox20.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(20) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox20.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(20) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox20.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(20) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox20.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(20) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox20.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(20) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox20.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(20) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox20.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(20) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox20.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(20) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox20.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(20) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox20.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(20) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox20.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(20) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "c8"
        By = 21
        If (Form1.PictureBox21.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox21.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox21.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox21.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox21.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox21.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox21.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(21) = "White"
        ElseIf (Form1.PictureBox21.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox21.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox21.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox21.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox21.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox21.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(21) = "Black"
        ElseIf Form1.PictureBox21.Image Is Form1.nonePic.Image Then
            PictureboxColor(21) = "None"
        End If
        If (Form1.PictureBox21.Image Is Form1.nonePic.Image) Then
            GotPiece(21) = "False"
        Else
            GotPiece(21) = "True"
        End If
        If (Form1.PictureBox21.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(21) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox21.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(21) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox21.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(21) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox21.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(21) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox21.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(21) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox21.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(21) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox21.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(21) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox21.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(21) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox21.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(21) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox21.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(21) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox21.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(21) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox21.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(21) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox21.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(21) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox21.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(21) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "d8"
        By = 22
        If (Form1.PictureBox22.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox22.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox22.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox22.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox22.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox22.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(22) = "White"
        ElseIf (Form1.PictureBox22.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox22.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox22.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox22.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox22.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox22.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(22) = "Black"
        ElseIf Form1.PictureBox22.Image Is Form1.nonePic.Image Then
            PictureboxColor(22) = "None"
        End If
        If (Form1.PictureBox22.Image Is Form1.nonePic.Image) Then
            GotPiece(22) = "False"
        Else
            GotPiece(22) = "True"
        End If
        If (Form1.PictureBox22.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(22) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox22.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(22) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox22.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(22) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox22.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(22) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox22.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(22) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox22.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(22) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox22.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(22) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox22.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(22) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox22.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(22) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox22.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(22) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox22.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(22) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox22.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(22) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox22.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(22) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox22.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(22) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "e8"
        By = 23
        If (Form1.PictureBox23.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox23.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox23.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox23.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox23.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox23.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(23) = "White"
        ElseIf (Form1.PictureBox23.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox23.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox23.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox23.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox23.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox23.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(23) = "Black"
        ElseIf Form1.PictureBox23.Image Is Form1.nonePic.Image Then
            PictureboxColor(23) = "None"
        End If
        If (Form1.PictureBox23.Image Is Form1.nonePic.Image) Then
            GotPiece(23) = "False"
        Else
            GotPiece(23) = "True"
        End If
        If (Form1.PictureBox23.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(23) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox23.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(23) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox23.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(23) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox23.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(23) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox23.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(23) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox23.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(23) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox23.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(23) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox23.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(23) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox23.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(23) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox23.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(23) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox23.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(23) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox23.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(23) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox23.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(23) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox23.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(23) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "f8"
        By = 24
        If (Form1.PictureBox24.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox24.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox24.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox24.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox24.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox24.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(24) = "White"
        ElseIf (Form1.PictureBox24.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox24.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox24.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox24.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox24.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox24.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(24) = "Black"
        ElseIf Form1.PictureBox24.Image Is Form1.nonePic.Image Then
            PictureboxColor(24) = "None"
        End If
        If (Form1.PictureBox24.Image Is Form1.nonePic.Image) Then
            GotPiece(24) = "False"
        Else
            GotPiece(24) = "True"
        End If
        If (Form1.PictureBox24.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(24) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox24.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(24) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox24.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(24) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox24.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(24) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox24.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(24) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox24.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(24) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox24.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(24) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox24.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(24) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox24.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(24) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox24.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(24) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox24.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(24) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox24.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(24) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox24.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(24) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox24.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(24) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "g8"
        By = 25
        If (Form1.PictureBox25.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox25.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox25.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox25.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox25.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox25.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(25) = "White"
        ElseIf (Form1.PictureBox25.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox25.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox25.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox25.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox25.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox25.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(25) = "Black"
        ElseIf Form1.PictureBox25.Image Is Form1.nonePic.Image Then
            PictureboxColor(25) = "None"
        End If
        If (Form1.PictureBox25.Image Is Form1.nonePic.Image) Then
            GotPiece(25) = "False"
        Else
            GotPiece(25) = "True"
        End If
        If (Form1.PictureBox25.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(25) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox25.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(25) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox25.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(25) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox25.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(25) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox25.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(25) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox25.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(25) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox25.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(25) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox25.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(25) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox25.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(25) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox25.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(25) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox25.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(25) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox25.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(25) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox25.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(25) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox25.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(25) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "h8"
        By = 26
        If (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(26) = "White"
        ElseIf (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(26) = "Black"
        ElseIf Form1.PictureBox26.Image Is Form1.nonePic.Image Then
            PictureboxColor(26) = "None"
        End If
        If (Form1.PictureBox26.Image Is Form1.nonePic.Image) Then
            GotPiece(26) = "False"
        Else
            GotPiece(26) = "True"
        End If
        If (Form1.PictureBox26.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(26) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox26.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(26) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox26.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(26) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox26.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(26) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox26.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(26) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox26.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(26) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox26.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(26) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox26.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(26) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox26.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(26) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox26.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(26) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox26.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(26) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox26.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(26) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox26.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(26) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox26.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(26) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "i8"
        By = 27
        If (Form1.PictureBox27.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox27.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox27.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox27.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox27.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox27.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(27) = "White"
        ElseIf (Form1.PictureBox27.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox27.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox27.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox27.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox27.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox27.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(27) = "Black"
        ElseIf Form1.PictureBox27.Image Is Form1.nonePic.Image Then
            PictureboxColor(27) = "None"
        End If
        If (Form1.PictureBox27.Image Is Form1.nonePic.Image) Then
            GotPiece(27) = "False"
        Else
            GotPiece(27) = "True"
        End If
        If (Form1.PictureBox27.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(27) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox27.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(27) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox27.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(27) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox27.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(27) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox27.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(27) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox27.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(27) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox27.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(27) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox27.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(27) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox27.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(27) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox27.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(27) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox27.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(27) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox27.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(27) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox27.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(27) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox27.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(27) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "a9"
        By = 10
        If (Form1.PictureBox10.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox10.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox10.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox10.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox10.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox10.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox10.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(10) = "White"
        ElseIf (Form1.PictureBox10.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox10.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox10.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox10.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox10.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox10.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(10) = "Black"
        ElseIf Form1.PictureBox10.Image Is Form1.nonePic.Image Then
            PictureboxColor(10) = "None"
        End If
        If (Form1.PictureBox10.Image Is Form1.nonePic.Image) Then
            GotPiece(10) = "False"
        Else
            GotPiece(10) = "True"
        End If
        If (Form1.PictureBox10.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(10) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox10.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(10) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox10.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(10) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox10.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(10) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox10.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(10) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox10.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(10) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox10.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(10) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox10.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(10) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox10.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(10) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox10.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(10) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox10.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(10) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox10.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(10) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox10.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(10) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox10.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(10) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "b9"
        By = 11
        If (Form1.PictureBox11.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox11.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox11.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox11.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox11.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox11.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox11.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(11) = "White"
        ElseIf (Form1.PictureBox11.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox11.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox11.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox11.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox11.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox11.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(11) = "Black"
        ElseIf Form1.PictureBox11.Image Is Form1.nonePic.Image Then
            PictureboxColor(11) = "None"
        End If
        If (Form1.PictureBox11.Image Is Form1.nonePic.Image) Then
            GotPiece(11) = "False"
        Else
            GotPiece(11) = "True"
        End If
        If (Form1.PictureBox11.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(11) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox11.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(11) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox11.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(11) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox11.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(11) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox11.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(11) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox11.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(11) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox11.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(11) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox11.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(11) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox11.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(11) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox11.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(11) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox11.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(11) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox11.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(11) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox11.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(11) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox11.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(11) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "c9"
        By = 12
        If (Form1.PictureBox12.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox12.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox12.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox12.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox12.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox12.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox12.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(12) = "White"
        ElseIf (Form1.PictureBox12.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox12.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox12.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox12.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox12.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox12.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(12) = "Black"
        ElseIf Form1.PictureBox12.Image Is Form1.nonePic.Image Then
            PictureboxColor(12) = "None"
        End If
        If (Form1.PictureBox12.Image Is Form1.nonePic.Image) Then
            GotPiece(12) = "False"
        Else
            GotPiece(12) = "True"
        End If
        If (Form1.PictureBox12.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(12) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox12.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(12) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox12.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(12) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox12.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(12) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox12.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(12) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox12.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(12) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox12.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(12) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox12.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(12) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox12.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(12) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox12.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(12) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox12.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(12) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox12.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(12) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox12.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(12) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox12.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(12) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "d9"
        By = 13
        If (Form1.PictureBox13.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox13.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox13.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox13.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox13.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox13.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(13) = "White"
        ElseIf (Form1.PictureBox13.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox13.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox13.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox13.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox13.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox13.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(13) = "Black"
        ElseIf Form1.PictureBox13.Image Is Form1.nonePic.Image Then
            PictureboxColor(13) = "None"
        End If
        If (Form1.PictureBox13.Image Is Form1.nonePic.Image) Then
            GotPiece(13) = "False"
        Else
            GotPiece(13) = "True"
        End If
        If (Form1.PictureBox13.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(13) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox13.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(13) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox13.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(13) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox13.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(13) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox13.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(13) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox13.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(13) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox13.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(13) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox13.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(13) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox13.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(13) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox13.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(13) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox13.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(13) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox13.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(13) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox13.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(13) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox13.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(13) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "e9"
        By = 14
        If (Form1.PictureBox14.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox14.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox14.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox14.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox14.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox14.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(14) = "White"
        ElseIf (Form1.PictureBox14.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox14.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox14.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox14.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox14.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox14.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(14) = "Black"
        ElseIf Form1.PictureBox14.Image Is Form1.nonePic.Image Then
            PictureboxColor(14) = "None"
        End If
        If (Form1.PictureBox14.Image Is Form1.nonePic.Image) Then
            GotPiece(14) = "False"
        Else
            GotPiece(14) = "True"
        End If
        If (Form1.PictureBox14.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(14) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox14.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(14) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox14.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(14) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox14.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(14) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox14.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(14) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox14.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(14) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox14.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(14) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox14.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(14) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox14.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(14) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox14.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(14) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox14.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(14) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox14.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(14) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox14.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(14) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox14.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(14) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "f9"
        By = 15
        If (Form1.PictureBox15.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox15.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox15.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox15.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox15.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox15.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(15) = "White"
        ElseIf (Form1.PictureBox15.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox15.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox15.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox15.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox15.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox15.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(15) = "Black"
        ElseIf Form1.PictureBox15.Image Is Form1.nonePic.Image Then
            PictureboxColor(15) = "None"
        End If
        If (Form1.PictureBox15.Image Is Form1.nonePic.Image) Then
            GotPiece(15) = "False"
        Else
            GotPiece(15) = "True"
        End If
        If (Form1.PictureBox15.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(15) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox15.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(15) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox15.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(15) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox15.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(15) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox15.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(15) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox15.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(15) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox15.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(15) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox15.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(15) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox15.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(15) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox15.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(15) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox15.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(15) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox15.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(15) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox15.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(15) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox15.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(15) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "g9"
        By = 16
        If (Form1.PictureBox16.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox16.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox16.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox16.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox16.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox16.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(16) = "White"
        ElseIf (Form1.PictureBox16.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox16.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox16.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox16.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox16.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox16.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(16) = "Black"
        ElseIf Form1.PictureBox16.Image Is Form1.nonePic.Image Then
            PictureboxColor(16) = "None"
        End If
        If (Form1.PictureBox16.Image Is Form1.nonePic.Image) Then
            GotPiece(16) = "False"
        Else
            GotPiece(16) = "True"
        End If
        If (Form1.PictureBox16.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(16) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox16.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(16) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox16.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(16) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox16.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(16) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox16.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(16) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox16.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(16) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox16.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(16) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox16.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(16) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox16.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(16) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox16.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(16) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox16.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(16) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox16.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(16) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox16.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(16) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox16.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(16) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "h9"
        By = 17
        If (Form1.PictureBox17.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox17.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox17.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox17.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox17.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox17.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(17) = "White"
        ElseIf (Form1.PictureBox17.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox17.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox17.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox17.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox17.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox17.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(17) = "Black"
        ElseIf Form1.PictureBox17.Image Is Form1.nonePic.Image Then
            PictureboxColor(17) = "None"
        End If
        If (Form1.PictureBox17.Image Is Form1.nonePic.Image) Then
            GotPiece(17) = "False"
        Else
            GotPiece(17) = "True"
        End If
        If (Form1.PictureBox17.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(17) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox17.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(17) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox17.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(17) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox17.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(17) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox17.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(17) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox17.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(17) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox17.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(17) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox17.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(17) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox17.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(17) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox17.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(17) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox17.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(17) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox17.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(17) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox17.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(17) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox17.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(17) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "i9"
        By = 18
        If (Form1.PictureBox18.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox18.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox18.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox18.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox18.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox18.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(18) = "White"
        ElseIf (Form1.PictureBox18.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox18.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox18.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox18.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox18.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox18.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(18) = "Black"
        ElseIf Form1.PictureBox18.Image Is Form1.nonePic.Image Then
            PictureboxColor(18) = "None"
        End If
        If (Form1.PictureBox18.Image Is Form1.nonePic.Image) Then
            GotPiece(18) = "False"
        Else
            GotPiece(18) = "True"
        End If
        If (Form1.PictureBox18.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(18) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox18.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(18) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox18.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(18) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox18.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(18) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox18.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(18) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox18.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(18) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox18.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(18) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox18.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(18) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox18.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(18) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox18.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(18) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox18.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(18) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox18.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(18) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox18.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(18) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox18.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(18) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "a10"
        By = 1
        If (Form1.PictureBox1.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox1.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox1.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox1.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox1.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox1.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox1.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(1) = "White"
        ElseIf (Form1.PictureBox1.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox1.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox1.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox1.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox1.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox1.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(1) = "Black"
        ElseIf Form1.PictureBox1.Image Is Form1.nonePic.Image Then
            PictureboxColor(1) = "None"
        End If
        If (Form1.PictureBox1.Image Is Form1.nonePic.Image) Then
            GotPiece(1) = "False"
        Else
            GotPiece(1) = "True"
        End If
        If (Form1.PictureBox1.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(1) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox1.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(1) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox1.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(1) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox1.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(1) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox1.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(1) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox1.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(1) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox1.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(1) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox1.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(1) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox1.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(1) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox1.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(1) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox1.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(1) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox1.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(1) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox1.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(1) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox1.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(1) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "b10"
        By = 2
        If (Form1.PictureBox2.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox2.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox2.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox2.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox2.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox2.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox2.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(2) = "White"
        ElseIf (Form1.PictureBox2.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox2.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox2.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox2.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox2.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox2.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(2) = "Black"
        ElseIf Form1.PictureBox2.Image Is Form1.nonePic.Image Then
            PictureboxColor(2) = "None"
        End If
        If (Form1.PictureBox2.Image Is Form1.nonePic.Image) Then
            GotPiece(2) = "False"
        Else
            GotPiece(2) = "True"
        End If
        If (Form1.PictureBox2.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(2) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox2.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(2) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox2.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(2) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox2.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(2) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox2.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(2) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox2.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(2) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox2.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(2) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox2.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(2) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox2.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(2) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox2.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(2) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox2.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(2) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox2.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(2) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox2.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(2) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox2.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(2) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "c10"
        By = 3
        If (Form1.PictureBox3.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox3.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox3.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox3.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox3.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox3.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox3.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(3) = "White"
        ElseIf (Form1.PictureBox3.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox3.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox3.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox3.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox3.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox3.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(3) = "Black"
        ElseIf Form1.PictureBox3.Image Is Form1.nonePic.Image Then
            PictureboxColor(3) = "None"
        End If
        If (Form1.PictureBox3.Image Is Form1.nonePic.Image) Then
            GotPiece(3) = "False"
        Else
            GotPiece(3) = "True"
        End If
        If (Form1.PictureBox3.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(3) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox3.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(3) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox3.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(3) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox3.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(3) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox3.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(3) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox3.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(3) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox3.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(3) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox3.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(3) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox3.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(3) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox3.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(3) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox3.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(3) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox3.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(3) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox3.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(3) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox3.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(3) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "d10"
        By = 4
        If (Form1.PictureBox4.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox4.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox4.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox4.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox4.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox4.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox4.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(4) = "White"
        ElseIf (Form1.PictureBox4.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox4.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox4.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox4.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox4.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox4.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(4) = "Black"
        ElseIf Form1.PictureBox4.Image Is Form1.nonePic.Image Then
            PictureboxColor(4) = "None"
        End If
        If (Form1.PictureBox4.Image Is Form1.nonePic.Image) Then
            GotPiece(4) = "False"
        Else
            GotPiece(4) = "True"
        End If
        If (Form1.PictureBox4.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(4) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox4.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(4) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox4.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(4) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox4.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(4) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox4.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(4) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox4.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(4) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox4.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(4) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox4.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(4) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox4.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(4) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox4.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(4) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox4.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(4) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox4.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(4) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox4.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(4) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox4.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(4) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "e10"
        By = 5
        If (Form1.PictureBox5.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox5.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox5.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox5.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox5.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox5.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(5) = "White"
        ElseIf (Form1.PictureBox5.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox5.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox5.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox5.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox5.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox5.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(5) = "Black"
        ElseIf Form1.PictureBox5.Image Is Form1.nonePic.Image Then
            PictureboxColor(5) = "None"
        End If
        If (Form1.PictureBox5.Image Is Form1.nonePic.Image) Then
            GotPiece(5) = "False"
        Else
            GotPiece(5) = "True"
        End If
        If (Form1.PictureBox5.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(5) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox5.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(5) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox5.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(5) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox5.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(5) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox5.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(5) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox5.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(5) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox5.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(5) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox5.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(5) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox5.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(5) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox5.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(5) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox5.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(5) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox5.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(5) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox5.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(5) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox5.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(5) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "f10"
        By = 6
        If (Form1.PictureBox6.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox6.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox6.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox6.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox6.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox6.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(6) = "White"
        ElseIf (Form1.PictureBox6.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox6.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox6.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox6.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox6.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox6.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(6) = "Black"
        ElseIf Form1.PictureBox6.Image Is Form1.nonePic.Image Then
            PictureboxColor(6) = "None"
        End If
        If (Form1.PictureBox6.Image Is Form1.nonePic.Image) Then
            GotPiece(6) = "False"
        Else
            GotPiece(6) = "True"
        End If
        If (Form1.PictureBox6.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(6) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox6.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(6) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox6.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(6) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox6.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(6) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox6.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(6) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox6.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(6) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox6.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(6) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox6.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(6) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox6.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(6) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox6.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(6) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox6.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(6) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox6.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(6) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox6.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(6) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox6.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(6) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "g10"
        By = 7
        If (Form1.PictureBox7.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox7.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox7.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox7.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox7.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox7.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(7) = "White"
        ElseIf (Form1.PictureBox7.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox7.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox7.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox7.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox7.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox7.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(7) = "Black"
        ElseIf Form1.PictureBox7.Image Is Form1.nonePic.Image Then
            PictureboxColor(7) = "None"
        End If
        If (Form1.PictureBox7.Image Is Form1.nonePic.Image) Then
            GotPiece(7) = "False"
        Else
            GotPiece(7) = "True"
        End If
        If (Form1.PictureBox7.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(7) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox7.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(7) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox7.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(7) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox7.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(7) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox7.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(7) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox7.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(7) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox7.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(7) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox7.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(7) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox7.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(7) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox7.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(7) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox7.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(7) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox7.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(7) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox7.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(7) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox7.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(7) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "h10"
        By = 8
        If (Form1.PictureBox8.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox8.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox8.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox8.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox8.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox8.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(8) = "White"
        ElseIf (Form1.PictureBox8.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox8.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox8.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox8.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox8.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox8.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(8) = "Black"
        ElseIf Form1.PictureBox8.Image Is Form1.nonePic.Image Then
            PictureboxColor(8) = "None"
        End If
        If (Form1.PictureBox8.Image Is Form1.nonePic.Image) Then
            GotPiece(8) = "False"
        Else
            GotPiece(8) = "True"
        End If
        If (Form1.PictureBox8.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(8) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox8.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(8) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox8.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(8) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox8.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(8) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox8.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(8) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox8.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(8) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox8.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(8) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox8.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(8) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox8.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(8) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox8.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(8) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox8.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(8) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox8.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(8) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox8.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(8) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox8.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(8) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()

        positionOne = "i10"
        By = 9
        If (Form1.PictureBox9.Image Is Form1.whiteChePic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteJiangPic.Image) _
        Or (Form1.PictureBox9.Image Is Form1.whiteMaPic.Image) Or (Form1.PictureBox9.Image Is Form1.whitePaoPic.Image) _
        Or (Form1.PictureBox9.Image Is Form1.whiteShiPic.Image) Or (Form1.PictureBox9.Image Is Form1.whiteXiangPic.Image) _
        Or (Form1.PictureBox9.Image Is Form1.whiteZuPic.Image) Then
            PictureboxColor(9) = "White"
        ElseIf (Form1.PictureBox9.Image Is Form1.blackChePic.Image) Or (Form1.PictureBox9.Image Is Form1.blackJiangPic.Image) _
        Or (Form1.PictureBox9.Image Is Form1.blackMaPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackPaoPic.Image) _
        Or (Form1.PictureBox9.Image Is Form1.blackShiPic.Image) Or (Form1.PictureBox9.Image Is Form1.blackXiangPic.Image) _
        Or (Form1.PictureBox9.Image Is Form1.blackBingPic.Image) Then
            PictureboxColor(9) = "Black"
        ElseIf Form1.PictureBox9.Image Is Form1.nonePic.Image Then
            PictureboxColor(9) = "None"
        End If
        If (Form1.PictureBox9.Image Is Form1.nonePic.Image) Then
            GotPiece(9) = "False"
        Else
            GotPiece(9) = "True"
        End If
        If (Form1.PictureBox9.Image Is Form1.whiteChePic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(9) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox9.Image Is Form1.blackChePic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(9) = 4
            Form1.CheckCheMovementArea()
        ElseIf (Form1.PictureBox9.Image Is Form1.whiteZuPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(9) = 2
            CheckWhiteZuMovementArea()
        ElseIf (Form1.PictureBox9.Image Is Form1.blackBingPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(9) = 2
            CheckBlackBingMovementArea()
        ElseIf (Form1.PictureBox9.Image Is Form1.whiteJiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(9) = 5
            CheckWhiteJiangMovementArea()
        ElseIf (Form1.PictureBox9.Image Is Form1.blackJiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(9) = 5
            CheckBlackJiangMovementArea()
        ElseIf (Form1.PictureBox9.Image Is Form1.whitePaoPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(9) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox9.Image Is Form1.blackPaoPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(9) = 3
            Form1.CheckPaoMovementArea()
        ElseIf (Form1.PictureBox9.Image Is Form1.whiteMaPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(9) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox9.Image Is Form1.blackMaPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(9) = 3
            Form1.CheckMaMovementArea()
        ElseIf (Form1.PictureBox9.Image Is Form1.whiteXiangPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(9) = 1
            CheckWhiteXiangMovementArea()
        ElseIf (Form1.PictureBox9.Image Is Form1.blackXiangPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(9) = 1
            CheckBlackXiangMovementArea()
        ElseIf (Form1.PictureBox9.Image Is Form1.whiteShiPic.Image) Then
            Form1.PieceColor = "White"
            PieceScore(9) = 1
            CheckWhiteShiMovementArea()
        ElseIf (Form1.PictureBox9.Image Is Form1.blackShiPic.Image) Then
            Form1.PieceColor = "Black"
            PieceScore(9) = 1
            CheckBlackShiMovementArea()
        End If
        RetrieveFrom = "saveBeforeShowMA"
        Form1.RetriveSavePieceLocation()
        RetrivePiece()
    End Sub
End Module
