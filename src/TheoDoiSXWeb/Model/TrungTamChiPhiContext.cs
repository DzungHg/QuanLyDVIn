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
    public class TrungTamChiPhiContext
    {
       TrungTamChiPhiLogic logic = new TrungTamChiPhiLogic();
       
        
        public List<TrungTamChiPhiModel> DocTatCa()
        {           
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TrungTamChiPhiBDO,TrungTamChiPhiModel>());
            var mapper = config.CreateMapper();
            List<TrungTamChiPhiModel>  nguon = mapper.Map<List<TrungTamChiPhiBDO>, List<TrungTamChiPhiModel>>(logic.DocTatCa());
            return nguon;
        }
       

        public TrungTamChiPhiModel DocTheoId(int idTrungTamChiPhi)
        {
            var objBDO = logic.DocTheoId(idTrungTamChiPhi);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<TrungTamChiPhiBDO, TrungTamChiPhiModel>());
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<TrungTamChiPhiModel>(objBDO);
            
            //Trả về
            return objModel;
        }

       

     

    }
}
