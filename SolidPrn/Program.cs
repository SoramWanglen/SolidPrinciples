//Single Responsibility Principle
using System;

namespace SolidPrn
{ 
    class BillBuilder
    {
        public void AddCustomer()
        {
            Console.WriteLine("add the customer");
        }
        public void DeleteCustomer()
        {
            Console.WriteLine("delete the customer");
        }
    }
    class Bill : BillBuilder
    {
        public void ShowBill()
        {
            Console.WriteLine("generate the bill!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bill myBill = new Bill();
            myBill.ShowBill();
        }
    }
}
