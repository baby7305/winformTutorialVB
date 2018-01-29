Imports System.IO

Public Class Form1
    Private txtBox As TextBox

    Public Sub New()

        Me.Text = "OpenDialog"
        Me.Size = New Size(300, 250)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim tbar As New ToolBar
        tbar.Parent = Me

        Dim open As New ToolBarButton
        open.Text = "file"
        tbar.Buttons.Add(open)

        txtBox = New TextBox
        txtBox.Parent = Me
        txtBox.Multiline = True
        txtBox.ScrollBars = ScrollBars.Both
        txtBox.WordWrap = False
        txtBox.Parent = Me
        txtBox.Dock = DockStyle.Fill

        AddHandler tbar.ButtonClick, AddressOf Me.OnClicked

    End Sub

    Private Sub OnClicked(ByVal sender As Object,
                          ByVal e As ToolBarButtonClickEventArgs)

        Dim dia As New OpenFileDialog
        dia.Filter = "VB files (*.vb)|*.vb"

        If dia.ShowDialog(Me) = DialogResult.OK Then

            Dim reader As New StreamReader(dia.FileName)
            Dim data As String = reader.ReadToEnd

            reader.Close()
            txtBox.Text = data

        End If

    End Sub
End Class
