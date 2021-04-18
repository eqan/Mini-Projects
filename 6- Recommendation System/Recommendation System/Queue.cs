using System;

namespace Recommendation_System
{
    class Queue
    {
        public struct Edge
        {
            public int src, dest, weight;
        }
        public Edge[] ele;
        public int front;
        public int rear;
        private int max = 100;

        public Queue()
        {
            ele = new Edge[max];
            front = 0;
            rear = -1;
        }
        public void enqueue(int src, int dest, int weight)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                rear++;
                ele[rear].src = src;
                ele[rear].dest = dest;
                ele[rear].weight = weight;
                Console.WriteLine("Edge {0} Enqueud!", rear);
            }
        }

        public void dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                Console.WriteLine("Edge {0} Dequed!", front);
                front++;
            }
        }

        // Function to print queue. 
        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine("Edge {0} Enqueud!", i);
                }
            }
        }
    }
}
