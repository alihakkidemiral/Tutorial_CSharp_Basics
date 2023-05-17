using System;

namespace MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "Ali Hakki Demiral";
            int userOld = 39;
            bool isMeried = true;


            WelcomeMessage(userName);
            Console.WriteLine();

            UserInfo(userName, userOld, isMeried);
            Console.WriteLine();

            GameEnd();
            GameEnd(true);
            Console.WriteLine();


            int number = 0;
            Console.WriteLine("Return int value from PlusFive method " + PlusFive(number) + "\n");

            // * you can store return in a variable. this more readable.
            int x = 7;
            int y = 11;
            int z = SumThem(x, y);
            Console.WriteLine("Return int value from PlusFive method " + z + "\n");

            // * Named Arguments
            // arguments order does not matter
            UserInfo("Yeliz", 39, true);
            Console.WriteLine();
            UserInfo(age: 39, Merried: true, name: "Yeliz");

            Console.ReadLine();
        }


        // * value can passed to method as parameter.
        static void WelcomeMessage(string name)
        {
            Console.WriteLine("Welcome " + name);
        }


        // * you can use many parameters.
        static void UserInfo(string name, int age, bool Merried)
        {
            Console.WriteLine("Username is " + name);
            Console.WriteLine("Age is " + age);
            Console.WriteLine("Is Merried " + Merried);
        }


        // * default parameter
        static void GameEnd(bool GameEnd = false)
        {
            Console.WriteLine("Game End " + GameEnd);
        }


        // * Return Value
        static int PlusFive(int x)
        {
            return 5 + x;
        }

        static int SumThem(int x, int y)
        {
            return x + y;
        }
    }
}