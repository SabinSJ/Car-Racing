Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim st As New Drawing2D.GraphicsPath
        Dim his As New Drawing2D.GraphicsPath
        Dim ex As New Drawing2D.GraphicsPath

        st.StartFigure()
        st.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        st.AddLine(20, 0, start_butt.Width - 20, 0)
        st.AddArc(New Rectangle(start_butt.Width - 20, 0, 20, 20), -90, 90)
        st.AddLine(start_butt.Width, 20, start_butt.Width, start_butt.Height - 20)
        st.AddArc(New Rectangle(start_butt.Width - 20, start_butt.Height - 20, 20, 20), 0, 90)
        st.AddLine(start_butt.Width - 20, start_butt.Height, 20, start_butt.Height)
        st.AddArc(New Rectangle(0, start_butt.Height - 20, 20, 20), 90, 90)
        st.CloseFigure()
        start_butt.Region = New Region(st)

        his.StartFigure()
        his.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        his.AddLine(20, 0, hist_butt.Width - 20, 0)
        his.AddArc(New Rectangle(hist_butt.Width - 20, 0, 20, 20), -90, 90)
        his.AddLine(hist_butt.Width, 20, hist_butt.Width, hist_butt.Height - 20)
        his.AddArc(New Rectangle(hist_butt.Width - 20, hist_butt.Height - 20, 20, 20), 0, 90)
        his.AddLine(hist_butt.Width - 20, hist_butt.Height, 20, hist_butt.Height)
        his.AddArc(New Rectangle(0, hist_butt.Height - 20, 20, 20), 90, 90)
        his.CloseFigure()
        hist_butt.Region = New Region(his)

        ex.StartFigure()
        ex.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        ex.AddLine(20, 0, exit_butt.Width - 20, 0)
        ex.AddArc(New Rectangle(exit_butt.Width - 20, 0, 20, 20), -90, 90)
        ex.AddLine(exit_butt.Width, 20, exit_butt.Width, exit_butt.Height - 20)
        ex.AddArc(New Rectangle(exit_butt.Width - 20, exit_butt.Height - 20, 20, 20), 0, 90)
        ex.AddLine(exit_butt.Width - 20, exit_butt.Height, 20, exit_butt.Height)
        ex.AddArc(New Rectangle(0, exit_butt.Height - 20, 20, 20), 90, 90)
        ex.CloseFigure()
        exit_butt.Region = New Region(ex)
    End Sub

    Private Sub start_butt_Click(sender As Object, e As EventArgs) Handles start_butt.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub exit_butt_Click(sender As Object, e As EventArgs) Handles exit_butt.Click
        Me.Close()
    End Sub
End Class