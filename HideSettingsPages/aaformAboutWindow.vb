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
'This particular file is based off the UXL Launcher About window.
'Original file on GitHub: 
'<https://github.com/DrewNaylor/UXL-Launcher/blob/master/UXL-Launcher/AboutWindow.vb>
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



Imports System.ComponentModel

Public Class aaformAboutWindow
#Region "Code that runs when the About window is opened."
    Private Sub RealAboutWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

#Region "hsp_registry-helper.exe info."
        ' Here's the text to show for hsp_registry-helper's info in the About window.
        Dim infoHSPRegistryHelper As String = " "

        ' Now see if hsp_registry-helper exists in the current folder.
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\hsp_registry-helper.exe") Then
            ' Properly set the variables above to the correct values if it does exist.
            Dim fileversionHSPRegistryHelper As FileVersionInfo = FileVersionInfo.GetVersionInfo(My.Application.Info.DirectoryPath & "\hsp_registry-helper.exe")

            ' Properly set info for hsp_registry-helper.
            infoHSPRegistryHelper =
                "HideSettingsPages Registry Helper" & vbCrLf &
                "Version " & fileversionHSPRegistryHelper.FileVersion & vbCrLf & ' hsp_registry-helper version number.
                fileversionHSPRegistryHelper.LegalCopyright & vbCrLf & ' hsp_registry-helper copyright info.
                My.Resources.HSPRegistryHelperInfo_TXT ' Boilerplate warranty info and stuff for hsp_registry-helper.

        Else
            ' If hsp_registry-helper is missing, let the user know.
            infoHSPRegistryHelper = "HideSettingsPages Registry Helper is missing. Please download a new copy of HideSettingsPages by clicking on the ""Check for updates"" link below."
        End If
#End Region

        ' Create a string with the BuildDate.txt file.
        Dim BuildDateString As String = My.Resources.BuildDate
        BuildDateString = BuildDateString.TrimEnd(CType(vbCrLf, Char()))

        ' Put the text in the About box on launch.
        textboxAboutApp.Text = ("HideSettingsPages - Hide Windows 10 Settings App Pages" & vbCrLf &
"Version " & My.Application.Info.Version.ToString & " " & My.Resources.isStable & vbCrLf &
"App compiled at UTC: " & BuildDateString & vbCrLf &
"Copyright (C) 2017  Drew Naylor. Lincensed under Gnu GPLv3+." & vbCrLf &
My.Resources.HideSettingsPagesInfo_TXT & vbCrLf & vbCrLf & ' HideSettingsPages info for warranty and stuff that used to be here directly.
My.Resources.separator & vbCrLf & vbCrLf & ' separator line.
infoHSPRegistryHelper) ' hsp_registry-helper.exe info as defined above.


        ' Load the GPL document in the RTF Textbox control.
        rtftextboxLicense.Rtf = My.Resources.gpl_RTF
        ' Load the Acknowledgements document in the RTF Textbox control.
        rtftextboxAcknowledgements.Rtf = My.Resources.Acknowledgements_RTF

    End Sub
#End Region

#Region "Code to run when clicking the link to go to the GitHub repository."
    Private Sub linkRepository_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRepository.LinkClicked
        ' Open the GitHub repository.
        Process.Start("https://github.com/DrewNaylor/HideSettingsPages")
    End Sub
#End Region

#Region "Code to run when clicking the link to check for updates."
    Private Sub linkUpdateCheck_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkUpdateCheck.LinkClicked
        ' Go to the Releases page.
        Process.Start("https://github.com/DrewNaylor/HideSettingsPages/releases/latest")
    End Sub
#End Region

#Region "Code to run when clicking the link to go to my website."
    Private Sub linkMyWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkMyWebsite.LinkClicked
        ' Go to my website.
        Process.Start("https://drew-naylor.com")
    End Sub
#End Region

#Region "Code to run when clicking links in the RTF documents."
    Private Sub rtftextboxLicense_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles rtftextboxLicense.LinkClicked
        ' When the user clicks a link in the RTF License rich textbox, go to that
        ' page in the default browser if the user chooses to visit the
        ' page in the messagebox.
        Dim msgResult As Integer = MessageBox.Show("Are you sure you want open this link?" & vbCrLf &
                "" & vbCrLf &
                e.LinkText, "HideSettingsPages",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        ' If the user chooses to open the link, navigate the default browser there.
        If msgResult = DialogResult.Yes Then
            Process.Start(e.LinkText)
        End If
    End Sub

    Private Sub rtftextboxAcknowledgements_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles rtftextboxAcknowledgements.LinkClicked
        ' When the user clicks a link in the RTF License rich textbox, go to that
        ' page in the default browser if the user chooses to visit the
        ' page in the messagebox.
        Dim msgResult As Integer = MessageBox.Show("Are you sure you want open this link?" & vbCrLf &
                "" & vbCrLf &
                e.LinkText, "HideSettingsPages",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        ' If the user chooses to open the link, navigate the default browser there.
        If msgResult = DialogResult.Yes Then
            Process.Start(e.LinkText)
        End If
    End Sub
#End Region

End Class