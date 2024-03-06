VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H00C0C000&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Restaurant Bill - By Kartavya Antani"
   ClientHeight    =   4605
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   9750
   Icon            =   "Restaurant.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4605
   ScaleWidth      =   9750
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtTotal 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   8760
      TabIndex        =   19
      Top             =   4080
      Width           =   855
   End
   Begin VB.CommandButton cmdBill 
      Caption         =   "Calculate Bill Amount"
      Height          =   495
      Left            =   6720
      TabIndex        =   18
      Top             =   480
      Width           =   2895
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "Cancel Selected Item >>"
      Height          =   495
      Left            =   4680
      TabIndex        =   17
      Top             =   480
      Width           =   1335
   End
   Begin VB.ListBox lstBillName 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2580
      ItemData        =   "Restaurant.frx":4678A
      Left            =   6720
      List            =   "Restaurant.frx":4678C
      TabIndex        =   16
      Top             =   1200
      Width           =   1815
   End
   Begin VB.ListBox lstBillPrice 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2580
      ItemData        =   "Restaurant.frx":4678E
      Left            =   8760
      List            =   "Restaurant.frx":46790
      TabIndex        =   15
      Top             =   1200
      Width           =   855
   End
   Begin VB.CommandButton cmdOrder 
      Caption         =   "Order"
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
      Left            =   3240
      TabIndex        =   14
      Top             =   3720
      Width           =   2775
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFC0&
      Caption         =   "Discount"
      Height          =   1575
      Left            =   3240
      TabIndex        =   9
      Top             =   1920
      Width           =   2775
      Begin VB.TextBox txtSpl 
         Alignment       =   1  'Right Justify
         BackColor       =   &H00C0C0FF&
         ForeColor       =   &H00400000&
         Height          =   405
         Left            =   1920
         TabIndex        =   13
         Top             =   960
         Width           =   735
      End
      Begin VB.TextBox txtGeneral 
         Alignment       =   1  'Right Justify
         BackColor       =   &H00C0C0FF&
         ForeColor       =   &H00400000&
         Height          =   405
         Left            =   1920
         TabIndex        =   12
         Top             =   360
         Width           =   735
      End
      Begin VB.CheckBox chkSpl 
         Caption         =   "Special Discount"
         Height          =   375
         Left            =   120
         TabIndex        =   11
         Top             =   960
         Width           =   2175
      End
      Begin VB.CheckBox chkGeneral 
         Caption         =   "General discount"
         Height          =   375
         Left            =   120
         TabIndex        =   10
         Top             =   360
         Width           =   2175
      End
   End
   Begin VB.ComboBox cmbType 
      Height          =   315
      ItemData        =   "Restaurant.frx":46792
      Left            =   4560
      List            =   "Restaurant.frx":467A2
      Style           =   2  'Dropdown List
      TabIndex        =   8
      Top             =   1320
      Width           =   1455
   End
   Begin VB.TextBox txtQuty 
      Alignment       =   1  'Right Justify
      Height          =   375
      Left            =   3240
      TabIndex        =   7
      Top             =   1320
      Width           =   1215
   End
   Begin VB.ListBox lstPrice 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2940
      ItemData        =   "Restaurant.frx":467D7
      Left            =   2160
      List            =   "Restaurant.frx":467D9
      TabIndex        =   6
      Top             =   1200
      Width           =   855
   End
   Begin VB.ListBox lstItem 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2940
      ItemData        =   "Restaurant.frx":467DB
      Left            =   120
      List            =   "Restaurant.frx":467DD
      TabIndex        =   5
      Top             =   1200
      Width           =   1815
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "< Add Item"
      Height          =   495
      Left            =   3240
      TabIndex        =   4
      Top             =   480
      Width           =   1215
   End
   Begin VB.TextBox txtPrice 
      Alignment       =   1  'Right Justify
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
      Left            =   2160
      TabIndex        =   2
      Top             =   480
      Width           =   855
   End
   Begin VB.TextBox txtItem 
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
      Left            =   120
      TabIndex        =   0
      Top             =   480
      Width           =   1815
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "Food Type"
      Height          =   255
      Left            =   4560
      TabIndex        =   22
      Top             =   1080
      Width           =   855
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "QTY. :-"
      Height          =   255
      Left            =   3240
      TabIndex        =   21
      Top             =   1080
      Width           =   855
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   " TOTAL >"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   6720
      TabIndex        =   20
      Top             =   4080
      Width           =   1935
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Price"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2160
      TabIndex        =   3
      Top             =   120
      Width           =   855
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Item Name"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   1815
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdAdd_Click()
    If txtItem.Text = Empty Or txtPrice.Text = Empty Then
        MsgBox "Please Enter Data", vbCritical
        Exit Sub
    End If
    If Not IsNumeric(txtPrice.Text) Then
        MsgBox "Enter Price properly", vbExclamation
        Exit Sub
    End If
    
    lstItem.AddItem txtItem.Text
    lstPrice.AddItem txtPrice.Text
    txtItem.Text = Empty
    txtPrice.Text = Empty
    txtItem.SetFocus
End Sub

Private Sub cmdBill_Click()
    Dim TotBill As Integer, i As Integer
    For i = 0 To lstBillPrice.ListCount - 1
        TotBill = TotBill + lstBillPrice.List(i)
    Next i
     txtTotal.Text = TotBill
End Sub

Private Sub cmdCancel_Click()
    If lstBillName.ListIndex = -1 Then
        MsgBox "Select Order To cancel", vbInformation
        Exit Sub
    End If
    lstBillName.RemoveItem (lstBillName.ListIndex)
    lstBillPrice.RemoveItem (lstBillPrice.ListIndex)
End Sub
Private Sub lstBillName_Click()
    lstBillPrice.ListIndex = lstBillName.ListIndex
End Sub

Private Sub lstBillPrice_Click()
    lstBillName.ListIndex = lstBillPrice.ListIndex
End Sub

Private Sub lstItem_Click()
    lstPrice.ListIndex = lstItem.ListIndex
    txtQuty.SetFocus
End Sub

Private Sub lstPrice_Click()
    lstItem.ListIndex = lstPrice.ListIndex
    txtQuty.SetFocus
End Sub

Private Sub cmdOrder_Click()
        
    Dim disc As Integer, FoodPrice As Integer
    
    Select Case cmbType.ListIndex
        Case 0
                disc = 5
        Case 1
                disc = 10
        Case 2
                disc = 15
        Case 3
                disc = 0
    End Select
    
    If chkGeneral.Value = 1 Then
        disc = disc + txtGeneral.Text
    End If
    If chkSpl.Value = 1 Then
        disc = disc + txtSpl.Text
    End If
        
    FoodPrice = txtQuty.Text * lstPrice.List(lstPrice.ListIndex)
    FoodPrice = FoodPrice - FoodPrice * disc / 100
    
    lstBillName.AddItem lstItem.List(lstItem.ListIndex)
    lstBillPrice.AddItem FoodPrice
End Sub

Private Sub txtQuty_GotFocus()
    txtQuty.Text = "0"
End Sub

Private Sub txtQuty_LostFocus()
    If Not IsNumeric(txtQuty.Text) Then
        MsgBox "Enter numeric Quantity"
        txtQuty.SetFocus
        Exit Sub
    End If
End Sub
