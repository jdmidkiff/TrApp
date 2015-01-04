Public Class Scoreboard
    Structure namescore
        Public playername As String 'Structure for storing usernames and scores'
        Public playerscore As Integer
    End Structure

    Dim sortscores As New Collection
    Dim tempinfo As namescore 'Temp space for names and scores'
    Dim result As Integer 'Exit strategy'
    Dim score As Integer = 0 'Keeping score'
    Dim readnames(1) As String
    Dim Usernames As New System.IO.StreamReader("Scoreboard.txt")

    Private Sub Form3_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Are you sure?", "Your progress will be saved", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            TotalScore = TotalScore + score
            End
        ElseIf result = DialogResult.No Then 'It still closes even though the code says to do nothing if no is selected'
            Stop
        End If
    End Sub

    Private Sub lblsources_Click(sender As System.Object, e As System.EventArgs) Handles lblsources.Click
        Bibliography.Show() 'Sources'
        Me.Hide()
    End Sub

    Private Sub btnmake_Click(sender As System.Object, e As System.EventArgs) Handles btnmake.Click
        DrinkMenu.Show() 'Make another drink'
        Me.Hide()
    End Sub

    Private Sub btnnew_Click(sender As System.Object, e As System.EventArgs) Handles btnnew.Click
        MochaQuiz.Show() 'New barista'
        Me.Hide()
    End Sub

    Private Sub btnend_Click(sender As System.Object, e As System.EventArgs) Handles btnend.Click
        Me.Close() 'End the programme'
    End Sub

    Private Sub Scoreboard_Load(sender As Object, e As System.EventArgs) Handles Me.Load 
        Do While Usernames.EndOfStream = False 'Load and read names and scores'
            readnames = Split(Usernames.ReadLine(), "/") 'Display the top five scores'
            tempinfo.playername = readnames(0)
            tempinfo.playerscore = readnames(1)
            sortscores.Add(tempinfo) 
        Loop

        For i = 1 To 5
            Usernames.ReadToEnd()
            If tempinfo.playerscore > readnames(1) Then
                Lbx1score.Text = tempinfo.playerscore 'End loop'
                If tempinfo.playerscore > readnames(3) Then
                    Lbx2score.Text = tempinfo.playerscore 'End loop'
                    If tempinfo.playerscore > readnames(5) Then
                        Lbx3score.Text = tempinfo.playerscore 'End loop'
                        If tempinfo.playerscore > readnames(7) Then
                            Lbx4name.Text = tempinfo.playerscore 'End loop'
                            If tempinfo.playerscore > readnames(9) Then
                                Lbx5name.Text = tempinfo.playerscore 'End loop'
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub
End Class