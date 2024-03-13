Imports System.Data.OleDb

Public Class frmlogin
    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            sql = "SELECT * FROM  tblUsers  WHERE Username='" & txtusername.Text & "' and Password='" & txtpassword.Text & "' and Status='Active'"
            cmd = New OleDb.OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                MsgBox("Login Succes", MsgBoxStyle.Information, "Success!")
                ActLogs("Logged in")

                If btnlogin.Enabled Then
                    If lblposition.Text = "Admin" Then
                        frmAdmindashboard.ShowDialog()

                    ElseIf lblposition.Text = "Cashier" Then
                        frmCashier.ShowDialog()

                    ElseIf lblposition.Text = "Manager" Then
                        frmMAainDashboard.ShowDialog()
                    End If
                End If
                Me.Hide()
            Else
                MsgBox("Log in failed", MsgBoxStyle.Critical)
                lblattempts.Text = lblattempts.Text - 1
                If lblattempts.Text = "0" Then
                    MsgBox("You reached the maximum attempt limits", MsgBoxStyle.Critical)
                    Call DisabledAccount()
                    btnlogin.Enabled = False
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub clear()
        txtpassword.Clear()
        txtusername.Clear()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub DisabledAccount()
        sql = "Update tblUsers Set Status=@Status where Username=@Username"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@Status", "Disable")
            .Parameters.AddWithValue("@Username", txtusername.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Your Account Has Been Disabled", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        sql = "Select [Position] from tblUsers where Username= '" & txtusername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblposition.Text = dr(0).ToString
        End If
    End Sub

    Private Sub lblposition_Click(sender As Object, e As EventArgs) Handles lblposition.Click

    End Sub
End Class