using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class StaticClass
    {
        public static int var1;
        public int var2;
        
        public static void add(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        public void mul(int x, int y)
        {
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
