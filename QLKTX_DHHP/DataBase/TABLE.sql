USE QLKTX
GO

CREATE TABLE [dbo].[Accounts](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[MaCB] [nvarchar](50) NULL,
	CONSTRAINT [PK_Accounts] PRIMARY KEY ([TaiKhoan])
) 
GO
 
CREATE TABLE [dbo].[CanBo](
	[MaCB] [nvarchar](50) NOT NULL PRIMARY KEY,
	[TenCB] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL
)
GO

CREATE TABLE [dbo].[Khu](
	[MaKhu] [nvarchar](50) NOT NULL PRIMARY KEY,
	[TenKhu] [nvarchar](50) NULL
)

CREATE TABLE [dbo].[Phong](
	[MaPhong] [nvarchar](50) NOT NULL PRIMARY KEY,
	[MaKhu] [nvarchar](50) NULL,
	[TenPhong] [nvarchar](50) NULL,
	[LoaiPhong] [nvarchar](50) NULL,
	[SoNguoiHienTai] [int] NULL,
	[SoNguoiToiDa] [int] NULL,
	[GiaPhong] [float] NULL,
	CONSTRAINT [FK_Phong_Khu] FOREIGN KEY ([MaKhu]) REFERENCES [dbo].[Khu] ([MaKhu])
)

CREATE TABLE [dbo].[SinhVien](
	[MaSV] [nvarchar](50) NOT NULL PRIMARY KEY,
	[TenSV] [nvarchar](50) NULL,
	[NgaySinh] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[SDT] [int] NULL,
	[Lop] [nvarchar](50) NULL,
	[KhoasHoc] [nvarchar](50) NULL,
	[Khoa] [nvarchar](50) NULL
)

GO

CREATE TABLE [dbo].[DangKyThue](
	[MaSV] [nvarchar](50) NOT NULL PRIMARY KEY,
	[TenSV] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[Lop] [nvarchar](50) NULL,
	[Khoa] [nvarchar](50) NULL,
	[NgayDen] [datetime] NULL,
	[NgayDi] [datetime] NULL,
	[MaPhong] [nvarchar](50) NULL,
	[GiaPhong] [float] NULL,
	CONSTRAINT [FK_DangKyThue_SinhVien] FOREIGN KEY ([MaSV]) REFERENCES [dbo].[SinhVien] ([MaSV]),
	CONSTRAINT [FK_DangKyThue_Phong] FOREIGN KEY ([MaPhong]) REFERENCES [dbo].[Phong] ([MaPhong])
)

CREATE TABLE [dbo].[HDDienNuoc](
	[So] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,  
	[MaPhong] [nvarchar](50) NULL,
	[Thang] [datetime] NULL,
	[CSDienCu] [int] NULL,
	[CSDienMoi] [int] NULL,
	[DonGiaDien] [float] NULL,
	[ThanhTienDien] [float] NULL,
	[CSNuocCu] [int] NULL,
	[CSNuocMoi] [int] NULL,
	[DonGiaNuoc] [float] NULL,
	[ThanhTienNuoc] [float] NULL,
	[TongTien] [float] NULL,
	CONSTRAINT [FK_HDDienNuoc_Phong] FOREIGN KEY ([MaPhong]) REFERENCES [dbo].[Phong] ([MaPhong])
)

CREATE TABLE [dbo].[HDTienPhong](
	[MaHD] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[MaSV] [nvarchar](50) NULL ,
	[TenSV] [nvarchar](50) NULL,
	[Lop] [nvarchar](50) NULL,
	[Khoa] [nvarchar](50) NULL,
	[Phong] [nvarchar](50) NULL,
	[NoiDung] [nvarchar](max) NULL,
	[SoTien] [float] NULL,
	[NguoiLap] [nvarchar](50) NULL,
	CONSTRAINT [FK_HDTienPhong_SinhVien] FOREIGN KEY ([MaSV]) REFERENCES [dbo].[SinhVien] ([MaSV])
)

CREATE TABLE [dbo].[HopDongThue](
	[MaHD] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[NgayLap] [datetime] NULL,
	[MaSV] [nvarchar](50) NULL,
	[TenSV] [nvarchar](50) NULL,
	[Lop] [nvarchar](50) NULL,
	[Khoa] [nvarchar](50) NULL,
	[MaPhong] [nvarchar](50) NULL,
	[GiaPhong] [float] NULL,
	[NgayDen] [datetime] NULL,
	[NgayDi] [datetime] NULL,
	CONSTRAINT [FK_HopDongThue_SinhVien] FOREIGN KEY ([MaSV]) REFERENCES [dbo].[SinhVien] ([MaSV]),
	CONSTRAINT [FK_HopDongThue_Phong] FOREIGN KEY ([MaPhong]) REFERENCES [dbo].[Phong] ([MaPhong])
)

