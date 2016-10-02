' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 20/2/2009
' Descripitons : Chinese Chess V1

Public Class Form1
    Public playerTurn, Turn, Purpose1, PieceColor, previousPicColor, positionOneColor, positionTwoColor As String
    Public sameColorBool, positionTwoNonPicBool, Moved As Boolean
    Public PieceProtectedPic(90), PieceAttackedPic(90) As Boolean
    Public NoPieceProtected(90), NoPieceAttacked(90) As Integer
    Dim tableNumber, round As Integer
    Public picturebox(90) As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.chinese_chess_icon_small
        Turn = "White"
        LoadHeader()
        ClearPicturebox()
        ClearPic()
        Me.Table_NumberTextBox.Text = ""
        DisableRequireUC()
    End Sub

    Private Sub DisableRequireUC()
        With Me
            .UserNameTextBox.Enabled = False
            .ScoreTextBox.Enabled = False
            .MovementRecordTextBox.Enabled = False
            .playBtn.Enabled = False
            .undoBtn.Enabled = False
            .moveBtn.Enabled = False
            .Button3.Enabled = False
        End With
    End Sub

    Public Sub EnableRequireUC()
        With Me
            .UserNameTextBox.Enabled = True
            .ScoreTextBox.Enabled = True
            .MovementRecordTextBox.Enabled = True
            .playBtn.Enabled = True
            .undoBtn.Enabled = True
            .moveBtn.Enabled = True
            .Button3.Enabled = True
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AboutChineseChessV1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutChineseChessV1ToolStripMenuItem.Click
        ChineseChessAboutBox.ShowDialog()
    End Sub
    Private Sub PlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayToolStripMenuItem.Click, playBtn.Click
        Form2.ShowDialog()

        Me.playBtn.Enabled = False
        Me.undoBtn.Enabled = True
        Me.moveBtn.Enabled = True
        Me.fromHorAlTxt.Enabled = True
        Me.fromVerNumTxt.Enabled = True
        Me.toHorAlTxt.Enabled = True
        Me.toVerNumTxt.Enabled = True
        Me.fromHorCBox.Enabled = True
        Me.fromVerCBox.Enabled = True
        Me.toHorCBox.Enabled = True
        Me.toVerCBox.Enabled = True
    End Sub
    Private Sub exitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub moveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles moveBtn.Click

        Me.firstClickPic.Image = Me.nonePic.Image
        Me.secondClickPic.Image = Me.nonePic.Image
        positionOneColor = ""
        positionTwoColor = ""

        GetPositionOne()
        AssignCurrentPicWithPositionOne()
        If (Me.currentPic.Image Is Me.nonePic.Image) Then
            MsgBox("No Piece Selected", MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If
        If AIMovement = True Then
            GoTo Line3
        End If
        checkPositionOneColor()
        CheckPreviousPicColor()
        CheckTurns()

        ' do not erase
        'If OurAttackerLocation <> "" And EnemyAttackerLocation <> "" Then
        '    positionOne = OurAttackerLocation
        '    positionTwo = EnemyAttackerLocation
        '    MovePiece()
        'End If

        'If ((playerTurn = "1st") And (Turn = "Black")) Or ((playerTurn = "2nd") And (Turn = "White")) Then
        '    MsgBox("Not your turn", MsgBoxStyle.OkOnly)
        '    ' AI Movement ' here 
        '    If Turn = "Black" Then 
        '        positionOne = "a1" 
        '        positionTwo = "a3" 
        '        MovePiece() 
        '        Me.previousPic.Image = Me.blackChePic.Image
        '    ElseIf Turn = "White" Then
        '        positionOne = "a10"
        '        positionTwo = "a8"
        '        moveAllowBool = True
        '        MovePiece()
        '        Me.previousPic.Image = Me.whiteChePic.Image
        '    End If
        '    Exit Sub
        'End If

        If (Turn = "White" And positionOneColor = "Black") Or (Turn = "Black" And positionOneColor = "White") Then
            MsgBox("Invalid Turn", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

Line3:  GetPositionTwo()
        GetPositionOneTwo()
        If AIMovement = True Then
            GoTo Line2
        End If
        checkPic()
        ChangePreviousPicToInterPic()
        ChangeCurrentPicToPreviousPic()
        AssignCurrentPicWithPositionTwo()
        If (Me.currentPic.Image Is Me.nonePic.Image) Then
            GoTo Line1
        Else
            checkPositionTwoColor()
            checkColor()
            If sameColorBool = True Then
                moveAllowBool = False
                Dim strings As String
                strings = "moveBool = " & moveBool & ", blockBool = " & blockBool & ", moveAllowBool = " &
            moveAllowBool & ControlChars.NewLine & ", PositionOne = " & positionOne & ", PositionTwo = " &
            positionTwo & ", PositionOneTwo = " & positionOneTwo & ", sameColor = " & sameColorBool & ", positiononecolor = " & positionOneColor & ", positiontwocolor = " & positionTwoColor
                MsgBox(strings, MsgBoxStyle.OkOnly, "")
                GoTo Line2
            Else
Line1:          CheckAllowBool()
Line2:          MovePiece()
            End If
        End If

        ViewData()
        CheckMate()
    End Sub

    Private Sub AIMove()
        AIMovement = True
        ' Check player moved piece.
        GetPositionTwo()
        GetPositionOneTwo()
        ' Add some piece checking, possible move, attack pieces, defence pieces. (Find the best move).
        ' Set the piece movement. 
        ' move the piece. 
        MovePiece()
        ViewData()
        CheckMate()
        CheckTurns()
        AIMovement = False
    End Sub

    Private Sub InsertMovementRecord()

        Dim query As String = ""
        If Me.Turn = "White" Then
            query = "INSERT INTO Record (TableID, MovementNumber, [White Movement], [Black Movement]) VALUES ( " & tableNumber & ", " & round & ", '" & positionOneTwo & "','') "
        ElseIf Me.Turn = "Black" Then
            query = "UPDATE Record SET [Black Movement] = '" & positionOneTwo & "' WHERE MovementNumber = " & round & " AND TableID = " & tableNumber
            round = round + 1
        End If
        libDBCon.ExecPostSQL(query, "")

    End Sub

    Private Sub CheckTurns()
        If AIMovement = False Then
            If previousPicColor = "White" Then
                Turn = "Black"
            ElseIf (previousPicColor = "Black") Or (Me.previousPic.Image Is Me.nonePic.Image) Then
                Turn = "White"
            End If
        Else
            If Turn = "White" Then
                Turn = "Black"
            Else
                Turn = "White"
            End If
        End If
    End Sub
    Private Sub CheckPreviousPicColor()
        If (Me.previousPic.Image Is Me.whiteChePic.Image) Or
        (Me.previousPic.Image Is Me.whiteMaPic.Image) Or
        (Me.previousPic.Image Is Me.whiteXiangPic.Image) Or
        (Me.previousPic.Image Is Me.whiteShiPic.Image) Or
        (Me.previousPic.Image Is Me.whiteJiangPic.Image) Or
        (Me.previousPic.Image Is Me.whitePaoPic.Image) Or
        (Me.previousPic.Image Is Me.whiteZuPic.Image) Then
            previousPicColor = "White"
        ElseIf (Me.previousPic.Image Is Me.blackChePic.Image) Or
        (Me.previousPic.Image Is Me.blackMaPic.Image) Or
        (Me.previousPic.Image Is Me.blackXiangPic.Image) Or
        (Me.previousPic.Image Is Me.blackShiPic.Image) Or
        (Me.previousPic.Image Is Me.blackJiangPic.Image) Or
        (Me.previousPic.Image Is Me.blackPaoPic.Image) Or
        (Me.previousPic.Image Is Me.blackBingPic.Image) Then
            previousPicColor = "Black"
        End If
    End Sub

    Private Sub undoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles undoBtn.Click
        positionInter = positionOne
        positionOne = positionTwo
        positionTwo = positionInter
        Me.interPic.Image = Me.currentPic.Image
        Me.currentPic.Image = Me.previousPic.Image
        Me.currentPic.Image = Me.interPic.Image
        CheckA()
        CheckB()
        CheckC()
        CheckD()
        CheckE()
        CheckF()
        CheckG()
        CheckH()
        CheckI()
    End Sub

    Private Sub LoadHeader()
        ListView1.Columns.Add("White Movement", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Black Movement", 100, HorizontalAlignment.Center)
    End Sub

    Private Sub ViewData()
        Dim sqlQuery As String
        Dim sqlWhere As String

        sqlQuery = ""
        sqlWhere = ""

        Dim itemAdd As ListViewItem

        If AIMovement = True Then
            Exit Sub
        End If

        sqlQuery = " SELECT [White Movement], [Black Movement] FROM Record "
        sqlWhere = " WHERE TableID = " & tableNumber

        Me.ListView1.Items.Clear()

        libDBCon.ExecGetSQL(sqlQuery, sqlWhere)
        For Each dtr As DataRow In libDBCon.GetGridInfo.Rows
            itemAdd = Me.ListView1.Items.Add(dtr.Item(libDBCon.GetGridInfo.Columns("White Movement").Ordinal).ToString())
            itemAdd.SubItems.Add(dtr.Item(libDBCon.GetGridInfo.Columns("Black Movement").Ordinal).ToString())
        Next

    End Sub

    Private Sub GetPositionOne()
        positionOne = Me.fromHorAlTxt.Text & Me.fromVerNumTxt.Text
    End Sub
    Private Sub GetPositionTwo()
        positionTwo = Me.toHorAlTxt.Text & Me.toVerNumTxt.Text
    End Sub
    Private Sub GetPositionOneTwo()
        positionOneTwo = positionOne + positionTwo
    End Sub
    Private Sub AssignCurrentPicWithPositionOne()
        If positionOne = "a1" Then
            Me.currentPic.Image = Me.PictureBox82.Image
        ElseIf positionOne = "b1" Then
            Me.currentPic.Image = Me.PictureBox83.Image
        ElseIf positionOne = "c1" Then
            Me.currentPic.Image = Me.PictureBox84.Image
        ElseIf positionOne = "d1" Then
            Me.currentPic.Image = Me.PictureBox85.Image
        ElseIf positionOne = "e1" Then
            Me.currentPic.Image = Me.PictureBox86.Image
        ElseIf positionOne = "f1" Then
            Me.currentPic.Image = Me.PictureBox87.Image
        ElseIf positionOne = "g1" Then
            Me.currentPic.Image = Me.PictureBox88.Image
        ElseIf positionOne = "h1" Then
            Me.currentPic.Image = Me.PictureBox89.Image
        ElseIf positionOne = "i1" Then
            Me.currentPic.Image = Me.PictureBox90.Image
        ElseIf positionOne = "a2" Then
            Me.currentPic.Image = Me.PictureBox73.Image
        ElseIf positionOne = "b2" Then
            Me.currentPic.Image = Me.PictureBox74.Image
        ElseIf positionOne = "c2" Then
            Me.currentPic.Image = Me.PictureBox75.Image
        ElseIf positionOne = "d2" Then
            Me.currentPic.Image = Me.PictureBox76.Image
        ElseIf positionOne = "e2" Then
            Me.currentPic.Image = Me.PictureBox77.Image
        ElseIf positionOne = "f2" Then
            Me.currentPic.Image = Me.PictureBox78.Image
        ElseIf positionOne = "g2" Then
            Me.currentPic.Image = Me.PictureBox79.Image
        ElseIf positionOne = "h2" Then
            Me.currentPic.Image = Me.PictureBox80.Image
        ElseIf positionOne = "i2" Then
            Me.currentPic.Image = Me.PictureBox81.Image
        ElseIf positionOne = "a3" Then
            Me.currentPic.Image = Me.PictureBox64.Image
        ElseIf positionOne = "b3" Then
            Me.currentPic.Image = Me.PictureBox65.Image
        ElseIf positionOne = "c3" Then
            Me.currentPic.Image = Me.PictureBox66.Image
        ElseIf positionOne = "d3" Then
            Me.currentPic.Image = Me.PictureBox67.Image
        ElseIf positionOne = "e3" Then
            Me.currentPic.Image = Me.PictureBox68.Image
        ElseIf positionOne = "f3" Then
            Me.currentPic.Image = Me.PictureBox69.Image
        ElseIf positionOne = "g3" Then
            Me.currentPic.Image = Me.PictureBox70.Image
        ElseIf positionOne = "h3" Then
            Me.currentPic.Image = Me.PictureBox71.Image
        ElseIf positionOne = "i3" Then
            Me.currentPic.Image = Me.PictureBox72.Image
        ElseIf positionOne = "a4" Then
            Me.currentPic.Image = Me.PictureBox55.Image
        ElseIf positionOne = "b4" Then
            Me.currentPic.Image = Me.PictureBox56.Image
        ElseIf positionOne = "c4" Then
            Me.currentPic.Image = Me.PictureBox57.Image
        ElseIf positionOne = "d4" Then
            Me.currentPic.Image = Me.PictureBox58.Image
        ElseIf positionOne = "e4" Then
            Me.currentPic.Image = Me.PictureBox59.Image
        ElseIf positionOne = "f4" Then
            Me.currentPic.Image = Me.PictureBox60.Image
        ElseIf positionOne = "g4" Then
            Me.currentPic.Image = Me.PictureBox61.Image
        ElseIf positionOne = "h4" Then
            Me.currentPic.Image = Me.PictureBox62.Image
        ElseIf positionOne = "i4" Then
            Me.currentPic.Image = Me.PictureBox63.Image
        ElseIf positionOne = "a5" Then
            Me.currentPic.Image = Me.PictureBox46.Image
        ElseIf positionOne = "b5" Then
            Me.currentPic.Image = Me.PictureBox47.Image
        ElseIf positionOne = "c5" Then
            Me.currentPic.Image = Me.PictureBox48.Image
        ElseIf positionOne = "d5" Then
            Me.currentPic.Image = Me.PictureBox49.Image
        ElseIf positionOne = "e5" Then
            Me.currentPic.Image = Me.PictureBox50.Image
        ElseIf positionOne = "f5" Then
            Me.currentPic.Image = Me.PictureBox51.Image
        ElseIf positionOne = "g5" Then
            Me.currentPic.Image = Me.PictureBox52.Image
        ElseIf positionOne = "h5" Then
            Me.currentPic.Image = Me.PictureBox53.Image
        ElseIf positionOne = "i5" Then
            Me.currentPic.Image = Me.PictureBox54.Image
        ElseIf positionOne = "a6" Then
            Me.currentPic.Image = Me.PictureBox37.Image
        ElseIf positionOne = "b6" Then
            Me.currentPic.Image = Me.PictureBox38.Image
        ElseIf positionOne = "c6" Then
            Me.currentPic.Image = Me.PictureBox39.Image
        ElseIf positionOne = "d6" Then
            Me.currentPic.Image = Me.PictureBox40.Image
        ElseIf positionOne = "e6" Then
            Me.currentPic.Image = Me.PictureBox41.Image
        ElseIf positionOne = "f6" Then
            Me.currentPic.Image = Me.PictureBox42.Image
        ElseIf positionOne = "g6" Then
            Me.currentPic.Image = Me.PictureBox43.Image
        ElseIf positionOne = "h6" Then
            Me.currentPic.Image = Me.PictureBox44.Image
        ElseIf positionOne = "i6" Then
            Me.currentPic.Image = Me.PictureBox45.Image
        ElseIf positionOne = "a7" Then
            Me.currentPic.Image = Me.PictureBox28.Image
        ElseIf positionOne = "b7" Then
            Me.currentPic.Image = Me.PictureBox29.Image
        ElseIf positionOne = "c7" Then
            Me.currentPic.Image = Me.PictureBox30.Image
        ElseIf positionOne = "d7" Then
            Me.currentPic.Image = Me.PictureBox31.Image
        ElseIf positionOne = "e7" Then
            Me.currentPic.Image = Me.PictureBox32.Image
        ElseIf positionOne = "f7" Then
            Me.currentPic.Image = Me.PictureBox33.Image
        ElseIf positionOne = "g7" Then
            Me.currentPic.Image = Me.PictureBox34.Image
        ElseIf positionOne = "h7" Then
            Me.currentPic.Image = Me.PictureBox35.Image
        ElseIf positionOne = "i7" Then
            Me.currentPic.Image = Me.PictureBox36.Image
        ElseIf positionOne = "a8" Then
            Me.currentPic.Image = Me.PictureBox19.Image
        ElseIf positionOne = "b8" Then
            Me.currentPic.Image = Me.PictureBox20.Image
        ElseIf positionOne = "c8" Then
            Me.currentPic.Image = Me.PictureBox21.Image
        ElseIf positionOne = "d8" Then
            Me.currentPic.Image = Me.PictureBox22.Image
        ElseIf positionOne = "e8" Then
            Me.currentPic.Image = Me.PictureBox23.Image
        ElseIf positionOne = "f8" Then
            Me.currentPic.Image = Me.PictureBox24.Image
        ElseIf positionOne = "g8" Then
            Me.currentPic.Image = Me.PictureBox25.Image
        ElseIf positionOne = "h8" Then
            Me.currentPic.Image = Me.PictureBox26.Image
        ElseIf positionOne = "i8" Then
            Me.currentPic.Image = Me.PictureBox27.Image
        ElseIf positionOne = "a9" Then
            Me.currentPic.Image = Me.PictureBox10.Image
        ElseIf positionOne = "b9" Then
            Me.currentPic.Image = Me.PictureBox11.Image
        ElseIf positionOne = "c9" Then
            Me.currentPic.Image = Me.PictureBox12.Image
        ElseIf positionOne = "d9" Then
            Me.currentPic.Image = Me.PictureBox13.Image
        ElseIf positionOne = "e9" Then
            Me.currentPic.Image = Me.PictureBox14.Image
        ElseIf positionOne = "f9" Then
            Me.currentPic.Image = Me.PictureBox15.Image
        ElseIf positionOne = "g9" Then
            Me.currentPic.Image = Me.PictureBox16.Image
        ElseIf positionOne = "h9" Then
            Me.currentPic.Image = Me.PictureBox17.Image
        ElseIf positionOne = "i9" Then
            Me.currentPic.Image = Me.PictureBox18.Image
        ElseIf positionOne = "a10" Then
            Me.currentPic.Image = Me.PictureBox1.Image
        ElseIf positionOne = "b10" Then
            Me.currentPic.Image = Me.PictureBox2.Image
        ElseIf positionOne = "c10" Then
            Me.currentPic.Image = Me.PictureBox3.Image
        ElseIf positionOne = "d10" Then
            Me.currentPic.Image = Me.PictureBox4.Image
        ElseIf positionOne = "e10" Then
            Me.currentPic.Image = Me.PictureBox5.Image
        ElseIf positionOne = "f10" Then
            Me.currentPic.Image = Me.PictureBox6.Image
        ElseIf positionOne = "g10" Then
            Me.currentPic.Image = Me.PictureBox7.Image
        ElseIf positionOne = "h10" Then
            Me.currentPic.Image = Me.PictureBox8.Image
        ElseIf positionOne = "i10" Then
            Me.currentPic.Image = Me.PictureBox9.Image

        End If
    End Sub
    Private Sub AssignCurrentPicWithPositionTwo()
        If positionTwo = "a1" Then
            Me.currentPic.Image = Me.PictureBox82.Image
        ElseIf positionTwo = "b1" Then
            Me.currentPic.Image = Me.PictureBox83.Image
        ElseIf positionTwo = "c1" Then
            Me.currentPic.Image = Me.PictureBox84.Image
        ElseIf positionTwo = "d1" Then
            Me.currentPic.Image = Me.PictureBox85.Image
        ElseIf positionTwo = "e1" Then
            Me.currentPic.Image = Me.PictureBox86.Image
        ElseIf positionTwo = "f1" Then
            Me.currentPic.Image = Me.PictureBox87.Image
        ElseIf positionTwo = "g1" Then
            Me.currentPic.Image = Me.PictureBox88.Image
        ElseIf positionTwo = "h1" Then
            Me.currentPic.Image = Me.PictureBox89.Image
        ElseIf positionTwo = "i1" Then
            Me.currentPic.Image = Me.PictureBox90.Image
        ElseIf positionTwo = "a2" Then
            Me.currentPic.Image = Me.PictureBox73.Image
        ElseIf positionTwo = "b2" Then
            Me.currentPic.Image = Me.PictureBox74.Image
        ElseIf positionTwo = "c2" Then
            Me.currentPic.Image = Me.PictureBox75.Image
        ElseIf positionTwo = "d2" Then
            Me.currentPic.Image = Me.PictureBox76.Image
        ElseIf positionTwo = "e2" Then
            Me.currentPic.Image = Me.PictureBox77.Image
        ElseIf positionTwo = "f2" Then
            Me.currentPic.Image = Me.PictureBox78.Image
        ElseIf positionTwo = "g2" Then
            Me.currentPic.Image = Me.PictureBox79.Image
        ElseIf positionTwo = "h2" Then
            Me.currentPic.Image = Me.PictureBox80.Image
        ElseIf positionTwo = "i2" Then
            Me.currentPic.Image = Me.PictureBox81.Image
        ElseIf positionTwo = "a3" Then
            Me.currentPic.Image = Me.PictureBox64.Image
        ElseIf positionTwo = "b3" Then
            Me.currentPic.Image = Me.PictureBox65.Image
        ElseIf positionTwo = "c3" Then
            Me.currentPic.Image = Me.PictureBox66.Image
        ElseIf positionTwo = "d3" Then
            Me.currentPic.Image = Me.PictureBox67.Image
        ElseIf positionTwo = "e3" Then
            Me.currentPic.Image = Me.PictureBox68.Image
        ElseIf positionTwo = "f3" Then
            Me.currentPic.Image = Me.PictureBox69.Image
        ElseIf positionTwo = "g3" Then
            Me.currentPic.Image = Me.PictureBox70.Image
        ElseIf positionTwo = "h3" Then
            Me.currentPic.Image = Me.PictureBox71.Image
        ElseIf positionTwo = "i3" Then
            Me.currentPic.Image = Me.PictureBox72.Image
        ElseIf positionTwo = "a4" Then
            Me.currentPic.Image = Me.PictureBox55.Image
        ElseIf positionTwo = "b4" Then
            Me.currentPic.Image = Me.PictureBox56.Image
        ElseIf positionTwo = "c4" Then
            Me.currentPic.Image = Me.PictureBox57.Image
        ElseIf positionTwo = "d4" Then
            Me.currentPic.Image = Me.PictureBox58.Image
        ElseIf positionTwo = "e4" Then
            Me.currentPic.Image = Me.PictureBox59.Image
        ElseIf positionTwo = "f4" Then
            Me.currentPic.Image = Me.PictureBox60.Image
        ElseIf positionTwo = "g4" Then
            Me.currentPic.Image = Me.PictureBox61.Image
        ElseIf positionTwo = "h4" Then
            Me.currentPic.Image = Me.PictureBox62.Image
        ElseIf positionTwo = "i4" Then
            Me.currentPic.Image = Me.PictureBox63.Image
        ElseIf positionTwo = "a5" Then
            Me.currentPic.Image = Me.PictureBox46.Image
        ElseIf positionTwo = "b5" Then
            Me.currentPic.Image = Me.PictureBox47.Image
        ElseIf positionTwo = "c5" Then
            Me.currentPic.Image = Me.PictureBox48.Image
        ElseIf positionTwo = "d5" Then
            Me.currentPic.Image = Me.PictureBox49.Image
        ElseIf positionTwo = "e5" Then
            Me.currentPic.Image = Me.PictureBox50.Image
        ElseIf positionTwo = "f5" Then
            Me.currentPic.Image = Me.PictureBox51.Image
        ElseIf positionTwo = "g5" Then
            Me.currentPic.Image = Me.PictureBox52.Image
        ElseIf positionTwo = "h5" Then
            Me.currentPic.Image = Me.PictureBox53.Image
        ElseIf positionTwo = "i5" Then
            Me.currentPic.Image = Me.PictureBox54.Image
        ElseIf positionTwo = "a6" Then
            Me.currentPic.Image = Me.PictureBox37.Image
        ElseIf positionTwo = "b6" Then
            Me.currentPic.Image = Me.PictureBox38.Image
        ElseIf positionTwo = "c6" Then
            Me.currentPic.Image = Me.PictureBox39.Image
        ElseIf positionTwo = "d6" Then
            Me.currentPic.Image = Me.PictureBox40.Image
        ElseIf positionTwo = "e6" Then
            Me.currentPic.Image = Me.PictureBox41.Image
        ElseIf positionTwo = "f6" Then
            Me.currentPic.Image = Me.PictureBox42.Image
        ElseIf positionTwo = "g6" Then
            Me.currentPic.Image = Me.PictureBox43.Image
        ElseIf positionTwo = "h6" Then
            Me.currentPic.Image = Me.PictureBox44.Image
        ElseIf positionTwo = "i6" Then
            Me.currentPic.Image = Me.PictureBox45.Image
        ElseIf positionTwo = "a7" Then
            Me.currentPic.Image = Me.PictureBox28.Image
        ElseIf positionTwo = "b7" Then
            Me.currentPic.Image = Me.PictureBox29.Image
        ElseIf positionTwo = "c7" Then
            Me.currentPic.Image = Me.PictureBox30.Image
        ElseIf positionTwo = "d7" Then
            Me.currentPic.Image = Me.PictureBox31.Image
        ElseIf positionTwo = "e7" Then
            Me.currentPic.Image = Me.PictureBox32.Image
        ElseIf positionTwo = "f7" Then
            Me.currentPic.Image = Me.PictureBox33.Image
        ElseIf positionTwo = "g7" Then
            Me.currentPic.Image = Me.PictureBox34.Image
        ElseIf positionTwo = "h7" Then
            Me.currentPic.Image = Me.PictureBox35.Image
        ElseIf positionTwo = "i7" Then
            Me.currentPic.Image = Me.PictureBox36.Image
        ElseIf positionTwo = "a8" Then
            Me.currentPic.Image = Me.PictureBox19.Image
        ElseIf positionTwo = "b8" Then
            Me.currentPic.Image = Me.PictureBox20.Image
        ElseIf positionTwo = "c8" Then
            Me.currentPic.Image = Me.PictureBox21.Image
        ElseIf positionTwo = "d8" Then
            Me.currentPic.Image = Me.PictureBox22.Image
        ElseIf positionTwo = "e8" Then
            Me.currentPic.Image = Me.PictureBox23.Image
        ElseIf positionTwo = "f8" Then
            Me.currentPic.Image = Me.PictureBox24.Image
        ElseIf positionTwo = "g8" Then
            Me.currentPic.Image = Me.PictureBox25.Image
        ElseIf positionTwo = "h8" Then
            Me.currentPic.Image = Me.PictureBox26.Image
        ElseIf positionTwo = "i8" Then
            Me.currentPic.Image = Me.PictureBox27.Image
        ElseIf positionTwo = "a9" Then
            Me.currentPic.Image = Me.PictureBox10.Image
        ElseIf positionTwo = "b9" Then
            Me.currentPic.Image = Me.PictureBox11.Image
        ElseIf positionTwo = "c9" Then
            Me.currentPic.Image = Me.PictureBox12.Image
        ElseIf positionTwo = "d9" Then
            Me.currentPic.Image = Me.PictureBox13.Image
        ElseIf positionTwo = "e9" Then
            Me.currentPic.Image = Me.PictureBox14.Image
        ElseIf positionTwo = "f9" Then
            Me.currentPic.Image = Me.PictureBox15.Image
        ElseIf positionTwo = "g9" Then
            Me.currentPic.Image = Me.PictureBox16.Image
        ElseIf positionTwo = "h9" Then
            Me.currentPic.Image = Me.PictureBox17.Image
        ElseIf positionTwo = "i9" Then
            Me.currentPic.Image = Me.PictureBox18.Image
        ElseIf positionTwo = "a10" Then
            Me.currentPic.Image = Me.PictureBox1.Image
        ElseIf positionTwo = "b10" Then
            Me.currentPic.Image = Me.PictureBox2.Image
        ElseIf positionTwo = "c10" Then
            Me.currentPic.Image = Me.PictureBox3.Image
        ElseIf positionTwo = "d10" Then
            Me.currentPic.Image = Me.PictureBox4.Image
        ElseIf positionTwo = "e10" Then
            Me.currentPic.Image = Me.PictureBox5.Image
        ElseIf positionTwo = "f10" Then
            Me.currentPic.Image = Me.PictureBox6.Image
        ElseIf positionTwo = "g10" Then
            Me.currentPic.Image = Me.PictureBox7.Image
        ElseIf positionTwo = "h10" Then
            Me.currentPic.Image = Me.PictureBox8.Image
        ElseIf positionTwo = "i10" Then
            Me.currentPic.Image = Me.PictureBox9.Image

        End If
    End Sub
    Private Sub ChangeCurrentPicToPreviousPic()
        Me.previousPic.Image = Me.currentPic.Image
    End Sub
    Private Sub ChangePreviousPicToInterPic()
        Me.interPic.Image = Me.previousPic.Image
    End Sub
    Private Sub ClearPic()
        Me.currentPic.Image = Me.nonePic.Image
        Me.previousPic.Image = Me.nonePic.Image
    End Sub

    Private Sub MovePiece()
        If moveAllowBool = True Then
            If (positionOne = "a1" Or positionOne = "a2" Or positionOne = "a3" Or positionOne = "a4" Or positionOne = "a5" Or positionOne = "a6" Or positionOne = "a7" Or positionOne = "a8" Or positionOne = "a9" Or positionOne = "a10") Then
                CheckA()
            ElseIf (positionOne = "b1" Or positionOne = "b2" Or positionOne = "b3" Or positionOne = "b4" Or positionOne = "b5" Or positionOne = "b6" Or positionOne = "b7" Or positionOne = "b8" Or positionOne = "b9" Or positionOne = "b10") Then
                CheckB()
            ElseIf (positionOne = "c1" Or positionOne = "c2" Or positionOne = "c3" Or positionOne = "c4" Or positionOne = "c5" Or positionOne = "c6" Or positionOne = "c7" Or positionOne = "c8" Or positionOne = "c9" Or positionOne = "c10") Then
                CheckC()
            ElseIf (positionOne = "d1" Or positionOne = "d2" Or positionOne = "d3" Or positionOne = "d4" Or positionOne = "d5" Or positionOne = "d6" Or positionOne = "d7" Or positionOne = "d8" Or positionOne = "d9" Or positionOne = "d10") Then
                CheckD()
            ElseIf (positionOne = "e1" Or positionOne = "e2" Or positionOne = "e3" Or positionOne = "e4" Or positionOne = "e5" Or positionOne = "e6" Or positionOne = "e7" Or positionOne = "e8" Or positionOne = "e9" Or positionOne = "e10") Then
                CheckE()
            ElseIf (positionOne = "f1" Or positionOne = "f2" Or positionOne = "f3" Or positionOne = "f4" Or positionOne = "f5" Or positionOne = "f6" Or positionOne = "f7" Or positionOne = "f8" Or positionOne = "f9" Or positionOne = "f10") Then
                CheckF()
            ElseIf (positionOne = "g1" Or positionOne = "g2" Or positionOne = "g3" Or positionOne = "g4" Or positionOne = "g5" Or positionOne = "g6" Or positionOne = "g7" Or positionOne = "g8" Or positionOne = "g9" Or positionOne = "g10") Then
                CheckG()
            ElseIf (positionOne = "h1" Or positionOne = "h2" Or positionOne = "h3" Or positionOne = "h4" Or positionOne = "h5" Or positionOne = "h6" Or positionOne = "h7" Or positionOne = "h8" Or positionOne = "h9" Or positionOne = "h10") Then
                CheckH()
            ElseIf (positionOne = "i1" Or positionOne = "i2" Or positionOne = "i3" Or positionOne = "i4" Or positionOne = "i5" Or positionOne = "i6" Or positionOne = "i7" Or positionOne = "i8" Or positionOne = "i9" Or positionOne = "i10") Then
                CheckI()
            End If
            If AIMovement = False Then
                InsertMovementRecord()
            End If
        Else
            Me.currentPic.Image = Me.previousPic.Image
            Me.previousPic.Image = Me.interPic.Image
            MsgBox("moveAllowBool = False", MsgBoxStyle.OkOnly, "")
        End If
    End Sub
    Private Sub CheckAllowBool()
        If (moveBool = True And blockBool = False) Then
            moveAllowBool = True
        ElseIf ((moveBool = False) Or (blockBool = True)) Then
            moveAllowBool = False
        Else
            MsgBox("checkAllowBool", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub checkPic()

        If (Me.currentPic.Image Is Me.whiteChePic.Image) Or (Me.currentPic.Image Is Me.blackChePic.Image) Then
            ' check Che Move
            CheckCheMove()
            CheckChePaoBlock()
        ElseIf (Me.currentPic.Image Is Me.whiteZuPic.Image) Then
            ' check white Zu Move
            CheckWhiteZuMove()
            noBlock()
        ElseIf (Me.currentPic.Image Is Me.blackBingPic.Image) Then
            ' check black bing move
            CheckBlackBingMove()
            noBlock()
        ElseIf (Me.currentPic.Image Is Me.whiteJiangPic.Image) Then
            ' check white jiang move
            CheckWhiteJiangMove()
            noBlock()
        ElseIf (Me.currentPic.Image Is Me.blackJiangPic.Image) Then
            ' check black jiang move
            CheckBlackJiangMove()
            noBlock()
        ElseIf (Me.currentPic.Image Is Me.whitePaoPic.Image) Or (Me.currentPic.Image Is Me.blackPaoPic.Image) Then
            ' check pao move
            CheckPaoMove()
            CheckChePaoBlock()
        ElseIf (Me.currentPic.Image Is Me.whiteMaPic.Image) Or (Me.currentPic.Image Is Me.blackMaPic.Image) Then
            ' check ma move
            CheckMaMove()
            CheckMaBlock()
        ElseIf (Me.currentPic.Image Is Me.whiteXiangPic.Image) Then
            ' check white xiang move
            CheckWhiteXiangMove()
            CheckWhiteXiangBlock()
        ElseIf (Me.currentPic.Image Is Me.blackXiangPic.Image) Then
            ' check black xiang move
            CheckBlackXiangMove()
            CheckBlackXiangBlock()
        ElseIf (Me.currentPic.Image Is Me.whiteShiPic.Image) Then
            ' check white shi move
            CheckWhiteShiMove()
            noBlock()
        ElseIf (Me.currentPic.Image Is Me.blackShiPic.Image) Then
            ' check black shi move
            CheckBlackShiMove()
            noBlock()
        End If
    End Sub
    Private Sub checkColor()
        If (positionOneColor = "Black" And positionTwoColor = "Black") Or
        (positionOneColor = "White" And positionTwoColor = "White") Then
            sameColorBool = True
        Else
            sameColorBool = False
        End If
    End Sub

    Private Sub checkPositionOneColor()
        If (Me.currentPic.Image Is Me.whiteZuPic.Image) Or
        (Me.currentPic.Image Is Me.whiteXiangPic.Image) Or
        (Me.currentPic.Image Is Me.whiteShiPic.Image) Or
        (Me.currentPic.Image Is Me.whitePaoPic.Image) Or
        (Me.currentPic.Image Is Me.whiteMaPic.Image) Or
        (Me.currentPic.Image Is Me.whiteJiangPic.Image) Or
        (Me.currentPic.Image Is Me.whiteChePic.Image) Then
            positionOneColor = "White"
        ElseIf (Me.currentPic.Image Is Me.blackBingPic.Image) Or
        (Me.currentPic.Image Is Me.blackXiangPic.Image) Or
        (Me.currentPic.Image Is Me.blackShiPic.Image) Or
        (Me.currentPic.Image Is Me.blackPaoPic.Image) Or
        (Me.currentPic.Image Is Me.blackMaPic.Image) Or
        (Me.currentPic.Image Is Me.blackJiangPic.Image) Or
        (Me.currentPic.Image Is Me.blackChePic.Image) Then
            positionOneColor = "Black"
        End If
    End Sub
    Private Sub checkPositionTwoColor()
        'If positionTwoNonPicBool = False Then
        If (Me.currentPic.Image Is Me.whiteZuPic.Image) Or
        (Me.currentPic.Image Is Me.whiteXiangPic.Image) Or
        (Me.currentPic.Image Is Me.whiteShiPic.Image) Or
        (Me.currentPic.Image Is Me.whitePaoPic.Image) Or
        (Me.currentPic.Image Is Me.whiteMaPic.Image) Or
        (Me.currentPic.Image Is Me.whiteJiangPic.Image) Or
        (Me.currentPic.Image Is Me.whiteChePic.Image) Then
            positionTwoColor = "White"
        ElseIf (Me.currentPic.Image Is Me.blackBingPic.Image) Or
        (Me.currentPic.Image Is Me.blackXiangPic.Image) Or
        (Me.currentPic.Image Is Me.blackShiPic.Image) Or
        (Me.currentPic.Image Is Me.blackPaoPic.Image) Or
        (Me.currentPic.Image Is Me.blackMaPic.Image) Or
        (Me.currentPic.Image Is Me.blackJiangPic.Image) Or
        (Me.currentPic.Image Is Me.blackChePic.Image) Then
            positionTwoColor = "Black"
        End If
        'End If
    End Sub

    Private Sub CheckMovementArea()
        Purpose1 = "CheckMovementArea"
        If (Me.currentPic.Image Is Me.whiteChePic.Image) Then
            PieceColor = "White"
            CheckCheMovementArea()
        ElseIf (Me.currentPic.Image Is Me.blackChePic.Image) Then
            PieceColor = "Black"
            CheckCheMovementArea()
        ElseIf (Me.currentPic.Image Is Me.whiteZuPic.Image) Then
            CheckWhiteZuMovementArea()
        ElseIf (Me.currentPic.Image Is Me.blackBingPic.Image) Then
            CheckBlackBingMovementArea()
        ElseIf (Me.currentPic.Image Is Me.whiteJiangPic.Image) Then
            CheckWhiteJiangMovementArea()
        ElseIf (Me.currentPic.Image Is Me.blackJiangPic.Image) Then
            CheckBlackJiangMovementArea()
        ElseIf (Me.currentPic.Image Is Me.whitePaoPic.Image) Then
            PieceColor = "White"
            CheckPaoMovementArea()
        ElseIf (Me.currentPic.Image Is Me.blackPaoPic.Image) Then
            PieceColor = "Black"
            CheckPaoMovementArea()
        ElseIf (Me.currentPic.Image Is Me.whiteMaPic.Image) Then
            PieceColor = "White"
            CheckMaMovementArea()
        ElseIf (Me.currentPic.Image Is Me.blackMaPic.Image) Then
            PieceColor = "Black"
            CheckMaMovementArea()
        ElseIf (Me.currentPic.Image Is Me.whiteXiangPic.Image) Then
            CheckWhiteXiangMovementArea()
        ElseIf (Me.currentPic.Image Is Me.blackXiangPic.Image) Then
            CheckBlackXiangMovementArea()
        ElseIf (Me.currentPic.Image Is Me.whiteShiPic.Image) Then
            CheckWhiteShiMovementArea()
        ElseIf (Me.currentPic.Image Is Me.blackShiPic.Image) Then
            CheckBlackShiMovementArea()
        End If
    End Sub

    Public Sub CheckMaMovementArea()
        If positionOne = "a1" Then
            CheckMaA1MovementArea()
        ElseIf positionOne = "a2" Then
            CheckMaA2MovementArea()
        ElseIf positionOne = "a3" Then
            CheckMaA3MovementArea()
        ElseIf positionOne = "a4" Then
            CheckMaA4MovementArea()
        ElseIf positionOne = "a5" Then
            CheckMaA5MovementArea()
        ElseIf positionOne = "a6" Then
            CheckMaA6MovementArea()
        ElseIf positionOne = "a7" Then
            CheckMaA7MovementArea()
        ElseIf positionOne = "a8" Then
            CheckMaA8MovementArea()
        ElseIf positionOne = "a9" Then
            CheckMaA9MovementArea()
        ElseIf positionOne = "a10" Then
            CheckMaA10MovementArea()
        ElseIf positionOne = "b1" Then
            CheckMaB1MovementArea()
        ElseIf positionOne = "b2" Then
            CheckMaB2MovementArea()
        ElseIf positionOne = "b3" Then
            CheckMaB3MovementArea()
        ElseIf positionOne = "b4" Then
            CheckMaB4MovementArea()
        ElseIf positionOne = "b5" Then
            CheckMaB5MovementArea()
        ElseIf positionOne = "b6" Then
            CheckMaB6MovementArea()
        ElseIf positionOne = "b7" Then
            CheckMaB7MovementArea()
        ElseIf positionOne = "b8" Then
            CheckMaB8MovementArea()
        ElseIf positionOne = "b9" Then
            CheckMaB9MovementArea()
        ElseIf positionOne = "b10" Then
            CheckMaB10MovementArea()
        ElseIf positionOne = "c1" Then
            CheckMaC1MovementArea()
        ElseIf positionOne = "c2" Then
            CheckMaC2MovementArea()
        ElseIf positionOne = "c3" Then
            CheckMaC3MovementArea()
        ElseIf positionOne = "c4" Then
            CheckMaC4MovementArea()
        ElseIf positionOne = "c5" Then
            CheckMaC5MovementArea()
        ElseIf positionOne = "c6" Then
            CheckMaC6MovementArea()
        ElseIf positionOne = "c7" Then
            CheckMaC7MovementArea()
        ElseIf positionOne = "c8" Then
            CheckMaC8MovementArea()
        ElseIf positionOne = "c9" Then
            CheckMaC9MovementArea()
        ElseIf positionOne = "c10" Then
            CheckMaC10MovementArea()
        ElseIf positionOne = "d1" Then
            CheckMaD1MovementArea()
        ElseIf positionOne = "d2" Then
            CheckMaD2MovementArea()
        ElseIf positionOne = "d3" Then
            CheckMaD3MovementArea()
        ElseIf positionOne = "d4" Then
            CheckMaD4MovementArea()
        ElseIf positionOne = "d5" Then
            CheckMaD5MovementArea()
        ElseIf positionOne = "d6" Then
            CheckMaD6MovementArea()
        ElseIf positionOne = "d7" Then
            CheckMaD7MovementArea()
        ElseIf positionOne = "d8" Then
            CheckMaD8MovementArea()
        ElseIf positionOne = "d9" Then
            CheckMaD9MovementArea()
        ElseIf positionOne = "d10" Then
            CheckMaD10MovementArea()
        ElseIf positionOne = "e1" Then
            CheckMaE1MovementArea()
        ElseIf positionOne = "e2" Then
            CheckMaE2MovementArea()
        ElseIf positionOne = "e3" Then
            CheckMaE3MovementArea()
        ElseIf positionOne = "e4" Then
            CheckMaE4MovementArea()
        ElseIf positionOne = "e5" Then
            CheckMaE5MovementArea()
        ElseIf positionOne = "e6" Then
            CheckMaE6MovementArea()
        ElseIf positionOne = "e7" Then
            CheckMaE7MovementArea()
        ElseIf positionOne = "e8" Then
            CheckMaE8MovementArea()
        ElseIf positionOne = "e9" Then
            CheckMaE9MovementArea()
        ElseIf positionOne = "e10" Then
            CheckMaE10MovementArea()
        ElseIf positionOne = "f1" Then
            CheckMaF1MovementArea()
        ElseIf positionOne = "f2" Then
            CheckMaF2MovementArea()
        ElseIf positionOne = "f3" Then
            CheckMaF3MovementArea()
        ElseIf positionOne = "f4" Then
            CheckMaF4MovementArea()
        ElseIf positionOne = "f5" Then
            CheckMaF5MovementArea()
        ElseIf positionOne = "f6" Then
            CheckMaF6MovementArea()
        ElseIf positionOne = "f7" Then
            CheckMaF7MovementArea()
        ElseIf positionOne = "f8" Then
            CheckMaF8MovementArea()
        ElseIf positionOne = "f9" Then
            CheckMaF9MovementArea()
        ElseIf positionOne = "f10" Then
            CheckMaF10MovementArea()
        ElseIf positionOne = "g1" Then
            CheckMaG1MovementArea()
        ElseIf positionOne = "g2" Then
            CheckMaG2MovementArea()
        ElseIf positionOne = "g3" Then
            CheckMaG3MovementArea()
        ElseIf positionOne = "g4" Then
            CheckMaG4MovementArea()
        ElseIf positionOne = "g5" Then
            CheckMaG5MovementArea()
        ElseIf positionOne = "g6" Then
            CheckMaG6MovementArea()
        ElseIf positionOne = "g7" Then
            CheckMaG7MovementArea()
        ElseIf positionOne = "g8" Then
            CheckMaG8MovementArea()
        ElseIf positionOne = "g9" Then
            CheckMaG9MovementArea()
        ElseIf positionOne = "g10" Then
            CheckMaG10MovementArea()
        ElseIf positionOne = "h1" Then
            CheckMaH1MovementArea()
        ElseIf positionOne = "h2" Then
            CheckMaH2MovementArea()
        ElseIf positionOne = "h3" Then
            CheckMaH3MovementArea()
        ElseIf positionOne = "h4" Then
            CheckMaH4MovementArea()
        ElseIf positionOne = "h5" Then
            CheckMaH5MovementArea()
        ElseIf positionOne = "h6" Then
            CheckMaH6MovementArea()
        ElseIf positionOne = "h7" Then
            CheckMaH7MovementArea()
        ElseIf positionOne = "h8" Then
            CheckMaH8MovementArea()
        ElseIf positionOne = "h9" Then
            CheckMaH9MovementArea()
        ElseIf positionOne = "h10" Then
            CheckMaH10MovementArea()
        ElseIf positionOne = "i1" Then
            CheckMaI1MovementArea()
        ElseIf positionOne = "i2" Then
            CheckMaI2MovementArea()
        ElseIf positionOne = "i3" Then
            CheckMaI3MovementArea()
        ElseIf positionOne = "i4" Then
            CheckMaI4MovementArea()
        ElseIf positionOne = "i5" Then
            CheckMaI5MovementArea()
        ElseIf positionOne = "i6" Then
            CheckMaI6MovementArea()
        ElseIf positionOne = "i7" Then
            CheckMaI7MovementArea()
        ElseIf positionOne = "i8" Then
            CheckMaI8MovementArea()
        ElseIf positionOne = "i9" Then
            CheckMaI9MovementArea()
        ElseIf positionOne = "i10" Then
            CheckMaI10MovementArea()
        End If

    End Sub
    Public Sub CheckCheMovementArea()
        If positionOne = "a1" Then
            CheckCheA1MovementArea()
        ElseIf positionOne = "b1" Then
            CheckCheB1MovementArea()
        ElseIf positionOne = "c1" Then
            CheckCheC1MovementArea()
        ElseIf positionOne = "d1" Then
            CheckCheD1MovementArea()
        ElseIf positionOne = "e1" Then
            CheckCheE1MovementArea()
        ElseIf positionOne = "f1" Then
            CheckCheF1MovementArea()
        ElseIf positionOne = "g1" Then
            CheckCheG1MovementArea()
        ElseIf positionOne = "h1" Then
            CheckCheH1MovementArea()
        ElseIf positionOne = "i1" Then
            CheckCheI1MovementArea()
        ElseIf positionOne = "a2" Then
            CheckCheA2MovementArea()
        ElseIf positionOne = "b2" Then
            CheckCheB2MovementArea()
        ElseIf positionOne = "c2" Then
            CheckCheC2MovementArea()
        ElseIf positionOne = "d2" Then
            CheckCheD2MovementArea()
        ElseIf positionOne = "e2" Then
            CheckCheE2MovementArea()
        ElseIf positionOne = "f2" Then
            CheckCheF2MovementArea()
        ElseIf positionOne = "g2" Then
            CheckCheG2MovementArea()
        ElseIf positionOne = "h2" Then
            CheckCheH2MovementArea()
        ElseIf positionOne = "i2" Then
            CheckCheI2MovementArea()
        ElseIf positionOne = "a3" Then
            CheckCheA3MovementArea()
        ElseIf positionOne = "b3" Then
            CheckCheB3MovementArea()
        ElseIf positionOne = "c3" Then
            CheckCheC3MovementArea()
        ElseIf positionOne = "d3" Then
            CheckCheD3MovementArea()
        ElseIf positionOne = "e3" Then
            CheckCheE3MovementArea()
        ElseIf positionOne = "f3" Then
            CheckCheF3MovementArea()
        ElseIf positionOne = "g3" Then
            CheckCheG3MovementArea()
        ElseIf positionOne = "h3" Then
            CheckCheH3MovementArea()
        ElseIf positionOne = "i3" Then
            CheckCheI3MovementArea()
        ElseIf positionOne = "a4" Then
            CheckCheA4MovementArea()
        ElseIf positionOne = "b4" Then
            CheckCheB4MovementArea()
        ElseIf positionOne = "c4" Then
            CheckCheC4MovementArea()
        ElseIf positionOne = "d4" Then
            CheckCheD4MovementArea()
        ElseIf positionOne = "e4" Then
            CheckCheE4MovementArea()
        ElseIf positionOne = "f4" Then
            CheckCheF4MovementArea()
        ElseIf positionOne = "g4" Then
            CheckCheG4MovementArea()
        ElseIf positionOne = "h4" Then
            CheckCheH4MovementArea()
        ElseIf positionOne = "i4" Then
            CheckCheI4MovementArea()
        ElseIf positionOne = "a5" Then
            CheckCheA5MovementArea()
        ElseIf positionOne = "b5" Then
            CheckCheB5MovementArea()
        ElseIf positionOne = "c5" Then
            CheckCheC5MovementArea()
        ElseIf positionOne = "d5" Then
            CheckCheD5MovementArea()
        ElseIf positionOne = "e5" Then
            CheckCheE5MovementArea()
        ElseIf positionOne = "f5" Then
            CheckCheF5MovementArea()
        ElseIf positionOne = "g5" Then
            CheckCheG5MovementArea()
        ElseIf positionOne = "h5" Then
            CheckCheH5MovementArea()
        ElseIf positionOne = "i5" Then
            CheckCheI5MovementArea()
        ElseIf positionOne = "a6" Then
            CheckCheA6MovementArea()
        ElseIf positionOne = "b6" Then
            CheckCheB6MovementArea()
        ElseIf positionOne = "c6" Then
            CheckCheC6MovementArea()
        ElseIf positionOne = "d6" Then
            CheckCheD6MovementArea()
        ElseIf positionOne = "e6" Then
            CheckCheE6MovementArea()
        ElseIf positionOne = "f6" Then
            CheckCheF6MovementArea()
        ElseIf positionOne = "g6" Then
            CheckCheG6MovementArea()
        ElseIf positionOne = "h6" Then
            CheckCheH6MovementArea()
        ElseIf positionOne = "i6" Then
            CheckCheI6MovementArea()
        ElseIf positionOne = "a7" Then
            CheckCheA7MovementArea()
        ElseIf positionOne = "b7" Then
            CheckCheB7MovementArea()
        ElseIf positionOne = "c7" Then
            CheckCheC7MovementArea()
        ElseIf positionOne = "d7" Then
            CheckCheD7MovementArea()
        ElseIf positionOne = "e7" Then
            CheckCheE7MovementArea()
        ElseIf positionOne = "f7" Then
            CheckCheF7MovementArea()
        ElseIf positionOne = "g7" Then
            CheckCheG7MovementArea()
        ElseIf positionOne = "h7" Then
            CheckCheH7MovementArea()
        ElseIf positionOne = "i7" Then
            CheckCheI7MovementArea()
        ElseIf positionOne = "a8" Then
            CheckCheA8MovementArea()
        ElseIf positionOne = "b8" Then
            CheckCheB8MovementArea()
        ElseIf positionOne = "c8" Then
            CheckCheC8MovementArea()
        ElseIf positionOne = "d8" Then
            CheckCheD8MovementArea()
        ElseIf positionOne = "e8" Then
            CheckCheE8MovementArea()
        ElseIf positionOne = "f8" Then
            CheckCheF8MovementArea()
        ElseIf positionOne = "g8" Then
            CheckCheG8MovementArea()
        ElseIf positionOne = "h8" Then
            CheckCheH8MovementArea()
        ElseIf positionOne = "i8" Then
            CheckCheI8MovementArea()
        ElseIf positionOne = "a9" Then
            CheckCheA9MovementArea()
        ElseIf positionOne = "b9" Then
            CheckCheB9MovementArea()
        ElseIf positionOne = "c9" Then
            CheckCheC9MovementArea()
        ElseIf positionOne = "d9" Then
            CheckCheD9MovementArea()
        ElseIf positionOne = "e9" Then
            CheckCheE9MovementArea()
        ElseIf positionOne = "f9" Then
            CheckCheF9MovementArea()
        ElseIf positionOne = "g9" Then
            CheckCheG9MovementArea()
        ElseIf positionOne = "h9" Then
            CheckCheH9MovementArea()
        ElseIf positionOne = "i9" Then
            CheckCheI9MovementArea()
        ElseIf positionOne = "a10" Then
            CheckCheA10MovementArea()
        ElseIf positionOne = "b10" Then
            CheckCheB10MovementArea()
        ElseIf positionOne = "c10" Then
            CheckCheC10MovementArea()
        ElseIf positionOne = "d10" Then
            CheckCheD10MovementArea()
        ElseIf positionOne = "e10" Then
            CheckCheE10MovementArea()
        ElseIf positionOne = "f10" Then
            CheckCheF10MovementArea()
        ElseIf positionOne = "g10" Then
            CheckCheG10MovementArea()
        ElseIf positionOne = "h10" Then
            CheckCheH10MovementArea()
        ElseIf positionOne = "i10" Then
            CheckCheI10MovementArea()
        End If
    End Sub
    Public Sub CheckPaoMovementArea()
        If positionOne = "a1" Then
            CheckPaoA1MovementArea()
        ElseIf positionOne = "b1" Then
            CheckPaoB1MovementArea()
        ElseIf positionOne = "c1" Then
            CheckPaoC1MovementArea()
        ElseIf positionOne = "d1" Then
            CheckPaoD1MovementArea()
        ElseIf positionOne = "e1" Then
            CheckPaoE1MovementArea()
        ElseIf positionOne = "f1" Then
            CheckPaoF1MovementArea()
        ElseIf positionOne = "g1" Then
            CheckPaoG1MovementArea()
        ElseIf positionOne = "h1" Then
            CheckPaoH1MovementArea()
        ElseIf positionOne = "i1" Then
            CheckPaoI1MovementArea()
        ElseIf positionOne = "a2" Then
            CheckPaoA2MovementArea()
        ElseIf positionOne = "b2" Then
            CheckPaoB2MovementArea()
        ElseIf positionOne = "c2" Then
            CheckPaoC2MovementArea()
        ElseIf positionOne = "d2" Then
            CheckPaoD2MovementArea()
        ElseIf positionOne = "e2" Then
            CheckPaoE2MovementArea()
        ElseIf positionOne = "f2" Then
            CheckPaoF2MovementArea()
        ElseIf positionOne = "g2" Then
            CheckPaoG2MovementArea()
        ElseIf positionOne = "h2" Then
            CheckPaoH2MovementArea()
        ElseIf positionOne = "i2" Then
            CheckPaoI2MovementArea()
        ElseIf positionOne = "a3" Then
            CheckPaoA3MovementArea()
        ElseIf positionOne = "b3" Then
            CheckPaoB3MovementArea()
        ElseIf positionOne = "c3" Then
            CheckPaoC3MovementArea()
        ElseIf positionOne = "d3" Then
            CheckPaoD3MovementArea()
        ElseIf positionOne = "e3" Then
            CheckPaoE3MovementArea()
        ElseIf positionOne = "f3" Then
            CheckPaoF3MovementArea()
        ElseIf positionOne = "g3" Then
            CheckPaoG3MovementArea()
        ElseIf positionOne = "h3" Then
            CheckPaoH3MovementArea()
        ElseIf positionOne = "i3" Then
            CheckPaoI3MovementArea()
        ElseIf positionOne = "a4" Then
            CheckPaoA4MovementArea()
        ElseIf positionOne = "b4" Then
            CheckPaoB4MovementArea()
        ElseIf positionOne = "c4" Then
            CheckPaoC4MovementArea()
        ElseIf positionOne = "d4" Then
            CheckPaoD4MovementArea()
        ElseIf positionOne = "e4" Then
            CheckPaoE4MovementArea()
        ElseIf positionOne = "f4" Then
            CheckPaoF4MovementArea()
        ElseIf positionOne = "g4" Then
            CheckPaoG4MovementArea()
        ElseIf positionOne = "h4" Then
            CheckPaoH4MovementArea()
        ElseIf positionOne = "i4" Then
            CheckPaoI4MovementArea()
        ElseIf positionOne = "a5" Then
            CheckPaoA5MovementArea()
        ElseIf positionOne = "b5" Then
            CheckPaoB5MovementArea()
        ElseIf positionOne = "c5" Then
            CheckPaoC5MovementArea()
        ElseIf positionOne = "d5" Then
            CheckPaoD5MovementArea()
        ElseIf positionOne = "e5" Then
            CheckPaoE5MovementArea()
        ElseIf positionOne = "f5" Then
            CheckPaoF5MovementArea()
        ElseIf positionOne = "g5" Then
            CheckPaoG5MovementArea()
        ElseIf positionOne = "h5" Then
            CheckPaoH5MovementArea()
        ElseIf positionOne = "i5" Then
            CheckPaoI5MovementArea()
        ElseIf positionOne = "a6" Then
            CheckPaoA6MovementArea()
        ElseIf positionOne = "b6" Then
            CheckPaoB6MovementArea()
        ElseIf positionOne = "c6" Then
            CheckPaoC6MovementArea()
        ElseIf positionOne = "d6" Then
            CheckPaoD6MovementArea()
        ElseIf positionOne = "e6" Then
            CheckPaoE6MovementArea()
        ElseIf positionOne = "f6" Then
            CheckPaoF6MovementArea()
        ElseIf positionOne = "g6" Then
            CheckPaoG6MovementArea()
        ElseIf positionOne = "h6" Then
            CheckPaoH6MovementArea()
        ElseIf positionOne = "i6" Then
            CheckPaoI6MovementArea()
        ElseIf positionOne = "a7" Then
            CheckPaoA7MovementArea()
        ElseIf positionOne = "b7" Then
            CheckPaoB7MovementArea()
        ElseIf positionOne = "c7" Then
            CheckPaoC7MovementArea()
        ElseIf positionOne = "d7" Then
            CheckPaoD7MovementArea()
        ElseIf positionOne = "e7" Then
            CheckPaoE7MovementArea()
        ElseIf positionOne = "f7" Then
            CheckPaoF7MovementArea()
        ElseIf positionOne = "g7" Then
            CheckPaoG7MovementArea()
        ElseIf positionOne = "h7" Then
            CheckPaoH7MovementArea()
        ElseIf positionOne = "i7" Then
            CheckPaoI7MovementArea()
        ElseIf positionOne = "a8" Then
            CheckPaoA8MovementArea()
        ElseIf positionOne = "b8" Then
            CheckPaoB8MovementArea()
        ElseIf positionOne = "c8" Then
            CheckPaoC8MovementArea()
        ElseIf positionOne = "d8" Then
            CheckPaoD8MovementArea()
        ElseIf positionOne = "e8" Then
            CheckPaoE8MovementArea()
        ElseIf positionOne = "f8" Then
            CheckPaoF8MovementArea()
        ElseIf positionOne = "g8" Then
            CheckPaoG8MovementArea()
        ElseIf positionOne = "h8" Then
            CheckPaoH8MovementArea()
        ElseIf positionOne = "i8" Then
            CheckPaoI8MovementArea()
        ElseIf positionOne = "a9" Then
            CheckPaoA9MovementArea()
        ElseIf positionOne = "b9" Then
            CheckPaoB9MovementArea()
        ElseIf positionOne = "c9" Then
            CheckPaoC9MovementArea()
        ElseIf positionOne = "d9" Then
            CheckPaoD9MovementArea()
        ElseIf positionOne = "e9" Then
            CheckPaoE9MovementArea()
        ElseIf positionOne = "f9" Then
            CheckPaoF9MovementArea()
        ElseIf positionOne = "g9" Then
            CheckPaoG9MovementArea()
        ElseIf positionOne = "h9" Then
            CheckPaoH9MovementArea()
        ElseIf positionOne = "i9" Then
            CheckPaoI9MovementArea()
        ElseIf positionOne = "a10" Then
            CheckPaoA10MovementArea()
        ElseIf positionOne = "b10" Then
            CheckPaoB10MovementArea()
        ElseIf positionOne = "c10" Then
            CheckPaoC10MovementArea()
        ElseIf positionOne = "d10" Then
            CheckPaoD10MovementArea()
        ElseIf positionOne = "e10" Then
            CheckPaoE10MovementArea()
        ElseIf positionOne = "f10" Then
            CheckPaoF10MovementArea()
        ElseIf positionOne = "g10" Then
            CheckPaoG10MovementArea()
        ElseIf positionOne = "h10" Then
            CheckPaoH10MovementArea()
        ElseIf positionOne = "i10" Then
            CheckPaoI10MovementArea()
        End If
    End Sub

    Private Sub CheckCheMove()
        If positionOne = "a1" Then
            checkCheA1Move()
        ElseIf positionOne = "b1" Then
            checkCheB1Move()
        ElseIf positionOne = "c1" Then
            checkCheC1Move()
        ElseIf positionOne = "d1" Then
            checkCheD1Move()
        ElseIf positionOne = "e1" Then
            checkCheE1Move()
        ElseIf positionOne = "f1" Then
            checkCheF1Move()
        ElseIf positionOne = "g1" Then
            checkCheG1Move()
        ElseIf positionOne = "h1" Then
            checkCheH1Move()
        ElseIf positionOne = "i1" Then
            checkCheI1Move()
        ElseIf positionOne = "a2" Then
            checkCheA2Move()
        ElseIf positionOne = "b2" Then
            checkCheB2Move()
        ElseIf positionOne = "c2" Then
            checkCheC2Move()
        ElseIf positionOne = "d2" Then
            checkCheD2Move()
        ElseIf positionOne = "e2" Then
            checkCheE2Move()
        ElseIf positionOne = "f2" Then
            checkCheF2Move()
        ElseIf positionOne = "g2" Then
            checkCheG2Move()
        ElseIf positionOne = "h2" Then
            checkCheH2Move()
        ElseIf positionOne = "i2" Then
            checkCheI2Move()
        ElseIf positionOne = "a3" Then
            checkCheA3Move()
        ElseIf positionOne = "b3" Then
            checkCheB3Move()
        ElseIf positionOne = "c3" Then
            checkCheC3Move()
        ElseIf positionOne = "d3" Then
            checkCheD3Move()
        ElseIf positionOne = "e3" Then
            checkCheE3Move()
        ElseIf positionOne = "f3" Then
            checkCheF3Move()
        ElseIf positionOne = "g3" Then
            checkCheG3Move()
        ElseIf positionOne = "h3" Then
            checkCheH3Move()
        ElseIf positionOne = "i3" Then
            checkCheI3Move()
        ElseIf positionOne = "a4" Then
            checkCheA4Move()
        ElseIf positionOne = "b4" Then
            checkCheB4Move()
        ElseIf positionOne = "c4" Then
            checkCheC4Move()
        ElseIf positionOne = "d4" Then
            checkCheD4Move()
        ElseIf positionOne = "e4" Then
            checkCheE4Move()
        ElseIf positionOne = "f4" Then
            checkCheF4Move()
        ElseIf positionOne = "g4" Then
            checkCheG4Move()
        ElseIf positionOne = "h4" Then
            checkCheH4Move()
        ElseIf positionOne = "i4" Then
            checkCheI4Move()
        ElseIf positionOne = "a5" Then
            checkCheA5Move()
        ElseIf positionOne = "b5" Then
            checkCheB5Move()
        ElseIf positionOne = "c5" Then
            checkCheC5Move()
        ElseIf positionOne = "d5" Then
            checkCheD5Move()
        ElseIf positionOne = "e5" Then
            checkCheE5Move()
        ElseIf positionOne = "f5" Then
            checkCheF5Move()
        ElseIf positionOne = "g5" Then
            checkCheG5Move()
        ElseIf positionOne = "h5" Then
            checkCheH5Move()
        ElseIf positionOne = "i5" Then
            checkCheI5Move()
        ElseIf positionOne = "a6" Then
            checkCheA6Move()
        ElseIf positionOne = "b6" Then
            checkCheB6Move()
        ElseIf positionOne = "c6" Then
            checkCheC6Move()
        ElseIf positionOne = "d6" Then
            checkCheD6Move()
        ElseIf positionOne = "e6" Then
            checkCheE6Move()
        ElseIf positionOne = "f6" Then
            checkCheF6Move()
        ElseIf positionOne = "g6" Then
            checkCheG6Move()
        ElseIf positionOne = "h6" Then
            checkCheH6Move()
        ElseIf positionOne = "i6" Then
            checkCheI6Move()
        ElseIf positionOne = "a7" Then
            checkCheA7Move()
        ElseIf positionOne = "b7" Then
            checkCheB7Move()
        ElseIf positionOne = "c7" Then
            checkCheC7Move()
        ElseIf positionOne = "d7" Then
            checkCheD7Move()
        ElseIf positionOne = "e7" Then
            checkCheE7Move()
        ElseIf positionOne = "f7" Then
            checkCheF7Move()
        ElseIf positionOne = "g7" Then
            checkCheG7Move()
        ElseIf positionOne = "h7" Then
            checkCheH7Move()
        ElseIf positionOne = "i7" Then
            checkCheI7Move()
        ElseIf positionOne = "a8" Then
            checkCheA8Move()
        ElseIf positionOne = "b8" Then
            checkCheB8Move()
        ElseIf positionOne = "c8" Then
            checkCheC8Move()
        ElseIf positionOne = "d8" Then
            checkCheD8Move()
        ElseIf positionOne = "e8" Then
            checkCheE8Move()
        ElseIf positionOne = "f8" Then
            checkCheF8Move()
        ElseIf positionOne = "g8" Then
            checkCheG8Move()
        ElseIf positionOne = "h8" Then
            checkCheH8Move()
        ElseIf positionOne = "i8" Then
            checkCheI8Move()
        ElseIf positionOne = "a9" Then
            checkCheA9Move()
        ElseIf positionOne = "b9" Then
            checkCheB9Move()
        ElseIf positionOne = "c9" Then
            checkCheC9Move()
        ElseIf positionOne = "d9" Then
            checkCheD9Move()
        ElseIf positionOne = "e9" Then
            checkCheE9Move()
        ElseIf positionOne = "f9" Then
            checkCheF9Move()
        ElseIf positionOne = "g9" Then
            checkCheG9Move()
        ElseIf positionOne = "h9" Then
            checkCheH9Move()
        ElseIf positionOne = "i9" Then
            checkCheI9Move()
        ElseIf positionOne = "a10" Then
            checkCheA10Move()
        ElseIf positionOne = "b10" Then
            checkCheB10Move()
        ElseIf positionOne = "c10" Then
            checkCheC10Move()
        ElseIf positionOne = "d10" Then
            checkCheD10Move()
        ElseIf positionOne = "e10" Then
            checkCheE10Move()
        ElseIf positionOne = "f10" Then
            checkCheF10Move()
        ElseIf positionOne = "g10" Then
            checkCheG10Move()
        ElseIf positionOne = "h10" Then
            checkCheH10Move()
        ElseIf positionOne = "i10" Then
            checkCheI10Move()
        End If
    End Sub
    Private Sub CheckWhiteZuMove()
        If (positionOne = "a7") Or (positionOne = "c7") Or (positionOne = "e7") Or (positionOne = "g7") Or (positionOne = "i7") Then
            checkWhiteZuRow7Move()
        ElseIf (positionOne = "a6") Or (positionOne = "c6") Or (positionOne = "e6") Or (positionOne = "g6") Or (positionOne = "i6") Then
            checkWhiteZuRow6Move()
        ElseIf (positionOne = "a5") Or (positionOne = "b5") Or (positionOne = "c5") Or (positionOne = "d5") Or (positionOne = "e5") Or (positionOne = "f5") Or (positionOne = "g5") Or (positionOne = "h5") Or (positionOne = "i5") Then
            checkWhiteZuRow5Move()
        ElseIf (positionOne = "a4") Or (positionOne = "b4") Or (positionOne = "c4") Or (positionOne = "d4") Or (positionOne = "e4") Or (positionOne = "f4") Or (positionOne = "g4") Or (positionOne = "h4") Or (positionOne = "i4") Then
            checkWhiteZuRow4Move()
        ElseIf (positionOne = "a3") Or (positionOne = "b3") Or (positionOne = "c3") Or (positionOne = "d3") Or (positionOne = "e3") Or (positionOne = "f3") Or (positionOne = "g3") Or (positionOne = "h3") Or (positionOne = "i3") Then
            checkWhiteZuRow3Move()
        ElseIf (positionOne = "a2") Or (positionOne = "b2") Or (positionOne = "c2") Or (positionOne = "d2") Or (positionOne = "e2") Or (positionOne = "f2") Or (positionOne = "g2") Or (positionOne = "h2") Or (positionOne = "i2") Then
            checkWhiteZuRow2Move()
        ElseIf (positionOne = "a1") Or (positionOne = "b1") Or (positionOne = "c1") Or (positionOne = "d1") Or (positionOne = "e1") Or (positionOne = "f1") Or (positionOne = "g1") Or (positionOne = "h1") Or (positionOne = "i1") Then
            checkWhiteZuRow1Move()
        End If
    End Sub
    Private Sub CheckBlackBingMove()
        If (positionOne = "a4") Or (positionOne = "c4") Or (positionOne = "e4") Or (positionOne = "g4") Or (positionOne = "i4") Then
            checkBlackBingRow4Move()
        ElseIf (positionOne = "a5") Or (positionOne = "c5") Or (positionOne = "e5") Or (positionOne = "g5") Or (positionOne = "i5") Then
            checkBlackBingRow5Move()
        ElseIf (positionOne = "a6") Or (positionOne = "b6") Or (positionOne = "c6") Or (positionOne = "d6") Or (positionOne = "e6") Or (positionOne = "f6") Or (positionOne = "g6") Or (positionOne = "h6") Or (positionOne = "i6") Then
            checkBlackBingRow6Move()
        ElseIf (positionOne = "a7") Or (positionOne = "b7") Or (positionOne = "c7") Or (positionOne = "d7") Or (positionOne = "e7") Or (positionOne = "f7") Or (positionOne = "g7") Or (positionOne = "h7") Or (positionOne = "i7") Then
            checkBlackBingRow7Move()
        ElseIf (positionOne = "a8") Or (positionOne = "b8") Or (positionOne = "c8") Or (positionOne = "d8") Or (positionOne = "e8") Or (positionOne = "f8") Or (positionOne = "g8") Or (positionOne = "h8") Or (positionOne = "i8") Then
            checkBlackBingRow8Move()
        ElseIf (positionOne = "a9") Or (positionOne = "b9") Or (positionOne = "c9") Or (positionOne = "d9") Or (positionOne = "e9") Or (positionOne = "f9") Or (positionOne = "g9") Or (positionOne = "h9") Or (positionOne = "i9") Then
            checkBlackBingRow9Move()
        ElseIf (positionOne = "a10") Or (positionOne = "b10") Or (positionOne = "c10") Or (positionOne = "d10") Or (positionOne = "e10") Or (positionOne = "f10") Or (positionOne = "g10") Or (positionOne = "h10") Or (positionOne = "i10") Then
            checkBlackBingRow10Move()
        End If
    End Sub
    Private Sub CheckWhiteJiangMove()
        If (positionOne = "a10") Or (positionOne = "b10") Or (positionOne = "c10") Or (positionOne = "d10") Or (positionOne = "e10") Or (positionOne = "f10") Or (positionOne = "g10") Or (positionOne = "h10") Or (positionOne = "i10") Then
            checkWhiteJiangRow10Move()
        ElseIf (positionOne = "a9") Or (positionOne = "b9") Or (positionOne = "c9") Or (positionOne = "d9") Or (positionOne = "e9") Or (positionOne = "f9") Or (positionOne = "g9") Or (positionOne = "h9") Or (positionOne = "i9") Then
            checkWhiteJiangRow9Move()
        ElseIf (positionOne = "a8") Or (positionOne = "b8") Or (positionOne = "c8") Or (positionOne = "d8") Or (positionOne = "e8") Or (positionOne = "f8") Or (positionOne = "g8") Or (positionOne = "h8") Or (positionOne = "i8") Then
            checkWhiteJiangRow8Move()
        End If
    End Sub
    Private Sub CheckBlackJiangMove()
        If (positionOne = "a1") Or (positionOne = "b1") Or (positionOne = "c1") Or (positionOne = "d1") Or (positionOne = "e1") Or (positionOne = "f1") Or (positionOne = "g1") Or (positionOne = "h1") Or (positionOne = "i1") Then
            checkBlackJiangRow1Move()
        ElseIf (positionOne = "a2") Or (positionOne = "b2") Or (positionOne = "c2") Or (positionOne = "d2") Or (positionOne = "e2") Or (positionOne = "f2") Or (positionOne = "g2") Or (positionOne = "h2") Or (positionOne = "i2") Then
            checkBlackJiangRow2Move()
        ElseIf (positionOne = "a3") Or (positionOne = "b3") Or (positionOne = "c3") Or (positionOne = "d3") Or (positionOne = "e3") Or (positionOne = "f3") Or (positionOne = "g3") Or (positionOne = "h3") Or (positionOne = "i3") Then
            checkBlackJiangRow3Move()
        End If
    End Sub
    Private Sub CheckPaoMove()
        CheckCheMove()
    End Sub
    Private Sub CheckMaMove()
        If positionOne = "a1" Then
            checkMaA1Move()
        ElseIf positionOne = "b1" Then
            checkMaB1Move()
        ElseIf positionOne = "c1" Then
            checkMaC1Move()
        ElseIf positionOne = "d1" Then
            checkMaD1Move()
        ElseIf positionOne = "e1" Then
            checkMaE1Move()
        ElseIf positionOne = "f1" Then
            checkMaF1Move()
        ElseIf positionOne = "g1" Then
            checkMaG1Move()
        ElseIf positionOne = "h1" Then
            checkMaH1Move()
        ElseIf positionOne = "i1" Then
            checkMaI1Move()
        ElseIf positionOne = "a2" Then
            checkMaA2Move()
        ElseIf positionOne = "b2" Then
            checkMaB2Move()
        ElseIf positionOne = "c2" Then
            checkMaC2Move()
        ElseIf positionOne = "d2" Then
            checkMaD2Move()
        ElseIf positionOne = "e2" Then
            checkMaE2Move()
        ElseIf positionOne = "f2" Then
            checkMaF2Move()
        ElseIf positionOne = "g2" Then
            checkMaG2Move()
        ElseIf positionOne = "h2" Then
            checkMaH2Move()
        ElseIf positionOne = "i2" Then
            checkMaI2Move()
        ElseIf positionOne = "a3" Then
            checkMaA3Move()
        ElseIf positionOne = "b3" Then
            checkMaB3Move()
        ElseIf positionOne = "c3" Then
            checkMaC3Move()
        ElseIf positionOne = "d3" Then
            checkMaD3Move()
        ElseIf positionOne = "e3" Then
            checkMaE3Move()
        ElseIf positionOne = "f3" Then
            checkMaF3Move()
        ElseIf positionOne = "g3" Then
            checkMaG3Move()
        ElseIf positionOne = "h3" Then
            checkMaH3Move()
        ElseIf positionOne = "i3" Then
            checkMaI3Move()
        ElseIf positionOne = "a4" Then
            checkMaA4Move()
        ElseIf positionOne = "b4" Then
            checkMaB4Move()
        ElseIf positionOne = "c4" Then
            checkMaC4Move()
        ElseIf positionOne = "d4" Then
            checkMaD4Move()
        ElseIf positionOne = "e4" Then
            checkMaE4Move()
        ElseIf positionOne = "f4" Then
            checkMaF4Move()
        ElseIf positionOne = "g4" Then
            checkMaG4Move()
        ElseIf positionOne = "h4" Then
            checkMaH4Move()
        ElseIf positionOne = "i4" Then
            checkMaI4Move()
        ElseIf positionOne = "a5" Then
            checkMaA5Move()
        ElseIf positionOne = "b5" Then
            checkMaB5Move()
        ElseIf positionOne = "c5" Then
            checkMaC5Move()
        ElseIf positionOne = "d5" Then
            checkMaD5Move()
        ElseIf positionOne = "e5" Then
            checkMaE5Move()
        ElseIf positionOne = "f5" Then
            checkMaF5Move()
        ElseIf positionOne = "g5" Then
            checkMaG5Move()
        ElseIf positionOne = "h5" Then
            checkMaH5Move()
        ElseIf positionOne = "i5" Then
            checkMaI5Move()
        ElseIf positionOne = "a6" Then
            checkMaA6Move()
        ElseIf positionOne = "b6" Then
            checkMaB6Move()
        ElseIf positionOne = "c6" Then
            checkMaC6Move()
        ElseIf positionOne = "d6" Then
            checkMaD6Move()
        ElseIf positionOne = "e6" Then
            checkMaE6Move()
        ElseIf positionOne = "f6" Then
            checkMaF6Move()
        ElseIf positionOne = "g6" Then
            checkMaG6Move()
        ElseIf positionOne = "h6" Then
            checkMaH6Move()
        ElseIf positionOne = "i6" Then
            checkMaI6Move()
        ElseIf positionOne = "a7" Then
            checkMaA7Move()
        ElseIf positionOne = "b7" Then
            checkMaB7Move()
        ElseIf positionOne = "c7" Then
            checkMaC7Move()
        ElseIf positionOne = "d7" Then
            checkMaD7Move()
        ElseIf positionOne = "e7" Then
            checkMaE7Move()
        ElseIf positionOne = "f7" Then
            checkMaF7Move()
        ElseIf positionOne = "g7" Then
            checkMaG7Move()
        ElseIf positionOne = "h7" Then
            checkMaH7Move()
        ElseIf positionOne = "i7" Then
            checkMaI7Move()
        ElseIf positionOne = "a8" Then
            checkMaA8Move()
        ElseIf positionOne = "b8" Then
            checkMaB8Move()
        ElseIf positionOne = "c8" Then
            checkMaC8Move()
        ElseIf positionOne = "d8" Then
            checkMaD8Move()
        ElseIf positionOne = "e8" Then
            checkMaE8Move()
        ElseIf positionOne = "f8" Then
            checkMaF8Move()
        ElseIf positionOne = "g8" Then
            checkMaG8Move()
        ElseIf positionOne = "h8" Then
            checkMaH8Move()
        ElseIf positionOne = "i8" Then
            checkMaI8Move()
        ElseIf positionOne = "a9" Then
            checkMaA9Move()
        ElseIf positionOne = "b9" Then
            checkMaB9Move()
        ElseIf positionOne = "c9" Then
            checkMaC9Move()
        ElseIf positionOne = "d9" Then
            checkMaD9Move()
        ElseIf positionOne = "e9" Then
            checkMaE9Move()
        ElseIf positionOne = "f9" Then
            checkMaF9Move()
        ElseIf positionOne = "g9" Then
            checkMaG9Move()
        ElseIf positionOne = "h9" Then
            checkMaH9Move()
        ElseIf positionOne = "i9" Then
            checkMaI9Move()
        ElseIf positionOne = "a10" Then
            checkMaA10Move()
        ElseIf positionOne = "b10" Then
            checkMaB10Move()
        ElseIf positionOne = "c10" Then
            checkMaC10Move()
        ElseIf positionOne = "d10" Then
            checkMaD10Move()
        ElseIf positionOne = "e10" Then
            checkMaE10Move()
        ElseIf positionOne = "f10" Then
            checkMaF10Move()
        ElseIf positionOne = "g10" Then
            checkMaG10Move()
        ElseIf positionOne = "h10" Then
            checkMaH10Move()
        ElseIf positionOne = "i10" Then
            checkMaI10Move()
        End If
    End Sub
    Private Sub CheckWhiteXiangMove()
        If (positionOne = "c10") Or (positionOne = "g10") Then
            checkWhiteXiangRow10Move()
        ElseIf (positionOne = "a8") Or (positionOne = "e8") Or (positionOne = "i8") Then
            checkWhiteXiangRow8Move()
        ElseIf (positionOne = "c6") Or (positionOne = "g6") Then
            checkWhiteXiangRow6Move()
        End If
    End Sub
    Private Sub CheckBlackXiangMove()
        If (positionOne = "c1") Or (positionOne = "g1") Then
            checkBlackXiangRow1Move()
        ElseIf (positionOne = "a3") Or (positionOne = "e3") Or (positionOne = "i3") Then
            checkBlackXiangRow3Move()
        ElseIf (positionOne = "c5") Or (positionOne = "g5") Then
            checkBlackXiangRow5Move()
        End If
    End Sub
    Private Sub CheckWhiteShiMove()
        If (positionOne = "d10") Or (positionOne = "f10") Then
            checkWhiteShiRow10Move()
        ElseIf (positionOne = "e9") Then
            checkWhiteShiRow9Move()
        ElseIf (positionOne = "d8") Or (positionOne = "f8") Then
            checkWhiteShiRow8Move()
        End If
    End Sub
    Private Sub CheckBlackShiMove()
        If (positionOne = "d1") Or (positionOne = "f1") Then
            checkBlackShiRow1Move()
        ElseIf (positionOne = "e2") Then
            checkBlackShiRow2Move()
        ElseIf (positionOne = "d3") Or (positionOne = "f3") Then
            checkBlackShiRow3Move()
        End If
    End Sub

    Private Sub CheckChePaoBlock()
        Select Case (positionOne)
            Case "a1"
                If positionOneTwo = "a1a2" Then
                    checkChePaoA1A2Block()
                ElseIf positionOneTwo = "a1a3" Then
                    checkChePaoA1A3Block()
                ElseIf positionOneTwo = "a1a4" Then
                    checkChePaoA1A4Block()
                ElseIf positionOneTwo = "a1a5" Then
                    checkChePaoA1A5Block()
                ElseIf positionOneTwo = "a1a6" Then
                    checkChePaoA1A6Block()
                ElseIf positionOneTwo = "a1a7" Then
                    checkChePaoA1A7Block()
                ElseIf positionOneTwo = "a1a8" Then
                    checkChePaoA1A8Block()
                ElseIf positionOneTwo = "a1a9" Then
                    checkChePaoA1A9Block()
                ElseIf positionOneTwo = "a1a10" Then
                    checkChePaoA1A10Block()
                ElseIf positionOneTwo = "a1c1" Then
                    checkChePaoA1C1Block()
                ElseIf positionOneTwo = "a1d1" Then
                    checkChePaoA1D1Block()
                ElseIf positionOneTwo = "a1e1" Then
                    checkChePaoA1E1Block()
                ElseIf positionOneTwo = "a1f1" Then
                    checkChePaoA1F1Block()
                ElseIf positionOneTwo = "a1g1" Then
                    checkChePaoA1G1Block()
                ElseIf positionOneTwo = "a1h1" Then
                    checkChePaoA1H1Block()
                ElseIf positionOneTwo = "a1i1" Then
                    checkChePaoA1I1Block()
                End If
            Case "b1"
                If positionOneTwo = "b1b2" Then
                    checkChePaoB1B2Block()
                ElseIf positionOneTwo = "b1b3" Then
                    checkChePaoB1B3Block()
                ElseIf positionOneTwo = "b1b4" Then
                    checkChePaoB1B4Block()
                ElseIf positionOneTwo = "b1b5" Then
                    checkChePaoB1B5Block()
                ElseIf positionOneTwo = "b1b6" Then
                    checkChePaoB1B6Block()
                ElseIf positionOneTwo = "b1b7" Then
                    checkChePaoB1B7Block()
                ElseIf positionOneTwo = "b1b8" Then
                    checkChePaoB1B8Block()
                ElseIf positionOneTwo = "b1b9" Then
                    checkChePaoB1B9Block()
                ElseIf positionOneTwo = "b1b10" Then
                    checkChePaoB1B10Block()
                ElseIf positionOneTwo = "b1d1" Then
                    checkChePaoB1D1Block()
                ElseIf positionOneTwo = "b1e1" Then
                    checkChePaoB1E1Block()
                ElseIf positionOneTwo = "b1f1" Then
                    checkChePaoB1F1Block()
                ElseIf positionOneTwo = "b1g1" Then
                    checkChePaoB1G1Block()
                ElseIf positionOneTwo = "b1h1" Then
                    checkChePaoB1H1Block()
                ElseIf positionOneTwo = "b1i1" Then
                    checkChePaoB1I1Block()
                End If
            Case "c1"
                If positionOneTwo = "c1c3" Then
                    checkChePaoC1C3Block()
                ElseIf positionOneTwo = "c1c4" Then
                    checkChePaoC1C4Block()
                ElseIf positionOneTwo = "c1c5" Then
                    checkChePaoC1C5Block()
                ElseIf positionOneTwo = "c1c6" Then
                    checkChePaoC1C6Block()
                ElseIf positionOneTwo = "c1c7" Then
                    checkChePaoC1C7Block()
                ElseIf positionOneTwo = "c1c8" Then
                    checkChePaoC1C8Block()
                ElseIf positionOneTwo = "c1c9" Then
                    checkChePaoC1C9Block()
                ElseIf positionOneTwo = "c1c10" Then
                    checkChePaoC1C10Block()
                ElseIf positionOneTwo = "c1a1" Then
                    checkChePaoC1A1Block()
                ElseIf positionOneTwo = "c1e1" Then
                    checkChePaoC1E1Block()
                ElseIf positionOneTwo = "c1f1" Then
                    checkChePaoC1F1Block()
                ElseIf positionOneTwo = "c1g1" Then
                    checkChePaoC1G1Block()
                ElseIf positionOneTwo = "c1h1" Then
                    checkChePaoC1H1Block()
                ElseIf positionOneTwo = "c1i1" Then
                    checkChePaoC1I1Block()
                End If
            Case "d1"
                If positionOneTwo = "d1d3" Then
                    checkChePaoD1D3Block()
                ElseIf positionOneTwo = "d1d4" Then
                    checkChePaoD1D4Block()
                ElseIf positionOneTwo = "d1d5" Then
                    checkChePaoD1D5Block()
                ElseIf positionOneTwo = "d1d6" Then
                    checkChePaoD1D6Block()
                ElseIf positionOneTwo = "d1d7" Then
                    checkChePaoD1D7Block()
                ElseIf positionOneTwo = "d1d8" Then
                    checkChePaoD1D8Block()
                ElseIf positionOneTwo = "d1d9" Then
                    checkChePaoD1D9Block()
                ElseIf positionOneTwo = "d1d10" Then
                    checkChePaoD1D10Block()
                ElseIf positionOneTwo = "d1a1" Then
                    checkChePaoD1A1Block()
                ElseIf positionOneTwo = "d1b1" Then
                    checkChePaoD1B1Block()
                ElseIf positionOneTwo = "d1f1" Then
                    checkChePaoD1F1Block()
                ElseIf positionOneTwo = "d1g1" Then
                    checkChePaoD1G1Block()
                ElseIf positionOneTwo = "d1h1" Then
                    checkChePaoD1H1Block()
                ElseIf positionOneTwo = "d1i1" Then
                    checkChePaoD1I1Block()
                End If
            Case "e1"
                If positionOneTwo = "e1e3" Then
                    checkChePaoE1E3Block()
                ElseIf positionOneTwo = "e1e4" Then
                    checkChePaoE1E4Block()
                ElseIf positionOneTwo = "e1e5" Then
                    checkChePaoE1E5Block()
                ElseIf positionOneTwo = "e1e6" Then
                    checkChePaoE1E6Block()
                ElseIf positionOneTwo = "e1e7" Then
                    checkChePaoE1E7Block()
                ElseIf positionOneTwo = "e1e8" Then
                    checkChePaoE1E8Block()
                ElseIf positionOneTwo = "e1e9" Then
                    checkChePaoE1E9Block()
                ElseIf positionOneTwo = "e1e10" Then
                    checkChePaoE1E10Block()
                ElseIf positionOneTwo = "e1a1" Then
                    checkChePaoE1A1Block()
                ElseIf positionOneTwo = "e1b1" Then
                    checkChePaoE1B1Block()
                ElseIf positionOneTwo = "e1c1" Then
                    checkChePaoE1C1Block()
                ElseIf positionOneTwo = "e1g1" Then
                    checkChePaoE1G1Block()
                ElseIf positionOneTwo = "e1h1" Then
                    checkChePaoE1H1Block()
                ElseIf positionOneTwo = "e1i1" Then
                    checkChePaoE1I1Block()
                End If
            Case "f1"
                If positionOneTwo = "f1f3" Then
                    checkChePaoF1F3Block()
                ElseIf positionOneTwo = "f1f4" Then
                    checkChePaoF1F4Block()
                ElseIf positionOneTwo = "f1f5" Then
                    checkChePaoF1F5Block()
                ElseIf positionOneTwo = "f1f6" Then
                    checkChePaoF1F6Block()
                ElseIf positionOneTwo = "f1f7" Then
                    checkChePaoF1F7Block()
                ElseIf positionOneTwo = "f1f8" Then
                    checkChePaoF1F8Block()
                ElseIf positionOneTwo = "f1f9" Then
                    checkChePaoF1F9Block()
                ElseIf positionOneTwo = "f1f10" Then
                    checkChePaoF1F10Block()
                ElseIf positionOneTwo = "f1a1" Then
                    checkChePaoF1A1Block()
                ElseIf positionOneTwo = "f1b1" Then
                    checkChePaoF1B1Block()
                ElseIf positionOneTwo = "f1c1" Then
                    checkChePaoF1C1Block()
                ElseIf positionOneTwo = "f1d1" Then
                    checkChePaoF1D1Block()
                ElseIf positionOneTwo = "f1h1" Then
                    checkChePaoF1H1Block()
                ElseIf positionOneTwo = "f1i1" Then
                    checkChePaoF1I1Block()
                End If
            Case "g1"
                If positionOneTwo = "g1g3" Then
                    checkChePaoG1G3Block()
                ElseIf positionOneTwo = "g1g4" Then
                    checkChePaoG1G4Block()
                ElseIf positionOneTwo = "g1g5" Then
                    checkChePaoG1G5Block()
                ElseIf positionOneTwo = "g1g6" Then
                    checkChePaoG1G6Block()
                ElseIf positionOneTwo = "g1g7" Then
                    checkChePaoG1G7Block()
                ElseIf positionOneTwo = "g1g8" Then
                    checkChePaoG1G8Block()
                ElseIf positionOneTwo = "g1g9" Then
                    checkChePaoG1G9Block()
                ElseIf positionOneTwo = "g1g10" Then
                    checkChePaoG1G10Block()
                ElseIf positionOneTwo = "g1a1" Then
                    checkChePaoG1A1Block()
                ElseIf positionOneTwo = "g1b1" Then
                    checkChePaoG1B1Block()
                ElseIf positionOneTwo = "g1c1" Then
                    checkChePaoG1C1Block()
                ElseIf positionOneTwo = "g1d1" Then
                    checkChePaoG1D1Block()
                ElseIf positionOneTwo = "g1e1" Then
                    checkChePaoG1E1Block()
                ElseIf positionOneTwo = "g1i1" Then
                    checkChePaoG1I1Block()
                End If
            Case "h1"
                If positionOneTwo = "h1h3" Then
                    checkChePaoH1H3Block()
                ElseIf positionOneTwo = "h1h4" Then
                    checkChePaoH1H4Block()
                ElseIf positionOneTwo = "h1h5" Then
                    checkChePaoH1H5Block()
                ElseIf positionOneTwo = "h1h6" Then
                    checkChePaoH1H6Block()
                ElseIf positionOneTwo = "h1h7" Then
                    checkChePaoH1H7Block()
                ElseIf positionOneTwo = "h1h8" Then
                    checkChePaoH1H8Block()
                ElseIf positionOneTwo = "h1h9" Then
                    checkChePaoH1H9Block()
                ElseIf positionOneTwo = "h1h10" Then
                    checkChePaoH1H10Block()
                ElseIf positionOneTwo = "h1a1" Then
                    checkChePaoH1A1Block()
                ElseIf positionOneTwo = "h1b1" Then
                    checkChePaoH1B1Block()
                ElseIf positionOneTwo = "h1c1" Then
                    checkChePaoH1C1Block()
                ElseIf positionOneTwo = "h1d1" Then
                    checkChePaoH1D1Block()
                ElseIf positionOneTwo = "h1e1" Then
                    checkChePaoH1E1Block()
                ElseIf positionOneTwo = "h1f1" Then
                    checkChePaoH1F1Block()
                End If
            Case "i1"
                If positionOneTwo = "i1i3" Then
                    checkChePaoI1I3Block()
                ElseIf positionOneTwo = "i1i4" Then
                    checkChePaoI1I4Block()
                ElseIf positionOneTwo = "i1i5" Then
                    checkChePaoI1I5Block()
                ElseIf positionOneTwo = "i1i6" Then
                    checkChePaoI1I6Block()
                ElseIf positionOneTwo = "i1i7" Then
                    checkChePaoI1I7Block()
                ElseIf positionOneTwo = "i1i8" Then
                    checkChePaoI1I8Block()
                ElseIf positionOneTwo = "i1i9" Then
                    checkChePaoI1I9Block()
                ElseIf positionOneTwo = "i1i10" Then
                    checkChePaoI1I10Block()
                ElseIf positionOneTwo = "i1a1" Then
                    checkChePaoI1A1Block()
                ElseIf positionOneTwo = "i1b1" Then
                    checkChePaoI1B1Block()
                ElseIf positionOneTwo = "i1c1" Then
                    checkChePaoI1C1Block()
                ElseIf positionOneTwo = "i1d1" Then
                    checkChePaoI1D1Block()
                ElseIf positionOneTwo = "i1e1" Then
                    checkChePaoI1E1Block()
                ElseIf positionOneTwo = "i1f1" Then
                    checkChePaoI1F1Block()
                ElseIf positionOneTwo = "i1g1" Then
                    checkChePaoI1G1Block()
                End If
            Case "a2"
                If positionOneTwo = "a2a4" Then
                    checkChePaoA2A4Block()
                ElseIf positionOneTwo = "a2a5" Then
                    checkChePaoA2A5Block()
                ElseIf positionOneTwo = "a2a6" Then
                    checkChePaoA2A6Block()
                ElseIf positionOneTwo = "a2a7" Then
                    checkChePaoA2A7Block()
                ElseIf positionOneTwo = "a2a8" Then
                    checkChePaoA2A8Block()
                ElseIf positionOneTwo = "a2a9" Then
                    checkChePaoA2A9Block()
                ElseIf positionOneTwo = "a2a10" Then
                    checkChePaoA2A10Block()
                ElseIf positionOneTwo = "a2c2" Then
                    checkChePaoA2C2Block()
                ElseIf positionOneTwo = "a2d2" Then
                    checkChePaoA2D2Block()
                ElseIf positionOneTwo = "a2e2" Then
                    checkChePaoA2E2Block()
                ElseIf positionOneTwo = "a2f2" Then
                    checkChePaoA2F2Block()
                ElseIf positionOneTwo = "a2g2" Then
                    checkChePaoA2G2Block()
                ElseIf positionOneTwo = "a2h2" Then
                    checkChePaoA2H2Block()
                ElseIf positionOneTwo = "a2i2" Then
                    checkChePaoA2I2Block()
                End If
            Case "b2"
                If positionOneTwo = "b2b4" Then
                    checkChePaoB2B4Block()
                ElseIf positionOneTwo = "b2b5" Then
                    checkChePaoB2B5Block()
                ElseIf positionOneTwo = "b2b6" Then
                    checkChePaoB2B6Block()
                ElseIf positionOneTwo = "b2b7" Then
                    checkChePaoB2B7Block()
                ElseIf positionOneTwo = "b2b8" Then
                    checkChePaoB2B8Block()
                ElseIf positionOneTwo = "b2b9" Then
                    checkChePaoB2B9Block()
                ElseIf positionOneTwo = "b2b10" Then
                    checkChePaoB2B10Block()
                ElseIf positionOneTwo = "b2d2" Then
                    checkChePaoB2D2Block()
                ElseIf positionOneTwo = "b2e2" Then
                    checkChePaoB2E2Block()
                ElseIf positionOneTwo = "b2f2" Then
                    checkChePaoB2F2Block()
                ElseIf positionOneTwo = "b2g2" Then
                    checkChePaoB2G2Block()
                ElseIf positionOneTwo = "b2h2" Then
                    checkChePaoB2H2Block()
                ElseIf positionOneTwo = "b2i2" Then
                    checkChePaoB2I2Block()
                End If
            Case "c2"
                If positionOneTwo = "c2c4" Then
                    checkChePaoC2C4Block()
                ElseIf positionOneTwo = "c2c5" Then
                    checkChePaoC2C5Block()
                ElseIf positionOneTwo = "c2c6" Then
                    checkChePaoC2C6Block()
                ElseIf positionOneTwo = "c2c7" Then
                    checkChePaoC2C7Block()
                ElseIf positionOneTwo = "c2c8" Then
                    checkChePaoC2C8Block()
                ElseIf positionOneTwo = "c2c9" Then
                    checkChePaoC2C9Block()
                ElseIf positionOneTwo = "c2c10" Then
                    checkChePaoC2C10Block()
                ElseIf positionOneTwo = "c2a2" Then
                    checkChePaoC2A2Block()
                ElseIf positionOneTwo = "c2e2" Then
                    checkChePaoC2E2Block()
                ElseIf positionOneTwo = "c2f2" Then
                    checkChePaoC2F2Block()
                ElseIf positionOneTwo = "c2g2" Then
                    checkChePaoC2G2Block()
                ElseIf positionOneTwo = "c2h2" Then
                    checkChePaoC2H2Block()
                ElseIf positionOneTwo = "c2i2" Then
                    checkChePaoC2I2Block()
                End If
            Case "d2"
                If positionOneTwo = "d2d4" Then
                    checkChePaoD2D4Block()
                ElseIf positionOneTwo = "d2d5" Then
                    checkChePaoD2D5Block()
                ElseIf positionOneTwo = "d2d6" Then
                    checkChePaoD2D6Block()
                ElseIf positionOneTwo = "d2d7" Then
                    checkChePaoD2D7Block()
                ElseIf positionOneTwo = "d2d8" Then
                    checkChePaoD2D8Block()
                ElseIf positionOneTwo = "d2d9" Then
                    checkChePaoD2D9Block()
                ElseIf positionOneTwo = "d2d10" Then
                    checkChePaoD2D10Block()
                ElseIf positionOneTwo = "d2a2" Then
                    checkChePaoD2A2Block()
                ElseIf positionOneTwo = "d2b2" Then
                    checkChePaoD2B2Block()
                ElseIf positionOneTwo = "d2f2" Then
                    checkChePaoD2F2Block()
                ElseIf positionOneTwo = "d2g2" Then
                    checkChePaoD2G2Block()
                ElseIf positionOneTwo = "d2h2" Then
                    checkChePaoD2H2Block()
                ElseIf positionOneTwo = "d2i2" Then
                    checkChePaoD2I2Block()
                End If
            Case ("e2")
                If positionOneTwo = "e2e4" Then
                    checkChePaoE2E4Block()
                ElseIf positionOneTwo = "e2e5" Then
                    checkChePaoE2E5Block()
                ElseIf positionOneTwo = "e2e6" Then
                    checkChePaoE2E6Block()
                ElseIf positionOneTwo = "e2e7" Then
                    checkChePaoE2E7Block()
                ElseIf positionOneTwo = "e2e8" Then
                    checkChePaoE2E8Block()
                ElseIf positionOneTwo = "e2e9" Then
                    checkChePaoE2E9Block()
                ElseIf positionOneTwo = "e2e10" Then
                    checkChePaoE2E10Block()
                ElseIf positionOneTwo = "e2a2" Then
                    checkChePaoE2A2Block()
                ElseIf positionOneTwo = "e2b2" Then
                    checkChePaoE2B2Block()
                ElseIf positionOneTwo = "e2c2" Then
                    checkChePaoE2C2Block()
                ElseIf positionOneTwo = "e2g2" Then
                    checkChePaoE2G2Block()
                ElseIf positionOneTwo = "e2h2" Then
                    checkChePaoE2H2Block()
                ElseIf positionOneTwo = "e2i2" Then
                    checkChePaoE2I2Block()
                End If
            Case "f2"
                If positionOneTwo = "f2f4" Then
                    checkChePaoF2F4Block()
                ElseIf positionOneTwo = "f2f5" Then
                    checkChePaoF2F5Block()
                ElseIf positionOneTwo = "f2f6" Then
                    checkChePaoF2F6Block()
                ElseIf positionOneTwo = "f2f7" Then
                    checkChePaoF2F7Block()
                ElseIf positionOneTwo = "f2f8" Then
                    checkChePaoF2F8Block()
                ElseIf positionOneTwo = "f2f9" Then
                    checkChePaoF2F9Block()
                ElseIf positionOneTwo = "f2f10" Then
                    checkChePaoF2F10Block()
                ElseIf positionOneTwo = "f2a2" Then
                    checkChePaoF2A2Block()
                ElseIf positionOneTwo = "f2b2" Then
                    checkChePaoF2B2Block()
                ElseIf positionOneTwo = "f2c2" Then
                    checkChePaoF2C2Block()
                ElseIf positionOneTwo = "f2d2" Then
                    checkChePaoF2D2Block()
                ElseIf positionOneTwo = "f2h2" Then
                    checkChePaoF2H2Block()
                ElseIf positionOneTwo = "f2i2" Then
                    checkChePaoF2I2Block()
                End If
            Case "g2"
                If positionOneTwo = "g2g4" Then
                    checkChePaoG2G4Block()
                ElseIf positionOneTwo = "g2g5" Then
                    checkChePaoG2G5Block()
                ElseIf positionOneTwo = "g2g6" Then
                    checkChePaoG2G6Block()
                ElseIf positionOneTwo = "g2g7" Then
                    checkChePaoG2G7Block()
                ElseIf positionOneTwo = "g2g8" Then
                    checkChePaoG2G8Block()
                ElseIf positionOneTwo = "g2g9" Then
                    checkChePaoG2G9Block()
                ElseIf positionOneTwo = "g2g10" Then
                    checkChePaoG2G10Block()
                ElseIf positionOneTwo = "g2a2" Then
                    checkChePaoG2A2Block()
                ElseIf positionOneTwo = "g2b2" Then
                    checkChePaoG2B2Block()
                ElseIf positionOneTwo = "g2c2" Then
                    checkChePaoG2C2Block()
                ElseIf positionOneTwo = "g2d2" Then
                    checkChePaoG2D2Block()
                ElseIf positionOneTwo = "g2e2" Then
                    checkChePaoG2E2Block()
                ElseIf positionOneTwo = "g2i2" Then
                    checkChePaoG2I2Block()
                End If
            Case "h2"
                If positionOneTwo = "h2h4" Then
                    checkChePaoH2H4Block()
                ElseIf positionOneTwo = "h2h5" Then
                    checkChePaoH2H5Block()
                ElseIf positionOneTwo = "h2h6" Then
                    checkChePaoH2H6Block()
                ElseIf positionOneTwo = "h2h7" Then
                    checkChePaoH2H7Block()
                ElseIf positionOneTwo = "h2h8" Then
                    checkChePaoH2H8Block()
                ElseIf positionOneTwo = "h2h9" Then
                    checkChePaoH2H9Block()
                ElseIf positionOneTwo = "h2h10" Then
                    checkChePaoH2H10Block()
                ElseIf positionOneTwo = "h2a2" Then
                    checkChePaoH2A2Block()
                ElseIf positionOneTwo = "h2b2" Then
                    checkChePaoH2B2Block()
                ElseIf positionOneTwo = "h2c2" Then
                    checkChePaoH2C2Block()
                ElseIf positionOneTwo = "h2d2" Then
                    checkChePaoH2D2Block()
                ElseIf positionOneTwo = "h2e2" Then
                    checkChePaoH2E2Block()
                ElseIf positionOneTwo = "h2f2" Then
                    checkChePaoH2F2Block()
                End If
            Case "i2"
                If positionOneTwo = "i2i4" Then
                    checkChePaoI2I4Block()
                ElseIf positionOneTwo = "i2i5" Then
                    checkChePaoI2I5Block()
                ElseIf positionOneTwo = "i2i6" Then
                    checkChePaoI2I6Block()
                ElseIf positionOneTwo = "i2i7" Then
                    checkChePaoI2I7Block()
                ElseIf positionOneTwo = "i2i8" Then
                    checkChePaoI2I8Block()
                ElseIf positionOneTwo = "i2i9" Then
                    checkChePaoI2I9Block()
                ElseIf positionOneTwo = "i2i10" Then
                    checkChePaoI2I10Block()
                ElseIf positionOneTwo = "i2a2" Then
                    checkChePaoI2A2Block()
                ElseIf positionOneTwo = "i2b2" Then
                    checkChePaoI2B2Block()
                ElseIf positionOneTwo = "i2c2" Then
                    checkChePaoI2C2Block()
                ElseIf positionOneTwo = "i2d2" Then
                    checkChePaoI2D2Block()
                ElseIf positionOneTwo = "i2e2" Then
                    checkChePaoI2E2Block()
                ElseIf positionOneTwo = "i2f2" Then
                    checkChePaoI2F2Block()
                ElseIf positionOneTwo = "i2g2" Then
                    checkChePaoI2G2Block()
                End If
            Case "a3"
                If positionOneTwo = "a3a1" Then
                    checkChePaoA3A1Block()
                ElseIf positionOneTwo = "a3a5" Then
                    checkChePaoA3A5Block()
                ElseIf positionOneTwo = "a3a6" Then
                    checkChePaoA3A6Block()
                ElseIf positionOneTwo = "a3a7" Then
                    checkChePaoA3A7Block()
                ElseIf positionOneTwo = "a3a8" Then
                    checkChePaoA3A8Block()
                ElseIf positionOneTwo = "a3a9" Then
                    checkChePaoA3A9Block()
                ElseIf positionOneTwo = "a3a10" Then
                    checkChePaoA3A10Block()
                ElseIf positionOneTwo = "a3c3" Then
                    checkChePaoA3C3Block()
                ElseIf positionOneTwo = "a3d3" Then
                    checkChePaoA3D3Block()
                ElseIf positionOneTwo = "a3e3" Then
                    checkChePaoA3E3Block()
                ElseIf positionOneTwo = "a3f3" Then
                    checkChePaoA3F3Block()
                ElseIf positionOneTwo = "a3g3" Then
                    checkChePaoA3G3Block()
                ElseIf positionOneTwo = "a3h3" Then
                    checkChePaoA3H3Block()
                ElseIf positionOneTwo = "a3i3" Then
                    checkChePaoA3I3Block()
                End If
            Case "b3"
                If positionOneTwo = "b3b1" Then
                    checkChePaoB3B1Block()
                ElseIf positionOneTwo = "b3b5" Then
                    checkChePaoB3B5Block()
                ElseIf positionOneTwo = "b3b6" Then
                    checkChePaoB3B6Block()
                ElseIf positionOneTwo = "b3b7" Then
                    checkChePaoB3B7Block()
                ElseIf positionOneTwo = "b3b8" Then
                    checkChePaoB3B8Block()
                ElseIf positionOneTwo = "b3b9" Then
                    checkChePaoB3B9Block()
                ElseIf positionOneTwo = "b3b10" Then
                    checkChePaoB3B10Block()
                ElseIf positionOneTwo = "b3d3" Then
                    checkChePaoB3D3Block()
                ElseIf positionOneTwo = "b3e3" Then
                    checkChePaoB3E3Block()
                ElseIf positionOneTwo = "b3f3" Then
                    checkChePaoB3F3Block()
                ElseIf positionOneTwo = "b3g3" Then
                    checkChePaoB3G3Block()
                ElseIf positionOneTwo = "b3h3" Then
                    checkChePaoB3H3Block()
                ElseIf positionOneTwo = "b3i3" Then
                    checkChePaoB3I3Block()
                End If
            Case "c3"
                If positionOneTwo = "c3c1" Then
                    checkChePaoC3C1Block()
                ElseIf positionOneTwo = "c3c5" Then
                    checkChePaoC3C5Block()
                ElseIf positionOneTwo = "c3c6" Then
                    checkChePaoC3C6Block()
                ElseIf positionOneTwo = "c3c7" Then
                    checkChePaoC3C7Block()
                ElseIf positionOneTwo = "c3c8" Then
                    checkChePaoC3C8Block()
                ElseIf positionOneTwo = "c3c9" Then
                    checkChePaoC3C9Block()
                ElseIf positionOneTwo = "c3c10" Then
                    checkChePaoC3C10Block()
                ElseIf positionOneTwo = "c3a3" Then
                    checkChePaoC3A3Block()
                ElseIf positionOneTwo = "c3e3" Then
                    checkChePaoC3E3Block()
                ElseIf positionOneTwo = "c3f3" Then
                    checkChePaoC3F3Block()
                ElseIf positionOneTwo = "c3g3" Then
                    checkChePaoC3G3Block()
                ElseIf positionOneTwo = "c3h3" Then
                    checkChePaoC3H3Block()
                ElseIf positionOneTwo = "c3i3" Then
                    checkChePaoC3I3Block()
                End If
            Case "d3"
                If positionOneTwo = "d3d1" Then
                    checkChePaoD3D1Block()
                ElseIf positionOneTwo = "d3d5" Then
                    checkChePaoD3D5Block()
                ElseIf positionOneTwo = "d3d6" Then
                    checkChePaoD3D6Block()
                ElseIf positionOneTwo = "d3d7" Then
                    checkChePaoD3D7Block()
                ElseIf positionOneTwo = "d3d8" Then
                    checkChePaoD3D8Block()
                ElseIf positionOneTwo = "d3d9" Then
                    checkChePaoD3D9Block()
                ElseIf positionOneTwo = "d3d10" Then
                    checkChePaoD3D10Block()
                ElseIf positionOneTwo = "d3a3" Then
                    checkChePaoD3A3Block()
                ElseIf positionOneTwo = "d3b3" Then
                    checkChePaoD3B3Block()
                ElseIf positionOneTwo = "d3f3" Then
                    checkChePaoD3F3Block()
                ElseIf positionOneTwo = "d3g3" Then
                    checkChePaoD3G3Block()
                ElseIf positionOneTwo = "d3h3" Then
                    checkChePaoD3H3Block()
                ElseIf positionOneTwo = "d3i3" Then
                    checkChePaoD3I3Block()
                End If
            Case "e3"
                If positionOneTwo = "e3e1" Then
                    checkChePaoE3E1Block()
                ElseIf positionOneTwo = "e3e5" Then
                    checkChePaoE3E5Block()
                ElseIf positionOneTwo = "e3e6" Then
                    checkChePaoE3E6Block()
                ElseIf positionOneTwo = "e3e7" Then
                    checkChePaoE3E7Block()
                ElseIf positionOneTwo = "e3e8" Then
                    checkChePaoE3E8Block()
                ElseIf positionOneTwo = "e3e9" Then
                    checkChePaoE3E9Block()
                ElseIf positionOneTwo = "e3e10" Then
                    checkChePaoE3E10Block()
                ElseIf positionOneTwo = "e3a3" Then
                    checkChePaoE3A3Block()
                ElseIf positionOneTwo = "e3b3" Then
                    checkChePaoE3B3Block()
                ElseIf positionOneTwo = "e3c3" Then
                    checkChePaoE3C3Block()
                ElseIf positionOneTwo = "e3g3" Then
                    checkChePaoE3G3Block()
                ElseIf positionOneTwo = "e3h3" Then
                    checkChePaoE3H3Block()
                ElseIf positionOneTwo = "e3i3" Then
                    checkChePaoE3I3Block()
                End If
            Case "f3"
                If positionOneTwo = "f3f1" Then
                    checkChePaoF3F1Block()
                ElseIf positionOneTwo = "f3f5" Then
                    checkChePaoF3F5Block()
                ElseIf positionOneTwo = "f3f6" Then
                    checkChePaoF3F6Block()
                ElseIf positionOneTwo = "f3f7" Then
                    checkChePaoF3F7Block()
                ElseIf positionOneTwo = "f3f8" Then
                    checkChePaoF3F8Block()
                ElseIf positionOneTwo = "f3f9" Then
                    checkChePaoF3F9Block()
                ElseIf positionOneTwo = "f3f10" Then
                    checkChePaoF3F10Block()
                ElseIf positionOneTwo = "f3a3" Then
                    checkChePaoF3A3Block()
                ElseIf positionOneTwo = "f3b3" Then
                    checkChePaoF3B3Block()
                ElseIf positionOneTwo = "f3c3" Then
                    checkChePaoF3C3Block()
                ElseIf positionOneTwo = "f3d3" Then
                    checkChePaoF3D3Block()
                ElseIf positionOneTwo = "f3h3" Then
                    checkChePaoF3H3Block()
                ElseIf positionOneTwo = "f3i3" Then
                    checkChePaoF3I3Block()
                End If
            Case "g3"
                If positionOneTwo = "g3g1" Then
                    checkChePaoG3G1Block()
                ElseIf positionOneTwo = "g3g5" Then
                    checkChePaoG3G5Block()
                ElseIf positionOneTwo = "g3g6" Then
                    checkChePaoG3G6Block()
                ElseIf positionOneTwo = "g3g7" Then
                    checkChePaoG3G7Block()
                ElseIf positionOneTwo = "g3g8" Then
                    checkChePaoG3G8Block()
                ElseIf positionOneTwo = "g3g9" Then
                    checkChePaoG3G9Block()
                ElseIf positionOneTwo = "g3g10" Then
                    checkChePaoG3G10Block()
                ElseIf positionOneTwo = "g3a3" Then
                    checkChePaoG3A3Block()
                ElseIf positionOneTwo = "g3b3" Then
                    checkChePaoG3B3Block()
                ElseIf positionOneTwo = "g3c3" Then
                    checkChePaoG3C3Block()
                ElseIf positionOneTwo = "g3d3" Then
                    checkChePaoG3D3Block()
                ElseIf positionOneTwo = "g3e3" Then
                    checkChePaoG3E3Block()
                ElseIf positionOneTwo = "g3i3" Then
                    checkChePaoG3I3Block()
                End If
            Case "h3"
                If positionOneTwo = "h3h1" Then
                    checkChePaoH3H1Block()
                ElseIf positionOneTwo = "h3h5" Then
                    checkChePaoH3H5Block()
                ElseIf positionOneTwo = "h3h6" Then
                    checkChePaoH3H6Block()
                ElseIf positionOneTwo = "h3h7" Then
                    checkChePaoH3H7Block()
                ElseIf positionOneTwo = "h3h8" Then
                    checkChePaoH3H8Block()
                ElseIf positionOneTwo = "h3h9" Then
                    checkChePaoH3H9Block()
                ElseIf positionOneTwo = "h3h10" Then
                    checkChePaoH3H10Block()
                ElseIf positionOneTwo = "h3a3" Then
                    checkChePaoH3A3Block()
                ElseIf positionOneTwo = "h3b3" Then
                    checkChePaoH3B3Block()
                ElseIf positionOneTwo = "h3c3" Then
                    checkChePaoH3C3Block()
                ElseIf positionOneTwo = "h3d3" Then
                    checkChePaoH3D3Block()
                ElseIf positionOneTwo = "h3e3" Then
                    checkChePaoH3E3Block()
                ElseIf positionOneTwo = "h3f3" Then
                    checkChePaoH3F3Block()
                End If
            Case "i3"
                If positionOneTwo = "i3i1" Then
                    checkChePaoI3I1Block()
                ElseIf positionOneTwo = "i3i5" Then
                    checkChePaoI3I5Block()
                ElseIf positionOneTwo = "i3i6" Then
                    checkChePaoI3I6Block()
                ElseIf positionOneTwo = "i3i7" Then
                    checkChePaoI3I7Block()
                ElseIf positionOneTwo = "i3i8" Then
                    checkChePaoI3I8Block()
                ElseIf positionOneTwo = "i3i9" Then
                    checkChePaoI3I9Block()
                ElseIf positionOneTwo = "i3i10" Then
                    checkChePaoI3I10Block()
                ElseIf positionOneTwo = "i3a3" Then
                    checkChePaoI3A3Block()
                ElseIf positionOneTwo = "i3b3" Then
                    checkChePaoI3B3Block()
                ElseIf positionOneTwo = "i3c3" Then
                    checkChePaoI3C3Block()
                ElseIf positionOneTwo = "i3d3" Then
                    checkChePaoI3D3Block()
                ElseIf positionOneTwo = "i3e3" Then
                    checkChePaoI3E3Block()
                ElseIf positionOneTwo = "i3f3" Then
                    checkChePaoI3F3Block()
                ElseIf positionOneTwo = "i3g3" Then
                    checkChePaoI3G3Block()
                End If
            Case "a4"
                If positionOneTwo = "a4a1" Then
                    checkChePaoA4A1Block()
                ElseIf positionOneTwo = "a4a2" Then
                    checkChePaoA4A2Block()
                ElseIf positionOneTwo = "a4a6" Then
                    checkChePaoA4A6Block()
                ElseIf positionOneTwo = "a4a7" Then
                    checkChePaoA4A7Block()
                ElseIf positionOneTwo = "a4a8" Then
                    checkChePaoA4A8Block()
                ElseIf positionOneTwo = "a4a9" Then
                    checkChePaoA4A9Block()
                ElseIf positionOneTwo = "a4a10" Then
                    checkChePaoA4A10Block()
                ElseIf positionOneTwo = "a4c4" Then
                    checkChePaoA4C4Block()
                ElseIf positionOneTwo = "a4d4" Then
                    checkChePaoA4D4Block()
                ElseIf positionOneTwo = "a4e4" Then
                    checkChePaoA4E4Block()
                ElseIf positionOneTwo = "a4f4" Then
                    checkChePaoA4F4Block()
                ElseIf positionOneTwo = "a4g4" Then
                    checkChePaoA4G4Block()
                ElseIf positionOneTwo = "a4h4" Then
                    checkChePaoA4H4Block()
                ElseIf positionOneTwo = "a4i4" Then
                    checkChePaoA4I4Block()
                End If
            Case "b4"
                If positionOneTwo = "b4b1" Then
                    checkChePaoB4B1Block()
                ElseIf positionOneTwo = "b4b2" Then
                    checkChePaoB4B2Block()
                ElseIf positionOneTwo = "b4b6" Then
                    checkChePaoB4B6Block()
                ElseIf positionOneTwo = "b4b7" Then
                    checkChePaoB4B7Block()
                ElseIf positionOneTwo = "b4b8" Then
                    checkChePaoB4B8Block()
                ElseIf positionOneTwo = "b4b9" Then
                    checkChePaoB4B9Block()
                ElseIf positionOneTwo = "b4b10" Then
                    checkChePaoB4B10Block()
                ElseIf positionOneTwo = "b4d4" Then
                    checkChePaoB4D4Block()
                ElseIf positionOneTwo = "b4e4" Then
                    checkChePaoB4E4Block()
                ElseIf positionOneTwo = "b4f4" Then
                    checkChePaoB4F4Block()
                ElseIf positionOneTwo = "b4g4" Then
                    checkChePaoB4G4Block()
                ElseIf positionOneTwo = "b4h4" Then
                    checkChePaoB4H4Block()
                ElseIf positionOneTwo = "b4i4" Then
                    checkChePaoB4I4Block()
                End If
            Case "c4"
                If positionOneTwo = "c4c1" Then
                    checkChePaoC4C1Block()
                ElseIf positionOneTwo = "c4c2" Then
                    checkChePaoC4C2Block()
                ElseIf positionOneTwo = "c4c6" Then
                    checkChePaoC4C6Block()
                ElseIf positionOneTwo = "c4c7" Then
                    checkChePaoC4C7Block()
                ElseIf positionOneTwo = "c4c8" Then
                    checkChePaoC4C8Block()
                ElseIf positionOneTwo = "c4c9" Then
                    checkChePaoC4C9Block()
                ElseIf positionOneTwo = "c4c10" Then
                    checkChePaoC4C10Block()
                ElseIf positionOneTwo = "c4a4" Then
                    checkChePaoC4A4Block()
                ElseIf positionOneTwo = "c4e4" Then
                    checkChePaoC4E4Block()
                ElseIf positionOneTwo = "c4f4" Then
                    checkChePaoC4F4Block()
                ElseIf positionOneTwo = "c4g4" Then
                    checkChePaoC4G4Block()
                ElseIf positionOneTwo = "c4h4" Then
                    checkChePaoC4H4Block()
                ElseIf positionOneTwo = "c4i4" Then
                    checkChePaoC4I4Block()
                End If
            Case "d4"
                If positionOneTwo = "d4d1" Then
                    checkChePaoD4D1Block()
                ElseIf positionOneTwo = "d4d2" Then
                    checkChePaoD4D2Block()
                ElseIf positionOneTwo = "d4d6" Then
                    checkChePaoD4D6Block()
                ElseIf positionOneTwo = "d4d7" Then
                    checkChePaoD4D7Block()
                ElseIf positionOneTwo = "d4d8" Then
                    checkChePaoD4D8Block()
                ElseIf positionOneTwo = "d4d9" Then
                    checkChePaoD4D9Block()
                ElseIf positionOneTwo = "d4d10" Then
                    checkChePaoD4D10Block()
                ElseIf positionOneTwo = "d4a4" Then
                    checkChePaoD4A4Block()
                ElseIf positionOneTwo = "d4b4" Then
                    checkChePaoD4B4Block()
                ElseIf positionOneTwo = "d4f4" Then
                    checkChePaoD4F4Block()
                ElseIf positionOneTwo = "d4g4" Then
                    checkChePaoD4G4Block()
                ElseIf positionOneTwo = "d4h4" Then
                    checkChePaoD4H4Block()
                ElseIf positionOneTwo = "d4i4" Then
                    checkChePaoD4I4Block()
                End If
            Case "e4"
                If positionOneTwo = "e4e1" Then
                    checkChePaoE4E1Block()
                ElseIf positionOneTwo = "e4e2" Then
                    checkChePaoE4E2Block()
                ElseIf positionOneTwo = "e4e6" Then
                    checkChePaoE4E6Block()
                ElseIf positionOneTwo = "e4e7" Then
                    checkChePaoE4E7Block()
                ElseIf positionOneTwo = "e4e8" Then
                    checkChePaoE4E8Block()
                ElseIf positionOneTwo = "e4e9" Then
                    checkChePaoE4E9Block()
                ElseIf positionOneTwo = "e4e10" Then
                    checkChePaoE4E10Block()
                ElseIf positionOneTwo = "e4a4" Then
                    checkChePaoE4A4Block()
                ElseIf positionOneTwo = "e4b4" Then
                    checkChePaoE4B4Block()
                ElseIf positionOneTwo = "e4c4" Then
                    checkChePaoE4C4Block()
                ElseIf positionOneTwo = "e4g4" Then
                    checkChePaoE4G4Block()
                ElseIf positionOneTwo = "e4h4" Then
                    checkChePaoE4H4Block()
                ElseIf positionOneTwo = "e4i4" Then
                    checkChePaoE4I4Block()
                End If
            Case "f4"
                If positionOneTwo = "f4f1" Then
                    checkChePaoF4F1Block()
                ElseIf positionOneTwo = "f4f2" Then
                    checkChePaoF4F2Block()
                ElseIf positionOneTwo = "f4f6" Then
                    checkChePaoF4F6Block()
                ElseIf positionOneTwo = "f4f7" Then
                    checkChePaoF4F7Block()
                ElseIf positionOneTwo = "f4f8" Then
                    checkChePaoF4F8Block()
                ElseIf positionOneTwo = "f4f9" Then
                    checkChePaoF4F9Block()
                ElseIf positionOneTwo = "f4f10" Then
                    checkChePaoF4F10Block()
                ElseIf positionOneTwo = "f4a4" Then
                    checkChePaoF4A4Block()
                ElseIf positionOneTwo = "f4b4" Then
                    checkChePaoF4B4Block()
                ElseIf positionOneTwo = "f4c4" Then
                    checkChePaoF4C4Block()
                ElseIf positionOneTwo = "f4d4" Then
                    checkChePaoF4D4Block()
                ElseIf positionOneTwo = "f4h4" Then
                    checkChePaoF4H4Block()
                ElseIf positionOneTwo = "f4i4" Then
                    checkChePaoF4I4Block()
                End If
            Case "g4"
                If positionOneTwo = "g4g1" Then
                    checkChePaoG4G1Block()
                ElseIf positionOneTwo = "g4g2" Then
                    checkChePaoG4G2Block()
                ElseIf positionOneTwo = "g4g6" Then
                    checkChePaoG4G6Block()
                ElseIf positionOneTwo = "g4g7" Then
                    checkChePaoG4G7Block()
                ElseIf positionOneTwo = "g4g8" Then
                    checkChePaoG4G8Block()
                ElseIf positionOneTwo = "g4g9" Then
                    checkChePaoG4G9Block()
                ElseIf positionOneTwo = "g4g10" Then
                    checkChePaoG4G10Block()
                ElseIf positionOneTwo = "g4a4" Then
                    checkChePaoG4A4Block()
                ElseIf positionOneTwo = "g4b4" Then
                    checkChePaoG4B4Block()
                ElseIf positionOneTwo = "g4c4" Then
                    checkChePaoG4C4Block()
                ElseIf positionOneTwo = "g4d4" Then
                    checkChePaoG4D4Block()
                ElseIf positionOneTwo = "g4e4" Then
                    checkChePaoG4E4Block()
                ElseIf positionOneTwo = "g4i4" Then
                    checkChePaoG4I4Block()
                End If
            Case "h4"
                If positionOneTwo = "h4h1" Then
                    checkChePaoH4H1Block()
                ElseIf positionOneTwo = "h4h2" Then
                    checkChePaoH4H2Block()
                ElseIf positionOneTwo = "h4h6" Then
                    checkChePaoH4H6Block()
                ElseIf positionOneTwo = "h4h7" Then
                    checkChePaoH4H7Block()
                ElseIf positionOneTwo = "h4h8" Then
                    checkChePaoH4H8Block()
                ElseIf positionOneTwo = "h4h9" Then
                    checkChePaoH4H9Block()
                ElseIf positionOneTwo = "h4h10" Then
                    checkChePaoH4H10Block()
                ElseIf positionOneTwo = "h4a4" Then
                    checkChePaoH4A4Block()
                ElseIf positionOneTwo = "h4b4" Then
                    checkChePaoH4B4Block()
                ElseIf positionOneTwo = "h4c4" Then
                    checkChePaoH4C4Block()
                ElseIf positionOneTwo = "h4d4" Then
                    checkChePaoH4D4Block()
                ElseIf positionOneTwo = "h4e4" Then
                    checkChePaoH4E4Block()
                ElseIf positionOneTwo = "h4f4" Then
                    checkChePaoH4F4Block()
                End If
            Case "i4"
                If positionOneTwo = "i4i1" Then
                    checkChePaoI4I1Block()
                ElseIf positionOneTwo = "i4i2" Then
                    checkChePaoI4I2Block()
                ElseIf positionOneTwo = "i4i6" Then
                    checkChePaoI4I6Block()
                ElseIf positionOneTwo = "i4i7" Then
                    checkChePaoI4I7Block()
                ElseIf positionOneTwo = "i4i8" Then
                    checkChePaoI4I8Block()
                ElseIf positionOneTwo = "i4i9" Then
                    checkChePaoI4I9Block()
                ElseIf positionOneTwo = "i4i10" Then
                    checkChePaoI4I10Block()
                ElseIf positionOneTwo = "i4a4" Then
                    checkChePaoI4A4Block()
                ElseIf positionOneTwo = "i4b4" Then
                    checkChePaoI4B4Block()
                ElseIf positionOneTwo = "i4c4" Then
                    checkChePaoI4C4Block()
                ElseIf positionOneTwo = "i4d4" Then
                    checkChePaoI4D4Block()
                ElseIf positionOneTwo = "i4e4" Then
                    checkChePaoI4E4Block()
                ElseIf positionOneTwo = "i4f4" Then
                    checkChePaoI4F4Block()
                ElseIf positionOneTwo = "i4g4" Then
                    checkChePaoI4G4Block()
                End If
            Case "a5"
                If positionOneTwo = "a5a1" Then
                    checkChePaoA5A1Block()
                ElseIf positionOneTwo = "a5a2" Then
                    checkChePaoA5A2Block()
                ElseIf positionOneTwo = "a5a3" Then
                    checkChePaoA5A3Block()
                ElseIf positionOneTwo = "a5a7" Then
                    checkChePaoA5A7Block()
                ElseIf positionOneTwo = "a5a8" Then
                    checkChePaoA5A8Block()
                ElseIf positionOneTwo = "a5a9" Then
                    checkChePaoA5A9Block()
                ElseIf positionOneTwo = "a5a10" Then
                    checkChePaoA5A10Block()
                ElseIf positionOneTwo = "a5c5" Then
                    checkChePaoA5C5Block()
                ElseIf positionOneTwo = "a5d5" Then
                    checkChePaoA5D5Block()
                ElseIf positionOneTwo = "a5e5" Then
                    checkChePaoA5E5Block()
                ElseIf positionOneTwo = "a5f5" Then
                    checkChePaoA5F5Block()
                ElseIf positionOneTwo = "a5g5" Then
                    checkChePaoA5G5Block()
                ElseIf positionOneTwo = "a5h5" Then
                    checkChePaoA5H5Block()
                ElseIf positionOneTwo = "a5i5" Then
                    checkChePaoA5I5Block()
                End If
            Case "b5"
                If positionOneTwo = "b5b1" Then
                    checkChePaoB5B1Block()
                ElseIf positionOneTwo = "b5b2" Then
                    checkChePaoB5B2Block()
                ElseIf positionOneTwo = "b5b3" Then
                    checkChePaoB5B3Block()
                ElseIf positionOneTwo = "b5b7" Then
                    checkChePaoB5B7Block()
                ElseIf positionOneTwo = "b5b8" Then
                    checkChePaoB5B8Block()
                ElseIf positionOneTwo = "b5b9" Then
                    checkChePaoB5B9Block()
                ElseIf positionOneTwo = "b5b10" Then
                    checkChePaoB5B10Block()
                ElseIf positionOneTwo = "b5d5" Then
                    checkChePaoB5D5Block()
                ElseIf positionOneTwo = "b5e5" Then
                    checkChePaoB5E5Block()
                ElseIf positionOneTwo = "b5f5" Then
                    checkChePaoB5F5Block()
                ElseIf positionOneTwo = "b5g5" Then
                    checkChePaoB5G5Block()
                ElseIf positionOneTwo = "b5h5" Then
                    checkChePaoB5H5Block()
                ElseIf positionOneTwo = "b5i5" Then
                    checkChePaoB5I5Block()
                End If
            Case "c5"
                If positionOneTwo = "c5c1" Then
                    checkChePaoC5C1Block()
                ElseIf positionOneTwo = "c5c2" Then
                    checkChePaoC5C2Block()
                ElseIf positionOneTwo = "c5c3" Then
                    checkChePaoC5C3Block()
                ElseIf positionOneTwo = "c5c7" Then
                    checkChePaoC5C7Block()
                ElseIf positionOneTwo = "c5c8" Then
                    checkChePaoC5C8Block()
                ElseIf positionOneTwo = "c5c9" Then
                    checkChePaoC5C9Block()
                ElseIf positionOneTwo = "c5c10" Then
                    checkChePaoC5C10Block()
                ElseIf positionOneTwo = "c5a5" Then
                    checkChePaoC5A5Block()
                ElseIf positionOneTwo = "c5e5" Then
                    checkChePaoC5E5Block()
                ElseIf positionOneTwo = "c5f5" Then
                    checkChePaoC5F5Block()
                ElseIf positionOneTwo = "c5g5" Then
                    checkChePaoC5G5Block()
                ElseIf positionOneTwo = "c5h5" Then
                    checkChePaoC5H5Block()
                ElseIf positionOneTwo = "c5i5" Then
                    checkChePaoC5I5Block()
                End If
            Case "d5"
                If positionOneTwo = "d5d1" Then
                    checkChePaoD5D1Block()
                ElseIf positionOneTwo = "d5d2" Then
                    checkChePaoD5D2Block()
                ElseIf positionOneTwo = "d5d3" Then
                    checkChePaoD5D3Block()
                ElseIf positionOneTwo = "d5d7" Then
                    checkChePaoD5D7Block()
                ElseIf positionOneTwo = "d5d8" Then
                    checkChePaoD5D8Block()
                ElseIf positionOneTwo = "d5d9" Then
                    checkChePaoD5D9Block()
                ElseIf positionOneTwo = "d5d10" Then
                    checkChePaoD5D10Block()
                ElseIf positionOneTwo = "d5a5" Then
                    checkChePaoD5A5Block()
                ElseIf positionOneTwo = "d5b5" Then
                    checkChePaoD5B5Block()
                ElseIf positionOneTwo = "d5f5" Then
                    checkChePaoD5F5Block()
                ElseIf positionOneTwo = "d5g5" Then
                    checkChePaoD5G5Block()
                ElseIf positionOneTwo = "d5h5" Then
                    checkChePaoD5H5Block()
                ElseIf positionOneTwo = "d5i5" Then
                    checkChePaoD5I5Block()
                End If
            Case "e5"
                If positionOneTwo = "e5e1" Then
                    checkChePaoE5E1Block()
                ElseIf positionOneTwo = "e5e2" Then
                    checkChePaoE5E2Block()
                ElseIf positionOneTwo = "e5e3" Then
                    checkChePaoE5E3Block()
                ElseIf positionOneTwo = "e5e7" Then
                    checkChePaoE5E7Block()
                ElseIf positionOneTwo = "e5e8" Then
                    checkChePaoE5E8Block()
                ElseIf positionOneTwo = "e5e9" Then
                    checkChePaoE5E9Block()
                ElseIf positionOneTwo = "e5e10" Then
                    checkChePaoE5E10Block()
                ElseIf positionOneTwo = "e5a5" Then
                    checkChePaoE5A5Block()
                ElseIf positionOneTwo = "e5b5" Then
                    checkChePaoE5B5Block()
                ElseIf positionOneTwo = "e5c5" Then
                    checkChePaoE5C5Block()
                ElseIf positionOneTwo = "e5g5" Then
                    checkChePaoE5G5Block()
                ElseIf positionOneTwo = "e5h5" Then
                    checkChePaoE5H5Block()
                ElseIf positionOneTwo = "e5i5" Then
                    checkChePaoE5I5Block()
                End If
            Case "f5"
                If positionOneTwo = "f5f1" Then
                    checkChePaoF5F1Block()
                ElseIf positionOneTwo = "f5f2" Then
                    checkChePaoF5F2Block()
                ElseIf positionOneTwo = "f5f3" Then
                    checkChePaoF5F3Block()
                ElseIf positionOneTwo = "f5f7" Then
                    checkChePaoF5F7Block()
                ElseIf positionOneTwo = "f5f8" Then
                    checkChePaoF5F8Block()
                ElseIf positionOneTwo = "f5f9" Then
                    checkChePaoF5F9Block()
                ElseIf positionOneTwo = "f5f10" Then
                    checkChePaoF5F10Block()
                ElseIf positionOneTwo = "f5a5" Then
                    checkChePaoF5A5Block()
                ElseIf positionOneTwo = "f5b5" Then
                    checkChePaoF5B5Block()
                ElseIf positionOneTwo = "f5c5" Then
                    checkChePaoF5C5Block()
                ElseIf positionOneTwo = "f5d5" Then
                    checkChePaoF5D5Block()
                ElseIf positionOneTwo = "f5h5" Then
                    checkChePaoF5H5Block()
                ElseIf positionOneTwo = "f5i5" Then
                    checkChePaoF5I5Block()
                End If
            Case "g5"
                If positionOneTwo = "g5g1" Then
                    checkChePaoG5G1Block()
                ElseIf positionOneTwo = "g5g2" Then
                    checkChePaoG5G2Block()
                ElseIf positionOneTwo = "g5g3" Then
                    checkChePaoG5G3Block()
                ElseIf positionOneTwo = "g5g7" Then
                    checkChePaoG5G7Block()
                ElseIf positionOneTwo = "g5g8" Then
                    checkChePaoG5G8Block()
                ElseIf positionOneTwo = "g5g9" Then
                    checkChePaoG5G9Block()
                ElseIf positionOneTwo = "g5g10" Then
                    checkChePaoG5G10Block()
                ElseIf positionOneTwo = "g5a5" Then
                    checkChePaoG5A5Block()
                ElseIf positionOneTwo = "g5b5" Then
                    checkChePaoG5B5Block()
                ElseIf positionOneTwo = "g5c5" Then
                    checkChePaoG5C5Block()
                ElseIf positionOneTwo = "g5d5" Then
                    checkChePaoG5D5Block()
                ElseIf positionOneTwo = "g5e5" Then
                    checkChePaoG5E5Block()
                ElseIf positionOneTwo = "g5i5" Then
                    checkChePaoG5I5Block()
                End If
            Case "h5"
                If positionOneTwo = "h5h1" Then
                    checkChePaoH5H1Block()
                ElseIf positionOneTwo = "h5h2" Then
                    checkChePaoH5H2Block()
                ElseIf positionOneTwo = "h5h3" Then
                    checkChePaoH5H3Block()
                ElseIf positionOneTwo = "h5h7" Then
                    checkChePaoH5H7Block()
                ElseIf positionOneTwo = "h5h8" Then
                    checkChePaoH5H8Block()
                ElseIf positionOneTwo = "h5h9" Then
                    checkChePaoH5H9Block()
                ElseIf positionOneTwo = "h5h10" Then
                    checkChePaoH5H10Block()
                ElseIf positionOneTwo = "h5a5" Then
                    checkChePaoH5A5Block()
                ElseIf positionOneTwo = "h5b5" Then
                    checkChePaoH5B5Block()
                ElseIf positionOneTwo = "h5c5" Then
                    checkChePaoH5C5Block()
                ElseIf positionOneTwo = "h5d5" Then
                    checkChePaoH5D5Block()
                ElseIf positionOneTwo = "h5e5" Then
                    checkChePaoH5E5Block()
                ElseIf positionOneTwo = "h5f5" Then
                    checkChePaoH5F5Block()
                End If
            Case "i5"
                If positionOneTwo = "i5i1" Then
                    checkChePaoI5I1Block()
                ElseIf positionOneTwo = "i5i2" Then
                    checkChePaoI5I2Block()
                ElseIf positionOneTwo = "i5i3" Then
                    checkChePaoI5I3Block()
                ElseIf positionOneTwo = "i5i7" Then
                    checkChePaoI5I7Block()
                ElseIf positionOneTwo = "i5i8" Then
                    checkChePaoI5I8Block()
                ElseIf positionOneTwo = "i5i9" Then
                    checkChePaoI5I9Block()
                ElseIf positionOneTwo = "i5i10" Then
                    checkChePaoI5I10Block()
                ElseIf positionOneTwo = "i5a5" Then
                    checkChePaoI5A5Block()
                ElseIf positionOneTwo = "i5b5" Then
                    checkChePaoI5B5Block()
                ElseIf positionOneTwo = "i5c5" Then
                    checkChePaoI5C5Block()
                ElseIf positionOneTwo = "i5d5" Then
                    checkChePaoI5D5Block()
                ElseIf positionOneTwo = "i5e5" Then
                    checkChePaoI5E5Block()
                ElseIf positionOneTwo = "i5f5" Then
                    checkChePaoI5F5Block()
                ElseIf positionOneTwo = "i5g5" Then
                    checkChePaoI5G5Block()
                End If
            Case "a6"
                If positionOneTwo = "a6a1" Then
                    checkChePaoA6A1Block()
                ElseIf positionOneTwo = "a6a2" Then
                    checkChePaoA6A2Block()
                ElseIf positionOneTwo = "a6a3" Then
                    checkChePaoA6A3Block()
                ElseIf positionOneTwo = "a6a4" Then
                    checkChePaoA6A4Block()
                ElseIf positionOneTwo = "a6a8" Then
                    checkChePaoA6A8Block()
                ElseIf positionOneTwo = "a6a9" Then
                    checkChePaoA6A9Block()
                ElseIf positionOneTwo = "a6a10" Then
                    checkChePaoA6A10Block()
                ElseIf positionOneTwo = "a6c6" Then
                    checkChePaoA6C6Block()
                ElseIf positionOneTwo = "a6d6" Then
                    checkChePaoA6D6Block()
                ElseIf positionOneTwo = "a6e6" Then
                    checkChePaoA6E6Block()
                ElseIf positionOneTwo = "a6f6" Then
                    checkChePaoA6F6Block()
                ElseIf positionOneTwo = "a6g6" Then
                    checkChePaoA6G6Block()
                ElseIf positionOneTwo = "a6h6" Then
                    checkChePaoA6H6Block()
                ElseIf positionOneTwo = "a6i6" Then
                    checkChePaoA6I6Block()
                End If
            Case "b6"
                If positionOneTwo = "b6b1" Then
                    checkChePaoB6B1Block()
                ElseIf positionOneTwo = "b6b2" Then
                    checkChePaoB6B2Block()
                ElseIf positionOneTwo = "b6b3" Then
                    checkChePaoB6B3Block()
                ElseIf positionOneTwo = "b6b4" Then
                    checkChePaoB6B4Block()
                ElseIf positionOneTwo = "b6b8" Then
                    checkChePaoB6B8Block()
                ElseIf positionOneTwo = "b6b9" Then
                    checkChePaoB6B9Block()
                ElseIf positionOneTwo = "b6b10" Then
                    checkChePaoB6B10Block()
                ElseIf positionOneTwo = "b6d6" Then
                    checkChePaoB6D6Block()
                ElseIf positionOneTwo = "b6e6" Then
                    checkChePaoB6E6Block()
                ElseIf positionOneTwo = "b6f6" Then
                    checkChePaoB6F6Block()
                ElseIf positionOneTwo = "b6g6" Then
                    checkChePaoB6G6Block()
                ElseIf positionOneTwo = "b6h6" Then
                    checkChePaoB6H6Block()
                ElseIf positionOneTwo = "b6i6" Then
                    checkChePaoB6I6Block()
                End If
            Case "c6"
                If positionOneTwo = "c6c1" Then
                    checkChePaoC6C1Block()
                ElseIf positionOneTwo = "c6c2" Then
                    checkChePaoC6C2Block()
                ElseIf positionOneTwo = "c6c3" Then
                    checkChePaoC6C3Block()
                ElseIf positionOneTwo = "c6c4" Then
                    checkChePaoC6C4Block()
                ElseIf positionOneTwo = "c6c8" Then
                    checkChePaoC6C8Block()
                ElseIf positionOneTwo = "c6c9" Then
                    checkChePaoC6C9Block()
                ElseIf positionOneTwo = "c6c10" Then
                    checkChePaoC6C10Block()
                ElseIf positionOneTwo = "c6a6" Then
                    checkChePaoC6A6Block()
                ElseIf positionOneTwo = "c6e6" Then
                    checkChePaoC6E6Block()
                ElseIf positionOneTwo = "c6f6" Then
                    checkChePaoC6F6Block()
                ElseIf positionOneTwo = "c6g6" Then
                    checkChePaoC6G6Block()
                ElseIf positionOneTwo = "c6h6" Then
                    checkChePaoC6H6Block()
                ElseIf positionOneTwo = "c6i6" Then
                    checkChePaoC6I6Block()
                End If
            Case "d6"
                If positionOneTwo = "d6d1" Then
                    checkChePaoD6D1Block()
                ElseIf positionOneTwo = "d6d2" Then
                    checkChePaoD6D2Block()
                ElseIf positionOneTwo = "d6d3" Then
                    checkChePaoD6D3Block()
                ElseIf positionOneTwo = "d6d4" Then
                    checkChePaoD6D4Block()
                ElseIf positionOneTwo = "d6d8" Then
                    checkChePaoD6D8Block()
                ElseIf positionOneTwo = "d6d9" Then
                    checkChePaoD6D9Block()
                ElseIf positionOneTwo = "d6d10" Then
                    checkChePaoD6D10Block()
                ElseIf positionOneTwo = "d6a6" Then
                    checkChePaoD6A6Block()
                ElseIf positionOneTwo = "d6b6" Then
                    checkChePaoD6B6Block()
                ElseIf positionOneTwo = "d6f6" Then
                    checkChePaoD6F6Block()
                ElseIf positionOneTwo = "d6g6" Then
                    checkChePaoD6G6Block()
                ElseIf positionOneTwo = "d6h6" Then
                    checkChePaoD6H6Block()
                ElseIf positionOneTwo = "d6i6" Then
                    checkChePaoD6I6Block()
                End If
            Case "e6"
                If positionOneTwo = "e6e1" Then
                    checkChePaoE6E1Block()
                ElseIf positionOneTwo = "e6e2" Then
                    checkChePaoE6E2Block()
                ElseIf positionOneTwo = "e6e3" Then
                    checkChePaoE6E3Block()
                ElseIf positionOneTwo = "e6e4" Then
                    checkChePaoE6E4Block()
                ElseIf positionOneTwo = "e6e8" Then
                    checkChePaoE6E8Block()
                ElseIf positionOneTwo = "e6e9" Then
                    checkChePaoE6E9Block()
                ElseIf positionOneTwo = "e6e10" Then
                    checkChePaoE6E10Block()
                ElseIf positionOneTwo = "e6a6" Then
                    checkChePaoE6A6Block()
                ElseIf positionOneTwo = "e6b6" Then
                    checkChePaoE6B6Block()
                ElseIf positionOneTwo = "e6c6" Then
                    checkChePaoE6C6Block()
                ElseIf positionOneTwo = "e6g6" Then
                    checkChePaoE6G6Block()
                ElseIf positionOneTwo = "e6h6" Then
                    checkChePaoE6H6Block()
                ElseIf positionOneTwo = "e6i6" Then
                    checkChePaoE6I6Block()
                End If
            Case "f6"
                If positionOneTwo = "f6f1" Then
                    checkChePaoF6F1Block()
                ElseIf positionOneTwo = "f6f2" Then
                    checkChePaoF6F2Block()
                ElseIf positionOneTwo = "f6f3" Then
                    checkChePaoF6F3Block()
                ElseIf positionOneTwo = "f6f4" Then
                    checkChePaoF6F4Block()
                ElseIf positionOneTwo = "f6f8" Then
                    checkChePaoF6F8Block()
                ElseIf positionOneTwo = "f6f9" Then
                    checkChePaoF6F9Block()
                ElseIf positionOneTwo = "f6f10" Then
                    checkChePaoF6F10Block()
                ElseIf positionOneTwo = "f6a6" Then
                    checkChePaoF6A6Block()
                ElseIf positionOneTwo = "f6b6" Then
                    checkChePaoF6B6Block()
                ElseIf positionOneTwo = "f6c6" Then
                    checkChePaoF6C6Block()
                ElseIf positionOneTwo = "f6d6" Then
                    checkChePaoF6D6Block()
                ElseIf positionOneTwo = "f6h6" Then
                    checkChePaoF6H6Block()
                ElseIf positionOneTwo = "f6i6" Then
                    checkChePaoF6I6Block()
                End If
            Case "g6"
                If positionOneTwo = "g6g1" Then
                    checkChePaoG6G1Block()
                ElseIf positionOneTwo = "g6g2" Then
                    checkChePaoG6G2Block()
                ElseIf positionOneTwo = "g6g3" Then
                    checkChePaoG6G3Block()
                ElseIf positionOneTwo = "g6g4" Then
                    checkChePaoG6G4Block()
                ElseIf positionOneTwo = "g6g8" Then
                    checkChePaoG6G8Block()
                ElseIf positionOneTwo = "g6g9" Then
                    checkChePaoG6G9Block()
                ElseIf positionOneTwo = "g6g10" Then
                    checkChePaoG6G10Block()
                ElseIf positionOneTwo = "g6a6" Then
                    checkChePaoG6A6Block()
                ElseIf positionOneTwo = "g6b6" Then
                    checkChePaoG6B6Block()
                ElseIf positionOneTwo = "g6c6" Then
                    checkChePaoG6C6Block()
                ElseIf positionOneTwo = "g6d6" Then
                    checkChePaoG6D6Block()
                ElseIf positionOneTwo = "g6e6" Then
                    checkChePaoG6E6Block()
                ElseIf positionOneTwo = "g6i6" Then
                    checkChePaoG6I6Block()
                End If
            Case "h6"
                If positionOneTwo = "h6h1" Then
                    checkChePaoH6H1Block()
                ElseIf positionOneTwo = "h6h2" Then
                    checkChePaoH6H2Block()
                ElseIf positionOneTwo = "h6h3" Then
                    checkChePaoH6H3Block()
                ElseIf positionOneTwo = "h6h4" Then
                    checkChePaoH6H4Block()
                ElseIf positionOneTwo = "h6h8" Then
                    checkChePaoH6H8Block()
                ElseIf positionOneTwo = "h6h9" Then
                    checkChePaoH6H9Block()
                ElseIf positionOneTwo = "h6h10" Then
                    checkChePaoH6H10Block()
                ElseIf positionOneTwo = "h6a6" Then
                    checkChePaoH6A6Block()
                ElseIf positionOneTwo = "h6b6" Then
                    checkChePaoH6B6Block()
                ElseIf positionOneTwo = "h6c6" Then
                    checkChePaoH6C6Block()
                ElseIf positionOneTwo = "h6d6" Then
                    checkChePaoH6D6Block()
                ElseIf positionOneTwo = "h6e6" Then
                    checkChePaoH6E6Block()
                ElseIf positionOneTwo = "h6f6" Then
                    checkChePaoH6F6Block()
                End If
            Case "i6"
                If positionOneTwo = "i6i1" Then
                    checkChePaoI6I1Block()
                ElseIf positionOneTwo = "i6i2" Then
                    checkChePaoI6I2Block()
                ElseIf positionOneTwo = "i6i3" Then
                    checkChePaoI6I3Block()
                ElseIf positionOneTwo = "i6i4" Then
                    checkChePaoI6I4Block()
                ElseIf positionOneTwo = "i6i8" Then
                    checkChePaoI6I8Block()
                ElseIf positionOneTwo = "i6i9" Then
                    checkChePaoI6I9Block()
                ElseIf positionOneTwo = "i6i10" Then
                    checkChePaoI6I10Block()
                ElseIf positionOneTwo = "i6a6" Then
                    checkChePaoI6A6Block()
                ElseIf positionOneTwo = "i6b6" Then
                    checkChePaoI6B6Block()
                ElseIf positionOneTwo = "i6c6" Then
                    checkChePaoI6C6Block()
                ElseIf positionOneTwo = "i6d6" Then
                    checkChePaoI6D6Block()
                ElseIf positionOneTwo = "i6e6" Then
                    checkChePaoI6E6Block()
                ElseIf positionOneTwo = "i6f6" Then
                    checkChePaoI6F6Block()
                ElseIf positionOneTwo = "i6g6" Then
                    checkChePaoI6G6Block()
                End If
            Case "a7"
                If positionOneTwo = "a7a1" Then
                    checkChePaoA7A1Block()
                ElseIf positionOneTwo = "a7a2" Then
                    checkChePaoA7A2Block()
                ElseIf positionOneTwo = "a7a3" Then
                    checkChePaoA7A3Block()
                ElseIf positionOneTwo = "a7a4" Then
                    checkChePaoA7A4Block()
                ElseIf positionOneTwo = "a7a5" Then
                    checkChePaoA7A5Block()
                ElseIf positionOneTwo = "a7a9" Then
                    checkChePaoA7A9Block()
                ElseIf positionOneTwo = "a7a10" Then
                    checkChePaoA7A10Block()
                ElseIf positionOneTwo = "a7c7" Then
                    checkChePaoA7C7Block()
                ElseIf positionOneTwo = "a7d7" Then
                    checkChePaoA7D7Block()
                ElseIf positionOneTwo = "a7e7" Then
                    checkChePaoA7E7Block()
                ElseIf positionOneTwo = "a7f7" Then
                    checkChePaoA7F7Block()
                ElseIf positionOneTwo = "a7g7" Then
                    checkChePaoA7G7Block()
                ElseIf positionOneTwo = "a7h7" Then
                    checkChePaoA7H7Block()
                ElseIf positionOneTwo = "a7i7" Then
                    checkChePaoA7I7Block()
                End If
            Case "b7"
                If positionOneTwo = "b7b1" Then
                    checkChePaoB7B1Block()
                ElseIf positionOneTwo = "b7b2" Then
                    checkChePaoB7B2Block()
                ElseIf positionOneTwo = "b7b3" Then
                    checkChePaoB7B3Block()
                ElseIf positionOneTwo = "b7b4" Then
                    checkChePaoB7B4Block()
                ElseIf positionOneTwo = "b7b5" Then
                    checkChePaoB7B5Block()
                ElseIf positionOneTwo = "b7b9" Then
                    checkChePaoB7B9Block()
                ElseIf positionOneTwo = "b7b10" Then
                    checkChePaoB7B10Block()
                ElseIf positionOneTwo = "b7d7" Then
                    checkChePaoB7D7Block()
                ElseIf positionOneTwo = "b7e7" Then
                    checkChePaoB7E7Block()
                ElseIf positionOneTwo = "b7f7" Then
                    checkChePaoB7F7Block()
                ElseIf positionOneTwo = "b7g7" Then
                    checkChePaoB7G7Block()
                ElseIf positionOneTwo = "b7h7" Then
                    checkChePaoB7H7Block()
                ElseIf positionOneTwo = "b7i7" Then
                    checkChePaoB7I7Block()
                End If
            Case "c7"
                If positionOneTwo = "c7c1" Then
                    checkChePaoC7C1Block()
                ElseIf positionOneTwo = "c7c2" Then
                    checkChePaoC7C2Block()
                ElseIf positionOneTwo = "c7c3" Then
                    checkChePaoC7C3Block()
                ElseIf positionOneTwo = "c7c4" Then
                    checkChePaoC7C4Block()
                ElseIf positionOneTwo = "c7c5" Then
                    checkChePaoC7C5Block()
                ElseIf positionOneTwo = "c7c9" Then
                    checkChePaoC7C9Block()
                ElseIf positionOneTwo = "c7c10" Then
                    checkChePaoC7C10Block()
                ElseIf positionOneTwo = "c7a7" Then
                    checkChePaoC7A7Block()
                ElseIf positionOneTwo = "c7e7" Then
                    checkChePaoC7E7Block()
                ElseIf positionOneTwo = "c7f7" Then
                    checkChePaoC7F7Block()
                ElseIf positionOneTwo = "c7g7" Then
                    checkChePaoC7G7Block()
                ElseIf positionOneTwo = "c7h7" Then
                    checkChePaoC7H7Block()
                ElseIf positionOneTwo = "c7i7" Then
                    checkChePaoC7I7Block()
                End If
            Case "d7"
                If positionOneTwo = "d7d1" Then
                    checkChePaoD7D1Block()
                ElseIf positionOneTwo = "d7d2" Then
                    checkChePaoD7D2Block()
                ElseIf positionOneTwo = "d7d3" Then
                    checkChePaoD7D3Block()
                ElseIf positionOneTwo = "d7d4" Then
                    checkChePaoD7D4Block()
                ElseIf positionOneTwo = "d7d5" Then
                    checkChePaoD7D5Block()
                ElseIf positionOneTwo = "d7d9" Then
                    checkChePaoD7D9Block()
                ElseIf positionOneTwo = "d7d10" Then
                    checkChePaoD7D10Block()
                ElseIf positionOneTwo = "d7a7" Then
                    checkChePaoD7A7Block()
                ElseIf positionOneTwo = "d7b7" Then
                    checkChePaoD7B7Block()
                ElseIf positionOneTwo = "d7f7" Then
                    checkChePaoD7F7Block()
                ElseIf positionOneTwo = "d7g7" Then
                    checkChePaoD7G7Block()
                ElseIf positionOneTwo = "d7h7" Then
                    checkChePaoD7H7Block()
                ElseIf positionOneTwo = "d7i7" Then
                    checkChePaoD7I7Block()
                End If
            Case "e7"
                If positionOneTwo = "e7e1" Then
                    checkChePaoE7E1Block()
                ElseIf positionOneTwo = "e7e2" Then
                    checkChePaoE7E2Block()
                ElseIf positionOneTwo = "e7e3" Then
                    checkChePaoE7E3Block()
                ElseIf positionOneTwo = "e7e4" Then
                    checkChePaoE7E4Block()
                ElseIf positionOneTwo = "e7e5" Then
                    checkChePaoE7E5Block()
                ElseIf positionOneTwo = "e7e9" Then
                    checkChePaoE7E9Block()
                ElseIf positionOneTwo = "e7e10" Then
                    checkChePaoE7E10Block()
                ElseIf positionOneTwo = "e7a7" Then
                    checkChePaoE7A7Block()
                ElseIf positionOneTwo = "e7b7" Then
                    checkChePaoE7B7Block()
                ElseIf positionOneTwo = "e7c7" Then
                    checkChePaoE7C7Block()
                ElseIf positionOneTwo = "e7g7" Then
                    checkChePaoE7G7Block()
                ElseIf positionOneTwo = "e7h7" Then
                    checkChePaoE7H7Block()
                ElseIf positionOneTwo = "e7i7" Then
                    checkChePaoE7I7Block()
                End If
            Case "f7"
                If positionOneTwo = "f7f1" Then
                    checkChePaoF7F1Block()
                ElseIf positionOneTwo = "f7f2" Then
                    checkChePaoF7F2Block()
                ElseIf positionOneTwo = "f7f3" Then
                    checkChePaoF7F3Block()
                ElseIf positionOneTwo = "f7f4" Then
                    checkChePaoF7F4Block()
                ElseIf positionOneTwo = "f7f5" Then
                    checkChePaoF7F5Block()
                ElseIf positionOneTwo = "f7f9" Then
                    checkChePaoF7F9Block()
                ElseIf positionOneTwo = "f7f10" Then
                    checkChePaoF7F10Block()
                ElseIf positionOneTwo = "f7a7" Then
                    checkChePaoF7A7Block()
                ElseIf positionOneTwo = "f7b7" Then
                    checkChePaoF7B7Block()
                ElseIf positionOneTwo = "f7c7" Then
                    checkChePaoF7C7Block()
                ElseIf positionOneTwo = "f7d7" Then
                    checkChePaoF7D7Block()
                ElseIf positionOneTwo = "f7h7" Then
                    checkChePaoF7H7Block()
                ElseIf positionOneTwo = "f7i7" Then
                    checkChePaoF7I7Block()
                End If
            Case "g7"
                If positionOneTwo = "g7g1" Then
                    checkChePaoG7G1Block()
                ElseIf positionOneTwo = "g7g2" Then
                    checkChePaoG7G2Block()
                ElseIf positionOneTwo = "g7g3" Then
                    checkChePaoG7G3Block()
                ElseIf positionOneTwo = "g7g4" Then
                    checkChePaoG7G4Block()
                ElseIf positionOneTwo = "g7g5" Then
                    checkChePaoG7G5Block()
                ElseIf positionOneTwo = "g7g9" Then
                    checkChePaoG7G9Block()
                ElseIf positionOneTwo = "g7g10" Then
                    checkChePaoG7G10Block()
                ElseIf positionOneTwo = "g7a7" Then
                    checkChePaoG7A7Block()
                ElseIf positionOneTwo = "g7b7" Then
                    checkChePaoG7B7Block()
                ElseIf positionOneTwo = "g7c7" Then
                    checkChePaoG7C7Block()
                ElseIf positionOneTwo = "g7d7" Then
                    checkChePaoG7D7Block()
                ElseIf positionOneTwo = "g7e7" Then
                    checkChePaoG7E7Block()
                ElseIf positionOneTwo = "g7i7" Then
                    checkChePaoG7I7Block()
                End If
            Case "h7"
                If positionOneTwo = "h7h1" Then
                    checkChePaoH7H1Block()
                ElseIf positionOneTwo = "h7h2" Then
                    checkChePaoH7H2Block()
                ElseIf positionOneTwo = "h7h3" Then
                    checkChePaoH7H3Block()
                ElseIf positionOneTwo = "h7h4" Then
                    checkChePaoH7H4Block()
                ElseIf positionOneTwo = "h7h5" Then
                    checkChePaoH7H5Block()
                ElseIf positionOneTwo = "h7h9" Then
                    checkChePaoH7H9Block()
                ElseIf positionOneTwo = "h7h10" Then
                    checkChePaoH7H10Block()
                ElseIf positionOneTwo = "h7a7" Then
                    checkChePaoH7A7Block()
                ElseIf positionOneTwo = "h7b7" Then
                    checkChePaoH7B7Block()
                ElseIf positionOneTwo = "h7c7" Then
                    checkChePaoH7C7Block()
                ElseIf positionOneTwo = "h7d7" Then
                    checkChePaoH7D7Block()
                ElseIf positionOneTwo = "h7e7" Then
                    checkChePaoH7E7Block()
                ElseIf positionOneTwo = "h7f7" Then
                    checkChePaoH7F7Block()
                End If
            Case "i7"
                If positionOneTwo = "i7i1" Then
                    checkChePaoI7I1Block()
                ElseIf positionOneTwo = "i7i2" Then
                    checkChePaoI7I2Block()
                ElseIf positionOneTwo = "i7i3" Then
                    checkChePaoI7I3Block()
                ElseIf positionOneTwo = "i7i4" Then
                    checkChePaoI7I4Block()
                ElseIf positionOneTwo = "i7i5" Then
                    checkChePaoI7I5Block()
                ElseIf positionOneTwo = "i7i9" Then
                    checkChePaoI7I9Block()
                ElseIf positionOneTwo = "i7i10" Then
                    checkChePaoI7I10Block()
                ElseIf positionOneTwo = "i7a7" Then
                    checkChePaoI7A7Block()
                ElseIf positionOneTwo = "i7b7" Then
                    checkChePaoI7B7Block()
                ElseIf positionOneTwo = "i7c7" Then
                    checkChePaoI7C7Block()
                ElseIf positionOneTwo = "i7d7" Then
                    checkChePaoI7D7Block()
                ElseIf positionOneTwo = "i7e7" Then
                    checkChePaoI7E7Block()
                ElseIf positionOneTwo = "i7f7" Then
                    checkChePaoI7F7Block()
                ElseIf positionOneTwo = "i7g7" Then
                    checkChePaoI7G7Block()
                End If
            Case "a8"
                If positionOneTwo = "a8a1" Then
                    checkChePaoA8A1Block()
                ElseIf positionOneTwo = "a8a2" Then
                    checkChePaoA8A2Block()
                ElseIf positionOneTwo = "a8a3" Then
                    checkChePaoA8A3Block()
                ElseIf positionOneTwo = "a8a4" Then
                    checkChePaoA8A4Block()
                ElseIf positionOneTwo = "a8a5" Then
                    checkChePaoA8A5Block()
                ElseIf positionOneTwo = "a8a6" Then
                    checkChePaoA8A6Block()
                ElseIf positionOneTwo = "a8a10" Then
                    checkChePaoA8A10Block()
                ElseIf positionOneTwo = "a8c8" Then
                    checkChePaoA8C8Block()
                ElseIf positionOneTwo = "a8d8" Then
                    checkChePaoA8D8Block()
                ElseIf positionOneTwo = "a8e8" Then
                    checkChePaoA8E8Block()
                ElseIf positionOneTwo = "a8f8" Then
                    checkChePaoA8F8Block()
                ElseIf positionOneTwo = "a8g8" Then
                    checkChePaoA8G8Block()
                ElseIf positionOneTwo = "a8h8" Then
                    checkChePaoA8H8Block()
                ElseIf positionOneTwo = "a8i8" Then
                    checkChePaoA8I8Block()
                End If
            Case "b8"
                If positionOneTwo = "b8b1" Then
                    checkChePaoB8B1Block()
                ElseIf positionOneTwo = "b8b2" Then
                    checkChePaoB8B2Block()
                ElseIf positionOneTwo = "b8b3" Then
                    checkChePaoB8B3Block()
                ElseIf positionOneTwo = "b8b4" Then
                    checkChePaoB8B4Block()
                ElseIf positionOneTwo = "b8b5" Then
                    checkChePaoB8B5Block()
                ElseIf positionOneTwo = "b8b6" Then
                    checkChePaoB8B6Block()
                ElseIf positionOneTwo = "b8b10" Then
                    checkChePaoB8B10Block()
                ElseIf positionOneTwo = "b8d8" Then
                    checkChePaoB8D8Block()
                ElseIf positionOneTwo = "b8e8" Then
                    checkChePaoB8E8Block()
                ElseIf positionOneTwo = "b8f8" Then
                    checkChePaoB8F8Block()
                ElseIf positionOneTwo = "b8g8" Then
                    checkChePaoB8G8Block()
                ElseIf positionOneTwo = "b8h8" Then
                    checkChePaoB8H8Block()
                ElseIf positionOneTwo = "b8i8" Then
                    checkChePaoB8I8Block()
                End If
            Case "c8"
                If positionOneTwo = "c8c1" Then
                    checkChePaoC8C1Block()
                ElseIf positionOneTwo = "c8c2" Then
                    checkChePaoC8C2Block()
                ElseIf positionOneTwo = "c8c3" Then
                    checkChePaoC8C3Block()
                ElseIf positionOneTwo = "c8c4" Then
                    checkChePaoC8C4Block()
                ElseIf positionOneTwo = "c8c5" Then
                    checkChePaoC8C5Block()
                ElseIf positionOneTwo = "c8c6" Then
                    checkChePaoC8C6Block()
                ElseIf positionOneTwo = "c8c10" Then
                    checkChePaoC8C10Block()
                ElseIf positionOneTwo = "c8a8" Then
                    checkChePaoC8A8Block()
                ElseIf positionOneTwo = "c8e8" Then
                    checkChePaoC8E8Block()
                ElseIf positionOneTwo = "c8f8" Then
                    checkChePaoC8F8Block()
                ElseIf positionOneTwo = "c8g8" Then
                    checkChePaoC8G8Block()
                ElseIf positionOneTwo = "c8h8" Then
                    checkChePaoC8H8Block()
                ElseIf positionOneTwo = "c8i8" Then
                    checkChePaoC8I8Block()
                End If
            Case "d8"
                If positionOneTwo = "d8d1" Then
                    checkChePaoD8D1Block()
                ElseIf positionOneTwo = "d8d2" Then
                    checkChePaoD8D2Block()
                ElseIf positionOneTwo = "d8d3" Then
                    checkChePaoD8D3Block()
                ElseIf positionOneTwo = "d8d4" Then
                    checkChePaoD8D4Block()
                ElseIf positionOneTwo = "d8d5" Then
                    checkChePaoD8D5Block()
                ElseIf positionOneTwo = "d8d6" Then
                    checkChePaoD8D6Block()
                ElseIf positionOneTwo = "d8d10" Then
                    checkChePaoD8D10Block()
                ElseIf positionOneTwo = "d8a8" Then
                    checkChePaoD8A8Block()
                ElseIf positionOneTwo = "d8b8" Then
                    checkChePaoD8B8Block()
                ElseIf positionOneTwo = "d8f8" Then
                    checkChePaoD8F8Block()
                ElseIf positionOneTwo = "d8g8" Then
                    checkChePaoD8G8Block()
                ElseIf positionOneTwo = "d8h8" Then
                    checkChePaoD8H8Block()
                ElseIf positionOneTwo = "d8i8" Then
                    checkChePaoD8I8Block()
                End If
            Case "e8"
                If positionOneTwo = "e8e1" Then
                    checkChePaoE8E1Block()
                ElseIf positionOneTwo = "e8e2" Then
                    checkChePaoE8E2Block()
                ElseIf positionOneTwo = "e8e3" Then
                    checkChePaoE8E3Block()
                ElseIf positionOneTwo = "e8e4" Then
                    checkChePaoE8E4Block()
                ElseIf positionOneTwo = "e8e5" Then
                    checkChePaoE8E5Block()
                ElseIf positionOneTwo = "e8e6" Then
                    checkChePaoE8E6Block()
                ElseIf positionOneTwo = "e8e10" Then
                    checkChePaoE8E10Block()
                ElseIf positionOneTwo = "e8a8" Then
                    checkChePaoE8A8Block()
                ElseIf positionOneTwo = "e8b8" Then
                    checkChePaoE8B8Block()
                ElseIf positionOneTwo = "e8c8" Then
                    checkChePaoE8C8Block()
                ElseIf positionOneTwo = "e8g8" Then
                    checkChePaoE8G8Block()
                ElseIf positionOneTwo = "e8h8" Then
                    checkChePaoE8H8Block()
                ElseIf positionOneTwo = "e8i8" Then
                    checkChePaoE8I8Block()
                End If
            Case "f8"
                If positionOneTwo = "f8f1" Then
                    checkChePaoF8F1Block()
                ElseIf positionOneTwo = "f8f2" Then
                    checkChePaoF8F2Block()
                ElseIf positionOneTwo = "f8f3" Then
                    checkChePaoF8F3Block()
                ElseIf positionOneTwo = "f8f4" Then
                    checkChePaoF8F4Block()
                ElseIf positionOneTwo = "f8f5" Then
                    checkChePaoF8F5Block()
                ElseIf positionOneTwo = "f8f6" Then
                    checkChePaoF8F6Block()
                ElseIf positionOneTwo = "f8f10" Then
                    checkChePaoF8F10Block()
                ElseIf positionOneTwo = "f8a8" Then
                    checkChePaoF8A8Block()
                ElseIf positionOneTwo = "f8b8" Then
                    checkChePaoF8B8Block()
                ElseIf positionOneTwo = "f8c8" Then
                    checkChePaoF8C8Block()
                ElseIf positionOneTwo = "f8d8" Then
                    checkChePaoF8D8Block()
                ElseIf positionOneTwo = "f8h8" Then
                    checkChePaoF8H8Block()
                ElseIf positionOneTwo = "f8i8" Then
                    checkChePaoF8I8Block()
                End If
            Case "g8"
                If positionOneTwo = "g8g1" Then
                    checkChePaoG8G1Block()
                ElseIf positionOneTwo = "g8g2" Then
                    checkChePaoG8G2Block()
                ElseIf positionOneTwo = "g8g3" Then
                    checkChePaoG8G3Block()
                ElseIf positionOneTwo = "g8g4" Then
                    checkChePaoG8G4Block()
                ElseIf positionOneTwo = "g8g5" Then
                    checkChePaoG8G5Block()
                ElseIf positionOneTwo = "g8g6" Then
                    checkChePaoG8G6Block()
                ElseIf positionOneTwo = "g8g10" Then
                    checkChePaoG8G10Block()
                ElseIf positionOneTwo = "g8a8" Then
                    checkChePaoG8A8Block()
                ElseIf positionOneTwo = "g8b8" Then
                    checkChePaoG8B8Block()
                ElseIf positionOneTwo = "g8c8" Then
                    checkChePaoG8C8Block()
                ElseIf positionOneTwo = "g8d8" Then
                    checkChePaoG8D8Block()
                ElseIf positionOneTwo = "g8e8" Then
                    checkChePaoG8E8Block()
                ElseIf positionOneTwo = "g8i8" Then
                    checkChePaoG8I8Block()
                End If
            Case "h8"
                If positionOneTwo = "h8h1" Then
                    checkChePaoH8H1Block()
                ElseIf positionOneTwo = "h8h2" Then
                    checkChePaoH8H2Block()
                ElseIf positionOneTwo = "h8h3" Then
                    checkChePaoH8H3Block()
                ElseIf positionOneTwo = "h8h4" Then
                    checkChePaoH8H4Block()
                ElseIf positionOneTwo = "h8h5" Then
                    checkChePaoH8H5Block()
                ElseIf positionOneTwo = "h8h6" Then
                    checkChePaoH8H6Block()
                ElseIf positionOneTwo = "h8h10" Then
                    checkChePaoH8H10Block()
                ElseIf positionOneTwo = "h8a8" Then
                    checkChePaoH8A8Block()
                ElseIf positionOneTwo = "h8b8" Then
                    checkChePaoH8B8Block()
                ElseIf positionOneTwo = "h8c8" Then
                    checkChePaoH8C8Block()
                ElseIf positionOneTwo = "h8d8" Then
                    checkChePaoH8D8Block()
                ElseIf positionOneTwo = "h8e8" Then
                    checkChePaoH8E8Block()
                ElseIf positionOneTwo = "h8f8" Then
                    checkChePaoH8F8Block()
                End If
            Case "i8"
                If positionOneTwo = "i8i1" Then
                    checkChePaoI8I1Block()
                ElseIf positionOneTwo = "i8i2" Then
                    checkChePaoI8I2Block()
                ElseIf positionOneTwo = "i8i3" Then
                    checkChePaoI8I3Block()
                ElseIf positionOneTwo = "i8i4" Then
                    checkChePaoI8I4Block()
                ElseIf positionOneTwo = "i8i5" Then
                    checkChePaoI8I5Block()
                ElseIf positionOneTwo = "i8i6" Then
                    checkChePaoI8I6Block()
                ElseIf positionOneTwo = "i8i10" Then
                    checkChePaoI8I10Block()
                ElseIf positionOneTwo = "i8a8" Then
                    checkChePaoI8A8Block()
                ElseIf positionOneTwo = "i8b8" Then
                    checkChePaoI8B8Block()
                ElseIf positionOneTwo = "i8c8" Then
                    checkChePaoI8C8Block()
                ElseIf positionOneTwo = "i8d8" Then
                    checkChePaoI8D8Block()
                ElseIf positionOneTwo = "i8e8" Then
                    checkChePaoI8E8Block()
                ElseIf positionOneTwo = "i8f8" Then
                    checkChePaoI8F8Block()
                ElseIf positionOneTwo = "i8g8" Then
                    checkChePaoI8G8Block()
                End If
            Case "a9"
                If positionOneTwo = "a9a1" Then
                    checkChePaoA9A1Block()
                ElseIf positionOneTwo = "a9a2" Then
                    checkChePaoA9A2Block()
                ElseIf positionOneTwo = "a9a3" Then
                    checkChePaoA9A3Block()
                ElseIf positionOneTwo = "a9a4" Then
                    checkChePaoA9A4Block()
                ElseIf positionOneTwo = "a9a5" Then
                    checkChePaoA9A5Block()
                ElseIf positionOneTwo = "a9a6" Then
                    checkChePaoA9A6Block()
                ElseIf positionOneTwo = "a9a7" Then
                    checkChePaoA9A7Block()
                ElseIf positionOneTwo = "a9c9" Then
                    checkChePaoA9C9Block()
                ElseIf positionOneTwo = "a9d9" Then
                    checkChePaoA9D9Block()
                ElseIf positionOneTwo = "a9e9" Then
                    checkChePaoA9E9Block()
                ElseIf positionOneTwo = "a9f9" Then
                    checkChePaoA9F9Block()
                ElseIf positionOneTwo = "a9g9" Then
                    checkChePaoA9G9Block()
                ElseIf positionOneTwo = "a9h9" Then
                    checkChePaoA9H9Block()
                ElseIf positionOneTwo = "a9i9" Then
                    checkChePaoA9I9Block()
                End If
            Case "b9"
                If positionOneTwo = "b9b1" Then
                    checkChePaoB9B1Block()
                ElseIf positionOneTwo = "b9b2" Then
                    checkChePaoB9B2Block()
                ElseIf positionOneTwo = "b9b3" Then
                    checkChePaoB9B3Block()
                ElseIf positionOneTwo = "b9b4" Then
                    checkChePaoB9B4Block()
                ElseIf positionOneTwo = "b9b5" Then
                    checkChePaoB9B5Block()
                ElseIf positionOneTwo = "b9b6" Then
                    checkChePaoB9B6Block()
                ElseIf positionOneTwo = "b9b7" Then
                    checkChePaoB9B7Block()
                ElseIf positionOneTwo = "b9d9" Then
                    checkChePaoB9D9Block()
                ElseIf positionOneTwo = "b9e9" Then
                    checkChePaoB9E9Block()
                ElseIf positionOneTwo = "b9f9" Then
                    checkChePaoB9F9Block()
                ElseIf positionOneTwo = "b9g9" Then
                    checkChePaoB9G9Block()
                ElseIf positionOneTwo = "b9h9" Then
                    checkChePaoB9H9Block()
                ElseIf positionOneTwo = "b9i9" Then
                    checkChePaoB9I9Block()
                End If
            Case "c9"
                If positionOneTwo = "c9c1" Then
                    checkChePaoC9C1Block()
                ElseIf positionOneTwo = "c9c2" Then
                    checkChePaoC9C2Block()
                ElseIf positionOneTwo = "c9c3" Then
                    checkChePaoC9C3Block()
                ElseIf positionOneTwo = "c9c4" Then
                    checkChePaoC9C4Block()
                ElseIf positionOneTwo = "c9c5" Then
                    checkChePaoC9C5Block()
                ElseIf positionOneTwo = "c9c6" Then
                    checkChePaoC9C6Block()
                ElseIf positionOneTwo = "c9c7" Then
                    checkChePaoC9C7Block()
                ElseIf positionOneTwo = "c9a9" Then
                    checkChePaoC9A9Block()
                ElseIf positionOneTwo = "c9e9" Then
                    checkChePaoC9E9Block()
                ElseIf positionOneTwo = "c9f9" Then
                    checkChePaoC9F9Block()
                ElseIf positionOneTwo = "c9g9" Then
                    checkChePaoC9G9Block()
                ElseIf positionOneTwo = "c9h9" Then
                    checkChePaoC9H9Block()
                ElseIf positionOneTwo = "c9i9" Then
                    checkChePaoC9I9Block()
                End If
            Case "d9"
                If positionOneTwo = "d9d1" Then
                    checkChePaoD9D1Block()
                ElseIf positionOneTwo = "d9d2" Then
                    checkChePaoD9D2Block()
                ElseIf positionOneTwo = "d9d3" Then
                    checkChePaoD9D3Block()
                ElseIf positionOneTwo = "d9d4" Then
                    checkChePaoD9D4Block()
                ElseIf positionOneTwo = "d9d5" Then
                    checkChePaoD9D5Block()
                ElseIf positionOneTwo = "d9d6" Then
                    checkChePaoD9D6Block()
                ElseIf positionOneTwo = "d9d7" Then
                    checkChePaoD9D7Block()
                ElseIf positionOneTwo = "d9a9" Then
                    checkChePaoD9A9Block()
                ElseIf positionOneTwo = "d9b9" Then
                    checkChePaoD9B9Block()
                ElseIf positionOneTwo = "d9f9" Then
                    checkChePaoD9F9Block()
                ElseIf positionOneTwo = "d9g9" Then
                    checkChePaoD9G9Block()
                ElseIf positionOneTwo = "d9h9" Then
                    checkChePaoD9H9Block()
                ElseIf positionOneTwo = "d9i9" Then
                    checkChePaoD9I9Block()
                End If
            Case "e9"
                If positionOneTwo = "e9e1" Then
                    checkChePaoE9E1Block()
                ElseIf positionOneTwo = "e9e2" Then
                    checkChePaoE9E2Block()
                ElseIf positionOneTwo = "e9e3" Then
                    checkChePaoE9E3Block()
                ElseIf positionOneTwo = "e9e4" Then
                    checkChePaoE9E4Block()
                ElseIf positionOneTwo = "e9e5" Then
                    checkChePaoE9E5Block()
                ElseIf positionOneTwo = "e9e6" Then
                    checkChePaoE9E6Block()
                ElseIf positionOneTwo = "e9e7" Then
                    checkChePaoE9E7Block()
                ElseIf positionOneTwo = "e9a9" Then
                    checkChePaoE9A9Block()
                ElseIf positionOneTwo = "e9b9" Then
                    checkChePaoE9B9Block()
                ElseIf positionOneTwo = "e9c9" Then
                    checkChePaoE9C9Block()
                ElseIf positionOneTwo = "e9g9" Then
                    checkChePaoE9G9Block()
                ElseIf positionOneTwo = "e9h9" Then
                    checkChePaoE9H9Block()
                ElseIf positionOneTwo = "e9i9" Then
                    checkChePaoE9I9Block()
                End If
            Case "f9"
                If positionOneTwo = "f9f1" Then
                    checkChePaoF9F1Block()
                ElseIf positionOneTwo = "f9f2" Then
                    checkChePaoF9F2Block()
                ElseIf positionOneTwo = "f9f3" Then
                    checkChePaoF9F3Block()
                ElseIf positionOneTwo = "f9f4" Then
                    checkChePaoF9F4Block()
                ElseIf positionOneTwo = "f9f5" Then
                    checkChePaoF9F5Block()
                ElseIf positionOneTwo = "f9f6" Then
                    checkChePaoF9F6Block()
                ElseIf positionOneTwo = "f9f7" Then
                    checkChePaoF9F7Block()
                ElseIf positionOneTwo = "f9a9" Then
                    checkChePaoF9A9Block()
                ElseIf positionOneTwo = "f9b9" Then
                    checkChePaoF9B9Block()
                ElseIf positionOneTwo = "f9c9" Then
                    checkChePaoF9C9Block()
                ElseIf positionOneTwo = "f9d9" Then
                    checkChePaoF9D9Block()
                ElseIf positionOneTwo = "f9h9" Then
                    checkChePaoF9H9Block()
                ElseIf positionOneTwo = "f9i9" Then
                    checkChePaoF9I9Block()
                End If
            Case "g9"
                If positionOneTwo = "g9g1" Then
                    checkChePaoG9G1Block()
                ElseIf positionOneTwo = "g9g2" Then
                    checkChePaoG9G2Block()
                ElseIf positionOneTwo = "g9g3" Then
                    checkChePaoG9G3Block()
                ElseIf positionOneTwo = "g9g4" Then
                    checkChePaoG9G4Block()
                ElseIf positionOneTwo = "g9g5" Then
                    checkChePaoG9G5Block()
                ElseIf positionOneTwo = "g9g6" Then
                    checkChePaoG9G6Block()
                ElseIf positionOneTwo = "g9g7" Then
                    checkChePaoG9G7Block()
                ElseIf positionOneTwo = "g9a9" Then
                    checkChePaoG9A9Block()
                ElseIf positionOneTwo = "g9b9" Then
                    checkChePaoG9B9Block()
                ElseIf positionOneTwo = "g9c9" Then
                    checkChePaoG9C9Block()
                ElseIf positionOneTwo = "g9d9" Then
                    checkChePaoG9D9Block()
                ElseIf positionOneTwo = "g9e9" Then
                    checkChePaoG9E9Block()
                ElseIf positionOneTwo = "g9i9" Then
                    checkChePaoG9I9Block()
                End If
            Case "h9"
                If positionOneTwo = "h9h1" Then
                    checkChePaoH9H1Block()
                ElseIf positionOneTwo = "h9h2" Then
                    checkChePaoH9H2Block()
                ElseIf positionOneTwo = "h9h3" Then
                    checkChePaoH9H3Block()
                ElseIf positionOneTwo = "h9h4" Then
                    checkChePaoH9H4Block()
                ElseIf positionOneTwo = "h9h5" Then
                    checkChePaoH9H5Block()
                ElseIf positionOneTwo = "h9h6" Then
                    checkChePaoH9H6Block()
                ElseIf positionOneTwo = "h9h7" Then
                    checkChePaoH9H7Block()
                ElseIf positionOneTwo = "h9a9" Then
                    checkChePaoH9A9Block()
                ElseIf positionOneTwo = "h9b9" Then
                    checkChePaoH9B9Block()
                ElseIf positionOneTwo = "h9c9" Then
                    checkChePaoH9C9Block()
                ElseIf positionOneTwo = "h9d9" Then
                    checkChePaoH9D9Block()
                ElseIf positionOneTwo = "h9e9" Then
                    checkChePaoH9E9Block()
                ElseIf positionOneTwo = "h9f9" Then
                    checkChePaoH9F9Block()
                End If
            Case "i9"
                If positionOneTwo = "i9i1" Then
                    checkChePaoI9I1Block()
                ElseIf positionOneTwo = "i9i2" Then
                    checkChePaoI9I2Block()
                ElseIf positionOneTwo = "i9i3" Then
                    checkChePaoI9I3Block()
                ElseIf positionOneTwo = "i9i4" Then
                    checkChePaoI9I4Block()
                ElseIf positionOneTwo = "i9i5" Then
                    checkChePaoI9I5Block()
                ElseIf positionOneTwo = "i9i6" Then
                    checkChePaoI9I6Block()
                ElseIf positionOneTwo = "i9i7" Then
                    checkChePaoI9I7Block()
                ElseIf positionOneTwo = "i9a9" Then
                    checkChePaoI9A9Block()
                ElseIf positionOneTwo = "i9b9" Then
                    checkChePaoI9B9Block()
                ElseIf positionOneTwo = "i9c9" Then
                    checkChePaoI9C9Block()
                ElseIf positionOneTwo = "i9d9" Then
                    checkChePaoI9D9Block()
                ElseIf positionOneTwo = "i9e9" Then
                    checkChePaoI9E9Block()
                ElseIf positionOneTwo = "i9f9" Then
                    checkChePaoI9F9Block()
                ElseIf positionOneTwo = "i9g9" Then
                    checkChePaoI9G9Block()
                End If
            Case "a10"
                If positionOneTwo = "a10a1" Then
                    checkChePaoA10A1Block()
                ElseIf positionOneTwo = "a10a2" Then
                    checkChePaoA10A2Block()
                ElseIf positionOneTwo = "a10a3" Then
                    checkChePaoA10A3Block()
                ElseIf positionOneTwo = "a10a4" Then
                    checkChePaoA10A4Block()
                ElseIf positionOneTwo = "a10a5" Then
                    checkChePaoA10A5Block()
                ElseIf positionOneTwo = "a10a6" Then
                    checkChePaoA10A6Block()
                ElseIf positionOneTwo = "a10a7" Then
                    checkChePaoA10A7Block()
                ElseIf positionOneTwo = "a10a8" Then
                    checkChePaoA10A8Block()
                ElseIf positionOneTwo = "a10c10" Then
                    checkChePaoA10C10Block()
                ElseIf positionOneTwo = "a10d10" Then
                    checkChePaoA10D10Block()
                ElseIf positionOneTwo = "a10e10" Then
                    checkChePaoA10E10Block()
                ElseIf positionOneTwo = "a10f10" Then
                    checkChePaoA10F10Block()
                ElseIf positionOneTwo = "a10g10" Then
                    checkChePaoA10G10Block()
                ElseIf positionOneTwo = "a10h10" Then
                    checkChePaoA10H10Block()
                ElseIf positionOneTwo = "a10i10" Then
                    checkChePaoA10I10Block()
                End If
            Case "b10"
                If positionOneTwo = "b10b1" Then
                    checkChePaoB10B1Block()
                ElseIf positionOneTwo = "b10b2" Then
                    checkChePaoB10B2Block()
                ElseIf positionOneTwo = "b10b3" Then
                    checkChePaoB10B3Block()
                ElseIf positionOneTwo = "b10b4" Then
                    checkChePaoB10B4Block()
                ElseIf positionOneTwo = "b10b5" Then
                    checkChePaoB10B5Block()
                ElseIf positionOneTwo = "b10b6" Then
                    checkChePaoB10B6Block()
                ElseIf positionOneTwo = "b10b7" Then
                    checkChePaoB10B7Block()
                ElseIf positionOneTwo = "b10b8" Then
                    checkChePaoB10B8Block()
                ElseIf positionOneTwo = "b10d10" Then
                    checkChePaoB10D10Block()
                ElseIf positionOneTwo = "b10e10" Then
                    checkChePaoB10E10Block()
                ElseIf positionOneTwo = "b10f10" Then
                    checkChePaoB10F10Block()
                ElseIf positionOneTwo = "b10g10" Then
                    checkChePaoB10G10Block()
                ElseIf positionOneTwo = "b10h10" Then
                    checkChePaoB10H10Block()
                ElseIf positionOneTwo = "b10i10" Then
                    checkChePaoB10I10Block()
                End If
            Case "c10"
                If positionOneTwo = "c10c1" Then
                    checkChePaoC10C1Block()
                ElseIf positionOneTwo = "c10c2" Then
                    checkChePaoC10C2Block()
                ElseIf positionOneTwo = "c10c3" Then
                    checkChePaoC10C3Block()
                ElseIf positionOneTwo = "c10c4" Then
                    checkChePaoC10C4Block()
                ElseIf positionOneTwo = "c10c5" Then
                    checkChePaoC10C5Block()
                ElseIf positionOneTwo = "c10c6" Then
                    checkChePaoC10C6Block()
                ElseIf positionOneTwo = "c10c7" Then
                    checkChePaoC10C7Block()
                ElseIf positionOneTwo = "c10c8" Then
                    checkChePaoC10C8Block()
                ElseIf positionOneTwo = "c10a10" Then
                    checkChePaoC10A10Block()
                ElseIf positionOneTwo = "c10e10" Then
                    checkChePaoC10E10Block()
                ElseIf positionOneTwo = "c10f10" Then
                    checkChePaoC10F10Block()
                ElseIf positionOneTwo = "c10g10" Then
                    checkChePaoC10G10Block()
                ElseIf positionOneTwo = "c10h10" Then
                    checkChePaoC10H10Block()
                ElseIf positionOneTwo = "c10i10" Then
                    checkChePaoC10I10Block()
                End If
            Case "d10"
                If positionOneTwo = "d10d1" Then
                    checkChePaoD10D1Block()
                ElseIf positionOneTwo = "d10d2" Then
                    checkChePaoD10D2Block()
                ElseIf positionOneTwo = "d10d3" Then
                    checkChePaoD10D3Block()
                ElseIf positionOneTwo = "d10d4" Then
                    checkChePaoD10D4Block()
                ElseIf positionOneTwo = "d10d5" Then
                    checkChePaoD10D5Block()
                ElseIf positionOneTwo = "d10d6" Then
                    checkChePaoD10D6Block()
                ElseIf positionOneTwo = "d10d7" Then
                    checkChePaoD10D7Block()
                ElseIf positionOneTwo = "d10d8" Then
                    checkChePaoD10D8Block()
                ElseIf positionOneTwo = "d10a10" Then
                    checkChePaoD10A10Block()
                ElseIf positionOneTwo = "d10b10" Then
                    checkChePaoD10B10Block()
                ElseIf positionOneTwo = "d10f10" Then
                    checkChePaoD10F10Block()
                ElseIf positionOneTwo = "d10g10" Then
                    checkChePaoD10G10Block()
                ElseIf positionOneTwo = "d10h10" Then
                    checkChePaoD10H10Block()
                ElseIf positionOneTwo = "d10i10" Then
                    checkChePaoD10I10Block()
                End If
            Case "e10"
                If positionOneTwo = "e10e1" Then
                    checkChePaoE10E1Block()
                ElseIf positionOneTwo = "e10e2" Then
                    checkChePaoE10E2Block()
                ElseIf positionOneTwo = "e10e3" Then
                    checkChePaoE10E3Block()
                ElseIf positionOneTwo = "e10e4" Then
                    checkChePaoE10E4Block()
                ElseIf positionOneTwo = "e10e5" Then
                    checkChePaoE10E5Block()
                ElseIf positionOneTwo = "e10e6" Then
                    checkChePaoE10E6Block()
                ElseIf positionOneTwo = "e10e7" Then
                    checkChePaoE10E7Block()
                ElseIf positionOneTwo = "e10e8" Then
                    checkChePaoE10E8Block()
                ElseIf positionOneTwo = "e10a10" Then
                    checkChePaoE10A10Block()
                ElseIf positionOneTwo = "e10b10" Then
                    checkChePaoE10B10Block()
                ElseIf positionOneTwo = "e10c10" Then
                    checkChePaoE10C10Block()
                ElseIf positionOneTwo = "e10g10" Then
                    checkChePaoE10G10Block()
                ElseIf positionOneTwo = "e10h10" Then
                    checkChePaoE10H10Block()
                ElseIf positionOneTwo = "e10i10" Then
                    checkChePaoE10I10Block()
                End If
            Case "f10"
                If positionOneTwo = "f10f1" Then
                    checkChePaoF10F1Block()
                ElseIf positionOneTwo = "f10f2" Then
                    checkChePaoF10F2Block()
                ElseIf positionOneTwo = "f10f3" Then
                    checkChePaoF10F3Block()
                ElseIf positionOneTwo = "f10f4" Then
                    checkChePaoF10F4Block()
                ElseIf positionOneTwo = "f10f5" Then
                    checkChePaoF10F5Block()
                ElseIf positionOneTwo = "f10f6" Then
                    checkChePaoF10F6Block()
                ElseIf positionOneTwo = "f10f7" Then
                    checkChePaoF10F7Block()
                ElseIf positionOneTwo = "f10f8" Then
                    checkChePaoF10F8Block()
                ElseIf positionOneTwo = "f10a10" Then
                    checkChePaoF10A10Block()
                ElseIf positionOneTwo = "f10b10" Then
                    checkChePaoF10B10Block()
                ElseIf positionOneTwo = "f10c10" Then
                    checkChePaoF10C10Block()
                ElseIf positionOneTwo = "f10d10" Then
                    checkChePaoF10D10Block()
                ElseIf positionOneTwo = "f10h10" Then
                    checkChePaoF10H10Block()
                ElseIf positionOneTwo = "f10i10" Then
                    checkChePaoF10I10Block()
                End If
            Case "g10"
                If positionOneTwo = "g10g1" Then
                    checkChePaoG10G1Block()
                ElseIf positionOneTwo = "g10g2" Then
                    checkChePaoG10G2Block()
                ElseIf positionOneTwo = "g10g3" Then
                    checkChePaoG10G3Block()
                ElseIf positionOneTwo = "g10g4" Then
                    checkChePaoG10G4Block()
                ElseIf positionOneTwo = "g10g5" Then
                    checkChePaoG10G5Block()
                ElseIf positionOneTwo = "g10g6" Then
                    checkChePaoG10G6Block()
                ElseIf positionOneTwo = "g10g7" Then
                    checkChePaoG10G7Block()
                ElseIf positionOneTwo = "g10g8" Then
                    checkChePaoG10G8Block()
                ElseIf positionOneTwo = "g10a10" Then
                    checkChePaoG10A10Block()
                ElseIf positionOneTwo = "g10b10" Then
                    checkChePaoG10B10Block()
                ElseIf positionOneTwo = "g10c10" Then
                    checkChePaoG10C10Block()
                ElseIf positionOneTwo = "g10d10" Then
                    checkChePaoG10D10Block()
                ElseIf positionOneTwo = "g10e10" Then
                    checkChePaoG10E10Block()
                ElseIf positionOneTwo = "g10i10" Then
                    checkChePaoG10I10Block()
                End If
            Case "h10"
                If positionOneTwo = "h10h1" Then
                    checkChePaoH10H1Block()
                ElseIf positionOneTwo = "h10h2" Then
                    checkChePaoH10H2Block()
                ElseIf positionOneTwo = "h10h3" Then
                    checkChePaoH10H3Block()
                ElseIf positionOneTwo = "h10h4" Then
                    checkChePaoH10H4Block()
                ElseIf positionOneTwo = "h10h5" Then
                    checkChePaoH10H5Block()
                ElseIf positionOneTwo = "h10h6" Then
                    checkChePaoH10H6Block()
                ElseIf positionOneTwo = "h10h7" Then
                    checkChePaoH10H7Block()
                ElseIf positionOneTwo = "h10h8" Then
                    checkChePaoH10H8Block()
                ElseIf positionOneTwo = "h10a10" Then
                    checkChePaoH10A10Block()
                ElseIf positionOneTwo = "h10b10" Then
                    checkChePaoH10B10Block()
                ElseIf positionOneTwo = "h10c10" Then
                    checkChePaoH10C10Block()
                ElseIf positionOneTwo = "h10d10" Then
                    checkChePaoH10D10Block()
                ElseIf positionOneTwo = "h10e10" Then
                    checkChePaoH10E10Block()
                ElseIf positionOneTwo = "h10f10" Then
                    checkChePaoH10F10Block()
                End If
            Case "i10"
                If positionOneTwo = "i10i1" Then
                    checkChePaoI10I1Block()
                ElseIf positionOneTwo = "i10i2" Then
                    checkChePaoI10I2Block()
                ElseIf positionOneTwo = "i10i3" Then
                    checkChePaoI10I3Block()
                ElseIf positionOneTwo = "i10i4" Then
                    checkChePaoI10I4Block()
                ElseIf positionOneTwo = "i10i5" Then
                    checkChePaoI10I5Block()
                ElseIf positionOneTwo = "i10i6" Then
                    checkChePaoI10I6Block()
                ElseIf positionOneTwo = "i10i7" Then
                    checkChePaoI10I7Block()
                ElseIf positionOneTwo = "i10i8" Then
                    checkChePaoI10I8Block()
                ElseIf positionOneTwo = "i10a10" Then
                    checkChePaoI10A10Block()
                ElseIf positionOneTwo = "i10b10" Then
                    checkChePaoI10B10Block()
                ElseIf positionOneTwo = "i10c10" Then
                    checkChePaoI10C10Block()
                ElseIf positionOneTwo = "i10d10" Then
                    checkChePaoI10D10Block()
                ElseIf positionOneTwo = "i10e10" Then
                    checkChePaoI10E10Block()
                ElseIf positionOneTwo = "i10f10" Then
                    checkChePaoI10F10Block()
                ElseIf positionOneTwo = "i10g10" Then
                    checkChePaoI10G10Block()
                End If
        End Select
    End Sub
    Private Sub CheckMaBlock()
        If positionOne = "a1" Then
            checkMaA1Block()
        ElseIf positionOne = "b1" Then
            checkMaB1Block()
        ElseIf positionOne = "c1" Then
            checkMaC1Block()
        ElseIf positionOne = "d1" Then
            checkMaD1Block()
        ElseIf positionOne = "e1" Then
            checkMaE1Block()
        ElseIf positionOne = "f1" Then
            checkMaF1Block()
        ElseIf positionOne = "g1" Then
            checkMaG1Block()
        ElseIf positionOne = "h1" Then
            checkMaH1Block()
        ElseIf positionOne = "i1" Then
            checkMaI1Block()
        ElseIf positionOne = "a2" Then
            checkMaA2Block()
        ElseIf positionOne = "b2" Then
            checkMaB2Block()
        ElseIf positionOne = "c2" Then
            checkMaC2Block()
        ElseIf positionOne = "d2" Then
            checkMaD2Block()
        ElseIf positionOne = "e2" Then
            checkMaE2Block()
        ElseIf positionOne = "f2" Then
            checkMaF2Block()
        ElseIf positionOne = "g2" Then
            checkMaG2Block()
        ElseIf positionOne = "h2" Then
            checkMaH2Block()
        ElseIf positionOne = "i2" Then
            checkMaI2Block()
        ElseIf positionOne = "a3" Then
            checkMaA3Block()
        ElseIf positionOne = "b3" Then
            checkMaB3Block()
        ElseIf positionOne = "c3" Then
            checkMaC3Block()
        ElseIf positionOne = "d3" Then
            checkMaD3Block()
        ElseIf positionOne = "e3" Then
            checkMaE3Block()
        ElseIf positionOne = "f3" Then
            checkMaF3Block()
        ElseIf positionOne = "g3" Then
            checkMaG3Block()
        ElseIf positionOne = "h3" Then
            checkMaH3Block()
        ElseIf positionOne = "i3" Then
            checkMaI3Block()
        ElseIf positionOne = "a4" Then
            checkMaA4Block()
        ElseIf positionOne = "b4" Then
            checkMaB4Block()
        ElseIf positionOne = "c4" Then
            checkMaC4Block()
        ElseIf positionOne = "d4" Then
            checkMaD4Block()
        ElseIf positionOne = "e4" Then
            checkMaE4Block()
        ElseIf positionOne = "f4" Then
            checkMaF4Block()
        ElseIf positionOne = "g4" Then
            checkMaG4Block()
        ElseIf positionOne = "h4" Then
            checkMaH4Block()
        ElseIf positionOne = "i4" Then
            checkMaI4Block()
        ElseIf positionOne = "a5" Then
            checkMaA5Block()
        ElseIf positionOne = "b5" Then
            checkMaB5Block()
        ElseIf positionOne = "c5" Then
            checkMaC5Block()
        ElseIf positionOne = "d5" Then
            checkMaD5Block()
        ElseIf positionOne = "e5" Then
            checkMaE5Block()
        ElseIf positionOne = "f5" Then
            checkMaF5Block()
        ElseIf positionOne = "g5" Then
            checkMaG5Block()
        ElseIf positionOne = "h5" Then
            checkMaH5Block()
        ElseIf positionOne = "i5" Then
            checkMaI5Block()
        ElseIf positionOne = "a6" Then
            checkMaA6Block()
        ElseIf positionOne = "b6" Then
            checkMaB6Block()
        ElseIf positionOne = "c6" Then
            checkMaC6Block()
        ElseIf positionOne = "d6" Then
            checkMaD6Block()
        ElseIf positionOne = "e6" Then
            checkMaE6Block()
        ElseIf positionOne = "f6" Then
            checkMaF6Block()
        ElseIf positionOne = "g6" Then
            checkMaG6Block()
        ElseIf positionOne = "h6" Then
            checkMaH6Block()
        ElseIf positionOne = "i6" Then
            checkMaI6Block()
        ElseIf positionOne = "a7" Then
            checkMaA7Block()
        ElseIf positionOne = "b7" Then
            checkMaB7Block()
        ElseIf positionOne = "c7" Then
            checkMaC7Block()
        ElseIf positionOne = "d7" Then
            checkMaD7Block()
        ElseIf positionOne = "e7" Then
            checkMaE7Block()
        ElseIf positionOne = "f7" Then
            checkMaF7Block()
        ElseIf positionOne = "g7" Then
            checkMaG7Block()
        ElseIf positionOne = "h7" Then
            checkMaH7Block()
        ElseIf positionOne = "i7" Then
            checkMaI7Block()
        ElseIf positionOne = "a8" Then
            checkMaA8Block()
        ElseIf positionOne = "b8" Then
            checkMaB8Block()
        ElseIf positionOne = "c8" Then
            checkMaC8Block()
        ElseIf positionOne = "d8" Then
            checkMaD8Block()
        ElseIf positionOne = "e8" Then
            checkMaE8Block()
        ElseIf positionOne = "f8" Then
            checkMaF8Block()
        ElseIf positionOne = "g8" Then
            checkMaG8Block()
        ElseIf positionOne = "h8" Then
            checkMaH8Block()
        ElseIf positionOne = "i8" Then
            checkMaI8Block()
        ElseIf positionOne = "a9" Then
            checkMaA9Block()
        ElseIf positionOne = "b9" Then
            checkMaB9Block()
        ElseIf positionOne = "c9" Then
            checkMaC9Block()
        ElseIf positionOne = "d9" Then
            checkMaD9Block()
        ElseIf positionOne = "e9" Then
            checkMaE9Block()
        ElseIf positionOne = "f9" Then
            checkMaF9Block()
        ElseIf positionOne = "g9" Then
            checkMaG9Block()
        ElseIf positionOne = "h9" Then
            checkMaH9Block()
        ElseIf positionOne = "i9" Then
            checkMaI9Block()
        ElseIf positionOne = "a10" Then
            checkMaA10Block()
        ElseIf positionOne = "b10" Then
            checkMaB10Block()
        ElseIf positionOne = "c10" Then
            checkMaC10Block()
        ElseIf positionOne = "d10" Then
            checkMaD10Block()
        ElseIf positionOne = "e10" Then
            checkMaE10Block()
        ElseIf positionOne = "f10" Then
            checkMaF10Block()
        ElseIf positionOne = "g10" Then
            checkMaG10Block()
        ElseIf positionOne = "h10" Then
            checkMaH10Block()
        ElseIf positionOne = "i10" Then
            checkMaI10Block()
        End If
    End Sub
    Private Sub CheckWhiteXiangBlock()
        If positionOne = "c10" Then
            checkWhiteXiangC10Block()
        ElseIf positionOne = "g10" Then
            checkWhiteXiangG10Block()
        ElseIf positionOne = "a8" Then
            checkWhiteXiangA8Block()
        ElseIf positionOne = "e8" Then
            checkWhiteXiangE8Block()
        ElseIf positionOne = "i8" Then
            checkWhiteXiangI8Block()
        ElseIf positionOne = "c6" Then
            checkWhiteXiangC6Block()
        ElseIf positionOne = "g6" Then
            checkWhiteXiangG6Block()
        End If
    End Sub
    Private Sub CheckBlackXiangBlock()
        If positionOne = "c1" Then
            checkBlackXiangC1Block()
        ElseIf positionOne = "g1" Then
            checkBlackXiangG1Block()
        ElseIf positionOne = "a3" Then
            checkBlackXiangA3Block()
        ElseIf positionOne = "e3" Then
            checkBlackXiangE3Block()
        ElseIf positionOne = "i3" Then
            checkBlackXiangI3Block()
        ElseIf positionOne = "c5" Then
            checkBlackXiangC5Block()
        ElseIf positionOne = "g5" Then
            checkBlackXiangG5Block()
        End If
    End Sub

    Private Sub CheckA()
        If positionOne = "a1" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckA1A()
                Case "b"
                    CheckA1B()
                Case "c"
                    CheckA1C()
                Case "d"
                    CheckA1D()
                Case "e"
                    CheckA1E()
                Case "f"
                    CheckA1F()
                Case "g"
                    CheckA1G()
                Case "h"
                    CheckA1H()
                Case "i"
                    CheckA1I()
            End Select

        ElseIf positionOne = "a2" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckA2A()
                Case "b"
                    CheckA2B()
                Case "c"
                    CheckA2C()
                Case "d"
                    CheckA2D()
                Case "e"
                    CheckA2E()
                Case "f"
                    CheckA2F()
                Case "g"
                    CheckA2G()
                Case "h"
                    CheckA2H()
                Case "i"
                    CheckA2I()
            End Select

        ElseIf positionOne = "a3" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckA3A()
                Case "b"
                    CheckA3B()
                Case "c"
                    CheckA3C()
                Case "d"
                    CheckA3D()
                Case "e"
                    CheckA3E()
                Case "f"
                    CheckA3F()
                Case "g"
                    CheckA3G()
                Case "h"
                    CheckA3H()
                Case "i"
                    CheckA3I()
            End Select

        ElseIf positionOne = "a4" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckA4A()
                Case "b"
                    CheckA4B()
                Case "c"
                    CheckA4C()
                Case "d"
                    CheckA4D()
                Case "e"
                    CheckA4E()
                Case "f"
                    CheckA4F()
                Case "g"
                    CheckA4G()
                Case "h"
                    CheckA4H()
                Case "i"
                    CheckA4I()
            End Select

        ElseIf positionOne = "a5" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckA5A()
                Case "b"
                    CheckA5B()
                Case "c"
                    CheckA5C()
                Case "d"
                    CheckA5D()
                Case "e"
                    CheckA5E()
                Case "f"
                    CheckA5F()
                Case "g"
                    CheckA5G()
                Case "h"
                    CheckA5H()
                Case "i"
                    CheckA5I()
            End Select

        ElseIf positionOne = "a6" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckA6A()
                Case "b"
                    CheckA6B()
                Case "c"
                    CheckA6C()
                Case "d"
                    CheckA6D()
                Case "e"
                    CheckA6E()
                Case "f"
                    CheckA6F()
                Case "g"
                    CheckA6G()
                Case "h"
                    CheckA6H()
                Case "i"
                    CheckA6I()
            End Select

        ElseIf positionOne = "a7" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckA7A()
                Case "b"
                    CheckA7B()
                Case "c"
                    CheckA7C()
                Case "d"
                    CheckA7D()
                Case "e"
                    CheckA7E()
                Case "f"
                    CheckA7F()
                Case "g"
                    CheckA7G()
                Case "h"
                    CheckA7H()
                Case "i"
                    CheckA7I()
            End Select

        ElseIf positionOne = "a8" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckA8A()
                Case "b"
                    CheckA8B()
                Case "c"
                    CheckA8C()
                Case "d"
                    CheckA8D()
                Case "e"
                    CheckA8E()
                Case "f"
                    CheckA8F()
                Case "g"
                    CheckA8G()
                Case "h"
                    CheckA8H()
                Case "i"
                    CheckA8I()
            End Select

        ElseIf positionOne = "a9" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckA9A()
                Case "b"
                    CheckA9B()
                Case "c"
                    CheckA9C()
                Case "d"
                    CheckA9D()
                Case "e"
                    CheckA9E()
                Case "f"
                    CheckA9F()
                Case "g"
                    CheckA9G()
                Case "h"
                    CheckA9H()
                Case "i"
                    CheckA9I()
            End Select

        ElseIf positionOne = "a10" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckA10A()
                Case "b"
                    CheckA10B()
                Case "c"
                    CheckA10C()
                Case "d"
                    CheckA10D()
                Case "e"
                    CheckA10E()
                Case "f"
                    CheckA10F()
                Case "g"
                    CheckA10G()
                Case "h"
                    CheckA10H()
                Case "i"
                    CheckA10I()
            End Select

        End If
    End Sub
    Private Sub CheckB()
        If positionOne = "b1" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckB1A()
                Case "b"
                    CheckB1B()
                Case "c"
                    CheckB1C()
                Case "d"
                    CheckB1D()
                Case "e"
                    CheckB1E()
                Case "f"
                    CheckB1F()
                Case "g"
                    CheckB1G()
                Case "h"
                    CheckB1H()
                Case "i"
                    CheckB1I()
            End Select

        ElseIf positionOne = "b2" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckB2A()
                Case "b"
                    CheckB2B()
                Case "c"
                    CheckB2C()
                Case "d"
                    CheckB2D()
                Case "e"
                    CheckB2E()
                Case "f"
                    CheckB2F()
                Case "g"
                    CheckB2G()
                Case "h"
                    CheckB2H()
                Case "i"
                    CheckB2I()
            End Select

        ElseIf positionOne = "b3" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckB3A()
                Case "b"
                    CheckB3B()
                Case "c"
                    CheckB3C()
                Case "d"
                    CheckB3D()
                Case "e"
                    CheckB3E()
                Case "f"
                    CheckB3F()
                Case "g"
                    CheckB3G()
                Case "h"
                    CheckB3H()
                Case "i"
                    CheckB3I()
            End Select

        ElseIf positionOne = "b4" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckB4A()
                Case "b"
                    CheckB4B()
                Case "c"
                    CheckB4C()
                Case "d"
                    CheckB4D()
                Case "e"
                    CheckB4E()
                Case "f"
                    CheckB4F()
                Case "g"
                    CheckB4G()
                Case "h"
                    CheckB4H()
                Case "i"
                    CheckB4I()
            End Select

        ElseIf positionOne = "b5" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckB5A()
                Case "b"
                    CheckB5B()
                Case "c"
                    CheckB5C()
                Case "d"
                    CheckB5D()
                Case "e"
                    CheckB5E()
                Case "f"
                    CheckB5F()
                Case "g"
                    CheckB5G()
                Case "h"
                    CheckB5H()
                Case "i"
                    CheckB5I()
            End Select

        ElseIf positionOne = "b6" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckB6A()
                Case "b"
                    CheckB6B()
                Case "c"
                    CheckB6C()
                Case "d"
                    CheckB6D()
                Case "e"
                    CheckB6E()
                Case "f"
                    CheckB6F()
                Case "g"
                    CheckB6G()
                Case "h"
                    CheckB6H()
                Case "i"
                    CheckB6I()
            End Select

        ElseIf positionOne = "b7" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckB7A()
                Case "b"
                    CheckB7B()
                Case "c"
                    CheckB7C()
                Case "d"
                    CheckB7D()
                Case "e"
                    CheckB7E()
                Case "f"
                    CheckB7F()
                Case "g"
                    CheckB7G()
                Case "h"
                    CheckB7H()
                Case "i"
                    CheckB7I()
            End Select

        ElseIf positionOne = "b8" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckB8A()
                Case "b"
                    CheckB8B()
                Case "c"
                    CheckB8C()
                Case "d"
                    CheckB8D()
                Case "e"
                    CheckB8E()
                Case "f"
                    CheckB8F()
                Case "g"
                    CheckB8G()
                Case "h"
                    CheckB8H()
                Case "i"
                    CheckB8I()
            End Select

        ElseIf positionOne = "b9" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckB9A()
                Case "b"
                    CheckB9B()
                Case "c"
                    CheckB9C()
                Case "d"
                    CheckB9D()
                Case "e"
                    CheckB9E()
                Case "f"
                    CheckB9F()
                Case "g"
                    CheckB9G()
                Case "h"
                    CheckB9H()
                Case "i"
                    CheckB9I()
            End Select

        ElseIf positionOne = "b10" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckB10A()
                Case "b"
                    CheckB10B()
                Case "c"
                    CheckB10C()
                Case "d"
                    CheckB10D()
                Case "e"
                    CheckB10E()
                Case "f"
                    CheckB10F()
                Case "g"
                    CheckB10G()
                Case "h"
                    CheckB10H()
                Case "i"
                    CheckB10I()
            End Select

        End If
    End Sub
    Private Sub CheckC()
        If positionOne = "c1" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckC1A()
                Case "b"
                    CheckC1B()
                Case "c"
                    CheckC1C()
                Case "d"
                    CheckC1D()
                Case "e"
                    CheckC1E()
                Case "f"
                    CheckC1F()
                Case "g"
                    CheckC1G()
                Case "h"
                    CheckC1H()
                Case "i"
                    CheckC1I()
            End Select

        ElseIf positionOne = "c2" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckC2A()
                Case "b"
                    CheckC2B()
                Case "c"
                    CheckC2C()
                Case "d"
                    CheckC2D()
                Case "e"
                    CheckC2E()
                Case "f"
                    CheckC2F()
                Case "g"
                    CheckC2G()
                Case "h"
                    CheckC2H()
                Case "i"
                    CheckC2I()
            End Select

        ElseIf positionOne = "c3" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckC3A()
                Case "b"
                    CheckC3B()
                Case "c"
                    CheckC3C()
                Case "d"
                    CheckC3D()
                Case "e"
                    CheckC3E()
                Case "f"
                    CheckC3F()
                Case "g"
                    CheckC3G()
                Case "h"
                    CheckC3H()
                Case "i"
                    CheckC3I()
            End Select

        ElseIf positionOne = "c4" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckC4A()
                Case "b"
                    CheckC4B()
                Case "c"
                    CheckC4C()
                Case "d"
                    CheckC4D()
                Case "e"
                    CheckC4E()
                Case "f"
                    CheckC4F()
                Case "g"
                    CheckC4G()
                Case "h"
                    CheckC4H()
                Case "i"
                    CheckC4I()
            End Select

        ElseIf positionOne = "c5" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckC5A()
                Case "b"
                    CheckC5B()
                Case "c"
                    CheckC5C()
                Case "d"
                    CheckC5D()
                Case "e"
                    CheckC5E()
                Case "f"
                    CheckC5F()
                Case "g"
                    CheckC5G()
                Case "h"
                    CheckC5H()
                Case "i"
                    CheckC5I()
            End Select

        ElseIf positionOne = "c6" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckC6A()
                Case "b"
                    CheckC6B()
                Case "c"
                    CheckC6C()
                Case "d"
                    CheckC6D()
                Case "e"
                    CheckC6E()
                Case "f"
                    CheckC6F()
                Case "g"
                    CheckC6G()
                Case "h"
                    CheckC6H()
                Case "i"
                    CheckC6I()
            End Select

        ElseIf positionOne = "c7" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckC7A()
                Case "b"
                    CheckC7B()
                Case "c"
                    CheckC7C()
                Case "d"
                    CheckC7D()
                Case "e"
                    CheckC7E()
                Case "f"
                    CheckC7F()
                Case "g"
                    CheckC7G()
                Case "h"
                    CheckC7H()
                Case "i"
                    CheckC7I()
            End Select

        ElseIf positionOne = "c8" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckC8A()
                Case "b"
                    CheckC8B()
                Case "c"
                    CheckC8C()
                Case "d"
                    CheckC8D()
                Case "e"
                    CheckC8E()
                Case "f"
                    CheckC8F()
                Case "g"
                    CheckC8G()
                Case "h"
                    CheckC8H()
                Case "i"
                    CheckC8I()
            End Select

        ElseIf positionOne = "c9" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckC9A()
                Case "b"
                    CheckC9B()
                Case "c"
                    CheckC9C()
                Case "d"
                    CheckC9D()
                Case "e"
                    CheckC9E()
                Case "f"
                    CheckC9F()
                Case "g"
                    CheckC9G()
                Case "h"
                    CheckC9H()
                Case "i"
                    CheckC9I()
            End Select

        ElseIf positionOne = "c10" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckC10A()
                Case "b"
                    CheckC10B()
                Case "c"
                    CheckC10C()
                Case "d"
                    CheckC10D()
                Case "e"
                    CheckC10E()
                Case "f"
                    CheckC10F()
                Case "g"
                    CheckC10G()
                Case "h"
                    CheckC10H()
                Case "i"
                    CheckC10I()
            End Select

        End If
    End Sub
    Private Sub CheckD()
        If positionOne = "d1" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckD1A()
                Case "b"
                    CheckD1B()
                Case "c"
                    CheckD1C()
                Case "d"
                    CheckD1D()
                Case "e"
                    CheckD1E()
                Case "f"
                    CheckD1F()
                Case "g"
                    CheckD1G()
                Case "h"
                    CheckD1H()
                Case "i"
                    CheckD1I()
            End Select

        ElseIf positionOne = "d2" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckD2A()
                Case "b"
                    CheckD2B()
                Case "c"
                    CheckD2C()
                Case "d"
                    CheckD2D()
                Case "e"
                    CheckD2E()
                Case "f"
                    CheckD2F()
                Case "g"
                    CheckD2G()
                Case "h"
                    CheckD2H()
                Case "i"
                    CheckD2I()
            End Select

        ElseIf positionOne = "d3" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckD3A()
                Case "b"
                    CheckD3B()
                Case "c"
                    CheckD3C()
                Case "d"
                    CheckD3D()
                Case "e"
                    CheckD3E()
                Case "f"
                    CheckD3F()
                Case "g"
                    CheckD3G()
                Case "h"
                    CheckD3H()
                Case "i"
                    CheckD3I()
            End Select

        ElseIf positionOne = "d4" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckD4A()
                Case "b"
                    CheckD4B()
                Case "c"
                    CheckD4C()
                Case "d"
                    CheckD4D()
                Case "e"
                    CheckD4E()
                Case "f"
                    CheckD4F()
                Case "g"
                    CheckD4G()
                Case "h"
                    CheckD4H()
                Case "i"
                    CheckD4I()
            End Select

        ElseIf positionOne = "d5" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckD5A()
                Case "b"
                    CheckD5B()
                Case "c"
                    CheckD5C()
                Case "d"
                    CheckD5D()
                Case "e"
                    CheckD5E()
                Case "f"
                    CheckD5F()
                Case "g"
                    CheckD5G()
                Case "h"
                    CheckD5H()
                Case "i"
                    CheckD5I()
            End Select

        ElseIf positionOne = "d6" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckD6A()
                Case "b"
                    CheckD6B()
                Case "c"
                    CheckD6C()
                Case "d"
                    CheckD6D()
                Case "e"
                    CheckD6E()
                Case "f"
                    CheckD6F()
                Case "g"
                    CheckD6G()
                Case "h"
                    CheckD6H()
                Case "i"
                    CheckD6I()
            End Select

        ElseIf positionOne = "d7" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckD7A()
                Case "b"
                    CheckD7B()
                Case "c"
                    CheckD7C()
                Case "d"
                    CheckD7D()
                Case "e"
                    CheckD7E()
                Case "f"
                    CheckD7F()
                Case "g"
                    CheckD7G()
                Case "h"
                    CheckD7H()
                Case "i"
                    CheckD7I()
            End Select

        ElseIf positionOne = "d8" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckD8A()
                Case "b"
                    CheckD8B()
                Case "c"
                    CheckD8C()
                Case "d"
                    CheckD8D()
                Case "e"
                    CheckD8E()
                Case "f"
                    CheckD8F()
                Case "g"
                    CheckD8G()
                Case "h"
                    CheckD8H()
                Case "i"
                    CheckD8I()
            End Select

        ElseIf positionOne = "d9" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckD9A()
                Case "b"
                    CheckD9B()
                Case "c"
                    CheckD9C()
                Case "d"
                    CheckD9D()
                Case "e"
                    CheckD9E()
                Case "f"
                    CheckD9F()
                Case "g"
                    CheckD9G()
                Case "h"
                    CheckD9H()
                Case "i"
                    CheckD9I()
            End Select

        ElseIf positionOne = "d10" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckD10A()
                Case "b"
                    CheckD10B()
                Case "c"
                    CheckD10C()
                Case "d"
                    CheckD10D()
                Case "e"
                    CheckD10E()
                Case "f"
                    CheckD10F()
                Case "g"
                    CheckD10G()
                Case "h"
                    CheckD10H()
                Case "i"
                    CheckD10I()
            End Select

        End If
    End Sub
    Private Sub CheckE()
        If positionOne = "e1" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckE1A()
                Case "b"
                    CheckE1B()
                Case "c"
                    CheckE1C()
                Case "d"
                    CheckE1D()
                Case "e"
                    CheckE1E()
                Case "f"
                    CheckE1F()
                Case "g"
                    CheckE1G()
                Case "h"
                    CheckE1H()
                Case "i"
                    CheckE1I()
            End Select

        ElseIf positionOne = "e2" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckE2A()
                Case "b"
                    CheckE2B()
                Case "c"
                    CheckE2C()
                Case "d"
                    CheckE2D()
                Case "e"
                    CheckE2E()
                Case "f"
                    CheckE2F()
                Case "g"
                    CheckE2G()
                Case "h"
                    CheckE2H()
                Case "i"
                    CheckE2I()
            End Select

        ElseIf positionOne = "e3" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckE3A()
                Case "b"
                    CheckE3B()
                Case "c"
                    CheckE3C()
                Case "d"
                    CheckE3D()
                Case "e"
                    CheckE3E()
                Case "f"
                    CheckE3F()
                Case "g"
                    CheckE3G()
                Case "h"
                    CheckE3H()
                Case "i"
                    CheckE3I()
            End Select

        ElseIf positionOne = "e4" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckE4A()
                Case "b"
                    CheckE4B()
                Case "c"
                    CheckE4C()
                Case "d"
                    CheckE4D()
                Case "e"
                    CheckE4E()
                Case "f"
                    CheckE4F()
                Case "g"
                    CheckE4G()
                Case "h"
                    CheckE4H()
                Case "i"
                    CheckE4I()
            End Select

        ElseIf positionOne = "e5" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckE5A()
                Case "b"
                    CheckE5B()
                Case "c"
                    CheckE5C()
                Case "d"
                    CheckE5D()
                Case "e"
                    CheckE5E()
                Case "f"
                    CheckE5F()
                Case "g"
                    CheckE5G()
                Case "h"
                    CheckE5H()
                Case "i"
                    CheckE5I()
            End Select

        ElseIf positionOne = "e6" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckE6A()
                Case "b"
                    CheckE6B()
                Case "c"
                    CheckE6C()
                Case "d"
                    CheckE6D()
                Case "e"
                    CheckE6E()
                Case "f"
                    CheckE6F()
                Case "g"
                    CheckE6G()
                Case "h"
                    CheckE6H()
                Case "i"
                    CheckE6I()
            End Select

        ElseIf positionOne = "e7" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckE7A()
                Case "b"
                    CheckE7B()
                Case "c"
                    CheckE7C()
                Case "d"
                    CheckE7D()
                Case "e"
                    CheckE7E()
                Case "f"
                    CheckE7F()
                Case "g"
                    CheckE7G()
                Case "h"
                    CheckE7H()
                Case "i"
                    CheckE7I()
            End Select

        ElseIf positionOne = "e8" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckE8A()
                Case "b"
                    CheckE8B()
                Case "c"
                    CheckE8C()
                Case "d"
                    CheckE8D()
                Case "e"
                    CheckE8E()
                Case "f"
                    CheckE8F()
                Case "g"
                    CheckE8G()
                Case "h"
                    CheckE8H()
                Case "i"
                    CheckE8I()
            End Select

        ElseIf positionOne = "e9" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckE9A()
                Case "b"
                    CheckE9B()
                Case "c"
                    CheckE9C()
                Case "d"
                    CheckE9D()
                Case "e"
                    CheckE9E()
                Case "f"
                    CheckE9F()
                Case "g"
                    CheckE9G()
                Case "h"
                    CheckE9H()
                Case "i"
                    CheckE9I()
            End Select

        ElseIf positionOne = "e10" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckE10A()
                Case "b"
                    CheckE10B()
                Case "c"
                    CheckE10C()
                Case "d"
                    CheckE10D()
                Case "e"
                    CheckE10E()
                Case "f"
                    CheckE10F()
                Case "g"
                    CheckE10G()
                Case "h"
                    CheckE10H()
                Case "i"
                    CheckE10I()
            End Select

        End If
    End Sub
    Private Sub CheckF()
        If positionOne = "f1" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckF1A()
                Case "b"
                    CheckF1B()
                Case "c"
                    CheckF1C()
                Case "d"
                    CheckF1D()
                Case "e"
                    CheckF1E()
                Case "f"
                    CheckF1F()
                Case "g"
                    CheckF1G()
                Case "h"
                    CheckF1H()
                Case "i"
                    CheckF1I()
            End Select

        ElseIf positionOne = "f2" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckF2A()
                Case "b"
                    CheckF2B()
                Case "c"
                    CheckF2C()
                Case "d"
                    CheckF2D()
                Case "e"
                    CheckF2E()
                Case "f"
                    CheckF2F()
                Case "g"
                    CheckF2G()
                Case "h"
                    CheckF2H()
                Case "i"
                    CheckF2I()
            End Select

        ElseIf positionOne = "f3" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckF3A()
                Case "b"
                    CheckF3B()
                Case "c"
                    CheckF3C()
                Case "d"
                    CheckF3D()
                Case "e"
                    CheckF3E()
                Case "f"
                    CheckF3F()
                Case "g"
                    CheckF3G()
                Case "h"
                    CheckF3H()
                Case "i"
                    CheckF3I()
            End Select

        ElseIf positionOne = "f4" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckF4A()
                Case "b"
                    CheckF4B()
                Case "c"
                    CheckF4C()
                Case "d"
                    CheckF4D()
                Case "e"
                    CheckF4E()
                Case "f"
                    CheckF4F()
                Case "g"
                    CheckF4G()
                Case "h"
                    CheckF4H()
                Case "i"
                    CheckF4I()
            End Select

        ElseIf positionOne = "f5" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckF5A()
                Case "b"
                    CheckF5B()
                Case "c"
                    CheckF5C()
                Case "d"
                    CheckF5D()
                Case "e"
                    CheckF5E()
                Case "f"
                    CheckF5F()
                Case "g"
                    CheckF5G()
                Case "h"
                    CheckF5H()
                Case "i"
                    CheckF5I()
            End Select

        ElseIf positionOne = "f6" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckF6A()
                Case "b"
                    CheckF6B()
                Case "c"
                    CheckF6C()
                Case "d"
                    CheckF6D()
                Case "e"
                    CheckF6E()
                Case "f"
                    CheckF6F()
                Case "g"
                    CheckF6G()
                Case "h"
                    CheckF6H()
                Case "i"
                    CheckF6I()
            End Select

        ElseIf positionOne = "f7" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckF7A()
                Case "b"
                    CheckF7B()
                Case "c"
                    CheckF7C()
                Case "d"
                    CheckF7D()
                Case "e"
                    CheckF7E()
                Case "f"
                    CheckF7F()
                Case "g"
                    CheckF7G()
                Case "h"
                    CheckF7H()
                Case "i"
                    CheckF7I()
            End Select

        ElseIf positionOne = "f8" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckF8A()
                Case "b"
                    CheckF8B()
                Case "c"
                    CheckF8C()
                Case "d"
                    CheckF8D()
                Case "e"
                    CheckF8E()
                Case "f"
                    CheckF8F()
                Case "g"
                    CheckF8G()
                Case "h"
                    CheckF8H()
                Case "i"
                    CheckF8I()
            End Select

        ElseIf positionOne = "f9" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckF9A()
                Case "b"
                    CheckF9B()
                Case "c"
                    CheckF9C()
                Case "d"
                    CheckF9D()
                Case "e"
                    CheckF9E()
                Case "f"
                    CheckF9F()
                Case "g"
                    CheckF9G()
                Case "h"
                    CheckF9H()
                Case "i"
                    CheckF9I()
            End Select

        ElseIf positionOne = "f10" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckF10A()
                Case "b"
                    CheckF10B()
                Case "c"
                    CheckF10C()
                Case "d"
                    CheckF10D()
                Case "e"
                    CheckF10E()
                Case "f"
                    CheckF10F()
                Case "g"
                    CheckF10G()
                Case "h"
                    CheckF10H()
                Case "i"
                    CheckF10I()
            End Select

        End If
    End Sub
    Private Sub CheckG()
        If positionOne = "g1" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckG1A()
                Case "b"
                    CheckG1B()
                Case "c"
                    CheckG1C()
                Case "d"
                    CheckG1D()
                Case "e"
                    CheckG1E()
                Case "f"
                    CheckG1F()
                Case "g"
                    CheckG1G()
                Case "h"
                    CheckG1H()
                Case "i"
                    CheckG1I()
            End Select

        ElseIf positionOne = "g2" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckG2A()
                Case "b"
                    CheckG2B()
                Case "c"
                    CheckG2C()
                Case "d"
                    CheckG2D()
                Case "e"
                    CheckG2E()
                Case "f"
                    CheckG2F()
                Case "g"
                    CheckG2G()
                Case "h"
                    CheckG2H()
                Case "i"
                    CheckG2I()
            End Select

        ElseIf positionOne = "g3" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckG3A()
                Case "b"
                    CheckG3B()
                Case "c"
                    CheckG3C()
                Case "d"
                    CheckG3D()
                Case "e"
                    CheckG3E()
                Case "f"
                    CheckG3F()
                Case "g"
                    CheckG3G()
                Case "h"
                    CheckG3H()
                Case "i"
                    CheckG3I()
            End Select

        ElseIf positionOne = "g4" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckG4A()
                Case "b"
                    CheckG4B()
                Case "c"
                    CheckG4C()
                Case "d"
                    CheckG4D()
                Case "e"
                    CheckG4E()
                Case "f"
                    CheckG4F()
                Case "g"
                    CheckG4G()
                Case "h"
                    CheckG4H()
                Case "i"
                    CheckG4I()
            End Select

        ElseIf positionOne = "g5" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckG5A()
                Case "b"
                    CheckG5B()
                Case "c"
                    CheckG5C()
                Case "d"
                    CheckG5D()
                Case "e"
                    CheckG5E()
                Case "f"
                    CheckG5F()
                Case "g"
                    CheckG5G()
                Case "h"
                    CheckG5H()
                Case "i"
                    CheckG5I()
            End Select

        ElseIf positionOne = "g6" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckG6A()
                Case "b"
                    CheckG6B()
                Case "c"
                    CheckG6C()
                Case "d"
                    CheckG6D()
                Case "e"
                    CheckG6E()
                Case "f"
                    CheckG6F()
                Case "g"
                    CheckG6G()
                Case "h"
                    CheckG6H()
                Case "i"
                    CheckG6I()
            End Select

        ElseIf positionOne = "g7" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckG7A()
                Case "b"
                    CheckG7B()
                Case "c"
                    CheckG7C()
                Case "d"
                    CheckG7D()
                Case "e"
                    CheckG7E()
                Case "f"
                    CheckG7F()
                Case "g"
                    CheckG7G()
                Case "h"
                    CheckG7H()
                Case "i"
                    CheckG7I()
            End Select

        ElseIf positionOne = "g8" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckG8A()
                Case "b"
                    CheckG8B()
                Case "c"
                    CheckG8C()
                Case "d"
                    CheckG8D()
                Case "e"
                    CheckG8E()
                Case "f"
                    CheckG8F()
                Case "g"
                    CheckG8G()
                Case "h"
                    CheckG8H()
                Case "i"
                    CheckG8I()
            End Select

        ElseIf positionOne = "g9" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckG9A()
                Case "b"
                    CheckG9B()
                Case "c"
                    CheckG9C()
                Case "d"
                    CheckG9D()
                Case "e"
                    CheckG9E()
                Case "f"
                    CheckG9F()
                Case "g"
                    CheckG9G()
                Case "h"
                    CheckG9H()
                Case "i"
                    CheckG9I()
            End Select

        ElseIf positionOne = "g10" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckG10A()
                Case "b"
                    CheckG10B()
                Case "c"
                    CheckG10C()
                Case "d"
                    CheckG10D()
                Case "e"
                    CheckG10E()
                Case "f"
                    CheckG10F()
                Case "g"
                    CheckG10G()
                Case "h"
                    CheckG10H()
                Case "i"
                    CheckG10I()
            End Select

        End If
    End Sub
    Private Sub CheckH()
        If positionOne = "h1" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckH1A()
                Case "b"
                    CheckH1B()
                Case "c"
                    CheckH1C()
                Case "d"
                    CheckH1D()
                Case "e"
                    CheckH1E()
                Case "f"
                    CheckH1F()
                Case "g"
                    CheckH1G()
                Case "h"
                    CheckH1H()
                Case "i"
                    CheckH1I()
            End Select

        ElseIf positionOne = "h2" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckH2A()
                Case "b"
                    CheckH2B()
                Case "c"
                    CheckH2C()
                Case "d"
                    CheckH2D()
                Case "e"
                    CheckH2E()
                Case "f"
                    CheckH2F()
                Case "g"
                    CheckH2G()
                Case "h"
                    CheckH2H()
                Case "i"
                    CheckH2I()
            End Select

        ElseIf positionOne = "h3" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckH3A()
                Case "b"
                    CheckH3B()
                Case "c"
                    CheckH3C()
                Case "d"
                    CheckH3D()
                Case "e"
                    CheckH3E()
                Case "f"
                    CheckH3F()
                Case "g"
                    CheckH3G()
                Case "h"
                    CheckH3H()
                Case "i"
                    CheckH3I()
            End Select

        ElseIf positionOne = "h4" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckH4A()
                Case "b"
                    CheckH4B()
                Case "c"
                    CheckH4C()
                Case "d"
                    CheckH4D()
                Case "e"
                    CheckH4E()
                Case "f"
                    CheckH4F()
                Case "g"
                    CheckH4G()
                Case "h"
                    CheckH4H()
                Case "i"
                    CheckH4I()
            End Select

        ElseIf positionOne = "h5" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckH5A()
                Case "b"
                    CheckH5B()
                Case "c"
                    CheckH5C()
                Case "d"
                    CheckH5D()
                Case "e"
                    CheckH5E()
                Case "f"
                    CheckH5F()
                Case "g"
                    CheckH5G()
                Case "h"
                    CheckH5H()
                Case "i"
                    CheckH5I()
            End Select

        ElseIf positionOne = "h6" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckH6A()
                Case "b"
                    CheckH6B()
                Case "c"
                    CheckH6C()
                Case "d"
                    CheckH6D()
                Case "e"
                    CheckH6E()
                Case "f"
                    CheckH6F()
                Case "g"
                    CheckH6G()
                Case "h"
                    CheckH6H()
                Case "i"
                    CheckH6I()
            End Select

        ElseIf positionOne = "h7" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckH7A()
                Case "b"
                    CheckH7B()
                Case "c"
                    CheckH7C()
                Case "d"
                    CheckH7D()
                Case "e"
                    CheckH7E()
                Case "f"
                    CheckH7F()
                Case "g"
                    CheckH7G()
                Case "h"
                    CheckH7H()
                Case "i"
                    CheckH7I()
            End Select

        ElseIf positionOne = "h8" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckH8A()
                Case "b"
                    CheckH8B()
                Case "c"
                    CheckH8C()
                Case "d"
                    CheckH8D()
                Case "e"
                    CheckH8E()
                Case "f"
                    CheckH8F()
                Case "g"
                    CheckH8G()
                Case "h"
                    CheckH8H()
                Case "i"
                    CheckH8I()
            End Select

        ElseIf positionOne = "h9" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckH9A()
                Case "b"
                    CheckH9B()
                Case "c"
                    CheckH9C()
                Case "d"
                    CheckH9D()
                Case "e"
                    CheckH9E()
                Case "f"
                    CheckH9F()
                Case "g"
                    CheckH9G()
                Case "h"
                    CheckH9H()
                Case "i"
                    CheckH9I()
            End Select

        ElseIf positionOne = "h10" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckH10A()
                Case "b"
                    CheckH10B()
                Case "c"
                    CheckH10C()
                Case "d"
                    CheckH10D()
                Case "e"
                    CheckH10E()
                Case "f"
                    CheckH10F()
                Case "g"
                    CheckH10G()
                Case "h"
                    CheckH10H()
                Case "i"
                    CheckH10I()
            End Select

        End If
    End Sub
    Private Sub CheckI()
        If positionOne = "i1" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckI1A()
                Case "b"
                    CheckI1B()
                Case "c"
                    CheckI1C()
                Case "d"
                    CheckI1D()
                Case "e"
                    CheckI1E()
                Case "f"
                    CheckI1F()
                Case "g"
                    CheckI1G()
                Case "h"
                    CheckI1H()
                Case "i"
                    CheckI1I()
            End Select

        ElseIf positionOne = "i2" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckI2A()
                Case "b"
                    CheckI2B()
                Case "c"
                    CheckI2C()
                Case "d"
                    CheckI2D()
                Case "e"
                    CheckI2E()
                Case "f"
                    CheckI2F()
                Case "g"
                    CheckI2G()
                Case "h"
                    CheckI2H()
                Case "i"
                    CheckI2I()
            End Select

        ElseIf positionOne = "i3" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckI3A()
                Case "b"
                    CheckI3B()
                Case "c"
                    CheckI3C()
                Case "d"
                    CheckI3D()
                Case "e"
                    CheckI3E()
                Case "f"
                    CheckI3F()
                Case "g"
                    CheckI3G()
                Case "h"
                    CheckI3H()
                Case "i"
                    CheckI3I()
            End Select

        ElseIf positionOne = "i4" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckI4A()
                Case "b"
                    CheckI4B()
                Case "c"
                    CheckI4C()
                Case "d"
                    CheckI4D()
                Case "e"
                    CheckI4E()
                Case "f"
                    CheckI4F()
                Case "g"
                    CheckI4G()
                Case "h"
                    CheckI4H()
                Case "i"
                    CheckI4I()
            End Select

        ElseIf positionOne = "i5" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckI5A()
                Case "b"
                    CheckI5B()
                Case "c"
                    CheckI5C()
                Case "d"
                    CheckI5D()
                Case "e"
                    CheckI5E()
                Case "f"
                    CheckI5F()
                Case "g"
                    CheckI5G()
                Case "h"
                    CheckI5H()
                Case "i"
                    CheckI5I()
            End Select

        ElseIf positionOne = "i6" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckI6A()
                Case "b"
                    CheckI6B()
                Case "c"
                    CheckI6C()
                Case "d"
                    CheckI6D()
                Case "e"
                    CheckI6E()
                Case "f"
                    CheckI6F()
                Case "g"
                    CheckI6G()
                Case "h"
                    CheckI6H()
                Case "i"
                    CheckI6I()
            End Select

        ElseIf positionOne = "i7" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckI7A()
                Case "b"
                    CheckI7B()
                Case "c"
                    CheckI7C()
                Case "d"
                    CheckI7D()
                Case "e"
                    CheckI7E()
                Case "f"
                    CheckI7F()
                Case "g"
                    CheckI7G()
                Case "h"
                    CheckI7H()
                Case "i"
                    CheckI7I()
            End Select

        ElseIf positionOne = "i8" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckI8A()
                Case "b"
                    CheckI8B()
                Case "c"
                    CheckI8C()
                Case "d"
                    CheckI8D()
                Case "e"
                    CheckI8E()
                Case "f"
                    CheckI8F()
                Case "g"
                    CheckI8G()
                Case "h"
                    CheckI8H()
                Case "i"
                    CheckI8I()
            End Select

        ElseIf positionOne = "i9" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckI9A()
                Case "b"
                    CheckI9B()
                Case "c"
                    CheckI9C()
                Case "d"
                    CheckI9D()
                Case "e"
                    CheckI9E()
                Case "f"
                    CheckI9F()
                Case "g"
                    CheckI9G()
                Case "h"
                    CheckI9H()
                Case "i"
                    CheckI9I()
            End Select

        ElseIf positionOne = "i10" Then
            Select Case (Me.toHorAlTxt.Text)
                Case "a"
                    CheckI10A()
                Case "b"
                    CheckI10B()
                Case "c"
                    CheckI10C()
                Case "d"
                    CheckI10D()
                Case "e"
                    CheckI10E()
                Case "f"
                    CheckI10F()
                Case "g"
                    CheckI10G()
                Case "h"
                    CheckI10H()
                Case "i"
                    CheckI10I()
            End Select

        End If
    End Sub

    Private Sub fromHorCBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fromHorCBox.SelectedIndexChanged
        If Me.fromHorCBox.SelectedIndex = 0 Then
            Me.fromHorAlTxt.Text = "a"
        ElseIf Me.fromHorCBox.SelectedIndex = 1 Then
            Me.fromHorAlTxt.Text = "b"
        ElseIf Me.fromHorCBox.SelectedIndex = 2 Then
            Me.fromHorAlTxt.Text = "c"
        ElseIf Me.fromHorCBox.SelectedIndex = 3 Then
            Me.fromHorAlTxt.Text = "d"
        ElseIf Me.fromHorCBox.SelectedIndex = 4 Then
            Me.fromHorAlTxt.Text = "e"
        ElseIf Me.fromHorCBox.SelectedIndex = 5 Then
            Me.fromHorAlTxt.Text = "f"
        ElseIf Me.fromHorCBox.SelectedIndex = 6 Then
            Me.fromHorAlTxt.Text = "g"
        ElseIf Me.fromHorCBox.SelectedIndex = 7 Then
            Me.fromHorAlTxt.Text = "h"
        ElseIf Me.fromHorCBox.SelectedIndex = 8 Then
            Me.fromHorAlTxt.Text = "i"
        End If
    End Sub

    Private Sub fromVerCBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fromVerCBox.SelectedIndexChanged
        If Me.fromVerCBox.SelectedIndex = 0 Then
            Me.fromVerNumTxt.Text = "1"
        ElseIf Me.fromVerCBox.SelectedIndex = 1 Then
            Me.fromVerNumTxt.Text = "2"
        ElseIf Me.fromVerCBox.SelectedIndex = 2 Then
            Me.fromVerNumTxt.Text = "3"
        ElseIf Me.fromVerCBox.SelectedIndex = 3 Then
            Me.fromVerNumTxt.Text = "4"
        ElseIf Me.fromVerCBox.SelectedIndex = 4 Then
            Me.fromVerNumTxt.Text = "5"
        ElseIf Me.fromVerCBox.SelectedIndex = 5 Then
            Me.fromVerNumTxt.Text = "6"
        ElseIf Me.fromVerCBox.SelectedIndex = 6 Then
            Me.fromVerNumTxt.Text = "7"
        ElseIf Me.fromVerCBox.SelectedIndex = 7 Then
            Me.fromVerNumTxt.Text = "8"
        ElseIf Me.fromVerCBox.SelectedIndex = 8 Then
            Me.fromVerNumTxt.Text = "9"
        ElseIf Me.fromVerCBox.SelectedIndex = 9 Then
            Me.fromVerNumTxt.Text = "10"
        End If
    End Sub

    Private Sub toHorCBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toHorCBox.SelectedIndexChanged
        If Me.toHorCBox.SelectedIndex = 0 Then
            Me.toHorAlTxt.Text = "a"
        ElseIf Me.toHorCBox.SelectedIndex = 1 Then
            Me.toHorAlTxt.Text = "b"
        ElseIf Me.toHorCBox.SelectedIndex = 2 Then
            Me.toHorAlTxt.Text = "c"
        ElseIf Me.toHorCBox.SelectedIndex = 3 Then
            Me.toHorAlTxt.Text = "d"
        ElseIf Me.toHorCBox.SelectedIndex = 4 Then
            Me.toHorAlTxt.Text = "e"
        ElseIf Me.toHorCBox.SelectedIndex = 5 Then
            Me.toHorAlTxt.Text = "f"
        ElseIf Me.toHorCBox.SelectedIndex = 6 Then
            Me.toHorAlTxt.Text = "g"
        ElseIf Me.toHorCBox.SelectedIndex = 7 Then
            Me.toHorAlTxt.Text = "h"
        ElseIf Me.toHorCBox.SelectedIndex = 8 Then
            Me.toHorAlTxt.Text = "i"
        End If
    End Sub

    Private Sub toVerCBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toVerCBox.SelectedIndexChanged
        If Me.toVerCBox.SelectedIndex = 0 Then
            Me.toVerNumTxt.Text = "1"
        ElseIf Me.toVerCBox.SelectedIndex = 1 Then
            Me.toVerNumTxt.Text = "2"
        ElseIf Me.toVerCBox.SelectedIndex = 2 Then
            Me.toVerNumTxt.Text = "3"
        ElseIf Me.toVerCBox.SelectedIndex = 3 Then
            Me.toVerNumTxt.Text = "4"
        ElseIf Me.toVerCBox.SelectedIndex = 4 Then
            Me.toVerNumTxt.Text = "5"
        ElseIf Me.toVerCBox.SelectedIndex = 5 Then
            Me.toVerNumTxt.Text = "6"
        ElseIf Me.toVerCBox.SelectedIndex = 6 Then
            Me.toVerNumTxt.Text = "7"
        ElseIf Me.toVerCBox.SelectedIndex = 7 Then
            Me.toVerNumTxt.Text = "8"
        ElseIf Me.toVerCBox.SelectedIndex = 8 Then
            Me.toVerNumTxt.Text = "9"
        ElseIf Me.toVerCBox.SelectedIndex = 9 Then
            Me.toVerNumTxt.Text = "10"
        End If
    End Sub

    Private Sub DisplayNonePicMessage()

        MessageBox.Show("No Pieces on that position.", "Picturebox = nonePic", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Me.currentPic.Image = Me.previousPic.Image

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim sqlQuery = " DELETE * FROM record "

        Try
            libDBCon.ExecPostSQL(sqlQuery, "")
        Catch myException As Exception
            MsgBox("Couldn't insert record: " + myException.ToString())
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        libDBCon.ExecGetSQL("SELECT MAX([Table Number]) AS tableNoMax FROM TableNumber", "")
        tableNumber = libDBCon.GetGridInfo().Rows(0)(libDBCon.GetGridInfo.Columns("tableNoMax").Ordinal) + 1
        Table_NumberTextBox.Text = tableNumber.ToString()

        libDBCon.ExecPostSQL("INSERT INTO TableNumber ([Table Number]) VALUES (" & tableNumber & ")", "")

        round = 0
        ClearPieceProtectedPic()
        ClearNoPieceProtected()
        ClearPieceAttackedPic()
        ClearNoPieceAttacked()
    End Sub

    Private Sub CheckMate()

        ' checkmate when jiang is eliminate from castle. 
        If Me.PictureBox4.Image IsNot Me.whiteJiangPic.Image And
        Me.PictureBox5.Image IsNot Me.whiteJiangPic.Image And
        Me.PictureBox6.Image IsNot Me.whiteJiangPic.Image And
        Me.PictureBox13.Image IsNot Me.whiteJiangPic.Image And
        Me.PictureBox14.Image IsNot Me.whiteJiangPic.Image And
        Me.PictureBox15.Image IsNot Me.whiteJiangPic.Image And
        Me.PictureBox22.Image IsNot Me.whiteJiangPic.Image And
        Me.PictureBox23.Image IsNot Me.whiteJiangPic.Image And
        Me.PictureBox24.Image IsNot Me.whiteJiangPic.Image Then
            ' white checkmate
            MsgBox("CheckMate, Black win")
        End If

        If Me.PictureBox67.Image IsNot Me.blackJiangPic.Image And
        Me.PictureBox68.Image IsNot Me.blackJiangPic.Image And
        Me.PictureBox69.Image IsNot Me.blackJiangPic.Image And
        Me.PictureBox76.Image IsNot Me.blackJiangPic.Image And
        Me.PictureBox77.Image IsNot Me.blackJiangPic.Image And
        Me.PictureBox78.Image IsNot Me.blackJiangPic.Image And
        Me.PictureBox85.Image IsNot Me.blackJiangPic.Image And
        Me.PictureBox86.Image IsNot Me.blackJiangPic.Image And
        Me.PictureBox87.Image IsNot Me.blackJiangPic.Image Then
            ' black checkmate
            MsgBox("CheckMate, white win")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SavePlayerInfo()
        SavePieceLocation()
        Form2.ShowDialog()
    End Sub

    Private Sub SavePlayerInfo()
        Dim sqlquery As String

        sqlquery = "UPDATE userscore SET [score]= " & Me.ScoreTextBox.Text
        libDBCon.ExecPostSQL(sqlquery, " WHERE [username] = '" & Me.UserNameTextBox.Text & "'")
    End Sub

    Public Sub SavePieceLocation()

        Dim sqlquery, SqlWhere As String
        sqlquery = ""
        SqlWhere = ""

        If SavePurpose = "saveBeforeShowMA" Then
            SqlWhere = "' WHERE SaveType = 'saveBeforeShowMA' "
        ElseIf SavePurpose = "saveBeforeSimulating" Then
            SqlWhere = "' WHERE SaveType = 'saveBeforeSimulating' "
        End If
        sqlquery = "UPDATE SavePieceLocation SET picturebox1 = '" & picturebox(1) & "', picturebox2 = '" & picturebox(2) & "', picturebox3 = '" & picturebox(3) & "', picturebox4 = '" & picturebox(4) & "', picturebox5 = '" & picturebox(5) & "', picturebox6 = '" & picturebox(6) & "', picturebox7 = '" & picturebox(7) & "', picturebox8 = '" & picturebox(8) & "', picturebox9 = '" & picturebox(9) & "', picturebox10 = '" & picturebox(10) &
        "',picturebox11 = '" & picturebox(11) & "', picturebox12 = '" & picturebox(12) & "', picturebox13 = '" & picturebox(13) & "', picturebox14 = '" & picturebox(14) & "', picturebox15 = '" & picturebox(15) & "', picturebox16 = '" & picturebox(16) & "', picturebox17 = '" & picturebox(17) & "', picturebox18 = '" & picturebox(18) & "', picturebox19 = '" & picturebox(19) & "', picturebox20 = '" & picturebox(20) &
        "',picturebox21 = '" & picturebox(21) & "', picturebox22 = '" & picturebox(22) & "', picturebox23 = '" & picturebox(23) & "', picturebox24 = '" & picturebox(24) & "', picturebox25 = '" & picturebox(25) & "', picturebox26 = '" & picturebox(26) & "', picturebox27 = '" & picturebox(27) & "', picturebox28 = '" & picturebox(28) & "', picturebox29 = '" & picturebox(29) & "', picturebox30 = '" & picturebox(30) &
        "',picturebox31 = '" & picturebox(31) & "', picturebox32 = '" & picturebox(32) & "', picturebox33 = '" & picturebox(33) & "', picturebox34 = '" & picturebox(34) & "', picturebox35 = '" & picturebox(35) & "', picturebox36 = '" & picturebox(36) & "', picturebox37 = '" & picturebox(37) & "', picturebox38 = '" & picturebox(38) & "', picturebox39 = '" & picturebox(39) & "', picturebox40 = '" & picturebox(40) &
        "',picturebox41 = '" & picturebox(41) & "', picturebox42 = '" & picturebox(42) & "', picturebox43 = '" & picturebox(43) & "', picturebox44 = '" & picturebox(44) & "', picturebox45 = '" & picturebox(45) & "', picturebox46 = '" & picturebox(46) & "', picturebox47 = '" & picturebox(47) & "', picturebox48 = '" & picturebox(48) & "', picturebox49 = '" & picturebox(49) & "', picturebox50 = '" & picturebox(50) &
        "',picturebox51 = '" & picturebox(51) & "', picturebox52 = '" & picturebox(52) & "', picturebox53 = '" & picturebox(53) & "', picturebox54 = '" & picturebox(54) & "', picturebox55 = '" & picturebox(55) & "', picturebox56 = '" & picturebox(56) & "', picturebox57 = '" & picturebox(57) & "', picturebox58 = '" & picturebox(58) & "', picturebox59 = '" & picturebox(59) & "', picturebox60 = '" & picturebox(60) &
        "',picturebox61 = '" & picturebox(61) & "', picturebox62 = '" & picturebox(62) & "', picturebox63 = '" & picturebox(63) & "', picturebox64 = '" & picturebox(64) & "', picturebox65 = '" & picturebox(65) & "', picturebox66 = '" & picturebox(66) & "', picturebox67 = '" & picturebox(67) & "', picturebox68 = '" & picturebox(68) & "', picturebox69 = '" & picturebox(69) & "', picturebox70 = '" & picturebox(70) &
        "',picturebox71 = '" & picturebox(71) & "', picturebox72 = '" & picturebox(72) & "', picturebox73 = '" & picturebox(73) & "', picturebox74 = '" & picturebox(74) & "', picturebox75 = '" & picturebox(75) & "', picturebox76 = '" & picturebox(76) & "', picturebox77 = '" & picturebox(77) & "', picturebox78 = '" & picturebox(78) & "', picturebox79 = '" & picturebox(79) & "', picturebox80 = '" & picturebox(80) &
        "',picturebox81 = '" & picturebox(81) & "', picturebox82 = '" & picturebox(82) & "', picturebox83 = '" & picturebox(83) & "', picturebox84 = '" & picturebox(84) & "', picturebox85 = '" & picturebox(85) & "', picturebox86 = '" & picturebox(86) & "', picturebox87 = '" & picturebox(87) & "', picturebox88 = '" & picturebox(88) & "', picturebox89 = '" & picturebox(89) & "', picturebox90 = '" & picturebox(90)

        libDBCon.ExecGetSQL(sqlquery, SqlWhere)
        SavePurpose = ""

    End Sub
    Public Sub RetriveSavePieceLocation()

        Dim sqlquery, sqlWhere As String

        sqlquery = ""
        sqlWhere = ""

        If RetrieveFrom = "saveBeforeShowMA" Then
            sqlWhere = " WHERE SaveType = 'saveBeforeShowMA' "
        ElseIf RetrieveFrom = "saveBeforeSimulating" Then
            sqlWhere = " WHERE SaveType = 'saveBeforeSimulating' "
        End If
        sqlquery = " SELECT * FROM SavePieceLocation "

        libDBCon.ExecGetSQL(sqlquery, sqlWhere)
        For dtrCount As Integer = 0 To libDBCon.GetGridInfo().Rows.Count
            Me.picturebox(dtrCount + 1) = libDBCon.GetGridInfo.Rows(0)(libDBCon.GetGridInfo.Columns("Picturebox" + (dtrCount + 1).ToString()).Ordinal).ToString()
        Next
        RetrieveFrom = ""

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Me.storePic.Image = Me.PictureBox1.Image

        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "a"
            Me.fromVerNumTxt.Text = "10"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "a"
            Me.toVerNumTxt.Text = "10"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If

    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Me.storePic.Image = Me.PictureBox2.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "b"
            Me.fromVerNumTxt.Text = "10"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "b"
            Me.toVerNumTxt.Text = "10"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If

    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        Me.storePic.Image = Me.PictureBox3.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "c"
            Me.fromVerNumTxt.Text = "10"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "c"
            Me.toVerNumTxt.Text = "10"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If

    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        Me.storePic.Image = Me.PictureBox4.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "d"
            Me.fromVerNumTxt.Text = "10"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "d"
            Me.toVerNumTxt.Text = "10"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If

    End Sub
    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

        Me.storePic.Image = Me.PictureBox5.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "e"
            Me.fromVerNumTxt.Text = "10"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "e"
            Me.toVerNumTxt.Text = "10"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If

    End Sub
    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click

        Me.storePic.Image = Me.PictureBox6.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "f"
            Me.fromVerNumTxt.Text = "10"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "f"
            Me.toVerNumTxt.Text = "10"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If

    End Sub
    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click

        Me.storePic.Image = Me.PictureBox7.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "g"
            Me.fromVerNumTxt.Text = "10"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "g"
            Me.toVerNumTxt.Text = "10"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click

        Me.storePic.Image = Me.PictureBox8.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "h"
            Me.fromVerNumTxt.Text = "10"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "h"
            Me.toVerNumTxt.Text = "10"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click

        Me.storePic.Image = Me.PictureBox9.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "i"
            Me.fromVerNumTxt.Text = "10"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "i"
            Me.toVerNumTxt.Text = "10"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click

        Me.storePic.Image = Me.PictureBox18.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "i"
            Me.fromVerNumTxt.Text = "9"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "i"
            Me.toVerNumTxt.Text = "9"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click

        Me.storePic.Image = Me.PictureBox17.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "h"
            Me.fromVerNumTxt.Text = "9"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "h"
            Me.toVerNumTxt.Text = "9"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click

        Me.storePic.Image = Me.PictureBox16.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "g"
            Me.fromVerNumTxt.Text = "9"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "g"
            Me.toVerNumTxt.Text = "9"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click

        Me.storePic.Image = Me.PictureBox15.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "f"
            Me.fromVerNumTxt.Text = "9"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "f"
            Me.toVerNumTxt.Text = "9"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click

        Me.storePic.Image = Me.PictureBox14.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "e"
            Me.fromVerNumTxt.Text = "9"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "e"
            Me.toVerNumTxt.Text = "9"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click

        Me.storePic.Image = Me.PictureBox13.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "d"
            Me.fromVerNumTxt.Text = "9"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "d"
            Me.toVerNumTxt.Text = "9"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click

        Me.storePic.Image = Me.PictureBox12.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "c"
            Me.fromVerNumTxt.Text = "9"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "c"
            Me.toVerNumTxt.Text = "9"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click

        Me.storePic.Image = Me.PictureBox11.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "b"
            Me.fromVerNumTxt.Text = "9"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "b"
            Me.toVerNumTxt.Text = "9"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click

        Me.storePic.Image = Me.PictureBox10.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "a"
            Me.fromVerNumTxt.Text = "9"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "a"
            Me.toVerNumTxt.Text = "9"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click

        Me.storePic.Image = Me.PictureBox28.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "a"
            Me.fromVerNumTxt.Text = "7"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "a"
            Me.toVerNumTxt.Text = "7"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.Click

        Me.storePic.Image = Me.PictureBox29.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "b"
            Me.fromVerNumTxt.Text = "7"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "b"
            Me.toVerNumTxt.Text = "7"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click

        Me.storePic.Image = Me.PictureBox30.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "c"
            Me.fromVerNumTxt.Text = "7"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "c"
            Me.toVerNumTxt.Text = "7"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox31.Click

        Me.storePic.Image = Me.PictureBox31.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "d"
            Me.fromVerNumTxt.Text = "7"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "d"
            Me.toVerNumTxt.Text = "7"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox32.Click

        Me.storePic.Image = Me.PictureBox32.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "e"
            Me.fromVerNumTxt.Text = "7"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "e"
            Me.toVerNumTxt.Text = "7"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox33.Click

        Me.storePic.Image = Me.PictureBox33.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "f"
            Me.fromVerNumTxt.Text = "7"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "f"
            Me.toVerNumTxt.Text = "7"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox34.Click

        Me.storePic.Image = Me.PictureBox34.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "g"
            Me.fromVerNumTxt.Text = "7"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "g"
            Me.toVerNumTxt.Text = "7"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox35.Click

        Me.storePic.Image = Me.PictureBox35.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "h"
            Me.fromVerNumTxt.Text = "7"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "h"
            Me.toVerNumTxt.Text = "7"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox36.Click

        Me.storePic.Image = Me.PictureBox36.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "i"
            Me.fromVerNumTxt.Text = "7"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "i"
            Me.toVerNumTxt.Text = "7"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox27.Click

        Me.storePic.Image = Me.PictureBox27.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "i"
            Me.fromVerNumTxt.Text = "8"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "i"
            Me.toVerNumTxt.Text = "8"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox26.Click

        Me.storePic.Image = Me.PictureBox26.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "h"
            Me.fromVerNumTxt.Text = "8"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "h"
            Me.toVerNumTxt.Text = "8"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox25.Click

        Me.storePic.Image = Me.PictureBox25.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "g"
            Me.fromVerNumTxt.Text = "8"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "g"
            Me.toVerNumTxt.Text = "8"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox24.Click

        Me.storePic.Image = Me.PictureBox24.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "f"
            Me.fromVerNumTxt.Text = "8"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "f"
            Me.toVerNumTxt.Text = "8"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click

        Me.storePic.Image = Me.PictureBox23.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "e"
            Me.fromVerNumTxt.Text = "8"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "e"
            Me.toVerNumTxt.Text = "8"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click

        Me.storePic.Image = Me.PictureBox22.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "d"
            Me.fromVerNumTxt.Text = "8"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "d"
            Me.toVerNumTxt.Text = "8"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click

        Me.storePic.Image = Me.PictureBox21.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "c"
            Me.fromVerNumTxt.Text = "8"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "c"
            Me.toVerNumTxt.Text = "8"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click

        Me.storePic.Image = Me.PictureBox20.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "b"
            Me.fromVerNumTxt.Text = "8"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "b"
            Me.toVerNumTxt.Text = "8"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click

        Me.storePic.Image = Me.PictureBox19.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "a"
            Me.fromVerNumTxt.Text = "8"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "a"
            Me.toVerNumTxt.Text = "8"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox46.Click

        Me.storePic.Image = Me.PictureBox46.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "a"
            Me.fromVerNumTxt.Text = "5"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "a"
            Me.toVerNumTxt.Text = "5"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox47.Click

        Me.storePic.Image = Me.PictureBox47.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "b"
            Me.fromVerNumTxt.Text = "5"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "b"
            Me.toVerNumTxt.Text = "5"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox48.Click

        Me.storePic.Image = Me.PictureBox48.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "c"
            Me.fromVerNumTxt.Text = "5"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "c"
            Me.toVerNumTxt.Text = "5"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox49.Click

        Me.storePic.Image = Me.PictureBox49.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "d"
            Me.fromVerNumTxt.Text = "5"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "d"
            Me.toVerNumTxt.Text = "5"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox50.Click

        Me.storePic.Image = Me.PictureBox50.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "e"
            Me.fromVerNumTxt.Text = "5"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "e"
            Me.toVerNumTxt.Text = "5"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox51.Click

        Me.storePic.Image = Me.PictureBox51.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "f"
            Me.fromVerNumTxt.Text = "5"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "f"
            Me.toVerNumTxt.Text = "5"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox52.Click

        Me.storePic.Image = Me.PictureBox52.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "g"
            Me.fromVerNumTxt.Text = "5"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "g"
            Me.toVerNumTxt.Text = "5"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox53.Click

        Me.storePic.Image = Me.PictureBox53.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "h"
            Me.fromVerNumTxt.Text = "5"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "h"
            Me.toVerNumTxt.Text = "5"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox54.Click

        Me.storePic.Image = Me.PictureBox54.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "i"
            Me.fromVerNumTxt.Text = "5"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "i"
            Me.toVerNumTxt.Text = "5"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox45.Click

        Me.storePic.Image = Me.PictureBox45.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "i"
            Me.fromVerNumTxt.Text = "6"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "i"
            Me.toVerNumTxt.Text = "6"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox44.Click

        Me.storePic.Image = Me.PictureBox44.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "h"
            Me.fromVerNumTxt.Text = "6"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "h"
            Me.toVerNumTxt.Text = "6"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox43.Click

        Me.storePic.Image = Me.PictureBox43.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "g"
            Me.fromVerNumTxt.Text = "6"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "g"
            Me.toVerNumTxt.Text = "6"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox42.Click

        Me.storePic.Image = Me.PictureBox42.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "f"
            Me.fromVerNumTxt.Text = "6"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "f"
            Me.toVerNumTxt.Text = "6"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox41.Click

        Me.storePic.Image = Me.PictureBox41.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "e"
            Me.fromVerNumTxt.Text = "6"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "e"
            Me.toVerNumTxt.Text = "6"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox40.Click

        Me.storePic.Image = Me.PictureBox40.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "d"
            Me.fromVerNumTxt.Text = "6"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "d"
            Me.toVerNumTxt.Text = "6"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox39.Click

        Me.storePic.Image = Me.PictureBox39.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "c"
            Me.fromVerNumTxt.Text = "6"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "c"
            Me.toVerNumTxt.Text = "6"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox38.Click

        Me.storePic.Image = Me.PictureBox38.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "b"
            Me.fromVerNumTxt.Text = "6"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "b"
            Me.toVerNumTxt.Text = "6"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.Click

        Me.storePic.Image = Me.PictureBox37.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "a"
            Me.fromVerNumTxt.Text = "6"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "a"
            Me.toVerNumTxt.Text = "6"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox64.Click

        Me.storePic.Image = Me.PictureBox64.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "a"
            Me.fromVerNumTxt.Text = "3"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "a"
            Me.toVerNumTxt.Text = "3"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox65.Click

        Me.storePic.Image = Me.PictureBox65.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "b"
            Me.fromVerNumTxt.Text = "3"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "b"
            Me.toVerNumTxt.Text = "3"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox66.Click

        Me.storePic.Image = Me.PictureBox66.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "c"
            Me.fromVerNumTxt.Text = "3"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "c"
            Me.toVerNumTxt.Text = "3"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox67.Click

        Me.storePic.Image = Me.PictureBox67.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "d"
            Me.fromVerNumTxt.Text = "3"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "d"
            Me.toVerNumTxt.Text = "3"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox68.Click

        Me.storePic.Image = Me.PictureBox68.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "e"
            Me.fromVerNumTxt.Text = "3"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "e"
            Me.toVerNumTxt.Text = "3"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox69.Click

        Me.storePic.Image = Me.PictureBox69.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "f"
            Me.fromVerNumTxt.Text = "3"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "f"
            Me.toVerNumTxt.Text = "3"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox70.Click

        Me.storePic.Image = Me.PictureBox70.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "g"
            Me.fromVerNumTxt.Text = "3"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "g"
            Me.toVerNumTxt.Text = "3"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox71.Click

        Me.storePic.Image = Me.PictureBox71.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "h"
            Me.fromVerNumTxt.Text = "3"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "h"
            Me.toVerNumTxt.Text = "3"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox72.Click

        Me.storePic.Image = Me.PictureBox72.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "i"
            Me.fromVerNumTxt.Text = "3"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "i"
            Me.toVerNumTxt.Text = "3"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox63.Click

        Me.storePic.Image = Me.PictureBox63.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "i"
            Me.fromVerNumTxt.Text = "4"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "i"
            Me.toVerNumTxt.Text = "4"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox62.Click

        Me.storePic.Image = Me.PictureBox62.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "h"
            Me.fromVerNumTxt.Text = "4"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "h"
            Me.toVerNumTxt.Text = "4"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox61.Click

        Me.storePic.Image = Me.PictureBox61.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "g"
            Me.fromVerNumTxt.Text = "4"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "g"
            Me.toVerNumTxt.Text = "4"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox60.Click

        Me.storePic.Image = Me.PictureBox60.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "f"
            Me.fromVerNumTxt.Text = "4"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "f"
            Me.toVerNumTxt.Text = "4"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox59.Click

        Me.storePic.Image = Me.PictureBox59.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "e"
            Me.fromVerNumTxt.Text = "4"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "e"
            Me.toVerNumTxt.Text = "4"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox58.Click

        Me.storePic.Image = Me.PictureBox58.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "d"
            Me.fromVerNumTxt.Text = "4"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "d"
            Me.toVerNumTxt.Text = "4"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox57.Click

        Me.storePic.Image = Me.PictureBox57.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "c"
            Me.fromVerNumTxt.Text = "4"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "c"
            Me.toVerNumTxt.Text = "4"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox56.Click

        Me.storePic.Image = Me.PictureBox56.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "b"
            Me.fromVerNumTxt.Text = "4"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "b"
            Me.toVerNumTxt.Text = "4"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox55.Click

        Me.storePic.Image = Me.PictureBox55.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "a"
            Me.fromVerNumTxt.Text = "4"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "a"
            Me.toVerNumTxt.Text = "4"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox82.Click

        Me.storePic.Image = Me.PictureBox82.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "a"
            Me.fromVerNumTxt.Text = "1"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "a"
            Me.toVerNumTxt.Text = "1"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox83.Click

        Me.storePic.Image = Me.PictureBox83.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "b"
            Me.fromVerNumTxt.Text = "1"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "b"
            Me.toVerNumTxt.Text = "1"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox84.Click

        Me.storePic.Image = Me.PictureBox84.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "c"
            Me.fromVerNumTxt.Text = "1"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "c"
            Me.toVerNumTxt.Text = "1"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox85.Click

        Me.storePic.Image = Me.PictureBox85.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "d"
            Me.fromVerNumTxt.Text = "1"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "d"
            Me.toVerNumTxt.Text = "1"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox86.Click

        Me.storePic.Image = Me.PictureBox86.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "e"
            Me.fromVerNumTxt.Text = "1"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "e"
            Me.toVerNumTxt.Text = "1"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox87.Click

        Me.storePic.Image = Me.PictureBox87.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "f"
            Me.fromVerNumTxt.Text = "1"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "f"
            Me.toVerNumTxt.Text = "1"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox88.Click

        Me.storePic.Image = Me.PictureBox88.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "g"
            Me.fromVerNumTxt.Text = "1"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "g"
            Me.toVerNumTxt.Text = "1"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox89.Click

        Me.storePic.Image = Me.PictureBox89.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "h"
            Me.fromVerNumTxt.Text = "1"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "h"
            Me.toVerNumTxt.Text = "1"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If playerTurn IsNot Nothing And playerTurn <> String.Empty Then
            EnableRequireUC()
        End If
    End Sub

    Private Sub PictureBox90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox90.Click

        Me.storePic.Image = Me.PictureBox90.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "i"
            Me.fromVerNumTxt.Text = "1"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "i"
            Me.toVerNumTxt.Text = "1"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox81.Click

        Me.storePic.Image = Me.PictureBox81.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "i"
            Me.fromVerNumTxt.Text = "2"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "i"
            Me.toVerNumTxt.Text = "2"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox80.Click

        Me.storePic.Image = Me.PictureBox80.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "h"
            Me.fromVerNumTxt.Text = "2"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "h"
            Me.toVerNumTxt.Text = "2"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox79.Click

        Me.storePic.Image = Me.PictureBox79.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "g"
            Me.fromVerNumTxt.Text = "2"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "g"
            Me.toVerNumTxt.Text = "2"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox78.Click

        Me.storePic.Image = Me.PictureBox78.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "f"
            Me.fromVerNumTxt.Text = "2"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "f"
            Me.toVerNumTxt.Text = "2"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox77.Click

        Me.storePic.Image = Me.PictureBox77.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "e"
            Me.fromVerNumTxt.Text = "2"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "e"
            Me.toVerNumTxt.Text = "2"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox76.Click

        Me.storePic.Image = Me.PictureBox76.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "d"
            Me.fromVerNumTxt.Text = "2"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "d"
            Me.toVerNumTxt.Text = "2"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox75.Click

        Me.storePic.Image = Me.PictureBox75.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "c"
            Me.fromVerNumTxt.Text = "2"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "c"
            Me.toVerNumTxt.Text = "2"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox74.Click

        Me.storePic.Image = Me.PictureBox74.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "b"
            Me.fromVerNumTxt.Text = "2"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "b"
            Me.toVerNumTxt.Text = "2"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub
    Private Sub PictureBox73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox73.Click

        Me.storePic.Image = Me.PictureBox73.Image
        If (Me.firstClickPic.Image Is Me.nonePic.Image) Then
            Me.firstClickPic.Image = Me.storePic.Image
            Me.fromHorAlTxt.Text = "a"
            Me.fromVerNumTxt.Text = "2"
            CheckPiece()
            SavePurpose = "saveBeforeShowMA"
            SavePieceLocation()
            GetPositionOne()
            AssignCurrentPicWithPositionOne()
            CheckMovementArea()
        ElseIf (Me.firstClickPic.Image IsNot Me.nonePic.Image) And (Me.secondClickPic.Image Is Me.nonePic.Image) Then
            Me.secondClickPic.Image = Me.storePic.Image
            Me.toHorAlTxt.Text = "a"
            Me.toVerNumTxt.Text = "2"
            RetrieveFrom = "saveBeforeShowMA"
            RetriveSavePieceLocation()
            RetrivePiece()
            moveBtn.PerformClick()
            AIMove()
        End If
    End Sub

    Private Sub form3Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles form3Btn.Click
        ProtectedPieceForm.ShowDialog()
        AttackOrProtectBy.ShowDialog()
        CheckJiangLocation()
        If Moved = True Then
            Exit Sub
        End If
        'CheckCheLocation()
        If Moved = True Then
            Exit Sub
        End If
        'CheckPaoMaLocation()
        If Moved = True Then
            Exit Sub
        End If
        'CheckBingZuLocation()
        If Moved = True Then
            Exit Sub
        End If
        'CheckXiangShiLocation()
    End Sub
End Class