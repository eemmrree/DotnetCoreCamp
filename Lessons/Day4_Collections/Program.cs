using System;
using System.Collections.Generic;

namespace Day4_Collections
{
    class Program
    {
        static void Main()
        {
            //string[] names = new[] {"Emre", "Esra", "Yunus" , "Ayşe"};
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5]; // -> Bellekteki Adres değişti yeni adres oluştu
            //names[4] = "Deneme";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]); // -> Output = null


            List<string> names2 = new() { "Emre", "Esra", "Yunus", "Ayşe" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Deneme");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2.Count);
            Console.WriteLine(names2.Capacity);
            





        }
    }
}
