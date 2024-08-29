using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            // Define a number of threads for enqueueing and dequeueing
            int numberOfThreads = 5;
            Thread[] threads = new Thread[numberOfThreads];


            threads[0] = new Thread(() => { queue.Enqueue(1); });
            threads[1] = new Thread(() => { queue.Enqueue(2); });
            threads[2] = new Thread(() => { queue.Enqueue(3); });

            threads[3] = new Thread(() => { queue.Dequeue(); });
            threads[4] = new Thread(() => { queue.Dequeue(); });

            // Start all threads
            foreach (var thread in threads)
            {
                thread.Start();
            }


        }
    }
}
