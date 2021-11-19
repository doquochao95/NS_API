using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;

namespace EF_CONFIG.DataTransform
{
    public static class QuantityBase
    {
        public static List<NS_Export> Get_AllExports()
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Export
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_Export> Get_AllDayExports(DateTime dateTime)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Export
                        .Where(i=> DbFunctions.TruncateTime(i.ExportTime) == dateTime.Date)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_Export> Get_AllWeekExports(DateTime dateTime)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    DateTime startDayOfWeek = dateTime.AddDays(-1 * (int)(dateTime.DayOfWeek));
                    DateTime endDayOfWeek = dateTime.AddDays(7 - (int)dateTime.DayOfWeek);
                    return DataContext.NS_Export
                        .Where(i => i.ExportTime >= startDayOfWeek && i.ExportTime <= endDayOfWeek )
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_Export> Get_AllMonthExports(DateTime dateTime)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    DateTime startDayOfMonth = dateTime.AddDays(-1 * (int)(dateTime.DayOfWeek));
                    DateTime endDayOfMonth = dateTime.AddDays(7 - (int)dateTime.DayOfWeek);
                    return DataContext.NS_Export
                        .Where(i => i.ExportTime.Month == dateTime.Month)
                        .ToList();
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
