Public Class registryKeyBuilder
#Region "Figure out the Registry key to set to hide pages."
    ' This class has subs that figure out what the Registry key data will be
    ' and it gets updated when the user checks checkboxes or changes the radio
    ' buttons at the top.

    ' Create a public, shared string called stringHideOrShowOnly
    ' that updates based on which of the radio buttons at the 
    ' top the user clicks.
    Public Shared stringHideOrShowOnly As String
    ' Create a public, shared string called stringPageList
    ' to store the list of pages the user wants to hide or shor only
    ' in the Settings app.
    Public Shared stringPageList As String
    ' Create a public, shared string called stringFullRegistryKey
    ' to store the completed Registry key.
    Public Shared stringFullRegistryKey As String


#End Region
End Class
