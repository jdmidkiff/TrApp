Public Class User
    ' ### Private Member Variables ###
    Private Const UsersFile = "users.txt"

    Private Name As String
    ' Private member variable for the form to update when taking a quiz
    Private TrainingForm As HomeForm

    ' Best quiz scores
    Private BestScores As Dictionary(Of String, Integer)

    ' Current score for quiz
    Private CurrentScores As Dictionary(Of String, Integer)
    Private CurrentQuiz As QuizClass

    ' Public member variable indicating whether the user previsouly existed
    Public Existed As Boolean

    Public Sub New(ByVal Username As String, ByRef TrainingForm As Form)
        Name = Username
        Existed = False
        CurrentQuiz = Nothing
        Me.TrainingForm = TrainingForm

        ' Setting initial best scores to 0
        BestScores.Add("latte", 0)
        BestScores.Add("mocha", 0)
        BestScores.Add("chai", 0)
        BestScores.Add("macchiato", 0)

        ' Setting current quiz scores to 0
        CurrentScores.Add("latte", 0)
        CurrentScores.Add("mocha", 0)
        CurrentScores.Add("chai", 0)
        CurrentScores.Add("macchiato", 0)

        ' #### ADD CHECKING IF USER EXISTS ####
    End Sub

    Public Sub StartQuiz(ByVal Drink As DrinkClass)
        ' Setting current quiz to the given quiz
        CurrentQuiz = Drink.Quiz

        ' Resetting the current score for the given quiz to 0
        CurrentScores(CurrentQuiz.DrinkName) = 0

        ' #### SET SHOWING FIRST QUESTION ####
    End Sub

    Public Sub NextQuestion()
        ' Goes to the next question in the quiz, if one is being taken
        If (Not IsNothing(CurrentQuiz)) Then
            TrainingForm.ShowQuestion(CurrentQuiz.GetQuestion(), 0)
        End If
    End Sub

    Public Sub FinishQuiz()
        ' Finish the quiz
        '   1) Check quiz score better than previous best score, if better replace
        '   2) Update stored score values for the user?
        If (CurrentScores.Item(CurrentQuiz.DrinkName) > BestScores.Item(CurrentQuiz.DrinkName)) Then
            BestScores(CurrentQuiz.DrinkName) = CurrentScores.Item(CurrentQuiz.DrinkName)
        End If
    End Sub

    Public Sub Save()
        ' Saves the user and their scores to the given file
    End Sub
End Class
