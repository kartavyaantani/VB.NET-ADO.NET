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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRINTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UNDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.COPYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PASTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELECTALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TIMEDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FORMATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FONTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKGROUNDCOLOURToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COLOURToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BULLETToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALIGNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LEFTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RIGHTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CENTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FINDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.EDITToolStripMenuItem, Me.FORMATToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NEWToolStripMenuItem, Me.OPENToolStripMenuItem, Me.SAVEToolStripMenuItem, Me.PRINTToolStripMenuItem, Me.ToolStripSeparator1, Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'NEWToolStripMenuItem
        '
        Me.NEWToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NEWToolStripMenuItem.Name = "NEWToolStripMenuItem"
        Me.NEWToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.NEWToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NEWToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NEWToolStripMenuItem.Text = "NEW"
        '
        'OPENToolStripMenuItem
        '
        Me.OPENToolStripMenuItem.Name = "OPENToolStripMenuItem"
        Me.OPENToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.OPENToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OPENToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OPENToolStripMenuItem.Text = "OPEN"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.SAVEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SAVEToolStripMenuItem.Text = "SAVE"
        '
        'PRINTToolStripMenuItem
        '
        Me.PRINTToolStripMenuItem.Name = "PRINTToolStripMenuItem"
        Me.PRINTToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PRINTToolStripMenuItem.Text = "PRINT"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UNDOToolStripMenuItem, Me.REDOToolStripMenuItem, Me.ToolStripSeparator2, Me.COPYToolStripMenuItem, Me.CUTToolStripMenuItem, Me.PASTEToolStripMenuItem, Me.ToolStripSeparator3, Me.DELETEToolStripMenuItem, Me.SELECTALLToolStripMenuItem, Me.ToolStripSeparator4, Me.TIMEDATEToolStripMenuItem})
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        '
        'UNDOToolStripMenuItem
        '
        Me.UNDOToolStripMenuItem.Name = "UNDOToolStripMenuItem"
        Me.UNDOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UNDOToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.UNDOToolStripMenuItem.Text = "UNDO"
        '
        'REDOToolStripMenuItem
        '
        Me.REDOToolStripMenuItem.Name = "REDOToolStripMenuItem"
        Me.REDOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.REDOToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.REDOToolStripMenuItem.Text = "REDO"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(174, 6)
        '
        'COPYToolStripMenuItem
        '
        Me.COPYToolStripMenuItem.Name = "COPYToolStripMenuItem"
        Me.COPYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.COPYToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.COPYToolStripMenuItem.Text = "COPY"
        '
        'CUTToolStripMenuItem
        '
        Me.CUTToolStripMenuItem.Name = "CUTToolStripMenuItem"
        Me.CUTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CUTToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CUTToolStripMenuItem.Text = "CUT"
        '
        'PASTEToolStripMenuItem
        '
        Me.PASTEToolStripMenuItem.Name = "PASTEToolStripMenuItem"
        Me.PASTEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PASTEToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PASTEToolStripMenuItem.Text = "PASTE"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(174, 6)
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'SELECTALLToolStripMenuItem
        '
        Me.SELECTALLToolStripMenuItem.Name = "SELECTALLToolStripMenuItem"
        Me.SELECTALLToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SELECTALLToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SELECTALLToolStripMenuItem.Text = "SELECT ALL"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(174, 6)
        '
        'TIMEDATEToolStripMenuItem
        '
        Me.TIMEDATEToolStripMenuItem.Name = "TIMEDATEToolStripMenuItem"
        Me.TIMEDATEToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.TIMEDATEToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.TIMEDATEToolStripMenuItem.Text = "TIME & DATE"
        '
        'FORMATToolStripMenuItem
        '
        Me.FORMATToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FONTToolStripMenuItem, Me.BACKGROUNDCOLOURToolStripMenuItem, Me.COLOURToolStripMenuItem, Me.BULLETToolStripMenuItem, Me.ALIGNToolStripMenuItem})
        Me.FORMATToolStripMenuItem.Name = "FORMATToolStripMenuItem"
        Me.FORMATToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.FORMATToolStripMenuItem.Text = "FORMAT"
        '
        'FONTToolStripMenuItem
        '
        Me.FONTToolStripMenuItem.Name = "FONTToolStripMenuItem"
        Me.FONTToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.FONTToolStripMenuItem.Text = "FONT"
        '
        'BACKGROUNDCOLOURToolStripMenuItem
        '
        Me.BACKGROUNDCOLOURToolStripMenuItem.Name = "BACKGROUNDCOLOURToolStripMenuItem"
        Me.BACKGROUNDCOLOURToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.BACKGROUNDCOLOURToolStripMenuItem.Text = "BACKGROUND COLOUR"
        '
        'COLOURToolStripMenuItem
        '
        Me.COLOURToolStripMenuItem.Name = "COLOURToolStripMenuItem"
        Me.COLOURToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.COLOURToolStripMenuItem.Text = "FONT COLOUR"
        '
        'BULLETToolStripMenuItem
        '
        Me.BULLETToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YESToolStripMenuItem, Me.NOToolStripMenuItem})
        Me.BULLETToolStripMenuItem.Name = "BULLETToolStripMenuItem"
        Me.BULLETToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.BULLETToolStripMenuItem.Text = "BULLET"
        '
        'YESToolStripMenuItem
        '
        Me.YESToolStripMenuItem.Name = "YESToolStripMenuItem"
        Me.YESToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.YESToolStripMenuItem.Text = "YES"
        '
        'NOToolStripMenuItem
        '
        Me.NOToolStripMenuItem.Name = "NOToolStripMenuItem"
        Me.NOToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.NOToolStripMenuItem.Text = "NO"
        '
        'ALIGNToolStripMenuItem
        '
        Me.ALIGNToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LEFTToolStripMenuItem, Me.RIGHTToolStripMenuItem, Me.CENTERToolStripMenuItem})
        Me.ALIGNToolStripMenuItem.Name = "ALIGNToolStripMenuItem"
        Me.ALIGNToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ALIGNToolStripMenuItem.Text = "ALIGN"
        '
        'LEFTToolStripMenuItem
        '
        Me.LEFTToolStripMenuItem.Name = "LEFTToolStripMenuItem"
        Me.LEFTToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.LEFTToolStripMenuItem.Text = "LEFT"
        '
        'RIGHTToolStripMenuItem
        '
        Me.RIGHTToolStripMenuItem.Name = "RIGHTToolStripMenuItem"
        Me.RIGHTToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RIGHTToolStripMenuItem.Text = "RIGHT"
        '
        'CENTERToolStripMenuItem
        '
        Me.CENTERToolStripMenuItem.Name = "CENTERToolStripMenuItem"
        Me.CENTERToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CENTERToolStripMenuItem.Text = "CENTER"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABOUTToolStripMenuItem, Me.FINDToolStripMenuItem})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ABOUTToolStripMenuItem.Text = "ABOUT"
        '
        'FINDToolStripMenuItem
        '
        Me.FINDToolStripMenuItem.Name = "FINDToolStripMenuItem"
        Me.FINDToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.FINDToolStripMenuItem.Text = "FIND"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(684, 437)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Custom Notepad - BY KARTAVYA ANTANI [206250307001]"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OPENToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UNDOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REDOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents COPYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PASTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SELECTALLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents TIMEDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FORMATToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FONTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents COLOURToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ALIGNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LEFTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RIGHTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CENTERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BULLETToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FINDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKGROUNDCOLOURToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRINTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
