using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;
using EF_CONFIG.BaseModel;

namespace EF_CONFIG.DataTransform
{
    public static class RequestBase
    {
        public static List<NS_Requests> Get_AllRequestsByDeviceIdQtyEqual1(int DeviceID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Requests
                        .Where(i => i.DeviceID == DeviceID && i.Quantity == 1)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_Requests> Get_AllRequestsByDeviceIdQtyEqual0(int DeviceID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Requests
                        .Where(i => i.DeviceID == DeviceID && i.Quantity == 0)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_Requests> Get_AllRequestsByDeviceId(int DeviceID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Requests
                        .Where(i => i.DeviceID == DeviceID)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static bool Add_NewRequest(NS_Requests request)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    DataContext.NS_Requests.Add(request);
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
        public static bool Delete_Request(int requestID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    var deleterequest = DataContext.NS_Requests
                        .Where(i => i.RequestID == requestID)
                        .FirstOrDefault();
                    DataContext.NS_Requests.Remove(deleterequest);
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
        public static bool Update_RequestQuantityDecrease1(int requestid)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    var newrequest = DataContext.NS_Requests.Where(i => i.RequestID == requestid).FirstOrDefault();
                    newrequest.Quantity--;
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
