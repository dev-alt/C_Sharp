using System.Numerics;

namespace Factorial_Prac
{
    internal class Program
    {
        // CheckStatus function to validate input number
        //static async Task CheckStatus(int num)
        //{
        //    if (num <= 0)
        //    {
        //        // Display warning message if input number is not positive
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.WriteLine("Warning: Input number must be a positive integer.");
        //        Console.ResetColor();
        //    }
        //}

        static void Main(string[] args)
        {
            // Display program title
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Factorial Program");
            Console.WriteLine("--------------------------------");

            BigInteger num;

            // Loop to accept input number and calculate factorial
            do
            {
                // Prompt the user to enter a positive integer
                Console.Write("Enter a positive integer (or 0 to quit): ");

                // Check if the input number is valid and positive
                if (!BigInteger.TryParse(Console.ReadLine(), out num) || num < 1)
                {
                    // Display error message if input number is invalid or not positive
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Invalid input. Please enter a positive integer.");
                    Console.ResetColor();
                    continue;
                }

                Console.WriteLine();
                if (num == 0)
                {
                    // Exit the loop if the input number is 0
                    break;
                }

                // Calculate the factorial of the input number and display the result
                Console.WriteLine($"The factorial of {num} is: {Factorial(num)}");
                Console.WriteLine();
            } while (true);
        }

        // Recursive function to calculate the factorial of a number
        static BigInteger Factorial(BigInteger factorialNum)
        {
            // Exit condition when the input number is 1
            if (factorialNum == 1)
            {
                return 1;
            }

            // Recursive call to calculate the factorial of the input number
            return factorialNum * Factorial(factorialNum - 1);
        }
    }
}