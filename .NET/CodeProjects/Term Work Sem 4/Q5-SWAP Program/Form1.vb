Public Class Form1
    Private Sub btnSwap_Click(sender As Object, e As EventArgs) Handles btnSwap.Click
        Dim Tmp As Single
        If txtNo1.Text = "" Or txtNo2.Text = "" Then
            MsgBox("Empty Text Box ... Can Not Swap")
            Exit Sub
        End If


        Tmp = txtNo1.Text
        txtNo1.Text = txtNo2.Text
        txtNo2.Text = Tmp
    End Sub
End Class
