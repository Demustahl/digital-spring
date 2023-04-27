using System;
using System.Linq;

namespace Library
{
    public class ZadanieOne
    {
        /// <summary>
        /// Outputs a comma-separated list of integers from 1 to n on the console.
        /// </summary>
        public static void One() /*need to add the static keyword so that the method
         can be called without creating a class object*/
        {
            Console.Write("Введите число N: ");
            int n;
            if ((!int.TryParse(Console.ReadLine(), out n) || (n < 0))) /* checking that it is possible to convert
            a string entered by the user into a number and is it not less than 0 */
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }
            string result = string.Join(", ", Enumerable.Range(1, n)) + "."; // adding a dot at the end of the line
            Console.WriteLine(result);
        }
    }
    public class ZadanieTwo
    {
        /// <summary>
        /// Outputs a square with the sides of length n on the console,
        /// consisting of the "#" symbol, except for the center, which is empty.
        /// </summary>
        public static void Two()
        {
            Console.Write("Введите нечетное число N: ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || (n <= 0)) // checking for a number and is it not less than 0
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }
            if (n % 2 == 0) // If N is an even number, exit the function.
            {
                Console.WriteLine("Вы ввели четное N.");
                return;
            }
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == n / 2 + 1 && col == n / 2 + 1) Console.Write("  "); /* we enter an additional 
                    space so that the figure really looks like a square in the console */
                    else Console.Write("# "); // here too
                }
                Console.WriteLine();
            }
        }
    }
    class program /* in the main function, we will call the methods of the classes */
    {
        static void Main()
        {
            ZadanieOne.One();
            ZadanieTwo.Two();
        }
    }
}