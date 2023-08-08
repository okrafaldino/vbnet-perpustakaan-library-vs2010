Imports System.Data.Odbc
Public Class FormLaporanDataMaster

    Private Sub btnPetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPetugas.Click
        Dim query As String = "SELECT KodePetugas,NamaPetugas,LevelPetugas FROM tbl_petugas ORDER BY KodePetugas ASC"
        Try
            FormLaporanPetugas.DataSetPetugas.Clear()
            FormLaporanPetugas.DataSetPetugas.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, conn)
            da.Fill(FormLaporanPetugas.DataSetPetugas.dataPetugas)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        FormLaporanPetugas.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FormLaporanPetugas.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FormLaporanPetugas.ReportViewer1.ZoomPercent = 25
        FormLaporanPetugas.ReportViewer1.RefreshReport()
        FormLaporanPetugas.Show()
    End Sub

    Private Sub btnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuku.Click
        Dim query As String = "SELECT * FROM tbl_buku ORDER BY KodeBuku ASC"
        Try
            FormLaporanBuku.DataSetBuku.Clear()
            FormLaporanBuku.DataSetBuku.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, conn)
            da.Fill(FormLaporanBuku.DataSetBuku.dataBuku)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        FormLaporanBuku.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FormLaporanBuku.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FormLaporanBuku.ReportViewer1.ZoomPercent = 25
        FormLaporanBuku.ReportViewer1.RefreshReport()
        FormLaporanBuku.Show()
    End Sub

    Private Sub btnAnggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnggota.Click
        Dim query As String = "SELECT * FROM tbl_anggota ORDER BY KodeAnggota ASC"
        Try
            FormLaporanAnggota.DataSetAnggota.Clear()
            FormLaporanAnggota.DataSetAnggota.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, conn)
            da.Fill(FormLaporanAnggota.DataSetAnggota.dataAnggota)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        FormLaporanAnggota.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FormLaporanAnggota.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FormLaporanAnggota.ReportViewer1.ZoomPercent = 25
        FormLaporanAnggota.ReportViewer1.RefreshReport()
        FormLaporanAnggota.Show()
    End Sub

    Private Sub btnKategoriBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKategoriBuku.Click
        Dim query As String = "SELECT * FROM tbl_kategori ORDER BY KodeKategori ASC"
        Try
            FormLaporanKategori.DataSetKategori.Clear()
            FormLaporanKategori.DataSetKategori.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, conn)
            da.Fill(FormLaporanKategori.DataSetKategori.dataKategori)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        FormLaporanKategori.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FormLaporanKategori.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FormLaporanKategori.ReportViewer1.ZoomPercent = 25
        FormLaporanKategori.ReportViewer1.RefreshReport()
        FormLaporanKategori.Show()
    End Sub

    Private Sub btnRakBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRakBuku.Click
        Dim query As String = "SELECT * FROM tbl_rak ORDER BY KodeRak ASC"
        Try
            FormLaporanRak.DataSetRak.Clear()
            FormLaporanRak.DataSetRak.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, conn)
            da.Fill(FormLaporanRak.DataSetRak.dataRak)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        FormLaporanRak.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        FormLaporanRak.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        FormLaporanRak.ReportViewer1.ZoomPercent = 25
        FormLaporanRak.ReportViewer1.RefreshReport()
        FormLaporanRak.Show()
    End Sub
End Class