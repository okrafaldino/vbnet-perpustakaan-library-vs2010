Imports System.Data.Odbc
Public Class MenuUtama



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
        DataGridView1.DataSource = ds.Tables("tbl_buku")


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
        DataGridView1.DataSource = ds.Tables("tbl_buku")

        ' Menutup koneksi ke database
        conn.Close()
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnDataMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataMaster.Click
        'tombol untuk yang dipilih'
        lblSelected1.Visible = False
        lblSelected2.Visible = True
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = False

        'tampilkan panel konten' 
        pnlDasboard.Visible = False
        pnlDataMaster.Visible = True
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        pnlTentang.Visible = False
    End Sub

    Private Sub btnTransaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaksi.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = True
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = False

        'tampilkan panel konten' 
        pnlDasboard.Visible = False
        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = True
        pnlLaporan.Visible = False
        pnlTentang.Visible = False
    End Sub

    Private Sub btnLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaporan.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = True
        lblSelected5.Visible = False
        lblSelected6.Visible = False

        'tampilkan panel konten' 
        pnlDasboard.Visible = False
        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = True
        pnlTentang.Visible = False
    End Sub


    Private Sub btnTentangSaya_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTentangSaya.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = True
        lblSelected6.Visible = False

        'tampilkan panel konten' 
        pnlDasboard.Visible = False
        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        pnlTentang.Visible = True

    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = True

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



    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblNamaUser.Text = ""
        lblStatus.Text = ""
        lblKodeUser.Text = KodePetugas
        lblNamaUser.Text = NamaPetugas
        lblStatus.Text = LevelPetugas

        If lblStatus.Text = "Operator" Then
            btnPetugas.Visible = False
            lblBtnPetugas.Visible = False
            btnAnggota.Location = New Point(74, 64)
            lblBtnAnggota.Location = New Point(74, 177)
            btnKategoriBuku.Location = New Point(276, 64)
            lblBtnKat.Location = New Point(276, 177)
            btnLapMaster.Location = New Point(276, 262)
            lblBtnMaster.Location = New Point(276, 375)
        Else
            btnPetugas.Visible = True
            btnAnggota.Location = New Point(276, 64)
            lblBtnAnggota.Location = New Point(276, 177)
            btnKategoriBuku.Location = New Point(276, 262)
            lblBtnKat.Location = New Point(276, 375)
            btnLapMaster.Location = New Point(478, 262)
            lblBtnMaster.Location = New Point(478, 375)
        End If

        'Lanjutkan dengan inisialisasi dan tampilan form menu utama
        lblJam.Text = TimeOfDay
        lblTanggal.Text = Today
        lblSelected1.Visible = True
        pnlDasboard.Visible = True

        DisplayData()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblJam.Text = TimeOfDay
    End Sub

    Private Sub btnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click
        lblSelected1.Visible = True
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = False

        'tampilkan panel konten' 
        pnlDasboard.Visible = True
        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
    End Sub

    Private Sub btnPetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPetugas.Click
        FormMasterPetugas.Show()
    End Sub

    Private Sub btnAnggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnggota.Click
        FormMasterAnggota.Show()
    End Sub

    Private Sub btnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuku.Click
        FormMasterBuku.Show()
    End Sub

    Private Sub btnLapPinjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLapPinjam.Click
        Dim query As String = "SELECT * FROM tbl_pinjam ORDER BY NomorPinjam ASC"
        Try
            FormLaporanPinjam.DataSetPinjam.Clear()
            FormLaporanPinjam.DataSetPinjam.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, conn)
            da.Fill(FormLaporanPinjam.DataSetPinjam.dataPinjam)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        FormLaporanPinjam.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FormLaporanPinjam.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FormLaporanPinjam.ReportViewer1.ZoomPercent = 25
        FormLaporanPinjam.ReportViewer1.RefreshReport()
        FormLaporanPinjam.Show()
    End Sub

    Private Sub btnLapKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLapKembali.Click
        Dim query As String = "SELECT * FROM tbl_kembali ORDER BY NomorKembali ASC"
        Try
            FormLaporanKembali.DataSetKembali.Clear()
            FormLaporanKembali.DataSetKembali.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, conn)
            da.Fill(FormLaporanKembali.DataSetKembali.dataKembali)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        FormLaporanKembali.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FormLaporanKembali.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FormLaporanKembali.ReportViewer1.ZoomPercent = 25
        FormLaporanKembali.ReportViewer1.RefreshReport()
        FormLaporanKembali.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPinjam.Click
        FormTransaksiPinjam.ShowDialog()
    End Sub

    Private Sub btnKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKembali.Click
        FormTransaksiPengembalian.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub lblTextSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTextSearch.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub pnlLaporan_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlLaporan.Paint

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub pnlTransaksi_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlTransaksi.Paint

    End Sub

    Private Sub lblBtnPetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBtnPetugas.Click

    End Sub

    Private Sub lblBtnAnggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBtnAnggota.Click

    End Sub

    Private Sub lblBtnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBtnBuku.Click

    End Sub

    Private Sub btnRakBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRakBuku.Click
        FormMasterRak.Show()
    End Sub

    Private Sub lblBtnRak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBtnRak.Click

    End Sub

    Private Sub btnKategoriBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKategoriBuku.Click
        FormMasterKategori.Show()
    End Sub

    Private Sub lblBtnKat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBtnKat.Click

    End Sub

    Private Sub btnLapMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLapMaster.Click
        FormLaporanDataMaster.Show()
    End Sub

    Private Sub lblBtnMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBtnMaster.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub pnlDataMaster_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlDataMaster.Paint

    End Sub

    Private Sub pnlClose_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlClose.Paint

    End Sub

    Private Sub pnlTop_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlTop.Paint

    End Sub

    Private Sub lblTanggal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTanggal.Click

    End Sub

    Private Sub lblJam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblJam.Click

    End Sub

    Private Sub lblSelected2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSelected2.Click

    End Sub

    Private Sub lblSelected3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSelected3.Click

    End Sub

    Private Sub lblSelected4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSelected4.Click

    End Sub

    Private Sub lblSelected5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblSelected6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSelected5.Click

    End Sub

    Private Sub lblSelected7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSelected6.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnAvatar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvatar.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStatus.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub lblNamaUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNamaUser.Click

    End Sub

    Private Sub lblKodeUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblKodeUser.Click

    End Sub

    Private Sub lblSelected1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSelected1.Click

    End Sub

    Private Sub pnlLeft_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlLeft.Paint

    End Sub

    Private Sub pnlDasboard_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlDasboard.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim query As String = "SELECT * FROM tbl_detail_pinjam ORDER BY NomorPinjam ASC"
        Try
            FormLaporanDetailPinjam.DataSetDetailPinjam.Clear()
            FormLaporanDetailPinjam.DataSetDetailPinjam.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, conn)
            da.Fill(FormLaporanDetailPinjam.DataSetDetailPinjam.dataDetailPinjam)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        FormLaporanDetailPinjam.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FormLaporanDetailPinjam.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FormLaporanDetailPinjam.ReportViewer1.ZoomPercent = 25
        FormLaporanDetailPinjam.ReportViewer1.RefreshReport()
        FormLaporanDetailPinjam.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim query As String = "SELECT * FROM tbl_detail_kembali ORDER BY NomorKembali ASC"
        Try
            FormLaporanDetailKembali.DataSetDetailKembali.Clear()
            FormLaporanDetailKembali.DataSetDetailKembali.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, conn)
            da.Fill(FormLaporanDetailKembali.DataSetDetailKembali.dataDetailKembali)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        FormLaporanDetailKembali.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FormLaporanDetailKembali.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FormLaporanDetailKembali.ReportViewer1.ZoomPercent = 25
        FormLaporanDetailKembali.ReportViewer1.RefreshReport()
        FormLaporanDetailKembali.Show()
    End Sub
End Class
