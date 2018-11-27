using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace QuanLyDVIn.TheoDoiSX.Common
{
    public static class GlobalConfig
    {
        
       /* public static void InitializeConnections()
        {
            SqlConnection sql = new SqlConnection();
        }*/
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
