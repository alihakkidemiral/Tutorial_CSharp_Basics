using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // * for (statement1; statement2; statement3)
            int length = 10;
            for (int i = 0; i < length; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            // * Nested Loops
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Outer Loop: " + i);

                for (int j = 0; j < length; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // * foreach (type variableName in arrayName)
            string[] colors = {"Red", "Orange", "Brown", "Yellow", "Green", "Turquoise", "Blue",
                                "Violet", "Pink", "White", "Grey", "Black"};
            foreach (string color in colors)
            {
                Console.Write(color + " ");
            }

            Console.ReadLine();
        }
    }
}