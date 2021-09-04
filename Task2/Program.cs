using System;


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество столбцов/строк от 1 до 3");
            int n = int.Parse(Console.ReadLine());
            if(n == 1)
            {
                Console.WriteLine("Введите число");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Определитель 1-го порядка - " + x);
            }
            else if(n == 2)
            {
                int x = Task2.Matrix2.determinant2();
                Console.WriteLine("Определитель 2-го порядка - " + x);
            }
            else if(n == 3)
            {
                int x = Task2.Matrix3.determinant3();
                Console.WriteLine("Определитель 3-го порядка - " + x);
            }
        }
    }
