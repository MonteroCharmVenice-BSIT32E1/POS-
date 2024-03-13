Imports System.Data.OleDb
Module DatabaseConnection
    Public cn As New OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public sql As String

    Public Sub connection()
        cn.Close()
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Moyla\Desktop\POS-MONTERO-31a1 - Copy44 - Copy\POS-MONTERO-31a1 - Copy44 - Copy\POS-MONTERO-31a1 - Copy\POS-MONTERO-31A1\POS-MONTERO-31A1\bin\Debug\mydbpos.accdb"
        cn.Open()
        MsgBox("Connection Success", MsgBoxStyle.Information, "Database Connection")

    End Sub
End Module
