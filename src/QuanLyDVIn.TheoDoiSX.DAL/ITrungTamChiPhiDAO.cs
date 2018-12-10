using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;

namespace QuanLyDVIn.TheoDoiSX.DAL
{
    public interface ITrungTamChiPhiDAO
    {

        IEnumerable<TrungTamChiPhiBDO> DocTatCa();

        TrungTamChiPhiBDO DocTheoId(int id);
        void Them(TrungTamChiPhiBDO entityBDO);
        void Sua(TrungTamChiPhiBDO entityBDO);
        void Xoa(int id);
    }
}
