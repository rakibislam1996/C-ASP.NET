using System;
using System.Collections.Generic;

namespace ListOfClass
{
    class Program
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Student() { }
            public Student(int Id,string Name)
            {
                this.Id = Id;
                this.Name = Name;
            }
            public static void findStudent(List<Student> stu,int id)
            {
                foreach (Student item in stu)
                {
                    if (item.Id == id)
                        Console.WriteLine($"Student found:- Id :{item.Id} , Name : {item.Name}");
                }
                Console.WriteLine("Student not found");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Info of students2");
            List<Student> students = new List<Student>()
            {
                new Student(1,"Rakib"),
                new Student(2,"Sakib"),
                new Student(3,"Karib"),
                new Student(4,"Samin")
            };
            Student[] st = new Student[]{
                new Student(5,"Rafi"),
                new Student(6,"Sifat"),
            };
            students.Add(st[0]);
            students.Add(st[1]);
            
            foreach (var item in students)
            {
                Console.WriteLine($"Name: {item.Name}, Id: {item.Id}");
            }

            Console.WriteLine("Info of students2");
            
            var students2 = new List<Student>();
            
            var names = new List<string>() { "Arafat", "Sajid", "Shojib"};
            var ids = new List<int>() { 10, 11, 12 };
            
            for (int i = 0; i < names.Count; i++)
            {
                Student x = new Student();
                x.Id = ids[i]; x.Name = names[i];
                students2.Add(x);
            }
            Student.findStudent(students2,11);
            foreach (var item in students2)
            {
                Console.WriteLine($"Name: {item.Name}, Id: {item.Id}");
            }
            var students3 = new List<Student>() { st[0],st[1] };
        }
    }
}
