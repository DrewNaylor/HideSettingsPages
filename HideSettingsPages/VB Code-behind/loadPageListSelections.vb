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
        ' Define the header text for file validity checking.
        Dim validHeaderCheck As String = "[HideSettingsPages Page Selections Format 1.00]"
        ' See what the file starts with.
        ' Load the file itself.
        Dim fileReaderInput As String = My.Computer.FileSystem.ReadAllText(inputTextFile)
        ' Ensure the input file is a valid text file for HideSettingsPages usage.
        ' This could be useful as a feature to add to hsp_registry-helper as well.
        If fileReaderInput.StartsWith(validHeaderCheck) Then
            ' Since the file appears to be valid, remove that text from the string and parse the rest.
            fileReaderInput = fileReaderInput.Replace(validHeaderCheck, "")
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

        ' First, get a page name list based on the previous
        ' split string.
        Dim pageNameList As String() = loaderPageList
        ' Now we look at each of the page names in that
        ' page name list.
        For Each pageName In pageNameList
            ' Look through every item in the checkedlistbox.
            For i As Integer = 0 To aaformMainWindow.checkedlistboxPageList.Items.Count - 1
                ' If the "current" checkedlistbox item text matches the
                ' page name we're looking for, then trim the end and
                ' check the checkedlistitem.
                If aaformMainWindow.checkedlistboxPageList.Items(i).ToString.TrimEnd = pageName Then
                    aaformMainWindow.checkedlistboxPageList.SetItemChecked(i, True)
                End If
            Next ' Go to the next checkedlistbox item.
        Next ' Go to the next page name.
    End Sub

End Class
