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
    public class MayInContext
    {
        MayInLogic logic = new MayInLogic();
       
        
        public List<MayInModel> DocTatCa()
        {           
            var config = new MapperConfiguration(cfg => cfg.CreateMap<MayInBDO, MayInModel>());
            var mapper = config.CreateMapper();
            List<MayInModel>  nguon = mapper.Map<List<MayInBDO>, List<MayInModel>>(logic.DocTatCa());
            return nguon;
        }
        public List<MayInModel> DocMayInConHoatDong()
        {
            return this.DocTatCa().Where(x => x.NgungHoatDong == false).OrderBy(x => x.ThuTuSapXep).ToList();
        }

        public MayInModel DocTheoId(int idMayIn)
        {
            var objBDO = logic.DocTheoId(idMayIn);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<MayInBDO, MayInModel>());
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<MayInModel>(objBDO);
            
            //Trả về
            return objModel;
        }

        public void Sua(MayInModel mayInModel)
        {            

            var config = new MapperConfiguration(cfg => cfg.CreateMap<MayInModel, MayInBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<MayInBDO>(mayInModel);
            logic.Sua(objBDO);
        }

        public void Them(MayInModel baiSP)
        {
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<MayInModel, MayInBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map <MayInBDO>(baiSP);
            //Chuyển
            //ChuyenObjectDTOThanhObjectBDO(baiSP, objBDO);
            //Thêm
            if (objBDO != null)
            {
                logic.Them(objBDO); //Thành công Mapper được
            }
        }

        public void Xoa(int idMayIn)
        {
            logic.Xoa(idMayIn);
        }
        ///
        /// 
     

    }
}
