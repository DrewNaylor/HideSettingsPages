Public Class aaformCrLf2Semicolon
    Private Sub buttonSelectInput_Click(sender As Object, e As EventArgs) Handles buttonSelectInput.Click
        ' Select all text in Input textbox when clicked.
        textboxInput.Focus()
        textboxInput.SelectAll()
    End Sub

    Private Sub buttonSelectOutput_Click(sender As Object, e As EventArgs) Handles buttonSelectOutput.Click
        ' Select all text in Output textbox when clicked.
        textboxOutput.Focus()
        textboxOutput.SelectAll()
    End Sub
End Class
