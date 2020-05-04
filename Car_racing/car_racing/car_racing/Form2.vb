Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub start_butt_Click(sender As Object, e As EventArgs) Handles start_butt.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub exit_butt_Click(sender As Object, e As EventArgs) Handles exit_butt.Click
        Me.Close()
    End Sub
End Class