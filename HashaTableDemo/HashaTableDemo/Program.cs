using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HashaTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable student = new Hashtable() { 
                { '1', "Rakib" }, 
                { "Sakib", 13 },
                { 14.5, "Faruk" },
                { "Jinia", 'C' }
            };
            Console.WriteLine("Showing keys: ");
            foreach (var item in student.Keys)
                Console.WriteLine(item);

            Console.WriteLine("\nShowing values: ");
            foreach (var item in student.Values)
                Console.WriteLine(item);

            Console.WriteLine("\nShowing Hash table");
            foreach (DictionaryEntry item in student)
                Console.WriteLine(item.Key + " " + item.Value);

            Console.WriteLine("\nNumber of keys: " + student.Keys.Count);
            Console.WriteLine("Number of values: " + student.Values.Count);

            Console.WriteLine("\nValue of an key: " + student["Jinia"]);  // [key]

            student.Add(15, "Sajid");
            student.Remove(13);
            Console.WriteLine("\nNumber of entries: " + student.Count);


        }
    }
}
