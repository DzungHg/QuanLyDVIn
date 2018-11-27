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
    public class BaiInContext
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
        BaiInLogic logic = new BaiInLogic();
       
        
        public List<BaiInModel> DocTatCa()
        {           
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BaiInBDO, BaiInModel>());
            var mapper = config.CreateMapper();
            List<BaiInModel>  nguon = mapper.Map<List<BaiInBDO>, List<BaiInModel>>(logic.DocTatCa());
            return nguon;
        }

        public List<BaiInModel> DocTheoTinhTrang(string tinhTrang)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BaiInBDO, BaiInModel>());
            var mapper = config.CreateMapper();
            List<BaiInModel> nguon = mapper.Map<List<BaiInBDO>, List<BaiInModel>>(logic.DocTheoTinhTrang(tinhTrang));
            return nguon;
        }
        public BaiInModel DocTheoId(int idBaiIn)
        {
            var objBDO = logic.DocTheoId(idBaiIn);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BaiInBDO, BaiInModel>()
                        );
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<BaiInModel>(objBDO);
            
            //Trả về
            return objModel;
        }

        public void Sua(BaiInModel mayInModel)
        {            

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BaiInModel, BaiInBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<BaiInBDO>(mayInModel);
            logic.Sua(objBDO);
        }

        public void Them(BaiInModel baiSP)
        {
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BaiInModel, BaiInBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map <BaiInBDO>(baiSP);
            //Chuyển
            //ChuyenObjectDTOThanhObjectBDO(baiSP, objBDO);
            //Thêm
            if (objBDO != null)
            {
                logic.Them(objBDO); //Thành công Mapper được
            }
        }

        public void Xoa(int idBaiIn)
        {
            logic.Xoa(idBaiIn);
        }
        ///
        /// 
     

    }
  
}
