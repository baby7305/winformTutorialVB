Imports System.Drawing.Drawing2D

Public Class Form1
    Dim trs(,) As Integer = New Integer(,) {
                                               {0, 35, 70, 100, 150, 180, 210, 250},
                                               {250, 0, 35, 70, 100, 150, 180, 210},
                                               {210, 250, 0, 35, 70, 100, 150, 180},
                                               {180, 210, 250, 0, 35, 70, 100, 150},
                                               {150, 180, 210, 250, 0, 35, 70, 100},
                                               {100, 150, 180, 210, 250, 0, 35, 70},
                                               {70, 100, 150, 180, 210, 250, 0, 35},
                                               {35, 70, 100, 150, 180, 210, 250, 0}
                                           }

    Dim count As Integer = 0
    Dim timer As Timer

    Public Sub New()

        Me.Text = "Waiting"
        Me.Size = New Size(250, 150)

        timer = New Timer
        timer.Enabled = True
        timer.Interval = 80

        AddHandler timer.Tick, AddressOf Me.OnTick
        AddHandler Me.Paint, AddressOf Me.OnPaint

        Me.CenterToScreen()

    End Sub

    Private Sub OnTick(ByVal sender As Object, ByVal e As EventArgs)
        count = count + 1
        Me.Refresh()
    End Sub

    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim si As Size = Me.ClientSize
        g.TranslateTransform(si.Width / 2, si.Height / 2)

        For i As Integer = 0 To 7
            Dim color As Color = Color.FromArgb(trs(count Mod 8, i), 30, 30, 30)
            Dim pen As New Pen(color, 3)
            pen.StartCap = LineCap.Round
            pen.EndCap = LineCap.Round
            g.DrawLine(pen, 0, -10, 0, -40)
            g.RotateTransform(45)
            pen.Dispose()
        Next

        g.Dispose()

    End Sub
End Class
