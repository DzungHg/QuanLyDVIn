using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using QuanLyDVIn.TheoDoiSX.BDO;
using QuanLyDVIn.TheoDoiSX.Common;

namespace QuanLyDVIn.TheoDoiSX.DAL
{
 

    public class BaiInDAO : IBaiInDAO
    {
        const string tenDB = "NhatKyPhongIn";
        public IEnumerable<BaiInBDO> DocTatCa()
        {
            IEnumerable<BaiInBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<BaiInBDO>("dbo.spBaiIn_DocTatCa");
                return output;
            }
        }

        public BaiInBDO DocTheoId(int id)
        {
            BaiInBDO output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<BaiInBDO>("dbo.spBaiIn_DocTheoId", id).SingleOrDefault();
                return output;
            }
        }

        public IEnumerable<BaiInBDO> DocTheoTinhTrangBaiIn(string tinhTrang)
        {
            IEnumerable<BaiInBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<BaiInBDO>("dbo.spBaiIn_TinhTrang", tinhTrang);
                return output;
            }
        }

        public void Sua(BaiInBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper
                

                p.Add("@id", entityBDO.Id);
                p.Add("@TenBaiIn", entityBDO.TenBaiIn);
                p.Add("@DienGiaiIn", entityBDO.DienGiaiIn);
                p.Add("@NguoiLamFile", entityBDO.NguoiLamFile);
                p.Add("@IdMayIn", entityBDO.IdMayIn);
                p.Add("@TenMayIn", entityBDO.TenMayIn);
                p.Add("@TenGiayIn", entityBDO.TenGiayIn);
                p.Add("@ToChayRong", entityBDO.TinhTrangBaiIn);
                p.Add("@ToChayDai", entityBDO.ToChayDai);
                p.Add("@SoLuongToChayCanIn", entityBDO.SoLuongToChayCanIn);
                p.Add("@SoLuongToChayBuHao", entityBDO.SoLuongToChayBuHao);
                p.Add("@SoMatIn", entityBDO.SoMatIn);
                p.Add("@MauIn", entityBDO.MauIn);
                p.Add("@SoClickCanIn", entityBDO.SoClickCanIn);
                p.Add("@DonViTinhClick", entityBDO.DonViTinhClick);
                p.Add("@MucUuTien", entityBDO.MucUuTien);
                p.Add("@DuongDanFileIn", entityBDO.DuongDanFileIn);
                p.Add("@DuongDanFileKhachHang", entityBDO.DuongDanFileKhachHang);
                p.Add("@TinhTrangBaiIn", entityBDO.TinhTrangBaiIn);
                p.Add("@IdBaiSanPham", entityBDO.IdBaiSanPham);
                p.Add("@ThoiHanInXong", entityBDO.ThoiHanInXong);

                //Excecute
                connection.Execute("dbo.spBaiIn_SuaTheoId", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void Them(BaiInBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@TenBaiIn", entityBDO.TenBaiIn);
                p.Add("@DienGiaiIn", entityBDO.DienGiaiIn);
                p.Add("@NguoiLamFile", entityBDO.NguoiLamFile);
                p.Add("@IdMayIn", entityBDO.IdMayIn);
                p.Add("@TenMayIn", entityBDO.TenMayIn);
                p.Add("@TenGiayIn", entityBDO.TenGiayIn);
                p.Add("@ToChayRong", entityBDO.TinhTrangBaiIn);
                p.Add("@ToChayDai", entityBDO.ToChayDai);
                p.Add("@SoLuongToChayCanIn", entityBDO.SoLuongToChayCanIn);
                p.Add("@SoLuongToChayBuHao", entityBDO.SoLuongToChayBuHao);
                p.Add("@SoMatIn", entityBDO.SoMatIn);
                p.Add("@MauIn", entityBDO.MauIn);
                p.Add("@SoClickCanIn", entityBDO.SoClickCanIn);
                p.Add("@DonViTinhClick", entityBDO.DonViTinhClick);
                p.Add("@MucUuTien", entityBDO.MucUuTien);
                p.Add("@DuongDanFileIn", entityBDO.DuongDanFileIn);
                p.Add("@DuongDanFileKhachHang", entityBDO.DuongDanFileKhachHang);
                p.Add("@TinhTrangBaiIn", entityBDO.TinhTrangBaiIn);
                p.Add("@IdBaiSanPham", entityBDO.IdBaiSanPham);
                p.Add("@ThoiHanInXong", entityBDO.ThoiHanInXong);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                //Excecute
                connection.Execute("dbo.spBaiIn_Them", p, commandType: CommandType.StoredProcedure);
                //xử lý id out
                entityBDO.Id = p.Get<int>("@id");
                ///nếu cần có thể
                ///đặt return ở đay cũng được
            }
        }

        public void Xoa(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper
                p.Add("@id", id);
                
                //Excecute
                connection.Execute("dbo.spBaiIn_XoaTheoId", p, commandType: CommandType.StoredProcedure);
               
            }
        }
    }
}
