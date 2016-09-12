' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 01/10/2010 to 28/10/2010
' Descripitons : Chinese Chess V1

Module ModuleXiangBlock
    Public Sub checkWhiteXiangC10Block()
        If positionTwo = "a8" Then
            If (Form1.PictureBox11.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e8" Then
            If (Form1.PictureBox13.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkWhiteXiangG10Block()
        If positionTwo = "e8" Then
            If (Form1.PictureBox15.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "i8" Then
            If (Form1.PictureBox17.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkWhiteXiangA8Block()
        If positionTwo = "c10" Then
            If (Form1.PictureBox11.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c6" Then
            If (Form1.PictureBox29.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If

    End Sub
    Public Sub checkWhiteXiangE8Block()
        If positionTwo = "c10" Then
            If (Form1.PictureBox13.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g10" Then
            If (Form1.PictureBox15.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c6" Then
            If (Form1.PictureBox31.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g6" Then
            If (Form1.PictureBox33.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkWhiteXiangI8Block()
        If positionTwo = "g10" Then
            If (Form1.PictureBox17.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g6" Then
            If (Form1.PictureBox35.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkWhiteXiangC6Block()
        If positionTwo = "a8" Then
            If (Form1.PictureBox29.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e8" Then
            If (Form1.PictureBox31.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkWhiteXiangG6Block()
        If positionTwo = "e8" Then
            If (Form1.PictureBox33.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "i8" Then
            If (Form1.PictureBox35.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub

    Public Sub checkBlackXiangC1Block()
        If positionTwo = "a3" Then
            If (Form1.PictureBox74.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e3" Then
            If (Form1.PictureBox76.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkBlackXiangG1Block()
        If positionTwo = "e3" Then
            If (Form1.PictureBox78.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "i3" Then
            If (Form1.PictureBox80.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkBlackXiangA3Block()
        If positionTwo = "c1" Then
            If (Form1.PictureBox74.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c5" Then
            If (Form1.PictureBox56.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkBlackXiangE3Block()
        If positionTwo = "c5" Then
            If (Form1.PictureBox58.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g5" Then
            If (Form1.PictureBox60.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c1" Then
            If (Form1.PictureBox76.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g1" Then
            If (Form1.PictureBox78.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkBlackXiangI3Block()
        If positionTwo = "g5" Then
            If (Form1.PictureBox62.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g1" Then
            If (Form1.PictureBox80.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkBlackXiangC5Block()
        If positionTwo = "a3" Then
            If (Form1.PictureBox56.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e3" Then
            If (Form1.PictureBox58.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkBlackXiangG5Block()
        If positionTwo = "e3" Then
            If (Form1.PictureBox60.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "i3" Then
            If (Form1.PictureBox62.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
End Module
