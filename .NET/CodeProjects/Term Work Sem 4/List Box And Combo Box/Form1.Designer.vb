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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddToListBox = New System.Windows.Forms.Button()
        Me.btnAddToComboBox = New System.Windows.Forms.Button()
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.comItem = New System.Windows.Forms.ComboBox()
        Me.btnMoveFromListToCombo = New System.Windows.Forms.Button()
        Me.btnMoveFromComboToList = New System.Windows.Forms.Button()
        Me.btnClearListBox = New System.Windows.Forms.Button()
        Me.btnClearComboBox = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtItemName
        '
        Me.txtItemName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtItemName.Location = New System.Drawing.Point(190, 44)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(293, 29)
        Me.txtItemName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(37, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Item Name :"
        '
        'btnAddToListBox
        '
        Me.btnAddToListBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddToListBox.Location = New System.Drawing.Point(510, 12)
        Me.btnAddToListBox.Name = "btnAddToListBox"
        Me.btnAddToListBox.Size = New System.Drawing.Size(189, 30)
        Me.btnAddToListBox.TabIndex = 2
        Me.btnAddToListBox.Text = "Add To List Box"
        Me.btnAddToListBox.UseVisualStyleBackColor = True
        '
        'btnAddToComboBox
        '
        Me.btnAddToComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddToComboBox.Location = New System.Drawing.Point(510, 60)
        Me.btnAddToComboBox.Name = "btnAddToComboBox"
        Me.btnAddToComboBox.Size = New System.Drawing.Size(189, 30)
        Me.btnAddToComboBox.TabIndex = 3
        Me.btnAddToComboBox.Text = "Add To Combo Box"
        Me.btnAddToComboBox.UseVisualStyleBackColor = True
        '
        'lstItem
        '
        Me.lstItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.ItemHeight = 21
        Me.lstItem.Location = New System.Drawing.Point(111, 127)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(111, 172)
        Me.lstItem.TabIndex = 4
        '
        'comItem
        '
        Me.comItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.comItem.FormattingEnabled = True
        Me.comItem.Location = New System.Drawing.Point(510, 148)
        Me.comItem.Name = "comItem"
        Me.comItem.Size = New System.Drawing.Size(164, 29)
        Me.comItem.TabIndex = 5
        '
        'btnMoveFromListToCombo
        '
        Me.btnMoveFromListToCombo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMoveFromListToCombo.Location = New System.Drawing.Point(256, 127)
        Me.btnMoveFromListToCombo.Name = "btnMoveFromListToCombo"
        Me.btnMoveFromListToCombo.Size = New System.Drawing.Size(208, 80)
        Me.btnMoveFromListToCombo.TabIndex = 6
        Me.btnMoveFromListToCombo.Text = "Move Selected Item From List Box To Combo box >>"
        Me.btnMoveFromListToCombo.UseVisualStyleBackColor = True
        '
        'btnMoveFromComboToList
        '
        Me.btnMoveFromComboToList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMoveFromComboToList.Location = New System.Drawing.Point(256, 213)
        Me.btnMoveFromComboToList.Name = "btnMoveFromComboToList"
        Me.btnMoveFromComboToList.Size = New System.Drawing.Size(208, 80)
        Me.btnMoveFromComboToList.TabIndex = 7
        Me.btnMoveFromComboToList.Text = "Move Selected Item  From Combo Box To List Box <<"
        Me.btnMoveFromComboToList.UseVisualStyleBackColor = True
        '
        'btnClearListBox
        '
        Me.btnClearListBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClearListBox.Location = New System.Drawing.Point(111, 330)
        Me.btnClearListBox.Name = "btnClearListBox"
        Me.btnClearListBox.Size = New System.Drawing.Size(111, 55)
        Me.btnClearListBox.TabIndex = 8
        Me.btnClearListBox.Text = "Clear List Box"
        Me.btnClearListBox.UseVisualStyleBackColor = True
        '
        'btnClearComboBox
        '
        Me.btnClearComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClearComboBox.Location = New System.Drawing.Point(525, 330)
        Me.btnClearComboBox.Name = "btnClearComboBox"
        Me.btnClearComboBox.Size = New System.Drawing.Size(111, 55)
        Me.btnClearComboBox.TabIndex = 9
        Me.btnClearComboBox.Text = "Clear Combo Box"
        Me.btnClearComboBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 450)
        Me.Controls.Add(Me.btnClearComboBox)
        Me.Controls.Add(Me.btnClearListBox)
        Me.Controls.Add(Me.btnMoveFromComboToList)
        Me.Controls.Add(Me.btnMoveFromListToCombo)
        Me.Controls.Add(Me.comItem)
        Me.Controls.Add(Me.lstItem)
        Me.Controls.Add(Me.btnAddToComboBox)
        Me.Controls.Add(Me.btnAddToListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtItemName)
        Me.Name = "Form1"
        Me.Text = "LIST BOX AND COMBO  BOX-DEMO BY KARTAVYA ANTANI [206250307001]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddToListBox As Button
    Friend WithEvents btnAddToComboBox As Button
    Friend WithEvents lstItem As ListBox
    Friend WithEvents comItem As ComboBox
    Friend WithEvents btnMoveFromListToCombo As Button
    Friend WithEvents btnMoveFromComboToList As Button
    Friend WithEvents btnClearListBox As Button
    Friend WithEvents btnClearComboBox As Button
End Class
