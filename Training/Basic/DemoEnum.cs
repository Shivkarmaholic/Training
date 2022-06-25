using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    enum dept { hr, sales, technical, development, testing };

    class Employee
    {
        private int emp_id;
        private string emp_name;
        private dept d;

        public Employee(int id, string name, dept dep)
        {
            this.emp_id = id;
            this.emp_name = name;
            this.d = dep;
        }
        public void Display()
        {
            Console.WriteLine("Id : " + emp_id);
            Console.WriteLine("Name : " + emp_name);
            Console.WriteLine("Department : " + d);
        }
    }
    class DemoEnum
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee(2, "Mahesh", dept.hr);
            emp.Display();
        }
    }
}
