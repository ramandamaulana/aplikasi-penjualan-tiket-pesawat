<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fedit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.id_pemesan = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.ComboBox()
        Me.simpan = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.total = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.tujuan = New System.Windows.Forms.ComboBox()
        Me.no_hp = New System.Windows.Forms.TextBox()
        Me.nama_pemesan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kembali = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Bisnis", "Umum"})
        Me.ComboBox1.Location = New System.Drawing.Point(122, 225)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(134, 21)
        Me.ComboBox1.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(17, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Id Pemesan"
        '
        'id_pemesan
        '
        Me.id_pemesan.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.id_pemesan.Enabled = False
        Me.id_pemesan.Location = New System.Drawing.Point(122, 25)
        Me.id_pemesan.Name = "id_pemesan"
        Me.id_pemesan.Size = New System.Drawing.Size(134, 20)
        Me.id_pemesan.TabIndex = 41
        '
        'jumlah
        '
        Me.jumlah.FormattingEnabled = True
        Me.jumlah.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.jumlah.Location = New System.Drawing.Point(412, 92)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(134, 21)
        Me.jumlah.TabIndex = 40
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(412, 228)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(134, 35)
        Me.simpan.TabIndex = 39
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(122, 268)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 38
        '
        'total
        '
        Me.total.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.total.Enabled = False
        Me.total.Location = New System.Drawing.Point(412, 181)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(134, 20)
        Me.total.TabIndex = 37
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(412, 136)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(134, 20)
        Me.harga.TabIndex = 36
        '
        'tujuan
        '
        Me.tujuan.FormattingEnabled = True
        Me.tujuan.Items.AddRange(New Object() {"Jakarta", "Bandung", "Surabaya"})
        Me.tujuan.Location = New System.Drawing.Point(122, 162)
        Me.tujuan.Name = "tujuan"
        Me.tujuan.Size = New System.Drawing.Size(134, 21)
        Me.tujuan.TabIndex = 35
        '
        'no_hp
        '
        Me.no_hp.Location = New System.Drawing.Point(122, 116)
        Me.no_hp.Name = "no_hp"
        Me.no_hp.Size = New System.Drawing.Size(134, 20)
        Me.no_hp.TabIndex = 34
        '
        'nama_pemesan
        '
        Me.nama_pemesan.Location = New System.Drawing.Point(122, 73)
        Me.nama_pemesan.Name = "nama_pemesan"
        Me.nama_pemesan.Size = New System.Drawing.Size(134, 20)
        Me.nama_pemesan.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(318, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Jumlah Tiket"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(318, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Total bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(14, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Berangkat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(318, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Kelas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Dari "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(14, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "No.Telepon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nama Pemesan"
        '
        'kembali
        '
        Me.kembali.Location = New System.Drawing.Point(412, 280)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(134, 36)
        Me.kembali.TabIndex = 44
        Me.kembali.Text = "&Kembali"
        Me.kembali.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Jakarta", "Bandung", "Surabaya"})
        Me.ComboBox2.Location = New System.Drawing.Point(122, 195)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(134, 21)
        Me.ComboBox2.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Tujuan"
        '
        'Fedit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.BackgroundImage = Global.Penjualan_tiket_pesawat.My.Resources.Resources.ethan_mcarthur_X_MOr6oa4_k_unsplash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(615, 372)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.id_pemesan)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.tujuan)
        Me.Controls.Add(Me.no_hp)
        Me.Controls.Add(Me.nama_pemesan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Fedit"
        Me.Text = "Edit Pemesanan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents id_pemesan As System.Windows.Forms.TextBox
    Friend WithEvents jumlah As System.Windows.Forms.ComboBox
    Friend WithEvents simpan As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents harga As System.Windows.Forms.TextBox
    Friend WithEvents tujuan As System.Windows.Forms.ComboBox
    Friend WithEvents no_hp As System.Windows.Forms.TextBox
    Friend WithEvents nama_pemesan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kembali As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
