'HideSettingsPages - GUI to set a Registry key value to hide individual pages
'in the Windows 10 Settings app on the Creators Update and newer.
'Copyright (C) 2017-2019 Drew Naylor
'Microsoft Windows and all related words are copyright
'and trademark Microsoft Corporation.
'Microsoft is not affiliated with either the HideSettingsPages project or Drew Naylor
'and does not endorse this software.
'Any other companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of HideSettingsPages
'(Program is also known as "Hide Windows 10 Settings App Pages.")
'
'HideSettingsPages is free software: you can redistribute it and/or modify
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



Public Class aaformRestorePointReminder
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklabelTurnOnOrOffSystemProtection.LinkClicked
        Process.Start("https://www.tenforums.com/tutorials/4533-turn-off-system-protection-drives-windows-10-a.html#step6")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklabelCreateSystemRestorePoint.LinkClicked
        Process.Start("https://www.tenforums.com/tutorials/4571-create-system-restore-point-windows-10-a.html#step5")
    End Sub

    Private Sub buttonOpenRestorePointControlPanel_Click(sender As Object, e As EventArgs) Handles buttonOpenRestorePointControlPanel.Click

        ' Define the ProcessStartInfo for SystemPropertiesProtection.exe.
        Dim proc As New ProcessStartInfo

        ' Check if Windows is 64-bit or 32-bit.
        If Environment.Is64BitOperatingSystem = True Then
            ' If Windows is 64-bit, then sysnative will need to be used
            ' in the path for running CMD.
            proc.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Windows) & "\sysnative\cmd.exe"
        Else
            ' Otherwise, Windows is 32-bit so just use the regular CMD.
            proc.FileName = "cmd.exe"
        End If

        ' Now have the SystemPropertiesProtection.exe file as the argument.
        proc.Arguments = "/c %windir%\system32\SystemPropertiesProtection.exe"
        'Debug.WriteLine(proc.FileName)

        ' Start cmd, which will then run SystemPropertiesProtection.exe.
        Process.Start(proc)

        ' Now we need to close the window.
        Me.Close()
    End Sub

    Private Sub buttonDontCreateRestorePoint_Click(sender As Object, e As EventArgs) Handles buttonDontCreateRestorePoint.Click

        ' If the user has the "Don't ask again" checkbox checked, turn off
        ' the restore point reminder message.
        If checkboxDontAskAgain.Checked = True Then
            My.Settings.messageShowSystemRestoreReminder = False

            ' Save and reload settings.
            My.Settings.Save()
            My.Settings.Reload()

            ' Now update the dropdown in the menubar.
            aaformMainWindow.menubarShowRestorePointReminderMessageButton.Checked = My.Settings.messageShowSystemRestoreReminder
        End If

        ' Now close the window.
        Me.Close()
    End Sub

    Private Sub aaformRestorePointReminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make sure the form is initialized cleanly.
        buttonOpenRestorePointControlPanel.Focus()
        checkboxDontAskAgain.Checked = False
    End Sub
End Class