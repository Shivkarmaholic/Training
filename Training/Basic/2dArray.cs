using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class _2dArray
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the 4*5 dimensional Array Data : ");
            int[,] arr = new int[4, 5];

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(" " + arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
