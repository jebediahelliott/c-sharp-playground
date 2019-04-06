using System;

namespace c_sharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            int y = 0;
            y = x.Next(1, 7);

            Console.WriteLine(y);

            double j = 0;
            j = x.NextDouble() * 100;
            Console.WriteLine(j);
        }
    }
}
