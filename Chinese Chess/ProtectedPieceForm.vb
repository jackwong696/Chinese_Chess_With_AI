' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 20/11/2010
' Descripitons : Chinese Chess V1

Public Class ProtectedPieceForm
    Private Sub ProtectedPieceForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CheckProtectedPiece()
        ProtectedPieceSaveData()
        'ViewData()
        ClearNoPieceProtected()
        ClearPieceProtectedPic()
        ClearPieceAttackedPic()
        ClearNoPieceAttacked()
        ClearPictureboxColor()
        Me.Close()
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        ClearNoPieceProtected()
        ClearPieceProtectedPic()
        ClearPieceAttackedPic()
        ClearNoPieceAttacked()
        ClearPictureboxColor()
        Me.Close()
    End Sub

    Private Sub ViewData()
        Dim itemAdd1 As ListViewItem
        Dim i As Integer

        Me.ListView1.Items.Clear()
        For i = 1 To 90
            itemAdd1 = Me.ListView1.Items.Add(i)
            itemAdd1.SubItems.Add(GotPiece(i))
            itemAdd1.SubItems.Add(Form1.PieceProtectedPic(i))
            itemAdd1.SubItems.Add(Form1.NoPieceProtected(i))
            itemAdd1.SubItems.Add(PieceScore(i))
            itemAdd1.SubItems.Add(Form1.PieceAttackedPic(i))
            itemAdd1.SubItems.Add(Form1.NoPieceAttacked(i))
            itemAdd1.SubItems.Add(PictureboxColor(i))
        Next i

    End Sub
End Class