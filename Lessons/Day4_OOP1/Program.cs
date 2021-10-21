using System;

namespace Day4_OOP1
{
    class Program
    {
        static void Main()
        {
            Product p1 = new Product
            {
                Id = 1,
                CategoryId = 2,
                ProductName = "Masa",
                UnitPrice = 500,
                UnitInStock = 3
            };

            Product p2 = new Product
            {
                Id = 2,
                CategoryId = 1,
                ProductName = "Kalem",
                UnitPrice = 5,
                UnitInStock = 3
            };

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(p1);

            //Console.WriteLine(p1.ProductName);
            //Output -> Kamera




            productManager.Sum2(3,4);
            int result = productManager.Sum(3, 7);
            Console.WriteLine(result*2);



            //int sayi = 100;
            //productManager.Test(sayi);

            //Console.WriteLine(sayi);
            //Output -> 100

        }
    }
}
