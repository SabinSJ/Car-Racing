Imports Microsoft.VisualBasic

Public Class Class1
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
End Class

'  linia 4 - 30 -> Sarca Florin-Sabin