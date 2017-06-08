'HideSettingsPages Registry Helper - Used to apply the Registry
'key value chosen in HideSettingsPages. Can also apply/remove key value via arguments.
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



Public Class argsOutput
    Friend Shared Sub noCommandLineArgs()
        ' Update titlebar to tell the user there's no arguments passed.
        Console.Title = titlebarText & ": No arguments passed."
        ' Show the user app info including title, version, copyright, and license.
        Console.WriteLine(My.Application.Info.Title & " Version " & My.Application.Info.Version.ToString)
        Console.WriteLine(My.Application.Info.Copyright)
        Console.WriteLine("Visit <http://www.gnu.org/licenses/> for more information on the Gnu GPL.")
        Console.WriteLine("")
        Console.WriteLine("Description:")
        Console.WriteLine("")
        Console.WriteLine(vbTab & "Applies the Registry key value chosen in HideSettingsPages.")
        Console.WriteLine(vbTab & "Can also apply/remove key value via arguments.")
        Console.WriteLine(vbTab & "This key value will hide or show pages in the Windows 10 Settings app")
        Console.WriteLine(vbTab & "on the Creators Update and newer.")
        Console.WriteLine("")
        Console.WriteLine("Syntax:")
        Console.WriteLine("")
        Console.WriteLine(vbTab & "hsp_registry-helper.exe <action> <key value>")
        Console.WriteLine("")
        Console.WriteLine(vbTab & "Where <action> is either /apply (apply Registry key value) or /undo" _
            & " (remove Registry key value.)")
        Console.WriteLine(vbTab & "<key value> is the Registry key to apply to the system.")
        Console.WriteLine("")
        Console.WriteLine(vbTab & "Even if /undo-ing the Registry key value, there must be something in the <key value>")
        Console.WriteLine(vbTab & "section or the app will crash. I want to make it ignore the second argument if <action> is /undo.")
        Console.WriteLine("")
        Console.WriteLine("Examples:")
        Console.WriteLine("")
        Console.WriteLine(vbTab & "hsp_registry-helper.exe /apply hide:display;about")
        Console.WriteLine(vbTab & "hsp_registry-helper.exe /apply showonly:display;about")
        MessageBox.Show("No arguments passed.")
    End Sub

    Friend Shared Sub passCommandLineArgs()
        Console.WriteLine(fullKeyValue)
        Console.WriteLine(actionToTake)

        MessageBox.Show("This is the full Registry key value.")
        MessageBox.Show("Stop.")
    End Sub
End Class
