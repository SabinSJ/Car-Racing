Public Class car_racing

    Dim speed As Integer
    Dim road(12) As PictureBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 11
            road(x).Top += 2
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next

    End Sub

    Private Sub enemy_mover_Tick(sender As Object, e As EventArgs) Handles enemy_mover.Tick
        enemy.Top += 1.5
        If enemy.Top >= Me.Height Then
            enemy.Top = -(CInt(Math.Ceiling(Rnd() * 175)) + enemy1.Height)
            enemy.Left = CInt(Math.Ceiling(Rnd() * 220)) + 10
        End If
    End Sub

    Private Sub enemy1_mover_Tick(sender As Object, e As EventArgs) Handles enemy1_mover.Tick
        enemy1.Top += 2.25
        If enemy1.Top >= Me.Height Then
            enemy1.Top = -(CInt(Math.Ceiling(Rnd() * 175)) + enemy1.Height)
            enemy1.Left = CInt(Math.Ceiling(Rnd() * 100)) + 45
        End If
    End Sub

    Private Sub enemy2_mover_Tick(sender As Object, e As EventArgs) Handles enemy2_mover.Tick
        enemy2.Top += 3
        If enemy2.Top >= Me.Height Then
            enemy2.Top = -(CInt(Math.Ceiling(Rnd() * 175)) + enemy1.Height)
            enemy2.Left = CInt(Math.Ceiling(Rnd() * 40)) + 185
        End If
    End Sub

End Class

'  linia 1 - 29 -> Sarca Florin-Sabin
'  linia 31 - 59 -> Zaharia Andrei