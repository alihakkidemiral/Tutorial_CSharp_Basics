using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // * define an array named "colors"
            string[] colors = {"Red", "Orange", "Brown", "Yellow", "Green", "Turquoise", "Blue",
                                "Violet", "Pink", "White", "Grey", "Black"};


            // * accessing element of array
            Console.WriteLine("First element of array (index number: 0 ) is " + colors[0]);


            // * array length
            Console.WriteLine("Lenght of colors array is " + colors.Length);


            Console.WriteLine();

            /*
            ! Creating an Array
                Create an empty array with element number.
            *   string[] colors = new string[3];

                Create an array with element number and values.
            *   string[] colors = new string[3] {"Red", "Green", "Blue"};

                Create an array with values but without element number
            *   string[] colors = new string[] {"Red", "Green", "Blue"};

                Create an array with skipping new command.
            *   string[] colors = {"Red", "Green", "Blue"};
            */


            // * loop in array
            Console.WriteLine("elements of color array(with for):");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write(colors[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            
            // *  foreach
            Console.WriteLine("elements of color array(with foreach):");
            foreach (string color in colors)
            {
                Console.Write(color + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // * Sort() 
            string[] cars = {"Volvo", "Renault", "BMW", "Honda"};
            Array.Sort(cars);
            foreach (string car in cars)
            {
                Console.Write(car + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            int[] numbers = {7, 5, 9, 3};
            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");



            // * System.Linq namespace
            // max value
            Console.WriteLine("Bigger value in numbers array is " + numbers.Max());
            Console.WriteLine("Smallest value in numbers array is " + numbers.Min());
            Console.WriteLine("Sum of elements in numbers array is " + numbers.Sum());


            // * Multidimensional arrays

            int[,] numbers2D = {{5,4,6}, {3,7,9}};
            int[,,] numbers3D = {{{2,3}, {5,7}}, {{4,7}, {6,7}}}; 

            Console.WriteLine(numbers2D[0, 1]);
            Console.WriteLine(numbers3D[1,1,0]);
            Console.WriteLine();

            // * loop 2D array
            // foreach for all elements of array
            foreach (int item in numbers2D)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");

            // * specific loop with diminsion index number.
            for (int i = 0; i < numbers2D.GetLength(0); i++)
            {
                for (int j = 0; j < numbers2D.GetLength(1); j++)
                {
                    Console.WriteLine(numbers2D[i, j]);                    
                }
            }


            Console.ReadLine();
        }
    }
}