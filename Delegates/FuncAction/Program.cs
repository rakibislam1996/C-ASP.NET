using System;

namespace FuncAction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Func can have zero or more input , and one output
            
            Func<int> func = () => 10;  // <output>
            Func<int, int> func1 = (x) => x+10; // <input,output>
            Func<int, int, int> func2 = (x, y) => x + y;  // <input,input,output>

            Func<int, int, int> func3 = Multiply;
            func3(5,9);

            Console.WriteLine(func());  // Func can be called as func.Invoke(params) or func(params)
            Console.WriteLine(func1.Invoke(10));
            Console.WriteLine(func2.Invoke(10, 20));

            // Action does not return , it has only inputs (zero or more)

            Action<int> action = Print;
            action(10);

            Action<int,int> action2 = Add;
            action2(10,20);

            Action action3 = () => Console.WriteLine("Action performed"); // Takes no input,gives no output
            action3.Invoke();

            // Predicate takes only one input and gives output as boolean

            Predicate<string> predicate = IsUpper; // <input>
            Console.WriteLine(predicate("Hello"));

        }
        public static void Print(int x)
        {
            Console.WriteLine(x);
        }
        public static void Add(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        public static int Multiply(int x, int y)
        {
            return (x*y);
        }
        private static bool IsUpper(string text)
        {
            return text.Equals(text.ToUpper());
        }
    }
}
