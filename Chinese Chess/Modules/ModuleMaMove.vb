' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 01/10/2010 to 28/10/2010
' Descripitons : Chinese Chess V1

Module ModuleMaMove
    Public Sub checkMaA1Move()
        If (positionOneTwo = "a1c2") Or (positionOneTwo = "a1b3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaB1Move()
        If (positionOneTwo = "b1a3") Or (positionOneTwo = "b1c3") Or (positionOneTwo = "b1d2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaC1Move()
        If (positionOneTwo = "c1a2") Or (positionOneTwo = "c1b3") Or (positionOneTwo = "c1d3") Or (positionOneTwo = "c1e2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaD1Move()
        If (positionOneTwo = "d1b2") Or (positionOneTwo = "d1c3") Or (positionOneTwo = "d1e3") Or (positionOneTwo = "d1f2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaE1Move()
        If (positionOneTwo = "e1c2") Or (positionOneTwo = "e1d3") Or (positionOneTwo = "e1f3") Or (positionOneTwo = "e1g2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaF1Move()
        If (positionOneTwo = "f1d2") Or (positionOneTwo = "f1e3") Or (positionOneTwo = "f1g3") Or (positionOneTwo = "f1h2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaG1Move()
        If (positionOneTwo = "g1e2") Or (positionOneTwo = "g1f3") Or (positionOneTwo = "g1h3") Or (positionOneTwo = "g1i2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaH1Move()
        If (positionOneTwo = "h1g3") Or (positionOneTwo = "h1i3") Or (positionOneTwo = "h1f2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaI1Move()
        If (positionOneTwo = "i1g2") Or (positionOneTwo = "i1h3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub

    Public Sub checkMaA2Move()
        If (positionOneTwo = "a2c3") Or (positionOneTwo = "a2b4") Or (positionOneTwo = "a2c1") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaB2Move()
        If (positionOneTwo = "b2a4") Or (positionOneTwo = "b2c4") Or (positionOneTwo = "b2d3") Or (positionOneTwo = "b2d1") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaC2Move()
        If (positionOneTwo = "c2a3") Or (positionOneTwo = "c2b4") Or (positionOneTwo = "c2d4") Or (positionOneTwo = "c2e3") Or (positionOneTwo = "c2e1") Or (positionOneTwo = "c2a1") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaD2Move()
        If (positionOneTwo = "d2b3") Or (positionOneTwo = "d2c4") Or (positionOneTwo = "d2e4") Or (positionOneTwo = "d2f3") Or (positionOneTwo = "d2f1") Or (positionOneTwo = "d2b1") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaE2Move()
        If (positionOneTwo = "e2c3") Or (positionOneTwo = "e2d4") Or (positionOneTwo = "e2f4") Or (positionOneTwo = "e2g3") Or (positionOneTwo = "e2g1") Or (positionOneTwo = "e2c1") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaF2Move()
        If (positionOneTwo = "f2d3") Or (positionOneTwo = "f2e4") Or (positionOneTwo = "f2g4") Or (positionOneTwo = "f2h3") Or (positionOneTwo = "f2h1") Or (positionOneTwo = "f2d1") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaG2Move()
        If (positionOneTwo = "g2e3") Or (positionOneTwo = "g2f4") Or (positionOneTwo = "g2h4") Or (positionOneTwo = "g2i3") Or (positionOneTwo = "g2i1") Or (positionOneTwo = "g2e1") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaH2Move()
        If (positionOneTwo = "h2g4") Or (positionOneTwo = "h2i4") Or (positionOneTwo = "h2f1") Or (positionOneTwo = "h2f3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaI2Move()
        If (positionOneTwo = "i2g3") Or (positionOneTwo = "i2h4") Or (positionOneTwo = "i2g1") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub

    Public Sub checkMaA3Move()
        If (positionOneTwo = "a3c4") Or (positionOneTwo = "a3b5") Or (positionOneTwo = "a3c2") Or (positionOneTwo = "a3b1") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaB3Move()
        If (positionOneTwo = "b3a5") Or (positionOneTwo = "b3c5") Or (positionOneTwo = "b3d4") Or (positionOneTwo = "b3d2") Or (positionOneTwo = "b3c1") Or (positionOneTwo = "b3a1") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaC3Move()
        If (positionOneTwo = "c3a4") Or (positionOneTwo = "c3b5") Or (positionOneTwo = "c3d5") Or (positionOneTwo = "c3e4") Or (positionOneTwo = "c3e2") Or (positionOneTwo = "c3d1") Or (positionOneTwo = "c3b1") Or (positionOneTwo = "c3a2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaD3Move()
        If (positionOneTwo = "d3b4") Or (positionOneTwo = "d3c5") Or (positionOneTwo = "d3e5") Or (positionOneTwo = "d3f4") Or (positionOneTwo = "d3f2") Or (positionOneTwo = "d3e1") Or (positionOneTwo = "d3c1") Or (positionOneTwo = "d3b2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaE3Move()
        If (positionOneTwo = "e3c4") Or (positionOneTwo = "e3d5") Or (positionOneTwo = "e3f5") Or (positionOneTwo = "e3g4") Or (positionOneTwo = "e3g2") Or (positionOneTwo = "e3f1") Or (positionOneTwo = "e3d1") Or (positionOneTwo = "e3c2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaF3Move()
        If (positionOneTwo = "f3d4") Or (positionOneTwo = "f3e5") Or (positionOneTwo = "f3g5") Or (positionOneTwo = "f3h4") Or (positionOneTwo = "f3h2") Or (positionOneTwo = "f3g1") Or (positionOneTwo = "f3e1") Or (positionOneTwo = "f3d2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaG3Move()
        If (positionOneTwo = "g3e4") Or (positionOneTwo = "g3f5") Or (positionOneTwo = "g3h5") Or (positionOneTwo = "g3i4") Or (positionOneTwo = "g3i2") Or (positionOneTwo = "g3h1") Or (positionOneTwo = "g3f1") Or (positionOneTwo = "g3e2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaH3Move()
        If (positionOneTwo = "h3g5") Or (positionOneTwo = "h3i5") Or (positionOneTwo = "h3i1") Or (positionOneTwo = "h3g1") Or (positionOneTwo = "h3f2") Or (positionOneTwo = "h3f4") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaI3Move()
        If (positionOneTwo = "i3g4") Or (positionOneTwo = "i3h5") Or (positionOneTwo = "i3h1") Or (positionOneTwo = "i3g2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub

    Public Sub checkMaA4Move()
        If (positionOneTwo = "a4c5") Or (positionOneTwo = "a4b6") Or (positionOneTwo = "a4c3") Or (positionOneTwo = "a4b2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaB4Move()
        If (positionOneTwo = "b4a6") Or (positionOneTwo = "b4c6") Or (positionOneTwo = "b4d5") Or (positionOneTwo = "b4d3") Or (positionOneTwo = "b4c2") Or (positionOneTwo = "b4a2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaC4Move()
        If (positionOneTwo = "c4a5") Or (positionOneTwo = "c4b6") Or (positionOneTwo = "c4d6") Or (positionOneTwo = "c4e5") Or (positionOneTwo = "c4e3") Or (positionOneTwo = "c4d2") Or (positionOneTwo = "c4b2") Or (positionOneTwo = "c4a3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaD4Move()
        If (positionOneTwo = "d4b5") Or (positionOneTwo = "d4c6") Or (positionOneTwo = "d4e6") Or (positionOneTwo = "d4f5") Or (positionOneTwo = "d4f3") Or (positionOneTwo = "d4e2") Or (positionOneTwo = "d4c2") Or (positionOneTwo = "d4b3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaE4Move()
        If (positionOneTwo = "e4c5") Or (positionOneTwo = "e4d6") Or (positionOneTwo = "e4f6") Or (positionOneTwo = "e4g5") Or (positionOneTwo = "e4g3") Or (positionOneTwo = "e4f2") Or (positionOneTwo = "e4d2") Or (positionOneTwo = "e4c3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaF4Move()
        If (positionOneTwo = "f4d5") Or (positionOneTwo = "f4e6") Or (positionOneTwo = "f4g6") Or (positionOneTwo = "f4h5") Or (positionOneTwo = "f4h3") Or (positionOneTwo = "f4g2") Or (positionOneTwo = "f4e2") Or (positionOneTwo = "f4d3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaG4Move()
        If (positionOneTwo = "g4e5") Or (positionOneTwo = "g4f6") Or (positionOneTwo = "g4h6") Or (positionOneTwo = "g4i5") Or (positionOneTwo = "g4i3") Or (positionOneTwo = "g4h2") Or (positionOneTwo = "g4f2") Or (positionOneTwo = "g4e3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaH4Move()
        If (positionOneTwo = "h4g6") Or (positionOneTwo = "h4i6") Or (positionOneTwo = "h4i2") Or (positionOneTwo = "h4g2") Or (positionOneTwo = "h4f3") Or (positionOneTwo = "h4f5") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaI4Move()
        If (positionOneTwo = "i4g5") Or (positionOneTwo = "i4h6") Or (positionOneTwo = "i4h2") Or (positionOneTwo = "i4g3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub

    Public Sub checkMaA5Move()
        If (positionOneTwo = "a5c6") Or (positionOneTwo = "a5b7") Or (positionOneTwo = "a5c4") Or (positionOneTwo = "a5b3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaB5Move()
        If (positionOneTwo = "b5a7") Or (positionOneTwo = "b5c7") Or (positionOneTwo = "b5d6") Or (positionOneTwo = "b5d4") Or (positionOneTwo = "b5c3") Or (positionOneTwo = "b5a3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaC5Move()
        If (positionOneTwo = "c5a6") Or (positionOneTwo = "c5b7") Or (positionOneTwo = "c5d7") Or (positionOneTwo = "c5e6") Or (positionOneTwo = "c5e4") Or (positionOneTwo = "c5d3") Or (positionOneTwo = "c5b3") Or (positionOneTwo = "c5a4") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaD5Move()
        If (positionOneTwo = "d5b6") Or (positionOneTwo = "d5c7") Or (positionOneTwo = "d5e7") Or (positionOneTwo = "d5f6") Or (positionOneTwo = "d5f4") Or (positionOneTwo = "d5e3") Or (positionOneTwo = "d5c3") Or (positionOneTwo = "d5b4") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaE5Move()
        If (positionOneTwo = "e5c6") Or (positionOneTwo = "e5d7") Or (positionOneTwo = "e5f7") Or (positionOneTwo = "e5g6") Or (positionOneTwo = "e5g4") Or (positionOneTwo = "e5f3") Or (positionOneTwo = "e5d3") Or (positionOneTwo = "e5c4") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaF5Move()
        If (positionOneTwo = "f5d6") Or (positionOneTwo = "f5e7") Or (positionOneTwo = "f5g7") Or (positionOneTwo = "f5h6") Or (positionOneTwo = "f5h4") Or (positionOneTwo = "f5g3") Or (positionOneTwo = "f5e3") Or (positionOneTwo = "f5d4") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaG5Move()
        If (positionOneTwo = "g5e6") Or (positionOneTwo = "g5f7") Or (positionOneTwo = "g5h7") Or (positionOneTwo = "g5i6") Or (positionOneTwo = "g5i4") Or (positionOneTwo = "g5h3") Or (positionOneTwo = "g5f3") Or (positionOneTwo = "g5e4") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaH5Move()
        If (positionOneTwo = "h5g7") Or (positionOneTwo = "h5i7") Or (positionOneTwo = "h5i3") Or (positionOneTwo = "h5g3") Or (positionOneTwo = "h5f4") Or (positionOneTwo = "h5f6") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaI5Move()
        If (positionOneTwo = "i5g6") Or (positionOneTwo = "i5h7") Or (positionOneTwo = "i5h3") Or (positionOneTwo = "i5g4") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub

    Public Sub checkMaA6Move()
        If (positionOneTwo = "a6c7") Or (positionOneTwo = "a6b8") Or (positionOneTwo = "a6c5") Or (positionOneTwo = "a6b4") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaB6Move()
        If (positionOneTwo = "b6a8") Or (positionOneTwo = "b6c8") Or (positionOneTwo = "b6d7") Or (positionOneTwo = "b6d5") Or (positionOneTwo = "b6c4") Or (positionOneTwo = "b6a4") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaC6Move()
        If (positionOneTwo = "c6a7") Or (positionOneTwo = "c6b8") Or (positionOneTwo = "c6d8") Or (positionOneTwo = "c6e7") Or (positionOneTwo = "c6e5") Or (positionOneTwo = "c6d4") Or (positionOneTwo = "c6b4") Or (positionOneTwo = "c6a5") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaD6Move()
        If (positionOneTwo = "d6b7") Or (positionOneTwo = "d6c8") Or (positionOneTwo = "d6e8") Or (positionOneTwo = "d6f7") Or (positionOneTwo = "d6f5") Or (positionOneTwo = "d6e4") Or (positionOneTwo = "d6c4") Or (positionOneTwo = "d6b5") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaE6Move()
        If (positionOneTwo = "e6c7") Or (positionOneTwo = "e6d8") Or (positionOneTwo = "e6f8") Or (positionOneTwo = "e6g7") Or (positionOneTwo = "e6g5") Or (positionOneTwo = "e6f4") Or (positionOneTwo = "e6d4") Or (positionOneTwo = "e6c5") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaF6Move()
        If (positionOneTwo = "f6d7") Or (positionOneTwo = "f6e8") Or (positionOneTwo = "f6g8") Or (positionOneTwo = "f6h7") Or (positionOneTwo = "f6h5") Or (positionOneTwo = "f6g4") Or (positionOneTwo = "f6e4") Or (positionOneTwo = "f6d5") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaG6Move()
        If (positionOneTwo = "g6e7") Or (positionOneTwo = "g6f8") Or (positionOneTwo = "g6h8") Or (positionOneTwo = "g6i7") Or (positionOneTwo = "g6i5") Or (positionOneTwo = "g6h4") Or (positionOneTwo = "g6f4") Or (positionOneTwo = "g6e5") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaH6Move()
        If (positionOneTwo = "h6g8") Or (positionOneTwo = "h6i8") Or (positionOneTwo = "h6i4") Or (positionOneTwo = "h6g4") Or (positionOneTwo = "h6f5") Or (positionOneTwo = "h6f7") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaI6Move()
        If (positionOneTwo = "i6g7") Or (positionOneTwo = "i6h8") Or (positionOneTwo = "i6h4") Or (positionOneTwo = "i6g5") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub

    Public Sub checkMaA7Move()
        If (positionOneTwo = "a7c8") Or (positionOneTwo = "a7b9") Or (positionOneTwo = "a7c6") Or (positionOneTwo = "a7b5") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaB7Move()
        If (positionOneTwo = "b7a9") Or (positionOneTwo = "b7c9") Or (positionOneTwo = "b7d8") Or (positionOneTwo = "b7d6") Or (positionOneTwo = "b7c5") Or (positionOneTwo = "b7a5") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaC7Move()
        If (positionOneTwo = "c7a8") Or (positionOneTwo = "c7b9") Or (positionOneTwo = "c7d9") Or (positionOneTwo = "c7e8") Or (positionOneTwo = "c7e6") Or (positionOneTwo = "c7d5") Or (positionOneTwo = "c7b5") Or (positionOneTwo = "c7a6") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaD7Move()
        If (positionOneTwo = "d7b8") Or (positionOneTwo = "d7c9") Or (positionOneTwo = "d7e9") Or (positionOneTwo = "d7f8") Or (positionOneTwo = "d7f6") Or (positionOneTwo = "d7e5") Or (positionOneTwo = "d7c5") Or (positionOneTwo = "d7b6") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaE7Move()
        If (positionOneTwo = "e7c8") Or (positionOneTwo = "e7d9") Or (positionOneTwo = "e7f9") Or (positionOneTwo = "e7g8") Or (positionOneTwo = "e7g6") Or (positionOneTwo = "e7f5") Or (positionOneTwo = "e7d5") Or (positionOneTwo = "e7c6") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaF7Move()
        If (positionOneTwo = "f7d8") Or (positionOneTwo = "f7e9") Or (positionOneTwo = "f7g9") Or (positionOneTwo = "f7h8") Or (positionOneTwo = "f7h6") Or (positionOneTwo = "f7g5") Or (positionOneTwo = "f7e5") Or (positionOneTwo = "f7d6") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaG7Move()
        If (positionOneTwo = "g7e8") Or (positionOneTwo = "g7f9") Or (positionOneTwo = "g7h9") Or (positionOneTwo = "g7i8") Or (positionOneTwo = "g7i6") Or (positionOneTwo = "g7h5") Or (positionOneTwo = "g7f5") Or (positionOneTwo = "g7e6") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaH7Move()
        If (positionOneTwo = "h7g9") Or (positionOneTwo = "h7i9") Or (positionOneTwo = "h7i5") Or (positionOneTwo = "h7g5") Or (positionOneTwo = "h7f6") Or (positionOneTwo = "h7f8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaI7Move()
        If (positionOneTwo = "i7g8") Or (positionOneTwo = "i7h9") Or (positionOneTwo = "i7h5") Or (positionOneTwo = "i7g6") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub

    Public Sub checkMaA8Move()
        If (positionOneTwo = "a8c9") Or (positionOneTwo = "a8b10") Or (positionOneTwo = "a8c7") Or (positionOneTwo = "a8b6") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaB8Move()
        If (positionOneTwo = "b8a10") Or (positionOneTwo = "b8c10") Or (positionOneTwo = "b8d9") Or (positionOneTwo = "b8d7") Or (positionOneTwo = "b8c6") Or (positionOneTwo = "b8a6") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaC8Move()
        If (positionOneTwo = "c8a9") Or (positionOneTwo = "c8b10") Or (positionOneTwo = "c8d10") Or (positionOneTwo = "c8e9") Or (positionOneTwo = "c8e7") Or (positionOneTwo = "c8d6") Or (positionOneTwo = "c8b6") Or (positionOneTwo = "c8a7") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaD8Move()
        If (positionOneTwo = "d8b9") Or (positionOneTwo = "d8c10") Or (positionOneTwo = "d8e10") Or (positionOneTwo = "d8f9") Or (positionOneTwo = "d8f7") Or (positionOneTwo = "d8e6") Or (positionOneTwo = "d8c6") Or (positionOneTwo = "d8b7") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaE8Move()
        If (positionOneTwo = "e8c9") Or (positionOneTwo = "e8d10") Or (positionOneTwo = "e8f10") Or (positionOneTwo = "e8g9") Or (positionOneTwo = "e8g7") Or (positionOneTwo = "e8f6") Or (positionOneTwo = "e8d6") Or (positionOneTwo = "e8c7") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaF8Move()
        If (positionOneTwo = "f8d9") Or (positionOneTwo = "f8e10") Or (positionOneTwo = "f8g10") Or (positionOneTwo = "f8h9") Or (positionOneTwo = "f8h7") Or (positionOneTwo = "f8g6") Or (positionOneTwo = "f8e6") Or (positionOneTwo = "f8d7") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaG8Move()
        If (positionOneTwo = "g8e9") Or (positionOneTwo = "g8f10") Or (positionOneTwo = "g8h10") Or (positionOneTwo = "g8i9") Or (positionOneTwo = "g8i7") Or (positionOneTwo = "g8h6") Or (positionOneTwo = "g8f6") Or (positionOneTwo = "g8e7") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaH8Move()
        If (positionOneTwo = "h8g10") Or (positionOneTwo = "h8i10") Or (positionOneTwo = "h8i6") Or (positionOneTwo = "h8g6") Or (positionOneTwo = "h8f7") Or (positionOneTwo = "h8f9") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaI8Move()
        If (positionOneTwo = "i8g9") Or (positionOneTwo = "i8h10") Or (positionOneTwo = "i8h6") Or (positionOneTwo = "i8g7") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub

    Public Sub checkMaA9Move()
        If (positionOneTwo = "a9c10") Or (positionOneTwo = "a9c8") Or (positionOneTwo = "a9b7") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaB9Move()
        If (positionOneTwo = "b9d10") Or (positionOneTwo = "b9d8") Or (positionOneTwo = "b9c7") Or (positionOneTwo = "b9a7") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaC9Move()
        If (positionOneTwo = "c9a10") Or (positionOneTwo = "c9e10") Or (positionOneTwo = "c9e8") Or (positionOneTwo = "c9d7") Or (positionOneTwo = "c9b7") Or (positionOneTwo = "c9a8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaD9Move()
        If (positionOneTwo = "d9b10") Or (positionOneTwo = "d9f10") Or (positionOneTwo = "d9f8") Or (positionOneTwo = "d9e7") Or (positionOneTwo = "d9c7") Or (positionOneTwo = "d9b8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaE9Move()
        If (positionOneTwo = "e9c10") Or (positionOneTwo = "e9g10") Or (positionOneTwo = "e9g8") Or (positionOneTwo = "e9f7") Or (positionOneTwo = "e9d7") Or (positionOneTwo = "e9c8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaF9Move()
        If (positionOneTwo = "f9d10") Or (positionOneTwo = "f9h10") Or (positionOneTwo = "f9h8") Or (positionOneTwo = "f9g7") Or (positionOneTwo = "f9e7") Or (positionOneTwo = "f9d8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaG9Move()
        If (positionOneTwo = "g9e10") Or (positionOneTwo = "g9i10") Or (positionOneTwo = "g9i8") Or (positionOneTwo = "g9h7") Or (positionOneTwo = "g9f7") Or (positionOneTwo = "g9e8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaH9Move()
        If (positionOneTwo = "h9i7") Or (positionOneTwo = "h9g7") Or (positionOneTwo = "h9f8") Or (positionOneTwo = "h9f10") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaI9Move()
        If (positionOneTwo = "i9g10") Or (positionOneTwo = "i9h7") Or (positionOneTwo = "i9g8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub

    Public Sub checkMaA10Move()
        If (positionOneTwo = "a10c9") Or (positionOneTwo = "a10b8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaB10Move()
        If (positionOneTwo = "b10d9") Or (positionOneTwo = "b10c8") Or (positionOneTwo = "b10a8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaC10Move()
        If (positionOneTwo = "c10e9") Or (positionOneTwo = "c10d8") Or (positionOneTwo = "c10b8") Or (positionOneTwo = "c10a9") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaD10Move()
        If (positionOneTwo = "d10f9") Or (positionOneTwo = "d10e8") Or (positionOneTwo = "d10c8") Or (positionOneTwo = "d10b9") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaE10Move()
        If (positionOneTwo = "e10g9") Or (positionOneTwo = "e10f8") Or (positionOneTwo = "e10d8") Or (positionOneTwo = "e10c9") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaF10Move()
        If (positionOneTwo = "f10h9") Or (positionOneTwo = "f10g8") Or (positionOneTwo = "f10e8") Or (positionOneTwo = "f10d9") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaG10Move()
        If (positionOneTwo = "g10i9") Or (positionOneTwo = "g10h8") Or (positionOneTwo = "g10f8") Or (positionOneTwo = "g10e9") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaH10Move()
        If (positionOneTwo = "h10i8") Or (positionOneTwo = "h10g8") Or (positionOneTwo = "h10f9") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkMaI10Move()
        If (positionOneTwo = "i10h8") Or (positionOneTwo = "i10g9") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
End Module
