using System;

namespace Day2_Loops
{
    class Program
    {
        static void Main()
        {
            //array

            string[] kurslar = new[] { "Ağ", "C#", "C++" };



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //for

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i);
            }

            foreach (var model in kurslar)
            {
                // Console.WriteLine(model.Length);
                Console.WriteLine(model);

            }

            Console.WriteLine("---Sayfa Sonu---");
        }
    }
}
