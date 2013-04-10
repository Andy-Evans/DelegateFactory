using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public class Person : PersonBase
    {
        private OrderBase.Factory factory;

        public Person(OrderBase.Factory factory)
        {
            Console.WriteLine("Person Constructor invoked");
            this.factory = factory;
        }

        public override void OrderRequest()
        {
            Console.Write("No. of orders requested ? : ");
            string numberOfOrders = Console.ReadLine();

            int i = Convert.ToInt16(numberOfOrders);

            for (int x = 1; x <= i; x++)
            {
                OrderBase order = factory();
                order.AddOrder(x);
            }
        }
    }
}
