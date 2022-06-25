using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class AvgOf5Subject
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter five Subjects Marks:");

            //int s1, s2, s3, s4, s5;

            int[] sub = { 0, 0, 0, 0, 0 };
            int total = 0, avg;

            //s1 = Convert.ToInt32(Console.ReadLine());
            //s2 = Convert.ToInt32(Console.ReadLine());
            //s3 = Convert.ToInt32(Console.ReadLine());
            //s4 = Convert.ToInt32(Console.ReadLine());
            //s5 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                sub[i] = Convert.ToInt32(Console.ReadLine());
                total = total + sub[i];
            }
            avg = total / 5;
            Console.WriteLine($"Total Marks = {total} Average Marks= {avg}");

        }
    }
}
