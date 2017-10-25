Imports System.Data.OleDb
Public Class POS

    Sub autoComp()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim dread As OleDbDataReader
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = "SELECT GONDOLA FROM medicine_tbl"
        dread = cmd.ExecuteReader
        Dim autoComplete As New AutoCompleteStringCollection()
        While dread.Read
            autoComplete.Add(dread("GONDOLA"))
        End While
        dread.Close()
        txtpCode.AutoCompleteMode = AutoCompleteMode.Suggest
        txtpCode.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtpCode.AutoCompleteCustomSource = autoComplete

    End Sub
    Sub itemDesc()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cm As New OleDbCommand
        Dim dr As OleDbDataReader
        cm.Connection = con
        cm.CommandText = "SELECT BRANDNAME, GENERICNAME, DOSAGE FROM medicine_tbl WHERE GONDOLA = '" & txtpCode.Text & "'"
        dr = cm.ExecuteReader
        While dr.Read
            Dim bname, gename, dosage As String
            bname = dr("BRANDNAME")


            If Not IsDBNull(dr("GENERICNAME")) Then
                gename = dr("GENERICNAME")
            Else
                gename = Nothing
            End If
            If Not IsDBNull(dr("DOSAGE")) Then
                dosage = dr("DOSAGE")
            Else
                dosage = Nothing
            End If
            txtpDesc.Text = bname + " - " + gename + " " + dosage
        End While

    End Sub
    Sub addItemToList()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cm2 As New OleDbCommand
        Dim readMe As OleDbDataReader
        cm2.Connection = con
        cm2.CommandText = "SELECT GONDOLA, PRICE, IN_STOCK, BRANDNAME FROM medicine_tbl WHERE GONDOLA = '" & txtpCode.Text & "'"
        readMe = cm2.ExecuteReader
        Dim prc, qnty, total_p, cur_stock, updateStock As Double
        While readMe.Read
            Dim item As New ListViewItem(txtpCode.Text)
            item.SubItems.Add(txtpDesc.Text)
            item.SubItems.Add(readMe("PRICE"))
            item.SubItems.Add(txtQnty.Text)

            ''-------------Computation of total prices----------------------

            prc = readMe("PRICE")
            qnty = Val(txtQnty.Text)
            total_p = prc * qnty
            item.SubItems.Add(total_p)
            lstvItems.Items.Add(item)
            ''-------------------------------------------------------------
            computeItem()
            ''-------INSERT ITEM INTO TABLE-----------
            Dim additem, lessItem, orIn As New OleDbCommand
            Try
                additem.Connection = con
                additem.CommandText = "INSERT INTO tempItems_tbl(OR_NUMBER, PRODUCT_CODE, DESCRIPTION, PRICE, QUANTITY, TOTAL_PRICE) VALUES('" & lblOR.Text &
                    "', '" & txtpCode.Text & "','" & txtpDesc.Text & "'," & prc & "," & qnty & "," & total_p & ")"
                additem.ExecuteNonQuery()

                ''--------subtract the item from inventory
                cur_stock = Val(readMe("IN_STOCK"))
                updateStock = cur_stock - qnty

                lessItem.Connection = con
                lessItem.CommandText = "UPDATE medicine_tbl SET IN_STOCK = " & updateStock & " WHERE GONDOLA ='" & txtpCode.Text & "'"
                lessItem.ExecuteNonQuery()


                orIn.Connection = con
                orIn.CommandText = "INSERT INTO receipt_tbl(ORNUM, PRODUCTCODE, DESCRIPTION, PRICE, QUANTITY, T_PRICE, VATABLE, PERCENT_VAT, TOTAL_AMOUNT)" & _
                                     "VALUES('" & lblOR.Text & "','" & txtpCode.Text & "','" & txtpDesc.Text & "'," & prc & "," & qnty & "," & total_p & "," & lblVsale.Text & "," & lblvat.Text &
                                         "," & lblTotal.Text & ") "
                orIn.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End While
        ''-----CLEAN-----
        txtpDesc.Text = ""
        txtpCode.Clear()
        txtQnty.Text = 1
    End Sub
    Sub NewTrans()
        lblOR.Text = DateAndTime.Now.ToString("yyyyMMdd-HHmmss")
        lstvItems.Items.Clear()
        txtpCode.Focus()
        lblItemCount.Text = lstvItems.Items.Count
        computeItem()
        txtCash.Text = 0
        txtChange.Text = 0
        pnlTend.Visible = False
    End Sub
    Sub delItem()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim itemCode As String = lstvItems.FocusedItem.SubItems(0).Text.ToString()
        Dim itemQuan As Integer = lstvItems.FocusedItem.SubItems(3).Text.ToString()
        Dim delitem, reStock, upreceipt As New OleDbCommand
        delitem.Connection = con
        upreceipt.Connection = con
        Try
            delitem.CommandText = "DELETE FROM tempItems_tbl WHERE PRODUCT_CODE = '" & itemCode & "'"
            delitem.ExecuteNonQuery()

            upreceipt.CommandText = "DELETE FROM receipt_tbl WHERE PRODUCTCODE = '" & itemCode & "'"
            upreceipt.ExecuteNonQuery()

            reStock.Connection = con
            reStock.CommandText = "UPDATE medicine_tbl SET IN_STOCK = IN_STOCK + " & itemQuan & " WHERE GONDOLA = '" & itemCode & "'"
            reStock.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        lstvItems.Items.RemoveAt(lstvItems.FocusedItem.Index)
        lblItemCount.Text = lstvItems.Items.Count


        computeItem()
    End Sub
    Sub computeItem()
        Dim TotalSum As Double = 0
        Dim TempNode As ListViewItem
        For Each TempNode In lstvItems.Items
            TotalSum += CDbl(TempNode.SubItems.Item(4).Text)
        Next
        Dim fSum As String = String.Format("{0:n}", TotalSum)
        lblTotal.Text = fSum
        Dim tax, vat As Double
        tax = Val(TotalSum) / 1.12
        lblTsale.Text = tax.ToString("0.00")
        lblVsale.Text = lblTsale.Text
        vat = TotalSum - Val(lblTsale.Text)
        lblvat.Text = vat.ToString("0.00")
    End Sub
    Sub transacComplete()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim completeMe, insertTrans, delTemp As New OleDbCommand
        Try
            completeMe.Connection = con
            completeMe.CommandText = "INSERT INTO transItems_tbl(OR_NUMBER, PRODUCT_CODE, DESCRIPTION, PRICE, QUANTITY, TOTAL_PRICE) SELECT * FROM tempItems_tbl WHERE OR_NUMBER = '" & lblOR.Text & "'"
            completeMe.ExecuteNonQuery()

            insertTrans.Connection = con
            insertTrans.CommandText = "INSERT INTO POStransaction_tbl(OR_NUMBER, TRANS_DATE, CASHIER, TOTAL_PRICE, VATABLE_SALES, VAT, TOTAL_SALES) VALUES('" & lblOR.Text & "','" & Date.Now.ToString("MM/d/yyyy") & "','" & lblStaffName.Text &
                "', " & lblTotal.Text & ", " & lblVsale.Text & "," & lblvat.Text & "," & lblTsale.Text & ")"
            insertTrans.ExecuteNonQuery()




            delTemp.Connection = con
            delTemp.CommandText = "DELETE * FROM tempItems_tbl"
            delTemp.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        NewTrans()

    End Sub

    Private Sub POS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim i As Integer = MessageBox.Show("YOU ARE ABOUT TO LOGOUT? PLEASE CONFIRM", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = DialogResult.No Then
            e.Cancel = True
        Else
            inventory_form.Close()
            details_frm.Close()
            main.Close()
            Form1.Show()
        End If
    End Sub
    Private Sub POS_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim i As Integer = MessageBox.Show("Are you sure to procceed to a NEW TRANSACTION? All items will be cleared.", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If i = DialogResult.Yes Then
                NewTrans()
            End If
            If e.KeyCode = Keys.Shift Then
                txtQnty.Focus()
                txtQnty.SelectAll()
            End If
        End If
    End Sub

    Private Sub POS_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtpCode.Focus()
        autoComp()
        NewTrans()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New OleDbCommand
        Dim numrows As Integer = 0
        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(*) FROM tempItems_tbl"
        numrows = cmd.ExecuteScalar
        If numrows > 0 Then

            Dim iii As Integer = MessageBox.Show("SYSTEM IS UNXPECTEDLY SHUTDOWN OR CLOSE. DO YOU WANT TO RESTORE PREVIOUS SESSION?", "RESTORE SESSION?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If iii = DialogResult.Yes Then
                Dim da As New OleDbDataAdapter("SELECT PRODUCT_CODE, DESCRIPTION, PRICE, QUANTITY, TOTAL_PRICE FROM tempItems_tbl", con)
                Dim dt As New DataTable
                da.Fill(dt)
                'For Each col As DataColumn In dt.Columns
                '    lstvItems.Columns.Add(col.ToString)
                'Next
                For Each row As DataRow In dt.Rows
                    Dim lst As ListViewItem
                    lst = lstvItems.Items.Add(If(row(0) IsNot Nothing, row(0).ToString, ""))
                    For i As Integer = 1 To dt.Columns.Count - 1
                        lst.SubItems.Add(If(row(i) IsNot Nothing, row(i).ToString, ""))
                    Next
                Next
                ''-----------restore or number -----------
                Dim dr As OleDbDataReader
                Dim cm As New OleDbCommand
                cm.Connection = con
                cm.CommandText = "SELECT OR_NUMBER FROM tempItems_tbl"
                dr = cm.ExecuteReader
                While dr.Read
                    lblOR.Text = dr("OR_NUMBER")
                End While
                dr.Close()

                computeItem()
            Else
                Dim delprev, delrec As New OleDbCommand
                delprev.Connection = con
                delprev.CommandText = "DELETE * FROM tempItems_tbl"
                delprev.ExecuteNonQuery()
                delrec.Connection = con
                delrec.CommandText = "DELETE * FROM receipt_tbl"
                delrec.ExecuteNonQuery()

            End If


        End If

    End Sub

    Private Sub txtpCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpCode.KeyDown, Me.KeyDown
        If e.KeyCode = 13 Then
            addItemToList()
            lblItemCount.Text = lstvItems.Items.Count

        End If
        If e.KeyCode = Keys.Insert Then
            txtQnty.Focus()
            txtQnty.SelectAll()
        End If
        If e.KeyCode = Keys.F3 Then
            pnlTend.Visible = True
            txtCash.Focus()
            txtCash.SelectAll()
        End If
    End Sub


    Private Sub txtpCode_TextChanged(sender As Object, e As EventArgs) Handles txtpCode.TextChanged
        itemDesc()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    MessageBox.Show(lstvItems.FocusedItem.Index)
    '    lstvItems.Items.RemoveAt(lstvItems.FocusedItem.Index)
    '    lblItemCount.Text = lstvItems.Items.Count
    '    'txtValue = ListView1.FocusedItem.SubItems(0).text
    'End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        lblOR.Text = DateAndTime.Now.ToString("yyyyMMdd-HHmmss")
        lstvItems.Items.Clear()
        txtpCode.Focus()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        delItem()
    End Sub

    Private Sub lstvItems_KeyDown(sender As Object, e As KeyEventArgs) Handles lstvItems.KeyDown
        If e.KeyCode = Keys.F2 Then
            delItem()
        End If
    End Sub

    Private Sub txtQnty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQnty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpCode.Focus()
        End If
    End Sub

    Private Sub txtCash_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCash.KeyDown
        If e.KeyCode = 13 Then
            transacComplete()
            MessageBox.Show("YOUR TRANSACTION IS COMPLETED. THANK YOU!", "COMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            receipt.Show()
        End If
    End Sub
    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Dim cash, change, total As Double
        cash = Val(txtCash.Text)
        total = Val(lblTotal.Text)
        change = cash - total
        If change < 0 Then
            txtChange.ForeColor = Color.Red
        Else
            txtChange.ForeColor = Color.Black
        End If
        txtChange.Text = change.ToString("0.00")
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    rptdoc = New CrystalReport1
    '    rptdoc.Load("|DataDirectory|CrystalReport1.rpt")
    '    receipt.CrystalReportViewer1.ReportSource = rptdoc
    '    'receipt.CrystalReportViewer1.ReportSource = rptdoc
    '    receipt.Show()
    'End Sub


    Private Sub Panel1_MouseHover(sender As Object, e As EventArgs) Handles Panel1.MouseHover
        pcbLogout.Visible = True
    End Sub

    
    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover, Me.MouseHover, Panel3.MouseHover, Panel4.MouseHover
        pcbLogout.Visible = False
    End Sub

    Private Sub pcbLogout_Click(sender As Object, e As EventArgs) Handles pcbLogout.Click
        Me.Close()
    End Sub
End Class