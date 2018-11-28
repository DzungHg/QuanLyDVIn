using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheoDoiSXWeb.Model;

namespace TheoDoiSXWeb.Pages
{
    public class IndexModel : PageModel
    {
        private BaiSanPhamContext _baiSanPhamContext;
        public IEnumerable<BaiSanPhamModel> BaiSanPhamS{get; set;}
        public IndexModel()
        {
            _baiSanPhamContext = new BaiSanPhamContext();
        }
        /* public async Task OnGet()
        {
            
        }*/
        public void OnGet()
        {
            this.BaiSanPhamS= _baiSanPhamContext.DocTatCa();
        }
    }
}
