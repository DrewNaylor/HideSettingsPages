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

#Region "menubarShowSystemRestoreReminderMessage toggle."
    Private Sub menubarShowSystemRestoreReminderMessageButton_Click(sender As Object, e As EventArgs) Handles menubarShowSystemRestoreReminderMessageButton.Click
        ' Toggles on or off the reminder message
        ' that asks the user if they want to create a
        ' system restore point and tells them how to do it
        ' via guides and opens the System Properties Protection
        ' tab for them to do it.

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

#Region "Start up registry helper and delete the key value if the user wants to."
        ' Tell the registry helper app to delete the key value in the Registry.
        Dim proc As New ProcessStartInfo
        proc.FileName = My.Application.Info.DirectoryPath & "\hsp_registry-helper.exe"
        proc.WindowStyle = ProcessWindowStyle.Hidden
        proc.Arguments = "/undo "
        proc.Verb = "runas"
        Try
            Process.Start(proc)
            ' We have to catch this exception
            ' in case the user clicks "No" in the UAC
            ' dialog. Otherwise, we get an error
            ' that says that the operation was
            ' canceled by the user.
        Catch ex As ComponentModel.Win32Exception
            ' Complain and ask the user to download a new copy
            ' if we can't launch the registry helper app.
            ' Code from: https://stackoverflow.com/a/20203356
            Select Case MsgBox("We couldn't find hsp_registry-helper.exe in the current folder." & vbCrLf &
                                "Because this file is used to apply or undo the Registry key value chosen above," & vbCrLf &
                                "it's recommended that a new copy of HideSettingsPages be downloaded." & vbCrLf &
                                "Would you like to download a new copy?" & vbCrLf &
                                vbCrLf &
                                "It's also possible that the User Account Control dialog was canceled, in which case," &
                                " please try again.", MsgBoxStyle.YesNo, "Couldn't launch Registry helper")
                Case MsgBoxResult.Yes
                    Process.Start("https://www.github.com/DrewNaylor/HideSettingsPages/releases")
                Case MsgBoxResult.No
            End Select
        End Try
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

#Region "Start up registry helper and apply the key value if the user wants to."
        ' Tell the registry helper app to apply the key value in the Registry.
        Dim proc As New ProcessStartInfo
        proc.FileName = My.Application.Info.DirectoryPath & "\hsp_registry-helper.exe"
        proc.WindowStyle = ProcessWindowStyle.Hidden
        proc.Arguments = "/apply " & registryKeyValueBuilder.stringFullRegistryKeyValue
        proc.Verb = "runas"
        Try
            Process.Start(proc)
            ' We have to catch this exception
            ' in case the user clicks "No" in the UAC
            ' dialog. Otherwise, we get an error
            ' that says that the operation was
            ' canceled by the user.
        Catch ex As ComponentModel.Win32Exception
            ' Complain and ask the user to download a new copy
            ' if we can't launch the registry helper app.
            ' Code from: https://stackoverflow.com/a/20203356
            Select Case MsgBox("We couldn't find hsp_registry-helper.exe in the current folder." & vbCrLf &
                                "Because this file is used to apply or undo the Registry key value chosen above," & vbCrLf &
                                "it's recommended that a new copy of HideSettingsPages be downloaded." & vbCrLf &
                                "Would you like to download a new copy?" & vbCrLf &
                                vbCrLf &
                                "It's also possible that the User Account Control dialog was canceled, in which case," &
                                " please try again.", MsgBoxStyle.YesNo, "Couldn't launch Registry helper")
                Case MsgBoxResult.Yes
                    Process.Start("https://www.github.com/DrewNaylor/HideSettingsPages/releases")
                Case MsgBoxResult.No
            End Select
        End Try
    End Sub
#End Region
#End Region
#End Region
End Class
