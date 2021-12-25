using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();

            st.Push(11);
            st.Push(15);
            st.Push(22);
            st.Push(98);

            foreach (var item in st)
                Console.Write(item+" ");

            Console.WriteLine();

            Console.WriteLine("At top : " + st.Peek()); 

            Console.WriteLine("Number of elements : " + st.Count());

            Console.WriteLine("Average: " + st.Average());

            st.Pop();

            Console.WriteLine("After pop");
            
            foreach (var item in st)
                Console.WriteLine(item);
            Console.WriteLine(st.Any());
            st.Clear();
            Console.WriteLine(st.Any());
        }
    }
}
