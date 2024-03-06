VERSION 5.00
Begin VB.Form frmCalc 
   BackColor       =   &H00C0FFFF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "My Calculator - By Kartavya Antani"
   ClientHeight    =   5445
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   4065
   Icon            =   "MyCalc.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5445
   ScaleWidth      =   4065
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdEqual 
      Caption         =   "="
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   24
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   720
      TabIndex        =   15
      Top             =   4200
      Width           =   2655
   End
   Begin VB.CommandButton cmdOp 
      Caption         =   "/"
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
      Index           =   3
      Left            =   2760
      TabIndex        =   14
      Top             =   3360
      Width           =   615
   End
   Begin VB.CommandButton cmdOp 
      Caption         =   "*"
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
      Index           =   2
      Left            =   2760
      TabIndex        =   13
      Top             =   2760
      Width           =   615
   End
   Begin VB.CommandButton cmdOp 
      Caption         =   "-"
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
      Index           =   1
      Left            =   2760
      TabIndex        =   12
      Top             =   2160
      Width           =   615
   End
   Begin VB.CommandButton cmdOp 
      Caption         =   "+"
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
      Index           =   0
      Left            =   2760
      TabIndex        =   11
      Top             =   1560
      Width           =   615
   End
   Begin VB.CommandButton cmdDigit 
      Caption         =   "9"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   9
      Left            =   1920
      TabIndex        =   10
      Top             =   1560
      Width           =   495
   End
   Begin VB.CommandButton cmdDigit 
      Caption         =   "8"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   8
      Left            =   1320
      TabIndex        =   9
      Top             =   1560
      Width           =   495
   End
   Begin VB.CommandButton cmdDigit 
      Caption         =   "7"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   7
      Left            =   720
      TabIndex        =   8
      Top             =   1560
      Width           =   495
   End
   Begin VB.CommandButton cmdDigit 
      Caption         =   "6"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   6
      Left            =   1920
      TabIndex        =   7
      Top             =   2160
      Width           =   495
   End
   Begin VB.CommandButton cmdDigit 
      Caption         =   "5"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   5
      Left            =   1320
      TabIndex        =   6
      Top             =   2160
      Width           =   495
   End
   Begin VB.CommandButton cmdDigit 
      Caption         =   "4"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   4
      Left            =   720
      TabIndex        =   5
      Top             =   2160
      Width           =   495
   End
   Begin VB.CommandButton cmdDigit 
      Caption         =   "3"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   3
      Left            =   1920
      TabIndex        =   4
      Top             =   2760
      Width           =   495
   End
   Begin VB.CommandButton cmdDigit 
      Caption         =   "2"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   2
      Left            =   1320
      TabIndex        =   3
      Top             =   2760
      Width           =   495
   End
   Begin VB.CommandButton cmdDigit 
      Caption         =   "1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   1
      Left            =   720
      TabIndex        =   2
      Top             =   2760
      Width           =   495
   End
   Begin VB.CommandButton cmdDigit 
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   0
      Left            =   1320
      TabIndex        =   1
      Top             =   3480
      Width           =   495
   End
   Begin VB.TextBox txtNo 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00C0C0FF&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   615
      Left            =   480
      Locked          =   -1  'True
      TabIndex        =   0
      Text            =   "0"
      Top             =   480
      Width           =   2895
   End
End
Attribute VB_Name = "frmCalc"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim N1 As Long, N2 As Long, ANS As Long
Dim op As String * 1
Private Sub cmdDigit_Click(Index As Integer)
    If txtNo.Text = "0" Then
        txtNo.Text = Empty
    End If
    txtNo.Text = txtNo.Text + cmdDigit(Index).Caption
End Sub

Private Sub cmdOp_Click(Index As Integer)
    N1 = txtNo.Text
    txtNo.Text = "0"
    op = cmdOp(Index).Caption
End Sub
Private Sub cmdEqual_Click()
    N2 = txtNo.Text
    Select Case op
        Case "+"
            ANS = N1 + N2
        Case "-"
            ANS = N1 - N2
        Case "*"
            ANS = N1 * N2
        Case "/"
            ANS = N1 / N2
    End Select
    txtNo.Text = ANS
End Sub

Private Sub Form_Activate()
    cmdDigit(0).SetFocus
End Sub
