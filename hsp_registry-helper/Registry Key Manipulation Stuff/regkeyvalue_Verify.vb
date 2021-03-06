﻿'HideSettingsPages Registry Helper - Used to apply the Registry
'key value chosen in HideSettingsPages. Can also apply/remove key value via arguments
'and show the current value in the Registry, also with arguments.
'This key value will hide or show pages in the Windows 10 Settings app on the Creators Update and newer.
'Copyright (C) 2017-2019 Drew Naylor
'Microsoft Windows and all related words are copyright
'and trademark Microsoft Corporation.
'Microsoft is not affiliated with either the HideSettingsPages project or Drew Naylor
'and does not endorse this software.
'Any other companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of HideSettingsPages Registry Helper
'which is used by HideSettingsPages
'(Program is also known as "hsp_registry-helper.")
'
'hsp_registry-helper is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'hsp_registry-helper is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with hsp_registry-helper.  If not, see <http://www.gnu.org/licenses/>.




Public Class regkeyvalue_Verify
    ' If the user chooses to /verify the current Registry key value,
    ' retrieve the proper key value from the Registry if it exists.

    ' I'm using a solution based on this thread:
    ' https://social.msdn.microsoft.com/Forums/en-US/7272f987-bfb5-4bac-a72c-dfde5745832f/how-to-use-add-read-change-delete-registry-keys-with-vbnet?forum=Vsexpressvb

    Public Shared Sub runVerification()


        Dim tempVal As Object = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", "SettingsPageVisibility", Nothing)

        If tempVal Is Nothing Then
            ' If the registry key value doesn't exist, tell the user.
            MessageBox.Show("The Registry key value does not exist.", "Verify current key value", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            ' If the registry key value does exist, tell the user what it is.
            MessageBox.Show("The Registry key value exists." & vbCrLf & vbCrLf & vbCrLf & "Current data:" & vbCrLf & vbCrLf & tempVal.ToString, "Verify current key value", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub


End Class
