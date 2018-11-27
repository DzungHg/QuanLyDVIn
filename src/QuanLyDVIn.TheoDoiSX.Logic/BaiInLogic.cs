using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;
using QuanLyDVIn.TheoDoiSX.DAL;

namespace QuanLyDVIn.TheoDoiSX.Logic
{
    public class BaiInLogic
    {
        BaiInDAO dataDAO = new BaiInDAO();
        public List<BaiInBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().ToList();
        }
        public List<BaiInBDO> DocTheoTinhTrang(string tinhTrang)
        {
            return dataDAO.DocTheoTinhTrangBaiIn(tinhTrang).ToList();
        }
        public BaiInBDO DocTheoId(int idBaiIn)
        {
            return dataDAO.DocTheoId(idBaiIn);
        }
        public void Them (BaiInBDO mayIn)
        {
            dataDAO.Them(mayIn);
        }
        public void Sua(BaiInBDO mayIn)
        {
            dataDAO.Sua(mayIn);
        }
        public void Xoa(int idBaiIn)
        {
            dataDAO.Xoa(idBaiIn);
        }
    }
}
