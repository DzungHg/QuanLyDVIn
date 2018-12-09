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
 

    public class TuyenViecDiDAO : ITuyenViecDiDAO
    {
        const string tenDB = "NhatKyPhongIn";//Không còn quan trộng
        public IEnumerable<TuyenViecDiBDO> DocTatCa()
        {
            IEnumerable<TuyenViecDiBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<TuyenViecDiBDO>("dbo.spTuyenViecDi_DocTatCa");
                return output;
            }
        }

        public TuyenViecDiBDO DocTheoId(int id)
        {
            TuyenViecDiBDO output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<TuyenViecDiBDO>("dbo.spTuyenViecDi_DocTheoId", id).SingleOrDefault();
                return output;
            }
        }

        
        public void Sua(TuyenViecDiBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper
               
                p.Add("@id", entityBDO.Id);
                p.Add("@Ten", entityBDO.Ten);
                p.Add("@TuyenDi", entityBDO.TuyenDi);
                p.Add("@ThuTu", entityBDO.ThuTu);
                
                //Excecute
                connection.Execute("dbo.spBaiIn_SuaTheoId", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void Them(TuyenViecDiBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@id", entityBDO.Id);
                p.Add("@Ten", entityBDO.Ten);
                p.Add("@TuyenDi", entityBDO.TuyenDi);
                p.Add("@ThuTu", entityBDO.ThuTu);

                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                //Excecute
                connection.Execute("dbo.spTuyenViecDi_Them", p, commandType: CommandType.StoredProcedure);
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
                connection.Execute("dbo.spTuyenViecDi_XoaTheoId", p, commandType: CommandType.StoredProcedure);
               
            }
        }
    }
}