/*
INSERT INTO [dbo].[Accounts] ([TaiKhoan], [MatKhau], [MaCB]) VALUES (N'Thang64', N'0604', N'1')

INSERT INTO [dbo].[CanBo] ([MaCB], [TenCB], [NgaySinh], [GioiTinh], [ChucVu], [DiaChi], [SDT]) VALUES (N'1', N'Đức Thắng', CAST(N'2003-04-06' AS DateTime), 1, N'Thu ngân', N'Thái Bình', 3456)
INSERT INTO [dbo].[CanBo] ([MaCB], [TenCB], [NgaySinh], [GioiTinh], [ChucVu], [DiaChi], [SDT]) VALUES (N'2', N'Danh Mạnh', CAST(N'2003-06-19' AS DateTime), 1, N'Thủ quỹ', N'Hà Nội', 1234)
INSERT INTO [dbo].[CanBo] ([MaCB], [TenCB], [NgaySinh], [GioiTinh], [ChucVu], [DiaChi], [SDT]) VALUES (N'3', N'Tống Thuyết', CAST(N'2003-06-30' AS DateTime), 1, N'Thủ quỹ', N'Hải Phòng', 5678)

INSERT INTO [dbo].[DangKyThue] ([MaSV], [TenSV], [DiaChi], [SDT], [Lop], [Khoa], [NgayDen], [NgayDi], [MaPhong], [GiaPhong]) VALUES (N'2023605565', N'Nguyễn Đức Thắng', N'Hải Phòng', 3456, N'CNTT2', N'K22', CAST(N'2023-08-26' AS DateTime), CAST(N'2021-08-26' AS DateTime), N'PA1', 650000)

SET IDENTITY_INSERT [dbo].[HDDienNuoc] ON 
INSERT INTO [dbo].[HDDienNuoc] ([MaPhong], [Thang], [CSDienCu], [CSDienMoi], [DonGiaDien], [ThanhTienDien], [CSNuocCu], [CSNuocMoi], [DonGiaNuoc], [ThanhTienNuoc], [TongTien]) VALUES (N'PA1', CAST(N'2023-08-21' AS DateTime), 1, 11, 2300, 23000, 1, 11, 5600, 56000, 79000)
INSERT INTO [dbo].[HDDienNuoc] ([MaPhong], [Thang], [CSDienCu], [CSDienMoi], [DonGiaDien], [ThanhTienDien], [CSNuocCu], [CSNuocMoi], [DonGiaNuoc], [ThanhTienNuoc], [TongTien]) VALUES (N'PB1', CAST(N'2023-08-21' AS DateTime), 1, 11, 2300, 23000, 1, 11, 5600, 56000, 79000)
SET IDENTITY_INSERT [dbo].[HDDienNuoc] OFF
SET IDENTITY_INSERT [dbo].[HDTienPhong] ON 

INSERT INTO [dbo].[HDTienPhong] ([MaSV], [TenSV], [Lop], [Khoa], [Phong], [NoiDung], [SoTien], [NguoiLap]) VALUES (N'MSV01', N'Nguyễn Đức Thắng', N'CNTT2', N'K22', N'PA1', N'Thu tiền thuê phòng', 780000, N'Nguyễn Danh Mạnh')
SET IDENTITY_INSERT [dbo].[HDTienPhong] OFF
SET IDENTITY_INSERT [dbo].[HopDongThue] ON 

INSERT INTO [dbo].[HopDongThue] ([NgayLap], [MaSV], [TenSV], [Lop], [Khoa], [MaPhong], [GiaPhong], [NgayDen], [NgayDi]) VALUES (CAST(N'2023-08-27' AS DateTime), N'MSV01', N'Nguyễn Đức Thắng', N'CNTT2', N'K22', N'PA1', 650000, CAST(N'2020-08-26' AS DateTime), CAST(N'2023-08-26' AS DateTime))
SET IDENTITY_INSERT [dbo].[HopDongThue] OFF

INSERT INTO [dbo].[Khu] ([MaKhu], [TenKhu]) VALUES (N'A', N'Khu A')
INSERT INTO [dbo].[Khu] ([MaKhu], [TenKhu]) VALUES (N'B', N'Khu B')

INSERT INTO [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [LoaiPhong], [SoNguoiHienTai], [SoNguoiToiDa], [GiaPhong]) VALUES (N'PA1', N'a', N'Phòng 101', N'Nam', 1, 6, 650000)
INSERT INTO [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [LoaiPhong], [SoNguoiHienTai], [SoNguoiToiDa], [GiaPhong]) VALUES (N'PA2', N'a', N'Phòng 102', N'Nữ', 0, 3, 1000000)
INSERT INTO [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [LoaiPhong], [SoNguoiHienTai], [SoNguoiToiDa], [GiaPhong]) VALUES (N'PB1', N'b', N'Phòng 201', N'Nữ', 0, 3, 1000000)
INSERT INTO [dbo].[Phong] ([MaPhong], [MaKhu], [TenPhong], [LoaiPhong], [SoNguoiHienTai], [SoNguoiToiDa], [GiaPhong]) VALUES (N'PB2', N'b', N'Phòng 202', N'Nam', 0, 6, 650000)

INSERT INTO [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Lop], [KhoasHoc], [Khoa]) VALUES (N'MSV02', N'Tống Văn Thuyết', N'2003-08-20', 1, N'Hải Phòng', 5678, N'CNTT2', N'K22', N'CNTT')
INSERT INTO [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Lop], [KhoasHoc], [Khoa]) VALUES (N'MSV01', N'Nguyễn Đức Thắng', N'2003-04-06', 1, N'Thái Bình', 3456, N'CNTT2', N'K22', N'CNTT')
INSERT INTO [dbo].[SinhVien] ([MaSV], [TenSV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Lop], [KhoasHoc], [Khoa]) VALUES (N'MSV03', N'Nguyễn Danh Mạnh', N'2003-05-19', 1, N'Hà Nội', 1234, N'CNTT2', N'K22', N'CNTT')
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_CanBo] FOREIGN KEY([MaCB])
REFERENCES [dbo].[CanBo] ([MaCB])
*/

