using System;

namespace c_sharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"{i}");
                if (i == 5) break;

            }
            int x = 10;
            while (x > 0)
            {
                Console.WriteLine(x);
                x--;
            }
            int y = 1;
            do
            {
                Console.WriteLine(y);
                y++;
            } while (y < 10);
        }
    }
}
