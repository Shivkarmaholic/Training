using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class NamesSortDesc
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Original array");
            string[] strArray = new string[] { "Mahesh", "Darshan", "Ashish", "Johny", "Apurva",
            "Aditya","Kailash","Danesh","Shrinivas","Snehal" };

            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

            Array.Sort(strArray);
            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            Array.Reverse(strArray);
            foreach (string str in strArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
    }
}
