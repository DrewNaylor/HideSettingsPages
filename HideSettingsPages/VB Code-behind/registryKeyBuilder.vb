Public Class registryKeyBuilder
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


#End Region
End Class
