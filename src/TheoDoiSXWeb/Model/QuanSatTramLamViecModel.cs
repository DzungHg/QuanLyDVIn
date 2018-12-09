using System;
using System.Collections.Generic;
using System.Text;

namespace TheoDoiSXWeb.Model
{
    public class QuanSatTramLamViecModel
    {
        public int Id { get; set; }
        public string MaTramLamViec { get; set; }
        public int IdViec { get; set; }
        public int IdNguoiThucHien { get; set; }
        public string Ten { get; set; }
        public DateTime ThoiGianVo { get; set; }
        public DateTime ThoiGianNhan { get; set; }
        public DateTime BatDauLam { get; set; }
        public DateTime ThoiGianHoanThanh { get; set; }
        public int SoLuongVo { get; set; }
        public int DonViSoLuongVo { get; set; }
        public int SoLuongVoDaLam { get; set; }
        public int SoLuongVoConLai { get; set; }
        public int SoLuongRa { get; set; }
        public int DonViSoLuongRa { get; set; }
        public int TinhTrang { get; set; }
        public int GhiChuVo { get; set; }
        public int GhiChuRa { get; set; }
    }
}
