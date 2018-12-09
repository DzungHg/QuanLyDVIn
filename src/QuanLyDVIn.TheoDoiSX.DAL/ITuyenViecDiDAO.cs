using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;

namespace QuanLyDVIn.TheoDoiSX.DAL
{
    public interface ITuyenViecDiDAO
    {

        IEnumerable<TuyenViecDiBDO> DocTatCa();        
        TuyenViecDiBDO DocTheoId(int id);
        void Them(TuyenViecDiBDO entityBDO);
        void Sua(TuyenViecDiBDO entityBDO);
        void Xoa(int id);
    }
}
