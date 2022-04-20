using System;

namespace MulticastDelegates
{
    public delegate void Calculate();

    public delegate int DemoDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate del,del1,del2,del3;

            del1 = new Calculate(Add);
            del2 = new Calculate(Subtract);
            del3 = new Calculate(Division);

            del = del1 + del2 + del3;
            del += del2;
            del -= del2;
            del();
            Console.WriteLine();

            del = Add;
            del += Subtract;
            del();
            Console.WriteLine();

            del-= Subtract;
            del();
            Console.WriteLine();

            DemoDelegate demo1 = new DemoDelegate(Fun1);
            demo1 += Fun2;

            Console.WriteLine(demo1());   // Returns the value of last invoked method

        }
        public static void Add()
        {
            Console.WriteLine("For addition");
        }
        public static void Subtract()
        {
            Console.WriteLine("For Subtraction");
        }
        public static void Division()
        {
            Console.WriteLine("For Division");
        }

        public static int Fun1()
        {
            return 20;
        }
        public static int Fun2()
        {
            return 50;
        }
    }
}
