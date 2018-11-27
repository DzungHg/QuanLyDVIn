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
 

    public class BaiSanPhamDAO : IBaiSanPhamDAO
    {
        const string tenDB = "NhatKyPhongIn";
        public IEnumerable<BaiSanPhamBDO> DocTatCa()
        {
            IEnumerable<BaiSanPhamBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<BaiSanPhamBDO>("dbo.spBaiSanPham_DocTatCa");
                return output;
            }
        }

        public BaiSanPhamBDO DocTheoId(int iD)
        {
            BaiSanPhamBDO output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<BaiSanPhamBDO>("dbo.spBaiSanPham_DocTheoId", iD).SingleOrDefault();
                return output;
            }
        }

        public void Sua(BaiSanPhamBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@id", entityBDO.Id);
                p.Add("@SoDonHang", entityBDO.SoDonHang);
                p.Add("@TenSanPham", entityBDO.TenSanPham);
                p.Add("@YeuCau", entityBDO.YeuCau);
                p.Add("@DuongDanFile01", entityBDO.DuongDanFile01);
                p.Add("@DuongDanFile02", entityBDO.DuongDanFile02);
                p.Add("@DuongDanFile03", entityBDO.DuongDanFile03);
                p.Add("@TinhTrangBaiSanPham", entityBDO.TinhTrangBaiSanPham);
                p.Add("@ThoiHan", entityBDO.ThoiHan);
               
                //Excecute
                connection.Execute("dbo.spBaiSanPham_SuaTheoId", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void Them(BaiSanPhamBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@SoDonHang", entityBDO.SoDonHang);
                p.Add("@TenSanPham", entityBDO.TenSanPham);
                p.Add("@YeuCau", entityBDO.YeuCau);
                p.Add("@DuongDanFile01", entityBDO.DuongDanFile01);
                p.Add("@DuongDanFile02", entityBDO.DuongDanFile02);
                p.Add("@DuongDanFile03", entityBDO.DuongDanFile03);
                p.Add("@TinhTrangBaiSanPham", entityBDO.TinhTrangBaiSanPham);
                p.Add("@ThoiHan", entityBDO.ThoiHan);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                //Excecute
                connection.Execute("dbo.spBaiSanPham_Them", p, commandType: CommandType.StoredProcedure);
                //xử lý id out
                entityBDO.Id = p.Get<int>("@id");
                ///nếu cần có thể
                ///đặt return ở đay cũng được
            }
        }

        public void Xoa(int iD)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper
                p.Add("@Id", iD);
                
                //Excecute
                connection.Execute("dbo.spBaiSanPham_XoaTheoId", p, commandType: CommandType.StoredProcedure);
               
            }
        }
    }
}
