namespace Queue_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This Program was crated by Andrew Logan (Student ID: 9957173)

            MyQueue queue = new MyQueue();

            queue.Enqueue("Car");
            queue.Enqueue("Plane");
            queue.Enqueue("Train");

            Console.WriteLine(queue.Dequeue()); // Output: Car
            Console.WriteLine(queue.Dequeue()); // Output: Plane

            queue.Enqueue("Bus");

            Console.WriteLine(queue.Dequeue()); // Output: Train

            Console.WriteLine(queue.Dequeue()); // Output: Bus
        }
    }
}