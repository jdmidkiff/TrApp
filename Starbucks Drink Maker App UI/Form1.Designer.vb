<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button_Quizzes = New System.Windows.Forms.Button()
        Me.Button_Results = New System.Windows.Forms.Button()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.Button_Recipes = New System.Windows.Forms.Button()
        Me.Picturebox_Logo = New System.Windows.Forms.PictureBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel_Drink = New System.Windows.Forms.Panel()
        Me.Label_Drink_Latte = New System.Windows.Forms.Label()
        Me.Label_Drink_Chai = New System.Windows.Forms.Label()
        Me.Label_Drink_Macchiato = New System.Windows.Forms.Label()
        Me.Label_Drink_Mocha = New System.Windows.Forms.Label()
        Me.lbldrinkmenu = New System.Windows.Forms.Label()
        Me.Panel_Recipes = New System.Windows.Forms.Panel()
        Me.PictureBox_Recipe = New System.Windows.Forms.PictureBox()
        Me.Label_Recipes = New System.Windows.Forms.Label()
        Me.Panel_Quiz = New System.Windows.Forms.Panel()
        Me.Button_Next_Quiz_Question = New System.Windows.Forms.Button()
        Me.Label_Quiz_Counter = New System.Windows.Forms.Label()
        Me.Wrong_Guess_2 = New System.Windows.Forms.Label()
        Me.Wrong_Guess_3 = New System.Windows.Forms.Label()
        Me.Wrong_Guess_1 = New System.Windows.Forms.Label()
        Me.Label_Quiz_Score = New System.Windows.Forms.Label()
        Me.Label_Quiz_Incorrect_Count = New System.Windows.Forms.Label()
        Me.RadioButton_Quiz_Answer4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Quiz_Answer3 = New System.Windows.Forms.RadioButton()
        Me.Label_Quiz_Question = New System.Windows.Forms.Label()
        Me.RadioButton_Quiz_Answer2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Quiz_Answer1 = New System.Windows.Forms.RadioButton()
        Me.Panel_Results = New System.Windows.Forms.Panel()
        Me.Label_Results = New System.Windows.Forms.Label()
        Me.Panel_Instructions = New System.Windows.Forms.Panel()
        Me.Label_Instructions = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Picturebox_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel_Drink.SuspendLayout()
        Me.Panel_Recipes.SuspendLayout()
        CType(Me.PictureBox_Recipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Quiz.SuspendLayout()
        Me.Panel_Results.SuspendLayout()
        Me.Panel_Instructions.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_Quizzes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_Results)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_Exit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button_Recipes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Picturebox_Logo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(785, 659)
        Me.SplitContainer1.SplitterDistance = 175
        Me.SplitContainer1.TabIndex = 0
        '
        'Button_Quizzes
        '
        Me.Button_Quizzes.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Quizzes.Location = New System.Drawing.Point(12, 359)
        Me.Button_Quizzes.Name = "Button_Quizzes"
        Me.Button_Quizzes.Size = New System.Drawing.Size(136, 52)
        Me.Button_Quizzes.TabIndex = 2
        Me.Button_Quizzes.Text = "QUIZZES"
        Me.Button_Quizzes.UseVisualStyleBackColor = True
        '
        'Button_Results
        '
        Me.Button_Results.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Results.Location = New System.Drawing.Point(12, 442)
        Me.Button_Results.Name = "Button_Results"
        Me.Button_Results.Size = New System.Drawing.Size(136, 52)
        Me.Button_Results.TabIndex = 3
        Me.Button_Results.Text = "RESULTS"
        Me.Button_Results.UseVisualStyleBackColor = True
        '
        'Button_Exit
        '
        Me.Button_Exit.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Exit.Location = New System.Drawing.Point(12, 522)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(136, 52)
        Me.Button_Exit.TabIndex = 4
        Me.Button_Exit.Text = "EXIT"
        Me.Button_Exit.UseVisualStyleBackColor = True
        '
        'Button_Recipes
        '
        Me.Button_Recipes.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Recipes.Location = New System.Drawing.Point(12, 279)
        Me.Button_Recipes.Name = "Button_Recipes"
        Me.Button_Recipes.Size = New System.Drawing.Size(136, 52)
        Me.Button_Recipes.TabIndex = 1
        Me.Button_Recipes.Text = "RECIPES"
        Me.Button_Recipes.UseVisualStyleBackColor = True
        '
        'Picturebox_Logo
        '
        Me.Picturebox_Logo.Image = CType(resources.GetObject("Picturebox_Logo.Image"), System.Drawing.Image)
        Me.Picturebox_Logo.Location = New System.Drawing.Point(3, 3)
        Me.Picturebox_Logo.Name = "Picturebox_Logo"
        Me.Picturebox_Logo.Size = New System.Drawing.Size(155, 141)
        Me.Picturebox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picturebox_Logo.TabIndex = 0
        Me.Picturebox_Logo.TabStop = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel_Drink)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel_Recipes)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel_Quiz)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel_Results)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel_Instructions)
        Me.SplitContainer2.Size = New System.Drawing.Size(606, 659)
        Me.SplitContainer2.SplitterDistance = 146
        Me.SplitContainer2.TabIndex = 0
        '
        'Panel_Drink
        '
        Me.Panel_Drink.Controls.Add(Me.Label_Drink_Latte)
        Me.Panel_Drink.Controls.Add(Me.Label_Drink_Chai)
        Me.Panel_Drink.Controls.Add(Me.Label_Drink_Macchiato)
        Me.Panel_Drink.Controls.Add(Me.Label_Drink_Mocha)
        Me.Panel_Drink.Controls.Add(Me.lbldrinkmenu)
        Me.Panel_Drink.Location = New System.Drawing.Point(0, 3)
        Me.Panel_Drink.Name = "Panel_Drink"
        Me.Panel_Drink.Size = New System.Drawing.Size(603, 142)
        Me.Panel_Drink.TabIndex = 1
        Me.Panel_Drink.Visible = False
        '
        'Label_Drink_Latte
        '
        Me.Label_Drink_Latte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_Drink_Latte.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Drink_Latte.Image = Global.Starbucks_Drink_Maker_App_UI.My.Resources.Resources.Starbucks_Latte_Diagram
        Me.Label_Drink_Latte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label_Drink_Latte.Location = New System.Drawing.Point(19, 25)
        Me.Label_Drink_Latte.Name = "Label_Drink_Latte"
        Me.Label_Drink_Latte.Size = New System.Drawing.Size(110, 110)
        Me.Label_Drink_Latte.TabIndex = 14
        Me.Label_Drink_Latte.Text = "Latte"
        Me.Label_Drink_Latte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label_Drink_Chai
        '
        Me.Label_Drink_Chai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_Drink_Chai.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Drink_Chai.Image = Global.Starbucks_Drink_Maker_App_UI.My.Resources.Resources.Starbucks_Chai_Diagram
        Me.Label_Drink_Chai.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label_Drink_Chai.Location = New System.Drawing.Point(412, 25)
        Me.Label_Drink_Chai.Name = "Label_Drink_Chai"
        Me.Label_Drink_Chai.Size = New System.Drawing.Size(110, 110)
        Me.Label_Drink_Chai.TabIndex = 17
        Me.Label_Drink_Chai.Text = "Chai"
        Me.Label_Drink_Chai.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label_Drink_Macchiato
        '
        Me.Label_Drink_Macchiato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_Drink_Macchiato.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Drink_Macchiato.Image = Global.Starbucks_Drink_Maker_App_UI.My.Resources.Resources.Starbucks_Macchiato_Diagram
        Me.Label_Drink_Macchiato.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label_Drink_Macchiato.Location = New System.Drawing.Point(284, 25)
        Me.Label_Drink_Macchiato.Name = "Label_Drink_Macchiato"
        Me.Label_Drink_Macchiato.Size = New System.Drawing.Size(110, 110)
        Me.Label_Drink_Macchiato.TabIndex = 16
        Me.Label_Drink_Macchiato.Text = "Macchiato"
        Me.Label_Drink_Macchiato.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label_Drink_Mocha
        '
        Me.Label_Drink_Mocha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_Drink_Mocha.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Drink_Mocha.Image = Global.Starbucks_Drink_Maker_App_UI.My.Resources.Resources.Starbucks_Mocha_Diagram
        Me.Label_Drink_Mocha.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label_Drink_Mocha.Location = New System.Drawing.Point(155, 26)
        Me.Label_Drink_Mocha.Name = "Label_Drink_Mocha"
        Me.Label_Drink_Mocha.Size = New System.Drawing.Size(110, 110)
        Me.Label_Drink_Mocha.TabIndex = 15
        Me.Label_Drink_Mocha.Text = "Mocha"
        Me.Label_Drink_Mocha.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbldrinkmenu
        '
        Me.lbldrinkmenu.AutoSize = True
        Me.lbldrinkmenu.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrinkmenu.Location = New System.Drawing.Point(4, 4)
        Me.lbldrinkmenu.Name = "lbldrinkmenu"
        Me.lbldrinkmenu.Size = New System.Drawing.Size(147, 18)
        Me.lbldrinkmenu.TabIndex = 13
        Me.lbldrinkmenu.Text = "DRINK MENU LABEL"
        '
        'Panel_Recipes
        '
        Me.Panel_Recipes.Controls.Add(Me.PictureBox_Recipe)
        Me.Panel_Recipes.Controls.Add(Me.Label_Recipes)
        Me.Panel_Recipes.Location = New System.Drawing.Point(495, 401)
        Me.Panel_Recipes.Name = "Panel_Recipes"
        Me.Panel_Recipes.Size = New System.Drawing.Size(99, 85)
        Me.Panel_Recipes.TabIndex = 6
        Me.Panel_Recipes.Visible = False
        '
        'PictureBox_Recipe
        '
        Me.PictureBox_Recipe.Location = New System.Drawing.Point(14, 25)
        Me.PictureBox_Recipe.Name = "PictureBox_Recipe"
        Me.PictureBox_Recipe.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox_Recipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox_Recipe.TabIndex = 1
        Me.PictureBox_Recipe.TabStop = False
        '
        'Label_Recipes
        '
        Me.Label_Recipes.AutoSize = True
        Me.Label_Recipes.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Recipes.Location = New System.Drawing.Point(11, 6)
        Me.Label_Recipes.Name = "Label_Recipes"
        Me.Label_Recipes.Size = New System.Drawing.Size(55, 16)
        Me.Label_Recipes.TabIndex = 0
        Me.Label_Recipes.Text = "Recipes"
        Me.Label_Recipes.Visible = False
        '
        'Panel_Quiz
        '
        Me.Panel_Quiz.Controls.Add(Me.Button_Next_Quiz_Question)
        Me.Panel_Quiz.Controls.Add(Me.Label_Quiz_Counter)
        Me.Panel_Quiz.Controls.Add(Me.Wrong_Guess_2)
        Me.Panel_Quiz.Controls.Add(Me.Wrong_Guess_3)
        Me.Panel_Quiz.Controls.Add(Me.Wrong_Guess_1)
        Me.Panel_Quiz.Controls.Add(Me.Label_Quiz_Score)
        Me.Panel_Quiz.Controls.Add(Me.Label_Quiz_Incorrect_Count)
        Me.Panel_Quiz.Controls.Add(Me.RadioButton_Quiz_Answer4)
        Me.Panel_Quiz.Controls.Add(Me.RadioButton_Quiz_Answer3)
        Me.Panel_Quiz.Controls.Add(Me.Label_Quiz_Question)
        Me.Panel_Quiz.Controls.Add(Me.RadioButton_Quiz_Answer2)
        Me.Panel_Quiz.Controls.Add(Me.RadioButton_Quiz_Answer1)
        Me.Panel_Quiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Quiz.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Quiz.Name = "Panel_Quiz"
        Me.Panel_Quiz.Size = New System.Drawing.Size(606, 509)
        Me.Panel_Quiz.TabIndex = 1
        Me.Panel_Quiz.Visible = False
        '
        'Button_Next_Quiz_Question
        '
        Me.Button_Next_Quiz_Question.Enabled = False
        Me.Button_Next_Quiz_Question.Location = New System.Drawing.Point(371, 382)
        Me.Button_Next_Quiz_Question.Name = "Button_Next_Quiz_Question"
        Me.Button_Next_Quiz_Question.Size = New System.Drawing.Size(107, 34)
        Me.Button_Next_Quiz_Question.TabIndex = 12
        Me.Button_Next_Quiz_Question.Text = "Next >>>"
        Me.Button_Next_Quiz_Question.UseVisualStyleBackColor = True
        '
        'Label_Quiz_Counter
        '
        Me.Label_Quiz_Counter.AutoSize = True
        Me.Label_Quiz_Counter.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Quiz_Counter.Location = New System.Drawing.Point(14, 7)
        Me.Label_Quiz_Counter.Name = "Label_Quiz_Counter"
        Me.Label_Quiz_Counter.Size = New System.Drawing.Size(73, 21)
        Me.Label_Quiz_Counter.TabIndex = 6
        Me.Label_Quiz_Counter.Text = "QCounter"
        Me.Label_Quiz_Counter.Visible = False
        '
        'Wrong_Guess_2
        '
        Me.Wrong_Guess_2.AutoSize = True
        Me.Wrong_Guess_2.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wrong_Guess_2.Location = New System.Drawing.Point(493, 4)
        Me.Wrong_Guess_2.Name = "Wrong_Guess_2"
        Me.Wrong_Guess_2.Size = New System.Drawing.Size(16, 24)
        Me.Wrong_Guess_2.TabIndex = 11
        Me.Wrong_Guess_2.Text = "l"
        Me.Wrong_Guess_2.Visible = False
        '
        'Wrong_Guess_3
        '
        Me.Wrong_Guess_3.AutoSize = True
        Me.Wrong_Guess_3.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wrong_Guess_3.Location = New System.Drawing.Point(504, 4)
        Me.Wrong_Guess_3.Name = "Wrong_Guess_3"
        Me.Wrong_Guess_3.Size = New System.Drawing.Size(16, 24)
        Me.Wrong_Guess_3.TabIndex = 10
        Me.Wrong_Guess_3.Text = "l"
        Me.Wrong_Guess_3.Visible = False
        '
        'Wrong_Guess_1
        '
        Me.Wrong_Guess_1.AutoSize = True
        Me.Wrong_Guess_1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wrong_Guess_1.Location = New System.Drawing.Point(482, 4)
        Me.Wrong_Guess_1.Name = "Wrong_Guess_1"
        Me.Wrong_Guess_1.Size = New System.Drawing.Size(16, 24)
        Me.Wrong_Guess_1.TabIndex = 9
        Me.Wrong_Guess_1.Text = "l"
        Me.Wrong_Guess_1.Visible = False
        '
        'Label_Quiz_Score
        '
        Me.Label_Quiz_Score.AutoSize = True
        Me.Label_Quiz_Score.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Quiz_Score.Location = New System.Drawing.Point(209, 4)
        Me.Label_Quiz_Score.Name = "Label_Quiz_Score"
        Me.Label_Quiz_Score.Size = New System.Drawing.Size(51, 21)
        Me.Label_Quiz_Score.TabIndex = 8
        Me.Label_Quiz_Score.Text = "Score:"
        Me.Label_Quiz_Score.Visible = False
        '
        'Label_Quiz_Incorrect_Count
        '
        Me.Label_Quiz_Incorrect_Count.AutoSize = True
        Me.Label_Quiz_Incorrect_Count.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Quiz_Incorrect_Count.Location = New System.Drawing.Point(346, 4)
        Me.Label_Quiz_Incorrect_Count.Name = "Label_Quiz_Incorrect_Count"
        Me.Label_Quiz_Incorrect_Count.Size = New System.Drawing.Size(132, 21)
        Me.Label_Quiz_Incorrect_Count.TabIndex = 7
        Me.Label_Quiz_Incorrect_Count.Text = "Incorrect Guesses:"
        Me.Label_Quiz_Incorrect_Count.Visible = False
        '
        'RadioButton_Quiz_Answer4
        '
        Me.RadioButton_Quiz_Answer4.AutoSize = True
        Me.RadioButton_Quiz_Answer4.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Quiz_Answer4.Location = New System.Drawing.Point(32, 259)
        Me.RadioButton_Quiz_Answer4.Name = "RadioButton_Quiz_Answer4"
        Me.RadioButton_Quiz_Answer4.Size = New System.Drawing.Size(77, 22)
        Me.RadioButton_Quiz_Answer4.TabIndex = 5
        Me.RadioButton_Quiz_Answer4.TabStop = True
        Me.RadioButton_Quiz_Answer4.Text = "Answer4"
        Me.RadioButton_Quiz_Answer4.UseVisualStyleBackColor = True
        Me.RadioButton_Quiz_Answer4.Visible = False
        '
        'RadioButton_Quiz_Answer3
        '
        Me.RadioButton_Quiz_Answer3.AutoSize = True
        Me.RadioButton_Quiz_Answer3.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Quiz_Answer3.Location = New System.Drawing.Point(32, 218)
        Me.RadioButton_Quiz_Answer3.Name = "RadioButton_Quiz_Answer3"
        Me.RadioButton_Quiz_Answer3.Size = New System.Drawing.Size(77, 22)
        Me.RadioButton_Quiz_Answer3.TabIndex = 4
        Me.RadioButton_Quiz_Answer3.TabStop = True
        Me.RadioButton_Quiz_Answer3.Text = "Answer3"
        Me.RadioButton_Quiz_Answer3.UseVisualStyleBackColor = True
        Me.RadioButton_Quiz_Answer3.Visible = False
        '
        'Label_Quiz_Question
        '
        Me.Label_Quiz_Question.AutoSize = True
        Me.Label_Quiz_Question.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Quiz_Question.Location = New System.Drawing.Point(32, 81)
        Me.Label_Quiz_Question.Name = "Label_Quiz_Question"
        Me.Label_Quiz_Question.Size = New System.Drawing.Size(82, 24)
        Me.Label_Quiz_Question.TabIndex = 1
        Me.Label_Quiz_Question.Text = "Question"
        Me.Label_Quiz_Question.Visible = False
        '
        'RadioButton_Quiz_Answer2
        '
        Me.RadioButton_Quiz_Answer2.AutoSize = True
        Me.RadioButton_Quiz_Answer2.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Quiz_Answer2.Location = New System.Drawing.Point(32, 178)
        Me.RadioButton_Quiz_Answer2.Name = "RadioButton_Quiz_Answer2"
        Me.RadioButton_Quiz_Answer2.Size = New System.Drawing.Size(77, 22)
        Me.RadioButton_Quiz_Answer2.TabIndex = 3
        Me.RadioButton_Quiz_Answer2.TabStop = True
        Me.RadioButton_Quiz_Answer2.Text = "Answer2"
        Me.RadioButton_Quiz_Answer2.UseVisualStyleBackColor = True
        Me.RadioButton_Quiz_Answer2.Visible = False
        '
        'RadioButton_Quiz_Answer1
        '
        Me.RadioButton_Quiz_Answer1.AutoSize = True
        Me.RadioButton_Quiz_Answer1.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Quiz_Answer1.Location = New System.Drawing.Point(32, 138)
        Me.RadioButton_Quiz_Answer1.Name = "RadioButton_Quiz_Answer1"
        Me.RadioButton_Quiz_Answer1.Size = New System.Drawing.Size(77, 22)
        Me.RadioButton_Quiz_Answer1.TabIndex = 2
        Me.RadioButton_Quiz_Answer1.TabStop = True
        Me.RadioButton_Quiz_Answer1.Text = "Answer1"
        Me.RadioButton_Quiz_Answer1.UseVisualStyleBackColor = True
        Me.RadioButton_Quiz_Answer1.Visible = False
        '
        'Panel_Results
        '
        Me.Panel_Results.Controls.Add(Me.Label_Results)
        Me.Panel_Results.Location = New System.Drawing.Point(464, 79)
        Me.Panel_Results.Name = "Panel_Results"
        Me.Panel_Results.Size = New System.Drawing.Size(80, 83)
        Me.Panel_Results.TabIndex = 2
        Me.Panel_Results.Visible = False
        '
        'Label_Results
        '
        Me.Label_Results.AutoSize = True
        Me.Label_Results.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Results.Location = New System.Drawing.Point(5, 14)
        Me.Label_Results.Name = "Label_Results"
        Me.Label_Results.Size = New System.Drawing.Size(52, 16)
        Me.Label_Results.TabIndex = 0
        Me.Label_Results.Text = "Results"
        '
        'Panel_Instructions
        '
        Me.Panel_Instructions.Controls.Add(Me.Label_Instructions)
        Me.Panel_Instructions.Location = New System.Drawing.Point(23, 31)
        Me.Panel_Instructions.Name = "Panel_Instructions"
        Me.Panel_Instructions.Size = New System.Drawing.Size(128, 109)
        Me.Panel_Instructions.TabIndex = 1
        '
        'Label_Instructions
        '
        Me.Label_Instructions.AutoSize = True
        Me.Label_Instructions.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Instructions.Location = New System.Drawing.Point(3, 7)
        Me.Label_Instructions.Name = "Label_Instructions"
        Me.Label_Instructions.Size = New System.Drawing.Size(393, 196)
        Me.Label_Instructions.TabIndex = 0
        Me.Label_Instructions.Text = "Welcome to the Starbucks Drink Maker!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ADD INSTRUCTIONS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """"""
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(785, 659)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HomeForm"
        Me.Text = "Home"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Picturebox_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel_Drink.ResumeLayout(False)
        Me.Panel_Drink.PerformLayout()
        Me.Panel_Recipes.ResumeLayout(False)
        Me.Panel_Recipes.PerformLayout()
        CType(Me.PictureBox_Recipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Quiz.ResumeLayout(False)
        Me.Panel_Quiz.PerformLayout()
        Me.Panel_Results.ResumeLayout(False)
        Me.Panel_Results.PerformLayout()
        Me.Panel_Instructions.ResumeLayout(False)
        Me.Panel_Instructions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Picturebox_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button_Exit As System.Windows.Forms.Button
    Friend WithEvents Button_Results As System.Windows.Forms.Button
    Friend WithEvents Button_Quizzes As System.Windows.Forms.Button
    Friend WithEvents Button_Recipes As System.Windows.Forms.Button
    Friend WithEvents RadioButton_Quiz_Answer4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Quiz_Answer3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Quiz_Answer2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Quiz_Answer1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label_Quiz_Question As System.Windows.Forms.Label
    Friend WithEvents Panel_Recipes As System.Windows.Forms.Panel
    Friend WithEvents Panel_Quiz As System.Windows.Forms.Panel
    Friend WithEvents Label_Quiz_Counter As System.Windows.Forms.Label
    Friend WithEvents Wrong_Guess_2 As System.Windows.Forms.Label
    Friend WithEvents Wrong_Guess_3 As System.Windows.Forms.Label
    Friend WithEvents Wrong_Guess_1 As System.Windows.Forms.Label
    Friend WithEvents Label_Quiz_Score As System.Windows.Forms.Label
    Friend WithEvents Label_Quiz_Incorrect_Count As System.Windows.Forms.Label
    Friend WithEvents Panel_Instructions As System.Windows.Forms.Panel
    Friend WithEvents Label_Instructions As System.Windows.Forms.Label
    Friend WithEvents Panel_Drink As System.Windows.Forms.Panel
    Friend WithEvents Label_Drink_Chai As System.Windows.Forms.Label
    Friend WithEvents Label_Drink_Macchiato As System.Windows.Forms.Label
    Friend WithEvents Label_Drink_Mocha As System.Windows.Forms.Label
    Friend WithEvents Label_Drink_Latte As System.Windows.Forms.Label
    Friend WithEvents lbldrinkmenu As System.Windows.Forms.Label
    Friend WithEvents Label_Recipes As System.Windows.Forms.Label
    Friend WithEvents Panel_Results As System.Windows.Forms.Panel
    Friend WithEvents Label_Results As System.Windows.Forms.Label
    Friend WithEvents PictureBox_Recipe As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Next_Quiz_Question As System.Windows.Forms.Button

End Class
