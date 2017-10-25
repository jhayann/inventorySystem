Imports System.Data.OleDb
Public Class Account
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Sub loadme()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        cmd.Connection = con
        Try
            cmd.CommandText = "SELECT * FROM users_tbl WHERE FNAME = '" & lblname.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                lblname.Text = dr("FNAME") + " " + dr("LNAME")
                lblusername.Text = dr("UNAME")
                lblposition.Text = dr("POST")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub
End Class