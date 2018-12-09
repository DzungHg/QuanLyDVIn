-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<QuanSatTramLamViec_Them>
-- =============================================
CREATE PROCEDURE spQuanSatTramLamViec_Them

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
@TinhTrang int,
@id int = 0 output

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into dbo.QuanSatTramLamViec (MaTramLamViec, IdViec, IdNguoiThucHien, Ten,
	 ThoiGianVo, ThoiGianNhan, BatDauLam, ThoiGianHoanThanh, SoLuongVo, DonViSoLuongVo,
	 SoLuongVoDaLam, SoLuongVoConLai, SoLuongRa, DonViSoLuongRa, SoLuongConLai,
	 GhiChuVo, GhiChuRa, TinhTrang, ThoiGianTao)
	values (@MaTramLamViec, @IdViec, @IdNguoiThucHien, @Ten,
	 @ThoiGianVo, @ThoiGianNhan, @BatDauLam, @ThoiGianHoanThanh, @SoLuongVo, @DonViSoLuongVo,
	 @SoLuongVoDaLam, @SoLuongVoConLai, @SoLuongRa, @DonViSoLuongRa, @SoLuongConLai,
	 @GhiChuVo, @GhiChuRa, @TinhTrang, CURRENT_TIMESTAMP);

	 select @id = SCOPE_IDENTITY();

   
END
GO
