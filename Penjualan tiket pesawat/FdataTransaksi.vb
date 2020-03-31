Imports System.Data.Odbc
Public Class FdataTransaksi
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
       
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Fmaster.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click
        Fcrud.Show()
    End Sub
End Class