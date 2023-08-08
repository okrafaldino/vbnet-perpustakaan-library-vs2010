-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 08 Agu 2023 pada 15.10
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `perpustakaan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_anggota`
--

CREATE TABLE `tbl_anggota` (
  `KodeAnggota` varchar(12) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Password` varchar(25) NOT NULL,
  `JenisKelamin` varchar(12) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Telepon` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_anggota`
--

INSERT INTO `tbl_anggota` (`KodeAnggota`, `Nama`, `Password`, `JenisKelamin`, `Alamat`, `Telepon`) VALUES
('USER001', 'Arif Rahmad Hidayat', '123', 'Laki - Laki', 'Rawang Ketaping', '089560372797'),
('USER002', 'Aqil Irsyaq zarika', '123', 'Laki - Laki', 'Cengkeh', '08231572642'),
('USER003', 'Bintang', '123', 'Laki - Laki', 'Parak Laweh', '08524357829'),
('USER004', 'Belinda', '123', 'Perempuan', 'Jati', '08635278138'),
('USER005', 'Annisa', '123', 'Perempuan', 'Belimbing', '08956472828'),
('USER006', 'Khomsi', '123', 'Laki - Laki', 'Andruring', '08472542322'),
('USER007', 'Ahmad Khomsi', '123', 'Laki - Laki', 'Anduring', '08672352622');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_buku`
--

CREATE TABLE `tbl_buku` (
  `KodeBuku` varchar(12) NOT NULL,
  `JudulBuku` varchar(50) NOT NULL,
  `Pengarang` varchar(25) NOT NULL,
  `Penerbit` varchar(25) NOT NULL,
  `Tahun` varchar(12) NOT NULL,
  `KodeKategori` varchar(12) NOT NULL,
  `KodeRak` varchar(12) NOT NULL,
  `StokBuku` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_buku`
--

INSERT INTO `tbl_buku` (`KodeBuku`, `JudulBuku`, `Pengarang`, `Penerbit`, `Tahun`, `KodeKategori`, `KodeRak`, `StokBuku`) VALUES
('BOOK001', 'Sebuah Seni Bersikap Bodo Amat', 'Mark Manson', 'Gramedia', '2009', 'KAT002', 'RAK001', 9),
('BOOK002', 'Berani Tidak Disukai', 'Ichiro Kishimi Dan Fumita', 'Gramedia Pustaka Utama', '2019', 'KAT002', 'RAK001', 21),
('BOOK003', 'Atomic Habits', 'James Clear', 'Grasindo', '2016', 'KAT002', 'RAK001', 9),
('BOOK004', 'The Psychology of Money', 'Henry Manampiring', 'Kompas', '2018', 'KAT002', 'RAK001', 10),
('BOOK005', 'Filosofi Teras', 'Henry Manampiring', 'Kompas', '2016', 'KAT002', 'RAK001', 9);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detail_kembali`
--

CREATE TABLE `tbl_detail_kembali` (
  `NomorKembali` varchar(12) NOT NULL,
  `KodeBuku` varchar(12) NOT NULL,
  `JumlahBuku` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_detail_kembali`
--

INSERT INTO `tbl_detail_kembali` (`NomorKembali`, `KodeBuku`, `JumlahBuku`) VALUES
('KBL230709001', 'book001', 1),
('KBL230709002', 'book002', 1),
('KBL230710003', 'book004', 1),
('KBL230710004', 'book002', 1),
('KBL230710005', 'book001', 1),
('KBL230710005', 'book002', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detail_pinjam`
--

CREATE TABLE `tbl_detail_pinjam` (
  `NomorPinjam` varchar(12) NOT NULL,
  `KodeBuku` varchar(12) NOT NULL,
  `JumlahBuku` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_detail_pinjam`
--

INSERT INTO `tbl_detail_pinjam` (`NomorPinjam`, `KodeBuku`, `JumlahBuku`) VALUES
('PJM230709001', 'BOOK001', 0),
('PJM230709001', 'BOOK004', 0),
('PJM230709002', 'BOOK002', 0),
('PJM230710003', 'BOOK005', 1),
('PJM230710003', 'BOOK003', 1),
('PJM230710004', 'BOOK002', 0),
('PJM230710005', 'BOOK001', 0),
('PJM230710005', 'BOOK002', 0),
('PJM230710006', 'BOOK001', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_kategori`
--

CREATE TABLE `tbl_kategori` (
  `KodeKategori` varchar(12) NOT NULL,
  `NamaKategori` varchar(50) NOT NULL,
  `Deskripsi` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_kategori`
--

INSERT INTO `tbl_kategori` (`KodeKategori`, `NamaKategori`, `Deskripsi`) VALUES
('KAT001', 'Komunikasi Dan Ilmu Sosial', 'Berisi buku mengenai tentang seputar komunikasi dan ilmu Sosial'),
('KAT002', 'Self Improvement', 'Kategori ini berisi buku mengenai buku buku untuk meningkat diri ');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_kembali`
--

CREATE TABLE `tbl_kembali` (
  `NomorKembali` varchar(12) NOT NULL,
  `TglKembali` date NOT NULL,
  `TotalKembali` int(11) NOT NULL,
  `Denda` int(11) NOT NULL,
  `DiBayar` int(11) NOT NULL,
  `Kembali` int(11) NOT NULL,
  `KodeAnggota` varchar(12) NOT NULL,
  `KodePetugas` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_kembali`
--

INSERT INTO `tbl_kembali` (`NomorKembali`, `TglKembali`, `TotalKembali`, `Denda`, `DiBayar`, `Kembali`, `KodeAnggota`, `KodePetugas`) VALUES
('KBL230709001', '2023-07-09', 1, 0, 0, 0, 'user001', 'PTG001'),
('KBL230709002', '2023-07-09', 1, 0, 0, 0, 'user002', 'PTG002'),
('KBL230710003', '2023-07-10', 1, 0, 0, 0, 'user001', 'PTG001'),
('KBL230710004', '2023-07-10', 1, 0, 0, 0, 'user001', 'PTG001'),
('KBL230710005', '2023-07-10', 2, 0, 0, 0, 'user007', 'PTG001');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_petugas`
--

CREATE TABLE `tbl_petugas` (
  `KodePetugas` varchar(12) NOT NULL,
  `NamaPetugas` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  `LevelPetugas` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_petugas`
--

INSERT INTO `tbl_petugas` (`KodePetugas`, `NamaPetugas`, `Password`, `LevelPetugas`) VALUES
('PTG001', 'OKRA', '123', 'Admin'),
('PTG002', 'DINO', '123', 'Operator'),
('PTG003', 'Khomsi', '123', 'Operator');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_pinjam`
--

CREATE TABLE `tbl_pinjam` (
  `NomorPinjam` varchar(12) NOT NULL,
  `TglPinjam` date NOT NULL,
  `JamPinjam` time NOT NULL,
  `KodeAnggota` varchar(12) NOT NULL,
  `ItemPinjam` int(11) NOT NULL,
  `TotalPinjam` int(11) NOT NULL,
  `KodePetugas` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_pinjam`
--

INSERT INTO `tbl_pinjam` (`NomorPinjam`, `TglPinjam`, `JamPinjam`, `KodeAnggota`, `ItemPinjam`, `TotalPinjam`, `KodePetugas`) VALUES
('PJM230709001', '2023-07-09', '03:27:03', 'USER001', 2, 0, 'PTG001'),
('PJM230709002', '2023-07-09', '09:56:31', 'USER002', 1, 0, 'PTG002'),
('PJM230710003', '2023-07-10', '12:09:36', 'USER002', 2, 2, 'PTG002'),
('PJM230710004', '2023-07-10', '14:28:21', 'USER001', 1, 0, 'PTG001'),
('PJM230710005', '2023-07-10', '15:13:15', 'USER007', 2, 0, 'PTG001'),
('PJM230710006', '2023-07-10', '15:16:13', 'USER001', 1, 1, 'PTG001');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_rak`
--

CREATE TABLE `tbl_rak` (
  `KodeRak` varchar(12) NOT NULL,
  `NamaRak` varchar(50) NOT NULL,
  `KapasitasRak` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_rak`
--

INSERT INTO `tbl_rak` (`KodeRak`, `NamaRak`, `KapasitasRak`) VALUES
('RAK001', 'Rak B Utama', 150),
('Rak002', 'Rak C Sudut', 200);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_anggota`
--
ALTER TABLE `tbl_anggota`
  ADD PRIMARY KEY (`KodeAnggota`);

--
-- Indeks untuk tabel `tbl_buku`
--
ALTER TABLE `tbl_buku`
  ADD PRIMARY KEY (`KodeBuku`);

--
-- Indeks untuk tabel `tbl_kategori`
--
ALTER TABLE `tbl_kategori`
  ADD PRIMARY KEY (`KodeKategori`);

--
-- Indeks untuk tabel `tbl_kembali`
--
ALTER TABLE `tbl_kembali`
  ADD PRIMARY KEY (`NomorKembali`);

--
-- Indeks untuk tabel `tbl_petugas`
--
ALTER TABLE `tbl_petugas`
  ADD PRIMARY KEY (`KodePetugas`);

--
-- Indeks untuk tabel `tbl_pinjam`
--
ALTER TABLE `tbl_pinjam`
  ADD PRIMARY KEY (`NomorPinjam`);

--
-- Indeks untuk tabel `tbl_rak`
--
ALTER TABLE `tbl_rak`
  ADD PRIMARY KEY (`KodeRak`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
