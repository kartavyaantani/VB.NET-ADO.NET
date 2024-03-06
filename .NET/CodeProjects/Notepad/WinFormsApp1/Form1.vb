Imports System.IO
Public Class Form1
    Dim url As String
    Dim ind As Byte = 0
    Private Sub NEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("SAVE WORK .....?", "SAVE.FILE.DIALOGUE", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            Me.Show()
        ElseIf result = DialogResult.No Then
            RichTextBox1.Clear()
        ElseIf result = DialogResult.Yes Then
            SaveFileDialog1.ShowDialog()
            RichTextBox1.SaveFile(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UNDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UNDOToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub REDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REDOToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
        End If
    End Sub

    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click

        If RichTextBox1.Modified = True Then
            Dim ask As MsgBoxResult
            ask = MsgBox("Save Files...", MsgBoxStyle.YesNoCancel, "Open Document")
            If MsgBoxResult.No Then
                OpenFileDialog1.ShowDialog()
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            ElseIf ask = MsgBoxResult.cancel Then
            ElseIf ask = MsgBoxResult.Yes Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
                RichTextBox1.Clear()
            End If
        Else
            OpenFileDialog1.ShowDialog()
            Try
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            Catch ex As Exception
                MsgBox("Open Exception")
            End Try
        End If

    End Sub

    Private Sub COPYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COPYToolStripMenuItem.Click
        If RichTextBox1.SelectionLength > 0 Then
            RichTextBox1.Copy()
        End If
    End Sub

    Private Sub CUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUTToolStripMenuItem.Click
        If RichTextBox1.SelectionLength > 0 Then
            RichTextBox1.Cut()
        End If
    End Sub

    Private Sub PASTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PASTEToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        RichTextBox1.SelectedText = " "
    End Sub

    Private Sub SELECTALLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTALLToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub TIMEDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TIMEDATEToolStripMenuItem.Click
        RichTextBox1.SelectedText = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")
    End Sub

    Private Sub FONTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FONTToolStripMenuItem.Click
        FontDialog1.Font = RichTextBox1.Font
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub COLOURToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COLOURToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    Private Sub LEFTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LEFTToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub RIGHTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RIGHTToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub CENTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CENTERToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub YESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YESToolStripMenuItem.Click
        RichTextBox1.SelectionBullet = True
    End Sub

    Private Sub NOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NOToolStripMenuItem.Click
        RichTextBox1.SelectionBullet = False
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        MsgBox("!!!Notepad Created By Kartavya Antani!!!")
        MsgBox("Enrollment NO: 206250307001")
    End Sub

    Private Sub FINDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FINDToolStripMenuItem.Click
        Dim a As String
        Dim b As String
        a = InputBox("Enter text to be found")
        b = InStr(RichTextBox1.Text, a)
        If b Then
            RichTextBox1.Focus()
            RichTextBox1.SelectionStart = b - 1
            RichTextBox1.SelectionLength = Len(a)
        Else
            MsgBox("Text Not Found")
        End If

    End Sub

    Private Sub BACKGROUNDCOLOURToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKGROUNDCOLOURToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub PRINTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRINTToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub
End Class
