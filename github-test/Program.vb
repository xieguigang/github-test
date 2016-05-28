Module Program

    Const Github As String = "https://github.com/"

    Sub Main()
        Do While True
            Try
                Dim respo As String = Github.GetRequest(https:=True)
                Call Process.Start(Github)
                Return
            Catch ex As Exception
                Call ex.PrintException
            End Try
        Loop
    End Sub
End Module
