using System;

namespace Delegates
{

    public delegate int AreaDelegate(int b, int h);
    public delegate int HeightDelegate(int area, int b);
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
            AreaDelegate del = new AreaDelegate(tri.Area); // If the method is not declared as static
            int area = del(10,20) ;
            Console.WriteLine($"Area of triangle : {area}");

            AreaDelegate del1 = new AreaDelegate(Triangle.Height); // If the method is declared as static
            int height = del1(area, 20);
            Console.WriteLine($"Height of triangle : {height}");
        }
    }
}
