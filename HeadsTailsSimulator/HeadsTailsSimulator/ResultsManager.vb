Imports System.Collections.Concurrent

''' <summary>
''' Delegates to BlockingCollection, which is Thread-safe.
''' Keeps the last n items.
''' </summary>
Public Class ResultsManager(Of T)
    Public Const LAST_TO_SHOW As Integer = 50

    Private results As BlockingCollection(Of T) = New BlockingCollection(Of T)
    ''' <summary>
    ''' Makes it respond to myResults(i) like an array or a List.
    ''' </summary>
    Default ReadOnly Property myProperty(ByVal i As Integer) As T
        Get
            Return results(i)
        End Get
    End Property

    Friend Function Count() As Integer
        Return results.Count()
    End Function

    ''' <summary>
    ''' Makes sure we don't add more than a fixed number of results so that 
    ''' we don't overflow the available memory
    ''' </summary>
    ''' <param name="current"></param>
    Friend Sub Add(current As T)
        While results.Count > LAST_TO_SHOW
            results.Take()
        End While

        results.Add(current)
    End Sub
End Class
