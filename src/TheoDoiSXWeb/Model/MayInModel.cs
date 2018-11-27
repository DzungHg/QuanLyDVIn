using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoDoiSXWeb.Model
{
    public class MayInModel
    {
        public int Id { get; set; }
        public string TenMayIn { get; set; }
        public string MaMayIn { get; set; }
        public string MaMayTenMay
        {
            get { return $"{this.MaMayIn} ({this.TenMayIn})"; }
        }
        public string MoTa { get; set; }
        public string DonViDemClick { get; set; } //A4, m2
        public bool NgungHoatDong { get; set; }
        public int ThuTuSapXep { get; set; }

        public MayInModel()
        {

        }
        public MayInModel(string tenMayIn, string maMayIn, string moTa, string donViDemClick,
            bool ngungHoatDong, int thuTuSapXep)
        {
            TenMayIn = tenMayIn;
            MaMayIn = maMayIn;
            MoTa = moTa;
            DonViDemClick = donViDemClick;
            NgungHoatDong = ngungHoatDong;          
            ThuTuSapXep = thuTuSapXep;

        }

    }
   
}
