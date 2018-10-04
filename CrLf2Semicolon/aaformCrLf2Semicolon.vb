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

    Private Sub buttonReplaceCrLfWithSemicolons_Click(sender As Object, e As EventArgs) Handles buttonReplaceCrLfWithSemicolons.Click
        ' Take the text in the Input textbox and replace
        ' all vbCrLf characters with semicolons, then
        ' output the text in the Output textbox.

        ' First, store Input textbox text in temp string.
        Dim stringCrLfReplacedBySemicolons As String = textboxInput.Text
        ' If the "Also convert Lf characters" checkbox
        ' is checked, convert vbLf characters to vbCrLf
        ' characters before replacing vbCrLf with
        ' semicolons.
        If checkboxConvertLf.Checked = True Then
            ' Replace vbLf characters in temp string with
            ' vbCrLf characters.

            ' This is only if the "Also convert Lf characters"
            ' checkbox is checked.

            ' First, we need to replace all vbCrLf characters with
            ' vbLf characters. Otherwise, lines will get cut off incorrectly.
            stringCrLfReplacedBySemicolons = stringCrLfReplacedBySemicolons.Replace(vbCrLf, vbLf)
            stringCrLfReplacedBySemicolons = stringCrLfReplacedBySemicolons.Replace(vbLf, vbCrLf)
        End If
        ' Replace vbCrLf characters in stringCrLfReplacedBySemicolons
        ' with semicolons.
        stringCrLfReplacedBySemicolons = stringCrLfReplacedBySemicolons.Replace(vbCrLf, ";")
        ' Write temp string to Output textbox.
        textboxOutput.Text = stringCrLfReplacedBySemicolons
    End Sub
End Class
