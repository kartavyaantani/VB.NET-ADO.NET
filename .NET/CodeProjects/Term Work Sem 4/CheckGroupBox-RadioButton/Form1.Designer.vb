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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optFemale = New System.Windows.Forms.RadioButton()
        Me.optMale = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkComputer = New System.Windows.Forms.CheckBox()
        Me.chkReading = New System.Windows.Forms.CheckBox()
        Me.chkNature = New System.Windows.Forms.CheckBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(64, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECT YOUR DETAILS :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.optFemale)
        Me.GroupBox1.Controls.Add(Me.optMale)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 143)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Gender :"
        '
        'optFemale
        '
        Me.optFemale.AutoSize = True
        Me.optFemale.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.optFemale.Location = New System.Drawing.Point(21, 83)
        Me.optFemale.Name = "optFemale"
        Me.optFemale.Size = New System.Drawing.Size(105, 32)
        Me.optFemale.TabIndex = 1
        Me.optFemale.TabStop = True
        Me.optFemale.Text = "FEMALE"
        Me.optFemale.UseVisualStyleBackColor = True
        '
        'optMale
        '
        Me.optMale.AutoSize = True
        Me.optMale.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.optMale.Location = New System.Drawing.Point(21, 41)
        Me.optMale.Name = "optMale"
        Me.optMale.Size = New System.Drawing.Size(84, 32)
        Me.optMale.TabIndex = 0
        Me.optMale.TabStop = True
        Me.optMale.Text = "MALE"
        Me.optMale.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.chkComputer)
        Me.GroupBox2.Controls.Add(Me.chkReading)
        Me.GroupBox2.Controls.Add(Me.chkNature)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(323, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 192)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Hobby :"
        '
        'chkComputer
        '
        Me.chkComputer.AutoSize = True
        Me.chkComputer.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkComputer.Location = New System.Drawing.Point(34, 136)
        Me.chkComputer.Name = "chkComputer"
        Me.chkComputer.Size = New System.Drawing.Size(139, 32)
        Me.chkComputer.TabIndex = 2
        Me.chkComputer.Text = "COMPUTER"
        Me.chkComputer.UseVisualStyleBackColor = True
        '
        'chkReading
        '
        Me.chkReading.AutoSize = True
        Me.chkReading.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkReading.Location = New System.Drawing.Point(34, 89)
        Me.chkReading.Name = "chkReading"
        Me.chkReading.Size = New System.Drawing.Size(120, 32)
        Me.chkReading.TabIndex = 1
        Me.chkReading.Text = "READING"
        Me.chkReading.UseVisualStyleBackColor = True
        '
        'chkNature
        '
        Me.chkNature.AutoSize = True
        Me.chkNature.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkNature.Location = New System.Drawing.Point(34, 42)
        Me.chkNature.Name = "chkNature"
        Me.chkNature.Size = New System.Drawing.Size(110, 32)
        Me.chkNature.TabIndex = 0
        Me.chkNature.Text = "NATURE"
        Me.chkNature.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.Gray
        Me.btnDisplay.Font = New System.Drawing.Font("Segoe UI", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDisplay.Location = New System.Drawing.Point(64, 341)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(580, 76)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "SHOW"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 466)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "CHKBOX-RADIOBTN-DEMO BY KARTAVYA ANTANI [206250307001]"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optFemale As RadioButton
    Friend WithEvents optMale As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkComputer As CheckBox
    Friend WithEvents chkReading As CheckBox
    Friend WithEvents chkNature As CheckBox
    Friend WithEvents btnDisplay As Button
End Class
