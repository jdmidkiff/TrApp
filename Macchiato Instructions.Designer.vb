<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MacchiattoInstruct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MacchiattoInstruct))
        Me.pbxinstructmachb = New System.Windows.Forms.PictureBox()
        Me.pbxinstructmach = New System.Windows.Forms.PictureBox()
        Me.pbxdrinkmach = New System.Windows.Forms.PictureBox()
        Me.btncont = New System.Windows.Forms.Button()
        Me.btninstruct = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.PictureBox()
        CType(Me.pbxinstructmachb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxinstructmach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxdrinkmach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxinstructmachb
        '
        Me.pbxinstructmachb.Image = CType(resources.GetObject("pbxinstructmachb.Image"), System.Drawing.Image)
        Me.pbxinstructmachb.Location = New System.Drawing.Point(36, 61)
        Me.pbxinstructmachb.Name = "pbxinstructmachb"
        Me.pbxinstructmachb.Size = New System.Drawing.Size(554, 391)
        Me.pbxinstructmachb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxinstructmachb.TabIndex = 13
        Me.pbxinstructmachb.TabStop = False
        '
        'pbxinstructmach
        '
        Me.pbxinstructmach.Image = CType(resources.GetObject("pbxinstructmach.Image"), System.Drawing.Image)
        Me.pbxinstructmach.Location = New System.Drawing.Point(268, 171)
        Me.pbxinstructmach.Name = "pbxinstructmach"
        Me.pbxinstructmach.Size = New System.Drawing.Size(312, 175)
        Me.pbxinstructmach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxinstructmach.TabIndex = 12
        Me.pbxinstructmach.TabStop = False
        '
        'pbxdrinkmach
        '
        Me.pbxdrinkmach.Image = CType(resources.GetObject("pbxdrinkmach.Image"), System.Drawing.Image)
        Me.pbxdrinkmach.Location = New System.Drawing.Point(36, 171)
        Me.pbxdrinkmach.Name = "pbxdrinkmach"
        Me.pbxdrinkmach.Size = New System.Drawing.Size(175, 175)
        Me.pbxdrinkmach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxdrinkmach.TabIndex = 11
        Me.pbxdrinkmach.TabStop = False
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
        'btninstruct
        '
        Me.btninstruct.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninstruct.Location = New System.Drawing.Point(221, 507)
        Me.btninstruct.Name = "btninstruct"
        Me.btninstruct.Size = New System.Drawing.Size(175, 39)
        Me.btninstruct.TabIndex = 9
        Me.btninstruct.Text = "READ INSTRUCTIONS"
        Me.btninstruct.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.Location = New System.Drawing.Point(-1, 604)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(62, 59)
        Me.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnback.TabIndex = 14
        Me.btnback.TabStop = False
        '
        'MacchiattoInstruct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(626, 675)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.pbxinstructmachb)
        Me.Controls.Add(Me.pbxinstructmach)
        Me.Controls.Add(Me.pbxdrinkmach)
        Me.Controls.Add(Me.btncont)
        Me.Controls.Add(Me.btninstruct)
        Me.Name = "MacchiattoInstruct"
        Me.Text = "Macchiato"
        CType(Me.pbxinstructmachb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxinstructmach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxdrinkmach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxinstructmachb As System.Windows.Forms.PictureBox
    Friend WithEvents pbxinstructmach As System.Windows.Forms.PictureBox
    Friend WithEvents pbxdrinkmach As System.Windows.Forms.PictureBox
    Friend WithEvents btncont As System.Windows.Forms.Button
    Friend WithEvents btninstruct As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.PictureBox
End Class
