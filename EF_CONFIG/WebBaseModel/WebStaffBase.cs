using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;

namespace EF_CONFIG.WebBaseModel
{
    public class WebStaffBase
    {
        private readonly NeedleSupplierDataContext _datacontext;
        public WebStaffBase(NeedleSupplierDataContext context)
        {
            _datacontext = context;
        }
        public NS_Staffs Get_Staff(int? id)
        {
            try
            {
                return _datacontext.NS_Staffs.Find(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null; 
            }
        }

    }
}



