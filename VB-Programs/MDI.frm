VERSION 5.00
Begin VB.MDIForm MDIForm1 
   BackColor       =   &H8000000C&
   Caption         =   "MDI Form By - Kartavya Antani"
   ClientHeight    =   7005
   ClientLeft      =   165
   ClientTop       =   855
   ClientWidth     =   8700
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.Menu mnuNumbers 
      Caption         =   "Numbers"
      Begin VB.Menu mnuPrime 
         Caption         =   "Prime"
      End
      Begin VB.Menu mnuFibonacci 
         Caption         =   "Fibonacci"
         Shortcut        =   ^F
      End
      Begin VB.Menu mnuLine 
         Caption         =   "-"
      End
      Begin VB.Menu mnuSort 
         Caption         =   "Sort"
         Begin VB.Menu mnuAscending 
            Caption         =   "Ascending"
         End
         Begin VB.Menu mnuDescending 
            Caption         =   "Descending"
         End
      End
      Begin VB.Menu mnuSumDigit 
         Caption         =   "Sum Digit Number"
      End
      Begin VB.Menu mnuCalc 
         Caption         =   "Calculator"
      End
   End
   Begin VB.Menu mnuString 
      Caption         =   "String"
      Begin VB.Menu mnuReverse 
         Caption         =   "Reverse String"
      End
      Begin VB.Menu mnuFindWords 
         Caption         =   "Find Total Words"
      End
   End
   Begin VB.Menu mnuExit 
      Caption         =   "Exit"
   End
End
Attribute VB_Name = "MDIForm1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub mnuCalc_Click()
    Shell "D:\vb-programs\mycalc.exe"
End Sub

Private Sub mnuExit_Click()
    End
End Sub

Private Sub mnuPrime_Click()
    Load frmChildPrime
    frmChildPrime.Show
End Sub

Private Sub mnuSumDigit_Click()
    Load frmSumDigit
    frmSumDigit.Show
End Sub
