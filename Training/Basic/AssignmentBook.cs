using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{

    class Book
    {
        public int b_id;
        public string b_name = "";
        public string b_author = "";
        public int b_price;


        public int getData()
        {
            Console.WriteLine("Enter the Id : ");
            b_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Book Name : ");
            b_name = Console.ReadLine();
            Console.WriteLine("Enter the Author Name : ");
            b_author = Console.ReadLine();
            Console.WriteLine("Enter the Book Price : ");
            b_price = Convert.ToInt32(Console.ReadLine());
            return 0;
        }
        public void printData()
        {
            Console.WriteLine("Id := " + b_id);
            Console.WriteLine("Name := " + b_name);
            Console.WriteLine("Author := " + b_author);
            Console.WriteLine("Price:= " + b_price);
        }
    }

    class AssignmentBook
    {
        static void Main()
        {
            Book[] b = new Book[5];


            for (int i = 0; i < b.Length; i++)
            {
                b[i] = new Book();
                b[i].getData();
            }
            Console.WriteLine("");
            foreach (Book b1 in b)
            {
                Console.WriteLine("");
                b1.printData();
                if (b1.b_price < 500)
                {
                    Console.WriteLine("This book is under 500 Rs.");
                }
            }

        }
    }
    
}
