using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class DateTimeExtentions
    {
        public static bool IsweekEnd(this DateTime value)
        {
            return value.DayOfWeek== DayOfWeek.Friday || value.DayOfWeek== DayOfWeek.Saturday;
        }
        public static bool IsweekDay(this DateTime value)
        {
            return !(IsweekEnd(value));
        }

    }
}
