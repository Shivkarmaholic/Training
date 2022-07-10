using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Training.Self
{
    class CW_6
    {
        static void m1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("M1"+i);
            }
        }

        static void m2()
        {
            for(int j=0; j < 10; j++)
            {
                Console.WriteLine("M222-"+j);
            }
        }

        static void m3()
        {
            for(int k=0; k < 10; k++)
            {
                Console.WriteLine("M33333-"+k);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Entering Main.");
            Thread t1 = new Thread(m1);
            t1.Start();
            Thread t2=new Thread(m2);
            t2.Start();
            Thread t3=new Thread(m3);
            t3.Start();
            Console.WriteLine(t1.IsAlive);
            Console.WriteLine(t2.IsAlive);
            Console.WriteLine(t3.IsAlive);
            Console.WriteLine("Main Ends");
        }
    }
}
