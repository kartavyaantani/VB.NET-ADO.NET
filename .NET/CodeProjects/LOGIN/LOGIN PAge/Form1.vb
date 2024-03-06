Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "Password" Then
            MsgBox("Login Successful")
        Else
            MsgBox("Login Unsuccessful")
        End If
    End Sub
End Class
