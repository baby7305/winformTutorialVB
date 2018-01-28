Public Class Form1
    Public Sub New()

        Me.Text = "Check menu item"
        Me.Size = New Size(380, 220)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Me.Text = "Anchor"
        Size = New Size(210, 210)

        Dim btn1 As New Button
        btn1.Text = "Button"
        btn1.Parent = Me
        btn1.Location = New Point(30, 30)

        Dim btn2 As New Button
        btn2.Text = "Button"
        btn2.Parent = Me
        btn2.Location = New Point(30, 80)
        btn2.Anchor = AnchorStyles.Right

        Me.CenterToScreen()

    End Sub
End Class
