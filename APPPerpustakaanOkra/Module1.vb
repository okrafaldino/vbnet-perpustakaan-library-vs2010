Imports System.Data.Odbc

Module Module1
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public rd As OdbcDataReader
    Public dt As DataTable
    Public cmd As OdbcCommand
    Public mydb As String

    Public KodePetugas As String
    Public NamaPetugas As String
    Public LevelPetugas As String
    Public KodeAnggota As String
    Public NamaAnggota As String



    Public Sub koneksi()
        mydb = "Driver={Mysql ODBC 3.51 Driver};Database = perpustakaan;server = localhost; uid = root"
        conn = New OdbcConnection(mydb)
        If conn.State = ConnectionState.Closed Then conn.Open()


    End Sub
End Module
