<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChaiInstruct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChaiInstruct))
        Me.pbxinstructchai = New System.Windows.Forms.PictureBox()
        Me.pbxinstructmo = New System.Windows.Forms.PictureBox()
        Me.pbxdrinkmocha = New System.Windows.Forms.PictureBox()
        Me.btncont = New System.Windows.Forms.Button()
        Me.btninstructchai = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.PictureBox()
        CType(Me.pbxinstructchai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxinstructmo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxdrinkmocha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxinstructchai
        '
        Me.pbxinstructchai.Image = CType(resources.GetObject("pbxinstructchai.Image"), System.Drawing.Image)
        Me.pbxinstructchai.Location = New System.Drawing.Point(36, 144)
        Me.pbxinstructchai.Name = "pbxinstructchai"
        Me.pbxinstructchai.Size = New System.Drawing.Size(557, 252)
        Me.pbxinstructchai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxinstructchai.TabIndex = 13
        Me.pbxinstructchai.TabStop = False
        '
        'pbxinstructmo
        '
        Me.pbxinstructmo.Image = CType(resources.GetObject("pbxinstructmo.Image"), System.Drawing.Image)
        Me.pbxinstructmo.Location = New System.Drawing.Point(268, 171)
        Me.pbxinstructmo.Name = "pbxinstructmo"
        Me.pbxinstructmo.Size = New System.Drawing.Size(312, 175)
        Me.pbxinstructmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxinstructmo.TabIndex = 12
        Me.pbxinstructmo.TabStop = False
        '
        'pbxdrinkmocha
        '
        Me.pbxdrinkmocha.Image = CType(resources.GetObject("pbxdrinkmocha.Image"), System.Drawing.Image)
        Me.pbxdrinkmocha.Location = New System.Drawing.Point(36, 171)
        Me.pbxdrinkmocha.Name = "pbxdrinkmocha"
        Me.pbxdrinkmocha.Size = New System.Drawing.Size(175, 175)
        Me.pbxdrinkmocha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxdrinkmocha.TabIndex = 11
        Me.pbxdrinkmocha.TabStop = False
        '
        'btncont
        '
        Me.btncont.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncont.Location = New System.Drawing.Point(221, 552)
        Me.btncont.Name = "btncont"
        Me.btncont.Size = New System.Drawing.Size(175, 39)
        Me.btncont.TabIndex = 10
        Me.btncont.Text = "CONTINUE"
        Me.btncont.UseVisualStyleBackColor = True
        '
        'btninstructchai
        '
        Me.btninstructchai.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninstructchai.Location = New System.Drawing.Point(221, 507)
        Me.btninstructchai.Name = "btninstructchai"
        Me.btninstructchai.Size = New System.Drawing.Size(175, 39)
        Me.btninstructchai.TabIndex = 9
        Me.btninstructchai.Text = "READ INSTRUCTIONS"
        Me.btninstructchai.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.Location = New System.Drawing.Point(-2, 604)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(62, 59)
        Me.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnback.TabIndex = 14
        Me.btnback.TabStop = False
        '
        'ChaiInstruct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(626, 675)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.pbxinstructchai)
        Me.Controls.Add(Me.pbxinstructmo)
        Me.Controls.Add(Me.pbxdrinkmocha)
        Me.Controls.Add(Me.btncont)
        Me.Controls.Add(Me.btninstructchai)
        Me.Name = "ChaiInstruct"
        Me.Text = "Chai Tea Latte"
        CType(Me.pbxinstructchai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxinstructmo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxdrinkmocha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxinstructchai As System.Windows.Forms.PictureBox
    Friend WithEvents pbxinstructmo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxdrinkmocha As System.Windows.Forms.PictureBox
    Friend WithEvents btncont As System.Windows.Forms.Button
    Friend WithEvents btninstructchai As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.PictureBox
End Class
