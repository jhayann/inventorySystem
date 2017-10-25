<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adduser
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
        Me.frmadduser = New PharmacyInventorySystem.FormSkin()
        Me.FlatComboBox1 = New PharmacyInventorySystem.FlatComboBox()
        Me.FlatLabel6 = New PharmacyInventorySystem.FlatLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnReset = New PharmacyInventorySystem.FlatButton()
        Me.btnAdduser = New PharmacyInventorySystem.FlatButton()
        Me.txtconpass = New PharmacyInventorySystem.FlatTextBox()
        Me.txtpass = New PharmacyInventorySystem.FlatTextBox()
        Me.txtusr = New PharmacyInventorySystem.FlatTextBox()
        Me.txtln = New PharmacyInventorySystem.FlatTextBox()
        Me.txtfn = New PharmacyInventorySystem.FlatTextBox()
        Me.FlatLabel5 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel4 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel3 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel2 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel1 = New PharmacyInventorySystem.FlatLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.frmadduser.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmadduser
        '
        Me.frmadduser.BackColor = System.Drawing.Color.White
        Me.frmadduser.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.frmadduser.BorderColor = System.Drawing.Color.White
        Me.frmadduser.Controls.Add(Me.FlatComboBox1)
        Me.frmadduser.Controls.Add(Me.FlatLabel6)
        Me.frmadduser.Controls.Add(Me.PictureBox3)
        Me.frmadduser.Controls.Add(Me.PictureBox2)
        Me.frmadduser.Controls.Add(Me.btnReset)
        Me.frmadduser.Controls.Add(Me.btnAdduser)
        Me.frmadduser.Controls.Add(Me.txtconpass)
        Me.frmadduser.Controls.Add(Me.txtpass)
        Me.frmadduser.Controls.Add(Me.txtusr)
        Me.frmadduser.Controls.Add(Me.txtln)
        Me.frmadduser.Controls.Add(Me.txtfn)
        Me.frmadduser.Controls.Add(Me.FlatLabel5)
        Me.frmadduser.Controls.Add(Me.FlatLabel4)
        Me.frmadduser.Controls.Add(Me.FlatLabel3)
        Me.frmadduser.Controls.Add(Me.FlatLabel2)
        Me.frmadduser.Controls.Add(Me.FlatLabel1)
        Me.frmadduser.Controls.Add(Me.PictureBox1)
        Me.frmadduser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmadduser.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.frmadduser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.frmadduser.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.frmadduser.HeaderMaximize = False
        Me.frmadduser.Location = New System.Drawing.Point(0, 0)
        Me.frmadduser.Name = "frmadduser"
        Me.frmadduser.Size = New System.Drawing.Size(489, 366)
        Me.frmadduser.TabIndex = 0
        Me.frmadduser.Text = "   Add User"
        '
        'FlatComboBox1
        '
        Me.FlatComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.FlatComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.FlatComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlatComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatComboBox1.ForeColor = System.Drawing.Color.White
        Me.FlatComboBox1.FormattingEnabled = True
        Me.FlatComboBox1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatComboBox1.ItemHeight = 18
        Me.FlatComboBox1.Items.AddRange(New Object() {"ADMIN", "CASHIER"})
        Me.FlatComboBox1.Location = New System.Drawing.Point(311, 249)
        Me.FlatComboBox1.Name = "FlatComboBox1"
        Me.FlatComboBox1.Size = New System.Drawing.Size(151, 24)
        Me.FlatComboBox1.TabIndex = 16
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel6.ForeColor = System.Drawing.Color.White
        Me.FlatLabel6.Location = New System.Drawing.Point(163, 247)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(80, 20)
        Me.FlatLabel6.TabIndex = 15
        Me.FlatLabel6.Text = "POSITION:"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PictureBox3.Image = Global.PharmacyInventorySystem.My.Resources.Resources.icons8_Zeitschrift_64
        Me.PictureBox3.Location = New System.Drawing.Point(3, 8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PharmacyInventorySystem.My.Resources.Resources.delete_1_icon
        Me.PictureBox2.Location = New System.Drawing.Point(459, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(17, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnReset.Location = New System.Drawing.Point(207, 309)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Rounded = False
        Me.btnReset.Size = New System.Drawing.Size(106, 32)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAdduser
        '
        Me.btnAdduser.BackColor = System.Drawing.Color.Transparent
        Me.btnAdduser.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAdduser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdduser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnAdduser.Location = New System.Drawing.Point(356, 309)
        Me.btnAdduser.Name = "btnAdduser"
        Me.btnAdduser.Rounded = False
        Me.btnAdduser.Size = New System.Drawing.Size(106, 32)
        Me.btnAdduser.TabIndex = 11
        Me.btnAdduser.Text = "ADD"
        Me.btnAdduser.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtconpass
        '
        Me.txtconpass.BackColor = System.Drawing.Color.Transparent
        Me.txtconpass.Location = New System.Drawing.Point(311, 208)
        Me.txtconpass.MaxLength = 32767
        Me.txtconpass.Multiline = False
        Me.txtconpass.Name = "txtconpass"
        Me.txtconpass.ReadOnly = False
        Me.txtconpass.Size = New System.Drawing.Size(151, 29)
        Me.txtconpass.TabIndex = 10
        Me.txtconpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtconpass.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtconpass.UseSystemPasswordChar = True
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.Transparent
        Me.txtpass.Location = New System.Drawing.Point(311, 173)
        Me.txtpass.MaxLength = 32767
        Me.txtpass.Multiline = False
        Me.txtpass.Name = "txtpass"
        Me.txtpass.ReadOnly = False
        Me.txtpass.Size = New System.Drawing.Size(151, 29)
        Me.txtpass.TabIndex = 9
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtpass.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtusr
        '
        Me.txtusr.BackColor = System.Drawing.Color.Transparent
        Me.txtusr.Location = New System.Drawing.Point(311, 138)
        Me.txtusr.MaxLength = 32767
        Me.txtusr.Multiline = False
        Me.txtusr.Name = "txtusr"
        Me.txtusr.ReadOnly = False
        Me.txtusr.Size = New System.Drawing.Size(151, 29)
        Me.txtusr.TabIndex = 8
        Me.txtusr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtusr.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtusr.UseSystemPasswordChar = False
        '
        'txtln
        '
        Me.txtln.BackColor = System.Drawing.Color.Transparent
        Me.txtln.Location = New System.Drawing.Point(311, 103)
        Me.txtln.MaxLength = 32767
        Me.txtln.Multiline = False
        Me.txtln.Name = "txtln"
        Me.txtln.ReadOnly = False
        Me.txtln.Size = New System.Drawing.Size(151, 29)
        Me.txtln.TabIndex = 7
        Me.txtln.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtln.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtln.UseSystemPasswordChar = False
        '
        'txtfn
        '
        Me.txtfn.BackColor = System.Drawing.Color.Transparent
        Me.txtfn.Location = New System.Drawing.Point(311, 68)
        Me.txtfn.MaxLength = 32767
        Me.txtfn.Multiline = False
        Me.txtfn.Name = "txtfn"
        Me.txtfn.ReadOnly = False
        Me.txtfn.Size = New System.Drawing.Size(151, 29)
        Me.txtfn.TabIndex = 6
        Me.txtfn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtfn.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtfn.UseSystemPasswordChar = False
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.White
        Me.FlatLabel5.Location = New System.Drawing.Point(163, 209)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(136, 20)
        Me.FlatLabel5.TabIndex = 5
        Me.FlatLabel5.Text = "Confirm Password:"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(163, 173)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(112, 20)
        Me.FlatLabel4.TabIndex = 4
        Me.FlatLabel4.Text = "New Password:"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(163, 139)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(117, 20)
        Me.FlatLabel3.TabIndex = 3
        Me.FlatLabel3.Text = "New Username:"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(163, 101)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(84, 20)
        Me.FlatLabel2.TabIndex = 2
        Me.FlatLabel2.Text = "Last Name:"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(163, 68)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(87, 20)
        Me.FlatLabel1.TabIndex = 1
        Me.FlatLabel1.Text = "First Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PharmacyInventorySystem.My.Resources.Resources.User___add_5121
        Me.PictureBox1.Location = New System.Drawing.Point(31, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'adduser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 366)
        Me.Controls.Add(Me.frmadduser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adduser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adduser"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.frmadduser.ResumeLayout(False)
        Me.frmadduser.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmadduser As PharmacyInventorySystem.FormSkin
    Friend WithEvents btnReset As PharmacyInventorySystem.FlatButton
    Friend WithEvents btnAdduser As PharmacyInventorySystem.FlatButton
    Friend WithEvents txtconpass As PharmacyInventorySystem.FlatTextBox
    Friend WithEvents txtpass As PharmacyInventorySystem.FlatTextBox
    Friend WithEvents txtusr As PharmacyInventorySystem.FlatTextBox
    Friend WithEvents txtln As PharmacyInventorySystem.FlatTextBox
    Friend WithEvents txtfn As PharmacyInventorySystem.FlatTextBox
    Friend WithEvents FlatLabel5 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel4 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel3 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel2 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel1 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatComboBox1 As PharmacyInventorySystem.FlatComboBox
    Friend WithEvents FlatLabel6 As PharmacyInventorySystem.FlatLabel
End Class
