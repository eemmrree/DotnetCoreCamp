using System;

namespace Day3_ValueAndReferanceTypes
{
    class Program
    {
        static void Main()
        {

            int x = 5;
            int y = 10;

            x = y;
            y = 15;


            int[] values = new[] {10, 20, 30};
            int[] values2 = new[] {100, 200, 300};

            values = values2;
            values2[0] = 999;
            
            
            Console.WriteLine(x);
            Console.WriteLine(values[0]);

        }
    }
}
