Public Class frmRunOptions

    Dim Invalid As Boolean = False
    Public InningScore(18) As Integer
    Public ARunTotal As Integer = 0
    Public HRunTotal As Integer = 0
    Dim ThreeOuts As Boolean = False

    Private Sub ClearChecks()
        'Clear RadioButtons to prevent furthur conflict
        rdbBatter1st.Checked = False
        rdbBatter2nd.Checked = False
        rdbBatter3rd.Checked = False
        rdbBatterOut.Checked = True
        rdbFirst1st.Checked = False
        rdbFirst2nd.Checked = False
        rdbFirst3rd.Checked = False
        rdbFirstHome.Checked = False
        rdbFirstOut.Checked = True
        rdbSecond2nd.Checked = False
        rdbSecond3rd.Checked = False
        rdbSecondHome.Checked = False
        rdbSecondOut.Checked = True
        rdbThird3rd.Checked = False
        rdbThirdHome.Checked = False
        rdbThirdOut.Checked = True
    End Sub

    Private Sub CheckBase1()
        If frmBaseballScoreboard.Base1Occupied = False Then
            frmBaseballScoreboard.Base1Occupied = True
        Else
            Invalid = True
        End If
    End Sub

    Private Sub CheckBase2()
        If frmBaseballScoreboard.Base2Occupied = False Then
            frmBaseballScoreboard.Base2Occupied = True
        Else
            Invalid = True
        End If
    End Sub

    Private Sub CheckBase3()
        If frmBaseballScoreboard.Base3Occupied = False Then
            frmBaseballScoreboard.Base3Occupied = True
        Else
            Invalid = True
        End If
    End Sub

    Public Sub ScoreRun()
        InningScore(frmBaseballScoreboard.Inning) += 1
        frmBaseballScoreboard.txtAway1.Text = InningScore(1)
        frmBaseballScoreboard.txtAway2.Text = InningScore(2)
        frmBaseballScoreboard.txtAway3.Text = InningScore(3)
        frmBaseballScoreboard.txtAway4.Text = InningScore(4)
        frmBaseballScoreboard.txtAway5.Text = InningScore(5)
        frmBaseballScoreboard.txtAway6.Text = InningScore(6)
        frmBaseballScoreboard.txtAway7.Text = InningScore(7)
        frmBaseballScoreboard.txtAway8.Text = InningScore(8)
        frmBaseballScoreboard.txtAway9.Text = InningScore(9)
        frmBaseballScoreboard.txtHome1.Text = InningScore(10)
        frmBaseballScoreboard.txtHome2.Text = InningScore(11)
        frmBaseballScoreboard.txtHome3.Text = InningScore(12)
        frmBaseballScoreboard.txtHome4.Text = InningScore(13)
        frmBaseballScoreboard.txtHome5.Text = InningScore(14)
        frmBaseballScoreboard.txtHome6.Text = InningScore(15)
        frmBaseballScoreboard.txtHome7.Text = InningScore(16)
        frmBaseballScoreboard.txtHome8.Text = InningScore(17)
        frmBaseballScoreboard.txtHome9.Text = InningScore(18)
        frmBaseballScoreboard.txtLog.Text += frmBaseballScoreboard.MentionTeam() + "Scores a run!" + vbCrLf
    End Sub

    Private Sub RunTotalCheck()
        If frmBaseballScoreboard.BattingTeam = "A" Then
            ARunTotal = InningScore(1) + InningScore(2) + InningScore(3) + InningScore(4) + InningScore(5) + InningScore(6) + InningScore(7) + InningScore(8) + InningScore(9)
            frmBaseballScoreboard.txtAwayR.Text = ARunTotal
        Else
            HRunTotal = InningScore(10) + InningScore(11) + InningScore(12) + InningScore(13) + InningScore(14) + InningScore(15) + InningScore(16) + InningScore(17) + InningScore(18)
            frmBaseballScoreboard.txtHomeR.Text = HRunTotal
        End If
    End Sub

    Private Sub LastChange()

        'Changes the base display in main form
        If frmBaseballScoreboard.Base1Occupied = True Then
            frmBaseballScoreboard.picActiveBase1.Visible = True
        Else
            frmBaseballScoreboard.picActiveBase1.Visible = False
        End If

        If frmBaseballScoreboard.Base2Occupied = True Then
            frmBaseballScoreboard.picActiveBase2.Visible = True
        Else
            frmBaseballScoreboard.picActiveBase2.Visible = False
        End If

        If frmBaseballScoreboard.Base3Occupied = True Then
            frmBaseballScoreboard.picActiveBase3.Visible = True
        Else
            frmBaseballScoreboard.picActiveBase3.Visible = False
        End If

        frmBaseballScoreboard.ResetTmr(0)
        Me.Hide()
        frmBaseballScoreboard.EnableOrNotButtons()

    End Sub

    Private Sub ThreeOutCheck()
        If Not ThreeOuts = True Then
            If frmBaseballScoreboard.outCount = 2 Then
                ThreeOuts = True
                frmBaseballScoreboard.txtLog.Text += "3 Outs! Batting and Fielding team changes" + vbCrLf
                frmBaseballScoreboard.txtLog.Text += frmBaseballScoreboard.MentionTeam() + " Scored a total of " + Str(InningScore(frmBaseballScoreboard.Inning)) + " runs durring inning " + frmBaseballScoreboard.MentionInning() + vbCrLf
            End If
            frmBaseballScoreboard.AddOut(1)
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        frmBaseballScoreboard.txtLog.Text += "#" + frmBaseballScoreboard.MentionNumber() + " " + frmBaseballScoreboard.MentionPlayerName() + " Hits the ball!" + vbCrLf
        'Checks what you checked in the UI
        If grpThird.Enabled = True Then
            If rdbThird3rd.Checked Then
                frmBaseballScoreboard.Base3Occupied = True
            ElseIf rdbThirdHome.Checked Then
                ScoreRun()
            ElseIf rdbThirdOut.Checked Then
                ThreeOutCheck()
            End If
        End If

        If grpSecond.Enabled = True Then
            If rdbSecond2nd.Checked Then
                frmBaseballScoreboard.Base2Occupied = True
            ElseIf rdbSecond3rd.Checked Then
                CheckBase3()
                If Invalid = True Then
                    MessageBox.Show("Two players are overlapping in base 3!", "Warning")
                    Invalid = False
                    Exit Sub
                End If
            ElseIf rdbSecondHome.Checked Then
                ScoreRun()
            ElseIf rdbSecondOut.Checked Then
                ThreeOutCheck()
            End If
        End If

        If grpFirst.Enabled = True Then
            If rdbFirst1st.Checked Then
                frmBaseballScoreboard.Base1Occupied = True
            ElseIf rdbFirst2nd.Checked Then
                CheckBase2()
                If Invalid = True Then
                    MessageBox.Show("Two players are overlapping in base 2!", "Warning")
                    Invalid = False
                    Exit Sub
                End If
            ElseIf rdbFirst3rd.Checked Then
                CheckBase3()
                If Invalid = True Then
                    MessageBox.Show("Two players are overlapping in base 3!", "Warning")
                    Invalid = False
                    Exit Sub
                End If
            ElseIf rdbFirstHome.Checked Then
                ScoreRun()
            ElseIf rdbFirstOut.Checked Then
                ThreeOutCheck()
            End If
        End If

        If rdbBatter1st.Checked Then
            CheckBase1()
            If Invalid = True Then
                MessageBox.Show("Two players are overlapping in base 1!", "Warning")
                Invalid = False
                Exit Sub
                frmBaseballScoreboard.txtLog.Text += "#" + frmBaseballScoreboard.MentionNumber() + " " + frmBaseballScoreboard.MentionPlayerName() + " manages to go up to 1st base." + vbCrLf
            End If
        ElseIf rdbBatter2nd.Checked Then
            CheckBase2()
            If Invalid = True Then
                MessageBox.Show("Two players are overlapping in base 2!", "Warning")
                Invalid = False
                Exit Sub
                frmBaseballScoreboard.txtLog.Text += "#" + frmBaseballScoreboard.MentionNumber() + " " + frmBaseballScoreboard.MentionPlayerName() + " manages to go up to 2nd base." + vbCrLf
            End If
        ElseIf rdbBatter3rd.Checked Then
            CheckBase3()
            If Invalid = True Then
                MessageBox.Show("Two players are overlapping in base 3!", "Warning")
                Invalid = False
                Exit Sub
                frmBaseballScoreboard.txtLog.Text += "#" + frmBaseballScoreboard.MentionNumber() + " " + frmBaseballScoreboard.MentionPlayerName() + " manages to go up to 3rd base." + vbCrLf
            End If
        ElseIf rdbBatterOut.Checked Then
            ThreeOutCheck()
        End If

        ClearChecks()
        RunTotalCheck()
        LastChange()

    End Sub

    Private Sub btnHomeRun_Click(sender As Object, e As EventArgs) Handles btnHomeRun.Click

        ClearChecks()

        Dim B1 As Integer
        Dim B2 As Integer
        Dim B3 As Integer

        Select Case picActiveBase1.Visible
            Case True
                B1 = 1
            Case False
                B1 = 0
        End Select

        Select Case picActiveBase2.Visible
            Case True
                B2 = 1
            Case False
                B2 = 0
        End Select

        Select Case picActiveBase3.Visible
            Case True
                B3 = 1
            Case False
                B3 = 0
        End Select

        Dim i As Integer = 0
        While B1 + B2 + B3 + 1 > i
            ScoreRun()
            i += 1
        End While

        frmBaseballScoreboard.txtLog.Text += "Player #" + frmBaseballScoreboard.MentionNumber() + " " + frmBaseballScoreboard.MentionPlayerName() + " hits a Home Run!" + vbCrLf

        RunTotalCheck()

        'Clear Field
        picActiveBase1.Visible = False
        picActiveBase2.Visible = False
        picActiveBase3.Visible = False
        frmBaseballScoreboard.picActiveBase1.Visible = False
        frmBaseballScoreboard.picActiveBase2.Visible = False
        frmBaseballScoreboard.picActiveBase3.Visible = False
        frmBaseballScoreboard.Base1Occupied = False
        frmBaseballScoreboard.Base2Occupied = False
        frmBaseballScoreboard.Base3Occupied = False

        frmBaseballScoreboard.ResetTmr(0)
        Me.Hide()
        frmBaseballScoreboard.EnableOrNotButtons()

    End Sub

    Private Sub frmRunOptions_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Makes it so that u can't close the form without clicking Confirm or HomeRun.
        Me.ShowDialog()
    End Sub
End Class