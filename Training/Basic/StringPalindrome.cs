using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class StringPalindrome
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string or number : ");
            string input= Console.ReadLine();
            bool iflag = true;
            int length=input.Length;

            for (int i=0; i<length/2; i++)
            {
                if (input[i] != input[length - (i + 1)])
                {
                    iflag = false;
                    break;
                }
            }
            if (iflag==false)
                Console.WriteLine("Input is Not Palindrome");
            else
                Console.WriteLine("Input is Palindrome");

        }
    }
}
