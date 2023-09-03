using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class DateTimehelper
    {
        public static bool IsweekEnd(DateTime value)
        {
            return value.DayOfWeek== DayOfWeek.Friday || value.DayOfWeek== DayOfWeek.Saturday;
        }
        public static bool IsweekDay(DateTime value)
        {
            return !(IsweekEnd(value));
        }

    }
}
