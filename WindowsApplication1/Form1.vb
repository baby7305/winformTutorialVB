Public Class Form1
    Public Sub New()

        Me.Text = "CheckBox"
        Me.Size = New Size(220, 170)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim cb As New CheckBox
        cb.Parent = Me
        cb.Location = New Point(30, 30)
        cb.Text = "Show Title"
        cb.Checked = True

        AddHandler cb.CheckedChanged, AddressOf Me.OnChanged

    End Sub

    Private Sub OnChanged(ByVal sender As Object, ByVal e As EventArgs)

        If sender.Checked Then
            Text = "CheckBox"
        Else
            Text = ""
        End If

    End Sub
End Class
