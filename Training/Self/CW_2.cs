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
     
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\n----------Queue Example------------\n\n");

            Queue q=new Queue();
            q.Enqueue(12);
            q.Enqueue(32);
            q.Enqueue("shivam");
            q.Enqueue(3.14f);
            q.Enqueue(true);
            Console.WriteLine("\n-------Queue After adding 5 Elements-------");
            foreach(var item in q)
            {
                System.Console.WriteLine(item);
            }
            Console.WriteLine("\ndequeue 1st element : "+ q.Dequeue());
            Console.WriteLine("dequeue 2nd element : "+ q.Dequeue());
            Console.WriteLine("\n-------after removing 2 elements--------");
            foreach (var item in q)
            {
                System.Console.WriteLine(item);
            }
            Console.WriteLine("Does Queue contain element 'shivam' : " + q.Contains("shivam"));
            Console.WriteLine("Queue contains "+q.Count+" Elements.");

            Console.WriteLine("\n\n\n\n----------Stack Example-----------\n\n");

            Stack stack = new Stack();
            stack.Push(34);
            stack.Push(62.5);
            stack.Push("shivam123");
            stack.Push(true);
            stack.Push("mahesh");

            Console.WriteLine("\n-----After adding 5 Elements in stack------");

            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Popping Element : "+stack.Pop());
            Console.WriteLine("Popping Element : " + stack.Pop());
            Console.WriteLine("\n-------After popping 2 Elements-------" );
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n\n\n----------List Example-----------\n\n");

            List<string> list = new List<string>();
            list.Add("shivam");
            list.Add("Mahesh");
            list.Add("Omkar");
            list.Add("Nagesh");
            list.Add("Natraj");
            Console.WriteLine("\n-----After Adding Staring Element----");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n------inserting Rudra in between Element------\n");
            list.Insert(3, "Rudra");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            list.Remove("Natraj");
            Console.WriteLine("\n------After Removing Natraj------");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(  "List Count : "+list.Count);
            Console.WriteLine("List Capacity : "+list.Capacity);


            Console.WriteLine("\n\n\n\n----------Array List Examaple--------------\n\n");
            ArrayList books = new ArrayList();
            books.Add("Good Vibes");
            books.Add("Love Story");
            books.Add("Life of Pi");
            books.Add("Honey Bunny");
            books.Add(20);
            books.Add(22.33);
            Console.WriteLine("\n-------After Adding Books-------");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            //Console.WriteLine("--------After Sorting Books-------");
            //books.Sort();
            //foreach (var book in books)
            //{
            //    Console.WriteLine(book);
            //}
            Console.WriteLine("\n----------After inserting book at 1st Postition----------");
            books.Insert(1, "Baby Sitting");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("\n----------------------");
            Console.WriteLine("Book Capacity : = "+ books.Capacity);
            Console.WriteLine("Book Count    : = " + books.Count);

            Console.WriteLine("\n--------After deleting 2nd element------");
            books.RemoveAt(2);
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }



        }
    }
}
