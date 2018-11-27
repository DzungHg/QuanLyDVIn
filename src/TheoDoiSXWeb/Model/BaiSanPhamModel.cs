using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhatKyPhongIn.Common.Enums;

namespace TheoDoiSXWeb.Model
{
    public class BaiSanPhamModel
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


        public BaiSanPhamModel()
        {

        }
        public BaiSanPhamModel(string soDonHang, string tenSanPham, string yeuCau
            , string duongDanFile01, string duongDanFile02, string duongDanFile03, DateTime thoiHan, string tinhTrangBaiSP)
        {
            this.SoDonHang = soDonHang;
            this.YeuCau = yeuCau;
            this.TenSanPham = tenSanPham;
            this.DuongDanFile01 = duongDanFile01;
            this.DuongDanFile02 = duongDanFile02;
            this.DuongDanFile03 = duongDanFile03;
            this.ThoiHan = thoiHan;
            this.TinhTrangBaiSanPham = tinhTrangBaiSP;


        }
    }
}
