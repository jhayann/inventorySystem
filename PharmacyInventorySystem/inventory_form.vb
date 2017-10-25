Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Public Class inventory_form
    Sub fillTable()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim dataAdapter As New OleDbDataAdapter("SELECT * FROM medicine_tbl WHERE DELETED = False ORDER BY BRANDNAME", con)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)
        dtgvMedicine.DataSource = dataTable
        con.Close()
    End Sub
    Sub addItem()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cm As New OleDbCommand
        cm.Connection = con
        Dim gondola, bname, gname, expdate, dosage, form As String
        Dim stock, price As Double
        gondola = txtgondola.Text.ToUpper
        bname = txtbname.Text.ToUpper
        gname = txtgname.Text.ToUpper
        expdate = dtpExpire.Text.ToString
        dosage = txtMG.Text + " MG"
        form = cbxForm.SelectedItem.ToString
        stock = Val(txtstock.Text)
        price = Val(txtprice.Text)

        Try
            cm.CommandText = "INSERT INTO medicine_tbl(GONDOLA,BRANDNAME,GENERICNAME,EXPIRATION_DATE,IN_STOCK,PRICE,DOSAGE,FORM)" &
            "VALUES ('" & gondola & "', '" & bname & "' , '" & gname & "', '" & expdate & "', " & stock & "," & price & ",'" & dosage & "','" & form & "')"
            cm.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Medicine Successfully added", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            resetControl()
            fillTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub delITem()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmDel As New OleDbCommand
        cmDel.Connection = con
        Try
            cmDel.CommandText = "DELETE FROM medicine_tbl WHERE GONDOLA = '" & lblSelItem.Text & "'"
            cmDel.ExecuteNonQuery()
            MessageBox.Show("The item is remove", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
        fillTable()
    End Sub
    Sub searchItem()
        Dim bSrch As String
        bSrch = txtsrch.Text
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim dataAdapter2 As New OleDbDataAdapter("SELECT * FROM medicine_tbl WHERE (GONDOLA LIKE '" & bSrch & "' + '%' AND DELETED = False) OR (BRANDNAME LIKE '" & bSrch & "' + '%' AND DELETED = False) ", con)
        Dim dataTable2 As New DataTable
        dataAdapter2.Fill(dataTable2)
        dtgvMedicine.DataSource = dataTable2

        con.Close()
    End Sub
    Sub FillTransactions()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim ORnum As String = txtOrnum.Text.ToString
        Dim TransDate As String = dtpTransDate.Value.ToString("MM/d/yyyy")
        Try
            If cbxFilterby.SelectedIndex = 0 Then
                Dim da As New OleDbDataAdapter("SELECT * FROM POStransaction_tbl WHERE OR_NUMBER LIKE '" & ORnum & "' + '%' ", con)
                Dim dt As New DataTable
                da.Fill(dt)
                dtgvPOS.DataSource = dt
            ElseIf cbxFilterby.SelectedIndex = 1 Then
                Dim da As New OleDbDataAdapter("SELECT * FROM POStransaction_tbl WHERE TRANS_DATE LIKE '" & TransDate & "' + '%' ", con)
                Dim dt As New DataTable
                da.Fill(dt)
                dtgvPOS.DataSource = dt
            ElseIf cbxFilterby.SelectedIndex = 2 Then
                Dim da As New OleDbDataAdapter("SELECT * FROM POStransaction_tbl", con)
                Dim dt As New DataTable
                da.Fill(dt)
                dtgvPOS.DataSource = dt
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub
    Private Sub inventory_form_Load(sender As Object, e As EventArgs) Handles Me.Load
        FlatTabControl1.SelectedIndex = 0

        MenuStrip1.ForeColor = Color.White

        fillTable()
        pnlAdd.Visible = False

        ''----------------TABLE DESIGN-------------
        dtgvMedicine.BorderStyle = BorderStyle.None
        dtgvMedicine.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(212, 214, 216)
        dtgvMedicine.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
        dtgvMedicine.DefaultCellStyle.SelectionBackColor = Color.SeaGreen
        dtgvMedicine.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        dtgvMedicine.BackgroundColor = Color.FromArgb(232, 234, 237)

        dtgvMedicine.EnableHeadersVisualStyles = False
        dtgvMedicine.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dtgvMedicine.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        dtgvMedicine.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dtgvMedicine.ColumnHeadersDefaultCellStyle.Font = New Font(dtgvMedicine.Font, FontStyle.Bold)
        ''----------------------------------------

        ''----------HIDE TAB----------------------
        FlatTabControl1.TabPages.Remove(TabPage4)
        FlatTabControl1.TabPages.Remove(TabPage3)
        FlatTabControl1.TabPages.Remove(TabPage2)
        ''----------------------------------------
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, LogoutToolStripMenuItem.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        pnlAdd.Visible = True
        cbxForm.SelectedIndex = 0
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        resetControl()
        pnlAdd.Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtgondola.Text = "" Or txtbname.Text = "" Or txtgname.Text = "" Then
            MessageBox.Show("Please enter all the neccessary information needed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Val(txtprice.Text) = 0 Or Val(txtstock.Text) = 0 Then
            MessageBox.Show("Please enter all the neccessary information needed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            addItem()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        resetControl()
        pnlAdd.Visible = False
    End Sub
    Sub resetControl()
        txtbname.Text = ""
        txtgname.Text = ""
        txtgondola.Text = ""
        txtMG.Text = 0
        txtprice.Text = 0
        txtstock.Text = 0
        txtgondola.Focus()
    End Sub

    Private Sub btnSrch_Click(sender As Object, e As EventArgs) Handles btnSrch.Click
        searchItem()
    End Sub

    Private Sub txtsrch_TextChanged(sender As Object, e As EventArgs) Handles txtsrch.TextChanged
        searchItem()
    End Sub
    Private Sub btnRem_Click(sender As Object, e As EventArgs) Handles btnRem.Click
        If lblSelItem.Text = "" Then
            MessageBox.Show("Please select an item to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim confirmDel As Integer = MessageBox.Show("Are you sure to delete this medicine ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmDel = DialogResult.Yes Then
                delITem()
            ElseIf confirmDel = DialogResult.No Then
                lblSelItem.Text = ""
            End If
        End If
    End Sub

    Private Sub dtgvMedicine_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvMedicine.CellClick
        lblSelItem.Text = dtgvMedicine.SelectedRows(0).Cells(0).Value.ToString
    End Sub
    Private Sub dtgvMedicine_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvMedicine.CellDoubleClick
        Dim df As New details_frm
        df.BunifuCircleProgressbar1.Value = dtgvMedicine.SelectedRows(0).Cells(4).Value.ToString
        df.lblgondola.Text = dtgvMedicine.SelectedRows(0).Cells(0).Value.ToString
        df.txtbname.Text = dtgvMedicine.SelectedRows(0).Cells(1).Value.ToString
        df.lblgname.Text = dtgvMedicine.SelectedRows(0).Cells(2).Value.ToString
        df.lblexp.Text = dtgvMedicine.SelectedRows(0).Cells(3).Value.ToString
        df.lbldos.Text = dtgvMedicine.SelectedRows(0).Cells(6).Value.ToString
        df.lblForm.Text = dtgvMedicine.SelectedRows(0).Cells(7).Value.ToString
        df.lblprice.Text = dtgvMedicine.SelectedRows(0).Cells(5).Value.ToString
        df.txtStocks.Text = dtgvMedicine.SelectedRows(0).Cells(4).Value.ToString
        df.ShowDialog()
    End Sub
    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        main.Show()
    End Sub
    Private Sub MedListStripMenuItem1_CheckStateChanged(sender As Object, e As EventArgs) Handles MedListStripMenuItem1.CheckStateChanged
        If MedListStripMenuItem1.CheckState = CheckState.Unchecked Then
            FlatTabControl1.TabPages.Remove(TabPage1)
        Else
            FlatTabControl1.TabPages.Insert(0, TabPage1)
            FlatTabControl1.SelectedIndex = 0
        End If
    End Sub
    'Private Sub EmpStripMenuItem2_CheckStateChanged(sender As Object, e As EventArgs) Handles EmpStripMenuItem2.CheckStateChanged
    '    If EmpStripMenuItem2.CheckState = CheckState.Unchecked Then
    '        FlatTabControl1.TabPages.Remove(TabPage2)
    '    Else
    '        FlatTabControl1.TabPages.Insert(1, TabPage2)
    '        FlatTabControl1.SelectedIndex = 1
    '    End If
    'End Sub
    'Private Sub OrderStripMenuItem1_CheckStateChanged(sender As Object, e As EventArgs) Handles OrderStripMenuItem1.CheckStateChanged
    '    If OrderStripMenuItem1.CheckState = CheckState.Unchecked Then
    '        FlatTabControl1.TabPages.Remove(TabPage3)
    '    Else
    '        FlatTabControl1.TabPages.Insert(0, TabPage3)
    '        FlatTabControl1.SelectedIndex = 0
    '    End If
    'End Sub
    Private Sub TransStripMenuItem1_CheckStateChanged(sender As Object, e As EventArgs) Handles TransStripMenuItem1.CheckStateChanged
        If TransStripMenuItem1.CheckState = CheckState.Unchecked Then
            FlatTabControl1.TabPages.Remove(TabPage4)
        Else
            FlatTabControl1.TabPages.Insert(0, TabPage4)
            FlatTabControl1.SelectedIndex = 0
        End If
    End Sub
    Private Sub CriticalToolStripMenuItem_CheckStateChanged(sender As Object, e As EventArgs) Handles CriticalToolStripMenuItem.CheckStateChanged
        If CriticalToolStripMenuItem.CheckState = CheckState.Unchecked Then
            FlatTabControl1.TabPages.Remove(TabPage2)
        Else
            FlatTabControl1.TabPages.Insert(0, TabPage2)
            FlatTabControl1.SelectedIndex = 0
            displayCritical()
        End If
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        backup.Show()
    End Sub
    Sub displayCritical()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim dateme As String = DateTime.Now.ToString("MMMM yyyy")
        Dim adapCrit As New OleDbDataAdapter("SELECT * FROM medicine_tbl WHERE IN_STOCK <= 25 OR EXPIRATION_DATE = '" & dateme & "'", con)
        Dim tableCrit As New DataTable
        adapCrit.Fill(tableCrit)
        dtgvcrit.DataSource = tableCrit
    End Sub
    Private Sub cbxFilterby_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFilterby.SelectedIndexChanged
        If cbxFilterby.SelectedIndex = 0 Then
            txtOrnum.Enabled = True
            dtpTransDate.Enabled = False
            txtOrnum.Focus()
            dtgvPOSitems.DataSource = Nothing
            btnprintSales.Enabled = True
        ElseIf cbxFilterby.SelectedIndex = 1 Then
            dtpTransDate.Enabled = True
            txtOrnum.Enabled = False
            FillTransactions()
            dtgvPOSitems.DataSource = Nothing
            btnprintSales.Enabled = True
        ElseIf cbxFilterby.SelectedIndex = 2 Then
            FillTransactions()
            dtgvPOSitems.DataSource = Nothing
            btnprintSales.Enabled = True
        End If
    End Sub

    Private Sub txtOrnum_TextChanged(sender As Object, e As EventArgs) Handles txtOrnum.TextChanged
        FillTransactions()
    End Sub

    Private Sub dtgvPOS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvPOS.CellClick
        con.Open()
        Dim selOrNum As String = dtgvPOS.SelectedRows(0).Cells(0).Value.ToString
        Try
            Dim dAdap As New OleDbDataAdapter("SELECT * FROM transItems_tbl WHERE OR_NUMBER = '" & selOrNum & "'", con)
            Dim dtable As New DataTable
            dAdap.Fill(dtable)
            dtgvPOSitems.DataSource = dtable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub dtpTransDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpTransDate.ValueChanged
        Dim TransDate As String = dtpTransDate.Value.ToString("MM/dd/yyyy")
        FillTransactions()
    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    'Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    'rptdoc = New CrystalReport1
    '    'rptdoc.Load("D:\backup\PharmacyInventorySystem\PharmacyInventorySystem\CrystalReport1.rpt")
    '    'receipt.CrystalReportViewer1.ReportSource = rptdoc
    '    ''receipt.CrystalReportViewer1.ReportSource = rptdoc
    '    'receipt.Show()
    'End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub


    Private Sub frmInventory_Click(sender As Object, e As EventArgs) Handles frmInventory.Click

    End Sub


    Private Sub cbxFilterCrit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFilterCrit.SelectedIndexChanged
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If cbxFilterCrit.SelectedIndex = 0 Then
            Dim dateme As String = DateTime.Now.ToString("MMMM yyyy")
            Dim adapCrit As New OleDbDataAdapter("SELECT * FROM medicine_tbl WHERE EXPIRATION_DATE = '" & dateme & "' ", con)
            Dim tableCrit As New DataTable
            adapCrit.Fill(tableCrit)
            dtgvcrit.DataSource = tableCrit
        ElseIf cbxFilterCrit.SelectedIndex = 1 Then
            Dim adapCrit As New OleDbDataAdapter("SELECT * FROM medicine_tbl WHERE IN_STOCK <= 25 ", con)
            Dim tableCrit As New DataTable
            adapCrit.Fill(tableCrit)
            dtgvcrit.DataSource = tableCrit
        Else
            displayCritical()

        End If
        FlatButton1.Enabled = True

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If cbxFilterCrit.SelectedIndex = 0 Then
            Dim cmd As New OleDbCommand
            Dim dateme As String = DateTime.Now.ToString("MMMM yyyy")
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO orderReport SELECT GONDOLA, BRANDNAME, GENERICNAME, IN_STOCK, PRICE, FORM FROM medicine_tbl WHERE EXPIRATION_DATE = '" & dateme & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("PRESS OK TO SHOW THE ORDER REPORTS", "SUCCESS EXPORTING", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ORDERREPORT.ShowDialog()
        ElseIf cbxFilterCrit.SelectedIndex = 1 Then
            Dim cmd As New OleDbCommand
            Dim dateme As String = DateTime.Now.ToString("MMMM yyyy")
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO orderReport SELECT GONDOLA, BRANDNAME, GENERICNAME, IN_STOCK, PRICE, FORM FROM medicine_tbl WHERE IN_STOCK <= 25"
            cmd.ExecuteNonQuery()
            MessageBox.Show("PRESS OK TO SHOW THE ORDER REPORTS", "SUCCESS EXPORTING", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ORDERREPORT.ShowDialog()
        Else
            Dim cmd As New OleDbCommand
            Dim dateme As String = DateTime.Now.ToString("MMMM yyyy")
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO orderReport SELECT GONDOLA, BRANDNAME, GENERICNAME, IN_STOCK, PRICE, FORM FROM medicine_tbl WHERE IN_STOCK <= 25 OR EXPIRATION_DATE = '" & dateme & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("PRESS OK TO SHOW THE ORDER REPORTS", "SUCCESS EXPORTING", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ORDERREPORT.ShowDialog()
        End If

    End Sub

    Private Sub dtgvMedicine_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvMedicine.CellContentClick

    End Sub

    Private Sub btnprintSales_Click(sender As Object, e As EventArgs) Handles btnprintSales.Click
        Dim ORnum As String = txtOrnum.Text.ToString
        Dim TransDate As String = dtpTransDate.Value.ToString("MM/d/yyyy")
        If cbxFilterby.SelectedIndex = 0 Then
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim trasferMe As New OleDbCommand
            trasferMe.Connection = con
            trasferMe.CommandText = "INSERT INTO salesReportTBL SELECT * FROM POStransaction_tbl WHERE OR_NUMBER LIKE '" & ORnum & "' + '%' "
            trasferMe.ExecuteNonQuery()
            MessageBox.Show("GENERATING SALES REPORT", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SALESREPORT.ShowDialog()
        ElseIf cbxFilterby.SelectedIndex = 1 Then
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim trasferMe As New OleDbCommand
            trasferMe.Connection = con
            trasferMe.CommandText = "INSERT INTO salesReportTBL SELECT * FROM POStransaction_tbl WHERE TRANS_DATE LIKE '" & TransDate & "' + '%' "
            trasferMe.ExecuteNonQuery()
            MessageBox.Show("GENERATING SALES REPORT", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SALESREPORT.ShowDialog()
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim trasferMe As New OleDbCommand
            trasferMe.Connection = con
            trasferMe.CommandText = "INSERT INTO salesReportTBL SELECT * FROM POStransaction_tbl "
            trasferMe.ExecuteNonQuery()
            MessageBox.Show("GENERATING SALES REPORT", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SALESREPORT.ShowDialog()
        End If
    End Sub
End Class