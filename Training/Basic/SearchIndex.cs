using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class SearchIndex
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];

            Console.WriteLine("Enter 10 Numbers : ");
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number to find in the list : ");

            int key = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (key == arr[i])
                {
                    Console.WriteLine("Number found at " + (i + 1) + " Position");
                }
                else
                {
                    Console.WriteLine("Key not Found.");
                }
            }




        }
    }
}
