using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> stu = new Dictionary<string, int>() {
                {"Rakib" , 10},
                {"Sakib" , 11},
                {"Fahim" , 12},
                {"Fimu" , 13},
            };

            stu.Add("Hamid", 14);

            Console.WriteLine("Keys: ");
            foreach (var item in stu.Keys)
                Console.Write(item + " ");

            Console.WriteLine("\nValues: ");
            foreach (var item in stu.Values)
                Console.Write(item + " ");

            Console.WriteLine("\nEntries: ");
            foreach (var item in stu)
                Console.WriteLine(item.Key + " " + item.Value);

            Console.WriteLine("\nNumber of entries: " + stu.Count);

            Console.WriteLine( stu["Rakib"] );
        }
    }
}
