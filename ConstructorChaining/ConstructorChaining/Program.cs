using System;
using System.Collections;
using System.Collections.Generic;

namespace ConstructorChaining
{
    internal class Program
    {
        public class Person
        {
            private int _Id;
            public int Id 
            { 
                get { return _Id; }
                private set { _Id  = value; } 
            }
            public string Name { get; set; }
            public int Age { get; set; }
            public Person() : this(101) 
            {
                Console.WriteLine("Calling Person()");
            }
            public Person(int Id) : this(Id,"John")
            {
                this.Id = Id;
                Console.WriteLine("Calling Person(int Id)");
            }
            public Person(int Id,string Name) : this(Id,Name,25)
            {
                this.Id = Id;
                this.Age = Age;
                Console.WriteLine("Calling Person(int Id,string Name)");
            }
            public Person(int Id,string Name, int Age)
            {
                this.Id = Id;
                this.Name = Name;
                this.Age = Age;
                Console.WriteLine("Calling Person(int Id,string Name, int Age)");
            }
        }
        public class Student : Person
        {
            public Student() 
            {
                Console.WriteLine("Calling Student()");
            }
            public Student(int Id) : base(Id)
            {
                Console.WriteLine("Calling Student(int Id)");
            }
            public Student(int Id, string Name) : base(Id,Name)
            {
                Console.WriteLine("Calling Student(int Id, string Name)");
            }
            public Student(int Id, string Name, int Age) : base(Id, Name, Age)
            {
                Console.WriteLine("Calling Student(int Id, string Name, int Age)");
            }
        }
        static void Main(string[] args)
        {
            IList<Person> persons = new List<Person>();
            
            //persons.Add(new Person { });
            Console.WriteLine();

            //persons.Add(new Person { Age = 25 });
            Console.WriteLine();

            //persons.Add(new Person { Id = 102, Age = 29 });
            Console.WriteLine();

            //persons.Add(new Person { Id = 103, Name = "Smith", Age = 25 });
            Console.WriteLine();

            IList<Student> students = new List<Student>();

            //students.Add(new Student { });
            Console.WriteLine();

            //students.Add(new Student { Age = 37 });
            Console.WriteLine();

            students.Add(new Student { Id = 104, Age = 25 });
            Console.WriteLine(students[0].Id);

            students.Add(new Student (05,"Fahim",27 ));
            Console.WriteLine();
        }
    }
}
