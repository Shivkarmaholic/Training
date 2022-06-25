using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    
    class DemoReturnMultipleParameters
    {
        static void Main(string[] args)
        {
            static void Calculate(int a, int b, out int sum, out int sub, out int mul, out int div)
            {
                sum = a + b;
                sub = a - b;
                mul = a * b;
                div = a / b;
            }

            int a = 10;
            int b = 3;
            int sum, sub, mul, div;
            Calculate(a, b, out sum, out sub, out mul, out div);
            Console.WriteLine("sum= " + sum + "sub = " + sub + "mul = " + mul + "div =" + div);

        }
    }
}
