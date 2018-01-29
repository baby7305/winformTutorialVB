Imports System.Drawing.Drawing2D

Public Class Form1
    Public Sub New()

        Me.Text = "Transparent rectangles"
        Me.Size = New Size(590, 110)

        AddHandler Me.Paint, AddressOf Me.OnPaint

        Me.CenterToScreen()

    End Sub


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)

        Dim g As Graphics = e.Graphics

        For i As Integer = 1 To 10
            Dim color As Color = Color.FromArgb(i * 25, 0, 0, 255)
            Dim brush As Brush = New SolidBrush(color)
            g.FillRectangle(brush, 50 * i, 20, 40, 40)
        Next

        g.Dispose()

    End Sub
End Class
