VERSION 5.00
Begin VB.Form frmSumDigit 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Form1"
   ClientHeight    =   6030
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   4710
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   6030
   ScaleWidth      =   4710
   Begin VB.CommandButton cmdFind 
      Caption         =   "FIND"
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   24
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   120
      TabIndex        =   13
      Top             =   5160
      Width           =   4455
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFF80&
      Caption         =   "Select"
      Height          =   3735
      Left            =   120
      TabIndex        =   2
      Top             =   1200
      Width           =   4455
      Begin VB.TextBox txtOddPos 
         Height          =   495
         Left            =   2280
         TabIndex        =   12
         Text            =   " "
         Top             =   3000
         Width           =   2055
      End
      Begin VB.CheckBox chkOddPos 
         Caption         =   "Sum of Odd position Digit"
         Height          =   495
         Left            =   240
         TabIndex        =   11
         Top             =   3000
         Width           =   2055
      End
      Begin VB.TextBox txtEvenPos 
         Height          =   495
         Left            =   2280
         TabIndex        =   10
         Text            =   " "
         Top             =   2340
         Width           =   2055
      End
      Begin VB.TextBox txtSumAll 
         Height          =   495
         Left            =   2280
         TabIndex        =   9
         Text            =   " "
         Top             =   1680
         Width           =   2055
      End
      Begin VB.TextBox txtSumEven 
         Height          =   495
         Left            =   2280
         TabIndex        =   8
         Text            =   " "
         Top             =   1020
         Width           =   2055
      End
      Begin VB.TextBox txtSumOdd 
         Height          =   495
         Left            =   2280
         TabIndex        =   7
         Text            =   " "
         Top             =   360
         Width           =   2055
      End
      Begin VB.CheckBox chkEven 
         Caption         =   "Sum of Even Digit"
         Height          =   495
         Left            =   240
         TabIndex        =   6
         Top             =   1020
         Width           =   2055
      End
      Begin VB.CheckBox chkAll 
         Caption         =   "Sum f All Digits"
         Height          =   495
         Left            =   240
         TabIndex        =   5
         Top             =   1680
         Width           =   2055
      End
      Begin VB.CheckBox chkEvePos 
         Caption         =   "Sum of Even position Digit"
         Height          =   495
         Left            =   240
         TabIndex        =   4
         Top             =   2340
         Width           =   2055
      End
      Begin VB.CheckBox chkOdd 
         Caption         =   "Sum of Odd Digit"
         Height          =   495
         Left            =   240
         TabIndex        =   3
         Top             =   360
         Width           =   2055
      End
   End
   Begin VB.TextBox txtItem 
      Height          =   615
      Left            =   1680
      TabIndex        =   0
      Top             =   120
      Width           =   2895
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00C0FFFF&
      Caption         =   "Number :"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   1335
   End
End
Attribute VB_Name = "frmSumDigit"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdFind_Click()
    Dim n As Long, d As Long, s As Long
    If chkOdd.Value = 1 Then
        s = 0
        n = txtItem.Text
        While n <> 0
            d = n Mod 10
            If d Mod 2 <> 0 Then
                s = s + d
            End If
            n = Int(n / 10)
        Wend
        txtSumOdd.Text = s
    End If
    
     If chkAll.Value = 1 Then
        s = 0
        n = txtItem.Text
        While n <> 0
            d = n Mod 10
            If d Mod 2 = 0 Then
                s = s + d
            End If
            n = Int(n / 10)
        Wend
        txtSumEven.Text = s
    End If
    
    If chkEven.Value = 1 Then
        s = 0
        n = txtItem.Text
        While n <> 0
            d = n Mod 10
            s = s + d
            n = Int(n / 10)
        Wend
        txtSumAll.Text = s
    End If
 
    
    
    
    
End Sub
