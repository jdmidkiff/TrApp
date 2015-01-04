Public Class FrmEntry
    Dim Scoreboard As New Collection
    ''System.IO.Streamwriter("Scoreboard.txt", True)

    Structure namescore
        Public playername As String 'Structure for storing usernames and scores'
        Public playerscore As Integer
    End Structure

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = Image.FromFile("Starbucks Logo.gif")
    End Sub

    Private Sub BtnBegin_Click(sender As System.Object, e As System.EventArgs) Handles BtnBegin.Click
        If TbxName.Text = "" Then MessageBox.Show("Please enter a name to begin")
        If TbxName.Text.Length = 1 Then MessageBox.Show("Username must have at least two characters")
        If TbxName.Text.Length > 2 Then
            DrinkMenu.Show()
            Me.Hide()
        End If

        Username = TbxName.Text
        'Username = text file storing names and scores'
    End Sub

    Private Sub FrmEntry_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Are you sure?" & " " & "Your progress will be saved") 'Exit message'
    End Sub

    Private Sub FrmEntry_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim tempinfo As namescore
        Dim readnames(1) As String
        Dim Usernames As New System.IO.StreamReader("Scoreboard.txt")
        Do While Usernames.EndOfStream = False 'Load and read questions'
            readnames = Split(Usernames.ReadLine(), "/")
            tempinfo.playername = readnames(0) 'Username'
            tempinfo.playerscore = readnames(1) 'Their score'
            Scoreboard.Add(tempinfo) 'Save information to text file'
        Loop


    End Sub
End Class