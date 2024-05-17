using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibRentStrumentTeam05.Data.Framework
{
    public static class Settings
    {
        public static string localConnection = GetConnectionString();
        public static string GetConnectionString()
        {
            string connectionString = "Trusted_Connection = True;";
            connectionString += "user id = sa;";
            connectionString += "Password = pxl;";
            connectionString += $@"Server=DESKTOP-P9CAQJ2\SQLEXPRESS2;";
            connectionString += $"Database=DB_Noviello_Luca";
            return connectionString;
        }

    }
}
