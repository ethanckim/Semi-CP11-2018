''' <summary>
''' To add a new type of GameBody, choose a char, and add a sprite.
''' 
''' If you don't do both, you won't get the image.
''' </summary>
Public MustInherit Class BodyOptions
    Private Shared spriteMap As Hashtable
    Private Shared spriteFilenames As Hashtable

    ' empty Space
    Public Shared ReadOnly S As Char = "-"c

    ' Character (mario)
    Public Shared ReadOnly C As Char = "C"c

    ' Brick
    Public Shared ReadOnly K As Char = "K"c

    'Blue Sphere
    Public Shared ReadOnly B As Char = "B"c

    'Red Sphere
    Public Shared ReadOnly R As Char = "R"c

    'Green Sphere
    Public Shared ReadOnly G As Char = "G"c

    'Yellow Sphere
    Public Shared ReadOnly Y As Char = "Y"c

    'Ring
    Public Shared ReadOnly I As Char = "I"c

    'Title
    Public Shared ReadOnly T As Char = "T"c

    'MapGround1
    Public Shared ReadOnly M As Char = "M"c

    'MapGround2
    Public Shared ReadOnly N As Char = "N"c

    Public Shared Function LoadSprites() As Hashtable
        If spriteMap Is Nothing Then
            spriteMap = New Hashtable()
        End If
        If spriteFilenames Is Nothing Then
            spriteFilenames = New Hashtable()
        End If

        ' Load your sprites here. Watch out for capitals, as well as the extension: JPG vs. JPEG vs. GIF vs. PNG.
        ' For best performance, make sure the sprites are 96 pixels/inch in Photoshop (Image - Image Size - Turn off Resample)

        AddSprite(C, 0, "images", "characterUp_0.png")
        AddSprite(C, 1, "images", "characterUp_1.png")
        AddSprite(C, 2, "images", "characterLeft_0.png")
        AddSprite(C, 3, "images", "characterLeft_1.png")
        AddSprite(C, 4, "images", "characterDown_0.png")
        AddSprite(C, 5, "images", "characterDown_1.png")
        AddSprite(C, 6, "images", "characterRight_0.png")
        AddSprite(C, 7, "images", "characterRight_1.png")
        AddSprite(C, 8, "images", "BallForm_0.png")
        AddSprite(C, 9, "images", "BallForm_1.png")
        AddSprite(C, 10, "images", "Success.png")


        AddSprite(K, 0, "images", "bumper32-96.png")
        AddSprite(B, 0, "images", "blue32-96.png")
        AddSprite(R, 0, "images", "red32-96.png")
        AddSprite(G, 0, "images", "green32-96.png")
        AddSprite(T, 0, "images", "Title.png")
        AddSprite(Y, 0, "images", "yellow32-96.png")
        AddSprite(I, 0, "images", "Rings.png")

        AddSprite(M, 0, "images", "tile1_1.png")
        AddSprite(N, 0, "images", "tile1_2.png")
        AddSprite(M, 1, "images", "tile2_1.png")
        AddSprite(N, 1, "images", "tile2_2.png")
        AddSprite(M, 2, "images", "tile3_1.png")
        AddSprite(N, 2, "images", "tile3_2.png")

        Return spriteMap
    End Function

    Private Shared Sub AddSprite(id As Char, i As Integer, folder As String, filename As String)
        Dim key As String = id & Str(i).Trim
        If Not spriteMap.ContainsKey(key) OrElse spriteMap(key) Is Nothing Then
            spriteMap.Add(key, Image.FromFile(Helpers.GetPath(folder, filename)))
            spriteFilenames.Add(key, filename)
        Else
            Throw New SpriteAlreadyUsedException(key, spriteFilenames(key), filename)
        End If
    End Sub

    Public Shared Function getSprite(id As Char, i As Integer) As Image
        Dim key As String = id & Str(i).Trim
        Return spriteMap(key)
    End Function

End Class
