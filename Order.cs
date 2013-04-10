using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public class Order : OrderBase
    {
        public Order()
        {
            Console.WriteLine("Order Constructor");
        }

        public override void AddOrder(int orderNo)
        {
            Console.WriteLine(String.Format("Order No {0} Added.", orderNo));
        }
    }
}
