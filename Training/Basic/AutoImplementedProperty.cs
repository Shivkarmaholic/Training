using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class AutoImplementedProperty
    {

        class Course
        {
            public int cid { get; set; }
            public String cname { get; set; }
            public int fees { get; set; }

        }
        class Program
        {
            static void Main(string[] args)
            {

                Course[] c1 = new Course[5];
                Console.WriteLine("Enter 5 Course Details: ");
                for (int i = 0; i < 5; i++)
                {
                    c1[i] = new Course();
                    Console.WriteLine("Id : ");
                    c1[i].cid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Name : ");
                    c1[i].cname = Console.ReadLine();
                    Console.WriteLine("Fees : ");
                    c1[i].fees = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("The Courses are: ");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Id : " + c1[i].cid);
                    Console.WriteLine("Name : " + c1[i].cname);
                    Console.WriteLine("Fees : " + c1[i].fees);
                }
            }
        }
    }
}
