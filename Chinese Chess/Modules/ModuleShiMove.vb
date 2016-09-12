' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 01/10/2010 to 28/10/2010
' Descripitons : Chinese Chess V1

Module ModuleShiMove
    Public Sub checkWhiteShiRow10Move()
        If (positionOneTwo = "d10e9") Or (positionOneTwo = "f10e9") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkWhiteShiRow9Move()
        If (positionOneTwo = "e9d10") Or (positionOneTwo = "e9d8") Or (positionOneTwo = "e9f10") Or (positionOneTwo = "e9f8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkWhiteShiRow8Move()
        If (positionOneTwo = "d8e9") Or (positionOneTwo = "f8e9") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub

    Public Sub checkBlackShiRow1Move()
        If (positionOneTwo = "d1e2") Or (positionOneTwo = "f1e2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkBlackShiRow2Move()
        If (positionOneTwo = "e2d1") Or (positionOneTwo = "e2d3") Or (positionOneTwo = "e2f1") Or (positionOneTwo = "e2f3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkBlackShiRow3Move()
        If (positionOneTwo = "d3e2") Or (positionOneTwo = "f3e2") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
End Module
