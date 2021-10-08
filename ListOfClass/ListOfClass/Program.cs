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
            public override string ToString()
            {
                return Name;
            }
            public override bool Equals(object obj)
            {
                return Id == ((Student)obj).Id;
            }
            public static void findStudent(List<Student> stu, Student newStu) // Do not returns
            {
                foreach (Student item in stu)
                    if (item.Equals(newStu)) // Equals() method is overriden & modified
                        Console.WriteLine($"Student found:- Id :{item.Id} , Name : {item.Name}");
                Console.WriteLine("Student not found");
            }
            public static int findStudent2(List<Student> stu, Student newStu) // returns index of obj
            {
                for (int i = 0; i < stu.Count; i++)
                    if (stu[i].Equals(newStu)) // Equals() method is overriden & modified
                        return i; 
                return -1; 
            }
            public static Student findStudent3(List<Student> stu, Student newStu) // returns obj
            {
                foreach (Student item in stu)
                    if (item.Equals(newStu)) // Equals() method is overriden & modified
                        return item;
                return null;
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
                Console.WriteLine($"Name: {item.Name}, Id: {item.Id}");

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
            
            var newStudent = new Student(11,"Sajid");

            Console.WriteLine(Student.findStudent3(students2, newStudent)); 
            // Calls ToString(), retturns null if not matched
            
            Student ifFound = Student.findStudent3(students2, newStudent);
            if (ifFound != null)
                Console.WriteLine($"Student found = Id :{ifFound.Id} , Name : {ifFound.Name}");
            else
                Console.WriteLine("Student not found");

            //int idx = Student.findStudent2(students2, newStudent);
            //if(idx>=0)
            //    Console.WriteLine($"Student found = Id :{students2[idx].Id} , Name : {students2[idx].Name}");
            //else
            //    Console.WriteLine("Student not found");

            foreach (var item in students2)
                Console.WriteLine($"Name: {item.Name}, Id: {item.Id}");

            var students3 = new List<Student>() { st[0],st[1] };
        }
    }
}
