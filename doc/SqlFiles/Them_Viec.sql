-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Thêm Việc mới>
-- =============================================
CREATE PROCEDURE spViec_Them
	
@Ten nvarchar(255),
@DienGiai nvarchar(255),
@QuyCach nvarchar(255),
@GhiChu nvarchar(255),
@NhanXet nvarchar(255),
@ThoiHan DateTime,
@IdTuyenDi int,
@SoLuong int,
@DonViSoLuong  nvarchar(20),
@MaLoaiViec char(12),
@IdNgoai int,
@TinhTrang int,
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into dbo.Viec(Ten, DienGiai, QuyCach, GhiChu, NhanXet,ThoiHan, IdTuyenDi,
	SoLuong, DonViSoLuong, MaLoaiViec, IdNgoai, TinhTrang, ThoiGianTao)
	values (@Ten, @DienGiai, @QuyCach, @GhiChu, @NhanXet, @ThoiHan, @IdTuyenDi,
	@SoLuong, @DonViSoLuong, @MaLoaiViec, @IdNgoai, @TinhTrang, CURRENT_TIMESTAMP);

	select @id = SCOPE_IDENTITY();
END
GO
