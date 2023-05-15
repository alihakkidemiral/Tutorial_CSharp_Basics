// * Command for console input values.
// * Console.ReadLine() method is used to get value from console.

using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Username is : " + userName);

            Console.ReadLine();
        }
    }
}