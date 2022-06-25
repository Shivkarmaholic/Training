using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class DemoStringBuilder
    {
        static void Main(string[] args)
        {

            StringBuilder str = new StringBuilder("Hello, ");
            Console.WriteLine("Original string : " + str);

            str.Append("Welcome Back Home");
            Console.WriteLine("After Appending : " + str);
            int slen = str.Length;
            Console.WriteLine("String Length : " + slen);
            str.Insert(slen, " Shivam.");
            Console.WriteLine("After Inserting Shivam :" + str);
            str.Remove(15, 4);
            Console.WriteLine("After removing back " + str);
            str.Replace("Home", "to Office");
            Console.WriteLine("After replacing home to office :" + str);

        }
    }
}
