using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{

    public class NameException : Exception
    {
        public NameException(string message) : base(message)
        {
            Console.WriteLine("Name Exception Occured : Handle It.");
        }
    }

    public class User
    {
        public void AcceptName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameException("Empty Name.");

            }
            else
            {
                Console.WriteLine($"Your Name is {name}");
            }
        }
    }
    
    class DemoNullException
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            try
            {
                string str = Console.ReadLine();
                user1.AcceptName(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }

}
