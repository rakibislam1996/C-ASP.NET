using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.add(23, 45); // pass by value

            int a = 15, b = 2;
            obj.mul(ref a, ref b); // pass by reference
            Console.WriteLine(a * b);

            int summation, product;
            obj.fun(10, 5, out summation, out product); // returning by paramters
            Console.WriteLine(summation + " " + product);
            string[] s = { "aa", "bb", "cc", "dd" };
            string[] s2 = { "aa", "bb", "cc", "dd" };
            Program.array(s,s2,23);

        }
        public static void array(string[] str, string[] str2,int x)
        {
            foreach (var item in str)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
        public void fun(int x,int y,out int sum,out int prod) // returning by paramters
        {
            sum = x + y;
            prod = x * y;
        }
        public void add(int x, int y) // pass by value
        {
            Console.WriteLine(x+y);
        }
        public void mul(ref int x,ref int y)  // pass by reference
        {
            x = 3;
            y = 6;
            //Console.WriteLine(x * y);
        }
    }

}
