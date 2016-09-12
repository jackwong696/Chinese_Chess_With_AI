' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 01/10/2010 to 28/10/2010
' Descripitons : Chinese Chess V1

Module ModuleJiangMove
    Public Sub checkWhiteJiangRow10Move()
        If (positionOneTwo = "d10e10") Or (positionOneTwo = "d10d9") Or (positionOneTwo = "e10e9") Or (positionOneTwo = "e10d10") Or (positionOneTwo = "e10f10") Or (positionOneTwo = "f10f9") Or (positionOneTwo = "f10e10") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkWhiteJiangRow9Move()
        If (positionOneTwo = "d9e9") Or (positionOneTwo = "d9d8") Or (positionOneTwo = "d9d10") Or (positionOneTwo = "e9e8") Or (positionOneTwo = "e9e10") Or (positionOneTwo = "e9d9") Or (positionOneTwo = "e9f9") Or (positionOneTwo = "f9e9") Or (positionOneTwo = "f9f10") Or (positionOneTwo = "f9f8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkWhiteJiangRow8Move()
        If (positionOneTwo = "d8e8") Or (positionOneTwo = "d8d9") Or (positionOneTwo = "e8e9") Or (positionOneTwo = "e8d8") Or (positionOneTwo = "e8f8") Or (positionOneTwo = "f8f9") Or (positionOneTwo = "f8e8") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub

    Public Sub checkBlackJiangRow1Move()
        If (positionOneTwo = "d1e1") Or (positionOneTwo = "d1d2") Or (positionOneTwo = "e1e2") Or (positionOneTwo = "e1d1") Or (positionOneTwo = "e1f1") Or (positionOneTwo = "f1f2") Or (positionOneTwo = "f1e1") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkBlackJiangRow2Move()
        If (positionOneTwo = "d2e2") Or (positionOneTwo = "d2d1") Or (positionOneTwo = "d2d3") Or (positionOneTwo = "e2e1") Or (positionOneTwo = "e2e3") Or (positionOneTwo = "e2d2") Or (positionOneTwo = "e2f2") Or (positionOneTwo = "f2e2") Or (positionOneTwo = "f2f1") Or (positionOneTwo = "f2f3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
    Public Sub checkBlackJiangRow3Move()
        If (positionOneTwo = "d3e3") Or (positionOneTwo = "d3d2") Or (positionOneTwo = "e3e2") Or (positionOneTwo = "e3d3") Or (positionOneTwo = "e3f3") Or (positionOneTwo = "f3f2") Or (positionOneTwo = "f3e3") Then
            moveBool = True
        Else
            moveBool = False
        End If
    End Sub
End Module
