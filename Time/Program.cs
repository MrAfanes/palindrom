using System;

namespace Time
{
    class Time
    {

        //static int hours = 0;
        //static int minutes = 0;
        static void Main(string[] args)
        {
            int hours = 0;
            int minutes = 0;
            Time time = new Time(hours, minutes);
            time.setTime();
            time.getTime();
        }


        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }
        public void setTime()
        {
            Console.WriteLine("Введите колличество часов");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите колличество минут");
            int m = int.Parse(Console.ReadLine());
            h = h + hours;
            m = m + minutes;
            if(m > 59)
            {
                hours++;
                minutes = m - 59;
            }
        }
        public int getTime()
        {
            return 0;
        }
    }
}
