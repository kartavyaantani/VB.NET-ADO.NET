Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ts As TimeSpan = DateTime.Now.Date - DateTimePicker1.Value
        Label3.Text = String.Format("{0:n0}", (ts.TotalDays / 365))
    End Sub
End Class
