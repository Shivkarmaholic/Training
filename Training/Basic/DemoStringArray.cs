using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class DemoStringArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 Names : ");
            string[] name = new string[5];
            string[] list = new string[5];
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = Console.ReadLine();
            }
            Console.WriteLine("");

            Console.WriteLine("Entered Names are : ");

            //    for(int i=0;i<name.Length;i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            foreach (string i in name)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            Array.Reverse(name);
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }
            Array.Sort(name);
            Console.WriteLine("");
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }
            Array.Clear(name, 2, 3);
            Console.WriteLine("");
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Array.Copy(name, 1, list, 1, 2);
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");
        }
    }
}
