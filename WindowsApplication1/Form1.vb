Public Class Form1
    Public Sub New()

        Me.Text = "Editor"
        Me.Size = New Size(220, 170)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim mainMenu As New MainMenu
        Dim file As MenuItem = mainMenu.MenuItems.Add("&File")
        file.MenuItems.Add(New MenuItem("E&xit",
                                        New EventHandler(AddressOf Me.OnExit), Shortcut.CtrlX))

        Menu = mainMenu

        Dim tb As New TextBox
        tb.Parent = Me
        tb.Dock = DockStyle.Fill
        tb.Multiline = True

        Dim sb As New StatusBar
        sb.Parent = Me
        sb.Text = "Ready"

    End Sub

    Private Sub OnExit(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub
End Class
