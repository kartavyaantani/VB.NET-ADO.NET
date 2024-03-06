Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DateTimePicker1.Value = DateTimePicker1.Value.AddDays(TextBox1.Text)
    End Sub
End Class
