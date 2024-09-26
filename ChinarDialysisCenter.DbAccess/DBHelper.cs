using System.Data;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace ChinarDialysisCenter.DbAccess
{
    public class DBHelper
    {

        public static string GetConnectionString()
        {

            var MyConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string connectionString = MyConfig.GetValue<string>("ConnectionStrings:db_chinardialysis");
            return connectionString;
        }


    }
}

