using System;

namespace MultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];


            int[,] arr2 = { { 5, 0 }, { 20, 31 }, { -101, -34 } };
            Console.WriteLine(arr2.Length);
            

            Console.WriteLine($"Number of dimensions : {arr2.Rank}");
            Console.WriteLine($"Number of elements : {arr2.Length}");
            
            Console.WriteLine($"Element at position (1,1) : {arr2.GetValue(1,1)}");

            Console.WriteLine($"Number of rows : {arr2.GetLength(0)}");
            Console.WriteLine($"Number of columns : {arr2.GetLength(1)}");

            Console.WriteLine($"Number of rows : {arr2.GetUpperBound(0) + 1}");
            Console.WriteLine($"Number of columns : {arr2.GetUpperBound(1) + 1}");

            //for (int i = 0; i <= arr2.GetUpperBound(0); i++)
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                //for (int j = 0; j <= arr2.GetUpperBound(1); j++)
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j]+" ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            //foreach (var i in arr2)
            //  Console.WriteLine(i);

        }
    }
}
