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

#Region "Ensure the Registry key value is properly recomputed when the user uses the mouse or keyboard."
    Private Sub checkedlistboxPageList_MouseUp(sender As Object, e As MouseEventArgs) Handles checkedlistboxPageList.MouseUp
        ' When the user checks checkboxes, update the string that displays
        ' which pages the user chose for the Registry key value.
        registryKeyValueBuilder.computeStringFullRegistryKeyValue()
    End Sub

    Private Sub checkedlistboxPageList_KeyUp(sender As Object, e As KeyEventArgs) Handles checkedlistboxPageList.KeyUp
        ' When the user checks checkboxes, update the string that displays
        ' which pages the user chose for the Registry key value.
        registryKeyValueBuilder.computeStringFullRegistryKeyValue()
    End Sub
#End Region
#End Region


#Region "Apply/undo Registry key value subs."


    Private Sub buttonUndoChanges_Click(sender As Object, e As EventArgs) Handles buttonUndoChanges.Click
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
        End Try

    End Sub

    Private Sub buttonApplyChanges_Click(sender As Object, e As EventArgs) Handles buttonApplyChanges.Click
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
        End Try
    End Sub
#End Region
End Class
