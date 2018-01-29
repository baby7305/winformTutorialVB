Public Class Form1
    Private sb As StatusBar

    Public Sub New()

        Me.Text = "ListBox"
        Me.Size = New Size(210, 210)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim lb As New ListBox
        lb.Parent = Me
        lb.Items.Add("Jessica")
        lb.Items.Add("Rachel")
        lb.Items.Add("Angelina")
        lb.Items.Add("Amy")
        lb.Items.Add("Jennifer")
        lb.Items.Add("Scarlett")

        lb.Dock = DockStyle.Fill

        sb = New StatusBar
        sb.Parent = Me

        AddHandler lb.SelectedIndexChanged, AddressOf Me.OnChanged

    End Sub

    Private Sub OnChanged(ByVal sender As Object, ByVal e As EventArgs)
        sb.Text = sender.SelectedItem
    End Sub

End Class
