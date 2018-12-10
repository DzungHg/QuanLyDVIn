using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;
using QuanLyDVIn.TheoDoiSX.DAL;

namespace QuanLyDVIn.TheoDoiSX.Logic
{
    public class TrungTamChiPhiLogic
    {
        TrungTamChiPhiDAO dataDAO = new TrungTamChiPhiDAO();
        public List<TrungTamChiPhiBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().ToList();
        }
        public TrungTamChiPhiBDO DocTheoId(int idTrungTamChiPhi)
        {
            return dataDAO.DocTheoId(idTrungTamChiPhi);
        }
      
    }
}
