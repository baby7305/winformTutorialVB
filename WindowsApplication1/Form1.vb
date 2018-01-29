Public Class Form1
    Public Sub New()

        Me.Text = "Simple menu"
        Me.Size = New Size(220, 170)

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
        fileItem.DropDownItems.Add(exitItem)

        ms.Items.Add(fileItem)
        MainMenuStrip = ms

    End Sub

    Private Sub OnExit(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub
End Class
