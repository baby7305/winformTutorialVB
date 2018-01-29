Public Class Form1
    Dim lyrics As String = "Meet you downstairs in the bar and heard" & vbNewLine &
                           "your rolled up sleeves and your skull t-shirt" & vbNewLine &
                           "You say why did you do it with him today?" & vbNewLine &
                           "and sniff me out like I was Tanqueray" & vbNewLine &
                           "" & vbNewLine &
                           "cause you're my fella, my guy" & vbNewLine &
                           "hand me your stella and fly" & vbNewLine &
                           "by the time I'm out the door" & vbNewLine &
                           "you tear men down like Roger Moore" & vbNewLine &
                           "" & vbNewLine &
                           "I cheated myself" & vbNewLine &
                           "like I knew I would" & vbNewLine &
                           "I told ya, I was trouble" & vbNewLine &
                           "you know that I'm no good"

    Public Sub New()

        Me.Text = "You know I'm no Good"
        Me.Size = New Size(300, 250)

        Me.InitUI()

        Me.CenterToScreen()

    End Sub

    Private Sub InitUI()

        Dim font As New Font("Serif", 10)

        Dim label As New Label
        label.Parent = Me
        label.Text = lyrics
        label.Font = font
        label.Location = New Point(10, 10)
        label.Size = New Size(290, 290)

    End Sub
End Class
