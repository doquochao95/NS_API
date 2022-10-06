using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;

namespace EF_CONFIG.BaseModel
{
    public class RecycleNeedleInBoxDataGridModel
    {
        public int SN { get; set; }
        public string Needle { get; set; }
        public string NeedleName { get; set; }
        public string Staffname { get; set; }
        public string LineName { get; set; }
        public string ExportTimeString { get; set; }
        public string PartEnough { get; set; }
    }
}
