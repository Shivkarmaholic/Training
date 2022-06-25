using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class DemoStringFunction
    {
        static void Main(string[] args)
        {

            string str1 = "Hello Team ";
            string str2 = "How are you";

            Console.WriteLine("str1 : " + str1);
            Console.WriteLine("str2 : " + str2);

            Console.WriteLine("str1 Length = " + str1.Length);
            Console.WriteLine("Str2 Length = " + str2.Length);

            Console.WriteLine("str1 to Lower Case : " + str1.ToLower());
            Console.WriteLine("str2 to Upper Case : " + str2.ToUpper());

            Console.WriteLine("str1 Index of 'T' " + str1.IndexOf('T'));

            Console.WriteLine("Str1 and str2 Concat : " + string.Concat(str1, str2));

            Console.WriteLine("str1 substring : " + str1.Substring(4));
        }
    }
}
