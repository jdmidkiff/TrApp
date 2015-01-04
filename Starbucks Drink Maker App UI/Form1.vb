Public Class HomeForm
    '   Declare class-level variables to keep track of the user's selections...
    Dim SelectedDrink As String
    Dim SelectedAction As String
    Dim CurrentQuiz As New ArrayList
    Dim QuizQuestionIdx As Integer
    Dim NumQuizQuestions As Integer

    Dim DrinkDict As New Dictionary(Of String, DrinkClass)

    Private Sub HomeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SelectedDrink = ""
        SelectedAction = ""
        ShowContentPanel(Panel_Instructions)
        SelectDrink("hide")
        SelectAction("none")

        Dim d As New DrinkClass("Chai", ".\resources\Starbucks Chai Recipe Card.png", ".\resources\Chai Questions.txt")
        DrinkDict.Add("Chai", d)
        d = New DrinkClass("Latte", ".\resources\Starbucks Latte Recipe Card.png", ".\resources\Latte Questions.txt")
        DrinkDict.Add("Latte", d)
        d = New DrinkClass("Macchiato", ".\resources\Starbucks Macchiato Recipe Card.png", ".\resources\Macchiato Questions.txt")
        DrinkDict.Add("Macchiato", d)
        d = New DrinkClass("Mocha", ".\resources\Starbucks Mocha Recipe Card.png", ".\resources\Mocha Questions.txt")
        DrinkDict.Add("Mocha", d)

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
        SelectDrink("latte")
    End Sub

    Private Sub Label_Drink_Mocha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_Drink_Mocha.Click
        SelectDrink("mocha")
    End Sub

    Private Sub Label_Drink_Macchiato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_Drink_Macchiato.Click
        SelectDrink("macchiato")
    End Sub

    Private Sub Label_Drink_Chai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_Drink_Chai.Click
        SelectDrink("chai")
    End Sub

    Private Sub Picturebox_Logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxlogo.Click
        ShowContentPanel(Panel_Instructions)
        SelectDrink("hide")
        SelectAction("none")
    End Sub

    Private Sub SelectAction(ByVal Action As String)
        Dim SelectededBackColor = Color.GreenYellow
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

        End Select
    End Sub

    Private Sub SelectDrink(ByVal DrinkName As String)

        Dim SelectededBackColor = Color.GreenYellow
        Dim UnselectededBackColor = Color.White

        '   Set all the picture box's background color to "unselected" color
        Label_Drink_Chai.BackColor = UnselectededBackColor
        Label_Drink_Latte.BackColor = UnselectededBackColor
        Label_Drink_Macchiato.BackColor = UnselectededBackColor
        Label_Drink_Mocha.BackColor = UnselectededBackColor

        SelectedDrink = DrinkName

        '   Set the desired button's background color to highlight it...
        Select Case SelectedDrink
            Case "chai"
                Label_Drink_Chai.BackColor = SelectededBackColor
                Select Case SelectedAction
                    Case "recipes"
                        PictureBox_Recipe.Load(".\resources\Starbucks Chai Recipe Card.png")
                        PictureBox_Recipe.Visible = True
                    Case "quizzes"
                        '   TakeQuiz(SelectedDrink)
                End Select
                Panel_Drink.Show()

            Case "latte"
                Label_Drink_Latte.BackColor = SelectededBackColor
                Select Case SelectedAction
                    Case "recipes"
                        PictureBox_Recipe.Load(".\resources\Starbucks Latte Recipe Card.png")
                        PictureBox_Recipe.Visible = True
                    Case "quizzes"
                        '   TakeQuiz(SelectedDrink)
                End Select
                Panel_Drink.Show()

            Case "macchiato"
                Label_Drink_Macchiato.BackColor = SelectededBackColor
                Select Case SelectedAction
                    Case "recipes"
                        PictureBox_Recipe.Load(".\resources\Starbucks Macchiato Recipe Card.png")
                        PictureBox_Recipe.Visible = True
                    Case "quizzes"
                        '   TakeQuiz(SelectedDrink)
                End Select
                Panel_Drink.Show()

            Case "mocha"
                Label_Drink_Mocha.BackColor = SelectededBackColor
                Select Case SelectedAction
                    Case "recipes"
                        PictureBox_Recipe.Load(".\resources\Starbucks Mocha Recipe Card.png")
                        PictureBox_Recipe.Visible = True
                    Case "quizzes"
                        '   TakeQuiz(SelectedDrink)
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

End Class
