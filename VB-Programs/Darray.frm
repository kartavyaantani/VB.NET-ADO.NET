VERSION 5.00
Begin VB.Form cmdBtn1 
   Caption         =   "Form1"
   ClientHeight    =   4275
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   6285
   LinkTopic       =   "Form1"
   ScaleHeight     =   4275
   ScaleWidth      =   6285
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdBtn2 
      Caption         =   "D array 2"
      Height          =   975
      Left            =   4440
      TabIndex        =   1
      Top             =   3120
      Width           =   1455
   End
   Begin VB.CommandButton cmdBtn1 
      Caption         =   "D array 1"
      Height          =   975
      Left            =   3000
      TabIndex        =   0
      Top             =   3120
      Width           =   1455
   End
End
Attribute VB_Name = "cmdBtn1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
    Option Base 1
    Dim n() As Integer 'Dynamic array declaration
Private Sub cmdBtn1_Click()
    ReDim n(3) As Integer
    n(1) = 5
    n(2) = 10
    n(3) = 15
    Print n(1), n(2), n(3)
End Sub

Private Sub cmdBtn2_Click()
    ReDim Preserve n(5) As Integer
    n(4) = 20
    n(5) = 25
    Print n(1), n(2), n(3), n(4), n(5)
End Sub
