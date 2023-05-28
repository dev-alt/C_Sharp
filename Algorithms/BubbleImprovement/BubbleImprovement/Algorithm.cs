using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleImprovement
{
    internal class Algorithm
    {
        private int[] numbers;
        private Random gen = new Random();

        // Constructor to initialize the Algorithm class with a given size
        public Algorithm(int size)
        {
            numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                // Generate random numbers between 10 and 100 and store them in the 'numbers' array
                numbers[i] = gen.Next(10, 100);
            }
        }

        // Method to perform bubble sort on the 'numbers' array
        public void BubbleSort()
        {
            int n = numbers.Length;
            bool swapped;


            // Outer loop iterating over the elements of the array
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                // Inner loop to compare adjacent elements and perform swapping if necessary
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Swap the elements if the current element is greater than the next element
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                        swapped = true; // Set the 'swapped' flag to indicate a swap has been made
                    }
                }

                // Check if any swaps were made in the inner loop; if not, the array is already sorted and no further iterations are needed
                if (!swapped)
                    break;
            }
        }

        // Method to display the generated numbers in the 'numbers' array
        public void Display()
        {
            foreach (int i in numbers)
            {
                // Print each number followed by a space
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        //public void Sorting()
        //{
        //    Console.WriteLine("Sorting the numbers with bubbleSort");
        //    StringBuilder animation = new StringBuilder();
        //    foreach (int num in numbers)
        //    {
        //        animation.Append("■");
        //        animation.Append(" ");
        //    }

        //    Console.WriteLine(animation.ToString());
        //}
    }
}
  //{
  //          for (var i = 0; i < numbers.Length; i++)
  //          {
  //              for (var j = 0; j < numbers.Length - 1; j++)
  //              {

  //                  if (numbers[j] > numbers[j + 1])
  //                  {
  //                      (numbers[j + 1], numbers[j]) = (numbers[j], numbers[j + 1]);
  //                  }
  //              }
  //          }
  //          Display();
  //      }