'HideSettingsPages Registry Helper - Used to apply the Registry
'key value chosen in HideSettingsPages. Can also apply/remove key value via arguments
'and show the current value in the Registry, also with arguments.
'This key value will hide or show pages in the Windows 10 Settings app on the Creators Update and newer.
'Copyright (C) 2017-2018 Drew Naylor
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




' Microsoft.Win32 is used for registry stuff.
Imports Microsoft.Win32

Friend Class regkeyvalue_Apply
    ' If the user chooses to /apply the Registry key value,
    ' create or edit the proper key value if it exists.

    ' I'm using a solution based on this thread:
    ' https://social.msdn.microsoft.com/Forums/en-US/7272f987-bfb5-4bac-a72c-dfde5745832f/how-to-use-add-read-change-delete-registry-keys-with-vbnet?forum=Vsexpressvb

    Friend Shared Sub runApplying()

        ' If the user is admin, edit the key value. Using a try/catch because I don't know
        ' how to do it properly. Can't find any examples in VB.

        ' Now we can edit the key value with the user's choice.
        ' Code from:
        ' https://social.msdn.microsoft.com/Forums/en-US/7272f987-bfb5-4bac-a72c-dfde5745832f/how-to-use-add-read-change-delete-registry-keys-with-vbnet?forum=Vsexpressvb

        Try
            Dim editFrom As RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
            ' Now edit the Registry key value.
            ' This also creates a new Registry key value if there
            ' isn't one there already.
            editFrom.SetValue("SettingsPageVisibility", fullKeyValue)
            editFrom.Close()

            ' After applying the value, tell the user.
            MessageBox.Show("Successfully applied the Registry key value." & vbCrLf & "Please start or restart the Settings app to see your changes.", "Apply changes", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Security.SecurityException
            ' Tell the user if they're not elevated.

            MessageBox.Show("The Registry key value could not be applied because the app isn't running as Administrator. Please elevate and try again.", "Apply changes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
