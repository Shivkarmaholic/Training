using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class PatternPrints
    {
        static void Main(string[] args)
        {
            //*
            //**
            //***
            //****
            //*****

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("---------xxxxx---------");


            //1
            //12
            //123
            //1234
            //12345

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("---------xxxxx---------");


            //12345
            //1234
            //123
            //12
            //1

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------xxxxx---------");

            //54321
            //5432
            //543
            //54
            //5

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("----------xxxxxxxx------------");

            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
