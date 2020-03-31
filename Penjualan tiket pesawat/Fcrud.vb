Imports System.Data.Odbc
Public Class Fcrud
    Private Sub Form5_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Koneksi()
        tampildata()
    End Sub

    Sub tampildata()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tbl_pemesanan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_pemesanan")
        DataGridView1.DataSource = Ds.Tables("tbl_pemesanan")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnedit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Call Koneksi()
            Dim pesan As Integer
            pesan = MsgBox("Apakah anda yakin akan menghapus Data pada server .. " + TextBox1.Text, vbExclamation + vbYesNo, "Perhatian")
            If pesan = vbNo Then Exit Sub
            Cmd = New OdbcCommand("DELETE FROM tbl_pemesanan where id_pemesan = '" & TextBox1.Text & "'", Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil didelete")
            tampildata()
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Ftambah.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click

        Fedit.Show()
        Fedit.id_pemesan.Text = TextBox1.Text
        Me.Hide()
    End Sub
End Class
