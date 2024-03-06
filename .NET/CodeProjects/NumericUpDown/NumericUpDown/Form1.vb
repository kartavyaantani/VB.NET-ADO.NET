Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Label1.Text = TextBox1.Text + TextBox2.Text
        ElseIf RadioButton2.Checked Then
            Label1.Text = TextBox1.Text - TextBox2.Text
        ElseIf RadioButton3.Checked Then
            Label1.Text = TextBox1.Text * TextBox2.Text
        ElseIf RadioButton4.Checked Then
            Label1.Text = TextBox1.Text / TextBox2.Text
        Else
            MsgBox("Please Specify Operation")
        End If

    End Sub
End Class
