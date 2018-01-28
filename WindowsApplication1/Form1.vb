Public Class Form1
    Private Const WIDTH1 = 250
    Private Const HEIGHT1 = 150
    Private Const BUTTONS_SPACE = 15
    Private Const PANEL_SPACE = 8
    Private Const CLOSE_SPACE = 10


    Public Sub New()

        Me.Text = "Buttons"
        Me.Size = New Size(WIDTH1, HEIGHT1)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim ok As New Button

        Dim panelHeight As New Integer
        panelHeight = ok.Height + PANEL_SPACE

        Dim panel As New Panel
        panel.Height = panelHeight
        panel.Dock = DockStyle.Bottom
        panel.Parent = Me

        Dim x As Integer = ok.Width * 2 + BUTTONS_SPACE
        Dim y As Integer = (panelHeight - ok.Height) / 2

        ok.Text = "Ok"
        ok.Parent = panel
        ok.Location = New Point(WIDTH1 - x, y)
        ok.Anchor = AnchorStyles.Right

        Dim close As New Button

        x = close.Width

        close.Text = "Close"
        close.Parent = panel
        close.Location = New Point(WIDTH1 - x - CLOSE_SPACE, y)
        close.Anchor = AnchorStyles.Right


    End Sub

    Private Sub OnExit(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub
End Class
