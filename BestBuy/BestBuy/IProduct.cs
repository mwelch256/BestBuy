using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy
{
    interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }

        double PriceWithTax(double price);
      
    }
}
