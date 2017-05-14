<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaformMainWindow
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
        Me.flowlayoutpanelMainWindow = New System.Windows.Forms.FlowLayoutPanel()
        Me.groupboxSettingsPageVisibility = New System.Windows.Forms.GroupBox()
        Me.menubarMainWindow = New System.Windows.Forms.MenuStrip()
        Me.menubarFileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarExitButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarHelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarAboutButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.flowlayoutpanelMainWindow.SuspendLayout()
        Me.groupboxSettingsPageVisibility.SuspendLayout()
        Me.menubarMainWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowlayoutpanelMainWindow
        '
        Me.flowlayoutpanelMainWindow.Controls.Add(Me.groupboxSettingsPageVisibility)
        Me.flowlayoutpanelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowlayoutpanelMainWindow.Location = New System.Drawing.Point(0, 24)
        Me.flowlayoutpanelMainWindow.Name = "flowlayoutpanelMainWindow"
        Me.flowlayoutpanelMainWindow.Size = New System.Drawing.Size(335, 558)
        Me.flowlayoutpanelMainWindow.TabIndex = 0
        '
        'groupboxSettingsPageVisibility
        '
        Me.groupboxSettingsPageVisibility.Controls.Add(Me.RadioButton2)
        Me.groupboxSettingsPageVisibility.Controls.Add(Me.RadioButton1)
        Me.groupboxSettingsPageVisibility.Controls.Add(Me.Label1)
        Me.groupboxSettingsPageVisibility.Location = New System.Drawing.Point(3, 3)
        Me.groupboxSettingsPageVisibility.Name = "groupboxSettingsPageVisibility"
        Me.groupboxSettingsPageVisibility.Size = New System.Drawing.Size(323, 104)
        Me.groupboxSettingsPageVisibility.TabIndex = 0
        Me.groupboxSettingsPageVisibility.TabStop = False
        Me.groupboxSettingsPageVisibility.Text = "Settings Page Visibility"
        '
        'menubarMainWindow
        '
        Me.menubarMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarFileMenu, Me.menubarHelpMenu})
        Me.menubarMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.menubarMainWindow.Name = "menubarMainWindow"
        Me.menubarMainWindow.Size = New System.Drawing.Size(335, 24)
        Me.menubarMainWindow.TabIndex = 1
        Me.menubarMainWindow.Text = "MenuStrip1"
        '
        'menubarFileMenu
        '
        Me.menubarFileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarExitButton})
        Me.menubarFileMenu.Name = "menubarFileMenu"
        Me.menubarFileMenu.Size = New System.Drawing.Size(37, 20)
        Me.menubarFileMenu.Text = "File"
        '
        'menubarExitButton
        '
        Me.menubarExitButton.Name = "menubarExitButton"
        Me.menubarExitButton.Size = New System.Drawing.Size(152, 22)
        Me.menubarExitButton.Text = "Exit"
        '
        'menubarHelpMenu
        '
        Me.menubarHelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarAboutButton})
        Me.menubarHelpMenu.Name = "menubarHelpMenu"
        Me.menubarHelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.menubarHelpMenu.Text = "Help"
        '
        'menubarAboutButton
        '
        Me.menubarAboutButton.Name = "menubarAboutButton"
        Me.menubarAboutButton.Size = New System.Drawing.Size(152, 22)
        Me.menubarAboutButton.Text = "About"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose whether to hide pages or show only certain pages."
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(13, 47)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Hide"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(13, 70)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Show Only"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(335, 582)
        Me.Controls.Add(Me.flowlayoutpanelMainWindow)
        Me.Controls.Add(Me.menubarMainWindow)
        Me.MainMenuStrip = Me.menubarMainWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "aaformMainWindow"
        Me.Text = "HideSettingsPages"
        Me.flowlayoutpanelMainWindow.ResumeLayout(False)
        Me.groupboxSettingsPageVisibility.ResumeLayout(False)
        Me.groupboxSettingsPageVisibility.PerformLayout()
        Me.menubarMainWindow.ResumeLayout(False)
        Me.menubarMainWindow.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents flowlayoutpanelMainWindow As FlowLayoutPanel
    Friend WithEvents menubarMainWindow As MenuStrip
    Friend WithEvents menubarFileMenu As ToolStripMenuItem
    Friend WithEvents menubarExitButton As ToolStripMenuItem
    Friend WithEvents menubarHelpMenu As ToolStripMenuItem
    Friend WithEvents menubarAboutButton As ToolStripMenuItem
    Friend WithEvents groupboxSettingsPageVisibility As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
