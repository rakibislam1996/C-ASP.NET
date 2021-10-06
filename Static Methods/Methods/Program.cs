using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass sc = new StaticClass();  // Non Static Class
            sc.var2 = 10; // Non Static var
            sc.mul(sc.var2, 20); // Non Static method

            StaticClass.var1 = 25;  // Static variable
            StaticClass.add(StaticClass.var1,25); // Static method

            StaticClass2.var = 30;  // Static variable of static class
            StaticClass2.add(StaticClass2.var, 25); // Static method  of static class



        }
    }
}
