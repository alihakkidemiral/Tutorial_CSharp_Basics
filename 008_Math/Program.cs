using System;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            int y = 11;
            Console.WriteLine("x = " + x + ", y = " + y );
            
            // * Math.Max(x, y)     returns the highest value  of  between x and y
            Console.WriteLine("Math.Max(x, y): " + Math.Max(x, y));

            // * Math.Min(x, y)     returns the lowest value  of  between x and y
            Console.WriteLine("Math.Min(x, y): " + Math.Min(x, y));

            // * Math.Sqrt(x)       returns the square root of x
            Console.WriteLine("Math.Sqrt(x): " + Math.Sqrt(x));

            // * Math.Abs(x)        returns the absolute value of x
            Console.WriteLine("Math.Abs(-5.4): " + Math.Abs(-5.4));

            // * Math.Round(x)      returns the nearest whole number
            Console.WriteLine("Math.Round(5.67): " + Math.Round(5.67));
            
            Console.ReadLine();
        }
    }
}