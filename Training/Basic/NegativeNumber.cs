using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class NegativeNumber
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the numbers in the array : ");
            int[] arr = new int[10];
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Negative Numbers are : ");
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                    Console.WriteLine(arr[i]);
                };
            }
            Console.WriteLine("Total negative numbers are : " + count);
        }
    }
}
