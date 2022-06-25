using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class _2dArrayRotate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array for Rotation : ");
            int[,] arr1 = new int[3, 5];
            int[,] arr2 = new int[5, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Copy the Array 

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr2[j, i] = arr1[i, j];
                }
            }


            Console.WriteLine("The Rotated Array = ");
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(" " + arr2[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
