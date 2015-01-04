<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bibliography
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bibliography))
        Me.lblbiblio = New System.Windows.Forms.Label()
        Me.lblsources = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblbiblio
        '
        Me.lblbiblio.AutoSize = True
        Me.lblbiblio.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbiblio.Location = New System.Drawing.Point(248, 43)
        Me.lblbiblio.Name = "lblbiblio"
        Me.lblbiblio.Size = New System.Drawing.Size(99, 21)
        Me.lblbiblio.TabIndex = 0
        Me.lblbiblio.Text = "Bibliography"
        '
        'lblsources
        '
        Me.lblsources.AutoSize = True
        Me.lblsources.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsources.Location = New System.Drawing.Point(12, 84)
        Me.lblsources.Name = "lblsources"
        Me.lblsources.Size = New System.Drawing.Size(473, 136)
        Me.lblsources.TabIndex = 1
        Me.lblsources.Text = resources.GetString("lblsources.Text")
        '
        'Bibliography
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(626, 675)
        Me.Controls.Add(Me.lblsources)
        Me.Controls.Add(Me.lblbiblio)
        Me.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Bibliography"
        Me.Text = "Bibliography"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblbiblio As System.Windows.Forms.Label
    Friend WithEvents lblsources As System.Windows.Forms.Label
End Class
