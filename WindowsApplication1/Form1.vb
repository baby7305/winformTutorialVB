Public Class Form1
    Public Sub New()

        Me.Text = "Player"
        Me.Size = New Size(350, 280)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim mainMenu As New MainMenu
        Dim file As MenuItem = mainMenu.MenuItems.Add("&File")
        Dim playm As MenuItem = mainMenu.MenuItems.Add("&Play")
        Dim view As MenuItem = mainMenu.MenuItems.Add("&View")

        Dim tools As MenuItem = mainMenu.MenuItems.Add("&Tools")
        Dim favourites As MenuItem = mainMenu.MenuItems.Add("&Favourites")
        Dim help As MenuItem = mainMenu.MenuItems.Add("&Help")
        file.MenuItems.Add(New MenuItem("E&xit",
                                        New EventHandler(AddressOf Me.OnExit), Shortcut.CtrlX))

        Menu = mainMenu

        Dim panel As New Panel
        panel.Parent = Me
        panel.BackColor = Color.Black
        panel.Dock = DockStyle.Fill

        Dim buttonPanel As New Panel
        buttonPanel.Parent = Me
        buttonPanel.Height = 40
        buttonPanel.Dock = DockStyle.Bottom

        Dim pause As New Button
        pause.FlatStyle = FlatStyle.Popup
        pause.Parent = buttonPanel
        pause.Location = New Point(5, 10)
        pause.Size = New Size(25, 25)
        pause.Image = New Bitmap("res/pause.png")

        Dim play As New Button
        play.FlatStyle = FlatStyle.Popup
        play.Parent = buttonPanel
        play.Location = New Point(35, 10)
        play.Size = New Size(25, 25)
        play.Image = New Bitmap("res/play.png")

        Dim forward As New Button
        forward.FlatStyle = FlatStyle.Popup
        forward.Parent = buttonPanel
        forward.Location = New Point(80, 10)
        forward.Size = New Size(25, 25)
        forward.Image = New Bitmap("res/forward.png")

        Dim backward As New Button
        backward.FlatStyle = FlatStyle.Popup
        backward.Parent = buttonPanel
        backward.Location = New Point(110, 10)
        backward.Size = New Size(25, 25)
        backward.Image = New Bitmap("res/backward.png")

        Dim tb As New TrackBar
        tb.Parent = buttonPanel
        tb.TickStyle = TickStyle.None
        tb.Size = New Size(150, 25)
        tb.Location = New Point(200, 10)
        tb.Anchor = AnchorStyles.Right

        Dim audio As New Button
        audio.FlatStyle = FlatStyle.Popup
        audio.Parent = buttonPanel
        audio.Size = New Size(25, 25)
        audio.Image = New Bitmap("res/audio.png")
        audio.Location = New Point(170, 10)
        audio.Anchor = AnchorStyles.Right

        Dim sb As New StatusBar
        sb.Parent = Me
        sb.Text = "Ready"

        Me.CenterToScreen()

    End Sub


    Private Sub OnExit(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub
End Class
