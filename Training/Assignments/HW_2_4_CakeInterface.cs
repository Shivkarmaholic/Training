using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    interface ICake
    {
        public void bake();
    }

    class Strawberry : ICake
    {
        public void bake()
        {
            Console.WriteLine("Making Strawbery Cake.");
        }
    }
    class Blackforest : ICake
    {
        public void bake()
        {
            Console.WriteLine("Making Blackforest Cake.");
        }
    }

    class HW_2_4_CakeInterface
    {
        static void Main(string[] args)
        {
            Strawberry s1 = new Strawberry();
            Blackforest b1 = new Blackforest();
            s1.bake();
            b1.bake();
        }
    }
}
