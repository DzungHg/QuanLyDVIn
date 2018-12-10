using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;
using QuanLyDVIn.TheoDoiSX.DAL;

namespace QuanLyDVIn.TheoDoiSX.Logic
{
    public class LoaiViecLogic
    {
        LoaiViecDAO dataDAO = new LoaiViecDAO();
        public List<LoaiViecBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().ToList();
        }
        public LoaiViecBDO DocTheoId(int idLoaiViec)
        {
            return dataDAO.DocTheoId(idLoaiViec);
        }
      
    }
}
