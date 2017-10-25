Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class receipt

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub receipt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim cmd As New OleDbCommand
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "DELETE * FROM receipt_tbl"
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub


    Private Sub receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdoc = New CrystalReport1
        rptdoc.DataSourceConnections.Clear()
        Dim crCon As New ConnectionInfo
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        rptdoc.Load(Application.StartupPath & "\CrystalReport1.rpt")
        With crCon
            .ServerName = Application.StartupPath & "\PharmacyDatabase.mdb"
            .UserID = "Admin"
            .Password = ""
            'crCon.Password = Chr(10) & "MyPass" 
        End With
        CrTables = rptdoc.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crCon
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        CrystalReportViewer1.ReportSource = rptdoc
    End Sub
End Class