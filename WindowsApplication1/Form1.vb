Public Class Form1
    Private sb As StatusBar
    Private WithEvents tv As TreeView

    Public Sub New()

        Me.Text = "TreeView"
        Me.Size = New Size(250, 250)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        tv = New TreeView

        Dim root As New TreeNode
        root.Text = "Languages"

        Dim child1 As New TreeNode
        child1.Text = "Python"

        Dim child2 As New TreeNode
        child2.Text = "Ruby"

        Dim child3 As New TreeNode
        child3.Text = "Java"

        root.Nodes.AddRange(New TreeNode() {child1, child2, child3})

        tv.Parent = Me
        tv.Nodes.Add(root)
        tv.Dock = DockStyle.Fill

        sb = New StatusBar
        sb.Parent = Me


    End Sub

    Private Sub OnSelected(ByVal sender As Object,
                           ByVal e As TreeViewEventArgs) Handles tv.AfterSelect
        sb.Text = e.Node.Text
    End Sub

End Class
