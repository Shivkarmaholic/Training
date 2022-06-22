using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class MyException:ApplicationException
    {
        public MyException()
        {

        }
        public MyException(string msg)
        {
            Console.WriteLine("Exception Generated. ");
        }
    }
    class HW_2_12_CustomException
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (x % 2 == 0)
                {
                    throw new MyException("Enter Odd Numbers.");
                }
                else
                    Console.WriteLine("The Number is Correct Odd Number.");
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }
        
    }
}
