Imports System.Data.OleDb
Public Class frmIventoryReports
    Private Sub frmIventoryReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call LoadAccounts()
    End Sub
    Private Sub LoadAccounts()
        sql = "Select * from tblProducts"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("ProductCode").ToString)
            x.SubItems.Add(dr("ProdName").ToString)
            x.SubItems.Add(dr("ProdDescription").ToString)
            x.SubItems.Add(dr("Category").ToString)
            x.SubItems.Add(dr("Amount").ToString)
            x.SubItems.Add(dr("Quantity").ToString)
            x.SubItems.Add(dr("CriticalLevel").ToString)
            x.SubItems.Add(dr("Status").ToString)
            ListView1.Items.Add(x)
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMAainDashboard.Show()
        Me.Close()
    End Sub
End Class