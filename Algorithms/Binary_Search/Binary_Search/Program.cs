using System.Diagnostics;

namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();

            Algorithm myAl = new Algorithm(100);

               
            myAl.DisplayArray();
            int searchKey = 76;
            int index;

            //Console.Write("what number do you want me to search for?");
            //searchKey = Convert.ToInt32(Console.ReadLine());

            sw.Start();
            index = myAl.BinarySearch(searchKey);
            sw.Stop();

            if (index == -1)
            {
                Console.WriteLine("that number was not found");
            }
            else
            {
                Console.WriteLine("that number was found at postion {0}", index + 1);
            }

           
            
            Console.WriteLine("Binary search finished in {0} miliseconds", sw.ElapsedMilliseconds);

      




            Console.ReadKey();


        }
    }
}