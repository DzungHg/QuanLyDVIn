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
 

    public class MayInDAO : IMayInDAO
    {
        const string tenDB = "NhatKyPhongIn";
        public IEnumerable<MayInBDO> DocTatCa()
        {
            IEnumerable<MayInBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<MayInBDO>("dbo.spMayIn_DocTatCa");
                return output;
            }
        }

        public MayInBDO DocTheoId(int id)
        {
            MayInBDO output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<MayInBDO>("dbo.spMayIn_DocTheoId", id).SingleOrDefault();
                return output;
            }
        }

        public void Sua(MayInBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@id", entityBDO.Id);
                p.Add("@TenMayIn", entityBDO.TenMayIn);
                p.Add("@MaMayIn", entityBDO.MaMayIn);
                p.Add("@MoTa", entityBDO.MoTa);
                p.Add("@ThuTuSapXep", entityBDO.ThuTuSapXep);
                p.Add("@DonViDemClick", entityBDO.DonViDemClick);
                p.Add("@NgungHoatDong", entityBDO.NgungHoatDong);

                //Excecute
                connection.Execute("dbo.spMayIn_SuaTheoId", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void Them(MayInBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@TenMayIn", entityBDO.TenMayIn);
                p.Add("@MaMayIn", entityBDO.MaMayIn);
                p.Add("@MoTa", entityBDO.MoTa);
                p.Add("@ThuTuSapXep", entityBDO.ThuTuSapXep);
                p.Add("@NgungHoatDong", entityBDO.NgungHoatDong);
                p.Add("@DonViDemClick", entityBDO.DonViDemClick);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                //Excecute
                connection.Execute("dbo.spMayIn_Them", p, commandType: CommandType.StoredProcedure);
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
                connection.Execute("dbo.spMayIn_XoaTheoId", p, commandType: CommandType.StoredProcedure);
               
            }
        }
    }
}
