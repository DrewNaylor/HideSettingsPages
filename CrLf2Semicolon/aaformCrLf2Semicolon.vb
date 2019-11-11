'CrLf2Semicolon - Replaces CrLf characters with semicolons.
'Copyright (C) 2018 Drew Naylor
'CrLf2Semicolon is part of the HideSettingsPages project.
'https://github.com/DrewNaylor/HideSettingsPages
'
'Microsoft Windows and all related words are copyright
'and trademark Microsoft Corporation.
'Microsoft is not affiliated with either the HideSettingsPages project or Drew Naylor
'and does not endorse this software.
'Any other companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of CrLf2Semicolon
'
'CrLf2Semicolon is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'CrLf2Semicolon is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with CrLf2Semicolon.  If not, see <http://www.gnu.org/licenses/>.




Imports PortableUXLLauncher_ThemeEngine

Public Class aaformCrLf2Semicolon
    Private Sub buttonSelectInput_Click(sender As Object, e As EventArgs) Handles buttonSelectInput.Click
        ' Select all text in Input textbox when clicked.
        textboxInput.Focus()
        textboxInput.SelectAll()
    End Sub

    Private Sub buttonSelectOutput_Click(sender As Object, e As EventArgs) Handles buttonSelectOutput.Click
        ' Select all text in Output textbox when clicked.
        textboxOutput.Focus()
        textboxOutput.SelectAll()
    End Sub

    Private Sub buttonReplaceCrLfWithSemicolons_Click(sender As Object, e As EventArgs) Handles buttonReplaceCrLfWithSemicolons.Click
        ' Take the text in the Input textbox and replace
        ' all vbCrLf characters with semicolons, then
        ' output the text in the Output textbox.

        ' First, store Input textbox text in temp string.
        Dim stringCrLfReplacedBySemicolons As String = textboxInput.Text
        ' If the "Also convert Lf characters" checkbox
        ' is checked, convert vbLf characters to vbCrLf
        ' characters before replacing vbCrLf with
        ' semicolons.
        If checkboxConvertLf.Checked = True Then
            ' Replace vbLf characters in temp string with
            ' vbCrLf characters.

            ' This is only if the "Also convert Lf characters"
            ' checkbox is checked.

            ' First, we need to replace all vbCrLf characters with
            ' vbLf characters. Otherwise, lines will get cut off incorrectly.
            stringCrLfReplacedBySemicolons = stringCrLfReplacedBySemicolons.Replace(vbCrLf, vbLf)
            stringCrLfReplacedBySemicolons = stringCrLfReplacedBySemicolons.Replace(vbLf, vbCrLf)
        End If
        ' Replace vbCrLf characters in stringCrLfReplacedBySemicolons
        ' with semicolons.
        stringCrLfReplacedBySemicolons = stringCrLfReplacedBySemicolons.Replace(vbCrLf, ";")
        ' Write temp string to Output textbox.
        textboxOutput.Text = stringCrLfReplacedBySemicolons
    End Sub

    Private Sub linklabelAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklabelAbout.LinkClicked
        ' Show about dialog.
        MessageBox.Show(My.Application.Info.Title & vbCrLf &
                        "Version " & My.Application.Info.Version.ToString & vbCrLf &
                        My.Application.Info.Description & vbCrLf &
                        My.Application.Info.Copyright & vbCrLf &
                        vbCrLf &
                        "This application is part of the HideSettingsPages project." & vbCrLf &
                        "You can get the code for HideSettingsPages from:" & vbCrLf &
                        "https://github.com/DrewNaylor/HideSettingsPages/" & vbCrLf &
                        vbCrLf &
                        "Below is part of the Gnu GPLv3+ as it applies to " & My.Application.Info.Title & "." & vbCrLf &
                        "Visit http://www.gnu.org/licenses/gpl.html for the full license." & vbCrLf &
                        vbCrLf &
                        "CrLf2Semicolon is free software: you can redistribute it and/or modify" & vbCrLf &
                        "it under the terms of the GNU General Public License as published by" & vbCrLf &
                        "the Free Software Foundation, either version 3 of the License, or" & vbCrLf &
                        "(at your option) any later version." & vbCrLf &
                        vbCrLf &
                        "CrLf2Semicolon is distributed in the hope that it will be useful," & vbCrLf &
                        "but WITHOUT ANY WARRANTY; without even the implied warranty of" & vbCrLf &
                        "MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the" & vbCrLf &
                        "GNU General Public License for more details." & vbCrLf &
                        vbCrLf &
                        "Copyright notice: Microsoft Windows and all related words and" & vbCrLf &
                        "trademarks/registered trademarks owned by Microsoft in the United States" & vbCrLf &
                        "and/or other countries are Copyright Microsoft Corporation. All" & vbCrLf &
                        "Rights Reserved to Microsoft for Microsoft's copyrights, trademarks," & vbCrLf &
                        "and registered trademarks." & vbCrLf &
                        vbCrLf &
                        "Any other companies mentioned own their respective copyrights/trademarks." & vbCrLf &
                        vbCrLf &
                        "Microsoft is not affiliated with either the HideSettingsPages project or" & vbCrLf &
                        "Drew Naylor and does not endorse this software.", "About " & My.Application.Info.Title)
    End Sub

    ' Create the renderer for the toolstrip:
    Public Shared UXLToolstripRenderer As New uxlProToolstripRenderer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PortableThemeEngine.userTheme.LoadXml(My.Resources.TenDarkTheme_XML)
        PortableUXLLauncher_ThemeEngine.PortableThemeEngine.themeEngine_ApplyTheme("TenDarkTheme", Me, UXLToolstripRenderer)
    End Sub
End Class
