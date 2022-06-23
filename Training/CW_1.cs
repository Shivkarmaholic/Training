using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class A
    {
        public A()
        {
            Console.WriteLine("Constructor A");
        }

        public A(int x)
        {
            Console.WriteLine("PConstructor A" + x);
        }

        static void Show()
        {
            Console.WriteLine("Static show method. ");
        }
        public virtual void Sum()
        {
            Console.WriteLine("Sum of A");
        }

    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("Constructor B");
        }

        public B(int x)
        {
            Console.WriteLine("PConstructor B" + x);
        }
        public void Calculate()
        {
            Console.WriteLine("B class Normal Calculate method");
        }
        public override void Sum()
        {
            Console.WriteLine("Sum Method of B");
        }
    }

    class C : B
    {
        public C()
        {
            Console.WriteLine("Constructor C");
        }

        //public C(int x)
        //{
        //    Console.WriteLine("PConstructor C"+x);
        //}

        public override void Sum()
        {
            Console.WriteLine("Sum Method of C");
        }
    }


    class CW_1
    {
        static void Main(string[] args)
        {
            A aa = new C();
            Console.WriteLine("1");
            A aa2 = new A(22);
            Console.WriteLine("2");
            B aa3 = new B(13);
            Console.WriteLine("3");
            B aa4 = new C();
            Console.WriteLine("4");
            C aa5 = new C();
            Console.WriteLine("5");
            B aa6 = new B(88);
            Console.WriteLine("6");
            Console.WriteLine("");
            Console.WriteLine("");

            aa.Sum();
            Console.WriteLine("");
            aa2.Sum();
            Console.WriteLine("");
            aa3.Sum();
            Console.WriteLine("");
            aa4.Sum();
            Console.WriteLine("");
            aa5.Sum();
            Console.WriteLine("");
            aa6.Sum();

        }

    }
}
