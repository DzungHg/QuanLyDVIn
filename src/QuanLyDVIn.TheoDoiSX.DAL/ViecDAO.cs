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
 

    public class ViecDAO : IViecDAO
    {
        const string tenDB = "NhatKyPhongIn";//Không còn quan trộng
        public IEnumerable<ViecBDO> DocTatCa()
        {
            IEnumerable<ViecBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<ViecBDO>("dbo.spViec_DocTatCa");
                return output;
            }
        }

        public ViecBDO DocTheoId(int id)
        {
            ViecBDO output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<ViecBDO>("dbo.spViec_DocTheoId", id).SingleOrDefault();
                return output;
            }
        }

        public IEnumerable<ViecBDO> DocTheoTinhTrang(int tinhTrang)
        {
            IEnumerable<ViecBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<ViecBDO>("dbo.spViec_DocTheoTinhTrang", tinhTrang);
                return output;
            }
        }
        public IEnumerable<ViecBDO> DocTheoGiaiDoan(int giaiDoan)
        {
            IEnumerable<ViecBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<ViecBDO>("dbo.spViec_DocTheoGiaiDoan", giaiDoan);
                return output;
            }
        }

        public void Sua(ViecBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper
               
                p.Add("@id", entityBDO.Id);
                p.Add("@Ten", entityBDO.Ten);
                p.Add("@DienGiai", entityBDO.DienGiai);
                p.Add("@QuyCach", entityBDO.QuyCach);
                p.Add("@GhiChu", entityBDO.GhiChu);
                p.Add("@NhanXet", entityBDO.NhanXet);
                p.Add("@ThoiHan", entityBDO.ThoiHan);
                p.Add("@IdTuyenDi", entityBDO.IdTuyenDi);
                p.Add("@SoLuong", entityBDO.SoLuong);
                p.Add("@DonViSoLuong", entityBDO.DonViSoLuong);
                p.Add("@MaLoaiViec", entityBDO.MaLoaiViec);
                p.Add("@IdNgoai", entityBDO.IdNgoai);
                p.Add("@GiaiDoan", entityBDO.GiaiDoan);
                p.Add("@TinhTrang", entityBDO.TinhTrang);
               

                //Excecute
                connection.Execute("dbo.spBaiIn_SuaTheoId", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void Them(ViecBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@id", entityBDO.Id);
                p.Add("@Ten", entityBDO.Ten);
                p.Add("@DienGiai", entityBDO.DienGiai);
                p.Add("@QuyCach", entityBDO.QuyCach);
                p.Add("@GhiChu", entityBDO.GhiChu);
                p.Add("@NhanXet", entityBDO.NhanXet);
                p.Add("@ThoiHan", entityBDO.ThoiHan);
                p.Add("@IdTuyenDi", entityBDO.IdTuyenDi);
                p.Add("@SoLuong", entityBDO.SoLuong);
                p.Add("@DonViSoLuong", entityBDO.DonViSoLuong);
                p.Add("@MaLoaiViec", entityBDO.MaLoaiViec);
                p.Add("@IdNgoai", entityBDO.IdNgoai);
                p.Add("@GiaiDoan", entityBDO.GiaiDoan);
                p.Add("@TinhTrang", entityBDO.TinhTrang);

                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                //Excecute
                connection.Execute("dbo.spViec_Them", p, commandType: CommandType.StoredProcedure);
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
                connection.Execute("dbo.spViec_XoaTheoId", p, commandType: CommandType.StoredProcedure);
               
            }
        }
    }
}
