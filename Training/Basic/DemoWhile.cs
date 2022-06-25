using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class DemoWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0, sum = 0, rem;

            while (num > 0)
            {
                rem = num % 10;
                count++;
                if (count % 2 == 1)
                {
                    sum = sum + rem;
                }
                num = num / 10;

            }
            if (count == 3)
            {
                Console.WriteLine("The number is 3 Digit Number ");
                Console.WriteLine("Sum of 1st and 3rd digit is = " + sum);
            }
            else
                Console.WriteLine("The number is not 3 digit. ");

        }
    }
}
