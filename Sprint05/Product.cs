using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint05
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public static void TotalPrice(ILookup<string, Product> lookup)
        {
            decimal sum = 0;
            foreach (IGrouping<string, Product> product in lookup)
            {                
                foreach (Product p in product)
                {
                    Console.WriteLine($"{p.Name} {p.Price}");
                    sum += p.Price;
                }                   
                Console.WriteLine($"{product.Key} {sum}");
                sum = 0;
            }
        }
    }
}
