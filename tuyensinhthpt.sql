USE [tuyensinhthpt]
GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 28/10/2019 8:35:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[machucvu] [int] IDENTITY(1,1) NOT NULL,
	[tenchucvu] [nvarchar](50) NULL,
 CONSTRAINT [PK_chucvu] PRIMARY KEY CLUSTERED 
(
	[machucvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[diemthi]    Script Date: 28/10/2019 8:35:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diemthi](
	[mahocsinh] [int] NOT NULL,
	[mamon] [int] NOT NULL,
	[diemthi] [float] NULL,
	[diemphuckhao] [float] NULL,
	[giaoviencham] [int] NULL,
	[nguoinhapdiem] [int] NULL,
 CONSTRAINT [PK_diemthi] PRIMARY KEY CLUSTERED 
(
	[mahocsinh] ASC,
	[mamon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[giaovien]    Script Date: 28/10/2019 8:35:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giaovien](
	[magiaovien] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
	[machucvu] [int] NULL,
 CONSTRAINT [PK_giaovien] PRIMARY KEY CLUSTERED 
(
	[magiaovien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hocsinh]    Script Date: 28/10/2019 8:35:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hocsinh](
	[mahocsinh] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[lop] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
	[hokhau] [nvarchar](50) NULL,
	[matruong] [int] NOT NULL,
	[ngaysinh] [date] NULL,
 CONSTRAINT [PK_hocsinh] PRIMARY KEY CLUSTERED 
(
	[mahocsinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hocsinh_xepphong]    Script Date: 28/10/2019 8:35:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hocsinh_xepphong](
	[mahocsinh] [int] NOT NULL,
	[maxepphong] [int] NOT NULL,
 CONSTRAINT [PK_hocsinh_xepphong] PRIMARY KEY CLUSTERED 
(
	[mahocsinh] ASC,
	[maxepphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[monhoc]    Script Date: 28/10/2019 8:35:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[monhoc](
	[mamon] [int] IDENTITY(1,1) NOT NULL,
	[tenmon] [nvarchar](50) NULL,
	[heso] [float] NULL,
 CONSTRAINT [PK_monhoc] PRIMARY KEY CLUSTERED 
(
	[mamon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhiemvu]    Script Date: 28/10/2019 8:35:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhiemvu](
	[manhiemvu] [int] IDENTITY(1,1) NOT NULL,
	[tennhiemvu] [nvarchar](50) NULL,
 CONSTRAINT [PK_nhiemvu] PRIMARY KEY CLUSTERED 
(
	[manhiemvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhiemvu_giaovien]    Script Date: 28/10/2019 8:35:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhiemvu_giaovien](
	[maxepphong] [int] NOT NULL,
	[magiaovien] [int] NOT NULL,
	[manhiemvu] [int] NOT NULL,
 CONSTRAINT [PK_nhiemvu_giaovien] PRIMARY KEY CLUSTERED 
(
	[maxepphong] ASC,
	[magiaovien] ASC,
	[manhiemvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phongthi]    Script Date: 28/10/2019 8:35:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phongthi](
	[maphongthi] [int] IDENTITY(1,1) NOT NULL,
	[tenphongthi] [nvarchar](50) NULL,
 CONSTRAINT [PK_phongthi] PRIMARY KEY CLUSTERED 
(
	[maphongthi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 28/10/2019 8:35:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[mataikhoan] [int] IDENTITY(1,1) NOT NULL,
	[tentaikhoan] [nvarchar](50) NULL,
	[magiaovien] [int] NULL,
	[matkhau] [nvarchar](255) NULL,
 CONSTRAINT [PK_taikhoan] PRIMARY KEY CLUSTERED 
(
	[mataikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[truongthcs]    Script Date: 28/10/2019 8:35:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[truongthcs](
	[matruong] [int] IDENTITY(1,1) NOT NULL,
	[tentruong] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
	[hieutruong] [nvarchar](50) NULL,
 CONSTRAINT [PK_truongthcs] PRIMARY KEY CLUSTERED 
(
	[matruong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[xepphong]    Script Date: 28/10/2019 8:35:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[xepphong](
	[maxepphong] [int] IDENTITY(1,1) NOT NULL,
	[maphongthi] [int] NULL,
	[mamon] [int] NULL,
	[ngaythi] [datetime] NULL,
 CONSTRAINT [PK_xepphong] PRIMARY KEY CLUSTERED 
(
	[maxepphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[chucvu] ON 

INSERT [dbo].[chucvu] ([machucvu], [tenchucvu]) VALUES (1, N'Hiệu Trưởng')
INSERT [dbo].[chucvu] ([machucvu], [tenchucvu]) VALUES (2, N'Giáo viên')
INSERT [dbo].[chucvu] ([machucvu], [tenchucvu]) VALUES (3, N'Hiệu Phó')
SET IDENTITY_INSERT [dbo].[chucvu] OFF
SET IDENTITY_INSERT [dbo].[giaovien] ON 

INSERT [dbo].[giaovien] ([magiaovien], [hoten], [ngaysinh], [gioitinh], [email], [sdt], [machucvu]) VALUES (1, N'Admin', CAST(N'1990-01-08' AS Date), N'Nữ', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[giaovien] OFF
SET IDENTITY_INSERT [dbo].[taikhoan] ON 

INSERT [dbo].[taikhoan] ([mataikhoan], [tentaikhoan], [magiaovien], [matkhau]) VALUES (1, N'admin', 1, N'356a192b7913b04c54574d18c28d46e6395428ab')
SET IDENTITY_INSERT [dbo].[taikhoan] OFF
ALTER TABLE [dbo].[diemthi]  WITH CHECK ADD  CONSTRAINT [FK_diemthi_giaovien] FOREIGN KEY([giaoviencham])
REFERENCES [dbo].[giaovien] ([magiaovien])
GO
ALTER TABLE [dbo].[diemthi] CHECK CONSTRAINT [FK_diemthi_giaovien]
GO
ALTER TABLE [dbo].[diemthi]  WITH CHECK ADD  CONSTRAINT [FK_diemthi_giaovien1] FOREIGN KEY([nguoinhapdiem])
REFERENCES [dbo].[giaovien] ([magiaovien])
GO
ALTER TABLE [dbo].[diemthi] CHECK CONSTRAINT [FK_diemthi_giaovien1]
GO
ALTER TABLE [dbo].[diemthi]  WITH CHECK ADD  CONSTRAINT [FK_diemthi_monhoc] FOREIGN KEY([mamon])
REFERENCES [dbo].[monhoc] ([mamon])
GO
ALTER TABLE [dbo].[diemthi] CHECK CONSTRAINT [FK_diemthi_monhoc]
GO
ALTER TABLE [dbo].[giaovien]  WITH CHECK ADD  CONSTRAINT [FK_giaovien_chucvu] FOREIGN KEY([machucvu])
REFERENCES [dbo].[chucvu] ([machucvu])
GO
ALTER TABLE [dbo].[giaovien] CHECK CONSTRAINT [FK_giaovien_chucvu]
GO
ALTER TABLE [dbo].[hocsinh]  WITH CHECK ADD  CONSTRAINT [FK_hocsinh_truongthcs1] FOREIGN KEY([matruong])
REFERENCES [dbo].[truongthcs] ([matruong])
GO
ALTER TABLE [dbo].[hocsinh] CHECK CONSTRAINT [FK_hocsinh_truongthcs1]
GO
ALTER TABLE [dbo].[hocsinh_xepphong]  WITH CHECK ADD  CONSTRAINT [FK_hocsinh_xepphong_hocsinh] FOREIGN KEY([mahocsinh])
REFERENCES [dbo].[hocsinh] ([mahocsinh])
GO
ALTER TABLE [dbo].[hocsinh_xepphong] CHECK CONSTRAINT [FK_hocsinh_xepphong_hocsinh]
GO
ALTER TABLE [dbo].[hocsinh_xepphong]  WITH CHECK ADD  CONSTRAINT [FK_hocsinh_xepphong_xepphong] FOREIGN KEY([maxepphong])
REFERENCES [dbo].[xepphong] ([maxepphong])
GO
ALTER TABLE [dbo].[hocsinh_xepphong] CHECK CONSTRAINT [FK_hocsinh_xepphong_xepphong]
GO
ALTER TABLE [dbo].[nhiemvu_giaovien]  WITH CHECK ADD  CONSTRAINT [FK_nhiemvu_giaovien_giaovien] FOREIGN KEY([magiaovien])
REFERENCES [dbo].[giaovien] ([magiaovien])
GO
ALTER TABLE [dbo].[nhiemvu_giaovien] CHECK CONSTRAINT [FK_nhiemvu_giaovien_giaovien]
GO
ALTER TABLE [dbo].[nhiemvu_giaovien]  WITH CHECK ADD  CONSTRAINT [FK_nhiemvu_giaovien_nhiemvu] FOREIGN KEY([manhiemvu])
REFERENCES [dbo].[nhiemvu] ([manhiemvu])
GO
ALTER TABLE [dbo].[nhiemvu_giaovien] CHECK CONSTRAINT [FK_nhiemvu_giaovien_nhiemvu]
GO
ALTER TABLE [dbo].[nhiemvu_giaovien]  WITH CHECK ADD  CONSTRAINT [FK_nhiemvu_giaovien_xepphong] FOREIGN KEY([maxepphong])
REFERENCES [dbo].[xepphong] ([maxepphong])
GO
ALTER TABLE [dbo].[nhiemvu_giaovien] CHECK CONSTRAINT [FK_nhiemvu_giaovien_xepphong]
GO
ALTER TABLE [dbo].[taikhoan]  WITH CHECK ADD  CONSTRAINT [FK_taikhoan_giaovien] FOREIGN KEY([magiaovien])
REFERENCES [dbo].[giaovien] ([magiaovien])
GO
ALTER TABLE [dbo].[taikhoan] CHECK CONSTRAINT [FK_taikhoan_giaovien]
GO
ALTER TABLE [dbo].[xepphong]  WITH CHECK ADD  CONSTRAINT [FK_xepphong_monhoc] FOREIGN KEY([mamon])
REFERENCES [dbo].[monhoc] ([mamon])
GO
ALTER TABLE [dbo].[xepphong] CHECK CONSTRAINT [FK_xepphong_monhoc]
GO
ALTER TABLE [dbo].[xepphong]  WITH CHECK ADD  CONSTRAINT [FK_xepphong_phongthi] FOREIGN KEY([maphongthi])
REFERENCES [dbo].[phongthi] ([maphongthi])
GO
ALTER TABLE [dbo].[xepphong] CHECK CONSTRAINT [FK_xepphong_phongthi]
GO
