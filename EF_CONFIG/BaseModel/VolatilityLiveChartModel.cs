using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.BaseModel
{
    public class VolatilityLiveChartModel
    {
        public string BuildingName { get; set;}
        public string DeviceName { get; set;}
        public DateTime DateTime { get; set;}
        public int Quantity { get;set;}
    }
}
