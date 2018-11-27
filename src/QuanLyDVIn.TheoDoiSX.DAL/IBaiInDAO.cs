using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;

namespace QuanLyDVIn.TheoDoiSX.DAL
{
    public interface IBaiInDAO
    {

        IEnumerable<BaiInBDO> DocTatCa();
        IEnumerable<BaiInBDO> DocTheoTinhTrangBaiIn(string tinhTrang);
        BaiInBDO DocTheoId(int id);
        void Them(BaiInBDO entityBDO);
        void Sua(BaiInBDO entityBDO);
        void Xoa(int id);
    }
}
