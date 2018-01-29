Public Class Form1
    Private IsDragging As Boolean = False
    Private oldX As Integer
    Private oldY As Integer

    Private dropRect As Rectangle
    Private picBox As PictureBox
    Private image As Bitmap
    Private brsh As Brush

    Public Sub New()

        Me.Text = "Drag & Drop image"
        Me.Size = New Size(350, 250)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        IsDragging = False
        dropRect = New Rectangle(10, 10, 200, 160)
        brsh = Brushes.Gray
        picBox = New PictureBox
        Me.LoadImage()

        picBox.Parent = Me
        picBox.Location = New Point(100, 50)
        picBox.Size = New Size(image.Width, image.Height)
        picBox.Image = image
        picBox.Cursor = Cursors.Hand

        AddHandler Me.Paint, AddressOf Me.OnPaint

        AddHandler picBox.MouseDown, AddressOf Me.OnMouseDown
        AddHandler picBox.MouseMove, AddressOf Me.OnMouseMove
        AddHandler picBox.MouseUp, AddressOf Me.OnMouseUp

    End Sub

    Private Sub LoadImage()

        Try
            image = New Bitmap("res/image.jpg")
        Catch
            Console.WriteLine("Error reading image")
            Environment.Exit(1)
        End Try

    End Sub

    Private Sub OnMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        IsDragging = True
        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub OnMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        If IsDragging Then
            picBox.Top = picBox.Top + (e.Y - oldY)
            picBox.Left = picBox.Left + (e.X - oldX)
        End If
    End Sub

    Private Sub OnMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)

        IsDragging = False

        If dropRect.Contains(picBox.Bounds) Then
            brsh = Brushes.Gold
        Else
            brsh = Brushes.Gray
        End If

        Me.Refresh()

    End Sub

    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.FillRectangle(brsh, dropRect)
    End Sub
End Class
