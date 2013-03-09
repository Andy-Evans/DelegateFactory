using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public abstract class OrderBase
    {
        public delegate OrderBase Factory();
        public abstract void AddOrder(int orderNo);
    }
}
