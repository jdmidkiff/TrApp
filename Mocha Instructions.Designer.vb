<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MochaInstruct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MochaInstruct))
        Me.btncont = New System.Windows.Forms.Button()
        Me.btninstruct = New System.Windows.Forms.Button()
        Me.pbxdrinkmocha = New System.Windows.Forms.PictureBox()
        Me.pbxinstructmo = New System.Windows.Forms.PictureBox()
        Me.pbxinstructmocha = New System.Windows.Forms.PictureBox()
        Me.btnback = New System.Windows.Forms.PictureBox()
        CType(Me.pbxdrinkmocha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxinstructmo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxinstructmocha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncont
        '
        Me.btncont.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncont.Location = New System.Drawing.Point(224, 527)
        Me.btncont.Name = "btncont"
        Me.btncont.Size = New System.Drawing.Size(175, 39)
        Me.btncont.TabIndex = 5
        Me.btncont.Text = "CONTINUE"
        Me.btncont.UseVisualStyleBackColor = True
        '
        'btninstruct
        '
        Me.btninstruct.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninstruct.Location = New System.Drawing.Point(224, 482)
        Me.btninstruct.Name = "btninstruct"
        Me.btninstruct.Size = New System.Drawing.Size(175, 39)
        Me.btninstruct.TabIndex = 4
        Me.btninstruct.Text = "READ INSTRUCTIONS"
        Me.btninstruct.UseVisualStyleBackColor = True
        '
        'pbxdrinkmocha
        '
        Me.pbxdrinkmocha.Image = CType(resources.GetObject("pbxdrinkmocha.Image"), System.Drawing.Image)
        Me.pbxdrinkmocha.Location = New System.Drawing.Point(39, 146)
        Me.pbxdrinkmocha.Name = "pbxdrinkmocha"
        Me.pbxdrinkmocha.Size = New System.Drawing.Size(175, 175)
        Me.pbxdrinkmocha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxdrinkmocha.TabIndex = 6
        Me.pbxdrinkmocha.TabStop = False
        '
        'pbxinstructmo
        '
        Me.pbxinstructmo.Image = CType(resources.GetObject("pbxinstructmo.Image"), System.Drawing.Image)
        Me.pbxinstructmo.Location = New System.Drawing.Point(271, 146)
        Me.pbxinstructmo.Name = "pbxinstructmo"
        Me.pbxinstructmo.Size = New System.Drawing.Size(312, 175)
        Me.pbxinstructmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxinstructmo.TabIndex = 7
        Me.pbxinstructmo.TabStop = False
        '
        'pbxinstructmocha
        '
        Me.pbxinstructmocha.Image = CType(resources.GetObject("pbxinstructmocha.Image"), System.Drawing.Image)
        Me.pbxinstructmocha.Location = New System.Drawing.Point(39, 59)
        Me.pbxinstructmocha.Name = "pbxinstructmocha"
        Me.pbxinstructmocha.Size = New System.Drawing.Size(555, 370)
        Me.pbxinstructmocha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxinstructmocha.TabIndex = 8
        Me.pbxinstructmocha.TabStop = False
        '
        'btnback
        '
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.Location = New System.Drawing.Point(-3, 514)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(62, 59)
        Me.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnback.TabIndex = 9
        Me.btnback.TabStop = False
        '
        'MochaInstruct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(626, 585)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.pbxinstructmocha)
        Me.Controls.Add(Me.pbxinstructmo)
        Me.Controls.Add(Me.pbxdrinkmocha)
        Me.Controls.Add(Me.btncont)
        Me.Controls.Add(Me.btninstruct)
        Me.Name = "MochaInstruct"
        Me.Text = "Mocha"
        CType(Me.pbxdrinkmocha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxinstructmo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxinstructmocha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncont As System.Windows.Forms.Button
    Friend WithEvents btninstruct As System.Windows.Forms.Button
    Friend WithEvents pbxdrinkmocha As System.Windows.Forms.PictureBox
    Friend WithEvents pbxinstructmo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxinstructmocha As System.Windows.Forms.PictureBox
    Friend WithEvents btnback As System.Windows.Forms.PictureBox
End Class
