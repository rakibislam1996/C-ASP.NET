using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericClass
{
    class Student<T>
    {
        public T Id { get; set; }
        public T Name { get; set; }
        public T StuDentDetails() 
        {
            return Id;
        }
    }
    class Student<TId, TName>
    {
        public TId Id { get; set; }
        public TName Name { get; set; }

        public Student(TId Id, TName Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public void StudentDetails<T>(T Name)
        {
            Console.WriteLine($"{Name}");
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Student<int> studentId = new Student<int>();
            studentId.Id = 101;

            Student<string> studentName = new Student<string>();
            studentName.Name = "Sakib";

            Student<int,string> student = new Student<int,string>(102,"Tamim");
            Console.WriteLine($"{student.Id} {student.Name}");

            student.StudentDetails<string>("Arafat");

        }
    }
}
