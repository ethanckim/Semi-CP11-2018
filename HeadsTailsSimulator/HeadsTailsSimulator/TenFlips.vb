Public Class TenFlips
    Inherits Simulation

    Public Sub New(iter As Integer)
        MyBase.New(iter)
    End Sub

    Protected Overrides Sub RunSimulation()
        While (Not kill) And (i < iterations)

            Dim line As String = ""
            Dim HeadsIARow As Integer = 0
            Dim j As Integer = 0
            Dim successfulIteration As Boolean = False

            While j < 10

                Dim coinHeads As Boolean
                coinHeads = flip()

                If coinHeads Then
                    line += "H"
                    HeadsIARow += 1

                    If HeadsIARow = 2 Then
                        successfulIteration = True
                    End If

                Else
                    line += "T"
                    HeadsIARow = 0
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

    Private Function flip() As Boolean
        Dim n As Integer
        n = r.Next(0, 2)

        If n = 0 Then
            Return True
        Else
            Return False
        End If

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
