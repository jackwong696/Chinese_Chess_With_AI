' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 01/10/2010 to 28/10/2010
' Descripitons : Chinese Chess V1

Module ModuleMaBlock

    Public Sub checkMaA1Block()
        If positionTwo = "b3" Then
            If (Form1.PictureBox73.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c2" Then
            If (Form1.PictureBox83.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaB1Block()
        If positionTwo = "a3" Or positionTwo = "c3" Then
            If (Form1.PictureBox74.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d2" Then
            If (Form1.PictureBox84.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaC1Block()
        If positionTwo = "a2" Then
            If (Form1.PictureBox83.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b3" Or positionTwo = "d3" Then
            If (Form1.PictureBox75.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e2" Then
            If (Form1.PictureBox85.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaD1Block()
        If positionTwo = "b2" Then
            If (Form1.PictureBox84.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c3" Or positionTwo = "e3" Then
            If (Form1.PictureBox76.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f2" Then
            If (Form1.PictureBox86.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaE1Block()
        If positionTwo = "c2" Then
            If (Form1.PictureBox85.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d3" Or positionTwo = "f3" Then
            If (Form1.PictureBox77.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g2" Then
            If (Form1.PictureBox87.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaF1Block()
        If positionTwo = "d2" Then
            If (Form1.PictureBox86.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e3" Or positionTwo = "g3" Then
            If (Form1.PictureBox78.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h2" Then
            If (Form1.PictureBox88.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaG1Block()
        If positionTwo = "e2" Then
            If (Form1.PictureBox87.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f3" Or positionTwo = "h3" Then
            If (Form1.PictureBox79.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "i2" Then
            If (Form1.PictureBox89.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaH1Block()
        If positionTwo = "f2" Then
            If (Form1.PictureBox88.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g3" Or positionTwo = "i3" Then
            If (Form1.PictureBox80.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
            'ElseIf positionTwo = "" Then
            '    If (Form1.PictureBox90.Image IsNot Form1.nonePic.Image) Then
            '        blockBool = True
            '    Else
            '        blockBool = False
            '    End If
        End If
    End Sub
    Public Sub checkMaI1Block()
        If positionTwo = "g2" Then
            If (Form1.PictureBox89.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h3" Then
            If (Form1.PictureBox81.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub

    Public Sub checkMaA2Block()
        If positionTwo = "b4" Then
            If (Form1.PictureBox64.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c3" Or positionTwo = "c1" Then
            If (Form1.PictureBox74.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaB2Block()
        If positionTwo = "a4" Or positionTwo = "c4" Then
            If (Form1.PictureBox65.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d3" Or positionTwo = "d1" Then
            If (Form1.PictureBox75.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaC2Block()
        If positionTwo = "a3" Or positionTwo = "a1" Then
            If (Form1.PictureBox74.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b4" Or positionTwo = "d4" Then
            If (Form1.PictureBox66.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e3" Or positionTwo = "e1" Then
            If (Form1.PictureBox76.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaD2Block()
        If positionTwo = "b3" Or positionTwo = "b1" Then
            If (Form1.PictureBox75.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c4" Or positionTwo = "e4" Then
            If (Form1.PictureBox67.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f3" Or positionTwo = "f1" Then
            If (Form1.PictureBox77.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaE2Block()
        If positionTwo = "c3" Or positionTwo = "c1" Then
            If (Form1.PictureBox76.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d4" Or positionTwo = "f4" Then
            If (Form1.PictureBox68.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g3" Or positionTwo = "g1" Then
            If (Form1.PictureBox78.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaF2Block()
        If positionTwo = "d3" Or positionTwo = "d1" Then
            If (Form1.PictureBox77.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e4" Or positionTwo = "g4" Then
            If (Form1.PictureBox69.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h3" Or positionTwo = "h1" Then
            If (Form1.PictureBox79.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaG2Block()
        If positionTwo = "e3" Or positionTwo = "e1" Then
            If (Form1.PictureBox78.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f4" Or positionTwo = "h4" Then
            If (Form1.PictureBox70.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "i3" Or positionTwo = "i1" Then
            If (Form1.PictureBox80.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaH2Block()
        If positionTwo = "f3" Or positionTwo = "f1" Then
            If (Form1.PictureBox79.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g4" Or positionTwo = "i4" Then
            If (Form1.PictureBox71.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
            'ElseIf positionTwo = "" Then
            '    If (Form1.PictureBox81.Image IsNot Form1.nonePic.Image) Then
            '        blockBool = True
            '    Else
            '        blockBool = False
            '    End If
        End If
    End Sub
    Public Sub checkMaI2Block()
        If positionTwo = "g3" Or positionTwo = "g1" Then
            If (Form1.PictureBox80.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h4" Then
            If (Form1.PictureBox72.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub

    Public Sub checkMaA3Block()
        If positionTwo = "b5" Then
            If (Form1.PictureBox55.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c4" Or positionTwo = "c2" Then
            If (Form1.PictureBox65.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b1" Then
            If (Form1.PictureBox73.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaB3Block()
        If positionTwo = "a5" Or positionTwo = "c5" Then
            If (Form1.PictureBox56.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d4" Or positionTwo = "d2" Then
            If (Form1.PictureBox66.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "a1" Or positionTwo = "c1" Then
            If (Form1.PictureBox74.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaC3Block()
        If positionTwo = "a4" Or positionTwo = "a2" Then
            If (Form1.PictureBox65.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b5" Or positionTwo = "d5" Then
            If (Form1.PictureBox57.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e4" Or positionTwo = "e2" Then
            If (Form1.PictureBox67.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b1" Or positionTwo = "d1" Then
            If (Form1.PictureBox75.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaD3Block()
        If positionTwo = "b4" Or positionTwo = "b2" Then
            If (Form1.PictureBox66.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c5" Or positionTwo = "e5" Then
            If (Form1.PictureBox58.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f4" Or positionTwo = "f2" Then
            If (Form1.PictureBox68.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c1" Or positionTwo = "e1" Then
            If (Form1.PictureBox76.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaE3Block()
        If positionTwo = "c4" Or positionTwo = "c2" Then
            If (Form1.PictureBox67.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d5" Or positionTwo = "f5" Then
            If (Form1.PictureBox59.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g4" Or positionTwo = "g2" Then
            If (Form1.PictureBox69.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d1" Or positionTwo = "f1" Then
            If (Form1.PictureBox77.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaF3Block()
        If positionTwo = "d4" Or positionTwo = "d2" Then
            If (Form1.PictureBox68.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e5" Or positionTwo = "g5" Then
            If (Form1.PictureBox60.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h4" Or positionTwo = "h2" Then
            If (Form1.PictureBox70.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e1" Or positionTwo = "g1" Then
            If (Form1.PictureBox78.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaG3Block()
        If positionTwo = "e4" Or positionTwo = "e2" Then
            If (Form1.PictureBox69.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f5" Or positionTwo = "h5" Then
            If (Form1.PictureBox61.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "i4" Or positionTwo = "i2" Then
            If (Form1.PictureBox71.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f1" Or positionTwo = "h1" Then
            If (Form1.PictureBox79.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaH3Block()
        If positionTwo = "f3" Or positionTwo = "f2" Then
            If (Form1.PictureBox70.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g5" Or positionTwo = "i5" Then
            If (Form1.PictureBox62.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g1" Or positionTwo = "i1" Then
            If (Form1.PictureBox80.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaI3Block()
        If positionTwo = "g4" Or positionTwo = "g2" Then
            If (Form1.PictureBox71.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h5" Then
            If (Form1.PictureBox63.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h1" Then
            If (Form1.PictureBox81.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub

    Public Sub checkMaA4Block()
        If positionTwo = "b6" Then
            If (Form1.PictureBox46.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c5" Or positionTwo = "c3" Then
            If (Form1.PictureBox56.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b2" Then
            If (Form1.PictureBox64.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaB4Block()
        If positionTwo = "a6" Or positionTwo = "c6" Then
            If (Form1.PictureBox47.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d5" Or positionTwo = "d3" Then
            If (Form1.PictureBox57.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "a2" Or positionTwo = "c2" Then
            If (Form1.PictureBox65.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaC4Block()
        If positionTwo = "a5" Or positionTwo = "a3" Then
            If (Form1.PictureBox56.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b6" Or positionTwo = "d6" Then
            If (Form1.PictureBox48.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e5" Or positionTwo = "e3" Then
            If (Form1.PictureBox58.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b2" Or positionTwo = "d2" Then
            If (Form1.PictureBox66.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaD4Block()
        If positionTwo = "b5" Or positionTwo = "b3" Then
            If (Form1.PictureBox57.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c6" Or positionTwo = "e6" Then
            If (Form1.PictureBox49.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f5" Or positionTwo = "f3" Then
            If (Form1.PictureBox59.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c2" Or positionTwo = "e2" Then
            If (Form1.PictureBox67.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaE4Block()
        If positionTwo = "c5" Or positionTwo = "c3" Then
            If (Form1.PictureBox58.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d6" Or positionTwo = "f6" Then
            If (Form1.PictureBox50.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g5" Or positionTwo = "g3" Then
            If (Form1.PictureBox60.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d2" Or positionTwo = "f2" Then
            If (Form1.PictureBox68.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaF4Block()
        If positionTwo = "d5" Or positionTwo = "d3" Then
            If (Form1.PictureBox59.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e6" Or positionTwo = "g6" Then
            If (Form1.PictureBox51.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h5" Or positionTwo = "h3" Then
            If (Form1.PictureBox61.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e2" Or positionTwo = "g2" Then
            If (Form1.PictureBox69.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaG4Block()
        If positionTwo = "e5" Or positionTwo = "e3" Then
            If (Form1.PictureBox60.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f6" Or positionTwo = "h6" Then
            If (Form1.PictureBox52.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "i5" Or positionTwo = "i3" Then
            If (Form1.PictureBox62.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f2" Or positionTwo = "h2" Then
            If (Form1.PictureBox70.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaH4Block()
        If positionTwo = "f5" Or positionTwo = "f3" Then
            If (Form1.PictureBox61.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g6" Or positionTwo = "i6" Then
            If (Form1.PictureBox53.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g2" Or positionTwo = "i2" Then
            If (Form1.PictureBox71.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaI4Block()
        If positionTwo = "g5" Or positionTwo = "g3" Then
            If (Form1.PictureBox62.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h6" Then
            If (Form1.PictureBox54.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h2" Then
            If (Form1.PictureBox72.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub

    Public Sub checkMaA5Block()
        If positionTwo = "b7" Then
            If (Form1.PictureBox37.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c6" Or positionTwo = "c4" Then
            If (Form1.PictureBox47.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b3" Then
            If (Form1.PictureBox55.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaB5Block()
        If positionTwo = "a7" Or positionTwo = "c7" Then
            If (Form1.PictureBox38.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d6" Or positionTwo = "d4" Then
            If (Form1.PictureBox48.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "a3" Or positionTwo = "c3" Then
            If (Form1.PictureBox56.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaC5Block()
        If positionTwo = "a6" Or positionTwo = "a4" Then
            If (Form1.PictureBox47.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b7" Or positionTwo = "d7" Then
            If (Form1.PictureBox39.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e6" Or positionTwo = "e4" Then
            If (Form1.PictureBox49.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b3" Or positionTwo = "d3" Then
            If (Form1.PictureBox57.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaD5Block()
        If positionTwo = "b6" Or positionTwo = "b4" Then
            If (Form1.PictureBox48.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c7" Or positionTwo = "e7" Then
            If (Form1.PictureBox40.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f6" Or positionTwo = "f4" Then
            If (Form1.PictureBox50.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c3" Or positionTwo = "e3" Then
            If (Form1.PictureBox58.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaE5Block()
        If positionTwo = "c6" Or positionTwo = "c4" Then
            If (Form1.PictureBox49.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d7" Or positionTwo = "f7" Then
            If (Form1.PictureBox41.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g6" Or positionTwo = "g4" Then
            If (Form1.PictureBox51.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d3" Or positionTwo = "f3" Then
            If (Form1.PictureBox59.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaF5Block()
        If positionTwo = "d6" Or positionTwo = "d4" Then
            If (Form1.PictureBox50.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e7" Or positionTwo = "g7" Then
            If (Form1.PictureBox42.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h6" Or positionTwo = "h4" Then
            If (Form1.PictureBox52.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e3" Or positionTwo = "g3" Then
            If (Form1.PictureBox60.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaG5Block()
        If positionTwo = "e6" Or positionTwo = "e4" Then
            If (Form1.PictureBox51.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f7" Or positionTwo = "h7" Then
            If (Form1.PictureBox43.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else : blockBool = False
            End If
        ElseIf positionTwo = "i6" Or positionTwo = "i4" Then
            If (Form1.PictureBox53.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f3" Or positionTwo = "h3" Then
            If (Form1.PictureBox61.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaH5Block()
        If positionTwo = "f6" Or positionTwo = "f4" Then
            If (Form1.PictureBox52.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g7" Or positionTwo = "i7" Then
            If (Form1.PictureBox44.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g3" Or positionTwo = "i3" Then
            If (Form1.PictureBox62.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaI5Block()
        If positionTwo = "g6" Or positionTwo = "g4" Then
            If (Form1.PictureBox53.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h7" Then
            If (Form1.PictureBox45.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h3" Then
            If (Form1.PictureBox63.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub

    Public Sub checkMaA6Block()
        If positionTwo = "b8" Then
            If (Form1.PictureBox28.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c7" Or positionTwo = "c5" Then
            If (Form1.PictureBox38.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b4" Then
            If (Form1.PictureBox46.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaB6Block()
        If positionTwo = "a8" Or positionTwo = "c8" Then
            If (Form1.PictureBox29.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d7" Or positionTwo = "d5" Then
            If (Form1.PictureBox39.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "a4" Or positionTwo = "c4" Then
            If (Form1.PictureBox47.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaC6Block()
        If positionTwo = "a7" Or positionTwo = "a5" Then
            If (Form1.PictureBox38.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b8" Or positionTwo = "d8" Then
            If (Form1.PictureBox30.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e7" Or positionTwo = "e5" Then
            If (Form1.PictureBox40.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b4" Or positionTwo = "d4" Then
            If (Form1.PictureBox48.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaD6Block()
        If positionTwo = "b7" Or positionTwo = "b5" Then
            If (Form1.PictureBox39.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c8" Or positionTwo = "e8" Then
            If (Form1.PictureBox31.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f7" Or positionTwo = "f5" Then
            If (Form1.PictureBox41.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c4" Or positionTwo = "e4" Then
            If (Form1.PictureBox49.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaE6Block()
        If positionTwo = "c7" Or positionTwo = "c5" Then
            If (Form1.PictureBox40.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d8" Or positionTwo = "f8" Then
            If (Form1.PictureBox32.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g7" Or positionTwo = "g5" Then
            If (Form1.PictureBox42.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d4" Or positionTwo = "f4" Then
            If (Form1.PictureBox50.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaF6Block()
        If positionTwo = "d7" Or positionTwo = "d5" Then
            If (Form1.PictureBox41.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e8" Or positionTwo = "g8" Then
            If (Form1.PictureBox33.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h7" Or positionTwo = "h5" Then
            If (Form1.PictureBox43.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e4" Or positionTwo = "g4" Then
            If (Form1.PictureBox51.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaG6Block()
        If positionTwo = "e7" Or positionTwo = "e5" Then
            If (Form1.PictureBox42.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f8" Or positionTwo = "h8" Then
            If (Form1.PictureBox34.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "i7" Or positionTwo = "i5" Then
            If (Form1.PictureBox44.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f4" Or positionTwo = "h4" Then
            If (Form1.PictureBox52.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaH6Block()
        If positionTwo = "f7" Or positionTwo = "f5" Then
            If (Form1.PictureBox43.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g8" Or positionTwo = "i8" Then
            If (Form1.PictureBox35.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g4" Or positionTwo = "i4" Then
            If (Form1.PictureBox53.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaI6Block()
        If positionTwo = "g7" Or positionTwo = "g5" Then
            If (Form1.PictureBox44.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h8" Then
            If (Form1.PictureBox36.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h4" Then
            If (Form1.PictureBox54.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub

    Public Sub checkMaA7Block()
        If positionTwo = "b9" Then
            If (Form1.PictureBox19.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c8" Or positionTwo = "c6" Then
            If (Form1.PictureBox29.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b5" Then
            If (Form1.PictureBox37.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaB7Block()
        If positionTwo = "a9" Or positionTwo = "c9" Then
            If (Form1.PictureBox20.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d8" Or positionTwo = "d6" Then
            If (Form1.PictureBox30.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "a5" Or positionTwo = "c5" Then
            If (Form1.PictureBox38.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaC7Block()
        If positionTwo = "a8" Or positionTwo = "a6" Then
            If (Form1.PictureBox29.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b9" Or positionTwo = "d9" Then
            If (Form1.PictureBox21.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e8" Or positionTwo = "e6" Then
            If (Form1.PictureBox31.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b5" Or positionTwo = "d5" Then
            If (Form1.PictureBox39.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaD7Block()
        If positionTwo = "b8" Or positionTwo = "b6" Then
            If (Form1.PictureBox30.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c9" Or positionTwo = "e9" Then
            If (Form1.PictureBox22.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f8" Or positionTwo = "f6" Then
            If (Form1.PictureBox32.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c5" Or positionTwo = "e5" Then
            If (Form1.PictureBox40.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaE7Block()
        If positionTwo = "c8" Or positionTwo = "c6" Then
            If (Form1.PictureBox31.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d9" Or positionTwo = "f9" Then
            If (Form1.PictureBox23.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g8" Or positionTwo = "g6" Then
            If (Form1.PictureBox33.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d5" Or positionTwo = "f5" Then
            If (Form1.PictureBox41.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaF7Block()
        If positionTwo = "d8" Or positionTwo = "d6" Then
            If (Form1.PictureBox32.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e9" Or positionTwo = "g9" Then
            If (Form1.PictureBox24.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h8" Or positionTwo = "h6" Then
            If (Form1.PictureBox34.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e5" Or positionTwo = "g5" Then
            If (Form1.PictureBox42.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaG7Block()
        If positionTwo = "e8" Or positionTwo = "e6" Then
            If (Form1.PictureBox33.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f9" Or positionTwo = "h9" Then
            If (Form1.PictureBox25.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "i8" Or positionTwo = "i6" Then
            If (Form1.PictureBox35.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f5" Or positionTwo = "h5" Then
            If (Form1.PictureBox43.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaH7Block()
        If positionTwo = "f8" Or positionTwo = "f6" Then
            If (Form1.PictureBox34.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g9" Or positionTwo = "i9" Then
            If (Form1.PictureBox26.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g5" Or positionTwo = "i5" Then
            If (Form1.PictureBox44.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaI7Block()
        If positionTwo = "g8" Or positionTwo = "g6" Then
            If (Form1.PictureBox35.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h9" Then
            If (Form1.PictureBox27.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h5" Then
            If (Form1.PictureBox45.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub

    Public Sub checkMaA8Block()
        If positionTwo = "b10" Then
            If (Form1.PictureBox10.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c9" Or positionTwo = "c7" Then
            If (Form1.PictureBox20.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b6" Then
            If (Form1.PictureBox28.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaB8Block()
        If positionTwo = "a10" Or positionTwo = "c10" Then
            If (Form1.PictureBox11.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d9" Or positionTwo = "d7" Then
            If (Form1.PictureBox21.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "a6" Or positionTwo = "c6" Then
            If (Form1.PictureBox29.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaC8Block()
        If positionTwo = "a9" Or positionTwo = "a7" Then
            If (Form1.PictureBox20.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b10" Or positionTwo = "d10" Then
            If (Form1.PictureBox12.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e9" Or positionTwo = "e7" Then
            If (Form1.PictureBox22.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b6" Or positionTwo = "d6" Then
            If (Form1.PictureBox30.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaD8Block()
        If positionTwo = "b9" Or positionTwo = "b7" Then
            If (Form1.PictureBox21.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c10" Or positionTwo = "e10" Then
            If (Form1.PictureBox13.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f9" Or positionTwo = "f7" Then
            If (Form1.PictureBox23.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c6" Or positionTwo = "e6" Then
            If (Form1.PictureBox31.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaE8Block()
        If positionTwo = "c9" Or positionTwo = "c7" Then
            If (Form1.PictureBox22.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d10" Or positionTwo = "f10" Then
            If (Form1.PictureBox14.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g9" Or positionTwo = "g7" Then
            If (Form1.PictureBox24.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d6" Or positionTwo = "f6" Then
            If (Form1.PictureBox32.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaF8Block()
        If positionTwo = "d9" Or positionTwo = "d7" Then
            If (Form1.PictureBox23.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e10" Or positionTwo = "g10" Then
            If (Form1.PictureBox15.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h9" Or positionTwo = "h7" Then
            If (Form1.PictureBox25.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e6" Or positionTwo = "g6" Then
            If (Form1.PictureBox33.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaG8Block()
        If positionTwo = "e9" Or positionTwo = "e7" Then
            If (Form1.PictureBox24.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f10" Or positionTwo = "h10" Then
            If (Form1.PictureBox16.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "i9" Or positionTwo = "i7" Then
            If (Form1.PictureBox26.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f6" Or positionTwo = "h6" Then
            If (Form1.PictureBox34.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaH8Block()
        If positionTwo = "f9" Or positionTwo = "f7" Then
            If (Form1.PictureBox25.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g10" Or positionTwo = "i10" Then
            If (Form1.PictureBox17.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g6" Or positionTwo = "i6" Then
            If (Form1.PictureBox35.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaI8Block()
        If positionTwo = "g9" Or positionTwo = "g7" Then
            If (Form1.PictureBox26.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h10" Then
            If (Form1.PictureBox18.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h6" Then
            If (Form1.PictureBox36.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub

    Public Sub checkMaA9Block()
        If positionTwo = "c10" Or positionTwo = "c8" Then
            If (Form1.PictureBox11.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b7" Then
            If (Form1.PictureBox19.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaB9Block()
        If positionTwo = "d10" Or positionTwo = "d8" Then
            If (Form1.PictureBox12.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "a7" Or positionTwo = "c7" Then
            If (Form1.PictureBox20.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaC9Block()
        If positionTwo = "a10" Or positionTwo = "a8" Then
            If (Form1.PictureBox11.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e10" Or positionTwo = "e8" Then
            If (Form1.PictureBox13.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b7" Or positionTwo = "d7" Then
            If (Form1.PictureBox21.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaD9Block()
        If positionTwo = "b10" Or positionTwo = "b8" Then
            If (Form1.PictureBox12.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f10" Or positionTwo = "f8" Then
            If (Form1.PictureBox14.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c7" Or positionTwo = "e7" Then
            If (Form1.PictureBox22.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaE9Block()
        If positionTwo = "c10" Or positionTwo = "c8" Then
            If (Form1.PictureBox13.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g10" Or positionTwo = "g8" Then
            If (Form1.PictureBox15.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d7" Or positionTwo = "f7" Then
            If (Form1.PictureBox23.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaF9Block()
        If positionTwo = "d10" Or positionTwo = "d8" Then
            If (Form1.PictureBox14.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h10" Or positionTwo = "h8" Then
            If (Form1.PictureBox16.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e7" Or positionTwo = "g7" Then
            If (Form1.PictureBox24.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaG9Block()
        If positionTwo = "e10" Or positionTwo = "e8" Then
            If (Form1.PictureBox15.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "i10" Or positionTwo = "i8" Then
            If (Form1.PictureBox17.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f7" Or positionTwo = "h7" Then
            If (Form1.PictureBox25.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaH9Block()
        If positionTwo = "f10" Or positionTwo = "f8" Then
            If (Form1.PictureBox16.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g7" Or positionTwo = "i7" Then
            If (Form1.PictureBox26.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaI9Block()
        If positionTwo = "g10" Or positionTwo = "g8" Then
            If (Form1.PictureBox17.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h7" Then
            If (Form1.PictureBox27.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub

    Public Sub checkMaA10Block()
        If positionTwo = "c9" Then
            If (Form1.PictureBox2.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b8" Then
            If (Form1.PictureBox10.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaB10Block()
        If positionTwo = "d9" Then
            If (Form1.PictureBox3.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "a8" Or positionTwo = "c8" Then
            If (Form1.PictureBox11.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaC10Block()
        If positionTwo = "a9" Then
            If (Form1.PictureBox2.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e9" Then
            If (Form1.PictureBox4.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "b8" Or positionTwo = "d8" Then
            If (Form1.PictureBox12.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaD10Block()
        If positionTwo = "b9" Then
            If (Form1.PictureBox3.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f9" Then
            If (Form1.PictureBox5.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "c8" Or positionTwo = "e8" Then
            If (Form1.PictureBox13.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaE10Block()
        If positionTwo = "c9" Then
            If (Form1.PictureBox4.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g9" Then
            If (Form1.PictureBox6.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "d8" Or positionTwo = "f8" Then
            If (Form1.PictureBox14.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaF10Block()
        If positionTwo = "d9" Then
            If (Form1.PictureBox5.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h9" Then
            If (Form1.PictureBox7.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "e8" Or positionTwo = "g8" Then
            If (Form1.PictureBox15.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaG10Block()
        If positionTwo = "e9" Then
            If (Form1.PictureBox6.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "i9" Then
            If (Form1.PictureBox8.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "f8" Or positionTwo = "h8" Then
            If (Form1.PictureBox16.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaH10Block()
        If positionTwo = "f9" Then
            If (Form1.PictureBox7.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "g8" Or positionTwo = "i8" Then
            If (Form1.PictureBox17.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
    Public Sub checkMaI10Block()
        If positionTwo = "g9" Then
            If (Form1.PictureBox8.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        ElseIf positionTwo = "h8" Then
            If (Form1.PictureBox18.Image IsNot Form1.nonePic.Image) Then
                blockBool = True
            Else
                blockBool = False
            End If
        End If
    End Sub
End Module
