'HideSettingsPages - GUI to set a Registry key value to hide individual pages
'in the Windows 10 Settings app on the Creators Update and newer.
'Copyright (C) 2017-2019 Drew Naylor
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



Public Class loadPageListSelections

    Friend Shared Sub loaderTextFileSource(inputTextFile As String)
        ' See what the file starts with.
        ' Load the file itself.
        Dim fileReaderInput As String = My.Computer.FileSystem.ReadAllText(inputTextFile)
        ' If it starts with "hide:", then select the "Hide" radio button.
        If fileReaderInput.StartsWith("hide:") Then
            Debug.WriteLine(fileReaderInput)
            aaformMainWindow.radiobuttonHidePages.Checked = True
            ' Now remove the beginning of the file and have it be a new string.
            checkBoxes(fileReaderInput.Remove(0, 5))

        ElseIf fileReaderInput.StartsWith("showonly:") Then
            ' Otherwise, if it starts with "showonly:", select the
            ' Show only radio button.
            Debug.WriteLine(fileReaderInput)
            aaformMainWindow.radiobuttonShowOnlyPages.Checked = True
            ' Now remove the beginning of the file and have it be a new string.
            checkBoxes(fileReaderInput.Remove(0, 9))

        End If
    End Sub

    Private Shared Sub checkBoxes(modifiedFile As String)
        Debug.WriteLine(modifiedFile)
        ' A delimiter is needed before continuing.
        ' This is used to split apart the words
        ' so that they canbe checked in the page
        ' list.
        Dim delimiter As Char = ";"c

        ' Page names now need to be split.
        Dim loaderPageList() As String = modifiedFile.Split(delimiter)

        ' Now go through the page list and check all pages
        ' that are in the page list from the file.
        ' This code is based on an MSDN example:
        ' https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.listbox.findstring?view=netframework-4.8

        ' Ensure we have a proper string to search for.
        'For Each pageName As String In loaderPageList
        '    If pageName <> String.Empty Then
        '        ' Find the item in the list and store the index to the item.
        '        Dim index As Integer = aaformMainWindow.checkedlistboxPageList.FindString(pageName)
        '        ' Determine if a valid index is returned. Select the item if it is valid.
        '        If index <> -1 Then
        '            aaformMainWindow.checkedlistboxPageList.SetItemChecked(index, True)
        '        End If
        '    End If
        'Next
        Dim pageName As String() = loaderPageList
        For Each page In pageName
            For i As Integer = 0 To aaformMainWindow.checkedlistboxPageList.Items.Count - 1
                If aaformMainWindow.checkedlistboxPageList.GetItemText(i) = page Then
                    aaformMainWindow.checkedlistboxPageList.SetItemChecked(i, True)
                End If
            Next
        Next
    End Sub

End Class
