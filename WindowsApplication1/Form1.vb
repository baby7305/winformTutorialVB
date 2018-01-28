Public Class Form1
    Public Sub New()

        Me.Text = "Quit button"
        Me.Size = New Size(250, 200)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim button As New Button

        button.Location = New Point(30, 20)
        button.Text = "Quit"
        button.Parent = Me

        AddHandler button.Click, AddressOf Me.OnClick

        Me.CenterToScreen()

    End Sub

    Private Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub
End Class
