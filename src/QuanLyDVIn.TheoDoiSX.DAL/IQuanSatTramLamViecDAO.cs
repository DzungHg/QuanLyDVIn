using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;

namespace QuanLyDVIn.TheoDoiSX.DAL
{
    public interface IQuanSatTramLamViecDAO
    {

        IEnumerable<QuanSatTramLamViecBDO> DocTatCa();
        IEnumerable<QuanSatTramLamViecBDO> DocTheoTinhTrang(int tinhTrang);
        QuanSatTramLamViecBDO DocTheoId(int id);
        void Them(QuanSatTramLamViecBDO entityBDO);
        void Sua(QuanSatTramLamViecBDO entityBDO);
        void Xoa(int id);
    }
}
