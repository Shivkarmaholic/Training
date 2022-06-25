using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{

    class Product
    {
        public int pid;
        public string pname;
        public int pprice;

        public Product(int id, string name, int price)
        {
            pid = id;
            pname = name;
            pprice = price;
        }
        public Product(int id, string name)
        {
            pid = id;
            pname = name;
        }
        public Product(string name, int price)
        {
            pname = name;
            pprice = price;
        }
        public override string ToString()
        {
            return $"Product Id: {pid} Product Name: {pname} Product Price: {pprice}" +
                $"";
        }


    }

   
   
    class ProductOverload
    {
        static void Main(string[] args)
        {
            Product p = new Product(1, "bulb", 20);
            Product p2 = new Product("camera", 30);
            Product p3 = new Product(1, "fan");

            Product[] parr = new Product[5];

            parr[0] = new Product(1, "bulb", 20);
            parr[1] = new Product("camera", 30);
            parr[2] = new Product(1, "fan");
            parr[3] = new Product(2, "machine",30);



            Console.WriteLine(p.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
        }

        
    }
}
