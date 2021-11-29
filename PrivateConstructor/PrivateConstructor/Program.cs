using System;

namespace PrivateConstructor
{
    internal class Program
    {
        class Teacher
        {
            public string Dept { get; set; }
            private Teacher() { Console.WriteLine("Teacher Constructor"); }
            public Teacher(string Dept) { this.Dept=Dept; }
        }
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("CSE");
            Console.WriteLine(teacher.Dept);
        }
    }
}
