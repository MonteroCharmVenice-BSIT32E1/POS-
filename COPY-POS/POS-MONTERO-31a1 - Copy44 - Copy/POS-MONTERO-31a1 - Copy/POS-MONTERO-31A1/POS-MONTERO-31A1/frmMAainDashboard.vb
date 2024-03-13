Imports System.Data.OleDb
Public Class frmMAainDashboard
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub frmMAainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TarnsactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarnsactionToolStripMenuItem.Click
    End Sub

    Private Sub POSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSToolStripMenuItem.Click
        frmCashier.Show()
    End Sub

    Private Sub ManageAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageAccountsToolStripMenuItem.Click
        frmManageAccount.Show()
        Me.Hide()
    End Sub
End Class