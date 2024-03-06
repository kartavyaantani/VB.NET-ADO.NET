VERSION 5.00
Begin VB.Form frmFileStudy 
   Caption         =   "File :)"
   ClientHeight    =   3390
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   9915
   LinkTopic       =   "Form1"
   ScaleHeight     =   3390
   ScaleWidth      =   9915
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdRead 
      Caption         =   "Process File"
      Height          =   1095
      Left            =   1920
      TabIndex        =   1
      Top             =   2040
      Width           =   1575
   End
   Begin VB.CommandButton cmdWrite 
      Caption         =   "Create File"
      Height          =   1095
      Left            =   120
      TabIndex        =   0
      Top             =   2040
      Width           =   1695
   End
End
Attribute VB_Name = "frmFileStudy"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
    Dim nm As String * 10, dob As Date, basic As Integer

Private Sub cmdRead_Click()
    Open "c:\Sample.dat" For Input As #2
    frmFileStudy.FontSize = 12
    While (Not EOF(2))
        Input #2, nm, dob, basic
        bonus = basic * 10 / 100
        Print nm, dob, basic, bonus
    Wend
    Close #2
End Sub

Private Sub cmdWrite_Click()
    Open "c:\Sample.dat" For Output As #1
rpt:     nm = InputBox("Enter name: ")
    dob = InputBox("Enter Date of Birth: ")
    basic = InputBox("Enter Basic pay: ")
    Write #1, nm, dob, basic
    ans = MsgBox("More Records?", vbYesNo)
    If ans = vbYes Then
        GoTo rpt
    End If
    Close #1
End Sub

