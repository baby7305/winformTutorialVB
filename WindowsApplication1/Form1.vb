Public Class Form1
    Dim sb As StatusBar

    Public Sub New()

        Me.Text = "Check menu item"
        Me.Size = New Size(380, 220)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        sb = New StatusBar
        sb.Parent = Me
        sb.Text = "Ready"

        Dim mainMenu As New MainMenu

        Dim file As MenuItem = mainMenu.MenuItems.Add("&File")
        file.MenuItems.Add(New MenuItem("E&xit",
                                        New EventHandler(AddressOf OnExit), Shortcut.CtrlX))

        Dim view As MenuItem = mainMenu.MenuItems.Add("&View")
        Dim viewStatusBar As New MenuItem("View StatusBar")
        viewStatusBar.Checked = True
        view.MenuItems.Add(viewStatusBar)

        Me.Menu = mainMenu

        AddHandler viewStatusBar.Click, AddressOf Me.ToggleStatusBar


    End Sub

    Private Sub ToggleStatusBar(ByVal sender As Object, ByVal e As EventArgs)

        Dim check As Boolean = sender.Checked

        If check Then
            sb.Visible = False
            sender.Checked = False
        Else
            sb.Visible = True
            sender.Checked = True
        End If

    End Sub


    Private Sub OnExit(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

End Class
