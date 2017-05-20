Public Class UserControl1
    Private Shared textboxLargeRegistryKeyPreview As Object

    Friend Shared Sub updateLargePreviewTextbox()
        textboxLargeRegistryKeyPreview.Text = registryKeyBuilder.stringFullRegistryKey
    End Sub
End Class
