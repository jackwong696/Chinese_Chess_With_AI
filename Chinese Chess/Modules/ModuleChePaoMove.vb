' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 01/10/2010 to 28/10/2010
' Descripitons : Chinese Chess V1

Module ModuleChePaoMove
    Public moveBool As Boolean

    Public Sub checkCheA1Move()
        If (positionOneTwo = "a1a2") Or (positionOneTwo = "a1a3") Or (positionOneTwo = "a1a4") Or (positionOneTwo = "a1a5") Or (positionOneTwo = "a1a6") Or (positionOneTwo = "a1a7") Or (positionOneTwo = "a1a8") Or (positionOneTwo = "a1a9") Or (positionOneTwo = "a1a10") Or (positionOneTwo = "a1b1") Or (positionOneTwo = "a1c1") Or (positionOneTwo = "a1d1") Or (positionOneTwo = "a1e1") Or (positionOneTwo = "a1f1") Or (positionOneTwo = "a1g1") Or (positionOneTwo = "a1h1") Or (positionOneTwo = "a1i1") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheB1Move()
        If (positionOneTwo = "b1b2") Or (positionOneTwo = "b1b3") Or (positionOneTwo = "b1b4") Or (positionOneTwo = "b1b5") Or (positionOneTwo = "b1b6") Or (positionOneTwo = "b1b7") Or (positionOneTwo = "b1b8") Or (positionOneTwo = "b1b9") Or (positionOneTwo = "b1b10") Or (positionOneTwo = "b1a1") Or (positionOneTwo = "b1c1") Or (positionOneTwo = "b1d1") Or (positionOneTwo = "b1e1") Or (positionOneTwo = "b1f1") Or (positionOneTwo = "b1g1") Or (positionOneTwo = "b1h1") Or (positionOneTwo = "b1i1") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheC1Move()
        If (positionOneTwo = "c1c2") Or (positionOneTwo = "c1c3") Or (positionOneTwo = "c1c4") Or (positionOneTwo = "c1c5") Or (positionOneTwo = "c1c6") Or (positionOneTwo = "c1c7") Or (positionOneTwo = "c1c8") Or (positionOneTwo = "c1c9") Or (positionOneTwo = "c1c10") Or (positionOneTwo = "c1b1") Or (positionOneTwo = "c1a1") Or (positionOneTwo = "c1d1") Or (positionOneTwo = "c1e1") Or (positionOneTwo = "c1f1") Or (positionOneTwo = "c1g1") Or (positionOneTwo = "c1h1") Or (positionOneTwo = "c1i1") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheD1Move()
        If (positionOneTwo = "d1d2") Or (positionOneTwo = "d1d3") Or (positionOneTwo = "d1d4") Or (positionOneTwo = "d1d5") Or (positionOneTwo = "d1d6") Or (positionOneTwo = "d1d7") Or (positionOneTwo = "d1d8") Or (positionOneTwo = "d1d9") Or (positionOneTwo = "d1d10") Or (positionOneTwo = "d1b1") Or (positionOneTwo = "d1c1") Or (positionOneTwo = "d1a1") Or (positionOneTwo = "d1e1") Or (positionOneTwo = "d1f1") Or (positionOneTwo = "d1g1") Or (positionOneTwo = "d1h1") Or (positionOneTwo = "d1i1") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheE1Move()
        If (positionOneTwo = "e1e2") Or (positionOneTwo = "e1e3") Or (positionOneTwo = "e1e4") Or (positionOneTwo = "e1e5") Or (positionOneTwo = "e1e6") Or (positionOneTwo = "e1e7") Or (positionOneTwo = "e1e8") Or (positionOneTwo = "e1e9") Or (positionOneTwo = "e1e10") Or (positionOneTwo = "e1b1") Or (positionOneTwo = "e1c1") Or (positionOneTwo = "e1d1") Or (positionOneTwo = "e1a1") Or (positionOneTwo = "e1f1") Or (positionOneTwo = "e1g1") Or (positionOneTwo = "e1h1") Or (positionOneTwo = "e1i1") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheF1Move()
        If (positionOneTwo = "f1f2") Or (positionOneTwo = "f1f3") Or (positionOneTwo = "f1f4") Or (positionOneTwo = "f1f5") Or (positionOneTwo = "f1f6") Or (positionOneTwo = "f1f7") Or (positionOneTwo = "f1f8") Or (positionOneTwo = "f1f9") Or (positionOneTwo = "f1f10") Or (positionOneTwo = "f1b1") Or (positionOneTwo = "f1c1") Or (positionOneTwo = "f1d1") Or (positionOneTwo = "f1e1") Or (positionOneTwo = "f1a1") Or (positionOneTwo = "f1g1") Or (positionOneTwo = "f1h1") Or (positionOneTwo = "f1i1") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheG1Move()
        If (positionOneTwo = "g1g2") Or (positionOneTwo = "g1g3") Or (positionOneTwo = "g1g4") Or (positionOneTwo = "g1g5") Or (positionOneTwo = "g1g6") Or (positionOneTwo = "g1g7") Or (positionOneTwo = "g1g8") Or (positionOneTwo = "g1g9") Or (positionOneTwo = "g1g10") Or (positionOneTwo = "g1b1") Or (positionOneTwo = "g1c1") Or (positionOneTwo = "g1d1") Or (positionOneTwo = "g1e1") Or (positionOneTwo = "g1f1") Or (positionOneTwo = "g1a1") Or (positionOneTwo = "g1h1") Or (positionOneTwo = "g1i1") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheH1Move()
        If (positionOneTwo = "h1h2") Or (positionOneTwo = "h1h3") Or (positionOneTwo = "h1h4") Or (positionOneTwo = "h1h5") Or (positionOneTwo = "h1h6") Or (positionOneTwo = "h1h7") Or (positionOneTwo = "h1h8") Or (positionOneTwo = "h1h9") Or (positionOneTwo = "h1h10") Or (positionOneTwo = "h1b1") Or (positionOneTwo = "h1c1") Or (positionOneTwo = "h1d1") Or (positionOneTwo = "h1e1") Or (positionOneTwo = "h1f1") Or (positionOneTwo = "h1g1") Or (positionOneTwo = "h1a1") Or (positionOneTwo = "h1i1") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheI1Move()
        If (positionOneTwo = "i1i2") Or (positionOneTwo = "i1i3") Or (positionOneTwo = "i1i4") Or (positionOneTwo = "i1i5") Or (positionOneTwo = "i1i6") Or (positionOneTwo = "i1i7") Or (positionOneTwo = "i1i8") Or (positionOneTwo = "i1i9") Or (positionOneTwo = "i1i10") Or (positionOneTwo = "i1b1") Or (positionOneTwo = "i1c1") Or (positionOneTwo = "i1d1") Or (positionOneTwo = "i1e1") Or (positionOneTwo = "i1f1") Or (positionOneTwo = "i1g1") Or (positionOneTwo = "i1h1") Or (positionOneTwo = "i1a1") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub

    Public Sub checkCheA2Move()
        If (positionOneTwo = "a2a1") Or (positionOneTwo = "a2a3") Or (positionOneTwo = "a2a4") Or (positionOneTwo = "a2a5") Or (positionOneTwo = "a2a6") Or (positionOneTwo = "a2a7") Or (positionOneTwo = "a2a8") Or (positionOneTwo = "a2a9") Or (positionOneTwo = "a2a10") Or (positionOneTwo = "a2b2") Or (positionOneTwo = "a2c2") Or (positionOneTwo = "a2d2") Or (positionOneTwo = "a2e2") Or (positionOneTwo = "a2f2") Or (positionOneTwo = "a2g2") Or (positionOneTwo = "a2h2") Or (positionOneTwo = "a2i2") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheB2Move()
        If (positionOneTwo = "b2b1") Or (positionOneTwo = "b2b3") Or (positionOneTwo = "b2b4") Or (positionOneTwo = "b2b5") Or (positionOneTwo = "b2b6") Or (positionOneTwo = "b2b7") Or (positionOneTwo = "b2b8") Or (positionOneTwo = "b2b9") Or (positionOneTwo = "b2b10") Or (positionOneTwo = "b2a2") Or (positionOneTwo = "b2c2") Or (positionOneTwo = "b2d2") Or (positionOneTwo = "b2e2") Or (positionOneTwo = "b2f2") Or (positionOneTwo = "b2g2") Or (positionOneTwo = "b2h2") Or (positionOneTwo = "b2i2") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheC2Move()
        If (positionOneTwo = "c2c1") Or (positionOneTwo = "c2c3") Or (positionOneTwo = "c2c4") Or (positionOneTwo = "c2c5") Or (positionOneTwo = "c2c6") Or (positionOneTwo = "c2c7") Or (positionOneTwo = "c2c8") Or (positionOneTwo = "c2c9") Or (positionOneTwo = "c2c10") Or (positionOneTwo = "c2b2") Or (positionOneTwo = "c2a2") Or (positionOneTwo = "c2d2") Or (positionOneTwo = "c2e2") Or (positionOneTwo = "c2f2") Or (positionOneTwo = "c2g2") Or (positionOneTwo = "c2h2") Or (positionOneTwo = "c2i2") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheD2Move()
        If (positionOneTwo = "d2d1") Or (positionOneTwo = "d2d3") Or (positionOneTwo = "d2d4") Or (positionOneTwo = "d2d5") Or (positionOneTwo = "d2d6") Or (positionOneTwo = "d2d7") Or (positionOneTwo = "d2d8") Or (positionOneTwo = "d2d9") Or (positionOneTwo = "d2d10") Or (positionOneTwo = "d2b2") Or (positionOneTwo = "d2c2") Or (positionOneTwo = "d2a2") Or (positionOneTwo = "d2e2") Or (positionOneTwo = "d2f2") Or (positionOneTwo = "d2g2") Or (positionOneTwo = "d2h2") Or (positionOneTwo = "d2i2") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheE2Move()
        If (positionOneTwo = "e2e1") Or (positionOneTwo = "e2e3") Or (positionOneTwo = "e2e4") Or (positionOneTwo = "e2e5") Or (positionOneTwo = "e2e6") Or (positionOneTwo = "e2e7") Or (positionOneTwo = "e2e8") Or (positionOneTwo = "e2e9") Or (positionOneTwo = "e2e10") Or (positionOneTwo = "e2b2") Or (positionOneTwo = "e2c2") Or (positionOneTwo = "e2d2") Or (positionOneTwo = "e2a2") Or (positionOneTwo = "e2f2") Or (positionOneTwo = "e2g2") Or (positionOneTwo = "e2h2") Or (positionOneTwo = "e2i2") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheF2Move()
        If (positionOneTwo = "f2f1") Or (positionOneTwo = "f2f3") Or (positionOneTwo = "f2f4") Or (positionOneTwo = "f2f5") Or (positionOneTwo = "f2f6") Or (positionOneTwo = "f2f7") Or (positionOneTwo = "f2f8") Or (positionOneTwo = "f2f9") Or (positionOneTwo = "f2f10") Or (positionOneTwo = "f2b2") Or (positionOneTwo = "f2c2") Or (positionOneTwo = "f2d2") Or (positionOneTwo = "f2e2") Or (positionOneTwo = "f2a2") Or (positionOneTwo = "f2g2") Or (positionOneTwo = "f2h2") Or (positionOneTwo = "f2i2") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheG2Move()
        If (positionOneTwo = "g2g1") Or (positionOneTwo = "g2g3") Or (positionOneTwo = "g2g4") Or (positionOneTwo = "g2g5") Or (positionOneTwo = "g2g6") Or (positionOneTwo = "g2g7") Or (positionOneTwo = "g2g8") Or (positionOneTwo = "g2g9") Or (positionOneTwo = "g2g10") Or (positionOneTwo = "g2b2") Or (positionOneTwo = "g2c2") Or (positionOneTwo = "g2d2") Or (positionOneTwo = "g2e2") Or (positionOneTwo = "g2f2") Or (positionOneTwo = "g2a2") Or (positionOneTwo = "g2h2") Or (positionOneTwo = "g2i2") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheH2Move()
        If (positionOneTwo = "h2h1") Or (positionOneTwo = "h2h3") Or (positionOneTwo = "h2h4") Or (positionOneTwo = "h2h5") Or (positionOneTwo = "h2h6") Or (positionOneTwo = "h2h7") Or (positionOneTwo = "h2h8") Or (positionOneTwo = "h2h9") Or (positionOneTwo = "h2h10") Or (positionOneTwo = "h2b2") Or (positionOneTwo = "h2c2") Or (positionOneTwo = "h2d2") Or (positionOneTwo = "h2e2") Or (positionOneTwo = "h2f2") Or (positionOneTwo = "h2g2") Or (positionOneTwo = "h2a2") Or (positionOneTwo = "h2i2") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheI2Move()
        If (positionOneTwo = "i2i1") Or (positionOneTwo = "i2i3") Or (positionOneTwo = "i2i4") Or (positionOneTwo = "i2i5") Or (positionOneTwo = "i2i6") Or (positionOneTwo = "i2i7") Or (positionOneTwo = "i2i8") Or (positionOneTwo = "i2i9") Or (positionOneTwo = "i2i10") Or (positionOneTwo = "i2b2") Or (positionOneTwo = "i2c2") Or (positionOneTwo = "i2d2") Or (positionOneTwo = "i2e2") Or (positionOneTwo = "i2f2") Or (positionOneTwo = "i2g2") Or (positionOneTwo = "i2h2") Or (positionOneTwo = "i2a2") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub

    Public Sub checkCheA3Move()
        If (positionOneTwo = "a3a1") Or (positionOneTwo = "a3a2") Or (positionOneTwo = "a3a4") Or (positionOneTwo = "a3a5") Or (positionOneTwo = "a3a6") Or (positionOneTwo = "a3a7") Or (positionOneTwo = "a3a8") Or (positionOneTwo = "a3a9") Or (positionOneTwo = "a3a10") Or (positionOneTwo = "a3b3") Or (positionOneTwo = "a3c3") Or (positionOneTwo = "a3d3") Or (positionOneTwo = "a3e3") Or (positionOneTwo = "a3f3") Or (positionOneTwo = "a3g3") Or (positionOneTwo = "a3h3") Or (positionOneTwo = "a3i3") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheB3Move()
        If (positionOneTwo = "b3b1") Or (positionOneTwo = "b3b2") Or (positionOneTwo = "b3b4") Or (positionOneTwo = "b3b5") Or (positionOneTwo = "b3b6") Or (positionOneTwo = "b3b7") Or (positionOneTwo = "b3b8") Or (positionOneTwo = "b3b9") Or (positionOneTwo = "b3b10") Or (positionOneTwo = "b3a3") Or (positionOneTwo = "b3c3") Or (positionOneTwo = "b3d3") Or (positionOneTwo = "b3e3") Or (positionOneTwo = "b3f3") Or (positionOneTwo = "b3g3") Or (positionOneTwo = "b3h3") Or (positionOneTwo = "b3i3") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheC3Move()
        If (positionOneTwo = "c3c1") Or (positionOneTwo = "c3c2") Or (positionOneTwo = "c3c4") Or (positionOneTwo = "c3c5") Or (positionOneTwo = "c3c6") Or (positionOneTwo = "c3c7") Or (positionOneTwo = "c3c8") Or (positionOneTwo = "c3c9") Or (positionOneTwo = "c3c10") Or (positionOneTwo = "c3b3") Or (positionOneTwo = "c3a3") Or (positionOneTwo = "c3d3") Or (positionOneTwo = "c3e3") Or (positionOneTwo = "c3f3") Or (positionOneTwo = "c3g3") Or (positionOneTwo = "c3h3") Or (positionOneTwo = "c3i3") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheD3Move()
        If (positionOneTwo = "d3d1") Or (positionOneTwo = "d3d2") Or (positionOneTwo = "d3d4") Or (positionOneTwo = "d3d5") Or (positionOneTwo = "d3d6") Or (positionOneTwo = "d3d7") Or (positionOneTwo = "d3d8") Or (positionOneTwo = "d3d9") Or (positionOneTwo = "d3d10") Or (positionOneTwo = "d3b3") Or (positionOneTwo = "d3c3") Or (positionOneTwo = "d3a3") Or (positionOneTwo = "d3e3") Or (positionOneTwo = "d3f3") Or (positionOneTwo = "d3g3") Or (positionOneTwo = "d3h3") Or (positionOneTwo = "d3i3") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheE3Move()
        If (positionOneTwo = "e3e1") Or (positionOneTwo = "e3e2") Or (positionOneTwo = "e3e4") Or (positionOneTwo = "e3e5") Or (positionOneTwo = "e3e6") Or (positionOneTwo = "e3e7") Or (positionOneTwo = "e3e8") Or (positionOneTwo = "e3e9") Or (positionOneTwo = "e3e10") Or (positionOneTwo = "e3b3") Or (positionOneTwo = "e3c3") Or (positionOneTwo = "e3d3") Or (positionOneTwo = "e3a3") Or (positionOneTwo = "e3f3") Or (positionOneTwo = "e3g3") Or (positionOneTwo = "e3h3") Or (positionOneTwo = "e3i3") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheF3Move()
        If (positionOneTwo = "f3f1") Or (positionOneTwo = "f3f2") Or (positionOneTwo = "f3f4") Or (positionOneTwo = "f3f5") Or (positionOneTwo = "f3f6") Or (positionOneTwo = "f3f7") Or (positionOneTwo = "f3f8") Or (positionOneTwo = "f3f9") Or (positionOneTwo = "f3f10") Or (positionOneTwo = "f3b3") Or (positionOneTwo = "f3c3") Or (positionOneTwo = "f3d3") Or (positionOneTwo = "f3e3") Or (positionOneTwo = "f3a3") Or (positionOneTwo = "f3g3") Or (positionOneTwo = "f3h3") Or (positionOneTwo = "f3i3") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheG3Move()
        If (positionOneTwo = "g3g1") Or (positionOneTwo = "g3g2") Or (positionOneTwo = "g3g4") Or (positionOneTwo = "g3g5") Or (positionOneTwo = "g3g6") Or (positionOneTwo = "g3g7") Or (positionOneTwo = "g3g8") Or (positionOneTwo = "g3g9") Or (positionOneTwo = "g3g10") Or (positionOneTwo = "g3b3") Or (positionOneTwo = "g3c3") Or (positionOneTwo = "g3d3") Or (positionOneTwo = "g3e3") Or (positionOneTwo = "g3f3") Or (positionOneTwo = "g3a3") Or (positionOneTwo = "g3h3") Or (positionOneTwo = "g3i3") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheH3Move()
        If (positionOneTwo = "h3h1") Or (positionOneTwo = "h3h2") Or (positionOneTwo = "h3h4") Or (positionOneTwo = "h3h5") Or (positionOneTwo = "h3h6") Or (positionOneTwo = "h3h7") Or (positionOneTwo = "h3h8") Or (positionOneTwo = "h3h9") Or (positionOneTwo = "h3h10") Or (positionOneTwo = "h3b3") Or (positionOneTwo = "h3c3") Or (positionOneTwo = "h3d3") Or (positionOneTwo = "h3e3") Or (positionOneTwo = "h3f3") Or (positionOneTwo = "h3g3") Or (positionOneTwo = "h3a3") Or (positionOneTwo = "h3i3") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheI3Move()
        If (positionOneTwo = "i3i1") Or (positionOneTwo = "i3i2") Or (positionOneTwo = "i3i4") Or (positionOneTwo = "i3i5") Or (positionOneTwo = "i3i6") Or (positionOneTwo = "i3i7") Or (positionOneTwo = "i3i8") Or (positionOneTwo = "i3i9") Or (positionOneTwo = "i3i10") Or (positionOneTwo = "i3b3") Or (positionOneTwo = "i3c3") Or (positionOneTwo = "i3d3") Or (positionOneTwo = "i3e3") Or (positionOneTwo = "i3f3") Or (positionOneTwo = "i3g3") Or (positionOneTwo = "i3h3") Or (positionOneTwo = "i3a3") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub

    Public Sub checkCheA4Move()
        If (positionOneTwo = "a4a1") Or (positionOneTwo = "a4a3") Or (positionOneTwo = "a4a2") Or (positionOneTwo = "a4a5") Or (positionOneTwo = "a4a6") Or (positionOneTwo = "a4a7") Or (positionOneTwo = "a4a8") Or (positionOneTwo = "a4a9") Or (positionOneTwo = "a4a10") Or (positionOneTwo = "a4b4") Or (positionOneTwo = "a4c4") Or (positionOneTwo = "a4d4") Or (positionOneTwo = "a4e4") Or (positionOneTwo = "a4f4") Or (positionOneTwo = "a4g4") Or (positionOneTwo = "a4h4") Or (positionOneTwo = "a4i4") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheB4Move()
        If (positionOneTwo = "b4b1") Or (positionOneTwo = "b4b3") Or (positionOneTwo = "b4b2") Or (positionOneTwo = "b4b5") Or (positionOneTwo = "b4b6") Or (positionOneTwo = "b4b7") Or (positionOneTwo = "b4b8") Or (positionOneTwo = "b4b9") Or (positionOneTwo = "b4b10") Or (positionOneTwo = "b4a4") Or (positionOneTwo = "b4c4") Or (positionOneTwo = "b4d4") Or (positionOneTwo = "b4e4") Or (positionOneTwo = "b4f4") Or (positionOneTwo = "b4g4") Or (positionOneTwo = "b4h4") Or (positionOneTwo = "b4i4") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheC4Move()
        If (positionOneTwo = "c4c1") Or (positionOneTwo = "c4c3") Or (positionOneTwo = "c4c2") Or (positionOneTwo = "c4c5") Or (positionOneTwo = "c4c6") Or (positionOneTwo = "c4c7") Or (positionOneTwo = "c4c8") Or (positionOneTwo = "c4c9") Or (positionOneTwo = "c4c10") Or (positionOneTwo = "c4b4") Or (positionOneTwo = "c4a4") Or (positionOneTwo = "c4d4") Or (positionOneTwo = "c4e4") Or (positionOneTwo = "c4f4") Or (positionOneTwo = "c4g4") Or (positionOneTwo = "c4h4") Or (positionOneTwo = "c4i4") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheD4Move()
        If (positionOneTwo = "d4d1") Or (positionOneTwo = "d4d3") Or (positionOneTwo = "d4d2") Or (positionOneTwo = "d4d5") Or (positionOneTwo = "d4d6") Or (positionOneTwo = "d4d7") Or (positionOneTwo = "d4d8") Or (positionOneTwo = "d4d9") Or (positionOneTwo = "d4d10") Or (positionOneTwo = "d4b4") Or (positionOneTwo = "d4c4") Or (positionOneTwo = "d4a4") Or (positionOneTwo = "d4e4") Or (positionOneTwo = "d4f4") Or (positionOneTwo = "d4g4") Or (positionOneTwo = "d4h4") Or (positionOneTwo = "d4i4") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheE4Move()
        If (positionOneTwo = "e4e1") Or (positionOneTwo = "e4e3") Or (positionOneTwo = "e4e2") Or (positionOneTwo = "e4e5") Or (positionOneTwo = "e4e6") Or (positionOneTwo = "e4e7") Or (positionOneTwo = "e4e8") Or (positionOneTwo = "e4e9") Or (positionOneTwo = "e4e10") Or (positionOneTwo = "e4b4") Or (positionOneTwo = "e4c4") Or (positionOneTwo = "e4d4") Or (positionOneTwo = "e4a4") Or (positionOneTwo = "e4f4") Or (positionOneTwo = "e4g4") Or (positionOneTwo = "e4h4") Or (positionOneTwo = "e4i4") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheF4Move()
        If (positionOneTwo = "f4f1") Or (positionOneTwo = "f4f3") Or (positionOneTwo = "f4f2") Or (positionOneTwo = "f4f5") Or (positionOneTwo = "f4f6") Or (positionOneTwo = "f4f7") Or (positionOneTwo = "f4f8") Or (positionOneTwo = "f4f9") Or (positionOneTwo = "f4f10") Or (positionOneTwo = "f4b4") Or (positionOneTwo = "f4c4") Or (positionOneTwo = "f4d4") Or (positionOneTwo = "f4e4") Or (positionOneTwo = "f4a4") Or (positionOneTwo = "f4g4") Or (positionOneTwo = "f4h4") Or (positionOneTwo = "f4i4") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheG4Move()
        If (positionOneTwo = "g4g1") Or (positionOneTwo = "g4g3") Or (positionOneTwo = "g4g2") Or (positionOneTwo = "g4g5") Or (positionOneTwo = "g4g6") Or (positionOneTwo = "g4g7") Or (positionOneTwo = "g4g8") Or (positionOneTwo = "g4g9") Or (positionOneTwo = "g4g10") Or (positionOneTwo = "g4b4") Or (positionOneTwo = "g4c4") Or (positionOneTwo = "g4d4") Or (positionOneTwo = "g4e4") Or (positionOneTwo = "g4f4") Or (positionOneTwo = "g4a4") Or (positionOneTwo = "g4h4") Or (positionOneTwo = "g4i4") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheH4Move()
        If (positionOneTwo = "h4h1") Or (positionOneTwo = "h4h3") Or (positionOneTwo = "h4h2") Or (positionOneTwo = "h4h5") Or (positionOneTwo = "h4h6") Or (positionOneTwo = "h4h7") Or (positionOneTwo = "h4h8") Or (positionOneTwo = "h4h9") Or (positionOneTwo = "h4h10") Or (positionOneTwo = "h4b4") Or (positionOneTwo = "h4c4") Or (positionOneTwo = "h4d4") Or (positionOneTwo = "h4e4") Or (positionOneTwo = "h4f4") Or (positionOneTwo = "h4g4") Or (positionOneTwo = "h4a4") Or (positionOneTwo = "h4i4") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheI4Move()
        If (positionOneTwo = "i4i1") Or (positionOneTwo = "i4i3") Or (positionOneTwo = "i4i2") Or (positionOneTwo = "i4i5") Or (positionOneTwo = "i4i6") Or (positionOneTwo = "i4i7") Or (positionOneTwo = "i4i8") Or (positionOneTwo = "i4i9") Or (positionOneTwo = "i4i10") Or (positionOneTwo = "i4b4") Or (positionOneTwo = "i4c4") Or (positionOneTwo = "i4d4") Or (positionOneTwo = "i4e4") Or (positionOneTwo = "i4f4") Or (positionOneTwo = "i4g4") Or (positionOneTwo = "i4h4") Or (positionOneTwo = "i4a4") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub

    Public Sub checkCheA5Move()
        If (positionOneTwo = "a5a1") Or (positionOneTwo = "a5a3") Or (positionOneTwo = "a5a4") Or (positionOneTwo = "a5a2") Or (positionOneTwo = "a5a6") Or (positionOneTwo = "a5a7") Or (positionOneTwo = "a5a8") Or (positionOneTwo = "a5a9") Or (positionOneTwo = "a5a10") Or (positionOneTwo = "a5b5") Or (positionOneTwo = "a5c5") Or (positionOneTwo = "a5d5") Or (positionOneTwo = "a5e5") Or (positionOneTwo = "a5f5") Or (positionOneTwo = "a5g5") Or (positionOneTwo = "a5h5") Or (positionOneTwo = "a5i5") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheB5Move()
        If (positionOneTwo = "b5b1") Or (positionOneTwo = "b5b3") Or (positionOneTwo = "b5b4") Or (positionOneTwo = "b5b2") Or (positionOneTwo = "b5b6") Or (positionOneTwo = "b5b7") Or (positionOneTwo = "b5b8") Or (positionOneTwo = "b5b9") Or (positionOneTwo = "b5b10") Or (positionOneTwo = "b5a5") Or (positionOneTwo = "b5c5") Or (positionOneTwo = "b5d5") Or (positionOneTwo = "b5e5") Or (positionOneTwo = "b5f5") Or (positionOneTwo = "b5g5") Or (positionOneTwo = "b5h5") Or (positionOneTwo = "b5i5") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheC5Move()
        If (positionOneTwo = "c5c1") Or (positionOneTwo = "c5c3") Or (positionOneTwo = "c5c4") Or (positionOneTwo = "c5c2") Or (positionOneTwo = "c5c6") Or (positionOneTwo = "c5c7") Or (positionOneTwo = "c5c8") Or (positionOneTwo = "c5c9") Or (positionOneTwo = "c5c10") Or (positionOneTwo = "c5b5") Or (positionOneTwo = "c5a5") Or (positionOneTwo = "c5d5") Or (positionOneTwo = "c5e5") Or (positionOneTwo = "c5f5") Or (positionOneTwo = "c5g5") Or (positionOneTwo = "c5h5") Or (positionOneTwo = "c5i5") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheD5Move()
        If (positionOneTwo = "d5d1") Or (positionOneTwo = "d5d3") Or (positionOneTwo = "d5d4") Or (positionOneTwo = "d5d2") Or (positionOneTwo = "d5d6") Or (positionOneTwo = "d5d7") Or (positionOneTwo = "d5d8") Or (positionOneTwo = "d5d9") Or (positionOneTwo = "d5d10") Or (positionOneTwo = "d5b5") Or (positionOneTwo = "d5c5") Or (positionOneTwo = "d5a5") Or (positionOneTwo = "d5e5") Or (positionOneTwo = "d5f5") Or (positionOneTwo = "d5g5") Or (positionOneTwo = "d5h5") Or (positionOneTwo = "d5i5") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheE5Move()
        If (positionOneTwo = "e5e1") Or (positionOneTwo = "e5e3") Or (positionOneTwo = "e5e4") Or (positionOneTwo = "e5e2") Or (positionOneTwo = "e5e6") Or (positionOneTwo = "e5e7") Or (positionOneTwo = "e5e8") Or (positionOneTwo = "e5e9") Or (positionOneTwo = "e5e10") Or (positionOneTwo = "e5b5") Or (positionOneTwo = "e5c5") Or (positionOneTwo = "e5d5") Or (positionOneTwo = "e5a5") Or (positionOneTwo = "e5f5") Or (positionOneTwo = "e5g5") Or (positionOneTwo = "e5h5") Or (positionOneTwo = "e5i5") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheF5Move()
        If (positionOneTwo = "f5f1") Or (positionOneTwo = "f5f3") Or (positionOneTwo = "f5f4") Or (positionOneTwo = "f5f2") Or (positionOneTwo = "f5f6") Or (positionOneTwo = "f5f7") Or (positionOneTwo = "f5f8") Or (positionOneTwo = "f5f9") Or (positionOneTwo = "f5f10") Or (positionOneTwo = "f5b5") Or (positionOneTwo = "f5c5") Or (positionOneTwo = "f5d5") Or (positionOneTwo = "f5e5") Or (positionOneTwo = "f5a5") Or (positionOneTwo = "f5g5") Or (positionOneTwo = "f5h5") Or (positionOneTwo = "f5i5") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheG5Move()
        If (positionOneTwo = "g5g1") Or (positionOneTwo = "g5g3") Or (positionOneTwo = "g5g4") Or (positionOneTwo = "g5g2") Or (positionOneTwo = "g5g6") Or (positionOneTwo = "g5g7") Or (positionOneTwo = "g5g8") Or (positionOneTwo = "g5g9") Or (positionOneTwo = "g5g10") Or (positionOneTwo = "g5b5") Or (positionOneTwo = "g5c5") Or (positionOneTwo = "g5d5") Or (positionOneTwo = "g5e5") Or (positionOneTwo = "g5f5") Or (positionOneTwo = "g5a5") Or (positionOneTwo = "g5h5") Or (positionOneTwo = "g5i5") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheH5Move()
        If (positionOneTwo = "h5h1") Or (positionOneTwo = "h5h3") Or (positionOneTwo = "h5h4") Or (positionOneTwo = "h5h2") Or (positionOneTwo = "h5h6") Or (positionOneTwo = "h5h7") Or (positionOneTwo = "h5h8") Or (positionOneTwo = "h5h9") Or (positionOneTwo = "h5h10") Or (positionOneTwo = "h5b5") Or (positionOneTwo = "h5c5") Or (positionOneTwo = "h5d5") Or (positionOneTwo = "h5e5") Or (positionOneTwo = "h5f5") Or (positionOneTwo = "h5g5") Or (positionOneTwo = "h5a5") Or (positionOneTwo = "h5i5") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheI5Move()
        If (positionOneTwo = "i5i1") Or (positionOneTwo = "i5i3") Or (positionOneTwo = "i5i4") Or (positionOneTwo = "i5i2") Or (positionOneTwo = "i5i6") Or (positionOneTwo = "i5i7") Or (positionOneTwo = "i5i8") Or (positionOneTwo = "i5i9") Or (positionOneTwo = "i5i10") Or (positionOneTwo = "i5b5") Or (positionOneTwo = "i5c5") Or (positionOneTwo = "i5d5") Or (positionOneTwo = "i5e5") Or (positionOneTwo = "i5f5") Or (positionOneTwo = "i5g5") Or (positionOneTwo = "i5h5") Or (positionOneTwo = "i5a5") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub

    Public Sub checkCheA6Move()
        If (positionOneTwo = "a6a1") Or (positionOneTwo = "a6a3") Or (positionOneTwo = "a6a4") Or (positionOneTwo = "a6a2") Or (positionOneTwo = "a6a5") Or (positionOneTwo = "a6a7") Or (positionOneTwo = "a6a8") Or (positionOneTwo = "a6a9") Or (positionOneTwo = "a6a10") Or (positionOneTwo = "a6b6") Or (positionOneTwo = "a6c6") Or (positionOneTwo = "a6d6") Or (positionOneTwo = "a6e6") Or (positionOneTwo = "a6f6") Or (positionOneTwo = "a6g6") Or (positionOneTwo = "a6h6") Or (positionOneTwo = "a6i6") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheB6Move()
        If (positionOneTwo = "b6b1") Or (positionOneTwo = "b6b3") Or (positionOneTwo = "b6b4") Or (positionOneTwo = "b6b2") Or (positionOneTwo = "b6b5") Or (positionOneTwo = "b6b7") Or (positionOneTwo = "b6b8") Or (positionOneTwo = "b6b9") Or (positionOneTwo = "b6b10") Or (positionOneTwo = "b6a6") Or (positionOneTwo = "b6c6") Or (positionOneTwo = "b6d6") Or (positionOneTwo = "b6e6") Or (positionOneTwo = "b6f6") Or (positionOneTwo = "b6g6") Or (positionOneTwo = "b6h6") Or (positionOneTwo = "b6i6") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheC6Move()
        If (positionOneTwo = "c6c1") Or (positionOneTwo = "c6c3") Or (positionOneTwo = "c6c4") Or (positionOneTwo = "c6c2") Or (positionOneTwo = "c6c5") Or (positionOneTwo = "c6c7") Or (positionOneTwo = "c6c8") Or (positionOneTwo = "c6c9") Or (positionOneTwo = "c6c10") Or (positionOneTwo = "c6b6") Or (positionOneTwo = "c6a6") Or (positionOneTwo = "c6d6") Or (positionOneTwo = "c6e6") Or (positionOneTwo = "c6f6") Or (positionOneTwo = "c6g6") Or (positionOneTwo = "c6h6") Or (positionOneTwo = "c6i6") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheD6Move()
        If (positionOneTwo = "d6d1") Or (positionOneTwo = "d6d3") Or (positionOneTwo = "d6d4") Or (positionOneTwo = "d6d2") Or (positionOneTwo = "d6d5") Or (positionOneTwo = "d6d7") Or (positionOneTwo = "d6d8") Or (positionOneTwo = "d6d9") Or (positionOneTwo = "d6d10") Or (positionOneTwo = "d6b6") Or (positionOneTwo = "d6c6") Or (positionOneTwo = "d6a6") Or (positionOneTwo = "d6e6") Or (positionOneTwo = "d6f6") Or (positionOneTwo = "d6g6") Or (positionOneTwo = "d6h6") Or (positionOneTwo = "d6i6") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheE6Move()
        If (positionOneTwo = "e6e1") Or (positionOneTwo = "e6e3") Or (positionOneTwo = "e6e4") Or (positionOneTwo = "e6e2") Or (positionOneTwo = "e6e5") Or (positionOneTwo = "e6e7") Or (positionOneTwo = "e6e8") Or (positionOneTwo = "e6e9") Or (positionOneTwo = "e6e10") Or (positionOneTwo = "e6b6") Or (positionOneTwo = "e6c6") Or (positionOneTwo = "e6d6") Or (positionOneTwo = "e6a6") Or (positionOneTwo = "e6f6") Or (positionOneTwo = "e6g6") Or (positionOneTwo = "e6h6") Or (positionOneTwo = "e6i6") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheF6Move()
        If (positionOneTwo = "f6f1") Or (positionOneTwo = "f6f3") Or (positionOneTwo = "f6f4") Or (positionOneTwo = "f6f2") Or (positionOneTwo = "f6f5") Or (positionOneTwo = "f6f7") Or (positionOneTwo = "f6f8") Or (positionOneTwo = "f6f9") Or (positionOneTwo = "f6f10") Or (positionOneTwo = "f6b6") Or (positionOneTwo = "f6c6") Or (positionOneTwo = "f6d6") Or (positionOneTwo = "f6e6") Or (positionOneTwo = "f6a6") Or (positionOneTwo = "f6g6") Or (positionOneTwo = "f6h6") Or (positionOneTwo = "f6i6") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheG6Move()
        If (positionOneTwo = "g6g1") Or (positionOneTwo = "g6g3") Or (positionOneTwo = "g6g4") Or (positionOneTwo = "g6g2") Or (positionOneTwo = "g6g5") Or (positionOneTwo = "g6g7") Or (positionOneTwo = "g6g8") Or (positionOneTwo = "g6g9") Or (positionOneTwo = "g6g10") Or (positionOneTwo = "g6b6") Or (positionOneTwo = "g6c6") Or (positionOneTwo = "g6d6") Or (positionOneTwo = "g6e6") Or (positionOneTwo = "g6f6") Or (positionOneTwo = "g6a6") Or (positionOneTwo = "g6h6") Or (positionOneTwo = "g6i6") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheH6Move()
        If (positionOneTwo = "h6h1") Or (positionOneTwo = "h6h3") Or (positionOneTwo = "h6h4") Or (positionOneTwo = "h6h2") Or (positionOneTwo = "h6h5") Or (positionOneTwo = "h6h7") Or (positionOneTwo = "h6h8") Or (positionOneTwo = "h6h9") Or (positionOneTwo = "h6h10") Or (positionOneTwo = "h6b6") Or (positionOneTwo = "h6c6") Or (positionOneTwo = "h6d6") Or (positionOneTwo = "h6e6") Or (positionOneTwo = "h6f6") Or (positionOneTwo = "h6g6") Or (positionOneTwo = "h6a6") Or (positionOneTwo = "h6i6") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheI6Move()
        If (positionOneTwo = "i6i1") Or (positionOneTwo = "i6i3") Or (positionOneTwo = "i6i4") Or (positionOneTwo = "i6i2") Or (positionOneTwo = "i6i5") Or (positionOneTwo = "i6i7") Or (positionOneTwo = "i6i8") Or (positionOneTwo = "i6i9") Or (positionOneTwo = "i6i10") Or (positionOneTwo = "i6b6") Or (positionOneTwo = "i6c6") Or (positionOneTwo = "i6d6") Or (positionOneTwo = "i6e6") Or (positionOneTwo = "i6f6") Or (positionOneTwo = "i6g6") Or (positionOneTwo = "i6h6") Or (positionOneTwo = "i6a6") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub

    Public Sub checkCheA7Move()
        If (positionOneTwo = "a7a1") Or (positionOneTwo = "a7a3") Or (positionOneTwo = "a7a4") Or (positionOneTwo = "a7a2") Or (positionOneTwo = "a7a5") Or (positionOneTwo = "a7a6") Or (positionOneTwo = "a7a8") Or (positionOneTwo = "a7a9") Or (positionOneTwo = "a7a10") Or (positionOneTwo = "a7b7") Or (positionOneTwo = "a7c7") Or (positionOneTwo = "a7d7") Or (positionOneTwo = "a7e7") Or (positionOneTwo = "a7f7") Or (positionOneTwo = "a7g7") Or (positionOneTwo = "a7h7") Or (positionOneTwo = "a7i7") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheB7Move()
        If (positionOneTwo = "b7b1") Or (positionOneTwo = "b7b3") Or (positionOneTwo = "b7b4") Or (positionOneTwo = "b7b2") Or (positionOneTwo = "b7b5") Or (positionOneTwo = "b7b6") Or (positionOneTwo = "b7b8") Or (positionOneTwo = "b7b9") Or (positionOneTwo = "b7b10") Or (positionOneTwo = "b7a7") Or (positionOneTwo = "b7c7") Or (positionOneTwo = "b7d7") Or (positionOneTwo = "b7e7") Or (positionOneTwo = "b7f7") Or (positionOneTwo = "b7g7") Or (positionOneTwo = "b7h7") Or (positionOneTwo = "b7i7") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheC7Move()
        If (positionOneTwo = "c7c1") Or (positionOneTwo = "c7c3") Or (positionOneTwo = "c7c4") Or (positionOneTwo = "c7c2") Or (positionOneTwo = "c7c5") Or (positionOneTwo = "c7c6") Or (positionOneTwo = "c7c8") Or (positionOneTwo = "c7c9") Or (positionOneTwo = "c7c10") Or (positionOneTwo = "c7b7") Or (positionOneTwo = "c7a7") Or (positionOneTwo = "c7d7") Or (positionOneTwo = "c7e7") Or (positionOneTwo = "c7f7") Or (positionOneTwo = "c7g7") Or (positionOneTwo = "c7h7") Or (positionOneTwo = "c7i7") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheD7Move()
        If (positionOneTwo = "d7d1") Or (positionOneTwo = "d7d3") Or (positionOneTwo = "d7d4") Or (positionOneTwo = "d7d2") Or (positionOneTwo = "d7d5") Or (positionOneTwo = "d7d6") Or (positionOneTwo = "d7d8") Or (positionOneTwo = "d7d9") Or (positionOneTwo = "d7d10") Or (positionOneTwo = "d7b7") Or (positionOneTwo = "d7c7") Or (positionOneTwo = "d7a7") Or (positionOneTwo = "d7e7") Or (positionOneTwo = "d7f7") Or (positionOneTwo = "d7g7") Or (positionOneTwo = "d7h7") Or (positionOneTwo = "d7i7") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheE7Move()
        If (positionOneTwo = "e7e1") Or (positionOneTwo = "e7e3") Or (positionOneTwo = "e7e4") Or (positionOneTwo = "e7e2") Or (positionOneTwo = "e7e5") Or (positionOneTwo = "e7e6") Or (positionOneTwo = "e7e8") Or (positionOneTwo = "e7e9") Or (positionOneTwo = "e7e10") Or (positionOneTwo = "e7b7") Or (positionOneTwo = "e7c7") Or (positionOneTwo = "e7d7") Or (positionOneTwo = "e7a7") Or (positionOneTwo = "e7f7") Or (positionOneTwo = "e7g7") Or (positionOneTwo = "e7h7") Or (positionOneTwo = "e7i7") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheF7Move()
        If (positionOneTwo = "f7f1") Or (positionOneTwo = "f7f3") Or (positionOneTwo = "f7f4") Or (positionOneTwo = "f7f2") Or (positionOneTwo = "f7f5") Or (positionOneTwo = "f7f6") Or (positionOneTwo = "f7f8") Or (positionOneTwo = "f7f9") Or (positionOneTwo = "f7f10") Or (positionOneTwo = "f7b7") Or (positionOneTwo = "f7c7") Or (positionOneTwo = "f7d7") Or (positionOneTwo = "f7e7") Or (positionOneTwo = "f7a7") Or (positionOneTwo = "f7g7") Or (positionOneTwo = "f7h7") Or (positionOneTwo = "f7i7") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheG7Move()
        If (positionOneTwo = "g7g1") Or (positionOneTwo = "g7g3") Or (positionOneTwo = "g7g4") Or (positionOneTwo = "g7g2") Or (positionOneTwo = "g7g5") Or (positionOneTwo = "g7g6") Or (positionOneTwo = "g7g8") Or (positionOneTwo = "g7g9") Or (positionOneTwo = "g7g10") Or (positionOneTwo = "g7b7") Or (positionOneTwo = "g7c7") Or (positionOneTwo = "g7d7") Or (positionOneTwo = "g7e7") Or (positionOneTwo = "g7f7") Or (positionOneTwo = "g7a7") Or (positionOneTwo = "g7h7") Or (positionOneTwo = "g7i7") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheH7Move()
        If (positionOneTwo = "h7h1") Or (positionOneTwo = "h7h3") Or (positionOneTwo = "h7h4") Or (positionOneTwo = "h7h2") Or (positionOneTwo = "h7h5") Or (positionOneTwo = "h7h6") Or (positionOneTwo = "h7h8") Or (positionOneTwo = "h7h9") Or (positionOneTwo = "h7h10") Or (positionOneTwo = "h7b7") Or (positionOneTwo = "h7c7") Or (positionOneTwo = "h7d7") Or (positionOneTwo = "h7e7") Or (positionOneTwo = "h7f7") Or (positionOneTwo = "h7g7") Or (positionOneTwo = "h7a7") Or (positionOneTwo = "h7i7") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheI7Move()
        If (positionOneTwo = "i7i1") Or (positionOneTwo = "i7i3") Or (positionOneTwo = "i7i4") Or (positionOneTwo = "i7i2") Or (positionOneTwo = "i7i5") Or (positionOneTwo = "i7i6") Or (positionOneTwo = "i7i8") Or (positionOneTwo = "i7i9") Or (positionOneTwo = "i7i10") Or (positionOneTwo = "i7b7") Or (positionOneTwo = "i7c7") Or (positionOneTwo = "i7d7") Or (positionOneTwo = "i7e7") Or (positionOneTwo = "i7f7") Or (positionOneTwo = "i7g7") Or (positionOneTwo = "i7h7") Or (positionOneTwo = "i7a7") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub

    Public Sub checkCheA8Move()
        If (positionOneTwo = "a8a1") Or (positionOneTwo = "a8a3") Or (positionOneTwo = "a8a4") Or (positionOneTwo = "a8a2") Or (positionOneTwo = "a8a5") Or (positionOneTwo = "a8a6") Or (positionOneTwo = "a8a7") Or (positionOneTwo = "a8a9") Or (positionOneTwo = "a8a10") Or (positionOneTwo = "a8b8") Or (positionOneTwo = "a8c8") Or (positionOneTwo = "a8d8") Or (positionOneTwo = "a8e8") Or (positionOneTwo = "a8f8") Or (positionOneTwo = "a8g8") Or (positionOneTwo = "a8h8") Or (positionOneTwo = "a8i8") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheB8Move()
        If (positionOneTwo = "b8b1") Or (positionOneTwo = "b8b3") Or (positionOneTwo = "b8b4") Or (positionOneTwo = "b8b2") Or (positionOneTwo = "b8b5") Or (positionOneTwo = "b8b6") Or (positionOneTwo = "b8b7") Or (positionOneTwo = "b8b9") Or (positionOneTwo = "b8b10") Or (positionOneTwo = "b8a8") Or (positionOneTwo = "b8c8") Or (positionOneTwo = "b8d8") Or (positionOneTwo = "b8e8") Or (positionOneTwo = "b8f8") Or (positionOneTwo = "b8g8") Or (positionOneTwo = "b8h8") Or (positionOneTwo = "b8i8") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheC8Move()
        If (positionOneTwo = "c8c1") Or (positionOneTwo = "c8c3") Or (positionOneTwo = "c8c4") Or (positionOneTwo = "c8c2") Or (positionOneTwo = "c8c5") Or (positionOneTwo = "c8c6") Or (positionOneTwo = "c8c7") Or (positionOneTwo = "c8c9") Or (positionOneTwo = "c8c10") Or (positionOneTwo = "c8b8") Or (positionOneTwo = "c8a8") Or (positionOneTwo = "c8d8") Or (positionOneTwo = "c8e8") Or (positionOneTwo = "c8f8") Or (positionOneTwo = "c8g8") Or (positionOneTwo = "c8h8") Or (positionOneTwo = "c8i8") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheD8Move()
        If (positionOneTwo = "d8d1") Or (positionOneTwo = "d8d3") Or (positionOneTwo = "d8d4") Or (positionOneTwo = "d8d2") Or (positionOneTwo = "d8d5") Or (positionOneTwo = "d8d6") Or (positionOneTwo = "d8d7") Or (positionOneTwo = "d8d9") Or (positionOneTwo = "d8d10") Or (positionOneTwo = "d8b8") Or (positionOneTwo = "d8c8") Or (positionOneTwo = "d8a8") Or (positionOneTwo = "d8e8") Or (positionOneTwo = "d8f8") Or (positionOneTwo = "d8g8") Or (positionOneTwo = "d8h8") Or (positionOneTwo = "d8i8") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheE8Move()
        If (positionOneTwo = "e8e1") Or (positionOneTwo = "e8e3") Or (positionOneTwo = "e8e4") Or (positionOneTwo = "e8e2") Or (positionOneTwo = "e8e5") Or (positionOneTwo = "e8e6") Or (positionOneTwo = "e8e7") Or (positionOneTwo = "e8e9") Or (positionOneTwo = "e8e10") Or (positionOneTwo = "e8b8") Or (positionOneTwo = "e8c8") Or (positionOneTwo = "e8d8") Or (positionOneTwo = "e8a8") Or (positionOneTwo = "e8f8") Or (positionOneTwo = "e8g8") Or (positionOneTwo = "e8h8") Or (positionOneTwo = "e8i8") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheF8Move()
        If (positionOneTwo = "f8f1") Or (positionOneTwo = "f8f3") Or (positionOneTwo = "f8f4") Or (positionOneTwo = "f8f2") Or (positionOneTwo = "f8f5") Or (positionOneTwo = "f8f6") Or (positionOneTwo = "f8f7") Or (positionOneTwo = "f8f9") Or (positionOneTwo = "f8f10") Or (positionOneTwo = "f8b8") Or (positionOneTwo = "f8c8") Or (positionOneTwo = "f8d8") Or (positionOneTwo = "f8e8") Or (positionOneTwo = "f8a8") Or (positionOneTwo = "f8g8") Or (positionOneTwo = "f8h8") Or (positionOneTwo = "f8i8") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheG8Move()
        If (positionOneTwo = "g8g1") Or (positionOneTwo = "g8g3") Or (positionOneTwo = "g8g4") Or (positionOneTwo = "g8g2") Or (positionOneTwo = "g8g5") Or (positionOneTwo = "g8g6") Or (positionOneTwo = "g8g7") Or (positionOneTwo = "g8g9") Or (positionOneTwo = "g8g10") Or (positionOneTwo = "g8b8") Or (positionOneTwo = "g8c8") Or (positionOneTwo = "g8d8") Or (positionOneTwo = "g8e8") Or (positionOneTwo = "g8f8") Or (positionOneTwo = "g8a8") Or (positionOneTwo = "g8h8") Or (positionOneTwo = "g8i8") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheH8Move()
        If (positionOneTwo = "h8h1") Or (positionOneTwo = "h8h3") Or (positionOneTwo = "h8h4") Or (positionOneTwo = "h8h2") Or (positionOneTwo = "h8h5") Or (positionOneTwo = "h8h6") Or (positionOneTwo = "h8h7") Or (positionOneTwo = "h8h9") Or (positionOneTwo = "h8h10") Or (positionOneTwo = "h8b8") Or (positionOneTwo = "h8c8") Or (positionOneTwo = "h8d8") Or (positionOneTwo = "h8e8") Or (positionOneTwo = "h8f8") Or (positionOneTwo = "h8g8") Or (positionOneTwo = "h8a8") Or (positionOneTwo = "h8i8") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheI8Move()
        If (positionOneTwo = "i8i1") Or (positionOneTwo = "i8i3") Or (positionOneTwo = "i8i4") Or (positionOneTwo = "i8i2") Or (positionOneTwo = "i8i5") Or (positionOneTwo = "i8i6") Or (positionOneTwo = "i8i7") Or (positionOneTwo = "i8i9") Or (positionOneTwo = "i8i10") Or (positionOneTwo = "i8b8") Or (positionOneTwo = "i8c8") Or (positionOneTwo = "i8d8") Or (positionOneTwo = "i8e8") Or (positionOneTwo = "i8f8") Or (positionOneTwo = "i8g8") Or (positionOneTwo = "i8h8") Or (positionOneTwo = "i8a8") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub

    Public Sub checkCheA9Move()
        If (positionOneTwo = "a9a1") Or (positionOneTwo = "a9a3") Or (positionOneTwo = "a9a4") Or (positionOneTwo = "a9a2") Or (positionOneTwo = "a9a5") Or (positionOneTwo = "a9a6") Or (positionOneTwo = "a9a7") Or (positionOneTwo = "a9a8") Or (positionOneTwo = "a9a10") Or (positionOneTwo = "a9b9") Or (positionOneTwo = "a9c9") Or (positionOneTwo = "a9d9") Or (positionOneTwo = "a9e9") Or (positionOneTwo = "a9f9") Or (positionOneTwo = "a9g9") Or (positionOneTwo = "a9h9") Or (positionOneTwo = "a9i9") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheB9Move()
        If (positionOneTwo = "b9b1") Or (positionOneTwo = "b9b3") Or (positionOneTwo = "b9b4") Or (positionOneTwo = "b9b2") Or (positionOneTwo = "b9b5") Or (positionOneTwo = "b9b6") Or (positionOneTwo = "b9b7") Or (positionOneTwo = "b9b8") Or (positionOneTwo = "b9b10") Or (positionOneTwo = "b9a9") Or (positionOneTwo = "b9c9") Or (positionOneTwo = "b9d9") Or (positionOneTwo = "b9e9") Or (positionOneTwo = "b9f9") Or (positionOneTwo = "b9g9") Or (positionOneTwo = "b9h9") Or (positionOneTwo = "b9i9") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheC9Move()
        If (positionOneTwo = "c9c1") Or (positionOneTwo = "c9c3") Or (positionOneTwo = "c9c4") Or (positionOneTwo = "c9c2") Or (positionOneTwo = "c9c5") Or (positionOneTwo = "c9c6") Or (positionOneTwo = "c9c7") Or (positionOneTwo = "c9c8") Or (positionOneTwo = "c9c10") Or (positionOneTwo = "c9b9") Or (positionOneTwo = "c9a9") Or (positionOneTwo = "c9d9") Or (positionOneTwo = "c9e9") Or (positionOneTwo = "c9f9") Or (positionOneTwo = "c9g9") Or (positionOneTwo = "c9h9") Or (positionOneTwo = "c9i9") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheD9Move()
        If (positionOneTwo = "d9d1") Or (positionOneTwo = "d9d3") Or (positionOneTwo = "d9d4") Or (positionOneTwo = "d9d2") Or (positionOneTwo = "d9d5") Or (positionOneTwo = "d9d6") Or (positionOneTwo = "d9d7") Or (positionOneTwo = "d9d8") Or (positionOneTwo = "d9d10") Or (positionOneTwo = "d9b9") Or (positionOneTwo = "d9c9") Or (positionOneTwo = "d9a9") Or (positionOneTwo = "d9e9") Or (positionOneTwo = "d9f9") Or (positionOneTwo = "d9g9") Or (positionOneTwo = "d9h9") Or (positionOneTwo = "d9i9") Then
            moveBool = True
        Else
            'move not allow
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheE9Move()
        If (positionOneTwo = "e9e1") Or (positionOneTwo = "e9e3") Or (positionOneTwo = "e9e4") Or (positionOneTwo = "e9e2") Or (positionOneTwo = "e9e5") Or (positionOneTwo = "e9e6") Or (positionOneTwo = "e9e7") Or (positionOneTwo = "e9e8") Or (positionOneTwo = "e9e10") Or (positionOneTwo = "e9b9") Or (positionOneTwo = "e9c9") Or (positionOneTwo = "e9d9") Or (positionOneTwo = "e9a9") Or (positionOneTwo = "e9f9") Or (positionOneTwo = "e9g9") Or (positionOneTwo = "e9h9") Or (positionOneTwo = "e9i9") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheF9Move()
        If (positionOneTwo = "f9f1") Or (positionOneTwo = "f9f3") Or (positionOneTwo = "f9f4") Or (positionOneTwo = "f9f2") Or (positionOneTwo = "f9f5") Or (positionOneTwo = "f9f6") Or (positionOneTwo = "f9f7") Or (positionOneTwo = "f9f8") Or (positionOneTwo = "f9f10") Or (positionOneTwo = "f9b9") Or (positionOneTwo = "f9c9") Or (positionOneTwo = "f9d9") Or (positionOneTwo = "f9e9") Or (positionOneTwo = "f9a9") Or (positionOneTwo = "f9g9") Or (positionOneTwo = "f9h9") Or (positionOneTwo = "f9i9") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheG9Move()
        If (positionOneTwo = "g9g1") Or (positionOneTwo = "g9g3") Or (positionOneTwo = "g9g4") Or (positionOneTwo = "g9g2") Or (positionOneTwo = "g9g5") Or (positionOneTwo = "g9g6") Or (positionOneTwo = "g9g7") Or (positionOneTwo = "g9g8") Or (positionOneTwo = "g9g10") Or (positionOneTwo = "g9b9") Or (positionOneTwo = "g9c9") Or (positionOneTwo = "g9d9") Or (positionOneTwo = "g9e9") Or (positionOneTwo = "g9f9") Or (positionOneTwo = "g9a9") Or (positionOneTwo = "g9h9") Or (positionOneTwo = "g9i9") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheH9Move()
        If (positionOneTwo = "h9h1") Or (positionOneTwo = "h9h3") Or (positionOneTwo = "h9h4") Or (positionOneTwo = "h9h2") Or (positionOneTwo = "h9h5") Or (positionOneTwo = "h9h6") Or (positionOneTwo = "h9h7") Or (positionOneTwo = "h9h8") Or (positionOneTwo = "h9h10") Or (positionOneTwo = "h9b9") Or (positionOneTwo = "h9c9") Or (positionOneTwo = "h9d9") Or (positionOneTwo = "h9e9") Or (positionOneTwo = "h9f9") Or (positionOneTwo = "h9g9") Or (positionOneTwo = "h9a9") Or (positionOneTwo = "h9i9") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheI9Move()
        If (positionOneTwo = "i9i1") Or (positionOneTwo = "i9i3") Or (positionOneTwo = "i9i4") Or (positionOneTwo = "i9i2") Or (positionOneTwo = "i9i5") Or (positionOneTwo = "i9i6") Or (positionOneTwo = "i9i7") Or (positionOneTwo = "i9i8") Or (positionOneTwo = "i9i10") Or (positionOneTwo = "i9b9") Or (positionOneTwo = "i9c9") Or (positionOneTwo = "i9d9") Or (positionOneTwo = "i9e9") Or (positionOneTwo = "i9f9") Or (positionOneTwo = "i9g9") Or (positionOneTwo = "i9h9") Or (positionOneTwo = "i9a9") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub

    Public Sub checkCheA10Move()
        If (positionOneTwo = "a10a1") Or (positionOneTwo = "a10a3") Or (positionOneTwo = "a10a4") Or (positionOneTwo = "a10a2") Or (positionOneTwo = "a10a5") Or (positionOneTwo = "a10a6") Or (positionOneTwo = "a10a7") Or (positionOneTwo = "a10a9") Or (positionOneTwo = "a10a8") Or (positionOneTwo = "a10b10") Or (positionOneTwo = "a10c10") Or (positionOneTwo = "a10d10") Or (positionOneTwo = "a10e10") Or (positionOneTwo = "a10f10") Or (positionOneTwo = "a10g10") Or (positionOneTwo = "a10h10") Or (positionOneTwo = "a10i10") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheB10Move()
        If (positionOneTwo = "b10b1") Or (positionOneTwo = "b10b3") Or (positionOneTwo = "b10b4") Or (positionOneTwo = "b10b2") Or (positionOneTwo = "b10b5") Or (positionOneTwo = "b10b6") Or (positionOneTwo = "b10b7") Or (positionOneTwo = "b10b9") Or (positionOneTwo = "b10b8") Or (positionOneTwo = "b10a10") Or (positionOneTwo = "b10c10") Or (positionOneTwo = "b10d10") Or (positionOneTwo = "b10e10") Or (positionOneTwo = "b10f10") Or (positionOneTwo = "b10g10") Or (positionOneTwo = "b10h10") Or (positionOneTwo = "b10i10") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheC10Move()
        If (positionOneTwo = "c10c1") Or (positionOneTwo = "c10c3") Or (positionOneTwo = "c10c4") Or (positionOneTwo = "c10c2") Or (positionOneTwo = "c10c5") Or (positionOneTwo = "c10c6") Or (positionOneTwo = "c10c7") Or (positionOneTwo = "c10c9") Or (positionOneTwo = "c10c8") Or (positionOneTwo = "c10b10") Or (positionOneTwo = "c10a10") Or (positionOneTwo = "c10d10") Or (positionOneTwo = "c10e10") Or (positionOneTwo = "c10f10") Or (positionOneTwo = "c10g10") Or (positionOneTwo = "c10h10") Or (positionOneTwo = "c10i10") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheD10Move()
        If (positionOneTwo = "d10d1") Or (positionOneTwo = "d10d3") Or (positionOneTwo = "d10d4") Or (positionOneTwo = "d10d2") Or (positionOneTwo = "d10d5") Or (positionOneTwo = "d10d6") Or (positionOneTwo = "d10d7") Or (positionOneTwo = "d10d9") Or (positionOneTwo = "d10d8") Or (positionOneTwo = "d10b10") Or (positionOneTwo = "d10c10") Or (positionOneTwo = "d10a10") Or (positionOneTwo = "d10e10") Or (positionOneTwo = "d10f10") Or (positionOneTwo = "d10g10") Or (positionOneTwo = "d10h10") Or (positionOneTwo = "d10i10") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheE10Move()
        If (positionOneTwo = "e10e1") Or (positionOneTwo = "e10e3") Or (positionOneTwo = "e10e4") Or (positionOneTwo = "e10e2") Or (positionOneTwo = "e10e5") Or (positionOneTwo = "e10e6") Or (positionOneTwo = "e10e7") Or (positionOneTwo = "e10e9") Or (positionOneTwo = "e10e8") Or (positionOneTwo = "e10b810") Or (positionOneTwo = "e10c10") Or (positionOneTwo = "e10d10") Or (positionOneTwo = "e10a10") Or (positionOneTwo = "e10f10") Or (positionOneTwo = "e10g10") Or (positionOneTwo = "e10h10") Or (positionOneTwo = "e10i10") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheF10Move()
        If (positionOneTwo = "f10f1") Or (positionOneTwo = "f10f3") Or (positionOneTwo = "f10f4") Or (positionOneTwo = "f10f2") Or (positionOneTwo = "f10f5") Or (positionOneTwo = "f10f6") Or (positionOneTwo = "f10f7") Or (positionOneTwo = "f10f9") Or (positionOneTwo = "f10f8") Or (positionOneTwo = "f10b10") Or (positionOneTwo = "f10c10") Or (positionOneTwo = "f10d10") Or (positionOneTwo = "f10e10") Or (positionOneTwo = "f10a10") Or (positionOneTwo = "f10g10") Or (positionOneTwo = "f10h10") Or (positionOneTwo = "f10i10") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheG10Move()
        If (positionOneTwo = "g10g1") Or (positionOneTwo = "g10g3") Or (positionOneTwo = "g10g4") Or (positionOneTwo = "g10g2") Or (positionOneTwo = "g10g5") Or (positionOneTwo = "g10g6") Or (positionOneTwo = "g10g7") Or (positionOneTwo = "g10g9") Or (positionOneTwo = "g10g8") Or (positionOneTwo = "g10b10") Or (positionOneTwo = "g10c10") Or (positionOneTwo = "g10d10") Or (positionOneTwo = "g10e10") Or (positionOneTwo = "g10f10") Or (positionOneTwo = "g10a10") Or (positionOneTwo = "g10h10") Or (positionOneTwo = "g10i10") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub
    Public Sub checkCheH10Move()
        If (positionOneTwo = "h10h1") Or (positionOneTwo = "h10h3") Or (positionOneTwo = "h10h4") Or (positionOneTwo = "h10h2") Or (positionOneTwo = "h10h5") Or (positionOneTwo = "h10h6") Or (positionOneTwo = "h10h7") Or (positionOneTwo = "h10h9") Or (positionOneTwo = "h10h8") Or (positionOneTwo = "h10b10") Or (positionOneTwo = "h10c10") Or (positionOneTwo = "h10d10") Or (positionOneTwo = "h10e10") Or (positionOneTwo = "h10f10") Or (positionOneTwo = "h10g10") Or (positionOneTwo = "h10a10") Or (positionOneTwo = "h10i10") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkCheI10Move()
        If (positionOneTwo = "i10i1") Or (positionOneTwo = "i10i3") Or (positionOneTwo = "i10i4") Or (positionOneTwo = "i10i2") Or (positionOneTwo = "i10i5") Or (positionOneTwo = "i10i6") Or (positionOneTwo = "108i7") Or (positionOneTwo = "i10i9") Or (positionOneTwo = "i10i8") Or (positionOneTwo = "i10b10") Or (positionOneTwo = "i10c10") Or (positionOneTwo = "i10d10") Or (positionOneTwo = "i10e10") Or (positionOneTwo = "i10f10") Or (positionOneTwo = "i10g10") Or (positionOneTwo = "i10h10") Or (positionOneTwo = "i10a10") Then
            moveBool = True
        Else
            moveBool = False
            MsgBox("Invalid Move", MsgBoxStyle.OkOnly, "Invalid Movement")
        End If
    End Sub

End Module
