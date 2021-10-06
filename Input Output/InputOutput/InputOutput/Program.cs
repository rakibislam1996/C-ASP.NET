using System;
namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(long.MaxValue);

            int a = 10;
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("int a =  " + a);
            Console.WriteLine("int a = {0}", a);
            Console.WriteLine($"int a = {a}");

            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Again int a = {a}");

            long b = 101;
            b = long.Parse(Console.ReadLine());
            Console.WriteLine($"long b = {b}");

            float c = 12.32f;  // Need to use f after the value for float type
            c = float.Parse(Console.ReadLine());
            Console.WriteLine($"float c = {c}");

            double d = 123.45;
            d = double.Parse(Console.ReadLine());
            Console.WriteLine($"double d = {d}");

            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"again double d = {d}");

            decimal e = 10.3M; // Need to use M after the value for decimal type.
            e = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"decimal e = {e}");

            char f = 'F';
            f = char.Parse(Console.ReadLine());
            Console.WriteLine($"char f = {f}");

            string s = Console.ReadLine();
            Console.WriteLine($"string s = {s}");

            bool t = true;
            Console.WriteLine($"bool t = {t}");
            
        }
    }
}
