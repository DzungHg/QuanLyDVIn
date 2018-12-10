using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;
using QuanLyDVIn.TheoDoiSX.DAL;

namespace QuanLyDVIn.TheoDoiSX.Logic
{
    public class ViecLogic
    {
        ViecDAO dataDAO = new ViecDAO();
        public List<ViecBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().ToList();
        }
        public List<ViecBDO> DocTheoTinhTrang(int tinhTrang)
        {
            return dataDAO.DocTheoTinhTrang(tinhTrang).ToList();
        }
        public List<ViecBDO> DocTheoGiaiDoan(int giaiDoan)
        {
            return dataDAO.DocTheoGiaiDoan(giaiDoan).ToList();
        }
        public ViecBDO DocTheoId(int idViec)
        {
            return dataDAO.DocTheoId(idViec);
        }
        public void Them (ViecBDO viec)
        {
            dataDAO.Them(viec);
        }
        public void Sua(ViecBDO viec)
        {
            dataDAO.Sua(viec);
        }
        public void Xoa(int idViec)
        {
            dataDAO.Xoa(idViec);
        }
    }
}
