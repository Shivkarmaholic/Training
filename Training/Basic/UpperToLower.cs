using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class UpperToLower
    {
        static void Main(string[] args)
        {

            string str;
            str = "India is my Country.";
            Console.WriteLine("String : " + str.ToUpper());
            Console.WriteLine("Converted to LowerCase : {0}", str.ToLower());

        }
    }
}
