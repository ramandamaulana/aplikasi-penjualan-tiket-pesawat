Imports System.Data.Odbc
Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Fmaster.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tampildata()
    End Sub

    Sub tampildata()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tbl_penumpang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_penumpang")
        DataGridView1.DataSource = Ds.Tables("tbl_penumpang")
        DataGridView1.ReadOnly = True
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Fregis.Show()
    End Sub
End Class