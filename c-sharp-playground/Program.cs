using System;

namespace c_sharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                //Console.WriteLine($"first loop i = {i}");
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write('0');
                    //Console.WriteLine($"second loof j = {j}");
                }
                Console.WriteLine();
            }

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('0');
                }
                Console.WriteLine();
            }
        }
    }
}
