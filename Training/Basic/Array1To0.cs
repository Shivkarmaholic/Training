using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class Array1To0
    {
        static void Main(string[] args)
        {
            int[] arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            foreach (int i in arr)
                Console.WriteLine(i);
            Console.WriteLine("After Converting :");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = 1;
                }

            }
            foreach (int i in arr)
                Console.WriteLine(i);
        }
    }
}
