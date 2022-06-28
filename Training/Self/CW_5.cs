using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Self
{
    public delegate int mydel(int x,int y);
    public delegate int mydel2(int x);

    class CW_5
    {
        public static void sum(int x, int y)
        {
            Console.WriteLine("Addition =" + (x + y));
        }
        public static void sub(int x, int y)
        {

            Console.WriteLine("Subtraction= " + (x - y));
        }
        public static void product(int x, int y)
        {
            Console.WriteLine("Product =" + x * y);
        }
        

        static void greet(string msg)
        {
            Console.WriteLine("Good Morning "+msg);
        }

        static bool isEven(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
        }
        static long productx(int x, float y)
        {
            Console.WriteLine("Addition is = "+(x+y));
            return (int)(x + y);
        }

        static void Main(string[] args)
        {

            //mydel d1 = sum;
            //d1 = d1 + sub + product;
            //d1(5, 7);

            //mydel d3 = delegate (int x, int y)
            //  {

            //  };

            ////lAMBDA EXPRESSION
            //mydel d2 = (p, q) => Console.WriteLine("lambda "+(p+q));
            //d2(8, 4);

            mydel d5 = (a, b) =>
            {
                return a + b;
            };

            mydel d4 = (a, b) => a + b;
            Console.WriteLine("Addition = "+d4(10,20));


            // Anonymous Methods
            mydel2 d10= delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
                return 1;
            };

            d10(4);

            // Three Predfined Deligates are Func, Action, Predicate

            Func<int, float, long> f1 = productx;
            f1(6,8);

            Action<string> a1 = greet;
            a1("Mahesh");

            Predicate<int> p1 = isEven;
            Console.WriteLine(p1(15));

        }
    }
}
