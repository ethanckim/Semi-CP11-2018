Public Class frmBaseballScoreboard

    Dim StartOrStop As Integer = 0
    Dim BlueJays(99) As String
    Dim Orioles(99) As String
    Dim seconds As Integer = 20
    Dim tenths As Integer = 0
    Dim waitTime As Integer = 2
    Dim ballCount As Integer = 0
    Dim strikeCount As Integer = 0
    Public outCount As Integer = 0
    Public Inning As Integer = 0
    Public BattingTeam As Char = "A"
    Dim AtBat As Integer = 1
    Public Base1Occupied As Boolean = False
    Public Base2Occupied As Boolean = False
    Public Base3Occupied As Boolean = False
    Dim AwayHit As Integer = 0
    Dim HomeHit As Integer = 0

    Private Sub frmBaseballScoreboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BlueJays(77) = "John Axford"
        BlueJays(24) = "Danny Barnes"
        BlueJays(36) = "Tyler Clippard"
        BlueJays(25) = "Marco Estrada"
        BlueJays(57) = "Jaime Garcia"
        BlueJays(33) = "J.A.Happ"
        BlueJays(62) = "Aaron Loup"
        BlueJays(22) = "Seung Hwan Oh"
        BlueJays(54) = "Roberto Osuna"
        BlueJays(41) = "Aaron Sanchez"
        BlueJays(6) = "Marcus Stroman"
        BlueJays(52) = "Ryan Tepera"
        BlueJays(21) = "Luke Maile"
        BlueJays(55) = "Russell Martin"
        BlueJays(1) = "Aledmys Diaz"
        BlueJays(20) = "Josh Donaldson"
        BlueJays(61) = "Gift Ngoepe"
        BlueJays(14) = "Justin Smoak"
        BlueJays(26) = "Yangervis Solarte"
        BlueJays(29) = "Devon Travis"
        BlueJays(18) = "Curtis Granderson"
        BlueJays(15) = "Randal Grichuk"
        BlueJays(28) = "Steve Pearce"
        BlueJays(11) = "Kevin Pillar"
        BlueJays(8) = "Kendrys Morales"

        Orioles(38) = "Pedro Araujo"
        Orioles(48) = "Richard Bleier"
        Orioles(35) = "Brad Brach"
        Orioles(37) = "Dylan Bundy"
        Orioles(54) = "Andrew Cashner"
        Orioles(50) = "Miguel Castro"
        Orioles(51) = "Nestor Cortes Jr."
        Orioles(34) = "Kevin Gausman"
        Orioles(60) = "Mychal Givens"
        Orioles(56) = "Darren O'Day"
        Orioles(30) = "Chris Tillman"
        Orioles(43) = "Mike Wright Jr."
        Orioles(36) = "Caleb Joseph"
        Orioles(15) = "Chance Sisco"
        Orioles(24) = "Pedro Alvarez"
        Orioles(1) = "Tim Beckham"
        Orioles(19) = "Chris Davis"
        Orioles(13) = "Manny Machado"
        Orioles(6) = "Jonathan Schoop"
        Orioles(2) = "Danny Valencia"
        Orioles(14) = "Craig Gentry"
        Orioles(10) = "Adam Jones"
        Orioles(16) = "Trey Mancini"
        Orioles(28) = "Colby Rasmus"
        Orioles(25) = "Anthony Santander"

    End Sub

    Private Sub btnStartEnd_Click(sender As Object, e As EventArgs) Handles btnStartEnd.Click
        If StartOrStop = 0 Then
            frmPlayerList.Show()
            btnStartEnd.Text = "Stop and Reset"
            StartOrStop = 1
        Else
            'This is the reset code
            'Reset Ball/Strike/Out Count
            ballCount = -1
            AddBall()
            strikeCount = -1
            AddStrike()
            outCount = -1
            AddOut(1)
            'Reset Score
            txtPlayerNumber.Text = ""
            txtHome1.Text = 0
            txtHome2.Text = 0
            txtHome3.Text = 0
            txtHome4.Text = 0
            txtHome5.Text = 0
            txtHome6.Text = 0
            txtHome7.Text = 0
            txtHome8.Text = 0
            txtHome9.Text = 0
            txtHomeH.Text = 0
            txtHomeR.Text = 0
            txtAway1.Text = 0
            txtAway2.Text = 0
            txtAway3.Text = 0
            txtAway4.Text = 0
            txtAway5.Text = 0
            txtAway6.Text = 0
            txtAway7.Text = 0
            txtAway8.Text = 0
            txtAway9.Text = 0
            txtAwayH.Text = 0
            txtAwayR.Text = 0
            AwayHit = 0
            HomeHit = 0
            frmRunOptions.InningScore(1) = 0
            frmRunOptions.InningScore(2) = 0
            frmRunOptions.InningScore(3) = 0
            frmRunOptions.InningScore(4) = 0
            frmRunOptions.InningScore(5) = 0
            frmRunOptions.InningScore(6) = 0
            frmRunOptions.InningScore(7) = 0
            frmRunOptions.InningScore(8) = 0
            frmRunOptions.InningScore(9) = 0
            frmRunOptions.InningScore(10) = 0
            frmRunOptions.InningScore(11) = 0
            frmRunOptions.InningScore(12) = 0
            frmRunOptions.InningScore(13) = 0
            frmRunOptions.InningScore(14) = 0
            frmRunOptions.InningScore(15) = 0
            frmRunOptions.InningScore(16) = 0
            frmRunOptions.InningScore(17) = 0
            frmRunOptions.InningScore(18) = 0
            'Reset PlayFlow
            Inning = 0
            BattingTeam = "A"
            AtBat = 1
            'Reset Field
            Base1Occupied = False
            Base2Occupied = False
            Base3Occupied = False
            picActiveBase1.Visible = False
            picActiveBase2.Visible = False
            picActiveBase3.Visible = False
            frmRunOptions.picActiveBase1.Visible = False
            frmRunOptions.picActiveBase2.Visible = False
            frmRunOptions.picActiveBase3.Visible = False
            'Reset timer
            ResetTmr(1)
            tmrWait.Enabled = False
            waitTime = 2
            'Reset Log
            txtLog.Text = ""
            'Disable Buttons
            btnBall.Enabled = False
            btnStrike.Enabled = False
            btnHit.Enabled = False
            btnPauseClock.Enabled = False



            btnStartEnd.Text = "Play Ball!"
            StartOrStop = 0
        End If
    End Sub

    Public Sub EnableOrNotButtons()
        If frmPlayerList.Visible = True Or frmRunOptions.Visible = True Then
            btnStartEnd.Enabled = False
            btnPauseClock.Enabled = False
            btnBall.Enabled = False
            btnStrike.Enabled = False
            btnHit.Enabled = False
        Else
            btnStartEnd.Enabled = True
            btnPauseClock.Enabled = True
            btnBall.Enabled = True
            btnStrike.Enabled = True
            btnHit.Enabled = True
        End If
    End Sub

    Private Sub tmrPitchClock_Tick(sender As Object, e As EventArgs) Handles tmrPitchClock.Tick
        lblSeconds.Text = Str(seconds)
        lblTenths.Text = Str(tenths)
        If tenths = 0 Then
            seconds -= 1
            tenths = 9
        End If
        tenths -= 1
        If seconds = 0 Then
            AddBall()
            seconds = 20
            tenths = 0
            lblSeconds.Text = "20"
        End If
    End Sub

    Public Sub ResetTmr(i As Integer)
        'i = 0 -> Wait 3 seconds, then activate the timer again
        'i = 1 -> Stop timer
        tmrPitchClock.Enabled = False
        seconds = 20
        tenths = 0
        lblSeconds.Text = "20"
        lblTenths.Text = "0"
        If i = 0 Then
            tmrWait.Enabled = True
        End If
    End Sub

    Private Sub tmrWait_Tick(sender As Object, e As EventArgs) Handles tmrWait.Tick
        waitTime -= 1
        If waitTime <= 0 Then
            tmrPitchClock.Enabled = True
            tmrWait.Enabled = False
            waitTime = 2
        End If
    End Sub

    Private Sub btnPauseClock_Click(sender As Object, e As EventArgs) Handles btnPauseClock.Click

        If tmrPitchClock.Enabled = True Or tmrWait.Enabled = True Then
            btnPauseClock.Text = "Start Pitch Clock"
            tmrPitchClock.Enabled = False
            If tmrWait.Enabled = True Then
                tmrWait.Enabled = False
                waitTime = 2
            End If
        Else
                btnPauseClock.Text = "Pause Pitch Clock"
            tmrPitchClock.Enabled = True
        End If

    End Sub

    Private Sub AddBall()
        ballCount += 1
        ResetTmr(0)
        Select Case ballCount
            Case 0
                picBall1.Hide()
                picBall2.Hide()
                picBall3.Hide()
            Case 1
                picBall1.Show()
                picBall2.Hide()
                picBall3.Hide()
                txtLog.Text += "1 Ball" + vbCrLf
            Case 2
                picBall1.Show()
                picBall2.Show()
                picBall3.Hide()
                txtLog.Text += "2 balls" + vbCrLf
            Case 3
                picBall1.Show()
                picBall2.Show()
                picBall3.Show()
                txtLog.Text += "3 balls" + vbCrLf
            Case Else
                picBall1.Hide()
                picBall2.Hide()
                picBall3.Hide()
                ballCount = 0
                strikeCount = -1
                AddStrike()

                txtLog.Text += "Player #" + MentionNumber() + " " + MentionPlayerName() + " gets a free run" + vbCrLf
                AtBatChange()
                'The batter gets a free run.
                If Base1Occupied = False Then
                    Base1Occupied = True
                    picActiveBase1.Visible = True
                ElseIf Base1Occupied = True Then
                    If Base3Occupied = True Then
                        Base3Occupied = False
                        picActiveBase3.Visible = False
                        frmRunOptions.ScoreRun()
                    End If
                    If Base2Occupied = True Then
                        Base3Occupied = True
                        picActiveBase3.Visible = True
                    End If
                    Base2Occupied = True
                    picActiveBase2.Visible = True
                End If

        End Select
    End Sub

    Private Sub AddStrike()
        strikeCount += 1
        ResetTmr(0)
        Select Case strikeCount
            Case 0
                picStrike1.Hide()
                picStrike2.Hide()
            Case 1
                picStrike1.Show()
                picStrike2.Hide()
                txtLog.Text += "1 Strike for #" + MentionNumber() + " " + MentionPlayerName() + vbCrLf
            Case 2
                picStrike1.Show()
                picStrike2.Show()
                txtLog.Text += "2 Strike for #" + MentionNumber() + " " + MentionPlayerName() + vbCrLf
            Case Else
                picStrike1.Hide()
                picStrike2.Hide()
                strikeCount = 0
                ballCount = -1
                AddBall()
                AddOut(0)
        End Select
    End Sub

    Public Sub AddOut(i As Integer)
        'i = 0 -> Change Batter after Adding the Out
        'i = 1 -> Don't change Batter
        outCount += 1
        ResetTmr(0)
        Select Case outCount
            Case 0
                picOut1.Hide()
                picOut2.Hide()
            Case 1
                picOut1.Show()
                picOut2.Hide()
                txtLog.Text += "1 Out for " + MentionTeam() + vbCrLf
            Case 2
                picOut1.Show()
                picOut2.Show()
                txtLog.Text += "2 Outs for " + MentionTeam() + vbCrLf
            Case Else
                picOut1.Hide()
                picOut2.Hide()
                outCount = 0
                ballCount = -1
                AddBall()

                txtLog.Text += "3 Outs! Batting and Fielding team changes" + vbCrLf
                txtLog.Text += MentionTeam() + " Scored a total of " + Str(frmRunOptions.InningScore(Inning)) + " runs durring inning " + MentionInning() + vbCrLf

                If Inning >= 18 Then
                    'Game Over
                    ResetTmr(1)
                    tmrWait.Enabled = False

                    btnBall.Enabled = False
                    btnStrike.Enabled = False
                    btnHit.Enabled = False
                    btnPauseClock.Enabled = False

                    txtLog.Text += "Game Over! "
                    If frmRunOptions.ARunTotal > frmRunOptions.HRunTotal Then
                        txtLog.Text += "BlueJays"
                    ElseIf frmRunOptions.ARunTotal < frmRunOptions.HRunTotal Then
                        txtLog.Text += "Orioles"
                    Else
                        txtLog.Text += "The game is tied!"
                        Exit Sub
                    End If
                    txtLog.Text += " Win the game by " + Str(frmRunOptions.ARunTotal) + " - " + Str(frmRunOptions.HRunTotal)
                Else
                    'Inning changes
                    If Inning - 10 >= 0 Then
                        Inning -= 8
                    Else
                        Inning += 9
                    End If
                End If


                'At Bat, Fielding changes
                If BattingTeam = "A" Then
                    BattingTeam = "H"
                    picBlueJays.Image = Baseball_Scoreboard.My.Resources.Resources.Orioles
                    picOrioles.Image = Baseball_Scoreboard.My.Resources.Resources.BlueJays
                    lblField.Text = "HOME"
                    lblHome.Text = "AWAY"
                Else
                    BattingTeam = "A"
                    picBlueJays.Image = Baseball_Scoreboard.My.Resources.Resources.BlueJays
                    picOrioles.Image = Baseball_Scoreboard.My.Resources.Resources.Orioles
                    lblField.Text = "AWAY"
                    lblHome.Text = "HOME"
                End If
        End Select

        If i = 0 Then
            AtBatChange()
        End If

    End Sub

    Private Sub AtBatChange()
        AtBat += 1
        If AtBat > 9 Then
            AtBat = 1
        End If
        If BattingTeam = "A" Then
            txtPlayerNumber.Text = frmPlayerList.PlayOrder(AtBat)
        Else
            txtPlayerNumber.Text = frmPlayerList.PlayOrder(AtBat + 9)
        End If
    End Sub

    Public Function MentionPlayerName() As String
        Dim result As String
        If BattingTeam = "A" Then
            result = BlueJays(frmPlayerList.PlayOrder(AtBat))
        Else
            result = Orioles(frmPlayerList.PlayOrder(AtBat + 9))
        End If
        Return result
    End Function

    Public Function MentionNumber() As String
        Dim result As String
        If BattingTeam = "A" Then
            result = Str(frmPlayerList.PlayOrder(AtBat))
        Else
            result = Str(frmPlayerList.PlayOrder(AtBat + 9))
        End If
        Return result
    End Function

    Public Function MentionTeam() As String
        Dim result As String
        If BattingTeam = "A" Then
            result = "BlueJays"
        Else
            result = "Orioles"
        End If
        Return result
    End Function

    Public Function MentionInning() As String
        Dim result As String
        If BattingTeam = "A" Then
            result = Str(Inning)
        Else
            result = Str(Inning - 9)
        End If
        Return result
    End Function

    Private Sub btnBall_Click(sender As Object, e As EventArgs) Handles btnBall.Click
        AddBall()
    End Sub

    Private Sub btnStrike_Click(sender As Object, e As EventArgs) Handles btnStrike.Click
        AddStrike()
    End Sub

    Private Sub btnHit_Click(sender As Object, e As EventArgs) Handles btnHit.Click
        AtBatChange()

        'Reset Ball/Strike Count
        ballCount = 0
        picBall1.Hide()
        picBall2.Hide()
        picBall3.Hide()
        strikeCount = 0
        picStrike1.Hide()
        picStrike2.Hide()

        'Timer stop/resets
        ResetTmr(1)
        If tmrWait.Enabled = True Then
            tmrWait.Enabled = False
            waitTime = 2
        End If

        'Add Score for Hit
        If BattingTeam = "A" Then
            AwayHit += 1
            txtAwayH.Text = AwayHit
        Else
            HomeHit += 1
            txtHomeH.Text = HomeHit
        End If

        'Changes the base display in frmRunOptions
        If Base1Occupied = True Then
            frmRunOptions.picActiveBase1.Visible = True
            frmRunOptions.grpFirst.Enabled = True
            Base1Occupied = False
        Else
            frmRunOptions.picActiveBase1.Visible = False
            frmRunOptions.grpFirst.Enabled = False
        End If

        If Base2Occupied = True Then
            frmRunOptions.picActiveBase2.Visible = True
            frmRunOptions.grpSecond.Enabled = True
            Base2Occupied = False
        Else
            frmRunOptions.picActiveBase2.Visible = False
            frmRunOptions.grpSecond.Enabled = False
        End If

        If Base3Occupied = True Then
            frmRunOptions.picActiveBase3.Visible = True
            frmRunOptions.grpThird.Enabled = True
            Base3Occupied = False
        Else
            frmRunOptions.picActiveBase3.Visible = False
            frmRunOptions.grpThird.Enabled = False
        End If

        frmRunOptions.Show()

        EnableOrNotButtons()

    End Sub


End Class
