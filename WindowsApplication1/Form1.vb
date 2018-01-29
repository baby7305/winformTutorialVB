Imports System.Drawing.Drawing2D

Public Class Form1
    Public Sub New()

        Me.Text = "You know I'm no Good"
        Me.Size = New Size(380, 450)

        AddHandler Me.Paint, AddressOf Me.OnPaint

        Me.CenterToScreen()

    End Sub


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)

        Dim g As Graphics = e.Graphics

        Dim ft As New Font("Purisa", 10)
        Dim br As New SolidBrush(Color.Black)

        Dim pt As PointF = New PointF(20.0F, 20.0F)
        g.DrawString("Meet you downstairs in the bar and heard", ft, br, pt)

        pt = New PointF(20.0F, 50.0F)
        g.DrawString("Your rolled up sleeves and your skull t-shirt", ft, br, pt)

        pt = New PointF(20.0F, 80.0F)
        g.DrawString("You say why did you do it with him today?", ft, br, pt)

        pt = New PointF(20.0F, 110.0F)
        g.DrawString("And sniffed me out like I was tanqueray", ft, br, pt)

        pt = New PointF(20.0F, 160.0F)
        g.DrawString("Cause you’re my fella, my guy", ft, br, pt)

        pt = New PointF(20.0F, 190.0F)
        g.DrawString("Hand me your stella and fly", ft, br, pt)

        pt = New PointF(20.0F, 220.0F)
        g.DrawString("By the time I’m out the door", ft, br, pt)

        pt = New PointF(20.0F, 250.0F)
        g.DrawString("You tear me down like roger moore", ft, br, pt)

        pt = New PointF(20.0F, 300.0F)
        g.DrawString("I cheated myself", ft, br, pt)

        pt = New PointF(20.0F, 330.0F)
        g.DrawString("Like I knew I would", ft, br, pt)

        pt = New PointF(20.0F, 360.0F)
        g.DrawString("I told ya, I was trouble", ft, br, pt)

        pt = New PointF(20.0F, 390.0F)
        g.DrawString("You know that I’m no good", ft, br, pt)

        ft.Dispose()
        br.Dispose()
        g.Dispose()

    End Sub
End Class
