using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr1 = new int[3][];

            arr1[0] = new int[3];
            arr1[1] = new int[2];
            arr1[2] = new int[4];

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    arr1[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(arr1[i][j] + " ");
                }
                Console.WriteLine();
            }

            int[][] arr = 
            {
                new int[]{ 45,12},
                new int[]{ 145,312,56 },
                new int[]{ 405,-12,45,48}
            };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
