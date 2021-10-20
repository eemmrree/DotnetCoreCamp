using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Methods
{
    class BasketManager
    {
        public void AddProduct(Product product)
        {
            Console.WriteLine("Added  :" + product.ProductName);
        }
        public void AddProduct2(string productName , string description , int price)
        {
            Console.WriteLine("New Added2  :" +productName);
            Console.WriteLine("New Added2 : " +description);
            Console.WriteLine("New Added2 : " +price);
        }
    }
}
