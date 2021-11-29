using System;
using System.Collections.Generic;

namespace Constructor
{
    class Person
    {
        public int id { get; set; }
        public int age { get; set; }
        public Person() { }
        public Person(int id, int age)
        {
            this.id = id;
            this.age = age;
        }
    }
    class Student : Person
    {
        public Student() { }
        public Student(int id, int age) : base(id, age) { }  // Calling Base Class Constructor
        public Student(Student obj)
        {
            this.id = obj.id;
            this.age = obj.age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(11608009,25);
            Console.WriteLine(person.id);
            Console.WriteLine(person.age);

            Person person1 = new Person
            {
                age = 25,
                id = 101
            };
            Console.WriteLine(person1.age+" "+person1.id);

            Student student = new Student(11608010, 30);
            Console.WriteLine(student.id);
            Console.WriteLine(student.age);

            List<Student> stuList = new List<Student>()
            {
                new Student(1,25),
                new Student(2,26),
                new Student{id = 3, age = 22 }
            };
            Console.WriteLine(stuList[0].id+" "+stuList[2].age);

            Student student1 = new Student(student);
            Console.WriteLine(student1.id);
            Console.WriteLine(student1.age);
        }
    }
}
