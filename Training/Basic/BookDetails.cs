using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class Bookk
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Id { get; set; }

        public Bookk(int id, string name, string author, double price)
        {
            Price = price;
            Name = name;
            Author = author;
            Id = id;

        }


        public override string ToString()
        {
            return $"ID= {Id} , Name= {Name} , Author={Author} , Price = {Price}";
        }


    }

    class BookDetails
    {
        static void Main(string[] args)
        {
            Bookk b1 = new Bookk(1, "Titanic", "xyz", 100);


            string str = b1.ToString();
            System.Console.WriteLine(str);
        }
    }
        
}
