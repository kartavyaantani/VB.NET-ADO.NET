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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstNumber = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnBiggestNumber = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtNumber.Location = New System.Drawing.Point(214, 51)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 34)
        Me.txtNumber.TabIndex = 0
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(52, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Number :"
        '
        'lstNumber
        '
        Me.lstNumber.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lstNumber.FormattingEnabled = True
        Me.lstNumber.ItemHeight = 28
        Me.lstNumber.Location = New System.Drawing.Point(214, 112)
        Me.lstNumber.Name = "lstNumber"
        Me.lstNumber.Size = New System.Drawing.Size(100, 144)
        Me.lstNumber.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(52, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Answer :"
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAnswer.Location = New System.Drawing.Point(214, 262)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 34)
        Me.txtAnswer.TabIndex = 4
        '
        'btnSum
        '
        Me.btnSum.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSum.Location = New System.Drawing.Point(320, 116)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(210, 43)
        Me.btnSum.TabIndex = 5
        Me.btnSum.Text = "SUM"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnAverage
        '
        Me.btnAverage.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAverage.Location = New System.Drawing.Point(320, 165)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(210, 43)
        Me.btnAverage.TabIndex = 6
        Me.btnAverage.Text = "AVERAGE"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'btnBiggestNumber
        '
        Me.btnBiggestNumber.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBiggestNumber.Location = New System.Drawing.Point(320, 214)
        Me.btnBiggestNumber.Name = "btnBiggestNumber"
        Me.btnBiggestNumber.Size = New System.Drawing.Size(210, 43)
        Me.btnBiggestNumber.TabIndex = 7
        Me.btnBiggestNumber.Text = "BIGGEST NUMBER"
        Me.btnBiggestNumber.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(320, 50)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 35)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(591, 327)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnBiggestNumber)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumber)
        Me.Name = "Form1"
        Me.Text = "LIST BOX-DEMO BY KARTAVYA ANTANI [206250307001]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstNumber As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents btnSum As Button
    Friend WithEvents btnAverage As Button
    Friend WithEvents btnBiggestNumber As Button
    Friend WithEvents btnAdd As Button
End Class
