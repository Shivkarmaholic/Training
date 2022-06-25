//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Training.Basic
//{
//    class CountCoPrime
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello Started Program. ");
//            int a = int.Parse(Console.ReadLine());
//            int c = 0;
//            int t = 0;
//            for (int n = 1; n <= a; n++)
//            {
//                for (int divisor = 1; divisor <= n; divisor++)
//                    if (a % divisor == 0 && n % divisor == 0)
//                        c++;

//                if (c == 1)
//                    Console.WriteLine(n);
//            }
//        }
//    }
//}
