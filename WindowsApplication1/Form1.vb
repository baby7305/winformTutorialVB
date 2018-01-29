Public Class Form1
    Private sb As StatusBar
    Private lv As ListView

    Public Sub New()

        Me.Text = "ListView"
        Me.Size = New Size(350, 300)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim actresses As New List(Of Actress)

        actresses.Add(New Actress("Jessica Alba", 1981))
        actresses.Add(New Actress("Angelina Jolie", 1975))
        actresses.Add(New Actress("Natalie Portman", 1981))
        actresses.Add(New Actress("Rachel Weiss", 1971))
        actresses.Add(New Actress("Scarlett Johansson", 1984))


        Dim name As New ColumnHeader
        name.Text = "Name"
        name.Width = -1
        Dim year As New ColumnHeader
        year.Text = "Year"

        Me.SuspendLayout()

        lv = New ListView
        lv.Parent = Me
        lv.FullRowSelect = True
        lv.GridLines = True
        lv.AllowColumnReorder = True
        lv.Sorting = SortOrder.Ascending
        lv.Columns.AddRange(New ColumnHeader() {name, year})

        For Each act As Actress In actresses
            Dim item As New ListViewItem
            item.Text = act.m_name
            item.SubItems.Add(act.m_year.ToString())
            lv.Items.Add(item)
        Next

        lv.Dock = DockStyle.Fill

        sb = New StatusBar
        sb.Parent = Me
        lv.View = View.Details

        Me.ResumeLayout()

        AddHandler lv.Click, AddressOf Me.OnChanged
        AddHandler lv.ColumnClick, AddressOf Me.OnColumnClick

    End Sub

    Private Sub OnChanged(ByVal sender As Object, ByVal e As EventArgs)

        Dim name As String = lv.SelectedItems(0).SubItems(0).Text
        Dim born As String = lv.SelectedItems(0).SubItems(1).Text
        sb.Text = name & ", " & born

    End Sub

    Private Sub OnColumnClick(ByVal sender As Object,
                              ByVal e As ColumnClickEventArgs)

        If sender.Sorting = SortOrder.Ascending Then
            sender.Sorting = SortOrder.Descending
        Else
            sender.Sorting = SortOrder.Ascending
        End If

    End Sub

End Class
