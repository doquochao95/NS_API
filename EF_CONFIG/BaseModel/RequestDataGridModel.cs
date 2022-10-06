using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;

namespace EF_CONFIG.BaseModel
{
    public class RequestDataGridModel
    {
        public int SN { get;set;}
        public NS_Requests NS_Requests { get; set; }

    }
}
