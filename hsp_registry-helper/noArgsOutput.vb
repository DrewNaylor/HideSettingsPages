Public Class noArgsOutput
    Friend Shared Sub outputText()
        ' Show the user app info including title, version, copyright, and license.
        Console.WriteLine(My.Application.Info.Title & " Version " & My.Application.Info.Version.ToString)
        Console.WriteLine(My.Application.Info.Copyright)
        Console.WriteLine("Visit <http://www.gnu.org/licenses/> for more information on the Gnu GPL.")
        Console.WriteLine("")
        Console.WriteLine("This program is non-interactive and only accepts command-line arguments.")
        Console.WriteLine("Proper command syntax is shown below.")
    End Sub
End Class
