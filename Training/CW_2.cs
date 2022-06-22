using System ;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    
    class CW_2
    {
        class Book
        {
            ArrayList books = new ArrayList();
        }

        static void Main(string[] args)
        {
            
            books.Add("Good Vibes");
            books.Add("Love Story");
            books.Add("Life of Pi");
            books.Add("Honey Bunny");
            
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

        }
    }
}
