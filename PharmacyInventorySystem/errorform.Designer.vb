<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class errorform
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
        Me.frmerr = New PharmacyInventorySystem.FormSkin()
        Me.FlatButton1 = New PharmacyInventorySystem.FlatButton()
        Me.lblMess = New PharmacyInventorySystem.FlatLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.frmerr.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmerr
        '
        Me.frmerr.BackColor = System.Drawing.Color.White
        Me.frmerr.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.frmerr.BorderColor = System.Drawing.Color.White
        Me.frmerr.Controls.Add(Me.PictureBox2)
        Me.frmerr.Controls.Add(Me.FlatButton1)
        Me.frmerr.Controls.Add(Me.lblMess)
        Me.frmerr.Controls.Add(Me.PictureBox1)
        Me.frmerr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmerr.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.frmerr.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.frmerr.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.frmerr.HeaderMaximize = False
        Me.frmerr.Location = New System.Drawing.Point(0, 0)
        Me.frmerr.Name = "frmerr"
        Me.frmerr.Size = New System.Drawing.Size(343, 149)
        Me.frmerr.TabIndex = 0
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(188, 105)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(64, 32)
        Me.FlatButton1.TabIndex = 3
        Me.FlatButton1.Text = "OK"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblMess
        '
        Me.lblMess.AutoSize = True
        Me.lblMess.BackColor = System.Drawing.Color.Transparent
        Me.lblMess.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMess.ForeColor = System.Drawing.Color.White
        Me.lblMess.Location = New System.Drawing.Point(104, 70)
        Me.lblMess.Name = "lblMess"
        Me.lblMess.Size = New System.Drawing.Size(76, 20)
        Me.lblMess.TabIndex = 2
        Me.lblMess.Text = "FlatLabel1"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.PharmacyInventorySystem.My.Resources.Resources.sign_red_error_icon_1
        Me.PictureBox2.Location = New System.Drawing.Point(18, 58)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 67)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PictureBox1.Image = Global.PharmacyInventorySystem.My.Resources.Resources.error1
        Me.PictureBox1.Location = New System.Drawing.Point(6, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'errorform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 149)
        Me.Controls.Add(Me.frmerr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "errorform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "errorform"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.frmerr.ResumeLayout(False)
        Me.frmerr.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmerr As PharmacyInventorySystem.FormSkin
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatButton1 As PharmacyInventorySystem.FlatButton
    Friend WithEvents lblMess As PharmacyInventorySystem.FlatLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
