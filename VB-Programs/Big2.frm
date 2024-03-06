VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H00FFC0C0&
   Caption         =   "Form1"
   ClientHeight    =   3480
   ClientLeft      =   5895
   ClientTop       =   3360
   ClientWidth     =   4605
   LinkTopic       =   "Form1"
   ScaleHeight     =   3480
   ScaleWidth      =   4605
   Begin VB.TextBox txtNo2 
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
      TabIndex        =   2
      Top             =   1080
      Width           =   2415
   End
   Begin VB.TextBox txtNo1 
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
      TabIndex        =   1
      Top             =   240
      Width           =   2415
   End
   Begin VB.CommandButton cmdFindBig 
      Caption         =   "OK"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   2040
      TabIndex        =   0
      Top             =   2280
      Width           =   2295
   End
   Begin VB.Label Label2 
      Caption         =   "Enter Second No. :"
      Height          =   615
      Left            =   240
      TabIndex        =   4
      Top             =   1080
      Width           =   1575
   End
   Begin VB.Label Label1 
      Caption         =   "Enter First No. :"
      Height          =   495
      Left            =   240
      TabIndex        =   3
      Top             =   240
      Width           =   1455
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub cmdFindBig_Click()
    If Val(txtNo1.Text) > Val(txtNo2.Text) Then
        MsgBox txtNo1.Text & " Is Big"
    Else
        MsgBox txtNo2.Text & " Is Big"
    End If
    
End Sub
