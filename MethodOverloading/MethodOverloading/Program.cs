using System;

namespace MethodOverloading
{
    class Calculator
    {
        public static void Add()
        {
            Console.WriteLine("Add");
        }
        public static void Add(int a,int b)
        {
            Console.WriteLine($"Add int a,int b: {a+b}");
        }
        public static void Add(double a, double b)
        {
            Console.WriteLine($"Add double a, double b: {a+b}");
        }
        public static void Add(char a, char b)
        {
            Console.WriteLine($"Add char a, char b: {a+b}");
        }
        public static void Add(string a, string b)
        {
            Console.WriteLine($"Add string a, string b: {a+b}");
        }
        public static void Add(char a, string b)
        {
            Console.WriteLine($"Add char a, string b: {a+b}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add();
            Calculator.Add(12,20);
            Calculator.Add(123,56.8);
            Calculator.Add('c', 'd');
            Calculator.Add('m', "Bappe");
            Calculator.Add("Rakib", " Islam");
        }
    }
}
