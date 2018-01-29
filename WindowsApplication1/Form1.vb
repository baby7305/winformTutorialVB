Public Class Form1
    Private col As Color

    Private Const rectWidth As Integer = 100
    Private Const rectHeight As Integer = 100
    Private r As Rectangle


    Public Sub New()

        Me.Text = "ColorDialog"
        Me.Size = New Size(300, 250)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim tbar As New ToolBar
        Dim open As New ToolBarButton
        open.Text = "color"

        col = Color.Blue

        tbar.Buttons.Add(open)

        Me.LocateRect()

        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Controls.Add(tbar)

        AddHandler Me.Paint, AddressOf Me.OnPaint
        AddHandler tbar.ButtonClick, AddressOf Me.OnClicked

    End Sub

    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)

        Dim g As Graphics = e.Graphics
        Me.LocateRect()

        Dim brsh As New SolidBrush(col)

        g.FillRectangle(brsh, r)

    End Sub

    Private Sub OnClicked(ByVal sender As Object,
                          ByVal e As ToolBarButtonClickEventArgs)

        Dim dialog As New ColorDialog

        If dialog.ShowDialog(Me) = DialogResult.OK Then
            col = dialog.Color
            Me.Invalidate()
        End If

    End Sub

    Private Sub LocateRect()
        Dim x As Integer = (Me.ClientSize.Width - rectWidth) / 2
        Dim y As Integer = (Me.ClientSize.Height - rectHeight) / 2
        r = New Rectangle(x, y, rectWidth, rectHeight)
    End Sub
End Class
