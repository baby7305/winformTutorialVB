Public Class Form1
    Public Sub New()

        Me.Text = "Submenu"
        Me.Size = New Size(380, 220)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim ms As New MenuStrip
        ms.Parent = Me

        Dim fileItem As New ToolStripMenuItem("&File")
        Dim exitItem As New ToolStripMenuItem("&Exit", Nothing,
                                              New EventHandler(AddressOf OnExit))

        exitItem.ShortcutKeys = Keys.Control Or Keys.X

        Dim import As New ToolStripMenuItem
        import.Text = "Import"

        Dim temp As New ToolStripMenuItem
        temp.Text = "Import newsfeed list..."
        import.DropDownItems.Add(temp)

        temp = New ToolStripMenuItem
        temp.Text = "Import bookmarks..."
        import.DropDownItems.Add(temp)

        temp = New ToolStripMenuItem
        temp.Text = "Import mail..."

        import.DropDownItems.Add(temp)
        fileItem.DropDownItems.Add(import)
        fileItem.DropDownItems.Add(exitItem)

        ms.Items.Add(fileItem)
        Me.MainMenuStrip = ms

    End Sub

    Private Sub OnExit(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub
End Class
