using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class nonStaticClass
    {
        public static int staticVar;
        public int var2;
        public static void add(int x,int y)
        {
            Console.WriteLine(staticVar);
            Console.WriteLine(x+y);
        }
        public void mul(int x, int y)
        {
            Console.WriteLine(staticVar);
            Console.WriteLine(x * y);
        }
    }
    static class StaticClass2
    {
        public static int var;
        public static void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
