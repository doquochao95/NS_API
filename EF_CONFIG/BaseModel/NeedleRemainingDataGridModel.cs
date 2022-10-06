using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;


namespace EF_CONFIG.BaseModel
{
    public class NeedleRemainingDataGridModel
    {
        public int SN { get; set; }
        public string StockName { get; set; }
        public string Needle { get; set; }
        public string NeedleName { get; set; }
        public int Quantity { get; set; }


    }
}
