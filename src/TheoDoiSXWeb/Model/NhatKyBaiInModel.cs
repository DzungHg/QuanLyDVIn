using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoDoiSXWeb.Model
{
    public class NhatKyBaiInModel
    {
        public DateTime NgayNhatKy { get; set; }
        public string TenNhatKy { get; set; }
        public ThoInModel NguoiIn { get; set; }
        public MayInModel ChoMayIn { get; set; }
        /// <summary>
        /// Quan hệ 1:1 ở đây là Nhật ký in của bài in
        /// </summary>
        public BaiInModel ChoBaiIn { get; set; }
        public double TongSoClickChay { get; set; }
        public string DonViTinhClick { get; set; }

        public double GomSoClickThu { get; set; }
        public double GomSoClickHu { get; set; }
        public DateTime ThoiGianLapPhieu { get; set; }//lấy từ hệ thống
        public DateTime ThoiGianInXong { get; set; }
    }
}
