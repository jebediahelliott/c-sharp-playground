using System;

namespace c_sharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.23456;
            // ceiling
            Console.WriteLine(Math.Ceiling(x));
            // floor
            Console.WriteLine(Math.Floor(x));
            // round
            Console.WriteLine(Math.Round(x, 2));
            // truncate
            Console.WriteLine(Math.Truncate(x, ));
        }
    }
}
