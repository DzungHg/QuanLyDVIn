-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<QuanSatTramLamViec_SuaTheoId>
-- =============================================
CREATE PROCEDURE spQuanSatTramLamViec_SuaTheoId
@id int,
@MaTramLamViec char(12),
@IdViec int,
@IdNguoiThucHien int,
@Ten nvarchar(100),
@ThoiGianVo datetime,
@ThoiGianNhan datetime,
@BatDauLam datetime,
@ThoiGianHoanThanh datetime,
@SoLuongVo int,
@DonViSoLuongVo nvarchar(20),
@SoLuongVoDaLam int,
@SoLuongVoConLai int,
@SoLuongRa int,
@DonViSoLuongRa nvarchar(20),
@SoLuongConLai int,
@GhiChuVo nvarchar(255),
@GhiChuRa nvarchar(255),
@TinhTrang int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update dbo.QuanSatTramLamViec
	set
		MaTramLamViec = @MaTramLamViec,
		IdViec = @IdViec,
		IdNguoiThucHien = @IdNguoiThucHien,
		Ten = @Ten ,
		ThoiGianVo = @ThoiGianVo,
		ThoiGianNhan = @ThoiGianNhan, 
		BatDauLam = @BatDauLam,
		ThoiGianHoanThanh = @ThoiGianHoanThanh,
		SoLuongVo = @SoLuongVo,
		DonViSoLuongVo = @DonViSoLuongVo,
		SoLuongVoDaLam = @SoLuongVoDaLam,
		SoLuongVoConLai = @SoLuongVoConLai,
		SoLuongRa = @SoLuongRa, 
		DonViSoLuongRa = @DonViSoLuongRa, 
		SoLuongConLai = @SoLuongConLai,
		GhiChuVo = @GhiChuVo,
		GhiChuRa = @GhiChuRa, 
		TinhTrang  =  @TinhTrang  
	  
	
	 where id = @id;

   
END
GO
