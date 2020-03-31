Imports System.Data.Odbc
Public Class Fedit

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
    End Sub

    Private Sub kembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kembali.Click
        Fcrud.Show()
        Me.Hide()
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        Koneksi()
        MyDB = "UPDATE tbl_pemesanan SET Nama_pemesan= '" & nama_pemesan.Text & "',No_HP= '" & no_hp.Text & "', dari= '" & ComboBox2.Text & "',tujuan= '" & tujuan.Text & "',kelas= '" & ComboBox1.Text & "',jadwal= '" & Format(DateTimePicker1.Value, ("yyyy-MM-dd")) & "',jumlah_tiket='" & jumlah.Text & "',harga= '" & harga.Text & "',total_bayar= '" & total.Text & "' WHERE id_pemesan = '" & id_pemesan.Text & "'"
        Cmd = New OdbcCommand(MyDB, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Information")
        Conn.Close()
        Fcrud.Show()
        tampildata()
        Me.Hide()
        Fcrud.Show()
    End Sub

    Private Sub total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total.TextChanged

    End Sub

    Private Sub tujuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tujuan.SelectedIndexChanged
        If tujuan.Text = "Jakarta" Then
            harga.Text = "900000"
        ElseIf tujuan.Text = "Bandung" Then
            harga.Text = "750000"
        Else
            harga.Text = "800000"

        End If
    End Sub

    Private Sub jumlah_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jumlah.SelectedIndexChanged
        total.Text = Val(jumlah.Text) * Val(harga.Text)
    End Sub

    Sub tampildata()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tbl_pemesanan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_pemesanan")
        Fcrud.DataGridView1.DataSource = Ds.Tables("tbl_pemesanan")
        Fcrud.DataGridView1.ReadOnly = True
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class