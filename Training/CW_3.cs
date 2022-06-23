using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
	class Studd
	{
		int sid; string name;
		int percent;

		public Studd(int sid, string name, int percent)
		{
			this.Sid = sid;
			this.Name = name;
			this.Percent = percent;
		}

		public override string ToString()
		{
			return $"Sid:{sid} Name:{name} Percent:{percent}";
		}
		public int Sid { get => sid; set => sid = value; }
		public string Name { get => name; set => name = value; }
		public int Percent { get => percent; set => percent = value; }



		class CW_3
		{
			static void Main(string[] args)
			{
				List<Studd> list = new List<Studd>();
				list.Add(new Studd(11, "shivam", 99));
				list.Add(new Studd(22, "mahesh", 88));
				list.Add(new Studd(33, "rudra", 67));
				list.Add(new Studd(44, "shambhu", 83));
				list.Add(new Studd(55, "natraj", 71));

			}

		}

		
	}
	class CW_3_1
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> dict = new Dictionary<int, string>();
			dict.Add(1, "shivam");
			dict.Add(2, "mahesh");
			dict.Add(3, "rudra");
			dict.Add(4, "mahadev");
            Console.WriteLine("-----After Adding 4 Items------");
			foreach (KeyValuePair<int, string> kv in dict)
			{
				Console.WriteLine($"key :{kv.Key } Value : {kv.Value}");
			}
			Console.WriteLine("3 rd element is :" + dict[3]);
			dict.Remove(3);
			Console.WriteLine("-----After Removing 3rd Item------");

			foreach (KeyValuePair<int, string> kv in dict)
			{
				Console.WriteLine($"key :{kv.Key } Value : {kv.Value}");
			}



		}
	}
	class Student
    {
		int id;
		string name;
		int per;
		public Student(int id,string name, int per)
        {
			this.id = id;
			this.name = name;
			this.per = per;
        }
        public override string ToString()
        {
			return $" ID: {id},   Name :  {name},  Percentage:  {per}";
        }
        public override bool Equals(object? obj)
        {
            return obj is Student student && 
				id== student.id &&
				name==student.name &&
				per==student.per;
            Console.WriteLine(	"");
        }
		

    }
	class CW_3_2
    {
        static void Main(string[] args)
        {
			Dictionary<Student, string> dict = new Dictionary<Student, string>();
			dict.Add(new Student(12, "Mahesh", 88), "Samarth");
			dict.Add(new Student(15, "Shivam", 79), "sarthak");
			dict.Add(new Student(18, "Rudra", 93), "Arnav");

			foreach(KeyValuePair<Student, string> kv in dict)
            {
                Console.WriteLine(kv.Key+"   "+kv.Value);
            }
        }
    }
}
