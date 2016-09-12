' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 01/10/2010 to 28/10/2010
' Descripitons : Chinese Chess V1

Module ModuleNoBlock
    Public Sub noBlock()
        If (Form1.currentPic.Image Is Form1.whiteJiangPic.Image) Or _
        (Form1.currentPic.Image Is Form1.blackJiangPic.Image) Or _
        (Form1.currentPic.Image Is Form1.whiteShiPic.Image) Or _
        (Form1.currentPic.Image Is Form1.blackShiPic.Image) Or _
        (Form1.currentPic.Image Is Form1.whiteZuPic.Image) Or _
        (Form1.currentPic.Image Is Form1.blackBingPic.Image) Then
            blockBool = False
        End If
    End Sub
End Module
