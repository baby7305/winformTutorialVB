Imports System.Drawing.Drawing2D

Public Class Form1
    Public Sub New()

        Me.Text = "Hatches"
        Me.Size = New Size(360, 300)

        AddHandler Me.Paint, AddressOf Me.OnPaint

        Me.CenterToScreen()

    End Sub


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)

        Dim g As Graphics = e.Graphics

        Dim hb As HatchBrush = New HatchBrush(HatchStyle.Cross, Color.Black, Me.BackColor)
        g.FillRectangle(hb, 10, 15, 90, 60)

        hb = New HatchBrush(HatchStyle.Percent05, Color.Black, Me.BackColor)
        g.FillRectangle(hb, 130, 15, 90, 60)

        hb = New HatchBrush(HatchStyle.SolidDiamond, Color.Black, Me.BackColor)
        g.FillRectangle(hb, 250, 15, 90, 60)

        hb = New HatchBrush(HatchStyle.DiagonalBrick, Color.Black, Me.BackColor)
        g.FillRectangle(hb, 10, 105, 90, 60)

        hb = New HatchBrush(HatchStyle.Divot, Color.Black, Me.BackColor)
        g.FillRectangle(hb, 130, 105, 90, 60)

        hb = New HatchBrush(HatchStyle.Wave, Color.Black, Me.BackColor)
        g.FillRectangle(hb, 250, 105, 90, 60)

        hb = New HatchBrush(HatchStyle.ZigZag, Color.Black, Me.BackColor)
        g.FillRectangle(hb, 10, 195, 90, 60)

        hb = New HatchBrush(HatchStyle.Sphere, Color.Black, Me.BackColor)
        g.FillRectangle(hb, 130, 195, 90, 60)

        hb = New HatchBrush(HatchStyle.Shingle, Color.Black, Me.BackColor)
        g.FillRectangle(hb, 250, 195, 90, 60)

        g.Dispose()
        hb.Dispose()

    End Sub
End Class
