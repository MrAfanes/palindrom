using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    public static class StaticTime
    {
        public static int Hours { get; private set; }
        public static int Minutes { get; private set; }

        public static void AddTime(int minutes1)
        {
            Hours = Hours + minutes1 / 60;
            Minutes = Minutes + minutes1 - minutes1 / 60 * 60;
            if (Minutes >= 60)
            {
                Hours++;
                Minutes = Minutes - 60;
            }
        }
    }
}
