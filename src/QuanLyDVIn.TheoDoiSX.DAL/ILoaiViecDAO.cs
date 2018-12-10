using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;

namespace QuanLyDVIn.TheoDoiSX.DAL
{
    public interface ILoaiViecDAO
    {

        IEnumerable<LoaiViecBDO> DocTatCa();

        LoaiViecBDO DocTheoId(int id);
        void Them(LoaiViecBDO entityBDO);
        void Sua(LoaiViecBDO entityBDO);
        void Xoa(int id);
    }
}
