using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhatKyPhongIn.Common.Enums;

namespace NhatKyPhongIn.Model
{
    public class BaiSanPham
    {
        public string SoDonHang { get; set; }
        public string TenSanPham { get; set; }
        public string YeuCau { get; set; }
        public string DuongDanFile01 { get; set; }
        public string DuongDanFile02 { get; set; }
        public string DuongDanFile03 { get; set; }
        public DateTime ThoiHan { get; set; }
        public TinhTrangBaiSanPham TinhTrangBaiSanPham { get; set; }


        public BaiSanPham()
        {

        }
        public BaiSanPham(string soDonHang, string tenSanPham, string yeuCau
            , string duongDanFile01, string duongDanFile02, string duongDanFile03)
        {
            this.SoDonHang = soDonHang;
            this.YeuCau = yeuCau;
            this.TenSanPham = tenSanPham;
            this.DuongDanFile01 = duongDanFile01;
            this.DuongDanFile02 = duongDanFile02;
            this.DuongDanFile03 = duongDanFile03;


        }
    }
}
