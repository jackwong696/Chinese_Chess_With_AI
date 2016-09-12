' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 07/01/2011
' Descripitons : Chinese Chess V1

Public Class AttackOrProtectBy
    Dim i As Integer

    Private Sub ViewData()
        Dim itemAdd1 As ListViewItem

        Me.ListView1.Items.Clear()
        For i = 1 To Length
            itemAdd1 = Me.ListView1.Items.Add(i)
            itemAdd1.SubItems.Add(CurrPic(i))
            itemAdd1.SubItems.Add(AttackOrProtect(i))
            itemAdd1.SubItems.Add(ByArray(i))
        Next i
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub AttackOrProtectBy_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        AttackOrProtectBySaveData()
        'ViewData()
        Me.Close()
    End Sub
End Class