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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaformRestorePointReminder))
        Me.buttonOpenRestorePointControlPanel = New System.Windows.Forms.Button()
        Me.labelRestorePointReminder = New System.Windows.Forms.Label()
        Me.linklabelTurnOnOrOffSystemProtection = New System.Windows.Forms.LinkLabel()
        Me.linklabelCreateSystemRestorePoint = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonOpenRestorePointControlPanel
        '
        Me.buttonOpenRestorePointControlPanel.Location = New System.Drawing.Point(273, 260)
        Me.buttonOpenRestorePointControlPanel.Name = "buttonOpenRestorePointControlPanel"
        Me.buttonOpenRestorePointControlPanel.Size = New System.Drawing.Size(107, 33)
        Me.buttonOpenRestorePointControlPanel.TabIndex = 0
        Me.buttonOpenRestorePointControlPanel.Text = "Yes"
        Me.buttonOpenRestorePointControlPanel.UseVisualStyleBackColor = True
        '
        'labelRestorePointReminder
        '
        Me.labelRestorePointReminder.AutoSize = True
        Me.labelRestorePointReminder.Location = New System.Drawing.Point(16, 9)
        Me.labelRestorePointReminder.Name = "labelRestorePointReminder"
        Me.labelRestorePointReminder.Size = New System.Drawing.Size(457, 136)
        Me.labelRestorePointReminder.TabIndex = 1
        Me.labelRestorePointReminder.Text = resources.GetString("labelRestorePointReminder.Text")
        '
        'linklabelTurnOnOrOffSystemProtection
        '
        Me.linklabelTurnOnOrOffSystemProtection.AutoSize = True
        Me.linklabelTurnOnOrOffSystemProtection.Location = New System.Drawing.Point(16, 175)
        Me.linklabelTurnOnOrOffSystemProtection.Name = "linklabelTurnOnOrOffSystemProtection"
        Me.linklabelTurnOnOrOffSystemProtection.Size = New System.Drawing.Size(346, 34)
        Me.linklabelTurnOnOrOffSystemProtection.TabIndex = 2
        Me.linklabelTurnOnOrOffSystemProtection.TabStop = True
        Me.linklabelTurnOnOrOffSystemProtection.Text = "TenForums: How to Turn On or Off System Protection" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Drives in Windows 10 (ste" &
    "p 6)"
        '
        'linklabelCreateSystemRestorePoint
        '
        Me.linklabelCreateSystemRestorePoint.AutoSize = True
        Me.linklabelCreateSystemRestorePoint.Location = New System.Drawing.Point(16, 216)
        Me.linklabelCreateSystemRestorePoint.Name = "linklabelCreateSystemRestorePoint"
        Me.linklabelCreateSystemRestorePoint.Size = New System.Drawing.Size(477, 17)
        Me.linklabelCreateSystemRestorePoint.TabIndex = 3
        Me.linklabelCreateSystemRestorePoint.TabStop = True
        Me.linklabelCreateSystemRestorePoint.Text = "TenForums: How to Create a System Restore Point in Windows 10 (step 5)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(386, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "No"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'aaformRestorePointReminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(506, 305)
        Me.Controls.Add(Me.linklabelCreateSystemRestorePoint)
        Me.Controls.Add(Me.linklabelTurnOnOrOffSystemProtection)
        Me.Controls.Add(Me.labelRestorePointReminder)
        Me.Controls.Add(Me.buttonOpenRestorePointControlPanel)
        Me.Controls.Add(Me.Button1)
        Me.Name = "aaformRestorePointReminder"
        Me.Text = "Restore point reminder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonOpenRestorePointControlPanel As Button
    Friend WithEvents labelRestorePointReminder As Label
    Friend WithEvents linklabelTurnOnOrOffSystemProtection As LinkLabel
    Friend WithEvents linklabelCreateSystemRestorePoint As LinkLabel
    Friend WithEvents Button1 As Button
End Class
