Imports System.Data.Odbc
Public Class Form1

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        tampildata()
    End Sub

    Sub tampildata()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tbl_user", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_user")
        DataGridView1.DataSource = Ds.Tables("tbl_user")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Fmaster.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.Text = " Data Petugas " Then
            Dim id As String
            id = DataGridView1.SelectedCells(0).Value
            MyDB = "SELECT * FROM tbl_user where id='" & DataGridView1.Text & "'"
            Cmd = New Odbc.OdbcCommand(MyDB, Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Fadmin.Show()
                Fadmin.TextBox1.Text = Rd.Item(0)
                Fadmin.TextBox2.Text = Rd.Item(1)
                Fadmin.Button2.Text = "Update"
                Me.Close()


            End If
        End If
        Fadmin.Show()
        Me.Hide()
    End Sub
End Class