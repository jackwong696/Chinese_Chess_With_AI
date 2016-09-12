' Project : Chinese Chess V1
' Programmer : Wong Wei Jian
' Date : 18/01/2011
' Descripitons : Chinese Chess V1

Module ModuleCheckAvailableBlock
    Public Sub ClearAvailableBlock()
        Dim i As Integer

        For i = 1 To 10
            PictureboxAbleToBlock(i) = 0
        Next i
    End Sub
    Public Sub CheckCheAvailableBlock()
        If (EnemyAttackerLocation = "a1") Then
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "a4") _
            Or (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "a6") _
            Or (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "a8") _
            Or (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "a10") Then
                CheA1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") _
            Or (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "e1") _
            Or (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "g1") _
            Or (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "i1") Then
                CheA1EastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a2") Then
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "a5") _
            Or (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "a7") _
            Or (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "a9") _
            Or (TargetLocationRowColumn = "a10") Then
                CheA2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "d2") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "f2") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "h2") Or (TargetLocationRowColumn = "i2") Then
                CheA2EastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a3") Then
            If (TargetLocationRowColumn = "a5") _
            Or (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "a7") _
            Or (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "a9") _
            Or (TargetLocationRowColumn = "a10") Then
                CheA3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c3") _
            Or (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "e3") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "g3") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "i3") Then
                CheA3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Then
                CheA3SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a4") Then
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "a7") _
            Or (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "a9") _
            Or (TargetLocationRowColumn = "a10") Then
                CheA4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c4") _
            Or (TargetLocationRowColumn = "d4") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "i4") Then
                CheA4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") Then
                CheA4SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a5") Then
            If (TargetLocationRowColumn = "a7") _
            Or (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "a9") _
            Or (TargetLocationRowColumn = "a10") Then
                CheA5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c5") _
            Or (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "e5") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "i5") Then
                CheA5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "a3") Then
                CheA5SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a6") Then
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "a9") _
            Or (TargetLocationRowColumn = "a10") Then
                CheA6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c6") _
            Or (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "e6") _
            Or (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "i6") Then
                CheA6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "a4") Then
                CheA6SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a7") Then
            If (TargetLocationRowColumn = "a9") _
            Or (TargetLocationRowColumn = "a10") Then
                CheA7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c7") _
            Or (TargetLocationRowColumn = "d7") Or (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "i7") Then
                CheA7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "a4") _
            Or (TargetLocationRowColumn = "a5") Then
                CheA7SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a8") Then
            If (TargetLocationRowColumn = "a10") Then
                CheA8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c8") _
            Or (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "e8") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "g8") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "i8") Then
                CheA8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "a4") _
            Or (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "a6") Then
                CheA8SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a9") Then
            If (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "d9") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "f9") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "i9") Then
                CheA9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "a4") _
            Or (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "a6") _
            Or (TargetLocationRowColumn = "a7") Then
                CheA9SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a10") Then
            If (TargetLocationRowColumn = "c10") _
            Or (TargetLocationRowColumn = "d10") Or (TargetLocationRowColumn = "e10") _
            Or (TargetLocationRowColumn = "f10") Or (TargetLocationRowColumn = "g10") _
            Or (TargetLocationRowColumn = "h10") Or (TargetLocationRowColumn = "i10") Then
                CheA10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "a4") _
            Or (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "a6") _
            Or (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "a8") Then
                CheA10SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b1") Then
            If (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "b5") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "b7") Or (TargetLocationRowColumn = "b8") _
            Or (TargetLocationRowColumn = "b9") Or (TargetLocationRowColumn = "b10") Then
                CheB1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "e1") _
            Or (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "g1") _
            Or (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "i1") Then
                CheB1EastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b2") Then
            If (TargetLocationRowColumn = "b4") Or (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "b6") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "b8") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "b10") Then
                CheB2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d2") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "f2") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "h2") Or (TargetLocationRowColumn = "i2") Then
                CheB2EastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b3") Then
            If (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "b6") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "b8") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "b10") Then
                CheB3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "e3") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "g3") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "i3") Then
                CheB3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Then
                CheB3SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b4") Then
            If (TargetLocationRowColumn = "b6") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "b8") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "b10") Then
                CheB4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d4") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "i4") Then
                CheB4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") Then
                CheB4SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b5") Then
            If (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "b8") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "b10") Then
                CheB5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "e5") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "i5") Then
                CheB5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") _
            Or (TargetLocationRowColumn = "b3") Then
                CheB5SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b6") Then
            If (TargetLocationRowColumn = "b8") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "b10") Then
                CheB6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "e6") _
            Or (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "i6") Then
                CheB6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") _
            Or (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "b4") Then
                CheB6SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b7") Then
            If (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "b10") Then
                CheB7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d7") Or (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "i7") Then
                CheB7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") _
            Or (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "b5") Then
                CheB7SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b8") Then
            If (TargetLocationRowColumn = "b10") Then
                CheB8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "e8") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "g8") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "i8") Then
                CheB8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") _
            Or (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "b5") Or (TargetLocationRowColumn = "b6") Then
                CheB8SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b9") Then
            If (TargetLocationRowColumn = "d9") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "f9") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "i9") Then
                CheB9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") _
            Or (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "b5") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "b7") Then
                CheB9SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b10") Then
            If (TargetLocationRowColumn = "d10") Or (TargetLocationRowColumn = "e10") _
            Or (TargetLocationRowColumn = "f10") Or (TargetLocationRowColumn = "g10") _
            Or (TargetLocationRowColumn = "h10") Or (TargetLocationRowColumn = "i10") Then
                CheB10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") _
            Or (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "b5") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "b7") Or (TargetLocationRowColumn = "b8") Then
                CheB10SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c1") Then
            If (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c4") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "c6") _
            Or (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "c8") _
            Or (TargetLocationRowColumn = "c9") Or (TargetLocationRowColumn = "c10") Then
                CheC1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") _
            Or (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "g1") _
            Or (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "i1") Then
                CheC1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Then
                CheC1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c2") Then
            If (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "c5") _
            Or (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "c7") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "c10") Then
                CheC2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "f2") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "h2") Or (TargetLocationRowColumn = "i2") Then
                CheC2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Then
                CheC2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c3") Then
            If (TargetLocationRowColumn = "c5") _
            Or (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "c7") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "c10") Then
                CheC3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e3") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "g3") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "i3") Then
                CheC3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Then
                CheC3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Then
                CheC3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c4") Then
            If (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "c7") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "c10") Then
                CheC4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "i4") Then
                CheC4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") Then
                CheC4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Then
                CheC4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c5") Then
            If (TargetLocationRowColumn = "c7") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "c10") Then
                CheC5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e5") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "i5") Then
                CheC5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "c3") Then
                CheC5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Then
                CheC5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c6") Then
            If (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "c10") Then
                CheC6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e6") _
            Or (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "i6") Then
                CheC6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c4") Then
                CheC6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Then
                CheC6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c7") Then
            If (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "c10") Then
                CheC7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "i7") Then
                CheC7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c4") _
            Or (TargetLocationRowColumn = "c5") Then
                CheC7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Then
                CheC7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c8") Then
            If (TargetLocationRowColumn = "c10") Then
                CheC8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e8") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "g8") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "i8") Then
                CheC8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c4") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "c6") Then
                CheC8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Then
                CheC8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c9") Then
            If (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "f9") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "i9") Then
                CheC9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c4") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "c6") _
            Or (TargetLocationRowColumn = "c7") Then
                CheC9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Then
                CheC9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c10") Then
            If (TargetLocationRowColumn = "e10") _
            Or (TargetLocationRowColumn = "f10") Or (TargetLocationRowColumn = "g10") _
            Or (TargetLocationRowColumn = "h10") Or (TargetLocationRowColumn = "i10") Then
                CheC10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c4") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "c6") _
            Or (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "c8") Then
                CheC10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Then
                CheC10WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d1") Then
            If (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "d6") _
            Or (TargetLocationRowColumn = "d7") Or (TargetLocationRowColumn = "d8") _
            Or (TargetLocationRowColumn = "d9") Or (TargetLocationRowColumn = "d10") Then
                CheD1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "g1") _
            Or (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "i1") Then
                CheD1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "b1") Then
                CheD1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d2") Then
            If (TargetLocationRowColumn = "d4") Or (TargetLocationRowColumn = "d5") _
            Or (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "d10") Then
                CheD2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f2") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "h2") Or (TargetLocationRowColumn = "i2") Then
                CheD2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Or (TargetLocationRowColumn = "a2") Then
                CheD2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d3") Then
            If (TargetLocationRowColumn = "d5") _
            Or (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "d10") Then
                CheD3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "g3") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "i3") Then
                CheD3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Then
                CheD3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "b3") Then
                CheD3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d4") Then
            If (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "d10") Then
                CheD4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "i4") Then
                CheD4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") Then
                CheD4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "b4") Then
                CheD4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d5") Then
            If (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "d10") Then
                CheD5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "i5") Then
                CheD5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "d3") Then
                CheD5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "b5") Then
                CheD5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d6") Then
            If (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "d10") Then
                CheD6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "i6") Then
                CheD6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d4") Then
                CheD6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "b6") Then
                CheD6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d7") Then
            If (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "d10") Then
                CheD7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "i7") Then
                CheD7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "d5") Then
                CheD7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "b7") Then
                CheD7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d8") Then
            If (TargetLocationRowColumn = "d10") Then
                CheD8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "g8") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "i8") Then
                CheD8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "d6") Then
                CheD8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "b8") Then
                CheD8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d9") Then
            If (TargetLocationRowColumn = "f9") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "i9") Then
                CheD9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "d6") _
            Or (TargetLocationRowColumn = "d7") Then
                CheD9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "b9") Then
                CheD9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d10") Then
            If (TargetLocationRowColumn = "f10") Or (TargetLocationRowColumn = "g10") _
            Or (TargetLocationRowColumn = "h10") Or (TargetLocationRowColumn = "i10") Then
                CheD10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "d6") _
            Or (TargetLocationRowColumn = "d7") Or (TargetLocationRowColumn = "d8") Then
                CheD10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "b10") Then
                CheD10WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e1") Then
            If (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "e6") _
            Or (TargetLocationRowColumn = "e7") Or (TargetLocationRowColumn = "e8") _
            Or (TargetLocationRowColumn = "e9") Or (TargetLocationRowColumn = "e10") Then
                CheE1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") _
            Or (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "i1") Then
                CheE1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "b1") _
            Or (TargetLocationRowColumn = "c1") Then
                CheE1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e2") Then
            If (TargetLocationRowColumn = "e4") Or (TargetLocationRowColumn = "e5") _
            Or (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "e10") Then
                CheE2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "h2") Or (TargetLocationRowColumn = "i2") Then
                CheE2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "c2") Then
                CheE2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e3") Then
            If (TargetLocationRowColumn = "e5") _
            Or (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "e10") Then
                CheE3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g3") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "i3") Then
                CheE3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Then
                CheE3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "b3") _
            Or (TargetLocationRowColumn = "c3") Then
                CheE3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e4") Then
            If (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "e10") Then
                CheE4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "i4") Then
                CheE4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") Then
                CheE4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "c4") Then
                CheE4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e5") Then
            If (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "e10") Then
                CheE5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "i5") Then
                CheE5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "e3") Then
                CheE5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "c5") Then
                CheE5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e6") Then
            If (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "e10") Then
                CheE6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "i6") Then
                CheE6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e4") Then
                CheE6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "c6") Then
                CheE6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e7") Then
            If (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "e10") Then
                CheE7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "i7") Then
                CheE7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "e5") Then
                CheE7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "c7") Then
                CheE7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e8") Then
            If (TargetLocationRowColumn = "e10") Then
                CheE8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g8") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "i8") Then
                CheE8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "e6") Then
                CheE8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "b8") _
            Or (TargetLocationRowColumn = "c8") Then
                CheE8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e9") Then
            If (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "i9") Then
                CheE9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "e6") _
            Or (TargetLocationRowColumn = "e7") Then
                CheE9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "c9") Then
                CheE9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e10") Then
            If (TargetLocationRowColumn = "g10") _
            Or (TargetLocationRowColumn = "h10") Or (TargetLocationRowColumn = "i10") Then
                CheE10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "e6") _
            Or (TargetLocationRowColumn = "e7") Or (TargetLocationRowColumn = "e8") Then
                CheE10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "b10") _
            Or (TargetLocationRowColumn = "c10") Then
                CheE10WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f1") Then
            If (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f4") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "f6") _
            Or (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "f8") _
            Or (TargetLocationRowColumn = "f9") Or (TargetLocationRowColumn = "f10") Then
                CheF1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "i1") Then
                CheF1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "b1") _
            Or (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "d1") Then
                CheF1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f2") Then
            If (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "f5") _
            Or (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "f7") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "f10") Then
                CheF2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h2") Or (TargetLocationRowColumn = "i2") Then
                CheF2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "c2") Or (TargetLocationRowColumn = "d2") Then
                CheF2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f3") Then
            If (TargetLocationRowColumn = "f5") _
            Or (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "f7") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "f10") Then
                CheF3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "i3") Then
                CheF3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Then
                CheF3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "b3") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "d3") Then
                CheF3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f4") Then
            If (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "f7") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "f10") Then
                CheF4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "i4") Then
                CheF4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") Then
                CheF4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "d4") Then
                CheF4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f5") Then
            If (TargetLocationRowColumn = "f7") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "f10") Then
                CheF5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "i5") Then
                CheF5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "f3") Then
                CheF5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "d5") Then
                CheF5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f6") Then
            If (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "f10") Then
                CheF6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "i6") Then
                CheF6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f4") Then
                CheF6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "d6") Then
                CheF6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f7") Then
            If (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "f10") Then
                CheF7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "i7") Then
                CheF7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f4") _
            Or (TargetLocationRowColumn = "f5") Then
                CheF7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "d7") Then
                CheF7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f8") Then
            If (TargetLocationRowColumn = "f10") Then
                CheF8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "i8") Then
                CheF8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f4") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "f6") Then
                CheF8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "b8") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "d8") Then
                CheF8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f9") Then
            If (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "i9") Then
                CheF9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f4") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "f6") _
            Or (TargetLocationRowColumn = "f7") Then
                CheF9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "c9") Or (TargetLocationRowColumn = "d9") Then
                CheF9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f10") Then
            If (TargetLocationRowColumn = "h10") Or (TargetLocationRowColumn = "i10") Then
                CheF10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f4") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "f6") _
            Or (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "f8") Then
                CheF10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "b10") _
            Or (TargetLocationRowColumn = "c10") Or (TargetLocationRowColumn = "d10") Then
                CheF10WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g1") Then
            If (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "g5") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "g7") Or (TargetLocationRowColumn = "g8") _
            Or (TargetLocationRowColumn = "g9") Or (TargetLocationRowColumn = "g10") Then
                CheG1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Then
                CheG1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "b1") _
            Or (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "d1") _
            Or (TargetLocationRowColumn = "e1") Then
                CheG1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g2") Then
            If (TargetLocationRowColumn = "g4") Or (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "g6") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "g10") Then
                CheG2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i2") Then
                CheG2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "c2") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "e2") Then
                CheG2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g3") Then
            If (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "g6") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "g10") Then
                CheG3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i3") Then
                CheG3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Then
                CheG3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "b3") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "d3") _
            Or (TargetLocationRowColumn = "e3") Then
                CheG3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g4") Then
            If (TargetLocationRowColumn = "g6") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "g10") Then
                CheG4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i4") Then
                CheG4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") Then
                CheG4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "e4") Then
                CheG4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g5") Then
            If (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "g10") Then
                CheG5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i5") Then
                CheG5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "g3") Then
                CheG5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "d5") _
            Or (TargetLocationRowColumn = "e5") Then
                CheG5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g6") Then
            If (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "g10") Then
                CheG6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i6") Then
                CheG6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g4") Then
                CheG6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "d6") _
            Or (TargetLocationRowColumn = "e6") Then
                CheG6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g7") Then
            If (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "g10") Then
                CheG7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i7") Then
                CheG7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "g5") Then
                CheG7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "e7") Then
                CheG7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g8") Then
            If (TargetLocationRowColumn = "g10") Then
                CheG8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i8") Then
                CheG8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "g5") Or (TargetLocationRowColumn = "g6") Then
                CheG8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "b8") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "d8") _
            Or (TargetLocationRowColumn = "e8") Then
                CheG8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g9") Then
            If (TargetLocationRowColumn = "i9") Then
                CheG9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "g5") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "g7") Then
                CheG9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "c9") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "e9") Then
                CheG9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g10") Then
            If (TargetLocationRowColumn = "i10") Then
                CheG10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "g5") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "g7") Or (TargetLocationRowColumn = "g8") Then
                CheG10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "b10") _
            Or (TargetLocationRowColumn = "c10") Or (TargetLocationRowColumn = "d10") _
            Or (TargetLocationRowColumn = "e10") Then
                CheG10WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h1") Then
            If (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "h4") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "h6") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "h8") _
            Or (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "h10") Then
                CheH1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "b1") _
            Or (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "d1") _
            Or (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "f1") Then
                CheH1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h2") Then
            If (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "h5") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "h7") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "h9") _
            Or (TargetLocationRowColumn = "h10") Then
                CheH2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "c2") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "e2") Or (TargetLocationRowColumn = "f2") Then
                CheH2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h3") Then
            If (TargetLocationRowColumn = "h5") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "h7") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "h9") _
            Or (TargetLocationRowColumn = "h10") Then
                CheH3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Then
                CheH3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "b3") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "d3") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "f3") Then
                CheH3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h4") Then
            If (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "h7") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "h9") _
            Or (TargetLocationRowColumn = "h10") Then
                CheH4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") Then
                CheH4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "e4") Or (TargetLocationRowColumn = "f4") Then
                CheH4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h5") Then
            If (TargetLocationRowColumn = "h7") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "h9") _
            Or (TargetLocationRowColumn = "h10") Then
                CheH5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") _
            Or (TargetLocationRowColumn = "h3") Then
                CheH5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "d5") _
            Or (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "f5") Then
                CheH5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h6") Then
            If (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "h9") _
            Or (TargetLocationRowColumn = "h10") Then
                CheH6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "h4") Then
                CheH6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "d6") _
            Or (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "f6") Then
                CheH6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h7") Then
            If (TargetLocationRowColumn = "h9") _
            Or (TargetLocationRowColumn = "h10") Then
                CheH7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "h4") _
            Or (TargetLocationRowColumn = "h5") Then
                CheH7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "e7") Or (TargetLocationRowColumn = "f7") Then
                CheH7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h8") Then
            If (TargetLocationRowColumn = "h10") Then
                CheH8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "h4") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "h6") Then
                CheH8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "b8") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "d8") _
            Or (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "f8") Then
                CheH8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h9") Then
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "h4") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "h6") _
            Or (TargetLocationRowColumn = "h7") Then
                CheH9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "c9") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "e9") Or (TargetLocationRowColumn = "f9") Then
                CheH9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h10") Then
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "h4") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "h6") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "h8") Then
                CheH10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "b10") _
            Or (TargetLocationRowColumn = "c10") Or (TargetLocationRowColumn = "d10") _
            Or (TargetLocationRowColumn = "e10") Or (TargetLocationRowColumn = "f10") Then
                CheH10WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i1") Then
            If (TargetLocationRowColumn = "i3") Or (TargetLocationRowColumn = "i4") _
            Or (TargetLocationRowColumn = "i5") Or (TargetLocationRowColumn = "i6") _
            Or (TargetLocationRowColumn = "i7") Or (TargetLocationRowColumn = "i8") _
            Or (TargetLocationRowColumn = "i9") Or (TargetLocationRowColumn = "i10") Then
                CheI1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "b1") _
            Or (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "d1") _
            Or (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "f1") _
            Or (TargetLocationRowColumn = "g1") Then
                CheI1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i2") Then
            If (TargetLocationRowColumn = "i4") Or (TargetLocationRowColumn = "i5") _
            Or (TargetLocationRowColumn = "i6") Or (TargetLocationRowColumn = "i7") _
            Or (TargetLocationRowColumn = "i8") Or (TargetLocationRowColumn = "i9") _
            Or (TargetLocationRowColumn = "i10") Then
                CheI2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "c2") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "e2") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "g2") Then
                CheI2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i3") Then
            If (TargetLocationRowColumn = "i5") _
            Or (TargetLocationRowColumn = "i6") Or (TargetLocationRowColumn = "i7") _
            Or (TargetLocationRowColumn = "i8") Or (TargetLocationRowColumn = "i9") _
            Or (TargetLocationRowColumn = "i10") Then
                CheI3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Then
                CheI3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "b3") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "d3") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "f3") _
            Or (TargetLocationRowColumn = "g3") Then
                CheI3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i4") Then
            If (TargetLocationRowColumn = "i6") Or (TargetLocationRowColumn = "i7") _
            Or (TargetLocationRowColumn = "i8") Or (TargetLocationRowColumn = "i9") _
            Or (TargetLocationRowColumn = "i10") Then
                CheI4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") Then
                CheI4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "e4") Or (TargetLocationRowColumn = "f4") _
            Or (TargetLocationRowColumn = "g4") Then
                CheI4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i5") Then
            If (TargetLocationRowColumn = "i7") _
            Or (TargetLocationRowColumn = "i8") Or (TargetLocationRowColumn = "i9") _
            Or (TargetLocationRowColumn = "i10") Then
                CheI5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") _
            Or (TargetLocationRowColumn = "i3") Then
                CheI5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "d5") _
            Or (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "f5") _
            Or (TargetLocationRowColumn = "g5") Then
                CheI5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i6") Then
            If (TargetLocationRowColumn = "i8") Or (TargetLocationRowColumn = "i9") _
            Or (TargetLocationRowColumn = "i10") Then
                CheI6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") _
            Or (TargetLocationRowColumn = "i3") Or (TargetLocationRowColumn = "i4") Then
                CheI6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "d6") _
            Or (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "f6") _
            Or (TargetLocationRowColumn = "g6") Then
                CheI6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i7") Then
            If (TargetLocationRowColumn = "i9") _
            Or (TargetLocationRowColumn = "i10") Then
                CheI7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") _
            Or (TargetLocationRowColumn = "i3") Or (TargetLocationRowColumn = "i4") _
            Or (TargetLocationRowColumn = "i5") Then
                CheI7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "e7") Or (TargetLocationRowColumn = "f7") _
            Or (TargetLocationRowColumn = "g7") Then
                CheI7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i8") Then
            If (TargetLocationRowColumn = "i10") Then
                CheI8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") _
            Or (TargetLocationRowColumn = "i3") Or (TargetLocationRowColumn = "i4") _
            Or (TargetLocationRowColumn = "i5") Or (TargetLocationRowColumn = "i6") Then
                CheI8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "b8") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "d8") _
            Or (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "f8") _
            Or (TargetLocationRowColumn = "g8") Then
                CheI8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i9") Then
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") _
            Or (TargetLocationRowColumn = "i3") Or (TargetLocationRowColumn = "i4") _
            Or (TargetLocationRowColumn = "i5") Or (TargetLocationRowColumn = "i6") _
            Or (TargetLocationRowColumn = "i7") Then
                CheI9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "c9") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "e9") Or (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "g9") Then
                CheI9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i10") Then
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") _
            Or (TargetLocationRowColumn = "i3") Or (TargetLocationRowColumn = "i4") _
            Or (TargetLocationRowColumn = "i5") Or (TargetLocationRowColumn = "i6") _
            Or (TargetLocationRowColumn = "i7") Or (TargetLocationRowColumn = "i8") Then
                CheI10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "b10") _
            Or (TargetLocationRowColumn = "c10") Or (TargetLocationRowColumn = "d10") _
            Or (TargetLocationRowColumn = "e10") Or (TargetLocationRowColumn = "f10") _
            Or (TargetLocationRowColumn = "g10") Then
                CheI10WestMovementArea()
            End If
        End If
    End Sub

    Public Sub CheckPaoAvailableBlock()
        If (EnemyAttackerLocation = "a1") Then
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "a4") _
            Or (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "a6") _
            Or (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "a8") _
            Or (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "a10") Then
                PaoA1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") _
            Or (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "e1") _
            Or (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "g1") _
            Or (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "i1") Then
                PaoA1EastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a2") Then
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "a5") _
            Or (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "a7") _
            Or (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "a9") _
            Or (TargetLocationRowColumn = "a10") Then
                PaoA2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "d2") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "f2") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "h2") Or (TargetLocationRowColumn = "i2") Then
                PaoA2EastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a3") Then
            If (TargetLocationRowColumn = "a5") _
            Or (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "a7") _
            Or (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "a9") _
            Or (TargetLocationRowColumn = "a10") Then
                PaoA3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c3") _
            Or (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "e3") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "g3") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "i3") Then
                PaoA3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Then
                PaoA3SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a4") Then
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "a7") _
            Or (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "a9") _
            Or (TargetLocationRowColumn = "a10") Then
                PaoA4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c4") _
            Or (TargetLocationRowColumn = "d4") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "i4") Then
                PaoA4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") Then
                PaoA4SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a5") Then
            If (TargetLocationRowColumn = "a7") _
            Or (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "a9") _
            Or (TargetLocationRowColumn = "a10") Then
                PaoA5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c5") _
            Or (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "e5") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "i5") Then
                PaoA5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "a3") Then
                PaoA5SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a6") Then
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "a9") _
            Or (TargetLocationRowColumn = "a10") Then
                PaoA6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c6") _
            Or (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "e6") _
            Or (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "i6") Then
                PaoA6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "a4") Then
                PaoA6SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a7") Then
            If (TargetLocationRowColumn = "a9") _
            Or (TargetLocationRowColumn = "a10") Then
                PaoA7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c7") _
            Or (TargetLocationRowColumn = "d7") Or (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "i7") Then
                PaoA7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "a4") _
            Or (TargetLocationRowColumn = "a5") Then
                PaoA7SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a8") Then
            If (TargetLocationRowColumn = "a10") Then
                PaoA8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c8") _
            Or (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "e8") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "g8") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "i8") Then
                PaoA8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "a4") _
            Or (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "a6") Then
                PaoA8SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a9") Then
            If (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "d9") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "f9") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "i9") Then
                PaoA9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "a4") _
            Or (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "a6") _
            Or (TargetLocationRowColumn = "a7") Then
                PaoA9SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a10") Then
            If (TargetLocationRowColumn = "c10") _
            Or (TargetLocationRowColumn = "d10") Or (TargetLocationRowColumn = "e10") _
            Or (TargetLocationRowColumn = "f10") Or (TargetLocationRowColumn = "g10") _
            Or (TargetLocationRowColumn = "h10") Or (TargetLocationRowColumn = "i10") Then
                PaoA10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "a4") _
            Or (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "a6") _
            Or (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "a8") Then
                PaoA10SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b1") Then
            If (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "b5") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "b7") Or (TargetLocationRowColumn = "b8") _
            Or (TargetLocationRowColumn = "b9") Or (TargetLocationRowColumn = "b10") Then
                PaoB1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "e1") _
            Or (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "g1") _
            Or (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "i1") Then
                PaoB1EastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b2") Then
            If (TargetLocationRowColumn = "b4") Or (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "b6") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "b8") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "b10") Then
                PaoB2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d2") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "f2") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "h2") Or (TargetLocationRowColumn = "i2") Then
                PaoB2EastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b3") Then
            If (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "b6") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "b8") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "b10") Then
                PaoB3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "e3") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "g3") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "i3") Then
                PaoB3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Then
                PaoB3SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b4") Then
            If (TargetLocationRowColumn = "b6") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "b8") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "b10") Then
                PaoB4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d4") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "i4") Then
                PaoB4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") Then
                PaoB4SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b5") Then
            If (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "b8") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "b10") Then
                PaoB5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "e5") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "i5") Then
                PaoB5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") _
            Or (TargetLocationRowColumn = "b3") Then
                PaoB5SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b6") Then
            If (TargetLocationRowColumn = "b8") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "b10") Then
                PaoB6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "e6") _
            Or (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "i6") Then
                PaoB6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") _
            Or (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "b4") Then
                PaoB6SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b7") Then
            If (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "b10") Then
                PaoB7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d7") Or (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "i7") Then
                PaoB7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") _
            Or (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "b5") Then
                PaoB7SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b8") Then
            If (TargetLocationRowColumn = "b10") Then
                PaoB8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "e8") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "g8") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "i8") Then
                PaoB8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") _
            Or (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "b5") Or (TargetLocationRowColumn = "b6") Then
                PaoB8SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b9") Then
            If (TargetLocationRowColumn = "d9") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "f9") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "i9") Then
                PaoB9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") _
            Or (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "b5") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "b7") Then
                PaoB9SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b10") Then
            If (TargetLocationRowColumn = "d10") Or (TargetLocationRowColumn = "e10") _
            Or (TargetLocationRowColumn = "f10") Or (TargetLocationRowColumn = "g10") _
            Or (TargetLocationRowColumn = "h10") Or (TargetLocationRowColumn = "i10") Then
                PaoB10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "b2") _
            Or (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "b5") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "b7") Or (TargetLocationRowColumn = "b8") Then
                PaoB10SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c1") Then
            If (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c4") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "c6") _
            Or (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "c8") _
            Or (TargetLocationRowColumn = "c9") Or (TargetLocationRowColumn = "c10") Then
                PaoC1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") _
            Or (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "g1") _
            Or (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "i1") Then
                PaoC1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Then
                PaoC1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c2") Then
            If (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "c5") _
            Or (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "c7") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "c10") Then
                PaoC2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "f2") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "h2") Or (TargetLocationRowColumn = "i2") Then
                PaoC2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Then
                PaoC2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c3") Then
            If (TargetLocationRowColumn = "c5") _
            Or (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "c7") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "c10") Then
                PaoC3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e3") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "g3") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "i3") Then
                PaoC3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Then
                PaoC3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Then
                PaoC3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c4") Then
            If (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "c7") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "c10") Then
                PaoC4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "i4") Then
                PaoC4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") Then
                PaoC4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Then
                PaoC4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c5") Then
            If (TargetLocationRowColumn = "c7") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "c10") Then
                PaoC5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e5") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "i5") Then
                PaoC5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "c3") Then
                PaoC5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Then
                PaoC5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c6") Then
            If (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "c10") Then
                PaoC6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e6") _
            Or (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "i6") Then
                PaoC6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c4") Then
                PaoC6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Then
                PaoC6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c7") Then
            If (TargetLocationRowColumn = "c9") _
            Or (TargetLocationRowColumn = "c10") Then
                PaoC7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "i7") Then
                PaoC7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c4") _
            Or (TargetLocationRowColumn = "c5") Then
                PaoC7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Then
                PaoC7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c8") Then
            If (TargetLocationRowColumn = "c10") Then
                PaoC8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e8") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "g8") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "i8") Then
                PaoC8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c4") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "c6") Then
                PaoC8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Then
                PaoC8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c9") Then
            If (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "f9") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "i9") Then
                PaoC9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c4") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "c6") _
            Or (TargetLocationRowColumn = "c7") Then
                PaoC9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Then
                PaoC9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c10") Then
            If (TargetLocationRowColumn = "e10") _
            Or (TargetLocationRowColumn = "f10") Or (TargetLocationRowColumn = "g10") _
            Or (TargetLocationRowColumn = "h10") Or (TargetLocationRowColumn = "i10") Then
                PaoC10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "c2") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c4") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "c6") _
            Or (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "c8") Then
                PaoC10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Then
                PaoC10WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d1") Then
            If (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "d6") _
            Or (TargetLocationRowColumn = "d7") Or (TargetLocationRowColumn = "d8") _
            Or (TargetLocationRowColumn = "d9") Or (TargetLocationRowColumn = "d10") Then
                PaoD1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "g1") _
            Or (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "i1") Then
                PaoD1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "b1") Then
                PaoD1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d2") Then
            If (TargetLocationRowColumn = "d4") Or (TargetLocationRowColumn = "d5") _
            Or (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "d10") Then
                PaoD2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f2") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "h2") Or (TargetLocationRowColumn = "i2") Then
                PaoD2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Or (TargetLocationRowColumn = "a2") Then
                PaoD2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d3") Then
            If (TargetLocationRowColumn = "d5") _
            Or (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "d10") Then
                PaoD3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "g3") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "i3") Then
                PaoD3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Then
                PaoD3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "b3") Then
                PaoD3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d4") Then
            If (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "d10") Then
                PaoD4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "i4") Then
                PaoD4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") Then
                PaoD4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "b4") Then
                PaoD4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d5") Then
            If (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "d10") Then
                PaoD5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "i5") Then
                PaoD5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "d3") Then
                PaoD5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "b5") Then
                PaoD5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d6") Then
            If (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "d10") Then
                PaoD6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "i6") Then
                PaoD6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d4") Then
                PaoD6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "b6") Then
                PaoD6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d7") Then
            If (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "d10") Then
                PaoD7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "i7") Then
                PaoD7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "d5") Then
                PaoD7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "b7") Then
                PaoD7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d8") Then
            If (TargetLocationRowColumn = "d10") Then
                PaoD8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "g8") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "i8") Then
                PaoD8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "d6") Then
                PaoD8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "b8") Then
                PaoD8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d9") Then
            If (TargetLocationRowColumn = "f9") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "i9") Then
                PaoD9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "d6") _
            Or (TargetLocationRowColumn = "d7") Then
                PaoD9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "b9") Then
                PaoD9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d10") Then
            If (TargetLocationRowColumn = "f10") Or (TargetLocationRowColumn = "g10") _
            Or (TargetLocationRowColumn = "h10") Or (TargetLocationRowColumn = "i10") Then
                PaoD10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "d6") _
            Or (TargetLocationRowColumn = "d7") Or (TargetLocationRowColumn = "d8") Then
                PaoD10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "b10") Then
                PaoD10WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e1") Then
            If (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "e6") _
            Or (TargetLocationRowColumn = "e7") Or (TargetLocationRowColumn = "e8") _
            Or (TargetLocationRowColumn = "e9") Or (TargetLocationRowColumn = "e10") Then
                PaoE1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") _
            Or (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "i1") Then
                PaoE1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "b1") _
            Or (TargetLocationRowColumn = "c1") Then
                PaoE1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e2") Then
            If (TargetLocationRowColumn = "e4") Or (TargetLocationRowColumn = "e5") _
            Or (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "e10") Then
                PaoE2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "h2") Or (TargetLocationRowColumn = "i2") Then
                PaoE2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "c2") Then
                PaoE2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e3") Then
            If (TargetLocationRowColumn = "e5") _
            Or (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "e10") Then
                PaoE3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g3") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "i3") Then
                PaoE3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Then
                PaoE3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "b3") _
            Or (TargetLocationRowColumn = "c3") Then
                PaoE3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e4") Then
            If (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "e10") Then
                PaoE4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "i4") Then
                PaoE4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") Then
                PaoE4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "c4") Then
                PaoE4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e5") Then
            If (TargetLocationRowColumn = "e7") _
            Or (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "e10") Then
                PaoE5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "i5") Then
                PaoE5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "e3") Then
                PaoE5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "c5") Then
                PaoE5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e6") Then
            If (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "e10") Then
                PaoE6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "i6") Then
                PaoE6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e4") Then
                PaoE6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "c6") Then
                PaoE6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e7") Then
            If (TargetLocationRowColumn = "e9") _
            Or (TargetLocationRowColumn = "e10") Then
                PaoE7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "i7") Then
                PaoE7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "e5") Then
                PaoE7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "c7") Then
                PaoE7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e8") Then
            If (TargetLocationRowColumn = "e10") Then
                PaoE8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g8") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "i8") Then
                PaoE8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "e6") Then
                PaoE8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "b8") _
            Or (TargetLocationRowColumn = "c8") Then
                PaoE8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e9") Then
            If (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "i9") Then
                PaoE9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "e6") _
            Or (TargetLocationRowColumn = "e7") Then
                PaoE9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "c9") Then
                PaoE9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e10") Then
            If (TargetLocationRowColumn = "g10") _
            Or (TargetLocationRowColumn = "h10") Or (TargetLocationRowColumn = "i10") Then
                PaoE10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "e2") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e4") _
            Or (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "e6") _
            Or (TargetLocationRowColumn = "e7") Or (TargetLocationRowColumn = "e8") Then
                PaoE10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "b10") _
            Or (TargetLocationRowColumn = "c10") Then
                PaoE10WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f1") Then
            If (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f4") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "f6") _
            Or (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "f8") _
            Or (TargetLocationRowColumn = "f9") Or (TargetLocationRowColumn = "f10") Then
                PaoF1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "i1") Then
                PaoF1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "b1") _
            Or (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "d1") Then
                PaoF1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f2") Then
            If (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "f5") _
            Or (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "f7") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "f10") Then
                PaoF2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h2") Or (TargetLocationRowColumn = "i2") Then
                PaoF2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "c2") Or (TargetLocationRowColumn = "d2") Then
                PaoF2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f3") Then
            If (TargetLocationRowColumn = "f5") _
            Or (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "f7") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "f10") Then
                PaoF3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "i3") Then
                PaoF3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Then
                PaoF3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "b3") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "d3") Then
                PaoF3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f4") Then
            If (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "f7") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "f10") Then
                PaoF4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "i4") Then
                PaoF4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") Then
                PaoF4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "d4") Then
                PaoF4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f5") Then
            If (TargetLocationRowColumn = "f7") _
            Or (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "f10") Then
                PaoF5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "i5") Then
                PaoF5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "f3") Then
                PaoF5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "d5") Then
                PaoF5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f6") Then
            If (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "f10") Then
                PaoF6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "i6") Then
                PaoF6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f4") Then
                PaoF6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "d6") Then
                PaoF6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f7") Then
            If (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "f10") Then
                PaoF7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "i7") Then
                PaoF7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f4") _
            Or (TargetLocationRowColumn = "f5") Then
                PaoF7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "d7") Then
                PaoF7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f8") Then
            If (TargetLocationRowColumn = "f10") Then
                PaoF8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "i8") Then
                PaoF8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f4") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "f6") Then
                PaoF8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "b8") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "d8") Then
                PaoF8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f9") Then
            If (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "i9") Then
                PaoF9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f4") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "f6") _
            Or (TargetLocationRowColumn = "f7") Then
                PaoF9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "c9") Or (TargetLocationRowColumn = "d9") Then
                PaoF9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f10") Then
            If (TargetLocationRowColumn = "h10") Or (TargetLocationRowColumn = "i10") Then
                PaoF10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f4") _
            Or (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "f6") _
            Or (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "f8") Then
                PaoF10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "b10") _
            Or (TargetLocationRowColumn = "c10") Or (TargetLocationRowColumn = "d10") Then
                PaoF10WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g1") Then
            If (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "g5") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "g7") Or (TargetLocationRowColumn = "g8") _
            Or (TargetLocationRowColumn = "g9") Or (TargetLocationRowColumn = "g10") Then
                PaoG1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Then
                PaoG1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "b1") _
            Or (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "d1") _
            Or (TargetLocationRowColumn = "e1") Then
                PaoG1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g2") Then
            If (TargetLocationRowColumn = "g4") Or (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "g6") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "g10") Then
                PaoG2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i2") Then
                PaoG2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "c2") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "e2") Then
                PaoG2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g3") Then
            If (TargetLocationRowColumn = "g5") _
            Or (TargetLocationRowColumn = "g6") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "g10") Then
                PaoG3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i3") Then
                PaoG3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Then
                PaoG3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "b3") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "d3") _
            Or (TargetLocationRowColumn = "e3") Then
                PaoG3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g4") Then
            If (TargetLocationRowColumn = "g6") Or (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "g10") Then
                PaoG4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i4") Then
                PaoG4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") Then
                PaoG4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "e4") Then
                PaoG4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g5") Then
            If (TargetLocationRowColumn = "g7") _
            Or (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "g10") Then
                PaoG5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i5") Then
                PaoG5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "g3") Then
                PaoG5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "d5") _
            Or (TargetLocationRowColumn = "e5") Then
                PaoG5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g6") Then
            If (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "g10") Then
                PaoG6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i6") Then
                PaoG6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g4") Then
                PaoG6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "d6") _
            Or (TargetLocationRowColumn = "e6") Then
                PaoG6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g7") Then
            If (TargetLocationRowColumn = "g9") _
            Or (TargetLocationRowColumn = "g10") Then
                PaoG7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i7") Then
                PaoG7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "g5") Then
                PaoG7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "e7") Then
                PaoG7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g8") Then
            If (TargetLocationRowColumn = "g10") Then
                PaoG8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i8") Then
                PaoG8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "g5") Or (TargetLocationRowColumn = "g6") Then
                PaoG8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "b8") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "d8") _
            Or (TargetLocationRowColumn = "e8") Then
                PaoG8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g9") Then
            If (TargetLocationRowColumn = "i9") Then
                PaoG9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "g5") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "g7") Then
                PaoG9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "c9") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "e9") Then
                PaoG9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g10") Then
            If (TargetLocationRowColumn = "i10") Then
                PaoG10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "g2") _
            Or (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g4") _
            Or (TargetLocationRowColumn = "g5") Or (TargetLocationRowColumn = "g6") _
            Or (TargetLocationRowColumn = "g7") Or (TargetLocationRowColumn = "g8") Then
                PaoG10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "b10") _
            Or (TargetLocationRowColumn = "c10") Or (TargetLocationRowColumn = "d10") _
            Or (TargetLocationRowColumn = "e10") Then
                PaoG10WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h1") Then
            If (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "h4") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "h6") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "h8") _
            Or (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "h10") Then
                PaoH1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "b1") _
            Or (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "d1") _
            Or (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "f1") Then
                PaoH1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h2") Then
            If (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "h5") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "h7") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "h9") _
            Or (TargetLocationRowColumn = "h10") Then
                PaoH2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "c2") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "e2") Or (TargetLocationRowColumn = "f2") Then
                PaoH2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h3") Then
            If (TargetLocationRowColumn = "h5") _
            Or (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "h7") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "h9") _
            Or (TargetLocationRowColumn = "h10") Then
                PaoH3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Then
                PaoH3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "b3") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "d3") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "f3") Then
                PaoH3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h4") Then
            If (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "h7") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "h9") _
            Or (TargetLocationRowColumn = "h10") Then
                PaoH4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") Then
                PaoH4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "e4") Or (TargetLocationRowColumn = "f4") Then
                PaoH4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h5") Then
            If (TargetLocationRowColumn = "h7") _
            Or (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "h9") _
            Or (TargetLocationRowColumn = "h10") Then
                PaoH5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") _
            Or (TargetLocationRowColumn = "h3") Then
                PaoH5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "d5") _
            Or (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "f5") Then
                PaoH5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h6") Then
            If (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "h9") _
            Or (TargetLocationRowColumn = "h10") Then
                PaoH6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "h4") Then
                PaoH6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "d6") _
            Or (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "f6") Then
                PaoH6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h7") Then
            If (TargetLocationRowColumn = "h9") _
            Or (TargetLocationRowColumn = "h10") Then
                PaoH7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "h4") _
            Or (TargetLocationRowColumn = "h5") Then
                PaoH7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "e7") Or (TargetLocationRowColumn = "f7") Then
                PaoH7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h8") Then
            If (TargetLocationRowColumn = "h10") Then
                PaoH8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "h4") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "h6") Then
                PaoH8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "b8") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "d8") _
            Or (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "f8") Then
                PaoH8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h9") Then
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "h4") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "h6") _
            Or (TargetLocationRowColumn = "h7") Then
                PaoH9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "c9") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "e9") Or (TargetLocationRowColumn = "f9") Then
                PaoH9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h10") Then
            If (TargetLocationRowColumn = "h1") Or (TargetLocationRowColumn = "h2") _
            Or (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "h4") _
            Or (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "h6") _
            Or (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "h8") Then
                PaoH10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "b10") _
            Or (TargetLocationRowColumn = "c10") Or (TargetLocationRowColumn = "d10") _
            Or (TargetLocationRowColumn = "e10") Or (TargetLocationRowColumn = "f10") Then
                PaoH10WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i1") Then
            If (TargetLocationRowColumn = "i3") Or (TargetLocationRowColumn = "i4") _
            Or (TargetLocationRowColumn = "i5") Or (TargetLocationRowColumn = "i6") _
            Or (TargetLocationRowColumn = "i7") Or (TargetLocationRowColumn = "i8") _
            Or (TargetLocationRowColumn = "i9") Or (TargetLocationRowColumn = "i10") Then
                PaoI1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "b1") _
            Or (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "d1") _
            Or (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "f1") _
            Or (TargetLocationRowColumn = "g1") Then
                PaoI1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i2") Then
            If (TargetLocationRowColumn = "i4") Or (TargetLocationRowColumn = "i5") _
            Or (TargetLocationRowColumn = "i6") Or (TargetLocationRowColumn = "i7") _
            Or (TargetLocationRowColumn = "i8") Or (TargetLocationRowColumn = "i9") _
            Or (TargetLocationRowColumn = "i10") Then
                PaoI2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Or (TargetLocationRowColumn = "a2") _
            Or (TargetLocationRowColumn = "c2") Or (TargetLocationRowColumn = "d2") _
            Or (TargetLocationRowColumn = "e2") Or (TargetLocationRowColumn = "f2") _
            Or (TargetLocationRowColumn = "g2") Then
                PaoI2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i3") Then
            If (TargetLocationRowColumn = "i5") _
            Or (TargetLocationRowColumn = "i6") Or (TargetLocationRowColumn = "i7") _
            Or (TargetLocationRowColumn = "i8") Or (TargetLocationRowColumn = "i9") _
            Or (TargetLocationRowColumn = "i10") Then
                PaoI3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Then
                PaoI3SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "b3") _
            Or (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "d3") _
            Or (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "f3") _
            Or (TargetLocationRowColumn = "g3") Then
                PaoI3WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i4") Then
            If (TargetLocationRowColumn = "i6") Or (TargetLocationRowColumn = "i7") _
            Or (TargetLocationRowColumn = "i8") Or (TargetLocationRowColumn = "i9") _
            Or (TargetLocationRowColumn = "i10") Then
                PaoI4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") Then
                PaoI4SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "b4") _
            Or (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "d4") _
            Or (TargetLocationRowColumn = "e4") Or (TargetLocationRowColumn = "f4") _
            Or (TargetLocationRowColumn = "g4") Then
                PaoI4WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i5") Then
            If (TargetLocationRowColumn = "i7") _
            Or (TargetLocationRowColumn = "i8") Or (TargetLocationRowColumn = "i9") _
            Or (TargetLocationRowColumn = "i10") Then
                PaoI5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") _
            Or (TargetLocationRowColumn = "i3") Then
                PaoI5SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "b5") _
            Or (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "d5") _
            Or (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "f5") _
            Or (TargetLocationRowColumn = "g5") Then
                PaoI5WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i6") Then
            If (TargetLocationRowColumn = "i8") Or (TargetLocationRowColumn = "i9") _
            Or (TargetLocationRowColumn = "i10") Then
                PaoI6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") _
            Or (TargetLocationRowColumn = "i3") Or (TargetLocationRowColumn = "i4") Then
                PaoI6SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "b6") _
            Or (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "d6") _
            Or (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "f6") _
            Or (TargetLocationRowColumn = "g6") Then
                PaoI6WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i7") Then
            If (TargetLocationRowColumn = "i9") _
            Or (TargetLocationRowColumn = "i10") Then
                PaoI7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") _
            Or (TargetLocationRowColumn = "i3") Or (TargetLocationRowColumn = "i4") _
            Or (TargetLocationRowColumn = "i5") Then
                PaoI7SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "b7") _
            Or (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "d7") _
            Or (TargetLocationRowColumn = "e7") Or (TargetLocationRowColumn = "f7") _
            Or (TargetLocationRowColumn = "g7") Then
                PaoI7WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i8") Then
            If (TargetLocationRowColumn = "i10") Then
                PaoI8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") _
            Or (TargetLocationRowColumn = "i3") Or (TargetLocationRowColumn = "i4") _
            Or (TargetLocationRowColumn = "i5") Or (TargetLocationRowColumn = "i6") Then
                PaoI8SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "b8") _
            Or (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "d8") _
            Or (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "f8") _
            Or (TargetLocationRowColumn = "g8") Then
                PaoI8WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i9") Then
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") _
            Or (TargetLocationRowColumn = "i3") Or (TargetLocationRowColumn = "i4") _
            Or (TargetLocationRowColumn = "i5") Or (TargetLocationRowColumn = "i6") _
            Or (TargetLocationRowColumn = "i7") Then
                PaoI9SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "b9") _
            Or (TargetLocationRowColumn = "c9") Or (TargetLocationRowColumn = "d9") _
            Or (TargetLocationRowColumn = "e9") Or (TargetLocationRowColumn = "f9") _
            Or (TargetLocationRowColumn = "g9") Then
                PaoI9WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i10") Then
            If (TargetLocationRowColumn = "i1") Or (TargetLocationRowColumn = "i2") _
            Or (TargetLocationRowColumn = "i3") Or (TargetLocationRowColumn = "i4") _
            Or (TargetLocationRowColumn = "i5") Or (TargetLocationRowColumn = "i6") _
            Or (TargetLocationRowColumn = "i7") Or (TargetLocationRowColumn = "i8") Then
                PaoI10SouthMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "b10") _
            Or (TargetLocationRowColumn = "c10") Or (TargetLocationRowColumn = "d10") _
            Or (TargetLocationRowColumn = "e10") Or (TargetLocationRowColumn = "f10") _
            Or (TargetLocationRowColumn = "g10") Then
                PaoI10WestMovementArea()
            End If
        End If
    End Sub

    Public Sub CheckMaAvailableBlock()
        If (EnemyAttackerLocation = "a1") Then
            If (TargetLocationRowColumn = "b3") Then
                MaA1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c2") Then
                MaA1EastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a2") Then
            If (TargetLocationRowColumn = "b4") Then
                MaA2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c1") Then
                MaA2EastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a3") Then
            If (TargetLocationRowColumn = "b5") Then
                MaA3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "c2") Then
                MaA3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Then
                MaA3SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a4") Then
            If (TargetLocationRowColumn = "b6") Then
                MaA4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "c3") Then
                MaA4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b2") Then
                MaA4SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a5") Then
            If (TargetLocationRowColumn = "b7") Then
                MaA5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "c4") Then
                MaA5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b3") Then
                MaA5SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a6") Then
            If (TargetLocationRowColumn = "b8") Then
                MaA6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "c5") Then
                MaA6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b4") Then
                MaA6SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a7") Then
            If (TargetLocationRowColumn = "b9") Then
                MaA7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "c6") Then
                MaA7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b5") Then
                MaA7SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a8") Then
            If (TargetLocationRowColumn = "b10") Then
                MaA8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c9") Or (TargetLocationRowColumn = "c7") Then
                MaA8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b6") Then
                MaA8SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a9") Then
            If (TargetLocationRowColumn = "c10") Or (TargetLocationRowColumn = "c8") Then
                MaA9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b7") Then
                MaA9SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a10") Then
            If (TargetLocationRowColumn = "c9") Then
                MaA10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b8") Then
                MaA10SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b1") Then
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "c3") Then
                MaB1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d2") Then
                MaB1EastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b2") Then
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "c4") Then
                MaB2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d1") Then
                MaB2EastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b3") Then
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "c5") Then
                MaB3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d4") Or (TargetLocationRowColumn = "d2") Then
                MaB3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a1") Or (TargetLocationRowColumn = "c1") Then
                MaB3SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b4") Then
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "c6") Then
                MaB4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "d3") Then
                MaB4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Or (TargetLocationRowColumn = "c2") Then
                MaB4SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b5") Then
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "c7") Then
                MaB5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "d4") Then
                MaB5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "c3") Then
                MaB5SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b6") Then
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "c8") Then
                MaB6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d7") Or (TargetLocationRowColumn = "d5") Then
                MaB6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "c4") Then
                MaB6SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b7") Then
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "c9") Then
                MaB7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "d6") Then
                MaB7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "c5") Then
                MaB7SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b8") Then
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "c10") Then
                MaB8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d9") Or (TargetLocationRowColumn = "d7") Then
                MaB8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "c6") Then
                MaB8SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b9") Then
            If (TargetLocationRowColumn = "d10") Or (TargetLocationRowColumn = "d8") Then
                MaB9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "c7") Then
                MaB9SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "b10") Then
            If (TargetLocationRowColumn = "d9") Then
                MaB10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "c8") Then
                MaB10SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c1") Then
            If (TargetLocationRowColumn = "e2") Then
                MaC1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "d3") Then
                MaC1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a2") Then
                MaC1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c2") Then
            If (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e1") Then
                MaC2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b4") Or (TargetLocationRowColumn = "d4") Then
                MaC2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a3") Or (TargetLocationRowColumn = "a1") Then
                MaC2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c3") Then
            If (TargetLocationRowColumn = "e4") Or (TargetLocationRowColumn = "e2") Then
                MaC3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b5") Or (TargetLocationRowColumn = "d5") Then
                MaC3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a4") Or (TargetLocationRowColumn = "a2") Then
                MaC3WestMovementArea()
            End If
            If (TargetLocationRowColumn = "b1") Or (TargetLocationRowColumn = "d1") Then
                MaC3SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c4") Then
            If (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "e3") Then
                MaC4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b6") Or (TargetLocationRowColumn = "d6") Then
                MaC4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a5") Or (TargetLocationRowColumn = "a3") Then
                MaC4WestMovementArea()
            End If
            If (TargetLocationRowColumn = "b2") Or (TargetLocationRowColumn = "d2") Then
                MaC4SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c5") Then
            If (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "e4") Then
                MaC5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b7") Or (TargetLocationRowColumn = "d7") Then
                MaC5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a6") Or (TargetLocationRowColumn = "a4") Then
                MaC5WestMovementArea()
            End If
            If (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "d3") Then
                MaC5SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c6") Then
            If (TargetLocationRowColumn = "e7") Or (TargetLocationRowColumn = "e5") Then
                MaC6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b8") Or (TargetLocationRowColumn = "d8") Then
                MaC6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a7") Or (TargetLocationRowColumn = "a5") Then
                MaC6WestMovementArea()
            End If
            If (TargetLocationRowColumn = "b4") Or (TargetLocationRowColumn = "d4") Then
                MaC6SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c7") Then
            If (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "e6") Then
                MaC7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b9") Or (TargetLocationRowColumn = "d9") Then
                MaC7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a8") Or (TargetLocationRowColumn = "a6") Then
                MaC7WestMovementArea()
            End If
            If (TargetLocationRowColumn = "b5") Or (TargetLocationRowColumn = "d5") Then
                MaC7SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c8") Then
            If (TargetLocationRowColumn = "e9") Or (TargetLocationRowColumn = "e7") Then
                MaC8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b10") Or (TargetLocationRowColumn = "d10") Then
                MaC8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Or (TargetLocationRowColumn = "a7") Then
                MaC8WestMovementArea()
            End If
            If (TargetLocationRowColumn = "b6") Or (TargetLocationRowColumn = "d6") Then
                MaC8SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c9") Then
            If (TargetLocationRowColumn = "e10") Or (TargetLocationRowColumn = "e8") Then
                MaC9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a10") Or (TargetLocationRowColumn = "a8") Then
                MaC9WestMovementArea()
            End If
            If (TargetLocationRowColumn = "b7") Or (TargetLocationRowColumn = "d7") Then
                MaC9SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c10") Then
            If (TargetLocationRowColumn = "e9") Then
                MaC10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "a9") Then
                MaC10WestMovementArea()
            End If
            If (TargetLocationRowColumn = "b8") Or (TargetLocationRowColumn = "d8") Then
                MaC10SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d1") Then
            If (TargetLocationRowColumn = "f2") Then
                MaD1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "e3") Then
                MaD1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "b2") Then
                MaD1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d2") Then
            If (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f1") Then
                MaD2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "e4") Then
                MaD2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "b3") Or (TargetLocationRowColumn = "b1") Then
                MaD2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d3") Then
            If (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "f2") Then
                MaD3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "e5") Then
                MaD3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "b4") Or (TargetLocationRowColumn = "b2") Then
                MaD3WestMovementArea()
            End If
            If (TargetLocationRowColumn = "c1") Or (TargetLocationRowColumn = "e1") Then
                MaD3SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d4") Then
            If (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "f3") Then
                MaD4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "e6") Then
                MaD4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "b5") Or (TargetLocationRowColumn = "b3") Then
                MaD4WestMovementArea()
            End If
            If (TargetLocationRowColumn = "c2") Or (TargetLocationRowColumn = "e2") Then
                MaD4SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d5") Then
            If (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "f4") Then
                MaD5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "e7") Then
                MaD5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "b6") Or (TargetLocationRowColumn = "b4") Then
                MaD5WestMovementArea()
            End If
            If (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "e3") Then
                MaD5SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d6") Then
            If (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "f5") Then
                MaD6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "e8") Then
                MaD6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "b7") Or (TargetLocationRowColumn = "b5") Then
                MaD6WestMovementArea()
            End If
            If (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "e4") Then
                MaD6SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d7") Then
            If (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "f6") Then
                MaD7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c9") Or (TargetLocationRowColumn = "e9") Then
                MaD7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "b8") Or (TargetLocationRowColumn = "b6") Then
                MaD7WestMovementArea()
            End If
            If (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "e5") Then
                MaD7SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d8") Then
            If (TargetLocationRowColumn = "f9") Or (TargetLocationRowColumn = "f7") Then
                MaD8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c10") Or (TargetLocationRowColumn = "e10") Then
                MaD8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "b9") Or (TargetLocationRowColumn = "b7") Then
                MaD8WestMovementArea()
            End If
            If (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "e6") Then
                MaD8SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d9") Then
            If (TargetLocationRowColumn = "f10") Or (TargetLocationRowColumn = "f8") Then
                MaD9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b10") Or (TargetLocationRowColumn = "b8") Then
                MaD9WestMovementArea()
            End If
            If (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "e7") Then
                MaD9SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "d10") Then
            If (TargetLocationRowColumn = "f9") Then
                MaD10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "b9") Then
                MaD10WestMovementArea()
            End If
            If (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "e8") Then
                MaD10SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e1") Then
            If (TargetLocationRowColumn = "g2") Then
                MaE1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "f3") Then
                MaE1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c2") Then
                MaE1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e2") Then
            If (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g1") Then
                MaE2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d4") Or (TargetLocationRowColumn = "f4") Then
                MaE2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c3") Or (TargetLocationRowColumn = "c1") Then
                MaE2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e3") Then
            If (TargetLocationRowColumn = "g4") Or (TargetLocationRowColumn = "g2") Then
                MaE3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "f5") Then
                MaE3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c4") Or (TargetLocationRowColumn = "c2") Then
                MaE3WestMovementArea()
            End If
            If (TargetLocationRowColumn = "d1") Or (TargetLocationRowColumn = "f1") Then
                MaE3SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e4") Then
            If (TargetLocationRowColumn = "g5") Or (TargetLocationRowColumn = "g3") Then
                MaE4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "f6") Then
                MaE4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c5") Or (TargetLocationRowColumn = "c3") Then
                MaE4WestMovementArea()
            End If
            If (TargetLocationRowColumn = "d2") Or (TargetLocationRowColumn = "f2") Then
                MaE4SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e5") Then
            If (TargetLocationRowColumn = "g6") Or (TargetLocationRowColumn = "g4") Then
                MaE5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d7") Or (TargetLocationRowColumn = "f7") Then
                MaE5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c6") Or (TargetLocationRowColumn = "c4") Then
                MaE5WestMovementArea()
            End If
            If (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "f3") Then
                MaE5SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e6") Then
            If (TargetLocationRowColumn = "g7") Or (TargetLocationRowColumn = "g5") Then
                MaE6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "f8") Then
                MaE6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c7") Or (TargetLocationRowColumn = "c5") Then
                MaE6WestMovementArea()
            End If
            If (TargetLocationRowColumn = "d4") Or (TargetLocationRowColumn = "f4") Then
                MaE6SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e7") Then
            If (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "g6") Then
                MaE7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d9") Or (TargetLocationRowColumn = "f9") Then
                MaE7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c8") Or (TargetLocationRowColumn = "c6") Then
                MaE7WestMovementArea()
            End If
            If (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "f5") Then
                MaE7SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e8") Then
            If (TargetLocationRowColumn = "g9") Or (TargetLocationRowColumn = "g7") Then
                MaE8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d10") Or (TargetLocationRowColumn = "f10") Then
                MaE8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "c9") Or (TargetLocationRowColumn = "c7") Then
                MaE8WestMovementArea()
            End If
            If (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "f6") Then
                MaE8SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e9") Then
            If (TargetLocationRowColumn = "g10") Or (TargetLocationRowColumn = "g8") Then
                MaE9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c10") Or (TargetLocationRowColumn = "c8") Then
                MaE9WestMovementArea()
            End If
            If (TargetLocationRowColumn = "d7") Or (TargetLocationRowColumn = "f7") Then
                MaE9SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e10") Then
            If (TargetLocationRowColumn = "g9") Then
                MaE10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "c9") Then
                MaE10WestMovementArea()
            End If
            If (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "f8") Then
                MaE10SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f1") Then
            If (TargetLocationRowColumn = "h2") Then
                MaF1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "g3") Then
                MaF1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d2") Then
                MaF1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f2") Then
            If (TargetLocationRowColumn = "h3") Or (TargetLocationRowColumn = "h1") Then
                MaF2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e4") Or (TargetLocationRowColumn = "g4") Then
                MaF2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d3") Or (TargetLocationRowColumn = "d1") Then
                MaF2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f3") Then
            If (TargetLocationRowColumn = "h4") Or (TargetLocationRowColumn = "h2") Then
                MaF3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "g5") Then
                MaF3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d4") Or (TargetLocationRowColumn = "d2") Then
                MaF3WestMovementArea()
            End If
            If (TargetLocationRowColumn = "e1") Or (TargetLocationRowColumn = "g1") Then
                MaF3SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f4") Then
            If (TargetLocationRowColumn = "h5") Or (TargetLocationRowColumn = "h3") Then
                MaF4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "g6") Then
                MaF4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d5") Or (TargetLocationRowColumn = "d3") Then
                MaF4WestMovementArea()
            End If
            If (TargetLocationRowColumn = "e2") Or (TargetLocationRowColumn = "g2") Then
                MaF4SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f5") Then
            If (TargetLocationRowColumn = "h6") Or (TargetLocationRowColumn = "h4") Then
                MaF5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e7") Or (TargetLocationRowColumn = "g7") Then
                MaF5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d6") Or (TargetLocationRowColumn = "d4") Then
                MaF5WestMovementArea()
            End If
            If (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "g3") Then
                MaF5SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f6") Then
            If (TargetLocationRowColumn = "h7") Or (TargetLocationRowColumn = "h5") Then
                MaF6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "g8") Then
                MaF6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d7") Or (TargetLocationRowColumn = "d5") Then
                MaF6WestMovementArea()
            End If
            If (TargetLocationRowColumn = "e4") Or (TargetLocationRowColumn = "g4") Then
                MaF6SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f7") Then
            If (TargetLocationRowColumn = "h8") Or (TargetLocationRowColumn = "h6") Then
                MaF7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e9") Or (TargetLocationRowColumn = "g9") Then
                MaF7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d8") Or (TargetLocationRowColumn = "d6") Then
                MaF7WestMovementArea()
            End If
            If (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "g5") Then
                MaF7SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f8") Then
            If (TargetLocationRowColumn = "h9") Or (TargetLocationRowColumn = "h7") Then
                MaF8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e10") Or (TargetLocationRowColumn = "g10") Then
                MaF8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "d9") Or (TargetLocationRowColumn = "d7") Then
                MaF8WestMovementArea()
            End If
            If (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "g6") Then
                MaF8SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f9") Then
            If (TargetLocationRowColumn = "h10") Or (TargetLocationRowColumn = "h8") Then
                MaF9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d10") Or (TargetLocationRowColumn = "d8") Then
                MaF9WestMovementArea()
            End If
            If (TargetLocationRowColumn = "e7") Or (TargetLocationRowColumn = "g7") Then
                MaF9SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "f10") Then
            If (TargetLocationRowColumn = "h9") Then
                MaF10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "d9") Then
                MaF10WestMovementArea()
            End If
            If (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "g8") Then
                MaF10SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g1") Then
            If (TargetLocationRowColumn = "i2") Then
                MaG1EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "h3") Then
                MaG1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e2") Then
                MaG1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g2") Then
            If (TargetLocationRowColumn = "i3") Or (TargetLocationRowColumn = "i1") Then
                MaG2EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "h4") Then
                MaG2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e3") Or (TargetLocationRowColumn = "e1") Then
                MaG2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g3") Then
            If (TargetLocationRowColumn = "i4") Or (TargetLocationRowColumn = "i2") Then
                MaG3EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "h5") Then
                MaG3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e4") Or (TargetLocationRowColumn = "e2") Then
                MaG3WestMovementArea()
            End If
            If (TargetLocationRowColumn = "f1") Or (TargetLocationRowColumn = "h1") Then
                MaG3SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g4") Then
            If (TargetLocationRowColumn = "i5") Or (TargetLocationRowColumn = "i3") Then
                MaG4EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "h6") Then
                MaG4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e5") Or (TargetLocationRowColumn = "e3") Then
                MaG4WestMovementArea()
            End If
            If (TargetLocationRowColumn = "f2") Or (TargetLocationRowColumn = "h2") Then
                MaG4SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g5") Then
            If (TargetLocationRowColumn = "i6") Or (TargetLocationRowColumn = "i4") Then
                MaG5EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "h7") Then
                MaG5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e6") Or (TargetLocationRowColumn = "e4") Then
                MaG5WestMovementArea()
            End If
            If (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "h3") Then
                MaG5SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g6") Then
            If (TargetLocationRowColumn = "i7") Or (TargetLocationRowColumn = "i5") Then
                MaG6EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "h8") Then
                MaG6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e7") Or (TargetLocationRowColumn = "e5") Then
                MaG6WestMovementArea()
            End If
            If (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "h4") Then
                MaG6SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g7") Then
            If (TargetLocationRowColumn = "i8") Or (TargetLocationRowColumn = "i6") Then
                MaG7EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f9") Or (TargetLocationRowColumn = "h9") Then
                MaG7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e8") Or (TargetLocationRowColumn = "e6") Then
                MaG7WestMovementArea()
            End If
            If (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "h5") Then
                MaG7SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g8") Then
            If (TargetLocationRowColumn = "i9") Or (TargetLocationRowColumn = "i7") Then
                MaG8EastMovementArea()
            End If
            If (TargetLocationRowColumn = "f10") Or (TargetLocationRowColumn = "h10") Then
                MaG8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "e9") Or (TargetLocationRowColumn = "e7") Then
                MaG8WestMovementArea()
            End If
            If (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "h6") Then
                MaG8SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g9") Then
            If (TargetLocationRowColumn = "i10") Or (TargetLocationRowColumn = "i8") Then
                MaG9EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e10") Or (TargetLocationRowColumn = "e8") Then
                MaG9WestMovementArea()
            End If
            If (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "h7") Then
                MaG9SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g10") Then
            If (TargetLocationRowColumn = "i9") Then
                MaG10EastMovementArea()
            End If
            If (TargetLocationRowColumn = "e9") Then
                MaG10WestMovementArea()
            End If
            If (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "h8") Then
                MaG10SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h1") Then
            If (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "i3") Then
                MaH1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f2") Then
                MaH1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h2") Then
            If (TargetLocationRowColumn = "g4") Or (TargetLocationRowColumn = "i4") Then
                MaH2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f3") Or (TargetLocationRowColumn = "f1") Then
                MaH2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h3") Then
            If (TargetLocationRowColumn = "g5") Or (TargetLocationRowColumn = "i5") Then
                MaH3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f4") Or (TargetLocationRowColumn = "f2") Then
                MaH3WestMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Or (TargetLocationRowColumn = "i1") Then
                MaH3SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h4") Then
            If (TargetLocationRowColumn = "g6") Or (TargetLocationRowColumn = "i6") Then
                MaH4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f5") Or (TargetLocationRowColumn = "f3") Then
                MaH4WestMovementArea()
            End If
            If (TargetLocationRowColumn = "g2") Or (TargetLocationRowColumn = "i2") Then
                MaH4SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h5") Then
            If (TargetLocationRowColumn = "g7") Or (TargetLocationRowColumn = "i7") Then
                MaH5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f6") Or (TargetLocationRowColumn = "f4") Then
                MaH5WestMovementArea()
            End If
            If (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "i3") Then
                MaH5SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h6") Then
            If (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "i8") Then
                MaH6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f7") Or (TargetLocationRowColumn = "f5") Then
                MaH6WestMovementArea()
            End If
            If (TargetLocationRowColumn = "g4") Or (TargetLocationRowColumn = "i4") Then
                MaH6SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h7") Then
            If (TargetLocationRowColumn = "g9") Or (TargetLocationRowColumn = "i9") Then
                MaH7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f8") Or (TargetLocationRowColumn = "f6") Then
                MaH7WestMovementArea()
            End If
            If (TargetLocationRowColumn = "g5") Or (TargetLocationRowColumn = "i5") Then
                MaH7SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h8") Then
            If (TargetLocationRowColumn = "g10") Or (TargetLocationRowColumn = "i10") Then
                MaH8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "f9") Or (TargetLocationRowColumn = "f7") Then
                MaH8WestMovementArea()
            End If
            If (TargetLocationRowColumn = "g6") Or (TargetLocationRowColumn = "i6") Then
                MaH8SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h9") Then
            If (TargetLocationRowColumn = "f10") Or (TargetLocationRowColumn = "f8") Then
                MaH9WestMovementArea()
            End If
            If (TargetLocationRowColumn = "g7") Or (TargetLocationRowColumn = "i7") Then
                MaH9SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "h10") Then
            If (TargetLocationRowColumn = "f9") Then
                MaH10WestMovementArea()
            End If
            If (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "i8") Then
                MaH10SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i1") Then
            If (TargetLocationRowColumn = "h3") Then
                MaI1NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g2") Then
                MaI1WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i2") Then
            If (TargetLocationRowColumn = "h4") Then
                MaI2NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g3") Or (TargetLocationRowColumn = "g1") Then
                MaI2WestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i3") Then
            If (TargetLocationRowColumn = "h5") Then
                MaI3NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g4") Or (TargetLocationRowColumn = "g2") Then
                MaI3WestMovementArea()
            End If
            If (TargetLocationRowColumn = "g1") Then
                MaI3SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i4") Then
            If (TargetLocationRowColumn = "h6") Then
                MaI4NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g5") Or (TargetLocationRowColumn = "g3") Then
                MaI4WestMovementArea()
            End If
            If (TargetLocationRowColumn = "h2") Then
                MaI4SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i5") Then
            If (TargetLocationRowColumn = "h7") Then
                MaI5NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g6") Or (TargetLocationRowColumn = "g4") Then
                MaI5WestMovementArea()
            End If
            If (TargetLocationRowColumn = "h3") Then
                MaI5SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i6") Then
            If (TargetLocationRowColumn = "h8") Then
                MaI6NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g7") Or (TargetLocationRowColumn = "g5") Then
                MaI6WestMovementArea()
            End If
            If (TargetLocationRowColumn = "h4") Then
                MaI6SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i7") Then
            If (TargetLocationRowColumn = "h9") Then
                MaI7NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g8") Or (TargetLocationRowColumn = "g6") Then
                MaI7WestMovementArea()
            End If
            If (TargetLocationRowColumn = "h5") Then
                MaI7SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i8") Then
            If (TargetLocationRowColumn = "h10") Then
                MaI8NorthMovementArea()
            End If
            If (TargetLocationRowColumn = "g9") Or (TargetLocationRowColumn = "g7") Then
                MaI8WestMovementArea()
            End If
            If (TargetLocationRowColumn = "h6") Then
                MaI8SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i9") Then
            If (TargetLocationRowColumn = "g10") Or (TargetLocationRowColumn = "g8") Then
                MaI9WestMovementArea()
            End If
            If (TargetLocationRowColumn = "h7") Then
                MaI9SouthMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i10") Then
            If (TargetLocationRowColumn = "g9") Then
                MaI10WestMovementArea()
            End If
            If (TargetLocationRowColumn = "h8") Then
                MaI10SouthMovementArea()
            End If
        End If
    End Sub

    Public Sub CheckXiangAvailableBlock()
        If (EnemyAttackerLocation = "a3") Then
            If (TargetLocationRowColumn = "c1") Then
                BlackXiangA3SouthEastMovementArea()
            ElseIf (TargetLocationRowColumn = "c5") Then
                BlackXiangA3NorthEastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c1") Then
            If (TargetLocationRowColumn = "a3") Then
                BlackXiangC1NorthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "e3") Then
                BlackXiangC1NorthEastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c5") Then
            If (TargetLocationRowColumn = "a3") Then
                BlackXiangC5SouthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "e3") Then
                BlackXiangC5SouthEastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e3") Then
            If (TargetLocationRowColumn = "c1") Then
                BlackXiangE3SouthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "c5") Then
                BlackXiangE3NorthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "g1") Then
                BlackXiangE3SouthEastMovementArea()
            ElseIf (TargetLocationRowColumn = "g5") Then
                BlackXiangE3NorthEastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g1") Then
            If (TargetLocationRowColumn = "e3") Then
                BlackXiangG1NorthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "i3") Then
                BlackXiangG1NorthEastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g5") Then
            If (TargetLocationRowColumn = "e3") Then
                BlackXiangG5SouthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "i3") Then
                BlackXiangG5SouthEastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i3") Then
            If (TargetLocationRowColumn = "g1") Then
                BlackXiangI3SouthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "g5") Then
                BlackXiangI3NorthWestMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "a8") Then
            If (TargetLocationRowColumn = "c6") Then
                WhiteXiangA8SouthEastMovementArea()
            ElseIf (TargetLocationRowColumn = "c10") Then
                WhiteXiangA8NorthEastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c6") Then
            If (TargetLocationRowColumn = "a8") Then
                WhiteXiangC6NorthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "e8") Then
                WhiteXiangC6NorthEastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "c10") Then
            If (TargetLocationRowColumn = "a8") Then
                WhiteXiangC10SouthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "e8") Then
                WhiteXiangC10SouthEastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "e8") Then
            If (TargetLocationRowColumn = "c6") Then
                WhiteXiangE8SouthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "c10") Then
                WhiteXiangE8NorthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "g6") Then
                WhiteXiangE8SouthEastMovementArea()
            ElseIf (TargetLocationRowColumn = "g10") Then
                WhiteXiangE8NorthEastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g6") Then
            If (TargetLocationRowColumn = "e8") Then
                WhiteXiangG6NorthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "i8") Then
                WhiteXiangG6NorthEastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "g10") Then
            If (TargetLocationRowColumn = "e8") Then
                WhiteXiangG10SouthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "i8") Then
                WhiteXiangG10SouthEastMovementArea()
            End If
        ElseIf (EnemyAttackerLocation = "i8") Then
            If (TargetLocationRowColumn = "g6") Then
                WhiteXiangI8SouthWestMovementArea()
            ElseIf (TargetLocationRowColumn = "g10") Then
                WhiteXiangI8NorthWestMovementArea()
            End If
        End If
    End Sub
End Module
