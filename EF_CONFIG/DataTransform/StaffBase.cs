using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;

namespace EF_CONFIG.DataTransform
{
    public static class StaffBase
    {
        public static NS_Staffs Get_Staff(int? id)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Staffs.Find(id);
                }
            }
            catch { return null; }
        }
        public static NS_Staffs Get_Staffs(int? cardnumber)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Staffs
                        .Where(i => i.CardNumber == cardnumber)
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static List<NS_Staffs> Get_StaffName(string Name)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Staffs
                       .Where(i => i.StaffName.Contains(Name))
                       .ToList();
                }
            }
            catch { return null; }
        }
        public static NS_Staffs Check_User(string username, string pass)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Staffs
                        .Where(i => i.UserName == username && i.UserPassword == pass)
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static NS_Staffs Check_User(string rfidcode)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Staffs
                        .Where(i => i.RFIDCode == rfidcode)
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static NS_Staffs Get_StaffByExportItem(NS_Export NS_Export)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Staffs
                        .Where(i => i.StaffID == NS_Export.StaffID)
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static NS_Staffs Get_UserWithRfid(string rfidcode)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    return DataContext.NS_Staffs
                        .Where(i => i.RFIDCode == rfidcode)
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static bool Check_StaffWithCardNumber(int cardnumber)
        {
            try
            {
                using (NeedleSupplierDataContext DataContext = new NeedleSupplierDataContext())
                {
                    var count = DataContext.NS_Staffs
                        .Where(i => i.CardNumber == cardnumber).Count();
                    if (count > 0)
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
    }
}
