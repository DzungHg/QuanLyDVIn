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
 

    public class QuanSatTramLamViecDAO : IQuanSatTramLamViecDAO
    {
        const string tenDB = "NhatKyPhongIn";//Không còn quan trộng
        public IEnumerable<QuanSatTramLamViecBDO> DocTatCa()
        {
            IEnumerable<QuanSatTramLamViecBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<QuanSatTramLamViecBDO>("dbo.spQuanSatTramLamViec_DocTatCa");
                return output;
            }
        }

        public QuanSatTramLamViecBDO DocTheoId(int id)
        {
            QuanSatTramLamViecBDO output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<QuanSatTramLamViecBDO>("dbo.spQuanSatTramLamViec_DocTheoId", id).SingleOrDefault();
                return output;
            }
        }

        public IEnumerable<QuanSatTramLamViecBDO> DocTheoTinhTrang(int tinhTrang)
        {
            IEnumerable<QuanSatTramLamViecBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<QuanSatTramLamViecBDO>("dbo.spQuanSatTramLamViec_DocTheoTinhTrang", tinhTrang);
                return output;
            }
        }
        public void Them(QuanSatTramLamViecBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@id", entityBDO.Id);
                p.Add("@Ten", entityBDO.Ten);
                p.Add("@MaTramLamViec", entityBDO.MaTramLamViec);
                p.Add("@IdViec", entityBDO.IdViec);
                p.Add("@IdNguoiThucHien", entityBDO.IdNguoiThucHien);
                p.Add("@ThoiGianVo", entityBDO.ThoiGianVo);
                p.Add("@BatDauLam", entityBDO.BatDauLam);
                p.Add("@SoLuongVo", entityBDO.SoLuongVo);
                p.Add("@DonViSoLuongVo", entityBDO.DonViSoLuongVo);
                p.Add("@SoLuongVoDaLam", entityBDO.SoLuongVoDaLam);
                p.Add("@SoLuongVoConLai", entityBDO.SoLuongVoConLai);
                p.Add("@SoLuongRa", entityBDO.SoLuongRa);
                p.Add("@DonViSoLuongRa", entityBDO.DonViSoLuongRa);
                p.Add("@TinhTrang", entityBDO.TinhTrang);
                p.Add("@GhiChuVo", entityBDO.GhiChuVo);
                p.Add("@GhiChuRa", entityBDO.GhiChuRa);

                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                //Excecute
                connection.Execute("dbo.spQuanSatTramLamViec_Them", p, commandType: CommandType.StoredProcedure);
                //xử lý id out
                entityBDO.Id = p.Get<int>("@id");
                ///nếu cần có thể
                ///đặt return ở đay cũng được
            }
        }

        public void Sua(QuanSatTramLamViecBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper
               
                p.Add("@id", entityBDO.Id);
                p.Add("@Ten", entityBDO.Ten);
                p.Add("@MaTramLamViec", entityBDO.MaTramLamViec);
                p.Add("@IdViec", entityBDO.IdViec);
                p.Add("@IdNguoiThucHien", entityBDO.IdNguoiThucHien);
                p.Add("@ThoiGianVo", entityBDO.ThoiGianVo);
                p.Add("@BatDauLam", entityBDO.BatDauLam);
                p.Add("@SoLuongVo", entityBDO.SoLuongVo);
                p.Add("@DonViSoLuongVo", entityBDO.DonViSoLuongVo);
                p.Add("@SoLuongVoDaLam", entityBDO.SoLuongVoDaLam);
                p.Add("@SoLuongVoConLai", entityBDO.SoLuongVoConLai);
                p.Add("@SoLuongRa", entityBDO.SoLuongRa);
                p.Add("@DonViSoLuongRa", entityBDO.DonViSoLuongRa);
                p.Add("@TinhTrang", entityBDO.TinhTrang);
                p.Add("@GhiChuVo", entityBDO.GhiChuVo);
                p.Add("@GhiChuRa", entityBDO.GhiChuRa);                


                //Excecute
                connection.Execute("dbo.spQuanSatTramLamViec_SuaTheoId", p, commandType: CommandType.StoredProcedure);

            }
        }

        

        public void Xoa(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper
                p.Add("@id", id);
                
                //Excecute
                connection.Execute("dbo.spQuanSatTramLamViec_XoaTheoId", p, commandType: CommandType.StoredProcedure);
               
            }
        }
    }
}
