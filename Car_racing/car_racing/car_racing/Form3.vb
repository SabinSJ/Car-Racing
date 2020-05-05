Public Class Form3
    Private Sub Start_button_Click(sender As Object, e As EventArgs) Handles Start_button.Click
        List_Player.Items.Add(Enter_Name.Text)

        If Enter_Name.Text = Nothing Then
            Form4.Show()
        Else
            Form1.Show()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class