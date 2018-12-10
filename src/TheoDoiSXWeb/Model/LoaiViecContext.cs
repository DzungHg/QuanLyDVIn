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
    public class LoaiViecContext
    {
       LoaiViecLogic logic = new LoaiViecLogic();
       
        
        public List<LoaiViecModel> DocTatCa()
        {           
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiViecBDO,LoaiViecModel>());
            var mapper = config.CreateMapper();
            List<LoaiViecModel>  nguon = mapper.Map<List<LoaiViecBDO>, List<LoaiViecModel>>(logic.DocTatCa());
            return nguon;
        }
       

        public LoaiViecModel DocTheoId(int idLoaiViec)
        {
            var objBDO = logic.DocTheoId(idLoaiViec);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiViecBDO, LoaiViecModel>());
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<LoaiViecModel>(objBDO);
            
            //Trả về
            return objModel;
        }

       

     

    }
}
