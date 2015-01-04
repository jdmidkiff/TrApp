<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scoreboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scoreboard))
        Me.btnmake = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnend = New System.Windows.Forms.Button()
        Me.pbxbackground = New System.Windows.Forms.PictureBox()
        Me.Lbx1name = New System.Windows.Forms.ListBox()
        Me.Lbx1score = New System.Windows.Forms.ListBox()
        Me.Lbx2name = New System.Windows.Forms.ListBox()
        Me.Lbx2score = New System.Windows.Forms.ListBox()
        Me.Lbx3name = New System.Windows.Forms.ListBox()
        Me.Lbx3score = New System.Windows.Forms.ListBox()
        Me.Lbx4name = New System.Windows.Forms.ListBox()
        Me.Lbx4score = New System.Windows.Forms.ListBox()
        Me.Lbx5name = New System.Windows.Forms.ListBox()
        Me.Lbx5score = New System.Windows.Forms.ListBox()
        Me.lblsources = New System.Windows.Forms.Label()
        CType(Me.pbxbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnmake
        '
        Me.btnmake.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmake.Location = New System.Drawing.Point(228, 436)
        Me.btnmake.Name = "btnmake"
        Me.btnmake.Size = New System.Drawing.Size(175, 39)
        Me.btnmake.TabIndex = 0
        Me.btnmake.Text = "MAKE ANOTHER DRINK"
        Me.btnmake.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(228, 481)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(175, 39)
        Me.btnnew.TabIndex = 1
        Me.btnnew.Text = "NEW BARISTA"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnend
        '
        Me.btnend.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnend.Location = New System.Drawing.Point(228, 526)
        Me.btnend.Name = "btnend"
        Me.btnend.Size = New System.Drawing.Size(175, 39)
        Me.btnend.TabIndex = 2
        Me.btnend.Text = "END"
        Me.btnend.UseVisualStyleBackColor = True
        '
        'pbxbackground
        '
        Me.pbxbackground.Image = CType(resources.GetObject("pbxbackground.Image"), System.Drawing.Image)
        Me.pbxbackground.Location = New System.Drawing.Point(-39, -1)
        Me.pbxbackground.Name = "pbxbackground"
        Me.pbxbackground.Size = New System.Drawing.Size(847, 586)
        Me.pbxbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxbackground.TabIndex = 3
        Me.pbxbackground.TabStop = False
        '
        'Lbx1name
        '
        Me.Lbx1name.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx1name.FormattingEnabled = True
        Me.Lbx1name.ItemHeight = 17
        Me.Lbx1name.Location = New System.Drawing.Point(345, 145)
        Me.Lbx1name.Name = "Lbx1name"
        Me.Lbx1name.Size = New System.Drawing.Size(120, 21)
        Me.Lbx1name.TabIndex = 4
        '
        'Lbx1score
        '
        Me.Lbx1score.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx1score.FormattingEnabled = True
        Me.Lbx1score.ItemHeight = 17
        Me.Lbx1score.Location = New System.Drawing.Point(482, 145)
        Me.Lbx1score.Name = "Lbx1score"
        Me.Lbx1score.Size = New System.Drawing.Size(120, 21)
        Me.Lbx1score.TabIndex = 5
        '
        'Lbx2name
        '
        Me.Lbx2name.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx2name.FormattingEnabled = True
        Me.Lbx2name.ItemHeight = 17
        Me.Lbx2name.Location = New System.Drawing.Point(345, 192)
        Me.Lbx2name.Name = "Lbx2name"
        Me.Lbx2name.Size = New System.Drawing.Size(120, 21)
        Me.Lbx2name.TabIndex = 6
        '
        'Lbx2score
        '
        Me.Lbx2score.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx2score.FormattingEnabled = True
        Me.Lbx2score.ItemHeight = 17
        Me.Lbx2score.Location = New System.Drawing.Point(482, 192)
        Me.Lbx2score.Name = "Lbx2score"
        Me.Lbx2score.Size = New System.Drawing.Size(120, 21)
        Me.Lbx2score.TabIndex = 7
        '
        'Lbx3name
        '
        Me.Lbx3name.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx3name.FormattingEnabled = True
        Me.Lbx3name.ItemHeight = 17
        Me.Lbx3name.Location = New System.Drawing.Point(345, 238)
        Me.Lbx3name.Name = "Lbx3name"
        Me.Lbx3name.Size = New System.Drawing.Size(120, 21)
        Me.Lbx3name.TabIndex = 8
        '
        'Lbx3score
        '
        Me.Lbx3score.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx3score.FormattingEnabled = True
        Me.Lbx3score.ItemHeight = 17
        Me.Lbx3score.Location = New System.Drawing.Point(482, 238)
        Me.Lbx3score.Name = "Lbx3score"
        Me.Lbx3score.Size = New System.Drawing.Size(120, 21)
        Me.Lbx3score.TabIndex = 9
        '
        'Lbx4name
        '
        Me.Lbx4name.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx4name.FormattingEnabled = True
        Me.Lbx4name.ItemHeight = 17
        Me.Lbx4name.Location = New System.Drawing.Point(345, 283)
        Me.Lbx4name.Name = "Lbx4name"
        Me.Lbx4name.Size = New System.Drawing.Size(120, 21)
        Me.Lbx4name.TabIndex = 10
        '
        'Lbx4score
        '
        Me.Lbx4score.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx4score.FormattingEnabled = True
        Me.Lbx4score.ItemHeight = 17
        Me.Lbx4score.Location = New System.Drawing.Point(482, 283)
        Me.Lbx4score.Name = "Lbx4score"
        Me.Lbx4score.Size = New System.Drawing.Size(120, 21)
        Me.Lbx4score.TabIndex = 11
        '
        'Lbx5name
        '
        Me.Lbx5name.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx5name.FormattingEnabled = True
        Me.Lbx5name.ItemHeight = 17
        Me.Lbx5name.Location = New System.Drawing.Point(345, 328)
        Me.Lbx5name.Name = "Lbx5name"
        Me.Lbx5name.Size = New System.Drawing.Size(120, 21)
        Me.Lbx5name.TabIndex = 12
        '
        'Lbx5score
        '
        Me.Lbx5score.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx5score.FormattingEnabled = True
        Me.Lbx5score.ItemHeight = 17
        Me.Lbx5score.Location = New System.Drawing.Point(482, 328)
        Me.Lbx5score.Name = "Lbx5score"
        Me.Lbx5score.Size = New System.Drawing.Size(120, 21)
        Me.Lbx5score.TabIndex = 13
        '
        'lblsources
        '
        Me.lblsources.AutoSize = True
        Me.lblsources.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblsources.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsources.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblsources.Location = New System.Drawing.Point(13, 560)
        Me.lblsources.Name = "lblsources"
        Me.lblsources.Size = New System.Drawing.Size(45, 15)
        Me.lblsources.TabIndex = 14
        Me.lblsources.Text = "Sources"
        '
        'Scoreboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(626, 585)
        Me.Controls.Add(Me.lblsources)
        Me.Controls.Add(Me.Lbx5score)
        Me.Controls.Add(Me.Lbx5name)
        Me.Controls.Add(Me.Lbx4score)
        Me.Controls.Add(Me.Lbx4name)
        Me.Controls.Add(Me.Lbx3score)
        Me.Controls.Add(Me.Lbx3name)
        Me.Controls.Add(Me.Lbx2score)
        Me.Controls.Add(Me.Lbx2name)
        Me.Controls.Add(Me.Lbx1score)
        Me.Controls.Add(Me.Lbx1name)
        Me.Controls.Add(Me.btnend)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnmake)
        Me.Controls.Add(Me.pbxbackground)
        Me.Name = "Scoreboard"
        Me.Text = "Scoreboard"
        CType(Me.pbxbackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnmake As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnend As System.Windows.Forms.Button
    Friend WithEvents pbxbackground As System.Windows.Forms.PictureBox
    Friend WithEvents Lbx1name As System.Windows.Forms.ListBox
    Friend WithEvents Lbx1score As System.Windows.Forms.ListBox
    Friend WithEvents Lbx2name As System.Windows.Forms.ListBox
    Friend WithEvents Lbx2score As System.Windows.Forms.ListBox
    Friend WithEvents Lbx3name As System.Windows.Forms.ListBox
    Friend WithEvents Lbx3score As System.Windows.Forms.ListBox
    Friend WithEvents Lbx4name As System.Windows.Forms.ListBox
    Friend WithEvents Lbx4score As System.Windows.Forms.ListBox
    Friend WithEvents Lbx5name As System.Windows.Forms.ListBox
    Friend WithEvents Lbx5score As System.Windows.Forms.ListBox
    Friend WithEvents lblsources As System.Windows.Forms.Label
End Class
