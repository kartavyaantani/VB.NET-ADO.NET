Public Class Form1
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If (txtPrice.Text = "" Or txtItemName.Text = "") Then
            MessageBox.Show("Please enter Item Name OR Price", "No entry",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        txtItemName.Focus()

        If IsNumeric(txtPrice.Text) Then
            lstFoodName.Items.Add(txtItemName.Text)
            lstPrice.Items.Add(txtPrice.Text)
        Else
            MessageBox.Show("Please enter Numeric Value", "No entry",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        txtPrice.Clear()
        txtItemName.Clear()

    End Sub

    Private Sub lstFoodName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFoodName.SelectedIndexChanged
        lstPrice.SelectedIndex = lstFoodName.SelectedIndex
    End Sub
    Private Sub lstPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrice.SelectedIndexChanged
        lstFoodName.SelectedIndex = lstPrice.SelectedIndex
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim x As Object
        x = lstPrice.SelectedItem * txtQty.Text

        If ComboBox1.SelectedIndex = 0 Then
            x = x - (x * 0.15)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            x = x - (x * 0.1)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            x = x - (x * 0.05)
        ElseIf ComboBox1.SelectedIndex = 3 Then
            x = x - (x * 0.02)
        End If

        If CheckBox1.Checked Then
            x = x - (x * (txtGeneral.Text / 100))
        ElseIf CheckBox2.Checked Then
            x = x - (x * (txtSpecial.Text / 100))
        End If

        lstItem.Items.Add(lstFoodName.SelectedItem)
        lstBillAmt.Items.Add(x)

    End Sub

    Private Sub btnCalcBill_Click(sender As Object, e As EventArgs) Handles btnCalcBill.Click
        If lstBillAmt.Items.Count = 0 Then
            MessageBox.Show("NO ORDER!", "No entry",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim i As Integer
        Dim totbill As Single
        For i = 0 To lstBillAmt.Items.Count - 1
            totbill = totbill + (lstBillAmt.Items(i))
        Next
        Label5.Text = totbill

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If lstFoodName.SelectedIndex = -1 Then
            MessageBox.Show("Nothing to modify", "No entry",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim temp As Integer
        temp = InputBox("Enter New Price")
        lstPrice.Items(lstPrice.SelectedIndex) = temp

    End Sub
End Class
