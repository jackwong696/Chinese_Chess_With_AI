' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 01/10/2010 to 28/10/2010
' Descripitons : Chinese Chess V1

Module ModuleXiangMove
    Public Sub checkWhiteXiangRow10Move()
        If (positionOneTwo = "c10a8") Or (positionOneTwo = "c10e8") Or (positionOneTwo = "g10e8") Or (positionOneTwo = "g10i8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkWhiteXiangRow8Move()
        If (positionOneTwo = "a8c6") Or (positionOneTwo = "a8c10") Or (positionOneTwo = "e8c6") Or (positionOneTwo = "e8c10") Or (positionOneTwo = "e8g6") Or (positionOneTwo = "e8g10") Or (positionOneTwo = "i8g6") Or (positionOneTwo = "i8g10") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkWhiteXiangRow6Move()
        If (positionOneTwo = "c6a8") Or (positionOneTwo = "c6e8") Or (positionOneTwo = "g6e8") Or (positionOneTwo = "g6i8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub

    Public Sub checkBlackXiangRow1Move()
        If (positionOneTwo = "c1a3") Or (positionOneTwo = "c1e3") Or (positionOneTwo = "g1e3") Or (positionOneTwo = "g1i3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkBlackXiangRow3Move()
        If (positionOneTwo = "a3c5") Or (positionOneTwo = "a3c1") Or (positionOneTwo = "e3c5") Or (positionOneTwo = "e3c1") Or (positionOneTwo = "e3g5") Or (positionOneTwo = "e3g1") Or (positionOneTwo = "i3g5") Or (positionOneTwo = "i3g1") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkBlackXiangRow5Move()
        If (positionOneTwo = "c5a3") Or (positionOneTwo = "c5e3") Or (positionOneTwo = "g5e3") Or (positionOneTwo = "g5i3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
End Module
