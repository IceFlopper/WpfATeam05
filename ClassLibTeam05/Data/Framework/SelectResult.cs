﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibRentStrumentTeam05.Data.Framework
{
    public class SelectResult : BaseResult
    {
        public DataTable DataTable { get; set; }
    }
}
