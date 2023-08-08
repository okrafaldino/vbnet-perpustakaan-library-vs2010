Imports System.Data.Odbc
Public Class FormMenuUtamaAnggota

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

    Private Sub GetInfoBukuPinjam(ByVal kodeAnggota As String)
        ' Membuat koneksi ke database
        koneksi()

        ' Query untuk mendapatkan informasi buku yang dipinjam oleh anggota
        Dim query As String = "SELECT tbl_pinjam.NomorPinjam, tbl_buku.JudulBuku, tbl_pinjam.TglPinjam, DATE_ADD(tbl_pinjam.TglPinjam, INTERVAL 5 DAY) AS TglTenggat, tbl_detail_pinjam.JumlahBuku " & _
                              "FROM tbl_pinjam " & _
                              "INNER JOIN tbl_detail_pinjam ON tbl_pinjam.NomorPinjam = tbl_detail_pinjam.NomorPinjam " & _
                              "INNER JOIN tbl_buku ON tbl_detail_pinjam.KodeBuku = tbl_buku.KodeBuku " & _
                              "WHERE tbl_pinjam.KodeAnggota = ?"
        Dim cmd As New OdbcCommand(query, conn)
        cmd.Parameters.AddWithValue("@KodeAnggota", kodeAnggota)

        ' Menggunakan DataAdapter untuk mendapatkan hasil query ke dalam DataTable
        Dim da As New OdbcDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        ' Menambahkan kolom Status ke dalam DataTable
        dt.Columns.Add("Status", GetType(String))

        ' Menghitung status untuk setiap buku yang dipinjam
        For Each row As DataRow In dt.Rows
            Dim tglPinjam As Date = Convert.ToDateTime(row("TglPinjam"))
            Dim tglTenggat As Date = Convert.ToDateTime(row("TglTenggat"))
            Dim status As String

            If Date.Now > tglTenggat Then
                status = "Terlambat"
            Else
                Dim sisaHari As Integer = (tglTenggat - Date.Now).Days
                status = "Sisa " & sisaHari & " hari"
            End If

            row("Status") = status
        Next

        ' Membuat DataView untuk melakukan filter pada DataTable
        Dim dv As New DataView(dt)
        dv.RowFilter = "JumlahBuku > 0"

        ' Menampilkan hasil informasi buku ke dalam DataGridView atau kontrol lainnya
        DataGridView1.DataSource = dv.ToTable()

        ' Menutup koneksi ke database
        conn.Close()
    End Sub







    Private Sub FormMenuUtamaAnggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblStatus.Text = ""
        lblKodeUser.Text = KodeAnggota
        lblNamaUser.Text = NamaAnggota
        lblJam.Text = TimeOfDay
        lblTanggal.Text = Today
        lblSelected1.Visible = True
        pnlDasboard.Visible = True
        GetInfoBukuPinjam(KodeAnggota)
        DisplayData()
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

    Private Sub btnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click
        lblSelected1.Visible = True
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False

        'tampilkan panel konten' 
        pnlDasboard.Visible = True
        pnlInformasi.Visible = False
        pnlTentang.Visible = False
    End Sub

    Private Sub btnDataMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataMaster.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = True
        lblSelected3.Visible = False
        lblSelected4.Visible = False

        'tampilkan panel konten' 
        pnlDasboard.Visible = False
        pnlInformasi.Visible = True
        pnlTentang.Visible = False
    End Sub

    Private Sub btnTentangSaya_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTentangSaya.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = True
        lblSelected4.Visible = False

        'tampilkan panel konten' 
        pnlDasboard.Visible = False
        pnlInformasi.Visible = False
        pnlTentang.Visible = True
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = True

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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblJam.Text = TimeOfDay
    End Sub
End Class