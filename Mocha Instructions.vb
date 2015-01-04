Public Class MochaInstruct
    Dim result As Integer
    Dim score As Integer = 0 'Keeping score'

    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btncont.Visible = False
        pbxinstructmocha.Visible = False
    End Sub
    Private Sub btninstruct_Click(sender As System.Object, e As System.EventArgs) Handles btninstruct.Click
        pbxdrinkmocha.Hide()
        pbxinstructmo.Hide()
        pbxinstructmocha.Show()
        btninstruct.Hide()
        btncont.Show()
    End Sub
    Private Sub Form6_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Would you like your progress to be saved?", "Select cancel to continue with the quiz", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            TotalScore = TotalScore + score
            End
        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub
    Private Sub btncont_Click(sender As System.Object, e As System.EventArgs) Handles btncont.Click
        MochaQuiz.Show()
        Me.Hide()
    End Sub

    Private Sub btnback_Click(sender As System.Object, e As System.EventArgs) Handles btnback.Click
        DrinkMenu.Show()
        Me.Hide()
    End Sub
End Class