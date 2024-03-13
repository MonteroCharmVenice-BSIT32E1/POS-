Imports System.Data.OleDb
Public Class frmPayment
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        frmCashier.Show()
    End Sub

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadMOP()
    End Sub
    Private Sub loadMOP()
        'get the payment mode on the database table
        sql = "Select distinct PaymentMode from tblPaymentMode where status = '1'"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboMOP.DataSource = dt
        cboMOP.DisplayMember = "PaymentMode"
    End Sub

    Private Sub cboMOP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMOP.SelectedIndexChanged
        If cboMOP.Text = "Cash" Then
            txtRefNo.ReadOnly = True
            txtAmountPaid.Clear()
            txtAmountPaid.Enabled = True
        Else
            txtRefNo.ReadOnly = False
            txtAmountPaid.Text = lblgrandtotal.Text
            txtChange.Text = "0.00"
            txtAmountPaid.Text = False
        End If
    End Sub

    Private Sub txtAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmountPaid.TextChanged
        Dim change As Double
        change = Val(txtAmountPaid.Text) - Val(lblgrandtotal.Text)
        txtChange.Text = Format(Val(change), "0.00")
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If Val(txtAmountPaid.Text) < Val(lblgrandtotal.Text) Then
            MsgBox("Insufficient Payment", MsgBoxStyle.Critical)
        Else
            frmCashier.lblamountpaid.Text = Me.txtAmountPaid.Text
            frmCashier.lblchange.Text = Me.txtChange.Text
            frmCashier.lblMOP.Text = Me.cboMOP.Text
            frmCashier.lblRefNo.Text = Me.txtRefNo.Text
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String = InputBox("Enter mode of payment")
        sql = "Insert into tblPaymentMode(PaymentMode,Status)values(@PaymentMode,@Status)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@PaymentMode", a)
            .Parameters.AddWithValue("@Status", "1")
            .ExecuteNonQuery()
        End With
    End Sub
End Class