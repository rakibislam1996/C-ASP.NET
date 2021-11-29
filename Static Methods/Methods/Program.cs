using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            nonStaticClass sc = new nonStaticClass();  // Non Static Class
            sc.var2 = 11; // Non Static var
            sc.mul(sc.var2, 20); // Non Static method

            nonStaticClass.staticVar = 101010;  // Static variable
            nonStaticClass.add(nonStaticClass.staticVar, 25); // Static method

            StaticClass2.var = 30;  // Static variable of static class
            StaticClass2.add(StaticClass2.var, 25); // Static method  of static class
        }
    }
}
