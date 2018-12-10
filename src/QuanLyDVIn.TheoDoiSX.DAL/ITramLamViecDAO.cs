using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;

namespace QuanLyDVIn.TheoDoiSX.DAL
{
    public interface ITramLamViecDAO
    {

        IEnumerable<TramLamViecBDO> DocTatCa();

        TramLamViecBDO DocTheoId(int id);
        void Them(TramLamViecBDO entityBDO);
        void Sua(TramLamViecBDO entityBDO);
        void Xoa(int id);
    }
}
