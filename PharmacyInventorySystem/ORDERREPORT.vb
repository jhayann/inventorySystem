Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class ORDERREPORT

    Private Sub ORDERREPORT_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = "DELETE * FROM orderReport"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub ORDERREPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdoc = New CrystalReport2
        rptdoc.DataSourceConnections.Clear()
        Dim crCon As New ConnectionInfo
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        rptdoc.Load(Application.StartupPath & "\CrystalReport2.rpt")
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