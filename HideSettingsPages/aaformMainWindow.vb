' HideSettingsPages - GUI for setting a Registry key to hide individual pages
'   in the Windows 10 Settings app on the Creators Update and newer.
' Copyright (C) 2017  Drew Naylor
' Microsoft Windows and all related words are copyright
'   and trademark Microsoft Corporation.
' (Note that the copyright years include the years left out by the hyphen.)
'
' This file is part of HideSettingsPages
' (Program is also known as "Hide Windows 10 Settings App Pages.")
'
' HideSetingsPages is free software: you can redistribute it and/or modify
'   it under the terms of the GNU General Public License as published by
'   the Free Software Foundation, either version 3 of the License, or
'   (at your option) any later version.
'
' HideSettingsPages is distributed in the hope that it will be useful,
'   but WITHOUT ANY WARRANTY; without even the implied warranty of
'   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'   GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
'   along with HideSettingsPages.  If not, see <http://www.gnu.org/licenses/>.



Public Class aaformMainWindow
#Region "Other app code subs."
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the window title based on the name, dev, and version number.
        Me.Text = "HideSettingsPages v." & My.Application.Info.Version.ToString
    End Sub

    Private Sub menubarExitButton_Click(sender As Object, e As EventArgs) Handles menubarExitButton.Click
        ' Close the application.
        Me.Close()
    End Sub
#End Region
#Region "Registry key generator code subs."
    Private Sub checkedlistboxPageList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles checkedlistboxPageList.SelectedIndexChanged
        ' When the user checks checkboxes, update the string that displays
        ' which pages the user chose for the Registry key.
        registryKeyBuilder.computeStringFullRegistryKey()
        textboxRegistryKey.Text = registryKeyBuilder.stringFullRegistryKey
    End Sub

    Private Sub radiobuttonHidePages_Click(sender As Object, e As EventArgs) Handles radiobuttonHidePages.Click
        ' Make sure the stringKeyHideOrShowOnly is updated
        ' when clicking the radio buttons.
        registryKeyBuilder.computeStringFullRegistryKey()
        textboxRegistryKey.Text = registryKeyBuilder.stringFullRegistryKey
    End Sub

    Private Sub radiobuttonShowOnlyPages_Click(sender As Object, e As EventArgs) Handles radiobuttonShowOnlyPages.Click
        ' Make sure the stringKeyHideOrShowOnly is updated
        ' when clicking the radio buttons.
        registryKeyBuilder.computeStringFullRegistryKey()
        textboxRegistryKey.Text = registryKeyBuilder.stringFullRegistryKey
    End Sub
#End Region
End Class
