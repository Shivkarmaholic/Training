using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class MultiException
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 8, 6, 8, 6, 7 };
            try
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);

                }

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Index != arr.Length");
            }
            try
            {
                Console.WriteLine("Enter two Numbers : ");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Division = " + x / y);

            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Exception Occured : " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by Zero Exception : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Common Exception: " + e.Message);

            }
        }
    }
}
