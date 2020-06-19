Imports FinalGameProject

Public Class GameStatus

    ' --------------- START: EDITABLE FIELDS ---------------
    Public Const TILE_SIZE = 32
    Public Const MAP_SIZE_X = 16
    Public Const MAP_SIZE_Y = MAP_SIZE_X

    ' To slow down the animation, increase the cooldown & vice-versa
    Private Const ANIMATION_COOLDOWN = 10
    Private score As Integer = 0

    Private background As BackgroundLayer
    Private characters As CharactersLayer
    '--------------- END: EDITABLE FIELDS ---------------

    Protected Friend spriteMap As Hashtable

    Protected Friend graphicsLayers As List(Of GraphicsLayer) = New List(Of GraphicsLayer)
    Private animationMode As AnimationMode = AnimationMode.Run
    Private animationTick As Integer = ANIMATION_COOLDOWN

    Protected Friend currentLevel As Integer


    Public Sub New()
        ' You can add more Layers here. They render in (first = bottom)-->(last = top) order.
        ' Therefore, you can think of the graphicsLayer's index as the z-index.
        background = New BackgroundLayer(Me)
        graphicsLayers.Add(background)

        characters = New CharactersLayer(Me)
        graphicsLayers.Add(characters)

    End Sub

    Public Sub InitGame()
        spriteMap = BodyOptions.LoadSprites()
        NewGame()
    End Sub

    Public Sub NewGame()
        score = 0

        ChangeLevel(0)
    End Sub

    Public Sub GameOver()
        score = 0

        ChangeLevel(0)
    End Sub

    Public Sub RestartLevel()
        ChangeLevel(currentLevel)
    End Sub
    Public Sub NextLevel()
        currentLevel += 1
        ChangeLevel(currentLevel)
    End Sub

    Public Function GetScore() As Integer
        Return score
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
        ' TODO increment the "cool-down" until it reaches the ANIMATION_COOLDOWN. Then tell the layers to Animate().
        If animationTick >= ANIMATION_COOLDOWN Then
            animationTick = 0
        Else
            animationTick += 1
            Exit Sub
        End If

        ' Tell each layer to Animate!
        Dim i As Integer
        i = 0
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

End Class
