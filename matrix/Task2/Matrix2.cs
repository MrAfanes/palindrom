using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Matrix2
    {
        public static int determinant2()
        {
            Console.WriteLine("Заполните матрицу 2х2");
            int[,] matrix = new int[2, 2];
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int det2 = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1,0];
            return det2;
        }
    }
}
