using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            
            //product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + " Eklendi..");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi..");
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }
        public void Sum2(int x, int y)
        {
            Console.WriteLine(x + y); 
        }




        //public void Test(int sayi)
        //{
        //    sayi = 99;
        //}
    }
}
