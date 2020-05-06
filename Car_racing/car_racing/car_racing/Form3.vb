Public Class Form3
    Private Sub Start_button_Click(sender As Object, e As EventArgs) Handles Start_button.Click
        List_Player.Items.Add(Enter_Name.Text)

        If Enter_Name.Text = Nothing Then
            Form4.Show()
        Else
            Form1.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles back_butt.Click
        Form2.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim play As New Drawing2D.GraphicsPath
        Dim bk As New Drawing2D.GraphicsPath

        play.StartFigure()
        play.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        play.AddLine(20, 0, Start_button.Width - 20, 0)
        play.AddArc(New Rectangle(Start_button.Width - 20, 0, 20, 20), -90, 90)
        play.AddLine(Start_button.Width, 20, Start_button.Width, Start_button.Height - 20)
        play.AddArc(New Rectangle(Start_button.Width - 20, Start_button.Height - 20, 20, 20), 0, 90)
        play.AddLine(Start_button.Width - 20, Start_button.Height, 20, Start_button.Height)
        play.AddArc(New Rectangle(0, Start_button.Height - 20, 20, 20), 90, 90)
        play.CloseFigure()
        Start_button.Region = New Region(play)

        bk.StartFigure()
        bk.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        bk.AddLine(20, 0, back_butt.Width - 20, 0)
        bk.AddArc(New Rectangle(back_butt.Width - 20, 0, 20, 20), -90, 90)
        bk.AddLine(back_butt.Width, 20, back_butt.Width, back_butt.Height - 20)
        bk.AddArc(New Rectangle(back_butt.Width - 20, back_butt.Height - 20, 20, 20), 0, 90)
        bk.AddLine(back_butt.Width - 20, back_butt.Height, 20, back_butt.Height)
        bk.AddArc(New Rectangle(0, back_butt.Height - 20, 20, 20), 90, 90)
        bk.CloseFigure()
        back_butt.Region = New Region(bk)
    End Sub
End Class