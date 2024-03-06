Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Timer1.Interval = 100
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblMilliSeconds.Text = lblMilliSeconds.Text + 1
        If lblMilliSeconds.Text = 10 Then
            lblSeconds.Text = lblSeconds.Text + 1
            lblMilliSeconds.Text = 0
            If lblSeconds.Text = 60 Then
                lblSeconds.Text = "00"
                lblMinutes.Text = lblMinutes.Text + 1
                If lblMinutes.Text = 60 Then
                    lblMinutes.Text = "00"
                    lblHours.Text = lblHours.Text + 1
                    If lblHours.Text = 24 Then
                        lblHours.Text = "00"
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblMinutes.Text = "00"
        lblSeconds.Text = "00"
        lblMinutes.Text = "00"
        lblHours.Text = "00"
        lblMilliSeconds.Text = "00"
    End Sub
End Class
