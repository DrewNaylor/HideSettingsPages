'HideSettingsPages - GUI to set a Registry key value to hide individual pages
'in the Windows 10 Settings app on the Creators Update and newer.
'Copyright (C) 2017-2018 Drew Naylor
'Microsoft Windows and all related words are copyright
'and trademark Microsoft Corporation.
'Microsoft is not affiliated with either the HideSettingsPages project or Drew Naylor
'and does not endorse this software.
'Any other companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of HideSettingsPages
'(Program is also known as "Hide Windows 10 Settings App Pages.")
'
'HideSettingsPages is free software: you can redistribute it and/or modify
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




Public Class registryKeyValueBuilder
#Region "Figure out the Registry key value to set to hide pages."
    ' This class has subs that figure out what the Registry key value data will be
    ' and it gets updated when the user checks checkboxes or changes the radio
    ' buttons at the top.

    ' Create a friend, shared string called stringKeyValueHideOrShowOnly
    ' that updates based on which of the radio buttons at the 
    ' top the user clicks.
    Friend Shared stringKeyValueHideOrShowOnly As String
    ' Create a friend, shared string called stringKeyValuePageList
    ' to store the list of pages the user wants to hide or shor only
    ' in the Settings app.
    Friend Shared stringKeyValuePageList As String
    ' Create a friend, shared string called stringFullRegistryKeyValue
    ' to store the completed Registry key value.
    Friend Shared stringFullRegistryKeyValue As String


#Region "computeStringKeyValueHideOrShowOnly to figure out stringKeyValueHideOrShowOnly."
    Friend Shared Sub computeStringKeyValueHideOrShowOnly()
        ' Depending on which Radio Button at the top is checked,
        ' change stringKeyValueHideOrShowOnly.

        If aaformMainWindow.radiobuttonHidePages.Checked = True Then
            stringKeyValueHideOrShowOnly = "hide:"
        ElseIf aaformMainWindow.radiobuttonShowOnlyPages.Checked = True Then
            stringKeyValueHideOrShowOnly = "showonly:"
        End If
    End Sub
#End Region

#Region "computeStringKeyValuePageList to figure out stringKeyValuePageList."
    Friend Shared Sub computeStringKeyValuePageList()
        ' Create private ints and objs to be able to get
        ' the list of the checked items. Code based on MSDN
        ' sample: https://msdn.microsoft.com/en-us/library/e954th47(v=vs.110).aspx

        ' Determine if there are any items checked.  
        If aaformMainWindow.checkedlistboxPageList.CheckedItems.Count > 0 Then
            ' If so, loop through all checked items and print results.
            Dim x As Integer
            Dim s As String = ""
            For x = 0 To aaformMainWindow.checkedlistboxPageList.CheckedItems.Count - 1
                ' Blank lines need to be removed using ".TrimEnd" before the semicolon.
                ' This is a side effect of pulling the page list from My.Resources or a text file. 
                s = s & aaformMainWindow.checkedlistboxPageList.CheckedItems(x).ToString.TrimEnd & ";"
            Next x
            stringKeyValuePageList = s
            ' Remove ending semicolon since it's a separator character.
            stringKeyValuePageList = stringKeyValuePageList.TrimEnd(CType(";", Char()))

        ElseIf aaformMainWindow.checkedlistboxPageList.CheckedItems.Count = 0 Then

            ' If nothing is checked, then make the string empty.
            stringKeyValuePageList = ""
        End If

    End Sub
#End Region

#Region "Build final Registry key value."
    Friend Shared Sub computeStringFullRegistryKeyValue()
        ' Put together final string to display in textbox
        ' and write to the Registry.
        computeStringKeyValueHideOrShowOnly()
        computeStringKeyValuePageList()
        stringFullRegistryKeyValue = stringKeyValueHideOrShowOnly & stringKeyValuePageList

        ' Set the text property in the preview textboxes.
        aaformMainWindow.textboxRegistryKeyValue.Text = stringFullRegistryKeyValue
        aaformRegistryKeyValueValueLargePreview.textboxLargeRegistryKeyValuePreview.Text = stringFullRegistryKeyValue
    End Sub

#End Region


#End Region
End Class
