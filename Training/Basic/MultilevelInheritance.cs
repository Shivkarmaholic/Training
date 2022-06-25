using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class MultilevelInheritance
    {
        abstract class multiply
        {
            abstract public void mul();
        }

        interface Imath
        {
            void sum();
        }
        class Calculator : multiply, Imath
        {
            public override void mul()
            {
                Console.WriteLine("Mul function.");
            }
            public void sum()
            {
                Console.WriteLine("Sum Function.");
            }
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.sum();
            calculator.mul();
                    
        }
    }
}
