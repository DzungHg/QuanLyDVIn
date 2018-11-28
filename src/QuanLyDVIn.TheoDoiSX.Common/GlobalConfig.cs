using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyDVIn.TheoDoiSX.Common
{
    public static class GlobalConfig
    {
        
        /*public static void InitializeConnections()
        {
            SqlConnection sql = new SqlConnection();
        }*/
        //TODO: Xài config bị nul vì không đọc được Connection strings
        public static string CnnString(string name)
        {
            return "Data Source=115.79.54.225,1433\\SQL2014CAN;Database=QuanLyIn;Initial Catalog=QuanLyIn;User ID=sa;Password=Ca@sql@2017!;";
            //return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
