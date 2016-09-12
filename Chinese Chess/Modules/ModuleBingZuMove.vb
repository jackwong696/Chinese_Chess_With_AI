' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 01/10/2010 to 28/10/2010
' Descripitons : Chinese Chess V1

Module ModuleBingZuMove
    Public Sub checkWhiteZuRow7Move()
        If (positionOneTwo = "a7a6") Or (positionOneTwo = "c7c6") Or (positionOneTwo = "e7e6") Or (positionOneTwo = "g7g6") Or (positionOneTwo = "i7i6") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkWhiteZuRow6Move()
        If (positionOneTwo = "a6a5") Or (positionOneTwo = "c6c5") Or (positionOneTwo = "e6e5") Or (positionOneTwo = "g6g5") Or (positionOneTwo = "i6i5") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkWhiteZuRow5Move()
        If (positionOneTwo = "a5a4") Or (positionOneTwo = "a5b5") Or (positionOneTwo = "b5a5") Or (positionOneTwo = "b5b4") Or (positionOneTwo = "b5c5") Or (positionOneTwo = "c5c4") Or (positionOneTwo = "c5b5") Or (positionOneTwo = "c5d5") Or (positionOneTwo = "d5d4") Or (positionOneTwo = "d5c5") Or (positionOneTwo = "d5e5") Or (positionOneTwo = "e5d5") Or (positionOneTwo = "e5f5") Or (positionOneTwo = "e5e4") Or (positionOneTwo = "f5f4") Or (positionOneTwo = "f5e5") Or (positionOneTwo = "f5g5") Or (positionOneTwo = "g5g4") Or (positionOneTwo = "g5f5") Or (positionOneTwo = "g5h5") Or (positionOneTwo = "h5h4") Or (positionOneTwo = "h5g5") Or (positionOneTwo = "h5i5") Or (positionOneTwo = "i5i4") Or (positionOneTwo = "i5h5") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkWhiteZuRow4Move()
        If (positionOneTwo = "a4a3") Or (positionOneTwo = "a4b4") Or (positionOneTwo = "b4a4") Or (positionOneTwo = "b4b3") Or (positionOneTwo = "b4c4") Or (positionOneTwo = "c4c3") Or (positionOneTwo = "c4b4") Or (positionOneTwo = "c4d4") Or (positionOneTwo = "d4d3") Or (positionOneTwo = "d4c4") Or (positionOneTwo = "d4e4") Or (positionOneTwo = "e4d4") Or (positionOneTwo = "e4f4") Or (positionOneTwo = "e4e3") Or (positionOneTwo = "f4f3") Or (positionOneTwo = "f4e4") Or (positionOneTwo = "f4g4") Or (positionOneTwo = "g4g3") Or (positionOneTwo = "g4f4") Or (positionOneTwo = "g4h4") Or (positionOneTwo = "h4h3") Or (positionOneTwo = "h4g4") Or (positionOneTwo = "h4i4") Or (positionOneTwo = "i4i3") Or (positionOneTwo = "i4h4") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkWhiteZuRow3Move()
        If (positionOneTwo = "a3a2") Or (positionOneTwo = "a3b3") Or (positionOneTwo = "b3a3") Or (positionOneTwo = "b3b2") Or (positionOneTwo = "b3c3") Or (positionOneTwo = "c3c2") Or (positionOneTwo = "c3b3") Or (positionOneTwo = "c3d3") Or (positionOneTwo = "d3d2") Or (positionOneTwo = "d3c3") Or (positionOneTwo = "d3e3") Or (positionOneTwo = "e3d3") Or (positionOneTwo = "e3f3") Or (positionOneTwo = "e3e2") Or (positionOneTwo = "f3f2") Or (positionOneTwo = "f3e3") Or (positionOneTwo = "f3g3") Or (positionOneTwo = "g3g2") Or (positionOneTwo = "g3f3") Or (positionOneTwo = "g3h3") Or (positionOneTwo = "h3h2") Or (positionOneTwo = "h3g3") Or (positionOneTwo = "h3i3") Or (positionOneTwo = "i3i2") Or (positionOneTwo = "i3h3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkWhiteZuRow2Move()
        If (positionOneTwo = "a2a1") Or (positionOneTwo = "a2b2") Or (positionOneTwo = "b2a2") Or (positionOneTwo = "b2b1") Or (positionOneTwo = "b2c2") Or (positionOneTwo = "c2c1") Or (positionOneTwo = "c2b2") Or (positionOneTwo = "c2d2") Or (positionOneTwo = "d2d1") Or (positionOneTwo = "d2c2") Or (positionOneTwo = "d2e2") Or (positionOneTwo = "e2d2") Or (positionOneTwo = "e2f2") Or (positionOneTwo = "e2e1") Or (positionOneTwo = "f2f1") Or (positionOneTwo = "f2e2") Or (positionOneTwo = "f2g2") Or (positionOneTwo = "g2g1") Or (positionOneTwo = "g2f2") Or (positionOneTwo = "g2h2") Or (positionOneTwo = "h2h1") Or (positionOneTwo = "h2g2") Or (positionOneTwo = "h2i2") Or (positionOneTwo = "i2i1") Or (positionOneTwo = "i2h2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkWhiteZuRow1Move()
        If (positionOneTwo = "a1b1") Or (positionOneTwo = "b1a1") Or (positionOneTwo = "b1c1") Or (positionOneTwo = "c1b1") Or (positionOneTwo = "c1d1") Or (positionOneTwo = "d1c1") Or (positionOneTwo = "d1e1") Or (positionOneTwo = "e1d1") Or (positionOneTwo = "e1f1") Or (positionOneTwo = "f1e1") Or (positionOneTwo = "f1g1") Or (positionOneTwo = "g1f1") Or (positionOneTwo = "g1h1") Or (positionOneTwo = "h1g1") Or (positionOneTwo = "h1i1") Or (positionOneTwo = "i1h1") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub

    Public Sub checkBlackBingRow4Move()
        If (positionOneTwo = "a4a5") Or (positionOneTwo = "c4c5") Or (positionOneTwo = "e4e5") Or (positionOneTwo = "g4g5") Or (positionOneTwo = "i4i5") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkBlackBingRow5Move()
        If (positionOneTwo = "a5a6") Or (positionOneTwo = "c5c6") Or (positionOneTwo = "e5e6") Or (positionOneTwo = "g5g6") Or (positionOneTwo = "i5i6") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkBlackBingRow6Move()
        If (positionOneTwo = "a6a7") Or (positionOneTwo = "a6b6") Or (positionOneTwo = "b6b7") Or (positionOneTwo = "b6a6") Or (positionOneTwo = "b6c6") Or (positionOneTwo = "c6c7") Or (positionOneTwo = "c6b6") Or (positionOneTwo = "c6d6") Or (positionOneTwo = "d6d7") Or (positionOneTwo = "d6c6") Or (positionOneTwo = "d6e6") Or (positionOneTwo = "e6e7") Or (positionOneTwo = "e6d6") Or (positionOneTwo = "e6f6") Or (positionOneTwo = "f6f7") Or (positionOneTwo = "f6e6") Or (positionOneTwo = "f6g6") Or (positionOneTwo = "g6g7") Or (positionOneTwo = "g6f6") Or (positionOneTwo = "g6h6") Or (positionOneTwo = "h6h7") Or (positionOneTwo = "h6g6") Or (positionOneTwo = "h6i6") Or (positionOneTwo = "i6i7") Or (positionOneTwo = "i6h6") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkBlackBingRow7Move()
        If (positionOneTwo = "a7a8") Or (positionOneTwo = "a7b7") Or (positionOneTwo = "b7b8") Or (positionOneTwo = "b7a7") Or (positionOneTwo = "b7c7") Or (positionOneTwo = "c7c8") Or (positionOneTwo = "c7b7") Or (positionOneTwo = "c7d7") Or (positionOneTwo = "d7d8") Or (positionOneTwo = "d7c7") Or (positionOneTwo = "d7e7") Or (positionOneTwo = "e7e8") Or (positionOneTwo = "e7d7") Or (positionOneTwo = "e7f7") Or (positionOneTwo = "f7f8") Or (positionOneTwo = "f7e7") Or (positionOneTwo = "f7g7") Or (positionOneTwo = "g7g8") Or (positionOneTwo = "g7f7") Or (positionOneTwo = "g7h7") Or (positionOneTwo = "h7h8") Or (positionOneTwo = "h7g7") Or (positionOneTwo = "h7i7") Or (positionOneTwo = "i7i8") Or (positionOneTwo = "i7h7") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkBlackBingRow8Move()
        If (positionOneTwo = "a8a9") Or (positionOneTwo = "a8b8") Or (positionOneTwo = "b8b9") Or (positionOneTwo = "b8a8") Or (positionOneTwo = "b8c8") Or (positionOneTwo = "c8c9") Or (positionOneTwo = "c8b8") Or (positionOneTwo = "c8d8") Or (positionOneTwo = "d8d9") Or (positionOneTwo = "d8c8") Or (positionOneTwo = "d8e8") Or (positionOneTwo = "e8e9") Or (positionOneTwo = "e8d8") Or (positionOneTwo = "e8f8") Or (positionOneTwo = "f8f9") Or (positionOneTwo = "f8e8") Or (positionOneTwo = "f8g8") Or (positionOneTwo = "g8g9") Or (positionOneTwo = "g8f8") Or (positionOneTwo = "g8h8") Or (positionOneTwo = "h8h9") Or (positionOneTwo = "h8g8") Or (positionOneTwo = "h8i8") Or (positionOneTwo = "i8i9") Or (positionOneTwo = "i8h8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkBlackBingRow9Move()
        If (positionOneTwo = "a9a10") Or (positionOneTwo = "a9b9") Or (positionOneTwo = "b9b10") Or (positionOneTwo = "b9a9") Or (positionOneTwo = "b9c9") Or (positionOneTwo = "c9c10") Or (positionOneTwo = "c9b9") Or (positionOneTwo = "c9d9") Or (positionOneTwo = "d9d10") Or (positionOneTwo = "d9c9") Or (positionOneTwo = "d9e9") Or (positionOneTwo = "e9e10") Or (positionOneTwo = "e9d9") Or (positionOneTwo = "e9f9") Or (positionOneTwo = "f9f10") Or (positionOneTwo = "f9e9") Or (positionOneTwo = "f9g9") Or (positionOneTwo = "g9g10") Or (positionOneTwo = "g9f9") Or (positionOneTwo = "g9h9") Or (positionOneTwo = "h9h10") Or (positionOneTwo = "h9g9") Or (positionOneTwo = "h9i9") Or (positionOneTwo = "i9i10") Or (positionOneTwo = "i9h9") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkBlackBingRow10Move()
        If (positionOneTwo = "a10b10") Or (positionOneTwo = "b10a10") Or (positionOneTwo = "b10c10") Or (positionOneTwo = "c10b10") Or (positionOneTwo = "c10d10") Or (positionOneTwo = "d10c10") Or (positionOneTwo = "d10e10") Or (positionOneTwo = "e10d10") Or (positionOneTwo = "e10f10") Or (positionOneTwo = "f10e10") Or (positionOneTwo = "f10g10") Or (positionOneTwo = "g10f10") Or (positionOneTwo = "g10h10") Or (positionOneTwo = "h10g10") Or (positionOneTwo = "h10i10") Or (positionOneTwo = "i10h10") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
End Module
