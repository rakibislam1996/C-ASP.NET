using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        public static void Summation(int[] x)
        {
            int sum = 0;
            foreach (var item in x)
            {
                sum += item;
            }
            Console.WriteLine($"The sum of array is: {sum}");
            x[0] = 100;
        }
        
        static void Main(string[] args)
        {
            int[] arr2 = { 34, 56, 12, 123 };
            int[] arr1 = { 34, 56, 12, 123 };

            Console.WriteLine(Enumerable.SequenceEqual(arr1,arr2));

            Program.Summation(arr1);

            Console.WriteLine(arr1[0]); // The array passed as argument is passed as reference

            Program.Summation(arr1);

            Array.Sort(arr1);
            
            foreach (var i in arr1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            
        }
    }
}
