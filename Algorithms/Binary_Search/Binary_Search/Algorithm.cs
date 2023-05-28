using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Algorithm
    {

        //private instance variables
        private int[] numbers;
        private static Random generator = new Random();

        //constructor which populates the data array with size number of integers
        public Algorithm(int size)
        {
            numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = generator.Next(10, 100);
            }
        }

        public int BinarySearch(int skey)
        {
            int low = 0;
            int high = numbers.Length - 1;
            int middle = (high + low) / 2;
            int index = -1;
            int counter = 0;


            do
            {
                counter++;


                if (skey == numbers[middle])
                {
                    index = middle;
                    break;
                }
                else if (skey < numbers[middle])
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
                middle = (high + low) / 2;

                RemainingElements(low, high);

            } while (low <= high);

            Console.WriteLine("Number of iterations: {0}",counter);

            return index;
        }

        internal void DisplayArray()
        {
            Console.WriteLine("\nThe array has been populated with the following integers:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        internal void RemainingElements(int low, int high)
        {

            Console.WriteLine("\nRemaning elements: ");

            for (int i = 0; i < high; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
