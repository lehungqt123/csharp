USE [master]
GO
/****** Object:  Database [QLQuanCF]    Script Date: 2020-08-15 12:14:31 PM ******/
CREATE DATABASE [QLQuanCF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLQuanCF', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLQuanCF.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLQuanCF_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLQuanCF_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLQuanCF] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLQuanCF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLQuanCF] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLQuanCF] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLQuanCF] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLQuanCF] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLQuanCF] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLQuanCF] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLQuanCF] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLQuanCF] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLQuanCF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLQuanCF] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLQuanCF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLQuanCF] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLQuanCF] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLQuanCF] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLQuanCF] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLQuanCF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLQuanCF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLQuanCF] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLQuanCF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLQuanCF] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLQuanCF] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLQuanCF] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLQuanCF] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLQuanCF] SET  MULTI_USER 
GO
ALTER DATABASE [QLQuanCF] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLQuanCF] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLQuanCF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLQuanCF] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLQuanCF] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLQuanCF]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 2020-08-15 12:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[MaBan] [int] IDENTITY(1,1) NOT NULL,
	[TenBan] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[MaKH] [nchar](5) NULL,
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 2020-08-15 12:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [nchar](5) NOT NULL,
	[MaBan] [int] NULL,
	[MaMon] [nchar](5) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDon_1] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietThucDon]    Script Date: 2020-08-15 12:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietThucDon](
	[MaMon] [nchar](5) NOT NULL,
	[MaLoai] [nchar](5) NULL,
	[TenMon] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[HinhMon] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTietThucDon] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 2020-08-15 12:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nchar](5) NOT NULL,
	[MaNV] [nchar](5) NULL,
	[NgayLap] [date] NULL,
	[TongTien] [int] NULL,
	[MaKH] [nchar](5) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 2020-08-15 12:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](5) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiThucDon]    Script Date: 2020-08-15 12:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThucDon](
	[MaLoai] [nchar](5) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiThucDon] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 2020-08-15 12:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nchar](5) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [nchar](11) NULL,
	[MaLoai] [nchar](5) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 2020-08-15 12:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](5) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[Luong] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QLNguoiDung]    Script Date: 2020-08-15 12:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLNguoiDung](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[HoatDong] [bit] NULL,
	[MaNV] [nchar](5) NULL,
 CONSTRAINT [PK_QL_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Ban] ON 

INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (1, N'Bàn 1', N'Trống', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (2, N'Bàn 2', N'Trống', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (3, N'Bàn 3', N'Trống', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (4, N'Bàn 4', N'Có Người', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (5, N'Bàn 5', N'Có Người', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (6, N'Bàn 6', N'Trống', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (7, N'Bàn 7', N'Trống', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (8, N'Bàn 8', N'Trống', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (9, N'Bàn 9', N'Trống', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (10, N'Bàn 10', N'Trống', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (11, N'Bàn 11', N'Có Người', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (12, N'Bàn 12', N'Có Người', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (13, N'Bàn 13 ', N'Trống', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (14, N'Bàn 14', N'Có Người', NULL)
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai], [MaKH]) VALUES (15, N'Bàn 15', N'Trống', NULL)
SET IDENTITY_INSERT [dbo].[Ban] OFF
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M001 ', N'L001 ', N'Cafe Đen', 25000, N'capheden.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M002 ', N'L003 ', N'Sting ', 15000, N'sting.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M003 ', N'L003 ', N'Nutri', 15000, N'nutri.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M004 ', N'L001 ', N'Cafe Sữa', 25000, N'caphesua.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M005 ', N'L001 ', N'Espresso', 18000, N'espresso.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M006 ', N'L001 ', N'Cappuccino', 25000, N'cappuccino.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M007 ', N'L001 ', N'Latte', 20000, N'latte.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M008 ', N'L001 ', N'Bạc Xỉu', 15000, N'bacxiu.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M009 ', N'L003 ', N'Nước Suối', 12000, N'nuocsuoi.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M010 ', N'L003 ', N'Coca', 12000, N'coca.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M011 ', N'L003 ', N'Trà Xanh 0 Độ', 12000, N'traxanh0do.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M012 ', N'L003 ', N'Number 1', 15000, N'number1.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M013 ', N'L004 ', N'Dừa', 20000, N'sinhtodua.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M014 ', N'L004 ', N'Bơ', 22000, N'sinhtobo.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M015 ', N'L004 ', N'Xoài', 17000, N'sinhtoxoai.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M016 ', N'L004 ', N'Dâu', 20000, N'sinhtodau.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M017 ', N'L004 ', N'Chuối', 15000, N'sinhtochuoi.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M018 ', N'L004 ', N'Kiwi Mật Ong', 22000, N'sinhtokiwi.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M019 ', N'L005 ', N'Trân Châu Đường Đen', 50000, N'tranchauduongden.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M020 ', N'L005 ', N'Okinawa', 50000, N'okinawa.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M021 ', N'L005 ', N'Matcha Đậu Đỏ', 57000, N'matchadaudo.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M022 ', N'L005 ', N'Chocolate', 50000, N'trasuasocola.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M023 ', N'L002 ', N'Bánh Chocolate', 25000, N'banhsocola.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M024 ', N'L002 ', N'Pudding', 20000, N'pudding.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M025 ', N'L002 ', N'Kem Trái Cây', 30000, N'kemtraicay.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M026 ', N'L002 ', N'Kem Chocolate', 30000, N'kemchocolate.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M027 ', N'L002 ', N'Bánh Mì Phô Mai', 35000, N'banhmiphomai.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M028 ', N'L002 ', N'Xúc Xích Đức Nướng', 40000, N'xucxichduc.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M029 ', N'L002 ', N'Súp Kem Paris', 55000, N'supkemparis.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M030 ', N'L002 ', N'Súp Kem Rau', 50000, N'supkemrau.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M031 ', N'L002 ', N'Gỏi Xoài', 15000, N'goixoai.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M032 ', N'L002 ', N'Phô Mai Que', 15000, N'phomaique.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M033 ', N'L002 ', N'Bánh Tráng Bơ', 20000, N'banhtrangbo.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M034 ', N'L002 ', N'Bánh Tráng Cuốn Trứng', 25000, N'banhtrangtrungcuon.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M035 ', N'L002 ', N'Khoai Tây Chiên', 30000, N'khoaitaychien.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M036 ', N'L002 ', N'Khoai Tây Nghiền', 30000, N'khoaitaynghien.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M037 ', N'L002 ', N'Sữa Tươi Chiên', 30000, N'suatuoichien.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M038 ', N'L002 ', N'Đùi Gà Rán', 50000, N'duigaran.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M039 ', N'L002 ', N'Cánh Gà Rán', 40000, N'canhgachien.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M040 ', N'L002 ', N'Tokbokki Cay', 20000, N'tokkokicay.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M041 ', N'L002 ', N'Gimbap Thường', 15000, N'gimbapthuong.jpg')
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia], [HinhMon]) VALUES (N'M042 ', N'L002 ', N'Gimbap Chiên', 20000, N'gimbapchien.jpg')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH]) VALUES (N'KH01 ', N'Phan Tấn Trung')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH]) VALUES (N'KH02 ', N'Quách Thành Vũ')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (N'L001 ', N'Cafe')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (N'L002 ', N'Đồ ăn nhẹ')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (N'L003 ', N'Nước giải khát')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (N'L004 ', N'Sinh tố')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (N'L005 ', N'Trà sữa')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [MaLoai]) VALUES (N'NCC01', N'Cà Phê Triều Nguyên', N'Lâm Đồng', N'0968770770 ', N'L001 ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [MaLoai]) VALUES (N'NCC02', N'90S Coffee', N'TP.HCM', N'0967694444 ', N'L001 ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [MaLoai]) VALUES (N'NCC03', N'Cà Phê AVC HEMERA', N'TP.HCM', N'0912144889 ', N'L001 ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [MaLoai]) VALUES (N'NCC04', N'Sơn Việt Coffee', N'Lâm Đồng', N'0937442338 ', N'L001 ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [MaLoai]) VALUES (N'NCC05', N'Cà Phê Liên Đồng', N'Lâm Đồng', N'0987605722 ', N'L001 ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [MaLoai]) VALUES (N'NCC06', N'Cà Phê Thái Anh', N'Tiền Giang', N'0913962755 ', N'L001 ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [MaLoai]) VALUES (N'NCC07', N'Trà Sữa Xuân Thịnh', N'TP.HCM', N'02835176969', N'L005 ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [MaLoai]) VALUES (N'NCC08', N'Siêu thị nguyên liệu', N'TP.HCM', N'0932757868 ', N'L005 ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [MaLoai]) VALUES (N'NCC09', N'Vua an toàn', N'TP.HCM', N'0987013052 ', N'L005 ')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [MaLoai]) VALUES (N'NCC10', N'Nguyên Liệu Nguyên An', N'TP.HCM', N'0912551039 ', N'L005 ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [Luong]) VALUES (N'NV01 ', N'Lê Văn Bình', CAST(N'1999-02-05' AS Date), N'Nam', 6000000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [Luong]) VALUES (N'NV02 ', N'Phan Ngọc Thịnh', CAST(N'1998-08-03' AS Date), N'Nam', 450000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [Luong]) VALUES (N'NV03 ', N'Nguyễn Thi Ngọc', CAST(N'1998-11-20' AS Date), N'Nữ', 5000000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [Luong]) VALUES (N'NV04 ', N'Trần Như Ngọc', CAST(N'1999-01-01' AS Date), N'Nữ', 4500000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [Luong]) VALUES (N'NV05 ', N'Phan Tấn Trung', CAST(N'1997-05-05' AS Date), N'Nam', 5500000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [Luong]) VALUES (N'NV06 ', N'Lê Ngọc Hưng', CAST(N'1999-05-02' AS Date), N'Nữ', 6500000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [Luong]) VALUES (N'NV07 ', N'Đào Tuấn Hùng', CAST(N'1999-02-09' AS Date), N'Nam', 4500000)
INSERT [dbo].[QLNguoiDung] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'admin', N'123', 1, N'NV01 ')
INSERT [dbo].[QLNguoiDung] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'binhle', N'123', 1, N'NV02 ')
INSERT [dbo].[QLNguoiDung] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'ngocnguyen', N'123', 1, N'NV03 ')
INSERT [dbo].[QLNguoiDung] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'ngoctran', N'123', 1, N'NV04 ')
INSERT [dbo].[QLNguoiDung] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'thinhphan', N'123', 1, N'NV05 ')
ALTER TABLE [dbo].[Ban]  WITH CHECK ADD  CONSTRAINT [FK_Ban_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[Ban] CHECK CONSTRAINT [FK_Ban_KhachHang]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_Ban] FOREIGN KEY([MaBan])
REFERENCES [dbo].[Ban] ([MaBan])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_Ban]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_ChiTietThucDon] FOREIGN KEY([MaMon])
REFERENCES [dbo].[ChiTietThucDon] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_ChiTietThucDon]
GO
ALTER TABLE [dbo].[ChiTietThucDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThucDon_LoaiThucDon] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiThucDon] ([MaLoai])
GO
ALTER TABLE [dbo].[ChiTietThucDon] CHECK CONSTRAINT [FK_ChiTietThucDon_LoaiThucDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[NhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_NhaCungCap_LoaiThucDon] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiThucDon] ([MaLoai])
GO
ALTER TABLE [dbo].[NhaCungCap] CHECK CONSTRAINT [FK_NhaCungCap_LoaiThucDon]
GO
ALTER TABLE [dbo].[QLNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_QL_NguoiDung_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[QLNguoiDung] CHECK CONSTRAINT [FK_QL_NguoiDung_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [QLQuanCF] SET  READ_WRITE 
GO
