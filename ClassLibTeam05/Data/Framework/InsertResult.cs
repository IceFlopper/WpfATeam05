using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibRentStrumentTeam05.Data.Framework
{
    public class InsertResult : BaseResult
    {
        //NewId wordt teruggegeven door SQL Server
        public int NewId { get; set; }
    }
}
