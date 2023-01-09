using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attandance_App.ViewModels
{
    public class Multi
    {
        public int MultiAtnDetKy { get; set; }
        public int AtnDetKy { get; set; }

        public string InDtm { get; set; }

        public string OutDtm { get; set; }

        public double INLatitude { get; set; }

        public double INLongitude { get; set; }
        public double OutLatitude { get; set; }
        public double OutLongitude { get; set; }

        public Location1 Location1 { get; set; }

        public double TTlMint { get; set; }

    }

    public class Location1
    {
        public int CodeKey { get; set; }
        public string Code { get; set; }

        public string ConditionCode { get; set; }
        public string CodeName { get; set; }

        public string CodeNameOnly { get; set; }
        public Boolean IsDefault { get; set; }

        public int IsActive { get; set; }

        public int IsApproved { get; set; }
    }
}