-- Bật các ràng buộc cho bảng Accounts
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_CanBo]
GO

-- Bật các ràng buộc cho bảng DangKyThue
ALTER TABLE [dbo].[DangKyThue] WITH CHECK ADD CONSTRAINT [FK_DangKyThue_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_NAME = 'FK_DangKyThue_Phong')
BEGIN
    -- Tạo ràng buộc nếu nó chưa tồn tại
    ALTER TABLE [dbo].[DangKyThue]  WITH CHECK ADD CONSTRAINT [FK_DangKyThue_Phong] FOREIGN KEY([MaPhong])
    REFERENCES [dbo].[Phong] ([MaPhong])
END

ALTER TABLE [dbo].[DangKyThue] CHECK CONSTRAINT [FK_DangKyThue_Phong]
GO
ALTER TABLE [dbo].[DangKyThue] WITH CHECK ADD CONSTRAINT [FK_DangKyThue_SinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[DangKyThue] CHECK CONSTRAINT [FK_DangKyThue_SinhVien]
GO

-- Bật các ràng buộc cho bảng HDDienNuoc
ALTER TABLE [dbo].[HDDienNuoc] WITH CHECK ADD CONSTRAINT [FK_HDDienNuoc_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[HDDienNuoc] CHECK CONSTRAINT [FK_HDDienNuoc_Phong]
GO

-- Bật các ràng buộc cho bảng HDTienPhong
ALTER TABLE [dbo].[HDTienPhong] WITH CHECK ADD CONSTRAINT [FK_HDTienPhong_SinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[HDTienPhong] CHECK CONSTRAINT [FK_HDTienPhong_SinhVien]
GO

-- Bật các ràng buộc cho bảng HopDongThue
ALTER TABLE [dbo].[HopDongThue] WITH CHECK ADD CONSTRAINT [FK_HopDongThue_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[HopDongThue] CHECK CONSTRAINT [FK_HopDongThue_Phong]
GO
ALTER TABLE [dbo].[HopDongThue] WITH CHECK ADD CONSTRAINT [FK_HopDongThue_SinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[HopDongThue] CHECK CONSTRAINT [FK_HopDongThue_SinhVien]
GO

-- Bật các ràng buộc cho bảng Phong
ALTER TABLE [dbo].[Phong] WITH CHECK ADD CONSTRAINT [FK_Phong_Khu] FOREIGN KEY([MaKhu])
REFERENCES [dbo].[Khu] ([MaKhu])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_Khu]
GO


