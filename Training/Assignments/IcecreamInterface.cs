using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{

    interface IIcecream
    {
        public void eat();
    }
    interface IJuice
    {
        public void drink();
    }

    class Mastani : IIcecream, IJuice
    {
        public void eat()
        {
            Console.WriteLine("Am Eating Mastani");
        }
        public void drink()
        {
            Console.WriteLine("Am Drinking Mastani");
        }
    }
    class IcecreamInterface
    {
        static void Main(string[] args)
        {
            Mastani m1 = new Mastani();
            m1.eat();
            m1.drink();
        }
    }
}
