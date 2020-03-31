Imports System.Data.Odbc

Public Class Fadmin

    Private Sub Fadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Koneksi()
        MyDB = "UPDATE tbl_user SET  username= '" & TextBox1.Text & "',password= '" & TextBox2.Text & "' where id= '" & TextId.Text & " ' "
        Cmd = New OdbcCommand(MyDB, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Information")
        Conn.Close()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class