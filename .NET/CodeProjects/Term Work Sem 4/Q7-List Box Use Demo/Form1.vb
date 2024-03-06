Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtNumber.Text = "" Then
            MsgBox("Please Enter Number")
            Exit Sub
        End If
        lstNumber.Items.Add(txtNumber.Text)
        txtNumber.Text = ""
        txtNumber.Focus()
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        If lstNumber.Items.Count = 0 Then
            MsgBox("Empty List Box")
            Exit Sub
        End If

        Dim sum As Integer = 0
        For i = 0 To lstNumber.Items.Count - 1
            sum = sum + lstNumber.Items.Item(i)
        Next i

        txtAnswer.Text = sum

    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        If lstNumber.Items.Count = 0 Then
            MsgBox("Empty List Box")
            Exit Sub
        End If

        Dim sum As Integer = 0, av As Single
        For i = 0 To lstNumber.Items.Count - 1
            sum = sum + lstNumber.Items.Item(i)
        Next i
        av = sum / lstNumber.Items.Count
        txtAnswer.Text = av
    End Sub

    Private Sub btnBiggestNumber_Click(sender As Object, e As EventArgs) Handles btnBiggestNumber.Click
        If lstNumber.Items.Count = 0 Then
            MsgBox("Empty List Box")
            Exit Sub
        End If
        Dim Big As Integer, Tmp As Integer
        Big = lstNumber.Items.Item(0)
        For i = 1 To lstNumber.Items.Count - 1
            Tmp = lstNumber.Items.Item(i)
            If Big < Tmp Then
                Big = Tmp
            End If
        Next
        txtAnswer.Text = Big

    End Sub
End Class
