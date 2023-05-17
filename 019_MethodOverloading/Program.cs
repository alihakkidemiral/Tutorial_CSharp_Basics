using System;

namespace ProgramOverloading
{
    class Program
    {
        static void Main()
        {
            int sumInt = SumMyMethod(7, 11);
            double sumDouble = SumMyMethod(7.87650D, 11.48965D);
            Console.WriteLine("Integer sum " + sumInt);
            Console.WriteLine();
            Console.WriteLine("Double sum " + sumDouble);
            
            Console.ReadLine();
        }

        static int SumMyMethod(int x, int y)
        {
            return x + y;
        }

        static double SumMyMethod(double x, double y)
        {
            return x + y;
        }

    }
}