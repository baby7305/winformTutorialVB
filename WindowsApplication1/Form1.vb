Public Class Form1
    Private isDragging As Boolean = False
    Private oldX As Integer
    Private oldY As Integer
    Private button As Button


    Public Sub New()

        Me.Text = "Drag & Drop button"
        Me.Size = New Size(270, 180)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        button = New Button
        button.Parent = Me
        button.Cursor = Cursors.Hand
        button.Text = "Button"
        button.Location = New Point(20, 20)

        AddHandler button.MouseDown, AddressOf Me.OnMouseDown
        AddHandler button.MouseUp, AddressOf Me.OnMouseUp
        AddHandler button.MouseMove, AddressOf Me.OnMouseMove

    End Sub

    Private Sub OnMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        isDragging = True
        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub OnMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        If isDragging Then
            button.Top = button.Top + (e.Y - oldY)
            button.Left = button.Left + (e.X - oldX)
        End If
    End Sub

    Private Sub OnMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        isDragging = False
    End Sub
End Class
