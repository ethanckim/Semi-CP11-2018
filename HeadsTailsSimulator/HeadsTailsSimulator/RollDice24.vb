Public Class RollDice24
    Inherits Simulation

    Public Sub New(iter As Integer)
        MyBase.New(iter)
    End Sub

    Protected Overrides Sub RunSimulation()
        While (Not kill) And (i < iterations)

            Dim line As String = ""
            Dim j As Integer = 0
            Dim successfulIteration As Boolean = False

            While j < 24

                Dim FirstDiceNumber As Integer
                FirstDiceNumber = roll()
                Dim SecondDiceNumber As Integer
                SecondDiceNumber = roll()

                line += "[" + Str(FirstDiceNumber) + ", " + Str(SecondDiceNumber) + "]"

                If FirstDiceNumber = 6 And SecondDiceNumber = 6 Then
                    successfulIteration = True
                End If

                j += 1
            End While

            If successfulIteration Then
                line += vbCrLf + "Success"
                success += 1
            Else
                line += vbCrLf + "Fail"
            End If

            lastResults.Add(line)
            i += 1
        End While
    End Sub

    Private Function roll() As Integer
        Dim n As Integer
        n = r.Next(1, 7)

        Return n

    End Function

    Public Overrides Function GetSummary() As String
        Dim output As String = ""
        Dim probability As Decimal = 0

        probability = success / iterations * 100
        output = "Iterations completed: " + Str(iterations) + vbCrLf +
            "Total Success: " + Str(success) + vbCrLf +
            "Total Fails: " + Str(iterations - success) + vbCrLf +
            "Probability: " + FormatNumber(probability, 2) + "%" + vbCrLf

        Return output
    End Function

End Class
