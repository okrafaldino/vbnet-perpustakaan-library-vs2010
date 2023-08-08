# Aplikasi Sistem Informasi Perpustakaan

Aplikasi Sistem Informasi Perpustakaan adalah proyek yang dibangun menggunakan bahasa VB.NET dengan IDE Microsoft Visual Studio 2010 dan menggunakan MySQL ODBC serta XAMPP sebagai web server. Aplikasi ini bertujuan untuk mengelola proses peminjaman dan pengembalian buku dalam suatu perpustakaan.

## Fitur Utama

- Pendaftaran anggota perpustakaan.
- Katalog buku  : Pencarian buku berdasarkan judul, pengarang, atau kategori.
- Proses peminjaman dan pengembalian buku.
- Notifikasi batas waktu pengembalian buku.
- Riwayat peminjaman dan pengembalian buku.

## Aktor atau Pengguna Sistem

Aplikasi ini memiliki 3 pengguna yaitu :

1. Petugas atau admin :
   Ketika login menggunakan username dan password petugas, maka tampil menu :
   - Dashboard
   - Data master yang berisi : data petugas , data anggota , data buku , data rak buku , data kategori buku . Yang mana admin/petugas 
     bisa mengola data tsb : seperti melihat , menginput , mengedit , dan menghapus data tersebut. Mengelola data anggota disini penting
   - Transaksi : Disini dilakukan transaksi peminjaman dan pengembalian buku , dari anggota
   - Laporan : Disini terdapat history dari setiap transaksi peminjaman dan pengembalian buku.
2. Anggota :
   Untuk mendapatkan username dan password , anggota harus daftar ke petugas . Dan setelah login terdapat menu :
   - Dashboard : disini terdapat halaman katalog buku , yang mana anggota bisa melihat buku yang tersedia , mencari buku , dimana letak 
     bukunya.
   - Informasi Pinjaman User : disini terdapar informasi buku yang telah dipinjam oleh si anggota , kapan tenggatnya ,sisa harinya.
3. Tamu 
   Ini merupakan orang yang belum jadi anggota , dan belum pernah melakukan transaksi peminjaman. Menu yang dapat dilihat :
   - Dashboard : sama dengan anggota disini terdapat katalog buku.
   
  
## Overview 

- Login
  
  ![Login](https://github.com/larymak/Html-Css-Recap/assets/141602862/d7a032ed-48d5-4ddc-90a1-f33ad83d2c7a)
  
- Menu Utama
  
  ![menu utama petugas](https://github.com/larymak/Html-Css-Recap/assets/141602862/7924c4d1-f1ac-4849-9bc5-2bb3ac7936e7)

- Data Master
  
  ![data master](https://github.com/larymak/Html-Css-Recap/assets/141602862/eea87e40-e388-4114-bc86-3770d6f12853)
  
- Transaksi
  
  ![transaksi](https://github.com/larymak/Html-Css-Recap/assets/141602862/742c797c-0001-47ca-8ffb-fbe8dc4a1e26)
  
- Laporan
  
  ![laporan](https://github.com/larymak/Html-Css-Recap/assets/141602862/3c7dd903-3841-45a0-a4c0-6e83e636d826)
  
- Katalog Buku
  
  ![katalog buku](https://github.com/larymak/Html-Css-Recap/assets/141602862/15aca864-a7a2-45c7-888b-7f9c28278421)
  
- Informasi Pinjaman Anggota
  
  ![informasi pinjam user](https://github.com/larymak/Html-Css-Recap/assets/141602862/7af25009-c5d9-4215-8ca8-a25d49ce2ede)
  

## Instalasi

1. Clone repositori ini ke komputer Anda.
2. Pastikan Anda memiliki Microsoft Visual Studio 2010 atau versi yang lebih baru.
3. Buka proyek menggunakan Visual Studio.
4. Konfigurasi koneksi database di module koneksi dengan pengaturan MySQL ODBC dan XAMPP.
   - Buat database dengan nama 'perpustakaan' dan import perpustakaan.sql
   - Mysql Odbc version 3.51 : atur dengan membuat data source namenya = 'koneksi'
   - Periksa module 1 apakah sudah sesuai.
6. Jalankan aplikasi melalui IDE Visual Studio atau hasil kompilasi.

## Kontribusi

Kami sangat menghargai kontribusi dari para pengembang. Jika Anda ingin berkontribusi pada proyek ini, Anda dapat melakukan langkah-langkah berikut:

1. Fork repositori ini.
2. Buat branch baru untuk fitur atau perbaikan tertentu.
3. Lakukan perubahan yang diperlukan.
4. Ajukan permintaan tarik (pull request) dengan deskripsi yang jelas tentang perubahan yang Anda buat.

## Lisensi

Aplikasi ini dilisensikan di bawah [Okrafaldino]. Silakan merujuk ke file `LISENSI.md` untuk informasi lebih lanjut.

## Kontak

Jika Anda memiliki pertanyaan atau masukan, silakan hubungi kami melalui [okrafaldino@gmail.com] .

---

[Badge Status Proyek / Informasi Tambahan]


