Imports System.Windows.Forms
Module Module1


    Public Sub Main(ByVal sArgs() As String)


        ' I got the code below from this SO answer:
        ' http://stackoverflow.com/a/26323809

        If sArgs.Length = 0 Then                'If there are no arguments
            Console.WriteLine("Hello World! <-no arguments passed->") 'Just output Hello World
        Else                                    'We have some arguments 

            Dim i As Integer = 0
            While i < sArgs.Length  'So with each argument
                Console.WriteLine("Hello " & sArgs(i) & "!") 'Print out each item
                i = i + 1  'Increment to the next argument
            End While

        End If

        MessageBox.Show("This is the full Registry key.")
        MessageBox.Show("Stop.")

    End Sub

End Module
