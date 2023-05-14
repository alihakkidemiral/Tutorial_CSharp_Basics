//* Commands of console output

using System;

namespace Output
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Output to console
            Console.Write("Hello ");

            //* New Line after output
            Console.WriteLine("World!");

            //* Combine two string
            Console.WriteLine("String1 " + "String2");

            //* Math in output
            Console.WriteLine("5 + 5 = " + 5 + 5);
            Console.WriteLine("5 + 5 = " + (5 + 5));

            Console.ReadLine();
        }
    }
}