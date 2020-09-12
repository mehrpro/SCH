using System;
using System.Globalization;

namespace SchoolApp
{
    public static class PersianClass
    {
        public static string ConvertDateToPersian(this DateTime dateTime)
        {
            var pc = new PersianCalendar();
            var years = pc.GetYear(dateTime);
            var month = pc.GetMonth(dateTime);
            var day = pc.GetDayOfMonth(dateTime);
            return $"{years}/{month}/{day}";

        }
    }
}
