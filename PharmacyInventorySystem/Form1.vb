Imports System.Data.OleDb
Public Class Form1
   
    Sub checkUser()
        Dim user, pass As String
        Dim cm As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim userFound, isCashier As Boolean
        user = txtUser.Text
        pass = txtPass.Text
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cm.Connection = con
        cm.CommandText = "SELECT * FROM users_tbl WHERE UNAME = '" & user & "' AND PWORD = '" & pass & "'"
        dr = cm.ExecuteReader
        userFound = False
        isCashier = False
        While dr.Read
            userFound = True
            Dim userName, lname, position As String
            If dr("POST").ToString = "CASHIER" Then
                isCashier = True
            End If
            userName = dr("FNAME").ToString
            lname = dr("LNAME").ToString
            position = dr("POST").ToString
            main.lblName.Text = userName
            POS.lblStaffName.Text = userName + " " + lname
            POS.lblPosition.Text = position
        End While
        con.Close()
        If userFound = True Then
            If isCashier = True Then
                POS.Show()
                POS.WindowState = FormWindowState.Maximized
                Me.Hide()
                txtUser.Text = ""
                txtPass.Text = ""
            Else
                main.Show()
                Me.Hide()
                txtUser.Text = ""
                txtPass.Text = ""
            End If
            

        Else
            'MessageBox.Show("Username or Password is invalid.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            errorform.frmerr.Text = "      Login Error"
            errorform.lblMess.Text = "Invalid Username or Password!"
            errorform.Show()
        End If
    End Sub
    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        checkUser()
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            checkUser()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.txtUser.Focus()
        Me.txtUser.Focus()
        Me.KeyPreview = True
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtPass.Text = ""
        txtUser.Text = ""
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If txtUser.Text = "" Then
            txtUser.Focus()
        Else
            txtPass.Focus()
        End If
    End Sub
End Class
