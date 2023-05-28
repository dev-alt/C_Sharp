using System;
using System.Threading;

namespace BubbleImprovement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Set text color to cyan

            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║                                        ║");
            Console.WriteLine("║       Welcome to my BubbleSort()       ║");
            Console.WriteLine("║             Algorithm :)               ║");
            Console.WriteLine("║                                        ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.ResetColor(); // Reset text color

            // Create an instance of the Algorithm class with size 100
            Algorithm myalgo = new Algorithm(100);

            Console.WriteLine("\nInitial numbers generated:\n");
            myalgo.Display();

            Console.WriteLine("\nSorting in progress...\n");
            Thread.Sleep(1000); // Delay for 1 second
            Console.WriteLine("Progress:");
            Console.Write("["); // Opening bracket of the progress bar

            int progressBarWidth = 20; // Width of the progress bar
            int totalIterations = 10; // Total number of iterations for the progress bar

            for (int i = 0; i <= totalIterations; i++)
            {
                Console.Write("=");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Move the cursor back by 1
                Console.Write(">"); // Indicator of the current progress

                double progressPercentage = (double)i / totalIterations * 100; // Calculate the progress percentage
                Console.SetCursorPosition(progressBarWidth + 2, Console.CursorTop);
                Console.Write($"{progressPercentage}%"); // Display the progress percentage

                Thread.Sleep(300);
            }

            Console.Write("]"); // Closing bracket of the progress bar
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Yellow; // Set text color to yellow
            myalgo.BubbleSort();
            Console.ResetColor(); // Reset text color

            Console.WriteLine("\nSorting complete!\n");
            Thread.Sleep(500); // Delay for 0.5 seconds

            Console.ForegroundColor = ConsoleColor.Green; // Set text color to green
            myalgo.Display();
            Console.ResetColor(); // Reset text color
        }
    }
}
