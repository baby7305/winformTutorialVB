Public Class Form1
    Private txtBox As TextBox
    Private btn As Button

    Public Sub New()

        Me.Text = "Drag & Drop text"
        Me.Size = New Size(250, 200)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        btn = New Button
        txtBox = New TextBox
        Me.SuspendLayout()

        btn.AllowDrop = True
        btn.Location = New Point(150, 50)
        txtBox.Location = New Point(15, 50)

        Me.Controls.Add(btn)
        Me.Controls.Add(txtBox)
        Me.ResumeLayout()

        AddHandler btn.DragEnter, AddressOf Me.OnDragEnter
        AddHandler btn.DragDrop, AddressOf Me.OnDragDrop
        AddHandler txtBox.MouseDown, AddressOf Me.OnMouseDown

    End Sub

    Private Sub OnDragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub OnDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
        sender.Text = e.Data.GetData(DataFormats.Text)
    End Sub

    Private Sub OnMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        sender.DoDragDrop(sender.Text, DragDropEffects.Copy)
    End Sub
End Class
