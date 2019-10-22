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
        Me.buttonDontCreateRestorePoint = New System.Windows.Forms.Button()
        Me.checkboxDontAskAgain = New System.Windows.Forms.CheckBox()
        Me.panelMessageArea = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'buttonOpenRestorePointControlPanel
        '
        Me.buttonOpenRestorePointControlPanel.Location = New System.Drawing.Point(175, 193)
        Me.buttonOpenRestorePointControlPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonOpenRestorePointControlPanel.Name = "buttonOpenRestorePointControlPanel"
        Me.buttonOpenRestorePointControlPanel.Size = New System.Drawing.Size(86, 26)
        Me.buttonOpenRestorePointControlPanel.TabIndex = 0
        Me.buttonOpenRestorePointControlPanel.Text = "Yes"
        Me.buttonOpenRestorePointControlPanel.UseVisualStyleBackColor = True
        '
        'labelRestorePointReminder
        '
        Me.labelRestorePointReminder.AutoSize = True
        Me.labelRestorePointReminder.BackColor = System.Drawing.SystemColors.Window
        Me.labelRestorePointReminder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelRestorePointReminder.Location = New System.Drawing.Point(13, 7)
        Me.labelRestorePointReminder.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelRestorePointReminder.Name = "labelRestorePointReminder"
        Me.labelRestorePointReminder.Size = New System.Drawing.Size(338, 91)
        Me.labelRestorePointReminder.TabIndex = 1
        Me.labelRestorePointReminder.Text = resources.GetString("labelRestorePointReminder.Text")
        '
        'linklabelTurnOnOrOffSystemProtection
        '
        Me.linklabelTurnOnOrOffSystemProtection.AutoSize = True
        Me.linklabelTurnOnOrOffSystemProtection.BackColor = System.Drawing.SystemColors.Window
        Me.linklabelTurnOnOrOffSystemProtection.Location = New System.Drawing.Point(13, 118)
        Me.linklabelTurnOnOrOffSystemProtection.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.linklabelTurnOnOrOffSystemProtection.Name = "linklabelTurnOnOrOffSystemProtection"
        Me.linklabelTurnOnOrOffSystemProtection.Size = New System.Drawing.Size(259, 26)
        Me.linklabelTurnOnOrOffSystemProtection.TabIndex = 2
        Me.linklabelTurnOnOrOffSystemProtection.TabStop = True
        Me.linklabelTurnOnOrOffSystemProtection.Text = "TenForums: How to Turn On or Off System Protection" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Drives in Windows 10 (ste" &
    "p 6)"
        '
        'linklabelCreateSystemRestorePoint
        '
        Me.linklabelCreateSystemRestorePoint.AutoSize = True
        Me.linklabelCreateSystemRestorePoint.BackColor = System.Drawing.SystemColors.Window
        Me.linklabelCreateSystemRestorePoint.Location = New System.Drawing.Point(13, 150)
        Me.linklabelCreateSystemRestorePoint.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.linklabelCreateSystemRestorePoint.Name = "linklabelCreateSystemRestorePoint"
        Me.linklabelCreateSystemRestorePoint.Size = New System.Drawing.Size(320, 26)
        Me.linklabelCreateSystemRestorePoint.TabIndex = 3
        Me.linklabelCreateSystemRestorePoint.TabStop = True
        Me.linklabelCreateSystemRestorePoint.Text = "TenForums: How to Create a System Restore Point in Windows 10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(step 5)"
        '
        'buttonDontCreateRestorePoint
        '
        Me.buttonDontCreateRestorePoint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonDontCreateRestorePoint.Location = New System.Drawing.Point(265, 193)
        Me.buttonDontCreateRestorePoint.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonDontCreateRestorePoint.Name = "buttonDontCreateRestorePoint"
        Me.buttonDontCreateRestorePoint.Size = New System.Drawing.Size(86, 26)
        Me.buttonDontCreateRestorePoint.TabIndex = 4
        Me.buttonDontCreateRestorePoint.Text = "No"
        Me.buttonDontCreateRestorePoint.UseVisualStyleBackColor = True
        '
        'checkboxDontAskAgain
        '
        Me.checkboxDontAskAgain.AutoSize = True
        Me.checkboxDontAskAgain.Location = New System.Drawing.Point(11, 199)
        Me.checkboxDontAskAgain.Margin = New System.Windows.Forms.Padding(2)
        Me.checkboxDontAskAgain.Name = "checkboxDontAskAgain"
        Me.checkboxDontAskAgain.Size = New System.Drawing.Size(100, 17)
        Me.checkboxDontAskAgain.TabIndex = 5
        Me.checkboxDontAskAgain.Text = "Don't ask again"
        Me.checkboxDontAskAgain.UseVisualStyleBackColor = True
        '
        'panelMessageArea
        '
        Me.panelMessageArea.BackColor = System.Drawing.SystemColors.Window
        Me.panelMessageArea.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMessageArea.Location = New System.Drawing.Point(0, 0)
        Me.panelMessageArea.Name = "panelMessageArea"
        Me.panelMessageArea.Size = New System.Drawing.Size(362, 188)
        Me.panelMessageArea.TabIndex = 6
        '
        'aaformRestorePointReminder
        '
        Me.AcceptButton = Me.buttonOpenRestorePointControlPanel
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonDontCreateRestorePoint
        Me.ClientSize = New System.Drawing.Size(362, 229)
        Me.Controls.Add(Me.checkboxDontAskAgain)
        Me.Controls.Add(Me.linklabelCreateSystemRestorePoint)
        Me.Controls.Add(Me.linklabelTurnOnOrOffSystemProtection)
        Me.Controls.Add(Me.labelRestorePointReminder)
        Me.Controls.Add(Me.buttonOpenRestorePointControlPanel)
        Me.Controls.Add(Me.buttonDontCreateRestorePoint)
        Me.Controls.Add(Me.panelMessageArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aaformRestorePointReminder"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore point reminder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonOpenRestorePointControlPanel As Button
    Friend WithEvents labelRestorePointReminder As Label
    Friend WithEvents linklabelTurnOnOrOffSystemProtection As LinkLabel
    Friend WithEvents linklabelCreateSystemRestorePoint As LinkLabel
    Friend WithEvents buttonDontCreateRestorePoint As Button
    Friend WithEvents checkboxDontAskAgain As CheckBox
    Friend WithEvents panelMessageArea As Panel
End Class
