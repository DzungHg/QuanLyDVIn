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
 

    public class TrungTamChiPhiDAO : ITrungTamChiPhiDAO
    {
        const string tenDB = "NhatKyPhongIn";
        public IEnumerable<TrungTamChiPhiBDO> DocTatCa()
        {
            IEnumerable<TrungTamChiPhiBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<TrungTamChiPhiBDO>("dbo.spTrungTamChiPhi_DocTatCa");
                return output;
            }
        }

        public TrungTamChiPhiBDO DocTheoId(int id)
        {
            TrungTamChiPhiBDO output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<TrungTamChiPhiBDO>("dbo.spTrungTamChiPhi_DocTheoId", id).SingleOrDefault();
                return output;
            }
        }

        public void Sua(TrungTamChiPhiBDO entityBDO)
        {
            throw new NotImplementedException();
        }

        public void Them(TrungTamChiPhiBDO entityBDO)
        {
            throw new NotImplementedException();
        }

        public void Xoa(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
