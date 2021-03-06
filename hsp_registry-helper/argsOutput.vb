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



Public Class argsOutput
    Friend Shared Sub noOrInvalidCommandLineArgs(message As String, messageTitle As String, showMessageBox As Boolean)
        ' Update titlebar to tell the user there's no arguments passed.
        Console.Title = titlebarText & ": " & messageTitle & "."
        ' Show the user app info including title, version, copyright, and license.
        Console.WriteLine(My.Application.Info.Title & " Version " & My.Application.Info.Version.ToString)
        Console.WriteLine(My.Application.Info.Copyright)
        Console.WriteLine("Visit <http://www.gnu.org/licenses/> for more information on the Gnu GPL.")
        Console.WriteLine("")
        Console.WriteLine("Description:")
        Console.WriteLine("")
        Console.WriteLine(vbTab & "Applies the Registry key value chosen in HideSettingsPages.")
        Console.WriteLine(vbTab & "Can also apply/remove key value via arguments and show the")
        Console.WriteLine(vbTab & "current Registry key value in the Registry, also with arguments.")
        Console.WriteLine(vbTab & "This key value will hide or show pages in the Windows 10 Settings app")
        Console.WriteLine(vbTab & "on the Creators Update and newer.")
        Console.WriteLine("")
        Console.WriteLine("Syntax:")
        Console.WriteLine("")
        Console.WriteLine(vbTab & "hsp_registry-helper.exe <action> <key value>")
        Console.WriteLine("")
        Console.WriteLine(vbTab & "Action:" & vbTab & vbTab & "Description:" _
            & vbCrLf & vbTab & "/apply" & vbTab & vbTab & "Apply Registry key value. Requires admin permissions." _
            & vbCrLf & vbTab & "/undo" & vbTab & vbTab & "Remove Registry key value. Requires admin permissions." _
            & vbCrLf & vbTab & "/verify" & vbTab & vbTab & "Show the current Registry key value if it exists." _
            & vbCrLf & vbTab & "/help" & vbTab & vbTab & "Display this help text." _
            & vbCrLf & vbTab & "/?" & vbTab & vbTab & "Display this help text." _
            & vbCrLf & vbTab & "/about" & vbTab & vbTab & "Display information about this application.")
        Console.WriteLine("")
        Console.WriteLine(vbTab & "<key value> is the Registry key value to apply to the system in the" & vbCrLf & vbTab & vbTab & "form of <hide or showonly>:<page>;<more pages>")
        Console.WriteLine("")
        Console.WriteLine(vbTab & "A <key value> is only required if using ""/apply"" as an <action>.")
        Console.WriteLine("")
        Console.WriteLine("Examples:")
        Console.WriteLine("")
        Console.WriteLine(vbTab & "hsp_registry-helper.exe /apply hide:display;about")
        Console.WriteLine(vbTab & "hsp_registry-helper.exe /apply showonly:display;about")
        Console.WriteLine(vbTab & "hsp_registry-helper.exe /undo")
        Console.WriteLine(vbTab & "hsp_registry-helper.exe /verify")
        Console.WriteLine(vbTab & "hsp_registry-helper.exe /help")
        Console.WriteLine(vbTab & "hsp_registry-helper.exe /?")
        Console.WriteLine(vbTab & "hsp_registry-helper.exe /about")

        ' Only shows an error message if showMessageBox is set to True.
        If showMessageBox = True Then
            MessageBox.Show(message, messageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Otherwise, if no messagebox will be shown, ask the user to push Enter to continue.
        ElseIf showMessageBox = False Then
            Console.WriteLine("")
            Console.WriteLine("Press Enter to continue...")
            Console.ReadLine()
        End If
    End Sub

    Friend Shared Sub aboutHspRegistryHelper()
        ' Update titlebar to tell the user this is about the application.
        Console.Title = titlebarText & ": " & "About."
        ' Show the user app info including title, version, copyright, and license.
        Console.WriteLine(My.Application.Info.Title & vbCrLf & "Version " & My.Application.Info.Version.ToString)
        Console.WriteLine(My.Application.Info.Copyright)
        Console.WriteLine("")
        Console.WriteLine(My.Resources.HSPRegistryHelperInfo)
        Console.WriteLine("Press Enter to continue...")
        Console.ReadLine()
    End Sub

    Friend Shared Sub passCommandLineArgs()

        ' Make sure to run the correct code based on the args the user chose.

        If actionToTake = "/verify" Then
            regkeyvalue_Verify.runVerification()
        ElseIf actionToTake = "/undo" Then
            regkeyvalue_Undo.runDeletion()
        ElseIf actionToTake = "/apply" Then
            regkeyvalue_Apply.runApplying()
        ElseIf actionToTake = "/help" Or actionToTake = "/?" Then
            noOrInvalidCommandLineArgs("", "Help info", False)
        ElseIf actionToTake = "/about" Then
            aboutHspRegistryHelper()
        Else
            ' If the argument isn't valid,
            ' tell the user and display
            ' the valid args.
            noOrInvalidCommandLineArgs("Invalid commandline argument: " & actionToTake, "Invalid commandline argument", True)
        End If
    End Sub
End Class
