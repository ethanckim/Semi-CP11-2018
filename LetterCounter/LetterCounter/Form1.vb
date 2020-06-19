Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click

        'Reset's Textbox
        txtOutput.Text = ""

        'Stores string value in txtInput in the variable Input as uppercase.
        Dim Input As String = txtInput.Text.ToUpper

        'There are 25 letter variables. Each represent the alphabet.
        'Array - Multiple variables at once!
        'This array is stored outside cuz I want to save the data from loop i, and use it for loop j
        Dim letters(25) As Integer
        'Variable specifically for Punctuation
        Dim punc As Integer = 0
        'Variable specifically for spaces
        Dim space As Integer = 0


        'Loops this code for the amount of characters in the code
        Dim i As Integer = 0
        While i < Input.Count

            'Finds a character in the variable input(depending on loop #) and stores it in the variable c.
            Dim c As Char = Input(i)
            'Variable ascii = ascii number of the character c.
            Dim ascii As Integer = Asc(c)

            If ascii = 33 Or ascii = 44 Or ascii = 46 Or ascii = 63 Then
                punc += 1

            ElseIf ascii = 32 Then
                space += 1

            Else
                ' + 1 the "letters" variable that corrisponds to the ascii code.
                letters(ascii - 65) += 1

            End If

            'Example - First loop, Text: Ethan
            'index = 0 (since it's first loop), so c = E
            'E is converted to 69
            'Add 1 to letters(4)

            i += 1
        End While


        Dim j As Integer = 0
        While j < letters.Length
            'Each time the loop repeats, the ascii variable's ascii code goes up by one. A to Z.
            Dim ascii As Integer = j + 65
            'Prints a character between A - Z, and the value stored on variable letters, ALL depending on the loop #
            txtOutput.Text += Chr(ascii) + " :  " + Str(letters(j)) + vbCrLf

            j += 1
        End While

        txtOutput.Text += "Space :  " + Str(space) + vbCrLf
        txtOutput.Text += "Punc :  " + Str(punc)


    End Sub

    Private Sub btnAscii_Click(sender As Object, e As EventArgs) Handles btnAscii.Click
        Dim Input As String = txtInput.Text
        If Not txtInput.Text = "" Then
            Dim c As Integer = Asc(Input(0))
            txtOutput.Text = c
        End If
    End Sub
End Class
