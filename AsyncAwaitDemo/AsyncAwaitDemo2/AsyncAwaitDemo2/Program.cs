using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate();
        }

        private static void Calculate()
        {
            Task.Run(() =>
            {
                Calculate1();
            });
            Task.Run(() =>
            {
                Calculate2();
            });
            Task.Run(() =>
            {
                Calculate3();
            });
            
        }

        private static void Calculate1()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Calculate1");
        }

        private static void Calculate2()
        {
            Thread.Sleep(600);
            Console.WriteLine("Calculate2");
        }

        private static void Calculate3()
        {
            Thread.Sleep(300);
            Console.WriteLine("Calculate3");
        }
    }
}
