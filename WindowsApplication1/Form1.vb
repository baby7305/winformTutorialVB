Public Class Form1
    Public Sub New()

        Me.Text = "MenuStrip"
        Me.Size = New Size(250, 200)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim menuStrip As New MenuStrip

        Dim titem1 As New ToolStripMenuItem("File")
        menuStrip.Items.Add(titem1)

        Dim titem2 As New ToolStripMenuItem("Tools")
        menuStrip.Items.Add(titem2)

        Dim subm1 As New ToolStripMenuItem("New")
        subm1.Image = Image.FromFile("res/new.png")
        titem1.DropDownItems.Add(subm1)

        Dim subm2 As New ToolStripMenuItem("Open")
        subm2.Image = Image.FromFile("res/open.png")
        titem1.DropDownItems.Add(subm2)

        titem1.DropDownItems.Add(New ToolStripSeparator)

        Dim subm3 As New ToolStripMenuItem("Exit")
        subm3.Image = Image.FromFile("res/exit.png")
        titem1.DropDownItems.Add(subm3)

        AddHandler subm3.Click, AddressOf Me.OnExit

        Controls.Add(menuStrip)

        MainMenuStrip = menuStrip

    End Sub

    Private Sub OnExit(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

End Class
