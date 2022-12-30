using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attandance_App.ViewModels
{
    public class Token
    {
        public int CompanyId { get; set; }
        public int UserKey { get; set; }
        public int EmpKy { get; set; }

        public int ShiftKy { get; set; }

        public double Latitude { get; set; }

        public string Longitude { get; set; }

        public LocationParam Location { get; set; }

        public int MultiAtnDetKy { get; set; }

        public int IsHoliday { get; set; }

        public int IsIn { get; set; }

        public int IsOut { get; set; }

        public int IsoutWithoutIn { get; set; }




    }

    public class LocationParam
    {

        public int CodeKey { get; set; }
        public string CodeName { get; set; }

    }
}
