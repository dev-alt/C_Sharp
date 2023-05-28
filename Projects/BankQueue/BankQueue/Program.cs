namespace BankQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This Program was crated by Andrew Logan (Student ID: 9957173)
            MyQueue queue = new MyQueue();

            // Creates a dictionary of customers and their processing time
            Dictionary<int, (string, int)> customers = new Dictionary<int, (string, int)>
            {
                { 1, ("Tradesman Joe", 5000 )},
                { 2, ("Dr Windy Pops", 2000 )},
                { 3, ("Grandpa Bob", 8000 )},
                { 4, ("Billy the kid", 3000 )},
                { 5, ("Chris on crutches", 6000 )}
            };

            Console.Title = "KiwiBank Queue";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t***********************************");
            Console.WriteLine("\t\t***********************************");
            Console.WriteLine("\t\t\tWelcome to KiwiBank");
            Console.WriteLine("\t\t***********************************");
            Console.WriteLine("\t\t***********************************\n\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to the Bank Queue\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("     Customer      \tProcessing time");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1    Tradesman Joe\t5 seconds");
            Console.WriteLine("2.   Dr Windy Pops\t2 seconds");
            Console.WriteLine("3.   Grandpa Bob\t8 seconds");
            Console.WriteLine("4.   Billy the kid\t3 seconds");
            Console.WriteLine("5.   Chris on crutches\t6 seconds");
            Console.WriteLine("-----------------------------------------");


            // Prompts the user to select 3 customers to add to the queue
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Select 3 customers to add to the queue\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Customer 1: ");
            int customer1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nCustomer 2: ");
            int customer2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nCustomer 3: ");
            int customer3 = Convert.ToInt32(Console.ReadLine());

            // Adds the selected customers to the queue
            CustomerChoice(customer1, customers, queue);
            CustomerChoice(customer2, customers, queue);
            CustomerChoice(customer3, customers, queue);



            Console.ReadLine();

            // Handles the selection of a customer and adds them to the queue
            static void CustomerChoice(int customer, Dictionary<int, (string, int)> customers, MyQueue queue)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                queue.Enqueue(customer);
                if (customers.ContainsKey(customer))
                {
                    Console.WriteLine("You have selected {0} adding {1} to the queue at position {2}\n", customers[customer].Item1, customers[customer].Item1, "3");
                    Console.WriteLine("{0} is walking to the front of the queue", customers[customer].Item1);
                    if (customer == 4)
                    {
                        Console.WriteLine("\nBilly has arrived at the teller, he has forgotten his ID\n");
                        Thread.Sleep(1000);
                        Console.WriteLine("Billy is going to his car\n");
                        Thread.Sleep(1000);
                        Console.WriteLine("  ______\r\n /|_||_\\`.__\r\n(   _    _ _\\\r\n=`-(_)--(_)-' \n");
                        Thread.Sleep(1000);
                        Console.WriteLine("Billy has to wait in the queue again");

                    }

                    else
                    {
                        Thread.Sleep(customers[customer].Item2);
                    }

                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }



        }
    }
}