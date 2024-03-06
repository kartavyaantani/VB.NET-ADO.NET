<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lstFoodName = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSpecial = New System.Windows.Forms.TextBox()
        Me.txtGeneral = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.lstBillAmt = New System.Windows.Forms.ListBox()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.btnCalcBill = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(22, 39)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(117, 23)
        Me.txtItemName.TabIndex = 0
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(165, 39)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 23)
        Me.txtPrice.TabIndex = 1
        '
        'lstFoodName
        '
        Me.lstFoodName.FormattingEnabled = True
        Me.lstFoodName.ItemHeight = 15
        Me.lstFoodName.Items.AddRange(New Object() {"Idli", "Pizza"})
        Me.lstFoodName.Location = New System.Drawing.Point(22, 80)
        Me.lstFoodName.Name = "lstFoodName"
        Me.lstFoodName.Size = New System.Drawing.Size(117, 199)
        Me.lstFoodName.TabIndex = 2
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.ItemHeight = 15
        Me.lstPrice.Items.AddRange(New Object() {"50", "130"})
        Me.lstPrice.Location = New System.Drawing.Point(165, 80)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(100, 199)
        Me.lstPrice.TabIndex = 3
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(281, 59)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(106, 23)
        Me.btnAddItem.TabIndex = 4
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(281, 113)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(106, 23)
        Me.txtQty.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Gujarati" & Global.Microsoft.VisualBasic.ChrW(9) & "15%", "Punjabi" & Global.Microsoft.VisualBasic.ChrW(9) & "10%", "Continental" & Global.Microsoft.VisualBasic.ChrW(9) & "5%", "Others" & Global.Microsoft.VisualBasic.ChrW(9) & "2%"})
        Me.ComboBox1.Location = New System.Drawing.Point(410, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSpecial)
        Me.GroupBox1.Controls.Add(Me.txtGeneral)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(281, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 110)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discount"
        '
        'txtSpecial
        '
        Me.txtSpecial.Location = New System.Drawing.Point(126, 63)
        Me.txtSpecial.Name = "txtSpecial"
        Me.txtSpecial.Size = New System.Drawing.Size(100, 23)
        Me.txtSpecial.TabIndex = 3
        '
        'txtGeneral
        '
        Me.txtGeneral.Location = New System.Drawing.Point(126, 28)
        Me.txtGeneral.Name = "txtGeneral"
        Me.txtGeneral.Size = New System.Drawing.Size(100, 23)
        Me.txtGeneral.TabIndex = 2
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(15, 67)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(63, 19)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Special"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 32)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(66, 19)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "General"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(281, 272)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(250, 67)
        Me.btnOrder.TabIndex = 8
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lstItem
        '
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.ItemHeight = 15
        Me.lstItem.Location = New System.Drawing.Point(557, 39)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(117, 259)
        Me.lstItem.TabIndex = 9
        '
        'lstBillAmt
        '
        Me.lstBillAmt.FormattingEnabled = True
        Me.lstBillAmt.ItemHeight = 15
        Me.lstBillAmt.Location = New System.Drawing.Point(694, 39)
        Me.lstBillAmt.Name = "lstBillAmt"
        Me.lstBillAmt.Size = New System.Drawing.Size(100, 259)
        Me.lstBillAmt.TabIndex = 10
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(425, 59)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(106, 23)
        Me.btnCancelOrder.TabIndex = 11
        Me.btnCancelOrder.Text = "Cancel Order"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'btnCalcBill
        '
        Me.btnCalcBill.Location = New System.Drawing.Point(557, 304)
        Me.btnCalcBill.Name = "btnCalcBill"
        Me.btnCalcBill.Size = New System.Drawing.Size(117, 35)
        Me.btnCalcBill.TabIndex = 12
        Me.btnCalcBill.Text = "Calculate Bill"
        Me.btnCalcBill.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Item Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(281, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(410, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Food Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(694, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 32)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "_________"
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(22, 285)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(243, 51)
        Me.btnModify.TabIndex = 18
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(826, 361)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcBill)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.lstBillAmt)
        Me.Controls.Add(Me.lstItem)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstFoodName)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtItemName)
        Me.Name = "Form1"
        Me.Text = "Restaurant Program"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lstFoodName As ListBox
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSpecial As TextBox
    Friend WithEvents txtGeneral As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents lstItem As ListBox
    Friend WithEvents lstBillAmt As ListBox
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents btnCalcBill As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnModify As Button
End Class
