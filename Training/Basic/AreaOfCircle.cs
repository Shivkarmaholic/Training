using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class AreaOfCircle
    {
        static void Main(string[] args)
        {
            double radius;
            Console.WriteLine("Enter the Radius");
            radius = Convert.ToInt32(Console.ReadLine());
            double area = 2.14 * radius * radius;
            System.Console.WriteLine("Area of Circle = " + area);
        }

    }
}
