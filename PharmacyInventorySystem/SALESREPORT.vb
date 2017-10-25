Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class SALESREPORT

    Private Sub SALESREPORT_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = "DELETE * FROM salesReportTBL"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub SALESREPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdoc = New CrystalReport3
        rptdoc.DataSourceConnections.Clear()
        Dim crCon As New ConnectionInfo
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        rptdoc.Load(Application.StartupPath & "\CrystalReport3.rpt")
        CrystalReportViewer1.Refresh()
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