Public Class Form3
    Private Sub Start_button_Click(sender As Object, e As EventArgs) Handles Start_button.Click
        List_Player.Items.Add(Enter_Name.Text)

        If Enter_Name.Text = Nothing Then
            error_name.Visible = True
        Else
            Form1.Show()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class