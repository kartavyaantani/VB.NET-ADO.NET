Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If optMale.Checked = False And optFemale.Checked = False Then
            MsgBox("YOU HAVE NOT SELECTED Gender CODE")

        ElseIf optMale.Checked Then
            MsgBox("Gender Code : MALE")

        ElseIf optFemale.Checked Then
            MsgBox("Gender Code : FEMALE")
        End If

        If chkNature.Checked = False And chkReading.Checked = False And chkComputer.Checked = False Then
            MsgBox("YOU HAVE NOT SELECTED ANY HOBBY")
        Else
            If chkNature.Checked = True Then
                MsgBox("Your Hobby is : NATURE")
            End If
            If chkReading.Checked = True Then
                MsgBox("Your Hobby is : READING")
            End If
            If chkComputer.Checked = True Then
                MsgBox("Your Hobby is : COMPUTER")
            End If
        End If
    End Sub
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        optMale.Checked = False
        optFemale.Checked = False
    End Sub
End Class



