using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time(0, 0);
            Time time2 = new Time(0, 0);
            Time time3 = new Time(0, 0);

            time.addTime(125);
            time2.addTime(360);
            time3.addTime(76);


            /*time++;
            time2--;
            time3--;

            time = time + 5;
            time2 = time - 7;
            time3 = time - 7;
            time2 = time2 + 15;*/

            Console.WriteLine($"hours = {time.Hours}, minutes = {time.Minutes}");

            Console.WriteLine($"hours = {time2.Hours}, minutes = {time2.Minutes}");

            Console.WriteLine($"hours = {time3.Hours}, minutes = {time3.Minutes}");

            StaticTime.AddTime(125);
            Console.WriteLine($"static method: hours = {StaticTime.Hours}, minutes = {StaticTime.Minutes}");

            StaticTime.AddTime(125);
            Console.WriteLine($"static method: hours = {StaticTime.Hours}, minutes = {StaticTime.Minutes}");

            Console.WriteLine($"{Time.Count} created objects");
        }
    }




  
}
