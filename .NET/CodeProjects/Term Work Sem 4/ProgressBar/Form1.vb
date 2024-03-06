Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 5
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Enabled = False
        End If
        Label2.Text = Label2.Text + 5

    End Sub

End Class
