Imports System.Data.Odbc

Public Class FormMasterBuku
    Sub kondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        lblNamaKategori.Text = ""
        lblNamaRak.Text = ""


        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False

        Button1.Enabled = True
        Button1.Text = "INPUT"
        Button2.Enabled = True
        Button2.Text = "EDIT"
        Button3.Enabled = True
        Button3.Text = "DELETE"
        Button4.Enabled = True
        Button4.Text = "CLOSE"

        munculGrid()
        Call munculKodeKategori()
        Call munculKodeRak()
    End Sub

    Sub munculGrid()
        Call koneksi()
        da = New OdbcDataAdapter("select * from tbl_buku", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_buku")
        DataGridView1.DataSource = (ds.Tables("tbl_buku"))
    End Sub

    Sub setelahisi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
    End Sub

    Sub munculKodeKategori()
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_kategori", conn)
        ComboBox1.Items.Clear()
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop
    End Sub

    Sub munculKodeRak()
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_rak", conn)
        ComboBox2.Items.Clear()
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox2.Items.Add(rd.Item(0))
        Loop
    End Sub

    Private Sub FormMasterBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"

            Call setelahisi()

            Call koneksi()
            cmd = New OdbcCommand("select * From tbl_buku where KodeBuku in (select max(KodeBuku)from tbl_buku)", conn)
            Dim urutanKode As String
            Dim hitung As String
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                urutanKode = "BOOK" + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
                urutanKode = "BOOK" + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
            TextBox1.Text = urutanKode
            TextBox2.Focus()

        Else

            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or
                TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
                MsgBox("Silahkan isi data terlebih dahulu !!! ")
            Else
                Call koneksi()
                Dim InputData As String = "insert into tbl_buku values ('" & TextBox1.Text &
                    "','" & TextBox2.Text &
                    "','" & TextBox3.Text &
                    "','" & TextBox4.Text &
                    "','" & TextBox5.Text &
                    "','" & ComboBox1.Text &
                    "','" & ComboBox2.Text &
                    "','" & TextBox6.Text & "')"
                cmd = New OdbcCommand(InputData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil !!! ")
                Call kondisiAwal()

            End If

        End If
    End Sub

    

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "EDIT" Then
            Button2.Text = "Simpan"
            Button3.Enabled = False
            Button1.Enabled = False
            Button4.Text = "Batal"

            Call setelahisi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or
                TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
                MsgBox("Silahkan isi data terlebih dahulu !!! ")
            Else
                Call koneksi()
                Dim EditData As String = "update tbl_buku Set JudulBuku = '" & TextBox2.Text &
                    "',Pengarang = '" & TextBox3.Text &
                    "',Penerbit = '" & TextBox4.Text &
                    "',Tahun = '" & TextBox5.Text &
                    "',KodeKategori = '" & ComboBox1.Text &
                    "',KodeRak = '" & ComboBox2.Text &
                    "',StokBuku = '" & TextBox6.Text &
                    "' where KodeBuku = '" & TextBox1.Text & "'"
                cmd = New OdbcCommand(EditData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Update data berhasil !!! ")
                Call kondisiAwal()

            End If

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "DELETE" Then
            Button3.Text = "CONFIRM"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Batal"

            Call setelahisi()

        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or
                TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
                MsgBox("Silahkan isi data terlebih dahulu !!! ")
            Else
                Call koneksi()
                Dim HapusData As String = "delete from tbl_buku where KodeBuku = '" & TextBox1.Text & "'"
                cmd = New OdbcCommand(HapusData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Hapus data berhasil !!! ")
                Call kondisiAwal()
            End If

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "CLOSE" Then
            Me.Close()
        Else
            Call kondisiAwal()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_kategori where KodeKategori = '" & ComboBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            lblNamaKategori.Text = rd.Item("NamaKategori")
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_rak where KodeRak = '" & ComboBox2.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            lblNamaRak.Text = rd.Item("NamaRak")
        End If
    End Sub

    Sub fillFormBuku()
        ' Mengambil nilai dari TextBox
        Dim kodeBuku As String = TextBox1.Text

        ' Melakukan koneksi ke database
        Call koneksi()

        ' Membuat perintah SQL untuk mengambil data dari tabel
        Dim query As String = "SELECT * FROM tbl_buku WHERE KodeBuku = '" & kodeBuku & "'"

        ' Membuat objek DataAdapter dan DataSet
        Dim da As New OdbcDataAdapter(query, conn)
        Dim ds As New DataSet()

        ' Mengisi DataSet dengan data dari database
        da.Fill(ds, "tbl_buku")

        ' Mengecek apakah ada baris data yang ditemukan
        If ds.Tables("tbl_buku").Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables("tbl_buku").Rows(0)

            ' Mengisi field TextBox dengan nilai dari kolom tertentu
            TextBox2.Text = row("JudulBuku").ToString()
            TextBox3.Text = row("Pengarang").ToString()
            TextBox4.Text = row("Penerbit").ToString()
            TextBox5.Text = row("Tahun").ToString()
            TextBox6.Text = row("StokBuku").ToString()

            ' Mengisi field ComboBox dengan nilai tertentu
            ComboBox1.Text = row("KodeKategori").ToString()
            ComboBox2.Text = row("KodeRak").ToString()

            ' Mengisi field lainnya sesuai dengan kebutuhan
        Else
            ' Jika tidak ada data yang ditemukan
            MsgBox("Kode Buku tidak ada !!!")
        End If

        ' Menutup koneksi ke database
        conn.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            fillFormBuku()
        End If
    End Sub


End Class