﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aaformRegistryKeyValueValueLargePreview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.textboxLargeRegistryKeyValuePreview = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'textboxLargeRegistryKeyPreview
        '
        Me.textboxLargeRegistryKeyValuePreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxLargeRegistryKeyValuePreview.Location = New System.Drawing.Point(0, 0)
        Me.textboxLargeRegistryKeyValuePreview.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.textboxLargeRegistryKeyValuePreview.Multiline = True
        Me.textboxLargeRegistryKeyValuePreview.Name = "textboxLargeRegistryKeyPreview"
        Me.textboxLargeRegistryKeyValuePreview.ReadOnly = True
        Me.textboxLargeRegistryKeyValuePreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxLargeRegistryKeyValuePreview.Size = New System.Drawing.Size(568, 524)
        Me.textboxLargeRegistryKeyValuePreview.TabIndex = 0
        '
        'aaformRegistryKeyValueValueLargePreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(568, 524)
        Me.Controls.Add(Me.textboxLargeRegistryKeyValuePreview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "aaformRegistryKeyValueValueLargePreview"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Registry Key Value Preview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxLargeRegistryKeyValuePreview As TextBox
End Class
