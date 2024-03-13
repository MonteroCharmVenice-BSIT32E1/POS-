Imports System.Data.OleDb
Module ActivityLogs

    Public Sub ActLogs(Action As String)
        Call connection()
        Dim time As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim username As String = frmlogin.txtusername.Text
        Dim Position As String = frmlogin.lblposition.Text
        sql = "INSERT INTO tblActivityLogs ([Username], [Position], [Action],[Time]) VALUES (@Username, @Position,@Action, @Time)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@Username", username)
            .Parameters.AddWithValue("@Username", Position)
            .Parameters.AddWithValue("@Action", Action)
            .Parameters.AddWithValue("@Time", time)
            .ExecuteNonQuery()
        End With
    End Sub
End Module
