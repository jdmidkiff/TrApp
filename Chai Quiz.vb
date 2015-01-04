Imports WindowsApplication1.FrmEntry

Public Class ChaiQuiz
    Public quizdatabase As New Collection
    Public correct As Integer
    Public useranswer As Integer = 1

    Structure question
        Public question As String
        Public answer1 As String
        Public answer2 As String
        Public answer3 As String
        Public answer4 As String
        Public correct As Int16
    End Structure

    Dim readQuestion As question
    Dim index As Integer
    Dim score As Integer = 0 'Keeping score'
    Dim guesses As Integer = 0 'Tracking incorrect guesses'
    Dim qcounter As Integer 'Counting questions'
    Dim result As Integer 'Form closing event selection'

    Private Sub ChaiQuiz_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Would you like your progress to be saved?", "Select cancel to continue with the quiz", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            TotalScore = TotalScore + score
            End
        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub 'Option to save progress'

    Private Sub Form10_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BtnFinish.Visible = False 'Button not visible until quiz is complete'
        Dim readQuestion As question
        Dim index As Integer
        Dim questString(5) As String
        Dim readthis As New System.IO.StreamReader("Chai Questions Edit.txt")
        Do While readthis.EndOfStream = False 'Load and read questions'
            questString = Split(readthis.ReadLine(), "/")
            readQuestion.question = questString(0)
            readQuestion.answer1 = questString(1)
            readQuestion.answer2 = questString(2)
            readQuestion.answer3 = questString(3)
            readQuestion.answer4 = questString(4)
            readQuestion.correct = questString(5)
            quizdatabase.Add(readQuestion)
        Loop


        readthis.Close()
        Randomize() 'Display question'
        index = Rnd() * (quizdatabase.Count - 1) + 1
        readQuestion = quizdatabase.Item(index)
        lblquestion.Text = readQuestion.question
        Option1.Text = readQuestion.answer1
        Option2.Text = readQuestion.answer2
        Option3.Text = readQuestion.answer3
        Option4.Text = readQuestion.answer4
        correct = readQuestion.correct
        quizdatabase.Remove(index)
        btnnextq.Show()
    End Sub

    Private Sub btnnextq_Click(sender As System.Object, e As System.EventArgs) Handles btnnextq.Click
        qcounter += 1 'Add 1 to question counter'
        lblcounter.Text = "Question:" & " " & qcounter
        If qcounter = 7 Then BtnFinish.Visible = True
        If correct = useranswer Then score += 10 'Correct answer'
        lblscore.Text = "Score: " & score
        TotalScore = TotalScore + 10
        If correct <> useranswer Then
            guesses += 1 'Tracking incorrect guesses'
            lblguesses.Text = "Incorrect: " & guesses
        End If

        If guesses = 3 Then
            MessageBox.Show("Try Again") 'Guesses exceeded'
            qcounter = 0 'Clears question counter'
            lblcounter.Text = "Question: " & 0
            guesses = 0 'Clears guesses'
            lblguesses.Text = "Incorrect: " & 0
            score = 0 'Clears current score'
            lblscore.Text = "Score: " & 0
            DrinkMenu.Show()
            Me.Close()
        End If

        Randomize()
        index = Rnd() * (quizdatabase.Count - 1) + 1
        readQuestion = quizdatabase.Item(index)
        lblquestion.Text = readQuestion.question
        Option1.Text = readQuestion.answer1
        Option2.Text = readQuestion.answer2
        Option3.Text = readQuestion.answer3
        Option4.Text = readQuestion.answer4
        correct = readQuestion.correct
        quizdatabase.Remove(index)
        btnnextq.Show()
    End Sub
    Private Sub Option1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Option1.CheckedChanged
        useranswer = 1
    End Sub

    Private Sub Option2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Option2.CheckedChanged
        useranswer = 2
    End Sub

    Private Sub Option3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Option3.CheckedChanged
        useranswer = 3
    End Sub

    Private Sub Option4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Option4.CheckedChanged
        useranswer = 4
    End Sub
    Private Sub BtnFinish_Click(sender As System.Object, e As System.EventArgs) Handles BtnFinish.Click
        Dim tempinfo As namescore
        Dim readnames(1) As String
        Dim Usernames As New System.IO.StreamReader("Scoreboard.txt")
        Do While Usernames.EndOfStream = False 'Load and read questions'
            readnames = Split(Usernames.ReadLine(), "/")
            tempinfo.playername = readnames(0) 'Username'
            tempinfo.playerscore = readnames(1) 'Their score'
            TotalScore = TotalScore + score 'Updating user score'
        Loop

        Scoreboard.Show() 'Appears when quiz is complete'
        Me.Close()
    End Sub

    Private Sub btnback_Click(sender As System.Object, e As System.EventArgs) Handles btnback.Click
        DrinkMenu.Show()
        Me.Close()
    End Sub
End Class