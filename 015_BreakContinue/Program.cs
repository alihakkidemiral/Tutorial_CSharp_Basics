using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;

            for (int i = 0; i < length; i++)
            {
                if (i == 4) continue;
                Console.WriteLine("i value is " + i);
                if (i == 7) break;
            }

            Console.ReadLine();
        }
    }
}