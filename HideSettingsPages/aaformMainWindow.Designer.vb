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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaformMainWindow))
        Me.flowlayoutpanelMainWindow = New System.Windows.Forms.FlowLayoutPanel()
        Me.groupboxSettingsPageVisibility = New System.Windows.Forms.GroupBox()
        Me.radiobuttonShowOnlyPages = New System.Windows.Forms.RadioButton()
        Me.radiobuttonHidePages = New System.Windows.Forms.RadioButton()
        Me.labelPageVisibility = New System.Windows.Forms.Label()
        Me.groupboxPageList = New System.Windows.Forms.GroupBox()
        Me.panelScrollablePageList = New System.Windows.Forms.Panel()
        Me.checkedlistboxPageList = New System.Windows.Forms.CheckedListBox()
        Me.labelChoosePages = New System.Windows.Forms.Label()
        Me.groupboxPreviewRegistryKeyValue = New System.Windows.Forms.GroupBox()
        Me.linklabelViewLarger = New System.Windows.Forms.LinkLabel()
        Me.textboxRegistryKeyValue = New System.Windows.Forms.TextBox()
        Me.panelApplyUndoExit = New System.Windows.Forms.Panel()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.buttonApplyChanges = New System.Windows.Forms.Button()
        Me.buttonUndoChanges = New System.Windows.Forms.Button()
        Me.menubarMainWindow = New System.Windows.Forms.MenuStrip()
        Me.menubarFileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarDirectlyApplyKeyValueButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarVerifyKeyValueButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarExitButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarOptionsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarShowStartupWarningMessageButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarShowRestorePointReminderMessageButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarHelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarHelpTopicsButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.zseparatorHelpMenu = New System.Windows.Forms.ToolStripSeparator()
        Me.menubarAuthorsButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarLicenseButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarAboutButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeselectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.flowlayoutpanelMainWindow.SuspendLayout()
        Me.groupboxSettingsPageVisibility.SuspendLayout()
        Me.groupboxPageList.SuspendLayout()
        Me.panelScrollablePageList.SuspendLayout()
        Me.groupboxPreviewRegistryKeyValue.SuspendLayout()
        Me.panelApplyUndoExit.SuspendLayout()
        Me.menubarMainWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowlayoutpanelMainWindow
        '
        Me.flowlayoutpanelMainWindow.Controls.Add(Me.groupboxSettingsPageVisibility)
        Me.flowlayoutpanelMainWindow.Controls.Add(Me.groupboxPageList)
        Me.flowlayoutpanelMainWindow.Controls.Add(Me.groupboxPreviewRegistryKeyValue)
        Me.flowlayoutpanelMainWindow.Controls.Add(Me.panelApplyUndoExit)
        Me.flowlayoutpanelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowlayoutpanelMainWindow.Location = New System.Drawing.Point(0, 24)
        Me.flowlayoutpanelMainWindow.Name = "flowlayoutpanelMainWindow"
        Me.flowlayoutpanelMainWindow.Size = New System.Drawing.Size(331, 660)
        Me.flowlayoutpanelMainWindow.TabIndex = 0
        '
        'groupboxSettingsPageVisibility
        '
        Me.groupboxSettingsPageVisibility.Controls.Add(Me.radiobuttonShowOnlyPages)
        Me.groupboxSettingsPageVisibility.Controls.Add(Me.radiobuttonHidePages)
        Me.groupboxSettingsPageVisibility.Controls.Add(Me.labelPageVisibility)
        Me.groupboxSettingsPageVisibility.Location = New System.Drawing.Point(3, 3)
        Me.groupboxSettingsPageVisibility.Name = "groupboxSettingsPageVisibility"
        Me.groupboxSettingsPageVisibility.Size = New System.Drawing.Size(323, 88)
        Me.groupboxSettingsPageVisibility.TabIndex = 0
        Me.groupboxSettingsPageVisibility.TabStop = False
        Me.groupboxSettingsPageVisibility.Text = "Settings page visibility"
        '
        'radiobuttonShowOnlyPages
        '
        Me.radiobuttonShowOnlyPages.AutoSize = True
        Me.radiobuttonShowOnlyPages.Location = New System.Drawing.Point(6, 63)
        Me.radiobuttonShowOnlyPages.Name = "radiobuttonShowOnlyPages"
        Me.radiobuttonShowOnlyPages.Size = New System.Drawing.Size(76, 17)
        Me.radiobuttonShowOnlyPages.TabIndex = 2
        Me.radiobuttonShowOnlyPages.Text = "Show Only"
        Me.radiobuttonShowOnlyPages.UseVisualStyleBackColor = True
        '
        'radiobuttonHidePages
        '
        Me.radiobuttonHidePages.AutoSize = True
        Me.radiobuttonHidePages.Checked = True
        Me.radiobuttonHidePages.Location = New System.Drawing.Point(6, 42)
        Me.radiobuttonHidePages.Name = "radiobuttonHidePages"
        Me.radiobuttonHidePages.Size = New System.Drawing.Size(47, 17)
        Me.radiobuttonHidePages.TabIndex = 1
        Me.radiobuttonHidePages.TabStop = True
        Me.radiobuttonHidePages.Text = "Hide"
        Me.radiobuttonHidePages.UseVisualStyleBackColor = True
        '
        'labelPageVisibility
        '
        Me.labelPageVisibility.AutoSize = True
        Me.labelPageVisibility.Location = New System.Drawing.Point(4, 20)
        Me.labelPageVisibility.Name = "labelPageVisibility"
        Me.labelPageVisibility.Size = New System.Drawing.Size(283, 13)
        Me.labelPageVisibility.TabIndex = 0
        Me.labelPageVisibility.Text = "Choose whether to hide pages or show only certain pages."
        '
        'groupboxPageList
        '
        Me.groupboxPageList.Controls.Add(Me.panelScrollablePageList)
        Me.groupboxPageList.Location = New System.Drawing.Point(3, 97)
        Me.groupboxPageList.Name = "groupboxPageList"
        Me.groupboxPageList.Size = New System.Drawing.Size(323, 439)
        Me.groupboxPageList.TabIndex = 1
        Me.groupboxPageList.TabStop = False
        Me.groupboxPageList.Text = "Settings page list"
        '
        'panelScrollablePageList
        '
        Me.panelScrollablePageList.Controls.Add(Me.checkedlistboxPageList)
        Me.panelScrollablePageList.Controls.Add(Me.labelChoosePages)
        Me.panelScrollablePageList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelScrollablePageList.Location = New System.Drawing.Point(3, 16)
        Me.panelScrollablePageList.Margin = New System.Windows.Forms.Padding(2)
        Me.panelScrollablePageList.Name = "panelScrollablePageList"
        Me.panelScrollablePageList.Size = New System.Drawing.Size(317, 420)
        Me.panelScrollablePageList.TabIndex = 13
        '
        'checkedlistboxPageList
        '
        Me.checkedlistboxPageList.CheckOnClick = True
        Me.checkedlistboxPageList.Location = New System.Drawing.Point(3, 22)
        Me.checkedlistboxPageList.Margin = New System.Windows.Forms.Padding(2)
        Me.checkedlistboxPageList.Name = "checkedlistboxPageList"
        Me.checkedlistboxPageList.Size = New System.Drawing.Size(311, 394)
        Me.checkedlistboxPageList.TabIndex = 17
        '
        'labelChoosePages
        '
        Me.labelChoosePages.AutoSize = True
        Me.labelChoosePages.Location = New System.Drawing.Point(0, 6)
        Me.labelChoosePages.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelChoosePages.Name = "labelChoosePages"
        Me.labelChoosePages.Size = New System.Drawing.Size(175, 13)
        Me.labelChoosePages.TabIndex = 13
        Me.labelChoosePages.Text = "Choose pages to hide or only show."
        '
        'groupboxPreviewRegistryKeyValue
        '
        Me.groupboxPreviewRegistryKeyValue.Controls.Add(Me.linklabelViewLarger)
        Me.groupboxPreviewRegistryKeyValue.Controls.Add(Me.textboxRegistryKeyValue)
        Me.groupboxPreviewRegistryKeyValue.Location = New System.Drawing.Point(3, 542)
        Me.groupboxPreviewRegistryKeyValue.Name = "groupboxPreviewRegistryKeyValue"
        Me.groupboxPreviewRegistryKeyValue.Size = New System.Drawing.Size(323, 78)
        Me.groupboxPreviewRegistryKeyValue.TabIndex = 2
        Me.groupboxPreviewRegistryKeyValue.TabStop = False
        Me.groupboxPreviewRegistryKeyValue.Text = "Registry key value preview"
        '
        'linklabelViewLarger
        '
        Me.linklabelViewLarger.AutoSize = True
        Me.linklabelViewLarger.Location = New System.Drawing.Point(6, 62)
        Me.linklabelViewLarger.Name = "linklabelViewLarger"
        Me.linklabelViewLarger.Size = New System.Drawing.Size(68, 13)
        Me.linklabelViewLarger.TabIndex = 1
        Me.linklabelViewLarger.TabStop = True
        Me.linklabelViewLarger.Text = "View larger..."
        '
        'textboxRegistryKeyValue
        '
        Me.textboxRegistryKeyValue.Location = New System.Drawing.Point(6, 20)
        Me.textboxRegistryKeyValue.Multiline = True
        Me.textboxRegistryKeyValue.Name = "textboxRegistryKeyValue"
        Me.textboxRegistryKeyValue.ReadOnly = True
        Me.textboxRegistryKeyValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxRegistryKeyValue.Size = New System.Drawing.Size(311, 39)
        Me.textboxRegistryKeyValue.TabIndex = 0
        '
        'panelApplyUndoExit
        '
        Me.panelApplyUndoExit.Controls.Add(Me.buttonExit)
        Me.panelApplyUndoExit.Controls.Add(Me.buttonApplyChanges)
        Me.panelApplyUndoExit.Controls.Add(Me.buttonUndoChanges)
        Me.panelApplyUndoExit.Location = New System.Drawing.Point(2, 625)
        Me.panelApplyUndoExit.Margin = New System.Windows.Forms.Padding(2)
        Me.panelApplyUndoExit.Name = "panelApplyUndoExit"
        Me.panelApplyUndoExit.Size = New System.Drawing.Size(324, 34)
        Me.panelApplyUndoExit.TabIndex = 4
        '
        'buttonExit
        '
        Me.buttonExit.Location = New System.Drawing.Point(231, 3)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(62, 23)
        Me.buttonExit.TabIndex = 2
        Me.buttonExit.Text = "Exit"
        Me.buttonExit.UseVisualStyleBackColor = True
        '
        'buttonApplyChanges
        '
        Me.buttonApplyChanges.Location = New System.Drawing.Point(32, 3)
        Me.buttonApplyChanges.Name = "buttonApplyChanges"
        Me.buttonApplyChanges.Size = New System.Drawing.Size(87, 23)
        Me.buttonApplyChanges.TabIndex = 0
        Me.buttonApplyChanges.Text = "Apply changes"
        Me.buttonApplyChanges.UseVisualStyleBackColor = True
        '
        'buttonUndoChanges
        '
        Me.buttonUndoChanges.Location = New System.Drawing.Point(125, 3)
        Me.buttonUndoChanges.Name = "buttonUndoChanges"
        Me.buttonUndoChanges.Size = New System.Drawing.Size(100, 23)
        Me.buttonUndoChanges.TabIndex = 1
        Me.buttonUndoChanges.Text = "Undo all changes"
        Me.buttonUndoChanges.UseVisualStyleBackColor = True
        '
        'menubarMainWindow
        '
        Me.menubarMainWindow.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.menubarMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarFileMenu, Me.menubarOptionsMenu, Me.menubarHelpMenu, Me.ToolsToolStripMenuItem})
        Me.menubarMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.menubarMainWindow.Name = "menubarMainWindow"
        Me.menubarMainWindow.Size = New System.Drawing.Size(331, 24)
        Me.menubarMainWindow.TabIndex = 1
        Me.menubarMainWindow.Text = "MenuStrip1"
        '
        'menubarFileMenu
        '
        Me.menubarFileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarDirectlyApplyKeyValueButton, Me.menubarVerifyKeyValueButton, Me.menubarExitButton})
        Me.menubarFileMenu.Name = "menubarFileMenu"
        Me.menubarFileMenu.Size = New System.Drawing.Size(37, 20)
        Me.menubarFileMenu.Text = "&File"
        '
        'menubarDirectlyApplyKeyValueButton
        '
        Me.menubarDirectlyApplyKeyValueButton.Name = "menubarDirectlyApplyKeyValueButton"
        Me.menubarDirectlyApplyKeyValueButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.menubarDirectlyApplyKeyValueButton.Size = New System.Drawing.Size(249, 22)
        Me.menubarDirectlyApplyKeyValueButton.Text = "&Directly apply key value..."
        '
        'menubarVerifyKeyValueButton
        '
        Me.menubarVerifyKeyValueButton.Name = "menubarVerifyKeyValueButton"
        Me.menubarVerifyKeyValueButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.menubarVerifyKeyValueButton.Size = New System.Drawing.Size(249, 22)
        Me.menubarVerifyKeyValueButton.Text = "&Verify current key value..."
        Me.menubarVerifyKeyValueButton.ToolTipText = "Shows the current data in the Registry key value this app modifies."
        '
        'menubarExitButton
        '
        Me.menubarExitButton.Name = "menubarExitButton"
        Me.menubarExitButton.Size = New System.Drawing.Size(249, 22)
        Me.menubarExitButton.Text = "E&xit"
        '
        'menubarOptionsMenu
        '
        Me.menubarOptionsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarShowStartupWarningMessageButton, Me.menubarShowRestorePointReminderMessageButton})
        Me.menubarOptionsMenu.Name = "menubarOptionsMenu"
        Me.menubarOptionsMenu.Size = New System.Drawing.Size(61, 20)
        Me.menubarOptionsMenu.Text = "&Options"
        '
        'menubarShowStartupWarningMessageButton
        '
        Me.menubarShowStartupWarningMessageButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menubarShowStartupWarningMessageButton.Name = "menubarShowStartupWarningMessageButton"
        Me.menubarShowStartupWarningMessageButton.Size = New System.Drawing.Size(273, 22)
        Me.menubarShowStartupWarningMessageButton.Text = "Show startup &warning message"
        '
        'menubarShowRestorePointReminderMessageButton
        '
        Me.menubarShowRestorePointReminderMessageButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menubarShowRestorePointReminderMessageButton.Name = "menubarShowRestorePointReminderMessageButton"
        Me.menubarShowRestorePointReminderMessageButton.Size = New System.Drawing.Size(273, 22)
        Me.menubarShowRestorePointReminderMessageButton.Text = "Show restore point &reminder message"
        '
        'menubarHelpMenu
        '
        Me.menubarHelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarHelpTopicsButton, Me.zseparatorHelpMenu, Me.menubarAuthorsButton, Me.menubarLicenseButton, Me.menubarAboutButton})
        Me.menubarHelpMenu.Name = "menubarHelpMenu"
        Me.menubarHelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.menubarHelpMenu.Text = "&Help"
        '
        'menubarHelpTopicsButton
        '
        Me.menubarHelpTopicsButton.Name = "menubarHelpTopicsButton"
        Me.menubarHelpTopicsButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.menubarHelpTopicsButton.Size = New System.Drawing.Size(210, 22)
        Me.menubarHelpTopicsButton.Text = "&View Help Topics"
        '
        'zseparatorHelpMenu
        '
        Me.zseparatorHelpMenu.Name = "zseparatorHelpMenu"
        Me.zseparatorHelpMenu.Size = New System.Drawing.Size(207, 6)
        '
        'menubarAuthorsButton
        '
        Me.menubarAuthorsButton.Name = "menubarAuthorsButton"
        Me.menubarAuthorsButton.Size = New System.Drawing.Size(210, 22)
        Me.menubarAuthorsButton.Text = "A&cknowledgments"
        '
        'menubarLicenseButton
        '
        Me.menubarLicenseButton.Name = "menubarLicenseButton"
        Me.menubarLicenseButton.Size = New System.Drawing.Size(210, 22)
        Me.menubarLicenseButton.Text = "&License"
        '
        'menubarAboutButton
        '
        Me.menubarAboutButton.Name = "menubarAboutButton"
        Me.menubarAboutButton.Size = New System.Drawing.Size(210, 22)
        Me.menubarAboutButton.Text = "&About"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAllToolStripMenuItem, Me.DeselectAllToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ToolsToolStripMenuItem.Text = "Page list"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select all"
        '
        'DeselectAllToolStripMenuItem
        '
        Me.DeselectAllToolStripMenuItem.Name = "DeselectAllToolStripMenuItem"
        Me.DeselectAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeselectAllToolStripMenuItem.Text = "Deselect all"
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(331, 684)
        Me.Controls.Add(Me.flowlayoutpanelMainWindow)
        Me.Controls.Add(Me.menubarMainWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menubarMainWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "aaformMainWindow"
        Me.Text = "HideSettingsPages"
        Me.flowlayoutpanelMainWindow.ResumeLayout(False)
        Me.groupboxSettingsPageVisibility.ResumeLayout(False)
        Me.groupboxSettingsPageVisibility.PerformLayout()
        Me.groupboxPageList.ResumeLayout(False)
        Me.panelScrollablePageList.ResumeLayout(False)
        Me.panelScrollablePageList.PerformLayout()
        Me.groupboxPreviewRegistryKeyValue.ResumeLayout(False)
        Me.groupboxPreviewRegistryKeyValue.PerformLayout()
        Me.panelApplyUndoExit.ResumeLayout(False)
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
    Friend WithEvents labelPageVisibility As Label
    Friend WithEvents radiobuttonShowOnlyPages As RadioButton
    Friend WithEvents radiobuttonHidePages As RadioButton
    Friend WithEvents groupboxPageList As GroupBox
    Friend WithEvents groupboxPreviewRegistryKeyValue As GroupBox
    Friend WithEvents buttonUndoChanges As Button
    Friend WithEvents buttonApplyChanges As Button
    Friend WithEvents buttonExit As Button
    Friend WithEvents panelScrollablePageList As Panel
    Friend WithEvents labelChoosePages As Label
    Friend WithEvents panelApplyUndoExit As Panel
    Friend WithEvents checkedlistboxPageList As CheckedListBox
    Friend WithEvents linklabelViewLarger As LinkLabel
    Friend WithEvents textboxRegistryKeyValue As TextBox
    Friend WithEvents menubarHelpTopicsButton As ToolStripMenuItem
    Friend WithEvents zseparatorHelpMenu As ToolStripSeparator
    Friend WithEvents menubarAuthorsButton As ToolStripMenuItem
    Friend WithEvents menubarLicenseButton As ToolStripMenuItem
    Friend WithEvents menubarVerifyKeyValueButton As ToolStripMenuItem
    Friend WithEvents menubarOptionsMenu As ToolStripMenuItem
    Friend WithEvents menubarShowStartupWarningMessageButton As ToolStripMenuItem
    Friend WithEvents menubarShowRestorePointReminderMessageButton As ToolStripMenuItem
    Friend WithEvents menubarDirectlyApplyKeyValueButton As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeselectAllToolStripMenuItem As ToolStripMenuItem
End Class
