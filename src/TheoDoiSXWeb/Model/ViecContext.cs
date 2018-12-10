using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TheoDoiSX.BDO;
using QuanLyDVIn.TheoDoiSX.Logic;

using AutoMapper;

namespace TheoDoiSXWeb.Model
{
    public class ViecContext
    {
        /* Tình trạng bài in đê có thể lọc
        Moi,
        DangLamFile,
        SanSangIn,
        DangIn,
        HoanThanh,
        DeNghiHuy,
        Huy
        */
        ViecLogic logic = new ViecLogic();
       
        
        public List<ViecModel> DocTatCa()
        {           
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ViecBDO, ViecModel>());
            var mapper = config.CreateMapper();
            List<ViecModel>  nguon = mapper.Map<List<ViecBDO>, List<ViecModel>>(logic.DocTatCa());
            return nguon;
        }

        public List<ViecModel> DocTheoTinhTrang(int tinhTrang)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ViecBDO, ViecModel>());
            var mapper = config.CreateMapper();
            List<ViecModel> nguon = mapper.Map<List<ViecBDO>, List<ViecModel>>(logic.DocTheoTinhTrang(tinhTrang));
            return nguon;
        }
        public List<ViecModel> DocTheoGiaiDoan(int giaiDoan)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ViecBDO, ViecModel>());
            var mapper = config.CreateMapper();
            List<ViecModel> nguon = mapper.Map<List<ViecBDO>, List<ViecModel>>(logic.DocTheoGiaiDoan(giaiDoan));
            return nguon;
        }
        public ViecModel DocTheoId(int idViec)
        {
            var objBDO = logic.DocTheoId(idViec);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ViecBDO, ViecModel>()
                        );
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<ViecModel>(objBDO);
            
            //Trả về
            return objModel;
        }

        public void Sua(ViecModel mayInModel)
        {            

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ViecModel, ViecBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<ViecBDO>(mayInModel);
            logic.Sua(objBDO);
        }

        public void Them(ViecModel baiSP)
        {
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ViecModel, ViecBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map <ViecBDO>(baiSP);
            //Chuyển
            //ChuyenObjectDTOThanhObjectBDO(baiSP, objBDO);
            //Thêm
            if (objBDO != null)
            {
                logic.Them(objBDO); //Thành công Mapper được
            }
        }

        public void Xoa(int idViec)
        {
            logic.Xoa(idViec);
        }
        ///
        /// 
     

    }
  
}
