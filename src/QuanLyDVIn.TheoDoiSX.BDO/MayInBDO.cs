using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDVIn.TheoDoiSX.BDO
{
    public class MayInBDO
    {
        public int Id { get; set; }
        public string TenMayIn { get; set; }
        public string MaMayIn { get; set; }
        public string MoTa { get; set; }
        public string DonViDemClick { get; set; } //A4, m2
        public bool NgungHoatDong { get; set; }
        public int ThuTuSapXep { get; set; }
    }
}
