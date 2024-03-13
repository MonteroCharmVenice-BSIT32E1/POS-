Imports System.Data.OleDb
Public Class frmAdmindashboard
    Private Sub frmAdmindashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tsstoday.Text = Now.ToLongDateString & " " & Now.ToLongTimeString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        frmcreateaccount.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        frmCashier.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub CashierAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashierAccountsToolStripMenuItem.Click
        frmManageAccount.Show()
        Me.Hide()
    End Sub

    Private Sub POSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSToolStripMenuItem.Click
        frmActivityLogs.Show()
        Me.Hide()
    End Sub

    Private Sub CreateAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAccountToolStripMenuItem.Click
        frmcreateaccount.Show()
        Me.Hide()
    End Sub
End Class