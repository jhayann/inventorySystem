Imports System.Data.OleDb
Public Class main
    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click, PictureBox2.Click
        Dim conOut As Integer = MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If conOut = DialogResult.OK Then
            Me.Hide()
            inventory_form.Close()
            details_frm.Close()
            POS.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbldate.Text = DateTime.Now.ToString("hh:mm dddd, dd MMMM yyyy")

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        adduser.Show()
    End Sub
    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        inventory_form.Show()
        inventory_form.FlatTabControl1.SelectedIndex = 0
        inventory_form.WindowState = FormWindowState.Normal
        Me.Hide()
    End Sub

  

    Private Sub btnPOS_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        POS.Show()
        POS.WindowState = FormWindowState.Maximized
        Me.Hide()
    End Sub

    Private Sub lblAccount_Click(sender As Object, e As EventArgs) Handles lblAccount.Click, PictureBox1.Click
        Account.Show()
        Account.lblname.Text = lblName.Text
        Account.loadme()
    End Sub

    
    'Private Sub btnORDER_Click(sender As Object, e As EventArgs)
    '    inventory_form.Show()
    '    inventory_form.FlatTabControl1.SelectedIndex =
    '    Me.Hide()
    'End Sub
End Class