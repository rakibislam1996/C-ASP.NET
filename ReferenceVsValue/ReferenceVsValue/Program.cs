using Baseline.ImTools;
using System;
using System.Collections.Generic;

namespace ReferenceVsValue
{
    class Student
    {
        public string Name { get; set; }
    }
    class Program
    {
        public static void Fun(int y) => y = -10;// int/float... are passed as value
        public static void Fun2(ref int y) => y = -10; // passed as reference using 'ref'
        public static void Fun3(int[] a) => a[1] = -101;// Array is passed as reference
        public static void Fun4(List<int> a) => a[1] = -57; // List is passed as reference
        public static void Fun5(Student st) => st.Name = "Sakib"; // Object is passed as reference
        public static void Fun6(int x,int y,out int sum,out int sub) // returning as argument
        {
            sum = x + y;
            sub = x - y;
        }
        static void Main(string[] args)
        {
            int x = 10;
            Program.Fun(x);
            Console.WriteLine(x);

            Program.Fun2(ref x);
            Console.WriteLine(x);

            int[] arr = { 5, 7, 8 };
            Fun3(arr);
            Console.WriteLine(arr[1]);

            List<int> lst = new List<int>() { 5, 7, 8 };
            Fun4(lst);
            Console.WriteLine(lst[1]);

            Student stu = new Student();
            stu.Name = "Rakib";
            Fun5(stu);
            Console.WriteLine(stu.Name);

            int sum, sub, a = 30, b = 10;
            Fun6(a, b, out sum, out sub);
            Console.WriteLine(sum + " " + sub);
        }
    }
}
