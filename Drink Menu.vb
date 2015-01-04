Public Class DrinkMenu
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pbxlattelabel.Visible = False
        pbxmacchiatolabel.Visible = False
        pbxmochalabel.Visible = False
        pbxchailabel.Visible = False
        lblinstructions.Visible = True
        lblastrik.Visible = True
    End Sub
    Private Sub Form2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Are you sure?" & " " & "Your progress will be saved")
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        LatteInstruct.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox1_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseHover
        pbxlattelabel.Visible = True
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseLeave
        pbxlattelabel.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        MacchiattoInstruct.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox2_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseHover
        pbxmacchiatolabel.Visible = True
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseLeave
        pbxmacchiatolabel.Visible = False
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        MochaInstruct.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox3_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseHover
        pbxmochalabel.Visible = True
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseLeave
        pbxmochalabel.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        ChaiInstruct.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox4.MouseHover
        pbxchailabel.Visible = True
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox4.MouseLeave
        pbxchailabel.Visible = False
    End Sub

    Private Sub btninstructions_Click(sender As System.Object, e As System.EventArgs) Handles btninstructions.Click
        lblinstructions.Hide()
        btninstructions.Hide()
        lblastrik.Hide()
    End Sub
End Class