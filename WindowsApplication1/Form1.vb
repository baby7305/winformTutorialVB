Public Class Form1
    Private label As Label

    Public Sub New()

        Me.Text = "ComboBox"
        Me.Size = New Size(240, 240)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim cb As New ComboBox
        cb.Parent = Me
        cb.Location = New Point(50, 30)

        cb.Items.AddRange(New Object() {"Ubuntu",
                                        "Mandriva",
                                        "Red Hat",
                                        "Fedora",
                                        "Gentoo"})

        label = New Label
        label.Location = New Point(50, 140)
        label.Parent = Me
        label.Text = "..."

        AddHandler cb.SelectionChangeCommitted, AddressOf Me.OnChanged

    End Sub

    Private Sub OnChanged(ByVal sender As Object, ByVal e As EventArgs)

        label.Text = sender.Text

    End Sub
End Class
