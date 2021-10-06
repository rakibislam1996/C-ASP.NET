using System;
using System.Collections.Generic;
using System.Linq;

namespace ListMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst1 = new List<int>() { 3, 7, 1 };

            lst1.Reverse();
            
            foreach (var item in lst1)
                Console.Write(item+" ");
            Console.WriteLine();

            lst1.Sort();

            int[] arr = lst1.ToArray();  // list to array conversion
            lst1 = arr.ToList();   // array to list conversion

            List<List<int>> lst = new List<List<int>>()
            {
                new List<int>{ 1, 5, 6, 7, 8 },
                new List<int>{ 21, 51, 66, 78 },
                new List<int>{ -56, -90 },
                new List<int>{ -11, 85, 61 }
            };
            Console.WriteLine(lst.Count);
            Console.WriteLine(lst[0].Count);

            foreach (var i in lst) //  foreach (List<int> i in lst)
            {
                foreach (var j in i) // foreach (int j in i)
                    Console.Write(j + " ");
                Console.WriteLine();
            }

            lst.Reverse(); // It will start from the last row to 1st row with same order of elements 

            Console.WriteLine("After reversing");
            foreach (var i in lst) //  foreach (List<int> i in lst)
            {
                foreach (var j in i) // foreach (int j in i)
                    Console.Write(j+" ");
                Console.WriteLine();
            }

            //for (int i = 0; i < lst.Count; i++)
            //{
            //    for (int j = 0; j < lst[i].Count; j++)
            //        Console.Write(lst[i][j]+" ");
            //    Console.WriteLine();
            //}


        }
    }
}
