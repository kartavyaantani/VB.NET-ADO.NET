VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H00FFC0C0&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Digital Clock - By Kartavya"
   ClientHeight    =   1515
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   3345
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1515
   ScaleWidth      =   3345
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdSet 
      BackColor       =   &H00C0C0FF&
      Caption         =   "Set Time"
      Height          =   375
      Left            =   960
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   1080
      Width           =   1335
   End
   Begin VB.TextBox txtSec 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFF80&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   24
         Charset         =   0
         Weight          =   400
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   675
      Left            =   2280
      Locked          =   -1  'True
      TabIndex        =   2
      Text            =   "00"
      Top             =   120
      Width           =   855
   End
   Begin VB.TextBox txtMin 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFF80&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   24
         Charset         =   0
         Weight          =   400
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   675
      Left            =   1200
      Locked          =   -1  'True
      TabIndex        =   1
      Text            =   "00"
      Top             =   120
      Width           =   855
   End
   Begin VB.TextBox txtHour 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFF80&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   24
         Charset         =   0
         Weight          =   400
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   675
      Left            =   120
      Locked          =   -1  'True
      TabIndex        =   0
      Text            =   "00"
      Top             =   120
      Width           =   855
   End
   Begin VB.Timer Timer1 
      Interval        =   1000
      Left            =   2640
      Top             =   960
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdSet_Click()
    Dim s As Integer, m As Integer, h As Integer
    h = InputBox("Enter Hour :")
    m = InputBox("Enter Minute :")
    s = InputBox("Enter Second :")
    txtHour.Text = h
    txtMin.Text = m
    txtSec.Text = s
End Sub

Private Sub Timer1_Timer()
    txtSec.Text = txtSec.Text + 1
    If txtSec = 60 Then
        txtSec.Text = 0
        txtMin.Text = txtMin.Text + 1
        If txtMin = 60 Then
            txtMin.Text = 0
            txtHour.Text = txtHour.Text + 1
            If txtHour = 24 Then
                txtHour.Text = 0
            End If
        End If
    End If
    
        
    
End Sub

