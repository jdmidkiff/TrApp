Public Class User
    ' ### Private Member Variables ###
    Private Const usersFile = "users.txt"

    Private name As String
    ' Private member variable for the form to update when taking a quiz
    Private form As Form

    ' Best quiz scores
    Private bestScores As Dictionary(Of String, Integer)

    ' Current score for quiz
    Private currentScores As Dictionary(Of String, Integer)
    Private currentQuiz As QuizClass

    ' Public member variable indicating whether the user previsouly existed
    Public existed As Boolean

    Public Sub New(ByVal username As String, ByRef trainingForm As Form)
        name = username
        existed = False
        currentQuiz = Nothing
        form = trainingForm

        ' Setting initial best scores to 0
        bestScores.Add("latte", 0)
        bestScores.Add("mocha", 0)
        bestScores.Add("chai", 0)
        bestScores.Add("macchiato", 0)

        ' Setting current quiz scores to 0
        currentScores.Add("latte", 0)
        currentScores.Add("mocha", 0)
        currentScores.Add("chai", 0)
        currentScores.Add("macchiato", 0)

        ' #### ADD CHECKING IF USER EXISTS ####
    End Sub

    Public Sub startQuiz(ByVal quiz As QuizClass)
        ' Setting current quiz to the given quiz
        'currentQuiz = quiz

        ' #### SET SHOWING FIRST QUESTION ####
    End Sub

    Public Sub nextQuestion()
        ' Goes to the next question in the quiz, if one is being taken
    End Sub

    Public Sub finishQuiz()
        ' Finish the quiz
        '   1) Check quiz score better than previous best score, if better replace
        '   2) Update stored score values for the user?
    End Sub

    Public Sub save()
        ' Saves the user and their scores to the given file
    End Sub
End Class
