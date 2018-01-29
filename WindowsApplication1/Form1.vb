Imports System.Drawing.Drawing2D

Public Class Form1
    Public Sub New()

        Me.Text = "Basic Shapes"
        Me.Size = New Size(420, 280)

        AddHandler Me.Paint, AddressOf Me.OnPaint

        Me.CenterToScreen()

    End Sub


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        g.FillRectangle(Brushes.Gray, 20, 20, 120, 80)
        g.FillRectangle(Brushes.Gray, 180, 20, 80, 80)

        g.FillEllipse(Brushes.Gray, 30, 120, 100, 100)
        g.FillEllipse(Brushes.Gray, 160, 130, 100, 70)

        Dim points(5) As Point

        points(0) = New Point(300, 40)
        points(1) = New Point(340, 15)
        points(2) = New Point(380, 40)
        points(3) = New Point(380, 80)
        points(4) = New Point(340, 105)
        points(5) = New Point(300, 80)

        g.FillPolygon(Brushes.Gray, points)
        g.FillPie(Brushes.Gray, New Rectangle(290, 130, 90, 90), 0, 315)

        g.Dispose()

    End Sub
End Class
