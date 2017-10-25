Imports System.Data.OleDb
Public Class adduser
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\PharmacyDatabase.mdb")
    Sub addUser()
        Dim cm As New OleDbCommand
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cm.Connection = con
        Dim pos As String = FlatComboBox1.SelectedItem.ToString

        MessageBox.Show(pos)
        cm.CommandText = "INSERT INTO users_tbl (UNAME, PWORD, FNAME, LNAME, POST) VALUES ('" & txtusr.Text & "','" & txtpass.Text &
            "','" & txtfn.Text & "','" & txtln.Text & "','" & pos & "')"
        cm.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("The User is succesfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearTxt()
    End Sub
    Sub checkUserExist()
        Dim cm As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim userFound As Boolean = False
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cm.Connection = con
        cm.CommandText = "SELECT UNAME FROM users_tbl WHERE UNAME = '" & txtusr.Text & "' "
        dr = cm.ExecuteReader()
        While dr.Read
            userFound = True
        End While
        If userFound = True Then
            MessageBox.Show("Username is already taken. Try again", "Username error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            If FlatComboBox1.SelectedItem = Nothing Then
                con.Close()
                MessageBox.Show("Please Select Position", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                addUser()
            End If

        End If
        con.Close()
    End Sub
    Sub clearTxt()
        txtusr.Text = ""
        txtpass.Text = ""
        txtconpass.Text = ""
        txtfn.Text = ""
        txtln.Text = ""
    End Sub
    Private Sub btnAdduser_Click(sender As Object, e As EventArgs) Handles btnAdduser.Click
        Dim a, b, bb, c, d As String
        a = txtusr.Text
        b = txtpass.Text
        bb = txtconpass.Text
        c = txtfn.Text
        d = txtln.Text
        If a = "" Or b = "" Or c = "" Or d = "" Then
            MessageBox.Show("Please enter all the required fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf String.Equals(b, bb) Then
            checkUserExist()
        Else
            MessageBox.Show("Password is not identical.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtconpass.Text = ""
            txtpass.Text = ""
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clearTxt()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        clearTxt()
        Me.Hide()
    End Sub
End Class