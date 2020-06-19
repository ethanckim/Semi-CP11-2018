Public Class CustomCoin
    Inherits Simulation

    Dim Result(1) As Integer
    Dim condition As String
    Dim MultipleCon() As String

    Public Sub New(iter As Integer, cond As String)
        MyBase.New(iter)
        If cond.Contains(",") Then
            condition = cond
            MultipleCon = condition.Split(",")
        Else
            condition = cond
        End If

    End Sub

    Protected Overrides Sub RunSimulation()
        ReDim Result(1)

        While (Not kill) And (i < iterations)

            Dim line As String = ""
            Dim upto As Integer = 1
            Dim successfulIteration As Boolean = False
            Dim FlipsOnIteration As Integer = 0

            While Not successfulIteration
                FlipsOnIteration += 1

                Dim coinHeads As Boolean
                coinHeads = flip()

                If coinHeads Then
                    line += "H"
                Else
                    line += "T"
                End If

                If MultipleCon Is Nothing Then
                    If line.EndsWith(condition) Then
                        successfulIteration = True
                    End If
                Else

                    Dim i As Integer = 0
                    While i < MultipleCon.Length

                        If line.EndsWith(MultipleCon(i)) Then
                            successfulIteration = True
                        End If

                        i += 1
                    End While

                End If
            End While

            line += vbCrLf + "Flips: " + Str(FlipsOnIteration)

            If Result.Length <= FlipsOnIteration Then
                ReDim Preserve Result(FlipsOnIteration)
            End If
            Result(FlipsOnIteration) += 1

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
        Dim j As Integer = 1
        While j < Result.Length
            totalFlips += j * Result(j)
            j += 1
        End While

        output = "Iterations completed: " + Str(iterations) + vbCrLf +
            "Total Number of flips: " + Str(totalFlips) + vbCrLf +
            "Average number of flips: " + Str(totalFlips / iterations) + vbCrLf
        output += vbCrLf

        j = 1
        While j < Result.Length
            output += Str(j) + " flips: " + Str(Result(j)) + vbCrLf
            j += 1
        End While

        Return output
    End Function

End Class
