using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;
using QuanLyDVIn.TheoDoiSX.DAL;

namespace QuanLyDVIn.TheoDoiSX.Logic
{
    public class TramLamViecLogic
    {
        TramLamViecDAO dataDAO = new TramLamViecDAO();
        public List<TramLamViecBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().ToList();
        }
        public TramLamViecBDO DocTheoId(int idTramLamViec)
        {
            return dataDAO.DocTheoId(idTramLamViec);
        }
      
    }
}
