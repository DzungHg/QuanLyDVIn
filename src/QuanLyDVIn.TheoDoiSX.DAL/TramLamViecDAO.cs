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
 

    public class TramLamViecDAO : ITramLamViecDAO
    {
        const string tenDB = "NhatKyPhongIn";
        public IEnumerable<TramLamViecBDO> DocTatCa()
        {
            IEnumerable<TramLamViecBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<TramLamViecBDO>("dbo.spTramLamViec_DocTatCa");
                return output;
            }
        }

        public TramLamViecBDO DocTheoId(int id)
        {
            TramLamViecBDO output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<TramLamViecBDO>("dbo.spTramLamViec_DocTheoId", id).SingleOrDefault();
                return output;
            }
        }

        public void Sua(TramLamViecBDO entityBDO)
        {
            throw new NotImplementedException();
        }

        public void Them(TramLamViecBDO entityBDO)
        {
            throw new NotImplementedException();
        }

        public void Xoa(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
