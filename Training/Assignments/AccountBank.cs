using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Account
    {
        public long accountNo { get; set; }
        public string customerName { get; set; }
        public float balance { get; set; }
        
        public Account()
        {
            accountNo = 0;
            customerName = "NA";
            balance = 0;
            Console.WriteLine("I am in Default Constructor.");
        }
        public Account(long accNo,string name, float bal)
        {
            accountNo = accNo;
            customerName = name;
            balance = bal;
            Console.WriteLine("I am in Parameterised Constructor");
        }
    }
    class AccountBank
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            Console.WriteLine("Account no: "+a1.accountNo
                +"\nAccount Name: "+a1.customerName
                +"\nAccount Bal:"+a1.balance);
            Account a2 = new Account(12345678,"Shivam",599.00f);
            Console.WriteLine("Account no: " + a2.accountNo
                + "\nAccount Name: " + a2.customerName
                + "\nAccount Bal:" + a2.balance);
        }
        
    }
}
