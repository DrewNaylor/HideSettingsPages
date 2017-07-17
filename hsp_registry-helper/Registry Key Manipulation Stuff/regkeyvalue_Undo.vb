'HideSettingsPages Registry Helper - Used to apply the Registry
'key value chosen in HideSettingsPages. Can also apply/remove key value via arguments
'and show the current value in the Registry, also with arguments.
'This key value will hide or show pages in the Windows 10 Settings app on the Creators Update and newer.
'Copyright (C) 2017  Drew Naylor
'Microsoft Windows and all related words are copyright
'and trademark Microsoft Corporation.
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

Friend Class regkeyvalue_Undo
    ' If the user chooses to /undo the Registry key value,
    ' delete the proper key value if it exists.

    ' I'm using a solution based on this thread:
    ' https://social.msdn.microsoft.com/Forums/en-US/7272f987-bfb5-4bac-a72c-dfde5745832f/how-to-use-add-read-change-delete-registry-keys-with-vbnet?forum=Vsexpressvb

    Friend Shared Sub runDeletion()

        Dim tempVal As Object = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", "SettingsPageVisibility", Nothing)

        ' First see if there's a key value to delete.
        If tempVal IsNot Nothing Then
            ' Next, if the user is admin, delete the key value. Using a try/catch because I don't know
            ' how to do it properly. Can't find any examples in VB.

            ' Now we can delete the key value.
            ' Code from:
            ' https://social.msdn.microsoft.com/Forums/en-US/7272f987-bfb5-4bac-a72c-dfde5745832f/how-to-use-add-read-change-delete-registry-keys-with-vbnet?forum=Vsexpressvb

            Try
                Dim deleteFrom As RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
                ' Now delete the key value.
                deleteFrom.DeleteValue("SettingsPageVisibility")
                deleteFrom.Close()

                ' After deleting the value, tell the user.
                MessageBox.Show("Successfully removed the Registry key value." & vbCrLf & "Please start or restart the Settings app to see your changes.", "Undo all changes", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Security.SecurityException
                ' Tell the user if they're not elevated.
                MessageBox.Show("The Registry key value cannot be deleted because the app isn't running as Administrator. Please elevate and try again.", "Undo all changes")
            End Try

        Else
            ' If there's no Registry key value to delete,
            ' tell the user.
            MessageBox.Show("There's no Registry key value to delete.", "Undo all changes")

        End If
    End Sub
End Class
