using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Time
    {
        public static int Count { get; private set; }

        public int Hours { get; private set; }
        public int Minutes { get; private set; }

        public Time(int Hours1, int Minutes1)
        {
            Hours = Hours1;
            Minutes = Minutes1;
            Count++;

        }

        public void addTime(int Minutes1)
        {
            Hours = Hours + Minutes1 / 60;
            Minutes = Minutes + Minutes1 - Minutes1 / 60 * 60;
            if (Minutes >= 60)
            {
                Hours++;
                Minutes = Minutes - 60;
            }

        }



        public static Time operator ++(Time time1)
        {
            time1.addTime(1);
            return time1;
        }

        public static Time operator --(Time time1)
        {
            time1.addTime(-1);
            return time1;
        }

        public static Time operator +(Time time1, int val)
        {
            time1.addTime(val);
            return time1;
        }

        public static Time operator -(Time time1, int val)
        {
            time1.addTime(-val);
            return time1;
        }
    }
}
