﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.textboxInput = New System.Windows.Forms.TextBox()
        Me.labelInput = New System.Windows.Forms.Label()
        Me.buttonReplaceCrLfWithSemicolons = New System.Windows.Forms.Button()
        Me.labelOutput = New System.Windows.Forms.Label()
        Me.textboxOutput = New System.Windows.Forms.TextBox()
        Me.buttonSelectInput = New System.Windows.Forms.Button()
        Me.buttonSelectOutput = New System.Windows.Forms.Button()
        Me.checkboxConvertLf = New System.Windows.Forms.CheckBox()
        Me.tooltipConvertLf = New System.Windows.Forms.ToolTip(Me.components)
        Me.linklabelAbout = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'textboxInput
        '
        Me.textboxInput.Location = New System.Drawing.Point(12, 33)
        Me.textboxInput.Multiline = True
        Me.textboxInput.Name = "textboxInput"
        Me.textboxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxInput.Size = New System.Drawing.Size(256, 277)
        Me.textboxInput.TabIndex = 0
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
        Me.buttonReplaceCrLfWithSemicolons.Location = New System.Drawing.Point(274, 53)
        Me.buttonReplaceCrLfWithSemicolons.Name = "buttonReplaceCrLfWithSemicolons"
        Me.buttonReplaceCrLfWithSemicolons.Size = New System.Drawing.Size(130, 55)
        Me.buttonReplaceCrLfWithSemicolons.TabIndex = 2
        Me.buttonReplaceCrLfWithSemicolons.Text = "Replace CrLf characters with semicolons    --->"
        Me.buttonReplaceCrLfWithSemicolons.UseVisualStyleBackColor = True
        '
        'labelOutput
        '
        Me.labelOutput.AutoSize = True
        Me.labelOutput.Location = New System.Drawing.Point(411, 14)
        Me.labelOutput.Name = "labelOutput"
        Me.labelOutput.Size = New System.Drawing.Size(119, 13)
        Me.labelOutput.TabIndex = 4
        Me.labelOutput.Text = "Output with semicolons:"
        '
        'textboxOutput
        '
        Me.textboxOutput.Location = New System.Drawing.Point(410, 33)
        Me.textboxOutput.Multiline = True
        Me.textboxOutput.Name = "textboxOutput"
        Me.textboxOutput.ReadOnly = True
        Me.textboxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxOutput.Size = New System.Drawing.Size(256, 100)
        Me.textboxOutput.TabIndex = 3
        '
        'buttonSelectInput
        '
        Me.buttonSelectInput.Location = New System.Drawing.Point(13, 317)
        Me.buttonSelectInput.Name = "buttonSelectInput"
        Me.buttonSelectInput.Size = New System.Drawing.Size(149, 23)
        Me.buttonSelectInput.TabIndex = 5
        Me.buttonSelectInput.Text = "Select all (input textbox)"
        Me.buttonSelectInput.UseVisualStyleBackColor = True
        '
        'buttonSelectOutput
        '
        Me.buttonSelectOutput.Location = New System.Drawing.Point(410, 139)
        Me.buttonSelectOutput.Name = "buttonSelectOutput"
        Me.buttonSelectOutput.Size = New System.Drawing.Size(149, 23)
        Me.buttonSelectOutput.TabIndex = 6
        Me.buttonSelectOutput.Text = "Select all (output textbox)"
        Me.buttonSelectOutput.UseVisualStyleBackColor = True
        '
        'checkboxConvertLf
        '
        Me.checkboxConvertLf.AutoSize = True
        Me.checkboxConvertLf.Location = New System.Drawing.Point(274, 114)
        Me.checkboxConvertLf.Name = "checkboxConvertLf"
        Me.checkboxConvertLf.Size = New System.Drawing.Size(122, 43)
        Me.checkboxConvertLf.TabIndex = 7
        Me.checkboxConvertLf.Text = "Also convert Lf" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "characters (Unix line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "endings)"
        Me.tooltipConvertLf.SetToolTip(Me.checkboxConvertLf, "Try this if some (or all) semicolons don't show up correctly.")
        Me.checkboxConvertLf.UseVisualStyleBackColor = True
        '
        'tooltipConvertLf
        '
        Me.tooltipConvertLf.AutoPopDelay = 10000
        Me.tooltipConvertLf.InitialDelay = 500
        Me.tooltipConvertLf.ReshowDelay = 100
        Me.tooltipConvertLf.ToolTipTitle = "Also convert Lf characters"
        '
        'linklabelAbout
        '
        Me.linklabelAbout.AutoSize = True
        Me.linklabelAbout.Location = New System.Drawing.Point(631, 327)
        Me.linklabelAbout.Name = "linklabelAbout"
        Me.linklabelAbout.Size = New System.Drawing.Size(35, 13)
        Me.linklabelAbout.TabIndex = 8
        Me.linklabelAbout.TabStop = True
        Me.linklabelAbout.Text = "About"
        '
        'aaformCrLf2Semicolon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(678, 367)
        Me.Controls.Add(Me.linklabelAbout)
        Me.Controls.Add(Me.checkboxConvertLf)
        Me.Controls.Add(Me.buttonSelectOutput)
        Me.Controls.Add(Me.buttonSelectInput)
        Me.Controls.Add(Me.labelOutput)
        Me.Controls.Add(Me.textboxOutput)
        Me.Controls.Add(Me.buttonReplaceCrLfWithSemicolons)
        Me.Controls.Add(Me.labelInput)
        Me.Controls.Add(Me.textboxInput)
        Me.Name = "aaformCrLf2Semicolon"
        Me.Text = "CrLf2Semicolon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textboxInput As TextBox
    Friend WithEvents labelInput As Label
    Friend WithEvents buttonReplaceCrLfWithSemicolons As Button
    Friend WithEvents labelOutput As Label
    Friend WithEvents textboxOutput As TextBox
    Friend WithEvents buttonSelectInput As Button
    Friend WithEvents buttonSelectOutput As Button
    Friend WithEvents checkboxConvertLf As CheckBox
    Friend WithEvents tooltipConvertLf As ToolTip
    Friend WithEvents linklabelAbout As LinkLabel
End Class
