using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;
using QuanLyDVIn.TheoDoiSX.DAL;

namespace QuanLyDVIn.TheoDoiSX.Logic
{
    public class TuyenViecDiLogic
    {
        TuyenViecDiDAO dataDAO = new TuyenViecDiDAO();
        public List<TuyenViecDiBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().ToList();
        }
       
        public TuyenViecDiBDO DocTheoId(int idTuyenViecDi)
        {
            return dataDAO.DocTheoId(idTuyenViecDi);
        }
        public void Them (TuyenViecDiBDO tuyenViecDi)
        {
            dataDAO.Them(tuyenViecDi);
        }
        public void Sua(TuyenViecDiBDO tuyenViecDi)
        {
            dataDAO.Sua(tuyenViecDi);
        }
        public void Xoa(int idTuyenViecDi)
        {
            dataDAO.Xoa(idTuyenViecDi);
        }
    }
}
