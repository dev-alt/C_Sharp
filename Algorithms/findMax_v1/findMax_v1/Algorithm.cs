using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findMax_v1
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

        public void FindNumMax(int n)
        {
            if (n <= 0 || n > numbers.Length)
            {
                Console.WriteLine("Invalid value of n.");
                return;
            }

            int[] maxElements = new int[n];
            for (int i = 0; i < n; i++)
            {
                maxElements[i] = int.MinValue;
            }

            foreach (int num in numbers)
            {
                for (int i = 0; i < n; i++)
                {
                    if (num > maxElements[i])
                    {
                        for (int j = n - 1; j > i; j--)
                        {
                            maxElements[j] = maxElements[j - 1];
                        }
                        maxElements[i] = num;
                        break;
                    }
                }
            }

            Console.WriteLine($"The {n} largest elements in the array are:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(maxElements[i]);
            }
        }
    }

}

