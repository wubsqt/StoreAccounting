using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.utility.Convertor
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar p = new PersianCalendar();
            return $"{p.GetYear(value)}/{p.GetMonth(value):00}/{p.GetDayOfMonth(value):00}";
        }

        public static string Timer(DateTime value)
        {
            return $"{value.Hour}:{value.Minute}:{value.Second}";
        }

        public static DateTime ToMiladi(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, new System.Globalization.PersianCalendar());
        }
    }
}
