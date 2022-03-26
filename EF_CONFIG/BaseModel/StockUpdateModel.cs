using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.BaseModel
{
    public class StockUpdateModel
    {
        public int StockID { get; set; }
        public string StockName { get; set; }
        public int DeviceID { get; set; }
        public int NeedleID { get; set; }
        public int CurrentQuantity { get; set; }
    }
}
