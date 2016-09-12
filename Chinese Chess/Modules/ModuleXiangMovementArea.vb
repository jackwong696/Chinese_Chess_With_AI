' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 15/11/2010
' Descripitons : Chinese Chess V1

Module ModuleXiangMovementArea

    Public Sub CheckBlackXiangMovementArea()
        If positionOne = "a3" Then
            BlackXiangA3NorthEastMovementArea()
            BlackXiangA3SouthEastMovementArea()
        ElseIf (positionOne = "c1") Then
            BlackXiangC1NorthEastMovementArea()
            BlackXiangC1NorthWestMovementArea()
        ElseIf (positionOne = "c5") Then
            BlackXiangC5SouthEastMovementArea()
            BlackXiangC5SouthWestMovementArea()
        ElseIf positionOne = "e3" Then
            BlackXiangE3NorthEastMovementArea()
            BlackXiangE3NorthWestMovementArea()
            BlackXiangE3SouthEastMovementArea()
            BlackXiangE3SouthWestMovementArea()
        ElseIf (positionOne = "g1") Then
            BlackXiangG1NorthEastMovementArea()
            BlackXiangG1NorthWestMovementArea()
        ElseIf (positionOne = "g5") Then
            BlackXiangG5SouthEastMovementArea()
            BlackXiangG5SouthWestMovementArea()
        ElseIf positionOne = "i3" Then
            BlackXiangI3NorthWestMovementArea()
            BlackXiangI3SouthWestMovementArea()
        End If
    End Sub
    Public Sub CheckWhiteXiangMovementArea()
        If positionOne = "a8" Then
            WhiteXiangA8NorthEastMovementArea()
            WhiteXiangA8SouthEastMovementArea()
        ElseIf (positionOne = "c10") Then
            WhiteXiangC10SouthEastMovementArea()
            WhiteXiangC10SouthWestMovementArea()
        ElseIf (positionOne = "c6") Then
            WhiteXiangC6NorthEastMovementArea()
            WhiteXiangC6NorthWestMovementArea()
        ElseIf positionOne = "e8" Then
            WhiteXiangE8NorthEastMovementArea()
            WhiteXiangE8NorthWestMovementArea()
            WhiteXiangE8SouthEastMovementArea()
            WhiteXiangE8SouthWestMovementArea()
        ElseIf (positionOne = "g10") Then
            WhiteXiangG10SouthEastMovementArea()
            WhiteXiangG10SouthWestMovementArea()
        ElseIf (positionOne = "g6") Then
            WhiteXiangG6NorthEastMovementArea()
            WhiteXiangG6NorthWestMovementArea()
        ElseIf positionOne = "i8" Then
            WhiteXiangI8NorthWestMovementArea()
            WhiteXiangI8SouthWestMovementArea()
        End If
    End Sub
End Module
