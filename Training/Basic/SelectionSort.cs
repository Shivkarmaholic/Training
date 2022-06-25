using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort :");
            int[] arr = new int[6] { 12, 45, 98, 21, 35, 74 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("");
            for (int i = 0; i < arr.Length; i++)
            {
                int index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[index] > arr[j])
                    {
                        int temp = arr[index];
                        arr[index] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
        }
    }
}
