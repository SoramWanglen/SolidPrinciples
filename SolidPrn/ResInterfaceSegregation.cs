using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrn
{
    public interface CustomerInterface
    {
        public CustomerInterface GetCustomer();
        public CustomerInterface AddCustomer();
        public CustomerInterface UpdateCustomer();
        public CustomerInterface DeleteCustomer();
    }
    public interface OrderInterface
    {
        public OrderInterface GetOrder();
        public OrderInterface AddOrder();
        public OrderInterface UpdateOrder();
        public OrderInterface DeleteOrder();
    }
    class ResInterfaceSegregation
    {
        public void Show()
        {
            Console.WriteLine("This is interface segregation!");
        }
    }
}
