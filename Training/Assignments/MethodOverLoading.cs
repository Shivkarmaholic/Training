using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Method Overloading by WAP to print area of cirle, area of square, area of rectangle

namespace Training
{
    class FindArea
    {
        public double Area(double x)
        {
            return 3.14*x*x;
        }
        public int Area(int x,int y)
        {
            return x * y;
        }
        public double Area(int x)
        {
            return x*x;
        }
    }

    class MethodOverLoading
    {
        
        static void Main(string[] args)
        {
            FindArea A1=new FindArea();
            ;
            Console.WriteLine(A1.Area(10));
            Console.WriteLine(A1.Area(10, 20));
            Console.WriteLine(A1.Area(20.30)); 
        }
    }
}
