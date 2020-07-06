USE [master]
GO
/****** Object:  Database [QLQuanCF]    Script Date: 2020-07-06 8:45:06 PM ******/
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
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 2020-07-06 8:45:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[Ban] [nvarchar](50) NULL,
	[TenMon] [nvarchar](50) NULL,
	[SoLuong] [smallint] NULL,
	[DonGia] [nchar](10) NULL,
	[TongCong] [float] NULL,
	[MaMon] [nchar](10) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietThucDon]    Script Date: 2020-07-06 8:45:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietThucDon](
	[MaMon] [nchar](10) NOT NULL,
	[MaLoai] [nchar](10) NULL,
	[TenMon] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_ChiTietThucDon] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 2020-07-06 8:45:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NULL,
	[NgayBan] [date] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiThucDon]    Script Date: 2020-07-06 8:45:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThucDon](
	[MaLoai] [nchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiThucDon] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 2020-07-06 8:45:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[TenDangNhap] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QL_NguoiDung]    Script Date: 2020-07-06 8:45:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NguoiDung](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[HoatDong] [bit] NULL,
 CONSTRAINT [PK_QL_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M001      ', N'L001      ', N'Cafe Đen', 25000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M002      ', N'L003      ', N'Sting ', 15000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M003      ', N'L003      ', N'Nutri', 15000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M004      ', N'L001      ', N'Cafe Sữa', 25000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M005      ', N'L001      ', N'Espresso', 18000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M006      ', N'L001      ', N'Cappuccino', 25000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M007      ', N'L001      ', N'Latte', 20000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M008      ', N'L001      ', N'Bạc Xỉu', 15000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M009      ', N'L003      ', N'Nước Suối', 12000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M010      ', N'L003      ', N'Coca', 12000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M011      ', N'L003      ', N'Trà Xanh 0 Độ', 12000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M012      ', N'L003      ', N'Number 1', 15000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M013      ', N'L004      ', N'Dừa', 20000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M014      ', N'L004      ', N'Bơ', 22000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M015      ', N'L004      ', N'Xoài', 17000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M016      ', N'L004      ', N'Dâu', 20000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M017      ', N'L004      ', N'Chuối', 15000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M018      ', N'L004      ', N'Kiwi Mật Ong', 22000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M019      ', N'L005      ', N'Trân Châu Đường Đen', 50000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M020      ', N'L005      ', N'Okinawa', 50000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M021      ', N'L005      ', N'Matcha Đậu Đỏ', 57000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M022      ', N'L005      ', N'Chocolate', 50000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M023      ', N'L002      ', N'Bánh Chocolate', 25000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M024      ', N'L002      ', N'Pudding', 20000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M025      ', N'L002      ', N'Kem Trái Cây', 30000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M026      ', N'L002      ', N'Kem Chocolate', 30000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M027      ', N'L002      ', N'Bánh Mỳ Phô Mai', 35000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M028      ', N'L002      ', N'Xúc Xích Đức Nướng', 40000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M029      ', N'L002      ', N'Súp Kem Paris', 55000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M030      ', N'L002      ', N'Súp Kem Rau', 50000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M031      ', N'L002      ', N'Gỏi Xoài', 15000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M032      ', N'L002      ', N'Phô Mai Que', 15000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M033      ', N'L002      ', N'Bánh Tráng Bơ', 20000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M034      ', N'L002      ', N'Bánh Tráng Cuốn Trứng', 25000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M035      ', N'L002      ', N'Khoai Tây Chiên', 30000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M036      ', N'L002      ', N'Khoai Tây Nghiền', 30000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M037      ', N'L002      ', N'Sữa Tươi Chiên', 30000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M038      ', N'L002      ', N'Đùi Gà Rán', 50000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M039      ', N'L002      ', N'Cánh Gà Rán', 40000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M040      ', N'L002      ', N'Tokbokki Cay', 20000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M041      ', N'L002      ', N'Gimbap Thường', 15000)
INSERT [dbo].[ChiTietThucDon] ([MaMon], [MaLoai], [TenMon], [DonGia]) VALUES (N'M042      ', N'L002      ', N'Gimbap Chiên', 20000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [NgayBan], [TongTien]) VALUES (N'HD01      ', N'NV01      ', NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [NgayBan], [TongTien]) VALUES (N'HD02      ', N'NV02      ', NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [NgayBan], [TongTien]) VALUES (N'HD03      ', N'NV05      ', NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [NgayBan], [TongTien]) VALUES (N'HD04      ', N'NV03      ', NULL, NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [NgayBan], [TongTien]) VALUES (N'HD05      ', N'NV04      ', NULL, NULL)
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (N'L001      ', N'Cafe')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (N'L002      ', N'Đồ ăn nhẹ')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (N'L003      ', N'Nước giải khát')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (N'L004      ', N'Sinh tố')
INSERT [dbo].[LoaiThucDon] ([MaLoai], [TenLoai]) VALUES (N'L005      ', N'Trà sữa')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [TenDangNhap]) VALUES (N'NV01      ', N'Lê Văn Bình', N'Nam', N'binhle')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [TenDangNhap]) VALUES (N'NV02      ', N'Phan Ngọc Thịnh', N'Nam', N'thinhphan')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [TenDangNhap]) VALUES (N'NV03      ', N'Nguyễn Thi Ngọc', N'Nữ', N'ngocnguyen')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [TenDangNhap]) VALUES (N'NV04      ', N'Trần Như Ngọc', N'Nữ', N'ngoctran')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [TenDangNhap]) VALUES (N'NV05      ', N'Phan Tấn Trung', N'Nam', N'admin')
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'admin', N'123', 1)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'binhle', N'123', 1)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'ngocnguyen', N'123', 1)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'ngoctran', N'123', 1)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'thinhphan', N'123', 1)
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_ChiTietThucDon] FOREIGN KEY([MaMon])
REFERENCES [dbo].[ChiTietThucDon] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_ChiTietThucDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietThucDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThucDon_LoaiThucDon] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiThucDon] ([MaLoai])
GO
ALTER TABLE [dbo].[ChiTietThucDon] CHECK CONSTRAINT [FK_ChiTietThucDon_LoaiThucDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_QL_NguoiDung] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[QL_NguoiDung] ([TenDangNhap])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_QL_NguoiDung]
GO
USE [master]
GO
ALTER DATABASE [QLQuanCF] SET  READ_WRITE 
GO
