' To-Do:
'   1) Checking if user already exists and setting the member variable "existed" to True/False
'   2) Implement the User.Save() method to save the user and their best scores
'   3) Implement the results page
'   4) Implement the login page
'

Public Class HomeForm
    '   Declare class-level variables to keep track of the user's selections...
    Dim SelectedDrink As String
    Dim SelectedAction As String
    Dim CurrentQuiz As New ArrayList
    Dim QuizQuestionIdx As Integer
    Dim NumQuizQuestions As Integer
    Dim CurrentUser As User
    Dim DrinkDict As New Dictionary(Of String, DrinkClass)

    Private Sub HomeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SelectedDrink = ""
        SelectedAction = ""
        SelectDrink("hide")
        SelectAction("none")
        ShowContentPanel(Panel_Instructions)

        DrinkDict.Add("Chai", New DrinkClass("Chai", ".\resources\Starbucks Chai Recipe Card.png", ".\resources\Chai Questions.txt"))
        DrinkDict.Add("Latte", New DrinkClass("Latte", ".\resources\Starbucks Latte Recipe Card.png", ".\resources\Latte Questions.txt"))
        DrinkDict.Add("Macchiato", New DrinkClass("Macchiato", ".\resources\Starbucks Macchiato Recipe Card.png", ".\resources\Macchiato Questions.txt"))
        DrinkDict.Add("Mocha", New DrinkClass("Mocha", ".\resources\Starbucks Mocha Recipe Card.png", ".\resources\Mocha Questions.txt"))

        CurrentUser = New User("Sally", Me)
    End Sub

    Private Sub Button_Quizzes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Quizzes.Click
        SelectAction("quizzes")
    End Sub

    Private Sub Button_Recipes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Recipes.Click
        SelectAction("recipes")
    End Sub

    Private Sub Button_Results_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Results.Click
        SelectAction("results")
    End Sub

    Private Sub Button_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Exit.Click
        SelectAction("exit")
        Application.Exit()
    End Sub

    Private Sub Label_Drink_Latte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_Drink_Latte.Click
        SelectDrink("Latte")
    End Sub

    Private Sub Label_Drink_Mocha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_Drink_Mocha.Click
        SelectDrink("Mocha")
    End Sub

    Private Sub Label_Drink_Macchiato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_Drink_Macchiato.Click
        SelectDrink("Macchiato")
    End Sub

    Private Sub Label_Drink_Chai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_Drink_Chai.Click
        SelectDrink("Chai")
    End Sub

    Private Sub Picturebox_Logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picturebox_Logo.Click
        ShowContentPanel(Panel_Instructions)
        SelectDrink("hide")
        SelectAction("none")
    End Sub

    Private Sub SelectAction(ByVal Action As String)
        Dim SelectededBackColor = Color.Green
        '   Dim UnselectededBackColor = Control.DefaultBackColor
        Dim UnselectededBackColor = Color.LightGray

        '   Set all the button's background color to "unselected" color
        Button_Recipes.BackColor = UnselectededBackColor
        Button_Quizzes.BackColor = UnselectededBackColor
        Button_Results.BackColor = UnselectededBackColor
        Button_Exit.BackColor = UnselectededBackColor

        SelectedAction = Action

        '   Set the desired button's background color to highlight it...
        Select Case SelectedAction
            Case "recipes"
                Button_Recipes.BackColor = SelectededBackColor
                lbldrinkmenu.Text = "Select a drink recipe..."
                SelectDrink("none")
                PictureBox_Recipe.Visible = False
                ShowContentPanel(Panel_Recipes)

            Case "quizzes"
                Button_Quizzes.BackColor = SelectededBackColor
                lbldrinkmenu.Text = "Select a drink quiz..."
                SelectDrink("none")
                '   Button_Recipes.Enabled = False
                ShowContentPanel(Panel_Quiz)

            Case "results"
                Button_Results.BackColor = SelectededBackColor
                Panel_Drink.Hide()

                ShowContentPanel(Panel_Results)

            Case "exit"
                Button_Exit.BackColor = SelectededBackColor
                Panel_Drink.Hide()
                Panel_Instructions.Hide()
                Panel_Quiz.Hide()
                Panel_Recipes.Hide()
                Panel_Results.Hide()

            Case "none"
                '   Panel_Drink.Hide()
                Panel_Instructions.Hide()
                Panel_Quiz.Hide()
                Panel_Recipes.Hide()
                Panel_Results.Hide()

        End Select
    End Sub

    Private Sub SelectDrink(ByVal DrinkName As String)

        Dim SelectededBackColor = Color.Green
        Dim UnselectededBackColor = Color.White

        '   Set all the picture box's background color to "unselected" color
        Label_Drink_Chai.BackColor = UnselectededBackColor
        Label_Drink_Latte.BackColor = UnselectededBackColor
        Label_Drink_Macchiato.BackColor = UnselectededBackColor
        Label_Drink_Mocha.BackColor = UnselectededBackColor

        SelectedDrink = DrinkName

        '   Set the desired button's background color to highlight it...
        Select Case SelectedDrink
            Case "Chai"
                Label_Drink_Chai.BackColor = SelectededBackColor
                Select Case SelectedAction
                    Case "recipes"
                        PictureBox_Recipe.Load(".\resources\Starbucks Chai Recipe Card.png")
                        PictureBox_Recipe.Visible = True
                    Case "quizzes"
                        CurrentUser.StartQuiz(DrinkDict(SelectedDrink))

                End Select
                Panel_Drink.Show()

            Case "Latte"
                Label_Drink_Latte.BackColor = SelectededBackColor
                Select Case SelectedAction
                    Case "recipes"
                        PictureBox_Recipe.Load(".\resources\Starbucks Latte Recipe Card.png")
                        PictureBox_Recipe.Visible = True
                    Case "quizzes"
                        CurrentUser.StartQuiz(DrinkDict(SelectedDrink))
                End Select
                Panel_Drink.Show()

            Case "Macchiato"
                Label_Drink_Macchiato.BackColor = SelectededBackColor
                Select Case SelectedAction
                    Case "recipes"
                        PictureBox_Recipe.Load(".\resources\Starbucks Macchiato Recipe Card.png")
                        PictureBox_Recipe.Visible = True
                    Case "quizzes"
                        CurrentUser.StartQuiz(DrinkDict(SelectedDrink))
                End Select
                Panel_Drink.Show()

            Case "Mocha"
                Label_Drink_Mocha.BackColor = SelectededBackColor
                Select Case SelectedAction
                    Case "recipes"
                        PictureBox_Recipe.Load(".\resources\Starbucks Mocha Recipe Card.png")
                        PictureBox_Recipe.Visible = True
                    Case "quizzes"
                        CurrentUser.StartQuiz(DrinkDict(SelectedDrink))
                End Select
                Panel_Drink.Show()

            Case "none"
                Panel_Drink.Show()

            Case "hide"
                Panel_Drink.Hide()
        End Select
    End Sub

    Private Sub ShowContentPanel(ByVal TargetPanel As Object)

        '   Make all the "content panels" in SplitContainer2.Panel2 invisible...
        '       Adapted from "http://stackoverflow.com/questions/199521/vb-net-iterating-through-controls-in-a-container-object"
        '
        '   Iterate through all of the controls in "Panel2"
        '       If a control is a Panel set Visible to False
        For Each ctrl As Control In SplitContainer2.Panel2.Controls
            If TypeOf ctrl Is Panel Then
                ctrl.Visible = False
            End If
        Next

        '   Make the desired "content panel" in SplitContainer2.Panel2 visible...
        TargetPanel.Location = New Point(0, 0)
        TargetPanel.Height = Panel_Instructions.Parent.Height
        TargetPanel.Width = Panel_Instructions.Parent.Width
        TargetPanel.Show()

    End Sub

    Private Sub RadioButton_Quiz_Answer1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Quiz_Answer1.CheckedChanged
        Button_Next_Quiz_Question.Enabled = True
        Button_Next_Quiz_Question.Visible = True
    End Sub

    Private Sub RadioButton_Quiz_Answer2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Quiz_Answer2.CheckedChanged
        Button_Next_Quiz_Question.Enabled = True

    End Sub

    Private Sub RadioButton_Quiz_Answer3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Quiz_Answer3.CheckedChanged
        Button_Next_Quiz_Question.Enabled = True

    End Sub

    Private Sub RadioButton_Quiz_Answer4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Quiz_Answer4.CheckedChanged
        Button_Next_Quiz_Question.Enabled = True

    End Sub

    Private Sub Button_Next_Quiz_Question_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Next_Quiz_Question.Click

        Dim SelectedAnswer = 0
        If (RadioButton_Quiz_Answer1.Checked) Then
            SelectedAnswer = 1
        ElseIf (RadioButton_Quiz_Answer2.Checked) Then
            SelectedAnswer = 2
        ElseIf (RadioButton_Quiz_Answer3.Checked) Then
            SelectedAnswer = 3
        ElseIf (RadioButton_Quiz_Answer4.Checked) Then
            SelectedAnswer = 4
        Else
            MsgBox("Unexpected situation ... no option appears to be selected")
        End If

        'Dim correct = DrinkDict(SelectedDrink).Quiz.CheckAnswer(SelectedAnswer)

        'MsgBox("Move to next question..." & vbCrLf & "SelectedAnswer = " & SelectedAnswer.ToString() & vbCrLf & "correct = " & correct.ToString())
        CurrentUser.SubmitQuestionAnswer(SelectedAnswer)
    End Sub

    Public Sub UpdateScore(ByVal Score As Integer)
        Me.Label_Quiz_Score.Text = "Score: " & Score
    End Sub

    Public Sub RemoveTallyMark(ByVal Idx As Integer)
        Select Case Idx
            Case 1
                Me.Wrong_Guess_1.ForeColor = Color.Red
            Case 2
                Me.Wrong_Guess_2.ForeColor = Color.Red
            Case 3
                Me.Wrong_Guess_3.ForeColor = Color.Red
                'Default
                'MsgBox()
        End Select
    End Sub

    Public Sub ShowQuestion(ByVal Question As QuizClass.Question, ByVal QuestionIdx As Integer, ByVal NumQuestions As Integer)
        ' Update the view showing the question
        Label_Quiz_Question.Visible = True
        Label_Quiz_Question.Text = Question.Question
        RadioButton_Quiz_Answer1.Visible = True
        RadioButton_Quiz_Answer1.Text = Question.AnswerList(0)
        RadioButton_Quiz_Answer2.Visible = True
        RadioButton_Quiz_Answer2.Text = Question.AnswerList(1)
        RadioButton_Quiz_Answer3.Visible = True
        RadioButton_Quiz_Answer3.Text = Question.AnswerList(2)
        RadioButton_Quiz_Answer4.Visible = True
        RadioButton_Quiz_Answer4.Text = Question.AnswerList(3)
        QuizQuestionIdx = QuestionIdx
        Me.Label_Quiz_Counter.Text = QuestionIdx & " of " & NumQuestions
    End Sub

    Public Sub StartQuiz()
        Me.Button_Recipes.Enabled = False
        Me.Button_Results.Enabled = False
        Me.Button_Quizzes.Enabled = False

        Me.Wrong_Guess_1.ForeColor = Color.Black
        Me.Wrong_Guess_2.ForeColor = Color.Black
        Me.Wrong_Guess_3.ForeColor = Color.Black

        Me.Wrong_Guess_1.Visible = True
        Me.Wrong_Guess_2.Visible = True
        Me.Wrong_Guess_3.Visible = True

        Me.Label_Quiz_Incorrect_Count.Visible = True

        Me.Label_Quiz_Score.Visible = True

        Me.Label_Quiz_Counter.Visible = True
        Button_Next_Quiz_Question.Visible = True
    End Sub

    Public Sub FinishQuiz()
        Button_Recipes.Enabled = True
        Button_Results.Enabled = True
        Button_Quizzes.Enabled = True

        Wrong_Guess_1.Visible = False
        Wrong_Guess_2.Visible = False
        Wrong_Guess_3.Visible = False

        Label_Quiz_Incorrect_Count.Visible = False

        Label_Quiz_Score.Visible = False

        Label_Quiz_Counter.Visible = False

        RadioButton_Quiz_Answer1.Visible = False
        RadioButton_Quiz_Answer2.Visible = False
        RadioButton_Quiz_Answer3.Visible = False
        RadioButton_Quiz_Answer4.Visible = False

        Label_Quiz_Question.Visible = False

        '   Panel_Quiz.Hide()

        Button_Next_Quiz_Question.Enabled = False
        Button_Next_Quiz_Question.Visible = False

        SelectDrink("none")
        SelectAction("none")
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub SplitContainer2_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer2.Panel2.Paint

    End Sub
End Class
