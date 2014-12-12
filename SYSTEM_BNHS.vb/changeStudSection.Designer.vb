<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changeStudSection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtStudSection = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtStudName = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.cboChangeSecStud = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSearchStudId = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSearchEnrol = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(12, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 21)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Current Year/Section:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(12, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 21)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Student Name:"
        '
        'txtStudSection
        '
        Me.txtStudSection.Location = New System.Drawing.Point(197, 142)
        Me.txtStudSection.Name = "txtStudSection"
        Me.txtStudSection.ReadOnly = True
        Me.txtStudSection.Size = New System.Drawing.Size(227, 20)
        Me.txtStudSection.TabIndex = 60
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(61, 239)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(164, 28)
        Me.btnSave.TabIndex = 57
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtStudName
        '
        Me.txtStudName.Location = New System.Drawing.Point(197, 113)
        Me.txtStudName.Name = "txtStudName"
        Me.txtStudName.ReadOnly = True
        Me.txtStudName.Size = New System.Drawing.Size(227, 20)
        Me.txtStudName.TabIndex = 59
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(253, 239)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(164, 28)
        Me.btnCancel.TabIndex = 58
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cboChangeSecStud
        '
        Me.cboChangeSecStud.FormattingEnabled = True
        Me.cboChangeSecStud.Items.AddRange(New Object() {"7 - Binet", "7 - Azucena", "7 - Bougainvillea", "7 - Chrysanthemum", "7 - Daffodil", "7 - Everlasting", "7 - Fleur d lis", "7 - Gladiola", "8 - Newton", "8 - Acacia", "8 - Banaba", "8 - Camachili", "8 - Dao", "8 - Evergreen", "III - Herschel", "III - Amethyst", "III - Beryl", "III - Citrine", "III - Diamond", "IV - Socrates", "IV - Amiability", "IV - Bravery", "IV - Charity", "IV - Dependability"})
        Me.cboChangeSecStud.Location = New System.Drawing.Point(197, 187)
        Me.cboChangeSecStud.Name = "cboChangeSecStud"
        Me.cboChangeSecStud.Size = New System.Drawing.Size(164, 21)
        Me.cboChangeSecStud.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(12, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 21)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Transfer student to..:"
        '
        'txtSearchStudId
        '
        Me.txtSearchStudId.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchStudId.Location = New System.Drawing.Point(9, 15)
        Me.txtSearchStudId.Name = "txtSearchStudId"
        Me.txtSearchStudId.Size = New System.Drawing.Size(187, 25)
        Me.txtSearchStudId.TabIndex = 50
        Me.txtSearchStudId.Text = "Enter Student ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtSearchStudId)
        Me.GroupBox1.Controls.Add(Me.btnSearchEnrol)
        Me.GroupBox1.Location = New System.Drawing.Point(182, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 50)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'btnSearchEnrol
        '
        Me.btnSearchEnrol.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnSearchEnrol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchEnrol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchEnrol.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchEnrol.ForeColor = System.Drawing.Color.White
        Me.btnSearchEnrol.Location = New System.Drawing.Point(202, 11)
        Me.btnSearchEnrol.Name = "btnSearchEnrol"
        Me.btnSearchEnrol.Size = New System.Drawing.Size(87, 33)
        Me.btnSearchEnrol.TabIndex = 51
        Me.btnSearchEnrol.Text = "SEARCH"
        Me.btnSearchEnrol.UseVisualStyleBackColor = True
        '
        'changeStudSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.bg11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(489, 279)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboChangeSecStud)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStudSection)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtStudName)
        Me.Controls.Add(Me.btnCancel)
        Me.DoubleBuffered = True
        Me.Name = "changeStudSection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudSection As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtStudName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboChangeSecStud As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearchStudId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchEnrol As System.Windows.Forms.Button
End Class
