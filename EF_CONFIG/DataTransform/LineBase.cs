using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;

namespace EF_CONFIG.DataTransform
{
    public class LineBase
    {
        public static NS_Lines Get_Line(int lineID)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Lines
                        .Where(i => i.LineID == lineID)
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
