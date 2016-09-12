Imports System.Data.SqlClient
Imports System.Windows.Forms

Module ModuleDatabase

    'Dim myconnection As OleDb.OleDbConnection
    'Dim myOleCommand As OleDb.OleDbCommand
    'Dim dbreader As OleDb.OleDbDataReader
    'myconnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ChineseChessDatabase.mdb")
    'myOleCommand = New OleDb.OleDbCommand("select max([Table Number]) as tableNoMax from TableNumber", myconnection)

    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    'Dim dbreader As SqlDataReader
    Dim myadapter As SqlDataAdapter
    Dim bindingsource As BindingSource
    Dim dataTable As DataTable
    'Dim gridInfo As DataGridView

    Dim conStr As String
    Dim _startCol As Integer

    Public Class libDBCon

        Shared Sub New()
            mycommand = New SqlCommand
            myadapter = New SqlDataAdapter
            bindingsource = New BindingSource
            dataTable = New DataTable
            'gridInfo = New DataGridView

            conStr = "server=desktop-jack;database=chinesechessdatabase;trusted_connection=true;"
            myconnection = New System.Data.SqlClient.SqlConnection(conStr)

            myadapter.AcceptChangesDuringFill = False
            'gridInfo.AutoGenerateColumns = True

        End Sub

        ' Create Using SQL Script 
        Public Sub CreateTable()

            'Dim tableNumber As Integer
            ''myconnection = New System.Data.SqlClient.SqlConnection("server=desktop-jack;database=chinesechessdatabase;trusted_connection=true;")
            'myolecommand = New System.Data.SqlClient.SqlCommand("select max([Table Number]) as tableNoMax from TableNumber", myconnection)

            'myconnection.Open()
            'myolecommand.ExecuteNonQuery()
            'dbreader = myolecommand.ExecuteReader()
            'If dbreader.HasRows Then
            '    While dbreader.Read()
            '        Me.Table_NumberTextBox.Text = dbreader("tableNoMax")
            '    End While
            '    tableNumber = Me.Table_NumberTextBox.Text + 1
            '    dbreader.Close()
            'Else
            '    MsgBox("Query return no row", MsgBoxStyle.OkOnly)
            'End If
            'myolecommand.CommandText = "CREATE TABLE Record" & tableNumber & "([ID] AUTOINCREMENT(1, 1) NOT NULL PRIMARY KEY ,[No] int,[White Movement] text(20), [Black Movement] text(20))"
            'myolecommand.ExecuteNonQuery()
            'myolecommand.CommandText = "INSERT INTO TableNumber values (" & tableNumber & ", " & tableNumber & ")"
            'myolecommand.ExecuteNonQuery()
            'myconnection.Close()
            'round = 0

            'ClearPieceProtectedPic()
            'ClearNoPieceProtected()
            'ClearPieceAttackedPic()
            'ClearNoPieceAttacked()
        End Sub

        ' Create By passing in Parameters
        Public Sub CreateTable(dbName As String, column As List(Of String))

        End Sub

        ' Execute Query Select - Get similar
        Public Shared Sub ExecGetSQL(query As String, filter As String, Optional startCol As Integer = 0)

            _startCol = startCol
            'gridInfo.Refresh()
            'bindingsource.Clear()
            bindingsource.DataSource = vbNull
            dataTable.Clear()

            'write source to datagridview by passing the data source
            mycommand = New SqlCommand(query + " " + filter, myconnection)
            myadapter.SelectCommand = mycommand
            myadapter.Fill(dataTable)
            bindingsource.DataSource = dataTable
            'gridInfo.DataSource = bindingsource
            'gridInfo.ResetBindings()
            'bindingsource.ResetBindings(True)

            ' write source to datagridview by reading from data reader. 
            '==============================================================
            'myconnection.Open()
            'dbreader = mycommand.ExecuteReader()
            'If dbreader.HasRows Then
            '    ' write some detail to console. 
            '    Console.WriteLine("dbreader has rows.")
            '    While (dbreader.Read())
            '        Console.WriteLine("Write datasource to data grid view.")
            '        gridInfo.Rows.Add(dbreader.GetValue(startCol))
            '        gridInfo.Rows.Add()
            '    End While
            'Else
            '    ' future - through some exception. 
            '    ' write some detail to console.
            '    Console.WriteLine("dbreader does not has row.")
            'End If
            'myconnection.Close()
            '==============================================================
        End Sub

        ' Execute Query Select - Post similar
        Public Shared Sub ExecPostSQL(query As String, filter As String)
            mycommand = New SqlCommand(query + " " + filter, myconnection)
            myconnection.Open()
            mycommand.ExecuteNonQuery()
            myconnection.Close()
        End Sub

        Public Shared Function GetGridInfo() As DataTable
            ' tracking startCol 
            'Console.WriteLine("Start Column Index = " + _startCol.ToString())
            Return dataTable
        End Function

    End Class
End Module
