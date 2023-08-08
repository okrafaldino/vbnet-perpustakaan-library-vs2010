Imports System.Data.Odbc

Public Class FormMasterPetugas
    Sub kondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
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
        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("Operator")
    End Sub

    Sub munculGrid()
        Call koneksi()
        da = New OdbcDataAdapter("select KodePetugas,NamaPetugas,LevelPetugas from tbl_petugas", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_petugas")
        DataGridView1.DataSource = (ds.Tables("tbl_petugas"))
    End Sub

    Sub setelahisi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
    End Sub

    Private Sub FormMasterPetugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            cmd = New OdbcCommand("select * From tbl_petugas where KodePetugas in (select max(KodePetugas)from tbl_petugas)", conn)
            Dim urutanKode As String
            Dim hitung As String
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                urutanKode = "PTG" + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
                urutanKode = "PTG" + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
            TextBox1.Text = urutanKode
            TextBox2.Focus()

        Else

            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan isi data terlebih dahulu !!! ")
            Else
                Call koneksi()
                Dim InputData As String = "insert into tbl_petugas values ('" & TextBox1.Text &
                    "','" & TextBox2.Text &
                    "','" & TextBox3.Text &
                    "','" & ComboBox1.Text & "')"
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
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan isi data terlebih dahulu !!! ")
            Else
                Call koneksi()
                Dim EditData As String = "update tbl_petugas Set NamaPetugas = '" & TextBox2.Text &
                    "',Password = '" & TextBox3.Text &
                    "',LevelPetugas = '" & ComboBox1.Text &
                    "' where KodePetugas = '" & TextBox1.Text & "'"
                cmd = New OdbcCommand(EditData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Edit data berhasil !!! ")
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
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan isi data terlebih dahulu !!! ")
            Else
                Call koneksi()
                Dim HapusData As String = "delete from tbl_petugas where KodePetugas = '" & TextBox1.Text & "'"
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

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OdbcCommand("Select * from tbl_petugas where KodePetugas ='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("Kode Petugas tidak ada !!!")
            Else
                TextBox1.Text = rd.Item("KodePetugas")
                TextBox2.Text = rd.Item("NamaPetugas")
                TextBox3.Text = rd.Item("Password")
                ComboBox1.Text = rd.Item("LevelPetugas")

            End If
        End If
    End Sub


End Class