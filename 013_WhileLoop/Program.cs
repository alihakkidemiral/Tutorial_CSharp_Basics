using System;

namespace whileLoop
{
    class Program
    {
        static void Main()
        {
            int x = 7;
            int y = 11;

            // * while
            Console.WriteLine("while loop");
            while (x < y)
            {
                Console.WriteLine("x value still lower than y, x value is " + x);
                x++;
            }

            Console.WriteLine();

            // * do while
            x = 7;
            Console.WriteLine("do while loop");
            do
            {
                Console.WriteLine("x value still lower than y, x value is " + x);
                x++;
            }
            while (x < y);
            Console.ReadLine();
        }
    }
}