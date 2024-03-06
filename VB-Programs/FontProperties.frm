VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H00C0C0C0&
   Caption         =   "Font Properties"
   ClientHeight    =   3960
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   6615
   LinkTopic       =   "Form1"
   ScaleHeight     =   3960
   ScaleWidth      =   6615
   StartUpPosition =   3  'Windows Default
   Begin VB.ListBox lstColor 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1500
      ItemData        =   "FontProperties.frx":0000
      Left            =   2760
      List            =   "FontProperties.frx":000D
      TabIndex        =   8
      Top             =   1800
      Width           =   1335
   End
   Begin VB.CommandButton cmdAply 
      Caption         =   "APPLY"
      Height          =   975
      Left            =   4320
      TabIndex        =   7
      Top             =   2400
      Width           =   1695
   End
   Begin VB.ComboBox cmbType 
      Height          =   315
      ItemData        =   "FontProperties.frx":0024
      Left            =   4320
      List            =   "FontProperties.frx":0031
      Style           =   2  'Dropdown List
      TabIndex        =   6
      Top             =   1200
      Width           =   1935
   End
   Begin VB.ComboBox cmbSize 
      Height          =   315
      ItemData        =   "FontProperties.frx":0054
      Left            =   2760
      List            =   "FontProperties.frx":006A
      Style           =   2  'Dropdown List
      TabIndex        =   5
      Top             =   1200
      Width           =   1335
   End
   Begin VB.Frame Frame1 
      Caption         =   "Select Style"
      Height          =   2655
      Left            =   120
      TabIndex        =   1
      Top             =   1080
      Width           =   2535
      Begin VB.OptionButton optUnder 
         Caption         =   "UNDERLINE"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   400
            Underline       =   -1  'True
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   240
         TabIndex        =   4
         Top             =   1800
         Width           =   2055
      End
      Begin VB.OptionButton optItalics 
         Caption         =   "ITALICS"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   240
         TabIndex        =   3
         Top             =   1080
         Width           =   2055
      End
      Begin VB.OptionButton optBold 
         Caption         =   "BOLD"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   240
         TabIndex        =   2
         Top             =   360
         Width           =   2055
      End
   End
   Begin VB.TextBox txtSample 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   0
      Text            =   " "
      ToolTipText     =   "Enter text to change style"
      Top             =   240
      Width           =   6015
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdAply_Click()
    
    If optBold.Value = True Then
        txtSample.Font.Bold = True
    End If
    
    If optItalics.Value = True Then
        txtSample.Font.Italic = True
    End If
    
    If optUnder.Value = True Then
        txtSample.Font.Underline = True
    End If
    
    txtSample.Font.Size = cmbSize.Text
    
    txtSample.Font.Name = cmbType.Text
    
    Select Case lstColor.ListIndex
        Case 0
            txtSample.ForeColor = vbRed
        Case 1
            txtSample.ForeColor = vbBlue
        Case 2
            txtSample.ForeColor = vbYellow
    End Select
            
End Sub

Private Sub Form_Activate()
    txtSample.SetFocus
End Sub

