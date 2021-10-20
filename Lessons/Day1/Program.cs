using System;

namespace Day1
{
    class Program
    {
        static void Main()
        {
            double dolarBugun = 7.35;
            double dolarDun = 7.45;
            bool girisDenetim = false;
            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış!");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış!");
            }
            else
            {
                Console.WriteLine("Eşit");
            }
            if (girisDenetim == false)
            {
                Console.WriteLine("Başarısız Giriş!");
            }
        }
    }
}
