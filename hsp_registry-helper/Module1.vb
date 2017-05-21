Imports System.Windows.Forms
Module Module1


    Public Sub Main(ByVal sArgs() As String)
        Dim i As Integer = 0
        Dim fullKey As String = Nothing
        Dim actionToTake As String = Nothing

        ' I got the code below from this SO answer:
        ' http://stackoverflow.com/a/26323809

        If sArgs.Length = 0 Then                'If there are no arguments
            Console.WriteLine("Hello World! <-no arguments passed->") 'Just output Hello World
        Else                                    'We have some arguments 

            For Each s As String In My.Application.CommandLineArgs
                Console.WriteLine("[" + i.ToString() + "] = " + s)
                i = i + 1

                If i.ToString = 1 Then
                    fullKey = s
                ElseIf i.ToString = 2 Then
                    actionToTake = s
                End If
            Next
        End If

        Console.WriteLine(fullKey)
        Console.WriteLine(actionToTake)

        MessageBox.Show("This is the full Registry key.")
        MessageBox.Show("Stop.")

    End Sub

End Module
