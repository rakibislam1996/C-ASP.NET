using System;
using System.Collections.Generic;

namespace Constructor
{
    class Person
    {
        public int id, age;

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
        public Student(int id, int age) : base(id,age){}  // Calling Base Class Constructor
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(11608009,25);
            Console.WriteLine(person.id);
            Console.WriteLine(person.age);

            Student student = new Student(11608010, 30);
            Console.WriteLine(student.id);
            Console.WriteLine(student.age);

            Person person1 = new Person
            {
                age = 25,
                id = 101
            };
            Console.WriteLine(person1.age+" "+person1.id);

            List<Student> stuList = new List<Student>()
            {
                new Student(1,25),
                new Student(2,26),
                new Student{id = 3, age = 22 }
            };
            Console.WriteLine(stuList[0].id+" "+stuList[1].age);
        }
    }
}
