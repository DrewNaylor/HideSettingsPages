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
        ' sample: https://msdn.microsoft.com/en-us/library/system.windows.forms.checkedlistbox.checkedindices(v=vs.110).aspx

        'Dim itemChecked As String
        'For Each itemChecked In aaformMainWindow.checkedlistboxPageList.CheckedItems
        '    stringKeyPageList = itemChecked.ToString
        'Next

        For Each i As Object In aaformMainWindow.checkedlistboxPageList.CheckedItems

            stringKeyPageList = i.ToString + ";" 'the " ", adds space in between the items.
        Next


    End Sub
#End Region


#End Region
End Class
