﻿Public Class MacchiattoInstruct
    Dim result As Integer
    Dim score As Integer = 0 'Keeping score'

    Private Sub Form8_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btncont.Visible = False
        pbxinstructmachb.Visible = False
    End Sub

    Private Sub btninstruct_Click(sender As System.Object, e As System.EventArgs) Handles btninstruct.Click
        pbxdrinkmach.Hide()
        pbxinstructmach.Hide()
        pbxinstructmachb.Show()
        btninstruct.Hide()
        btncont.Show()
    End Sub
    Private Sub Form8_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Are you sure?", "Your progress will be saved", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            TotalScore = TotalScore + score
            End
        ElseIf result = DialogResult.No Then 'It still closes even though the code says to do nothing if no is selected'
            Stop
        End If
    End Sub
    Private Sub btncont_Click(sender As System.Object, e As System.EventArgs) Handles btncont.Click
        MacchiattoQuiz.Show()
        Me.Hide()
    End Sub

    Private Sub btnback_Click(sender As System.Object, e As System.EventArgs) Handles btnback.Click
        DrinkMenu.Show()
        Me.Hide()
    End Sub
End Class