Public Class Form1
    Dim statusbar As StatusBar

    Public Sub New()

        Me.Text = "FolderBrowserDialog"
        Me.Size = New Size(300, 250)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim toolbar As New ToolBar
        Dim open As New ToolBarButton
        open.Text = "file"

        statusbar = New StatusBar
        statusbar.Parent = Me

        toolbar.Buttons.Add(open)

        Me.Controls.Add(toolbar)

        AddHandler toolbar.ButtonClick, AddressOf Me.OnClicked

    End Sub

    Private Sub OnClicked(ByVal sender As Object,
                          ByVal e As ToolBarButtonClickEventArgs)

        Dim dialog As New FolderBrowserDialog

        If dialog.ShowDialog(Me) = DialogResult.OK Then
            statusbar.Text = dialog.SelectedPath
        End If

    End Sub
End Class
