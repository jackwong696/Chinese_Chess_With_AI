Imports System.Data.SqlClient
Imports System.Data.SqlDbType

Public Class Form2
    Private Sub okBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okBtn.Click
        'Dim sqlQuery As String
        'Dim myconnection As SqlConnection
        'Dim myOleCommand As SqlCommand
        'Dim dbreader As SqlDataReader

        'Dim myconnection As OleDb.OleDbConnection
        'Dim myOleCommand As OleDb.OleDbCommand
        'Dim dbreader As OleDb.OleDbDataReader

        Dim initScore As Integer = 1500
        Dim playercolor As Integer = 0 ' 0 = white, 1 = black 

        If Me.nameTxt.Text = "" Then
            MsgBox("Please enter a name.", MsgBoxStyle.OkOnly)
            Me.nameTxt.Focus()
            Exit Sub
        End If

        'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.14.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")

        'myconnection = New SqlConnection("Server=DESKTOP-JACK;Database=ChineseChessDatabase;Trusted_Connection=True;")
        'sqlQuery = "select * from userscore where username = '" & Me.nameTxt.Text & "'"

        'myOleCommand = New OleDb.OleDbCommand(sqlQuery, myconnection)

        'myolecommand = New SqlCommand(sqlQuery, myconnection)
        'myconnection.Open()
        'myOleCommand.ExecuteNonQuery()

        'dbreader = myOleCommand.ExecuteReader()
        libDBCon.ExecGetSQL("SELECT * FROM userscore WHERE username = '" & Me.nameTxt.Text & "'", "")

        If Me.whiteRBtn.Checked = True Then
            Form1.playerTurn = "1st"
            playercolor = 0
        ElseIf Me.blackRBtn.Checked = True Then
            Form1.playerTurn = "2nd"
            playercolor = 1
        End If

        If libDBCon.GetGridInfo().Rows.Count <> 0 Then

            Form1.UserNameTextBox.Text = libDBCon.GetGridInfo.Rows(0)(libDBCon.GetGridInfo.Columns("UserName").Ordinal).ToString()
            Form1.ScoreTextBox.Text = libDBCon.GetGridInfo.Rows(0)(libDBCon.GetGridInfo.Columns("Score").Ordinal).ToString()
            libDBCon.ExecPostSQL("UPDATE UserScore SET [CurrentColor] = " & playercolor, " WHERE UserName = '" & libDBCon.GetGridInfo.Rows(0)(1).ToString() & "' ")
            ' ===============================================
            'While libDBCon.GetDbReader().Read()
            '    Form1.UserNameTextBox.Text = libDBCon.GetDbReader()("username")
            '    Form1.ScoreTextBox.Text = libDBCon.GetDbReader()("score")
            'End While
            'libDBCon.GetDbReader().Close()
            ' ===============================================
        Else
            'libDBCon.GetDbReader().Close()
            libDBCon.ExecPostSQL("INSERT INTO userscore ([username], [score], [CurrentColor]) VALUES ('" & Me.nameTxt.Text & "', " & initScore & ", " & playercolor & " )", "")
            'myolecommand.CommandText = "insert into userscore ([username], [score]) values ('" & Me.nameTxt.Text & "', 0 )"
            'myolecommand.ExecuteNonQuery()
            Form1.UserNameTextBox.Text = Me.nameTxt.Text
            Form1.ScoreTextBox.Text = 0
        End If
        'myconnection.Close()

        ' Generate a new table. 
        'myconnection.Open()
        'myOleCommand.CommandText = " INSERT "

        Me.nameTxt.Clear()
        Me.Close()
        ClearPicturebox()
        LoadBlackPieaces()
        LoadWhitePieaces()
        Form1.Button2.PerformClick()

    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.whiteRBtn.Checked = True
    End Sub
End Class