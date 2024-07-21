USE [master]
GO
/****** Object:  Database [QLHSNS]    Script Date: 21/7/2024 8:08:04 PM ******/
CREATE DATABASE [QLHSNS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLHSNS', FILENAME = N'D:\sql\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLHSNS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLHSNS_log', FILENAME = N'D:\sql\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLHSNS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLHSNS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLHSNS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLHSNS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLHSNS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLHSNS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLHSNS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLHSNS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLHSNS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLHSNS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLHSNS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLHSNS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLHSNS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLHSNS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLHSNS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLHSNS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLHSNS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLHSNS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLHSNS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLHSNS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLHSNS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLHSNS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLHSNS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLHSNS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLHSNS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLHSNS] SET RECOVERY FULL 
GO
ALTER DATABASE [QLHSNS] SET  MULTI_USER 
GO
ALTER DATABASE [QLHSNS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLHSNS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLHSNS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLHSNS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLHSNS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLHSNS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLHSNS', N'ON'
GO
ALTER DATABASE [QLHSNS] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLHSNS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLHSNS]
GO
/****** Object:  Table [dbo].[BAOHIEM]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOHIEM](
	[IDBH] [int] NOT NULL,
	[IDNV] [int] NULL,
	[SOBH] [int] NULL,
	[NGAYCAP] [date] NULL,
	[NOICAP] [nvarchar](200) NULL,
	[THOIHAN] [date] NULL,
	[NOIKHAMBENH] [nvarchar](200) NULL,
 CONSTRAINT [PK_tb_BAOHIEM] PRIMARY KEY CLUSTERED 
(
	[IDBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCDANH]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCDANH](
	[IDCD] [int] IDENTITY(1,1) NOT NULL,
	[TENCD] [nvarchar](50) NULL,
	[IDPB] [int] NULL,
 CONSTRAINT [PK_CHUCDANH] PRIMARY KEY CLUSTERED 
(
	[IDCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[IDCV] [int] IDENTITY(1,1) NOT NULL,
	[TENCV] [nvarchar](50) NULL,
	[IDCD] [int] NULL,
 CONSTRAINT [PK_tb_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[IDCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOPDONG]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOPDONG](
	[IDHD] [int] IDENTITY(1,1) NOT NULL,
	[TENHP] [nvarchar](50) NULL,
	[NGAYBATDAU] [date] NULL,
	[NGAYKETTHUC] [datetimeoffset](7) NULL,
	[NGAYKY] [date] NULL,
	[IDNV] [int] NULL,
	[NGUOILAMHOPDONG] [nvarchar](50) NULL,
	[IDLUONG] [int] NULL,
	[HESOLUONG] [float] NULL,
 CONSTRAINT [PK_tb_HOPDONG] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHENTHUONG_KYLUAT]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHENTHUONG_KYLUAT](
	[IDKTKL] [int] IDENTITY(1,1) NOT NULL,
	[LOAI] [bit] NULL,
	[NOIDUNG] [nvarchar](200) NULL,
	[NGAY] [date] NULL,
 CONSTRAINT [PK_tb_KHENTHUONG_KYLUAT] PRIMARY KEY CLUSTERED 
(
	[IDKTKL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LUONG]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LUONG](
	[IDLUONG] [int] IDENTITY(1,1) NOT NULL,
	[IDHD] [int] NULL,
	[THANG] [int] NULL,
	[NGAYCONG] [int] NULL,
	[NGAYNGHI] [int] NULL,
	[NGAYDENMUON] [int] NULL,
	[NGAYVESOM] [int] NULL,
	[NGUOIDUYET] [nvarchar](50) NULL,
	[IDNH] [int] NULL,
	[TIENTHUONG] [float] NULL,
	[TIENPHAT] [float] NULL,
	[HESOLUONG] [float] NULL,
	[LUONGCB] [float] NULL,
	[TONGLUONG] [float] NULL,
	[IDPC] [int] NULL,
	[IDPL] [int] NULL,
	[IDKTKL] [int] NULL,
	[IDNGHI] [int] NULL,
 CONSTRAINT [PK_tb_BANGCONG] PRIMARY KEY CLUSTERED 
(
	[IDLUONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGANHANG]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGANHANG](
	[IDNH] [int] IDENTITY(1,1) NOT NULL,
	[TENNH] [nvarchar](50) NULL,
	[CHINHANH] [nvarchar](200) NULL,
 CONSTRAINT [PK_tb_NGANHANG] PRIMARY KEY CLUSTERED 
(
	[IDNH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGHIVIEC]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGHIVIEC](
	[IDNGHI] [int] IDENTITY(1,1) NOT NULL,
	[IDLUONG] [int] NULL,
	[COPHEP] [bit] NULL,
	[LYDO] [nvarchar](200) NULL,
	[NGAYNGHIBATDAU] [date] NULL,
	[NGAYNGHIKETTHUC] [datetimeoffset](7) NULL,
	[NGUOIDUYET] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_NGHIVIEC] PRIMARY KEY CLUSTERED 
(
	[IDNGHI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[IDNV] [int] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[GIOITINH] [bit] NULL,
	[NGAYSINH] [date] NULL,
	[DIACHI] [nvarchar](200) NULL,
	[QUEQUAN] [nvarchar](50) NULL,
	[DIENTHOAI] [int] NULL,
	[EMAIL] [nvarchar](50) NULL,
	[CCCD] [int] NULL,
	[QUOCTICH] [nvarchar](50) NULL,
	[TTHONNHAN] [bit] NULL,
	[QTCT] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[IDNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OVERTIME]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OVERTIME](
	[IDOT] [int] NOT NULL,
	[IDPC] [int] NULL,
	[SOGIO] [int] NULL,
	[HESOLUONG] [float] NULL,
	[SOTIEN] [float] NULL,
 CONSTRAINT [PK_OVERTIME] PRIMARY KEY CLUSTERED 
(
	[IDOT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGBAN](
	[IDPB] [int] IDENTITY(1,1) NOT NULL,
	[TENPB] [nvarchar](20) NULL,
	[IDNV] [int] NULL,
 CONSTRAINT [PK_tb_PHONGBAN] PRIMARY KEY CLUSTERED 
(
	[IDPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHUCAP]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHUCAP](
	[IDPC] [int] IDENTITY(1,1) NOT NULL,
	[LOAIPHUCAP] [nvarchar](50) NULL,
	[IDOT] [int] NULL,
	[NGAY] [date] NULL,
	[SOTIEN] [float] NULL,
 CONSTRAINT [PK_tb_PHUCAP] PRIMARY KEY CLUSTERED 
(
	[IDPC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHUCLOI]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHUCLOI](
	[IDPL] [int] IDENTITY(1,1) NOT NULL,
	[LOAIPHUCLOI] [nvarchar](50) NULL,
	[NGAY] [date] NULL,
	[SOTIEN] [float] NULL,
 CONSTRAINT [PK_tb_PHUCLOI] PRIMARY KEY CLUSTERED 
(
	[IDPL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAISAN]    Script Date: 21/7/2024 8:08:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAISAN](
	[IDTS] [int] NOT NULL,
	[TENTS] [nvarchar](50) NULL,
	[NGAYNHAN] [date] NULL,
	[NGAYTRA] [date] NULL,
	[TINHTRANG] [nvarchar](20) NULL,
	[GIATRITAISAN] [float] NULL,
	[IDNV] [int] NULL,
 CONSTRAINT [PK_tb_CAPPHATTAISAN] PRIMARY KEY CLUSTERED 
(
	[IDTS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([IDNV], [HOTEN], [GIOITINH], [NGAYSINH], [DIACHI], [QUEQUAN], [DIENTHOAI], [EMAIL], [CCCD], [QUOCTICH], [TTHONNHAN], [QTCT]) VALUES (1, N'Phan Quốc Hoàng', 1, CAST(N'0001-01-01' AS Date), N'Giáp Bát, Hoàng Mai, HN', N'Vinh, Nghệ An', 974459015, N'phanquoc1236@gmail.com', 1200003225, N'Việt Nam', 1, N'Thực tập sinh')
INSERT [dbo].[NHANVIEN] ([IDNV], [HOTEN], [GIOITINH], [NGAYSINH], [DIACHI], [QUEQUAN], [DIENTHOAI], [EMAIL], [CCCD], [QUOCTICH], [TTHONNHAN], [QTCT]) VALUES (3, N'Trần Trung Quân', 1, CAST(N'2001-07-07' AS Date), N'Hồ Đắc Di, Đống Đa, HN', N'Nam Định', 974459017, N'quan147@gmail.com', 1200003220, N'Việt Nam', 1, N'Đã Nghỉ')
INSERT [dbo].[NHANVIEN] ([IDNV], [HOTEN], [GIOITINH], [NGAYSINH], [DIACHI], [QUEQUAN], [DIENTHOAI], [EMAIL], [CCCD], [QUOCTICH], [TTHONNHAN], [QTCT]) VALUES (4, N'Phạm Đăng Kiên', 1, CAST(N'2000-06-06' AS Date), N'Hồ Tùng Mậu, Hoàng Mai, HN', N'Hưng Yên', 974459018, N'khien234@gmail.com', 1200003230, N'Việt Nam', 0, N'Ngoài công ty')
INSERT [dbo].[NHANVIEN] ([IDNV], [HOTEN], [GIOITINH], [NGAYSINH], [DIACHI], [QUEQUAN], [DIENTHOAI], [EMAIL], [CCCD], [QUOCTICH], [TTHONNHAN], [QTCT]) VALUES (5, N'John Lennon ', 1, CAST(N'1999-05-03' AS Date), N'San diego, California, USA', N'California', 974459019, N'John1236@gmail.com', 1200003229, N'Mĩ', 0, N'Trong công ty')
INSERT [dbo].[NHANVIEN] ([IDNV], [HOTEN], [GIOITINH], [NGAYSINH], [DIACHI], [QUEQUAN], [DIENTHOAI], [EMAIL], [CCCD], [QUOCTICH], [TTHONNHAN], [QTCT]) VALUES (6, N'Nguyễn Thu Hương', 0, CAST(N'0001-01-01' AS Date), N'Giáp Bát, Hoàng Mai, HN', N'Vinh, Nghệ An', 974459019, N'huong123@gmail.com', 1200003290, N'Việt Nam', 0, N'Trong công ty')
INSERT [dbo].[NHANVIEN] ([IDNV], [HOTEN], [GIOITINH], [NGAYSINH], [DIACHI], [QUEQUAN], [DIENTHOAI], [EMAIL], [CCCD], [QUOCTICH], [TTHONNHAN], [QTCT]) VALUES (7, N'Nguyễn Ngọc Nhi', 0, CAST(N'0001-01-01' AS Date), N'Phạm Ngọc Thạch , Đống Đa , HN', N'Thái Bình', 966717872, N'nhi1233@gmail.com', 1200004557, N'Việt Nam', 1, N'Trong công ty')
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
GO
ALTER TABLE [dbo].[BAOHIEM]  WITH CHECK ADD  CONSTRAINT [FK_tb_BAOHIEM_tb_NHANVIEN] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NHANVIEN] ([IDNV])
GO
ALTER TABLE [dbo].[BAOHIEM] CHECK CONSTRAINT [FK_tb_BAOHIEM_tb_NHANVIEN]
GO
ALTER TABLE [dbo].[CHUCDANH]  WITH CHECK ADD  CONSTRAINT [FK_CHUCDANH_PHONGBAN] FOREIGN KEY([IDPB])
REFERENCES [dbo].[PHONGBAN] ([IDPB])
GO
ALTER TABLE [dbo].[CHUCDANH] CHECK CONSTRAINT [FK_CHUCDANH_PHONGBAN]
GO
ALTER TABLE [dbo].[CHUCVU]  WITH CHECK ADD  CONSTRAINT [FK_CHUCVU_CHUCDANH] FOREIGN KEY([IDCD])
REFERENCES [dbo].[CHUCDANH] ([IDCD])
GO
ALTER TABLE [dbo].[CHUCVU] CHECK CONSTRAINT [FK_CHUCVU_CHUCDANH]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_HOPDONG_NHANVIEN] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NHANVIEN] ([IDNV])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_HOPDONG_NHANVIEN]
GO
ALTER TABLE [dbo].[LUONG]  WITH CHECK ADD  CONSTRAINT [FK_LUONG_HOPDONG] FOREIGN KEY([IDHD])
REFERENCES [dbo].[HOPDONG] ([IDHD])
GO
ALTER TABLE [dbo].[LUONG] CHECK CONSTRAINT [FK_LUONG_HOPDONG]
GO
ALTER TABLE [dbo].[LUONG]  WITH CHECK ADD  CONSTRAINT [FK_LUONG_KHENTHUONG_KYLUAT] FOREIGN KEY([IDKTKL])
REFERENCES [dbo].[KHENTHUONG_KYLUAT] ([IDKTKL])
GO
ALTER TABLE [dbo].[LUONG] CHECK CONSTRAINT [FK_LUONG_KHENTHUONG_KYLUAT]
GO
ALTER TABLE [dbo].[LUONG]  WITH CHECK ADD  CONSTRAINT [FK_LUONG_NGANHANG] FOREIGN KEY([IDNH])
REFERENCES [dbo].[NGANHANG] ([IDNH])
GO
ALTER TABLE [dbo].[LUONG] CHECK CONSTRAINT [FK_LUONG_NGANHANG]
GO
ALTER TABLE [dbo].[LUONG]  WITH CHECK ADD  CONSTRAINT [FK_LUONG_NGHIVIEC] FOREIGN KEY([IDNGHI])
REFERENCES [dbo].[NGHIVIEC] ([IDNGHI])
GO
ALTER TABLE [dbo].[LUONG] CHECK CONSTRAINT [FK_LUONG_NGHIVIEC]
GO
ALTER TABLE [dbo].[LUONG]  WITH CHECK ADD  CONSTRAINT [FK_LUONG_PHUCAP] FOREIGN KEY([IDPC])
REFERENCES [dbo].[PHUCAP] ([IDPC])
GO
ALTER TABLE [dbo].[LUONG] CHECK CONSTRAINT [FK_LUONG_PHUCAP]
GO
ALTER TABLE [dbo].[LUONG]  WITH CHECK ADD  CONSTRAINT [FK_LUONG_PHUCLOI] FOREIGN KEY([IDPC])
REFERENCES [dbo].[PHUCLOI] ([IDPL])
GO
ALTER TABLE [dbo].[LUONG] CHECK CONSTRAINT [FK_LUONG_PHUCLOI]
GO
ALTER TABLE [dbo].[PHONGBAN]  WITH CHECK ADD  CONSTRAINT [FK_PHONGBAN_NHANVIEN] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NHANVIEN] ([IDNV])
GO
ALTER TABLE [dbo].[PHONGBAN] CHECK CONSTRAINT [FK_PHONGBAN_NHANVIEN]
GO
ALTER TABLE [dbo].[PHUCAP]  WITH CHECK ADD  CONSTRAINT [FK_PHUCAP_OVERTIME] FOREIGN KEY([IDOT])
REFERENCES [dbo].[OVERTIME] ([IDOT])
GO
ALTER TABLE [dbo].[PHUCAP] CHECK CONSTRAINT [FK_PHUCAP_OVERTIME]
GO
ALTER TABLE [dbo].[TAISAN]  WITH CHECK ADD  CONSTRAINT [FK_tb_CAPPHATTAISAN_tb_NHANVIEN] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NHANVIEN] ([IDNV])
GO
ALTER TABLE [dbo].[TAISAN] CHECK CONSTRAINT [FK_tb_CAPPHATTAISAN_tb_NHANVIEN]
GO
USE [master]
GO
ALTER DATABASE [QLHSNS] SET  READ_WRITE 
GO
