namespace Acronym_builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program created by Andrew Logan (9957173)
            Console.Write("Please enter a phrase to generate an acronym: ");
            string input = Console.ReadLine();

            Acronym acronym = new Acronym(input);
            acronym.BuildAcronym();
            acronym.DisplayAcronym();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}