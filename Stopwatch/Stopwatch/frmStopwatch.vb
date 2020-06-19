Public Class frmStopwatch

    Dim tenths As Integer = 0
    Dim seconds As Integer = 0
    Dim LaptimeS As Integer = 0
    Dim LaptimeT As Integer = 0
    Dim LapNumber As Integer = 0

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        'This is the code for the Start button
        If tmrTimer.Enabled = False Then
            tmrTimer.Enabled = True
            btnLapReset.Text = "Lap"
            btnStartStop.Text = "Stop"
            'This is the code for the Stop button
        Else
            tmrTimer.Enabled = False
            btnLapReset.Text = "Reset"
            btnStartStop.Text = "Start"
        End If
    End Sub

    Private Sub tmrTenths_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick

        txtCurrentLap.Text = "Current Lap"
        'Update Textboxs
        txtTenths.Text = Str(tenths)
        txtSeconds.Text = Str(seconds)
        txtLapT.Text = Str(LaptimeT)
        txtLapS.Text = Str(LaptimeS) + " s"
        'Adding 1 to variables each time 1 tenth second passed
        tenths += 1
        LaptimeT += 1
        'Converting Tenths to Seconds
        If tenths = 10 Then
            seconds += 1
            tenths = 0
        End If
        If LaptimeT = 10 Then
            LaptimeS += 1
            LaptimeT = 0
        End If
    End Sub

    Private Sub btnLapReset_Click(sender As Object, e As EventArgs) Handles btnLapReset.Click
        'This is the code for the Lap Button
        If tmrTimer.Enabled = True Then
            LapNumber += 1
            txtPreviousLaps.Text += "Lap " + Str(LapNumber) + "                               "
            txtPreviousLaps.Text += Str(LaptimeS) + " s " + Str(LaptimeT) + vbCrLf
            LaptimeT = 0
            LaptimeS = 0
            'This is the code for the Reset Button
        Else
            tenths = 0
            seconds = 0
            LaptimeT = 0
            LaptimeS = 0
            LapNumber = 0
            txtTenths.Text = "0"
            txtSeconds.Text = "0"
            txtLapT.Text = ""
            txtLapS.Text = ""
            txtPreviousLaps.Text = ""
            txtCurrentLap.Text = ""
        End If
    End Sub
End Class
