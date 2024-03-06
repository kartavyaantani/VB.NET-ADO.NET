VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H00FFFF80&
   Caption         =   "Listbox Movement - By Kartavya Antani"
   ClientHeight    =   7260
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   8580
   LinkTopic       =   "Form1"
   ScaleHeight     =   7260
   ScaleWidth      =   8580
   StartUpPosition =   3  'Windows Default
   Begin VB.ListBox lstMove 
      BeginProperty Font 
         Name            =   "Courier"
         Size            =   15
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4860
      ItemData        =   "list move.frx":0000
      Left            =   5400
      List            =   "list move.frx":0002
      TabIndex        =   7
      Top             =   1200
      Width           =   2535
   End
   Begin VB.CommandButton Command5 
      BackColor       =   &H000080FF&
      Caption         =   "ADD Item"
      Default         =   -1  'True
      Height          =   495
      Left            =   3120
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   240
      Width           =   1815
   End
   Begin VB.CommandButton cmdMoveAllBack 
      Caption         =   "<< Move All Back"
      Height          =   735
      Left            =   3120
      TabIndex        =   5
      Top             =   5280
      Width           =   1815
   End
   Begin VB.CommandButton cmdMoveSelectedBack 
      Caption         =   "< Move Selected"
      Height          =   735
      Left            =   3120
      TabIndex        =   4
      Top             =   4080
      Width           =   1815
   End
   Begin VB.CommandButton cmdMoveAll 
      Caption         =   "Move All >>"
      Height          =   735
      Left            =   3120
      TabIndex        =   3
      Top             =   2880
      Width           =   1815
   End
   Begin VB.CommandButton cmdMoveSelected 
      Caption         =   "Move Selected Item >"
      Height          =   735
      Left            =   3120
      TabIndex        =   2
      Top             =   1680
      Width           =   1815
   End
   Begin VB.ListBox lstItem 
      BeginProperty Font 
         Name            =   "Courier"
         Size            =   15
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4860
      ItemData        =   "list move.frx":0004
      Left            =   120
      List            =   "list move.frx":0006
      TabIndex        =   1
      Top             =   1320
      Width           =   2535
   End
   Begin VB.TextBox txtItem 
      BeginProperty Font 
         Name            =   "Courier"
         Size            =   15
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   120
      TabIndex        =   0
      Text            =   " "
      Top             =   240
      Width           =   2535
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdMoveAll_Click()
    Dim n As Integer, i As Integer
    n = lstItem.ListCount
    For i = 0 To n - 1
        lstMove.AddItem lstItem.List(i)
    Next i
    lstItem.Clear
End Sub

Private Sub cmdMoveAllBack_Click()
    Dim n As Integer, i As Integer
    n = lstMove.ListCount
    For i = 0 To n - 1
        lstItem.AddItem lstMove.List(i)
    Next i
    lstMove.Clear
End Sub

Private Sub cmdMoveSelected_Click()
    If lstItem.ListIndex = -1 Then
        MsgBox "NO Selected Item", vbCritical
        Exit Sub
    End If
    lstMove.AddItem lstItem.List(lstItem.ListIndex)
    lstItem.RemoveItem (lstItem.ListIndex)
End Sub

Private Sub cmdMoveSelectedBack_Click()
    If lstMove.ListIndex = -1 Then
        MsgBox "NO Selected Item", vbCritical
        Exit Sub
    End If
    lstItem.AddItem lstMove.List(lstMove.ListIndex)
    lstMove.RemoveItem (lstMove.ListIndex)
End Sub

Private Sub Form_Activate()
    txtItem.SetFocus
End Sub

Private Sub Command5_Click()
    lstItem.AddItem txtItem.Text
    txtItem = Empty
End Sub

