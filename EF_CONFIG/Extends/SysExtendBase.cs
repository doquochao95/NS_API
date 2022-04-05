using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Model;
using EF_CONFIG.BaseModel;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;

namespace EF_CONFIG.Extends
{
    public static class SysExtendBase
    {
        public static DateTime FirstDayOfWeek(this DateTime datetime)
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var FormatedFirstDate = culture.DateTimeFormat.FirstDayOfWeek;

            if (FormatedFirstDate != DayOfWeek.Monday)
                FormatedFirstDate = DayOfWeek.Monday;

            var diff = datetime.DayOfWeek - FormatedFirstDate;

            if (diff < 0)
            {
                diff += 7;
            }

            return datetime.AddDays(-diff).Date;
        }
        public static DateTime LastDayOfWeek(this DateTime datetime) =>
        datetime.FirstDayOfWeek().AddDays(6);

        public static DateTime FirstDayOfMonth(this DateTime datetime) =>
            new DateTime(datetime.Year, datetime.Month, 1);

        public static DateTime LastDayOfMonth(this DateTime datetime) =>
            datetime.FirstDayOfMonth().AddMonths(1).AddDays(-1);

        public static DateTime FirstDayOfNextMonth(this DateTime datetime) =>
            datetime.FirstDayOfMonth().AddMonths(1);

        public static bool IsAvailable()
        {
            NeedleSupplierDataContext needleSupplierDataContext = new NeedleSupplierDataContext();
            using (SqlConnection connection = new SqlConnection(needleSupplierDataContext.Database.Connection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
