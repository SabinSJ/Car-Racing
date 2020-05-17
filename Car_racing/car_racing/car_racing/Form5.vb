Public Class Form5

    Dim SQL As New SQL_Control

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Sql.HasConnection = True Then
            Sql.RunQuery("Select * from rank")

            If SQL.SQLDataSet.Tables.Count > 0 Then
                dataView.DataSource = SQL.SQLDataSet.Tables(0)
            End If

            dataView.Sort(dataView.Columns(2), System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Back_butt_Click(sender As Object, e As EventArgs) Handles Back_butt.Click
        Dim back As New Drawing2D.GraphicsPath

        back.StartFigure()
        back.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        back.AddLine(20, 0, Back_butt.Width - 20, 0)
        back.AddArc(New Rectangle(Back_butt.Width - 20, 0, 20, 20), -90, 90)
        back.AddLine(Back_butt.Width, 20, Back_butt.Width, Back_butt.Height - 20)
        back.AddArc(New Rectangle(Back_butt.Width - 20, Back_butt.Height - 20, 20, 20), 0, 90)
        back.AddLine(Back_butt.Width - 20, Back_butt.Height, 20, Back_butt.Height)
        back.AddArc(New Rectangle(0, Back_butt.Height - 20, 20, 20), 90, 90)
        back.CloseFigure()
        Back_butt.Region = New Region(back)

        Form2.Show()
        Me.Close()

    End Sub
End Class