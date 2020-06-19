Imports FinalGameProject

Public Class Character
    Inherits GameBody

    Dim d As Direction = Direction.None

    Dim Animation As Boolean = False
    Dim AnimationStep As Integer = 0

    Dim Backwards As Boolean = False

    Dim HitRedSphere As Boolean = False
    Dim FailRotate As Integer = 0

    Dim FinishLevel As Boolean = False
    Dim SuccessAnimationCount As Integer = 0

    Dim BallForm As Boolean = False
    Dim BallTime As Integer = 0

    Dim YellowBall As Boolean = False

    Dim RingRevealCount As Integer = 0


    Public Sub New(g As GameStatus, x As Integer, y As Integer, bs As Integer, r As Integer)
        MyBase.New(g, x, y)
        game.BSScore = bs
        game.RScore = r
    End Sub

    Public Overrides Function SpriteId() As Char
        Return BodyOptions.C
    End Function

    Protected Friend Overrides Function Collission(ahead As GameBody, dx As Integer, dy As Integer) As Boolean

        If BallForm = True Then
            Return True
            Exit Function
        End If

        If YellowBall = True Then
            Return True
            Exit Function
        End If


        Select Case ahead.SpriteId

            Case BodyOptions.B

                game.Remove(ahead)
                game.background.bodies.Add(New RedSphere(game, ahead.location.X, ahead.location.Y))

                game.BSScore -= 1

                    'Finish Level
                    If game.BSScore <= 0 Then
                        FinishLevel = True
                        d = Direction.None
                        frmPaint.tmrFaster.Enabled = False
                        AutoMove()
                    End If


                Return True

            Case BodyOptions.R
                HitRedSphere = True
                d = Direction.None
                    frmPaint.tmrFaster.Enabled = False
                    AutoMove()
                Return True

            Case BodyOptions.G
                game.Remove(ahead)
                game.background.bodies.Add(New BlueSphere(game, ahead.location.X, ahead.location.Y))

                Return True

            Case BodyOptions.Y
                YellowBall = True
                spriteNum = 8
                game.Animation_Cooldown = game.Animation_Cooldown / 4


            Case BodyOptions.K

                If Backwards = False Then
                        Backwards = True
                    Else
                        Backwards = False
                    End If

                    Select Case d
                        Case Direction.Up
                            d = Direction.Down
                        Case Direction.Left
                            d = Direction.Right
                        Case Direction.Down
                            d = Direction.Up
                        Case Direction.Right
                            d = Direction.Left
                    End Select

                'TODO make sure character doesnt get stuck between bumpers and crashes the game

                Move(d)
                Return False

            Case BodyOptions.I
                game.Remove(ahead)
                game.RScore -= 1

                If game.RScore <= 0 Then
                    game.Perfect = True
                End If
        End Select

        Return True
    End Function

    Public Overrides Sub KeyDown(keyCode As Keys)

        If HitRedSphere Then
            Exit Sub
        End If

        If YellowBall Then
            Exit Sub
        End If

        If BallForm Then
            Exit Sub
        End If

        If FinishLevel Then
            Exit Sub
        End If


        Dim CounterClock As Boolean = False
        Dim ClockWise As Boolean = False

        'First move
        If d = Direction.None Then
            Select Case keyCode

                Case Keys.Left
                    Select Case spriteNum
                        Case 0
                            spriteNum = 2
                        Case 2
                            spriteNum = 4
                        Case 4
                            spriteNum = 6
                        Case 6
                            spriteNum = 0
                    End Select

                Case Keys.Right
                    Select Case spriteNum
                        Case 0
                            spriteNum = 6
                        Case 6
                            spriteNum = 4
                        Case 4
                            spriteNum = 2
                        Case 2
                            spriteNum = 0
                    End Select

                Case Keys.Up
                    frmPaint.tmrFaster.Enabled = True
                    game.Remove(game.characters.t)
                    Select Case spriteNum
                        Case 0
                            d = Direction.Up
                        Case 2
                            d = Direction.Left
                        Case 4
                            d = Direction.Down
                        Case 6
                            d = Direction.Right
                    End Select

            End Select

            Exit Sub
        End If

        'Auto Move
        Select Case keyCode
            'Ez mode {
            Case Keys.W
                d = Direction.Up
                spriteNum = 0
                Exit Sub
            Case Keys.A
                d = Direction.Left
                spriteNum = 2
                Exit Sub
            Case Keys.S
                d = Direction.Down
                spriteNum = 4
                Exit Sub
            Case Keys.D
                d = Direction.Right
                spriteNum = 6
                Exit Sub
            '}

            Case Keys.Left
                If Backwards = False Then
                    CounterClock = True
                Else
                    ClockWise = True
                End If

            Case Keys.Right
                If Backwards = False Then
                    ClockWise = True
                Else
                    CounterClock = True
                End If

            Case Keys.Up
                If Backwards = True Then
                    Backwards = False

                    Select Case d
                        Case Direction.Up
                            d = Direction.Down
                        Case Direction.Left
                            d = Direction.Right
                        Case Direction.Down
                            d = Direction.Up
                        Case Direction.Right
                            d = Direction.Left
                    End Select
                End If

            Case Keys.Space
                BallForm = True
                spriteNum = 8

        End Select

        If CounterClock = True Then
            Select Case d
                Case Direction.Up
                    d = Direction.Left
                    If Backwards = False Then
                        spriteNum = 2
                    Else
                        spriteNum = 6
                    End If

                Case Direction.Left
                    d = Direction.Down
                    If Backwards = False Then
                        spriteNum = 4
                    Else
                        spriteNum = 0
                    End If

                Case Direction.Down
                    d = Direction.Right
                    If Backwards = False Then
                        spriteNum = 6
                    Else
                        spriteNum = 2
                    End If

                Case Direction.Right
                    d = Direction.Up
                    If Backwards = False Then
                        spriteNum = 0
                    Else
                        spriteNum = 4
                    End If

            End Select

        ElseIf ClockWise = True Then
            Select Case d
                Case Direction.Up
                    d = Direction.Right
                    If Backwards = False Then
                        spriteNum = 6
                    Else
                        spriteNum = 2
                    End If

                Case Direction.Right
                    d = Direction.Down
                    If Backwards = False Then
                        spriteNum = 4
                    Else
                        spriteNum = 0
                    End If

                Case Direction.Down
                    d = Direction.Left
                    If Backwards = False Then
                        spriteNum = 2
                    Else
                        spriteNum = 6
                    End If

                Case Direction.Left
                    d = Direction.Up
                    If Backwards = False Then
                        spriteNum = 0
                    Else
                        spriteNum = 4
                    End If

            End Select
        End If

    End Sub

    Public Overrides Sub AutoMove()

        'Fail Animation
        If HitRedSphere = True Then

            If FailRotate <= 3 Then
                game.Animation_Cooldown = 2
            ElseIf FailRotate <= 7 Then
                game.Animation_Cooldown = 1
            ElseIf FailRotate <= 15 Then
                FailRotate = 0
                game.Animation_Cooldown = 8
                game.RestartLevel()
                HitRedSphere = False
		game.Perfect = False
                Exit Sub
            End If

            Select Case spriteNum
                Case 0
                    spriteNum = 2
                Case 2
                    spriteNum = 4
                Case 4
                    spriteNum = 6
                Case 6
                    spriteNum = 0
            End Select

            FailRotate += 1
            Exit Sub
        End If


        'Success Animation
        If FinishLevel = True Then

            game.Animation_Cooldown = 2

            If SuccessAnimationCount >= 3 And SuccessAnimationCount <= 6 Then
                spriteNum = 4
            ElseIf SuccessAnimationCount >= 6 And SuccessAnimationCount <= 15 Then
                spriteNum = 10
            ElseIf SuccessAnimationCount >= 15 Then
                game.Animation_Cooldown = 8
                FinishLevel = False
                SuccessAnimationCount = 0
                game.Perfect = False
                If game.currentLevel = 3 Then
                    game.GameOver()
                End If
                game.NextLevel()
                Exit Sub
            End If

            SuccessAnimationCount += 1
            Exit Sub
        End If


        'Jump
        If BallForm = True Then

            BallTime += 1
            If BallTime >= 3 Then
                BallForm = False
                BallTime = 0
                Select Case d
                    Case Direction.Up
                        spriteNum = 0
                    Case Direction.Left
                        spriteNum = 2
                    Case Direction.Down
                        spriteNum = 4
                    Case Direction.Right
                        spriteNum = 6
                End Select
            End If
        End If

        'Yellow Sphere
        If YellowBall = True Then

            BallTime += 1
            If BallTime >= 11 Then
                YellowBall = False
                BallTime = 0
                game.Animation_Cooldown = game.Animation_Cooldown * 4
                Select Case d
                    Case Direction.Up
                        spriteNum = 0
                    Case Direction.Left
                        spriteNum = 2
                    Case Direction.Down
                        spriteNum = 4
                    Case Direction.Right
                        spriteNum = 6
                End Select
            End If
        End If

        'Animate Character
        If Not d = Direction.None Then
            If AnimationStep = 0 Then
                Select Case spriteNum
                    Case 0
                        spriteNum = 1
                    Case 2
                        spriteNum = 3
                    Case 4
                        spriteNum = 5
                    Case 6
                        spriteNum = 7
                    Case 8
                        spriteNum = 9
                End Select
                AnimationStep += 1
            Else
                Select Case spriteNum
                    Case 1
                        spriteNum = 0
                    Case 3
                        spriteNum = 2
                    Case 5
                        spriteNum = 4
                    Case 7
                        spriteNum = 6
                    Case 9
                        spriteNum = 8
                End Select
                AnimationStep = 0
            End If
        End If

        If AnimationStep = 0 Then

            'Character Automatically moves
            Move(d)

            'Move Camera
            Select Case d
                Case Direction.Up
                    If location.Y <= GameStatus.PLAYFIELD_SIZE_X - (GameStatus.CAM_SIZE_X / 2 + 1) Then
                        game.MoveCam(Direction.Up)
                    End If

                Case Direction.Left
                    If location.X <= GameStatus.PLAYFIELD_SIZE_X - (GameStatus.CAM_SIZE_X / 2 + 1) Then
                        game.MoveCam(Direction.Left)
                    End If

                Case Direction.Down
                    If location.Y >= 5 Then
                        game.MoveCam(Direction.Down)
                    End If

                Case Direction.Right
                    If location.X >= 5 Then
                        game.MoveCam(Direction.Right)
                    End If
            End Select
        End If

    End Sub

End Class
