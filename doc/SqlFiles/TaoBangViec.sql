USE [QuanLyIn]
GO

/****** Object:  Table [dbo].[BaiIn]    Script Date: 09/12/2018 3:14:36 PM ******/
 
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Viec](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](150) NULL,
	[DienGiai] [nvarchar](255) NULL,
	[QuyCach] [nvarchar](255) NULL,
	[GhiChu] [nvarchar](255) NULL,
	[NhanXet] [nvarchar](255) NULL,
	[ThoiHan] [datetime] NULL,	
	[IdTuyenDi] [int] NULL,
	[SoLuong] [int] NULL,
	[DonViSoLuong] [nvarchar](20) NULL,
	[MaLoaiViec] [char](12) NULL,
	[IdNgoai] [int] NULL,
	[TinhTrang] [int] NULL,
		
 CONSTRAINT [PK_Viec] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


