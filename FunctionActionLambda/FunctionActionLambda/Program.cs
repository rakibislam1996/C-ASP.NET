using System;

namespace FunctionActionLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> func = () => 10;  // <output>
            Func<int,int> func1 = (x) => x+10; // <input,output>
            Func<int, int, int> func2 = (x, y) => x + y;  // <input,input,output>

            Console.WriteLine(func.Invoke());
            Console.WriteLine(func1.Invoke(10));
            Console.WriteLine(func2.Invoke(10,20));

            Action func3 = () => Console.WriteLine("Action performed"); // Takes no input,gives no output

            func3.Invoke();

        }
    }
}
