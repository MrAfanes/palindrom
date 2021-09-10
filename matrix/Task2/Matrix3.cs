using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Matrix3
    {
        public static int determinant3()
        {
            Console.WriteLine("Заполните матрицу 3х3");
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                        matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int det3 = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] + matrix[1, 0] * matrix[2, 1] * matrix[0, 2] - matrix[0, 2] * matrix[1, 1] * matrix[2, 0] - matrix[0, 1] * matrix[1, 0] * matrix[2, 2] - matrix[2, 1] * matrix[1, 2] * matrix[0, 0];
            return det3;
        }
    }
}
