Imports System.Data.OleDb
Public Class frmCashier

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call gettransactionNo()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Now.ToShortDateString
        lbltime.Text = Now.ToShortDateString
    End Sub
    Private Sub gettransactionNo()
        sql = "select TransNo from tbltransactions order by TransNo desc"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lbltransactionNo.Text = Val(dr(0)) + 1
        Else
            lbltransactionNo.Text = 1000001
        End If

    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged
        sql = "select Prodname,Amount,Quantity,CriticalLevel,Status from qryProducts where productCode ='" & txtcode.Text & "' and Quantity>'0'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtprodname.Text = dr(0) 'for product name
            txtamount.Text = dr(1) 'for amount of the product
            txtquantity1.Text = dr(2) 'for the quantity of the product
            txtcrit.Text = dr(3) 'for the critical level of the product
            txtstatus.Text = dr(4) ' for the status
        Else
            MsgBox("Item(s) not found or Item(s) is out of stocked", MsgBoxStyle.Critical)
            cleartext()
        End If
    End Sub
    Private Sub cleartext()
        txtprodname.Clear()
        txtamount.Clear()
        txtcrit.Clear()
        txtquantity1.Clear()
        txtstatus.Text = "******"

    End Sub
    Dim l As ListViewItem
    Dim amount As Double
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        Dim a As String = InputBox("Enter number of products?", "Quantity")
        If a = "" Or a = 0 Then
            MsgBox("Please enter number of products")
        Else
            If Val(a) > Val(txtquantity1.Text) Then
                MsgBox("Number of Products is greater than the availavle products", MsgBoxStyle.Exclamation, "re-enter number of products")

            Else
                txtquantity1.Text = Val(txtquantity1.Text) - Val(a)
                amount = Val(txtamount.Text) * Val(a)
                l = Me.ListView1.Items.Add(txtcode.Text) 'product code
                l.SubItems.Add(txtprodname.Text) 'product name
                l.SubItems.Add(txtamount.Text)
                l.SubItems.Add(a)
                l.SubItems.Add(amount)
                If Val(txtquantity1.Text) = 0 Then
                    txtstatus.Text = "OUT OF STOCK"
                ElseIf Val(txtquantity1.Text) <= Val(txtcrit.Text) Then ' if quantity reaches the critical level or lower
                    txtstatus.Text = "CRITICAL LEVEL"
                End If
            End If
        End If
        gettotal()
        gettotalitems()
        getVAT()
        'Catch ex As Exception


        'End Try
    End Sub
    Private Sub gettotal()
        Const col As Integer = 4
        Dim total As Integer
        Dim lvsi As ListViewItem.ListViewSubItem
        For i As Integer = 0 To ListView1.Items.Count - 1
            lvsi = ListView1.Items(i).SubItems(col)
            total += Double.Parse(lvsi.Text)
        Next
        lbltotal.Text = Format(Val(total), "0.00")
    End Sub
    Private Sub gettotalitems()
        Const col As Integer = 3 'quantity
        Dim total As Integer
        Dim lvsi As ListViewItem.ListViewSubItem
        For i As Integer = 0 To ListView1.Items.Count - 1
            lvsi = ListView1.Items(i).SubItems(col)
            total += Double.Parse(lvsi.Text)
        Next
        lbltotalitems.Text = Val(total)
    End Sub
    Private Sub getVAT()
        Dim vatableSales As Double
        vatableSales = lbltotal.Text / 1.12
        lblVAT.Text = Format(Val(vatableSales), "0.00")
        lblVsales.Text = Val(lbltotal.Text) - Val(lblVAT.Text)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnremoved_Click(sender As Object, e As EventArgs) Handles btnremoved.Click
        If MsgBox("Remove Product?", vbQuestion + vbYes) = vbYes Then
            If ListView1.Items.Count = 0 Then
                MsgBox("No Product on the list", MsgBoxStyle.Critical)
            Else
                If ListView1.SelectedItems.Count > 0 Then
                    Dim lvalue As Integer = Integer.Parse(ListView1.SelectedItems(0).SubItems(3).Text)
                    Dim newquantity As Integer = lvalue + Val(txtquantity1.Text)
                    txtquantity1.Text = newquantity
                    ListView1.Items.Remove(ListView1.FocusedItem)
                    If Val(txtquantity1.Text) > Val(txtcrit.Text) Then
                        txtstatus.Text = "Available"
                    End If
                    gettotalitems()
                    gettotal()
                End If

            End If
        End If
    End Sub

    Private Sub btnpayment_Click(sender As Object, e As EventArgs) Handles btnpayment.Click
        frmPayment.Show()
        frmPayment.lblgrandtotal.Text = Me.lbltotal.Text
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        If MsgBox("Log out account?", vbQuestion + vbYesNo) = vbYes Then
            MsgBox("Good bye :> " & lblcashier.Text & "  " & " Have a nice day!!!", MsgBoxStyle.Information, "USER LOGOUT")
            Me.Hide()
            frmlogin.Show()

        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If MsgBox("Save Transaction?", vbQuestion + vbYesNo) = vbYes Then

            If Val(lblamountpaid.Text) < Val(lbltotal.Text) Then
                MsgBox("Insufficient Amount Paid", MsgBoxStyle.Critical, "Please Re-Enter Payment")
            Else
                'saving transaction
                sql = "Insert into tblTransactions(TransNo,TransDate,TransTime,TotalAmount,VAT,VatableSales,Discount,DiscountType,CashierName)values(@TransNo,@TransDate,@TransTime,@TotalAmount,@VAT,@VatableSales,@Discount,@DiscountType,@CashierName)"
                cmd = New OleDbCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@TransNo", lbltransactionNo.Text)
                    .Parameters.AddWithValue("@TransDate", lbldate.Text)
                    .Parameters.AddWithValue("@TransTime", lbltime.Text)
                    .Parameters.AddWithValue("@TotalAmount", lbltotal.Text)
                    .Parameters.AddWithValue("@VAT", lblVAT.Text)
                    .Parameters.AddWithValue("@VatableSales", lblVsales.Text)
                    .Parameters.AddWithValue("@Discount", lblDisc.Text)
                    .Parameters.AddWithValue("@DiscountType", cbodiscount.Text)
                    .Parameters.AddWithValue("@CashierName", lblcashier.Text)
                    .ExecuteNonQuery()
                End With

                For Each i As ListViewItem In ListView1.Items
                    sql = "Insert into tblTransactionDetails(TransNo,ProductCode,Amount,Quantity,Total)Values(@TransNo,@ProductCode,@Amount,@Quantity,@Total)"
                    cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@TransNo", lbltransactionNo.Text)
                    cmd.Parameters.AddWithValue("@ProductCode", i.Text)
                    cmd.Parameters.AddWithValue("@Amount", i.SubItems(2).Text)
                    cmd.Parameters.AddWithValue("@Qty", i.SubItems(3).Text)
                    cmd.Parameters.AddWithValue("@Total", i.SubItems(4).Text)
                    cmd.ExecuteNonQuery()
                Next

                sql = "Insert into tblpayments(TransNo,TotalAmount,AmountPaid,AmountChange,MOP,RefNo)Values(@TransNo,@TotalAmount,@AmountPaid,@AmountChange,@MOP,@RefNo)"
                cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@TransNo", lbltransactionNo.Text)
                cmd.Parameters.AddWithValue("@TotalAmount", lbltotal.Text)
                cmd.Parameters.AddWithValue("@AmountPaid", lblamountpaid.Text)
                cmd.Parameters.AddWithValue("@AmountChange", lblchange.Text)
                cmd.Parameters.AddWithValue("@MOP", lblMOP.Text)
                cmd.Parameters.AddWithValue("@RefNo", lblRefNo.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Transaction Successfully Saved", MsgBoxStyle.Information)
                ListView1.Items.Clear()
                Call resetcurrency()
            End If
        End If
        Call gettransactionNo()
    End Sub
    Private Sub resetcurrency()
        lblamountpaid.Text = "0.00"
        lblVAT.Text = "0.00"
        lblVsales.Text = "0.00"
        lbltotalitems.Text = "0.00"
        lblMOP.Text = "******"
        lblDisc.Text = "0.00"
        lblRefNo.Text = "*****"
        lbltotal.Text = "0.00"
        lblchange.Text = "0.00"
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Call ResetText()
        Call cleartext()
        ListView1.Items.Clear()
        Call resetcurrency()
    End Sub

    Private Sub cbodiscount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodiscount.SelectedIndexChanged
        Dim discount, newTotal As Double
        discount = Val(lbltotal.Text) * 0.2
        lblDisc.Text = Format(Val(discount), "0.00")
        newTotal = Val(lbltotal.Text) - Val(lblDisc.Text)
        lbltotal.Text = Format(Val(newTotal), "0.00")
        lblVAT.Text = "0.00"
        lblVsales.Text = "0.00"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class