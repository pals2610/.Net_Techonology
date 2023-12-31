create database Hotel_Manager_Data
go
USE [Hotel_Manager_Data]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 05/11/2022 9:14:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[Taikhoan] [nvarchar](50) NOT NULL,
	[Matkhau] [nvarchar](50) NULL,
	[FullName] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[phanquyen] [int] NULL,
	[trangthai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoadon]    Script Date: 05/11/2022 9:14:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadon](
	[id_hoadon] [nvarchar](15) NOT NULL,
	[MaPhong] [nvarchar](15) NULL,
	[Makh] [nvarchar](15) NULL,
	[Manv] [nvarchar](15) NULL,
	[Ngaydatphong] [date] NULL,
	[Ngaynhanphong] [date] NULL,
	[Ngaytraphong] [date] NULL,
	[soluongnguoi] [int] NULL,
	[phiphong] [real] NULL,
	[phiphuthu] [real] NULL,
	[thanhtien] [real] NULL,
	[trangthai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khachhang]    Script Date: 05/11/2022 9:14:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khachhang](
	[MaKh] [nvarchar](15) NOT NULL,
	[Tenkh] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[gioitinh] [nvarchar](10) NULL,
	[sdt] [nvarchar](15) NULL,
	[Cmnd] [nvarchar](30) NULL,
	[Email] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khohang]    Script Date: 05/11/2022 9:14:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khohang](
	[Maitem] [nvarchar](15) NOT NULL,
	[TenItem] [nvarchar](500) NULL,
	[gianhap] [real] NULL,
	[soluong] [int] NULL,
	[giaban] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[Maitem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LPhong]    Script Date: 05/11/2022 9:14:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LPhong](
	[loaiphong] [nvarchar](50) NOT NULL,
	[mota] [nvarchar](50) NULL,
	[giaphong] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[loaiphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 05/11/2022 9:14:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[Manv] [nvarchar](15) NOT NULL,
	[Tennv] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[gioitinh] [nvarchar](10) NULL,
	[sdt] [nvarchar](15) NULL,
	[Cmnd] [nvarchar](30) NULL,
	[Email] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhapKho]    Script Date: 05/11/2022 9:14:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapKho](
	[Id_hd] [nvarchar](15) NOT NULL,
	[sanpham] [nvarchar](100) NULL,
	[ngaynhap] [date] NULL,
	[Thanhtien] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_hd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 05/11/2022 9:14:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [nvarchar](15) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[loaiphong] [nvarchar](50) NULL,
	[Mota] [nvarchar](1000) NULL,
	[songtoida] [int] NULL,
	[trangthai] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phuthu]    Script Date: 05/11/2022 9:14:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phuthu](
	[MaPhu] [nvarchar](15) NOT NULL,
	[MaKh] [nvarchar](15) NULL,
	[Maitem] [nvarchar](15) NULL,
	[tensp] [nvarchar](500) NULL,
	[soluong] [int] NULL,
	[gia] [real] NULL,
	[trangthai] [int] NULL,
	[thanhtien] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



--FOREIGN KEY
ALTER TABLE Hoadon
ADD CONSTRAINT FK_HOADON_MAKH FOREIGN KEY (MaKh) REFERENCES Khachhang(MaKh)

ALTER TABLE Hoadon
ADD CONSTRAINT FK_HOADON_MANV FOREIGN KEY (MANV) REFERENCES Nhanvien(Manv)

Alter table Hoadon
Add constraint fk_hoadon_MaPhong Foreign key (MaPhong) references Phong(MaPhong)



INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'admin', N'123456', N'Phát Thịnh', N'phatthinh2610@gmail.com', 1, 1)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'nguoidung', N'123456', N'Anh Duy', N'duyduong@gmail.com', 3, 1)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'nguoidung2', N'123456', N'Quốc Việt', N'quocviet@gmail.com', 3, 0)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'quanly', N'123123', N'Trúc Ank đài', N'china@gmail.com', 1, 1)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'quanly2', N'123456', N'Trần Mạnh Hùng', N'hung@gmail.com', 2, 0)
GO
INSERT [dbo].[Hoadon] ([id_hoadon], [MaPhong], [Makh], [Manv], [Ngaydatphong], [Ngaynhanphong], [Ngaytraphong], [soluongnguoi], [phiphong], [phiphuthu], [thanhtien], [trangthai]) VALUES (N'hd01', N'ph01', N'kh01', N'nv01', CAST(N'2020-10-26' AS Date), CAST(N'2020-10-27' AS Date), CAST(N'2020-10-30' AS Date), 4, 3600000, 300000, 2100000, N'Đã đặt')
INSERT [dbo].[Hoadon] ([id_hoadon], [MaPhong], [Makh], [Manv], [Ngaydatphong], [Ngaynhanphong], [Ngaytraphong], [soluongnguoi], [phiphong], [phiphuthu], [thanhtien], [trangthai]) VALUES (N'hd02', N'ph03', N'kh01', N'nv03', CAST(N'2022-12-11' AS Date), CAST(N'2022-12-11' AS Date), CAST(N'2022-12-11' AS Date), 2, 0, 0, 0, N'Đã đặt')
INSERT [dbo].[Hoadon] ([id_hoadon], [MaPhong], [Makh], [Manv], [Ngaydatphong], [Ngaynhanphong], [Ngaytraphong], [soluongnguoi], [phiphong], [phiphuthu], [thanhtien], [trangthai]) VALUES (N'hd04', N'ph02', N'kh01', N'nv03', CAST(N'2022-12-11' AS Date), CAST(N'2022-12-11' AS Date), CAST(N'2022-12-11' AS Date), 2, 0, 200000, 200000, N'Đã thanh toán')
GO
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'kh01', N'Đoàn Duy Khanh', CAST(N'1993-02-03' AS Date), N'Nam', N'386123242', N'146582362', N'khach@gmail.com')
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'kh02', N'Trần Doãn Mạnh', CAST(N'1992-12-05' AS Date), N'Nam', N'386427880', N'146582895', N'manh@gmail.com')
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'kh03', N'Trần Văn Minh', CAST(N'1996-09-11' AS Date), N'Nam', N'366421315', N'146582662', N'Minh@gmail.com')
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'kh04', N'Trần Hoài Nam', CAST(N'1999-01-22' AS Date), N'Nam', N'976445444', N'146582321', N'Namhh@gmail.com')
GO
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it01', N'Cocacola', 6000, 2000, 10000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it02', N'Khăn giương', 10000, 201, 20000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it05', N'Khăn mặt', 10000, 194, 20000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it06', N'BimBims', 8000, 490, 10000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it07', N'Kẹo', 10000, 100, 100000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it08', N'Bia', 50000, 100, 200000)
GO
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'Deluxe', N'Phòng trung cấp', 500000)
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'Standard', N'Phòng bình dân', 300000)
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'Super Pro Vip', N'Phòng Siêu Cấp', 1000000)
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'Superior', N'Phòng thường', 400000)
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'VIP', N'Phòng cao cấp', 600000)
GO
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'nv01', N'Trần Hữu Anh', CAST(N'1996-08-25' AS Date), N'Nam', N'0386143805', N'145715186', N'anhth.hh@gmail.com')
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'nv02', N'Trần Văn Hiệp', CAST(N'1998-12-15' AS Date), N'Nam', N'0366524687', N'145715189', N'hieptr.hh@gmail.com')
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'nv03', N'Hoang Van Nam', CAST(N'1999-03-02' AS Date), N'Nam', N'0385145235', N'145715125', N'namhv.hh@gmail.com')
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'nv04', N'Trần Thị Linh', CAST(N'2000-06-07' AS Date), N'Nữ', N'0366888521', N'154862123', N'linhtt.hh@gmail.com')
GO
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph01', N'6001', N'VIP', N'Phòng đẹp, rộng 5*15m, có cửa sổ, view đẹp nhìn ra biển', 4, N'Đã đặt')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph02', N'4001', N'Standard', N'Phòng đẹp, rộng 4*6m, có cửa sổ, view hồ ', 2, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph03', N'4002', N'Superior ', N'Phòng đẹp, rộng 10*4m, có cửa sổ, view đẹp nhìn ra biển', 4, N'Đã đặt')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph04', N'4003', N'Deluxe', N'Phòng đẹp, rộng 3*8m, có cửa sổ, view đẹp nhìn ra biển', 4, N'Đã đặt')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph05', N'4004', N'Standard', N'Phòng đẹp, rộng 4*6m, có cửa sổ, view đẹp nhìn ra biển', 2, N'Đang thuê')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph06', N'4005', N'Standard', N'Phòng đẹp, rộng 4*6m, có cửa sổ, view đẹp nhìn ra biển', 2, N'Đang thuê')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph07', N'4006', N'Superior', N'Phòng đẹp, rộng 10*4m, có cửa sổ, view đẹp nhìn ra biển', 4, N'Trống')
GO
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [soluong], [gia], [trangthai], [thanhtien]) VALUES (N'ph01', N'kh01', N'it01', N'BimBims', 10, 10000, 0, 100000)
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [soluong], [gia], [trangthai], [thanhtien]) VALUES (N'ph04', N'kh01', N'it05', N'Khăn mặt', 10, 10000, 0, 100000)
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [soluong], [gia], [trangthai], [thanhtien]) VALUES (N'ph05', N'kh03', N'it08', N'Bia', 2, 200000, 0, 400000)
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [soluong], [gia], [trangthai], [thanhtien]) VALUES (N'ph06', N'kh02', N'it05', N'Khăn mặt', 2, 20000, 1, 40000)
GO
USE [master]
GO
ALTER DATABASE [Hotel_Manager_Data] SET  READ_WRITE 
GO
