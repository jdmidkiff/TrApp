Public Class DrinkClass
    Public DrinkName As String
    Public Recipe As String
    Public Quiz As QuizClass

    Public Sub New(ByVal Name As String, ByVal RecipeFilename As String, ByVal QuizFilename As String)
        '   Set the drink name to used for a given instance of the class
        DrinkName = Name
        Recipe = RecipeFilename
        Quiz = New QuizClass(Name, QuizFilename)

    End Sub

End Class
Public Class QuizClass

    Public DrinkName As String
    Public QuizFileName As String
    Private CurrentQuestion As Question

    Public Structure Question
        Dim Question As String
        Dim AnswerList As List(Of String)
        Dim CorrectAnswer As Integer
    End Structure

    Private QuestionList As New List(Of Question)

    Public Sub New(ByVal Name As String, ByVal Filename As String)
        '   This method is a constructor for the Quiz object loads data from a file containing the quiz data  

        '   Set the drink name to used for a given instance of the class
        DrinkName = Name

        Dim CurrentRow As String()
        Dim currQuestion As New Question
        Dim AnswerList As New List(Of String)

        '   Open the data file & read the data into a "Question" object
        Using QuizReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Filename)
            QuizReader.TextFieldType = FileIO.FieldType.Delimited
            QuizReader.SetDelimiters("/")

            '   Iterate through the rows in the data file...
            While Not QuizReader.EndOfData
                Try
                    CurrentRow = QuizReader.ReadFields()

                    '   Load data from the file into the appropriate object variables...
                    currQuestion.Question = CurrentRow(0)

                    AnswerList.Add(CurrentRow(1))
                    AnswerList.Add(CurrentRow(2))
                    AnswerList.Add(CurrentRow(3))
                    AnswerList.Add(CurrentRow(4))

                    currQuestion.AnswerList = AnswerList
                    currQuestion.CorrectAnswer = Int(CurrentRow(5))

                    '   Add the question to the list of questions associated with the current quiz...
                    QuestionList.Add(currQuestion)

                    '   Clear the Answer list to prevent the list to prevent answers from being carried over to the next question... 
                    AnswerList.Clear()

                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub

    Public Function GetQuestion() As Question
        '   Dim q As Question

        CurrentQuestion.Question = "Where art thou?"
        CurrentQuestion.AnswerList = New List(Of String)
        CurrentQuestion.AnswerList.Add("In the shed")
        CurrentQuestion.AnswerList.Add("In the Viranda")
        CurrentQuestion.AnswerList.Add("In the Rose Garden")
        CurrentQuestion.AnswerList.Add("In the Boat House")
        CurrentQuestion.CorrectAnswer = 2

        GetQuestion = CurrentQuestion
    End Function

    Public Function CheckAnswer(ByVal UserResponse) As Boolean
        CheckAnswer = (CurrentQuestion.CorrectAnswer = UserResponse)
    End Function

    Public Sub ResetQuiz()
        CurrentQuestion = Nothing
    End Sub
End Class
