using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP which throws IndexOutOfRangeException. In the console,
//observe the stack trace and the line number from where the Exception is thrown

namespace Training
{
    class HW_2_10_OutOfRangeException
    {
        static void Main(string[] args)
        {
            
            try
            {
                int[] arr = { 00, 11, 22, 33, 44 };
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
