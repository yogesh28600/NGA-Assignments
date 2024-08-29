using System;

namespace Multithreading
{
    public class Queue
    {
        private static int[] items = new int[20];
        private static int head = 0;
        private static int tail = 0;
        private static int length = 0;
        private static object lockObject = new object();

        public void Enqueue(int item)
        {
            lock (lockObject)
            {
                if (length >= items.Length)
                {
                    Console.WriteLine("Queue is full");
                    return;
                }
                items[tail] = item;
                tail = (tail + 1) % items.Length;
                length++;
                Console.WriteLine("Enqueue: " + item);
            }
        }

        public void Dequeue()
        {
            lock (lockObject)
            {
                if (length <= 0)
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }
                int dequeuedItem = items[head];
                head = (head + 1) % items.Length;
                length--;
                Console.WriteLine("Dequeue: " + dequeuedItem);
            }
        }

        public int Peek()
        {
            lock (lockObject)
            {
                if (length <= 0)
                {
                    Console.WriteLine("Queue is empty");
                    return -1; // Assuming -1 is not a valid item
                }
                return items[head];
            }
        }

        public bool IsEmpty()
        {
            lock (lockObject)
            {
                return length == 0;
            }
        }
    }
}
