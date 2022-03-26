using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;
using EF_CONFIG.BaseModel;
using System.Collections.ObjectModel;

namespace EF_CONFIG.DataTransform
{
    public static class StockBase
    {
        public static List<NS_Stocks> Get_NeedleQtyInStock()
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Stocks
                        .Where(i => i.CurrentQuantity > 0)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_Stocks> Get_NeedleQtyInStockWithDeviceID(int deviceid)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Stocks
                        .Where(i => i.CurrentQuantity > 0 && i.DeviceID == deviceid)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_Stocks> Get_AllNeedleInStockWithDeviceID(int deviceid)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Stocks
                        .Where(i => i.DeviceID == deviceid)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static bool Update_Stock(int stockid, int deviceid, int quantity)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    var updateqty = DataContext.NS_Stocks.First(i => i.StockID == stockid && i.DeviceID == deviceid);
                    updateqty.CurrentQuantity = quantity;
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
        public static bool Update_StockQuantity(ObservableCollection<NS_Stocks> model)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    ObservableCollection<NS_Stocks> stockUpdateModel;
                    stockUpdateModel = model;
                    foreach (var item in stockUpdateModel)
                    {
                        var updateqty = DataContext.NS_Stocks.First(i => i.StockID == item.StockID && i.DeviceID == item.DeviceID);
                        updateqty.NeedleID = item.NeedleID;
                        updateqty.CurrentQuantity = item.CurrentQuantity;
                        DataContext.SaveChanges();
                    }
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
