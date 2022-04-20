using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var val1 = MethodAsync();
            
            var val2 = Method();
            
            Console.WriteLine($"Output of sync method : {val2}");

            Console.WriteLine($"Output of async method : {val1.Result}");
        }

        public static int Method()
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine($"Sync method number : {i}");
                sum += i;
            }
            return sum;
        }
        public static Task<int> MethodAsync()
        {
            Task<int> task = new Task<int>(() =>
            {
                int sum = 0;
                for (int i = 11; i <= 15; i++)
                {
                    Thread.Sleep(200);
                    Console.WriteLine($"Async method number : {i}");
                    sum += i;
                }
                return sum;
            });

            task.Start();

            return task;           
        }

       
    }
}