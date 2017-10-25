Imports System.Data.OleDb
Module data_conModule
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\PharmacyDatabase.mdb")
End Module
