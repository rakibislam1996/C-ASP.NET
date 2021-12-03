using System;

namespace DestructorDemo
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person() { Console.WriteLine("Person Constructor"); }
        ~Person() { Console.WriteLine("Person Destructor"); }
    }
    class Student : Person
    {
        public Student(){ Console.WriteLine("Student Constructor"); }
        ~Student() { Console.WriteLine("Student Destructor"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine();
            Student student = new Student();
            Console.WriteLine();
            Person person2 = new Student();
        }
    }
}
