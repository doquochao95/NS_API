using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;
using EF_CONFIG.BaseModel;

namespace EF_CONFIG.DataTransform
{
    public static class RecycledBoxBase
    {

        public static bool Add_NewRecycle(NS_RecycledBox model)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    DataContext.NS_RecycledBox.Add(model);
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
        public static List<NS_RecycledBox> Get_AllRecycleBinAvailable()
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_RecycledBox
                        .Where(i => i.InBox == 1)
                        .OrderBy(a => a.RecycleBoxID)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_RecycledBox> Get_AllRecycleBinAvailable(int deviceID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_RecycledBox
                        .Where(i => i.InBox == 1 && i.DeviceID == deviceID)
                        .OrderBy(a => a.RecycleBoxID)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_RecycledBox> Get_AllRecycleBinUnavailable(int deviceID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_RecycledBox
                        .Where(i => i.InBox == 0 && i.DeviceID == deviceID)
                        .OrderBy(a => a.RecycleBoxID)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static NS_RecycledBox Get_MostRecentRecycleBox()
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_RecycledBox
                        .OrderByDescending(a => a.RecycleBoxID)
                        .First();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static bool Update_RecycleBinRemoveFromBox(int recycleboxID, int staffID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    var updateqty = DataContext.NS_RecycledBox.First(i => i.RecycleBoxID == recycleboxID);
                    updateqty.InBox = 0;
                    updateqty.DeleteByStaffID = staffID;
                    updateqty.DeleteTime = DateTime.Now;
                    updateqty.DeleteTimeStr = DateTime.Now.ToString("HH: mm, dd / MM / yyyy");
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
        public static bool Update_RecycleBin(NS_RecycledBox recyclebox)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    var updateqty = DataContext.NS_RecycledBox.First(i => i.RecycleBoxID == recyclebox.RecycleBoxID);
                    updateqty.SewingMachine = recyclebox.SewingMachine;
                    updateqty.ProcessID = recyclebox.ProcessID;
                    updateqty.ReasonID = recyclebox.ReasonID;
                    updateqty.Operator = recyclebox.Operator;
                    updateqty.PO = recyclebox.PO;
                    updateqty.Handle = recyclebox.Handle;
                    updateqty.BrokenTime = recyclebox.BrokenTime;
                    updateqty.BrokenTimeStr = recyclebox.BrokenTimeStr;
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
        public static NS_RecycledBox Get_RecylcleBox(int recycleboxID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_RecycledBox
                        .Where(a => a.RecycleBoxID == recycleboxID)
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static bool Update_RecycleBinConfirmation(int recyclebinID, int staffID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    DateTime now = DateTime.Now;
                    var updateqty = DataContext.NS_RecycledBox.First(i => i.RecycleBoxID == recyclebinID);
                    updateqty.ConfirmationByStaffID = staffID;
                    updateqty.ConfirmationTime = now;
                    updateqty.ConfirmationTimeStr = now.ToString("HH: mm, dd / MM / yyyy");
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
        public static bool Update_RecycleBinCapturedImage(int recyclebinID, byte[] image, decimal lengh, int enoughpart)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    var updateqty = DataContext.NS_RecycledBox.First(i => i.RecycleBoxID == recyclebinID);
                    updateqty.RecycleNeedleImage = image;
                    updateqty.CapturedLength = lengh;
                    updateqty.NeedlePartsEnough = enoughpart;
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