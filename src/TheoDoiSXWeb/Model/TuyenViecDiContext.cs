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
    public class TuyenViecDiContext
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
        TuyenViecDiLogic logic = new TuyenViecDiLogic();
       
        
        public List<TuyenViecDiModel> DocTatCa()
        {           
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TuyenViecDiBDO, TuyenViecDiModel>());
            var mapper = config.CreateMapper();
            List<TuyenViecDiModel>  nguon = mapper.Map<List<TuyenViecDiBDO>, List<TuyenViecDiModel>>(logic.DocTatCa());
            return nguon;
        }

        
        public TuyenViecDiModel DocTheoId(int idTuyenViecDi)
        {
            var objBDO = logic.DocTheoId(idTuyenViecDi);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<TuyenViecDiBDO, TuyenViecDiModel>()
                        );
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<TuyenViecDiModel>(objBDO);
            
            //Trả về
            return objModel;
        }

        public void Sua(TuyenViecDiModel mayInModel)
        {            

            var config = new MapperConfiguration(cfg => cfg.CreateMap<TuyenViecDiModel, TuyenViecDiBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<TuyenViecDiBDO>(mayInModel);
            logic.Sua(objBDO);
        }

        public void Them(TuyenViecDiModel baiSP)
        {
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TuyenViecDiModel, TuyenViecDiBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map <TuyenViecDiBDO>(baiSP);
            //Chuyển
            //ChuyenObjectDTOThanhObjectBDO(baiSP, objBDO);
            //Thêm
            if (objBDO != null)
            {
                logic.Them(objBDO); //Thành công Mapper được
            }
        }

        public void Xoa(int idTuyenViecDi)
        {
            logic.Xoa(idTuyenViecDi);
        }
        ///
        /// 
     

    }
  
}
