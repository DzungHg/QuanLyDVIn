using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;
using QuanLyDVIn.TheoDoiSX.DAL;

namespace QuanLyDVIn.TheoDoiSX.Logic
{
    public class MayInLogic
    {
        MayInDAO dataDAO = new MayInDAO();
        public List<MayInBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().ToList();
        }
        public MayInBDO DocTheoId(int idMayIn)
        {
            return dataDAO.DocTheoId(idMayIn);
        }
        public void Them (MayInBDO mayIn)
        {
            dataDAO.Them(mayIn);
        }
        public void Sua(MayInBDO mayIn)
        {
            dataDAO.Sua(mayIn);
        }
        public void Xoa(int idMayIn)
        {
            dataDAO.Xoa(idMayIn);
        }
    }
}
