Public Class Form1
    Private txt As Label

    Public Sub New()

        Me.Text = "FontDialog"
        Me.Size = New Size(300, 250)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim tbar As New ToolBar
        tbar.Parent = Me

        Dim open As New ToolBarButton
        open.Text = "font"
        tbar.Buttons.Add(open)

        txt = New Label
        txt.Parent = Me
        txt.Text = "Winforms tutorial"

        Me.LocateText()

        txt.AutoSize = True

        AddHandler Me.Resize, AddressOf Me.OnResize
        AddHandler tbar.ButtonClick, AddressOf Me.OnClicked

    End Sub

    Private Sub OnClicked(ByVal sender As Object,
                          ByVal e As ToolBarButtonClickEventArgs)

        Dim dialog As New FontDialog

        If dialog.ShowDialog(Me) = DialogResult.OK Then
            txt.Font = dialog.Font
            Me.LocateText()
        End If

    End Sub

    Private Sub LocateText()
        txt.Top = (Me.ClientSize.Height - txt.Height) / 2
        txt.Left = (Me.ClientSize.Width - txt.Width) / 2
    End Sub

    Private Sub OnResize(ByVal sender As Object, ByVal e As EventArgs)
        Me.LocateText()
    End Sub
End Class
