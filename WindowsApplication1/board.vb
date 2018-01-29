Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace BoardSpace

    Public Class Board
        Inherits UserControl


        Const WIDTH As Integer = 300
        Const HEIGHT As Integer = 300
        Const DOT_SIZE As Integer = 10
        Const ALL_DOTS As Integer = 900
        Const RAND_POS As Integer = 27
        Const DELAY As Integer = 140

        Dim x(ALL_DOTS) As Integer
        Dim y(ALL_DOTS) As Integer

        Dim dots As Integer
        Dim apple_x As Integer
        Dim apple_y As Integer

        Dim left As Boolean = False
        Dim right As Boolean = True

        Dim up As Boolean = False
        Dim down As Boolean = False
        Dim inGame As Boolean = True

        Private timer As Timer

        Private dot As Bitmap
        Private apple As Bitmap
        Private head As Bitmap

        Private components As IContainer

        Public BORDER_WIDTH As Integer
        Public TITLEBAR_HEIGHT As Integer


        Public Sub New()

            components = New Container
            Me.BackColor = Color.Black
            Me.DoubleBuffered = True
            Me.ClientSize = New Size(WIDTH, HEIGHT)

            Try
                dot = New Bitmap("res/dot.png")
                apple = New Bitmap("res/apple.png")
                head = New Bitmap("res/head.png")

            Catch e As Exception
                Console.WriteLine(e.Message)
                Environment.Exit(1)
            End Try

            Me.InitGame()

        End Sub


        Private Sub InitGame()

            dots = 3

            For z As Integer = 0 To dots - 1
                x(z) = 50 - z * 10
                y(z) = 50
            Next

            Me.LocateApple()

            AddHandler Me.KeyUp, AddressOf Me.OnKeyUp

            timer = New Timer(Me.components)
            timer.Enabled = True
            timer.Interval = DELAY

            AddHandler timer.Tick, AddressOf Me.OnTick
            AddHandler Me.Paint, AddressOf Me.OnPaint

        End Sub


        Private Sub OnPaint(ByVal sender As Object,
                            ByVal e As PaintEventArgs)

            Dim g As Graphics = e.Graphics

            If inGame Then
                Me.DrawObjects(g)
            Else
                Me.GameOver(g)
            End If

        End Sub

        Private Sub DrawObjects(ByVal g As Graphics)
            g.DrawImage(apple, apple_x, apple_y)

            For z As Integer = 0 To dots - 1
                If z = 0 Then
                    g.DrawImage(head, x(z), y(z))
                Else
                    g.DrawImage(dot, x(z), y(z))
                End If
            Next
        End Sub

        Private Sub GameOver(ByVal g As Graphics)

            Dim msg As String = "Game Over"
            Dim rectF As RectangleF = RectangleF.op_Implicit(Me.ClientRectangle)

            Dim format As New StringFormat
            format.Alignment = StringAlignment.Center
            format.LineAlignment = StringAlignment.Center

            g.DrawString(msg, Font, Brushes.White, rectF, format)
            timer.Stop()

        End Sub


        Private Sub CheckApple()

            If x(0) = apple_x And y(0) = apple_y Then

                dots += 1
                Me.LocateApple()

            End If

        End Sub

        Private Sub Move()

            For z As Integer = dots To 1 Step -1
                x(z) = x(z - 1)
                y(z) = y(z - 1)
            Next

            If left Then
                x(0) -= DOT_SIZE
            End If

            If right Then
                x(0) += DOT_SIZE
            End If

            If up Then
                y(0) -= DOT_SIZE
            End If

            If down Then
                y(0) += DOT_SIZE
            End If

        End Sub


        Private Sub CheckCollision()

            For z As Integer = dots To 1 Step -1
                If z > 4 And x(0) = x(z) And y(0) = y(z) Then
                    inGame = False
                End If
            Next

            If y(0) >= HEIGHT - DOT_SIZE - TITLEBAR_HEIGHT Then
                inGame = False
            End If

            If y(0) < 0 Then
                inGame = False
            End If

            If x(0) >= WIDTH - DOT_SIZE - BORDER_WIDTH Then
                inGame = False
            End If

            If x(0) < 0 Then
                inGame = False
            End If

        End Sub


        Private Sub LocateApple()

            Dim rand As New Random

            Dim r As Integer = rand.Next(RAND_POS)

            apple_x = r * DOT_SIZE
            r = rand.Next(RAND_POS)
            apple_y = r * DOT_SIZE


        End Sub



        Private Sub OnTick(ByVal sender As Object, ByVal e As EventArgs)

            If inGame Then
                Me.CheckApple()
                Me.CheckCollision()
                Me.Move()
            End If

            Me.Refresh()

        End Sub


        Private Sub OnKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)

            Dim key As Integer = e.KeyCode

            If key = Keys.Left And Not right Then
                left = True
                up = False
                down = False
            End If

            If key = Keys.Right And Not left Then
                right = True
                up = False
                down = False
            End If

            If key = Keys.Up And Not down Then
                up = True
                right = False
                left = False
            End If

            If key = Keys.Down And Not up Then
                down = True
                right = False
                left = False
            End If

        End Sub

    End Class

End Namespace