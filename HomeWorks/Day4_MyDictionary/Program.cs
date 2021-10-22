using System;

namespace Day4_MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> names = new MyDictionary<int, string>();
            names.Add(1, "Emre");
            names.Add(2, "Esra");


            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(names.Length);
        }
    }
}
