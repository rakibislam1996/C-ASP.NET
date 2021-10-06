using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst1 = new List<int>();

            List<int> lst3 = new List<int>() { 67, 89, 34 };
            for (int i = 0; i < lst3.Count; i++)
            {
                Console.Write(lst3[i]+" ");
            }
            Console.WriteLine();
            List<int> lst2 = new List<int>() { 67, 89, 34 };
            Console.WriteLine($"Are the lists same: {lst2.SequenceEqual(lst3)}"); // System.Linq

            List<int> lst = lst2;

            Console.WriteLine($"Are the lists same: {lst.Equals(lst2)}");

            lst.Add(12);
            lst.Add(23);
            lst.Add(90);
            
            Console.WriteLine($"Number of elements: {lst.Count}");
            
            foreach (var item in lst)
                Console.Write(item+" ");
            Console.WriteLine();
            
            lst.Insert(1,-101);
            Console.WriteLine($"Number of elements after inserting: {lst.Count}");
            foreach (var item in lst)
                Console.Write(item + " ");
            Console.WriteLine();

            lst.Remove(-101); // Return true if the item is found,otherwise returns false
            Console.WriteLine($"Number of elements after removing: {lst.Count}");
            foreach (var item in lst)
                Console.Write(item + " ");
            Console.WriteLine();
            Console.WriteLine($"This element is in list: {lst.Contains(12)}");

            lst.Clear();
            Console.WriteLine($"Number of elements after clearing: {lst.Count}");
        }
    }
}
