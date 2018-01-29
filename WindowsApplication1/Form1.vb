Public Class Form1
    Private label As Label

    Public Sub New()

        Me.Text = "MonthCalendar"
        Me.Size = New Size(240, 240)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim calendar As New MonthCalendar
        calendar.Parent = Me
        calendar.Location = New Point(20, 20)

        label = New Label
        label.Location = New Point(40, 170)
        label.Parent = Me
        Dim dt As DateTime = calendar.SelectionStart
        label.Text = dt.Month & "/" & dt.Day & "/" & dt.Year

        AddHandler calendar.DateSelected, AddressOf Me.OnSel

    End Sub

    Private Sub OnSel(ByVal sender As Object, ByVal e As DateRangeEventArgs)

        Dim dt As DateTime = sender.SelectionStart
        label.Text = dt.Month & "/" & dt.Day & "/" & dt.Year

    End Sub
End Class
