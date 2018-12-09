using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;

namespace QuanLyDVIn.TheoDoiSX.DAL
{
    public interface IViecDAO
    {

        IEnumerable<ViecBDO> DocTatCa();
        IEnumerable<ViecBDO> DocTheoTinhTrang(int tinhTrang);
        ViecBDO DocTheoId(int id);
        void Them(ViecBDO entityBDO);
        void Sua(ViecBDO entityBDO);
        void Xoa(int id);
    }
}
