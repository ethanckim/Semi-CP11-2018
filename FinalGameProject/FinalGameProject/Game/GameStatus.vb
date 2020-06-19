Imports FinalGameProject

Public Class GameStatus

    ' --------------- START: EDITABLE FIELDS ---------------
    Public Const TILE_SIZE = 32
    Public Const PLAYFIELD_SIZE_X = 32
    Public Const PLAYFIELD_SIZE_Y = PLAYFIELD_SIZE_X
    'Public Const MAP_SIZE_X = 33
    'Public Const MAP_SIZE_Y = MAP_SIZE_X

    Public Const CAM_SIZE_X = 9
    Public Const CAM_SIZE_Y = CAM_SIZE_X

    Public CamX As Integer = 0
    Public CamY As Integer = 0

    ' To slow down the animation, increase the cooldown & vice-versa
    Public Animation_Cooldown = 8
    Public BSScore As Integer = 0
    Public RScore As Integer = 0
    Public Perfect As Boolean = False
    Public BeatGame As Boolean = False

    Public background As BackgroundLayer
    Public characters As CharactersLayer
    Public ground As GroundLayer
    '--------------- END: EDITABLE FIELDS ---------------

    Public Function spriteMap(id As Char, i As Integer) As Image
        Return BodyOptions.getSprite(id, i)
    End Function


    Protected Friend graphicsLayers As List(Of GraphicsLayer) = New List(Of GraphicsLayer)
    Private animationMode As AnimationMode = AnimationMode.Run
    Private animationTick As Integer = Animation_Cooldown

    Protected Friend currentLevel As Integer


    Public Sub New()
        ' You can add more Layers here. They render in (first = bottom)-->(last = top) order.
        ' Therefore, you can think of the graphicsLayer's index as the z-index.

        ground = New GroundLayer(Me)
        graphicsLayers.Add(ground)

        background = New BackgroundLayer(Me)
        graphicsLayers.Add(background)

        characters = New CharactersLayer(Me)
        graphicsLayers.Add(characters)

    End Sub

    Public Sub InitGame()
        BodyOptions.LoadSprites()
        NewGame()
    End Sub

    Public Sub NewGame()

        ChangeLevel(1)
    End Sub

    Public Sub GameOver()

        BeatGame = True

        frmWelcome.Show()
        frmPaint.Hide()
    End Sub

    Public Sub RestartLevel()
        ChangeLevel(currentLevel)
        Perfect = False
    End Sub
    Public Sub NextLevel()
        currentLevel += 1
        ChangeLevel(currentLevel)
        Perfect = False
    End Sub

    Public Function GetBSScore() As Integer
        Return BSScore
    End Function

    Public Function GetRScore() As Integer
        Return RScore
    End Function

    Public Overrides Function ToString() As String
        Return "Cooldown: " + Str(animationTick)
    End Function


    Public Sub ChangeLevel(level As Integer)
        currentLevel = level
        Dim i As Integer = 0
        While i < graphicsLayers.Count
            Dim layer As GraphicsLayer = graphicsLayers(i)
            layer.ChangeLevel(level)

            i += 1
        End While
    End Sub

    Public Sub Remove(target As GameBody)
        Dim i As Integer = 0
        While i < graphicsLayers.Count
            graphicsLayers(i).remove(target)

            i += 1
        End While
    End Sub


    Public Sub AdvanceAnimation()
        'increment the "cool-down" until it reaches the ANIMATION_COOLDOWN.
        If animationTick >= Animation_Cooldown Then
            animationTick = 0
        Else
            animationTick += 1
            Exit Sub
        End If

        'Tell each layer to animate()
        Dim i As Integer = 0
        While i < graphicsLayers.Count
            Dim layer As GraphicsLayer

            layer = graphicsLayers(i)
            layer.Animate()

            i += 1
        End While


    End Sub
    ''' <summary>
    ''' Searches from z-index highest to lowest.
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <returns></returns>
    Public Function LookAhead(x As Integer, y As Integer) As List(Of GameBody)
        Dim i As Integer = graphicsLayers.Count - 1
        Dim ahead As List(Of GameBody) = New List(Of GameBody)
        While i >= 0
            Dim layer As GraphicsLayer = graphicsLayers(i)
            If layer IsNot Nothing Then
                Dim result As GameBody = layer.search(x, y)
                If result IsNot Nothing Then
                    ahead.Add(result)
                End If
            End If
            i -= 1
        End While
        Return ahead
    End Function


    Public Sub MoveCam(d As Direction)
        Dim dx As Integer = xDelta(d)
        Dim dy As Integer = yDelta(d)

        MoveCam(dx, dy)
    End Sub

    Public Sub MoveCam(dx As Integer, dy As Integer)

        Dim x2 As Integer = CamX + dx
        Dim y2 As Integer = CamY + dy


        CamX = Math.Min(PLAYFIELD_SIZE_X - CAM_SIZE_X, Math.Max(0, x2))
        CamY = Math.Min(PLAYFIELD_SIZE_Y - CAM_SIZE_Y, Math.Max(0, y2))


    End Sub

End Class
