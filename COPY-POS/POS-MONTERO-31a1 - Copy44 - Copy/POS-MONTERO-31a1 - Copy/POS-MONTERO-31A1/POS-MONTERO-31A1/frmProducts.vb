Imports System.Data.OleDb

Public Class frmProducts
    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call LoadProducts()
    End Sub
    Private Sub LoadProducts()
        sql = "SELECT * FROM tblProducts"
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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtcode.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged
        sql = "Select ProdName, ProdDescription, Category, Amount, Quantity, CriticalLevel, Status from tblProducts where ProductCode = '" & txtcode.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtprodname.Text = dr("ProdName").ToString
            txtProductDiscription.Text = dr("ProdDescription").ToString
            txtCategory.Text = dr("Category").ToString
            txtamount.Text = dr("Amount").ToString
            txtquantity1.Text = dr("Quantity").ToString
            txtcrit.Text = dr("CriticalLevel").ToString
            txtstatus.Text = dr("Status").ToString
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call addData()
        clearText()
    End Sub
    Private Sub addData()
        If String.IsNullOrEmpty(txtcode.Text) OrElse String.IsNullOrEmpty(txtprodname.Text) OrElse String.IsNullOrEmpty(txtProductDiscription.Text) OrElse String.IsNullOrEmpty(txtCategory.Text) OrElse String.IsNullOrEmpty(txtamount.Text) OrElse String.IsNullOrEmpty(txtquantity1.Text) OrElse String.IsNullOrEmpty(txtcrit.Text) OrElse String.IsNullOrEmpty(txtstatus.Text) Then
            MsgBox("Please input the all fields", MsgBoxStyle.Exclamation, "Incomplete Data")
        Else
            sql = "Insert into tblProducts ([ProductCode], [ProdName], [ProdDescription], [Category], [Amount], [Quantity], [CriticalLevel], [Status]) values (@ProductCode, @ProdName, @ProdDescription, @Category, @Amount, @Quantity, @CriticalLevel, @Status)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@ProductCode", txtcode.Text)
                .Parameters.AddWithValue("@ProdName", txtprodname.Text)
                .Parameters.AddWithValue("@ProdDescription", txtProductDiscription.Text)
                .Parameters.AddWithValue("@Category", txtCategory.Text)
                .Parameters.AddWithValue("@Amount", txtamount.Text)
                .Parameters.AddWithValue("@Quantity", txtquantity1.Text)
                .Parameters.AddWithValue("@CriticalLevel", txtcrit.Text)
                .Parameters.AddWithValue("@Status", txtstatus.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Products Record Successfully Added", MsgBoxStyle.Information)
            Call LoadProducts()
        End If

    End Sub
    Private Sub clearText()
        txtcode.Clear()
        txtprodname.Clear()
        txtProductDiscription.Clear()
        txtCategory.Clear()
        txtamount.Clear()
        txtquantity1.Clear()
        txtcrit.Clear()
        txtstatus.Text = ""
    End Sub
    Private Sub CheckifExist()
        If String.IsNullOrEmpty(txtcode.Text) OrElse String.IsNullOrEmpty(txtprodname.Text) OrElse String.IsNullOrEmpty(txtProductDiscription.Text) OrElse String.IsNullOrEmpty(txtCategory.Text) OrElse String.IsNullOrEmpty(txtamount.Text) OrElse String.IsNullOrEmpty(txtquantity1.Text) OrElse String.IsNullOrEmpty(txtcrit.Text) OrElse String.IsNullOrEmpty(txtstatus.Text) Then
            MsgBox("Please input the fields", MsgBoxStyle.Exclamation, "Incomplete Data")
        Else
            sql = "Select ProductCode from tblProducts where ProductCode ='" & txtcode.Text & "'"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                MsgBox("Product already exists", MsgBoxStyle.Exclamation, "Duplicate Records")
            Else
                Call addData()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call updateProducts()
        clearText()
    End Sub
    Private Sub updateProducts()
        If String.IsNullOrEmpty(txtcode.Text) OrElse String.IsNullOrEmpty(txtprodname.Text) OrElse String.IsNullOrEmpty(txtProductDiscription.Text) OrElse String.IsNullOrEmpty(txtCategory.Text) OrElse String.IsNullOrEmpty(txtamount.Text) OrElse String.IsNullOrEmpty(txtquantity1.Text) OrElse String.IsNullOrEmpty(txtcrit.Text) OrElse String.IsNullOrEmpty(txtstatus.Text) Then
            MsgBox("Please input the all fields", MsgBoxStyle.Exclamation, "Incomplete Data")
        Else
            sql = "UPDATE tblProducts SET [ProdName] = @ProdName, [ProdDescription] = @ProdDescription, [Category] = @Category, [Amount] = @Amount, [Quantity] = @Quantity, [CriticalLevel] = @CriticalLevel, [Status] = @Status WHERE ProductCode = @ProductCode;"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@ProdName", txtprodname.Text)
                .Parameters.AddWithValue("@ProdDescription", txtProductDiscription.Text)
                .Parameters.AddWithValue("@Category", txtCategory.Text)
                .Parameters.AddWithValue("@Amount", txtamount.Text)
                .Parameters.AddWithValue("@Quantity", txtquantity1.Text)
                .Parameters.AddWithValue("@CriticalLevel", txtcrit.Text)
                .Parameters.AddWithValue("@Status", txtstatus.Text)
                .Parameters.AddWithValue("@ProductCode", txtcode.Text)
                .ExecuteNonQuery()
            End With
            Call LoadProducts()
            MsgBox("Products Record Successfully Updated", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call clearText()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Do you want to Logout?", vbQuestion + vbYesNo) = vbYes Then
            MsgBox("Goodbye!" & " " & "Have a nice day!", MsgBoxStyle.Information, "User Logout")
            Me.Close()
            ActLogs("Logged Out")
            frmlogin.ShowDialog()
        End If
    End Sub
End Class