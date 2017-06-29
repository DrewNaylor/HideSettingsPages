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



Imports System.Windows.Forms
Public Module hsp_registry_helper_main

    ' fullKey is the Registry key value from main app.
    Friend fullKeyValue As String = Nothing
    ' actionToTake is the "apply" or "undo" string
    ' from main app.
    Friend actionToTake As String = Nothing
    ' Create string to hold titlebar text for now.
    Friend titlebarText As String = "HideSettingsPages Registry Helper v." & My.Application.Info.Version.ToString

    Public Sub Main(ByVal sArgs() As String)

        ' Set titlebar text to application name and version.
        Console.Title = titlebarText

#Region "Assign values to arguments."
        If sArgs.Length = 0 Then
            'If there are no arguments, print app info and 
            ' tell the user what arguments are accepted.
            argsOutput.noCommandLineArgs()
        Else
            ' Change value of commandline arguments if they exist.
            fullKeyValue = sArgs(0)
            actionToTake = sArgs(1)
            argsOutput.passCommandLineArgs()
        End If
#End Region

    End Sub

End Module
