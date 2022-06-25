using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class Copy2dArray
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the 2D Array of 3*3 : ");

            int[,] arr1 = new int[3, 4];
            int[,] arr2 = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Copying the Array to Array 2 : ");

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    arr2[i, k] = arr1[i, k];

                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.Write(" " + arr2[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
