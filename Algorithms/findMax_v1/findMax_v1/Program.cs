namespace findMax_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of maximum elements to find: ");
            int n = int.Parse(Console.ReadLine());

          
            Algorithm algo = new Algorithm(100);
            algo.FindNumMax(n);
        }
    }
}