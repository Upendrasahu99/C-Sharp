using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    internal class MyQueuecs
    {
        public void QueuePractice()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue('t');
            queue.Enqueue("tata");
            queue.Dequeue();
            foreach (object i in queue)
            {
                Console.WriteLine(i);
            }
        }
    }
}
