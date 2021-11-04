using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(10);
            qu.Enqueue(101);
            qu.Enqueue(21);
            qu.Enqueue(22);
            qu.Enqueue(45);

            foreach (var item in qu)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            qu.Dequeue();
            Console.WriteLine("After dequeue");
            foreach (var item in qu)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("Number of elements: " + qu.Count);

            Console.WriteLine("Top element: " + qu.Peek()); 


        }
    }
}
