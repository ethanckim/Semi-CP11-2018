Public Class frmVowls



    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim Input As String = txtText.Text.ToLower

        Dim Vowels As Integer = 0
        Dim Consonants As Integer = 0
        Dim Character As Integer = Input.Count

        'i means index (Programmers are lazy)
        Dim i As Integer = 0
        'index counting starts at 0, 1st index is 0, 2nd is 1...

        '.Count tells us how many Characters
        'Loop
        While i < Input.Count
            Dim c As Char

            c = Input(i)

            If c = "a" Or c = "e" Or c = "i" Or c = "o" Or c = "u" Then
                Vowels += 1
            ElseIf Char.IsLetter(c) Then
                Consonants += 1
            End If


            i += 1
        End While

        txtVowels.Text = Str(Vowels)
        txtConsonants.Text = Str(Consonants)
        txtCharacters.Text = Str(Character)
    End Sub

    Private Sub btnCrazy_Click(sender As Object, e As EventArgs) Handles btnCrazy.Click
        Dim Output As String = ""
        Dim Input As String = txtText.Text.ToLower

        Dim i As Integer = 0

        While i < Input.Count
            Dim c As Char = Input(i)

            If i Mod 2 = 0 Then
                c = Char.ToUpper(c)
                Output += c
            Else
                c = Char.ToLower(c)
                Output += c
            End If

            i += 1
        End While

        txtSpecialOutput.Text = Output
    End Sub

    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        Dim Output As String = ""
        Dim Input As String = txtText.Text

        Dim i As Integer = Input.Count - 1

        While i >= 0
            Dim c As Char = Input(i)

            Output += c

            i -= 1
        End While

        txtSpecialOutput.Text = Output
    End Sub

    Private Sub btnPalindrome_Click(sender As Object, e As EventArgs) Handles btnPalindrome.Click
        Dim Output2 As String = ""
        Dim Output1 As String = txtText.Text
        Dim Input As String = txtText.Text

        Dim i As Integer = Input.Count - 1

        While i >= 0
            Dim c As Char = Input(i)

            Output2 += c

            i -= 1
        End While

        txtSpecialOutput.Text = Output1 + Output2
    End Sub
End Class
