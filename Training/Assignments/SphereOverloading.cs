using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Sphere
    {
        double r, area;
        public double volume(double r)
        {
            return (4 / 3) * (22 / 7) * (r * r * r);
        }

        public double volume(double h, double r)
        {
            return (22 / 7) * (r * r) * h;
        }

        public double volume(double l, double b, double h)
        {
            return l * b * h;
        }
        
    }
    class SphereOverloading
    {

        static void Main(string[] args)
        {
            Sphere s1 = new Sphere();

            Console.WriteLine("Sphere    : "+ s1.volume(2.125)); 
            Console.WriteLine("Cylinder  : "+ s1.volume(21.22, 31.2114)) ;
            Console.WriteLine("Cuboid    : "+ s1.volume(2.3, 4.1, 9.5)); 
        }
    }
}