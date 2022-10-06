using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;
using EF_CONFIG.BaseModel;

namespace EF_CONFIG.DataTransform
{
    public class LogBase
    {
        public static List<LogEvent> Get_AllLogEvent(int deviceID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.LogEvents
                        .Where(i => i.DeviceID == deviceID.ToString())
                        .OrderBy(a => a.LogId)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static LogEvent Get_MostRecentLogEvent(int deviceID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.LogEvents
                        .Where((i) => i.DeviceID == deviceID.ToString())
                        .OrderByDescending(a => a.LogId)
                        .First();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
