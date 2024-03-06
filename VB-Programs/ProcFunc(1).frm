VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   1185
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   2640
   LinkTopic       =   "Form1"
   ScaleHeight     =   1185
   ScaleWidth      =   2640
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdTest 
      Caption         =   "Test......"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   24
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2415
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdTest_Click()
    Dim x As Integer, y As Integer
    Dim ans As Integer
    x = InputBox("Enter start value:")
    y = InputBox("Enter stop value:")
    Call sumodd(x, y) 'Procedure call
    ans = big2(x, y) 'Function call
    MsgBox "Bigger no =" & ans
End Sub
Private Sub sumodd(a As Integer, b As Integer)
    Dim i As Integer, sum As Integer
    For i = a To b
        If i Mod 2 = 1 Then
            sum = sum + i
        End If
    Next i
    MsgBox "Sum of Odd no. = " & sum
    
End Sub

Private Function big2(a As Integer, b As Integer) As Integer
    If a > b Then
        big2 = a
    Else
        big2 = b
    End If
End Function
