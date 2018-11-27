using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;

namespace QuanLyDVIn.TheoDoiSX.DAL
{
    public interface IBaiSanPhamDAO
    {

        IEnumerable<BaiSanPhamBDO> DocTatCa();


        BaiSanPhamBDO DocTheoId(int iD);
        void Them(BaiSanPhamBDO entityBDO);
        void Sua(BaiSanPhamBDO entityBDO);
        void Xoa(int iD);
    }
}
