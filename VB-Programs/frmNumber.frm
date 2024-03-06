VERSION 5.00
Begin VB.Form frmNumber 
   BackColor       =   &H008080FF&
   Caption         =   "Number - By Kartavya Antani"
   ClientHeight    =   6345
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4110
   LinkTopic       =   "Form1"
   ScaleHeight     =   6345
   ScaleWidth      =   4110
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtAns 
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
      Left            =   1560
      TabIndex        =   8
      Text            =   " "
      Top             =   5640
      Width           =   2175
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "&Add number To List"
      Default         =   -1  'True
      Height          =   735
      Left            =   1440
      TabIndex        =   7
      Top             =   240
      Width           =   2295
   End
   Begin VB.Frame Frame1 
      Caption         =   "Select Option : "
      Height          =   2655
      Left            =   1560
      TabIndex        =   3
      Top             =   1200
      Width           =   2175
      Begin VB.OptionButton optEven 
         Caption         =   "Average of EVEN"
         Height          =   375
         Left            =   240
         TabIndex        =   6
         Top             =   1920
         Width           =   1695
      End
      Begin VB.OptionButton optOdd 
         Caption         =   "Average of ODD"
         Height          =   375
         Left            =   240
         TabIndex        =   5
         Top             =   1200
         Width           =   1695
      End
      Begin VB.OptionButton optBig 
         Caption         =   "Biggest Number"
         Height          =   375
         Left            =   240
         TabIndex        =   4
         Top             =   480
         Width           =   1695
      End
   End
   Begin VB.ListBox lstNumber 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4845
      Left            =   120
      TabIndex        =   2
      Top             =   1320
      Width           =   975
   End
   Begin VB.TextBox txtNum 
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
      Left            =   120
      TabIndex        =   1
      Top             =   360
      Width           =   975
   End
   Begin VB.CommandButton cmdFind 
      Caption         =   "FIND"
      Height          =   735
      Left            =   1560
      TabIndex        =   0
      Top             =   3960
      Width           =   2175
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFF80&
      Caption         =   "Solution"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   24
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   1560
      TabIndex        =   9
      Top             =   4800
      Width           =   2175
   End
End
Attribute VB_Name = "frmNumber"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdAdd_Click()
    lstNumber.AddItem txtNum.Text
    txtNum.Text = Empty
    txtNum.SetFocus
End Sub

Private Sub Form_Activate()
    txtNum.SetFocus
End Sub

Private Sub cmdFind_Click()
    Dim Big As Integer, TotNo As Integer
    Dim Tmp As Integer, i As Integer
    Dim s As Integer, count As Integer, ave As Single
    TotNo = lstNumber.ListCount

    If optBig.Value = True Then
        Big = lstNumber.List(0)
            For i = 1 To TotNo - 1
                Tmp = lstNumber.List(i)
                If Big < Tmp Then
                    Big = Tmp
                End If
            Next i
        txtAns.Text = Big
    Else
        If optEven.Value = True Then
            s = 0
            count = 0
            
            For i = 0 To TotNo - 1
                Tmp = lstNumber.List(i)
                If Tmp Mod 2 = 0 Then
                    s = s + Tmp
                    count = count + 1
                End If
            Next i
            ave = s / count
            txtAns.Text = ave
         Else
            If optOdd.Value = True Then
                s = 0
                count = 0
                
                For i = 0 To TotNo - 1
                    Tmp = lstNumber.List(i)
                    If Tmp Mod 2 = 1 Then
                        s = s + Tmp
                        count = count + 1
                    End If
                Next i
                ave = s / count
                txtAns.Text = ave
            End If
        End If
    
    End If
    
    
End Sub

