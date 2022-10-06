using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;

namespace EF_CONFIG.BaseModel
{
    public class NeedlePickingListtFormModel
    {
        public int NeedleID { get; set; }
        public int NeedleName { get; set; }
        public ICollection<NS_Stocks> NS_Stocks { get; set; }
        public int TotalQuantity { get; set; }


        /*  public NS_Stocks NS_Stocks { get;set;}
         public NS_Needles NS_Needles { get;set;}*/
    }
}
