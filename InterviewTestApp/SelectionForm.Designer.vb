<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectionForm
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
        Me.btnTops = New System.Windows.Forms.Button()
        Me.btnHats = New System.Windows.Forms.Button()
        Me.btnBottoms = New System.Windows.Forms.Button()
        Me.btnBags = New System.Windows.Forms.Button()
        Me.btnEyewear = New System.Windows.Forms.Button()
        Me.btnFootwear = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'btnTops
        '
        Me.btnTops.Location = New System.Drawing.Point(40, 63)
        Me.btnTops.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTops.Name = "btnTops"
        Me.btnTops.Size = New System.Drawing.Size(444, 80)
        Me.btnTops.TabIndex = 0
        Me.btnTops.Text = "Tops"
        Me.btnTops.UseVisualStyleBackColor = true
        '
        'btnHats
        '
        Me.btnHats.Enabled = false
        Me.btnHats.Location = New System.Drawing.Point(491, 63)
        Me.btnHats.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHats.Name = "btnHats"
        Me.btnHats.Size = New System.Drawing.Size(147, 80)
        Me.btnHats.TabIndex = 1
        Me.btnHats.Text = "Hats"
        Me.btnHats.UseVisualStyleBackColor = true
        '
        'btnBottoms
        '
        Me.btnBottoms.Enabled = false
        Me.btnBottoms.Location = New System.Drawing.Point(40, 149)
        Me.btnBottoms.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBottoms.Name = "btnBottoms"
        Me.btnBottoms.Size = New System.Drawing.Size(280, 231)
        Me.btnBottoms.TabIndex = 2
        Me.btnBottoms.Text = "Bottoms"
        Me.btnBottoms.UseVisualStyleBackColor = true
        '
        'btnBags
        '
        Me.btnBags.Enabled = false
        Me.btnBags.Location = New System.Drawing.Point(325, 149)
        Me.btnBags.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBags.Name = "btnBags"
        Me.btnBags.Size = New System.Drawing.Size(157, 110)
        Me.btnBags.TabIndex = 3
        Me.btnBags.Text = "Bags"
        Me.btnBags.UseVisualStyleBackColor = true
        '
        'btnEyewear
        '
        Me.btnEyewear.Enabled = false
        Me.btnEyewear.Location = New System.Drawing.Point(491, 149)
        Me.btnEyewear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEyewear.Name = "btnEyewear"
        Me.btnEyewear.Size = New System.Drawing.Size(147, 110)
        Me.btnEyewear.TabIndex = 4
        Me.btnEyewear.Text = "Eyewear"
        Me.btnEyewear.UseVisualStyleBackColor = true
        '
        'btnFootwear
        '
        Me.btnFootwear.Enabled = false
        Me.btnFootwear.Location = New System.Drawing.Point(325, 265)
        Me.btnFootwear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFootwear.Name = "btnFootwear"
        Me.btnFootwear.Size = New System.Drawing.Size(309, 116)
        Me.btnFootwear.TabIndex = 5
        Me.btnFootwear.Text = "Footwear"
        Me.btnFootwear.UseVisualStyleBackColor = true
        '
        'SelectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 420)
        Me.Controls.Add(Me.btnFootwear)
        Me.Controls.Add(Me.btnEyewear)
        Me.Controls.Add(Me.btnBags)
        Me.Controls.Add(Me.btnBottoms)
        Me.Controls.Add(Me.btnHats)
        Me.Controls.Add(Me.btnTops)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SelectionForm"
        Me.Text = "Selection Form"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents btnTops As Button
    Friend WithEvents btnHats As Button
    Friend WithEvents btnBottoms As Button
    Friend WithEvents btnBags As Button
    Friend WithEvents btnEyewear As Button
    Friend WithEvents btnFootwear As Button
End Class
