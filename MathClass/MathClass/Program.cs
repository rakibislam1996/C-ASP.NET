using System;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = Math.Truncate(121.9);
            Console.WriteLine(d);

            double c = Math.Round(12.5);
            Console.WriteLine(c);

            double b = Math.Floor(3.6);
            Console.WriteLine(b);
            b = Math.Ceiling(3.6);
            Console.WriteLine(b);

            double a = Math.Pow(12, 10);
            Console.WriteLine(a);
            Console.WriteLine(double.IsInfinity(a));

           

        }
    }
}
