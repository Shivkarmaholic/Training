using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7.Design class Order (int ordered, String Orderdate, Customer cust, Item item)
//Customer(int custid, String custname, Address address)
//Address(String addr1, city, int pincode)
//Item(int itemid, String itemname, int price)
//Write constructors, properties  in respective classes.


namespace Training
{
    class Item
    {
        int itemid;
        string itemname;
        int price;
        public Item(int id, string name, int price)
        {
            itemid = id;
            itemname = name;
            this.price = price;
        }
        public Item()
        {

        }

    }
    class Address
    {
        string addr;
        string city;
        int pincode;
        public Address(string add, string c, int pin)
        {
            addr = add;
            city = c;
            pincode = pin;
        }
        public Address()
        {

        }
    }

    class Customer : Address
    {
        int custid { get; set; }
        string custname { get; set; }
        Address address;
        public Customer(int cid, string name, Address ad)
        {

        }
    }

    //class Order : Customer
    //{
    //    int orderId { get; set; }
    //    string orderdate { get; set; }
    //    Customer cust;
    //    Item item;
    //}



    class HW_2_7_PersonOrder
    {
        static void Main(string[] args)
        {
            Item item = new Item(11, "Samosa", 20);
            Item item2 = new Item(22, "Vada-Pav", 10);
            Address ad = new Address("manik Baug", "Pune", 411040);
            Customer c1 = new Customer(1, "Manohar", ad);
        }
       

    }
}
