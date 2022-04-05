using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;
using EF_CONFIG.BaseModel;

namespace EF_CONFIG.DataTransform
{
    public static class NeedleBase
    {
        public static NS_Needles Get_Needles(int NeedleID) // get needles by id
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Needles.Find(NeedleID);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static NS_Needles Get_Needles(string NeedleName) // get needle by name
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Needles.Find(NeedleName);
                }
            }
            catch { return null; }
        }
        public static List<NS_Needles> Get_NeedlePoint(string NeedlePoint) //get needles have the same point
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Needles
                        .Where(i => i.NeedlePoint.Contains(NeedlePoint))
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_Needles> Get_NeedleSize(string NeedleSize) //get needles have the same size
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Needles
                        .Where(i => i.NeedleSize.Contains(NeedleSize))
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_Needles> Get_AllNeedle()
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Needles
                        .OrderBy(a => a.NeedleName)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<SimpleNeedleModel> Get_AllNeedlePickingFormModel(List<NS_Needles> nS_Needles)
        {
            try
            {
                List<SimpleNeedleModel> Models = new List<SimpleNeedleModel>();
                foreach (NS_Needles nS_Needle in nS_Needles)
                {
                    SimpleNeedleModel model = new SimpleNeedleModel()
                    {
                        NeedleID = nS_Needle.NeedleID,
                        NeedleName = nS_Needle.NeedleName
                    };
                    Models.Add(model);
                }
                return Models;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_Stocks> Get_StockNeedleChanged(int NeedleID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Stocks
                        .Where(i => i.NeedleID == NeedleID)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_Stocks> Get_LastStockOfNeedle(int NeedleID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Stocks
                        .Where(i => i.NeedleID == NeedleID)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static NS_Needles Get_NeedleByExportItem(NS_Export NS_Export)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Needles
                        .Where(i => i.NeedleID == NS_Export.NeedleID)
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static NS_Needles Get_NeedleByVotatilityDatagridModelItem(VotatilityDatagridModel item)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Needles
                        .Where(i => i.NeedleID == item.NS_Export.NeedleID)
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static bool Check_AvailableNeedleName(int needlename)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    var rfaccCount = DataContext.NS_Needles.Where(i => i.NeedleName == needlename).Count();
                    if (rfaccCount > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public static bool Add_NewNeedle(NS_Needles nS_Needles)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    DataContext.NS_Needles.Add(nS_Needles);
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

        public static bool Update_NeedleInformatio(NS_Needles model)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    var updateqty = DataContext.NS_Needles.First(i => i.NeedleID == model.NeedleID);
                    updateqty.NeedleName = model.NeedleName;
                    updateqty.NeedleCode = model.NeedleCode;
                    updateqty.NeedleSize = model.NeedleSize;
                    updateqty.NeedlePoint = model.NeedlePoint;
                    updateqty.NeedlePrice = model.NeedlePrice;
                    updateqty.NeedleLength = model.NeedleLength;
                    updateqty.PointTypeImage = model.PointTypeImage;
                    updateqty.RealityImage = model.RealityImage;
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
