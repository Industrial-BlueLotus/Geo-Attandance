﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attandance_App.ViewModels
{
    public class DateToken
    {
        public int EmpKy { get; set; }

        public int CompanyId { get; set; }

        public DateTime FDT { get; set; }

        public DateTime TDT { get; set; }

        public int Chk { get; set; }

        public int PrjKy { get; set; }

        public int TaskKy { get; set; }
    }
}
