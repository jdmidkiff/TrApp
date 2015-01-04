<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MochaQuiz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MochaQuiz))
        Me.lblguesses = New System.Windows.Forms.Label()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.Option4 = New System.Windows.Forms.RadioButton()
        Me.Option3 = New System.Windows.Forms.RadioButton()
        Me.Option2 = New System.Windows.Forms.RadioButton()
        Me.lblquestion = New System.Windows.Forms.Label()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.btnnextq = New System.Windows.Forms.Button()
        Me.BtnFinish = New System.Windows.Forms.Button()
        Me.lblcounter = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.PictureBox()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblguesses
        '
        Me.lblguesses.AutoSize = True
        Me.lblguesses.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblguesses.Location = New System.Drawing.Point(412, 9)
        Me.lblguesses.Name = "lblguesses"
        Me.lblguesses.Size = New System.Drawing.Size(87, 24)
        Me.lblguesses.TabIndex = 26
        Me.lblguesses.Text = "Incorrect"
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.Location = New System.Drawing.Point(520, 9)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(58, 24)
        Me.lblscore.TabIndex = 25
        Me.lblscore.Text = "Score"
        '
        'Option4
        '
        Me.Option4.AutoSize = True
        Me.Option4.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option4.Location = New System.Drawing.Point(27, 198)
        Me.Option4.Name = "Option4"
        Me.Option4.Size = New System.Drawing.Size(103, 21)
        Me.Option4.TabIndex = 24
        Me.Option4.TabStop = True
        Me.Option4.Text = "RadioButton4"
        Me.Option4.UseVisualStyleBackColor = True
        '
        'Option3
        '
        Me.Option3.AutoSize = True
        Me.Option3.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option3.Location = New System.Drawing.Point(27, 165)
        Me.Option3.Name = "Option3"
        Me.Option3.Size = New System.Drawing.Size(103, 21)
        Me.Option3.TabIndex = 23
        Me.Option3.TabStop = True
        Me.Option3.Text = "RadioButton3"
        Me.Option3.UseVisualStyleBackColor = True
        '
        'Option2
        '
        Me.Option2.AutoSize = True
        Me.Option2.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option2.Location = New System.Drawing.Point(27, 133)
        Me.Option2.Name = "Option2"
        Me.Option2.Size = New System.Drawing.Size(103, 21)
        Me.Option2.TabIndex = 22
        Me.Option2.TabStop = True
        Me.Option2.Text = "RadioButton2"
        Me.Option2.UseVisualStyleBackColor = True
        '
        'lblquestion
        '
        Me.lblquestion.AutoSize = True
        Me.lblquestion.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquestion.Location = New System.Drawing.Point(23, 51)
        Me.lblquestion.Name = "lblquestion"
        Me.lblquestion.Size = New System.Drawing.Size(74, 21)
        Me.lblquestion.TabIndex = 21
        Me.lblquestion.Text = "Question"
        '
        'Option1
        '
        Me.Option1.AutoSize = True
        Me.Option1.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option1.Location = New System.Drawing.Point(27, 98)
        Me.Option1.Name = "Option1"
        Me.Option1.Size = New System.Drawing.Size(103, 21)
        Me.Option1.TabIndex = 20
        Me.Option1.TabStop = True
        Me.Option1.Text = "RadioButton1"
        Me.Option1.UseVisualStyleBackColor = True
        '
        'btnnextq
        '
        Me.btnnextq.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnextq.Location = New System.Drawing.Point(406, 297)
        Me.btnnextq.Name = "btnnextq"
        Me.btnnextq.Size = New System.Drawing.Size(175, 39)
        Me.btnnextq.TabIndex = 19
        Me.btnnextq.Text = "Continue"
        Me.btnnextq.UseVisualStyleBackColor = True
        '
        'BtnFinish
        '
        Me.BtnFinish.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinish.Location = New System.Drawing.Point(406, 342)
        Me.BtnFinish.Name = "BtnFinish"
        Me.BtnFinish.Size = New System.Drawing.Size(175, 39)
        Me.BtnFinish.TabIndex = 27
        Me.BtnFinish.Text = "Finish"
        Me.BtnFinish.UseVisualStyleBackColor = True
        '
        'lblcounter
        '
        Me.lblcounter.AutoSize = True
        Me.lblcounter.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcounter.Location = New System.Drawing.Point(23, 9)
        Me.lblcounter.Name = "lblcounter"
        Me.lblcounter.Size = New System.Drawing.Size(83, 24)
        Me.lblcounter.TabIndex = 31
        Me.lblcounter.Text = "Question"
        '
        'btnback
        '
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.Location = New System.Drawing.Point(-1, 514)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(62, 59)
        Me.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnback.TabIndex = 32
        Me.btnback.TabStop = False
        '
        'MochaQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(626, 585)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.lblcounter)
        Me.Controls.Add(Me.BtnFinish)
        Me.Controls.Add(Me.lblguesses)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.Option4)
        Me.Controls.Add(Me.Option3)
        Me.Controls.Add(Me.Option2)
        Me.Controls.Add(Me.lblquestion)
        Me.Controls.Add(Me.Option1)
        Me.Controls.Add(Me.btnnextq)
        Me.Name = "MochaQuiz"
        Me.Text = "Mocha Quiz"
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblguesses As System.Windows.Forms.Label
    Friend WithEvents lblscore As System.Windows.Forms.Label
    Friend WithEvents Option4 As System.Windows.Forms.RadioButton
    Friend WithEvents Option3 As System.Windows.Forms.RadioButton
    Friend WithEvents Option2 As System.Windows.Forms.RadioButton
    Friend WithEvents lblquestion As System.Windows.Forms.Label
    Friend WithEvents Option1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnnextq As System.Windows.Forms.Button
    Friend WithEvents BtnFinish As System.Windows.Forms.Button
    Friend WithEvents lblcounter As System.Windows.Forms.Label
    Friend WithEvents btnback As System.Windows.Forms.PictureBox
End Class
