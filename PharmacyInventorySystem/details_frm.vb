Imports System.Data.OleDb
Public Class details_frm
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub
    Sub loadItem()
        txtgon.Enabled = False
        txtgon.Text = lblgondola.Text
        txtbn.Text = txtbname.Text
        txtgn.Text = lblgname.Text
        txtdsg.Text = lbldos.Text
        txtPrice.Text = lblprice.Text
        cbxf.SelectedItem = lblForm.Text
        If lblexp.Text = "" Then

        Else
            dtped.Value = lblexp.Text
        End If
    End Sub
    Sub refreshItem()
        lblgondola.Text = txtgon.Text
        txtbname.Text = txtbn.Text
        lblgname.Text = txtgn.Text
        lbldos.Text = txtdsg.Text
        lblprice.Text = txtPrice.Text
        lblForm.Text = cbxf.SelectedItem
        lblexp.Text = dtped.Text
        BunifuCircleProgressbar1.Value = txtStocks.Text
        inventory_form.fillTable()
    End Sub
    Private Sub btnEditSave_Click(sender As Object, e As EventArgs) Handles btnEditSave.Click

        If btnEditSave.Text = "EDIT" Then
            txtPrice.Visible = True
            pnlEdit.Visible = True
            txtStocks.Visible = True
            lblstocks.Visible = True
            btnEditSave.Text = "Update"
            loadItem()
        Else
            btnEditSave.Text = "EDIT"
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim cmd As New OleDbCommand
            cmd.Connection = con
            Dim expired As String = dtped.Value.ToString("MMMM yyyy")
            Try
                btnEditSave.Enabled = False
                cmd.CommandText = "UPDATE medicine_tbl SET BRANDNAME = '" & txtbn.Text.ToUpper &
                "', GENERICNAME='" & txtgn.Text.ToUpper & "' , EXPIRATION_DATE = '" & expired &
                "', IN_STOCK = " & Val(txtStocks.Text) & ", PRICE = " & Val(txtPrice.Text) & ", DOSAGE = '" & txtdsg.Text & "', FORM = '" & cbxf.SelectedItem.ToString &
                "' WHERE GONDOLA = '" & txtgon.Text & "'"
                cmd.ExecuteNonQuery()
                con.Close()
                txtPrice.Visible = False
                pnlEdit.Visible = False
                txtStocks.Visible = False
                lblstocks.Visible = False
                MessageBox.Show("Item successfully updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnEditSave.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            refreshItem()
        End If
    End Sub
End Class