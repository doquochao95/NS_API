using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;
using EF_CONFIG.BaseModel;

namespace EF_CONFIG.DataTransform
{
    public static class BrokenReasonBase
    {
        public static List<NS_BrokenReason> Get_Reasons()
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_BrokenReason
                        .OrderBy(a => a.ReasonID)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static NS_BrokenReason Get_ReasonsbyID(int? id)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_BrokenReason
                        .Where(a => a.ReasonID == id)
                        .FirstOrDefault();
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
