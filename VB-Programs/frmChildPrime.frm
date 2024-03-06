VERSION 5.00
Begin VB.Form frmChildPrime 
   Caption         =   "Prime Number"
   ClientHeight    =   3090
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   Begin VB.CommandButton cmdCheck 
      Caption         =   "Check For Prime"
      Height          =   735
      Left            =   1800
      TabIndex        =   2
      Top             =   1680
      Width           =   1575
   End
   Begin VB.TextBox txtNo 
      Alignment       =   1  'Right Justify
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1920
      TabIndex        =   0
      Top             =   120
      Width           =   1575
   End
   Begin VB.Label Label1 
      Caption         =   "Enter No. :"
      Height          =   735
      Left            =   240
      TabIndex        =   1
      Top             =   240
      Width           =   1215
   End
End
Attribute VB_Name = "frmChildPrime"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdCheck_Click()
    Dim i As Integer
    
    For i = 2 To txtNo.Text - 1
        If txtNo.Text Mod i = 0 Then
            MsgBox "Not Prime", vbCritical
            Unload Me
            Exit Sub
        End If
    Next i
    MsgBox "Prime Number", vbInformation
End Sub
