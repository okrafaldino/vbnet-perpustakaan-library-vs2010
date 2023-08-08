Imports System.Data.Odbc
Public Class FormTransaksiPinjam
    Sub KondisiAwal()
        Call NomorOtamatis()
        Call MunculKodeAnggota()
        LBLNamaPetugas.Text = Module1.NamaPetugas
        LBLNama.Text = ""
        LBLAlamat.Text = ""
        LBLTelepon.Text = ""
        LBLJudul.Text = ""
        LBLPengarang.Text = ""
        LBLTahun.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        LBLTotalBuku.Text = "0"
        LBLTelahPinjam.Text = "0"
        Call kolom()
    End Sub

    Sub NomorOtamatis()
        Call koneksi()
        cmd = New OdbcCommand("select * From tbl_pinjam where NomorPinjam in (select max(NomorPinjam)from tbl_pinjam)", conn)
        Dim urutanKode As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutanKode = "PJM" + Format(Now, "yyMMdd") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
            urutanKode = "PJM" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        LBLNoPinjam.Text = urutanKode
        ComboBox1.Focus()
    End Sub

    Sub MunculKodeAnggota()
        Call koneksi()
        ComboBox1.Items.Clear()
        cmd = New OdbcCommand("Select * from tbl_anggota", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop
    End Sub

    Sub kolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("KodeBuku", "Kode Buku")
        DataGridView1.Columns.Add("JudulBuku", "Judul Buku")
        DataGridView1.Columns.Add("Pengarang", "Pengarang")
        DataGridView1.Columns.Add("Penerbit", "Penerbit")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub

    Private Sub FormTransaksiPinjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        LBLTanggal.Text = Today
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksi()
        cmd = New OdbcCommand("Select * From tbl_anggota where KodeAnggota = '" & ComboBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            LBLNama.Text = rd!Nama
            LBLAlamat.Text = rd!Alamat
            LBLTelepon.Text = rd!Telepon
            Call cekPinjaman()
        End If
    End Sub
   
  
    Sub RumusTotalBuku()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(4).Value
            LBLTotalBuku.Text = HitungItem
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Val(LBLTelahPinjam.Text) + Val(LBLTotalBuku.Text) >= 5 Or Val(LBLTotalBuku.Text) + Val(TextBox2.Text) > 5 Then
            MsgBox("Buku yang dipinjam melebihi maksimal !!!")
        Else
            If LBLJudul.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Silahkan Masukan Kode Buku dan Tekan Enter !!!")
            Else
                DataGridView1.Rows.Add(New String() {TextBox1.Text, LBLJudul.Text, LBLPengarang.Text, LBLTahun.Text, TextBox2.Text})
                TextBox1.Text = ""
                TextBox2.Text = ""
                LBLJudul.Text = ""
                TextBox2.Text = ""
                LBLPengarang.Text = ""
                LBLTahun.Text = ""
                Call RumusTotalBuku()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If LBLNama.Text = "" Then
            MsgBox("Transaksi Tidak ada , Silahkan lakukan transaksi terlebih dahulu !!!")
        Else
            Call koneksi()
            Dim tglsql As String
            tglsql = Format(Today, "yyyy-MM-dd")
            Dim SimpanPinjam As String = "Insert into tbl_pinjam values('" & LBLNoPinjam.Text &
                "','" & tglsql &
                "','" & LBLJam.Text &
                "','" & ComboBox1.Text &
                "','" & LBLTotalBuku.Text &
                "','" & LBLTotalBuku.Text &
                "','" & Module1.KodePetugas & "')"
            cmd = New OdbcCommand(SimpanPinjam, conn)
            cmd.ExecuteNonQuery()

            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call koneksi()
                Dim simpanDetail As String = "Insert into tbl_detail_pinjam values('" & LBLNoPinjam.Text &
                    "','" & DataGridView1.Rows(baris).Cells(0).Value &
                    "','" & DataGridView1.Rows(baris).Cells(4).Value & "')"
                cmd = New OdbcCommand(simpanDetail, conn)
                cmd.ExecuteNonQuery()

                Call koneksi()
                cmd = New OdbcCommand("select * from tbl_buku where KodeBuku = '" & DataGridView1.Rows(baris).Cells(0).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                Call koneksi()
                Dim KurangiStok As String = "Update tbl_buku set StokBuku = '" & rd.Item("StokBuku") - DataGridView1.Rows(baris).Cells(4).Value &
                    "' where KodeBuku ='" & DataGridView1.Rows(baris).Cells(0).Value & "'"
                cmd = New OdbcCommand(KurangiStok, conn)
                cmd.ExecuteNonQuery()
            Next
            Call KondisiAwal()
            MsgBox("Transaksi Berhasil Disimpan")

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call KondisiAwal()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OdbcCommand("Select * from tbl_buku where KodeBuku ='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("Kode Buku tidak ada !!!")
            Else
                TextBox1.Text = rd.Item("KodeBuku")
                LBLJudul.Text = rd.Item("JudulBuku")
                LBLPengarang.Text = rd.Item("Pengarang")
                LBLTahun.Text = rd.Item("Tahun")
                TextBox2.Enabled = True
                TextBox2.Text = "1"
            End If
        End If
    End Sub

    Sub cekPinjaman()
        Call koneksi()
        da = New OdbcDataAdapter("Select tbl_buku.KodeBuku,JudulBuku,JumlahBuku from tbl_anggota, tbl_pinjam,tbl_buku,tbl_detail_pinjam where tbl_buku.KodeBuku = tbl_detail_pinjam.KodeBuku And tbl_pinjam.NomorPinjam = tbl_detail_pinjam.NomorPinjam And tbl_anggota.KodeAnggota = tbl_pinjam.KodeAnggota And tbl_anggota.KodeAnggota = '" & ComboBox1.Text & "' And tbl_detail_pinjam.JumlahBuku>0", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Detail")
        DataGridView2.DataSource = (ds.Tables("Detail"))
        Dim HitungItemPinjam As Integer = 0
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            HitungItemPinjam = HitungItemPinjam + DataGridView2.Rows(i).Cells(2).Value
            LBLTelahPinjam.Text = HitungItemPinjam
        Next
        'LBLTelahPinjam.Text = DataGridView2.Rows.Count - 1
        DataGridView2.ReadOnly = True
    End Sub

   
End Class