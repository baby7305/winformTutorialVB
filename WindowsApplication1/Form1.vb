Public Class Form1
    Dim sb As StatusBar

    Public Sub New()

        Me.Text = "Toolbar"
        Me.Size = New Size(250, 220)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim toolBar As New ToolBar
        toolBar.Parent = Me
        Dim toolBarIcons As New ImageList
        Dim saveb As New ToolBarButton
        Dim exitb As New ToolBarButton

        saveb.ImageIndex = 0
        saveb.Tag = "Save"
        exitb.ImageIndex = 1
        exitb.Tag = "Exit"

        toolBar.ImageList = toolBarIcons
        toolBar.ShowToolTips = True
        toolBar.Buttons.AddRange(New ToolBarButton() {saveb, exitb})

        toolBarIcons.Images.Add(New Icon("res/new.ico"))
        toolBarIcons.Images.Add(New Icon("res/exit.ico"))

        AddHandler toolBar.ButtonClick, AddressOf Me.OnClicked

    End Sub


    Private Sub OnClicked(ByVal sender As Object,
                          ByVal e As ToolBarButtonClickEventArgs)

        If e.Button.Tag.Equals("Exit") Then
            Me.Close()
        End If
    End Sub

End Class
