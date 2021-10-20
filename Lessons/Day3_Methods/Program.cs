using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Methods
{
    class Program
    {
        static void Main()
        {
            var p1 = new Product() {Id = 1, ProductName = "Elma", Description = "Kırmızı Elma", Price = 12};
            var p2 = new Product() {Id = 2, ProductName = "Kiraz", Description = "Yeşil Elma", Price = 10};
            var products = new Product[] { p1, p2 };

            foreach (var item in products)
            {
                Console.WriteLine(item.Id+" "+item.Description + " ---> " + item.Price);
            }

            var bm = new BasketManager();
            bm.AddProduct(p2);
            bm.AddProduct2("Elma" ,"Deneme" , 15);
        }
    }
}
