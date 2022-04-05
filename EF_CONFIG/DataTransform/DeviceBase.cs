using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;
using EF_CONFIG.BaseModel;

namespace EF_CONFIG.DataTransform
{
    public static class DeviceBase
    {
        public static NS_Devices Get_DeviceWithDeviceId(int deviceid)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Devices
                        .Where(i => i.DeviceID == deviceid)
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static bool Update_OnlineStatus(int deviceid, string status)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    var updateqty = DataContext.NS_Devices.First(i => i.DeviceID == deviceid);
                    updateqty.OnlineStatus = status;
                    DataContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}
