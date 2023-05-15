// you can take warrning like 
// "variable 'pi' is assigned but its value is never used",
// it's not a problem, ignore it.

using System;

namespace CSharpVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *   int     whole numbers from -2,147,483,648 to 2,147,483,647
            *   long    whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            *   float   fractional numbers. 6 to 7 decimal digits
            *   double  fractional numbers. 15 decimal digits
            *   bool    true / false
            *   char    a single character, in single quotes '*'
            *   string  character array, in double quotes "Hello World!"
            */


            // * don't use nonsense words, or single characters,
            // * when naming variables.

            string prdctnm = "wtf";
            string p = "O_O";
            string productName ="I know now that what is that.";

            // * Variables are stored various type data.
            // * Can changed after they are defined.

            int myInteger = 123;

            float myFloat;
            myFloat = 33.50F;

            double myDouble = 44.6546543D;

            char myChar = 'A';

            string myString = "Hello, welcome to my git page.";

            bool myBool = true;


            // * Constants variables
            // * Can't changed after they are defined.

            const double pi = 3.14159265359D;
            // ! pi = 20; // ERROR

            // * You can add variable to other variable.

            string firstName = "Ali Hakki";
            string lastName = "Demiral";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            int number1 = 5;
            int number2 = 7;
            Console.WriteLine("Numeric add: string + (5 + 7) = " + (number1 + number2));
            Console.WriteLine("String add: string + 5 + 7 = " + number1 + number2);

            // * you can declare same type many variable in one line.
            int x = 5, y = 7, z = 9;
            Console.WriteLine("x + y + z = " + (x + y + z));

            Console.ReadLine();
        }
    }
}