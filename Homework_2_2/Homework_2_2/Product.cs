using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_2
{
    internal class Product
    {
        public string Name { get; }
        public decimal Price { get; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
