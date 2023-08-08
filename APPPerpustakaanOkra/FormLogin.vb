Imports System.Data.Odbc
Public Class FormLogin


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Melakukan koneksi ke database
        Call koneksi()

        ' Mendapatkan nilai dari TextBox username dan password
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        ' Mengecek apakah username dan password valid
        Dim isValidAdmin As Boolean = ValidateAdmin(username, password)
        Dim isValidUser As Boolean = ValidateUser(username, password)

        ' Memvalidasi login berdasarkan peran (admin atau user)
        If isValidAdmin Then
            ' Jika login valid sebagai admin, simpan informasi petugas ke variabel publik di modul koneksi
            Dim queryInfoPetugas As String = "SELECT KodePetugas ,NamaPetugas, LevelPetugas FROM tbl_petugas WHERE KodePetugas = ?"
            Dim cmdInfoPetugas As New OdbcCommand(queryInfoPetugas, conn)
            cmdInfoPetugas.Parameters.AddWithValue("@KodePetugas", username)

            Dim readerPetugas As OdbcDataReader = cmdInfoPetugas.ExecuteReader()
            If readerPetugas.HasRows Then
                readerPetugas.Read()
                KodePetugas = readerPetugas("KodePetugas").ToString()
                NamaPetugas = readerPetugas("NamaPetugas").ToString()
                LevelPetugas = readerPetugas("LevelPetugas").ToString()
            End If

            ' Tutup koneksi
            conn.Close()

            ' Buka form menu utama admin
            Dim formAdmin As New MenuUtama()
            formAdmin.Show()
            Me.Hide()

        ElseIf isValidUser Then
            ' Jika login valid sebagai user, simpan informasi anggota ke variabel publik di modul koneksi
            Dim queryInfoAnggota As String = "SELECT KodeAnggota,Nama FROM tbl_anggota WHERE KodeAnggota = ?"
            Dim cmdInfoAnggota As New OdbcCommand(queryInfoAnggota, conn)
            cmdInfoAnggota.Parameters.AddWithValue("@KodeAnggota", username)

            Dim readerAnggota As OdbcDataReader = cmdInfoAnggota.ExecuteReader()
            If readerAnggota.HasRows Then
                readerAnggota.Read()
                KodeAnggota = readerAnggota("KodeAnggota").ToString()
                NamaAnggota = readerAnggota("Nama").ToString()
            End If

            ' Tutup koneksi
            conn.Close()

            ' Buka form menu utama user
            Dim formUser As New FormMenuUtamaAnggota()
            formUser.Show()
            Me.Hide()
        Else
            ' Jika login tidak valid, tampilkan pesan kesalahan
            MessageBox.Show("Username atau password salah. Silakan coba lagi.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Menutup koneksi ke database
        conn.Close()
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.TabStop = False
        TextBox2.TabStop = False
    End Sub

    Private Function ValidateAdmin(ByVal username As String, ByVal password As String) As Boolean
        ' Melakukan validasi login sebagai admin
        ' Melakukan query ke database untuk mencocokkan username dan password admin
        Dim query As String = "SELECT COUNT(*) FROM tbl_petugas WHERE KodePetugas = ? AND Password = ?"
        Dim cmd As New OdbcCommand(query, conn)
        cmd.Parameters.AddWithValue("@KodePetugas", username)
        cmd.Parameters.AddWithValue("@Password", password)

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        ' Mengembalikan nilai True jika username dan password valid
        Return count > 0
    End Function

    Private Function ValidateUser(ByVal username As String, ByVal password As String) As Boolean
        ' Melakukan validasi login sebagai user
        ' Melakukan query ke database untuk mencocokkan username dan password user
        Dim query As String = "SELECT COUNT(*) FROM tbl_anggota WHERE KodeAnggota = ? AND Password = ?"
        Dim cmd As New OdbcCommand(query, conn)
        cmd.Parameters.AddWithValue("@KodeAnggota", username)
        cmd.Parameters.AddWithValue("@Password", password)

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        ' Mengembalikan nilai True jika username dan password valid
        Return count > 0
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FormMenuUtamTamu.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "Username" Or TextBox1.Text = "" Then
            TextBox1.ForeColor = Color.Silver
            TextBox1.Text = "Username"
        End If
    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        If TextBox1.Text = "Username" Then
            TextBox1.Clear()
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "Password" Or TextBox2.Text = "" Then
            TextBox2.ForeColor = Color.Silver
            TextBox2.Text = "Password"
            TextBox2.PasswordChar = ""
        End If
    End Sub

    Private Sub TextBox2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseClick
        If TextBox2.Text = "Password" Then
            TextBox2.Clear()
            TextBox2.ForeColor = Color.Black
            TextBox2.PasswordChar = "*"
        End If
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class