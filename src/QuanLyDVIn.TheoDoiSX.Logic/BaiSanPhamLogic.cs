using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;
using QuanLyDVIn.TheoDoiSX.DAL;

namespace QuanLyDVIn.TheoDoiSX.Logic
{
    public class BaiSanPhamLogic
    {
        BaiSanPhamDAO dataDAO = new BaiSanPhamDAO();
        public List<BaiSanPhamBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().ToList();
        }
        public BaiSanPhamBDO DocTheoId(int idBaiSP)
        {
            return dataDAO.DocTheoId(idBaiSP);
        }
        public void Them (BaiSanPhamBDO baiSP)
        {
            dataDAO.Them(baiSP);
        }
        public void Sua(BaiSanPhamBDO baiSP)
        {
            dataDAO.Sua(baiSP);
        }
        public void Xoa(int idBaiSP)
        {
            dataDAO.Xoa(idBaiSP);
        }
    }
}
