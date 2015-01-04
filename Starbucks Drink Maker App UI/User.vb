Public Class User
    ' ### Private Member Variables ###
    Private Const UsersFile = "users.txt"
    Private Const Reward = 10

    Private Name As String
    ' Private member variable for the form to update when taking a quiz
    Private TrainingForm As HomeForm

    ' Best quiz scores
    Private BestScores As New Dictionary(Of String, Integer)

    ' Current score for quiz
    Private CurrentScores As New Dictionary(Of String, Integer)
    Private CurrentQuiz As QuizClass

    Private NumIncorrectGuesses As Integer

    ' Public member variable indicating whether the user previsouly existed
    Public Existed As Boolean

    Public Sub New(ByVal Username As String, ByRef TrainingForm As Form)
        Name = Username
        Existed = False
        CurrentQuiz = Nothing
        NumIncorrectGuesses = 0
        Me.TrainingForm = TrainingForm

        ' Setting initial best scores to 0
        BestScores.Add("Latte", 0)
        BestScores.Add("Mocha", 0)
        BestScores.Add("Chai", 0)
        BestScores.Add("Macchiato", 0)

        ' Setting current quiz scores to 0
        CurrentScores.Add("Latte", 0)
        CurrentScores.Add("Mocha", 0)
        CurrentScores.Add("Chai", 0)
        CurrentScores.Add("Macchiato", 0)

        ' #### ADD CHECKING IF USER EXISTS ####
    End Sub

    Public Sub StartQuiz(ByVal Drink As DrinkClass)
        ' Setting current quiz to the given quiz
        Drink.Quiz.ResetQuiz()
        CurrentQuiz = Drink.Quiz

        ' Resetting the current score for the given quiz to 0
        CurrentScores(CurrentQuiz.DrinkName) = 0
        NumIncorrectGuesses = 0

        TrainingForm.UpdateScore(0)
        TrainingForm.StartQuiz()
        NextQuestion()
    End Sub

    Public Sub SubmitQuestionAnswer(ByVal AnswerIdx As Integer)
        If (CurrentQuiz.CheckAnswer(AnswerIdx)) Then
            CurrentScores(CurrentQuiz.DrinkName) += Reward
            TrainingForm.UpdateScore(CurrentScores(CurrentQuiz.DrinkName))
        Else
            NumIncorrectGuesses += 1

            If (NumIncorrectGuesses >= 3) Then
                FinishQuiz()
                MsgBox("Test Failed!")
            Else
                TrainingForm.RemoveTallyMark(NumIncorrectGuesses)
            End If
        End If

        If (CurrentQuiz.CurrentQuestionNumber < CurrentQuiz.NumberOfQuestions) Then
            NextQuestion()
        Else
            FinishQuiz()
        End If
    End Sub

    Private Sub NextQuestion()
        ' Goes to the next question in the quiz, if one is being taken
        If (Not IsNothing(CurrentQuiz)) Then
            TrainingForm.ShowQuestion(CurrentQuiz.GetQuestion(), CurrentQuiz.CurrentQuestionNumber, CurrentQuiz.NumberOfQuestions)
        End If
    End Sub

    Public Sub FinishQuiz()
        TrainingForm.FinishQuiz()

        If (CurrentScores.Item(CurrentQuiz.DrinkName) > BestScores.Item(CurrentQuiz.DrinkName)) Then
            BestScores(CurrentQuiz.DrinkName) = CurrentScores.Item(CurrentQuiz.DrinkName)
        End If
    End Sub

    Public Sub Save()
        ' Saves the user and their scores to the given file
    End Sub
End Class
