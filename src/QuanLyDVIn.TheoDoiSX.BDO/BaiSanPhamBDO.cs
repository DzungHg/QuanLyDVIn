using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDVIn.TheoDoiSX.BDO
{
    public class BaiSanPhamBDO
    {
        public int Id { get; set; }
        public string SoDonHang { get; set; }
        public string TenSanPham { get; set; }
        public string YeuCau { get; set; }
        public string DuongDanFile01 { get; set; }
        public string DuongDanFile02 { get; set; }
        public string DuongDanFile03 { get; set; }
        public DateTime ThoiHan { get; set; }
        public string TinhTrangBaiSanPham { get; set; }
    }
}
