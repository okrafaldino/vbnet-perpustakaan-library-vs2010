Imports System.Data.Odbc
Public Class FormMenuUtamTamu

    Private Sub DisplayData()
        ' Melakukan koneksi ke database
        Call koneksi()

        ' Membuat perintah SQL untuk mengambil data dari tabel
        Dim query As String = "SELECT b.JudulBuku, b.Pengarang, b.Penerbit, b.Tahun, k.NamaKategori, r.NamaRak AS 'Lokasi Buku', " &
                              "CASE WHEN b.StokBuku > 0 THEN 'Tersedia' ELSE 'Telah Dipinjam' END AS 'Status' " &
                              "FROM tbl_buku b " &
                              "INNER JOIN tbl_kategori k ON b.KodeKategori = k.KodeKategori " &
                              "INNER JOIN tbl_rak r ON b.KodeRak = r.KodeRak"

        ' Membuat objek DataAdapter dan DataSet
        Dim da As New OdbcDataAdapter(query, conn)
        Dim ds As New DataSet()

        ' Mengisi DataSet dengan data dari database
        da.Fill(ds, "tbl_buku")

        'Mengisi DataGridView dengan data dari DataSet
        DataGridView2.DataSource = ds.Tables("tbl_buku")


        ' Menutup koneksi ke database
        conn.Close()
    End Sub


    Private Sub SearchData()
        ' Mendapatkan nilai pencarian dari TextBox
        Dim searchKeyword As String = lblTextSearch.Text.Trim()

        ' Melakukan koneksi ke database
        Call koneksi()

        ' Membuat perintah SQL untuk mencari data berdasarkan kriteria pencarian
        Dim query As String = "SELECT b.JudulBuku, b.Pengarang, b.Penerbit, b.Tahun, k.NamaKategori, r.NamaRak " &
                              "FROM tbl_buku b " &
                              "INNER JOIN tbl_kategori k ON b.KodeKategori = k.KodeKategori " &
                              "INNER JOIN tbl_rak r ON b.KodeRak = r.KodeRak " &
                              "WHERE b.JudulBuku LIKE '%" & searchKeyword & "%' " &
                              "OR b.Pengarang LIKE '%" & searchKeyword & "%' " &
                              "OR b.Penerbit LIKE '%" & searchKeyword & "%' " &
                              "OR b.Tahun LIKE '%" & searchKeyword & "%' " &
                              "OR k.NamaKategori LIKE '%" & searchKeyword & "%' " &
                              "OR r.NamaRak LIKE '%" & searchKeyword & "%'"

        ' Membuat objek DataAdapter dan DataSet
        Dim da As New OdbcDataAdapter(query, conn)
        Dim ds As New DataSet()

        ' Mengisi DataSet dengan data dari database
        da.Fill(ds, "tbl_buku")

        ' Mengisi DataGridView dengan data dari DataSet
        DataGridView2.DataSource = ds.Tables("tbl_buku")

        ' Menutup koneksi ke database
        conn.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblJam.Text = TimeOfDay
    End Sub



    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData()
    End Sub

    Private Sub btnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click
        lblSelected1.Visible = True
        lblSelected2.Visible = False
        lblSelected3.Visible = False

        'tampilkan panel konten' 
        pnlDashboard.Visible = True
        pnlTentang.Visible = False
    End Sub

    Private Sub FormMenuUtamTamu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblStatus.Text = ""
        lblKodeUser.Text = "Guest"
        lblNamaUser.Text = "Guest"
        lblJam.Text = TimeOfDay
        lblTanggal.Text = Today
        lblSelected1.Visible = True
        pnlDashboard.Visible = True
        DisplayData()
    End Sub

    Private Sub btnTentangSaya_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTentangSaya.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = True
        lblSelected3.Visible = False

        'tampilkan panel konten' 
        pnlDashboard.Visible = False
        pnlTentang.Visible = True
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = True

        ' Menampilkan message box konfirmasi logout
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika pengguna memilih Yes, melakukan logout
        If result = DialogResult.Yes Then
            ' Menampilkan kembali form login
            Dim formLogin As New FormLogin()
            formLogin.Show()

            ' Menutup form menu utama
            Me.Close()
        End If
    End Sub
End Class