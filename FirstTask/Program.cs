using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        public static int Main(string[] args)
        {
            List<int> varNumbers = new List<int>();
            varNumbers = WritingToArray();

            List<int> evenNumbers = new List<int>();
            evenNumbers = EvenNumbers(varNumbers);

            List<int> oddNumbers = new List<int>();
            oddNumbers = OddNumbers(varNumbers);
            foreach(int count in varNumbers) { 
            Console.WriteLine(count);
            }
            foreach (int even in evenNumbers)
            {
                Console.WriteLine(even);
            }
            foreach (int odd in oddNumbers)
            {
                Console.WriteLine(odd);
            }

            return 0;
        }

        public static List<int> WritingToArray()
        {
            List<int> varNumbers = new List<int>();
            bool exit = false;
            while (!exit)
            {
                int i;
                string arrayElement = (Console.ReadLine());
                if (arrayElement == "exit")
                {
                    exit = true;
                    break;
                }
                bool result = int.TryParse(arrayElement, out i);
                if (result == true)
                {
                    varNumbers.Add(i);
                }
                else
                {
                    Console.WriteLine("Error");
                    break;
                }

            }
            return varNumbers;
        }

        public static List<int> EvenNumbers(List<int> even)
        {
            List<int> even1 = new List<int>();
            foreach(int count in even)
            {
                if(count % 2 == 0)
                {
                    even1.Add(count);
                }
            }
            return even1;
        }

        public static List<int> OddNumbers(List<int> odd)
        {
            List<int> odd1 = new List<int>();
            foreach (int count in odd)
            {
                if (count % 2 != 0)
                {
                    odd1.Add(count);
                }
            }
            return odd1;
        }

    }
}
