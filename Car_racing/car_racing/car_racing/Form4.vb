Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Ok_butt.Click
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim OK As New Drawing2D.GraphicsPath
        OK.StartFigure()
        OK.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        OK.AddLine(20, 0, Ok_butt.Width - 20, 0)
        OK.AddArc(New Rectangle(Ok_butt.Width - 20, 0, 20, 20), -90, 90)
        OK.AddLine(Ok_butt.Width, 20, Ok_butt.Width, Ok_butt.Height - 20)
        OK.AddArc(New Rectangle(Ok_butt.Width - 20, Ok_butt.Height - 20, 20, 20), 0, 90)
        OK.AddLine(Ok_butt.Width - 20, Ok_butt.Height, 20, Ok_butt.Height)
        OK.AddArc(New Rectangle(0, Ok_butt.Height - 20, 20, 20), 90, 90)
        OK.CloseFigure()
        Ok_butt.Region = New Region(OK)
    End Sub
End Class