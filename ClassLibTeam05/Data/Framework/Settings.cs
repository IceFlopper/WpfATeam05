using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibRentStrumentTeam05.Data.Framework
{
    public static class Settings
    {

        public static string GetConnectionString()
        {
            string connectionString = "Trusted_Connection = True;";
            connectionString += "user id = sa;";
            connectionString += "Password = pxl;";
            connectionString += $@"Server=5CG215060M\SQLEXPRESS2;";
            connectionString += $"Database=WPL2_G5";
            return connectionString;
        }

    }
}
