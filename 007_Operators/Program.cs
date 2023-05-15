using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            !   Arithmatic Operators
            *   +   Addition        Adds together two values
            *   -   Subtraction     Subtracs one value from another
            *   *   Multiplication  Multiplies two values
            *   /   Division        Divides one value by another
            *   %   Modules         Returns the division remainder
            *   ++  Increment       Increase value of a variable by 1
            *   --  Decrement       Decrease value of a variable by 1
            */

            Console.WriteLine (5 + 10);

            int myNumber = 0;
            Console.WriteLine("Increase after use. myNumber++ :" + (myNumber++));
            Console.WriteLine("Current myNumber value is: " + myNumber);
            Console.WriteLine("increase before use. ++myNumber :" + (++myNumber));

            /*
            ! Assignment Operators
            *   =       x = 7
            *   +=      x += 3      x = x + 3
            *   -=      x -= 3      x = x - 3
            *   *=      x *= 3      x = x * 3
            *   /=      x /= 3      x = x / 3
            *   %=      x %= 3      x = x % 3
            *   &=      x &= 3      x = x & 3
            *   |=      x |= 3      x = x | 3
            *   ^=      x ^= 3      x = x ^ 3
            *   >>=     x >>= 3     x = x >> 3
            *   <<=     x <<= 3     x = x << 3
            */

            int x = 7;
            Console.WriteLine("x = " + x);
            Console.WriteLine("x += 3: " + (x+=3));
            Console.WriteLine("x = " + x);

            /*
            ! Comparison Operators
            *   used for compare two value.
            *   it returns true or false value.
            *   ==      equal to                    x == y
            *   !=      not equal                   x != y
            *   >       greater than                x > y
            *   <       less than                   x < y
            *   >=      greater than or equal to    x >= y
            *   <=      less than or equal to       x <= y
            */

            int a = 7;
            int b = 9;
            Console.WriteLine("a = 7, b = 9" + " a > b: " + (a > b));

            /*
            ! Logical Operators
            *   used for compare two statements
            *   it returns true or false value.
            
            returns true if both statements are true
            *   &&      logical and         a > 3 && b > 10
            
            returns true if one of the statements is true
            *   ||      logical or          a > 3 || b > 10

            used for reverse the result 
            *   !       logical not         !(a > 3)
            */

            Console.WriteLine("a > 3 && b > 10: " + (a > 3 && b > 10));
            Console.WriteLine("a > 3 || b > 10: " + (a > 3 || b > 10));
            Console.WriteLine("!(a > 3): " + (!(a > 3)));

            Console.ReadLine();
        }
    }
}