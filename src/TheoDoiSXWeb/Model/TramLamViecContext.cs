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
    public class TramLamViecContext
    {
       TramLamViecLogic logic = new TramLamViecLogic();
       
        
        public List<TramLamViecModel> DocTatCa()
        {           
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TramLamViecBDO,TramLamViecModel>());
            var mapper = config.CreateMapper();
            List<TramLamViecModel>  nguon = mapper.Map<List<TramLamViecBDO>, List<TramLamViecModel>>(logic.DocTatCa());
            return nguon;
        }
       

        public TramLamViecModel DocTheoId(int idTramLamViec)
        {
            var objBDO = logic.DocTheoId(idTramLamViec);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<TramLamViecBDO, TramLamViecModel>());
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<TramLamViecModel>(objBDO);
            
            //Trả về
            return objModel;
        }

       

     

    }
}
