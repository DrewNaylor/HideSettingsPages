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
#Region "Other app code subs."
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the window title based on the name, dev, and version number.
        Me.Text = "HideSettingsPages v." & My.Application.Info.Version.ToString

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
    Private Sub menubarExitButton_Click(sender As Object, e As EventArgs) Handles menubarExitButton.Click
        ' Close the application.
        Me.Close()
    End Sub

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
                           "I couldn't find a way to put the shield on buttons in VB.Net.", MsgBoxStyle.YesNo, "Apply changes")
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
