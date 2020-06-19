Imports System.ComponentModel

''' <summary>
''' The only place you are likely to make changes in this file is in ChooseAndCreateSimulation().
''' You will need to use If-statement(s) to set the correct Simulation into the sim variable.
''' </summary>
Public Class frmProbSim
    Private sim As Simulation
    Private worker As System.Threading.Thread
    Private startTime As Double
    Private finishTime As Double = -1

    Private Sub ChooseAndCreateSimulation()
        Dim iterations As Integer = CInt(txtNumIterations.Text)
        If radTemFlips.Checked Then
            sim = New TenFlips(iterations)
        ElseIf radBtoBHeads.Checked Then
            sim = New BtoBHeads(iterations)
        ElseIf radTwntyForRollsSixSix.Checked Then
            sim = New RollDice24(iterations)
        End If

        If chkHH.Checked And chkTT.Checked And chkCustom.Checked Then
            Dim condition As String = "HH,TT," + txtCondition.Text
            sim = New CustomCoin(iterations, condition)
        ElseIf chkHH.Checked And chkTT.Checked Then
            Dim condition As String = "HH,TT"
            sim = New CustomCoin(iterations, condition)
        ElseIf chkHH.Checked And chkCustom.Checked Then
            Dim condition As String = "HH," + txtCondition.Text
            sim = New CustomCoin(iterations, condition)
        ElseIf chkTT.Checked And chkCustom.Checked Then
            Dim condition As String = "TT," + txtCondition.Text
            sim = New CustomCoin(iterations, condition)
        ElseIf chkCustom.Checked Then
            Dim condition As String = txtCondition.Text
            sim = New CustomCoin(iterations, condition)
        ElseIf chkHH.Checked Then
            Dim condition As String = "HH"
            sim = New CustomCoin(iterations, condition)
        ElseIf chkTT.Checked Then
            Dim condition As String = "TT"
            sim = New CustomCoin(iterations, condition)
        End If

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        If sim Is Nothing OrElse Not sim.IsRunning() Then
            ChooseAndCreateSimulation()
            If sim Is Nothing Then
                Exit Sub
            End If
            startTime = GetCurrentTime()
            finishTime = -1

            prbOverall.Value = 0
            EnableUiElements(False)

            tmrUiUpdate.Enabled = True
            btnGo.Text = "Cancel"

            worker = New System.Threading.Thread(AddressOf sim.doSimulation)
            worker.Start()
        Else
            sim.KillSimulation()
            finishTime = GetCurrentTime()
            UpdateUi(True)
        End If
    End Sub

    Private Sub tmrUiUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUiUpdate.Tick
        Try
            UpdateUi(False)
        Catch ex As Exception
            Console.WriteLine("ex caught: " + ex.ToString())
        End Try

        If sim IsNot Nothing AndAlso Not sim.IsRunning() Then
            FinishSimulation()
        End If
    End Sub

    Private Sub EnableUiElements(switch As Boolean)
        txtNumIterations.Enabled = switch
    End Sub

    Private lastUpdateStart As Double = -1
    Private lastUpdateFinish As Double = -1
    Private lastUpdateDuration As Double = -1
    Private updateFudgeFactor As Integer = 5


    Private Sub UpdateUi(force As Boolean)
        If sim Is Nothing Then
            lblStatus.Text = "No simulation"
            Return
        End If

        Dim currentTime As Double = GetCurrentTime()

        Dim timeSinceUpdate As Double = currentTime - lastUpdateFinish
        Dim minimumDelay As Double = lastUpdateDuration * updateFudgeFactor
        If Not force AndAlso lastUpdateDuration >= 0 AndAlso minimumDelay > timeSinceUpdate Then
            Exit Sub
        End If
        lastUpdateStart = currentTime

        Dim count As Integer = sim.GetIterations()
        Dim i As Integer = sim.GetI()
        Dim success As Integer = sim.GetSuccesses()
        Dim pct As Double = If(count = 0, -1, 100 * i / count)

        prbOverall.Value = pct
        Dim r As String = ""
        Try
            r = sim.GetResults()
        Catch e As Exception
            r = "weird exception"
        End Try
        Dim s As String = ""
        Try
            s = sim.GetSummary()
        Catch e As Exception
            s = "weird exception"
        End Try
        txtRawOutput.Text = r
        txtSummary.Text = s

        Dim status As String = ""
        Dim duration As Double
        If sim.IsRunning() Then
            status = "Running"
            duration = GetCurrentTime() - startTime
        Else
            If sim.IsKilled() Then
                status = "Killed"
            Else
                status = "Complete"
            End If
            If finishTime < 0 Then
                finishTime = GetCurrentTime()
            End If
            duration = finishTime - startTime
        End If

        lblStatus.Text = status + vbCrLf +
                Str(i).Trim + "/" + Str(count).Trim + vbCrLf +
                FormatNumber(pct, 0).Trim + "% complete" + vbCrLf + "Duration: " + FormatNumber(duration, 0).Trim
        lastUpdateFinish = GetCurrentTime()
        lastUpdateDuration = lastUpdateFinish - lastUpdateStart
    End Sub

    Private Shared Function GetCurrentTime() As Double
        Return ((DateTime.Now - New DateTime(1970, 1, 1)).TotalMilliseconds) / 1000
    End Function

    Private Sub FinishSimulation()
        tmrUiUpdate.Enabled = False
        UpdateUi(True)
        prbOverall.Value = 100
        btnGo.Text = "Go"
        EnableUiElements(True)

        lastUpdateStart = -1
        lastUpdateFinish = -1
        lastUpdateDuration = -1
    End Sub

    Private Sub frmFlipUi_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If sim IsNot Nothing AndAlso sim.IsRunning Then
            sim.KillSimulation()
        End If
    End Sub


    Private Sub ChkChanged(sender As Object, e As EventArgs) Handles chkCustom.CheckedChanged, chkHH.CheckedChanged, chkTT.CheckedChanged

        If chkCustom.Checked = False Then
            txtCondition.Clear()
            txtCondition.Enabled = False
        End If

        If chkCustom.Checked = True Or chkHH.Checked = True Or chkTT.Checked = True Then
            radTemFlips.Checked = False
            radBtoBHeads.Checked = False
            radTwntyForRollsSixSix.Checked = False

            If chkCustom.Checked = True Then
                txtCondition.Enabled = True
            End If

        Else
            radTemFlips.Checked = True
        End If
    End Sub

    Private Sub RadChanged(sender As Object, e As EventArgs) Handles radTemFlips.CheckedChanged, radBtoBHeads.CheckedChanged, radTwntyForRollsSixSix.CheckedChanged
        If chkCustom.Checked = True Or chkHH.Checked = True Or chkTT.Checked = True Then
            If radTemFlips.Checked = True Or radTwntyForRollsSixSix.Checked = True Or radBtoBHeads.Checked = True Then
                chkCustom.Checked = False
                chkHH.Checked = False
                chkTT.Checked = False
            End If
        End If
    End Sub
End Class
