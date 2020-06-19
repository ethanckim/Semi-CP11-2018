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
    Public Shared ReadOnly B As Char = "B"c
    ' Mushroom
    Public Shared ReadOnly M As Char = "M"c

    Public Shared Function LoadSprites() As Hashtable
        If spriteMap Is Nothing Then
            spriteMap = New Hashtable()
        End If
        If spriteFilenames Is Nothing Then
            spriteFilenames = New Hashtable()
        End If

        ' Load your sprites here. Watch out for capitals, as well as the extension: JPG vs. JPEG vs. GIF vs. PNG.
        ' For best performance, make sure the sprites are 96 pixels/inch in Photoshop (Image - Image Size - Turn off Resample)

        AddSprite(C, "images", "character.png")
        AddSprite(B, "images", "brick.png")
        AddSprite(M, "images", "mushroom.png")


        Return spriteMap
    End Function

    Private Shared Sub AddSprite(c As Char, folder As String, filename As String)
        If Not spriteMap.ContainsKey(c) OrElse spriteMap(c) Is Nothing Then
            spriteMap.Add(c, Image.FromFile(Helpers.GetPath(folder, filename)))
            spriteFilenames.Add(c, filename)
        Else
            Throw New SpriteAlreadyUsedException(c, spriteFilenames(c), filename)
        End If
    End Sub

End Class
