Imports System.Drawing.Drawing2D

Public Class Form1
    Private rotunda As Bitmap
    Private gs As Bitmap

    Public Sub New()

        Me.Text = "Grayscale"
        Me.Size = New Size(290, 150)

        rotunda = Me.LoadImage
        gs = GrayScale(rotunda.Clone)

        AddHandler Me.Paint, AddressOf Me.OnPaint

        Me.CenterToScreen()

    End Sub

    Private Function LoadImage() As Bitmap

        Try
            rotunda = New Bitmap("res/rotunda.jpg")
            Return rotunda
        Catch
            Console.WriteLine("Image not found")
            Environment.Exit(1)
        End Try

    End Function

    Private Function GrayScale(ByVal image As Bitmap) As Bitmap

        Dim w As Integer = image.Width
        Dim h As Integer = image.Height

        For i As Integer = 0 To w - 1
            For j As Integer = 0 To h - 1
                Dim c As Color = image.GetPixel(i, j)
                Dim lum As Double = 0.299 * c.R + 0.587 * c.G + 0.114 * c.B
                image.SetPixel(i, j, Color.FromArgb(lum, lum, lum))
            Next
        Next

        Return image

    End Function


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)

        Dim g As Graphics = e.Graphics

        Dim r1 As New Rectangle(15, 15, rotunda.Width, rotunda.Height)
        g.DrawImage(rotunda, r1)

        Dim r2 As New Rectangle(150, 15, gs.Width, gs.Height)
        g.DrawImage(gs, r2)

        g.Dispose()

    End Sub
End Class
