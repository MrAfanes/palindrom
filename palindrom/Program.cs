using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            word1 = word1.ToLower();
            char[] delSymbol = new char[] {' ', ',', ':', ';', '!', '.', '?', '`', '*'};
            string replaced = word1;
            for(int i = 0; i < delSymbol.Length; i++)
            {
                string y = delSymbol[i].ToString();
                replaced = replaced?.Replace(y, "");
            }
            char[] a = replaced.ToCharArray();
            Array.Reverse(a);
            string word2 = new string(a);
            if (replaced == word2)
            {
                Console.WriteLine("Слово/предложение " + word1 + " - палиндром");
            }
            else Console.WriteLine("Слово " + word1 + " - не палиндром");
        }
    }
}
