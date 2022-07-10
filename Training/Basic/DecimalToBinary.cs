using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a Decimal Number : ");
            int n=Convert.ToInt32(Console.ReadLine());
            int []arr=new int[10];
            for (i=0; n>0; i++)
            {
                arr[i] = n % 2;
                n = n / 2;
            }
            
            for(i=i-1; i>=0; i--)
            Console.Write(arr[i]);

        }
    }
}
