Imports System.Data.Odbc
Public Class Fregis

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        form_login.Show()
        Me.Hide()
    End Sub



    Private Sub btnSimpan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            If username.Text = "" Or password.Text = "" Then
                MsgBox("Isi semua form!")

            Else
                Call Koneksi()
                Cmd = New Odbc.OdbcCommand("Insert into tbl_penumpang values ('" & username.Text & "','" & password.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "')", Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diinput")
                Form2.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class