<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class details_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(details_frm))
        Me.FormSkin1 = New PharmacyInventorySystem.FormSkin()
        Me.txtStocks = New System.Windows.Forms.TextBox()
        Me.lblstocks = New PharmacyInventorySystem.FlatLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.dtped = New System.Windows.Forms.DateTimePicker()
        Me.txtgon = New System.Windows.Forms.TextBox()
        Me.cbxf = New PharmacyInventorySystem.FlatComboBox()
        Me.txtdsg = New PharmacyInventorySystem.FlatTextBox()
        Me.txtgn = New PharmacyInventorySystem.FlatTextBox()
        Me.txtbn = New PharmacyInventorySystem.FlatTextBox()
        Me.FlatLabel10 = New PharmacyInventorySystem.FlatLabel()
        Me.lblprice = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel8 = New PharmacyInventorySystem.FlatLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEditSave = New PharmacyInventorySystem.FlatButton()
        Me.lblForm = New PharmacyInventorySystem.FlatLabel()
        Me.lbldos = New PharmacyInventorySystem.FlatLabel()
        Me.lblexp = New PharmacyInventorySystem.FlatLabel()
        Me.lblgname = New PharmacyInventorySystem.FlatLabel()
        Me.lblgondola = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel7 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel6 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel5 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel4 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel3 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel2 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel1 = New PharmacyInventorySystem.FlatLabel()
        Me.BunifuCircleProgressbar1 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.txtbname = New System.Windows.Forms.TextBox()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEdit.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.txtStocks)
        Me.FormSkin1.Controls.Add(Me.lblstocks)
        Me.FormSkin1.Controls.Add(Me.PictureBox2)
        Me.FormSkin1.Controls.Add(Me.txtPrice)
        Me.FormSkin1.Controls.Add(Me.pnlEdit)
        Me.FormSkin1.Controls.Add(Me.FlatLabel10)
        Me.FormSkin1.Controls.Add(Me.lblprice)
        Me.FormSkin1.Controls.Add(Me.FlatLabel8)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Controls.Add(Me.btnEditSave)
        Me.FormSkin1.Controls.Add(Me.lblForm)
        Me.FormSkin1.Controls.Add(Me.lbldos)
        Me.FormSkin1.Controls.Add(Me.lblexp)
        Me.FormSkin1.Controls.Add(Me.lblgname)
        Me.FormSkin1.Controls.Add(Me.lblgondola)
        Me.FormSkin1.Controls.Add(Me.FlatLabel7)
        Me.FormSkin1.Controls.Add(Me.FlatLabel6)
        Me.FormSkin1.Controls.Add(Me.FlatLabel5)
        Me.FormSkin1.Controls.Add(Me.FlatLabel4)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.BunifuCircleProgressbar1)
        Me.FormSkin1.Controls.Add(Me.txtbname)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(624, 445)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "   Details"
        '
        'txtStocks
        '
        Me.txtStocks.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtStocks.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStocks.Location = New System.Drawing.Point(143, 386)
        Me.txtStocks.MaxLength = 3
        Me.txtStocks.Name = "txtStocks"
        Me.txtStocks.Size = New System.Drawing.Size(54, 33)
        Me.txtStocks.TabIndex = 24
        Me.txtStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtStocks.Visible = False
        '
        'lblstocks
        '
        Me.lblstocks.AutoSize = True
        Me.lblstocks.BackColor = System.Drawing.Color.Transparent
        Me.lblstocks.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstocks.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblstocks.Location = New System.Drawing.Point(16, 383)
        Me.lblstocks.Name = "lblstocks"
        Me.lblstocks.Size = New System.Drawing.Size(132, 40)
        Me.lblstocks.TabIndex = 23
        Me.lblstocks.Text = "STOCKS:"
        Me.lblstocks.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PictureBox2.Image = Global.PharmacyInventorySystem.My.Resources.Resources.icons8_Menu_64
        Me.PictureBox2.Location = New System.Drawing.Point(3, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(97, 342)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 33)
        Me.txtPrice.TabIndex = 7
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPrice.Visible = False
        '
        'pnlEdit
        '
        Me.pnlEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.pnlEdit.Controls.Add(Me.dtped)
        Me.pnlEdit.Controls.Add(Me.txtgon)
        Me.pnlEdit.Controls.Add(Me.cbxf)
        Me.pnlEdit.Controls.Add(Me.txtdsg)
        Me.pnlEdit.Controls.Add(Me.txtgn)
        Me.pnlEdit.Controls.Add(Me.txtbn)
        Me.pnlEdit.Location = New System.Drawing.Point(391, 73)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(228, 248)
        Me.pnlEdit.TabIndex = 20
        Me.pnlEdit.Visible = False
        '
        'dtped
        '
        Me.dtped.Location = New System.Drawing.Point(0, 141)
        Me.dtped.Name = "dtped"
        Me.dtped.Size = New System.Drawing.Size(225, 29)
        Me.dtped.TabIndex = 4
        '
        'txtgon
        '
        Me.txtgon.Location = New System.Drawing.Point(3, 14)
        Me.txtgon.Name = "txtgon"
        Me.txtgon.Size = New System.Drawing.Size(163, 29)
        Me.txtgon.TabIndex = 1
        '
        'cbxf
        '
        Me.cbxf.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cbxf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxf.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.cbxf.ForeColor = System.Drawing.Color.White
        Me.cbxf.FormattingEnabled = True
        Me.cbxf.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cbxf.ItemHeight = 18
        Me.cbxf.Items.AddRange(New Object() {"CAPSULE", "TABLET", "SYRUP", "CREAM", "POWDER", "SOLUTION", "AMPOULES", "CLEANSER", "SOAP", "GRANULES", "SUSPENSION", "OINTMENT", "INHALER", "SHAMPOO", "GEL"})
        Me.cbxf.Location = New System.Drawing.Point(2, 215)
        Me.cbxf.Name = "cbxf"
        Me.cbxf.Size = New System.Drawing.Size(163, 24)
        Me.cbxf.TabIndex = 6
        '
        'txtdsg
        '
        Me.txtdsg.BackColor = System.Drawing.Color.Transparent
        Me.txtdsg.Location = New System.Drawing.Point(1, 178)
        Me.txtdsg.MaxLength = 32767
        Me.txtdsg.Multiline = False
        Me.txtdsg.Name = "txtdsg"
        Me.txtdsg.ReadOnly = False
        Me.txtdsg.Size = New System.Drawing.Size(163, 29)
        Me.txtdsg.TabIndex = 5
        Me.txtdsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtdsg.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdsg.UseSystemPasswordChar = False
        '
        'txtgn
        '
        Me.txtgn.BackColor = System.Drawing.Color.Transparent
        Me.txtgn.Location = New System.Drawing.Point(2, 103)
        Me.txtgn.MaxLength = 32767
        Me.txtgn.Multiline = False
        Me.txtgn.Name = "txtgn"
        Me.txtgn.ReadOnly = False
        Me.txtgn.Size = New System.Drawing.Size(163, 29)
        Me.txtgn.TabIndex = 3
        Me.txtgn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtgn.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtgn.UseSystemPasswordChar = False
        '
        'txtbn
        '
        Me.txtbn.BackColor = System.Drawing.Color.Transparent
        Me.txtbn.Location = New System.Drawing.Point(3, 53)
        Me.txtbn.MaxLength = 32767
        Me.txtbn.Multiline = False
        Me.txtbn.Name = "txtbn"
        Me.txtbn.ReadOnly = False
        Me.txtbn.Size = New System.Drawing.Size(163, 29)
        Me.txtbn.TabIndex = 2
        Me.txtbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtbn.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtbn.UseSystemPasswordChar = False
        '
        'FlatLabel10
        '
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel10.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel10.ForeColor = System.Drawing.Color.SeaGreen
        Me.FlatLabel10.Location = New System.Drawing.Point(18, 335)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New System.Drawing.Size(75, 40)
        Me.FlatLabel10.TabIndex = 19
        Me.FlatLabel10.Text = "PHP"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.BackColor = System.Drawing.Color.Transparent
        Me.lblprice.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblprice.Location = New System.Drawing.Point(91, 335)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(0, 40)
        Me.lblprice.TabIndex = 18
        '
        'FlatLabel8
        '
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel8.ForeColor = System.Drawing.Color.White
        Me.FlatLabel8.Location = New System.Drawing.Point(21, 301)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(122, 20)
        Me.FlatLabel8.TabIndex = 17
        Me.FlatLabel8.Text = "CURRENT PRICE:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.PharmacyInventorySystem.My.Resources.Resources.delete_1_icon
        Me.PictureBox1.Location = New System.Drawing.Point(583, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'btnEditSave
        '
        Me.btnEditSave.BackColor = System.Drawing.Color.Transparent
        Me.btnEditSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnEditSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnEditSave.Location = New System.Drawing.Point(394, 354)
        Me.btnEditSave.Name = "btnEditSave"
        Me.btnEditSave.Rounded = False
        Me.btnEditSave.Size = New System.Drawing.Size(146, 59)
        Me.btnEditSave.TabIndex = 8
        Me.btnEditSave.Text = "EDIT"
        Me.btnEditSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.BackColor = System.Drawing.Color.Transparent
        Me.lblForm.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForm.ForeColor = System.Drawing.Color.White
        Me.lblForm.Location = New System.Drawing.Point(391, 286)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(46, 20)
        Me.lblForm.TabIndex = 13
        Me.lblForm.Text = "Form"
        '
        'lbldos
        '
        Me.lbldos.AutoSize = True
        Me.lbldos.BackColor = System.Drawing.Color.Transparent
        Me.lbldos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldos.ForeColor = System.Drawing.Color.White
        Me.lbldos.Location = New System.Drawing.Point(391, 251)
        Me.lbldos.Name = "lbldos"
        Me.lbldos.Size = New System.Drawing.Size(61, 20)
        Me.lbldos.TabIndex = 12
        Me.lbldos.Text = "Dosage"
        '
        'lblexp
        '
        Me.lblexp.AutoSize = True
        Me.lblexp.BackColor = System.Drawing.Color.Transparent
        Me.lblexp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexp.ForeColor = System.Drawing.Color.White
        Me.lblexp.Location = New System.Drawing.Point(391, 214)
        Me.lblexp.Name = "lblexp"
        Me.lblexp.Size = New System.Drawing.Size(80, 20)
        Me.lblexp.TabIndex = 11
        Me.lblexp.Text = "Expiration"
        '
        'lblgname
        '
        Me.lblgname.AutoSize = True
        Me.lblgname.BackColor = System.Drawing.Color.Transparent
        Me.lblgname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgname.ForeColor = System.Drawing.Color.White
        Me.lblgname.Location = New System.Drawing.Point(391, 176)
        Me.lblgname.Name = "lblgname"
        Me.lblgname.Size = New System.Drawing.Size(101, 20)
        Me.lblgname.TabIndex = 10
        Me.lblgname.Text = "Genericname"
        '
        'lblgondola
        '
        Me.lblgondola.AutoSize = True
        Me.lblgondola.BackColor = System.Drawing.Color.Transparent
        Me.lblgondola.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgondola.ForeColor = System.Drawing.Color.White
        Me.lblgondola.Location = New System.Drawing.Point(391, 88)
        Me.lblgondola.Name = "lblgondola"
        Me.lblgondola.Size = New System.Drawing.Size(66, 20)
        Me.lblgondola.TabIndex = 8
        Me.lblgondola.Text = "gondola"
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel7.ForeColor = System.Drawing.Color.White
        Me.FlatLabel7.Location = New System.Drawing.Point(242, 286)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(55, 20)
        Me.FlatLabel7.TabIndex = 7
        Me.FlatLabel7.Text = "FORM:"
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel6.ForeColor = System.Drawing.Color.White
        Me.FlatLabel6.Location = New System.Drawing.Point(242, 251)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(71, 20)
        Me.FlatLabel6.TabIndex = 6
        Me.FlatLabel6.Text = "DOSAGE:"
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.White
        Me.FlatLabel5.Location = New System.Drawing.Point(242, 214)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(136, 20)
        Me.FlatLabel5.TabIndex = 5
        Me.FlatLabel5.Text = "EXPIRATION DATE:"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(242, 176)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(121, 20)
        Me.FlatLabel4.TabIndex = 4
        Me.FlatLabel4.Text = "GENERIC NAME:"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(242, 123)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(112, 20)
        Me.FlatLabel3.TabIndex = 3
        Me.FlatLabel3.Text = "BRAND NAME:"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(242, 88)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(85, 20)
        Me.FlatLabel2.TabIndex = 2
        Me.FlatLabel2.Text = "GONDOLA:"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(21, 84)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(57, 20)
        Me.FlatLabel1.TabIndex = 1
        Me.FlatLabel1.Text = "STOCK:"
        '
        'BunifuCircleProgressbar1
        '
        Me.BunifuCircleProgressbar1.animated = False
        Me.BunifuCircleProgressbar1.animationIterval = 5
        Me.BunifuCircleProgressbar1.animationSpeed = 300
        Me.BunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgressbar1.BackgroundImage = CType(resources.GetObject("BunifuCircleProgressbar1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCircleProgressbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar1.LabelVisible = True
        Me.BunifuCircleProgressbar1.LineProgressThickness = 8
        Me.BunifuCircleProgressbar1.LineThickness = 5
        Me.BunifuCircleProgressbar1.Location = New System.Drawing.Point(25, 117)
        Me.BunifuCircleProgressbar1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.BunifuCircleProgressbar1.MaxValue = 100
        Me.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1"
        Me.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar1.Size = New System.Drawing.Size(163, 163)
        Me.BunifuCircleProgressbar1.TabIndex = 0
        Me.BunifuCircleProgressbar1.Value = 0
        '
        'txtbname
        '
        Me.txtbname.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtbname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtbname.ForeColor = System.Drawing.Color.Transparent
        Me.txtbname.Location = New System.Drawing.Point(391, 117)
        Me.txtbname.Multiline = True
        Me.txtbname.Name = "txtbname"
        Me.txtbname.Size = New System.Drawing.Size(206, 56)
        Me.txtbname.TabIndex = 21
        Me.txtbname.Text = "brandname"
        '
        'details_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(624, 445)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "details_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "details_frm"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As PharmacyInventorySystem.FormSkin
    Friend WithEvents FlatLabel4 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel3 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel2 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel1 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents BunifuCircleProgressbar1 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents FlatLabel5 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents btnEditSave As PharmacyInventorySystem.FlatButton
    Friend WithEvents lblForm As PharmacyInventorySystem.FlatLabel
    Friend WithEvents lbldos As PharmacyInventorySystem.FlatLabel
    Friend WithEvents lblexp As PharmacyInventorySystem.FlatLabel
    Friend WithEvents lblgname As PharmacyInventorySystem.FlatLabel
    Friend WithEvents lblgondola As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel7 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel6 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatLabel10 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents lblprice As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel8 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents pnlEdit As System.Windows.Forms.Panel
    Friend WithEvents txtgon As System.Windows.Forms.TextBox
    Friend WithEvents cbxf As PharmacyInventorySystem.FlatComboBox
    Friend WithEvents txtdsg As PharmacyInventorySystem.FlatTextBox
    Friend WithEvents txtgn As PharmacyInventorySystem.FlatTextBox
    Friend WithEvents txtbn As PharmacyInventorySystem.FlatTextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents dtped As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtbname As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblstocks As PharmacyInventorySystem.FlatLabel
    Friend WithEvents txtStocks As System.Windows.Forms.TextBox
End Class
