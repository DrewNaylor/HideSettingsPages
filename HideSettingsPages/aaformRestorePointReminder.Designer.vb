<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaformRestorePointReminder
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
        Me.buttonOpenRestorePointControlPanel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonOpenRestorePointControlPanel
        '
        Me.buttonOpenRestorePointControlPanel.Location = New System.Drawing.Point(275, 164)
        Me.buttonOpenRestorePointControlPanel.Name = "buttonOpenRestorePointControlPanel"
        Me.buttonOpenRestorePointControlPanel.Size = New System.Drawing.Size(219, 70)
        Me.buttonOpenRestorePointControlPanel.TabIndex = 0
        Me.buttonOpenRestorePointControlPanel.Text = "Open Create Restore Point window"
        Me.buttonOpenRestorePointControlPanel.UseVisualStyleBackColor = True
        '
        'aaformRestorePointReminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(506, 246)
        Me.Controls.Add(Me.buttonOpenRestorePointControlPanel)
        Me.Name = "aaformRestorePointReminder"
        Me.Text = "aaformRestorePointReminder"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buttonOpenRestorePointControlPanel As Button
End Class
