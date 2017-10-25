<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventory_form
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Medicine_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmacyDatabaseDataSet = New PharmacyInventorySystem.PharmacyDatabaseDataSet()
        Me.TransItemstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmacyDatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POStransactiontblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Medicine_tblTableAdapter = New PharmacyInventorySystem.PharmacyDatabaseDataSetTableAdapters.medicine_tblTableAdapter()
        Me.TableAdapterManager = New PharmacyInventorySystem.PharmacyDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.frmInventory = New PharmacyInventorySystem.FormSkin()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.FlatMax1 = New PharmacyInventorySystem.FlatMax()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlatMini1 = New PharmacyInventorySystem.FlatMini()
        Me.FlatTabControl1 = New PharmacyInventorySystem.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlAdd = New System.Windows.Forms.Panel()
        Me.txtstock = New PharmacyInventorySystem.FlatTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblPaneltitle = New PharmacyInventorySystem.FlatLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtgondola = New System.Windows.Forms.TextBox()
        Me.btnCancel = New PharmacyInventorySystem.FlatButton()
        Me.btnSave = New PharmacyInventorySystem.FlatButton()
        Me.cbxForm = New PharmacyInventorySystem.FlatComboBox()
        Me.FlatLabel8 = New PharmacyInventorySystem.FlatLabel()
        Me.txtMG = New PharmacyInventorySystem.FlatTextBox()
        Me.FlatLabel7 = New PharmacyInventorySystem.FlatLabel()
        Me.txtprice = New PharmacyInventorySystem.FlatTextBox()
        Me.FlatLabel6 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel5 = New PharmacyInventorySystem.FlatLabel()
        Me.dtpExpire = New System.Windows.Forms.DateTimePicker()
        Me.FlatLabel4 = New PharmacyInventorySystem.FlatLabel()
        Me.txtgname = New PharmacyInventorySystem.FlatTextBox()
        Me.txtbname = New PharmacyInventorySystem.FlatTextBox()
        Me.FlatLabel3 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel2 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel1 = New PharmacyInventorySystem.FlatLabel()
        Me.lblSelItem = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel9 = New PharmacyInventorySystem.FlatLabel()
        Me.btnSrch = New PharmacyInventorySystem.FlatButton()
        Me.txtsrch = New System.Windows.Forms.TextBox()
        Me.btnRem = New PharmacyInventorySystem.FlatButton()
        Me.btnAdd = New PharmacyInventorySystem.FlatButton()
        Me.dtgvMedicine = New System.Windows.Forms.DataGridView()
        Me.GONDOLADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BRANDNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENERICNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXPIRATIONDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSTOCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOSAGEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FORMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnprintSales = New PharmacyInventorySystem.FlatButton()
        Me.dtpTransDate = New System.Windows.Forms.DateTimePicker()
        Me.txtOrnum = New System.Windows.Forms.TextBox()
        Me.cbxFilterby = New PharmacyInventorySystem.FlatComboBox()
        Me.FlatLabel12 = New PharmacyInventorySystem.FlatLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtgvPOSitems = New System.Windows.Forms.DataGridView()
        Me.ORNUMBERDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRICEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALPRICEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtgvPOS = New System.Windows.Forms.DataGridView()
        Me.ORNUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRANSDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CASHIERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VATABLESALESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALSALESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlatLabel11 = New PharmacyInventorySystem.FlatLabel()
        Me.FlatLabel10 = New PharmacyInventorySystem.FlatLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FlatLabel13 = New PharmacyInventorySystem.FlatLabel()
        Me.cbxFilterCrit = New PharmacyInventorySystem.FlatComboBox()
        Me.FlatButton1 = New PharmacyInventorySystem.FlatButton()
        Me.dtgvcrit = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcoountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MedListStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medicine_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransItemstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POStransactiontblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmInventory.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlAdd.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvMedicine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dtgvPOSitems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgvPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgvcrit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.PharmacyInventorySystem.My.Resources.Resources.icon_help_dark
        Me.PictureBox4.Location = New System.Drawing.Point(425, 30)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Please Input your search in the textbox." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you can search it by:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BRAND NAME or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G" & _
        "ONDOLA")
        '
        'Medicine_tblBindingSource
        '
        Me.Medicine_tblBindingSource.DataMember = "medicine_tbl"
        Me.Medicine_tblBindingSource.DataSource = Me.PharmacyDatabaseDataSet
        '
        'PharmacyDatabaseDataSet
        '
        Me.PharmacyDatabaseDataSet.DataSetName = "PharmacyDatabaseDataSet"
        Me.PharmacyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransItemstblBindingSource
        '
        Me.TransItemstblBindingSource.DataMember = "transItems_tbl"
        Me.TransItemstblBindingSource.DataSource = Me.PharmacyDatabaseDataSetBindingSource
        '
        'PharmacyDatabaseDataSetBindingSource
        '
        Me.PharmacyDatabaseDataSetBindingSource.DataSource = Me.PharmacyDatabaseDataSet
        Me.PharmacyDatabaseDataSetBindingSource.Position = 0
        '
        'POStransactiontblBindingSource
        '
        Me.POStransactiontblBindingSource.DataMember = "POStransaction_tbl"
        Me.POStransactiontblBindingSource.DataSource = Me.PharmacyDatabaseDataSetBindingSource
        '
        'Medicine_tblTableAdapter
        '
        Me.Medicine_tblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.medicine_tblTableAdapter = Me.Medicine_tblTableAdapter
        Me.TableAdapterManager.POStransaction_tblTableAdapter = Nothing
        Me.TableAdapterManager.tempItems_tblTableAdapter = Nothing
        Me.TableAdapterManager.transItems_tblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PharmacyInventorySystem.PharmacyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.users_tblTableAdapter = Nothing
        '
        'frmInventory
        '
        Me.frmInventory.BackColor = System.Drawing.Color.White
        Me.frmInventory.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.frmInventory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.frmInventory.Controls.Add(Me.PictureBox5)
        Me.frmInventory.Controls.Add(Me.FlatMax1)
        Me.frmInventory.Controls.Add(Me.PictureBox1)
        Me.frmInventory.Controls.Add(Me.FlatMini1)
        Me.frmInventory.Controls.Add(Me.FlatTabControl1)
        Me.frmInventory.Controls.Add(Me.MenuStrip1)
        Me.frmInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmInventory.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.frmInventory.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.frmInventory.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.frmInventory.HeaderMaximize = False
        Me.frmInventory.Location = New System.Drawing.Point(0, 0)
        Me.frmInventory.Name = "frmInventory"
        Me.frmInventory.Size = New System.Drawing.Size(1130, 740)
        Me.frmInventory.TabIndex = 0
        Me.frmInventory.Text = "   Inventory Management System"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PictureBox5.Image = Global.PharmacyInventorySystem.My.Resources.Resources._1600
        Me.PictureBox5.Location = New System.Drawing.Point(7, 9)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(33, 35)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'FlatMax1
        '
        Me.FlatMax1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMax1.BackColor = System.Drawing.Color.White
        Me.FlatMax1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMax1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMax1.Location = New System.Drawing.Point(1060, 13)
        Me.FlatMax1.Name = "FlatMax1"
        Me.FlatMax1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMax1.TabIndex = 4
        Me.FlatMax1.Text = "FlatMax1"
        Me.FlatMax1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.PharmacyInventorySystem.My.Resources.Resources.delete_1_icon
        Me.PictureBox1.Location = New System.Drawing.Point(1091, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(1032, 13)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 2
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage3)
        Me.FlatTabControl1.Controls.Add(Me.TabPage4)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(12, 100)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(1106, 628)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.pnlAdd)
        Me.TabPage1.Controls.Add(Me.lblSelItem)
        Me.TabPage1.Controls.Add(Me.FlatLabel9)
        Me.TabPage1.Controls.Add(Me.PictureBox4)
        Me.TabPage1.Controls.Add(Me.btnSrch)
        Me.TabPage1.Controls.Add(Me.txtsrch)
        Me.TabPage1.Controls.Add(Me.btnRem)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.dtgvMedicine)
        Me.TabPage1.ImageKey = "(none)"
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1098, 580)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Medicine List"
        '
        'pnlAdd
        '
        Me.pnlAdd.BackColor = System.Drawing.Color.Transparent
        Me.pnlAdd.Controls.Add(Me.txtstock)
        Me.pnlAdd.Controls.Add(Me.Panel2)
        Me.pnlAdd.Controls.Add(Me.txtgondola)
        Me.pnlAdd.Controls.Add(Me.btnCancel)
        Me.pnlAdd.Controls.Add(Me.btnSave)
        Me.pnlAdd.Controls.Add(Me.cbxForm)
        Me.pnlAdd.Controls.Add(Me.FlatLabel8)
        Me.pnlAdd.Controls.Add(Me.txtMG)
        Me.pnlAdd.Controls.Add(Me.FlatLabel7)
        Me.pnlAdd.Controls.Add(Me.txtprice)
        Me.pnlAdd.Controls.Add(Me.FlatLabel6)
        Me.pnlAdd.Controls.Add(Me.FlatLabel5)
        Me.pnlAdd.Controls.Add(Me.dtpExpire)
        Me.pnlAdd.Controls.Add(Me.FlatLabel4)
        Me.pnlAdd.Controls.Add(Me.txtgname)
        Me.pnlAdd.Controls.Add(Me.txtbname)
        Me.pnlAdd.Controls.Add(Me.FlatLabel3)
        Me.pnlAdd.Controls.Add(Me.FlatLabel2)
        Me.pnlAdd.Controls.Add(Me.FlatLabel1)
        Me.pnlAdd.Location = New System.Drawing.Point(277, 134)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(673, 364)
        Me.pnlAdd.TabIndex = 3
        Me.pnlAdd.Visible = False
        '
        'txtstock
        '
        Me.txtstock.BackColor = System.Drawing.Color.Transparent
        Me.txtstock.Location = New System.Drawing.Point(148, 212)
        Me.txtstock.MaxLength = 32767
        Me.txtstock.Multiline = False
        Me.txtstock.Name = "txtstock"
        Me.txtstock.ReadOnly = False
        Me.txtstock.Size = New System.Drawing.Size(164, 29)
        Me.txtstock.TabIndex = 29
        Me.txtstock.Text = "0"
        Me.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtstock.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtstock.UseSystemPasswordChar = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.lblPaneltitle)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(673, 46)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.PharmacyInventorySystem.My.Resources.Resources.delete_1_icon
        Me.PictureBox3.Location = New System.Drawing.Point(639, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'lblPaneltitle
        '
        Me.lblPaneltitle.AutoSize = True
        Me.lblPaneltitle.BackColor = System.Drawing.Color.Transparent
        Me.lblPaneltitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblPaneltitle.ForeColor = System.Drawing.Color.White
        Me.lblPaneltitle.Location = New System.Drawing.Point(49, 18)
        Me.lblPaneltitle.Name = "lblPaneltitle"
        Me.lblPaneltitle.Size = New System.Drawing.Size(112, 13)
        Me.lblPaneltitle.TabIndex = 2
        Me.lblPaneltitle.Text = "ADD NEW MEDICINE"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PharmacyInventorySystem.My.Resources.Resources.icons8_Add_List_961
        Me.PictureBox2.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'txtgondola
        '
        Me.txtgondola.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtgondola.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgondola.Location = New System.Drawing.Point(148, 70)
        Me.txtgondola.Name = "txtgondola"
        Me.txtgondola.Size = New System.Drawing.Size(164, 25)
        Me.txtgondola.TabIndex = 19
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCancel.Location = New System.Drawing.Point(383, 293)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Rounded = False
        Me.btnCancel.Size = New System.Drawing.Size(106, 32)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(527, 293)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Rounded = False
        Me.btnSave.Size = New System.Drawing.Size(106, 32)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cbxForm
        '
        Me.cbxForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cbxForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxForm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxForm.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.cbxForm.ForeColor = System.Drawing.Color.White
        Me.cbxForm.FormattingEnabled = True
        Me.cbxForm.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cbxForm.ItemHeight = 18
        Me.cbxForm.Items.AddRange(New Object() {"CAPSULE", "TABLET", "SYRUP", "CREAM", "POWDER", "SOLUTION", "AMPOULES", "CLEANSER", "SOAP", "GRANULES", "SUSPENSION", "OINTMENT", "INHALER", "SHAMPOO", "GEL"})
        Me.cbxForm.Location = New System.Drawing.Point(469, 196)
        Me.cbxForm.Name = "cbxForm"
        Me.cbxForm.Size = New System.Drawing.Size(164, 24)
        Me.cbxForm.TabIndex = 26
        '
        'FlatLabel8
        '
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel8.ForeColor = System.Drawing.Color.White
        Me.FlatLabel8.Location = New System.Drawing.Point(411, 200)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(52, 20)
        Me.FlatLabel8.TabIndex = 15
        Me.FlatLabel8.Text = "FORM:"
        '
        'txtMG
        '
        Me.txtMG.BackColor = System.Drawing.Color.Transparent
        Me.txtMG.Location = New System.Drawing.Point(148, 296)
        Me.txtMG.MaxLength = 32767
        Me.txtMG.Multiline = False
        Me.txtMG.Name = "txtMG"
        Me.txtMG.ReadOnly = False
        Me.txtMG.Size = New System.Drawing.Size(164, 29)
        Me.txtMG.TabIndex = 25
        Me.txtMG.Text = "0"
        Me.txtMG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMG.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMG.UseSystemPasswordChar = False
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel7.ForeColor = System.Drawing.Color.White
        Me.FlatLabel7.Location = New System.Drawing.Point(34, 305)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(70, 20)
        Me.FlatLabel7.TabIndex = 13
        Me.FlatLabel7.Text = "DOSAGE:"
        '
        'txtprice
        '
        Me.txtprice.BackColor = System.Drawing.Color.Transparent
        Me.txtprice.Location = New System.Drawing.Point(148, 253)
        Me.txtprice.MaxLength = 32767
        Me.txtprice.Multiline = False
        Me.txtprice.Name = "txtprice"
        Me.txtprice.ReadOnly = False
        Me.txtprice.Size = New System.Drawing.Size(164, 29)
        Me.txtprice.TabIndex = 24
        Me.txtprice.Text = "0"
        Me.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtprice.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtprice.UseSystemPasswordChar = False
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel6.ForeColor = System.Drawing.Color.White
        Me.FlatLabel6.Location = New System.Drawing.Point(34, 262)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(50, 20)
        Me.FlatLabel6.TabIndex = 11
        Me.FlatLabel6.Text = "PRICE:"
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.White
        Me.FlatLabel5.Location = New System.Drawing.Point(34, 216)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(75, 20)
        Me.FlatLabel5.TabIndex = 9
        Me.FlatLabel5.Text = "IN STOCK:"
        '
        'dtpExpire
        '
        Me.dtpExpire.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.dtpExpire.Location = New System.Drawing.Point(168, 158)
        Me.dtpExpire.Name = "dtpExpire"
        Me.dtpExpire.Size = New System.Drawing.Size(232, 25)
        Me.dtpExpire.TabIndex = 22
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(34, 162)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(133, 20)
        Me.FlatLabel4.TabIndex = 7
        Me.FlatLabel4.Text = "EXPIRATION DATE:"
        '
        'txtgname
        '
        Me.txtgname.BackColor = System.Drawing.Color.Transparent
        Me.txtgname.Location = New System.Drawing.Point(469, 107)
        Me.txtgname.MaxLength = 32767
        Me.txtgname.Multiline = False
        Me.txtgname.Name = "txtgname"
        Me.txtgname.ReadOnly = False
        Me.txtgname.Size = New System.Drawing.Size(164, 29)
        Me.txtgname.TabIndex = 21
        Me.txtgname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtgname.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtgname.UseSystemPasswordChar = False
        '
        'txtbname
        '
        Me.txtbname.BackColor = System.Drawing.Color.Transparent
        Me.txtbname.Location = New System.Drawing.Point(148, 107)
        Me.txtbname.MaxLength = 32767
        Me.txtbname.Multiline = False
        Me.txtbname.Name = "txtbname"
        Me.txtbname.ReadOnly = False
        Me.txtbname.Size = New System.Drawing.Size(164, 29)
        Me.txtbname.TabIndex = 20
        Me.txtbname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtbname.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtbname.UseSystemPasswordChar = False
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(346, 116)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(117, 20)
        Me.FlatLabel3.TabIndex = 4
        Me.FlatLabel3.Text = "GENERIC NAME:"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(34, 116)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(108, 20)
        Me.FlatLabel2.TabIndex = 2
        Me.FlatLabel2.Text = "BRAND NAME:"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(34, 71)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(83, 20)
        Me.FlatLabel1.TabIndex = 1
        Me.FlatLabel1.Text = "GONDOLA:"
        '
        'lblSelItem
        '
        Me.lblSelItem.AutoSize = True
        Me.lblSelItem.BackColor = System.Drawing.Color.Transparent
        Me.lblSelItem.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelItem.ForeColor = System.Drawing.Color.Red
        Me.lblSelItem.Location = New System.Drawing.Point(600, 30)
        Me.lblSelItem.Name = "lblSelItem"
        Me.lblSelItem.Size = New System.Drawing.Size(0, 20)
        Me.lblSelItem.TabIndex = 8
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel9.ForeColor = System.Drawing.Color.White
        Me.FlatLabel9.Location = New System.Drawing.Point(498, 30)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(104, 20)
        Me.FlatLabel9.TabIndex = 7
        Me.FlatLabel9.Text = "Selected Item:"
        '
        'btnSrch
        '
        Me.btnSrch.BackColor = System.Drawing.Color.Transparent
        Me.btnSrch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSrch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSrch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSrch.Location = New System.Drawing.Point(354, 27)
        Me.btnSrch.Name = "btnSrch"
        Me.btnSrch.Rounded = False
        Me.btnSrch.Size = New System.Drawing.Size(65, 29)
        Me.btnSrch.TabIndex = 5
        Me.btnSrch.Text = "Search"
        Me.btnSrch.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtsrch
        '
        Me.txtsrch.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrch.Location = New System.Drawing.Point(138, 27)
        Me.txtsrch.Name = "txtsrch"
        Me.txtsrch.Size = New System.Drawing.Size(210, 29)
        Me.txtsrch.TabIndex = 4
        '
        'btnRem
        '
        Me.btnRem.BackColor = System.Drawing.Color.Transparent
        Me.btnRem.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnRem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRem.Location = New System.Drawing.Point(15, 124)
        Me.btnRem.Name = "btnRem"
        Me.btnRem.Rounded = False
        Me.btnRem.Size = New System.Drawing.Size(106, 32)
        Me.btnRem.TabIndex = 2
        Me.btnRem.Text = "DELETE"
        Me.btnRem.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(15, 70)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Rounded = False
        Me.btnAdd.Size = New System.Drawing.Size(106, 32)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'dtgvMedicine
        '
        Me.dtgvMedicine.AllowUserToAddRows = False
        Me.dtgvMedicine.AllowUserToDeleteRows = False
        Me.dtgvMedicine.AllowUserToResizeRows = False
        Me.dtgvMedicine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgvMedicine.AutoGenerateColumns = False
        Me.dtgvMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvMedicine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgvMedicine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dtgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvMedicine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GONDOLADataGridViewTextBoxColumn, Me.BRANDNAMEDataGridViewTextBoxColumn, Me.GENERICNAMEDataGridViewTextBoxColumn, Me.EXPIRATIONDATEDataGridViewTextBoxColumn, Me.INSTOCKDataGridViewTextBoxColumn, Me.PRICEDataGridViewTextBoxColumn, Me.DOSAGEDataGridViewTextBoxColumn, Me.FORMDataGridViewTextBoxColumn})
        Me.dtgvMedicine.DataSource = Me.Medicine_tblBindingSource
        Me.dtgvMedicine.Location = New System.Drawing.Point(138, 70)
        Me.dtgvMedicine.MultiSelect = False
        Me.dtgvMedicine.Name = "dtgvMedicine"
        Me.dtgvMedicine.ReadOnly = True
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        Me.dtgvMedicine.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvMedicine.Size = New System.Drawing.Size(954, 510)
        Me.dtgvMedicine.TabIndex = 0
        '
        'GONDOLADataGridViewTextBoxColumn
        '
        Me.GONDOLADataGridViewTextBoxColumn.DataPropertyName = "GONDOLA"
        Me.GONDOLADataGridViewTextBoxColumn.HeaderText = "GONDOLA"
        Me.GONDOLADataGridViewTextBoxColumn.Name = "GONDOLADataGridViewTextBoxColumn"
        Me.GONDOLADataGridViewTextBoxColumn.ReadOnly = True
        Me.GONDOLADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'BRANDNAMEDataGridViewTextBoxColumn
        '
        Me.BRANDNAMEDataGridViewTextBoxColumn.DataPropertyName = "BRANDNAME"
        Me.BRANDNAMEDataGridViewTextBoxColumn.HeaderText = "BRANDNAME"
        Me.BRANDNAMEDataGridViewTextBoxColumn.Name = "BRANDNAMEDataGridViewTextBoxColumn"
        Me.BRANDNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GENERICNAMEDataGridViewTextBoxColumn
        '
        Me.GENERICNAMEDataGridViewTextBoxColumn.DataPropertyName = "GENERICNAME"
        Me.GENERICNAMEDataGridViewTextBoxColumn.HeaderText = "GENERICNAME"
        Me.GENERICNAMEDataGridViewTextBoxColumn.Name = "GENERICNAMEDataGridViewTextBoxColumn"
        Me.GENERICNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EXPIRATIONDATEDataGridViewTextBoxColumn
        '
        Me.EXPIRATIONDATEDataGridViewTextBoxColumn.DataPropertyName = "EXPIRATION_DATE"
        Me.EXPIRATIONDATEDataGridViewTextBoxColumn.HeaderText = "EXPIRATION_DATE"
        Me.EXPIRATIONDATEDataGridViewTextBoxColumn.Name = "EXPIRATIONDATEDataGridViewTextBoxColumn"
        Me.EXPIRATIONDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.EXPIRATIONDATEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'INSTOCKDataGridViewTextBoxColumn
        '
        Me.INSTOCKDataGridViewTextBoxColumn.DataPropertyName = "IN_STOCK"
        Me.INSTOCKDataGridViewTextBoxColumn.HeaderText = "IN_STOCK"
        Me.INSTOCKDataGridViewTextBoxColumn.Name = "INSTOCKDataGridViewTextBoxColumn"
        Me.INSTOCKDataGridViewTextBoxColumn.ReadOnly = True
        Me.INSTOCKDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PRICEDataGridViewTextBoxColumn
        '
        Me.PRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE"
        Me.PRICEDataGridViewTextBoxColumn.HeaderText = "PRICE"
        Me.PRICEDataGridViewTextBoxColumn.Name = "PRICEDataGridViewTextBoxColumn"
        Me.PRICEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRICEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DOSAGEDataGridViewTextBoxColumn
        '
        Me.DOSAGEDataGridViewTextBoxColumn.DataPropertyName = "DOSAGE"
        Me.DOSAGEDataGridViewTextBoxColumn.HeaderText = "DOSAGE"
        Me.DOSAGEDataGridViewTextBoxColumn.Name = "DOSAGEDataGridViewTextBoxColumn"
        Me.DOSAGEDataGridViewTextBoxColumn.ReadOnly = True
        Me.DOSAGEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FORMDataGridViewTextBoxColumn
        '
        Me.FORMDataGridViewTextBoxColumn.DataPropertyName = "FORM"
        Me.FORMDataGridViewTextBoxColumn.HeaderText = "FORM"
        Me.FORMDataGridViewTextBoxColumn.Name = "FORMDataGridViewTextBoxColumn"
        Me.FORMDataGridViewTextBoxColumn.ReadOnly = True
        Me.FORMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1098, 580)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Orders"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.btnprintSales)
        Me.TabPage4.Controls.Add(Me.dtpTransDate)
        Me.TabPage4.Controls.Add(Me.txtOrnum)
        Me.TabPage4.Controls.Add(Me.cbxFilterby)
        Me.TabPage4.Controls.Add(Me.FlatLabel12)
        Me.TabPage4.Controls.Add(Me.Panel3)
        Me.TabPage4.Controls.Add(Me.Panel1)
        Me.TabPage4.Controls.Add(Me.FlatLabel11)
        Me.TabPage4.Controls.Add(Me.FlatLabel10)
        Me.TabPage4.Location = New System.Drawing.Point(4, 44)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1098, 580)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Sale Transactions"
        '
        'btnprintSales
        '
        Me.btnprintSales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnprintSales.BackColor = System.Drawing.Color.Transparent
        Me.btnprintSales.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnprintSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprintSales.Enabled = False
        Me.btnprintSales.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnprintSales.Location = New System.Drawing.Point(665, 33)
        Me.btnprintSales.Name = "btnprintSales"
        Me.btnprintSales.Rounded = False
        Me.btnprintSales.Size = New System.Drawing.Size(172, 27)
        Me.btnprintSales.TabIndex = 9
        Me.btnprintSales.Text = "PRINT SALES REPORT"
        Me.btnprintSales.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'dtpTransDate
        '
        Me.dtpTransDate.Enabled = False
        Me.dtpTransDate.Location = New System.Drawing.Point(444, 33)
        Me.dtpTransDate.Name = "dtpTransDate"
        Me.dtpTransDate.Size = New System.Drawing.Size(215, 25)
        Me.dtpTransDate.TabIndex = 8
        '
        'txtOrnum
        '
        Me.txtOrnum.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtOrnum.Enabled = False
        Me.txtOrnum.ForeColor = System.Drawing.Color.White
        Me.txtOrnum.Location = New System.Drawing.Point(277, 33)
        Me.txtOrnum.Name = "txtOrnum"
        Me.txtOrnum.Size = New System.Drawing.Size(161, 25)
        Me.txtOrnum.TabIndex = 7
        '
        'cbxFilterby
        '
        Me.cbxFilterby.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cbxFilterby.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxFilterby.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxFilterby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFilterby.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.cbxFilterby.ForeColor = System.Drawing.Color.White
        Me.cbxFilterby.FormattingEnabled = True
        Me.cbxFilterby.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cbxFilterby.ItemHeight = 18
        Me.cbxFilterby.Items.AddRange(New Object() {"OR NUMBER", "TRANSACTION DATE", "SHOW ALL"})
        Me.cbxFilterby.Location = New System.Drawing.Point(92, 34)
        Me.cbxFilterby.Name = "cbxFilterby"
        Me.cbxFilterby.Size = New System.Drawing.Size(179, 24)
        Me.cbxFilterby.TabIndex = 6
        '
        'FlatLabel12
        '
        Me.FlatLabel12.AutoSize = True
        Me.FlatLabel12.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel12.ForeColor = System.Drawing.Color.White
        Me.FlatLabel12.Location = New System.Drawing.Point(22, 35)
        Me.FlatLabel12.Name = "FlatLabel12"
        Me.FlatLabel12.Size = New System.Drawing.Size(73, 21)
        Me.FlatLabel12.TabIndex = 5
        Me.FlatLabel12.Text = "Filter By:"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.dtgvPOSitems)
        Me.Panel3.Location = New System.Drawing.Point(26, 360)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1036, 220)
        Me.Panel3.TabIndex = 1
        '
        'dtgvPOSitems
        '
        Me.dtgvPOSitems.AllowUserToAddRows = False
        Me.dtgvPOSitems.AllowUserToDeleteRows = False
        Me.dtgvPOSitems.AllowUserToResizeRows = False
        Me.dtgvPOSitems.AutoGenerateColumns = False
        Me.dtgvPOSitems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvPOSitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvPOSitems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ORNUMBERDataGridViewTextBoxColumn1, Me.PRODUCTCODEDataGridViewTextBoxColumn, Me.DESCRIPTIONDataGridViewTextBoxColumn, Me.PRICEDataGridViewTextBoxColumn1, Me.QUANTITYDataGridViewTextBoxColumn, Me.TOTALPRICEDataGridViewTextBoxColumn1})
        Me.dtgvPOSitems.DataSource = Me.TransItemstblBindingSource
        Me.dtgvPOSitems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgvPOSitems.Location = New System.Drawing.Point(0, 0)
        Me.dtgvPOSitems.Name = "dtgvPOSitems"
        Me.dtgvPOSitems.ReadOnly = True
        Me.dtgvPOSitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvPOSitems.Size = New System.Drawing.Size(1036, 220)
        Me.dtgvPOSitems.TabIndex = 1
        '
        'ORNUMBERDataGridViewTextBoxColumn1
        '
        Me.ORNUMBERDataGridViewTextBoxColumn1.DataPropertyName = "OR_NUMBER"
        Me.ORNUMBERDataGridViewTextBoxColumn1.HeaderText = "OR_NUMBER"
        Me.ORNUMBERDataGridViewTextBoxColumn1.Name = "ORNUMBERDataGridViewTextBoxColumn1"
        Me.ORNUMBERDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PRODUCTCODEDataGridViewTextBoxColumn
        '
        Me.PRODUCTCODEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_CODE"
        Me.PRODUCTCODEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_CODE"
        Me.PRODUCTCODEDataGridViewTextBoxColumn.Name = "PRODUCTCODEDataGridViewTextBoxColumn"
        Me.PRODUCTCODEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.DESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION"
        Me.DESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION"
        Me.DESCRIPTIONDataGridViewTextBoxColumn.Name = "DESCRIPTIONDataGridViewTextBoxColumn"
        Me.DESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRICEDataGridViewTextBoxColumn1
        '
        Me.PRICEDataGridViewTextBoxColumn1.DataPropertyName = "PRICE"
        Me.PRICEDataGridViewTextBoxColumn1.HeaderText = "PRICE"
        Me.PRICEDataGridViewTextBoxColumn1.Name = "PRICEDataGridViewTextBoxColumn1"
        Me.PRICEDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'QUANTITYDataGridViewTextBoxColumn
        '
        Me.QUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.Name = "QUANTITYDataGridViewTextBoxColumn"
        Me.QUANTITYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALPRICEDataGridViewTextBoxColumn1
        '
        Me.TOTALPRICEDataGridViewTextBoxColumn1.DataPropertyName = "TOTAL_PRICE"
        Me.TOTALPRICEDataGridViewTextBoxColumn1.HeaderText = "TOTAL_PRICE"
        Me.TOTALPRICEDataGridViewTextBoxColumn1.Name = "TOTALPRICEDataGridViewTextBoxColumn1"
        Me.TOTALPRICEDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.dtgvPOS)
        Me.Panel1.Location = New System.Drawing.Point(26, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1036, 252)
        Me.Panel1.TabIndex = 4
        '
        'dtgvPOS
        '
        Me.dtgvPOS.AllowUserToAddRows = False
        Me.dtgvPOS.AllowUserToDeleteRows = False
        Me.dtgvPOS.AllowUserToResizeRows = False
        Me.dtgvPOS.AutoGenerateColumns = False
        Me.dtgvPOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvPOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ORNUMBERDataGridViewTextBoxColumn, Me.TRANSDATEDataGridViewTextBoxColumn, Me.CASHIERDataGridViewTextBoxColumn, Me.TOTALPRICEDataGridViewTextBoxColumn, Me.VATABLESALESDataGridViewTextBoxColumn, Me.VATDataGridViewTextBoxColumn, Me.TOTALSALESDataGridViewTextBoxColumn})
        Me.dtgvPOS.DataSource = Me.POStransactiontblBindingSource
        Me.dtgvPOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgvPOS.Location = New System.Drawing.Point(0, 0)
        Me.dtgvPOS.Name = "dtgvPOS"
        Me.dtgvPOS.ReadOnly = True
        Me.dtgvPOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvPOS.Size = New System.Drawing.Size(1036, 252)
        Me.dtgvPOS.TabIndex = 0
        '
        'ORNUMBERDataGridViewTextBoxColumn
        '
        Me.ORNUMBERDataGridViewTextBoxColumn.DataPropertyName = "OR_NUMBER"
        Me.ORNUMBERDataGridViewTextBoxColumn.HeaderText = "OR_NUMBER"
        Me.ORNUMBERDataGridViewTextBoxColumn.Name = "ORNUMBERDataGridViewTextBoxColumn"
        Me.ORNUMBERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TRANSDATEDataGridViewTextBoxColumn
        '
        Me.TRANSDATEDataGridViewTextBoxColumn.DataPropertyName = "TRANS_DATE"
        Me.TRANSDATEDataGridViewTextBoxColumn.HeaderText = "TRANS_DATE"
        Me.TRANSDATEDataGridViewTextBoxColumn.Name = "TRANSDATEDataGridViewTextBoxColumn"
        Me.TRANSDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CASHIERDataGridViewTextBoxColumn
        '
        Me.CASHIERDataGridViewTextBoxColumn.DataPropertyName = "CASHIER"
        Me.CASHIERDataGridViewTextBoxColumn.HeaderText = "CASHIER"
        Me.CASHIERDataGridViewTextBoxColumn.Name = "CASHIERDataGridViewTextBoxColumn"
        Me.CASHIERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALPRICEDataGridViewTextBoxColumn
        '
        Me.TOTALPRICEDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_PRICE"
        Me.TOTALPRICEDataGridViewTextBoxColumn.HeaderText = "TOTAL_PRICE"
        Me.TOTALPRICEDataGridViewTextBoxColumn.Name = "TOTALPRICEDataGridViewTextBoxColumn"
        Me.TOTALPRICEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VATABLESALESDataGridViewTextBoxColumn
        '
        Me.VATABLESALESDataGridViewTextBoxColumn.DataPropertyName = "VATABLE_SALES"
        Me.VATABLESALESDataGridViewTextBoxColumn.HeaderText = "VATABLE_SALES"
        Me.VATABLESALESDataGridViewTextBoxColumn.Name = "VATABLESALESDataGridViewTextBoxColumn"
        Me.VATABLESALESDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VATDataGridViewTextBoxColumn
        '
        Me.VATDataGridViewTextBoxColumn.DataPropertyName = "VAT"
        Me.VATDataGridViewTextBoxColumn.HeaderText = "VAT"
        Me.VATDataGridViewTextBoxColumn.Name = "VATDataGridViewTextBoxColumn"
        Me.VATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALSALESDataGridViewTextBoxColumn
        '
        Me.TOTALSALESDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_SALES"
        Me.TOTALSALESDataGridViewTextBoxColumn.HeaderText = "TOTAL_SALES"
        Me.TOTALSALESDataGridViewTextBoxColumn.Name = "TOTALSALESDataGridViewTextBoxColumn"
        Me.TOTALSALESDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FlatLabel11
        '
        Me.FlatLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatLabel11.AutoSize = True
        Me.FlatLabel11.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel11.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel11.ForeColor = System.Drawing.Color.White
        Me.FlatLabel11.Location = New System.Drawing.Point(841, 327)
        Me.FlatLabel11.Name = "FlatLabel11"
        Me.FlatLabel11.Size = New System.Drawing.Size(221, 30)
        Me.FlatLabel11.TabIndex = 3
        Me.FlatLabel11.Text = "TRANSACTION ITEMS"
        '
        'FlatLabel10
        '
        Me.FlatLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel10.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel10.ForeColor = System.Drawing.Color.White
        Me.FlatLabel10.Location = New System.Drawing.Point(895, 28)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New System.Drawing.Size(167, 30)
        Me.FlatLabel10.TabIndex = 2
        Me.FlatLabel10.Text = "TRANSACTIONS"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.FlatLabel13)
        Me.TabPage2.Controls.Add(Me.cbxFilterCrit)
        Me.TabPage2.Controls.Add(Me.FlatButton1)
        Me.TabPage2.Controls.Add(Me.dtgvcrit)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1098, 580)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Critical Items"
        '
        'FlatLabel13
        '
        Me.FlatLabel13.AutoSize = True
        Me.FlatLabel13.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel13.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel13.ForeColor = System.Drawing.Color.White
        Me.FlatLabel13.Location = New System.Drawing.Point(76, 24)
        Me.FlatLabel13.Name = "FlatLabel13"
        Me.FlatLabel13.Size = New System.Drawing.Size(78, 20)
        Me.FlatLabel13.TabIndex = 11
        Me.FlatLabel13.Text = "FILTER BY:"
        '
        'cbxFilterCrit
        '
        Me.cbxFilterCrit.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cbxFilterCrit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxFilterCrit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxFilterCrit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFilterCrit.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.cbxFilterCrit.ForeColor = System.Drawing.Color.White
        Me.cbxFilterCrit.FormattingEnabled = True
        Me.cbxFilterCrit.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cbxFilterCrit.ItemHeight = 18
        Me.cbxFilterCrit.Items.AddRange(New Object() {"EXPIRED MEDICINES", "CRITICAL STOCKS", "Show EXPIRED & CRITICAL STOCKS"})
        Me.cbxFilterCrit.Location = New System.Drawing.Point(160, 24)
        Me.cbxFilterCrit.Name = "cbxFilterCrit"
        Me.cbxFilterCrit.Size = New System.Drawing.Size(212, 24)
        Me.cbxFilterCrit.TabIndex = 10
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Enabled = False
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(742, 16)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(283, 32)
        Me.FlatButton1.TabIndex = 9
        Me.FlatButton1.Text = "PRINT ALL TO ORDER REPORT"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'dtgvcrit
        '
        Me.dtgvcrit.AllowUserToAddRows = False
        Me.dtgvcrit.AllowUserToDeleteRows = False
        Me.dtgvcrit.AllowUserToResizeRows = False
        Me.dtgvcrit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgvcrit.AutoGenerateColumns = False
        Me.dtgvcrit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvcrit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgvcrit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dtgvcrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvcrit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dtgvcrit.DataSource = Me.Medicine_tblBindingSource
        Me.dtgvcrit.Location = New System.Drawing.Point(71, 54)
        Me.dtgvcrit.MultiSelect = False
        Me.dtgvcrit.Name = "dtgvcrit"
        Me.dtgvcrit.ReadOnly = True
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(2)
        Me.dtgvcrit.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgvcrit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvcrit.Size = New System.Drawing.Size(954, 510)
        Me.dtgvcrit.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "GONDOLA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "GONDOLA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BRANDNAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BRANDNAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GENERICNAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "GENERICNAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EXPIRATION_DATE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "EXPIRATION_DATE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IN_STOCK"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IN_STOCK"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PRICE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PRICE"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DOSAGE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DOSAGE"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FORM"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FORM"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ManageToolStripMenuItem, Me.ViewToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 50)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(252, 29)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.AcoountToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.MainMenuToolStripMenuItem.Text = "Main menu"
        '
        'AcoountToolStripMenuItem
        '
        Me.AcoountToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.AcoountToolStripMenuItem.Enabled = False
        Me.AcoountToolStripMenuItem.Name = "AcoountToolStripMenuItem"
        Me.AcoountToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.AcoountToolStripMenuItem.Text = "Account"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.ShowShortcutKeys = False
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.LogoutToolStripMenuItem.Text = "Exit"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem, Me.BackupToolStripMenuItem})
        Me.ManageToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(78, 25)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.BackupToolStripMenuItem.Text = "Backup Database"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CriticalToolStripMenuItem, Me.ToolStripSeparator1, Me.MedListStripMenuItem1, Me.TransStripMenuItem1})
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(56, 25)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'CriticalToolStripMenuItem
        '
        Me.CriticalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CriticalToolStripMenuItem.CheckOnClick = True
        Me.CriticalToolStripMenuItem.Name = "CriticalToolStripMenuItem"
        Me.CriticalToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.CriticalToolStripMenuItem.Text = "Critical Items"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(167, 6)
        '
        'MedListStripMenuItem1
        '
        Me.MedListStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MedListStripMenuItem1.Checked = True
        Me.MedListStripMenuItem1.CheckOnClick = True
        Me.MedListStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MedListStripMenuItem1.Name = "MedListStripMenuItem1"
        Me.MedListStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.MedListStripMenuItem1.ShowShortcutKeys = False
        Me.MedListStripMenuItem1.Size = New System.Drawing.Size(170, 26)
        Me.MedListStripMenuItem1.Text = "Medicine List"
        '
        'TransStripMenuItem1
        '
        Me.TransStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TransStripMenuItem1.CheckOnClick = True
        Me.TransStripMenuItem1.Name = "TransStripMenuItem1"
        Me.TransStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.TransStripMenuItem1.ShowShortcutKeys = False
        Me.TransStripMenuItem1.Size = New System.Drawing.Size(170, 26)
        Me.TransStripMenuItem1.Text = "Transactions"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'inventory_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 740)
        Me.Controls.Add(Me.frmInventory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "inventory_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inventory_form"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medicine_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransItemstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POStransactiontblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmInventory.ResumeLayout(False)
        Me.frmInventory.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.pnlAdd.ResumeLayout(False)
        Me.pnlAdd.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvMedicine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dtgvPOSitems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtgvPOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dtgvcrit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmInventory As PharmacyInventorySystem.FormSkin
    Friend WithEvents PharmacyDatabaseDataSet As PharmacyInventorySystem.PharmacyDatabaseDataSet
    Friend WithEvents Medicine_tblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Medicine_tblTableAdapter As PharmacyInventorySystem.PharmacyDatabaseDataSetTableAdapters.medicine_tblTableAdapter
    Friend WithEvents TableAdapterManager As PharmacyInventorySystem.PharmacyDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FlatMini1 As PharmacyInventorySystem.FlatMini
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FlatMax1 As PharmacyInventorySystem.FlatMax
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcoountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MedListStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PharmacyDatabaseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents POStransactiontblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransItemstblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlatTabControl1 As PharmacyInventorySystem.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents pnlAdd As System.Windows.Forms.Panel
    Friend WithEvents txtstock As PharmacyInventorySystem.FlatTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPaneltitle As PharmacyInventorySystem.FlatLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtgondola As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As PharmacyInventorySystem.FlatButton
    Friend WithEvents btnSave As PharmacyInventorySystem.FlatButton
    Friend WithEvents cbxForm As PharmacyInventorySystem.FlatComboBox
    Friend WithEvents FlatLabel8 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents txtMG As PharmacyInventorySystem.FlatTextBox
    Friend WithEvents FlatLabel7 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents txtprice As PharmacyInventorySystem.FlatTextBox
    Friend WithEvents FlatLabel6 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel5 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents dtpExpire As System.Windows.Forms.DateTimePicker
    Friend WithEvents FlatLabel4 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents txtgname As PharmacyInventorySystem.FlatTextBox
    Friend WithEvents txtbname As PharmacyInventorySystem.FlatTextBox
    Friend WithEvents FlatLabel3 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel2 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel1 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents lblSelItem As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel9 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSrch As PharmacyInventorySystem.FlatButton
    Friend WithEvents txtsrch As System.Windows.Forms.TextBox
    Friend WithEvents btnRem As PharmacyInventorySystem.FlatButton
    Friend WithEvents btnAdd As PharmacyInventorySystem.FlatButton
    Friend WithEvents dtgvMedicine As System.Windows.Forms.DataGridView
    Friend WithEvents GONDOLADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BRANDNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GENERICNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPIRATIONDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INSTOCKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOSAGEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FORMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dtpTransDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOrnum As System.Windows.Forms.TextBox
    Friend WithEvents cbxFilterby As PharmacyInventorySystem.FlatComboBox
    Friend WithEvents FlatLabel12 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtgvPOSitems As System.Windows.Forms.DataGridView
    Friend WithEvents ORNUMBERDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRICEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALPRICEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtgvPOS As System.Windows.Forms.DataGridView
    Friend WithEvents ORNUMBERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRANSDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CASHIERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALPRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VATABLESALESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALSALESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlatLabel11 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents FlatLabel10 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dtgvcrit As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlatButton1 As PharmacyInventorySystem.FlatButton
    Friend WithEvents FlatLabel13 As PharmacyInventorySystem.FlatLabel
    Friend WithEvents cbxFilterCrit As PharmacyInventorySystem.FlatComboBox
    Friend WithEvents btnprintSales As PharmacyInventorySystem.FlatButton
End Class
