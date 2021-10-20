using System;

namespace Day2_Classes
{
    class Program
    {
        static void Main()
        {
            //string adi = "emre";
            //int yas = 23;

            var k1 = new Kurs { KursAdi = "C#", Egitmen = "Emre", Izlenme = 56 };

            var k2 = new Kurs { KursAdi = "Python", Egitmen = "Emre", Izlenme = 15 };

            var k3 = new Kurs { KursAdi = "Java", Egitmen = "Emre", Izlenme = 23 };

            Console.WriteLine(k1.KursAdi + " - " + k1.Egitmen);

            var kurs = new Kurs[] { k1, k2, k3 };

            foreach (var item in kurs)
            {
                Console.WriteLine(item.KursAdi);
            }
        }
    }
    public class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int Izlenme { get; set; }
    }
}
