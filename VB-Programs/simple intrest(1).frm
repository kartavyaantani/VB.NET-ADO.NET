VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H00000000&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Simple Intrest"
   ClientHeight    =   6225
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   2460
   FillColor       =   &H0080FF80&
   ForeColor       =   &H00FFFFFF&
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6225
   ScaleWidth      =   2460
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdSubmit 
      BackColor       =   &H000000FF&
      Caption         =   "SUBMIT"
      Height          =   375
      Left            =   600
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   4080
      Width           =   1215
   End
   Begin VB.TextBox txtN 
      Height          =   495
      Left            =   360
      TabIndex        =   3
      Text            =   " "
      Top             =   3360
      Width           =   1815
   End
   Begin VB.TextBox txtR 
      Height          =   495
      Left            =   360
      TabIndex        =   2
      Text            =   " "
      Top             =   2040
      Width           =   1815
   End
   Begin VB.TextBox txtP 
      Height          =   495
      Left            =   360
      TabIndex        =   1
      Text            =   " "
      Top             =   720
      Width           =   1815
   End
   Begin VB.TextBox txtans 
      BackColor       =   &H00E0E0E0&
      Height          =   1095
      Left            =   600
      TabIndex        =   0
      Text            =   " "
      Top             =   5040
      Width           =   1215
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      BackColor       =   &H00E0E0E0&
      Caption         =   "Simple intrest Amount"
      ForeColor       =   &H00800080&
      Height          =   375
      Left            =   600
      TabIndex        =   7
      Top             =   4560
      Width           =   1215
   End
   Begin VB.Label Label3 
      BackColor       =   &H0080C0FF&
      Caption         =   "Enter Time Of Deposit"
      Height          =   255
      Left            =   360
      TabIndex        =   6
      Top             =   2880
      Width           =   1815
   End
   Begin VB.Label Label2 
      BackColor       =   &H00FFFF80&
      Caption         =   "Enter Rate Of Intrest"
      Height          =   255
      Left            =   360
      TabIndex        =   5
      Top             =   1560
      Width           =   1815
   End
   Begin VB.Label Label1 
      BackColor       =   &H00C0C0FF&
      Caption         =   "Enter Money Amount"
      Height          =   255
      Left            =   360
      TabIndex        =   4
      Top             =   240
      Width           =   1815
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdSubmit_Click()
    Dim p As Integer, r As Integer, n As Integer, ans As Integer
    p = Int(Val(txtP.Text))
    r = Int(Val(txtR.Text))
    n = Int(Val(txtN.Text))
    ans = (p * r * n) / 100
    txtans.Text = ans
    
End Sub

