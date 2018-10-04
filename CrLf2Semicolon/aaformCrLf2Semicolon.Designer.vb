<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaformCrLf2Semicolon
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.labelInput = New System.Windows.Forms.Label()
        Me.buttonReplaceCrLfWithSemicolons = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 33)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 277)
        Me.TextBox1.TabIndex = 0
        '
        'labelInput
        '
        Me.labelInput.AutoSize = True
        Me.labelInput.Location = New System.Drawing.Point(13, 14)
        Me.labelInput.Name = "labelInput"
        Me.labelInput.Size = New System.Drawing.Size(263, 13)
        Me.labelInput.TabIndex = 1
        Me.labelInput.Text = "Input text with CrLf (Windows line endings) characters:"
        '
        'buttonReplaceCrLfWithSemicolons
        '
        Me.buttonReplaceCrLfWithSemicolons.Location = New System.Drawing.Point(274, 138)
        Me.buttonReplaceCrLfWithSemicolons.Name = "buttonReplaceCrLfWithSemicolons"
        Me.buttonReplaceCrLfWithSemicolons.Size = New System.Drawing.Size(118, 55)
        Me.buttonReplaceCrLfWithSemicolons.TabIndex = 2
        Me.buttonReplaceCrLfWithSemicolons.Text = "Replace CrLf characters with semicolons    --->"
        Me.buttonReplaceCrLfWithSemicolons.UseVisualStyleBackColor = True
        '
        'aaformCrLf2Semicolon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(661, 367)
        Me.Controls.Add(Me.buttonReplaceCrLfWithSemicolons)
        Me.Controls.Add(Me.labelInput)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "aaformCrLf2Semicolon"
        Me.Text = "CrLf2Semicolon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents labelInput As Label
    Friend WithEvents buttonReplaceCrLfWithSemicolons As Button
End Class
