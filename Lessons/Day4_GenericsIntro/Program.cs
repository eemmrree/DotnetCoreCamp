using System;

namespace Day4_GenericsIntro
{
    class Program
    {
        static void Main()
        {
            MyList<int> numbers = new MyList<int>();
            numbers.Add(4);
            numbers.Add(3);
            numbers.Add(5);
            foreach (var item in numbers.Items)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine(numbers.Length);
            

        }
    }
}
