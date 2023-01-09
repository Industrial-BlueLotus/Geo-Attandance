
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attandance_App.ViewModels
{

    public class MultiNew
    {
        public int MultiAtnDetKy { get; set; }
        public int AtnDetKy { get; set; }
        public DateTime? InDtm { get; set; }
        public DateTime? OutDtm { get; set; }
        public float INLatitude { get; set; }
        public float INLongitude { get; set; }
        public float OutLatitude { get; set; }
        public float OutLongitude { get; set; }
        public LocationTe Location { get; set; }
        public float TTlMint { get; set; }
    }

    public class LocationTe
    {
        public int CodeKey { get; set; }
        public string Code { get; set; }
        public string ConditionCode { get; set; }
        public string CodeName { get; set; }
        public object CodeNameOnly { get; set; }
        public bool IsDefault { get; set; }
        public int IsActive { get; set; }
        public int IsApproved { get; set; }
        public object Latitude { get; internal set; }
        public object Longitude { get; internal set; }


    }
}