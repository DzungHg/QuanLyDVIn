using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.Common.Enums;

namespace TheoDoiSXWeb.Model
{
    public class BaiInModel
    {
        public int Id { get; set; }
        public string TenBaiIn { get; set; }
        public string NguoiLamFile { get; set; }
        public string DienGiaiIn { get; set; }
        public int IdMayIn { get; set; }
        public string TenMayIn { get; set; }
        public string TenGiayIn { get; set; }
        public double ToChayRong { get; set; }
        public double ToChayDai { get; set; }
        public int SoLuongToChayCanIn { get; set; }
        public int SoLuongToChayBuHao { get; set; }
        public int SoMatIn { get; set; }
        public string MauIn { get; set; }
        public double SoClickCanIn { get; set; }
        public string DonViTinhClick { get; set; }

        public int MucUuTien { get; set; }
        public string DuongDanFileKhachHang { get; set; }
        public string DuongDanFileIn { get; set; }
        public string TinhTrangBaiIn { get; set; }
        public DateTime ThoiHanInXong { get; set; }
        public  int IdBaiSanPham { get; set; }

    }
}
