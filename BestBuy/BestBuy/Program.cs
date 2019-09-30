using System;

namespace BestBuy
{
    class Program
    {
        static void Main(string[] args)
        {
         Product imac = new Product();
         imac.Name = "Apple IMac";
         imac.Price = 1899;

            Console.WriteLine($"the product's Price:{imac.Price}  Name: {imac.Name} With Tax {imac.PriceWithTax(1899 * 1.1)}");



        }
    }
}
