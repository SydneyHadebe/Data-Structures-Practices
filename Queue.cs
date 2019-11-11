using System;


namespace DataStructures
{
    public class Queue
    {
        private int maxSize;
        private long[] joinTheQueue;
        private int first;
        private int last;
        private int items;


        public Queue(int size)
        {
            maxSize = size;
            joinTheQueue = new long[size];
            first = 0;
            last = -1;
            items = 0;
        }

        public void InsertToTheQueue(long joinNow)
        {
            if (IsTheQueueFull())
            {
                Console.WriteLine($"The queue is full");
            }
            else
            {
                if (last == maxSize - 1)
                {
                    last = -1;
                }
                last++;
                joinTheQueue[last] = joinNow;
                items++;
            }
        }

        public long Remove()
        {
            long temp = joinTheQueue[first];
            first++;
            if (first == maxSize)
            {
                first = 0;
            }
            return temp;
        }

        public long peekFirst()
        {
            return joinTheQueue[first];
        }

        public bool isEmpty()
        {
            if (items == 0)
            {
                return true;
            }
            return false;
        }

        private bool IsTheQueueFull()
        {
            bool checkSpace = false;
            if (items == maxSize)
            {
                return checkSpace;
            }

            return checkSpace;
        }

        public void Display()
        {
            Console.Write("[");
            for (int i = 0; i < joinTheQueue.Length; i++)
            {
                Console.Write(joinTheQueue[i] + " ");
            }
            Console.WriteLine("]");
        }
    }

}

