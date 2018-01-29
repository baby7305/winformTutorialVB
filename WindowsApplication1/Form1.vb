Public Class Form1
    Public Sub New()

        Me.Text = "Nibbles"

        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        Dim borderWidth As Integer = (Me.Width - Me.ClientSize.Width) / 2
        Dim titleBarHeight As Integer = Me.Height - Me.ClientSize.Height - borderWidth

        Dim board As New BoardSpace.Board
        board.BORDER_WIDTH = borderWidth
        board.TITLEBAR_HEIGHT = titleBarHeight

        Me.Controls.Add(board)
        Me.CenterToScreen()

    End Sub
End Class
