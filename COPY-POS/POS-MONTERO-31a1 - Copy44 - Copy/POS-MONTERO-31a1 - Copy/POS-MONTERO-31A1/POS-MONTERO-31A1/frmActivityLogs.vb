Imports System.Data.OleDb
Public Class frmActivityLogs

    Private Sub frmActivityLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        LoadAccounts()

    End Sub
    Private Sub LoadAccounts()
        sql = "SELECT * FROM tblActivityLogs WHERE Username=@Username order LogID desc"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@username", frmlogin.txtusername.Text)
        cmd.Parameters.AddWithValue("@position", frmlogin.lblposition.Text)
        dr = cmd.ExecuteReader
        Dim x As New ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("username").ToString)
            x.SubItems.Add(dr("Position").ToString)
            x.SubItems.Add(dr("Action").ToString())
            x.SubItems.Add(dr("TimeStamp").ToString())
            ListView1.Items.Add(x)
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMAainDashboard.Show()
        Me.Hide()
    End Sub
End Class