using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string variable contains an array of characters and declared in double quotes.
            string firstName = "Ali Hakkı";
            string lastName = "Demiral";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            // * Length property.
            //  when you use a property brackets "()" not used.
            //  The last space character is also counted.
            string text = "The lenght of the this string is: ";
            Console.WriteLine(text + text.Length);

            // * ToUpper() and ToLower() methods
            
            //  returns a copy string converted to uppercase
            Console.WriteLine(text.ToUpper() + text.Length);

            //  returns a copy string converted to lowercase
            Console.WriteLine(text.ToLower() + text.Length);
            

            string arrayA = "QWERTY";
            string arrayB = "ASDFGH";
            string arrayC = "ZXCVBN";

            //  when you use + operator for combine arrayA, arrayB, and arrayC
            //  first memory reserved for (arrayA + ArrayB) after repeating that for arrayC
            //  The + operator only processing between two variables.
            string arrayD = arrayA + arrayB + arrayC;
            foreach (var item in arrayD)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // * Concat()
            //  string.Concat() method can combine multiple array at one time.
            //  before combine all of them memory reserved one time for all. 
            string arrayF = string.Concat(arrayA, arrayB, arrayC);
            foreach (var item in arrayF)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // * Adding Numbers and Strings
            int x = 9;
            int y = 11;
            int z = x + y;
            Console.WriteLine("z is: " + z); // z is: 20

            string a = "9";
            string b = "11";
            string c = a + b;
            Console.WriteLine("c is: " + c); // z is 911

            // * String Interpolation
            //  You can define placeholders in double quotes.
            //  Replaces the values of variables with placeholders.
            string comment = $"{firstName} {lastName} user is requesting root privileges";
            Console.WriteLine(comment);


            // * access the characters in a string.
            string myString = "Hello World!";
            Console.WriteLine(myString[0]); // H


            // * IndexOf() you can find a specific character in a string.
            Console.WriteLine(myString.IndexOf('!'));


            // * Substring() you can extracts the characters from a string
            //  This method is often used together with
            //  IndexOf() to get specific character position.
            int charPos = fullName.IndexOf('D');
            lastName = fullName.Substring(charPos);
            Console.WriteLine(lastName);


            /*
            ! Special Characters
            *   \'      '       single quote
            *   \"      "       double quote
            *   \\      \       Backslash
            */

            // ! string word1 = "she told me "come here"."; // ERROR
            string word1 = "she told me \"come here\".";
            Console.WriteLine(word1);


            Console.ReadLine();
        }
    }
}