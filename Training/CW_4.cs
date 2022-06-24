using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Training
{
    class Stud:IComparable<Stud>
    {
        int id;
        string name;
        int per;

        public Stud(int id,string name,int per)
        {
            this.id = id;
            this.name = name;
            this.per = per;
        }
        public override string ToString()
        {
            return $"Id := {id},  Name := {name}, Percentage := {per}";
        }

        public int CompareTo(Stud s)
        {
            return s.id.CompareTo(id);
        }
    }

    //To create your Own Sorting Login for String Builder Class
    //Stringbuilder class do not have icomparable interface. it has icomparer interface
    class mysorted : IComparer<StringBuilder>
    {
        public int Compare(StringBuilder s1, StringBuilder s2)
        {
            return s1.ToString().CompareTo(s2.ToString());
        }
    }

    class CW_4
    {
        static void Main(string[] args)
        {
            List<Stud> s1 = new List<Stud>();
            s1.Add(new Stud(12, "Mahesh", 89));
            s1.Add(new Stud(14, "Somnath", 92));
            s1.Add(new Stud(17, "Onkar", 95));
            s1.Add(new Stud(18, "Ajinkya", 90));
            
            s1.Sort();
            foreach (Stud s in s1)
            {
                Console.WriteLine(s);
            }

        
        }

    }

    //hashsets

    class DemoLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<int> list=new LinkedList<int>();

            list.AddFirst(10);
            list.AddLast(20);
            list.AddLast(34);
            list.AddLast(12);
            Console.WriteLine("-------Adding 4 Elements----");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            LinkedListNode<int> node= list.Find(34);
            Console.WriteLine("-----Add before 34----");
            list.AddBefore(node,15);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }


        }
    }
}
