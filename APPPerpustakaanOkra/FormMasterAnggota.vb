Imports System.Data.Odbc
Public Class FormMasterAnggota
    Sub kondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        ComboBox1.Enabled = False



        Button1.Enabled = True
        Button1.Text = "INPUT"
        Button2.Enabled = True
        Button2.Text = "EDIT"
        Button3.Enabled = True
        Button3.Text = "DELETE"
        Button4.Enabled = True
        Button4.Text = "CLOSE"

        munculKombo()
        munculGrid()
        TextBox3.PasswordChar = "*"
    End Sub

    Sub munculKombo()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Laki - Laki")
        ComboBox1.Items.Add("Perempuan")
    End Sub

    Sub munculGrid()
        Call koneksi()
        da = New OdbcDataAdapter("select KodeAnggota,Nama,JenisKelamin,Alamat,Telepon from tbl_anggota", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_anggota")
        DataGridView1.DataSource = (ds.Tables("tbl_anggota"))
    End Sub

    Sub setelahisi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        ComboBox1.Enabled = True
    End Sub


    Private Sub FormMasterAnggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            cmd = New OdbcCommand("select * From tbl_anggota where KodeAnggota in (select max(KodeAnggota)from tbl_anggota)", conn)
            Dim urutanKode As String
            Dim hitung As String
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                urutanKode = "USER" + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
                urutanKode = "USER" + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
            TextBox1.Text = urutanKode
            TextBox2.Focus()

        Else

            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Silahkan isi data terlebih dahulu !!! ")
            Else
                Call koneksi()
                Dim InputData As String = "insert into tbl_anggota values ('" & TextBox1.Text &
                    "','" & TextBox2.Text &
                    "','" & TextBox3.Text &
                    "','" & ComboBox1.Text &
                    "','" & TextBox4.Text &
                    "','" & TextBox5.Text & "')"
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Silahkan isi data terlebih dahulu !!! ")
            Else
                Call koneksi()
                Dim EditData As String = "update tbl_anggota Set Nama = '" & TextBox2.Text &
                    "',Password = '" & TextBox3.Text &
                    "',JenisKelamin = '" & ComboBox1.Text &
                    "',Alamat = '" & TextBox4.Text &
                    "',Telepon = '" & TextBox5.Text &
                    "' where KodeAnggota = '" & TextBox1.Text & "'"
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Silahkan isi data terlebih dahulu !!! ")
            Else
                Call koneksi()
                Dim HapusData As String = "delete from tbl_anggota where KodeAnggota = '" & TextBox1.Text & "'"
                cmd = New OdbcCommand(HapusData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Hapus data berhasil !!! ")
                Call kondisiAwal()

            End If

        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OdbcCommand("Select * from tbl_anggota where KodeAnggota ='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("Kode Anggota tidak ada !!!")
            Else
                TextBox1.Text = rd.Item("KodeAnggota")
                TextBox2.Text = rd.Item("Nama")
                TextBox3.Text = rd.Item("Password")
                ComboBox1.Text = rd.Item("JenisKelamin")
                TextBox4.Text = rd.Item("Alamat")
                TextBox5.Text = rd.Item("Telepon")

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

    End Sub
End Class