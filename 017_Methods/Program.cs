using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();

            Console.ReadLine();
        }

        // * "static" mean this method belongs to Program class and it is not an object.
        // * "void" mean this method does not return any value.
        static void MyMethod()
        {
            Console.WriteLine("MyMethod has been called.");
        }
        
    }
}