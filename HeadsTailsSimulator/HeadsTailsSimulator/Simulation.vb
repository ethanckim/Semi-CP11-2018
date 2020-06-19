Imports System.Collections.Concurrent
''' <summary>
''' Protected means any of the sub-classes (ie: your simulations) can use those variables as well. 
''' </summary>
Public MustInherit Class Simulation
    Protected r As System.Random = New System.Random()

    ''' <summary>
    ''' Number of completed iterations
    ''' </summary>
    Protected i As Integer = 0
    ''' <summary>
    ''' Number of iterations to be run
    ''' </summary>
    Protected iterations As Integer
    ''' <summary>
    ''' Number of iterations that were considered a probability success
    ''' </summary>

    Protected success As Integer = 0

    ''' <summary>
    ''' Used to make sure we don't start 2 simulations at once
    ''' </summary>
    Protected running As Boolean = False
    ''' <summary>
    ''' If you want to abort a simulation half-way, turn this to true. This is how the cancel button in the ui works.
    ''' </summary>
    Protected kill As Boolean = False

    Protected lastResults As ResultsManager(Of String) = New ResultsManager(Of String)
    Private cond As String

    Public Sub New(iter As Integer)
        Me.iterations = iter
        'lastResults = New List(Of String)
    End Sub

    Public Function IsRunning() As Boolean
        Return running
    End Function
    Public Function IsKilled() As Boolean
        Return kill
    End Function
    Public Sub KillSimulation()
        kill = True
    End Sub

    Public Function GetResults() As String
        Dim results As String = ""

        Dim i As Integer = 0
        While i < lastResults.Count
            Dim r As String = lastResults(i)
            If r IsNot Nothing Then
                results = r + vbCrLf + vbCrLf + results
            End If

            i += 1
        End While
        Return results
    End Function
    Public Function GetI() As Integer
        Return i
    End Function
    Public Function GetIterations() As Integer
        Return iterations
    End Function
    Public Function GetSuccesses() As Integer
        Return success
    End Function

    Public Sub doSimulation()
        running = True
        RunSimulation()
        running = False
    End Sub
    ''' <summary>
    ''' Do your probability calculations in this method.
    ''' When starting this assigment, your loop should be:
    ''' 
    ''' While (Not kill) And (i < total)
    ''' 
    ''' After you get comfortable, you may make it more complicated, but always keep the (Not kill) part.
    ''' 
    ''' Put each iteration into results, delimited by a vbCrLf
    ''' </summary>
    Protected MustOverride Sub RunSimulation()

    ''' <summary>
    ''' Generate the summary that gets put in the summary box on the right side of the ui.
    ''' </summary>
    ''' <returns></returns>
    Public Overridable Function GetSummary() As String
        Return "GetSummary() should be implemented in Simulation. " + vbCrLf +
                "However, because it is Overridable, you may change the summary for one particular simulation by overriding it in that class."
    End Function
End Class
