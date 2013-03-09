using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new Person(() => new Order()).OrderRequest();

            Console.WriteLine("Order Processing Complete");
            Console.ReadKey();
        }
    }
}
