using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class Employeee
    {
        protected int eid;
        protected string name;
        protected double bs, hra, da, pf, gross;
        public Employeee()
        {
            eid = 0;
            name = "";
            bs = 0.0;
        }
        public Employeee(int id, string nm, double basic)
        {
            eid = id;
            name = nm;
            bs = basic;
        }

        public virtual void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            gross = (bs + hra + da) - pf;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Employee Gross salary is {gross}");
        }


    }

    class Manager : Employeee
    {
        private double fa, ta, bonus;
        public Manager() : base()
        {
            fa = 0.0;
            ta = 0.0;
            bonus = 0.0;
        }
        public Manager(int id, string nm, double bs, double t, double b, double f) : base(id, nm, bs)
        {
            fa = f;
            ta = t;
            bonus = b;
        }
        public override void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            gross = (bs + hra + da + ta + bonus + fa) - pf;
        }
        public override void Print()
        {
            Console.WriteLine($"Manager Gross salary is {gross}");
        }
    }

    class President : Employeee
    {
        double fa, ta;
        public President() : base()
        {
            fa = 0.0;
            ta = 0.0;
        }
        public President(int id, string nm, double bs, double t, double f) : base(id, nm, bs)
        {
            fa = f;
            ta = t;
        }

        public override void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            gross = (bs + hra + da + ta + fa) - pf;
        }
        public override void Print()
        {
            Console.WriteLine($"President Gross salary is {gross}");
        }

    }

    class DemoEmployee
    {
        static void Main(string[] args)
        {
            Employeee employee = new Employeee(1, "sachin", 5000);
            employee.CalculateSalary();
            employee.Print();

            Manager manager = new Manager(1, "sumit", 1000, 2000, 300, 600);
            manager.CalculateSalary();
            manager.Print();

            President president = new President(1, "mahesh", 5000, 6000, 7000);
            president.CalculateSalary();
            president.Print();
        }
    }
}
