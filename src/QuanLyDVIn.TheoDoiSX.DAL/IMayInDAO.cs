using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;

namespace QuanLyDVIn.TheoDoiSX.DAL
{
    public interface IMayInDAO
    {

        IEnumerable<MayInBDO> DocTatCa();

        MayInBDO DocTheoId(int id);
        void Them(MayInBDO entityBDO);
        void Sua(MayInBDO entityBDO);
        void Xoa(int id);
    }
}
