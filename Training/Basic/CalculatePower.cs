using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class CalculatePower
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the Base : ");
            int b, p, result = 1;
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Power : ");
            p = Convert.ToInt32(Console.ReadLine());

            for (int i = p; i > 0; i--)
            {
                result = result * b;
            }
            Console.WriteLine(result);
        }
    }
}
