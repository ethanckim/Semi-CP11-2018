Public Class BtoBHeads
    Inherits Simulation

    Dim Result(2) As Integer

    Public Sub New(iter As Integer)
        MyBase.New(iter)
    End Sub

    Protected Overrides Sub RunSimulation()
        ReDim Result(2)
        While (Not kill) And (i < iterations)

            Dim line As String = ""
            Dim HeadsIARow As Integer = 0
            Dim successfulIteration As Boolean = False
            Dim FlipsAfterIteration As Integer = 0

            While Not successfulIteration
                FlipsAfterIteration += 1

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
            End While

            line += vbCrLf + "Flips: " + Str(FlipsAfterIteration)

            If Result.Length <= FlipsAfterIteration Then
                ReDim Preserve Result(FlipsAfterIteration)
            End If
            Result(FlipsAfterIteration) += 1

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
        Dim totalFlips As Double = 0

        'Find total flips for all iterations
        Dim j As Integer = 2
        While j < Result.Length
            totalFlips += j * Result(j)
            j += 1
        End While

        output = "Iterations completed: " + Str(iterations) + vbCrLf +
            "Total Number of flips: " + Str(totalFlips) + vbCrLf +
            "Average number of flips: " + FormatNumber(totalFlips / iterations, 2) + vbCrLf
        output += vbCrLf

        j = 2
        While j < Result.Length
            output += Str(j) + " flips: " + Str(Result(j)) + vbCrLf
            j += 1
        End While

        Return output
    End Function

End Class
