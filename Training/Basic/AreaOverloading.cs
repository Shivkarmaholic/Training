using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
   
    class AreaOverloading
    {
        public void Area(float x)
        {
            Console.WriteLine("the area of the square is " + (x * x) + " sq units");
        }
        public void Area(float x, float y)
        {
            Console.WriteLine("the area of the rectangle is " + (x * y) + " sq units");
        }
        public void Area(double x)
        {
            double z = 3.14 * x * x;
            Console.WriteLine("the area of the circle is " + z + " sq units");
        }


    }

    class Program
    {
        static void Main()
        {
            AreaOverloading ar = new AreaOverloading();
            ar.Area(5);
            ar.Area(11, 12);
            ar.Area(2.5);
        }
    }

}
