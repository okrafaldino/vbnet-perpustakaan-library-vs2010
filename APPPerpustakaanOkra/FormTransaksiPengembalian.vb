Imports System.Data.Odbc
Public Class FormTransaksiPengembalian
    Sub KondisiAwal()
        TXTKODEAGT.Text = ""
        LBLNama.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        LBLJudul.Text = ""
        TextBox2.Text = ""
        LBLTglPinjam.Text = ""
        LBLLamaPinjam.Text = ""
        LBL_Denda.Text = ""
        LBLNoPinjam.Text = ""
        txtdibayar.Text = ""
        LBLDenda.Text = ""
        LBLKembali.Text = ""
        LBLTelahPinjam.Text = ""
        LBLTotal.Text = ""
    End Sub

    Sub KondisiAwal2()
        TextBox1.Text = ""
        TextBox2.Text = ""
        LBLJudul.Text = ""
        TextBox2.Text = ""
        LBLTglPinjam.Text = ""
        LBLLamaPinjam.Text = ""
        LBL_Denda.Text = ""
        LBLNoPinjam.Text = ""
        txtdibayar.Text = ""
        LBLDenda.Text = ""
        LBLKembali.Text = ""
    End Sub

    Sub TampilGrid()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("KodeBuku", "Kode Buku")
        DataGridView1.Columns.Add("NomorPinjam", "Nomor Pinjam")
        DataGridView1.Columns.Add("Judul", "Judul Buku")
        DataGridView1.Columns.Add("Jumlah", "Jumlah Pinjam")
        DataGridView1.Columns.Add("Tanggal", "Tanggal Pinjam")
        DataGridView1.Columns.Add("Lama", "Lama Pinjam")
        DataGridView1.Columns.Add("Denda", "Denda")
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 75
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 50
        DataGridView1.Columns(4).Width = 75
        DataGridView1.Columns(5).Width = 50
        DataGridView1.Columns(6).Width = 75
    End Sub

    Sub TampilGrid2()
        DataGridView2.Columns.Add("Kode", "Kode")
        DataGridView2.Columns.Add("Judul", "Judul Buku")
        DataGridView2.Columns.Add("Jumlah", "Jumlah")
        DataGridView2.Columns(0).Width = 75
        DataGridView2.Columns(1).Width = 300
        DataGridView2.Columns(2).Width = 100
        DataGridView2.ReadOnly = True
    End Sub

    Private Sub NomorOtamatis()
        Call koneksi()
        cmd = New OdbcCommand("select * From tbl_kembali where NomorKembali in (select max(NomorKembali)from tbl_kembali)", conn)
        Dim urutanKode As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutanKode = "KBL" + Format(Now, "yyMMdd") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
            urutanKode = "KBL" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        LBLNoKembali.Text = urutanKode
        'ComboBox1.Focus()
    End Sub

    Private Sub FormTransaksiPengembalian_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        koneksi()
        Call NomorOtamatis()
        LBLTanggalKembali.Text = Today
    End Sub


    Private Sub FormTransaksiPengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call koneksi()
        Call TampilGrid()
        'Call HapusMaster()
        Call NomorOtamatis()
        LBLNamaPetugas.Text = Module1.NamaPetugas
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub

    Sub Pinjaman()
        Call koneksi()
        da = New OdbcDataAdapter("Select tbl_buku.KodeBuku,JudulBuku,JumlahBuku from tbl_anggota, tbl_pinjam,tbl_buku,tbl_detail_pinjam where tbl_buku.KodeBuku = tbl_detail_pinjam.KodeBuku And tbl_pinjam.NomorPinjam = tbl_detail_pinjam.NomorPinjam And tbl_anggota.KodeAnggota = tbl_pinjam.KodeAnggota And tbl_anggota.KodeAnggota = '" & TXTKODEAGT.Text & "' And tbl_detail_pinjam.JumlahBuku>0", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Detail")
        DataGridView2.DataSource = (ds.Tables("Detail"))
        DataGridView2.ReadOnly = True
        DataGridView2.Columns(0).Width = 80
        DataGridView2.Columns(1).Width = 300
        DataGridView2.Columns(2).Width = 100
    End Sub

    Sub CariData()
        Call koneksi()
        cmd = New OdbcCommand("Select * From tbl_anggota where KodeAnggota = '" & TXTKODEAGT.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            LBLNama.Text = rd.Item("Nama")
            Call koneksi()
            cmd = New OdbcCommand("Select KodeAnggota from tbl_pinjam where KodeAnggota = '" & TXTKODEAGT.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Call koneksi()
                cmd = New OdbcCommand("Select SUM(TotalPinjam) as Ketemu from tbl_pinjam where KodeAnggota = '" & TXTKODEAGT.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                LBLTelahPinjam.Text = rd.Item(0)
                Call Pinjaman()
            End If
        Else
            MsgBox("Kode Anggota Tidak Ada")
        End If
    End Sub
  
    Private Sub TXTKODEAGT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTKODEAGT.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            Call CariData()
        End If
    End Sub




    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim kodeBuku As String = TextBox1.Text.ToLower()
            Dim kodeBukuExists As Boolean = False

            ' Validasi kode buku pada DataGridView1
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("KodeBuku").Value IsNot Nothing AndAlso row.Cells("KodeBuku").Value.ToString().ToLower() = kodeBuku Then
                    kodeBukuExists = True
                    Exit For
                End If
            Next

            If kodeBukuExists Then
                MsgBox("Kode Buku sudah ada diinputkan!")
                TextBox1.Text = ""
                LBLNoPinjam.Text = ""
                LBLJudul.Text = ""
                LBLTglPinjam.Text = ""
                TextBox2.Text = ""
                LBLLamaPinjam.Text = ""
                LBL_Denda.Text = ""
            Else
                Call koneksi()
                cmd = New OdbcCommand("Select distinct tbl_buku.KodeBuku,tbl_detail_pinjam.NomorPinjam,JudulBuku,JumlahBuku,TglPinjam From tbl_anggota,tbl_pinjam,tbl_buku,tbl_detail_pinjam where tbl_buku.KodeBuku = tbl_detail_pinjam.KodeBuku And tbl_pinjam.NomorPinjam = tbl_detail_pinjam.NomorPinjam And tbl_anggota.KodeAnggota = tbl_pinjam.KodeAnggota And tbl_anggota.KodeAnggota = '" & TXTKODEAGT.Text & "' And tbl_detail_pinjam.KodeBuku = '" & TextBox1.Text & "' And tbl_detail_pinjam.JumlahBuku>0", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If Not rd.HasRows Then
                    MsgBox("Kode Buku Bukan Yang Dipinjam!!!")
                    TextBox1.Text = ""
                    LBLNoPinjam.Text = ""
                    LBLJudul.Text = ""
                    LBLTglPinjam.Text = ""
                    TextBox2.Text = ""
                    LBLLamaPinjam.Text = ""
                    LBL_Denda.Text = ""
                Else
                    LBLNoPinjam.Text = rd.Item(1)
                    LBLJudul.Text = rd.Item(2)
                    LBLTglPinjam.Text = rd.Item(4)
                    TextBox2.Text = rd.Item(3)
                    LBLLamaPinjam.Text = DateDiff(DateInterval.Day, rd.Item(4), Today())
                    If LBLLamaPinjam.Text > 5 Then
                        LBL_Denda.Text = Val((LBLLamaPinjam.Text) - 5) * 1000
                    Else
                        LBL_Denda.Text = 0
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Rows.Add(New String() {TextBox1.Text, LBLNoPinjam.Text, LBLJudul.Text, TextBox2.Text, LBLTglPinjam.Text, LBLLamaPinjam.Text, LBL_Denda.Text})
        TextBox1.Text = ""
        LBLNoPinjam.Text = ""
        LBLJudul.Text = ""
        LBLTglPinjam.Text = ""
        TextBox2.Text = ""
        LBLLamaPinjam.Text = ""
        LBL_Denda.Text = ""

        Call TotalKembali()
        Call TotalDenda()
    End Sub

    Sub TotalKembali()
        Dim total As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            total += Val(DataGridView1.Rows(i).Cells(3).Value)
            LBLTotal.Text = total
        Next
    End Sub

    Sub TotalDenda()
        Dim total As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            total += Val(DataGridView1.Rows(i).Cells(6).Value)
            LBLDenda.Text = total
        Next
    End Sub


   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TXTKODEAGT.Text = "" Or LBLDenda.Text = "" Or LBLKembali.Text = "" Then
            MsgBox("Transaksi tidak ada , silahkan lakukan transaksi terlebih dahulu !!!")
        Else
            Call koneksi()
            Dim tglsql As String
            tglsql = Format(Today, "yyyy-MM-dd")
            Dim BukuKembali As String = "Insert into tbl_kembali(NomorKembali,TglKembali,TotalKembali,Denda,DiBayar,Kembali,KodeAnggota,KodePetugas) values('" & LBLNoKembali.Text &
                "','" & tglsql &
                "','" & LBLTotal.Text &
                "','" & LBLDenda.Text &
                "','" & txtdibayar.Text &
                "','" & LBLKembali.Text &
                "','" & TXTKODEAGT.Text &
                "','" & Module1.KodePetugas & "')"
            cmd = New OdbcCommand(BukuKembali, conn)
            cmd.ExecuteNonQuery()

            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call koneksi()
                Dim simpanDetail As String = "Insert into tbl_detail_kembali(NomorKembali,KodeBuku,JumlahBuku) values('" & LBLNoKembali.Text &
                    "','" & DataGridView1.Rows(baris).Cells(0).Value &
                    "','" & DataGridView1.Rows(baris).Cells(3).Value & "')"
                cmd = New OdbcCommand(simpanDetail, conn)
                cmd.ExecuteNonQuery()

                'Update buku
                Call koneksi()
                cmd = New OdbcCommand("select * from tbl_buku where KodeBuku = '" & DataGridView1.Rows(baris).Cells(0).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Call koneksi()
                    Dim TambahStok As String = "Update tbl_buku set StokBuku = '" & rd.Item("StokBuku") + DataGridView1.Rows(baris).Cells(3).Value &
                        "' where KodeBuku ='" & DataGridView1.Rows(baris).Cells(0).Value & "'"
                    cmd = New OdbcCommand(TambahStok, conn)
                    cmd.ExecuteNonQuery()
                End If
                

                'Update detail Pinjam
                Call koneksi()
                cmd = New OdbcCommand("select JumlahBuku from tbl_detail_pinjam where KodeBuku = '" & DataGridView1.Rows(baris).Cells(0).Value & "'  And NomorPinjam = '" & DataGridView1.Rows(baris).Cells(1).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Call koneksi()
                    Dim UpdateDetailPinjam As String = "Update tbl_detail_pinjam set JumlahBuku = '" & rd.Item(0) - DataGridView1.Rows(baris).Cells(3).Value &
                        "' where KodeBuku ='" & DataGridView1.Rows(baris).Cells(0).Value & "' And NomorPinjam = '" & DataGridView1.Rows(baris).Cells(1).Value & "' "
                    cmd = New OdbcCommand(UpdateDetailPinjam, conn)
                    cmd.ExecuteNonQuery()
                End If
                

                'Update total pinjam
                Call koneksi()
                cmd = New OdbcCommand("select TotalPinjam from tbl_pinjam where NomorPinjam = '" & DataGridView1.Rows(baris).Cells(1).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Call koneksi()
                    Dim UpdateTotalPinjam As String = "Update tbl_pinjam set TotalPinjam = '" & rd.Item(0) - DataGridView1.Rows(baris).Cells(3).Value &
                        "' where NomorPinjam ='" & DataGridView1.Rows(baris).Cells(1).Value & "' "
                    cmd = New OdbcCommand(UpdateTotalPinjam, conn)
                    cmd.ExecuteNonQuery()
                End If
                


            Next
            Call KondisiAwal()
            Call NomorOtamatis()
            DataGridView1.Columns.Clear()
            DataGridView2.Columns.Clear()
            MsgBox("Transaksi Berhasil Disimpan")
            Call TampilGrid()
        End If
    End Sub

    Private Sub txtdibayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdibayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtdibayar.Text) < Val(LBLDenda.Text) Then
                MsgBox("Pembayaran Anda Kurang")
                txtdibayar.Focus()
            ElseIf Val(txtdibayar.Text) = Val(LBLDenda.Text) Then
                LBLKembali.Text = 0
                Button2.Focus()
            Else
                LBLKembali.Text = Val(LBLDenda.Text) - Val(txtdibayar.Text)
                Button2.Focus()
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class