using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.BaseModel
{
    public class RecycleBinInformationModel
    {
        public int SN { get; set; }
        public int RecycleBoxID { get; set; }
        public string Line { get; set; }
        public int Needle { get; set; }
        public int WarehouseCode { get; set; }
        public DateTime ExportTime { get; set; }
        public string CompletedStatus { get; set; }
    }
}
