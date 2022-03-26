using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;
using EF_CONFIG.BaseModel;

namespace EF_CONFIG.DataTransform
{
    public static class ImportBase
    {
        public static bool Add_NewImport(List<NS_Imports> model)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    foreach (var item in model)
                    {
                        DataContext.NS_Imports.Add(item);
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