Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call login_server(TB_User.Text, TB_Password.Text, TB_Server.Text, TB_Database.Text)

    End Sub
End Class
