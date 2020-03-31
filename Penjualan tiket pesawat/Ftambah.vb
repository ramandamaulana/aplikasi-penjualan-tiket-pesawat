Imports System.Data.Odbc
Public Class Ftambah

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)

    End Sub

    Private Sub jumlah_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jumlah.SelectedIndexChanged
        total.Text = Val(jumlah.Text) * Val(harga.Text)
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        Koneksi()
        MyDB = "insert into tbl_pemesanan (id_pemesan,Nama_pemesan,No_HP,dari,tujuan,kelas,jadwal,jumlah_tiket,harga,total_bayar) values ('" & id_pemesan.Text & "','" & nama_pemesan.Text & "', '" & no_hp.Text & "','" & ComboBox2.Text & "', '" & tujuan.Text & "','" & ComboBox1.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & jumlah.Text & "','" & harga.Text & "','" & total.Text & "')"
        Cmd = New OdbcCommand(MyDB, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Information")
        Conn.Close()
        Fcrud.tampildata()
        Fcrud.Show()

        Me.Hide()
        Fcrud.Show()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        otomatis()
        total.Enabled = False
    End Sub

    Sub otomatis()
        koneksi()
        Cmd = New Odbc.OdbcCommand("SELECT * FROM tbl_pemesanan ORDER BY id_pemesan DESC", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            id_pemesan.Text = "P" + "0001"
        Else
            id_pemesan.Text = Val(Microsoft.VisualBasic.Mid(Rd.Item("id_pemesan").ToString, 4, 3)) + 1
            If Len(id_pemesan.Text) = 1 Then
                id_pemesan.Text = "P000" & id_pemesan.Text & ""
            ElseIf Len(id_pemesan.Text) = 2 Then
                id_pemesan.Text = "P00" & id_pemesan.Text & ""
            ElseIf Len(id_pemesan.Text) = 3 Then
                id_pemesan.Text = "P0" & id_pemesan.Text & ""
            End If
        End If
        conn.Close()
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

    Private Sub id_pemesan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_pemesan.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batal.Click
        Fcrud.Show()
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class