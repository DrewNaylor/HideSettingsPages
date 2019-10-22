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
        proc.FileName = "C:\Windows\sysnative\cmd.exe"
        proc.Arguments = "/c %windir%\system32\SystemPropertiesProtection.exe"
        Debug.WriteLine(proc.FileName)
        'proc.Verb = "runas"
        Process.Start(proc)
    End Sub
End Class