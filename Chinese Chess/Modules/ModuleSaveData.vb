' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 01/02/2011
' Descripitons : Chinese Chess V1

Module ModuleSaveData

    Public Sub AttackOrProtectBySaveData()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim TmStr As String
        Dim i As Integer

        myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
        TmStr = "Delete * from AttackOrProtectBy"
        myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
        'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
        myconnection.Open()
        myOleCommand.ExecuteNonQuery()
        myconnection.Close()

        For i = 1 To Length
            myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
            'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
            TmStr = "Insert into AttackOrProtectBy (ID, CurrPic, AttackOrProtect, ByPic) values (" & i & ", " & CurrPic(i) & ", '" & AttackOrProtect(i) & "', " & ByArray(i) & ")"
            myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
            'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
            myconnection.Open()
            myOleCommand.ExecuteNonQuery()
            myconnection.Close()
        Next i
    End Sub

    Public Sub ProtectedPieceSaveData()
        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        Dim myconnection As SqlClient.SqlConnection
        Dim myOleCommand As SqlClient.SqlCommand
        Dim TmStr As String
        Dim i As Integer

        For i = 1 To 90
            myconnection = New SqlClient.SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
            'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
            TmStr = "Update PieceStatus set GotPiece = '" & GotPiece(i) & "', IsProtected = '" & Form1.PieceProtectedPic(i) & "', ProtectedLevel = " & Form1.NoPieceProtected(i) & ", IsAttacked = '" & Form1.PieceAttackedPic(i) & "', AttackedLevel = " & Form1.NoPieceAttacked(i) & ", PieceScore = " & PieceScore(i) & ", PictureBoxColor = '" & PictureboxColor(i) & "' Where PicNo = " & i & ""
            myOleCommand = New SqlClient.SqlCommand(TmStr, myconnection)
            'myOleCommand = New OleDb.OleDbCommand(TmStr, myconnection)
            myconnection.Open()
            myOleCommand.ExecuteNonQuery()
            myconnection.Close()
        Next i
    End Sub
End Module
