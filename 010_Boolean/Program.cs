using System;

namespace BooleanType
{
    class Program
    {
        static void Main(string[] args)
        {
            // * bool data type can take the values true or false
            bool isStart = true;
            bool isEnd = false;
            Console.WriteLine("isStart: " + isStart);
            Console.WriteLine("isEnd: " + isEnd);

            // * Boolean Expression returns true or false value.
            int x = 7;
            int y = 11;
            Console.WriteLine("x > y: " + (x > y));   // false
            Console.WriteLine("7 < 11: " + (7 < 11));  // true
            Console.WriteLine("x == 7: " + (x == 7));  // true

            int myAge = 39;
            int votingAge = 18;
            Console.WriteLine("myAge >= votingAge: " + (myAge >= votingAge)); // true

            // * Boolean expression in if else statement.
            if (myAge >= votingAge)
            {
                Console.WriteLine("You can use your vote.");
            }
            else
            {
                Console.WriteLine("You can't use vote for now.");
            }

            Console.ReadLine();
        }
    }
}