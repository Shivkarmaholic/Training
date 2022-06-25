using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class CountDigit
    {
        static void Main(string[] args)
        {


            int num;
            System.Console.WriteLine("Enter the Digit");
            num = Convert.ToInt32(System.Console.ReadLine());
            int count = 0;
            for (int i = num; i > 0;)
            {
                if (num % 10 != 0)
                    count++;
                i = i / 10;
            }
            System.Console.WriteLine("The number of Digit = " + count);
        }
    }
}
