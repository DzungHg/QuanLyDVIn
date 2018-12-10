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
 

    public class LoaiViecDAO : ILoaiViecDAO
    {
        const string tenDB = "NhatKyPhongIn";
        public IEnumerable<LoaiViecBDO> DocTatCa()
        {
            IEnumerable<LoaiViecBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<LoaiViecBDO>("dbo.spLoaiViec_DocTatCa");
                return output;
            }
        }

        public LoaiViecBDO DocTheoId(int id)
        {
            LoaiViecBDO output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<LoaiViecBDO>("dbo.spLoaiViec_DocTheoId", id).SingleOrDefault();
                return output;
            }
        }

        public void Sua(LoaiViecBDO entityBDO)
        {
            throw new NotImplementedException();
        }

        public void Them(LoaiViecBDO entityBDO)
        {
            throw new NotImplementedException();
        }

        public void Xoa(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
