using System;

namespace CSharpVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // int: stored an integer value.
            int myInteger = 15;
            Console.WriteLine(myInteger);

            // float: stored a decimal value.
            float myFloat = 33.50f;
            Console.WriteLine(myFloat);

            // double: stored a decimal value but bigger than float.
            double myDouble = 44.6546543d;
            Console.WriteLine(myDouble);

            // char: stored a single character.
            char myChar = 'A';
            Console.WriteLine(myChar);

            // string: stored an char array.
            string myString = "Hello, welcome to my git page.";
            Console.WriteLine(myString);

            // bool: stored logical key 1 (true) or 0 (false).
            bool myBoolean = true;
            Console.WriteLine(myBoolean);

            Console.ReadLine();
        }
    }
}