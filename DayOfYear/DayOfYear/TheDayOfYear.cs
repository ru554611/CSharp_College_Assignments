using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfYear
{
    public class TheDayOfYear
    {
        public int CalculateDayOfYear(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            int x = dt.DayOfYear;
            return x;
        }
    }
}
