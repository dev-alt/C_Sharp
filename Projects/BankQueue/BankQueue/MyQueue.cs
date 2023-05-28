using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankQueue
{
    internal class MyQueue
    {
        private ArrayList ALQueue;
        // Constructor for MyQueue class
        public MyQueue()
        {
            ALQueue = new ArrayList();
        }

        // Adds an item to the queue
        public void Enqueue(object item)
        {
            ALQueue.Add(item);
        }

        // Removes an item from the queue
        public object Dequeue()
        {
            if (ALQueue.Count > 0)
            {
                object item = ALQueue[0];
                ALQueue.RemoveAt(0);
                return item;
            }
            return null; // Return null when the queue is empty
        }
    }
}
