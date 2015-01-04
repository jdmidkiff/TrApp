<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LatteInstruct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LatteInstruct))
        Me.btninstruct = New System.Windows.Forms.Button()
        Me.btncont = New System.Windows.Forms.Button()
        Me.pbxdrink = New System.Windows.Forms.PictureBox()
        Me.pbxrecipe = New System.Windows.Forms.PictureBox()
        Me.pbxinstruct = New System.Windows.Forms.PictureBox()
        Me.btnback = New System.Windows.Forms.PictureBox()
        CType(Me.pbxdrink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxrecipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxinstruct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btninstruct
        '
        Me.btninstruct.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninstruct.Location = New System.Drawing.Point(228, 461)
        Me.btninstruct.Name = "btninstruct"
        Me.btninstruct.Size = New System.Drawing.Size(175, 39)
        Me.btninstruct.TabIndex = 1
        Me.btninstruct.Text = "READ INSTRUCTIONS"
        Me.btninstruct.UseVisualStyleBackColor = True
        '
        'btncont
        '
        Me.btncont.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncont.Location = New System.Drawing.Point(228, 506)
        Me.btncont.Name = "btncont"
        Me.btncont.Size = New System.Drawing.Size(175, 39)
        Me.btncont.TabIndex = 2
        Me.btncont.Text = "CONTINUE"
        Me.btncont.UseVisualStyleBackColor = True
        '
        'pbxdrink
        '
        Me.pbxdrink.Image = CType(resources.GetObject("pbxdrink.Image"), System.Drawing.Image)
        Me.pbxdrink.Location = New System.Drawing.Point(34, 132)
        Me.pbxdrink.Name = "pbxdrink"
        Me.pbxdrink.Size = New System.Drawing.Size(175, 175)
        Me.pbxdrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxdrink.TabIndex = 3
        Me.pbxdrink.TabStop = False
        '
        'pbxrecipe
        '
        Me.pbxrecipe.Image = CType(resources.GetObject("pbxrecipe.Image"), System.Drawing.Image)
        Me.pbxrecipe.Location = New System.Drawing.Point(245, 132)
        Me.pbxrecipe.Name = "pbxrecipe"
        Me.pbxrecipe.Size = New System.Drawing.Size(312, 175)
        Me.pbxrecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxrecipe.TabIndex = 4
        Me.pbxrecipe.TabStop = False
        '
        'pbxinstruct
        '
        Me.pbxinstruct.Image = CType(resources.GetObject("pbxinstruct.Image"), System.Drawing.Image)
        Me.pbxinstruct.Location = New System.Drawing.Point(34, 81)
        Me.pbxinstruct.Name = "pbxinstruct"
        Me.pbxinstruct.Size = New System.Drawing.Size(554, 330)
        Me.pbxinstruct.TabIndex = 5
        Me.pbxinstruct.TabStop = False
        '
        'btnback
        '
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.Location = New System.Drawing.Point(-3, 514)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(62, 59)
        Me.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnback.TabIndex = 6
        Me.btnback.TabStop = False
        '
        'LatteInstruct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(626, 585)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.pbxinstruct)
        Me.Controls.Add(Me.pbxrecipe)
        Me.Controls.Add(Me.pbxdrink)
        Me.Controls.Add(Me.btncont)
        Me.Controls.Add(Me.btninstruct)
        Me.Name = "LatteInstruct"
        Me.Text = "Latte"
        CType(Me.pbxdrink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxrecipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxinstruct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btninstruct As System.Windows.Forms.Button
    Friend WithEvents btncont As System.Windows.Forms.Button
    Friend WithEvents pbxdrink As System.Windows.Forms.PictureBox
    Friend WithEvents pbxrecipe As System.Windows.Forms.PictureBox
    Friend WithEvents pbxinstruct As System.Windows.Forms.PictureBox
    Friend WithEvents btnback As System.Windows.Forms.PictureBox
End Class
