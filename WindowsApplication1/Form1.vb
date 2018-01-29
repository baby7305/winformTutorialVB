Public Class Form1
    Private label As Label

    Public Sub New()

        Me.Text = "TextBox"
        Me.Size = New Size(250, 200)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        label = New Label
        label.Parent = Me
        label.Text = "..."
        label.Location = New Point(60, 40)
        label.AutoSize = True

        Dim tbox As New TextBox
        tbox.Parent = Me
        tbox.Location = New Point(60, 100)

        AddHandler tbox.KeyUp, AddressOf Me.OnKeyUp

    End Sub

    Private Sub OnKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)

        Me.label.Text = sender.Text

    End Sub

End Class
