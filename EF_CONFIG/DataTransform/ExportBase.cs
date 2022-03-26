using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;
using EF_CONFIG.BaseModel;

namespace EF_CONFIG.DataTransform
{
    public static class ExportBase
    {
        public static bool Add_NewExport(List<NS_Export> model)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    foreach (var item in model)
                    {
                        DataContext.NS_Export.Add(item);
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
        public static bool Add_NewExport(NS_Export model)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    DataContext.NS_Export.Add(model);
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
