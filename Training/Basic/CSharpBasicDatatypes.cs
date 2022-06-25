using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class CSharpBasicDatatypes
    {
        static void Main(string[] args)
        {
            int a = 10;
            float b = 32.45f;
            char c = 'z';
            double d = 23.15;
            string s = "Mahesh";

            //***********Data Types**************

            Console.WriteLine("Value of a = " + a);
            Console.WriteLine("Value of b = " + b);
            Console.WriteLine($"Value of c = {c}");
            Console.WriteLine("Value of d = {0}", d);
            Console.WriteLine($"Name = {s} and Roll no is = {a}");

            //**************Calculation * ********

            a = 0;
            b = 0;
            int result;
            Console.WriteLine("Enter Number 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition = " + (a + b));
            Console.WriteLine("Substraction = " + (a - b));
            Console.WriteLine("Multiplication = " + a * b);
            Console.WriteLine("Division = " + a / b);

            //*******************18 + Age Checking * ******************

            
            Console.WriteLine("Enter age");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 18)
                Console.WriteLine("The Person is eligible for Voting");
            else
                Console.WriteLine("The Person is not eligible for Voting");
                    
        }
    }
}
