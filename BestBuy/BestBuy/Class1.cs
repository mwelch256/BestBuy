using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy
{
public class Product : IProduct
    { 
        public string Name { get; set; }
        public double Price { get; set; }

        public double PriceWithTax()
        {
            return Price * (Price * 1.1);
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product()
        { }
    }
}
