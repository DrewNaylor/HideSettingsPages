'HideSettingsPages - GUI to set a Registry key value to hide individual pages
'in the Windows 10 Settings app on the Creators Update and newer.
'Copyright (C) 2017  Drew Naylor
'Microsoft Windows and all related words are copyright
'and trademark Microsoft Corporation.
'Any other companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of HideSettingsPages
'(Program is also known as "Hide Windows 10 Settings App Pages.")
'
'HideSetingsPages is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'HideSettingsPages is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with HideSettingsPages.  If not, see <http://www.gnu.org/licenses/>.



Public Class aaformMainWindow
#Region "Form1 load code, exit button, and Registry key View Larger link label."
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the window title based on the name and version number.
        Me.Text = "HideSettingsPages v" & My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString

        ' Make sure the Registry key value is updated as soon as the window
        ' opens because sometimes the "Hide" radio button is unchecked
        ' when I lauch this app from the Debug folder on Windows 7.
        registryKeyValueBuilder.computeStringFullRegistryKeyValue()
        textboxRegistryKeyValue.Text = registryKeyValueBuilder.stringFullRegistryKeyValue

#Region "Startup warning message."
        ' This warning is to let the user know that HideSettingsPages can cause
        ' problems with their Settings app if all the pages in certain categories
        ' are hidden AND that this message can be disabled from "Options>Show startup warning message".

        If My.Settings.messageShowStartupWarning = True Then
            MessageBox.Show("Please be aware that hiding too many pages from certain categories (such as ""Apps"") may cause the Settings app to crash when clicking on those categories." & vbCrLf &
            vbCrLf &
            "This message can be disabled via ""Options>Show startup warning message"".", "HideSettingsPages", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
#End Region

#Region "Options menubar checkboxes."
        ' When the app starts up, we have to make sure the checkboxes
        ' are in the CheckState.Checked if the My.Settings value for
        ' it is True and CheckState.Unchecked if it's False.

        ' First up, the Show startup warning checkbox.
        If My.Settings.messageShowStartupWarning = True Then
            menubarShowStartupWarningMessageButton.CheckState = CheckState.Checked
        ElseIf My.Settings.messageShowStartupWarning = False Then
            menubarShowStartupWarningMessageButton.CheckState = CheckState.Unchecked
        End If

        ' Next, the System Restore reminder message checkbox.
        If My.Settings.messageShowSystemRestoreReminder = True Then
            menubarShowRestorePointReminderMessageButton.CheckState = CheckState.Checked
        ElseIf My.Settings.messageShowSystemRestoreReminder = False Then
            menubarShowRestorePointReminderMessageButton.CheckState = CheckState.Unchecked
        End If
#End Region

    End Sub

    Private Sub buttonExit_Click(sender As Object, e As EventArgs) Handles buttonExit.Click
        ' Close the application.
        Me.Close()
    End Sub

    Private Sub linklabelViewLarger_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklabelViewLarger.LinkClicked
        ' Opens a larger window to preview the Registry key value more easily.
        aaformRegistryKeyValueValueLargePreview.Show()
    End Sub
#End Region

#Region "Menubar buttons."

#Region "File menubar buttons."
    Private Sub menubarExitButton_Click(sender As Object, e As EventArgs) Handles menubarExitButton.Click
        ' Close the application.
        Me.Close()
    End Sub
#End Region

#Region "Options menubar buttons."

#Region "menubarShowStartupWarningMessageButton toggle."
    Private Sub menubarShowStartupWarningMessageButton_Click(sender As Object, e As EventArgs) Handles menubarShowStartupWarningMessageButton.Click
        ' Toggles on or off the warning message on startup
        ' that tells the user this app should only be used
        ' if they know what they're doing and that it could
        ' cause their Settings app to crash if too many pages
        ' are hidden in certain categories.

        ' Code based on UXL Launcher's "Always On Top" button
        ' code.

        ' If the checkbox is unchecked, when it's clicked, set
        ' My.Settings.messageShowStartupWarning to True
        ' and the control's CheckState to CheckState.Checked.
        If menubarShowStartupWarningMessageButton.CheckState = CheckState.Unchecked Then
            menubarShowStartupWarningMessageButton.CheckState = CheckState.Checked
            If My.Settings.messageShowStartupWarning = False Then
                My.Settings.messageShowStartupWarning = True
            End If
            My.Settings.Save()
            My.Settings.Reload()

            ' Print the current value of My.Settings.messageShowStartupWarning.
            Debug.WriteLine("My.Settings.messageShowStartupWarning current value: " & My.Settings.messageShowStartupWarning)

            ' However, if the checkbox is checked, when it's clicked, set
            ' My.Settings.messageShowStartupWarning to False
            ' and the control's CheckState to CheckState.Unchecked.
        ElseIf menubarShowStartupWarningMessageButton.CheckState = CheckState.Checked Then
            menubarShowStartupWarningMessageButton.CheckState = CheckState.Unchecked
            If My.Settings.messageShowStartupWarning = True Then
                My.Settings.messageShowStartupWarning = False
            End If
            My.Settings.Save()
            My.Settings.Reload()

            ' Print the current value of My.Settings.messageShowStartupWarning.
            Debug.WriteLine("My.Settings.messageShowStartupWarning current value: " & My.Settings.messageShowStartupWarning)

        End If
    End Sub
#End Region

#Region "menubarShowRestorePointReminderMessage toggle."
    Private Sub menubarShowRestorePointReminderMessageButton_Click(sender As Object, e As EventArgs) Handles menubarShowRestorePointReminderMessageButton.Click
        ' Toggles on or off the reminder message
        ' that asks the user if they want to create a
        ' system restore point and tells them how to do it
        ' via guides and opens the System Properties Protection
        ' tab for them to do it.

        ' Code based on UXL Launcher's "Always On Top" button
        ' code.

        ' If the checkbox is unchecked, when it's clicked, set
        ' My.Settings.messageShowSystemRestoreReminder to True
        ' and the control's CheckState to CheckState.Checked.
        If menubarShowRestorePointReminderMessageButton.CheckState = CheckState.Unchecked Then
            menubarShowRestorePointReminderMessageButton.CheckState = CheckState.Checked
            If My.Settings.messageShowSystemRestoreReminder = False Then
                My.Settings.messageShowSystemRestoreReminder = True
            End If
            My.Settings.Save()
            My.Settings.Reload()

            ' Print the current value of My.Settings.messageShowSystemRestoreReminder.
            Debug.WriteLine("My.Settings.messageShowSystemRestoreReminder current value: " & My.Settings.messageShowSystemRestoreReminder)

            ' However, if the checkbox is checked, when it's clicked, set
            ' My.Settings.messageShowSystemRestoreReminder to False
            ' and the control's CheckState to CheckState.Unchecked.
        ElseIf menubarShowRestorePointReminderMessageButton.CheckState = CheckState.Checked Then
            menubarShowRestorePointReminderMessageButton.CheckState = CheckState.Unchecked
            If My.Settings.messageShowSystemRestoreReminder = True Then
                My.Settings.messageShowSystemRestoreReminder = False
            End If
            My.Settings.Save()
            My.Settings.Reload()

            ' Print the current value of My.Settings.messageShowSystemRestoreReminder.
            Debug.WriteLine("My.Settings.messageShowSystemRestoreReminder current value: " & My.Settings.messageShowSystemRestoreReminder)

        End If
    End Sub

#End Region

#End Region

#Region "Help menubar buttons."
    Private Sub menubarAboutButton_Click(sender As Object, e As EventArgs) Handles menubarAboutButton.Click
        ' Open the About window to About tab. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
        Dim forceAboutWindowTab As New aaformAboutWindow
        forceAboutWindowTab.tabcontrolAboutWindow.SelectTab(0)
        forceAboutWindowTab.ShowDialog()
    End Sub

    Private Sub menubarLicenseButton_Click(sender As Object, e As EventArgs) Handles menubarLicenseButton.Click
        ' Open the About window to License tab. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
        Dim forceAboutWindowTab As New aaformAboutWindow
        forceAboutWindowTab.tabcontrolAboutWindow.SelectTab(1)
        forceAboutWindowTab.ShowDialog()
    End Sub

    Private Sub menubarAuthorsButton_Click(sender As Object, e As EventArgs) Handles menubarAuthorsButton.Click
        ' Open the About window to Acknowledgements tab. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
        Dim forceAboutWindowTab As New aaformAboutWindow
        forceAboutWindowTab.tabcontrolAboutWindow.SelectTab(2)
        forceAboutWindowTab.ShowDialog()
    End Sub

    Private Sub menubarHelpTopicsButton_Click(sender As Object, e As EventArgs) Handles menubarHelpTopicsButton.Click
        ' Go to the GitHub wiki.
        Process.Start("https://github.com/DrewNaylor/HideSettingsPages/wiki")
    End Sub

    Private Sub menubarVerifyKeyValueButton_Click(sender As Object, e As EventArgs) Handles menubarVerifyKeyValueButton.Click
        ' Launch hsp_registry-helper.exe and have it tell the user what the current Registry key value is.
        ' Tell the registry helper app to apply the key value in the Registry.
        Dim proc As New ProcessStartInfo
        proc.FileName = My.Application.Info.DirectoryPath & "\hsp_registry-helper.exe"
        proc.WindowStyle = ProcessWindowStyle.Hidden
        proc.Arguments = "/verify"
        Try
            Process.Start(proc)
        Catch ex As ComponentModel.Win32Exception
            ' Complain and ask the user to download a new copy
            ' if we can't launch the registry helper app.
            ' Code from: https://stackoverflow.com/a/20203356
            Select Case MsgBox("We couldn't find hsp_registry-helper.exe in the current folder." & vbCrLf &
                                "Because this file is used to show the current Registry key value's data," & vbCrLf &
                                "it's recommended that a new copy of HideSettingsPages be downloaded." & vbCrLf &
                                "Would you like to download a new copy?", MsgBoxStyle.YesNo, "Couldn't launch Registry helper")
                Case MsgBoxResult.Yes
                    Process.Start("https://www.github.com/DrewNaylor/HideSettingsPages/releases")
                Case MsgBoxResult.No
            End Select
        End Try
    End Sub
#End Region
#End Region

#Region "Registry computation code subs."

    Private Sub radiobuttonHidePages_Click(sender As Object, e As EventArgs) Handles radiobuttonHidePages.Click
        ' Make sure the stringKeyValueHideOrShowOnly is updated
        ' when clicking the radio buttons.
        registryKeyValueBuilder.computeStringFullRegistryKeyValue()
    End Sub

    Private Sub radiobuttonShowOnlyPages_Click(sender As Object, e As EventArgs) Handles radiobuttonShowOnlyPages.Click
        ' Make sure the stringKeyValueHideOrShowOnly is updated
        ' when clicking the radio buttons.
        registryKeyValueBuilder.computeStringFullRegistryKeyValue()
    End Sub

#Region "Ensure the Registry key value is properly recomputed however the user activates the items."
    Private Sub checkedlistboxPageList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles checkedlistboxPageList.ItemCheck
        ' When the user checks checkboxes, update the string that displays
        ' which pages the user chose for the Registry key value.

        ' I've found a better way to get all the items in the CheckedListBox
        ' rather than just relying on MouseUp and KeyUp events.
        ' Based on code from: https://stackoverflow.com/a/4454594
        ' Converted with: http://converter.telerik.com/
        Me.BeginInvoke(DirectCast(Sub() registryKeyValueBuilder.computeStringFullRegistryKeyValue(), MethodInvoker))
    End Sub
#End Region
#End Region


#Region "Apply/undo Registry key value subs."

#Region "Undo key value."
    Private Sub buttonUndoChanges_Click(sender As Object, e As EventArgs) Handles buttonUndoChanges.Click

#Region "Ask user if they want to delete the key value."
        ' Ask the user if they want to delete the Registry key value.
        ' Code from: https://stackoverflow.com/a/20203356
        Select Case MsgBox("Are you sure you want to undo all changes?" & vbCrLf &
                           "This will cause all Settings app pages available on your system to be shown." & vbCrLf &
                           "User Account Control will ask for admin permissions." & vbCrLf &
                           "I couldn't find a way to put the shield on buttons in VB.Net.", MsgBoxStyle.YesNo, "Undo all changes")
            Case MsgBoxResult.Yes
                ' This just continues the Sub and deletes the key value.
            Case MsgBoxResult.No
                ' This stops the key value from being deleted.
                Exit Sub
        End Select
#End Region

#Region "Remind the user about making a restore point if they want to."

        ' If the user has it enabled in the Options menu, remind the user about
        ' making a System Restore Point and link them to guides after opening the
        ' System Properties Protection tab.
        ' Code from: https://stackoverflow.com/a/20203356

        If My.Settings.messageShowSystemRestoreReminder = True Then
            Select Case MsgBox("Would you like to manually create a restore point?" & vbCrLf &
                               "Doing so will open two guides, one on enabling System Protection" & vbCrLf &
                               "and another on creating a restore point. The System Properties page in the Control Panel will also appear." & vbCrLf &
                               "In each guide, start at part 5 and only follow ""Option One"" on the restore point creation guide." & vbCrLf &
                               "I could do this in code, but Windows 8 and above only allow one restore point per day if done programmatically." & vbCrLf &
                               "There's not a universal way to go straight to the System Properties Protection tab, so this workaround will hopefully work until Microsoft removes the Control Panel." & vbCrLf &
                               vbCrLf &
                               "This message can be disabled via ""Options>Show restore point reminder message"".", MsgBoxStyle.YesNo, "Undo all changes")
                Case MsgBoxResult.Yes
                    ' Open the appropriate links and applications.
                    Process.Start("https://www.tenforums.com/tutorials/4533-turn-off-system-protection-drives-windows-10-a.html")
                    Process.Start("https://www.tenforums.com/tutorials/4571-create-system-restore-point-windows-10-a.html")
                    Process.Start("control.exe", "system")

                    ' Put another messagebox in so that the user
                    ' has enough time to make a restore point.
                    MessageBox.Show("Once you're ready to apply the key value, click OK.", "Undo all changes")

                Case MsgBoxResult.No
                    ' This just skips this code.
            End Select
        End If

#End Region


#Region "Start up registry helper and delete the key value if the user wants to."
        ' Tell the registry helper app to delete the key value in the Registry.
        Dim proc As New ProcessStartInfo
        proc.FileName = My.Application.Info.DirectoryPath & "\hsp_registry-helper.exe"
        proc.WindowStyle = ProcessWindowStyle.Hidden
        proc.Arguments = "/undo "
        proc.Verb = "runas"
        ' First we need to make sure the user has hsp_registry-helper.
        If My.Computer.FileSystem.FileExists(proc.FileName) Then
            ' Then we use Try...Catch to prevent errors if the user cancels UAC.
            Try
                Process.Start(proc)
                ' We have to catch this exception
                ' in case the user clicks "No" in the UAC
                ' dialog. Otherwise, we get an error
                ' that says that the operation was
                ' canceled by the user.
            Catch ex As ComponentModel.Win32Exception
            End Try

            ' If hsp_registry-helper isn't found, tell the user.
        Else
            ' Complain and ask the user to download a new copy
            ' if we can't launch the registry helper app.
            ' Code from: https://stackoverflow.com/a/20203356
            Select Case MsgBox("We couldn't find hsp_registry-helper.exe in the current folder." & vbCrLf &
                                "Because this file is used to apply or undo the Registry key value chosen via" & vbCrLf &
                                "HideSettingsPages, it's recommended that a new copy of this app be downloaded." & vbCrLf &
                                "Would you like to download a new copy?", MsgBoxStyle.YesNo, "Couldn't launch Registry helper")
                Case MsgBoxResult.Yes
                    Process.Start("https://www.github.com/DrewNaylor/HideSettingsPages/releases")
                Case MsgBoxResult.No
            End Select
        End If
    End Sub
#End Region
#End Region

#Region "Apply key value"
    Private Sub buttonApplyChanges_Click(sender As Object, e As EventArgs) Handles buttonApplyChanges.Click

#Region "Ask user if they want to apply the key value."
        ' Ask the user if they want to apply the Registry key value.
        ' Code from: https://stackoverflow.com/a/20203356
        Select Case MsgBox("Are you sure you want to apply your changes?" & vbCrLf &
                           "This will cause pages in the Settings app to be hidden based on your selections." & vbCrLf &
                           "User Account Control will ask for admin permissions." & vbCrLf &
                           "I couldn't find a way to put the shield on buttons in VB.Net." & vbCrLf & vbCrLf & vbCrLf &
                           "Your selections:" & vbCrLf &
                           vbCrLf &
                           registryKeyValueBuilder.stringFullRegistryKeyValue, MsgBoxStyle.YesNo, "Apply changes")
            Case MsgBoxResult.Yes
                ' This just continues the Sub and applies the key value.
            Case MsgBoxResult.No
                ' This stops the key value from being applied.
                Exit Sub
        End Select
#End Region

#Region "Remind the user about making a restore point if they want to."

        ' If the user has it enabled in the Options menu, remind the user about
        ' making a System Restore Point and link them to guides after opening the
        ' System Properties Protection tab.
        ' Code from: https://stackoverflow.com/a/20203356

        If My.Settings.messageShowSystemRestoreReminder = True Then
            Select Case MsgBox("Would you like to manually create a restore point?" & vbCrLf &
                               "Doing so will open two guides, one on enabling System Protection" & vbCrLf &
                               "and another on creating a restore point. The System Properties page in the Control Panel will also appear." & vbCrLf &
                               "In each guide, start at part 5 and only follow ""Option One"" on the restore point creation guide." & vbCrLf &
                               "I could do this in code, but Windows 8 and above only allow one restore point per day if done programmatically." & vbCrLf &
                               "There's not a universal way to go straight to the System Properties Protection tab, so this workaround will hopefully work until Microsoft removes the Control Panel." & vbCrLf &
                               vbCrLf &
                               "This message can be disabled via ""Options>Show restore point reminder message"".", MsgBoxStyle.YesNo, "Apply changes")
                Case MsgBoxResult.Yes
                    ' Open the appropriate links and applications.
                    Process.Start("https://www.tenforums.com/tutorials/4533-turn-off-system-protection-drives-windows-10-a.html")
                    Process.Start("https://www.tenforums.com/tutorials/4571-create-system-restore-point-windows-10-a.html")
                    Process.Start("control.exe", "system")

                    ' Put another messagebox in so that the user
                    ' has enough time to make a restore point.
                    MessageBox.Show("Once you're ready to apply the key value, click OK.", "Apply changes")

                Case MsgBoxResult.No
                    ' This just skips this code.
            End Select
        End If

#End Region

#Region "Start up registry helper and apply the key value if the user wants to."
        ' Tell the registry helper app to apply the key value in the Registry.
        Dim proc As New ProcessStartInfo
        proc.FileName = My.Application.Info.DirectoryPath & "\hsp_registry-helper.exe"
        proc.WindowStyle = ProcessWindowStyle.Hidden
        proc.Arguments = "/apply " & registryKeyValueBuilder.stringFullRegistryKeyValue
        proc.Verb = "runas"
        ' First we need to make sure the user has hsp_registry-helper.
        If My.Computer.FileSystem.FileExists(proc.FileName) Then
            ' Then we use Try...Catch to prevent errors if the user cancels UAC.
            Try
                Process.Start(proc)
                ' We have to catch this exception
                ' in case the user clicks "No" in the UAC
                ' dialog. Otherwise, we get an error
                ' that says that the operation was
                ' canceled by the user.
            Catch ex As ComponentModel.Win32Exception
            End Try

            ' If hsp_registry-helper isn't found, tell the user.
        Else
            ' Complain and ask the user to download a new copy
            ' if we can't launch the registry helper app.
            ' Code from: https://stackoverflow.com/a/20203356
            Select Case MsgBox("We couldn't find hsp_registry-helper.exe in the current folder." & vbCrLf &
                                "Because this file is used to apply or undo the Registry key value chosen via" & vbCrLf &
                                "HideSettingsPages, it's recommended that a new copy of this app be downloaded." & vbCrLf &
                                "Would you like to download a new copy?", MsgBoxStyle.YesNo, "Couldn't launch Registry helper")
                Case MsgBoxResult.Yes
                    Process.Start("https://www.github.com/DrewNaylor/HideSettingsPages/releases")
                Case MsgBoxResult.No
            End Select
        End If
    End Sub
#End Region
#End Region
#End Region
End Class
