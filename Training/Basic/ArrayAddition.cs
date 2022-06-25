using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class ArrayAddition
    {
        static void Main(string[] args)
        {

            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] res = new int[3, 3];
            Console.WriteLine("Enter the First Array : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the Second Array : ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    res[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            Console.WriteLine("Result is : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + res[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
