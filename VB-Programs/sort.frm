VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "SORT - By Kartavya Antani"
   ClientHeight    =   4500
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   6270
   LinkTopic       =   "Form1"
   ScaleHeight     =   4500
   ScaleWidth      =   6270
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdSort 
      BackColor       =   &H00FFFF80&
      Caption         =   "SORT"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   24
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   240
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   3480
      Width           =   5775
   End
   Begin VB.Frame Frame1 
      Caption         =   "Sort Type"
      Height          =   3015
      Left            =   4560
      TabIndex        =   2
      Top             =   240
      Width           =   1455
      Begin VB.OptionButton optDesc 
         Caption         =   "Descinding"
         Height          =   735
         Left            =   120
         TabIndex        =   5
         Top             =   1560
         Width           =   1215
      End
      Begin VB.OptionButton optAsc 
         Caption         =   "Ascending"
         Height          =   735
         Left            =   120
         TabIndex        =   4
         Top             =   480
         Width           =   1215
      End
   End
   Begin VB.ListBox lstMarks 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2670
      ItemData        =   "sort.frx":0000
      Left            =   2760
      List            =   "sort.frx":001C
      TabIndex        =   1
      Top             =   240
      Width           =   1575
   End
   Begin VB.ListBox lstName 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2670
      ItemData        =   "sort.frx":0040
      Left            =   240
      List            =   "sort.frx":005C
      TabIndex        =   0
      Top             =   240
      Width           =   2295
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Base 0
Private Sub cmdSort_Click()
    Dim n(10) As String * 10
    Dim m(10) As Integer
    Dim x As Integer, y As Integer, TotNo As Integer
    Dim tmp_m As Integer, tmp_n As String * 10
    
    For x = 0 To lstName.ListCount - 1
        n(x) = lstName.List(x)
        m(x) = lstMarks.List(x)
    Next x
    TotNo = lstName.ListCount
    lstMarks.Clear
    lstName.Clear
    
    If optAsc.Value = True Then
    For x = 0 To TotNo - 2
        For y = x + 1 To TotNo - 1
            If m(x) > m(y) Then
                tmp_m = m(x)
                m(x) = m(y)
                m(y) = tmp_m
                
                tmp_n = n(x)
                n(x) = n(y)
                n(y) = tmp_n
            End If
        Next y
    Next x
    End If
    
    If optDesc.Value = True Then
    For x = 0 To TotNo - 2
        For y = x + 1 To TotNo - 1
            If m(x) < m(y) Then
                tmp_m = m(x)
                m(x) = m(y)
                m(y) = tmp_m
                
                tmp_n = n(x)
                n(x) = n(y)
                n(y) = tmp_n
            End If
        Next y
    Next x
    End If
    
    For x = 0 To TotNo - 1
        lstMarks.AddItem m(x)
        lstName.AddItem n(x)
    Next x
End Sub

