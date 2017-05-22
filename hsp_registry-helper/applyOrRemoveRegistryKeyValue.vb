﻿'HideSettingsPages Registry Helper - Used to apply the Registry
'key value chosen in HideSettingsPages. Can also apply/remove key value via arguments.
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
Module applyOrRemoveRegistryKeyValue

    ' fullKey is the Registry key value from main app.
    Friend fullKeyValue As String = Nothing
    ' actionToTake is the "apply" or "undo" string
    ' from main app.
    Friend actionToTake As String = Nothing

    Public Sub Main(ByVal sArgs() As String)

        ' Create string to hold titlebar text for now.
        Dim titlebarText As String = "HideSettingsPages Registry Helper v." & My.Application.Info.Version.ToString

        ' Set titlebar text to application name and version.
        Console.Title = titlebarText

#Region "Assign values to arguments."
        If sArgs.Length = 0 Then
            'If there are no arguments, print app info and 
            ' tell the user what arguments are accepted.
            argsOutput.noCommandLineArgs()
            ' Update titlebar to tell the user there's no arguments passed.
            Console.Title = titlebarText & ": No arguments passed."
        Else
            ' Change value of commandline arguments if they exist.
            fullKeyValue = sArgs(0)
            actionToTake = sArgs(1)

        End If
#End Region

#Region "Figure out all the arguments."
        ' I got the code below from this SO answer:
        ' http://stackoverflow.com/a/26323809
        ' Also, this code was modified from this
        ' MSDN article:
        ' https://msdn.microsoft.com/en-us/library/system.diagnostics.ProcessStartInfo.Arguments28v=vs.110%29.aspx?f=255&MSPPError=-2147217396



#End Region


        Console.WriteLine(fullKeyValue)
        Console.WriteLine(actionToTake)

        MessageBox.Show("This is the full Registry key value.")
        MessageBox.Show("Stop.")

    End Sub

End Module
