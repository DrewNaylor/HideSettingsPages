Public Class aaformRestorePointReminder
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.tenforums.com/tutorials/4533-turn-off-system-protection-drives-windows-10-a.html")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://www.tenforums.com/tutorials/4571-create-system-restore-point-windows-10-a.html")
    End Sub

    Private Sub buttonOpenRestorePointControlPanel_Click(sender As Object, e As EventArgs) Handles buttonOpenRestorePointControlPanel.Click
        Debug.WriteLine("GetFolderPath: {0}", Environment.GetFolderPath(Environment.SpecialFolder.System))
        Debug.WriteLine("GetFolderPath: {0}", Environment.GetFolderPath(Environment.SpecialFolder.SystemX86))
        Dim proc As New ProcessStartInfo
        ' Check if Windows is 64-bit or 32-bit.
        If Environment.Is64BitOperatingSystem = True Then
            ' If Windows is 64-bit, then sysnative will need to be used
            ' in the path for running CMD.
            proc.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Windows) & "\sysnative\cmd.exe"
        Else
            ' Otherwise, Windows is 32-bit so just use the regular CMD.
            proc.FileName = "cmd.exe"
        End If
        proc.Arguments = "/c %windir%\system32\SystemPropertiesProtection.exe"
        Debug.WriteLine(proc.FileName)
        'proc.Verb = "runas"
        Process.Start(proc)
    End Sub
End Class