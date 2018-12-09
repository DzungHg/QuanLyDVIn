using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;
using QuanLyDVIn.TheoDoiSX.DAL;

namespace QuanLyDVIn.TheoDoiSX.Logic
{
    public class QuanSatTramLamViecLogic
    {
        QuanSatTramLamViecDAO dataDAO = new QuanSatTramLamViecDAO();
        public List<QuanSatTramLamViecBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().ToList();
        }
        public List<QuanSatTramLamViecBDO> DocTheoTinhTrang(int tinhTrang)
        {
            return dataDAO.DocTheoTinhTrang(tinhTrang).ToList();
        }
        public QuanSatTramLamViecBDO DocTheoId(int idQSTRV)
        {
            return dataDAO.DocTheoId(idQSTRV);
        }
        public void Them (QuanSatTramLamViecBDO quanSatTramLV)
        {
            dataDAO.Them(quanSatTramLV);
        }
        public void Sua(QuanSatTramLamViecBDO quanSatTramLV)
        {
            dataDAO.Sua(quanSatTramLV);
        }
        public void Xoa(int idViec)
        {
            dataDAO.Xoa(idViec);
        }
    }
}
