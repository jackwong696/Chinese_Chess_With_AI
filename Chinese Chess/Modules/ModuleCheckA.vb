' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 01/10/2010 to 28/10/2010
' Descripitons : Chinese Chess V1

Module ModuleCheckA
    Public positionOne, positionTwo, positionOneTwo As String

    Public Sub CheckA1A()
        If ((positionOne = "a1") And (positionTwo = "a1")) Then
            MessageBox.Show("a1-a1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ((positionOne = "a1") And (positionTwo = "a2")) Then
            Form1.PictureBox73.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "a3")) Then
            Form1.PictureBox64.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "a4")) Then
            Form1.PictureBox55.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "a5")) Then
            Form1.PictureBox46.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "a6")) Then
            Form1.PictureBox37.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "a7")) Then
            Form1.PictureBox28.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "a8")) Then
            Form1.PictureBox19.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "a9")) Then
            Form1.PictureBox10.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "a10")) Then
            Form1.PictureBox1.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image
        End If
    End Sub
    Public Sub CheckA1B()

        If ((positionOne = "a1") And (positionTwo = "b1")) Then
            Form1.PictureBox83.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "b2")) Then
            Form1.PictureBox74.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "b3")) Then
            Form1.PictureBox65.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "b4")) Then
            Form1.PictureBox56.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "b5")) Then
            Form1.PictureBox47.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "b6")) Then
            Form1.PictureBox38.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "b7")) Then
            Form1.PictureBox29.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "b8")) Then
            Form1.PictureBox20.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "b9")) Then
            Form1.PictureBox11.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "b10")) Then
            Form1.PictureBox2.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA1C()

        If ((positionOne = "a1") And (positionTwo = "c1")) Then
            Form1.PictureBox84.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "c2")) Then
            Form1.PictureBox75.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "c3")) Then
            Form1.PictureBox66.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "c4")) Then
            Form1.PictureBox57.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "c5")) Then
            Form1.PictureBox48.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "c6")) Then
            Form1.PictureBox39.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "c7")) Then
            Form1.PictureBox30.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "c8")) Then
            Form1.PictureBox21.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "c9")) Then
            Form1.PictureBox12.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "c10")) Then
            Form1.PictureBox3.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA1D()

        If ((positionOne = "a1") And (positionTwo = "d1")) Then
            Form1.PictureBox85.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "d2")) Then
            Form1.PictureBox76.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "d3")) Then
            Form1.PictureBox67.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "d4")) Then
            Form1.PictureBox58.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

            Form1.PictureBox58.Visible = True

        ElseIf ((positionOne = "a1") And (positionTwo = "d5")) Then
            Form1.PictureBox49.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "d6")) Then
            Form1.PictureBox40.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "d7")) Then
            Form1.PictureBox31.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "d8")) Then
            Form1.PictureBox22.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "d9")) Then
            Form1.PictureBox13.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "d10")) Then
            Form1.PictureBox4.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA1E()

        If ((positionOne = "a1") And (positionTwo = "e1")) Then
            Form1.PictureBox86.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "e2")) Then
            Form1.PictureBox77.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "e3")) Then
            Form1.PictureBox68.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "e4")) Then
            Form1.PictureBox59.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "e5")) Then
            Form1.PictureBox50.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "e6")) Then
            Form1.PictureBox41.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "e7")) Then
            Form1.PictureBox32.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "e8")) Then
            Form1.PictureBox23.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "e9")) Then
            Form1.PictureBox14.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "e10")) Then
            Form1.PictureBox5.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA1F()

        If ((positionOne = "a1") And (positionTwo = "f1")) Then
            Form1.PictureBox87.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "f2")) Then
            Form1.PictureBox78.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "f3")) Then
            Form1.PictureBox69.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "f4")) Then
            Form1.PictureBox60.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "f5")) Then
            Form1.PictureBox51.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "f6")) Then
            Form1.PictureBox42.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "f7")) Then
            Form1.PictureBox33.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "f8")) Then
            Form1.PictureBox24.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "f9")) Then
            Form1.PictureBox15.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "f10")) Then
            Form1.PictureBox6.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA1G()

        If ((positionOne = "a1") And (positionTwo = "g1")) Then
            Form1.PictureBox88.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "g2")) Then
            Form1.PictureBox79.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "g3")) Then
            Form1.PictureBox70.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "g4")) Then
            Form1.PictureBox61.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "g5")) Then
            Form1.PictureBox52.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "g6")) Then
            Form1.PictureBox43.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "g7")) Then
            Form1.PictureBox34.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "g8")) Then
            Form1.PictureBox25.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "g9")) Then
            Form1.PictureBox16.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "g10")) Then
            Form1.PictureBox7.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA1H()

        If ((positionOne = "a1") And (positionTwo = "h1")) Then
            Form1.PictureBox89.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "h2")) Then
            Form1.PictureBox80.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "h3")) Then
            Form1.PictureBox71.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "h4")) Then
            Form1.PictureBox62.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "h5")) Then
            Form1.PictureBox53.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "h6")) Then
            Form1.PictureBox44.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "h7")) Then
            Form1.PictureBox35.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "h8")) Then
            Form1.PictureBox26.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "h9")) Then
            Form1.PictureBox17.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "h10")) Then
            Form1.PictureBox8.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA1I()

        If ((positionOne = "a1") And (positionTwo = "i1")) Then
            Form1.PictureBox90.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "i2")) Then
            Form1.PictureBox81.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "i3")) Then
            Form1.PictureBox72.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "i4")) Then
            Form1.PictureBox63.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "i5")) Then
            Form1.PictureBox54.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "i6")) Then
            Form1.PictureBox45.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "i7")) Then
            Form1.PictureBox36.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "i8")) Then
            Form1.PictureBox27.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "i9")) Then
            Form1.PictureBox18.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a1") And (positionTwo = "i10")) Then
            Form1.PictureBox9.Image = Form1.PictureBox82.Image
            Form1.PictureBox82.Image = Form1.nonePic.Image

        End If
    End Sub

    Public Sub CheckA2A()

        If ((positionOne = "a2") And (positionTwo = "a1")) Then
            Form1.PictureBox82.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "a2")) Then
            MessageBox.Show("a2-a2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ((positionOne = "a2") And (positionTwo = "a3")) Then
            Form1.PictureBox64.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "a4")) Then
            Form1.PictureBox55.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "a5")) Then
            Form1.PictureBox46.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "a6")) Then
            Form1.PictureBox37.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "a7")) Then
            Form1.PictureBox28.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "a8")) Then
            Form1.PictureBox19.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "a9")) Then
            Form1.PictureBox10.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "a10")) Then
            Form1.PictureBox1.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA2B()

        If ((positionOne = "a2") And (positionTwo = "b1")) Then
            Form1.PictureBox83.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "b2")) Then
            Form1.PictureBox74.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "b3")) Then
            Form1.PictureBox65.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "b4")) Then
            Form1.PictureBox56.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "b5")) Then
            Form1.PictureBox47.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "b6")) Then
            Form1.PictureBox38.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "b7")) Then
            Form1.PictureBox29.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "b8")) Then
            Form1.PictureBox20.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "b9")) Then
            Form1.PictureBox11.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "b10")) Then
            Form1.PictureBox2.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA2C()

        If ((positionOne = "a2") And (positionTwo = "c1")) Then
            Form1.PictureBox84.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "c2")) Then
            Form1.PictureBox75.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "c3")) Then
            Form1.PictureBox66.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "c4")) Then
            Form1.PictureBox57.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "c5")) Then
            Form1.PictureBox48.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "c6")) Then
            Form1.PictureBox39.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "c7")) Then
            Form1.PictureBox30.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "c8")) Then
            Form1.PictureBox21.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "c9")) Then
            Form1.PictureBox12.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "c10")) Then
            Form1.PictureBox3.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA2D()

        If ((positionOne = "a2") And (positionTwo = "d1")) Then
            Form1.PictureBox85.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "d2")) Then
            Form1.PictureBox76.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "d3")) Then
            Form1.PictureBox67.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "d4")) Then
            Form1.PictureBox58.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "d5")) Then
            Form1.PictureBox49.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "d6")) Then
            Form1.PictureBox40.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "d7")) Then
            Form1.PictureBox31.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "d8")) Then
            Form1.PictureBox22.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "d9")) Then
            Form1.PictureBox13.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "d10")) Then
            Form1.PictureBox4.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA2E()

        If ((positionOne = "a2") And (positionTwo = "e1")) Then
            Form1.PictureBox86.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "e2")) Then
            Form1.PictureBox77.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "e3")) Then
            Form1.PictureBox68.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "e4")) Then
            Form1.PictureBox59.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "e5")) Then
            Form1.PictureBox50.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "e6")) Then
            Form1.PictureBox41.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "e7")) Then
            Form1.PictureBox32.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "e8")) Then
            Form1.PictureBox23.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "e9")) Then
            Form1.PictureBox14.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "e10")) Then
            Form1.PictureBox5.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA2F()

        If ((positionOne = "a2") And (positionTwo = "f1")) Then
            Form1.PictureBox87.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "f2")) Then
            Form1.PictureBox78.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "f3")) Then
            Form1.PictureBox69.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "f4")) Then
            Form1.PictureBox60.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "f5")) Then
            Form1.PictureBox51.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "f6")) Then
            Form1.PictureBox42.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "f7")) Then
            Form1.PictureBox33.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "f8")) Then
            Form1.PictureBox24.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "f9")) Then
            Form1.PictureBox15.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "f10")) Then
            Form1.PictureBox6.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA2G()

        If ((positionOne = "a2") And (positionTwo = "g1")) Then
            Form1.PictureBox88.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "g2")) Then
            Form1.PictureBox79.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "g3")) Then
            Form1.PictureBox70.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "g4")) Then
            Form1.PictureBox61.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "g5")) Then
            Form1.PictureBox52.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "g6")) Then
            Form1.PictureBox43.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "g7")) Then
            Form1.PictureBox34.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "g8")) Then
            Form1.PictureBox25.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "g9")) Then
            Form1.PictureBox16.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "g10")) Then
            Form1.PictureBox7.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA2H()

        If ((positionOne = "a2") And (positionTwo = "h1")) Then
            Form1.PictureBox89.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "h2")) Then
            Form1.PictureBox80.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "h3")) Then
            Form1.PictureBox71.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "h4")) Then
            Form1.PictureBox62.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "h5")) Then
            Form1.PictureBox53.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "h6")) Then
            Form1.PictureBox44.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "h7")) Then
            Form1.PictureBox35.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "h8")) Then
            Form1.PictureBox26.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "h9")) Then
            Form1.PictureBox17.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "h10")) Then
            Form1.PictureBox8.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA2I()

        If ((positionOne = "a2") And (positionTwo = "i1")) Then
            Form1.PictureBox90.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "i2")) Then
            Form1.PictureBox81.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "i3")) Then
            Form1.PictureBox72.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "i4")) Then
            Form1.PictureBox63.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "i5")) Then
            Form1.PictureBox54.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "i6")) Then
            Form1.PictureBox45.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "i7")) Then
            Form1.PictureBox36.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "i8")) Then
            Form1.PictureBox27.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "i9")) Then
            Form1.PictureBox18.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a2") And (positionTwo = "i10")) Then
            Form1.PictureBox9.Image = Form1.PictureBox73.Image
            Form1.PictureBox73.Image = Form1.nonePic.Image

        End If
    End Sub

    Public Sub CheckA3A()

        If ((positionOne = "a3") And (positionTwo = "a1")) Then
            Form1.PictureBox82.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "a2")) Then
            Form1.PictureBox73.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "a3")) Then
            MessageBox.Show("a3-a3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ((positionOne = "a3") And (positionTwo = "a4")) Then
            Form1.PictureBox55.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "a5")) Then
            Form1.PictureBox46.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "a6")) Then
            Form1.PictureBox37.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "a7")) Then
            Form1.PictureBox28.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "a8")) Then
            Form1.PictureBox19.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "a9")) Then
            Form1.PictureBox10.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "a10")) Then
            Form1.PictureBox1.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA3B()

        If ((positionOne = "a3") And (positionTwo = "b1")) Then
            Form1.PictureBox83.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "b2")) Then
            Form1.PictureBox74.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "b3")) Then
            Form1.PictureBox65.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "b4")) Then
            Form1.PictureBox56.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "b5")) Then
            Form1.PictureBox47.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "b6")) Then
            Form1.PictureBox38.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "b7")) Then
            Form1.PictureBox29.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "b8")) Then
            Form1.PictureBox20.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "b9")) Then
            Form1.PictureBox11.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "b10")) Then
            Form1.PictureBox2.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image
        End If
    End Sub
    Public Sub CheckA3C()

        If ((positionOne = "a3") And (positionTwo = "c1")) Then
            Form1.PictureBox84.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "c2")) Then
            Form1.PictureBox75.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "c3")) Then
            Form1.PictureBox66.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "c4")) Then
            Form1.PictureBox57.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "c5")) Then
            Form1.PictureBox48.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "c6")) Then
            Form1.PictureBox39.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "c7")) Then
            Form1.PictureBox30.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "c8")) Then
            Form1.PictureBox21.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "c9")) Then
            Form1.PictureBox12.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "c10")) Then
            Form1.PictureBox3.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA3D()

        If ((positionOne = "a3") And (positionTwo = "d1")) Then
            Form1.PictureBox85.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "d2")) Then
            Form1.PictureBox76.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "d3")) Then
            Form1.PictureBox67.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "d4")) Then
            Form1.PictureBox58.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "d5")) Then
            Form1.PictureBox49.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "d6")) Then
            Form1.PictureBox40.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "d7")) Then
            Form1.PictureBox31.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "d8")) Then
            Form1.PictureBox22.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "d9")) Then
            Form1.PictureBox13.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "d10")) Then
            Form1.PictureBox4.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA3E()

        If ((positionOne = "a3") And (positionTwo = "e1")) Then
            Form1.PictureBox86.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "e2")) Then
            Form1.PictureBox77.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "e3")) Then
            Form1.PictureBox68.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "e4")) Then
            Form1.PictureBox59.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "e5")) Then
            Form1.PictureBox50.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "e6")) Then
            Form1.PictureBox41.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "e7")) Then
            Form1.PictureBox32.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "e8")) Then
            Form1.PictureBox23.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "e9")) Then
            Form1.PictureBox14.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "e10")) Then
            Form1.PictureBox5.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image
        End If
    End Sub
    Public Sub CheckA3F()

        If ((positionOne = "a3") And (positionTwo = "f1")) Then
            Form1.PictureBox87.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "f2")) Then
            Form1.PictureBox78.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "f3")) Then
            Form1.PictureBox69.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "f4")) Then
            Form1.PictureBox60.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "f5")) Then
            Form1.PictureBox51.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "f6")) Then
            Form1.PictureBox42.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "f7")) Then
            Form1.PictureBox33.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "f8")) Then
            Form1.PictureBox24.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "f9")) Then
            Form1.PictureBox15.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "f10")) Then
            Form1.PictureBox6.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA3G()

        If ((positionOne = "a3") And (positionTwo = "g1")) Then
            Form1.PictureBox88.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "g2")) Then
            Form1.PictureBox79.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "g3")) Then
            Form1.PictureBox70.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "g4")) Then
            Form1.PictureBox61.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "g5")) Then
            Form1.PictureBox52.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "g6")) Then
            Form1.PictureBox43.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "g7")) Then
            Form1.PictureBox34.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "g8")) Then
            Form1.PictureBox25.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "g9")) Then
            Form1.PictureBox16.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "g10")) Then
            Form1.PictureBox7.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA3H()

        If ((positionOne = "a3") And (positionTwo = "h1")) Then
            Form1.PictureBox89.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "h2")) Then
            Form1.PictureBox80.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "h3")) Then
            Form1.PictureBox71.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "h4")) Then
            Form1.PictureBox62.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "h5")) Then
            Form1.PictureBox53.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "h6")) Then
            Form1.PictureBox44.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "h7")) Then
            Form1.PictureBox35.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "h8")) Then
            Form1.PictureBox26.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "h9")) Then
            Form1.PictureBox17.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "h10")) Then
            Form1.PictureBox8.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA3I()

        If ((positionOne = "a3") And (positionTwo = "i1")) Then
            Form1.PictureBox90.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "i2")) Then
            Form1.PictureBox81.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "i3")) Then
            Form1.PictureBox72.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "i4")) Then
            Form1.PictureBox63.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "i5")) Then
            Form1.PictureBox54.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "i6")) Then
            Form1.PictureBox45.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "i7")) Then
            Form1.PictureBox36.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "i8")) Then
            Form1.PictureBox27.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "i9")) Then
            Form1.PictureBox18.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a3") And (positionTwo = "i10")) Then
            Form1.PictureBox9.Image = Form1.PictureBox64.Image
            Form1.PictureBox64.Image = Form1.nonePic.Image

        End If
    End Sub

    Public Sub CheckA4A()

        If ((positionOne = "a4") And (positionTwo = "a1")) Then
            Form1.PictureBox82.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "a2")) Then
            Form1.PictureBox73.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "a3")) Then
            Form1.PictureBox64.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "a4")) Then
            MessageBox.Show("a4-a4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ((positionOne = "a4") And (positionTwo = "a5")) Then
            Form1.PictureBox46.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "a6")) Then
            Form1.PictureBox37.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "a7")) Then
            Form1.PictureBox28.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "a8")) Then
            Form1.PictureBox19.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "a9")) Then
            Form1.PictureBox10.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "a10")) Then
            Form1.PictureBox1.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA4B()

        If ((positionOne = "a4") And (positionTwo = "b1")) Then
            Form1.PictureBox83.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "b2")) Then
            Form1.PictureBox74.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "b3")) Then
            Form1.PictureBox65.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "b4")) Then
            Form1.PictureBox56.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "b5")) Then
            Form1.PictureBox47.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "b6")) Then
            Form1.PictureBox38.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "b7")) Then
            Form1.PictureBox29.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "b8")) Then
            Form1.PictureBox20.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "b9")) Then
            Form1.PictureBox11.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "b10")) Then
            Form1.PictureBox2.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA4C()

        If ((positionOne = "a4") And (positionTwo = "c1")) Then
            Form1.PictureBox84.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "c2")) Then
            Form1.PictureBox75.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "c3")) Then
            Form1.PictureBox66.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "c4")) Then
            Form1.PictureBox57.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "c5")) Then
            Form1.PictureBox48.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "c6")) Then
            Form1.PictureBox39.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "c7")) Then
            Form1.PictureBox30.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "c8")) Then
            Form1.PictureBox21.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "c9")) Then
            Form1.PictureBox12.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "c10")) Then
            Form1.PictureBox3.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA4D()

        If ((positionOne = "a4") And (positionTwo = "d1")) Then
            Form1.PictureBox85.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "d2")) Then
            Form1.PictureBox76.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "d3")) Then
            Form1.PictureBox67.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "d4")) Then
            Form1.PictureBox58.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "d5")) Then
            Form1.PictureBox49.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "d6")) Then
            Form1.PictureBox40.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "d7")) Then
            Form1.PictureBox31.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "d8")) Then
            Form1.PictureBox22.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "d9")) Then
            Form1.PictureBox13.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "d10")) Then
            Form1.PictureBox4.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA4E()

        If ((positionOne = "a4") And (positionTwo = "e1")) Then
            Form1.PictureBox86.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "e2")) Then
            Form1.PictureBox77.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "e3")) Then
            Form1.PictureBox68.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "e4")) Then
            Form1.PictureBox59.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "e5")) Then
            Form1.PictureBox50.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "e6")) Then
            Form1.PictureBox41.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "e7")) Then
            Form1.PictureBox32.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "e8")) Then
            Form1.PictureBox23.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "e9")) Then
            Form1.PictureBox14.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "e10")) Then
            Form1.PictureBox5.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA4F()

        If ((positionOne = "a4") And (positionTwo = "f1")) Then
            Form1.PictureBox87.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "f2")) Then
            Form1.PictureBox78.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "f3")) Then
            Form1.PictureBox69.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "f4")) Then
            Form1.PictureBox60.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "f5")) Then
            Form1.PictureBox51.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "f6")) Then
            Form1.PictureBox42.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "f7")) Then
            Form1.PictureBox33.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "f8")) Then
            Form1.PictureBox24.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "f9")) Then
            Form1.PictureBox15.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "f10")) Then
            Form1.PictureBox6.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA4G()

        If ((positionOne = "a4") And (positionTwo = "g1")) Then
            Form1.PictureBox88.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "g2")) Then
            Form1.PictureBox79.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "g3")) Then
            Form1.PictureBox70.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "g4")) Then
            Form1.PictureBox61.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "g5")) Then
            Form1.PictureBox52.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "g6")) Then
            Form1.PictureBox43.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "g7")) Then
            Form1.PictureBox34.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "g8")) Then
            Form1.PictureBox25.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "g9")) Then
            Form1.PictureBox16.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "g10")) Then
            Form1.PictureBox7.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA4H()

        If ((positionOne = "a4") And (positionTwo = "h1")) Then
            Form1.PictureBox89.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "h2")) Then
            Form1.PictureBox80.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "h3")) Then
            Form1.PictureBox71.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "h4")) Then
            Form1.PictureBox62.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "h5")) Then
            Form1.PictureBox53.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "h6")) Then
            Form1.PictureBox44.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "h7")) Then
            Form1.PictureBox35.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "h8")) Then
            Form1.PictureBox26.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "h9")) Then
            Form1.PictureBox17.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "h10")) Then
            Form1.PictureBox8.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA4I()

        If ((positionOne = "a4") And (positionTwo = "i1")) Then
            Form1.PictureBox90.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "i2")) Then
            Form1.PictureBox81.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "i3")) Then
            Form1.PictureBox72.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "i4")) Then
            Form1.PictureBox63.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "i5")) Then
            Form1.PictureBox54.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "i6")) Then
            Form1.PictureBox45.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "i7")) Then
            Form1.PictureBox36.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "i8")) Then
            Form1.PictureBox27.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "i9")) Then
            Form1.PictureBox18.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a4") And (positionTwo = "i10")) Then
            Form1.PictureBox9.Image = Form1.PictureBox55.Image
            Form1.PictureBox55.Image = Form1.nonePic.Image

        End If
    End Sub

    Public Sub CheckA5A()

        If ((positionOne = "a5") And (positionTwo = "a1")) Then
            Form1.PictureBox82.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "a2")) Then
            Form1.PictureBox73.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "a3")) Then
            Form1.PictureBox64.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "a4")) Then
            Form1.PictureBox55.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "a5")) Then
            MessageBox.Show("a5-a5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ((positionOne = "a5") And (positionTwo = "a6")) Then
            Form1.PictureBox37.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "a7")) Then
            Form1.PictureBox28.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "a8")) Then
            Form1.PictureBox19.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "a9")) Then
            Form1.PictureBox10.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "a10")) Then
            Form1.PictureBox1.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA5B()

        If ((positionOne = "a5") And (positionTwo = "b1")) Then
            Form1.PictureBox83.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "b2")) Then
            Form1.PictureBox74.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "b3")) Then
            Form1.PictureBox65.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "b4")) Then
            Form1.PictureBox56.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "b5")) Then
            Form1.PictureBox47.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "b6")) Then
            Form1.PictureBox38.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "b7")) Then
            Form1.PictureBox29.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "b8")) Then
            Form1.PictureBox20.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "b9")) Then
            Form1.PictureBox11.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "b10")) Then
            Form1.PictureBox2.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA5C()

        If ((positionOne = "a5") And (positionTwo = "c1")) Then
            Form1.PictureBox84.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "c2")) Then
            Form1.PictureBox75.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "c3")) Then
            Form1.PictureBox66.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "c4")) Then
            Form1.PictureBox57.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "c5")) Then
            Form1.PictureBox48.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "c6")) Then
            Form1.PictureBox39.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "c7")) Then
            Form1.PictureBox30.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "c8")) Then
            Form1.PictureBox21.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "c9")) Then
            Form1.PictureBox12.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "c10")) Then
            Form1.PictureBox3.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA5D()

        If ((positionOne = "a5") And (positionTwo = "d1")) Then
            Form1.PictureBox85.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "d2")) Then
            Form1.PictureBox76.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "d3")) Then
            Form1.PictureBox67.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "d4")) Then
            Form1.PictureBox58.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "d5")) Then
            Form1.PictureBox49.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "d6")) Then
            Form1.PictureBox40.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "d7")) Then
            Form1.PictureBox31.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "d8")) Then
            Form1.PictureBox22.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "d9")) Then
            Form1.PictureBox13.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "d10")) Then
            Form1.PictureBox4.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA5E()

        If ((positionOne = "a5") And (positionTwo = "e1")) Then
            Form1.PictureBox86.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "e2")) Then
            Form1.PictureBox77.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "e3")) Then
            Form1.PictureBox68.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "e4")) Then
            Form1.PictureBox59.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "e5")) Then
            Form1.PictureBox50.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "e6")) Then
            Form1.PictureBox41.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "e7")) Then
            Form1.PictureBox32.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "e8")) Then
            Form1.PictureBox23.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "e9")) Then
            Form1.PictureBox14.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "e10")) Then
            Form1.PictureBox5.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA5F()

        If ((positionOne = "a5") And (positionTwo = "f1")) Then
            Form1.PictureBox87.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "f2")) Then
            Form1.PictureBox78.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "f3")) Then
            Form1.PictureBox69.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "f4")) Then
            Form1.PictureBox60.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "f5")) Then
            Form1.PictureBox51.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "f6")) Then
            Form1.PictureBox42.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "f7")) Then
            Form1.PictureBox33.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "f8")) Then
            Form1.PictureBox24.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "f9")) Then
            Form1.PictureBox15.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "f10")) Then
            Form1.PictureBox6.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA5G()

        If ((positionOne = "a5") And (positionTwo = "g1")) Then
            Form1.PictureBox88.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "g2")) Then
            Form1.PictureBox79.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "g3")) Then
            Form1.PictureBox70.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "g4")) Then
            Form1.PictureBox61.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "g5")) Then
            Form1.PictureBox52.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "g6")) Then
            Form1.PictureBox43.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image
        ElseIf ((positionOne = "a5") And (positionTwo = "g7")) Then
            Form1.PictureBox34.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "g8")) Then
            Form1.PictureBox25.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "g9")) Then
            Form1.PictureBox16.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "g10")) Then
            Form1.PictureBox7.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA5H()

        If ((positionOne = "a5") And (positionTwo = "h1")) Then
            Form1.PictureBox89.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "h2")) Then
            Form1.PictureBox80.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "h3")) Then
            Form1.PictureBox71.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "h4")) Then
            Form1.PictureBox62.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "h5")) Then
            Form1.PictureBox53.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "h6")) Then
            Form1.PictureBox44.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "h7")) Then
            Form1.PictureBox35.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "h8")) Then
            Form1.PictureBox26.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "h9")) Then
            Form1.PictureBox17.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "h10")) Then
            Form1.PictureBox8.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA5I()

        If ((positionOne = "a5") And (positionTwo = "i1")) Then
            Form1.PictureBox90.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "i2")) Then
            Form1.PictureBox81.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "i3")) Then
            Form1.PictureBox72.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "i4")) Then
            Form1.PictureBox63.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "i5")) Then
            Form1.PictureBox54.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "i6")) Then
            Form1.PictureBox45.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "i7")) Then
            Form1.PictureBox36.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "i8")) Then
            Form1.PictureBox27.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "i9")) Then
            Form1.PictureBox18.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a5") And (positionTwo = "i10")) Then
            Form1.PictureBox9.Image = Form1.PictureBox46.Image
            Form1.PictureBox46.Image = Form1.nonePic.Image

        End If
    End Sub

    Public Sub CheckA6A()

        If ((positionOne = "a6") And (positionTwo = "a1")) Then
            Form1.PictureBox82.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "a2")) Then
            Form1.PictureBox73.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "a3")) Then
            Form1.PictureBox64.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "a4")) Then
            Form1.PictureBox55.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "a5")) Then
            Form1.PictureBox46.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "a6")) Then
            MessageBox.Show("a6-a6", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ((positionOne = "a6") And (positionTwo = "a7")) Then
            Form1.PictureBox28.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "a8")) Then
            Form1.PictureBox19.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "a9")) Then
            Form1.PictureBox10.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "a10")) Then
            Form1.PictureBox1.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA6B()

        If ((positionOne = "a6") And (positionTwo = "b1")) Then
            Form1.PictureBox83.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "b2")) Then
            Form1.PictureBox74.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "b3")) Then
            Form1.PictureBox65.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "b4")) Then
            Form1.PictureBox56.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "b5")) Then
            Form1.PictureBox47.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "b6")) Then
            Form1.PictureBox38.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "b7")) Then
            Form1.PictureBox29.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "b8")) Then
            Form1.PictureBox20.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "b9")) Then
            Form1.PictureBox11.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "b10")) Then
            Form1.PictureBox2.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA6C()

        If ((positionOne = "a6") And (positionTwo = "c1")) Then
            Form1.PictureBox84.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "c2")) Then
            Form1.PictureBox75.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "c3")) Then
            Form1.PictureBox66.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "c4")) Then
            Form1.PictureBox57.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "c5")) Then
            Form1.PictureBox48.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "c6")) Then
            Form1.PictureBox39.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "c7")) Then
            Form1.PictureBox30.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "c8")) Then
            Form1.PictureBox21.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "c9")) Then
            Form1.PictureBox12.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "c10")) Then
            Form1.PictureBox3.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA6D()

        If ((positionOne = "a6") And (positionTwo = "d1")) Then
            Form1.PictureBox85.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "d2")) Then
            Form1.PictureBox76.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "d3")) Then
            Form1.PictureBox67.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "d4")) Then
            Form1.PictureBox58.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "d5")) Then
            Form1.PictureBox49.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "d6")) Then
            Form1.PictureBox40.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "d7")) Then
            Form1.PictureBox31.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "d8")) Then
            Form1.PictureBox22.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "d9")) Then
            Form1.PictureBox13.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "d10")) Then
            Form1.PictureBox4.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA6E()

        If ((positionOne = "a6") And (positionTwo = "e1")) Then
            Form1.PictureBox86.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "e2")) Then
            Form1.PictureBox77.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "e3")) Then
            Form1.PictureBox68.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "e4")) Then
            Form1.PictureBox59.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "e5")) Then
            Form1.PictureBox50.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "e6")) Then
            Form1.PictureBox41.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "e7")) Then
            Form1.PictureBox32.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "e8")) Then
            Form1.PictureBox23.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "e9")) Then
            Form1.PictureBox14.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "e10")) Then
            Form1.PictureBox5.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA6F()

        If ((positionOne = "a6") And (positionTwo = "f1")) Then
            Form1.PictureBox87.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "f2")) Then
            Form1.PictureBox78.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "f3")) Then
            Form1.PictureBox69.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "f4")) Then
            Form1.PictureBox60.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "f5")) Then
            Form1.PictureBox51.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "f6")) Then
            Form1.PictureBox42.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "f7")) Then
            Form1.PictureBox33.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "f8")) Then
            Form1.PictureBox24.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "f9")) Then
            Form1.PictureBox15.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "f10")) Then
            Form1.PictureBox6.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA6G()

        If ((positionOne = "a6") And (positionTwo = "g1")) Then
            Form1.PictureBox88.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "g2")) Then
            Form1.PictureBox79.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "g3")) Then
            Form1.PictureBox70.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "g4")) Then
            Form1.PictureBox61.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "g5")) Then
            Form1.PictureBox52.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "g6")) Then
            Form1.PictureBox43.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "g7")) Then
            Form1.PictureBox34.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "g8")) Then
            Form1.PictureBox25.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "g9")) Then
            Form1.PictureBox16.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "g10")) Then
            Form1.PictureBox7.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA6H()

        If ((positionOne = "a6") And (positionTwo = "h1")) Then
            Form1.PictureBox89.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "h2")) Then
            Form1.PictureBox80.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "h3")) Then
            Form1.PictureBox71.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "h4")) Then
            Form1.PictureBox62.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "h5")) Then
            Form1.PictureBox53.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "h6")) Then
            Form1.PictureBox44.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "h7")) Then
            Form1.PictureBox35.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "h8")) Then
            Form1.PictureBox26.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "h9")) Then
            Form1.PictureBox17.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "h10")) Then
            Form1.PictureBox8.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA6I()

        If ((positionOne = "a6") And (positionTwo = "i1")) Then
            Form1.PictureBox90.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "i2")) Then
            Form1.PictureBox81.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "i3")) Then
            Form1.PictureBox72.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "i4")) Then
            Form1.PictureBox63.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "i5")) Then
            Form1.PictureBox54.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "i6")) Then
            Form1.PictureBox45.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "i7")) Then
            Form1.PictureBox36.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "i8")) Then
            Form1.PictureBox27.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "i9")) Then
            Form1.PictureBox18.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a6") And (positionTwo = "i10")) Then
            Form1.PictureBox9.Image = Form1.PictureBox37.Image
            Form1.PictureBox37.Image = Form1.nonePic.Image

        End If
    End Sub

    Public Sub CheckA7A()

        If ((positionOne = "a7") And (positionTwo = "a1")) Then
            Form1.PictureBox82.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "a2")) Then
            Form1.PictureBox73.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "a3")) Then
            Form1.PictureBox64.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "a4")) Then
            Form1.PictureBox55.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "a5")) Then
            Form1.PictureBox46.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "a6")) Then
            Form1.PictureBox37.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "a7")) Then
            MessageBox.Show("a7-a7", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ((positionOne = "a7") And (positionTwo = "a8")) Then
            Form1.PictureBox19.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "a9")) Then
            Form1.PictureBox10.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "a10")) Then
            Form1.PictureBox1.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA7B()

        If ((positionOne = "a7") And (positionTwo = "b1")) Then
            Form1.PictureBox83.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "b2")) Then
            Form1.PictureBox74.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "b3")) Then
            Form1.PictureBox65.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "b4")) Then
            Form1.PictureBox56.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "b5")) Then
            Form1.PictureBox47.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "b6")) Then
            Form1.PictureBox38.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "b7")) Then
            Form1.PictureBox29.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "b8")) Then
            Form1.PictureBox20.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "b9")) Then
            Form1.PictureBox11.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "b10")) Then
            Form1.PictureBox2.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA7C()

        If ((positionOne = "a7") And (positionTwo = "c1")) Then
            Form1.PictureBox84.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "c2")) Then
            Form1.PictureBox75.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "c3")) Then
            Form1.PictureBox66.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "c4")) Then
            Form1.PictureBox57.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "c5")) Then
            Form1.PictureBox48.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "c6")) Then
            Form1.PictureBox39.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "c7")) Then
            Form1.PictureBox30.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "c8")) Then
            Form1.PictureBox21.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "c9")) Then
            Form1.PictureBox12.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image
        ElseIf ((positionOne = "a7") And (positionTwo = "c10")) Then
            Form1.PictureBox3.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA7D()

        If ((positionOne = "a7") And (positionTwo = "d1")) Then
            Form1.PictureBox85.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "d2")) Then
            Form1.PictureBox76.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "d3")) Then
            Form1.PictureBox67.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "d4")) Then
            Form1.PictureBox58.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "d5")) Then
            Form1.PictureBox49.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "d6")) Then
            Form1.PictureBox40.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "d7")) Then
            Form1.PictureBox31.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "d8")) Then
            Form1.PictureBox22.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "d9")) Then
            Form1.PictureBox13.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "d10")) Then
            Form1.PictureBox4.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA7E()

        If ((positionOne = "a7") And (positionTwo = "e1")) Then
            Form1.PictureBox86.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "e2")) Then
            Form1.PictureBox77.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "e3")) Then
            Form1.PictureBox68.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "e4")) Then
            Form1.PictureBox59.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "e5")) Then
            Form1.PictureBox50.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "e6")) Then
            Form1.PictureBox41.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "e7")) Then
            Form1.PictureBox32.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "e8")) Then
            Form1.PictureBox23.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "e9")) Then
            Form1.PictureBox14.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "e10")) Then
            Form1.PictureBox5.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA7F()

        If ((positionOne = "a7") And (positionTwo = "f1")) Then
            Form1.PictureBox87.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "f2")) Then
            Form1.PictureBox78.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "f3")) Then
            Form1.PictureBox69.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "f4")) Then
            Form1.PictureBox60.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "f5")) Then
            Form1.PictureBox51.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "f6")) Then
            Form1.PictureBox42.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "f7")) Then
            Form1.PictureBox33.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "f8")) Then
            Form1.PictureBox24.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "f9")) Then
            Form1.PictureBox15.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "f10")) Then
            Form1.PictureBox6.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA7G()

        If ((positionOne = "a7") And (positionTwo = "g1")) Then
            Form1.PictureBox88.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "g2")) Then
            Form1.PictureBox79.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "g3")) Then
            Form1.PictureBox70.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "g4")) Then
            Form1.PictureBox61.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "g5")) Then
            Form1.PictureBox52.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "g6")) Then
            Form1.PictureBox43.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "g7")) Then
            Form1.PictureBox34.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "g8")) Then
            Form1.PictureBox25.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "g9")) Then
            Form1.PictureBox16.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "g10")) Then
            Form1.PictureBox7.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image
        End If
    End Sub
    Public Sub CheckA7H()

        If ((positionOne = "a7") And (positionTwo = "h1")) Then
            Form1.PictureBox89.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "h2")) Then
            Form1.PictureBox80.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "h3")) Then
            Form1.PictureBox71.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "h4")) Then
            Form1.PictureBox62.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "h5")) Then
            Form1.PictureBox53.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "h6")) Then
            Form1.PictureBox44.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "h7")) Then
            Form1.PictureBox35.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "h8")) Then
            Form1.PictureBox26.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "h9")) Then
            Form1.PictureBox17.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "h10")) Then
            Form1.PictureBox8.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA7I()

        If ((positionOne = "a7") And (positionTwo = "i1")) Then
            Form1.PictureBox90.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "i2")) Then
            Form1.PictureBox81.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "i3")) Then
            Form1.PictureBox72.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "i4")) Then
            Form1.PictureBox63.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "i5")) Then
            Form1.PictureBox54.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "i6")) Then
            Form1.PictureBox45.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "i7")) Then
            Form1.PictureBox36.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "i8")) Then
            Form1.PictureBox27.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "i9")) Then
            Form1.PictureBox18.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a7") And (positionTwo = "i10")) Then
            Form1.PictureBox9.Image = Form1.PictureBox28.Image
            Form1.PictureBox28.Image = Form1.nonePic.Image

        End If
    End Sub

    Public Sub CheckA8A()

        If ((positionOne = "a8") And (positionTwo = "a1")) Then
            Form1.PictureBox82.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "a2")) Then
            Form1.PictureBox73.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "a3")) Then
            Form1.PictureBox64.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "a4")) Then
            Form1.PictureBox55.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "a5")) Then
            Form1.PictureBox46.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "a6")) Then
            Form1.PictureBox37.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "a7")) Then
            Form1.PictureBox28.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "a8")) Then
            MessageBox.Show("a8-a8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ((positionOne = "a8") And (positionTwo = "a9")) Then
            Form1.PictureBox10.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "a10")) Then
            Form1.PictureBox1.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA8B()

        If ((positionOne = "a8") And (positionTwo = "b1")) Then
            Form1.PictureBox83.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "b2")) Then
            Form1.PictureBox74.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "b3")) Then
            Form1.PictureBox65.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "b4")) Then
            Form1.PictureBox56.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "b5")) Then
            Form1.PictureBox47.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "b6")) Then
            Form1.PictureBox38.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "b7")) Then
            Form1.PictureBox29.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "b8")) Then
            Form1.PictureBox20.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "b9")) Then
            Form1.PictureBox11.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "b10")) Then
            Form1.PictureBox2.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA8C()

        If ((positionOne = "a8") And (positionTwo = "c1")) Then
            Form1.PictureBox84.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "c2")) Then
            Form1.PictureBox75.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "c3")) Then
            Form1.PictureBox66.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "c4")) Then
            Form1.PictureBox57.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "c5")) Then
            Form1.PictureBox48.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "c6")) Then
            Form1.PictureBox39.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "c7")) Then
            Form1.PictureBox30.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "c8")) Then
            Form1.PictureBox21.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "c9")) Then
            Form1.PictureBox12.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "c10")) Then
            Form1.PictureBox3.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA8D()

        If ((positionOne = "a8") And (positionTwo = "d1")) Then
            Form1.PictureBox85.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "d2")) Then
            Form1.PictureBox76.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "d3")) Then
            Form1.PictureBox67.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "d4")) Then
            Form1.PictureBox58.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image
        ElseIf ((positionOne = "a8") And (positionTwo = "d5")) Then
            Form1.PictureBox49.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image
        ElseIf ((positionOne = "a8") And (positionTwo = "d6")) Then
            Form1.PictureBox40.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "d7")) Then
            Form1.PictureBox31.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "d8")) Then
            Form1.PictureBox22.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "d9")) Then
            Form1.PictureBox13.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "d10")) Then
            Form1.PictureBox4.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA8E()

        If ((positionOne = "a8") And (positionTwo = "e1")) Then
            Form1.PictureBox86.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "e2")) Then
            Form1.PictureBox77.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "e3")) Then
            Form1.PictureBox68.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "e4")) Then
            Form1.PictureBox59.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "e5")) Then
            Form1.PictureBox50.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "e6")) Then
            Form1.PictureBox41.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "e7")) Then
            Form1.PictureBox32.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "e8")) Then
            Form1.PictureBox23.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "e9")) Then
            Form1.PictureBox14.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "e10")) Then
            Form1.PictureBox5.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA8F()

        If ((positionOne = "a8") And (positionTwo = "f1")) Then
            Form1.PictureBox87.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "f2")) Then
            Form1.PictureBox78.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "f3")) Then
            Form1.PictureBox69.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "f4")) Then
            Form1.PictureBox60.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "f5")) Then
            Form1.PictureBox51.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "f6")) Then
            Form1.PictureBox42.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "f7")) Then
            Form1.PictureBox33.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "f8")) Then
            Form1.PictureBox24.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "f9")) Then
            Form1.PictureBox15.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "f10")) Then
            Form1.PictureBox6.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA8G()

        If ((positionOne = "a8") And (positionTwo = "g1")) Then
            Form1.PictureBox88.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "g2")) Then
            Form1.PictureBox79.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image
        ElseIf ((positionOne = "a8") And (positionTwo = "g3")) Then
            Form1.PictureBox70.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "g4")) Then
            Form1.PictureBox61.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "g5")) Then
            Form1.PictureBox52.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "g6")) Then
            Form1.PictureBox43.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "g7")) Then
            Form1.PictureBox34.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "g8")) Then
            Form1.PictureBox25.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "g9")) Then
            Form1.PictureBox16.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "g10")) Then
            Form1.PictureBox7.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA8H()

        If ((positionOne = "a8") And (positionTwo = "h1")) Then
            Form1.PictureBox89.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "h2")) Then
            Form1.PictureBox80.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "h3")) Then
            Form1.PictureBox71.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "h4")) Then
            Form1.PictureBox62.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "h5")) Then
            Form1.PictureBox53.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "h6")) Then
            Form1.PictureBox44.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "h7")) Then
            Form1.PictureBox35.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "h8")) Then
            Form1.PictureBox26.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "h9")) Then
            Form1.PictureBox17.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "h10")) Then
            Form1.PictureBox8.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA8I()

        If ((positionOne = "a8") And (positionTwo = "i1")) Then
            Form1.PictureBox90.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "i2")) Then
            Form1.PictureBox81.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "i3")) Then
            Form1.PictureBox72.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "i4")) Then
            Form1.PictureBox63.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "i5")) Then
            Form1.PictureBox54.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "i6")) Then
            Form1.PictureBox45.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "i7")) Then
            Form1.PictureBox36.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "i8")) Then
            Form1.PictureBox27.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "i9")) Then
            Form1.PictureBox18.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a8") And (positionTwo = "i10")) Then
            Form1.PictureBox9.Image = Form1.PictureBox19.Image
            Form1.PictureBox19.Image = Form1.nonePic.Image
        End If
    End Sub

    Public Sub CheckA9A()

        If ((positionOne = "a9") And (positionTwo = "a1")) Then
            Form1.PictureBox82.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "a2")) Then
            Form1.PictureBox73.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "a3")) Then
            Form1.PictureBox64.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "a4")) Then
            Form1.PictureBox55.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image
        ElseIf ((positionOne = "a9") And (positionTwo = "a5")) Then
            Form1.PictureBox46.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "a6")) Then
            Form1.PictureBox37.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "a7")) Then
            Form1.PictureBox28.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "a8")) Then
            Form1.PictureBox19.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "a9")) Then
            MessageBox.Show("a9-a9", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf ((positionOne = "a9") And (positionTwo = "a10")) Then
            Form1.PictureBox1.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA9B()

        If ((positionOne = "a9") And (positionTwo = "b1")) Then
            Form1.PictureBox83.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "b2")) Then
            Form1.PictureBox74.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "b3")) Then
            Form1.PictureBox65.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "b4")) Then
            Form1.PictureBox56.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "b5")) Then
            Form1.PictureBox47.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "b6")) Then
            Form1.PictureBox38.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "b7")) Then
            Form1.PictureBox29.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "b8")) Then
            Form1.PictureBox20.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "b9")) Then
            Form1.PictureBox11.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "b10")) Then
            Form1.PictureBox2.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA9C()

        If ((positionOne = "a9") And (positionTwo = "c1")) Then
            Form1.PictureBox84.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "c2")) Then
            Form1.PictureBox75.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "c3")) Then
            Form1.PictureBox66.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "c4")) Then
            Form1.PictureBox57.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "c5")) Then
            Form1.PictureBox48.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image
        ElseIf ((positionOne = "a9") And (positionTwo = "c6")) Then
            Form1.PictureBox39.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "c7")) Then
            Form1.PictureBox30.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "c8")) Then
            Form1.PictureBox21.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "c9")) Then
            Form1.PictureBox12.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "c10")) Then
            Form1.PictureBox3.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA9D()

        If ((positionOne = "a9") And (positionTwo = "d1")) Then
            Form1.PictureBox85.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "d2")) Then
            Form1.PictureBox76.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "d3")) Then
            Form1.PictureBox67.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "d4")) Then
            Form1.PictureBox58.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "d5")) Then
            Form1.PictureBox49.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "d6")) Then
            Form1.PictureBox40.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "d7")) Then
            Form1.PictureBox31.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "d8")) Then
            Form1.PictureBox22.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "d9")) Then
            Form1.PictureBox13.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "d10")) Then
            Form1.PictureBox4.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA9E()

        If ((positionOne = "a9") And (positionTwo = "e1")) Then
            Form1.PictureBox86.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "e2")) Then
            Form1.PictureBox77.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "e3")) Then
            Form1.PictureBox68.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "e4")) Then
            Form1.PictureBox59.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "e5")) Then
            Form1.PictureBox50.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "e6")) Then
            Form1.PictureBox41.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "e7")) Then
            Form1.PictureBox32.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "e8")) Then
            Form1.PictureBox23.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "e9")) Then
            Form1.PictureBox14.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "e10")) Then
            Form1.PictureBox5.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA9F()

        If ((positionOne = "a9") And (positionTwo = "f1")) Then
            Form1.PictureBox87.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "f2")) Then
            Form1.PictureBox78.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "f3")) Then
            Form1.PictureBox69.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "f4")) Then
            Form1.PictureBox60.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "f5")) Then
            Form1.PictureBox51.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "f6")) Then
            Form1.PictureBox42.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "f7")) Then
            Form1.PictureBox33.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "f8")) Then
            Form1.PictureBox24.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "f9")) Then
            Form1.PictureBox15.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "f10")) Then
            Form1.PictureBox6.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA9G()

        If ((positionOne = "a9") And (positionTwo = "g1")) Then
            Form1.PictureBox88.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "g2")) Then
            Form1.PictureBox79.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "g3")) Then
            Form1.PictureBox70.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "g4")) Then
            Form1.PictureBox61.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "g5")) Then
            Form1.PictureBox52.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "g6")) Then
            Form1.PictureBox43.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "g7")) Then
            Form1.PictureBox34.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "g8")) Then
            Form1.PictureBox25.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "g9")) Then
            Form1.PictureBox16.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "g10")) Then
            Form1.PictureBox7.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image
        End If
    End Sub
    Public Sub CheckA9H()

        If ((positionOne = "a9") And (positionTwo = "h1")) Then
            Form1.PictureBox89.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "h2")) Then
            Form1.PictureBox80.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "h3")) Then
            Form1.PictureBox71.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "h4")) Then
            Form1.PictureBox62.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "h5")) Then
            Form1.PictureBox53.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "h6")) Then
            Form1.PictureBox44.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "h7")) Then
            Form1.PictureBox35.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "h8")) Then
            Form1.PictureBox26.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "h9")) Then
            Form1.PictureBox17.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "h10")) Then
            Form1.PictureBox8.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA9I()

        If ((positionOne = "a9") And (positionTwo = "i1")) Then
            Form1.PictureBox90.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "i2")) Then
            Form1.PictureBox81.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "i3")) Then
            Form1.PictureBox72.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "i4")) Then
            Form1.PictureBox63.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image
        ElseIf ((positionOne = "a9") And (positionTwo = "i5")) Then
            Form1.PictureBox54.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "i6")) Then
            Form1.PictureBox45.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "i7")) Then
            Form1.PictureBox36.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "i8")) Then
            Form1.PictureBox27.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "i9")) Then
            Form1.PictureBox18.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a9") And (positionTwo = "i10")) Then
            Form1.PictureBox9.Image = Form1.PictureBox10.Image
            Form1.PictureBox10.Image = Form1.nonePic.Image

        End If
    End Sub

    Public Sub CheckA10A()

        If ((positionOne = "a10") And (positionTwo = "a1")) Then
            Form1.PictureBox82.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "a2")) Then
            Form1.PictureBox73.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "a3")) Then
            Form1.PictureBox64.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "a4")) Then
            Form1.PictureBox55.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "a5")) Then
            Form1.PictureBox46.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "a6")) Then
            Form1.PictureBox37.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "a7")) Then
            Form1.PictureBox28.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "a8")) Then
            Form1.PictureBox19.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "a9")) Then
            Form1.PictureBox10.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "a10")) Then
            MessageBox.Show("a10-a10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
    Public Sub CheckA10B()

        If ((positionOne = "a10") And (positionTwo = "b1")) Then
            Form1.PictureBox83.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "b2")) Then
            Form1.PictureBox74.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "b3")) Then
            Form1.PictureBox65.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "b4")) Then
            Form1.PictureBox56.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "b5")) Then
            Form1.PictureBox47.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "b6")) Then
            Form1.PictureBox38.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "b7")) Then
            Form1.PictureBox29.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "b8")) Then
            Form1.PictureBox20.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "b9")) Then
            Form1.PictureBox11.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "b10")) Then
            Form1.PictureBox2.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA10C()

        If ((positionOne = "a10") And (positionTwo = "c1")) Then
            Form1.PictureBox84.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image
        ElseIf ((positionOne = "a10") And (positionTwo = "c2")) Then
            Form1.PictureBox75.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "c3")) Then
            Form1.PictureBox66.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "c4")) Then
            Form1.PictureBox57.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "c5")) Then
            Form1.PictureBox48.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "c6")) Then
            Form1.PictureBox39.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "c7")) Then
            Form1.PictureBox30.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "c8")) Then
            Form1.PictureBox21.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "c9")) Then
            Form1.PictureBox12.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "c10")) Then
            Form1.PictureBox3.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA10D()

        If ((positionOne = "a10") And (positionTwo = "d1")) Then
            Form1.PictureBox85.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "d2")) Then
            Form1.PictureBox76.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "d3")) Then
            Form1.PictureBox67.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "d4")) Then
            Form1.PictureBox58.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "d5")) Then
            Form1.PictureBox49.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "d6")) Then
            Form1.PictureBox40.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "d7")) Then
            Form1.PictureBox31.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "d8")) Then
            Form1.PictureBox22.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "d9")) Then
            Form1.PictureBox13.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "d10")) Then
            Form1.PictureBox4.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA10E()

        If ((positionOne = "a10") And (positionTwo = "e1")) Then
            Form1.PictureBox86.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "e2")) Then
            Form1.PictureBox77.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "e3")) Then
            Form1.PictureBox68.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "e4")) Then
            Form1.PictureBox59.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "e5")) Then
            Form1.PictureBox50.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "e6")) Then
            Form1.PictureBox41.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "e7")) Then
            Form1.PictureBox32.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "e8")) Then
            Form1.PictureBox23.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "e9")) Then
            Form1.PictureBox14.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "e10")) Then
            Form1.PictureBox5.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA10F()

        If ((positionOne = "a10") And (positionTwo = "f1")) Then
            Form1.PictureBox87.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "f2")) Then
            Form1.PictureBox78.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "f3")) Then
            Form1.PictureBox69.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "f4")) Then
            Form1.PictureBox60.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "f5")) Then
            Form1.PictureBox51.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "f6")) Then
            Form1.PictureBox42.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "f7")) Then
            Form1.PictureBox33.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "f8")) Then
            Form1.PictureBox24.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "f9")) Then
            Form1.PictureBox15.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "f10")) Then
            Form1.PictureBox6.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA10G()

        If ((positionOne = "a10") And (positionTwo = "g1")) Then
            Form1.PictureBox88.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "g2")) Then
            Form1.PictureBox79.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "g3")) Then
            Form1.PictureBox70.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "g4")) Then
            Form1.PictureBox61.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "g5")) Then
            Form1.PictureBox52.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "g6")) Then
            Form1.PictureBox43.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "g7")) Then
            Form1.PictureBox34.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "g8")) Then
            Form1.PictureBox25.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image
        ElseIf ((positionOne = "a10") And (positionTwo = "g9")) Then
            Form1.PictureBox16.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "g10")) Then
            Form1.PictureBox7.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA10H()

        If ((positionOne = "a10") And (positionTwo = "h1")) Then
            Form1.PictureBox89.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "h2")) Then
            Form1.PictureBox80.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "h3")) Then
            Form1.PictureBox71.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "h4")) Then
            Form1.PictureBox62.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "h5")) Then
            Form1.PictureBox53.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image
        ElseIf ((positionOne = "a10") And (positionTwo = "h6")) Then
            Form1.PictureBox44.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "h7")) Then
            Form1.PictureBox35.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "h8")) Then
            Form1.PictureBox26.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "h9")) Then
            Form1.PictureBox17.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "h10")) Then
            Form1.PictureBox8.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        End If
    End Sub
    Public Sub CheckA10I()

        If ((positionOne = "a10") And (positionTwo = "i1")) Then
            Form1.PictureBox90.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "i2")) Then
            Form1.PictureBox81.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "i3")) Then
            Form1.PictureBox72.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "i4")) Then
            Form1.PictureBox63.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "i5")) Then
            Form1.PictureBox54.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "i6")) Then
            Form1.PictureBox45.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "i7")) Then
            Form1.PictureBox36.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "i8")) Then
            Form1.PictureBox27.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "i9")) Then
            Form1.PictureBox18.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image

        ElseIf ((positionOne = "a10") And (positionTwo = "i10")) Then
            Form1.PictureBox9.Image = Form1.PictureBox1.Image
            Form1.PictureBox1.Image = Form1.nonePic.Image
        End If
    End Sub
End Module
