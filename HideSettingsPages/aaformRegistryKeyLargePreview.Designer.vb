﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aaformRegistryKeyLargePreview
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
        Me.elementhostTextBox = New System.Windows.Forms.Integration.ElementHost()
        Me.wpfusercontrolPreviewKey = New HideSettingsPages.previewRegistryKey()
        Me.SuspendLayout()
        '
        'elementhostTextBox
        '
        Me.elementhostTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.elementhostTextBox.Location = New System.Drawing.Point(0, 0)
        Me.elementhostTextBox.Name = "elementhostTextBox"
        Me.elementhostTextBox.Size = New System.Drawing.Size(284, 262)
        Me.elementhostTextBox.TabIndex = 0
        Me.elementhostTextBox.Text = "ElementHost1"
        Me.elementhostTextBox.Child = Me.wpfusercontrolPreviewKey
        '
        'aaformRegistryKeyLargePreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.elementhostTextBox)
        Me.Name = "aaformRegistryKeyLargePreview"
        Me.Text = "aaformRegistryKeyLargePreview"
        Me.ResumeLayout(False)

    End Sub
    Friend PreviewRegistryKey1 As previewRegistryKey
    Friend WithEvents elementhostTextBox As Integration.ElementHost
    Friend wpfusercontrolPreviewKey As previewRegistryKey
End Class
