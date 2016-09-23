' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 04/01/2011
' Descripitons : Chinese Chess V1

Module ModuleAIMovement
    Public PictureboxAbleToBlock1, JiangLocation, Location, AttackerPicLocation, MoveAvailable1 As Integer
    Public TargetLocationRowColumn, EnemyAttackerLocation, OurAttackerLocation, PiecePic, TargetLocation, AttackerLocation As String
    Public AttackBigerThanProtect, AIMovement, IsWhite As Boolean
    Public FromHor(50), FromVer(50), ToHor(50), ToVer(50) As String
    Public LocationAbleToBlock2(10), LocationAbleToBlock1(10), LocationAbleToBlock(10), CheLocation(2), PaoMaLocation(4), BingZuLocation(5), XiangShiLocation(4) As Integer
    Public MoveAvailable(10), PieceAbleToFill(10), PieceAbleToFill1(10), MoveCount(20) As Integer
    Public DifferenceProtectAttack(50), MoveLocationAvailable(10), PieceNotAvailableToFill(10), MoveNotAvailable(10) As Integer
    Public WhichSimulate As String
    Dim i, j, k, l, l2, n As Integer
    Dim o(10) As Integer

    Public Sub CheckJiangLocation()

        'Dim myconnection As SqlClient.SqlConnection
        'Dim myOleCommand As SqlClient.SqlCommand
        'Dim dbreader As SqlClient.SqlDataReader

        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader
        Dim TmStr As String

        PiecePic = "Jiang"
        'myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = " SELECT * FROM PieceStatus "
        '"where (PieceScore = " & 5 & " and PictureBoxColor = 'Black' and IsAttacked = 'True')"
        'myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        'myconnection.Open()
        'myOleCommand.ExecuteNonQuery()
        'dbreader = myOleCommand.ExecuteReader()
        'If dbreader.HasRows Then
        '    While dbreader.Read
        '        JiangLocation = dbreader("PicNo")
        '        ' here
        '        ' move, defence, eliminate
        '        ' Eliminate
        '        ' locate the attacker piece
        '        ' check is it the attacker piece is attack by our piece
        '        ' Defence
        '        ' ............
        '        ' Move
        '        ' If eliminate and defence is fail, then move.
        '        MsgBox("Black Jiang is Attacked", MsgBoxStyle.OkOnly)
        '    End While
        'Else
        '    MsgBox("Black Jiang is not Attacked", MsgBoxStyle.OkOnly)
        '    Exit Sub
        'End If
        'dbreader.Close()
        'myconnection.Close()
        libDBCon.ExecGetSQL(TmStr, " WHERE (PieceScore = " & 5 & " AND PictureBoxColor = 'Black' AND IsAttacked = 'True')")
        JiangLocation = libDBCon.GetGridInfo.Rows(0)(libDBCon.GetGridInfo.Columns("PicNo").Ordinal).ToString()
        If JiangLocation <> vbNull Then
            MsgBox("Black Jiang is Attacked", MsgBoxStyle.OkOnly)
        Else
            MsgBox("Black Jiang is not Attacked", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        CheckCurrPicAttackBy()
        If AttackerPicLocation = 0 Then
            Exit Sub
        End If
        ' Eliminate
        CheckIsAttackBigerThanProtect()
        If AttackBigerThanProtect = True Then
            CheckAttackerAttackBy()
            RowColumn = OurAttackerLocation
            ChangeToHorVer()
            Form1.fromHorAlTxt.Text = Horizontal
            Form1.fromVerNumTxt.Text = Vertical
            RowColumn = EnemyAttackerLocation
            ChangeToHorVer()
            Form1.toHorAlTxt.Text = Horizontal
            Form1.toVerNumTxt.Text = Vertical
            Form1.moveBtn.PerformClick()
            Exit Sub
        End If

        ' Block
        ' check attacker piece
        CheckAttackerPiece()
        Location = JiangLocation
        CheckPicturebox()
        TargetLocationRowColumn = RowColumn
        ClearAvailableBlock()
        If AttackerPiece = "Che" Then
            CheckCheAvailableBlock()
        ElseIf AttackerPiece = "Pao" Then
            CheckPaoAvailableBlock()
            ' from Pao
            ' check which row or column. locate Pao Location, jump stone Location, and target location.
            ' row or column not = Pao Location, jump stone location, and target location.
            ' check our piece that can block at those location.
            ' check safety of those location. locations that are not attacked by opponent.
        ElseIf AttackerPiece = "Ma" Then
            CheckMaAvailableBlock()
        ElseIf AttackerPiece = "Xiang" Then
            CheckXiangAvailableBlock()
        ElseIf AttackerPiece = "Shi" Then
        ElseIf AttackerPiece = "Jiang" Then
        ElseIf AttackerPiece = "BingZu" Then
        End If

        Block1()
        If (LocationAbleToBlock1(1) = 0) Or (LocationAbleToBlock2(1) = 0) Then
            GoTo Line1
        End If
        WhichSimulate = "Block"
        SimulateMove()

        ' Evade
        'Location = JiangLocation
        'CheckPicturebox()
        'TargetLocationRowColumn = RowColumn
Line1:  For i = 0 To 50
            FromHor(i) = ""
            FromVer(i) = ""
            ToHor(i) = ""
            ToVer(i) = ""
        Next i
        ProtectedPieceForm.ShowDialog()
        AttackOrProtectBy.ShowDialog()

        For i = 0 To 10
            MoveAvailable(i) = 0
            PieceAbleToFill(i) = 0
            PieceAbleToFill1(i) = 0
            MoveNotAvailable(i) = 0
        Next i

        i = 1

        'myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "Select * from AttackOrProtectBy "
        ' " AttackOrProtect = ' Move Available ' and ByPic = " & JiangLocation
        'myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        'myconnection.Open()
        'myOleCommand.ExecuteNonQuery()
        'dbreader = myOleCommand.ExecuteReader()
        'If dbreader.HasRows Then
        '    While dbreader.Read
        '        MoveAvailable(i) = dbreader("CurrPic")
        '        'MsgBox(MoveAvailable(i), MsgBoxStyle.OkOnly)
        '        i = i + 1
        '    End While
        'Else
        'End If
        'dbreader.Close()
        'myconnection.Close()

        libDBCon.ExecGetSQL(TmStr, " AttackOrProtect = ' Move Available ' and ByPic = " & JiangLocation)
        For Each dtr As DataRow In libDBCon.GetGridInfo.Rows
            MoveAvailable(i) = libDBCon.GetGridInfo.Rows()(libDBCon.GetGridInfo.Columns("CurrPic").Ordinal).ToString()
            i = i + 1
        Next

        j = 1
        For i = 1 To 10
            If MoveAvailable(i) = 0 Then
                Exit For
            End If

            'myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
            'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
            TmStr = " SELECT * FROM AttackOrProtectBy "
            '" where CurrPic = " & MoveAvailable(i) & " and AttackOrProtect = ' Move Available '"
            'myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
            'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
            'myconnection.Open()
            'myOleCommand.ExecuteNonQuery()
            'dbreader = myOleCommand.ExecuteReader()
            'If dbreader.HasRows Then
            '    While dbreader.Read
            '        If (dbreader("ByPic") <> JiangLocation) Then
            '            PieceAbleToFill(j) = dbreader("ByPic")
            '            'MsgBox(PieceAbleToFill(j), MsgBoxStyle.OkOnly)
            '            j = j + 1
            '        End If
            '    End While
            'Else
            'End If
            'dbreader.Close()
            'myconnection.Close()

            libDBCon.ExecGetSQL(TmStr, " WHERE CurrPic = " & MoveAvailable(i) & " AND AttackOrProtect = ' Move Available '")
            For Each dtr As DataRow In libDBCon.GetGridInfo.Rows
                If Convert.ToInt32((libDBCon.GetGridInfo.Rows(0)(libDBCon.GetGridInfo.Columns("ByPic").Ordinal).ToString()) <> JiangLocation) Then
                    PieceAbleToFill(j) = Convert.ToInt32(libDBCon.GetGridInfo.Rows(0)(libDBCon.GetGridInfo.Columns("ByPic").Ordinal).ToString())
                    'MsgBox(PieceAbleToFill(j), MsgBoxStyle.OkOnly)
                    j = j + 1
                End If
            Next
        Next i

        i = 1
        For j = 1 To 10
            If PieceAbleToFill(j) = 0 Then
                Exit For
            End If

            'myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
            'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
            TmStr = "SELECT * FROM PieceStatus "
            '" where PicNo = " & PieceAbleToFill(j) & " and PictureBoxColor = 'White'"
            'myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
            'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
            'myconnection.Open()
            'myOleCommand.ExecuteNonQuery()
            'dbreader = myOleCommand.ExecuteReader()
            'If dbreader.HasRows Then
            '    While dbreader.Read
            '        PieceAbleToFill1(i) = dbreader("PicNo")
            '        'MsgBox(PieceAbleToFill1(i), MsgBoxStyle.OkOnly)
            '        i = i + 1
            '    End While
            'Else
            'End If
            'dbreader.Close()
            'myconnection.Close()
            libDBCon.ExecGetSQL(TmStr, " WHERE PicNo = " & PieceAbleToFill(j) & " AND PictureBoxColor = 'White'")
            For Each dtr As DataRow In libDBCon.GetGridInfo.Rows
                PieceAbleToFill1(i) = Convert.ToInt32(libDBCon.GetGridInfo.Rows(0)(libDBCon.GetGridInfo.Columns("PicNo").Ordinal).ToString())
                'MsgBox(PieceAbleToFill1(i), MsgBoxStyle.OkOnly)
                i = i + 1
            Next
        Next j

        j = 1
        For i = 1 To 10
            If MoveAvailable(i) = 0 Then
                Exit For
            End If
            For k = 1 To 10
                If PieceAbleToFill1(k) = 0 Then
                    Exit For
                End If

                'myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
                'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
                TmStr = "Select * FROM AttackOrProtectBy "
                ' "where CurrPic = " & MoveAvailable(i) & " and AttackOrProtect = ' Move Available ' and ByPic = " & PieceAbleToFill1(k)
                'myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
                'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
                'myconnection.Open()
                'myOleCommand.ExecuteNonQuery()
                'dbreader = myOleCommand.ExecuteReader()
                'If dbreader.HasRows Then
                '    While dbreader.Read
                '        MoveNotAvailable(j) = dbreader("CurrPic")
                '        j = j + 1
                '    End While
                'Else
                'End If 
                'dbreader.Close()
                'myconnection.Close()

                libDBCon.ExecGetSQL(TmStr, " WHERE CurrPic = " & MoveAvailable(i) & " AND AttackOrProtect = ' Move Available ' AND ByPic = " & PieceAbleToFill1(k))
                For Each dtr As DataRow In libDBCon.GetGridInfo.Rows
                    PieceAbleToFill1(j) = Convert.ToInt32(libDBCon.GetGridInfo.Rows(0)(libDBCon.GetGridInfo.Columns("CurrPic").Ordinal).ToString())
                    j = j + 1
                Next

            Next k
        Next i

        MoveAvailable1 = 100
        For i = 1 To 10
            'MoveAvailable1 = MoveAvailable1 + 1
            If MoveAvailable(i) = 0 Then
                Exit For
            End If
            For j = 1 To 10
                'If (MoveNotAvailable(j) = 100) Then
                '    Exit For
                'End If
                'MsgBox(MoveAvailable(i), MsgBoxStyle.OkOnly)
                'MsgBox(MoveNotAvailable(j), MsgBoxStyle.OkOnly)
                'MsgBox(MoveAvailable1, MsgBoxStyle.OkOnly)
                If (MoveAvailable(i) <> MoveNotAvailable(j)) And (MoveAvailable1 <> MoveAvailable(i)) Then
                    Location = JiangLocation
                    CheckPicturebox()
                    ChangeToHorVer()
                    FromHor(l) = Horizontal
                    FromVer(l) = Vertical
                    Location = MoveAvailable(i)
                    CheckPicturebox()
                    ChangeToHorVer()
                    ToHor(l) = Horizontal
                    ToVer(l) = Vertical
                    l = l + 1
                End If
                MoveAvailable1 = MoveAvailable(i)
            Next j
        Next i
        WhichSimulate = "Evade"
        SimulateMove()
        ' check jiang available move
        ' check is it movement avaible for black pieces
        ' if no, evade
        ' Defence
    End Sub

    Public Sub CheckCheLocation()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        'Dim myconnection As System.Data.SqlClient.SqlConnection
        'Dim myOleCommand As System.Data.SqlClient.SqlCommand
        'Dim dbreader As System.Data.SqlClient.SqlDataReader

        Dim TmStr As String

        PiecePic = "Che"
        i = 1

        'myconnection = New System.Data.SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = " SELECT * FROM PieceStatus "
        '" where (PieceScore = 4 and PictureBoxColor = 'Black' and IsAttacked = 'True')"
        'myOleCommand = New System.Data.SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        'myconnection.Open()
        'myOleCommand.ExecuteNonQuery()
        'dbreader = myOleCommand.ExecuteReader()
        'If dbreader.HasRows Then
        '    While dbreader.Read
        '        CheLocation(i) = dbreader("PicNo")
        '        i = i + 1
        '    End While
        '    MsgBox(CheLocation(1), MsgBoxStyle.OkOnly)
        '    MsgBox(CheLocation(2), MsgBoxStyle.OkOnly)
        'Else
        'End If
        'dbreader.Close()
        'myconnection.Close()

        libDBCon.ExecGetSQL(TmStr, " WHERE (PieceScore = 4 AND PictureBoxColor = 'Black' AND IsAttacked = 'True')")
        For Each dtr As DataRow In libDBCon.GetGridInfo().Rows
            CheLocation(i) = Convert.ToInt32(libDBCon.GetGridInfo.Rows(0)(libDBCon.GetGridInfo.Columns("PicNo").Ordinal).ToString())
            'CheLocation(i) = dbreader("PicNo")
            i = i + 1
        Next

        For i = 1 To 2
            CheckCurrPicAttackBy()
            If AttackerPicLocation = 0 Then
                Exit Sub
            End If
            CheckIsAttackBigerThanProtect()
            If AttackBigerThanProtect = True Then
                CheckAttackerAttackBy()
            End If
        Next i

    End Sub

    Public Sub CheckPaoMaLocation()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim dbreader As SqlClient.SqlDataReader
        Dim TmStr As String

        PiecePic = "PaoMa"
        i = 1
        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "select * from PieceStatus where (PieceScore = 3 and PictureBoxColor = 'Black' and IsAttacked = 'True')"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            While dbreader.Read
                PaoMaLocation(i) = dbreader("PicNo")
                i = i + 1
            End While
            MsgBox(PaoMaLocation(1), MsgBoxStyle.OkOnly)
            MsgBox(PaoMaLocation(2), MsgBoxStyle.OkOnly)
            MsgBox(PaoMaLocation(3), MsgBoxStyle.OkOnly)
            MsgBox(PaoMaLocation(4), MsgBoxStyle.OkOnly)
        Else
        End If
        dbreader.Close()
        myconnection.Close()

        For i = 1 To 4
            CheckCurrPicAttackBy()
            If AttackerPicLocation = 0 Then
                Exit Sub
            End If
            CheckIsAttackBigerThanProtect()
            If AttackBigerThanProtect = True Then
                CheckAttackerAttackBy()
            End If
        Next i

    End Sub

    Public Sub CheckBingZuLocation()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim dbreader As SqlClient.SqlDataReader
        Dim TmStr As String

        PiecePic = "BingZu"
        i = 1
        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "select * from PieceStatus where (PieceScore = 2 and PictureBoxColor = 'Black' and IsAttacked = 'True')"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            While dbreader.Read
                BingZuLocation(i) = dbreader("PicNo")
                i = i + 1
            End While
            MsgBox(BingZuLocation(1), MsgBoxStyle.OkOnly)
            MsgBox(BingZuLocation(2), MsgBoxStyle.OkOnly)
            MsgBox(BingZuLocation(3), MsgBoxStyle.OkOnly)
            MsgBox(BingZuLocation(4), MsgBoxStyle.OkOnly)
            MsgBox(BingZuLocation(5), MsgBoxStyle.OkOnly)
        Else
        End If
        dbreader.Close()
        myconnection.Close()

        For i = 1 To 5
            CheckCurrPicAttackBy()
            If AttackerPicLocation = 0 Then
                Exit Sub
            End If
            CheckIsAttackBigerThanProtect()
            If AttackBigerThanProtect = True Then
                CheckAttackerAttackBy()
            End If
        Next i

    End Sub

    Public Sub CheckXiangShiLocation()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim dbreader As SqlClient.SqlDataReader

        Dim TmStr As String

        PiecePic = "XiangShi"
        i = 1
        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "select * from PieceStatus where (PieceScore = 1 and PictureBoxColor = 'Black' and IsAttacked = 'True')"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            While dbreader.Read
                XiangShiLocation(i) = dbreader("PicNo")
                i = i + 1
            End While
            MsgBox(XiangShiLocation(1), MsgBoxStyle.OkOnly)
            MsgBox(XiangShiLocation(2), MsgBoxStyle.OkOnly)
            MsgBox(XiangShiLocation(3), MsgBoxStyle.OkOnly)
            MsgBox(XiangShiLocation(4), MsgBoxStyle.OkOnly)
        Else
        End If
        dbreader.Close()
        myconnection.Close()

        For i = 1 To 4
            CheckCurrPicAttackBy()
            If AttackerPicLocation = 0 Then
                Exit Sub
            End If
            CheckIsAttackBigerThanProtect()
            If AttackBigerThanProtect = True Then
                CheckAttackerAttackBy()
            End If
        Next i

    End Sub

    Private Sub CheckCurrPicAttackBy()

        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim dbreader As SqlClient.SqlDataReader
        Dim TmStr As String

        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = ""
        If PiecePic = "Jiang" Then
            TmStr = "select * from AttackOrProtectBy where CurrPic = " & JiangLocation & " and AttackOrProtect = ' Attack By ' "
            TargetLocation = JiangLocation
        ElseIf PiecePic = "Che" Then
            TmStr = "select * from AttackOrProtectBy where CurrPic = " & CheLocation(i) & " and AttackOrProtect = ' Attack By ' "
            TargetLocation = CheLocation(i)
        ElseIf PiecePic = "PaoMa" Then
            TmStr = "select * from AttackOrProtectBy where CurrPic = " & PaoMaLocation(i) & " and AttackOrProtect = ' Attack By ' "
            TargetLocation = PaoMaLocation(i)
        ElseIf PiecePic = "BingZu" Then
            TmStr = "select * from AttackOrProtectBy where CurrPic = " & BingZuLocation(i) & " and AttackOrProtect = ' Attack By ' "
            TargetLocation = BingZuLocation(i)
        ElseIf PiecePic = "XiangShi" Then
            TmStr = "select * from AttackOrProtectBy where CurrPic = " & XiangShiLocation(i) & " and AttackOrProtect = ' Attack By ' "
            TargetLocation = XiangShiLocation(i)
        End If
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            While dbreader.Read
                AttackerPicLocation = dbreader("ByPic")
                Location = dbreader("ByPic")
                CheckPicturebox()
                EnemyAttackerLocation = RowColumn
            End While
        Else
            AttackerPicLocation = 0
        End If
        dbreader.Close()
        myconnection.Close()
    End Sub

    Private Sub CheckIsAttackBigerThanProtect()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim dbreader As SqlClient.SqlDataReader
        Dim TmStr As String

        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "select * from PieceStatus where PicNo = " & AttackerPicLocation & " and (ProtectedLevel <AttackedLevel)"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
            myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            AttackBigerThanProtect = True
        Else
            AttackBigerThanProtect = False
        End If
        dbreader.Close()
        myconnection.Close()
    End Sub

    Private Sub CheckIsProtectBigerThanAttack()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim dbreader As SqlClient.SqlDataReader
        Dim TmStr As String

        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "select * from PieceStatus where PicNo = " & PictureboxAbleToBlock1 '& " and (ProtectedLevel > AttackedLevel)"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            While dbreader.Read
                DifferenceProtectAttack(l) = dbreader("ProtectedLevel") - dbreader("AttackedLevel")
            End While
            'AttackBigerThanProtect = True
        Else
            'AttackBigerThanProtect = False
        End If
        dbreader.Close()
        myconnection.Close()

        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "Insert into ProtectAttackDifference (ID, Difference) values (" & l & ", " & DifferenceProtectAttack(l) & ")"

        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        myconnection.Close()
    End Sub

    Public Sub CheckWhichPositionMoreFree()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim dbreader As SqlClient.SqlDataReader
        Dim TmStr As String

        RowColumn = ToHor(l) & ToVer(l)
        ChangeToPicNo()

        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "select Count(*) as MoveCount from AttackOrProtectBy where AttackOrProtect = ' Move Available ' and ByPic = " & PictureboxNo
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            While dbreader.Read
                'MsgBox(dbreader("MoveCount"), MsgBoxStyle.OkOnly)
                MoveCount(l) = dbreader("MoveCount")
            End While
        Else
        End If
        dbreader.Close()
        myconnection.Close()

        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "Insert into MoveCountTable (ID, MoveCount) values (" & l & ", " & MoveCount(l) & ")"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        myconnection.Close()
    End Sub

    Private Sub CheckAttackerAttackBy()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim dbreader As SqlClient.SqlDataReader
        Dim TmStr As String

        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "select * from AttackOrProtectBy where CurrPic = " & AttackerPicLocation & " and AttackOrProtect = ' Attack By ' "
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            While dbreader.Read
                Location = dbreader("ByPic")
                CheckPicturebox()
                OurAttackerLocation = RowColumn
            End While
        Else
        End If
        dbreader.Close()
        myconnection.Close()
    End Sub

    'Public Sub CheAttackerDefence()
    '    Location = TargetLocation
    '    CheckPicturebox()
    '    TargetLocationRowColumn = RowColumn
    '    AttackerLocation = EnemyAttackerLocation
    '    ' here
    'End Sub

    Public Sub SimulateMove()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim TmStr As String

        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "Delete * from ProtectAttackDifference"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        myconnection.Close()

        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "Delete * from MoveCountTable"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        myconnection.Close()

        SavePurpose = "saveBeforeSimulating"
        Form1.SavePieceLocation()
        For l = 1 To 50
            'MsgBox(FromHor(l), MsgBoxStyle.OkOnly)
            If FromHor(l) = "" Then
                Exit For
            End If
            Form1.fromHorAlTxt.Text = FromHor(l)
            Form1.fromVerNumTxt.Text = FromVer(l)
            Form1.toHorAlTxt.Text = ToHor(l)
            Form1.toVerNumTxt.Text = ToVer(l)
            AIMovement = True
            Form1.moveBtn.PerformClick()
            'CheckProtectedPiece()
            'ProtectedPieceSaveData()
            ProtectedPieceForm.ShowDialog()
            'AttackOrProtectBySaveData()
            AttackOrProtectBy.ShowDialog()
            If WhichSimulate = "Block" Then
                CheckPictureboxAbleToBlock()
                CheckIsProtectBigerThanAttack()
            ElseIf WhichSimulate = "Evade" Then
                CheckIsAttackedByPao()
                If IsWhite = True Then
                Else
                    CheckWhichPositionMoreFree()
                    IsWhite = False
                End If
            End If
            RetrieveFrom = "saveBeforeSimulating"
            Form1.RetriveSavePieceLocation()
            RetrivePiece()
            AIMovement = False
        Next l

        ' check max difference
        If WhichSimulate = "Block" Then
            CheckMaxDifference()
        ElseIf WhichSimulate = "Evade" Then
            CheckMaxMoveCount()
        End If

        Form1.fromHorAlTxt.Text = FromHor(l2)
        Form1.fromVerNumTxt.Text = FromVer(l2)
        Form1.toHorAlTxt.Text = ToHor(l2)
        Form1.toVerNumTxt.Text = ToVer(l2)
        Form1.moveBtn.PerformClick()

    End Sub

    Public Sub CheckIsAttackedByPao()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim dbreader As SqlClient.SqlDataReader

        Dim TmStr As String

        RowColumn = ToHor(l) & ToVer(l)
        ChangeToPicNo()
        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "select * from AttackOrProtectBy where CurrPic = " & PictureboxNo & " and AttackOrProtect = ' Attack By '"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            While dbreader.Read
                PictureboxNo = dbreader("ByPic")
            End While
        Else
            IsWhite = False
            dbreader.Close()
            myconnection.Close()
            Exit Sub
        End If
        dbreader.Close()
        myconnection.Close()

        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "select * from PieceStatus where PicNo = " & PictureboxNo & " and PictureBoxColor = 'White'"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            IsWhite = True
        Else
        End If
        dbreader.Close()
        myconnection.Close()
    End Sub

    Public Sub CheckPictureboxAbleToBlock()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim dbreader As SqlClient.SqlDataReader
        Dim TmStr As String

        'For i = 0 To 10
        '    PictureboxAbleToBlock1(i) = 0
        'Next i

        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "select * from ChangeToHorVer where FromHor = '" & FromHor(l) & "' and FromVer = '" & FromVer(l) & "' and ToHor = '" & ToHor(l) & "' and ToVer = '" & ToVer(l) & "'"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            While dbreader.Read
                PictureboxAbleToBlock1 = dbreader("PictureboxAbleToBlock")
            End While
        Else
        End If
        dbreader.Close()
        myconnection.Close()
    End Sub

    Public Sub CheckMaxDifference()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim dbreader As SqlClient.SqlDataReader
        Dim TmStr As String
        Dim MaxDiff As Integer

        i = 1

        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "select Max(Difference) as MaxDiff from ProtectAttackDifference"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            While dbreader.Read
                MaxDiff = dbreader("MaxDiff")
            End While
        Else
        End If
        dbreader.Close()
        myOleCommand.CommandText = "Select Count(ID) as IDCount from ProtectAttackDifference where Difference = " & MaxDiff
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            While dbreader.Read
                If (dbreader("IDCount") = 1) Then
                    dbreader.Close()
                    myOleCommand.CommandText = "Select ID from ProtectAttackDifference where Difference = " & MaxDiff
                    myOleCommand.ExecuteNonQuery()
                    dbreader = myOleCommand.ExecuteReader()
                    If dbreader.HasRows Then
                        While dbreader.Read ' here, three ID same maxDiff
                            l2 = dbreader("ID")
                        End While
                    Else
                    End If
                ElseIf (dbreader("IDCount") > 1) Then
                    MsgBox("Same MaxDiff", MsgBoxStyle.OkOnly)
                    ' here, check for other condition
                End If
            End While
        End If
        dbreader.Close()
        myconnection.Close()
    End Sub

    Public Sub CheckMaxMoveCount()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim dbreader As SqlClient.SqlDataReader
        Dim TmStr As String
        Dim MaxMoveCount As Integer

        i = 1
        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "select Max(MoveCount) as MaxMoveCount from MoveCountTable"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            While dbreader.Read
                If IsDBNull(dbreader("MaxMoveCount")) Then
                    Exit Sub
                End If
                MaxMoveCount = dbreader("MaxMoveCount")
            End While
        Else
        End If
        dbreader.Close()
        myOleCommand.CommandText = "Select ID from MoveCountTable where MoveCount = " & MaxMoveCount
        myOleCommand.ExecuteNonQuery()
        dbreader = myOleCommand.ExecuteReader()
        If dbreader.HasRows Then
            While dbreader.Read ' here, three ID same maxDiff
                'o(i) = dbreader("ID")
                'i = i + 1
                l2 = dbreader("ID")
            End While
        Else
        End If
        dbreader.Close()
        myconnection.Close()
    End Sub

    Public Sub Block1()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim dbreader As SqlClient.SqlDataReader
        Dim TmStr As String

        j = 1
        For i = 1 To 10
            If PictureboxAbleToBlock(i) = 0 Then
                Exit For
            End If
            myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
            'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
            TmStr = "select * from AttackOrProtectBy where CurrPic = " & PictureboxAbleToBlock(i) & " and AttackOrProtect = ' Move Available ' and ByPic <> " & AttackerPicLocation & " and ByPic <> " & TargetLocation
            'MsgBox(PictureboxAbleToBlock(i), MsgBoxStyle.OkOnly)
            myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
            'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
            myconnection.Open()
            myOleCommand.ExecuteNonQuery()
            dbreader = myOleCommand.ExecuteReader()
            If dbreader.HasRows Then
                While dbreader.Read
                    Location = dbreader("ByPic")
                    'MsgBox(Location, MsgBoxStyle.OkOnly)
                    LocationAbleToBlock1(j) = Location
                    j = j + 1
                End While
            Else
            End If
            dbreader.Close()
            myconnection.Close()
        Next i

        k = 1
        For j = 1 To 10
            If LocationAbleToBlock1(j) = 0 Then
                Exit For
            End If
            myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
            'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
            TmStr = "select * from PieceStatus where PicNo = " & LocationAbleToBlock1(j) & " and PictureBoxColor = 'Black'"
            myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
            'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
            myconnection.Open()
            myOleCommand.ExecuteNonQuery()
            dbreader = myOleCommand.ExecuteReader()
            If dbreader.HasRows Then
                While dbreader.Read
                    LocationAbleToBlock2(k) = dbreader("PicNo")
                    'MsgBox(LocationAbleToBlock2(k), MsgBoxStyle.OkOnly)
                    k = k + 1
                End While
            Else
            End If
            dbreader.Close()
            myconnection.Close()
        Next j

        l = 1
        For i = 1 To 10
            If PictureboxAbleToBlock(i) = 0 Then
                Exit For
            End If
            For k = 1 To 10
                If LocationAbleToBlock2(k) = 0 Then
                    Exit For
                End If
                myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
                'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
                TmStr = "select * from AttackOrProtectBy where CurrPic = " & PictureboxAbleToBlock(i) & " and AttackOrProtect = ' Move Available ' and ByPic = " & LocationAbleToBlock2(k)
                myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
                'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
                'MsgBox(PictureboxAbleToBlock(i), MsgBoxStyle.OkOnly)
                'MsgBox(LocationAbleToBlock2(k), MsgBoxStyle.OkOnly)
                myconnection.Open()
                myOleCommand.ExecuteNonQuery()
                dbreader = myOleCommand.ExecuteReader()
                If dbreader.HasRows Then
                    While dbreader.Read
                        Location = LocationAbleToBlock2(k)
                        CheckPicturebox()
                        ChangeToHorVer()
                        FromHor(l) = Horizontal
                        FromVer(l) = Vertical
                        Location = PictureboxAbleToBlock(i)
                        CheckPicturebox()
                        ChangeToHorVer()
                        ToHor(l) = Horizontal
                        ToVer(l) = Vertical
                        myOleCommand.CommandText = "Insert into ChangeToHorVer (LocationAbleToBlock2, FromHor, FromVer, PictureboxAbleToBlock, ToHor, ToVer) values (" & LocationAbleToBlock2(k) & ", '" & FromHor(l) & "', '" & FromVer(l) & "', " & PictureboxAbleToBlock(i) & ", '" & ToHor(l) & "', '" & ToVer(l) & "')"
                        l = l + 1
                        n = l
                    End While
                Else
                End If
                dbreader.Close()
                myOleCommand.ExecuteNonQuery()
                myconnection.Close()
            Next k
        Next i
    End Sub
End Module
