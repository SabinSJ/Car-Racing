Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class Form1

    Dim speed As Integer
    Dim road(12) As PictureBox
    Dim score As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rsg As New Drawing2D.GraphicsPath
        Dim exg As New Drawing2D.GraphicsPath

        rsg.StartFigure()
        rsg.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        rsg.AddLine(10, 0, rest_game.Width - 20, 0)
        rsg.AddArc(New Rectangle(rest_game.Width - 10, 0, 10, 10), -90, 90)
        rsg.AddLine(rest_game.Width, 20, rest_game.Width, rest_game.Height - 10)
        rsg.AddArc(New Rectangle(rest_game.Width - 10, rest_game.Height - 10, 10, 10), 0, 90)
        rsg.AddLine(rest_game.Width - 10, rest_game.Height, 20, rest_game.Height)
        rsg.AddArc(New Rectangle(0, rest_game.Height - 10, 10, 10), 90, 90)
        rsg.CloseFigure()
        rest_game.Region = New Region(rsg)

        exg.StartFigure()
        exg.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        exg.AddLine(10, 0, Ex_game.Width - 20, 0)
        exg.AddArc(New Rectangle(Ex_game.Width - 10, 0, 10, 10), -90, 90)
        exg.AddLine(Ex_game.Width, 20, Ex_game.Width, Ex_game.Height - 10)
        exg.AddArc(New Rectangle(Ex_game.Width - 10, Ex_game.Height - 10, 10, 10), 0, 90)
        exg.AddLine(Ex_game.Width - 10, Ex_game.Height, 20, Ex_game.Height)
        exg.AddArc(New Rectangle(0, Ex_game.Height - 10, 10, 10), 90, 90)
        exg.CloseFigure()
        Ex_game.Region = New Region(exg)

        My.Computer.Audio.Play("C:\Users\Zaharia Andrei\Documents\GitHub\Car-Racing\Car_racing\car_racing\car_racing\Sounds\music.wav")
        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
        road(8) = PictureBox9
        road(9) = PictureBox10
        road(10) = PictureBox11
        road(11) = PictureBox12
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            right_mover.Start()
        End If
        If e.KeyCode = Keys.Left Then
            left_mover.Start()
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        right_mover.Stop()
        left_mover.Stop()
    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 11
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        If (player_car.Bounds.IntersectsWith(enemy.Bounds)) Then
            gameover()
        End If
        If (player_car.Bounds.IntersectsWith(enemy1.Bounds)) Then
            gameover()
        End If
        If (player_car.Bounds.IntersectsWith(enemy2.Bounds)) Then
            gameover()
        End If
        speed_incrs.Text = "speed " & speed
        If score > 10 And score < 20 Then
            speed = 5
        End If
        If score > 20 And score < 30 Then
            speed = 6
        End If
        If score > 35 Then
            speed = 7
        End If

    End Sub

    Private Sub enemy_mover_Tick(sender As Object, e As EventArgs) Handles enemy_mover.Tick
        enemy.Top += speed
        If enemy.Top >= Me.Height Then
            score += 1
            table_score.Text = "score " & score
            enemy.Top = -(CInt(Math.Ceiling(Rnd() * 175)) + enemy1.Height)
            enemy.Left = CInt(Math.Ceiling(Rnd() * 50) + 83)
        End If
    End Sub

    Private Sub enemy1_mover_Tick(sender As Object, e As EventArgs) Handles enemy1_mover.Tick
        enemy1.Top += speed / 2
        If enemy1.Top >= Me.Height Then
            score += 1
            table_score.Text = "score " & score
            enemy1.Top = -(CInt(Math.Ceiling(Rnd() * 175)) + enemy1.Height)
            enemy1.Left = CInt(Math.Ceiling(Rnd() * 50) + 150)
        End If
    End Sub

    Private Sub enemy2_mover_Tick(sender As Object, e As EventArgs) Handles enemy2_mover.Tick
        enemy2.Top += speed * 1.5
        If enemy2.Top >= Me.Height Then
            score += 1
            table_score.Text = "score " & score
            enemy2.Top = -(CInt(Math.Ceiling(Rnd() * 175)) + enemy1.Height)
            enemy2.Left = CInt(Math.Ceiling(Rnd() * 40) + 190)
        End If
    End Sub

    Private Sub left_mover_Tick(sender As Object, e As EventArgs) Handles left_mover.Tick
        If (player_car.Location.X > 65) Then
            player_car.Left -= 5
        End If
    End Sub

    Private Sub right_mover_Tick(sender As Object, e As EventArgs) Handles right_mover.Tick
        If (player_car.Location.X < 229) Then
            player_car.Left += 5
        End If
    End Sub

    Private Sub gameover()
        My.Computer.Audio.Play("C:\Users\Zaharia Andrei\Documents\GitHub\Car-Racing\Car_racing\car_racing\car_racing\Sounds\car_crash.wav")
        Ex_game.Visible = True
        rest_game.Visible = True
        end_game.Visible = True
        enemy1_mover.Stop()
        enemy2_mover.Stop()
        enemy_mover.Stop()
        RoadMover.Stop()
    End Sub

    Private Sub rest_game_MouseDown(sender As Object, e As MouseEventArgs) Handles rest_game.MouseDown
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub

    Private Sub Ex_game_MouseDown(sender As Object, e As MouseEventArgs) Handles Ex_game.MouseDown
        Me.Close()
        Form2.Close()
    End Sub

    Private Sub Pause_game_Tick(sender As Object, e As EventArgs) Handles Pause_game.Tick
        RoadMover.Stop()
        enemy1_mover.Stop()
        enemy2_mover.Stop()
        enemy_mover.Stop()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub cont_butt_MouseDown(sender As Object, e As MouseEventArgs) Handles cont_butt.MouseDown
        paused_text.Visible = False
        Pause_game.Enabled = False
        cont_butt.Visible = False
        Ext_butt.Visible = False

        My.Computer.Audio.Play("C:\Users\Zaharia Andrei\Documents\GitHub\Car-Racing\Car_racing\car_racing\car_racing\Sounds\music.wav")

        RoadMover.Start()
        enemy1_mover.Start()
        enemy2_mover.Start()
        enemy_mover.Start()
    End Sub

    Private Sub Ext_butt_MouseDown(sender As Object, e As MouseEventArgs) Handles Ext_butt.MouseDown
        Me.Close()
        Form2.Close()
    End Sub

    Private Sub paused_game_MouseDown(sender As Object, e As MouseEventArgs) Handles paused_game.MouseDown
        paused_text.Visible = True
        Pause_game.Enabled = True
        cont_butt.Visible = True
        Ext_butt.Visible = True
    End Sub
End Class