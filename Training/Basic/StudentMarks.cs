using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sub1 { get; set; }
        public int Sub2 { get; set; }
        public int Sub3 { get; set; }


        public Student(int id, string name, int sub1, int sub2, int sub3)
        {
            Id = id;
            Name = name;
            Sub1 = sub1;
            Sub2 = sub2;
            Sub3 = sub3;
        }

        public int totalMarks()
        {
            return Sub1 + Sub2 + Sub3;
        }
        public double avg()
        { return (Sub1 + Sub2 + Sub3) / 3; }

        public override string ToString()
        {
            return $"ID = {Id}, NAME = {Name} , SUB1 = {Sub1}, SUB2 = {Sub2}, SUB3 = {Sub3}";
        }

    }

    
    class StudentMarks
    {
        static void Main(string[] args)
        {
            int total_marks;
            double avg_marks;
            Student s1 = new Student(1, "Shiva", 56, 87, 45);
            Student s2 = new Student(2, "Mahesh", 66, 98, 47);

            string str;
            str = s1.ToString();
            System.Console.WriteLine("Student 1 Details : " + str);
            total_marks = s1.totalMarks();
            System.Console.WriteLine("Total Marks : " + total_marks);
            avg_marks = s1.avg();
            System.Console.WriteLine("Average Marks : " + avg_marks);

            str = s2.ToString();
            System.Console.WriteLine("Student 2 Details" + str);
            total_marks = s2.totalMarks();
            System.Console.WriteLine("Total Marks : " + total_marks);
            avg_marks = s2.avg();
            System.Console.WriteLine("Average Marks : " + avg_marks);
        }

    }
}
