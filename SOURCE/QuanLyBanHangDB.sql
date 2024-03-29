USE [master]
GO
/****** Object:  Database [QuanLyBanHang]    Script Date: 29/11/2023 11:26:08 AM ******/
CREATE DATABASE [QuanLyBanHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBanHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyBanHang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyBanHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyBanHang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyBanHang] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBanHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBanHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyBanHang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBanHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBanHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBanHang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyBanHang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyBanHang] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyBanHang', N'ON'
GO
ALTER DATABASE [QuanLyBanHang] SET QUERY_STORE = OFF
GO
USE [QuanLyBanHang]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaDonHang] [nvarchar](5) NOT NULL,
	[MaSanPham] [nvarchar](5) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [decimal](10, 2) NULL,
	[ThanhTien] [float] NULL,
	[MaKho] [nvarchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [nvarchar](5) NOT NULL,
	[MaSanPham] [nvarchar](5) NOT NULL,
	[SoLuongNhap] [int] NULL,
	[DonGiaNhap] [decimal](10, 2) NULL,
	[MaKho] [nvarchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DM_ManHinh]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_ManHinh](
	[MaManHinh] [nvarchar](5) NOT NULL,
	[TenManHinh] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDonHang] [nvarchar](5) NOT NULL,
	[NgayDat] [date] NULL,
	[TongGia] [float] NULL,
	[TrangThaiDonHang] [nvarchar](50) NULL,
	[MaKhachHang] [nvarchar](5) NULL,
	[NgayShipHang] [date] NULL,
	[MaNhanVien] [nvarchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [nvarchar](5) NOT NULL,
	[TenKhachHang] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[Email] [nvarchar](255) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaKho] [nvarchar](5) NOT NULL,
	[TenKho] [nvarchar](255) NULL,
	[MaNhanVien] [nvarchar](5) NULL,
	[DiaChiKho] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[MaKhuyenMai] [nvarchar](5) NOT NULL,
	[TenChuongTrinh] [nvarchar](255) NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
	[GiamGia] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhuyenMai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoai] [nvarchar](5) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [nvarchar](5) NOT NULL,
	[TenNhaCungCap] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[Email] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](5) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[ChucVu] [nvarchar](255) NULL,
	[CCCD] [char](12) NULL,
	[SoDienThoai] [char](10) NULL,
	[Luong] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanHoiKhachHang]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanHoiKhachHang](
	[MaPhanHoi] [nvarchar](5) NOT NULL,
	[NoiDungPhanHoi] [nvarchar](max) NULL,
	[DiemDanhGia] [int] NULL,
	[MaKhachHang] [nvarchar](5) NULL,
	[MaSanPham] [nvarchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhanHoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapHang](
	[MaPhieuNhap] [nvarchar](5) NOT NULL,
	[NgayNhap] [date] NULL,
	[MaNhaCungCap] [nvarchar](5) NULL,
	[MaNhanVien] [nvarchar](5) NULL,
	[TongTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QL_NguoiDung]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NguoiDung](
	[TenDangNhap] [nvarchar](5) NOT NULL,
	[MatKhau] [nvarchar](255) NULL,
	[HoatDong] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QL_NguoiDungNhomNguoiDung]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NguoiDungNhomNguoiDung](
	[TenDangNhap] [nvarchar](5) NOT NULL,
	[MaNhomNguoiDung] [nvarchar](5) NOT NULL,
	[GhiChu] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC,
	[MaNhomNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QL_NhomNguoiDung]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NhomNguoiDung](
	[MaNhom] [nvarchar](5) NOT NULL,
	[TenNhom] [nvarchar](255) NULL,
	[GhiChu] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QL_PhanQuyen]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_PhanQuyen](
	[MaNhomNguoiDung] [nvarchar](5) NOT NULL,
	[MaManHinh] [nvarchar](5) NOT NULL,
	[CoQuyen] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [nvarchar](5) NOT NULL,
	[TenSanPham] [nvarchar](255) NULL,
	[Gia] [decimal](10, 2) NULL,
	[SoLuong] [int] NULL,
	[MoTaSanPham] [nvarchar](max) NULL,
	[HinhAnh] [nvarchar](255) NULL,
	[NgayCapNhat] [date] NULL,
	[MaKhuyenMai] [nvarchar](5) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[MaThuongHieu] [nvarchar](5) NULL,
	[MaLoai] [nvarchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaKhachHang] [nvarchar](5) NOT NULL,
	[TenTaiKhoan] [char](11) NULL,
	[MatKhau] [char](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuongHieu]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuongHieu](
	[MaThuongHieu] [nvarchar](5) NOT NULL,
	[TenThuongHieu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThuongHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TonKho]    Script Date: 29/11/2023 11:26:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TonKho](
	[MaKho] [nvarchar](5) NOT NULL,
	[MaSanPham] [nvarchar](5) NOT NULL,
	[SoLuongTon] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH01', N'SP01', 1, CAST(31990000.00 AS Decimal(10, 2)), 31990000, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH02', N'SP02', 1, CAST(34990000.00 AS Decimal(10, 2)), 34990000, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH03', N'SP03', 2, CAST(21990000.00 AS Decimal(10, 2)), 43980000, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH04', N'SP01', 0, CAST(31990000.00 AS Decimal(10, 2)), 0, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH05', N'SP01', 0, CAST(31990000.00 AS Decimal(10, 2)), 0, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH06', N'SP01', 0, CAST(31990000.00 AS Decimal(10, 2)), 0, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH07', N'SP01', 0, CAST(31990000.00 AS Decimal(10, 2)), 0, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH08', N'SP01', 3, CAST(31990000.00 AS Decimal(10, 2)), 95970000, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH08', N'SP02', 1, CAST(34990000.00 AS Decimal(10, 2)), 34990000, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH10', N'SP01', 1, CAST(31990000.00 AS Decimal(10, 2)), 31990000, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH12', N'SP01', 0, CAST(31990000.00 AS Decimal(10, 2)), 0, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH13', N'SP01', 0, CAST(31990000.00 AS Decimal(10, 2)), 0, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH14', N'SP01', 1, CAST(31990000.00 AS Decimal(10, 2)), 31990000, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH15', N'SP01', 1, CAST(31990000.00 AS Decimal(10, 2)), 31990000, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH16', N'SP01', 0, CAST(31990000.00 AS Decimal(10, 2)), 0, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH17', N'SP01', 0, CAST(31990000.00 AS Decimal(10, 2)), 0, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH17', N'SP02', 0, CAST(34990000.00 AS Decimal(10, 2)), 0, N'K01')
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSanPham], [SoLuong], [DonGia], [ThanhTien], [MaKho]) VALUES (N'DH18', N'SP01', 1, CAST(31990000.00 AS Decimal(10, 2)), 31990000, N'K01')
GO
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN01', N'SP01', 5, CAST(28000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN01', N'SP02', 3, CAST(32000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN02', N'SP01', 2, CAST(28000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN02', N'SP03', 5, CAST(18000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN03', N'SP02', 2, CAST(32000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN03', N'SP03', 3, CAST(18000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN05', N'SP01', 1, CAST(20000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN08', N'SP01', 3, CAST(2000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN09', N'SP01', 1, CAST(2000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN09', N'SP02', 1, CAST(2000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN09', N'SP03', 1, CAST(3000000.00 AS Decimal(10, 2)), N'K02')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN10', N'SP03', 1, CAST(3000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN11', N'SP01', 1, CAST(30000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN12', N'SP01', 1, CAST(3000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN13', N'SP01', 1, CAST(1000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN14', N'SP01', 1, CAST(1000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN15', N'SP01', 1, CAST(200000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN16', N'SP01', 1, CAST(2000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN17', N'SP01', 1, CAST(2000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN17', N'SP02', 2, CAST(2000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN18', N'SP01', 4, CAST(2000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN18', N'SP02', 1, CAST(2000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN18', N'SP03', 1, CAST(2000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN19', N'SP01', 0, CAST(20000000.00 AS Decimal(10, 2)), N'K01')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuongNhap], [DonGiaNhap], [MaKho]) VALUES (N'PN21', N'SP01', 3, CAST(10000000.00 AS Decimal(10, 2)), N'K01')
GO
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH01', N'Trang chủ')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH02', N'Quản lý nhân viên')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH03', N'Quản lý nhóm người dùng')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH04', N'Quản lý hiển thị và phân quyền')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH05', N'Quản lý khách hàng')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH06', N'Quản lý loại sản phẩm')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH07', N'Quản lý thương hiệu')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH08', N'Quản lý sản phẩm')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH09', N'Quản lý nhà cung cấp')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH10', N'Quản lý kho')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH11', N'Quản lý bán hàng')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH12', N'Quản lý thông tin khuyến mãi')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH13', N'Quản lý nhập hàng')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH14', N'Thống kê báo cáo')
GO
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH01', CAST(N'2023-01-21' AS Date), 31990000, N'Đã giao', N'KH01', CAST(N'2023-01-23' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH02', CAST(N'2023-02-14' AS Date), 34990000, N'Đã giao', N'KH02', CAST(N'2023-02-20' AS Date), N'NV02')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH03', CAST(N'2023-03-12' AS Date), 43980000, N'Đã giao', N'KH03', CAST(N'2023-03-18' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH04', CAST(N'2023-11-20' AS Date), 0, N'Đã giao', N'KH01', CAST(N'2023-11-20' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH05', CAST(N'2023-11-20' AS Date), 0, N'Đã giao', N'KH01', CAST(N'2023-11-20' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH06', CAST(N'2023-11-20' AS Date), 0, N'Đã giao', N'KH01', CAST(N'2023-11-20' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH07', CAST(N'2023-11-20' AS Date), 0, N'Đã giao', N'KH01', CAST(N'2023-11-20' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH08', CAST(N'2023-11-20' AS Date), 130960000, N'Đã giao', N'KH01', CAST(N'2023-11-20' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH09', CAST(N'2023-11-20' AS Date), 0, N'Đã giao', N'KH01', CAST(N'2023-11-20' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH10', CAST(N'2023-11-20' AS Date), 31990000, N'Đã giao', N'KH01', CAST(N'2023-11-20' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH11', CAST(N'2023-11-20' AS Date), 0, N'Đã đặt', N'KH01', CAST(N'2023-11-20' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH12', CAST(N'2023-11-20' AS Date), 0, N'Đã đặt', N'KH01', CAST(N'2023-11-20' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH13', CAST(N'2023-11-20' AS Date), 0, N'Đã giao', N'KH01', CAST(N'2023-11-20' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH14', CAST(N'2023-11-20' AS Date), 31990000, N'Đã đặt', N'KH01', CAST(N'2023-11-20' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH15', CAST(N'2023-11-20' AS Date), 31990000, N'Đang giao', N'KH01', CAST(N'2023-11-20' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH16', CAST(N'2023-11-23' AS Date), 31990000, N'Đã giao', N'KH01', CAST(N'2023-11-23' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH17', CAST(N'2023-11-25' AS Date), 0, N'Đã giao', N'KH01', CAST(N'2023-11-25' AS Date), N'NV01')
INSERT [dbo].[DonHang] ([MaDonHang], [NgayDat], [TongGia], [TrangThaiDonHang], [MaKhachHang], [NgayShipHang], [MaNhanVien]) VALUES (N'DH18', CAST(N'2023-11-25' AS Date), 31990000, N'Đã giao', N'KH01', CAST(N'2023-11-25' AS Date), N'NV01')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [Email], [NgaySinh], [GioiTinh]) VALUES (N'KH01', N'Lê Thị Kim Ngân', N'123 Nguyễn Huệ, Q1, TP.HCM', N'0901234567', N'nganle@gmail.com', CAST(N'2000-03-25' AS Date), N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [Email], [NgaySinh], [GioiTinh]) VALUES (N'KH02', N'Nguyễn Minh Tuấn', N'456 Lê Lợi, Q.Tân Bình, TP.HCM', N'0939876789', N'tuannm@gmail.com', CAST(N'1997-07-12' AS Date), N'Nam')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [Email], [NgaySinh], [GioiTinh]) VALUES (N'KH03', N'Trần Thanh Tâm', N'789 CMT8, Q.Tân Phú, TP.HCM', N'0988234971', N'tamtt@gmail.com', CAST(N'1995-02-02' AS Date), N'Nữ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [Email], [NgaySinh], [GioiTinh]) VALUES (N'KH04', N'A', NULL, N'0778899668', NULL, NULL, NULL)
GO
INSERT [dbo].[Kho] ([MaKho], [TenKho], [MaNhanVien], [DiaChiKho]) VALUES (N'K01', N'Kho hàng 1', N'NV01', N'123 Võ Văn Ngân, Q.Thủ Đức, TP.HCM')
INSERT [dbo].[Kho] ([MaKho], [TenKho], [MaNhanVien], [DiaChiKho]) VALUES (N'K02', N'Kho hàng 2', N'NV02', N'456 Đinh Bộ Lĩnh, Bình Thạnh, TP.HCM')
GO
INSERT [dbo].[KhuyenMai] ([MaKhuyenMai], [TenChuongTrinh], [NgayBatDau], [NgayKetThuc], [GiamGia]) VALUES (N'KM01', N'Chương trình giảm giá mùa hè', CAST(N'2023-05-01' AS Date), CAST(N'2023-08-31' AS Date), CAST(0.10 AS Decimal(5, 2)))
INSERT [dbo].[KhuyenMai] ([MaKhuyenMai], [TenChuongTrinh], [NgayBatDau], [NgayKetThuc], [GiamGia]) VALUES (N'KM02', N'Ưu đãi sinh nhật cửa hàng', CAST(N'2023-12-01' AS Date), CAST(N'2023-12-31' AS Date), CAST(0.20 AS Decimal(5, 2)))
INSERT [dbo].[KhuyenMai] ([MaKhuyenMai], [TenChuongTrinh], [NgayBatDau], [NgayKetThuc], [GiamGia]) VALUES (N'KM03', N'Khuyến mãi Black Friday', CAST(N'2023-11-25' AS Date), CAST(N'2023-11-30' AS Date), CAST(0.30 AS Decimal(5, 2)))
INSERT [dbo].[KhuyenMai] ([MaKhuyenMai], [TenChuongTrinh], [NgayBatDau], [NgayKetThuc], [GiamGia]) VALUES (N'KM04', N'Không có khuyến mãi', NULL, NULL, CAST(0.00 AS Decimal(5, 2)))
INSERT [dbo].[KhuyenMai] ([MaKhuyenMai], [TenChuongTrinh], [NgayBatDau], [NgayKetThuc], [GiamGia]) VALUES (N'KM05', N'KM1', CAST(N'2023-11-16' AS Date), CAST(N'2023-11-16' AS Date), CAST(0.30 AS Decimal(5, 2)))
GO
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai]) VALUES (N'L02', N'Điện Thoại')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai]) VALUES (N'L01', N'LapTop')
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (N'NCC01', N'Công ty TNHH Thương mại Dịch vụ ABCD', N'123 Nguyễn Văn Cừ, Q.5, TP.HCM', N'0288888888', N'abcd@email.com')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (N'NCC02', N'Công ty Cổ phần Điện máy XYZ', N'456 Quang Trung, Q.Gò Vấp, TP.HCM', N'0289999999', N'xyz@email.com')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (N'NCC03', N'Công ty Cổ phần XNK Thiên Long', N'789 Lý Thường Kiệt, Q.11, TP.HCM', N'0290000000', N'thienlong@email.com')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [CCCD], [SoDienThoai], [Luong]) VALUES (N'NV01', N'Nguyễn Văn A', N'Quản lý', N'123456789123', N'0123456789', CAST(15000000.00 AS Decimal(10, 2)))
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [CCCD], [SoDienThoai], [Luong]) VALUES (N'NV02', N'Trần Thị B', N'Nhân viên', N'987654321987', N'0987654321', CAST(10000000.00 AS Decimal(10, 2)))
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [CCCD], [SoDienThoai], [Luong]) VALUES (N'NV03', N'Lê Văn C', N'Nhân viên', N'456789123123', N'0232345678', CAST(9000000.00 AS Decimal(10, 2)))
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [CCCD], [SoDienThoai], [Luong]) VALUES (N'NV04', N'Phạm Thị D', N'Nhân viên', N'258369147123', N'0909123456', CAST(8500000.00 AS Decimal(10, 2)))
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [CCCD], [SoDienThoai], [Luong]) VALUES (N'NV05', N'Hoàng Minh E', N'Bảo vệ', N'369258147211', N'0988776655', CAST(7000000.00 AS Decimal(10, 2)))
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [CCCD], [SoDienThoai], [Luong]) VALUES (N'NV06', N'v', N'B', N'123131231212', N'0973456789', CAST(4535.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[PhanHoiKhachHang] ([MaPhanHoi], [NoiDungPhanHoi], [DiemDanhGia], [MaKhachHang], [MaSanPham]) VALUES (N'PH01', N'Sản phẩm tốt, giao hàng nhanh.', 10, N'KH01', N'SP01')
INSERT [dbo].[PhanHoiKhachHang] ([MaPhanHoi], [NoiDungPhanHoi], [DiemDanhGia], [MaKhachHang], [MaSanPham]) VALUES (N'PH02', N'Cửa hàng phục vụ chu đáo, tư vấn nhiệt tình', 9, N'KH02', N'SP01')
INSERT [dbo].[PhanHoiKhachHang] ([MaPhanHoi], [NoiDungPhanHoi], [DiemDanhGia], [MaKhachHang], [MaSanPham]) VALUES (N'PH03', N'Giá cả phải chăng, sẽ ủng hộ tiếp.', 8, N'KH03', N'SP01')
GO
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN01', CAST(N'2023-01-15' AS Date), N'NCC01', N'NV01', 236000000)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN02', CAST(N'2023-02-28' AS Date), N'NCC02', N'NV02', 146000000)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN03', CAST(N'2023-03-20' AS Date), N'NCC03', N'NV03', 118000000)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN04', CAST(N'2023-11-18' AS Date), N'NCC01', N'NV01', 0)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN05', CAST(N'2023-11-18' AS Date), N'NCC01', N'NV01', 0)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN06', CAST(N'2023-11-18' AS Date), N'NCC01', N'NV01', 0)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN07', CAST(N'2023-11-18' AS Date), N'NCC01', N'NV01', 0)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN08', CAST(N'2023-11-18' AS Date), N'NCC01', N'NV01', 6000000)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN09', CAST(N'2023-11-18' AS Date), N'NCC01', N'NV01', 0)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN10', CAST(N'2023-11-18' AS Date), N'NCC01', N'NV01', 0)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN11', CAST(N'2023-11-18' AS Date), N'NCC01', N'NV01', 0)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN12', CAST(N'2023-11-18' AS Date), N'NCC01', N'NV01', 0)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN13', CAST(N'2023-11-18' AS Date), N'NCC01', N'NV01', 0)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN14', CAST(N'2023-11-18' AS Date), N'NCC01', N'NV01', 0)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN15', CAST(N'2023-11-18' AS Date), N'NCC01', N'NV01', 200000)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN16', CAST(N'2023-11-18' AS Date), N'NCC02', N'NV01', 2000000)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN17', CAST(N'2023-11-18' AS Date), N'NCC03', N'NV01', 6000000)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN18', CAST(N'2023-11-18' AS Date), N'NCC03', N'NV01', 12000000)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN19', CAST(N'2023-11-19' AS Date), N'NCC01', N'NV01', 0)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN20', CAST(N'2023-11-19' AS Date), N'NCC01', N'NV01', 0)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien], [TongTien]) VALUES (N'PN21', CAST(N'2023-11-19' AS Date), N'NCC01', N'NV01', 30000000)
GO
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV01', N'123', 0)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV02', N'123', 0)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV03', N'789', 0)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV04', N'246', 1)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV05', N'135', 1)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV06', N'123', 0)
GO
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'NV01', N'NN01', NULL)
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'NV02', N'NN02', NULL)
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'NV03', N'NN02', NULL)
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'NV04', N'NN04', NULL)
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'NV05', N'NN02', NULL)
GO
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'NN01', N'Nhóm quản trị', NULL)
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'NN02', N'Nhóm nhân viên', NULL)
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'NN03', N'Nhóm kế toán', NULL)
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'NN04', N'Nhóm Kho', N'')
GO
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH01', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH02', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH03', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH04', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH05', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH06', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH07', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH08', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH09', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH10', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH11', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH12', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH13', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN01', N'MH14', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN02', N'MH05', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN02', N'MH11', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN03', N'MH14', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN04', N'MH09', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN04', N'MH10', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NN04', N'MH13', 1)
GO
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP01', N'Điện thoại iPhone 14 Pro Max', CAST(31990000.00 AS Decimal(10, 2)), 21, N'Điện thoại iPhone 14 Pro Max 128GB chính hãng VN/A', N'Iphone.jpg', CAST(N'2023-02-15' AS Date), N'KM04', N'Còn hàng', N'TH01', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP02', N'Điện thoại Samsung Galaxy Z Fold4', CAST(34990000.00 AS Decimal(10, 2)), 7, N'Điện thoại Samsung Galaxy Z Fold4 512GB chính hãng', N'SamSung.jpg', CAST(N'2023-08-30' AS Date), N'KM02', N'Còn hàng', N'TH03', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP03', N'Laptop ASUS Zenbook Pro 15', CAST(21990000.00 AS Decimal(10, 2)), 9, N'Laptop ASUS Zenbook Pro 15 i7 12700H/16GB/1TB/RTX 3050', N'LapTop.jpg', CAST(N'2023-05-12' AS Date), N'KM04', N'Còn hàng', N'TH02', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP04', N'Điện thoại OnePlus 10 Pro', CAST(27990000.00 AS Decimal(10, 2)), 15, N'Điện thoại OnePlus 10 Pro 256GB chính hãng', N'OnePlus.jpg', CAST(N'2023-10-20' AS Date), N'KM03', N'Còn hàng', N'TH03', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP05', N'Laptop Dell XPS 15', CAST(28990000.00 AS Decimal(10, 2)), 5, N'Laptop Dell XPS 15 i7 12800H/16GB/512GB/RTX 3050 Ti', N'DellXPS.jpg', CAST(N'2023-09-08' AS Date), N'KM02', N'Còn hàng', N'TH04', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP06', N'Điện thoại Xiaomi Mi 12', CAST(25990000.00 AS Decimal(10, 2)), 20, N'Điện thoại Xiaomi Mi 12 128GB chính hãng', N'XiaomiMi.jpg', CAST(N'2023-07-17' AS Date), N'KM01', N'Còn hàng', N'TH03', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP07', N'Laptop HP Spectre x360', CAST(30990000.00 AS Decimal(10, 2)), 8, N'Laptop HP Spectre x360 i7 12600H/16GB/1TB/RTX 3050', N'HPSpectre.jpg', CAST(N'2023-06-25' AS Date), N'KM04', N'Còn hàng', N'TH05', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP08', N'Điện thoại Oppo Find X5 Pro', CAST(32990000.00 AS Decimal(10, 2)), 12, N'Điện thoại Oppo Find X5 Pro 256GB chính hãng', N'OppoFind.jpg', CAST(N'2023-04-13' AS Date), N'KM03', N'Còn hàng', N'TH03', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP09', N'Laptop Asus ROG Zephyrus G14', CAST(34990000.00 AS Decimal(10, 2)), 3, N'Laptop Asus ROG Zephyrus G14 Ryzen 9/32GB/1TB/RTX 3060', N'AsusROG.jpg', CAST(N'2023-03-21' AS Date), N'KM02', N'Còn hàng', N'TH02', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP10', N'Điện thoại Vivo X70 Pro+', CAST(29990000.00 AS Decimal(10, 2)), 18, N'Điện thoại Vivo X70 Pro+ 256GB chính hãng', N'VivoX70.jpg', CAST(N'2023-02-09' AS Date), N'KM01', N'Còn hàng', N'TH03', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP11', N'Laptop MSI GS66 Stealth', CAST(37990000.00 AS Decimal(10, 2)), 6, N'Laptop MSI GS66 Stealth i9/32GB/1TB/RTX 3080', N'MSIGS66.jpg', CAST(N'2023-01-27' AS Date), N'KM04', N'Còn hàng', N'TH01', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP12', N'Điện thoại Google Pixel 7 Pro', CAST(31990000.00 AS Decimal(10, 2)), 10, N'Điện thoại Google Pixel 7 Pro 128GB chính hãng', N'Pixel7.jpg', CAST(N'2023-11-05' AS Date), N'KM05', N'Còn hàng', N'TH04', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP13', N'Laptop Lenovo Legion 5 Pro', CAST(26990000.00 AS Decimal(10, 2)), 14, N'Laptop Lenovo Legion 5 Pro Ryzen 7/16GB/512GB/RTX 3060', N'LenovoLegion.jpg', CAST(N'2023-10-10' AS Date), N'KM03', N'Còn hàng', N'TH05', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP14', N'Điện thoại Sony Xperia 5 III', CAST(33990000.00 AS Decimal(10, 2)), 9, N'Điện thoại Sony Xperia 5 III 256GB chính hãng', N'SonyXperia.jpg', CAST(N'2023-09-15' AS Date), N'KM02', N'Còn hàng', N'TH03', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP15', N'Laptop Acer Predator Helios 300', CAST(25990000.00 AS Decimal(10, 2)), 11, N'Laptop Acer Predator Helios 300 i7/16GB/512GB/GTX 1660 Ti', N'AcerPredator.jpg', CAST(N'2023-08-20' AS Date), N'KM01', N'Còn hàng', N'TH02', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP16', N'Điện thoại Motorola Edge 30 Pro', CAST(28990000.00 AS Decimal(10, 2)), 16, N'Điện thoại Motorola Edge 30 Pro 128GB chính hãng', N'MotorolaEdge.jpg', CAST(N'2023-07-25' AS Date), N'KM04', N'Còn hàng', N'TH01', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP17', N'Laptop Razer Blade 15', CAST(38990000.00 AS Decimal(10, 2)), 4, N'Laptop Razer Blade 15 i9/32GB/1TB/RTX 3080', N'RazerBlade.jpg', CAST(N'2023-06-30' AS Date), N'KM03', N'Còn hàng', N'TH03', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP18', N'Điện thoại Nokia G50', CAST(23990000.00 AS Decimal(10, 2)), 22, N'Điện thoại Nokia G50 64GB chính hãng', N'NokiaG50.jpg', CAST(N'2023-05-05' AS Date), N'KM02', N'Còn hàng', N'TH04', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP19', N'Laptop Microsoft Surface Laptop 4', CAST(29990000.00 AS Decimal(10, 2)), 7, N'Laptop Microsoft Surface Laptop 4 i5/8GB/256GB', N'MicrosoftSurface.jpg', CAST(N'2023-04-10' AS Date), N'KM01', N'Còn hàng', N'TH05', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP20', N'Điện thoại LG Velvet 3', CAST(26990000.00 AS Decimal(10, 2)), 13, N'Điện thoại LG Velvet 3 128GB chính hãng', N'LGVelvet.jpg', CAST(N'2023-03-16' AS Date), N'KM04', N'Còn hàng', N'TH03', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP21', N'Laptop Gigabyte Aero 15', CAST(36990000.00 AS Decimal(10, 2)), 5, N'Laptop Gigabyte Aero 15 i7/16GB/512GB/RTX 3070', N'GigabyteAero.jpg', CAST(N'2023-02-20' AS Date), N'KM03', N'Còn hàng', N'TH02', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP22', N'Điện thoại Huawei P50 Pro', CAST(31990000.00 AS Decimal(10, 2)), 17, N'Điện thoại Huawei P50 Pro 256GB chính hãng', N'HuaweiP50.jpg', CAST(N'2023-01-25' AS Date), N'KM02', N'Còn hàng', N'TH04', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP23', N'Laptop Apple MacBook Pro 14', CAST(43990000.00 AS Decimal(10, 2)), 9, N'Laptop Apple MacBook Pro 14 M1 Pro/16GB/512GB', N'MacBookPro.jpg', CAST(N'2023-11-10' AS Date), N'KM01', N'Còn hàng', N'TH05', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP24', N'Điện thoại Blackberry Key3', CAST(27990000.00 AS Decimal(10, 2)), 21, N'Điện thoại Blackberry Key3 128GB chính hãng', N'BlackberryKey.jpg', CAST(N'2023-10-15' AS Date), N'KM04', N'Còn hàng', N'TH03', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP25', N'Laptop Samsung Galaxy Book Pro', CAST(32990000.00 AS Decimal(10, 2)), 6, N'Laptop Samsung Galaxy Book Pro i7/16GB/512GB/RTX 3050', N'SamsungGalaxyBook.jpg', CAST(N'2023-09-20' AS Date), N'KM03', N'Còn hàng', N'TH01', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP26', N'Điện thoại Oppo Reno 7 Pro', CAST(29990000.00 AS Decimal(10, 2)), 14, N'Điện thoại Oppo Reno 7 Pro 256GB chính hãng', N'OppoReno.jpg', CAST(N'2023-08-25' AS Date), N'KM02', N'Còn hàng', N'TH04', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP27', N'Laptop Asus VivoBook S15', CAST(24990000.00 AS Decimal(10, 2)), 11, N'Laptop Asus VivoBook S15 i5/8GB/256GB', N'AsusVivoBook.jpg', CAST(N'2023-07-30' AS Date), N'KM01', N'Còn hàng', N'TH05', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP28', N'Điện thoại Motorola Moto G60', CAST(25990000.00 AS Decimal(10, 2)), 19, N'Điện thoại Motorola Moto G60 128GB chính hãng', N'MotoG60.jpg', CAST(N'2023-06-05' AS Date), N'KM04', N'Còn hàng', N'TH03', N'L02')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP29', N'Laptop HP Envy 13', CAST(31990000.00 AS Decimal(10, 2)), 8, N'Laptop HP Envy 13 i7/16GB/512GB/RTX 3050 Ti', N'HPEnd.jpg', CAST(N'2023-05-10' AS Date), N'KM03', N'Còn hàng', N'TH02', N'L01')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Gia], [SoLuong], [MoTaSanPham], [HinhAnh], [NgayCapNhat], [MaKhuyenMai], [TrangThai], [MaThuongHieu], [MaLoai]) VALUES (N'SP30', N'Điện thoại Xiaomi Redmi Note 11 Pro', CAST(23990000.00 AS Decimal(10, 2)), 16, N'Điện thoại Xiaomi Redmi Note 11 Pro 128GB chính hãng', N'XiaomiNote.jpg', CAST(N'2023-04-15' AS Date), N'KM02', N'Còn hàng', N'TH04', N'L02')
GO
INSERT [dbo].[TaiKhoan] ([MaKhachHang], [TenTaiKhoan], [MatKhau]) VALUES (N'KH04', N'0778899668 ', N'123                                               ')
GO
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenThuongHieu]) VALUES (N'TH03', N'Android')
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenThuongHieu]) VALUES (N'TH02', N'Asus')
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenThuongHieu]) VALUES (N'TH04', N'Dell')
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenThuongHieu]) VALUES (N'TH05', N'HP')
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenThuongHieu]) VALUES (N'TH01', N'Iphone')
GO
INSERT [dbo].[TonKho] ([MaKho], [MaSanPham], [SoLuongTon]) VALUES (N'K01', N'SP01', 18)
INSERT [dbo].[TonKho] ([MaKho], [MaSanPham], [SoLuongTon]) VALUES (N'K01', N'SP02', 5)
INSERT [dbo].[TonKho] ([MaKho], [MaSanPham], [SoLuongTon]) VALUES (N'K01', N'SP03', 4)
INSERT [dbo].[TonKho] ([MaKho], [MaSanPham], [SoLuongTon]) VALUES (N'K02', N'SP01', 3)
INSERT [dbo].[TonKho] ([MaKho], [MaSanPham], [SoLuongTon]) VALUES (N'K02', N'SP02', 2)
INSERT [dbo].[TonKho] ([MaKho], [MaSanPham], [SoLuongTon]) VALUES (N'K02', N'SP03', 5)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__LoaiSanP__E29B10426670E197]    Script Date: 29/11/2023 11:26:08 AM ******/
ALTER TABLE [dbo].[LoaiSanPham] ADD UNIQUE NONCLUSTERED 
(
	[TenLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TaiKhoan__B106EAF8891178D8]    Script Date: 29/11/2023 11:26:08 AM ******/
ALTER TABLE [dbo].[TaiKhoan] ADD UNIQUE NONCLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ThuongHi__98D6A834E352C38E]    Script Date: 29/11/2023 11:26:08 AM ******/
ALTER TABLE [dbo].[ThuongHieu] ADD UNIQUE NONCLUSTERED 
(
	[TenThuongHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_SanPham] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhapHang] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_SanPham] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_SanPham]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhanHoiKhachHang]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PhanHoiKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_PhanHoi_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[PhanHoiKhachHang] CHECK CONSTRAINT [FK_PhanHoi_SanPham]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[QL_NguoiDung]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[QL_NguoiDungNhomNguoiDung]  WITH CHECK ADD FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[QL_NhomNguoiDung] ([MaNhom])
GO
ALTER TABLE [dbo].[QL_NguoiDungNhomNguoiDung]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[QL_NguoiDung] ([TenDangNhap])
GO
ALTER TABLE [dbo].[QL_PhanQuyen]  WITH CHECK ADD FOREIGN KEY([MaManHinh])
REFERENCES [dbo].[DM_ManHinh] ([MaManHinh])
GO
ALTER TABLE [dbo].[QL_PhanQuyen]  WITH CHECK ADD FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[QL_NhomNguoiDung] ([MaNhom])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaKhuyenMai])
REFERENCES [dbo].[KhuyenMai] ([MaKhuyenMai])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [fk_SP_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSanPham] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [fk_SP_MaLoai]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [fk_SP_MaThuongHieu] FOREIGN KEY([MaThuongHieu])
REFERENCES [dbo].[ThuongHieu] ([MaThuongHieu])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [fk_SP_MaThuongHieu]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[TonKho]  WITH CHECK ADD FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
GO
ALTER TABLE [dbo].[TonKho]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
USE [master]
GO
ALTER DATABASE [QuanLyBanHang] SET  READ_WRITE 
GO
