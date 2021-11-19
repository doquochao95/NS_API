using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;

namespace EF_CONFIG.BaseModel
{
    public class VotatilityDatagridModel
    {
        public int SN { get;set;}
        public NS_Export NS_Export { get; set;}
        public NS_Buildings NS_Buildings { get; set;}
        public NS_Devices NS_Devices { get; set;}
        public NS_Needles NS_Needles { get; set;}
        public NS_Staffs NS_Staffs { get; set;}

    }
}
