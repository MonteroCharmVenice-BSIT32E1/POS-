Imports System.Data.OleDb
Public Class frmcreateaccount
    Private Sub frmcreateaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub
    Private Sub savedata()
        sql = "insert into tblusers([Username], [Password], [Position]) values([@Username], [@Password], [@Position])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("[@Username]", txtusername.Text)
            .Parameters.AddWithValue("[@Password]", txtpassword.Text)
            .Parameters.AddWithValue("[@Position]", cboposition.Text)
            .ExecuteNonQuery()
        End With

        MsgBox("New Record Successfully Save", MsgBoxStyle.Information, "Save Data")
    End Sub
    Private Sub checkifusernameexist()
        sql = "select Username from tblusers where username='" & txtusername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            MsgBox("Username already exists", MsgBoxStyle.Information, "Duplicate Records")

        ElseIf MsgBox("Are you sure that all credentials are correct?", vbQuestion + vbYesNo, "Create Account") = vbYes Then
            savedata()
            clear()
        End If
    End Sub
    Public Sub clear()
        txtpassword.Clear()
        txtconfirmpassword.Clear()
        txtusername.Clear()
        cboposition.Text = ""
    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        If txtpassword.Text <> txtconfirmpassword.Text Then
            MsgBox("Password mismatch", MsgBoxStyle.Critical, "re-write password")

        ElseIf txtpassword.TextLength < 6 And txtconfirmpassword.TextLength < 6 Then
            MsgBox("Password must be 6 characters and above", MsgBoxStyle.Critical)
        Else
            checkifusernameexist()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cboposition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboposition.SelectedIndexChanged

    End Sub
End Class