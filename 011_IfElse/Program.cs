using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 11;


            // * if (condition)
            if (x > 5)
            {
                Console.WriteLine("x is bigger than 5");
            }


            // * if else
            if (x > y)
            {
                Console.WriteLine("x is bigger than y");
            }
            else
            {
                Console.WriteLine("x is not bigger than y");
            }


            // * else if
            if (x > y)
            {
                Console.WriteLine("x is bigger than y");
            }
            else if (y > x)
            {
                Console.WriteLine("y is bigger than y");
            }
            else
            {
                Console.WriteLine("x and y are equal");
            }


            // * Short if...else    (Ternary Operator)
            // * Variable = (condition) ? expressionTrue : expressionFalse;
            int minValue;
            minValue = (x < y) ? x : y;
            Console.WriteLine(minValue);


            Console.ReadLine();
        }
    }
}