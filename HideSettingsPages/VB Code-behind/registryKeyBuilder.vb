'HideSettingsPages - GUI to set a Registry key to hide individual pages
'in the Windows 10 Settings app on the Creators Update and newer.
'Copyright (C) 2017  Drew Naylor
'Microsoft Windows and all related words are copyright
'and trademark Microsoft Corporation.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of HideSettingsPages
'(Program is also known as "Hide Windows 10 Settings App Pages.")
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

Public Class registryKeyBuilder
    Implements INotifyPropertyChanged
#Region "Figure out the Registry key to set to hide pages."
    ' This class has subs that figure out what the Registry key data will be
    ' and it gets updated when the user checks checkboxes or changes the radio
    ' buttons at the top.

    ' Create a friend, shared string called stringKeyHideOrShowOnly
    ' that updates based on which of the radio buttons at the 
    ' top the user clicks.
    Friend Shared stringKeyHideOrShowOnly As String
    ' Create a friend, shared string called stringKeyPageList
    ' to store the list of pages the user wants to hide or shor only
    ' in the Settings app.
    Friend Shared stringKeyPageList As String
    ' Create a friend, shared string called stringFullRegistryKey
    ' to store the completed Registry key.
    Friend Shared stringFullRegistryKey As String
    ' Add an event handler for INotifyPropertyChanged.
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

#Region "computeStringKeyHideOrShowOnly to figure out stringKeyHideOrShowOnly."
    Friend Shared Sub computeStringKeyHideOrShowOnly()
        ' Depending on which Radio Button at the top is checked,
        ' change stringKeyHideOrShowOnly.

        If aaformMainWindow.radiobuttonHidePages.Checked = True Then
            stringKeyHideOrShowOnly = "hide:"
        ElseIf aaformMainWindow.radiobuttonShowOnlyPages.Checked = True Then
            stringKeyHideOrShowOnly = "showonly:"
        End If
    End Sub
#End Region

#Region "computeStringKeyPageList to figure out stringKeyPageList."
    Friend Shared Sub computeStringKeyPageList()
        ' Create private ints and objs to be able to get
        ' the list of the checked items. Code based on MSDN
        ' sample: https://msdn.microsoft.com/en-us/library/e954th47(v=vs.110).aspx

        ' Determine if there are any items checked.  
        If aaformMainWindow.checkedlistboxPageList.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and print results.  
            Dim x As Integer
            Dim s As String = ""
            For x = 0 To aaformMainWindow.checkedlistboxPageList.CheckedItems.Count - 1
                s = s & aaformMainWindow.checkedlistboxPageList.CheckedItems(x).ToString & ";"
            Next x
            stringKeyPageList = s
            stringKeyPageList = stringKeyPageList.TrimEnd(CType(";", Char()))
        End If

    End Sub
#End Region

#Region "Build final Registry key."
    Friend Shared Sub computeStringFullRegistryKey()
        ' Put together final string to display in textbox
        ' and write to the Registry.
        computeStringKeyHideOrShowOnly()
        computeStringKeyPageList()
        stringFullRegistryKey = stringKeyHideOrShowOnly & stringKeyPageList
    End Sub

#End Region


#End Region
End Class
