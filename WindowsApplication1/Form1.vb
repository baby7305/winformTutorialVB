Public Class Form1
    Public Sub New()

        Me.Text = "Icon"
        Me.Size = New Size(250, 200)

        Try
            Icon = New Icon("res/web.ico")
        Catch e As Exception
            Console.WriteLine(e.Message)
            Environment.Exit(1)
        End Try

        Me.CenterToScreen()

    End Sub
End Class
