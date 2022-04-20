using System;

namespace Delegates
{

    public delegate int Calculate(int b, int h);
    
    //public delegate int HeightDelegate(int area, int b);
    class Triangle
    {
        public int Area(int b,int h)
        {
            return (b * h)/2;
        }
        public static int Height(int area, int b)
        {
            return (2 * area) / b;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle();
            Calculate del = new Calculate(tri.Area); // If the method is not declared as static
            int area = del(10,20) ;
            Console.WriteLine($"Area of triangle : {area}");

            Calculate del1 = new Calculate(Triangle.Height); // If the method is declared as static
            int height = del1(area, 20);
            Console.WriteLine($"Height of triangle : {height}");

            Calculate del2 = new Calculate(Base);
            int _base = del2(area, height);
            Console.WriteLine($"Base of triangle : {_base}");
        }
        public static int Base(int area, int height)
        {
            return (2 * area) / height;
        }
    }
}
