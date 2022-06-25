using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class CountWords
    {
        static void Main(string[] args)
        {
            string str = "GeeksforGeeks A computer science portal A for A geeks ";
            string word = "A";
            int count = 0;
            Console.WriteLine("Sentence :" + str);
            Console.WriteLine("Word :" + word);

            string[] a = str.Split(' ');
            for (int i = 0; i < a.Length; i++)
            {

                if (word.Equals(a[i]))
                    count++;
            }
            Console.WriteLine("count = " + count);
        }
    }
}
