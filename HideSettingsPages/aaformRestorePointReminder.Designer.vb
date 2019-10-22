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
        Me.labelRestorePointReminder = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'buttonOpenRestorePointControlPanel
        '
        Me.buttonOpenRestorePointControlPanel.Location = New System.Drawing.Point(275, 164)
        Me.buttonOpenRestorePointControlPanel.Name = "buttonOpenRestorePointControlPanel"
        Me.buttonOpenRestorePointControlPanel.Size = New System.Drawing.Size(219, 70)
        Me.buttonOpenRestorePointControlPanel.TabIndex = 0
        Me.buttonOpenRestorePointControlPanel.Text = "Open create restore point window"
        Me.buttonOpenRestorePointControlPanel.UseVisualStyleBackColor = True
        '
        'labelRestorePointReminder
        '
        Me.labelRestorePointReminder.AutoSize = True
        Me.labelRestorePointReminder.Location = New System.Drawing.Point(13, 13)
        Me.labelRestorePointReminder.Name = "labelRestorePointReminder"
        Me.labelRestorePointReminder.Size = New System.Drawing.Size(457, 51)
        Me.labelRestorePointReminder.TabIndex = 1
        Me.labelRestorePointReminder.Text = "Once you've finished creating a restore point, please close this window." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you " &
    "need help turning on System Restore or creating a restore point," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the guides lin" &
    "ked below should help."
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(16, 85)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(346, 34)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "TenForums: How to Turn On or Off System Protection" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Drives in Windows 10"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(16, 126)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(424, 17)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "TenForums: How to Create a System Restore Point in Windows 10"
        '
        'aaformRestorePointReminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(506, 246)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.labelRestorePointReminder)
        Me.Controls.Add(Me.buttonOpenRestorePointControlPanel)
        Me.Name = "aaformRestorePointReminder"
        Me.Text = "Restore point reminder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonOpenRestorePointControlPanel As Button
    Friend WithEvents labelRestorePointReminder As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
