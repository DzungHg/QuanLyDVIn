using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDVIn.TheoDoiSX.BDO
{
    public class ViecBDO
    {
        public int Id { get; set; }       
        public string Ten { get; set; }
        public string DienGiai { get; set; }
        public string QuyCach { get; set; }
        public string GhiChu { get; set; }
        public string NhanXet { get; set; }
        public DateTime ThoiHan { get; set; }
        public int IdTuyenDi { get; set; }
        public int SoLuong { get; set; }
        public string DonViSoLuong { get; set; }
        public string MaLoaiViec { get; set; }
        public int IdNgoai { get; set; }
        public int TinhTrang { get; set; }
    }
}
