Public Class Form1
    Private Sub btnAddToListBox_Click(sender As Object, e As EventArgs) Handles btnAddToListBox.Click
        If txtItemName.Text = "" Then
            MsgBox("No Item to Add")
            Exit Sub
        End If
        lstItem.Items.Add(txtItemName.Text)
        txtItemName.Text = ""
    End Sub

    Private Sub btnAddToComboBox_Click(sender As Object, e As EventArgs) Handles btnAddToComboBox.Click
        If txtItemName.Text = "" Then
            MsgBox("No Item to Add")
            Exit Sub
        End If
        comItem.Items.Add(txtItemName.Text)
        txtItemName.Text = ""
    End Sub

    Private Sub btnMoveFromListToCombo_Click(sender As Object, e As EventArgs) Handles btnMoveFromListToCombo.Click
        If lstItem.Items.Count = 0 Then
            MsgBox("Empty List Box")
            Exit Sub
        End If
        If lstItem.SelectedIndex = -1 Then
            MsgBox("Item Is Not Selected")
            Exit Sub
        End If
        comItem.Items.Add(lstItem.Items.Item(lstItem.SelectedIndex))
        lstItem.Items.Remove(lstItem.Items.Item(lstItem.SelectedIndex))
    End Sub

    Private Sub btnMoveFromComboToList_Click(sender As Object, e As EventArgs) Handles btnMoveFromComboToList.Click
        If comItem.Items.Count = 0 Then
            MsgBox("Empty Combo Box")
            Exit Sub
        End If
        If comItem.SelectedIndex = -1 Then
            MsgBox("Item Is Not Selected")
            Exit Sub
        End If
        lstItem.Items.Add(comItem.Items.Item(comItem.SelectedIndex))
        comItem.Items.Remove(comItem.Items.Item(comItem.SelectedIndex))

    End Sub

    Private Sub btnClearListBox_Click(sender As Object, e As EventArgs) Handles btnClearListBox.Click
        lstItem.Items.Clear()
    End Sub

    Private Sub btnClearComboBox_Click(sender As Object, e As EventArgs) Handles btnClearComboBox.Click
        comItem.Items.Clear()
    End Sub
End Class
