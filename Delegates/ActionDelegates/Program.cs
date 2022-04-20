using System;

namespace ActionDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = () => Console.WriteLine("This is action with no input,no output");
            action();
            
            Action action1 = Print;
            action1();

            Action<int> action2 = Print;
            action2(101);

            Action<int,int> action3 = Add;
            action3(101,10);

            
        }
        public static void Print()
        {
            Console.WriteLine("This is action");
        }
        public static void Print(int x)
        {
            Console.WriteLine(x);
        }
        public static void Add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        
    }
}
