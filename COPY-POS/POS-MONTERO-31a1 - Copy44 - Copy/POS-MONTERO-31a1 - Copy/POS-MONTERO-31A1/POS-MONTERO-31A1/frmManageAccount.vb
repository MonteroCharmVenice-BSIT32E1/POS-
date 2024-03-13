Imports System.Data.OleDb
Public Class frmManageAccount
    Private Sub frmManageAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call LoadAccounts()
        Call checkifExist()
    End Sub
    Private Sub LoadAccounts()
        sql = "SELECT * FROM tblUsers"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListView1.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("Username").ToString)
            x.SubItems.Add(dr("Password").ToString)
            x.SubItems.Add(dr("Lastname").ToString)
            x.SubItems.Add(dr("Firstname").ToString)
            x.SubItems.Add(dr("Position").ToString)
            x.SubItems.Add(dr("Sex").ToString)
            x.SubItems.Add(dr("Middlename").ToString)
            ListView1.Items.Add(x)
        Loop
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtusername.text = ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub
    Private Sub checkifExist()
        sql = "SELECT username FROM tblUsers WHERE username = '" & txtusername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            MsgBox("Username already exist", MsgBoxStyle.Exclamation, "Re-Create username")
        Else
            Call addData()
        End If
    End Sub

    Private Sub addData()
        sql = "INSERT INTO tblUsers ([Lastname], [Firstname], [Password], [Username], [Position]) values (@Lastname), (@Firstname), (@Password), (@Username), (@Position)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@Lastname", txtlastname.Text)
            .Parameters.AddWithValue("@Firstname", txtfirstname.Text)
            .Parameters.AddWithValue("@Password", txtpassword.Text)
            .Parameters.AddWithValue("@Username", txtusername.Text)
            .Parameters.AddWithValue("@Position", cboposition.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Record Successfully Added", MsgBoxStyle.Information)
        Call LoadAccounts()
    End Sub
    Private Sub updateData()
        sql = "UPDATE tblUsers SET [LastName] = @LastName, [FirstName] = @FirstName, [Password] = @Password, [Role] = @Role WHERE Username=@Username;"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@LastName", txtlastname.Text)
            .Parameters.AddWithValue("@FirstName", txtfirstname.Text)
            .Parameters.AddWithValue("@Password", txtpassword.Text)
            .Parameters.AddWithValue("@Role", cboposition.Text)
            .Parameters.AddWithValue("@Username", txtusername.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Update Successfully", MsgBoxStyle.Information)
        Call LoadAccounts()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtpassword.Text <> txtconfirmpassword.Text Then
            MsgBox("Password and Confirm Password Mismatch", MsgBoxStyle.Critical, "Re-type your Password")
        ElseIf txtpassword.TextLength < 6 Then
            MsgBox("Password is less than 6 characters", MsgBoxStyle.Critical)
        Else
            checkifExist()
        End If
        clearText()
    End Sub
    Private Sub clearText()
        txtusername.Clear()
        txtlastname.Clear()
        txtfirstname.Clear()
        txtpassword.Clear()
        txtconfirmpassword.Clear()
        cboposition.Text = ""
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        sql = "SELECT LastName, FirstName, Password, Role from tblUsers WHERE username = '" & txtusername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtlastname.Text = dr("LastName").ToString
            txtfirstname.Text = dr("FirstName").ToString
            txtpassword.Text = dr("Password").ToString
            cboposition.Text = dr("Role").ToString
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtpassword.Text <> txtconfirmpassword.Text Then
            MsgBox("Password and Confirm Password Mismatch", MsgBoxStyle.Critical, "Re-type your Password")
        ElseIf txtpassword.TextLength < 6 Then
            MsgBox("Password is less than 6 characters", MsgBoxStyle.Critical)
        Else
            Call updateData()
        End If
        clearText()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call clearText()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmAdmindashboard.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)

    End Sub
End Class