using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.BaseModel
{
    public class LogListViewModel
    {
        public DateTime? DateTime { get; set; }
        public string LogType { get; set; }
        public string Message { get; set; }
    }
}
