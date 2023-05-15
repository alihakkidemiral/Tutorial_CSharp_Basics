using System;

namespace TypeCasting
{
    class Program
    {
        static void Main()
        {
            /*
                type casting, used when you need convert a variable type to another type.
                C# have two still type casting

            *   Implicit Casting (Automatically), smaller type to larger type. withouth loss data.
            *   char -> int -> long -> float -> double
            
            *   Explicit Casting (manually), larger type to smaller type. can be loss some data.
            *   double -> float -> long -> int -> char
            */

            int myInt = 123;
            double myDouble = myInt; // Implicit casting, int to double.

            myDouble = 3.14159265359D;
            myInt = (int) myDouble; // Explicit casting, double to int.
            Console.WriteLine(myInt);   // decimal digits will loss


            /*
                Type Casting Methods
            *   Convert.ToBoolean
            *   Convert.ToDouble
            *   Convert.ToString
            *   Convert.ToInt32 (int)
            *   Convert.ToInt64 (long)
            */
            
            bool myBool = true;

            Console.WriteLine("double to int: " + Convert.ToInt32(myDouble));
            Console.WriteLine("int to double: " + Convert.ToDouble(myInt));
            Console.WriteLine("int to string: " + Convert.ToString(myInt));
            Console.WriteLine("double to string: " + Convert.ToString(myDouble));
            Console.WriteLine("bool to string: " + Convert.ToString(myBool));

            Console.ReadLine();

        }
    }
}