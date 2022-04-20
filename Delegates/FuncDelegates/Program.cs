using System;

namespace FuncDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> Calculate = Add;
            Console.WriteLine(Calculate(10, 20));

            Calculate = Subtract;
            Console.WriteLine(Calculate(30, 5));

            Func<int, int, int> func4 = delegate(int x,int y) { return x+y; }; 

            Func<int> func = () => 10;  // <output>
            Func<int, int> func1 = (x) => x+10; // <input,output>
            Func<int, int, int> func2 = (x, y) => x + y;  // <input,input,output>

            Func<int, int, int> func3 = Multiply;
            func3(5, 9);

            Console.WriteLine(func());  // Func can be called as func.Invoke(params) or func(params)
            Console.WriteLine(func1.Invoke(10));
            Console.WriteLine(func2.Invoke(10, 20));
        } 
        public static int Add(int x,int y)
        {
            return x+y;
        }
        public static int Subtract(int x, int y)
        {
            return x-y;
        }
        public static int Multiply(int x, int y)
        {
            return (x*y);
        }
    }
}
