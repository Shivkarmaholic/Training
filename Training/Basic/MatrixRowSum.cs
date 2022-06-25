using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class MatrixRowSum
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Console.WriteLine("Enter the 3*3 Array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("***********************");
            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum = sum + arr[i, j];
                    if (j == 2)
                    {
                        Console.WriteLine("Sum of " + i + " th row =" + sum);
                    }
                }

            }



            int[,] arr1 = new int[3, 3];
            Console.WriteLine("Enter the 3*3 Array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int max = 0;
            Console.WriteLine("***********************");
            for (int i = 0; i < 3; i++)
            {
                max = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (max < arr1[i, j])
                    {
                        max = arr1[i, j];
                    }
                    if (j == 2)
                        Console.WriteLine("Max of " + i + " th Row =" + max);
                }

            }
        }
    }
}
